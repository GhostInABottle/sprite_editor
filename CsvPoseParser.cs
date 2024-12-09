using SpriteEditor.Models;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SpriteEditor
{
    public static class CsvPoseParser
    {
        private static readonly StringSplitOptions SplitOptions =
            StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries;
        private class LineFormat(int nameIndex, int sizeIndex, int coordsIndex, int? frameCountIndex = null)
        {
            public int NameIndex { get; set; } = nameIndex;
            public int SizeIndex { get; set; } = sizeIndex;
            public int CoordsIndex { get; set; } = coordsIndex;
            public int? FrameCountIndex { get; set; } = frameCountIndex;
        }
        // Specifies how the CSV can look like. Destination coordinates are
        // irrelevant for the sprite editor but are useful when setting up the CSVs
        private static readonly Dictionary<int, LineFormat> FormatByPartCount = new()
        {
            // Name, Width, Height, Source X, Source Y
            { 5, new LineFormat(0, 1, 3) },
            // Name, Width, Height, Source X, Source Y, Frame Count
            { 6, new LineFormat(0, 1, 3, 5) },
            // Name, Destination X, Destination Y, Width, Height, Source X, Source Y
            { 7, new LineFormat(0, 3, 5) },
            // Name, Destination X, Destination Y, Width, Height, Source X, Source Y, Frame Count
            { 8, new LineFormat(0, 3, 5, 7) },
        };

        private static void AddFrames(int x, int y, int width, int height,
                int count, bool isVertical, bool isRectangular, int perRow,
                List<Frame> frames)
        {
            var originalX = x;
            var originalY = y;

            for (var i = 0; i < count - 1; i++)
            {
                var nextRowOrColumn = isRectangular && (i + 1) % perRow == 0;
                if (isVertical)
                {
                    y += height;
                    if (nextRowOrColumn)
                    {
                        x += width;
                        y = originalY;
                    }
                }
                else
                {
                    x += width;
                    if (nextRowOrColumn)
                    {
                        y += height;
                        x = originalX;
                    }
                }

                frames.Add(
                    new Frame
                    {
                        Rectangle = new Rect(x, y, width, height)
                    }
                );
            }
        }

        private const string framePattern = @"(?<frameCount>\d+)(?<direction>V|H)?(?<perRow>\d+)?";
        private static readonly Regex frameRegex = new(framePattern,
            RegexOptions.Compiled | RegexOptions.IgnoreCase);

        private static bool CheckFramePatternMatch(Group frameCount, Group direction, Group perRow)
        {
            return frameCount.Success
                && (!perRow.Success || direction.Success);
        }

        private static (Pose pose, string error) ParseLine(string line)
        {
            var parts = line.Split(',', SplitOptions);
            if (!FormatByPartCount.TryGetValue(parts.Length, out LineFormat format))
            {
                return (null, $"Error: Could not parse pose CSV in line: {line}");
            }

            var poseName = parts[format.NameIndex];

            if (!int.TryParse(parts[format.SizeIndex], out int width) || width < 1)
            {
                return (null, $"Error: Invalid source width in line: {line}");
            }

            if (!int.TryParse(parts[format.SizeIndex + 1], out int height) || height < 1)
            {
                return (null, $"Error: Invalid source height in line: {line}");
            }

            if (!int.TryParse(parts[format.CoordsIndex], out int x) || x < 0)
            {
                return (null, $"Error: Invalid source X in line: {line}");
            }

            if (!int.TryParse(parts[format.CoordsIndex + 1], out int y) || y < 0)
            {
                return (null, $"Error: Invalid source Y in line: {line}");
            }

            var frames = new List<Frame>
            {
                new() { Rectangle = new Rect(x, y, width, height) }
            };

            if (format.FrameCountIndex.HasValue)
            {
                // 3V means 3 vertical frames, 3H or 3 means horizontal frames
                // 4V2 means 4 vertical frames with 2 frames per row
                // 4H2 means 4 horizontal frames with 2 frames per column
                var countString = parts[format.FrameCountIndex.Value].ToUpper();
                var match = frameRegex.Match(countString);
                if (!match.Success)
                {
                    return (null, $"Error: Invalid frame count format in line: {line}");
                }

                var frameCountGroup = match.Groups["frameCount"];
                var directionGroup = match.Groups["direction"];
                var perRowGroup = match.Groups["perRow"];

                if (!CheckFramePatternMatch(frameCountGroup, directionGroup, perRowGroup))
                {
                    return (null, $"Error: Invalid frame count in line: {line}");
                }

                var isVertical = directionGroup.Success
                    && directionGroup.Value.Equals("V", StringComparison.CurrentCultureIgnoreCase);


                if (!int.TryParse(frameCountGroup.Value, out int count) || count < 2)
                {
                    return (null, $"Error: Invalid frame count in line: {line}");
                }

                var perRow = count;
                var isRectangular = false;
                if (perRowGroup.Success)
                {
                    if (!int.TryParse(perRowGroup.Value, out perRow) || perRow < 2)
                    {
                        return (null, $"Error: Invalid per row/column in line: {line}");
                    }
                    isRectangular = true;
                }

                AddFrames(x, y, width, height, count, isVertical, isRectangular, perRow, frames);
            }

            var pose = new Pose
            {
                Tags =
                    {
                        ["Name"] = poseName
                    },
                BoundingBox = new Rect(0, 0, width, height),
                Frames = frames,
            };

            return (pose, null);
        }
        public static (IEnumerable<Pose> poses, string error) ParseCsv(string text)
        {
            var lines = text.Split('\n', SplitOptions);
            var poses = new List<Pose>();

            foreach (var line in lines)
            {
                var (pose, error) = ParseLine(line);
                if (error != null)
                {
                    return (poses, error);
                }

                poses.Add(pose);
            }

            return (poses, null);
        }
    }
}

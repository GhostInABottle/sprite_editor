using SpriteEditor.Models;
using System.Collections.Generic;
using System;

namespace SpriteEditor
{
    public static class CsvPoseParser
    {
        private static readonly StringSplitOptions SplitOptions =
            StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries;
        private class LineFormat
        {
            public LineFormat(int nameIndex, int sizeIndex, int coordsIndex, int? frameCountIndex = null)
            {
                NameIndex = nameIndex;
                SizeIndex = sizeIndex;
                CoordsIndex = coordsIndex;
                FrameCountIndex = frameCountIndex;
            }

            public int NameIndex { get; set; }
            public int SizeIndex { get; set; }
            public int CoordsIndex { get; set; }
            public int? FrameCountIndex { get; set; }
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
        private static (Pose pose, string error) ParseLine(string line)
        {
            var parts = line.Split(',', SplitOptions);
            if (!FormatByPartCount.ContainsKey(parts.Length))
            {
                return (null, $"Error: Could not parse pose CSV in line: {line}");
            }

            var format = FormatByPartCount[parts.Length];
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
                var countString = parts[format.FrameCountIndex.Value].ToUpper();
                var isVertical = countString.EndsWith("V");
                if (isVertical || countString.EndsWith("H")) {
                    countString = countString.Substring(0, countString.Length - 1);
                }

                if (!int.TryParse(countString, out int count) || count < 2)
                {
                    return (null, $"Error: Invalid frame count in line: {line}");
                }

                for (var i = 0; i < count - 1; i++)
                {
                    if (isVertical)
                    {
                        y += height;
                    }
                    else
                    {
                        x += width;
                    }

                    frames.Add(
                        new Frame {
                            Rectangle = new Rect(x, y, width, height)
                        }
                    );
                }
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

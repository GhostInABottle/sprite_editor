using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;

namespace SpriteEditor
{
    public static class Utilities
    {
        private static readonly Regex hexRegex = new Regex(
                @"^#((?'R'[0-9a-f]{2})(?'G'[0-9a-f]{2})(?'B'[0-9a-f]{2}))"
                + @"|((?'R'[0-9a-f])(?'G'[0-9a-f])(?'B'[0-9a-f]))$",
                RegexOptions.Compiled | RegexOptions.IgnoreCase);

        // http://stackoverflow.com/questions/982028/convert-net-color-objects-to-hex-codes-and-back
        public static string ToHex(this Color color)
        {
            return $"#{color.R:X2}{color.G:X2}{color.B:X2}";
        }

        public static Color FromHex(string colorString)
        {
            if (colorString == null)
            {
                throw new ArgumentNullException(nameof(colorString));
            }

            var match = hexRegex.Match(colorString);
            if (!match.Success)
            {

                throw new ArgumentException(
                    $"\"{colorString}\" doesn't represent a valid hex color", nameof(colorString));
            }

            return Color.FromArgb(
                ColorComponentToValue(match.Groups["R"].Value),
                ColorComponentToValue(match.Groups["G"].Value),
                ColorComponentToValue(match.Groups["B"].Value));
        }

        public static int ColorComponentToValue(string component)
        {
            Debug.Assert(component != null, "Color component is not null");
            Debug.Assert(component.Length > 0, "Color component length greater than 0");
            Debug.Assert(component.Length <= 2, "Color component length less than 0");

            if (component.Length == 1)
            {
                component += component;
            }

            return int.Parse(
                component,
                System.Globalization.NumberStyles.HexNumber);
        }

        public static bool CheckClose(float a, float b)
        {
            return CheckClose(a, b, 0.01f);
        }

        public static bool CheckClose(float a, float b, float epsilon)
        {
            float absA = Math.Abs(a);
            float absB = Math.Abs(b);
            float diff = Math.Abs(a - b);

            if (a * b == 0)
            {
                // a or b or both are zero
                // relative error is not meaningful here
                return diff < (epsilon * epsilon);
            }

            // use relative error
            return diff / (absA + absB) < epsilon;
        }

        public static string ResolveRelativePath(string referencePath, string relativePath)
        {
            var uri = new Uri(Path.Combine(referencePath, relativePath));
            return Uri.UnescapeDataString(Path.GetFullPath(uri.AbsolutePath));
        }

        public static string MakeRelativePath(string fromPath, string toPath)
        {
            if (string.IsNullOrEmpty(fromPath))
            {
                throw new ArgumentNullException(nameof(fromPath));
            }

            if (string.IsNullOrEmpty(toPath))
            {
                throw new ArgumentNullException(nameof(toPath));
            }

            if (Directory.Exists(fromPath) && !fromPath.EndsWith("\\"))
            {
                fromPath += "\\";
            }

            if (Directory.Exists(toPath) && !toPath.EndsWith("\\"))
            {
                toPath += "\\";
            }

            var fromUri = new Uri(fromPath);
            var toUri = new Uri(toPath);

            var relativeUri = fromUri.MakeRelativeUri(toUri);
            var relativePath = Uri.UnescapeDataString(relativeUri.ToString());

            return relativePath;
        }
    }
}

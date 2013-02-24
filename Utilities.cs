using System;
using System.Diagnostics;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Collections.Generic;


namespace SpriteEditor
{
    public static class Utilities
    {
        // http://stackoverflow.com/questions/982028/convert-net-color-objects-to-hex-codes-and-back
        public static string ToHex(this Color color)
        {
            return string.Format("#{0:X2}{1:X2}{2:X2}", color.R, color.G, color.B);
        }

        static Regex hexRegex = new Regex(
            @"^#((?'R'[0-9a-f]{2})(?'G'[0-9a-f]{2})(?'B'[0-9a-f]{2}))"
            + @"|((?'R'[0-9a-f])(?'G'[0-9a-f])(?'B'[0-9a-f]))$",
            RegexOptions.Compiled | RegexOptions.IgnoreCase);

        public static Color FromHex(string colorString)
        {
            if (colorString == null)
            {
                throw new ArgumentNullException("colorString");
            }

            var match = hexRegex.Match(colorString);
            if (!match.Success)
            {
                var msg = "The string \"{0}\" doesn't represent a valid hexadecimal color";
                msg = string.Format(msg, colorString);

                throw new ArgumentException(msg,
                    "colorString");
            }

            return Color.FromArgb(
                ColorComponentToValue(match.Groups["R"].Value),
                ColorComponentToValue(match.Groups["G"].Value),
                ColorComponentToValue(match.Groups["B"].Value)
            );
        }

        static int ColorComponentToValue(string component)
        {
            Debug.Assert(component != null);
            Debug.Assert(component.Length > 0);
            Debug.Assert(component.Length <= 2);

            if (component.Length == 1)
            {
                component += component;
            }

            return int.Parse(component,
                System.Globalization.NumberStyles.HexNumber);
        }
    }
}

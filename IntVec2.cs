using System;
using System.Drawing;
using System.Text.RegularExpressions;

namespace SpriteEditor
{
    [Serializable]
    public class IntVec2
    {
        public IntVec2()
        {
            X = Y = 1;
        }

        public IntVec2(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public static explicit operator Point(IntVec2 r)
        {
            return new Point(r.X, r.Y);
        }

        public static IntVec2 FromString(string input)
        {
            IntVec2 result = null;
            // Matches strings like (30, -6)
            const string pattern = @"^\(\s*(-?\d+)\s*,\s*(-?\d+)\s*\)$";
            var match = Regex.Match(input, pattern);
            if (match.Success)
            {
                result = new IntVec2
                {
                    X = int.Parse(match.Groups[1].Value),
                    Y = int.Parse(match.Groups[2].Value)
                };
            }

            return result;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}

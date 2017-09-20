using System;
using System.Drawing;
using System.Text.RegularExpressions;

namespace SpriteEditor
{
    [Serializable]
    public class Vec2
    {
        public Vec2()
        {
            X = Y = 1.0f;
        }

        public Vec2(float x, float y)
        {
            X = x;
            Y = y;
        }

        public float X { get; set; }

        public float Y { get; set; }

        public static explicit operator Point(Vec2 r)
        {
            return new Point((int)r.X, (int)r.Y);
        }

        public static Vec2 FromString(string input)
        {
            Vec2 result = null;
            string pattern = @"^\(\s*(-?(\d+.)?\d+)\s*,\s*(-?(\d+.)?\d+)\s*\)$";
            var match = Regex.Match(input, pattern);
            if (match.Success)
            {
                result = new Vec2
                {
                    X = float.Parse(match.Groups[1].Value),
                    Y = float.Parse(match.Groups[3].Value)
                };
            }

            return result;
        }

        public bool Equals(int x, int y)
        {
            return Utilities.CheckClose(X, x) && Utilities.CheckClose(Y, y);
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}

using System;
using System.Drawing;
using System.Text.RegularExpressions;

namespace SpriteEditor.Models
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

        public Vec2(Vec2 other)
        {
            X = other.X;
            Y = other.Y;
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
            // Matches strings like (12.5, -3.6) or (3, 5)
            const string pattern = @"^\(\s*(-?(\d+\.)?\d+)\s*,\s*(-?(\d+\.)?\d+)\s*\)$";
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

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using System.Drawing;

namespace SpriteEditor
{
    [Serializable()]
    public class Vec2
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Vec2()
        {
            X = Y = 1.0f;
        }

        public Vec2(float x, float y)
        {
            X = x;
            Y = y;
        }

        public bool equals(int x, int y)
        {
            return Utilities.CheckClose(X, x) && Utilities.CheckClose(Y, y);
        }

        public static explicit operator Point(Vec2 r)
        {
            return new Point((int)r.X, (int)r.Y);
        }

        public override string ToString()
        {
            return String.Format("({0}, {1})", X, Y);
        }

        public static Vec2 FromString(string input)
        {
            Vec2 result = null;
            string pattern = @"^\(\s*(-?(\d+.)?\d+)\s*,\s*(-?(\d+.)?\d+)\s*\)$";
            var match = Regex.Match(input, pattern);
            if (match.Success)
            {
                result = new Vec2();
                result.X = Single.Parse(match.Groups[1].Value);
                result.Y = Single.Parse(match.Groups[3].Value);
            }
            return result;
        }
    }
}

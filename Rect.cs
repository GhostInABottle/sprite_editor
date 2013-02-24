using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace SpriteEditor
{
    [Serializable()]
    public class Rect
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Rect()
        {
            X = Y = Width = Height = -1;
        }

        public Rect(int x, int y, int w, int h)
        {
            X = x;
            Y = y;
            Width = w;
            Height = h;
        }

        public XElement ToXml(string name) {
            return new XElement(name,
                new XAttribute("X", X),
                new XAttribute("Y", Y),
                new XAttribute("Width", Width),
                new XAttribute("Height", Height));
        }

        public bool equals(int x, int y, int w, int h)
        {
            return X == x && Y == y && Width == w && Height == h;
        }

        public static explicit operator Rectangle(Rect r)
        {
            return new Rectangle(r.X, r.Y, r.Width, r.Height);
        }

        public override string ToString()
        {
            return String.Format("({0}, {1}, {2}, {3})", X, Y, Width, Height);
        }

        public static Rect FromString(string input)
        {
            Rect result = null;
            string pattern = @"^\(\s*(-?\d+)\s*,\s*(-?\d+)\s*,\s*(-?\d+)\s*,\s*(-?\d+)\s*\)$";
            var match = Regex.Match(input, pattern);
            if (match.Success)
            {
                result = new Rect();
                result.X = Int32.Parse(match.Groups[1].Value);
                result.Y = Int32.Parse(match.Groups[2].Value);
                result.Width = Int32.Parse(match.Groups[3].Value);
                result.Height = Int32.Parse(match.Groups[4].Value);
            }
            return result;
        }
    }
}

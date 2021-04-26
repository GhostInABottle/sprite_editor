using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace SpriteEditor
{
    [Serializable]
    public class Rect
    {
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

        public Rect(Rect other)
        {
            X = other.X;
            Y = other.Y;
            Width = other.Width;
            Height = other.Height;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public static explicit operator Rectangle(Rect r)
        {
            return new Rectangle(r.X, r.Y, r.Width, r.Height);
        }

        public static Rect FromString(string input)
        {
            Rect result = null;
            // Matches patterns like (-33, 2, 4, 12)
            const string pattern = @"^\(\s*(-?\d+)\s*,\s*(-?\d+)\s*,\s*(-?\d+)\s*,\s*(-?\d+)\s*\)$";
            var match = Regex.Match(input, pattern);
            if (match.Success)
            {
                result = new Rect
                {
                    X = int.Parse(match.Groups[1].Value),
                    Y = int.Parse(match.Groups[2].Value),
                    Width = int.Parse(match.Groups[3].Value),
                    Height = int.Parse(match.Groups[4].Value)
                };
            }

            return result;
        }

        public XElement ToXml(string name)
        {
            return new XElement(
                name,
                new XAttribute("X", X),
                new XAttribute("Y", Y),
                new XAttribute("Width", Width),
                new XAttribute("Height", Height));
        }

        public bool Equals(int x, int y, int w, int h)
        {
            return X == x && Y == y && Width == w && Height == h;
        }

        public override string ToString()
        {
            return $"({X}, {Y}, {Width}, {Height})";
        }
    }
}

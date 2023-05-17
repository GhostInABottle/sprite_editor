using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace SpriteEditor.Models
{
    [Serializable]
    public class Circle
    {
        public Circle()
        {
            X = Y = Radius = -1;
        }

        public Circle(int x, int y, int radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public Circle(Circle other)
        {
            X = other.X;
            Y = other.Y;
            Radius = other.Radius;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public int Radius { get; set; }

        public static explicit operator Rect(Circle r)
        {
            return new Rect(r.X - r.Radius, r.Y - r.Radius, r.Radius * 2, r.Radius * 2);
        }

        public static Circle FromString(string input)
        {
            // Matches patterns like (-33, 2, 4)
            const string pattern = @"^\(\s*(-?\d+)\s*,\s*(-?\d+)\s*,\s*(-?\d+)\s*\)$";
            var match = Regex.Match(input, pattern);
            if (!match.Success) return null;

            return new Circle
            {
                X = int.Parse(match.Groups[1].Value),
                Y = int.Parse(match.Groups[2].Value),
                Radius = int.Parse(match.Groups[3].Value)
            };
        }

        public XElement ToXml(string name)
        {
            return new XElement(
                name,
                new XAttribute("X", X),
                new XAttribute("Y", Y),
                new XAttribute("Radius", Radius));
        }

        public static Circle FromXml(XElement element)
        {
            return new Circle(
                (int)element.Attribute("X"),
                (int)element.Attribute("Y"),
                (int)element.Attribute("Radius"));
        }

        public bool Equals(int x, int y, int radius)
        {
            return X == x && Y == y && Radius == radius;
        }

        public override string ToString()
        {
            return $"({X}, {Y}, {Radius})";
        }
    }
}

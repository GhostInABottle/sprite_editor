using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;

namespace SpriteEditor
{
    /// <summary>
    /// A container of poses. SpriteData only contains data read from XML files and
    /// not any actual logic, which is represented by SpriteLogic.
    /// </summary>
    [Serializable]
    public class SpriteData
    {
        public SpriteData()
        {
            BaseDirectory = ".";
            Poses = new List<Pose>();
        }

        /// <summary>
        /// Name of the sprite image.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Transparent color as hex string
        /// </summary>
        public string TransparentColor { get; set; }

        /// <summary>
        /// Transparent color as hex string
        /// </summary>
        public string BaseDirectory { get; set; }

        /// <summary>
        /// List of poses.
        /// </summary>
        public List<Pose> Poses { get; set; }

        public static void Save(SpriteData sprite, string filename)
        {
            var doc = new XDocument(
                new XDeclaration("1.0", "us-ascii", null),
                sprite.ToXml());
            doc.Save(filename);
        }

        public static SpriteData Load(string filename)
        {
            var extension = System.IO.Path.GetExtension(filename);
            if (extension == null)
            {
                throw new ArgumentException($"Unknown extension for file {filename}", nameof(filename));
            }
            if (extension.Equals(".spr", StringComparison.InvariantCultureIgnoreCase))
            {
                return LoadSprite(filename);
            }
            if (extension.Equals(".png", StringComparison.InvariantCultureIgnoreCase))
            {
                return LoadImage(filename);
            }
            throw new ArgumentException($"Trying to load a wrong file format {filename}", nameof(filename));
        }

        public XElement ToXml()
        {
            var children = new List<object>();
            if (!string.IsNullOrEmpty(Image))
            {
                children.Add(new XAttribute("Image", Image));
            }

            if (!string.IsNullOrEmpty(TransparentColor))
            {
                children.Add(new XAttribute("Transparent-Color", TransparentColor));
            }

            if (BaseDirectory != ".")
            {
                children.Add(new XAttribute("Base-Dir", BaseDirectory));
            }

            foreach (var pose in Poses)
            {
                children.Add(pose.ToXml());
            }

            return new XElement("Sprite", children);
        }

        private static SpriteData LoadSprite(string filename)
        {
            var xml = XDocument.Load(filename);
            var spriteData =
                (from sprite in xml.Descendants("Sprite")
                 select new SpriteData()
                 {
                     Image = (string)sprite.Attribute("Image"),
                     TransparentColor = (string)sprite.Attribute("Transparent-Color"),
                     BaseDirectory = (string)sprite.Attribute("Base-Dir") ?? ".",
                     Poses =
                         (from pose in sprite.Descendants("Pose")
                          select new Pose()
                          {
                              DefaultDuration = (int?)pose.Attribute("Duration") ?? 100,
                              Repeats = (int?)pose.Attribute("Repeats") ?? -1,
                              Origin = new Vec2(
                                                (float?)pose.Attribute("X-Origin") ?? 0.0f,
                                                (float?)pose.Attribute("Y-Origin") ?? 0.0f),
                              BoundingBox =
                                  (from box in pose.Descendants("Bounding-Box")
                                   select new Rect(
                                       (int)box.Attribute("X"),
                                       (int)box.Attribute("Y"),
                                       (int)box.Attribute("Width"),
                                       (int)box.Attribute("Height"))).DefaultIfEmpty(new Rect()).First(),
                              Image = (string)pose.Attribute("Image"),
                              TransparentColor = (string)pose.Attribute("Transparent-Color"),
                              Tags =
                                  (from tag in pose.Descendants("Tag")
                                   select new
                                   {
                                       Key = (string)tag.Attribute("Key"),
                                       Value = (string)tag.Attribute("Value")
                                   }).ToDictionary(tag => tag.Key, tag => tag.Value),
                              Frames =
                                  (from frame in pose.Descendants("Frame")
                                   select new Frame()
                                   {
                                       Duration = (int?)frame.Attribute("Duration") ?? -1,
                                       Magnification = new Vec2(
                                                                (float?)frame.Attribute("X-Mag") ?? 1.0f,
                                                                (float?)frame.Attribute("Y-Mag") ?? 1.0f),
                                       Angle = (int?)frame.Attribute("Angle") ?? 0,
                                       Opacity = (float?)frame.Attribute("Opacity") ?? 1.0f,
                                       IsTweenFrame = (bool?)frame.Attribute("Tween") ?? false,
                                       Rectangle =
                                           (from rect in frame.Descendants("Rectangle")
                                            select new Rect(
                                                (int)rect.Attribute("X"),
                                                (int)rect.Attribute("Y"),
                                                (int)rect.Attribute("Width"),
                                                (int)rect.Attribute("Height"))).DefaultIfEmpty(new Rect(0, 0, 0, 0)).First(),
                                       Image = (string)frame.Attribute("Image"),
                                       TransparentColor = (string)frame.Attribute("Transparent-Color"),
                                       Sound = (string)frame.Attribute("Sound"),
                                   }).ToList()
                          }).ToList()
                 }).FirstOrDefault();
            return spriteData;
        }

        private static SpriteData LoadImage(string filename)
        {
            string transparentColor;
            int bitmapWidth, bitmapHeight;
            using (var bmp = new Bitmap(filename))
            {
                transparentColor = bmp.GetPixel(0, 0).ToHex();
                bitmapWidth = bmp.Width;
                bitmapHeight = bmp.Height;
            }

            var spriteData = new SpriteData()
            {
                Image = filename,
                TransparentColor = transparentColor,
                Poses = new List<Pose>()
                {
                    new Pose()
                    {
                        BoundingBox = new Rect(0, 0, bitmapWidth, bitmapHeight),
                        Tags = new Dictionary<string, string>()
                        {
                            { "Name", "Main" }
                        },
                        Frames = new List<Frame>()
                        {
                            new Frame()
                            {
                                Rectangle = new Rect(0, 0, bitmapWidth, bitmapHeight)
                            }
                        }
                    }
                }
            };
            return spriteData;
        }
    }
}

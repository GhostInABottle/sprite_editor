using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Drawing;

namespace SpriteEditor
{
    /// <summary>
    /// A container of poses. SpriteData only contains data read from XML files and
    /// not any actual logic, which is represented by SpriteLogic.
    /// </summary>
    [Serializable()]
    public class SpriteData
    {
        /// <summary>
        /// Name of the sprite image. 
        /// </summary>
        public String Image { get; set; }
        /// </summary>
        /// Transparent color as hex string
        /// </summary>
        public string TransparentColor { get; set; }
        /// </summary>
        /// Transparent color as hex string
        /// </summary>
        public string BaseDirectory { get; set; }
        /// <summary>
        /// List of poses. 
        /// </summary>
        public List<Pose> Poses { get; set; }

        public SpriteData()
        {
            BaseDirectory = ".";
            Poses = new List<Pose>();
        }

        public static void Save(SpriteData sprite, string filename)
        {
            var doc = new XDocument(
                new XDeclaration("1.0", "us-ascii", null),
                sprite.ToXml()
            );
            doc.Save(filename);
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
                              XOrigin = (float?)pose.Attribute("X-Origin") ?? 0.0f,
                              YOrigin = (float?)pose.Attribute("Y-Origin") ?? 0.0f,
                              BoundingBox =
                                  (from box in pose.Descendants("Bounding-Box")
                                   select new Rect(
                                       (int)box.Attribute("X"),
                                       (int)box.Attribute("Y"),
                                       (int)box.Attribute("Width"),
                                       (int)box.Attribute("Height"))
                                  ).DefaultIfEmpty(new Rect()).First(),
                              Tags =
                                  (from tag in pose.Descendants("Tag")
                                   select new
                                   {
                                       Key = (string)tag.Attribute("Key"),
                                       Value = (string)tag.Attribute("Value")
                                   }
                                  ).ToDictionary(tag => tag.Key, tag => tag.Value),
                              Frames =
                                  (from frame in pose.Descendants("Frame")
                                   select new Frame()
                                   {
                                       Duration = (int?)frame.Attribute("Duration") ?? -1,
                                       XMagnification = (float?)frame.Attribute("X-Mag") ?? 1.0f,
                                       YMagnification = (float?)frame.Attribute("Y-Mag") ?? 1.0f,
                                       Angle = (int?)frame.Attribute("Angle") ?? 0,
                                       Opacity = (float?)frame.Attribute("Opacity") ?? 1.0f,
                                       IsTweenFrame = (bool?)frame.Attribute("Tween") ?? false,
                                       Rectangle =
                                           (from rect in frame.Descendants("Rectangle")
                                            select new Rect(
                                                (int)rect.Attribute("X"),
                                                (int)rect.Attribute("Y"),
                                                (int)rect.Attribute("Width"),
                                                (int)rect.Attribute("Height"))
                                       ).DefaultIfEmpty(new Rect(0, 0, 0, 0)).First(),
                                       Image = (string)frame.Attribute("Image"),
                                       TransparentColor = (string)frame.Attribute("Transparent-Color"),
                                   }).ToList<Frame>()
                          }).ToList<Pose>()
                 }).FirstOrDefault();
            return spriteData;
        }

        private static SpriteData LoadImage(string filename)
        {
            Bitmap bmp = new Bitmap(filename);
            var spriteData = new SpriteData()
            {
                Image = filename,
                TransparentColor = bmp.GetPixel(0, 0).ToHex(),
                Poses = new List<Pose>()
                {
                    new Pose()
                    {
                        BoundingBox = new Rect(0, 0, bmp.Width, bmp.Height),
                        Tags = new Dictionary<string, string>()
                        {
                            {"Name", "Main"}
                        },
                        Frames = new List<Frame>()
                        {
                            new Frame()
                            {
                                Rectangle = new Rect(0, 0, bmp.Width, bmp.Height)
                            }
                        }
                    }
                }

            };
            return spriteData;
        }

        public static SpriteData Load(string filename)
        {
            var extension = System.IO.Path.GetExtension(filename);
            if (extension == ".spr")
                return LoadSprite(filename);
            else if (extension == ".png")
                return LoadImage(filename);
            else
                throw new ArgumentException("Trying to load a wrong file format");
        }

        public XElement ToXml()
        {
            var children = new List<object>();
            if (!String.IsNullOrEmpty(Image))
                children.Add(new XAttribute("Image", Image));
            if (!String.IsNullOrEmpty(TransparentColor))
                children.Add(new XAttribute("Transparent-Color", TransparentColor));
            if (BaseDirectory != ".")
                children.Add(new XAttribute("Base-Dir", BaseDirectory));

            foreach (var pose in Poses)
            {
                children.Add(pose.ToXml());
            }

            return new XElement("Sprite", children);
        }
    }
}

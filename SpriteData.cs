using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

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
                new XDeclaration("2.0", "us-ascii", null),
                sprite.ToXml()
            );
            doc.Save(filename);
        }

        public static SpriteData Load(string filename)
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
                            Name = (string)pose.Attribute("Name"),
                            DefaultDuration = (int?)pose.Attribute("Duration") ?? 100,
                            Repeats = (int?)pose.Attribute("Repeats") ?? -1,
                            BoundingBox = 
                                    (from box in pose.Descendants("Bounding-Box")
                                    select new Rect(
                                        (int)box.Attribute("X"), 
                                        (int)box.Attribute("Y"),
                                        (int)box.Attribute("Width"),
                                        (int)box.Attribute("Height"))
                                    ).DefaultIfEmpty(new Rect()).First(),
                            Frames =
                                (from frame in pose.Descendants("Frame")
                                 select new Frame()
                                 {
                                     Duration = (int?)frame.Attribute("Duration") ?? -1,
                                     XMagnification = (float?)frame.Attribute("X-Mag") ?? 1.0f,
                                     YMagnification = (float?)frame.Attribute("Y-Mag") ?? 1.0f,
                                     Angle = (int?)frame.Attribute("Angle") ?? 0,
                                     IsTweenFrame = (bool?)frame.Attribute("Tween") ?? false,
                                     Rectangle = 
                                         (from rect in frame.Descendants("Rectangle")
                                          select new Rect(
                                              (int)rect.Attribute("X"),
                                              (int)rect.Attribute("Y"),
                                              (int)rect.Attribute("Width"),
                                              (int)rect.Attribute("Height"))
                                        ).DefaultIfEmpty(new Rect(0, 0, 0, 0)).First(),
                                 }).ToList<Frame>()
                        }).ToList<Pose>()
                }).FirstOrDefault();
            return spriteData;
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

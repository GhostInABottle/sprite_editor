using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
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
        [XmlElement(ElementName = "Transparent-Color")]
        public string TransparentColor { get; set; }
        /// </summary>
        /// Transparent color as hex string
        /// </summary>
        [XmlElement(ElementName = "Base-Dir")]
        public string BaseDirectory { get; set; }
        /// <summary>
        /// List of poses. 
        /// </summary>
        [XmlElement(ElementName = "Pose")]
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

        public static void Load(string filename)
        {
            var xml = XDocument.Load(filename);
            var spriteData = 
                (from sprite in xml.Descendants("Sprite")
                select new SpriteData()
                {
                    Image = (string)sprite.Attribute("Image"),
                    TransparentColor = (string)sprite.Attribute("Transparent-Color"),
                    BaseDirectory = (string)sprite.Attribute("Base-Dir")
                }).FirstOrDefault();
                            
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

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

        public XElement ToXml()
        {
            var children = new List<object>();
            children.Add(new XAttribute("Version", 2.0f));
            if (!String.IsNullOrEmpty(Image))
                children.Add(new XAttribute("Image", Image));
            if (!String.IsNullOrEmpty(TransparentColor))
                children.Add(new XAttribute("Transparent-Color", TransparentColor));
            if (BaseDirectory != ".")
                children.Add(new XAttribute("Image-Dir", BaseDirectory));

            foreach (var pose in Poses)
            {
                children.Add(pose.ToXml());
            }

            return new XElement("Sprite", children);
        }
    }
}

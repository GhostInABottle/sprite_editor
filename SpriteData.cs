using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

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
        /// Maximum number of poses in a sprite.
        /// </summary>
        public static readonly int MAX_SPRITE_POSES = 3;
        /// <summary>
        /// Name of the sprite image. 
        /// </summary>
        public String Image { get; set; }
        /// </summary>
        /// List of poses. 
        /// </summary>
        [XmlElement(ElementName = "Pose")]
        public List<Pose> Poses { get; set; }

        [XmlElement(ElementName = "Transparent-Color")]
        public string TransparentColor { get; set; } 

        public SpriteData()
        {
            Poses = new List<Pose>(MAX_SPRITE_POSES);
        }
    }
}

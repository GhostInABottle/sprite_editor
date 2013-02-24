using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Xml.Serialization;

namespace SpriteEditor
{
    /// <summary>
    /// A single frame in a pose.
    /// </summary>
    [Serializable()]
    public class Frame
    {
        /// <summary>
        /// Frame duration in milliseconds.
        /// </summary>
        public int Duration { get; set; }
        [XmlIgnoreAttribute()]
        public bool DurationSpecified { get; set; }
        /// <summary>
        /// Source rectangle.
        /// </summary>
        public Rect Rectangle { get; set; }
        /// <summary>
        /// Horizontal magnification. 
        /// </summary>
        [XmlElement(ElementName = "X-Magnification")]
        public float XMagnification { get; set; }
        [XmlIgnoreAttribute()]
        public bool XMagnificationSpecified { get; set; }
        /// <summary>
        /// Vertical magnification. 
        /// </summary>
        [XmlElement(ElementName = "Y-Magnification")]
        public float YMagnification { get; set; }
        [XmlIgnoreAttribute()]
        public bool YMagnificationSpecified { get; set; }
        /// <summary>
        /// Rotation angle. 
        /// </summary>
        public int Angle { get; set; }
        [XmlIgnoreAttribute()]
        public bool AngleSpecified { get; set; }
        /// <summary>
        /// Is it a tween frame? 
        /// </summary>
        [XmlElement(ElementName = "Tween-Frame")]
        public bool IsTweenFrame { get; set; }
        [XmlIgnoreAttribute()]
        public bool IsTweenFrameSpecified { get; set; }

        public Frame()
        {
            Duration = -1;
            XMagnification = YMagnification = 1.0f;
            Angle = 0;
            IsTweenFrame = false;
            Rectangle = new Rect(0, 0, 0, 0);
        }
    }

}

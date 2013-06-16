using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Xml.Linq;

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
        /// <summary>
        /// Source rectangle.
        /// </summary>
        public Rect Rectangle { get; set; }
        /// <summary>
        /// Horizontal magnification. 
        /// </summary>
        public float XMagnification { get; set; }
        /// <summary>
        /// Vertical magnification. 
        /// </summary>
        public float YMagnification { get; set; }
        /// <summary>
        /// Rotation angle. 
        /// </summary>
        public int Angle { get; set; }
        /// <summary>
        /// Is it a tween frame? 
        /// </summary>
        public bool IsTweenFrame { get; set; }
        /// <summary>
        /// Name of the frame's image. 
        /// </summary>
        public String Image { get; set; }
        /// </summary>
        /// Transparent color as hex string
        /// </summary>
        public string TransparentColor { get; set; }

        public Frame()
        {
            Duration = -1;
            XMagnification = YMagnification = 1.0f;
            Angle = 0;
            IsTweenFrame = false;
            Rectangle = new Rect(0, 0, 0, 0);
        }

        public XElement ToXml()
        {
            var children = new List<object>();
            if (Duration != -1)
                children.Add(new XAttribute("Duration", Duration));
            children.Add(Rectangle.ToXml("Rectangle"));
            if (!Utilities.CheckClose(XMagnification, 1.0f, 0.01f))
                children.Add(new XAttribute("X-Mag", XMagnification));
            if (!Utilities.CheckClose(YMagnification, 1.0f, 0.01f))
                children.Add(new XAttribute("Y-Mag", YMagnification));
            if (Angle != 0)
                children.Add(new XAttribute("Angle", Angle));
            if (IsTweenFrame)
                children.Add(new XAttribute("Tween", IsTweenFrame));
            if (!String.IsNullOrEmpty(Image))
                children.Add(new XAttribute("Image", Image));
            if (!String.IsNullOrEmpty(TransparentColor))
                children.Add(new XAttribute("Transparent-Color", TransparentColor));
            return new XElement("Frame", children.ToArray());
        }
    }

}

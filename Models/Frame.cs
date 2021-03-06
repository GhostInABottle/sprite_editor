using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace SpriteEditor.Models
{
    /// <summary>
    /// A single frame in a pose.
    /// </summary>
    public class Frame : IDisposable
    {
        public Frame()
        {
            Duration = -1;
            Magnification = new Vec2();
            Angle = 0;
            Opacity = 1.0f;
            IsTweenFrame = false;
            Rectangle = new Rect(0, 0, 0, 0);
            Sound = new Sound();
        }

        public Frame(Frame other)
        {
            Duration = other.Duration;
            Rectangle = new Rect(other.Rectangle);
            Magnification = new Vec2(other.Magnification);
            Angle = other.Angle;
            Opacity = other.Opacity;
            IsTweenFrame = other.IsTweenFrame;
            Image = other.Image;
            TransparentColor = other.TransparentColor;
            Sound = other.Sound;
        }

        /// <summary>
        /// Frame duration in milliseconds.
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// Source rectangle.
        /// </summary>
        public Rect Rectangle { get; set; }

        /// <summary>
        /// Magnification.
        /// </summary>
        public Vec2 Magnification { get; set; }

        /// <summary>
        /// Rotation angle.
        /// </summary>
        public int Angle { get; set; }

        /// <summary>
        /// Alpha value (0 to 1)
        /// </summary>
        public float Opacity { get; set; }

        /// <summary>
        /// Is it a tween frame?
        /// </summary>
        public bool IsTweenFrame { get; set; }

        /// <summary>
        /// Name of the frame's image.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Transparent color as hex string
        /// </summary>
        public string TransparentColor { get; set; }

        /// <summary>
        /// Sound effect to play
        /// </summary>
        public Sound Sound { get; set; }

        public XElement ToXml()
        {
            var children = new List<object>();
            if (Duration != -1)
            {
                children.Add(new XAttribute("Duration", Duration));
            }

            children.Add(Rectangle.ToXml("Rectangle"));

            if (!Utilities.CheckClose(Magnification.X, 1.0f))
            {
                children.Add(new XAttribute("X-Mag", Magnification.X));
            }

            if (!Utilities.CheckClose(Magnification.Y, 1.0f))
            {
                children.Add(new XAttribute("Y-Mag", Magnification.Y));
            }

            if (Angle != 0)
            {
                children.Add(new XAttribute("Angle", Angle));
            }

            if (!Utilities.CheckClose(Opacity, 1.0f, 0.01f))
            {
                children.Add(new XAttribute("Opacity", Opacity));
            }

            if (IsTweenFrame)
            {
                children.Add(new XAttribute("Tween", IsTweenFrame));
            }

            if (!string.IsNullOrEmpty(Image))
            {
                children.Add(new XAttribute("Image", Image.Replace("\\", "/")));
            }

            if (!string.IsNullOrEmpty(TransparentColor))
            {
                children.Add(new XAttribute("Transparent-Color", TransparentColor));
            }

            if (!string.IsNullOrEmpty(Sound?.Filename))
            {
                children.Add(Sound.ToXml());
            }

            return new XElement("Frame", children.ToArray());
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing) return;
            Sound.Dispose();
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}

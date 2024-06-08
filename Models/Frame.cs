using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;

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
            MaxDuration = other.MaxDuration;
            Rectangle = new Rect(other.Rectangle);
            Magnification = new Vec2(other.Magnification);
            Angle = other.Angle;
            Opacity = other.Opacity;
            IsTweenFrame = other.IsTweenFrame;
            Image = other.Image;
            TransparentColor = other.TransparentColor;
            Sound = new Sound(other.Sound);
        }

        /// <summary>
        /// Regular or min frame duration in milliseconds.
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// Max frame duration in milliseconds.
        /// </summary>
        public int? MaxDuration { get; set; }

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
            if (MaxDuration.HasValue)
            {
                children.Add(new XAttribute("Max-Duration", MaxDuration));
            }

            children.Add(Rectangle.ToXml("Rectangle"));

            if (!IsTweenFrame && !Utilities.CheckClose(Magnification.X, 1.0f))
            {
                children.Add(new XAttribute("X-Mag", Magnification.X));
            }

            if (!IsTweenFrame && !Utilities.CheckClose(Magnification.Y, 1.0f))
            {
                children.Add(new XAttribute("Y-Mag", Magnification.Y));
            }

            if (!IsTweenFrame && Angle != 0)
            {
                children.Add(new XAttribute("Angle", Angle));
            }

            if (!IsTweenFrame && !Utilities.CheckClose(Opacity, 1.0f, 0.01f))
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

        public static Frame FromXml(XElement frame)
        {
            return new Frame()
            {
                Duration = (int?)frame.Attribute("Duration") ?? -1,
                MaxDuration = (int?)frame.Attribute("Max-Duration"),
                Magnification = new Vec2(
                    (float?)frame.Attribute("X-Mag") ?? 1.0f,
                    (float?)frame.Attribute("Y-Mag") ?? 1.0f),
                Angle = (int?)frame.Attribute("Angle") ?? 0,
                Opacity = (float?)frame.Attribute("Opacity") ?? 1.0f,
                IsTweenFrame = (bool?)frame.Attribute("Tween") ?? false,
                Rectangle =
                (from rect in frame.Descendants("Rectangle") select Rect.FromXml(rect))
                    .DefaultIfEmpty(new Rect(0, 0, 0, 0)).Single(),
                Image = (string)frame.Attribute("Image"),
                TransparentColor = (string)frame.Attribute("Transparent-Color"),
                Sound = (
                    from sound in frame.Descendants("Sound")
                    select new Sound(
                        (string)sound.Attribute("Filename"),
                        (float?)sound.Attribute("Pitch"),
                        (float?)sound.Attribute("Volume")
                    )
                ).DefaultIfEmpty(new Sound((string)frame.Attribute("Sound"))).Single(),
            };
        }

        public void Offset(int x, int y)
        {
            Rectangle.X += x;
            Rectangle.Y += y;
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

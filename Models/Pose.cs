using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace SpriteEditor.Models
{
    /// <summary>
    /// A single pose in a sprite.
    /// </summary>
    public class Pose : IDisposable
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Pose()
        {
            BoundingBox = new Rect(-1, -1, -1, -1);
            DefaultDuration = 100;
            Repeats = -1;
            RequireCompletion = false;
            Origin = new Vec2(0.0f, 0.0f);
            Tags = new Dictionary<string, string>();
            Frames = new List<Frame>();
        }

        public Pose(Pose other)
        {
            BoundingBox = new Rect(other.BoundingBox);
            DefaultDuration = other.DefaultDuration;
            Repeats = other.Repeats;
            RequireCompletion = other.RequireCompletion;
            Origin = new Vec2(other.Origin);
            Image = other.Image;
            TransparentColor = other.TransparentColor;
            Tags = new Dictionary<string, string>();
            foreach (var (key, value) in other.Tags)
            {
                Tags[key] = value;
            }
            Frames = other.Frames.Select(x => new Frame(x)).ToList();
        }

        /// <summary>
        /// Collision bounding box.
        /// </summary>
        public Rect BoundingBox { get; set; }

        /// <summary>
        /// Total duration of one pose cycle in milliseconds.
        /// </summary>
        public int DefaultDuration { get; set; }

        /// <summary>
        /// Number of times pose is repeated (-1 = forever).
        /// </summary>
        public int Repeats { get; set; }

        /// <summary>
        /// Should all never-ending pose frames be finished before
        /// it can be marked as completed?
        /// </summary>
        public bool RequireCompletion { get; set; }

        /// <summary>
        /// Image origin.
        /// </summary>
        public Vec2 Origin { get; set; }

        /// <summary>
        /// Name of the pose's image.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Transparent color as hex string
        /// </summary>
        public string TransparentColor { get; set; }

        /// <summary>
        /// Tags associated with pose
        /// </summary>
        public Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// List of frames.
        /// </summary>
        public List<Frame> Frames { get; set; }

        public string GetName()
        {
            return Tags.ContainsKey("Name") ? Tags["Name"] : "";
        }

        public string NameWithTags()
        {
            var name = GetName();
            if (Tags.ContainsKey("Direction"))
            {
                name += " [" + Tags["Direction"] + "]";
            }

            if (Tags.ContainsKey("State"))
            {
                name += " [" + Tags["State"] + "]";
            }

            return name;
        }

        public XElement ToXml()
        {
            var children = new List<object>();
            if (!BoundingBox.Equals(-1, -1, -1, -1))
            {
                children.Add(BoundingBox.ToXml("Bounding-Box"));
            }

            children.Add(new XAttribute("Duration", DefaultDuration));

            if (Repeats != -1)
            {
                children.Add(new XAttribute("Repeats", Repeats));
            }
            else if (RequireCompletion)
            {
                children.Add(new XAttribute("Require-Completion", RequireCompletion));
            }

            if (!Utilities.CheckClose(Origin.X, 0.0f))
            {
                children.Add(new XAttribute("X-Origin", Origin.X));
            }

            if (!Utilities.CheckClose(Origin.Y, 0.0f))
            {
                children.Add(new XAttribute("Y-Origin", Origin.Y));
            }

            if (!string.IsNullOrEmpty(Image))
            {
                children.Add(new XAttribute("Image", Image.Replace("\\", "/")));
            }

            if (!string.IsNullOrEmpty(TransparentColor))
            {
                children.Add(new XAttribute("Transparent-Color", TransparentColor));
            }

            foreach (var pair in Tags)
            {
                var tagElement = new XElement(
                    "Tag",
                    new XAttribute("Key", pair.Key),
                    new XAttribute("Value", pair.Value));
                children.Add(tagElement);
            }

            foreach (var frame in Frames)
            {
                children.Add(frame.ToXml());
            }

            return new XElement("Pose", children.ToArray());
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing) return;
            foreach (var frame in Frames)
            {
                frame.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}

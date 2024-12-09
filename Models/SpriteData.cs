using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Xml.Linq;

namespace SpriteEditor.Models
{
    /// <summary>
    /// A container of poses. SpriteData only contains data read from XML files and
    /// not any actual logic, which is represented by SpriteLogic.
    /// </summary>
    public class SpriteData : IDisposable
    {
        public SpriteData()
        {
            BaseDirectory = ".";
            Poses = [];
        }

        /// <summary>
        /// Name of the sprite image.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Transparent color as hex string
        /// </summary>
        public string TransparentColor { get; set; }

        /// <summary>
        /// Transparent color as hex string
        /// </summary>
        public string BaseDirectory { get; set; }

        /// <summary>
        /// The default pose for this sprite
        /// </summary>
        public string DefaultPose { get; set; }

        /// <summary>
        /// List of poses.
        /// </summary>
        public List<Pose> Poses { get; set; }

        public static void Save(SpriteData sprite, string filename)
        {
            var doc = new XDocument(
                new XDeclaration("1.0", "us-ascii", null),
                sprite.ToXml());
            doc.Save(filename);
        }

        public static SpriteData Load(string filename)
        {
            var extension = System.IO.Path.GetExtension(filename)
                ?? throw new ArgumentException($"Unknown extension for file {filename}", nameof(filename));

            if (extension.Equals(".spr", StringComparison.InvariantCultureIgnoreCase))
            {
                return LoadSprite(filename);
            }

            if (OperatingSystem.IsWindows() && extension.Equals(".png", StringComparison.InvariantCultureIgnoreCase))
            {
                return LoadImage(filename);
            }

            throw new ArgumentException($"Trying to load a wrong file format {filename}", nameof(filename));
        }

        public XElement ToXml()
        {
            var children = new List<object>();
            if (!string.IsNullOrEmpty(Image))
            {
                children.Add(new XAttribute("Image", Image.Replace("\\", "/")));
            }

            if (!string.IsNullOrEmpty(TransparentColor))
            {
                children.Add(new XAttribute("Transparent-Color", TransparentColor));
            }

            if (BaseDirectory != ".")
            {
                children.Add(new XAttribute("Base-Dir", BaseDirectory));
            }

            if (!string.IsNullOrEmpty(DefaultPose))
            {
                children.Add(new XAttribute("Default-Pose", DefaultPose));
            }

            foreach (var pose in Poses)
            {
                children.Add(pose.ToXml());
            }

            return new XElement("Sprite", children);
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
                     DefaultPose = (string)sprite.Attribute("Default-Pose"),
                     Poses =
                         (from pose in sprite.Descendants("Pose")
                          select Pose.FromXml(pose)).ToList()
                 }).FirstOrDefault();
            return spriteData;
        }

        [SupportedOSPlatform("windows")]
        private static SpriteData LoadImage(string filename)
        {
            string transparentColor;
            int bitmapWidth, bitmapHeight;
            using (var bmp = new Bitmap(filename))
            {
                transparentColor = bmp.GetPixel(0, 0).ToHex();
                bitmapWidth = bmp.Width;
                bitmapHeight = bmp.Height;
            }

            var spriteData = new SpriteData()
            {
                Image = filename,
                TransparentColor = transparentColor,
                Poses =
                [
                    new ()
                    {
                        BoundingBox = new Rect(0, 0, bitmapWidth, bitmapHeight),
                        Tags = new Dictionary<string, string>()
                        {
                            { "Name", "Main" }
                        },
                        Frames =
                        [
                            new()
                            {
                                Rectangle = new Rect(0, 0, bitmapWidth, bitmapHeight)
                            }
                        ]
                    }
                ]
            };
            return spriteData;
        }

        public IEnumerable<string> GetPoseNames()
        {
            var poses = new HashSet<string>();
            foreach (var pose in Poses)
            {
                var poseName = pose.GetName();
                if (string.IsNullOrEmpty(poseName)) continue;
                poses.Add(pose.GetName());
            }
            return poses;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing) return;
            foreach (var pose in Poses)
            {
                pose.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}

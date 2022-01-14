using System.Collections.Generic;
using System.Xml.Linq;

namespace SpriteEditor.Models
{
    /// <summary>
    /// Sound to be played in a frame
    /// </summary>
    public class Sound
    {
        public Sound()
        {
        }

        public Sound(Sound other)
        {
            Filename = other.Filename;
            Pitch = other.Pitch;
            Volume = other.Volume;
        }

        /// <summary>
        /// Name of the sound file
        /// </summary>
        public string Filename { get; set; }
        /// <summary>
        /// The sound's pitch multiplier
        /// </summary>
        public float? Pitch { get; set; }
        /// <summary>
        /// Sound volume percentage (1 is 100%)
        /// </summary>
        public float? Volume { get; set; }

        public XObject ToXml()
        {
            var filename = Filename.Replace("\\", "/");
            if (!Pitch.HasValue && !Volume.HasValue)
            {
                return new XAttribute("Sound", filename);
            }

            var children = new List<object>
            {
                new XAttribute("Filename", filename)
            };

            if (Pitch.HasValue)
            {
                children.Add(new XAttribute("Pitch", Pitch));
            }

            if (Volume.HasValue)
            {
                children.Add(new XAttribute("Volume", Volume));
            }

            return new XElement("Sound", children.ToArray());
        }
    }
}

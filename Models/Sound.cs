using FmodAudio;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace SpriteEditor.Models
{
    /// <summary>
    /// Sound to be played in a frame
    /// </summary>
    public class Sound : IDisposable
    {
        private bool isDisposed;
        private string lastLoadedFilename;

        public Sound(string filename = null, float? pitch = null, float? volume = null)
        {
            Filename = filename;
            Pitch = pitch;
            Volume = volume;
        }

        public Sound(Sound other)
        {
            Filename = other.Filename;
            Pitch = other.Pitch;
            Volume = other.Volume;
        }

        ~Sound()
        {
            Dispose(disposing: false);
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
        /// <summary>
        /// The FMOD sound handle
        /// </summary>
        public FmodAudio.Sound? FmodSound { get; set; }

        public FmodAudio.Sound? LoadFmodSound(FmodSystem system, string fullPath)
        {
            if (FmodSound != null && lastLoadedFilename == fullPath) return FmodSound;

            FmodSound = system.CreateSound(fullPath, Mode._2D | Mode.Loop_Off);
            lastLoadedFilename = fullPath;

            return FmodSound;
        }

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

        protected virtual void Dispose(bool disposing)
        {
            if (isDisposed)
            {
                return;
            }

            if (disposing)
            {
                FmodSound?.Dispose();
                FmodSound = null;
            }

            isDisposed = true;
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}

using FmodAudio;
using System;
using System.Windows.Forms;

namespace SpriteEditor
{
	public class Audio : IDisposable
    {
        /// <summary>
        /// FMOD system
        /// </summary>
        private readonly FmodSystem? fmodSystem;
        private bool isDisposed;

        public Audio()
		{
            try
            {
                fmodSystem = Fmod.CreateSystem();
                fmodSystem.Value.Init(10);
            }
            catch (Exception ex)
            {
                fmodSystem = null;
                if (OperatingSystem.IsWindowsVersionAtLeast(6, 1))
                {
                    MessageBox.Show("Failed to load FMOD sound system - make sure the correct DLL is in the executable folder - " + ex.Message);
                }
            }
        }

        public void Update()
        {
            fmodSystem?.Update();
        }

        private Channel PlaySound(Sound sound, bool paused = true)
        {
            if (fmodSystem == null) return null;

            return fmodSystem.Value.PlaySound(sound, paused: paused);
        }

        public Channel PlaySound(Models.Sound soundData, string filename = null)
        {
            if (fmodSystem == null) return null;

            var sound = soundData.LoadFmodSound(fmodSystem.Value, filename ?? soundData.Filename);
            if (sound == null) return null;

            var channel = PlaySound(sound.Value);
            if (channel == null) return null;

            if (soundData.Pitch.HasValue)
            {
                channel.Pitch = soundData.Pitch.Value;
            }
            if (soundData.Volume.HasValue)
            {
                channel.Volume = soundData.Volume.Value;
            }

            channel.Paused = false;
            return channel;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (isDisposed) return;

            fmodSystem?.Dispose();
            isDisposed = true;
        }

        ~Audio()
        {
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}

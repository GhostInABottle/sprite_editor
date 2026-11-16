using FmodAudio;
using SpriteEditor.Properties;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SpriteEditor
{
    public partial class FrmSound : Form
    {
        private readonly FmodSystem fmodSystem;
        private Channel currentChannel;
        private int lastItemIndex;
        private Stopwatch playStopwatch;
        private static readonly string[] ValidExtensions =
        [
            "wav",
            "ogg",
            "mp3"
        ];

        public FrmSound()
        {
            InitializeComponent();
            try
            {
                fmodSystem = Fmod.CreateSystem();
                fmodSystem.Init(10);
                trmUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load FMOD sound system - make sure the correct DLL is in the executable folder - " + ex.Message);
            }

            var dir = Settings.Default.LastSoundDirectory;
            if (!string.IsNullOrWhiteSpace(dir))
            {
                txtDirectory.Text = dir;
                fbdDirectory.SelectedPath = dir;
                PopulatelstSoundFiles(dir);
            }
            hsbVolume_Scroll(this, null);
            hsbPitch_Scroll(this, null);
            lstSoundFiles.Focus();
        }

        private void hsbVolume_Scroll(object sender, ScrollEventArgs e)
        {
            lblVolume.Text = $"Volume: {hsbVolume.Value}";
        }

        private void hsbPitch_Scroll(object sender, ScrollEventArgs e)
        {

            lblPitch.Text = $"Pitch: {hsbPitch.Value}";
        }

        private void btnDirectory_Click(object sender, EventArgs e)
        {
            var result = fbdDirectory.ShowDialog();
            var path = fbdDirectory.SelectedPath;
            if (result == DialogResult.Cancel || string.IsNullOrWhiteSpace(path))
            {
                return;
            }

            txtDirectory.Text = path;
            Settings.Default.LastSoundDirectory = path;
            PopulatelstSoundFiles(path);
            lstSoundFiles.Focus();
            lastItemIndex = -2;
        }

        private void PopulatelstSoundFiles(string path)
        {
            if (!Directory.Exists(path))
            {
                return;
            }

            var files = Directory.GetFiles(path)
                .Where(f => ValidExtensions.Any(ext => f.EndsWith($".{ext}")))
                .Select(f => Path.GetFileName(f));

            lstSoundFiles.Items.Clear();
            lstSoundFiles.Items.AddRange([.. files]);
        }

        private void FrmSound_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
        }

        private void trmUpdate_Tick(object sender, EventArgs e)
        {
            fmodSystem.Update();
            var stopwatchActive = playStopwatch != null && playStopwatch.IsRunning;
            if (!stopwatchActive) return;

            var elapsed = playStopwatch.Elapsed;
            lblLength.Text = $"Length: {elapsed.TotalSeconds:F2}s";
            var soundPlaying = currentChannel != null && currentChannel.IsPlaying;
            if (!soundPlaying)
            {
                playStopwatch.Stop();
                playStopwatch = null;
            }
        }

        private void PlaySound()
        {
            StopSound();

            if (lstSoundFiles.SelectedItem is not string selectedItem)
            {
                return;
            }

            lastItemIndex = lstSoundFiles.SelectedIndex;

            var fullPath = Path.Combine(txtDirectory.Text, selectedItem);
            var sound = LoadFmodSound(fullPath);

            currentChannel = fmodSystem.PlaySound(sound.Value, paused: true);
            currentChannel.Pitch = hsbPitch.Value / 100.0f;
            currentChannel.Volume = hsbVolume.Value / 100.0f;
            currentChannel.Paused = false;
            playStopwatch = new Stopwatch();
            playStopwatch.Start();
        }

        private void StopSound()
        {
            if (currentChannel == null || !currentChannel.IsPlaying)
            {
                currentChannel = null;
                return;
            }

            currentChannel.Stop();
            currentChannel = null;
        }

        private Sound? LoadFmodSound(string fullPath)
        {
            return fmodSystem.CreateSound(fullPath, Mode._2D | Mode.Loop_Off);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (lstSoundFiles.SelectedIndex == lastItemIndex && currentChannel != null && currentChannel.IsPlaying)
            {
                return;
            }

            PlaySound();
        }

        private void lstSoundFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlaySound();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopSound();
        }

        private void lstSoundFiles_KeyDown(object sender, KeyEventArgs e)
        {
            if (lstSoundFiles.SelectedItem == null || !e.Control || e.KeyCode != Keys.C) return;
            Clipboard.SetText(lstSoundFiles.SelectedItem.ToString());
            e.SuppressKeyPress = true;
            e.Handled = true;
        }
    }
}

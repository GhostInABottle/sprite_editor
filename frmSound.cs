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
        private readonly Audio audio;
        private Models.Sound currentSound;
        private Channel currentChannel;
        private int lastItemIndex;
        private Stopwatch playStopwatch;
        private static readonly string[] ValidExtensions =
        [
            "wav",
            "ogg",
            "mp3"
        ];
        private bool inSelectionMode { get; set; } = false;

        public FrmSound(Audio audioSystem)
        {
            InitializeComponent();
            audio = audioSystem;
            trmUpdate.Enabled = true;

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

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components.Dispose();
                currentSound?.Dispose();
            }

            base.Dispose(disposing);
        }

        public (string filename, float pitch, float volume) OpenAsDialog(string basePath, string selected, float pitch, float volume)
        {
            setDirectory(basePath);
            hsbPitch.Value = (int)(pitch * 100);
            hsbVolume.Value = (int)(volume * 100);
            hsbVolume_Scroll(this, null);
            hsbPitch_Scroll(this, null);
            if (!string.IsNullOrWhiteSpace(selected) && lstSoundFiles.Items.Contains(selected))
            {
                lstSoundFiles.SelectedItem = selected;
            }

            inSelectionMode = true;
            var result = ShowDialog();
            inSelectionMode = false;
            if (result != DialogResult.OK) return (null, pitch, volume);

            var filename = Path.Combine(basePath, lstSoundFiles.SelectedItem.ToString());
            return (filename, hsbPitch.Value / 100.0f, hsbVolume.Value / 100.0f);
        }

        private void hsbVolume_Scroll(object sender, ScrollEventArgs e)
        {
            lblVolume.Text = $"Volume: {hsbVolume.Value}";
        }

        private void hsbPitch_Scroll(object sender, ScrollEventArgs e)
        {

            lblPitch.Text = $"Pitch: {hsbPitch.Value}";
        }

        private void setDirectory(string path)
        {
            if (path == null) return;
            txtDirectory.Text = path;
            Settings.Default.LastSoundDirectory = path;
            PopulatelstSoundFiles(path);
            lstSoundFiles.Focus();
            lastItemIndex = -2;
        }

        private void btnDirectory_Click(object sender, EventArgs e)
        {
            var result = fbdDirectory.ShowDialog();
            var path = fbdDirectory.SelectedPath;
            if (result == DialogResult.Cancel || string.IsNullOrWhiteSpace(path))
            {
                return;
            }

            setDirectory(path);
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
            StopSound();
        }

        private void trmUpdate_Tick(object sender, EventArgs e)
        {
            audio?.Update();
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
            if (audio == null) return;

            StopSound();

            if (lstSoundFiles.SelectedItem is not string selectedItem)
            {
                return;
            }

            lastItemIndex = lstSoundFiles.SelectedIndex;

            var fullPath = Path.Combine(txtDirectory.Text, selectedItem);
            currentSound?.Dispose();
            currentSound = new Models.Sound(fullPath, hsbPitch.Value / 100.0f, hsbVolume.Value / 100.0f);
            currentChannel = audio.PlaySound(currentSound);
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
            currentSound.Dispose();
            currentSound = null;
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

        private void lstSoundFiles_DoubleClick(object sender, EventArgs e)
        {
            if (!inSelectionMode || lstSoundFiles.SelectedIndex == -1) return;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

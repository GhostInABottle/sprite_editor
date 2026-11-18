
namespace SpriteEditor
{
    partial class FrmSound
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblDirectory = new System.Windows.Forms.Label();
            txtDirectory = new System.Windows.Forms.TextBox();
            btnDirectory = new System.Windows.Forms.Button();
            fbdDirectory = new System.Windows.Forms.FolderBrowserDialog();
            lstSoundFiles = new System.Windows.Forms.ListBox();
            lblVolume = new System.Windows.Forms.Label();
            hsbVolume = new System.Windows.Forms.HScrollBar();
            hsbPitch = new System.Windows.Forms.HScrollBar();
            lblPitch = new System.Windows.Forms.Label();
            btnPlay = new System.Windows.Forms.Button();
            trmUpdate = new System.Windows.Forms.Timer(components);
            btnStop = new System.Windows.Forms.Button();
            lblLength = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lblDirectory
            // 
            lblDirectory.AutoSize = true;
            lblDirectory.Location = new System.Drawing.Point(13, 15);
            lblDirectory.Name = "lblDirectory";
            lblDirectory.Size = new System.Drawing.Size(61, 17);
            lblDirectory.TabIndex = 0;
            lblDirectory.Text = "Directory";
            // 
            // txtDirectory
            // 
            txtDirectory.Location = new System.Drawing.Point(75, 15);
            txtDirectory.Name = "txtDirectory";
            txtDirectory.Size = new System.Drawing.Size(354, 25);
            txtDirectory.TabIndex = 1;
            // 
            // btnDirectory
            // 
            btnDirectory.Location = new System.Drawing.Point(435, 15);
            btnDirectory.Name = "btnDirectory";
            btnDirectory.Size = new System.Drawing.Size(37, 26);
            btnDirectory.TabIndex = 2;
            btnDirectory.Text = "...";
            btnDirectory.UseVisualStyleBackColor = true;
            btnDirectory.Click += btnDirectory_Click;
            // 
            // fbdDirectory
            // 
            fbdDirectory.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // lstSoundFiles
            // 
            lstSoundFiles.FormattingEnabled = true;
            lstSoundFiles.Location = new System.Drawing.Point(12, 61);
            lstSoundFiles.Name = "lstSoundFiles";
            lstSoundFiles.Size = new System.Drawing.Size(460, 378);
            lstSoundFiles.TabIndex = 3;
            lstSoundFiles.SelectedIndexChanged += lstSoundFiles_SelectedIndexChanged;
            lstSoundFiles.KeyDown += lstSoundFiles_KeyDown;
            // 
            // lblVolume
            // 
            lblVolume.AutoSize = true;
            lblVolume.Location = new System.Drawing.Point(12, 447);
            lblVolume.Name = "lblVolume";
            lblVolume.Size = new System.Drawing.Size(51, 17);
            lblVolume.TabIndex = 4;
            lblVolume.Text = "Volume";
            // 
            // hsbVolume
            // 
            hsbVolume.Location = new System.Drawing.Point(13, 474);
            hsbVolume.Maximum = 200;
            hsbVolume.Name = "hsbVolume";
            hsbVolume.Size = new System.Drawing.Size(120, 23);
            hsbVolume.TabIndex = 5;
            hsbVolume.Value = 100;
            hsbVolume.Scroll += hsbVolume_Scroll;
            // 
            // hsbPitch
            // 
            hsbPitch.Location = new System.Drawing.Point(147, 474);
            hsbPitch.Maximum = 500;
            hsbPitch.Name = "hsbPitch";
            hsbPitch.Size = new System.Drawing.Size(120, 23);
            hsbPitch.TabIndex = 7;
            hsbPitch.Value = 100;
            hsbPitch.Scroll += hsbPitch_Scroll;
            // 
            // lblPitch
            // 
            lblPitch.AutoSize = true;
            lblPitch.Location = new System.Drawing.Point(147, 447);
            lblPitch.Name = "lblPitch";
            lblPitch.Size = new System.Drawing.Size(35, 17);
            lblPitch.TabIndex = 6;
            lblPitch.Text = "Pitch";
            // 
            // btnPlay
            // 
            btnPlay.Location = new System.Drawing.Point(336, 474);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new System.Drawing.Size(65, 26);
            btnPlay.TabIndex = 8;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // trmUpdate
            // 
            trmUpdate.Interval = 1;
            trmUpdate.Tick += trmUpdate_Tick;
            // 
            // btnStop
            // 
            btnStop.Location = new System.Drawing.Point(407, 474);
            btnStop.Name = "btnStop";
            btnStop.Size = new System.Drawing.Size(65, 26);
            btnStop.TabIndex = 9;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.Location = new System.Drawing.Point(317, 447);
            lblLength.Name = "lblLength";
            lblLength.Size = new System.Drawing.Size(84, 17);
            lblLength.TabIndex = 10;
            lblLength.Text = "Length: 0.00s";
            // 
            // FrmSound
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(484, 511);
            Controls.Add(lblLength);
            Controls.Add(btnStop);
            Controls.Add(btnPlay);
            Controls.Add(hsbPitch);
            Controls.Add(lblPitch);
            Controls.Add(hsbVolume);
            Controls.Add(lblVolume);
            Controls.Add(lstSoundFiles);
            Controls.Add(btnDirectory);
            Controls.Add(txtDirectory);
            Controls.Add(lblDirectory);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmSound";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            Text = "FMOD Sound Player";
            FormClosing += FrmSound_FormClosing;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDirectory;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Button btnDirectory;
        private System.Windows.Forms.FolderBrowserDialog fbdDirectory;
        private System.Windows.Forms.ListBox lstSoundFiles;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.HScrollBar hsbVolume;
        private System.Windows.Forms.HScrollBar hsbPitch;
        private System.Windows.Forms.Label lblPitch;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Timer trmUpdate;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblLength;
    }
}


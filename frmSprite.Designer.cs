namespace SpriteEditor
{
    partial class frmSprite
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.tbcSprite = new System.Windows.Forms.TabControl();
            this.tabSprite = new System.Windows.Forms.TabPage();
            this.lblBaseFolder = new System.Windows.Forms.Label();
            this.btnBrowseFolder = new System.Windows.Forms.Button();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.btnTransColor = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.lstPoses = new System.Windows.Forms.ListBox();
            this.mnuPose = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.miCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.miPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.miRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPoses = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.tabPose = new System.Windows.Forms.TabPage();
            this.lstFrames = new System.Windows.Forms.ListBox();
            this.mnuFrame = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miAddFrame = new System.Windows.Forms.ToolStripMenuItem();
            this.miCopyFrame = new System.Windows.Forms.ToolStripMenuItem();
            this.miPasteFrame = new System.Windows.Forms.ToolStripMenuItem();
            this.miRemoveFrame = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFrames = new System.Windows.Forms.Label();
            this.txtBoundingBox = new System.Windows.Forms.TextBox();
            this.lblBoundingBox = new System.Windows.Forms.Label();
            this.txtRepeats = new System.Windows.Forms.TextBox();
            this.lblRepeats = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtPoseName = new System.Windows.Forms.TextBox();
            this.lblPoseName = new System.Windows.Forms.Label();
            this.tabFrame = new System.Windows.Forms.TabPage();
            this.btnNextFrame = new System.Windows.Forms.Button();
            this.btnPrevFrame = new System.Windows.Forms.Button();
            this.chkTween = new System.Windows.Forms.CheckBox();
            this.txtRectangle = new System.Windows.Forms.TextBox();
            this.lblRectangle = new System.Windows.Forms.Label();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.lblAngle = new System.Windows.Forms.Label();
            this.txtYMagnification = new System.Windows.Forms.TextBox();
            this.lblYMagnification = new System.Windows.Forms.Label();
            this.txtXMagnification = new System.Windows.Forms.TextBox();
            this.lblXMagnification = new System.Windows.Forms.Label();
            this.txtFrameDuration = new System.Windows.Forms.TextBox();
            this.lblFrameDuration = new System.Windows.Forms.Label();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miNew = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.miSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miFull = new System.Windows.Forms.ToolStripMenuItem();
            this.miPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.miAnimated = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miShowSrcRect = new System.Windows.Forms.ToolStripMenuItem();
            this.miShowBoundingBox = new System.Windows.Forms.ToolStripMenuItem();
            this.miShowGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.miGridSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stlMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.ofdSprite = new System.Windows.Forms.OpenFileDialog();
            this.sfdSprite = new System.Windows.Forms.SaveFileDialog();
            this.cdTransparentColor = new System.Windows.Forms.ColorDialog();
            this.fbdBase = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlSprite = new SpriteEditor.FlickerFreePanel();
            this.tbcSprite.SuspendLayout();
            this.tabSprite.SuspendLayout();
            this.mnuPose.SuspendLayout();
            this.tabPose.SuspendLayout();
            this.mnuFrame.SuspendLayout();
            this.tabFrame.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Enabled = true;
            this.tmrUpdate.Interval = 1;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // tbcSprite
            // 
            this.tbcSprite.Controls.Add(this.tabSprite);
            this.tbcSprite.Controls.Add(this.tabPose);
            this.tbcSprite.Controls.Add(this.tabFrame);
            this.tbcSprite.Location = new System.Drawing.Point(498, 27);
            this.tbcSprite.Multiline = true;
            this.tbcSprite.Name = "tbcSprite";
            this.tbcSprite.SelectedIndex = 0;
            this.tbcSprite.Size = new System.Drawing.Size(190, 377);
            this.tbcSprite.TabIndex = 1;
            // 
            // tabSprite
            // 
            this.tabSprite.BackColor = System.Drawing.Color.Transparent;
            this.tabSprite.Controls.Add(this.lblBaseFolder);
            this.tabSprite.Controls.Add(this.btnBrowseFolder);
            this.tabSprite.Controls.Add(this.txtBase);
            this.tabSprite.Controls.Add(this.btnTransColor);
            this.tabSprite.Controls.Add(this.lblColor);
            this.tabSprite.Controls.Add(this.btnBrowseImage);
            this.tabSprite.Controls.Add(this.lstPoses);
            this.tabSprite.Controls.Add(this.lblPoses);
            this.tabSprite.Controls.Add(this.lblImage);
            this.tabSprite.Controls.Add(this.txtImage);
            this.tabSprite.Location = new System.Drawing.Point(4, 22);
            this.tabSprite.Name = "tabSprite";
            this.tabSprite.Padding = new System.Windows.Forms.Padding(3);
            this.tabSprite.Size = new System.Drawing.Size(182, 351);
            this.tabSprite.TabIndex = 0;
            this.tabSprite.Text = "Sprite";
            // 
            // lblBaseFolder
            // 
            this.lblBaseFolder.AutoSize = true;
            this.lblBaseFolder.Location = new System.Drawing.Point(6, 6);
            this.lblBaseFolder.Name = "lblBaseFolder";
            this.lblBaseFolder.Size = new System.Drawing.Size(63, 13);
            this.lblBaseFolder.TabIndex = 16;
            this.lblBaseFolder.Text = "Base Folder";
            // 
            // btnBrowseFolder
            // 
            this.btnBrowseFolder.Location = new System.Drawing.Point(145, 22);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new System.Drawing.Size(31, 20);
            this.btnBrowseFolder.TabIndex = 15;
            this.btnBrowseFolder.Text = "...";
            this.btnBrowseFolder.UseVisualStyleBackColor = true;
            this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
            // 
            // txtBase
            // 
            this.txtBase.Enabled = false;
            this.txtBase.Location = new System.Drawing.Point(9, 22);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(130, 20);
            this.txtBase.TabIndex = 14;
            // 
            // btnTransColor
            // 
            this.btnTransColor.Location = new System.Drawing.Point(103, 87);
            this.btnTransColor.Name = "btnTransColor";
            this.btnTransColor.Size = new System.Drawing.Size(19, 18);
            this.btnTransColor.TabIndex = 13;
            this.btnTransColor.UseVisualStyleBackColor = false;
            this.btnTransColor.Click += new System.EventHandler(this.btnTransColor_Click);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(6, 92);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(91, 13);
            this.lblColor.TabIndex = 12;
            this.lblColor.Text = "Transparent Color";
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Location = new System.Drawing.Point(145, 60);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(31, 20);
            this.btnBrowseImage.TabIndex = 11;
            this.btnBrowseImage.Text = "...";
            this.btnBrowseImage.UseVisualStyleBackColor = true;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // lstPoses
            // 
            this.lstPoses.ContextMenuStrip = this.mnuPose;
            this.lstPoses.FormattingEnabled = true;
            this.lstPoses.Location = new System.Drawing.Point(9, 146);
            this.lstPoses.Name = "lstPoses";
            this.lstPoses.Size = new System.Drawing.Size(167, 199);
            this.lstPoses.TabIndex = 5;
            this.lstPoses.SelectedIndexChanged += new System.EventHandler(this.lstPoses_SelectedIndexChanged);
            // 
            // mnuPose
            // 
            this.mnuPose.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAdd,
            this.miCopy,
            this.miPaste,
            this.miRemove});
            this.mnuPose.Name = "mnuPose";
            this.mnuPose.Size = new System.Drawing.Size(118, 92);
            this.mnuPose.Opening += new System.ComponentModel.CancelEventHandler(this.mnuPose_Opening);
            // 
            // miAdd
            // 
            this.miAdd.Name = "miAdd";
            this.miAdd.Size = new System.Drawing.Size(117, 22);
            this.miAdd.Text = "Add";
            this.miAdd.Click += new System.EventHandler(this.miAdd_Click);
            // 
            // miCopy
            // 
            this.miCopy.Enabled = false;
            this.miCopy.Name = "miCopy";
            this.miCopy.Size = new System.Drawing.Size(117, 22);
            this.miCopy.Text = "Copy";
            this.miCopy.Click += new System.EventHandler(this.miCopy_Click);
            // 
            // miPaste
            // 
            this.miPaste.Enabled = false;
            this.miPaste.Name = "miPaste";
            this.miPaste.Size = new System.Drawing.Size(117, 22);
            this.miPaste.Text = "Paste";
            this.miPaste.Click += new System.EventHandler(this.miPaste_Click);
            // 
            // miRemove
            // 
            this.miRemove.Name = "miRemove";
            this.miRemove.Size = new System.Drawing.Size(117, 22);
            this.miRemove.Text = "Remove";
            this.miRemove.Click += new System.EventHandler(this.miRemove_Click);
            // 
            // lblPoses
            // 
            this.lblPoses.AutoSize = true;
            this.lblPoses.Location = new System.Drawing.Point(6, 130);
            this.lblPoses.Name = "lblPoses";
            this.lblPoses.Size = new System.Drawing.Size(36, 13);
            this.lblPoses.TabIndex = 4;
            this.lblPoses.Text = "Poses";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(6, 45);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(36, 13);
            this.lblImage.TabIndex = 1;
            this.lblImage.Text = "Image";
            // 
            // txtImage
            // 
            this.txtImage.Enabled = false;
            this.txtImage.Location = new System.Drawing.Point(9, 61);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(130, 20);
            this.txtImage.TabIndex = 0;
            // 
            // tabPose
            // 
            this.tabPose.BackColor = System.Drawing.Color.Transparent;
            this.tabPose.Controls.Add(this.lstFrames);
            this.tabPose.Controls.Add(this.lblFrames);
            this.tabPose.Controls.Add(this.txtBoundingBox);
            this.tabPose.Controls.Add(this.lblBoundingBox);
            this.tabPose.Controls.Add(this.txtRepeats);
            this.tabPose.Controls.Add(this.lblRepeats);
            this.tabPose.Controls.Add(this.txtDuration);
            this.tabPose.Controls.Add(this.lblDuration);
            this.tabPose.Controls.Add(this.txtPoseName);
            this.tabPose.Controls.Add(this.lblPoseName);
            this.tabPose.Location = new System.Drawing.Point(4, 22);
            this.tabPose.Name = "tabPose";
            this.tabPose.Padding = new System.Windows.Forms.Padding(3);
            this.tabPose.Size = new System.Drawing.Size(182, 351);
            this.tabPose.TabIndex = 1;
            this.tabPose.Text = "Pose";
            // 
            // lstFrames
            // 
            this.lstFrames.AllowDrop = true;
            this.lstFrames.ContextMenuStrip = this.mnuFrame;
            this.lstFrames.FormattingEnabled = true;
            this.lstFrames.Location = new System.Drawing.Point(9, 175);
            this.lstFrames.Name = "lstFrames";
            this.lstFrames.Size = new System.Drawing.Size(167, 160);
            this.lstFrames.TabIndex = 12;
            this.lstFrames.SelectedIndexChanged += new System.EventHandler(this.lstFrames_SelectedIndexChanged);
            this.lstFrames.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstFrames_DragDrop);
            this.lstFrames.DragOver += new System.Windows.Forms.DragEventHandler(this.lstFrames_DragOver);
            this.lstFrames.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstFrames_MouseDown);
            // 
            // mnuFrame
            // 
            this.mnuFrame.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAddFrame,
            this.miCopyFrame,
            this.miPasteFrame,
            this.miRemoveFrame});
            this.mnuFrame.Name = "mnuPose";
            this.mnuFrame.Size = new System.Drawing.Size(118, 92);
            this.mnuFrame.Opening += new System.ComponentModel.CancelEventHandler(this.mnuFrame_Opening);
            // 
            // miAddFrame
            // 
            this.miAddFrame.Name = "miAddFrame";
            this.miAddFrame.Size = new System.Drawing.Size(117, 22);
            this.miAddFrame.Text = "Add";
            this.miAddFrame.Click += new System.EventHandler(this.miAddFrame_Click);
            // 
            // miCopyFrame
            // 
            this.miCopyFrame.Enabled = false;
            this.miCopyFrame.Name = "miCopyFrame";
            this.miCopyFrame.Size = new System.Drawing.Size(117, 22);
            this.miCopyFrame.Text = "Copy";
            this.miCopyFrame.Click += new System.EventHandler(this.miCopyFrame_Click);
            // 
            // miPasteFrame
            // 
            this.miPasteFrame.Enabled = false;
            this.miPasteFrame.Name = "miPasteFrame";
            this.miPasteFrame.Size = new System.Drawing.Size(117, 22);
            this.miPasteFrame.Text = "Paste";
            this.miPasteFrame.Click += new System.EventHandler(this.miPasteFrame_Click);
            // 
            // miRemoveFrame
            // 
            this.miRemoveFrame.Name = "miRemoveFrame";
            this.miRemoveFrame.Size = new System.Drawing.Size(117, 22);
            this.miRemoveFrame.Text = "Remove";
            this.miRemoveFrame.Click += new System.EventHandler(this.miRemoveFrame_Click);
            // 
            // lblFrames
            // 
            this.lblFrames.AutoSize = true;
            this.lblFrames.Location = new System.Drawing.Point(6, 159);
            this.lblFrames.Name = "lblFrames";
            this.lblFrames.Size = new System.Drawing.Size(41, 13);
            this.lblFrames.TabIndex = 11;
            this.lblFrames.Text = "Frames";
            // 
            // txtBoundingBox
            // 
            this.txtBoundingBox.Location = new System.Drawing.Point(9, 136);
            this.txtBoundingBox.Name = "txtBoundingBox";
            this.txtBoundingBox.Size = new System.Drawing.Size(167, 20);
            this.txtBoundingBox.TabIndex = 9;
            this.txtBoundingBox.TextChanged += new System.EventHandler(this.txtBoundingBox_TextChanged);
            // 
            // lblBoundingBox
            // 
            this.lblBoundingBox.AutoSize = true;
            this.lblBoundingBox.Location = new System.Drawing.Point(6, 120);
            this.lblBoundingBox.Name = "lblBoundingBox";
            this.lblBoundingBox.Size = new System.Drawing.Size(73, 13);
            this.lblBoundingBox.TabIndex = 8;
            this.lblBoundingBox.Text = "Bounding Box";
            // 
            // txtRepeats
            // 
            this.txtRepeats.Location = new System.Drawing.Point(9, 97);
            this.txtRepeats.Name = "txtRepeats";
            this.txtRepeats.Size = new System.Drawing.Size(167, 20);
            this.txtRepeats.TabIndex = 7;
            this.txtRepeats.TextChanged += new System.EventHandler(this.txtRepeats_TextChanged);
            // 
            // lblRepeats
            // 
            this.lblRepeats.AutoSize = true;
            this.lblRepeats.Location = new System.Drawing.Point(6, 81);
            this.lblRepeats.Name = "lblRepeats";
            this.lblRepeats.Size = new System.Drawing.Size(47, 13);
            this.lblRepeats.TabIndex = 6;
            this.lblRepeats.Text = "Repeats";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(9, 58);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(167, 20);
            this.txtDuration.TabIndex = 5;
            this.txtDuration.TextChanged += new System.EventHandler(this.txtDuration_TextChanged);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(6, 42);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(47, 13);
            this.lblDuration.TabIndex = 4;
            this.lblDuration.Text = "Duration";
            // 
            // txtPoseName
            // 
            this.txtPoseName.Location = new System.Drawing.Point(9, 19);
            this.txtPoseName.Name = "txtPoseName";
            this.txtPoseName.Size = new System.Drawing.Size(167, 20);
            this.txtPoseName.TabIndex = 3;
            this.txtPoseName.TextChanged += new System.EventHandler(this.txtPoseName_TextChanged);
            // 
            // lblPoseName
            // 
            this.lblPoseName.AutoSize = true;
            this.lblPoseName.Location = new System.Drawing.Point(6, 3);
            this.lblPoseName.Name = "lblPoseName";
            this.lblPoseName.Size = new System.Drawing.Size(35, 13);
            this.lblPoseName.TabIndex = 2;
            this.lblPoseName.Text = "Name";
            // 
            // tabFrame
            // 
            this.tabFrame.BackColor = System.Drawing.Color.Transparent;
            this.tabFrame.Controls.Add(this.btnNextFrame);
            this.tabFrame.Controls.Add(this.btnPrevFrame);
            this.tabFrame.Controls.Add(this.chkTween);
            this.tabFrame.Controls.Add(this.txtRectangle);
            this.tabFrame.Controls.Add(this.lblRectangle);
            this.tabFrame.Controls.Add(this.txtAngle);
            this.tabFrame.Controls.Add(this.lblAngle);
            this.tabFrame.Controls.Add(this.txtYMagnification);
            this.tabFrame.Controls.Add(this.lblYMagnification);
            this.tabFrame.Controls.Add(this.txtXMagnification);
            this.tabFrame.Controls.Add(this.lblXMagnification);
            this.tabFrame.Controls.Add(this.txtFrameDuration);
            this.tabFrame.Controls.Add(this.lblFrameDuration);
            this.tabFrame.Location = new System.Drawing.Point(4, 22);
            this.tabFrame.Name = "tabFrame";
            this.tabFrame.Size = new System.Drawing.Size(182, 351);
            this.tabFrame.TabIndex = 2;
            this.tabFrame.Text = "Frame";
            // 
            // btnNextFrame
            // 
            this.btnNextFrame.Location = new System.Drawing.Point(94, 258);
            this.btnNextFrame.Name = "btnNextFrame";
            this.btnNextFrame.Size = new System.Drawing.Size(82, 23);
            this.btnNextFrame.TabIndex = 16;
            this.btnNextFrame.Text = "Next Frame";
            this.btnNextFrame.UseVisualStyleBackColor = true;
            this.btnNextFrame.Click += new System.EventHandler(this.btnNextFrame_Click);
            // 
            // btnPrevFrame
            // 
            this.btnPrevFrame.Location = new System.Drawing.Point(9, 258);
            this.btnPrevFrame.Name = "btnPrevFrame";
            this.btnPrevFrame.Size = new System.Drawing.Size(82, 23);
            this.btnPrevFrame.TabIndex = 15;
            this.btnPrevFrame.Text = "Prev. Frame";
            this.btnPrevFrame.UseVisualStyleBackColor = true;
            this.btnPrevFrame.Click += new System.EventHandler(this.btnPrevFrame_Click);
            // 
            // chkTween
            // 
            this.chkTween.AutoSize = true;
            this.chkTween.Location = new System.Drawing.Point(3, 6);
            this.chkTween.Name = "chkTween";
            this.chkTween.Size = new System.Drawing.Size(88, 17);
            this.chkTween.TabIndex = 14;
            this.chkTween.Text = "TweenFrame";
            this.chkTween.UseVisualStyleBackColor = true;
            this.chkTween.CheckedChanged += new System.EventHandler(this.chkTween_CheckedChanged);
            // 
            // txtRectangle
            // 
            this.txtRectangle.Location = new System.Drawing.Point(9, 198);
            this.txtRectangle.Name = "txtRectangle";
            this.txtRectangle.Size = new System.Drawing.Size(167, 20);
            this.txtRectangle.TabIndex = 12;
            this.txtRectangle.TextChanged += new System.EventHandler(this.txtRectangle_TextChanged);
            // 
            // lblRectangle
            // 
            this.lblRectangle.AutoSize = true;
            this.lblRectangle.Location = new System.Drawing.Point(6, 182);
            this.lblRectangle.Name = "lblRectangle";
            this.lblRectangle.Size = new System.Drawing.Size(93, 13);
            this.lblRectangle.TabIndex = 11;
            this.lblRectangle.Text = "Source Rectangle";
            // 
            // txtAngle
            // 
            this.txtAngle.Location = new System.Drawing.Point(9, 159);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(167, 20);
            this.txtAngle.TabIndex = 10;
            this.txtAngle.TextChanged += new System.EventHandler(this.txtAngle_TextChanged);
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Location = new System.Drawing.Point(6, 143);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(34, 13);
            this.lblAngle.TabIndex = 9;
            this.lblAngle.Text = "Angle";
            // 
            // txtYMagnification
            // 
            this.txtYMagnification.Location = new System.Drawing.Point(9, 120);
            this.txtYMagnification.Name = "txtYMagnification";
            this.txtYMagnification.Size = new System.Drawing.Size(167, 20);
            this.txtYMagnification.TabIndex = 8;
            this.txtYMagnification.TextChanged += new System.EventHandler(this.txtYMagnification_TextChanged);
            // 
            // lblYMagnification
            // 
            this.lblYMagnification.AutoSize = true;
            this.lblYMagnification.Location = new System.Drawing.Point(6, 104);
            this.lblYMagnification.Name = "lblYMagnification";
            this.lblYMagnification.Size = new System.Drawing.Size(80, 13);
            this.lblYMagnification.TabIndex = 7;
            this.lblYMagnification.Text = "Y Magnification";
            // 
            // txtXMagnification
            // 
            this.txtXMagnification.Location = new System.Drawing.Point(9, 81);
            this.txtXMagnification.Name = "txtXMagnification";
            this.txtXMagnification.Size = new System.Drawing.Size(167, 20);
            this.txtXMagnification.TabIndex = 6;
            this.txtXMagnification.TextChanged += new System.EventHandler(this.txtXMagnification_TextChanged);
            // 
            // lblXMagnification
            // 
            this.lblXMagnification.AutoSize = true;
            this.lblXMagnification.Location = new System.Drawing.Point(6, 65);
            this.lblXMagnification.Name = "lblXMagnification";
            this.lblXMagnification.Size = new System.Drawing.Size(80, 13);
            this.lblXMagnification.TabIndex = 5;
            this.lblXMagnification.Text = "X Magnification";
            // 
            // txtFrameDuration
            // 
            this.txtFrameDuration.Location = new System.Drawing.Point(9, 42);
            this.txtFrameDuration.Name = "txtFrameDuration";
            this.txtFrameDuration.Size = new System.Drawing.Size(167, 20);
            this.txtFrameDuration.TabIndex = 4;
            this.txtFrameDuration.TextChanged += new System.EventHandler(this.txtFrameDuration_TextChanged);
            // 
            // lblFrameDuration
            // 
            this.lblFrameDuration.AutoSize = true;
            this.lblFrameDuration.Location = new System.Drawing.Point(6, 26);
            this.lblFrameDuration.Name = "lblFrameDuration";
            this.lblFrameDuration.Size = new System.Drawing.Size(47, 13);
            this.lblFrameDuration.TabIndex = 3;
            this.lblFrameDuration.Text = "Duration";
            // 
            // ofdImage
            // 
            this.ofdImage.Filter = "Image files|*.png;*.jpg;*.gif;*.bmp";
            this.ofdImage.Title = "Select sprite image";
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.viewToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(698, 24);
            this.mnuMain.TabIndex = 7;
            this.mnuMain.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNew,
            this.miOpen,
            this.miSave,
            this.miSaveAs});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(37, 20);
            this.miFile.Text = "&File";
            // 
            // miNew
            // 
            this.miNew.Name = "miNew";
            this.miNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.miNew.Size = new System.Drawing.Size(155, 22);
            this.miNew.Text = "&New";
            this.miNew.Click += new System.EventHandler(this.miNew_Click);
            // 
            // miOpen
            // 
            this.miOpen.Name = "miOpen";
            this.miOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.miOpen.Size = new System.Drawing.Size(155, 22);
            this.miOpen.Text = "&Open...";
            this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
            // 
            // miSave
            // 
            this.miSave.Name = "miSave";
            this.miSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.miSave.Size = new System.Drawing.Size(155, 22);
            this.miSave.Text = "&Save";
            this.miSave.Click += new System.EventHandler(this.miSave_Click);
            // 
            // miSaveAs
            // 
            this.miSaveAs.Name = "miSaveAs";
            this.miSaveAs.Size = new System.Drawing.Size(155, 22);
            this.miSaveAs.Text = "Save &As...";
            this.miSaveAs.Click += new System.EventHandler(this.miSaveAs_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFull,
            this.miPreview,
            this.miAnimated,
            this.toolStripSeparator1,
            this.miShowSrcRect,
            this.miShowBoundingBox,
            this.miShowGrid,
            this.miGridSettings});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // miFull
            // 
            this.miFull.Checked = true;
            this.miFull.CheckOnClick = true;
            this.miFull.CheckState = System.Windows.Forms.CheckState.Checked;
            this.miFull.Name = "miFull";
            this.miFull.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.miFull.Size = new System.Drawing.Size(223, 22);
            this.miFull.Text = "&Full Sprite View";
            this.miFull.Click += new System.EventHandler(this.miFull_Click);
            // 
            // miPreview
            // 
            this.miPreview.CheckOnClick = true;
            this.miPreview.Name = "miPreview";
            this.miPreview.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.miPreview.Size = new System.Drawing.Size(223, 22);
            this.miPreview.Text = "&Non-Animated Preview";
            this.miPreview.Click += new System.EventHandler(this.miPreview_Click);
            // 
            // miAnimated
            // 
            this.miAnimated.CheckOnClick = true;
            this.miAnimated.Name = "miAnimated";
            this.miAnimated.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.miAnimated.Size = new System.Drawing.Size(223, 22);
            this.miAnimated.Text = "&Animated Preview";
            this.miAnimated.Click += new System.EventHandler(this.miAnimated_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(220, 6);
            // 
            // miShowSrcRect
            // 
            this.miShowSrcRect.CheckOnClick = true;
            this.miShowSrcRect.Name = "miShowSrcRect";
            this.miShowSrcRect.Size = new System.Drawing.Size(223, 22);
            this.miShowSrcRect.Text = "Show &Source Rect";
            this.miShowSrcRect.CheckedChanged += new System.EventHandler(this.miShowSrcRect_CheckedChanged);
            // 
            // miShowBoundingBox
            // 
            this.miShowBoundingBox.CheckOnClick = true;
            this.miShowBoundingBox.Name = "miShowBoundingBox";
            this.miShowBoundingBox.Size = new System.Drawing.Size(223, 22);
            this.miShowBoundingBox.Text = "Show &Bounding Box";
            this.miShowBoundingBox.CheckedChanged += new System.EventHandler(this.miShowBoundingBox_CheckChanged);
            // 
            // miShowGrid
            // 
            this.miShowGrid.CheckOnClick = true;
            this.miShowGrid.Name = "miShowGrid";
            this.miShowGrid.Size = new System.Drawing.Size(223, 22);
            this.miShowGrid.Text = "Show Grid";
            this.miShowGrid.CheckedChanged += new System.EventHandler(this.miShowGrid_CheckChanged);
            // 
            // miGridSettings
            // 
            this.miGridSettings.Name = "miGridSettings";
            this.miGridSettings.Size = new System.Drawing.Size(223, 22);
            this.miGridSettings.Text = "Grid Settings...";
            this.miGridSettings.Click += new System.EventHandler(this.miGridSettings_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stlMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 407);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(698, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "stsMain";
            // 
            // stlMessage
            // 
            this.stlMessage.Name = "stlMessage";
            this.stlMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // ofdSprite
            // 
            this.ofdSprite.Filter = "Sprite XML Files|*.spr";
            this.ofdSprite.Title = "Select sprite file";
            // 
            // sfdSprite
            // 
            this.sfdSprite.FileName = "sprite.spr";
            this.sfdSprite.Filter = "Sprite XML Files|*.spr";
            this.sfdSprite.Title = "Save sprite file as...";
            // 
            // pnlSprite
            // 
            this.pnlSprite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSprite.Location = new System.Drawing.Point(12, 27);
            this.pnlSprite.Name = "pnlSprite";
            this.pnlSprite.Size = new System.Drawing.Size(480, 320);
            this.pnlSprite.TabIndex = 0;
            this.pnlSprite.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSprite_Paint);
            // 
            // frmSprite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 429);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.pnlSprite);
            this.Controls.Add(this.tbcSprite);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSprite";
            this.Text = "Sprite Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSprite_FormClosed);
            this.Load += new System.EventHandler(this.frmSprite_Load);
            this.tbcSprite.ResumeLayout(false);
            this.tabSprite.ResumeLayout(false);
            this.tabSprite.PerformLayout();
            this.mnuPose.ResumeLayout(false);
            this.tabPose.ResumeLayout(false);
            this.tabPose.PerformLayout();
            this.mnuFrame.ResumeLayout(false);
            this.tabFrame.ResumeLayout(false);
            this.tabFrame.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlickerFreePanel pnlSprite;
        private System.Windows.Forms.Timer tmrUpdate;
        private System.Windows.Forms.TabControl tbcSprite;
        private System.Windows.Forms.TabPage tabSprite;
        private System.Windows.Forms.TabPage tabPose;
        private System.Windows.Forms.TabPage tabFrame;
        private System.Windows.Forms.ListBox lstPoses;
        private System.Windows.Forms.Label lblPoses;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.TextBox txtPoseName;
        private System.Windows.Forms.Label lblPoseName;
        private System.Windows.Forms.TextBox txtRepeats;
        private System.Windows.Forms.Label lblRepeats;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblFrames;
        private System.Windows.Forms.TextBox txtBoundingBox;
        private System.Windows.Forms.Label lblBoundingBox;
        private System.Windows.Forms.ListBox lstFrames;
        private System.Windows.Forms.TextBox txtFrameDuration;
        private System.Windows.Forms.Label lblFrameDuration;
        private System.Windows.Forms.TextBox txtYMagnification;
        private System.Windows.Forms.Label lblYMagnification;
        private System.Windows.Forms.TextBox txtXMagnification;
        private System.Windows.Forms.Label lblXMagnification;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.CheckBox chkTween;
        private System.Windows.Forms.TextBox txtRectangle;
        private System.Windows.Forms.Label lblRectangle;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.OpenFileDialog ofdImage;
        private System.Windows.Forms.ContextMenuStrip mnuPose;
        private System.Windows.Forms.ToolStripMenuItem miAdd;
        private System.Windows.Forms.ToolStripMenuItem miRemove;
        private System.Windows.Forms.Button btnNextFrame;
        private System.Windows.Forms.Button btnPrevFrame;
        private System.Windows.Forms.ContextMenuStrip mnuFrame;
        private System.Windows.Forms.ToolStripMenuItem miAddFrame;
        private System.Windows.Forms.ToolStripMenuItem miRemoveFrame;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miNew;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miOpen;
        private System.Windows.Forms.ToolStripMenuItem miSave;
        private System.Windows.Forms.ToolStripMenuItem miSaveAs;
        private System.Windows.Forms.ToolStripMenuItem miFull;
        private System.Windows.Forms.ToolStripMenuItem miPreview;
        private System.Windows.Forms.ToolStripMenuItem miAnimated;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stlMessage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miShowSrcRect;
        private System.Windows.Forms.ToolStripMenuItem miShowBoundingBox;
        private System.Windows.Forms.OpenFileDialog ofdSprite;
        private System.Windows.Forms.SaveFileDialog sfdSprite;
        private System.Windows.Forms.ToolStripMenuItem miShowGrid;
        private System.Windows.Forms.ToolStripMenuItem miGridSettings;
        private System.Windows.Forms.ToolStripMenuItem miCopy;
        private System.Windows.Forms.ToolStripMenuItem miPaste;
        private System.Windows.Forms.ToolStripMenuItem miCopyFrame;
        private System.Windows.Forms.ToolStripMenuItem miPasteFrame;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Button btnTransColor;
        private System.Windows.Forms.ColorDialog cdTransparentColor;
        private System.Windows.Forms.Label lblBaseFolder;
        private System.Windows.Forms.Button btnBrowseFolder;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.FolderBrowserDialog fbdBase;
    }
}


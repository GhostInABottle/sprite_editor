namespace SpriteEditor
{
    partial class FrmSprite
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tmrUpdate = new System.Windows.Forms.Timer(components);
            tbcSprite = new System.Windows.Forms.TabControl();
            tabSprite = new System.Windows.Forms.TabPage();
            cbDefaultPose = new System.Windows.Forms.ComboBox();
            lblDefaultPose = new System.Windows.Forms.Label();
            lblBaseFolder = new System.Windows.Forms.Label();
            btnBrowseFolder = new System.Windows.Forms.Button();
            txtBase = new System.Windows.Forms.TextBox();
            btnTransColor = new System.Windows.Forms.Button();
            lblColor = new System.Windows.Forms.Label();
            btnBrowseImage = new System.Windows.Forms.Button();
            lstPoses = new System.Windows.Forms.ListBox();
            mnuPose = new System.Windows.Forms.ContextMenuStrip(components);
            miAdd = new System.Windows.Forms.ToolStripMenuItem();
            miCopy = new System.Windows.Forms.ToolStripMenuItem();
            miPaste = new System.Windows.Forms.ToolStripMenuItem();
            miPasteCsv = new System.Windows.Forms.ToolStripMenuItem();
            miRemove = new System.Windows.Forms.ToolStripMenuItem();
            miOffsetFrames = new System.Windows.Forms.ToolStripMenuItem();
            lblPoses = new System.Windows.Forms.Label();
            lblImage = new System.Windows.Forms.Label();
            txtImage = new System.Windows.Forms.TextBox();
            tabPose = new System.Windows.Forms.TabPage();
            txtCompletionFrame = new System.Windows.Forms.TextBox();
            chkRequireCompletion = new System.Windows.Forms.CheckBox();
            btnPoseTransColor = new System.Windows.Forms.Button();
            lblPoseColor = new System.Windows.Forms.Label();
            btnBrowsePoseImage = new System.Windows.Forms.Button();
            lblPoseImage = new System.Windows.Forms.Label();
            txtPoseImage = new System.Windows.Forms.TextBox();
            txtOrigin = new System.Windows.Forms.TextBox();
            lblOrigin = new System.Windows.Forms.Label();
            cbState = new System.Windows.Forms.ComboBox();
            lblState = new System.Windows.Forms.Label();
            cbDirection = new System.Windows.Forms.ComboBox();
            lblDirection = new System.Windows.Forms.Label();
            lstFrames = new System.Windows.Forms.ListBox();
            mnuFrame = new System.Windows.Forms.ContextMenuStrip(components);
            miAddFrame = new System.Windows.Forms.ToolStripMenuItem();
            miCopyFrame = new System.Windows.Forms.ToolStripMenuItem();
            miPasteFrame = new System.Windows.Forms.ToolStripMenuItem();
            miRemoveFrame = new System.Windows.Forms.ToolStripMenuItem();
            miClearFrames = new System.Windows.Forms.ToolStripMenuItem();
            miAddMultiple = new System.Windows.Forms.ToolStripMenuItem();
            miOffsetFrame = new System.Windows.Forms.ToolStripMenuItem();
            lblFrames = new System.Windows.Forms.Label();
            txtBoundingBox = new System.Windows.Forms.TextBox();
            lblBoundingBox = new System.Windows.Forms.Label();
            txtRepeats = new System.Windows.Forms.TextBox();
            lblRepeats = new System.Windows.Forms.Label();
            txtDuration = new System.Windows.Forms.TextBox();
            lblDuration = new System.Windows.Forms.Label();
            txtPoseName = new System.Windows.Forms.TextBox();
            lblPoseName = new System.Windows.Forms.Label();
            tabFrame = new System.Windows.Forms.TabPage();
            txtFrameMarker = new System.Windows.Forms.TextBox();
            lblFrameMarker = new System.Windows.Forms.Label();
            txtRemoveSound = new System.Windows.Forms.Button();
            txtVolume = new System.Windows.Forms.TextBox();
            lblVolume = new System.Windows.Forms.Label();
            txtPitch = new System.Windows.Forms.TextBox();
            lblPitch = new System.Windows.Forms.Label();
            lblFrameNumber = new System.Windows.Forms.Label();
            btnBrowseSound = new System.Windows.Forms.Button();
            lblSound = new System.Windows.Forms.Label();
            txtSound = new System.Windows.Forms.TextBox();
            txtOpacity = new System.Windows.Forms.TextBox();
            lblOpacity = new System.Windows.Forms.Label();
            btnFrameTransColor = new System.Windows.Forms.Button();
            lblFrameColor = new System.Windows.Forms.Label();
            btnBrowseFrameImage = new System.Windows.Forms.Button();
            lblFrameImage = new System.Windows.Forms.Label();
            txtFrameImage = new System.Windows.Forms.TextBox();
            btnNextFrame = new System.Windows.Forms.Button();
            btnPrevFrame = new System.Windows.Forms.Button();
            chkTween = new System.Windows.Forms.CheckBox();
            txtRectangle = new System.Windows.Forms.TextBox();
            lblRectangle = new System.Windows.Forms.Label();
            txtAngle = new System.Windows.Forms.TextBox();
            lblAngle = new System.Windows.Forms.Label();
            txtMagnification = new System.Windows.Forms.TextBox();
            lblMagnification = new System.Windows.Forms.Label();
            txtFrameDuration = new System.Windows.Forms.TextBox();
            lblFrameDuration = new System.Windows.Forms.Label();
            ofdImage = new System.Windows.Forms.OpenFileDialog();
            mnuMain = new System.Windows.Forms.MenuStrip();
            miFile = new System.Windows.Forms.ToolStripMenuItem();
            miNew = new System.Windows.Forms.ToolStripMenuItem();
            miOpen = new System.Windows.Forms.ToolStripMenuItem();
            miSave = new System.Windows.Forms.ToolStripMenuItem();
            miSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            miAutoReload = new System.Windows.Forms.ToolStripMenuItem();
            miCheckEdges = new System.Windows.Forms.ToolStripMenuItem();
            miRecentFiles = new System.Windows.Forms.ToolStripMenuItem();
            miView = new System.Windows.Forms.ToolStripMenuItem();
            miFull = new System.Windows.Forms.ToolStripMenuItem();
            miPreview = new System.Windows.Forms.ToolStripMenuItem();
            miAnimated = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            miShowSrcRect = new System.Windows.Forms.ToolStripMenuItem();
            miShowBoundingBox = new System.Windows.Forms.ToolStripMenuItem();
            miTransparent = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            miShowGrid = new System.Windows.Forms.ToolStripMenuItem();
            miGridSelection = new System.Windows.Forms.ToolStripMenuItem();
            miGridSettings = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            miMagnification = new System.Windows.Forms.ToolStripMenuItem();
            miMagnification50 = new System.Windows.Forms.ToolStripMenuItem();
            miMagnification100 = new System.Windows.Forms.ToolStripMenuItem();
            miMagnification200 = new System.Windows.Forms.ToolStripMenuItem();
            miMagnification300 = new System.Windows.Forms.ToolStripMenuItem();
            miMagnification400 = new System.Windows.Forms.ToolStripMenuItem();
            miMagnification800 = new System.Windows.Forms.ToolStripMenuItem();
            miMagnification1600 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            miMagnificationZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            miMagnificationZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            stlMessage = new System.Windows.Forms.ToolStripStatusLabel();
            ofdSprite = new System.Windows.Forms.OpenFileDialog();
            sfdSprite = new System.Windows.Forms.SaveFileDialog();
            cdTransparentColor = new System.Windows.Forms.ColorDialog();
            fbdBase = new System.Windows.Forms.FolderBrowserDialog();
            ofdSound = new System.Windows.Forms.OpenFileDialog();
            fswUpdatedImageWatcher = new System.IO.FileSystemWatcher();
            pnlSprite = new FlickerFreePanel();
            tbcSprite.SuspendLayout();
            tabSprite.SuspendLayout();
            mnuPose.SuspendLayout();
            tabPose.SuspendLayout();
            mnuFrame.SuspendLayout();
            tabFrame.SuspendLayout();
            mnuMain.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fswUpdatedImageWatcher).BeginInit();
            SuspendLayout();
            // 
            // tmrUpdate
            // 
            tmrUpdate.Enabled = true;
            tmrUpdate.Interval = 1;
            tmrUpdate.Tick += tmrUpdate_Tick;
            // 
            // tbcSprite
            // 
            tbcSprite.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            tbcSprite.Controls.Add(tabSprite);
            tbcSprite.Controls.Add(tabPose);
            tbcSprite.Controls.Add(tabFrame);
            tbcSprite.Location = new System.Drawing.Point(883, 31);
            tbcSprite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbcSprite.Multiline = true;
            tbcSprite.Name = "tbcSprite";
            tbcSprite.SelectedIndex = 0;
            tbcSprite.Size = new System.Drawing.Size(280, 767);
            tbcSprite.TabIndex = 1;
            // 
            // tabSprite
            // 
            tabSprite.BackColor = System.Drawing.Color.Transparent;
            tabSprite.Controls.Add(cbDefaultPose);
            tabSprite.Controls.Add(lblDefaultPose);
            tabSprite.Controls.Add(lblBaseFolder);
            tabSprite.Controls.Add(btnBrowseFolder);
            tabSprite.Controls.Add(txtBase);
            tabSprite.Controls.Add(btnTransColor);
            tabSprite.Controls.Add(lblColor);
            tabSprite.Controls.Add(btnBrowseImage);
            tabSprite.Controls.Add(lstPoses);
            tabSprite.Controls.Add(lblPoses);
            tabSprite.Controls.Add(lblImage);
            tabSprite.Controls.Add(txtImage);
            tabSprite.Location = new System.Drawing.Point(4, 24);
            tabSprite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabSprite.Name = "tabSprite";
            tabSprite.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabSprite.Size = new System.Drawing.Size(272, 739);
            tabSprite.TabIndex = 0;
            tabSprite.Text = "Sprite";
            // 
            // cbDefaultPose
            // 
            cbDefaultPose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbDefaultPose.FormattingEnabled = true;
            cbDefaultPose.Location = new System.Drawing.Point(10, 152);
            cbDefaultPose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbDefaultPose.Name = "cbDefaultPose";
            cbDefaultPose.Size = new System.Drawing.Size(245, 23);
            cbDefaultPose.TabIndex = 18;
            cbDefaultPose.SelectedIndexChanged += cbDefaultPose_SelectedIndexChanged;
            // 
            // lblDefaultPose
            // 
            lblDefaultPose.AutoSize = true;
            lblDefaultPose.Location = new System.Drawing.Point(7, 134);
            lblDefaultPose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDefaultPose.Name = "lblDefaultPose";
            lblDefaultPose.Size = new System.Drawing.Size(73, 15);
            lblDefaultPose.TabIndex = 17;
            lblDefaultPose.Text = "Default Pose";
            // 
            // lblBaseFolder
            // 
            lblBaseFolder.AutoSize = true;
            lblBaseFolder.Location = new System.Drawing.Point(7, 7);
            lblBaseFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblBaseFolder.Name = "lblBaseFolder";
            lblBaseFolder.Size = new System.Drawing.Size(67, 15);
            lblBaseFolder.TabIndex = 16;
            lblBaseFolder.Text = "Base Folder";
            // 
            // btnBrowseFolder
            // 
            btnBrowseFolder.Location = new System.Drawing.Point(220, 25);
            btnBrowseFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnBrowseFolder.Name = "btnBrowseFolder";
            btnBrowseFolder.Size = new System.Drawing.Size(36, 23);
            btnBrowseFolder.TabIndex = 15;
            btnBrowseFolder.Text = "...";
            btnBrowseFolder.UseVisualStyleBackColor = true;
            btnBrowseFolder.Click += btnBrowseFolder_Click;
            // 
            // txtBase
            // 
            txtBase.Location = new System.Drawing.Point(10, 25);
            txtBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtBase.Name = "txtBase";
            txtBase.ReadOnly = true;
            txtBase.Size = new System.Drawing.Size(199, 23);
            txtBase.TabIndex = 14;
            // 
            // btnTransColor
            // 
            btnTransColor.Location = new System.Drawing.Point(120, 100);
            btnTransColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnTransColor.Name = "btnTransColor";
            btnTransColor.Size = new System.Drawing.Size(22, 21);
            btnTransColor.TabIndex = 13;
            btnTransColor.UseVisualStyleBackColor = false;
            btnTransColor.Click += btnTransColor_Click;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new System.Drawing.Point(7, 106);
            lblColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblColor.Name = "lblColor";
            lblColor.Size = new System.Drawing.Size(100, 15);
            lblColor.TabIndex = 12;
            lblColor.Text = "Transparent Color";
            // 
            // btnBrowseImage
            // 
            btnBrowseImage.Location = new System.Drawing.Point(220, 70);
            btnBrowseImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnBrowseImage.Name = "btnBrowseImage";
            btnBrowseImage.Size = new System.Drawing.Size(36, 23);
            btnBrowseImage.TabIndex = 11;
            btnBrowseImage.Text = "...";
            btnBrowseImage.UseVisualStyleBackColor = true;
            btnBrowseImage.Click += btnBrowseImage_Click;
            // 
            // lstPoses
            // 
            lstPoses.AllowDrop = true;
            lstPoses.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            lstPoses.ContextMenuStrip = mnuPose;
            lstPoses.FormattingEnabled = true;
            lstPoses.Location = new System.Drawing.Point(7, 196);
            lstPoses.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lstPoses.Name = "lstPoses";
            lstPoses.Size = new System.Drawing.Size(249, 529);
            lstPoses.TabIndex = 5;
            lstPoses.SelectedIndexChanged += lstPoses_SelectedIndexChanged;
            lstPoses.DragDrop += lstPoses_DragDrop;
            lstPoses.DragOver += lstPoses_DragOver;
            lstPoses.KeyDown += lstPoses_KeyDown;
            lstPoses.KeyUp += lstPoses_KeyUp;
            lstPoses.MouseDown += lstPoses_MouseDown;
            // 
            // mnuPose
            // 
            mnuPose.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { miAdd, miCopy, miPaste, miPasteCsv, miRemove, miOffsetFrames });
            mnuPose.Name = "mnuPose";
            mnuPose.Size = new System.Drawing.Size(158, 136);
            mnuPose.Opening += mnuPose_Opening;
            // 
            // miAdd
            // 
            miAdd.Name = "miAdd";
            miAdd.Size = new System.Drawing.Size(157, 22);
            miAdd.Text = "Add";
            miAdd.Click += miAdd_Click;
            // 
            // miCopy
            // 
            miCopy.Enabled = false;
            miCopy.Name = "miCopy";
            miCopy.ShortcutKeyDisplayString = "Ctrl+C";
            miCopy.Size = new System.Drawing.Size(157, 22);
            miCopy.Text = "Copy";
            miCopy.Click += miCopy_Click;
            // 
            // miPaste
            // 
            miPaste.Enabled = false;
            miPaste.Name = "miPaste";
            miPaste.ShortcutKeyDisplayString = "Ctrl+V";
            miPaste.Size = new System.Drawing.Size(157, 22);
            miPaste.Text = "Paste";
            miPaste.Click += miPaste_Click;
            // 
            // miPasteCsv
            // 
            miPasteCsv.Name = "miPasteCsv";
            miPasteCsv.Size = new System.Drawing.Size(157, 22);
            miPasteCsv.Text = "Paste CSV";
            miPasteCsv.Click += miPasteCsv_Click;
            // 
            // miRemove
            // 
            miRemove.Name = "miRemove";
            miRemove.ShortcutKeyDisplayString = "Delete";
            miRemove.Size = new System.Drawing.Size(157, 22);
            miRemove.Text = "Remove";
            miRemove.Click += miRemove_Click;
            // 
            // miOffsetFrames
            // 
            miOffsetFrames.Name = "miOffsetFrames";
            miOffsetFrames.Size = new System.Drawing.Size(157, 22);
            miOffsetFrames.Text = "Offset Frames...";
            miOffsetFrames.Click += miOffsetFrames_Click;
            // 
            // lblPoses
            // 
            lblPoses.AutoSize = true;
            lblPoses.Location = new System.Drawing.Point(7, 180);
            lblPoses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPoses.Name = "lblPoses";
            lblPoses.Size = new System.Drawing.Size(37, 15);
            lblPoses.TabIndex = 4;
            lblPoses.Text = "Poses";
            // 
            // lblImage
            // 
            lblImage.AutoSize = true;
            lblImage.Location = new System.Drawing.Point(7, 52);
            lblImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblImage.Name = "lblImage";
            lblImage.Size = new System.Drawing.Size(40, 15);
            lblImage.TabIndex = 1;
            lblImage.Text = "Image";
            // 
            // txtImage
            // 
            txtImage.Location = new System.Drawing.Point(10, 70);
            txtImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtImage.Name = "txtImage";
            txtImage.ReadOnly = true;
            txtImage.Size = new System.Drawing.Size(199, 23);
            txtImage.TabIndex = 0;
            // 
            // tabPose
            // 
            tabPose.BackColor = System.Drawing.Color.Transparent;
            tabPose.Controls.Add(txtCompletionFrame);
            tabPose.Controls.Add(chkRequireCompletion);
            tabPose.Controls.Add(btnPoseTransColor);
            tabPose.Controls.Add(lblPoseColor);
            tabPose.Controls.Add(btnBrowsePoseImage);
            tabPose.Controls.Add(lblPoseImage);
            tabPose.Controls.Add(txtPoseImage);
            tabPose.Controls.Add(txtOrigin);
            tabPose.Controls.Add(lblOrigin);
            tabPose.Controls.Add(cbState);
            tabPose.Controls.Add(lblState);
            tabPose.Controls.Add(cbDirection);
            tabPose.Controls.Add(lblDirection);
            tabPose.Controls.Add(lstFrames);
            tabPose.Controls.Add(lblFrames);
            tabPose.Controls.Add(txtBoundingBox);
            tabPose.Controls.Add(lblBoundingBox);
            tabPose.Controls.Add(txtRepeats);
            tabPose.Controls.Add(lblRepeats);
            tabPose.Controls.Add(txtDuration);
            tabPose.Controls.Add(lblDuration);
            tabPose.Controls.Add(txtPoseName);
            tabPose.Controls.Add(lblPoseName);
            tabPose.Location = new System.Drawing.Point(4, 24);
            tabPose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPose.Name = "tabPose";
            tabPose.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPose.Size = new System.Drawing.Size(272, 739);
            tabPose.TabIndex = 1;
            tabPose.Text = "Pose";
            // 
            // txtCompletionFrame
            // 
            txtCompletionFrame.Enabled = false;
            txtCompletionFrame.Location = new System.Drawing.Point(142, 112);
            txtCompletionFrame.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtCompletionFrame.Name = "txtCompletionFrame";
            txtCompletionFrame.Size = new System.Drawing.Size(118, 23);
            txtCompletionFrame.TabIndex = 25;
            txtCompletionFrame.TextChanged += txtCompletionFrame_TextChanged;
            // 
            // chkRequireCompletion
            // 
            chkRequireCompletion.AutoSize = true;
            chkRequireCompletion.Enabled = false;
            chkRequireCompletion.Location = new System.Drawing.Point(142, 93);
            chkRequireCompletion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkRequireCompletion.Name = "chkRequireCompletion";
            chkRequireCompletion.Size = new System.Drawing.Size(111, 19);
            chkRequireCompletion.TabIndex = 8;
            chkRequireCompletion.Text = "Must complete?";
            chkRequireCompletion.UseVisualStyleBackColor = true;
            chkRequireCompletion.CheckedChanged += chkRequireCompletion_CheckedChanged;
            // 
            // btnPoseTransColor
            // 
            btnPoseTransColor.Location = new System.Drawing.Point(120, 367);
            btnPoseTransColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnPoseTransColor.Name = "btnPoseTransColor";
            btnPoseTransColor.Size = new System.Drawing.Size(22, 21);
            btnPoseTransColor.TabIndex = 22;
            btnPoseTransColor.UseVisualStyleBackColor = false;
            btnPoseTransColor.Click += btnPoseTransColor_Click;
            // 
            // lblPoseColor
            // 
            lblPoseColor.AutoSize = true;
            lblPoseColor.Location = new System.Drawing.Point(7, 373);
            lblPoseColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPoseColor.Name = "lblPoseColor";
            lblPoseColor.Size = new System.Drawing.Size(100, 15);
            lblPoseColor.TabIndex = 21;
            lblPoseColor.Text = "Transparent Color";
            // 
            // btnBrowsePoseImage
            // 
            btnBrowsePoseImage.Location = new System.Drawing.Point(224, 342);
            btnBrowsePoseImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnBrowsePoseImage.Name = "btnBrowsePoseImage";
            btnBrowsePoseImage.Size = new System.Drawing.Size(36, 23);
            btnBrowsePoseImage.TabIndex = 20;
            btnBrowsePoseImage.Text = "...";
            btnBrowsePoseImage.UseVisualStyleBackColor = true;
            btnBrowsePoseImage.Click += btnBrowsePoseImage_Click;
            // 
            // lblPoseImage
            // 
            lblPoseImage.AutoSize = true;
            lblPoseImage.Location = new System.Drawing.Point(8, 322);
            lblPoseImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPoseImage.Name = "lblPoseImage";
            lblPoseImage.Size = new System.Drawing.Size(40, 15);
            lblPoseImage.TabIndex = 18;
            lblPoseImage.Text = "Image";
            // 
            // txtPoseImage
            // 
            txtPoseImage.Location = new System.Drawing.Point(12, 343);
            txtPoseImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtPoseImage.Name = "txtPoseImage";
            txtPoseImage.ReadOnly = true;
            txtPoseImage.Size = new System.Drawing.Size(205, 23);
            txtPoseImage.TabIndex = 19;
            // 
            // txtOrigin
            // 
            txtOrigin.Location = new System.Drawing.Point(10, 202);
            txtOrigin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtOrigin.Name = "txtOrigin";
            txtOrigin.Size = new System.Drawing.Size(249, 23);
            txtOrigin.TabIndex = 13;
            txtOrigin.TextChanged += txtOrigin_TextChanged;
            // 
            // lblOrigin
            // 
            lblOrigin.AutoSize = true;
            lblOrigin.Location = new System.Drawing.Point(7, 183);
            lblOrigin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOrigin.Name = "lblOrigin";
            lblOrigin.Size = new System.Drawing.Size(40, 15);
            lblOrigin.TabIndex = 12;
            lblOrigin.Text = "Origin";
            // 
            // cbState
            // 
            cbState.FormattingEnabled = true;
            cbState.Location = new System.Drawing.Point(10, 294);
            cbState.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbState.Name = "cbState";
            cbState.Size = new System.Drawing.Size(249, 23);
            cbState.TabIndex = 17;
            cbState.DropDown += cbState_DropDown;
            cbState.SelectedIndexChanged += cbState_SelectedIndexChanged;
            cbState.TextChanged += cbState_TextChanged;
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Location = new System.Drawing.Point(7, 275);
            lblState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblState.Name = "lblState";
            lblState.Size = new System.Drawing.Size(33, 15);
            lblState.TabIndex = 16;
            lblState.Text = "State";
            // 
            // cbDirection
            // 
            cbDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbDirection.FormattingEnabled = true;
            cbDirection.Items.AddRange(new object[] { "None", "Up", "Right", "Down", "Left", "Up|Right", "Up|Left", "Down|Right", "Down|Left" });
            cbDirection.Location = new System.Drawing.Point(10, 247);
            cbDirection.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbDirection.Name = "cbDirection";
            cbDirection.Size = new System.Drawing.Size(249, 23);
            cbDirection.TabIndex = 15;
            cbDirection.SelectedIndexChanged += cbDirection_SelectedIndexChanged;
            // 
            // lblDirection
            // 
            lblDirection.AutoSize = true;
            lblDirection.Location = new System.Drawing.Point(7, 227);
            lblDirection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDirection.Name = "lblDirection";
            lblDirection.Size = new System.Drawing.Size(55, 15);
            lblDirection.TabIndex = 14;
            lblDirection.Text = "Direction";
            // 
            // lstFrames
            // 
            lstFrames.AllowDrop = true;
            lstFrames.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            lstFrames.ContextMenuStrip = mnuFrame;
            lstFrames.FormattingEnabled = true;
            lstFrames.Location = new System.Drawing.Point(12, 412);
            lstFrames.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lstFrames.Name = "lstFrames";
            lstFrames.Size = new System.Drawing.Size(248, 304);
            lstFrames.TabIndex = 24;
            lstFrames.SelectedIndexChanged += lstFrames_SelectedIndexChanged;
            lstFrames.DragDrop += lstFrames_DragDrop;
            lstFrames.DragOver += lstFrames_DragOver;
            lstFrames.KeyDown += lstFrames_KeyDown;
            lstFrames.KeyUp += lstFrames_KeyUp;
            lstFrames.MouseDown += lstFrames_MouseDown;
            // 
            // mnuFrame
            // 
            mnuFrame.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { miAddFrame, miCopyFrame, miPasteFrame, miRemoveFrame, miClearFrames, miAddMultiple, miOffsetFrame });
            mnuFrame.Name = "mnuPose";
            mnuFrame.Size = new System.Drawing.Size(158, 158);
            mnuFrame.Opening += mnuFrame_Opening;
            // 
            // miAddFrame
            // 
            miAddFrame.Name = "miAddFrame";
            miAddFrame.Size = new System.Drawing.Size(157, 22);
            miAddFrame.Text = "Add";
            miAddFrame.Click += miAddFrame_Click;
            // 
            // miCopyFrame
            // 
            miCopyFrame.Enabled = false;
            miCopyFrame.Name = "miCopyFrame";
            miCopyFrame.ShortcutKeyDisplayString = "Ctrl+C";
            miCopyFrame.Size = new System.Drawing.Size(157, 22);
            miCopyFrame.Text = "Copy";
            miCopyFrame.Click += miCopyFrame_Click;
            // 
            // miPasteFrame
            // 
            miPasteFrame.Enabled = false;
            miPasteFrame.Name = "miPasteFrame";
            miPasteFrame.ShortcutKeyDisplayString = "Ctrl+V";
            miPasteFrame.Size = new System.Drawing.Size(157, 22);
            miPasteFrame.Text = "Paste";
            miPasteFrame.Click += miPasteFrame_Click;
            // 
            // miRemoveFrame
            // 
            miRemoveFrame.Name = "miRemoveFrame";
            miRemoveFrame.ShortcutKeyDisplayString = "Delete";
            miRemoveFrame.Size = new System.Drawing.Size(157, 22);
            miRemoveFrame.Text = "Remove";
            miRemoveFrame.Click += miRemoveFrame_Click;
            // 
            // miClearFrames
            // 
            miClearFrames.Name = "miClearFrames";
            miClearFrames.Size = new System.Drawing.Size(157, 22);
            miClearFrames.Text = "Clear";
            miClearFrames.Click += miClearFrames_Click;
            // 
            // miAddMultiple
            // 
            miAddMultiple.Name = "miAddMultiple";
            miAddMultiple.Size = new System.Drawing.Size(157, 22);
            miAddMultiple.Text = "Add Multiple...";
            miAddMultiple.Click += miAddMultiple_Click;
            // 
            // miOffsetFrame
            // 
            miOffsetFrame.Name = "miOffsetFrame";
            miOffsetFrame.Size = new System.Drawing.Size(157, 22);
            miOffsetFrame.Text = "Offset...";
            miOffsetFrame.Click += miOffsetFrame_Click;
            // 
            // lblFrames
            // 
            lblFrames.AutoSize = true;
            lblFrames.Location = new System.Drawing.Point(8, 393);
            lblFrames.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFrames.Name = "lblFrames";
            lblFrames.Size = new System.Drawing.Size(45, 15);
            lblFrames.TabIndex = 23;
            lblFrames.Text = "Frames";
            // 
            // txtBoundingBox
            // 
            txtBoundingBox.Location = new System.Drawing.Point(10, 157);
            txtBoundingBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtBoundingBox.Name = "txtBoundingBox";
            txtBoundingBox.Size = new System.Drawing.Size(249, 23);
            txtBoundingBox.TabIndex = 11;
            txtBoundingBox.TextChanged += txtBoundingBox_TextChanged;
            // 
            // lblBoundingBox
            // 
            lblBoundingBox.AutoSize = true;
            lblBoundingBox.Location = new System.Drawing.Point(7, 138);
            lblBoundingBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblBoundingBox.Name = "lblBoundingBox";
            lblBoundingBox.Size = new System.Drawing.Size(94, 15);
            lblBoundingBox.TabIndex = 10;
            lblBoundingBox.Text = "Bounding Shape";
            // 
            // txtRepeats
            // 
            txtRepeats.Location = new System.Drawing.Point(10, 112);
            txtRepeats.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtRepeats.Name = "txtRepeats";
            txtRepeats.Size = new System.Drawing.Size(124, 23);
            txtRepeats.TabIndex = 7;
            txtRepeats.TextChanged += txtRepeats_TextChanged;
            // 
            // lblRepeats
            // 
            lblRepeats.AutoSize = true;
            lblRepeats.Location = new System.Drawing.Point(7, 93);
            lblRepeats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRepeats.Name = "lblRepeats";
            lblRepeats.Size = new System.Drawing.Size(48, 15);
            lblRepeats.TabIndex = 6;
            lblRepeats.Text = "Repeats";
            // 
            // txtDuration
            // 
            txtDuration.Location = new System.Drawing.Point(10, 67);
            txtDuration.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new System.Drawing.Size(249, 23);
            txtDuration.TabIndex = 5;
            txtDuration.TextChanged += txtDuration_TextChanged;
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new System.Drawing.Point(7, 48);
            lblDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new System.Drawing.Size(53, 15);
            lblDuration.TabIndex = 4;
            lblDuration.Text = "Duration";
            // 
            // txtPoseName
            // 
            txtPoseName.Location = new System.Drawing.Point(10, 22);
            txtPoseName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtPoseName.Name = "txtPoseName";
            txtPoseName.Size = new System.Drawing.Size(249, 23);
            txtPoseName.TabIndex = 3;
            txtPoseName.TextChanged += txtPoseName_TextChanged;
            // 
            // lblPoseName
            // 
            lblPoseName.AutoSize = true;
            lblPoseName.Location = new System.Drawing.Point(7, 3);
            lblPoseName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPoseName.Name = "lblPoseName";
            lblPoseName.Size = new System.Drawing.Size(39, 15);
            lblPoseName.TabIndex = 2;
            lblPoseName.Text = "Name";
            // 
            // tabFrame
            // 
            tabFrame.BackColor = System.Drawing.Color.Transparent;
            tabFrame.Controls.Add(txtFrameMarker);
            tabFrame.Controls.Add(lblFrameMarker);
            tabFrame.Controls.Add(txtRemoveSound);
            tabFrame.Controls.Add(txtVolume);
            tabFrame.Controls.Add(lblVolume);
            tabFrame.Controls.Add(txtPitch);
            tabFrame.Controls.Add(lblPitch);
            tabFrame.Controls.Add(lblFrameNumber);
            tabFrame.Controls.Add(btnBrowseSound);
            tabFrame.Controls.Add(lblSound);
            tabFrame.Controls.Add(txtSound);
            tabFrame.Controls.Add(txtOpacity);
            tabFrame.Controls.Add(lblOpacity);
            tabFrame.Controls.Add(btnFrameTransColor);
            tabFrame.Controls.Add(lblFrameColor);
            tabFrame.Controls.Add(btnBrowseFrameImage);
            tabFrame.Controls.Add(lblFrameImage);
            tabFrame.Controls.Add(txtFrameImage);
            tabFrame.Controls.Add(btnNextFrame);
            tabFrame.Controls.Add(btnPrevFrame);
            tabFrame.Controls.Add(chkTween);
            tabFrame.Controls.Add(txtRectangle);
            tabFrame.Controls.Add(lblRectangle);
            tabFrame.Controls.Add(txtAngle);
            tabFrame.Controls.Add(lblAngle);
            tabFrame.Controls.Add(txtMagnification);
            tabFrame.Controls.Add(lblMagnification);
            tabFrame.Controls.Add(txtFrameDuration);
            tabFrame.Controls.Add(lblFrameDuration);
            tabFrame.Location = new System.Drawing.Point(4, 24);
            tabFrame.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabFrame.Name = "tabFrame";
            tabFrame.Size = new System.Drawing.Size(272, 739);
            tabFrame.TabIndex = 2;
            tabFrame.Text = "Frame";
            // 
            // txtFrameMarker
            // 
            txtFrameMarker.Location = new System.Drawing.Point(10, 93);
            txtFrameMarker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtFrameMarker.Name = "txtFrameMarker";
            txtFrameMarker.Size = new System.Drawing.Size(249, 23);
            txtFrameMarker.TabIndex = 34;
            txtFrameMarker.TextChanged += txtFrameMarker_TextChanged;
            // 
            // lblFrameMarker
            // 
            lblFrameMarker.AutoSize = true;
            lblFrameMarker.Location = new System.Drawing.Point(8, 74);
            lblFrameMarker.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFrameMarker.Name = "lblFrameMarker";
            lblFrameMarker.Size = new System.Drawing.Size(44, 15);
            lblFrameMarker.TabIndex = 33;
            lblFrameMarker.Text = "Marker";
            // 
            // txtRemoveSound
            // 
            txtRemoveSound.Location = new System.Drawing.Point(223, 349);
            txtRemoveSound.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtRemoveSound.Name = "txtRemoveSound";
            txtRemoveSound.Size = new System.Drawing.Size(36, 23);
            txtRemoveSound.TabIndex = 32;
            txtRemoveSound.Text = "X";
            txtRemoveSound.UseVisualStyleBackColor = true;
            txtRemoveSound.Click += btnRemoveSound_Click;
            // 
            // txtVolume
            // 
            txtVolume.Enabled = false;
            txtVolume.Location = new System.Drawing.Point(163, 349);
            txtVolume.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtVolume.Name = "txtVolume";
            txtVolume.Size = new System.Drawing.Size(51, 23);
            txtVolume.TabIndex = 31;
            txtVolume.TextChanged += txtVolume_TextChanged;
            // 
            // lblVolume
            // 
            lblVolume.AutoSize = true;
            lblVolume.Location = new System.Drawing.Point(108, 352);
            lblVolume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblVolume.Name = "lblVolume";
            lblVolume.Size = new System.Drawing.Size(47, 15);
            lblVolume.TabIndex = 30;
            lblVolume.Text = "Volume";
            // 
            // txtPitch
            // 
            txtPitch.Enabled = false;
            txtPitch.Location = new System.Drawing.Point(49, 349);
            txtPitch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtPitch.Name = "txtPitch";
            txtPitch.Size = new System.Drawing.Size(51, 23);
            txtPitch.TabIndex = 29;
            txtPitch.TextChanged += txtPitch_TextChanged;
            // 
            // lblPitch
            // 
            lblPitch.AutoSize = true;
            lblPitch.Location = new System.Drawing.Point(7, 352);
            lblPitch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPitch.Name = "lblPitch";
            lblPitch.Size = new System.Drawing.Size(34, 15);
            lblPitch.TabIndex = 28;
            lblPitch.Text = "Pitch";
            // 
            // lblFrameNumber
            // 
            lblFrameNumber.AutoSize = true;
            lblFrameNumber.Location = new System.Drawing.Point(126, 465);
            lblFrameNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFrameNumber.Name = "lblFrameNumber";
            lblFrameNumber.Size = new System.Drawing.Size(14, 15);
            lblFrameNumber.TabIndex = 27;
            lblFrameNumber.Text = "#";
            // 
            // btnBrowseSound
            // 
            btnBrowseSound.Location = new System.Drawing.Point(224, 320);
            btnBrowseSound.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnBrowseSound.Name = "btnBrowseSound";
            btnBrowseSound.Size = new System.Drawing.Size(36, 23);
            btnBrowseSound.TabIndex = 26;
            btnBrowseSound.Text = "...";
            btnBrowseSound.UseVisualStyleBackColor = true;
            btnBrowseSound.Click += btnBrowseSound_Click;
            // 
            // lblSound
            // 
            lblSound.AutoSize = true;
            lblSound.Location = new System.Drawing.Point(7, 299);
            lblSound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSound.Name = "lblSound";
            lblSound.Size = new System.Drawing.Size(41, 15);
            lblSound.TabIndex = 25;
            lblSound.Text = "Sound";
            // 
            // txtSound
            // 
            txtSound.Location = new System.Drawing.Point(10, 320);
            txtSound.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtSound.Name = "txtSound";
            txtSound.ReadOnly = true;
            txtSound.Size = new System.Drawing.Size(206, 23);
            txtSound.TabIndex = 24;
            // 
            // txtOpacity
            // 
            txtOpacity.Location = new System.Drawing.Point(10, 227);
            txtOpacity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtOpacity.Name = "txtOpacity";
            txtOpacity.Size = new System.Drawing.Size(249, 23);
            txtOpacity.TabIndex = 23;
            txtOpacity.TextChanged += txtOpacity_TextChanged;
            // 
            // lblOpacity
            // 
            lblOpacity.AutoSize = true;
            lblOpacity.Location = new System.Drawing.Point(7, 209);
            lblOpacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOpacity.Name = "lblOpacity";
            lblOpacity.Size = new System.Drawing.Size(48, 15);
            lblOpacity.TabIndex = 22;
            lblOpacity.Text = "Opacity";
            // 
            // btnFrameTransColor
            // 
            btnFrameTransColor.Location = new System.Drawing.Point(118, 421);
            btnFrameTransColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnFrameTransColor.Name = "btnFrameTransColor";
            btnFrameTransColor.Size = new System.Drawing.Size(22, 21);
            btnFrameTransColor.TabIndex = 21;
            btnFrameTransColor.UseVisualStyleBackColor = false;
            btnFrameTransColor.Click += btnFrameTransColor_Click;
            // 
            // lblFrameColor
            // 
            lblFrameColor.AutoSize = true;
            lblFrameColor.Location = new System.Drawing.Point(10, 424);
            lblFrameColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFrameColor.Name = "lblFrameColor";
            lblFrameColor.Size = new System.Drawing.Size(100, 15);
            lblFrameColor.TabIndex = 20;
            lblFrameColor.Text = "Transparent Color";
            // 
            // btnBrowseFrameImage
            // 
            btnBrowseFrameImage.Location = new System.Drawing.Point(224, 391);
            btnBrowseFrameImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnBrowseFrameImage.Name = "btnBrowseFrameImage";
            btnBrowseFrameImage.Size = new System.Drawing.Size(36, 23);
            btnBrowseFrameImage.TabIndex = 19;
            btnBrowseFrameImage.Text = "...";
            btnBrowseFrameImage.UseVisualStyleBackColor = true;
            btnBrowseFrameImage.Click += btnBrowseFrameImage_Click;
            // 
            // lblFrameImage
            // 
            lblFrameImage.AutoSize = true;
            lblFrameImage.Location = new System.Drawing.Point(8, 374);
            lblFrameImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFrameImage.Name = "lblFrameImage";
            lblFrameImage.Size = new System.Drawing.Size(40, 15);
            lblFrameImage.TabIndex = 18;
            lblFrameImage.Text = "Image";
            // 
            // txtFrameImage
            // 
            txtFrameImage.Location = new System.Drawing.Point(10, 392);
            txtFrameImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtFrameImage.Name = "txtFrameImage";
            txtFrameImage.ReadOnly = true;
            txtFrameImage.Size = new System.Drawing.Size(206, 23);
            txtFrameImage.TabIndex = 17;
            // 
            // btnNextFrame
            // 
            btnNextFrame.Location = new System.Drawing.Point(153, 459);
            btnNextFrame.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnNextFrame.Name = "btnNextFrame";
            btnNextFrame.Size = new System.Drawing.Size(103, 27);
            btnNextFrame.TabIndex = 16;
            btnNextFrame.Text = "Next Frame";
            btnNextFrame.UseVisualStyleBackColor = true;
            btnNextFrame.Click += btnNextFrame_Click;
            // 
            // btnPrevFrame
            // 
            btnPrevFrame.Location = new System.Drawing.Point(7, 459);
            btnPrevFrame.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnPrevFrame.Name = "btnPrevFrame";
            btnPrevFrame.Size = new System.Drawing.Size(103, 27);
            btnPrevFrame.TabIndex = 15;
            btnPrevFrame.Text = "Prev. Frame";
            btnPrevFrame.UseVisualStyleBackColor = true;
            btnPrevFrame.Click += btnPrevFrame_Click;
            // 
            // chkTween
            // 
            chkTween.AutoSize = true;
            chkTween.Location = new System.Drawing.Point(10, 7);
            chkTween.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkTween.Name = "chkTween";
            chkTween.Size = new System.Drawing.Size(92, 19);
            chkTween.TabIndex = 14;
            chkTween.Text = "TweenFrame";
            chkTween.UseVisualStyleBackColor = true;
            chkTween.CheckedChanged += chkTween_CheckedChanged;
            // 
            // txtRectangle
            // 
            txtRectangle.Location = new System.Drawing.Point(10, 272);
            txtRectangle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtRectangle.Name = "txtRectangle";
            txtRectangle.Size = new System.Drawing.Size(249, 23);
            txtRectangle.TabIndex = 12;
            txtRectangle.TextChanged += txtRectangle_TextChanged;
            // 
            // lblRectangle
            // 
            lblRectangle.AutoSize = true;
            lblRectangle.Location = new System.Drawing.Point(7, 254);
            lblRectangle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRectangle.Name = "lblRectangle";
            lblRectangle.Size = new System.Drawing.Size(98, 15);
            lblRectangle.TabIndex = 11;
            lblRectangle.Text = "Source Rectangle";
            // 
            // txtAngle
            // 
            txtAngle.Location = new System.Drawing.Point(10, 182);
            txtAngle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtAngle.Name = "txtAngle";
            txtAngle.Size = new System.Drawing.Size(249, 23);
            txtAngle.TabIndex = 10;
            txtAngle.TextChanged += txtAngle_TextChanged;
            // 
            // lblAngle
            // 
            lblAngle.AutoSize = true;
            lblAngle.Location = new System.Drawing.Point(7, 164);
            lblAngle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAngle.Name = "lblAngle";
            lblAngle.Size = new System.Drawing.Size(38, 15);
            lblAngle.TabIndex = 9;
            lblAngle.Text = "Angle";
            // 
            // txtMagnification
            // 
            txtMagnification.Location = new System.Drawing.Point(10, 137);
            txtMagnification.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtMagnification.Name = "txtMagnification";
            txtMagnification.Size = new System.Drawing.Size(249, 23);
            txtMagnification.TabIndex = 6;
            txtMagnification.TextChanged += txtMagnification_TextChanged;
            // 
            // lblMagnification
            // 
            lblMagnification.AutoSize = true;
            lblMagnification.Location = new System.Drawing.Point(7, 119);
            lblMagnification.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMagnification.Name = "lblMagnification";
            lblMagnification.Size = new System.Drawing.Size(81, 15);
            lblMagnification.TabIndex = 5;
            lblMagnification.Text = "Magnification";
            // 
            // txtFrameDuration
            // 
            txtFrameDuration.Location = new System.Drawing.Point(10, 48);
            txtFrameDuration.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtFrameDuration.Name = "txtFrameDuration";
            txtFrameDuration.Size = new System.Drawing.Size(249, 23);
            txtFrameDuration.TabIndex = 4;
            txtFrameDuration.TextChanged += txtFrameDuration_TextChanged;
            // 
            // lblFrameDuration
            // 
            lblFrameDuration.AutoSize = true;
            lblFrameDuration.Location = new System.Drawing.Point(7, 30);
            lblFrameDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFrameDuration.Name = "lblFrameDuration";
            lblFrameDuration.Size = new System.Drawing.Size(53, 15);
            lblFrameDuration.TabIndex = 3;
            lblFrameDuration.Text = "Duration";
            // 
            // ofdImage
            // 
            ofdImage.Filter = "Image files|*.png;*.jpg;*.gif;*.bmp";
            ofdImage.Title = "Select sprite image";
            // 
            // mnuMain
            // 
            mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { miFile, miView });
            mnuMain.Location = new System.Drawing.Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            mnuMain.Size = new System.Drawing.Size(1176, 24);
            mnuMain.TabIndex = 7;
            mnuMain.Text = "menuStrip1";
            // 
            // miFile
            // 
            miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { miNew, miOpen, miSave, miSaveAs, miAutoReload, miCheckEdges, miRecentFiles });
            miFile.Name = "miFile";
            miFile.Size = new System.Drawing.Size(37, 20);
            miFile.Text = "&File";
            // 
            // miNew
            // 
            miNew.Name = "miNew";
            miNew.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N;
            miNew.Size = new System.Drawing.Size(217, 22);
            miNew.Text = "&New";
            miNew.Click += miNew_Click;
            // 
            // miOpen
            // 
            miOpen.Name = "miOpen";
            miOpen.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O;
            miOpen.Size = new System.Drawing.Size(217, 22);
            miOpen.Text = "&Open...";
            miOpen.Click += miOpen_Click;
            // 
            // miSave
            // 
            miSave.Name = "miSave";
            miSave.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S;
            miSave.Size = new System.Drawing.Size(217, 22);
            miSave.Text = "&Save";
            miSave.Click += miSave_Click;
            // 
            // miSaveAs
            // 
            miSaveAs.Name = "miSaveAs";
            miSaveAs.Size = new System.Drawing.Size(217, 22);
            miSaveAs.Text = "Save &As...";
            miSaveAs.Click += miSaveAs_Click;
            // 
            // miAutoReload
            // 
            miAutoReload.CheckOnClick = true;
            miAutoReload.Name = "miAutoReload";
            miAutoReload.Size = new System.Drawing.Size(217, 22);
            miAutoReload.Text = "Auto-Reload Images";
            miAutoReload.CheckedChanged += miAutoReload_CheckedChanged;
            // 
            // miCheckEdges
            // 
            miCheckEdges.Name = "miCheckEdges";
            miCheckEdges.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E;
            miCheckEdges.Size = new System.Drawing.Size(217, 22);
            miCheckEdges.Text = "Check Frame &Edges";
            miCheckEdges.Click += miCheckEdges_Click;
            // 
            // miRecentFiles
            // 
            miRecentFiles.Name = "miRecentFiles";
            miRecentFiles.Size = new System.Drawing.Size(217, 22);
            miRecentFiles.Text = "Recent Files";
            // 
            // miView
            // 
            miView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { miFull, miPreview, miAnimated, toolStripSeparator1, miShowSrcRect, miShowBoundingBox, miTransparent, toolStripSeparator2, miShowGrid, miGridSelection, miGridSettings, toolStripSeparator4, miMagnification });
            miView.Name = "miView";
            miView.Size = new System.Drawing.Size(44, 20);
            miView.Text = "&View";
            // 
            // miFull
            // 
            miFull.Checked = true;
            miFull.CheckOnClick = true;
            miFull.CheckState = System.Windows.Forms.CheckState.Checked;
            miFull.Name = "miFull";
            miFull.ShortcutKeys = System.Windows.Forms.Keys.F10;
            miFull.Size = new System.Drawing.Size(223, 22);
            miFull.Text = "&Full Sprite View";
            miFull.Click += miFull_Click;
            // 
            // miPreview
            // 
            miPreview.CheckOnClick = true;
            miPreview.Name = "miPreview";
            miPreview.ShortcutKeys = System.Windows.Forms.Keys.F11;
            miPreview.Size = new System.Drawing.Size(223, 22);
            miPreview.Text = "&Non-Animated Preview";
            miPreview.Click += miPreview_Click;
            // 
            // miAnimated
            // 
            miAnimated.CheckOnClick = true;
            miAnimated.Name = "miAnimated";
            miAnimated.ShortcutKeys = System.Windows.Forms.Keys.F12;
            miAnimated.Size = new System.Drawing.Size(223, 22);
            miAnimated.Text = "&Animated Preview";
            miAnimated.Click += miAnimated_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(220, 6);
            // 
            // miShowSrcRect
            // 
            miShowSrcRect.CheckOnClick = true;
            miShowSrcRect.Name = "miShowSrcRect";
            miShowSrcRect.Size = new System.Drawing.Size(223, 22);
            miShowSrcRect.Text = "Show &Source Rect";
            miShowSrcRect.CheckedChanged += miShowSrcRect_CheckedChanged;
            // 
            // miShowBoundingBox
            // 
            miShowBoundingBox.CheckOnClick = true;
            miShowBoundingBox.Name = "miShowBoundingBox";
            miShowBoundingBox.Size = new System.Drawing.Size(223, 22);
            miShowBoundingBox.Text = "Show &Bounding Box";
            miShowBoundingBox.CheckedChanged += miShowBoundingBox_CheckChanged;
            // 
            // miTransparent
            // 
            miTransparent.CheckOnClick = true;
            miTransparent.Name = "miTransparent";
            miTransparent.Size = new System.Drawing.Size(223, 22);
            miTransparent.Text = "Use Transparent Color";
            miTransparent.CheckedChanged += miTransparent_CheckedChanged;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(220, 6);
            // 
            // miShowGrid
            // 
            miShowGrid.CheckOnClick = true;
            miShowGrid.Name = "miShowGrid";
            miShowGrid.Size = new System.Drawing.Size(223, 22);
            miShowGrid.Text = "Show Grid";
            miShowGrid.CheckedChanged += miShowGrid_CheckChanged;
            // 
            // miGridSelection
            // 
            miGridSelection.CheckOnClick = true;
            miGridSelection.Name = "miGridSelection";
            miGridSelection.Size = new System.Drawing.Size(223, 22);
            miGridSelection.Text = "Grid Selection";
            miGridSelection.CheckedChanged += miGridSelection_CheckedChanged;
            // 
            // miGridSettings
            // 
            miGridSettings.Name = "miGridSettings";
            miGridSettings.Size = new System.Drawing.Size(223, 22);
            miGridSettings.Text = "Grid Settings...";
            miGridSettings.Click += miGridSettings_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(220, 6);
            // 
            // miMagnification
            // 
            miMagnification.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { miMagnification50, miMagnification100, miMagnification200, miMagnification300, miMagnification400, miMagnification800, miMagnification1600, toolStripSeparator3, miMagnificationZoomIn, miMagnificationZoomOut });
            miMagnification.Name = "miMagnification";
            miMagnification.Size = new System.Drawing.Size(223, 22);
            miMagnification.Text = "Magnification";
            // 
            // miMagnification50
            // 
            miMagnification50.Name = "miMagnification50";
            miMagnification50.Size = new System.Drawing.Size(168, 22);
            miMagnification50.Text = "50%";
            miMagnification50.Click += miMagnification50_Click;
            // 
            // miMagnification100
            // 
            miMagnification100.Name = "miMagnification100";
            miMagnification100.ShortcutKeyDisplayString = "Ctrl+0";
            miMagnification100.Size = new System.Drawing.Size(168, 22);
            miMagnification100.Text = "100%";
            miMagnification100.Click += miMagnification100_Click;
            // 
            // miMagnification200
            // 
            miMagnification200.Name = "miMagnification200";
            miMagnification200.Size = new System.Drawing.Size(168, 22);
            miMagnification200.Text = "200%";
            miMagnification200.Click += miMagnification200_Click;
            // 
            // miMagnification300
            // 
            miMagnification300.Name = "miMagnification300";
            miMagnification300.Size = new System.Drawing.Size(168, 22);
            miMagnification300.Text = "300%";
            miMagnification300.Click += miMagnification300_Click;
            // 
            // miMagnification400
            // 
            miMagnification400.Name = "miMagnification400";
            miMagnification400.Size = new System.Drawing.Size(168, 22);
            miMagnification400.Text = "400%";
            miMagnification400.Click += miMagnification400_Click;
            // 
            // miMagnification800
            // 
            miMagnification800.Name = "miMagnification800";
            miMagnification800.Size = new System.Drawing.Size(168, 22);
            miMagnification800.Text = "800%";
            miMagnification800.Click += miMagnification800_Click;
            // 
            // miMagnification1600
            // 
            miMagnification1600.Name = "miMagnification1600";
            miMagnification1600.Size = new System.Drawing.Size(168, 22);
            miMagnification1600.Text = "1600%";
            miMagnification1600.Click += miMagnification1600_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(165, 6);
            // 
            // miMagnificationZoomIn
            // 
            miMagnificationZoomIn.Name = "miMagnificationZoomIn";
            miMagnificationZoomIn.ShortcutKeyDisplayString = "Ctrl++";
            miMagnificationZoomIn.Size = new System.Drawing.Size(168, 22);
            miMagnificationZoomIn.Text = "Zoom In";
            miMagnificationZoomIn.Click += miMagnificationZoomIn_Click;
            // 
            // miMagnificationZoomOut
            // 
            miMagnificationZoomOut.Name = "miMagnificationZoomOut";
            miMagnificationZoomOut.ShortcutKeyDisplayString = "Ctrl+-";
            miMagnificationZoomOut.Size = new System.Drawing.Size(168, 22);
            miMagnificationZoomOut.Text = "Zoom Out";
            miMagnificationZoomOut.Click += miMagnificationZoomOut_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { stlMessage });
            statusStrip1.Location = new System.Drawing.Point(0, 819);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            statusStrip1.Size = new System.Drawing.Size(1176, 22);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = "stsMain";
            // 
            // stlMessage
            // 
            stlMessage.Name = "stlMessage";
            stlMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // ofdSprite
            // 
            ofdSprite.Filter = "Sprite and Image Files|*.spr;*.png|Sprite XML Files|*.spr|Image Files|*.png";
            ofdSprite.Title = "Select sprite file";
            // 
            // sfdSprite
            // 
            sfdSprite.FileName = "sprite.spr";
            sfdSprite.Filter = "Sprite XML Files|*.spr";
            sfdSprite.Title = "Save sprite file as...";
            // 
            // ofdSound
            // 
            ofdSound.Filter = "Sound files|*.wav;*.ogg;*.mp3";
            ofdSound.Title = "Select sprite image";
            // 
            // fswUpdatedImageWatcher
            // 
            fswUpdatedImageWatcher.EnableRaisingEvents = true;
            fswUpdatedImageWatcher.NotifyFilter = System.IO.NotifyFilters.LastWrite;
            fswUpdatedImageWatcher.SynchronizingObject = this;
            fswUpdatedImageWatcher.Changed += fswUpdatedImageWatcher_Changed;
            // 
            // pnlSprite
            // 
            pnlSprite.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlSprite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pnlSprite.Location = new System.Drawing.Point(0, 31);
            pnlSprite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlSprite.Name = "pnlSprite";
            pnlSprite.Size = new System.Drawing.Size(874, 767);
            pnlSprite.TabIndex = 0;
            pnlSprite.Paint += pnlSprite_Paint;
            pnlSprite.MouseClick += pnlSprite_MouseClick;
            pnlSprite.MouseHover += pnlSprite_MouseHover;
            // 
            // FrmSprite
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1176, 841);
            Controls.Add(statusStrip1);
            Controls.Add(mnuMain);
            Controls.Add(pnlSprite);
            Controls.Add(tbcSprite);
            DoubleBuffered = true;
            KeyPreview = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FrmSprite";
            Text = "Sprite Editor";
            FormClosed += frmSprite_FormClosed;
            Load += frmSprite_Load;
            KeyDown += frmSprite_KeyDown;
            tbcSprite.ResumeLayout(false);
            tabSprite.ResumeLayout(false);
            tabSprite.PerformLayout();
            mnuPose.ResumeLayout(false);
            tabPose.ResumeLayout(false);
            tabPose.PerformLayout();
            mnuFrame.ResumeLayout(false);
            tabFrame.ResumeLayout(false);
            tabFrame.PerformLayout();
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fswUpdatedImageWatcher).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlickerFreePanel pnlSprite;
        private System.Windows.Forms.Timer tmrUpdate;
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
        private System.Windows.Forms.TextBox txtMagnification;
        private System.Windows.Forms.Label lblMagnification;
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
        private System.Windows.Forms.ToolStripMenuItem miView;
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
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.ComboBox cbDirection;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Button btnFrameTransColor;
        private System.Windows.Forms.Label lblFrameColor;
        private System.Windows.Forms.Button btnBrowseFrameImage;
        private System.Windows.Forms.Label lblFrameImage;
        private System.Windows.Forms.TextBox txtFrameImage;
        private System.Windows.Forms.ToolStripMenuItem miAddMultiple;
        private System.Windows.Forms.TextBox txtOpacity;
        private System.Windows.Forms.Label lblOpacity;
        private System.Windows.Forms.Button btnPoseTransColor;
        private System.Windows.Forms.Label lblPoseColor;
        private System.Windows.Forms.Button btnBrowsePoseImage;
        private System.Windows.Forms.Label lblPoseImage;
        private System.Windows.Forms.TextBox txtPoseImage;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.Label lblOrigin;
        private System.Windows.Forms.Button btnBrowseSound;
        private System.Windows.Forms.Label lblSound;
        private System.Windows.Forms.TextBox txtSound;
        private System.Windows.Forms.OpenFileDialog ofdSound;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem miMagnification;
        private System.Windows.Forms.ToolStripMenuItem miMagnification50;
        private System.Windows.Forms.ToolStripMenuItem miMagnification100;
        private System.Windows.Forms.ToolStripMenuItem miMagnification200;
        private System.Windows.Forms.ToolStripMenuItem miMagnification300;
        private System.Windows.Forms.ToolStripMenuItem miMagnification400;
        private System.Windows.Forms.ToolStripMenuItem miMagnification800;
        private System.Windows.Forms.ToolStripMenuItem miMagnification1600;
        private System.Windows.Forms.ToolStripMenuItem miMagnificationZoomIn;
        private System.Windows.Forms.ToolStripMenuItem miMagnificationZoomOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem miRecentFiles;
        private System.Windows.Forms.ToolStripMenuItem miClearFrames;
        private System.Windows.Forms.CheckBox chkRequireCompletion;
        private System.Windows.Forms.ComboBox cbDefaultPose;
        private System.Windows.Forms.Label lblDefaultPose;
        private System.IO.FileSystemWatcher fswUpdatedImageWatcher;
        private System.Windows.Forms.ToolStripMenuItem miAutoReload;
        private System.Windows.Forms.ToolStripMenuItem miGridSelection;
        private System.Windows.Forms.Label lblFrameNumber;
        private System.Windows.Forms.ToolStripMenuItem miTransparent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.TabControl tbcSprite;
        private System.Windows.Forms.Button txtRemoveSound;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TextBox txtPitch;
        private System.Windows.Forms.Label lblPitch;
        private System.Windows.Forms.ToolStripMenuItem miPasteCsv;
        private System.Windows.Forms.ToolStripMenuItem miCheckEdges;
        private System.Windows.Forms.ToolStripMenuItem miOffsetFrames;
        private System.Windows.Forms.ToolStripMenuItem miOffsetFrame;
        private System.Windows.Forms.TextBox txtCompletionFrame;
        private System.Windows.Forms.TextBox txtFrameMarker;
        private System.Windows.Forms.Label lblFrameMarker;
    }
}


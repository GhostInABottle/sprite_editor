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
            this.components = new System.ComponentModel.Container();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.tbcSprite = new System.Windows.Forms.TabControl();
            this.tabSprite = new System.Windows.Forms.TabPage();
            this.cbDefaultPose = new System.Windows.Forms.ComboBox();
            this.lblDefaultPose = new System.Windows.Forms.Label();
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
            this.chkRequireCompletion = new System.Windows.Forms.CheckBox();
            this.btnPoseTransColor = new System.Windows.Forms.Button();
            this.lblPoseColor = new System.Windows.Forms.Label();
            this.btnBrowsePoseImage = new System.Windows.Forms.Button();
            this.lblPoseImage = new System.Windows.Forms.Label();
            this.txtPoseImage = new System.Windows.Forms.TextBox();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.lblOrigin = new System.Windows.Forms.Label();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.lblState = new System.Windows.Forms.Label();
            this.cbDirection = new System.Windows.Forms.ComboBox();
            this.lblDirection = new System.Windows.Forms.Label();
            this.lstFrames = new System.Windows.Forms.ListBox();
            this.mnuFrame = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miAddFrame = new System.Windows.Forms.ToolStripMenuItem();
            this.miCopyFrame = new System.Windows.Forms.ToolStripMenuItem();
            this.miPasteFrame = new System.Windows.Forms.ToolStripMenuItem();
            this.miRemoveFrame = new System.Windows.Forms.ToolStripMenuItem();
            this.miClearFrames = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddMultiple = new System.Windows.Forms.ToolStripMenuItem();
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
            this.lblFrameNumber = new System.Windows.Forms.Label();
            this.btnBrowseSound = new System.Windows.Forms.Button();
            this.lblSound = new System.Windows.Forms.Label();
            this.txtSound = new System.Windows.Forms.TextBox();
            this.txtOpacity = new System.Windows.Forms.TextBox();
            this.lblOpacity = new System.Windows.Forms.Label();
            this.btnFrameTransColor = new System.Windows.Forms.Button();
            this.lblFrameColor = new System.Windows.Forms.Label();
            this.btnBrowseFrameImage = new System.Windows.Forms.Button();
            this.lblFrameImage = new System.Windows.Forms.Label();
            this.txtFrameImage = new System.Windows.Forms.TextBox();
            this.btnNextFrame = new System.Windows.Forms.Button();
            this.btnPrevFrame = new System.Windows.Forms.Button();
            this.chkTween = new System.Windows.Forms.CheckBox();
            this.txtRectangle = new System.Windows.Forms.TextBox();
            this.lblRectangle = new System.Windows.Forms.Label();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.lblAngle = new System.Windows.Forms.Label();
            this.txtMagnification = new System.Windows.Forms.TextBox();
            this.lblMagnification = new System.Windows.Forms.Label();
            this.txtFrameDuration = new System.Windows.Forms.TextBox();
            this.lblFrameDuration = new System.Windows.Forms.Label();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miNew = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.miSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.miAutoReload = new System.Windows.Forms.ToolStripMenuItem();
            this.miRecentFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.miView = new System.Windows.Forms.ToolStripMenuItem();
            this.miFull = new System.Windows.Forms.ToolStripMenuItem();
            this.miPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.miAnimated = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miShowSrcRect = new System.Windows.Forms.ToolStripMenuItem();
            this.miShowBoundingBox = new System.Windows.Forms.ToolStripMenuItem();
            this.miTransparent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.miShowGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.miGridSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.miGridSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.miMagnification = new System.Windows.Forms.ToolStripMenuItem();
            this.miMagnification50 = new System.Windows.Forms.ToolStripMenuItem();
            this.miMagnification100 = new System.Windows.Forms.ToolStripMenuItem();
            this.miMagnification200 = new System.Windows.Forms.ToolStripMenuItem();
            this.miMagnification400 = new System.Windows.Forms.ToolStripMenuItem();
            this.miMagnification800 = new System.Windows.Forms.ToolStripMenuItem();
            this.miMagnification1600 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.miMagnificationZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.miMagnificationZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stlMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.ofdSprite = new System.Windows.Forms.OpenFileDialog();
            this.sfdSprite = new System.Windows.Forms.SaveFileDialog();
            this.cdTransparentColor = new System.Windows.Forms.ColorDialog();
            this.fbdBase = new System.Windows.Forms.FolderBrowserDialog();
            this.ofdSound = new System.Windows.Forms.OpenFileDialog();
            this.fswUpdatedImageWatcher = new System.IO.FileSystemWatcher();
            this.pnlSprite = new SpriteEditor.FlickerFreePanel();
            this.tbcSprite.SuspendLayout();
            this.tabSprite.SuspendLayout();
            this.mnuPose.SuspendLayout();
            this.tabPose.SuspendLayout();
            this.mnuFrame.SuspendLayout();
            this.tabFrame.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fswUpdatedImageWatcher)).BeginInit();
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
            this.tbcSprite.Location = new System.Drawing.Point(882, 31);
            this.tbcSprite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbcSprite.Multiline = true;
            this.tbcSprite.Name = "tbcSprite";
            this.tbcSprite.SelectedIndex = 0;
            this.tbcSprite.Size = new System.Drawing.Size(280, 767);
            this.tbcSprite.TabIndex = 1;
            // 
            // tabSprite
            // 
            this.tabSprite.BackColor = System.Drawing.Color.Transparent;
            this.tabSprite.Controls.Add(this.cbDefaultPose);
            this.tabSprite.Controls.Add(this.lblDefaultPose);
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
            this.tabSprite.Location = new System.Drawing.Point(4, 24);
            this.tabSprite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabSprite.Name = "tabSprite";
            this.tabSprite.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabSprite.Size = new System.Drawing.Size(272, 739);
            this.tabSprite.TabIndex = 0;
            this.tabSprite.Text = "Sprite";
            // 
            // cbDefaultPose
            // 
            this.cbDefaultPose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDefaultPose.FormattingEnabled = true;
            this.cbDefaultPose.Location = new System.Drawing.Point(10, 152);
            this.cbDefaultPose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbDefaultPose.Name = "cbDefaultPose";
            this.cbDefaultPose.Size = new System.Drawing.Size(245, 23);
            this.cbDefaultPose.TabIndex = 18;
            this.cbDefaultPose.SelectedIndexChanged += new System.EventHandler(this.cbDefaultPose_SelectedIndexChanged);
            // 
            // lblDefaultPose
            // 
            this.lblDefaultPose.AutoSize = true;
            this.lblDefaultPose.Location = new System.Drawing.Point(7, 134);
            this.lblDefaultPose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDefaultPose.Name = "lblDefaultPose";
            this.lblDefaultPose.Size = new System.Drawing.Size(73, 15);
            this.lblDefaultPose.TabIndex = 17;
            this.lblDefaultPose.Text = "Default Pose";
            // 
            // lblBaseFolder
            // 
            this.lblBaseFolder.AutoSize = true;
            this.lblBaseFolder.Location = new System.Drawing.Point(7, 7);
            this.lblBaseFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaseFolder.Name = "lblBaseFolder";
            this.lblBaseFolder.Size = new System.Drawing.Size(67, 15);
            this.lblBaseFolder.TabIndex = 16;
            this.lblBaseFolder.Text = "Base Folder";
            // 
            // btnBrowseFolder
            // 
            this.btnBrowseFolder.Location = new System.Drawing.Point(220, 25);
            this.btnBrowseFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new System.Drawing.Size(36, 23);
            this.btnBrowseFolder.TabIndex = 15;
            this.btnBrowseFolder.Text = "...";
            this.btnBrowseFolder.UseVisualStyleBackColor = true;
            this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
            // 
            // txtBase
            // 
            this.txtBase.Enabled = false;
            this.txtBase.Location = new System.Drawing.Point(10, 25);
            this.txtBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(199, 23);
            this.txtBase.TabIndex = 14;
            // 
            // btnTransColor
            // 
            this.btnTransColor.Location = new System.Drawing.Point(120, 100);
            this.btnTransColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTransColor.Name = "btnTransColor";
            this.btnTransColor.Size = new System.Drawing.Size(22, 21);
            this.btnTransColor.TabIndex = 13;
            this.btnTransColor.UseVisualStyleBackColor = false;
            this.btnTransColor.Click += new System.EventHandler(this.btnTransColor_Click);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(7, 106);
            this.lblColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(100, 15);
            this.lblColor.TabIndex = 12;
            this.lblColor.Text = "Transparent Color";
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Location = new System.Drawing.Point(220, 70);
            this.btnBrowseImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(36, 23);
            this.btnBrowseImage.TabIndex = 11;
            this.btnBrowseImage.Text = "...";
            this.btnBrowseImage.UseVisualStyleBackColor = true;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // lstPoses
            // 
            this.lstPoses.ContextMenuStrip = this.mnuPose;
            this.lstPoses.FormattingEnabled = true;
            this.lstPoses.ItemHeight = 15;
            this.lstPoses.Location = new System.Drawing.Point(7, 196);
            this.lstPoses.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstPoses.Name = "lstPoses";
            this.lstPoses.Size = new System.Drawing.Size(249, 529);
            this.lstPoses.TabIndex = 5;
            this.lstPoses.SelectedIndexChanged += new System.EventHandler(this.lstPoses_SelectedIndexChanged);
            this.lstPoses.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstPoses_KeyUp);
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
            this.lblPoses.Location = new System.Drawing.Point(7, 180);
            this.lblPoses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPoses.Name = "lblPoses";
            this.lblPoses.Size = new System.Drawing.Size(37, 15);
            this.lblPoses.TabIndex = 4;
            this.lblPoses.Text = "Poses";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(7, 52);
            this.lblImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(40, 15);
            this.lblImage.TabIndex = 1;
            this.lblImage.Text = "Image";
            // 
            // txtImage
            // 
            this.txtImage.Enabled = false;
            this.txtImage.Location = new System.Drawing.Point(10, 70);
            this.txtImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(199, 23);
            this.txtImage.TabIndex = 0;
            // 
            // tabPose
            // 
            this.tabPose.BackColor = System.Drawing.Color.Transparent;
            this.tabPose.Controls.Add(this.chkRequireCompletion);
            this.tabPose.Controls.Add(this.btnPoseTransColor);
            this.tabPose.Controls.Add(this.lblPoseColor);
            this.tabPose.Controls.Add(this.btnBrowsePoseImage);
            this.tabPose.Controls.Add(this.lblPoseImage);
            this.tabPose.Controls.Add(this.txtPoseImage);
            this.tabPose.Controls.Add(this.txtOrigin);
            this.tabPose.Controls.Add(this.lblOrigin);
            this.tabPose.Controls.Add(this.cbState);
            this.tabPose.Controls.Add(this.lblState);
            this.tabPose.Controls.Add(this.cbDirection);
            this.tabPose.Controls.Add(this.lblDirection);
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
            this.tabPose.Location = new System.Drawing.Point(4, 24);
            this.tabPose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPose.Name = "tabPose";
            this.tabPose.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPose.Size = new System.Drawing.Size(272, 739);
            this.tabPose.TabIndex = 1;
            this.tabPose.Text = "Pose";
            // 
            // chkRequireCompletion
            // 
            this.chkRequireCompletion.AutoSize = true;
            this.chkRequireCompletion.Enabled = false;
            this.chkRequireCompletion.Location = new System.Drawing.Point(142, 114);
            this.chkRequireCompletion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkRequireCompletion.Name = "chkRequireCompletion";
            this.chkRequireCompletion.Size = new System.Drawing.Size(111, 19);
            this.chkRequireCompletion.TabIndex = 8;
            this.chkRequireCompletion.Text = "Must complete?";
            this.chkRequireCompletion.UseVisualStyleBackColor = true;
            this.chkRequireCompletion.CheckedChanged += new System.EventHandler(this.chkRequireCompletion_CheckedChanged);
            // 
            // btnPoseTransColor
            // 
            this.btnPoseTransColor.Location = new System.Drawing.Point(120, 367);
            this.btnPoseTransColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPoseTransColor.Name = "btnPoseTransColor";
            this.btnPoseTransColor.Size = new System.Drawing.Size(22, 21);
            this.btnPoseTransColor.TabIndex = 22;
            this.btnPoseTransColor.UseVisualStyleBackColor = false;
            this.btnPoseTransColor.Click += new System.EventHandler(this.btnPoseTransColor_Click);
            // 
            // lblPoseColor
            // 
            this.lblPoseColor.AutoSize = true;
            this.lblPoseColor.Location = new System.Drawing.Point(7, 373);
            this.lblPoseColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPoseColor.Name = "lblPoseColor";
            this.lblPoseColor.Size = new System.Drawing.Size(100, 15);
            this.lblPoseColor.TabIndex = 21;
            this.lblPoseColor.Text = "Transparent Color";
            // 
            // btnBrowsePoseImage
            // 
            this.btnBrowsePoseImage.Location = new System.Drawing.Point(224, 342);
            this.btnBrowsePoseImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBrowsePoseImage.Name = "btnBrowsePoseImage";
            this.btnBrowsePoseImage.Size = new System.Drawing.Size(36, 23);
            this.btnBrowsePoseImage.TabIndex = 20;
            this.btnBrowsePoseImage.Text = "...";
            this.btnBrowsePoseImage.UseVisualStyleBackColor = true;
            this.btnBrowsePoseImage.Click += new System.EventHandler(this.btnBrowsePoseImage_Click);
            // 
            // lblPoseImage
            // 
            this.lblPoseImage.AutoSize = true;
            this.lblPoseImage.Location = new System.Drawing.Point(8, 322);
            this.lblPoseImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPoseImage.Name = "lblPoseImage";
            this.lblPoseImage.Size = new System.Drawing.Size(40, 15);
            this.lblPoseImage.TabIndex = 18;
            this.lblPoseImage.Text = "Image";
            // 
            // txtPoseImage
            // 
            this.txtPoseImage.Enabled = false;
            this.txtPoseImage.Location = new System.Drawing.Point(12, 343);
            this.txtPoseImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPoseImage.Name = "txtPoseImage";
            this.txtPoseImage.Size = new System.Drawing.Size(205, 23);
            this.txtPoseImage.TabIndex = 19;
            // 
            // txtOrigin
            // 
            this.txtOrigin.Location = new System.Drawing.Point(10, 202);
            this.txtOrigin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(249, 23);
            this.txtOrigin.TabIndex = 13;
            this.txtOrigin.TextChanged += new System.EventHandler(this.txtOrigin_TextChanged);
            // 
            // lblOrigin
            // 
            this.lblOrigin.AutoSize = true;
            this.lblOrigin.Location = new System.Drawing.Point(7, 183);
            this.lblOrigin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Size = new System.Drawing.Size(40, 15);
            this.lblOrigin.TabIndex = 12;
            this.lblOrigin.Text = "Origin";
            // 
            // cbState
            // 
            this.cbState.FormattingEnabled = true;
            this.cbState.Location = new System.Drawing.Point(10, 294);
            this.cbState.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(249, 23);
            this.cbState.TabIndex = 17;
            this.cbState.DropDown += new System.EventHandler(this.cbState_DropDown);
            this.cbState.SelectedIndexChanged += new System.EventHandler(this.cbState_SelectedIndexChanged);
            this.cbState.TextChanged += new System.EventHandler(this.cbState_TextChanged);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(7, 275);
            this.lblState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(33, 15);
            this.lblState.TabIndex = 16;
            this.lblState.Text = "State";
            // 
            // cbDirection
            // 
            this.cbDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDirection.FormattingEnabled = true;
            this.cbDirection.Items.AddRange(new object[] {
            "None",
            "Up",
            "Right",
            "Down",
            "Left",
            "Up|Right",
            "Up|Left",
            "Down|Right",
            "Down|Left"});
            this.cbDirection.Location = new System.Drawing.Point(10, 247);
            this.cbDirection.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbDirection.Name = "cbDirection";
            this.cbDirection.Size = new System.Drawing.Size(249, 23);
            this.cbDirection.TabIndex = 15;
            this.cbDirection.SelectedIndexChanged += new System.EventHandler(this.cbDirection_SelectedIndexChanged);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(7, 227);
            this.lblDirection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(55, 15);
            this.lblDirection.TabIndex = 14;
            this.lblDirection.Text = "Direction";
            // 
            // lstFrames
            // 
            this.lstFrames.AllowDrop = true;
            this.lstFrames.ContextMenuStrip = this.mnuFrame;
            this.lstFrames.FormattingEnabled = true;
            this.lstFrames.ItemHeight = 15;
            this.lstFrames.Location = new System.Drawing.Point(12, 412);
            this.lstFrames.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstFrames.Name = "lstFrames";
            this.lstFrames.Size = new System.Drawing.Size(248, 304);
            this.lstFrames.TabIndex = 24;
            this.lstFrames.SelectedIndexChanged += new System.EventHandler(this.lstFrames_SelectedIndexChanged);
            this.lstFrames.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstFrames_DragDrop);
            this.lstFrames.DragOver += new System.Windows.Forms.DragEventHandler(this.lstFrames_DragOver);
            this.lstFrames.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstFrames_KeyUp);
            this.lstFrames.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstFrames_MouseDown);
            // 
            // mnuFrame
            // 
            this.mnuFrame.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAddFrame,
            this.miCopyFrame,
            this.miPasteFrame,
            this.miRemoveFrame,
            this.miClearFrames,
            this.miAddMultiple});
            this.mnuFrame.Name = "mnuPose";
            this.mnuFrame.Size = new System.Drawing.Size(144, 136);
            this.mnuFrame.Opening += new System.ComponentModel.CancelEventHandler(this.mnuFrame_Opening);
            // 
            // miAddFrame
            // 
            this.miAddFrame.Name = "miAddFrame";
            this.miAddFrame.Size = new System.Drawing.Size(143, 22);
            this.miAddFrame.Text = "Add";
            this.miAddFrame.Click += new System.EventHandler(this.miAddFrame_Click);
            // 
            // miCopyFrame
            // 
            this.miCopyFrame.Enabled = false;
            this.miCopyFrame.Name = "miCopyFrame";
            this.miCopyFrame.Size = new System.Drawing.Size(143, 22);
            this.miCopyFrame.Text = "Copy";
            this.miCopyFrame.Click += new System.EventHandler(this.miCopyFrame_Click);
            // 
            // miPasteFrame
            // 
            this.miPasteFrame.Enabled = false;
            this.miPasteFrame.Name = "miPasteFrame";
            this.miPasteFrame.Size = new System.Drawing.Size(143, 22);
            this.miPasteFrame.Text = "Paste";
            this.miPasteFrame.Click += new System.EventHandler(this.miPasteFrame_Click);
            // 
            // miRemoveFrame
            // 
            this.miRemoveFrame.Name = "miRemoveFrame";
            this.miRemoveFrame.Size = new System.Drawing.Size(143, 22);
            this.miRemoveFrame.Text = "Remove";
            this.miRemoveFrame.Click += new System.EventHandler(this.miRemoveFrame_Click);
            // 
            // miClearFrames
            // 
            this.miClearFrames.Name = "miClearFrames";
            this.miClearFrames.Size = new System.Drawing.Size(143, 22);
            this.miClearFrames.Text = "Clear";
            this.miClearFrames.Click += new System.EventHandler(this.miClearFrames_Click);
            // 
            // miAddMultiple
            // 
            this.miAddMultiple.Name = "miAddMultiple";
            this.miAddMultiple.Size = new System.Drawing.Size(143, 22);
            this.miAddMultiple.Text = "Add Multiple";
            this.miAddMultiple.Click += new System.EventHandler(this.miAddMultiple_Click);
            // 
            // lblFrames
            // 
            this.lblFrames.AutoSize = true;
            this.lblFrames.Location = new System.Drawing.Point(8, 393);
            this.lblFrames.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrames.Name = "lblFrames";
            this.lblFrames.Size = new System.Drawing.Size(45, 15);
            this.lblFrames.TabIndex = 23;
            this.lblFrames.Text = "Frames";
            // 
            // txtBoundingBox
            // 
            this.txtBoundingBox.Location = new System.Drawing.Point(10, 157);
            this.txtBoundingBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBoundingBox.Name = "txtBoundingBox";
            this.txtBoundingBox.Size = new System.Drawing.Size(249, 23);
            this.txtBoundingBox.TabIndex = 11;
            this.txtBoundingBox.TextChanged += new System.EventHandler(this.txtBoundingBox_TextChanged);
            // 
            // lblBoundingBox
            // 
            this.lblBoundingBox.AutoSize = true;
            this.lblBoundingBox.Location = new System.Drawing.Point(7, 138);
            this.lblBoundingBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBoundingBox.Name = "lblBoundingBox";
            this.lblBoundingBox.Size = new System.Drawing.Size(82, 15);
            this.lblBoundingBox.TabIndex = 10;
            this.lblBoundingBox.Text = "Bounding Box";
            // 
            // txtRepeats
            // 
            this.txtRepeats.Location = new System.Drawing.Point(10, 112);
            this.txtRepeats.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRepeats.Name = "txtRepeats";
            this.txtRepeats.Size = new System.Drawing.Size(124, 23);
            this.txtRepeats.TabIndex = 7;
            this.txtRepeats.TextChanged += new System.EventHandler(this.txtRepeats_TextChanged);
            // 
            // lblRepeats
            // 
            this.lblRepeats.AutoSize = true;
            this.lblRepeats.Location = new System.Drawing.Point(7, 93);
            this.lblRepeats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRepeats.Name = "lblRepeats";
            this.lblRepeats.Size = new System.Drawing.Size(48, 15);
            this.lblRepeats.TabIndex = 6;
            this.lblRepeats.Text = "Repeats";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(10, 67);
            this.txtDuration.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(249, 23);
            this.txtDuration.TabIndex = 5;
            this.txtDuration.TextChanged += new System.EventHandler(this.txtDuration_TextChanged);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(7, 48);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(53, 15);
            this.lblDuration.TabIndex = 4;
            this.lblDuration.Text = "Duration";
            // 
            // txtPoseName
            // 
            this.txtPoseName.Location = new System.Drawing.Point(10, 22);
            this.txtPoseName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPoseName.Name = "txtPoseName";
            this.txtPoseName.Size = new System.Drawing.Size(249, 23);
            this.txtPoseName.TabIndex = 3;
            this.txtPoseName.TextChanged += new System.EventHandler(this.txtPoseName_TextChanged);
            // 
            // lblPoseName
            // 
            this.lblPoseName.AutoSize = true;
            this.lblPoseName.Location = new System.Drawing.Point(7, 3);
            this.lblPoseName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPoseName.Name = "lblPoseName";
            this.lblPoseName.Size = new System.Drawing.Size(39, 15);
            this.lblPoseName.TabIndex = 2;
            this.lblPoseName.Text = "Name";
            // 
            // tabFrame
            // 
            this.tabFrame.BackColor = System.Drawing.Color.Transparent;
            this.tabFrame.Controls.Add(this.lblFrameNumber);
            this.tabFrame.Controls.Add(this.btnBrowseSound);
            this.tabFrame.Controls.Add(this.lblSound);
            this.tabFrame.Controls.Add(this.txtSound);
            this.tabFrame.Controls.Add(this.txtOpacity);
            this.tabFrame.Controls.Add(this.lblOpacity);
            this.tabFrame.Controls.Add(this.btnFrameTransColor);
            this.tabFrame.Controls.Add(this.lblFrameColor);
            this.tabFrame.Controls.Add(this.btnBrowseFrameImage);
            this.tabFrame.Controls.Add(this.lblFrameImage);
            this.tabFrame.Controls.Add(this.txtFrameImage);
            this.tabFrame.Controls.Add(this.btnNextFrame);
            this.tabFrame.Controls.Add(this.btnPrevFrame);
            this.tabFrame.Controls.Add(this.chkTween);
            this.tabFrame.Controls.Add(this.txtRectangle);
            this.tabFrame.Controls.Add(this.lblRectangle);
            this.tabFrame.Controls.Add(this.txtAngle);
            this.tabFrame.Controls.Add(this.lblAngle);
            this.tabFrame.Controls.Add(this.txtMagnification);
            this.tabFrame.Controls.Add(this.lblMagnification);
            this.tabFrame.Controls.Add(this.txtFrameDuration);
            this.tabFrame.Controls.Add(this.lblFrameDuration);
            this.tabFrame.Location = new System.Drawing.Point(4, 24);
            this.tabFrame.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabFrame.Name = "tabFrame";
            this.tabFrame.Size = new System.Drawing.Size(272, 739);
            this.tabFrame.TabIndex = 2;
            this.tabFrame.Text = "Frame";
            // 
            // lblFrameNumber
            // 
            this.lblFrameNumber.AutoSize = true;
            this.lblFrameNumber.Location = new System.Drawing.Point(126, 402);
            this.lblFrameNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrameNumber.Name = "lblFrameNumber";
            this.lblFrameNumber.Size = new System.Drawing.Size(14, 15);
            this.lblFrameNumber.TabIndex = 27;
            this.lblFrameNumber.Text = "#";
            // 
            // btnBrowseSound
            // 
            this.btnBrowseSound.Location = new System.Drawing.Point(224, 276);
            this.btnBrowseSound.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBrowseSound.Name = "btnBrowseSound";
            this.btnBrowseSound.Size = new System.Drawing.Size(36, 23);
            this.btnBrowseSound.TabIndex = 26;
            this.btnBrowseSound.Text = "...";
            this.btnBrowseSound.UseVisualStyleBackColor = true;
            this.btnBrowseSound.Click += new System.EventHandler(this.btnBrowseSound_Click);
            // 
            // lblSound
            // 
            this.lblSound.AutoSize = true;
            this.lblSound.Location = new System.Drawing.Point(7, 255);
            this.lblSound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSound.Name = "lblSound";
            this.lblSound.Size = new System.Drawing.Size(41, 15);
            this.lblSound.TabIndex = 25;
            this.lblSound.Text = "Sound";
            // 
            // txtSound
            // 
            this.txtSound.Enabled = false;
            this.txtSound.Location = new System.Drawing.Point(10, 276);
            this.txtSound.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSound.Name = "txtSound";
            this.txtSound.Size = new System.Drawing.Size(206, 23);
            this.txtSound.TabIndex = 24;
            // 
            // txtOpacity
            // 
            this.txtOpacity.Location = new System.Drawing.Point(10, 183);
            this.txtOpacity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOpacity.Name = "txtOpacity";
            this.txtOpacity.Size = new System.Drawing.Size(249, 23);
            this.txtOpacity.TabIndex = 23;
            this.txtOpacity.TextChanged += new System.EventHandler(this.txtOpacity_TextChanged);
            // 
            // lblOpacity
            // 
            this.lblOpacity.AutoSize = true;
            this.lblOpacity.Location = new System.Drawing.Point(7, 165);
            this.lblOpacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpacity.Name = "lblOpacity";
            this.lblOpacity.Size = new System.Drawing.Size(48, 15);
            this.lblOpacity.TabIndex = 22;
            this.lblOpacity.Text = "Opacity";
            // 
            // btnFrameTransColor
            // 
            this.btnFrameTransColor.Location = new System.Drawing.Point(120, 354);
            this.btnFrameTransColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFrameTransColor.Name = "btnFrameTransColor";
            this.btnFrameTransColor.Size = new System.Drawing.Size(22, 21);
            this.btnFrameTransColor.TabIndex = 21;
            this.btnFrameTransColor.UseVisualStyleBackColor = false;
            this.btnFrameTransColor.Click += new System.EventHandler(this.btnFrameTransColor_Click);
            // 
            // lblFrameColor
            // 
            this.lblFrameColor.AutoSize = true;
            this.lblFrameColor.Location = new System.Drawing.Point(7, 360);
            this.lblFrameColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrameColor.Name = "lblFrameColor";
            this.lblFrameColor.Size = new System.Drawing.Size(100, 15);
            this.lblFrameColor.TabIndex = 20;
            this.lblFrameColor.Text = "Transparent Color";
            // 
            // btnBrowseFrameImage
            // 
            this.btnBrowseFrameImage.Location = new System.Drawing.Point(224, 324);
            this.btnBrowseFrameImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBrowseFrameImage.Name = "btnBrowseFrameImage";
            this.btnBrowseFrameImage.Size = new System.Drawing.Size(36, 23);
            this.btnBrowseFrameImage.TabIndex = 19;
            this.btnBrowseFrameImage.Text = "...";
            this.btnBrowseFrameImage.UseVisualStyleBackColor = true;
            this.btnBrowseFrameImage.Click += new System.EventHandler(this.btnBrowseFrameImage_Click);
            // 
            // lblFrameImage
            // 
            this.lblFrameImage.AutoSize = true;
            this.lblFrameImage.Location = new System.Drawing.Point(7, 306);
            this.lblFrameImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrameImage.Name = "lblFrameImage";
            this.lblFrameImage.Size = new System.Drawing.Size(40, 15);
            this.lblFrameImage.TabIndex = 18;
            this.lblFrameImage.Text = "Image";
            // 
            // txtFrameImage
            // 
            this.txtFrameImage.Enabled = false;
            this.txtFrameImage.Location = new System.Drawing.Point(10, 324);
            this.txtFrameImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFrameImage.Name = "txtFrameImage";
            this.txtFrameImage.Size = new System.Drawing.Size(206, 23);
            this.txtFrameImage.TabIndex = 17;
            // 
            // btnNextFrame
            // 
            this.btnNextFrame.Location = new System.Drawing.Point(158, 396);
            this.btnNextFrame.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNextFrame.Name = "btnNextFrame";
            this.btnNextFrame.Size = new System.Drawing.Size(103, 27);
            this.btnNextFrame.TabIndex = 16;
            this.btnNextFrame.Text = "Next Frame";
            this.btnNextFrame.UseVisualStyleBackColor = true;
            this.btnNextFrame.Click += new System.EventHandler(this.btnNextFrame_Click);
            // 
            // btnPrevFrame
            // 
            this.btnPrevFrame.Location = new System.Drawing.Point(13, 396);
            this.btnPrevFrame.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPrevFrame.Name = "btnPrevFrame";
            this.btnPrevFrame.Size = new System.Drawing.Size(103, 27);
            this.btnPrevFrame.TabIndex = 15;
            this.btnPrevFrame.Text = "Prev. Frame";
            this.btnPrevFrame.UseVisualStyleBackColor = true;
            this.btnPrevFrame.Click += new System.EventHandler(this.btnPrevFrame_Click);
            // 
            // chkTween
            // 
            this.chkTween.AutoSize = true;
            this.chkTween.Location = new System.Drawing.Point(10, 7);
            this.chkTween.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkTween.Name = "chkTween";
            this.chkTween.Size = new System.Drawing.Size(92, 19);
            this.chkTween.TabIndex = 14;
            this.chkTween.Text = "TweenFrame";
            this.chkTween.UseVisualStyleBackColor = true;
            this.chkTween.CheckedChanged += new System.EventHandler(this.chkTween_CheckedChanged);
            // 
            // txtRectangle
            // 
            this.txtRectangle.Location = new System.Drawing.Point(10, 228);
            this.txtRectangle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRectangle.Name = "txtRectangle";
            this.txtRectangle.Size = new System.Drawing.Size(249, 23);
            this.txtRectangle.TabIndex = 12;
            this.txtRectangle.TextChanged += new System.EventHandler(this.txtRectangle_TextChanged);
            // 
            // lblRectangle
            // 
            this.lblRectangle.AutoSize = true;
            this.lblRectangle.Location = new System.Drawing.Point(7, 210);
            this.lblRectangle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRectangle.Name = "lblRectangle";
            this.lblRectangle.Size = new System.Drawing.Size(98, 15);
            this.lblRectangle.TabIndex = 11;
            this.lblRectangle.Text = "Source Rectangle";
            // 
            // txtAngle
            // 
            this.txtAngle.Location = new System.Drawing.Point(10, 138);
            this.txtAngle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(249, 23);
            this.txtAngle.TabIndex = 10;
            this.txtAngle.TextChanged += new System.EventHandler(this.txtAngle_TextChanged);
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Location = new System.Drawing.Point(7, 120);
            this.lblAngle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(38, 15);
            this.lblAngle.TabIndex = 9;
            this.lblAngle.Text = "Angle";
            // 
            // txtMagnification
            // 
            this.txtMagnification.Location = new System.Drawing.Point(10, 93);
            this.txtMagnification.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMagnification.Name = "txtMagnification";
            this.txtMagnification.Size = new System.Drawing.Size(249, 23);
            this.txtMagnification.TabIndex = 6;
            this.txtMagnification.TextChanged += new System.EventHandler(this.txtMagnification_TextChanged);
            // 
            // lblMagnification
            // 
            this.lblMagnification.AutoSize = true;
            this.lblMagnification.Location = new System.Drawing.Point(7, 75);
            this.lblMagnification.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMagnification.Name = "lblMagnification";
            this.lblMagnification.Size = new System.Drawing.Size(81, 15);
            this.lblMagnification.TabIndex = 5;
            this.lblMagnification.Text = "Magnification";
            // 
            // txtFrameDuration
            // 
            this.txtFrameDuration.Location = new System.Drawing.Point(10, 48);
            this.txtFrameDuration.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFrameDuration.Name = "txtFrameDuration";
            this.txtFrameDuration.Size = new System.Drawing.Size(249, 23);
            this.txtFrameDuration.TabIndex = 4;
            this.txtFrameDuration.TextChanged += new System.EventHandler(this.txtFrameDuration_TextChanged);
            // 
            // lblFrameDuration
            // 
            this.lblFrameDuration.AutoSize = true;
            this.lblFrameDuration.Location = new System.Drawing.Point(7, 30);
            this.lblFrameDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrameDuration.Name = "lblFrameDuration";
            this.lblFrameDuration.Size = new System.Drawing.Size(53, 15);
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
            this.miView});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mnuMain.Size = new System.Drawing.Size(1176, 24);
            this.mnuMain.TabIndex = 7;
            this.mnuMain.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNew,
            this.miOpen,
            this.miSave,
            this.miSaveAs,
            this.miAutoReload,
            this.miRecentFiles});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(37, 20);
            this.miFile.Text = "&File";
            // 
            // miNew
            // 
            this.miNew.Name = "miNew";
            this.miNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.miNew.Size = new System.Drawing.Size(182, 22);
            this.miNew.Text = "&New";
            this.miNew.Click += new System.EventHandler(this.miNew_Click);
            // 
            // miOpen
            // 
            this.miOpen.Name = "miOpen";
            this.miOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.miOpen.Size = new System.Drawing.Size(182, 22);
            this.miOpen.Text = "&Open...";
            this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
            // 
            // miSave
            // 
            this.miSave.Name = "miSave";
            this.miSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.miSave.Size = new System.Drawing.Size(182, 22);
            this.miSave.Text = "&Save";
            this.miSave.Click += new System.EventHandler(this.miSave_Click);
            // 
            // miSaveAs
            // 
            this.miSaveAs.Name = "miSaveAs";
            this.miSaveAs.Size = new System.Drawing.Size(182, 22);
            this.miSaveAs.Text = "Save &As...";
            this.miSaveAs.Click += new System.EventHandler(this.miSaveAs_Click);
            // 
            // miAutoReload
            // 
            this.miAutoReload.CheckOnClick = true;
            this.miAutoReload.Name = "miAutoReload";
            this.miAutoReload.Size = new System.Drawing.Size(182, 22);
            this.miAutoReload.Text = "Auto-Reload Images";
            this.miAutoReload.CheckedChanged += new System.EventHandler(this.miAutoReload_CheckedChanged);
            // 
            // miRecentFiles
            // 
            this.miRecentFiles.Name = "miRecentFiles";
            this.miRecentFiles.Size = new System.Drawing.Size(182, 22);
            this.miRecentFiles.Text = "Recent Files";
            // 
            // miView
            // 
            this.miView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFull,
            this.miPreview,
            this.miAnimated,
            this.toolStripSeparator1,
            this.miShowSrcRect,
            this.miShowBoundingBox,
            this.miTransparent,
            this.toolStripSeparator2,
            this.miShowGrid,
            this.miGridSelection,
            this.miGridSettings,
            this.toolStripSeparator4,
            this.miMagnification});
            this.miView.Name = "miView";
            this.miView.Size = new System.Drawing.Size(44, 20);
            this.miView.Text = "&View";
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
            // miTransparent
            // 
            this.miTransparent.CheckOnClick = true;
            this.miTransparent.Name = "miTransparent";
            this.miTransparent.Size = new System.Drawing.Size(223, 22);
            this.miTransparent.Text = "Use Transparent Color";
            this.miTransparent.CheckedChanged += new System.EventHandler(this.miTransparent_CheckedChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(220, 6);
            // 
            // miShowGrid
            // 
            this.miShowGrid.CheckOnClick = true;
            this.miShowGrid.Name = "miShowGrid";
            this.miShowGrid.Size = new System.Drawing.Size(223, 22);
            this.miShowGrid.Text = "Show Grid";
            this.miShowGrid.CheckedChanged += new System.EventHandler(this.miShowGrid_CheckChanged);
            // 
            // miGridSelection
            // 
            this.miGridSelection.CheckOnClick = true;
            this.miGridSelection.Name = "miGridSelection";
            this.miGridSelection.Size = new System.Drawing.Size(223, 22);
            this.miGridSelection.Text = "Grid Selection";
            this.miGridSelection.CheckedChanged += new System.EventHandler(this.miGridSelection_CheckedChanged);
            // 
            // miGridSettings
            // 
            this.miGridSettings.Name = "miGridSettings";
            this.miGridSettings.Size = new System.Drawing.Size(223, 22);
            this.miGridSettings.Text = "Grid Settings...";
            this.miGridSettings.Click += new System.EventHandler(this.miGridSettings_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(220, 6);
            // 
            // miMagnification
            // 
            this.miMagnification.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miMagnification50,
            this.miMagnification100,
            this.miMagnification200,
            this.miMagnification400,
            this.miMagnification800,
            this.miMagnification1600,
            this.toolStripSeparator3,
            this.miMagnificationZoomIn,
            this.miMagnificationZoomOut});
            this.miMagnification.Name = "miMagnification";
            this.miMagnification.Size = new System.Drawing.Size(223, 22);
            this.miMagnification.Text = "Magnification";
            // 
            // miMagnification50
            // 
            this.miMagnification50.Name = "miMagnification50";
            this.miMagnification50.Size = new System.Drawing.Size(168, 22);
            this.miMagnification50.Text = "50%";
            this.miMagnification50.Click += new System.EventHandler(this.miMagnification50_Click);
            // 
            // miMagnification100
            // 
            this.miMagnification100.Name = "miMagnification100";
            this.miMagnification100.ShortcutKeyDisplayString = "Ctrl+0";
            this.miMagnification100.Size = new System.Drawing.Size(168, 22);
            this.miMagnification100.Text = "100%";
            this.miMagnification100.Click += new System.EventHandler(this.miMagnification100_Click);
            // 
            // miMagnification200
            // 
            this.miMagnification200.Name = "miMagnification200";
            this.miMagnification200.Size = new System.Drawing.Size(168, 22);
            this.miMagnification200.Text = "200%";
            this.miMagnification200.Click += new System.EventHandler(this.miMagnification200_Click);
            // 
            // miMagnification400
            // 
            this.miMagnification400.Name = "miMagnification400";
            this.miMagnification400.Size = new System.Drawing.Size(168, 22);
            this.miMagnification400.Text = "400%";
            this.miMagnification400.Click += new System.EventHandler(this.miMagnification400_Click);
            // 
            // miMagnification800
            // 
            this.miMagnification800.Name = "miMagnification800";
            this.miMagnification800.Size = new System.Drawing.Size(168, 22);
            this.miMagnification800.Text = "800%";
            this.miMagnification800.Click += new System.EventHandler(this.miMagnification800_Click);
            // 
            // miMagnification1600
            // 
            this.miMagnification1600.Name = "miMagnification1600";
            this.miMagnification1600.Size = new System.Drawing.Size(168, 22);
            this.miMagnification1600.Text = "1600%";
            this.miMagnification1600.Click += new System.EventHandler(this.miMagnification1600_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(165, 6);
            // 
            // miMagnificationZoomIn
            // 
            this.miMagnificationZoomIn.Name = "miMagnificationZoomIn";
            this.miMagnificationZoomIn.ShortcutKeyDisplayString = "Ctrl++";
            this.miMagnificationZoomIn.Size = new System.Drawing.Size(168, 22);
            this.miMagnificationZoomIn.Text = "Zoom In";
            this.miMagnificationZoomIn.Click += new System.EventHandler(this.miMagnificationZoomIn_Click);
            // 
            // miMagnificationZoomOut
            // 
            this.miMagnificationZoomOut.Name = "miMagnificationZoomOut";
            this.miMagnificationZoomOut.ShortcutKeyDisplayString = "Ctrl+-";
            this.miMagnificationZoomOut.Size = new System.Drawing.Size(168, 22);
            this.miMagnificationZoomOut.Text = "Zoom Out";
            this.miMagnificationZoomOut.Click += new System.EventHandler(this.miMagnificationZoomOut_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stlMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 819);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1176, 22);
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
            this.ofdSprite.Filter = "Sprite and Image Files|*.spr;*.png|Sprite XML Files|*.spr|Image Files|*.png";
            this.ofdSprite.Title = "Select sprite file";
            // 
            // sfdSprite
            // 
            this.sfdSprite.FileName = "sprite.spr";
            this.sfdSprite.Filter = "Sprite XML Files|*.spr";
            this.sfdSprite.Title = "Save sprite file as...";
            // 
            // ofdSound
            // 
            this.ofdSound.Filter = "Sound files|*.wav;*.ogg;*.mp3";
            this.ofdSound.Title = "Select sprite image";
            // 
            // fswUpdatedImageWatcher
            // 
            this.fswUpdatedImageWatcher.EnableRaisingEvents = true;
            this.fswUpdatedImageWatcher.NotifyFilter = System.IO.NotifyFilters.LastWrite;
            this.fswUpdatedImageWatcher.SynchronizingObject = this;
            this.fswUpdatedImageWatcher.Changed += new System.IO.FileSystemEventHandler(this.fswUpdatedImageWatcher_Changed);
            // 
            // pnlSprite
            // 
            this.pnlSprite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSprite.Location = new System.Drawing.Point(0, 31);
            this.pnlSprite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlSprite.Name = "pnlSprite";
            this.pnlSprite.Size = new System.Drawing.Size(874, 767);
            this.pnlSprite.TabIndex = 0;
            this.pnlSprite.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSprite_Paint);
            this.pnlSprite.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlSprite_MouseClick);
            // 
            // FrmSprite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 841);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.pnlSprite);
            this.Controls.Add(this.tbcSprite);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FrmSprite";
            this.Text = "Sprite Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSprite_FormClosed);
            this.Load += new System.EventHandler(this.frmSprite_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSprite_KeyDown);
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
            ((System.ComponentModel.ISupportInitialize)(this.fswUpdatedImageWatcher)).EndInit();
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
    }
}


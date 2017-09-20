using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using SpriteEditor.Properties;

namespace SpriteEditor
{
    public partial class FrmSprite : Form
    {
        private static readonly Brush BackgroundBrush =
            new HatchBrush(HatchStyle.LargeCheckerBoard, Color.LightGray, Color.White);

        private static readonly Brush SourceRectBrush =
            new SolidBrush(Color.FromArgb(80, Color.Yellow));

        private SpriteLogic spriteLogic;
        private Pose selectedPose;
        private Frame selectedFrame;
        private Pose copiedPose;
        private Frame copiedFrame;
        private frmGridSize gridSizeForm = new frmGridSize();
        private frmAddFrames addFramesForm;

        public FrmSprite()
        {
            addFramesForm = new frmAddFrames(this);
            InitializeComponent();
        }

        public void AddFrames(
            int startX,
            int startY,
            int frameWidth,
            int frameHeight,
            int frameCount,
            bool isVertical,
            bool isRectangular,
            int perRow)
        {
            var img = string.IsNullOrEmpty(selectedPose.Image) ?
                spriteLogic.SpriteData.Image : selectedPose.Image;
            var bmp = openBitmap(img);
            if (bmp == null)
            {
                stlMessage.Text = "Error: Couldn't load bitmap";
                return;
            }

            if (!isRectangular)
            {
                perRow = frameCount;
            }

            int maxFrames = frameCount / perRow;
            if (frameCount % perRow != 0)
            {
                maxFrames++;
            }

            int maxRow = isVertical ? perRow : maxFrames;
            int maxColumn = isVertical ? maxFrames : perRow;

            var newFrames = new List<Frame>();
            try
            {
                newFrames = addFrameImplementation(
                                            bmp,
                                            startX,
                                            startY,
                                            frameWidth,
                                            frameHeight,
                                            frameCount,
                                            maxRow,
                                            maxColumn);
            }
            catch (ArgumentException ex)
            {
                stlMessage.Text = ex.Message;
            }

            selectedPose.Frames.AddRange(newFrames);
            populatePose(selectedPose);
            changeSelectedFrame(selectedPose.Frames.Count - 1);
            spriteLogic.Reset(Environment.TickCount);
        }

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

            spriteLogic.Dispose();
            base.Dispose(disposing);
        }

        private List<Frame> addFrameImplementation(
            Bitmap bmp,
            int startX,
            int startY,
            int frameWidth,
            int frameHeight,
            int frameCount,
            int maxRow,
            int maxColumn)
        {
            var newFrames = new List<Frame>();
            int counter = 1;
            for (int row = 0; row < maxRow; row++)
            {
                for (int column = 0; column < maxColumn; column++)
                {
                    int x = startX + column * frameWidth;
                    int y = startY + row * frameHeight;
                    if (x < 0 || y < 0 || x + frameWidth > bmp.Width || y + frameHeight > bmp.Height)
                    {
                        throw new ArgumentException("Error: Invalid frame positions " + row + ", " + column);
                    }

                    Rect rect = new Rect(x, y, frameWidth, frameHeight);
                    newFrames.Add(new Frame() { Rectangle = rect });

                    if (++counter > frameCount)
                    {
                        return newFrames;
                    }
                }
            }

            return newFrames;
        }

        private void frmSprite_Load(object sender, EventArgs e)
        {
            setViewChecked(Settings.Default.DisplayMode);
            miShowSrcRect.Checked = Settings.Default.ShowSrcRect;
            miShowBoundingBox.Checked = Settings.Default.ShowBoundingBox;
            miShowGrid.Checked = Settings.Default.ShowGrid;
            cbDirection.SelectedIndex = 0;
            var args = Environment.GetCommandLineArgs();
            bool opened = false;
            if (args.Length > 1 && File.Exists(args[1]))
            {
                opened = openSprite(args[1]);
            }

            if (!opened)
            {
                miNew_Click(sender, e);
            }
        }

        private void pnlSprite_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(pnlSprite.BackColor);
            var currentPose = spriteLogic.CurrentPose;
            var currentFrame = spriteLogic.CurrentFrame;
            if (currentPose == null || currentFrame == null)
            {
                return;
            }

            var image = spriteLogic.Image;
            var bmp = openBitmap(image);
            if (bmp == null)
            {
                return;
            }

            // Default values (for full sprite view)
            var midX = pnlSprite.Width / 2 - bmp.Width / 2;
            var midY = pnlSprite.Height / 2 - bmp.Height / 2;
            var source = new Rectangle(0, 0, bmp.Width, bmp.Height);
            var dest = new Rectangle(midX, midY, bmp.Width, bmp.Height);
            var transform = new Matrix();

            // Transformed values (for animated and non-animated views)
            if (miPreview.Checked || miAnimated.Checked)
            {
                if (miPreview.Checked && selectedFrame != null)
                {
                    currentFrame = selectedFrame;
                }

                source = (Rectangle)currentFrame.Rectangle;
                var magnifiedWidth = (int)(source.Width * currentFrame.Magnification.X);
                var magnifiedHeight = (int)(source.Height * currentFrame.Magnification.Y);
                midX = pnlSprite.Width / 2 - magnifiedWidth / 2;
                midY = pnlSprite.Height / 2 - magnifiedHeight / 2;
                dest = new Rectangle(midX, midY, magnifiedWidth, magnifiedHeight);
                var origin = new Point(
                                        (int)(midX + magnifiedWidth * currentPose.Origin.X),
                                        (int)(midY + magnifiedWidth * currentPose.Origin.Y));
                transform = e.Graphics.Transform;
                transform.RotateAt(currentFrame.Angle, origin);
            }

            e.Graphics.MultiplyTransform(transform);

            // Set alpha
            ImageAttributes attributes = new ImageAttributes();
            if (!Utilities.CheckClose(currentFrame.Opacity, 1.0f, 0.01f))
            {
                ColorMatrix matrix = new ColorMatrix
                {
                    Matrix33 = currentFrame.Opacity
                };
                attributes.SetColorMatrix(matrix);
            }

            // Draw the sprite
            e.Graphics.FillRectangle(BackgroundBrush, dest);
            e.Graphics.DrawImage(
                                    bmp,
                                    dest,
                                    source.X,
                                    source.Y,
                                    source.Width,
                                    source.Height,
                                    GraphicsUnit.Pixel,
                                    attributes);

            // Draw the grid
            if (Settings.Default.ShowGrid)
            {
                var pen = new Pen(Settings.Default.GridColor);
                var gridWidth = Settings.Default.GridWidth;
                var gridHeight = Settings.Default.GridHeight;
                for (int y = dest.Y; y <= dest.Y + dest.Height; y += gridHeight)
                {
                    for (int x = dest.X; x <= dest.X + dest.Width; x += gridWidth)
                    {
                        e.Graphics.DrawLine(pen, x, dest.Y, x, dest.Y + dest.Height);
                    }

                    e.Graphics.DrawLine(pen, dest.X, y, dest.X + dest.Width, y);
                }
            }

            // Draw bounding box in animated and non-animated views
            if (Settings.Default.ShowBoundingBox &&
                !miFull.Checked && selectedPose != null)
            {
                var box = (Rectangle)selectedPose.BoundingBox;
                if (box.X == -1)
                {
                    box.X = 0;
                }

                if (box.Y == -1)
                {
                    box.Y = 0;
                }

                if (box.Width == -1)
                {
                    box.Width = dest.Width;
                }

                if (box.Height == -1)
                {
                    box.Height = dest.Height;
                }

                box.X += midX;
                box.Y += midY;
                e.Graphics.DrawRectangle(new Pen(Color.Black), box);
            }

            // Draw source rect in full sprite view
            if (Settings.Default.ShowSrcRect && 
                miFull.Checked && selectedFrame != null)
            {
                var currentRect = (Rectangle)selectedFrame.Rectangle;
                currentRect.X += midX;
                currentRect.Y += midY;
                e.Graphics.FillRectangle(SourceRectBrush, currentRect);
            }

            e.Graphics.ResetTransform();
        }

        private Bitmap openBitmap(string filename)
        {
            Bitmap bmp = null;
            if (string.IsNullOrEmpty(filename))
            {
                return bmp;
            }

            filename = spriteLogic.ResolvePath(filename);
            try
            {
                bmp = new Bitmap(filename);
            }
            catch (Exception)
            {
            }

            return bmp;
        }

        private bool validateFrames(List<Frame> frames)
        {
            for (int i = 0; i < frames.Count; ++i)
            {
                var frame = frames[i];
                if (frame.IsTweenFrame && (i == 0 || i == frames.Count - 1))
                {
                    stlMessage.Text = "Error: Tween frame " + lstFrames.Items[i].ToString();
                    return false;
                }
            }

            return true;
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            if (spriteLogic == null ||
                spriteLogic.CurrentPose == null ||
                spriteLogic.CurrentFrame == null ||
                !validateFrames(spriteLogic.CurrentPose.Frames))
            {
                return;
            }

            if (miAnimated.Checked)
            {
                spriteLogic.Update(System.Environment.TickCount);
            }
            else if (lstFrames.SelectedIndex != -1)
            {
                spriteLogic.SetFrame(lstFrames.SelectedIndex);
            }
            else
            {
                return;
            }

            pnlSprite.Invalidate();
        }

        private void populateSprite(SpriteData spriteData)
        {
            if (spriteData == null)
            {
                return;
            }

            txtImage.Text = spriteData.Image;

            var transColor = cdTransparentColor.Color;
            if (!string.IsNullOrEmpty(spriteData.TransparentColor))
            {
                transColor = Utilities.FromHex(spriteData.TransparentColor);
            }

            cdTransparentColor.Color = transColor;
            btnTransColor.BackColor = transColor;
            var poseNames = spriteData.Poses.Select(x => x.NameWithTags());
            lstPoses.Items.Clear();
            lstPoses.Items.AddRange(poseNames.ToArray());
        }

        private void populatePose(Pose pose)
        {
            if (pose == null)
            {
                clearPose();
                return;
            }

            if (pose.Tags.ContainsKey("Name"))
            {
                txtPoseName.Text = pose.Tags["Name"];
            }
            else
            {
                txtPoseName.Text = "";
            }

            txtDuration.Text = pose.DefaultDuration.ToString();
            txtRepeats.Text = pose.Repeats.ToString();
            txtBoundingBox.Text = pose.BoundingBox.ToString();
            txtOrigin.Text = pose.Origin.ToString();
            if (pose.Tags.ContainsKey("Direction"))
            {
                int index = cbDirection.Items.IndexOf(pose.Tags["Direction"]);
                cbDirection.SelectedIndex = index;
            }
            else
            {
                cbDirection.SelectedIndex = 0;
            }

            if (pose.Tags.ContainsKey("State"))
            {
                cbState.Text = pose.Tags["State"];
            }
            else
            {
                cbState.Text = "";
            }

            txtPoseImage.Text = pose.Image;
            var transColor = cdTransparentColor.Color;
            if (!string.IsNullOrEmpty(pose.TransparentColor))
            {
                transColor = Utilities.FromHex(pose.TransparentColor);
            }

            cdTransparentColor.Color = transColor;
            btnPoseTransColor.BackColor = transColor;
            var frameIndices = pose.Frames.Select((x, i) => (i + 1).ToString());
            lstFrames.Items.Clear();
            lstFrames.Items.AddRange(frameIndices.ToArray());
        }

        private void clearPose()
        {
            txtPoseName.Text = "";
            txtDuration.Text = "";
            txtRepeats.Text = "";
            txtBoundingBox.Text = "";
            txtOrigin.Text = "";
            lstFrames.Items.Clear();
        }

        private void populateFrame(Frame frame)
        {
            if (frame == null)
            {
                clearFrame();
                return;
            }

            txtFrameDuration.Text = frame.Duration.ToString();
            txtMagnification.Text = frame.Magnification.ToString();
            txtAngle.Text = frame.Angle.ToString();
            txtOpacity.Text = frame.Opacity.ToString();
            txtRectangle.Text = frame.Rectangle.ToString();
            chkTween.Checked = frame.IsTweenFrame;
            txtSound.Text = frame.Sound;
            txtFrameImage.Text = frame.Image;
            var transColor = cdTransparentColor.Color;
            if (!string.IsNullOrEmpty(frame.TransparentColor))
            {
                transColor = Utilities.FromHex(frame.TransparentColor);
            }

            cdTransparentColor.Color = transColor;
            btnFrameTransColor.BackColor = transColor;
        }

        private void clearFrame()
        {
            txtFrameDuration.Text = "";
            txtMagnification.Text = "";
            txtAngle.Text = "";
            txtOpacity.Text = "";
            txtRectangle.Text = "";
            chkTween.Checked = false;
        }

        private void lstPoses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPoses.SelectedIndex == -1)
            {
                return;
            }

            var poses = spriteLogic.SpriteData.Poses;
            selectedPose = poses[lstPoses.SelectedIndex];
            populatePose(selectedPose);
            spriteLogic.SetPose(selectedPose.NameWithTags(), System.Environment.TickCount);
            if (lstFrames.Items.Count > 0)
            {
                lstFrames.SelectedIndex = 0;
                changeSelectedFrame(0);
            }
            else
            {
                populateFrame(null);
            }
        }

        private void chkTween_CheckedChanged(object sender, EventArgs e)
        {
            stlMessage.Text = "";
            txtMagnification.Enabled = !chkTween.Checked;
            txtAngle.Enabled = !chkTween.Checked;
            txtOpacity.Enabled = !chkTween.Checked;
            if (selectedFrame != null)
            {
                selectedFrame.IsTweenFrame = chkTween.Checked;
                spriteLogic.Reset(System.Environment.TickCount);
            }
        }

        private void lstFrames_MouseDown(object sender, MouseEventArgs e)
        {
            if (selectedPose == null || lstFrames.SelectedItem == null)
            {
                return;
            }

            if (e.Button == MouseButtons.Left)
            {
                lstFrames.DoDragDrop(lstFrames.SelectedIndex, DragDropEffects.Move);
                if (lstFrames.SelectedIndex != -1)
                {
                    changeSelectedFrame(lstFrames.SelectedIndex);
                    populateFrame(selectedFrame);
                }
            }
        }

        private void lstFrames_DragDrop(object sender, DragEventArgs e)
        {
            Point point = lstFrames.PointToClient(new Point(e.X, e.Y));
            int toIndex = lstFrames.IndexFromPoint(point);
            if (toIndex < 0)
            {
                toIndex = lstFrames.Items.Count - 1;
            }

            int fromIndex = (int)e.Data.GetData(typeof(int));
            string data = lstFrames.Items[fromIndex].ToString();
            var fromFrame = selectedPose.Frames[fromIndex];
            lstFrames.Items.RemoveAt(fromIndex);
            lstFrames.Items.Insert(toIndex, data);
            Frame tempFrame = selectedPose.Frames[fromIndex];
            selectedPose.Frames[fromIndex] = selectedPose.Frames[toIndex];
            selectedPose.Frames[toIndex] = tempFrame;
            changeSelectedFrame(toIndex);
            stlMessage.Text = "";
        }

        private void lstFrames_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            var result = ofdImage.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            var fullFilename = ofdImage.FileName;
            setImage(fullFilename, "sprite");
        }

        private void setImage(string path, string type)
        {
            var filename = Path.GetFileName(path);
            var bmp = openBitmap(path);
            if (bmp != null)
            {
                var baseDir = spriteLogic.ResolveBaseDir();
                var image = path;
                if (baseDir != "." && Path.IsPathRooted(path))
                {
                    image = Utilities.MakeRelativePath(baseDir, path);
                }

                if (type == "frame")
                {
                    txtFrameImage.Text = filename;
                    selectedFrame.Image = image;
                }
                else if (type == "pose")
                {
                    txtPoseImage.Text = filename;
                    selectedPose.Image = image;
                }
                else
                {
                    txtImage.Text = filename;
                    spriteLogic.SpriteData.Image = image;
                }

                stlMessage.Text = "";
            }
            else
            {
                stlMessage.Text = "Error: Invalid image";
            }
        }

        private void txtPoseName_TextChanged(object sender, EventArgs e)
        {
            if (selectedPose == null || selectedPose.GetName() == txtPoseName.Text)
            {
                return;
            }

            var newName = txtPoseName.Text;
            if (newName == "")
            {
                selectedPose.Tags.Remove("Name");
            }
            else
            {
                selectedPose.Tags["Name"] = newName;
            }

            if (tbcSprite.SelectedTab == tabPose)
            {
                populateSprite(spriteLogic.SpriteData);
            }
        }

        private void txtDuration_TextChanged(object sender, EventArgs e)
        {
            if (selectedPose == null)
            {
                return;
            }

            if (int.TryParse(txtDuration.Text, out int duration))
            {
                selectedPose.DefaultDuration = duration;
            }
        }

        private void txtRepeats_TextChanged(object sender, EventArgs e)
        {
            if (selectedPose == null)
            {
                return;
            }

            if (int.TryParse(txtRepeats.Text, out int repeats))
            {
                if (spriteLogic.CurrentPose != null)
                {
                    spriteLogic.Reset(Environment.TickCount);
                }

                selectedPose.Repeats = repeats;
            }
        }

        private void txtFrameDuration_TextChanged(object sender, EventArgs e)
        {
            if (selectedFrame == null)
            {
                return;
            }

            if (int.TryParse(txtFrameDuration.Text, out int duration))
            {
                selectedFrame.Duration = duration;

            }
        }

        private void txtMagnification_TextChanged(object sender, EventArgs e)
        {
            if (selectedFrame == null)
            {
                return;
            }

            var mag = Vec2.FromString(txtMagnification.Text);
            if (mag != null)
            {
                selectedFrame.Magnification = mag;
            }
        }

        private void txtAngle_TextChanged(object sender, EventArgs e)
        {
            if (selectedFrame == null)
            {
                return;
            }

            if (int.TryParse(txtAngle.Text, out int angle))
            {
                selectedFrame.Angle = angle;
            }
        }

        private void txtOpacity_TextChanged(object sender, EventArgs e)
        {
            if (selectedFrame == null)
            {
                return;
            }

            if (float.TryParse(txtOpacity.Text, out float opacity))
            {
                selectedFrame.Opacity = opacity;
            }
        }

        private void miAdd_Click(object sender, EventArgs e)
        {
            if (spriteLogic == null)
            {
                return;
            }

            var poses = spriteLogic.SpriteData.Poses;
            var pose = new Pose();
            pose.Tags["Name"] = "Unnamed Pose " + lstPoses.Items.Count;
            poses.Add(pose);
            populateSprite(spriteLogic.SpriteData);
            populateFrame(null);
            lstPoses.SelectedIndex = lstPoses.Items.Count - 1;
        }

        private void miRemove_Click(object sender, EventArgs e)
        {
            if (spriteLogic == null || lstPoses.SelectedIndex == -1)
            {
                return;
            }

            var poses = spriteLogic.SpriteData.Poses;
            poses.RemoveAt(lstPoses.SelectedIndex);
            populateSprite(spriteLogic.SpriteData);
            if (lstPoses.Items.Count > 0)
            {
                lstPoses.SelectedIndex = 0;
            }
            else
            {
                clearPose();
            }
        }

        private void mnuPose_Opening(object sender, CancelEventArgs e)
        {
            miRemove.Enabled = lstPoses.SelectedIndex != -1;
            miCopy.Enabled = miRemove.Enabled;
            miPaste.Enabled = copiedPose != null;
        }

        private void changeSelectedFrame(int newFrameIndex)
        {
            btnPrevFrame.Enabled = newFrameIndex > 0;
            btnNextFrame.Enabled = newFrameIndex < selectedPose.Frames.Count - 1;
            if (selectedPose != null &&
                newFrameIndex >= 0 &&
                newFrameIndex < selectedPose.Frames.Count)
            {
                selectedFrame = selectedPose.Frames[newFrameIndex];
                populateFrame(selectedFrame);
                lstFrames.SelectedIndex = newFrameIndex;
            }
        }

        private void btnPrevFrame_Click(object sender, EventArgs e)
        {
            changeSelectedFrame(lstFrames.SelectedIndex - 1);
        }

        private void btnNextFrame_Click(object sender, EventArgs e)
        {
            changeSelectedFrame(lstFrames.SelectedIndex + 1);
        }

        private void miAddFrame_Click(object sender, EventArgs e)
        {
            if (selectedPose == null)
            {
                return;
            }

            var frames = selectedPose.Frames;
            Rect rect = new Rect(0, 0, 0, 0);
            var bmp = openBitmap(spriteLogic.Image);
            if (bmp != null)
            {
                rect = new Rect(0, 0, bmp.Width, bmp.Height);
            }

            frames.Add(new Frame() { Rectangle = rect });
            populatePose(selectedPose);
            changeSelectedFrame(frames.Count - 1);
            spriteLogic.Reset(System.Environment.TickCount);
        }

        private void miRemoveFrame_Click(object sender, EventArgs e)
        {
            if (selectedPose == null || lstFrames.SelectedIndex == -1)
            {
                return;
            }

            var frames = selectedPose.Frames;
            frames.RemoveAt(lstFrames.SelectedIndex);
            populatePose(selectedPose);
            if (lstFrames.Items.Count > 0)
            {
                changeSelectedFrame(0);
            }
            else
            {
                clearFrame();
            }

            spriteLogic.Reset(System.Environment.TickCount);
        }

        private void btnBrowseFrameImage_Click(object sender, EventArgs e)
        {
            if (selectedFrame == null)
            {
                return;
            }

            var result = ofdImage.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            var fullFilename = ofdImage.FileName;
            setImage(fullFilename, "frame");
        }

        private void btnFrameTransColor_Click(object sender, EventArgs e)
        {
            if (selectedFrame == null)
            {
                return;
            }

            cdTransparentColor.ShowDialog();
            string hex = cdTransparentColor.Color.ToHex();
            selectedFrame.TransparentColor = hex;
            btnFrameTransColor.BackColor = cdTransparentColor.Color;
        }

        private void txtRectangle_TextChanged(object sender, EventArgs e)
        {
            if (selectedFrame == null)
            {
                return;
            }

            var rect = Rect.FromString(txtRectangle.Text);
            if (rect != null)
            {
                selectedFrame.Rectangle = rect;
            }
        }

        private void txtBoundingBox_TextChanged(object sender, EventArgs e)
        {
            if (selectedPose == null)
            {
                return;
            }

            var rect = Rect.FromString(txtBoundingBox.Text);
            if (rect != null)
            {
                selectedPose.BoundingBox = rect;
            }
        }

        private void txtOrigin_TextChanged(object sender, EventArgs e)
        {
            if (selectedPose == null)
            {
                return;
            }

            var origin = Vec2.FromString(txtOrigin.Text);
            if (origin != null)
            {
                selectedPose.Origin = origin;
            }
        }

        private void setViewChecked(string view)
        {
            miFull.Checked = view == "full";
            miPreview.Checked = view == "preview";
            miAnimated.Checked = view == "animated";
            Settings.Default.DisplayMode = view;
        }

        private void miFull_Click(object sender, EventArgs e)
        {
            setViewChecked("full");
        }

        private void miPreview_Click(object sender, EventArgs e)
        {
            setViewChecked("preview");
        }

        private void miAnimated_Click(object sender, EventArgs e)
        {
            setViewChecked("animated");
        }

        private void miNew_Click(object sender, EventArgs e)
        {
            selectedPose = null;
            selectedFrame = null;
            List<Pose> poses = new List<Pose>();
            var frames = new List<Frame>();
            SpriteData spriteData = new SpriteData() { Image = "", Poses = poses };
            spriteLogic = new SpriteLogic(spriteData, null);
            populateSprite(spriteData);
            miAdd_Click(sender, e);
            miAddFrame_Click(sender, e);
            pnlSprite.Invalidate();
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            var result = ofdSprite.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            openSprite(ofdSprite.FileName);
        }

        private bool openSprite(string path)
        {
            stlMessage.Text = "";
            try
            {
                Directory.SetCurrentDirectory(Path.GetDirectoryName(path));
                Text = "Sprite Editor - " + Path.GetFileName(path);
                var spriteData = SpriteData.Load(path);
                if (spriteData == null)
                {
                    throw new IOException("Error loading sprite data.");
                }

                spriteLogic = new SpriteLogic(spriteData, path);
                populateSprite(spriteData);
                if (spriteData.Poses.Count > 0)
                {
                    spriteLogic.SetPose(spriteData.Poses[0].NameWithTags(), System.Environment.TickCount);
                    lstPoses.SelectedIndex = 0;
                }

                if (lstFrames.Items.Count > 0)
                {
                    lstFrames.SelectedIndex = 0;
                    changeSelectedFrame(0);
                }

                pnlSprite.Invalidate();
            }
            catch (Exception ex)
            {
                stlMessage.Text = "Error: Couldn't open file " + path + ": " + ex.Message;
                return false;
            }

            return true;
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            if (spriteLogic.OpenedFileName == null)
            {
                miSaveAs_Click(sender, e);
            }

            saveSprite(spriteLogic.OpenedFileName);
        }

        private bool saveSprite(string filename)
        {
            stlMessage.Text = "";
            try
            {
                SpriteData.Save(spriteLogic.SpriteData, filename);
            }
            catch (Exception ex)
            {
                stlMessage.Text = "Error: Couldn't save file " + filename + ": " + ex.Message;
                return false;
            }

            return true;
        }

        private void miSaveAs_Click(object sender, EventArgs e)
        {
            var result = sfdSprite.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            if (saveSprite(sfdSprite.FileName))
            {
                spriteLogic.OpenedFileName = sfdSprite.FileName;
                Text = "Sprite Editor - " + Path.GetFileName(spriteLogic.OpenedFileName);
            }
        }

        private void miShowSrcRect_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.ShowSrcRect = miShowSrcRect.Checked;
        }

        private void miShowBoundingBox_CheckChanged(object sender, EventArgs e)
        {
            Settings.Default.ShowBoundingBox = miShowBoundingBox.Checked;
        }

        private void miShowGrid_CheckChanged(object sender, EventArgs e)
        {
            Settings.Default.ShowGrid = miShowGrid.Checked;
        }

        private void miGridSettings_Click(object sender, EventArgs e)
        {
            gridSizeForm.ShowDialog();
        }

        private void frmSprite_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }

        private void lstFrames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFrames.SelectedIndex == -1)
            {
                return;
            }

            changeSelectedFrame(lstFrames.SelectedIndex);
            populateFrame(selectedFrame);
        }

        private void mnuFrame_Opening(object sender, CancelEventArgs e)
        {
            miRemoveFrame.Enabled = lstFrames.SelectedIndex != -1;
            miCopyFrame.Enabled = miRemoveFrame.Enabled;
            miPasteFrame.Enabled = copiedFrame != null;
        }

        private void miCopyFrame_Click(object sender, EventArgs e)
        {
            if (lstFrames.SelectedIndex == -1)
            {
                return;
            }

            copiedFrame = selectedPose.Frames[lstFrames.SelectedIndex];
        }

        private void miPasteFrame_Click(object sender, EventArgs e)
        {
            if (selectedPose == null || copiedFrame == null)
            {
                return;
            }

            selectedPose.Frames.Add(ObjectCopier.Clone(copiedFrame));
            populatePose(selectedPose);
            changeSelectedFrame(lstFrames.Items.Count - 1);
            spriteLogic.Reset(Environment.TickCount);
        }

        private void miCopy_Click(object sender, EventArgs e)
        {
            if (lstPoses.SelectedIndex == -1)
            {
                return;
            }

            var poses = spriteLogic.SpriteData.Poses;
            copiedPose = poses[lstPoses.SelectedIndex];
        }

        private void miPaste_Click(object sender, EventArgs e)
        {
            if (copiedPose == null)
            {
                return;
            }

            var poses = spriteLogic.SpriteData.Poses;
            var poseClone = ObjectCopier.Clone(copiedPose);
            if (poseClone.Tags.ContainsKey("Name") && poseClone.Tags["Name"] != "")
            {
                poseClone.Tags["Name"] += " Copy";
            }

            poses.Add(poseClone);
            populateSprite(spriteLogic.SpriteData);
            populateFrame(null);
            lstPoses.SelectedIndex = lstPoses.Items.Count - 1;
        }

        private void btnTransColor_Click(object sender, EventArgs e)
        {
            cdTransparentColor.ShowDialog();
            string hex = cdTransparentColor.Color.ToHex();
            spriteLogic.SpriteData.TransparentColor = hex;
            btnTransColor.BackColor = cdTransparentColor.Color;
        }

        private void btnBrowseFolder_Click(object sender, EventArgs e)
        {
            if (spriteLogic.OpenedFileName != null)
            {
                fbdBase.SelectedPath = Path.GetDirectoryName(spriteLogic.OpenedFileName);
            }

            fbdBase.ShowDialog();
            var selectedPath = fbdBase.SelectedPath;
            if (string.IsNullOrEmpty(selectedPath))
            {
                return;
            }

            if (spriteLogic.OpenedFileName != null)
            {
                selectedPath = Utilities.MakeRelativePath(
                    spriteLogic.OpenedFileName, selectedPath);
            }

            spriteLogic.SpriteData.BaseDirectory = selectedPath;
            txtBase.Text = selectedPath;
            if (!string.IsNullOrEmpty(spriteLogic.SpriteData.Image))
            {
                setImage(spriteLogic.SpriteData.Image, "sprite");
            }
        }

        private void cbState_DropDown(object sender, EventArgs e)
        {
            cbState.Items.Clear();
            foreach (var pose in spriteLogic.SpriteData.Poses)
            {
                if (pose.Tags.ContainsKey("State") &&
                        !cbState.Items.Contains(pose.Tags["State"]))
                {
                    cbState.Items.Add(pose.Tags["State"]);
                }
            }
        }

        private void cbDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedPose == null)
            {
                return;
            }

            var selected = (string)cbDirection.SelectedItem;
            if (selected == "None")
            {
                selectedPose.Tags.Remove("Direction");
            }
            else
            {
                selectedPose.Tags["Direction"] = selected;
            }

            if (tbcSprite.SelectedTab == tabPose)
            {
                populateSprite(spriteLogic.SpriteData);
            }
        }

        private void changeState(string newState)
        {
            if (newState == "")
            {
                selectedPose.Tags.Remove("State");
            }
            else
            {
                selectedPose.Tags["State"] = newState;
            }

            if (tbcSprite.SelectedTab == tabPose)
            {
                populateSprite(spriteLogic.SpriteData);
            }
        }

        private void cbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedPose == null)
            {
                return;
            }

            changeState((string)cbState.SelectedItem); 
        }

        private void cbState_TextChanged(object sender, EventArgs e)
        {
            changeState(cbState.Text);
        }

        private void miAddMultiple_Click(object sender, EventArgs e)
        {
            if (selectedPose == null)
            {
                return;
            }

            addFramesForm.ShowDialog();
        }

        private void btnBrowsePoseImage_Click(object sender, EventArgs e)
        {
            if (selectedPose == null)
            {
                return;
            }

            var result = ofdImage.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            var fullFilename = ofdImage.FileName;
            setImage(fullFilename, "pose");
        }

        private void btnPoseTransColor_Click(object sender, EventArgs e)
        {
            if (selectedPose == null)
            {
                return;
            }

            cdTransparentColor.ShowDialog();
            string hex = cdTransparentColor.Color.ToHex();
            selectedPose.TransparentColor = hex;
            btnPoseTransColor.BackColor = cdTransparentColor.Color;
        }

        private void btnBrowseSound_Click(object sender, EventArgs e)
        {
            if (selectedFrame == null)
            {
                return;
            }

            var result = ofdSound.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            var path = ofdSound.FileName;
            var filename = Path.GetFileName(path);
            var baseDir = spriteLogic.ResolveBaseDir();
            if (baseDir != "." && Path.IsPathRooted(path))
            {
                path = Utilities.MakeRelativePath(baseDir, path);
            }

            txtSound.Text = filename;
            selectedFrame.Sound = path;
        }
    }
}

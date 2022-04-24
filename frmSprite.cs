using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using SpriteEditor.Models;
using SpriteEditor.Properties;

namespace SpriteEditor
{
    public partial class FrmSprite : Form
    {
        private static readonly Brush BackgroundBrush =
            new HatchBrush(HatchStyle.LargeCheckerBoard, Color.LightGray, Color.White);

        private static readonly Brush SourceRectBrush =
            new SolidBrush(Color.FromArgb(150, Color.DarkGray));

        private static readonly Brush SelectedRectBrush =
            new SolidBrush(Color.FromArgb(150, Color.YellowGreen));

        private SpriteLogic spriteLogic;
        private Pose selectedPose;
        private Frame selectedFrame;
        private Pose copiedPose;
        private Frame copiedFrame;
        private readonly frmGridSize gridSizeForm = new();
        private readonly frmAddFrames addFramesForm;
        private string lastImageName;
        private Bitmap lastBitmap;
        private readonly float[] scales = { 0.5f, 1.0f, 2.0f, 4.0f, 8.0f, 16.0f };
        private float dpiX, dpiY;
        private int scaleIndex = 1;

        public FrmSprite()
        {
            addFramesForm = new frmAddFrames(this);
            InitializeComponent();
            pnlSprite.MouseWheel += pnlSprite_MouseWheel;
        }

        public void AddPoses(List<Pose> newPoses)
        {
            if (!newPoses.Any()) return;
            if (selectedPose != null)
            {
                foreach (var pose in newPoses)
                {
                    pose.BoundingBox = new Rect(selectedPose.BoundingBox);
                    pose.DefaultDuration = selectedPose.DefaultDuration;
                }
            }
            spriteLogic.SpriteData.Poses.AddRange(newPoses);
            PopulateSprite(spriteLogic.SpriteData);
        }

        public void AddFrames(List<Frame> newFrames)
        {
            selectedPose.Frames.AddRange(newFrames);
            PopulatePose(selectedPose);
            changeSelectedFrame(selectedPose.Frames.Count - 1);
            spriteLogic.Reset(Environment.TickCount);
        }

        public void ShowError(string message)
        {
            stlMessage.Text = message;
        }

        /// <inheritdoc />
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
                spriteLogic.Dispose();
            }

            base.Dispose(disposing);
        }

        private void frmSprite_Load(object sender, EventArgs e)
        {
            SetViewChecked(Settings.Default.DisplayMode);
            InitializeMenuItems();
            Zoom(Settings.Default.ZoomLevel);
            PopulateRecentFiles();
            cbDirection.SelectedIndex = 0;
            var args = Environment.GetCommandLineArgs();
            bool opened = false;
            if (args.Length > 1 && File.Exists(args[1]))
            {
                opened = OpenSprite(args[1]);
            }

            if (!opened)
            {
                miNew_Click(sender, e);
            }
        }

        private void InitializeMenuItems()
        {
            miShowSrcRect.Checked = Settings.Default.ShowSrcRect;
            miShowBoundingBox.Checked = Settings.Default.ShowBoundingBox;
            miShowGrid.Checked = Settings.Default.ShowGrid;
            miAutoReload.Checked = Settings.Default.AutoReloadImages;
            miGridSelection.Checked = Settings.Default.UseGridSelection;
            miTransparent.Checked = Settings.Default.UseTransparentColor;
        }

        private void PopulateRecentFiles()
        {
            miRecentFiles.DropDownItems.Clear();
            foreach (var file in Settings.Default.RecentFiles)
            {
                if (string.IsNullOrWhiteSpace(file)) continue;
                var miRecentFile = new ToolStripMenuItem(file, null, miRecentFile_Click);
                miRecentFiles.DropDownItems.Add(miRecentFile);
            }
        }


        private float Magnification => scales[scaleIndex];
        private float ScalingX => dpiX / lastBitmap.HorizontalResolution * Magnification;
        private float ScalingY => dpiY / lastBitmap.VerticalResolution * Magnification;
        private int ScaledWidth => lastBitmap != null ? (int)(lastBitmap.Width * ScalingX) : 0;
        private int ScaledHeight => lastBitmap != null ? (int)(lastBitmap.Height * ScalingY) : 0;


        private void pnlSprite_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(pnlSprite.BackColor);
            e.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
            var currentPose = spriteLogic.CurrentPose;
            var currentFrame = spriteLogic.CurrentFrame;
            if (currentPose == null || (currentFrame == null && !miFull.Checked)) return;

            if (spriteLogic.Image != lastImageName)
            {
                lastImageName = spriteLogic.Image;
                lastBitmap = OpenBitmap(lastImageName);
                fswUpdatedImageWatcher.Path = Path.GetDirectoryName(spriteLogic.ResolvePath(lastImageName));
                fswUpdatedImageWatcher.Filter = Path.GetFileName(lastImageName);
            }

            if (lastBitmap == null) return;

            // Default values (for full sprite view)
            dpiX = e.Graphics.DpiX;
            dpiY = e.Graphics.DpiY;
            var midX = Math.Max(0, pnlSprite.Width / 2 - ScaledWidth / 2);
            var midY = Math.Max(0, pnlSprite.Height / 2 - ScaledHeight / 2);
            var source = new Rectangle(0, 0, lastBitmap.Width, lastBitmap.Height);
            var dest = new Rectangle(midX, midY, ScaledWidth, ScaledHeight);

            var transform = new Matrix();

            // Transformed values (for animated and non-animated views)
            if (miPreview.Checked || miAnimated.Checked)
            {
                if (miPreview.Checked && selectedFrame != null)
                {
                    currentFrame = selectedFrame;
                }

                source = (Rectangle)currentFrame.Rectangle;
                var magnifiedWidth = (int)(source.Width * ScalingX * currentFrame.Magnification.X);
                var magnifiedHeight = (int)(source.Height * ScalingY * currentFrame.Magnification.Y);
                midX = Math.Max(0, pnlSprite.Width / 2 - magnifiedWidth / 2);
                midY = Math.Max(0, pnlSprite.Height / 2 - magnifiedHeight / 2);
                dest = new Rectangle(midX, midY, magnifiedWidth, magnifiedHeight);
                var origin = new Point(
                                        (int)(midX + magnifiedWidth * currentPose.Origin.X),
                                        (int)(midY + magnifiedHeight * currentPose.Origin.Y));
                transform = e.Graphics.Transform;
                transform.RotateAt(currentFrame.Angle, origin);
            }

            pnlSprite.AutoScrollMinSize = new Size(dest.Width, dest.Height);

            e.Graphics.TranslateTransform(pnlSprite.AutoScrollPosition.X, pnlSprite.AutoScrollPosition.Y);
            e.Graphics.MultiplyTransform(transform);
            ImageAttributes attributes = GetImageAttributes(currentPose, currentFrame);

            // Draw the sprite
            e.Graphics.FillRectangle(BackgroundBrush, dest);
            e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            e.Graphics.DrawImage(
                                    lastBitmap,
                                    dest,
                                    source.X,
                                    source.Y,
                                    source.Width,
                                    source.Height,
                                    GraphicsUnit.Pixel,
                                    attributes);

            // Draw the grid
            var gridWidth = (int)(Settings.Default.GridWidth * ScalingX);
            var gridHeight = (int)(Settings.Default.GridHeight * ScalingY);
            if (Settings.Default.ShowGrid)
            {
                DrawGrid(e, dest, gridWidth, gridHeight);
            }

            // Draw bounding box in animated and non-animated views
            if (Settings.Default.ShowBoundingBox &&
                !miFull.Checked && selectedPose != null)
            {
                DrawBoundingBox(e, midX, midY, dest);
            }

            // Draw source rect and selected rect in full sprite view
            if (miFull.Checked)
            {
                if (Settings.Default.ShowSrcRect && selectedFrame != null)
                {
                    DrawSourceRect(e, midX, midY);
                }

                if (Settings.Default.UseGridSelection)
                {
                    DrawSelectedRect(e, midX, midY, gridWidth, gridHeight);
                }

            }

            e.Graphics.ResetTransform();
        }

        private ImageAttributes GetImageAttributes(Pose currentPose, Frame currentFrame)
        {

            // Set alpha
            var attributes = new ImageAttributes();
            if (currentFrame != null && !Utilities.CheckClose(currentFrame.Opacity, 1.0f, 0.01f))
            {
                var matrix = new ColorMatrix
                {
                    Matrix33 = currentFrame.Opacity
                };
                attributes.SetColorMatrix(matrix);
            }

            if (Settings.Default.UseTransparentColor)
            {
                var transparentColorHex = currentFrame?.TransparentColor
                ?? currentPose?.TransparentColor
                ?? spriteLogic.SpriteData.TransparentColor;
                if (!string.IsNullOrEmpty(transparentColorHex))
                {
                    var transparentColor = Utilities.FromHex(transparentColorHex);
                    attributes.SetColorKey(transparentColor, transparentColor);
                }
            }

            return attributes;
        }

        private void DrawSelectedRect(PaintEventArgs e, int midX, int midY, int gridWidth, int gridHeight)
        {
            var panelCursorPos = pnlSprite.PointToClient(Cursor.Position);
            var bitmapCursorPos = MouseToBitmapPosition(panelCursorPos);

            if (MouseWithinBitmapBounds(bitmapCursorPos))
            {
                var selectRect = new Rectangle
                {
                    X = gridWidth * (int)(ScalingX * bitmapCursorPos.X / gridWidth) + midX,
                    Y = gridHeight * (int)(ScalingY * bitmapCursorPos.Y / gridHeight) + midY,
                    Width = gridWidth,
                    Height = gridHeight
                };
                e.Graphics.FillRectangle(SelectedRectBrush, selectRect);
            }
        }

        private void DrawSourceRect(PaintEventArgs e, int midX, int midY)
        {
            var currentRect = (Rectangle)selectedFrame.Rectangle;
            currentRect.X = (int)(currentRect.X * ScalingX) + midX;
            currentRect.Y = (int)(currentRect.Y * ScalingY) + midY;
            currentRect.Width = (int)(currentRect.Width * ScalingX);
            currentRect.Height = (int)(currentRect.Height * ScalingY);
            e.Graphics.FillRectangle(SourceRectBrush, currentRect);
            e.Graphics.DrawRectangle(new Pen(Color.Blue), currentRect);
        }

        private void DrawBoundingBox(PaintEventArgs e, int midX, int midY, Rectangle dest)
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
            else
            {
                box.Width = (int)(box.Width * ScalingX);
            }

            if (box.Height == -1)
            {
                box.Height = dest.Height;
            }
            else
            {
                box.Height = (int)(box.Height * ScalingY);
            }

            box.X = (int)(box.X * ScalingX) + midX;
            box.Y = (int)(box.Y * ScalingY) + midY;

            e.Graphics.DrawRectangle(new Pen(Color.Black), box);
        }

        private static void DrawGrid(PaintEventArgs e, Rectangle dest, int gridWidth, int gridHeight)
        {
            var pen = new Pen(Settings.Default.GridColor);
            for (int y = dest.Y; y <= dest.Y + dest.Height; y += gridHeight)
            {
                for (int x = dest.X; x <= dest.X + dest.Width; x += gridWidth)
                {
                    e.Graphics.DrawLine(pen, x, dest.Y, x, dest.Y + dest.Height);
                }

                e.Graphics.DrawLine(pen, dest.X, y, dest.X + dest.Width, y);
            }
        }

        private Point MouseToBitmapPosition(Point mousePos)
        {
            var midX = Math.Max(0, pnlSprite.Width / 2 - ScaledWidth / 2);
            var midY = Math.Max(0, pnlSprite.Height / 2 - ScaledHeight / 2);
            return new Point
            {
                X = (int)((mousePos.X - midX - pnlSprite.AutoScrollPosition.X) / ScalingX),
                Y = (int)((mousePos.Y - midY - pnlSprite.AutoScrollPosition.Y) / ScalingY),
            };
        }

        private bool MouseWithinBitmapBounds(Point bitmapCursorPos)
        {
            if (lastBitmap == null) return false;
            var withinBoundsX = bitmapCursorPos.X >= 0 && bitmapCursorPos.X < lastBitmap.Width;
            var withinBoundsY = bitmapCursorPos.Y >= 0 && bitmapCursorPos.Y < lastBitmap.Height;
            return withinBoundsX && withinBoundsY;
        }

        private Bitmap OpenBitmap(string filename)
        {
            if (string.IsNullOrEmpty(filename)) return null;

            filename = spriteLogic.ResolvePath(filename);
            try
            {
                using var tempBitmap = new Bitmap(filename);
                return new Bitmap(tempBitmap);
            }
            catch (Exception)
            {
                return null;
            }
        }

        private bool ValidateFrames(List<Frame> frames)
        {
            for (var i = 0; i < frames.Count; ++i)
            {
                var frame = frames[i];
                if (frame.IsTweenFrame && (i == 0 || i == frames.Count - 1))
                {
                    stlMessage.Text = $"Error: Tween frame {lstFrames.Items[i]}";
                    return false;
                }
            }

            return true;
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            if (spriteLogic?.CurrentPose == null ||
                !ValidateFrames(spriteLogic.CurrentPose.Frames))
            {
                return;
            }

            if (miAnimated.Checked)
            {
                spriteLogic.Update(Environment.TickCount);
            }
            else if (lstFrames.SelectedIndex != -1)
            {
                spriteLogic.SetFrame(lstFrames.SelectedIndex);
            }

            pnlSprite.Invalidate();
        }

        private void PopulateSprite(SpriteData spriteData)
        {
            if (spriteData == null) return;

            txtBase.Text = spriteData.BaseDirectory;
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
            cbDefaultPose.Items.Clear();
            cbDefaultPose.Items.Add("");
            cbDefaultPose.Items.AddRange(spriteData.GetPoseNames().ToArray<object>());
            if (!string.IsNullOrEmpty(spriteData.DefaultPose))
            {
                cbDefaultPose.SelectedItem = spriteData.DefaultPose;
            }
        }

        private void PopulatePose(Pose pose)
        {
            if (pose == null)
            {
                ClearPose();
                return;
            }

            txtPoseName.Text = pose.Tags.ContainsKey("Name") ? pose.Tags["Name"] : "";

            txtDuration.Text = pose.DefaultDuration.ToString();
            txtRepeats.Text = pose.Repeats.ToString();
            chkRequireCompletion.Enabled = pose.Repeats == -1;
            chkRequireCompletion.Checked = pose.RequireCompletion;
            txtBoundingBox.Text = pose.BoundingBox.ToString();
            txtOrigin.Text = pose.Origin.ToString();
            if (pose.Tags.ContainsKey("Direction"))
            {
                var index = cbDirection.Items.IndexOf(pose.Tags["Direction"]);
                cbDirection.SelectedIndex = index;
            }
            else
            {
                cbDirection.SelectedIndex = 0;
            }

            cbState.Text = pose.Tags.ContainsKey("State") ? pose.Tags["State"] : "";

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

        private void ClearPose()
        {
            txtPoseName.Text = "";
            txtDuration.Text = "";
            txtRepeats.Text = "";
            chkRequireCompletion.Enabled = false;
            chkRequireCompletion.Checked = false;
            txtBoundingBox.Text = "";
            txtOrigin.Text = "";
            lstFrames.Items.Clear();
        }

        private void PopulateFrame(Frame frame)
        {
            if (frame == null)
            {
                ClearFrame();
                return;
            }

            txtFrameDuration.Text = frame.Duration.ToString();
            txtMagnification.Text = frame.Magnification.ToString();
            txtAngle.Text = frame.Angle.ToString();
            txtOpacity.Text = frame.Opacity.ToString();
            txtRectangle.Text = frame.Rectangle.ToString();
            chkTween.Checked = frame.IsTweenFrame;
            txtSound.Text = frame.Sound.Filename;
            txtPitch.Text = frame.Sound.Pitch.ToString();
            txtPitch.Enabled = frame.Sound.Filename != null;
            txtVolume.Text = frame.Sound.Volume.ToString();
            txtVolume.Enabled = frame.Sound.Filename != null;
            txtFrameImage.Text = frame.Image;
            var transColor = cdTransparentColor.Color;
            if (!string.IsNullOrEmpty(frame.TransparentColor))
            {
                transColor = Utilities.FromHex(frame.TransparentColor);
            }

            cdTransparentColor.Color = transColor;
            btnFrameTransColor.BackColor = transColor;
        }

        private void ClearFrame()
        {
            txtFrameDuration.Text = "";
            txtMagnification.Text = "";
            txtAngle.Text = "";
            txtOpacity.Text = "";
            txtRectangle.Text = "";
            txtSound.Text = "";
            txtPitch.Text = "";
            txtPitch.Enabled = false;
            txtVolume.Text = "";
            txtVolume.Enabled = false;
            txtFrameImage.Text = "";
            chkTween.Checked = false;
        }

        private void lstPoses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPoses.SelectedIndex == -1) return;

            var poses = spriteLogic.SpriteData.Poses;
            selectedPose = poses[lstPoses.SelectedIndex];
            PopulatePose(selectedPose);
            spriteLogic.SetPose(selectedPose.NameWithTags(), Environment.TickCount);
            if (lstFrames.Items.Count > 0)
            {
                changeSelectedFrame(0);
            }
            else
            {
                PopulateFrame(null);
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
                spriteLogic.Reset(Environment.TickCount);
            }
        }

        private void lstFrames_MouseDown(object sender, MouseEventArgs e)
        {
            if (selectedPose == null || lstFrames.SelectedItem == null) return;

            if (e.Button == MouseButtons.Left)
            {
                lstFrames.DoDragDrop(lstFrames.SelectedIndex, DragDropEffects.Move);
                if (lstFrames.SelectedIndex != -1)
                {
                    changeSelectedFrame(lstFrames.SelectedIndex);
                    PopulateFrame(selectedFrame);
                }
            }
        }

        private void lstFrames_DragDrop(object sender, DragEventArgs e)
        {
            var point = lstFrames.PointToClient(new Point(e.X, e.Y));
            int toIndex = lstFrames.IndexFromPoint(point);
            if (toIndex < 0)
            {
                toIndex = lstFrames.Items.Count - 1;
            }

            int fromIndex = (int)e.Data.GetData(typeof(int));
            var data = lstFrames.Items[fromIndex].ToString();
            lstFrames.Items.RemoveAt(fromIndex);
            lstFrames.Items.Insert(toIndex, data);
            var tempFrame = selectedPose.Frames[fromIndex];
            selectedPose.Frames.RemoveAt(fromIndex);
            selectedPose.Frames.Insert(toIndex, tempFrame);
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
            SetImage(fullFilename, "sprite");
        }

        private void SetImage(string path, string type)
        {
            var filename = Path.GetFileName(path);
            var bmp = OpenBitmap(path);
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
            if (selectedPose == null || selectedPose.GetName() == txtPoseName.Text) return;

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
                PopulateSprite(spriteLogic.SpriteData);
            }
        }

        private void txtDuration_TextChanged(object sender, EventArgs e)
        {
            if (selectedPose == null) return;

            if (int.TryParse(txtDuration.Text, out int duration))
            {
                selectedPose.DefaultDuration = duration;
            }
        }

        private void txtRepeats_TextChanged(object sender, EventArgs e)
        {
            if (selectedPose == null) return;

            if (int.TryParse(txtRepeats.Text, out var repeats))
            {
                if (spriteLogic.CurrentPose != null)
                {
                    spriteLogic.Reset(Environment.TickCount);
                }

                selectedPose.Repeats = repeats;
                chkRequireCompletion.Enabled = repeats == -1;
            }
        }

        private void txtFrameDuration_TextChanged(object sender, EventArgs e)
        {
            if (selectedFrame == null) return;

            if (int.TryParse(txtFrameDuration.Text, out var duration))
            {
                selectedFrame.Duration = duration;

            }
        }

        private void txtMagnification_TextChanged(object sender, EventArgs e)
        {
            if (selectedFrame == null) return;

            var mag = Vec2.FromString(txtMagnification.Text);
            if (mag != null)
            {
                selectedFrame.Magnification = mag;
            }
        }

        private void txtAngle_TextChanged(object sender, EventArgs e)
        {
            if (selectedFrame == null) return;

            if (int.TryParse(txtAngle.Text, out var angle))
            {
                selectedFrame.Angle = angle;
            }
        }

        private void txtOpacity_TextChanged(object sender, EventArgs e)
        {
            if (selectedFrame == null) return;

            if (float.TryParse(txtOpacity.Text, out var opacity))
            {
                selectedFrame.Opacity = opacity;
            }
        }

        private void miAdd_Click(object sender, EventArgs e)
        {
            if (spriteLogic == null) return;

            var poses = spriteLogic.SpriteData.Poses;
            var pose = new Pose
            {
                Tags =
                {
                    ["Name"] = "Unnamed Pose " + lstPoses.Items.Count
                }
            };
            poses.Add(pose);
            PopulateSprite(spriteLogic.SpriteData);
            PopulateFrame(null);
            lstPoses.SelectedIndex = lstPoses.Items.Count - 1;
        }

        private void miRemove_Click(object sender, EventArgs e)
        {
            if (spriteLogic == null || lstPoses.SelectedIndex == -1) return;

            var poses = spriteLogic.SpriteData.Poses;
            poses.RemoveAt(lstPoses.SelectedIndex);
            PopulateSprite(spriteLogic.SpriteData);
            if (lstPoses.Items.Count > 0)
            {
                lstPoses.SelectedIndex = 0;
            }
            else
            {
                ClearPose();
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
            if (selectedPose == null) return;
            btnPrevFrame.Enabled = newFrameIndex > 0;
            btnNextFrame.Enabled = newFrameIndex < selectedPose.Frames.Count - 1;
            if (newFrameIndex < 0 || newFrameIndex >= selectedPose.Frames.Count) return;
            selectedFrame = selectedPose.Frames[newFrameIndex];
            PopulateFrame(selectedFrame);
            lstFrames.SelectedIndex = newFrameIndex;
            lblFrameNumber.Text = $"#{newFrameIndex + 1}";
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
            if (selectedPose == null) return;

            var frames = selectedPose.Frames;
            var rect = new Rect(0, 0, 0, 0);
            var bmp = OpenBitmap(spriteLogic.Image);
            if (bmp != null)
            {
                rect = new Rect(0, 0, bmp.Width, bmp.Height);
            }

            frames.Add(new Frame() { Rectangle = rect });
            PopulatePose(selectedPose);
            changeSelectedFrame(frames.Count - 1);
            spriteLogic.Reset(Environment.TickCount);
        }

        private void miRemoveFrame_Click(object sender, EventArgs e)
        {
            if (selectedPose == null || lstFrames.SelectedIndex == -1) return;

            var frames = selectedPose.Frames;
            frames.RemoveAt(lstFrames.SelectedIndex);
            PopulatePose(selectedPose);
            if (lstFrames.Items.Count > 0)
            {
                changeSelectedFrame(0);
            }
            else
            {
                ClearFrame();
            }

            spriteLogic.Reset(Environment.TickCount);
        }

        private void miClearFrames_Click(object sender, EventArgs e)
        {
            if (selectedPose == null) return;
            selectedPose.Frames.Clear();
            PopulatePose(selectedPose);
            ClearFrame();
            spriteLogic.Reset(Environment.TickCount);
        }

        private void btnBrowseFrameImage_Click(object sender, EventArgs e)
        {
            if (selectedFrame == null) return;

            var result = ofdImage.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            var fullFilename = ofdImage.FileName;
            SetImage(fullFilename, "frame");
        }

        private void btnFrameTransColor_Click(object sender, EventArgs e)
        {
            if (selectedFrame == null) return;

            cdTransparentColor.ShowDialog();
            var hex = cdTransparentColor.Color.ToHex();
            selectedFrame.TransparentColor = hex;
            btnFrameTransColor.BackColor = cdTransparentColor.Color;
        }

        private void txtRectangle_TextChanged(object sender, EventArgs e)
        {
            if (selectedFrame == null) return;

            var rect = Rect.FromString(txtRectangle.Text);
            if (rect != null)
            {
                selectedFrame.Rectangle = rect;
            }
        }

        private void txtBoundingBox_TextChanged(object sender, EventArgs e)
        {
            if (selectedPose == null) return;

            var rect = Rect.FromString(txtBoundingBox.Text);
            if (rect != null)
            {
                selectedPose.BoundingBox = rect;
            }
        }

        private void txtOrigin_TextChanged(object sender, EventArgs e)
        {
            if (selectedPose == null) return;

            var origin = Vec2.FromString(txtOrigin.Text);
            if (origin != null)
            {
                selectedPose.Origin = origin;
            }
        }

        private void SetViewChecked(string view)
        {
            miFull.Checked = view == "full";
            miPreview.Checked = view == "preview";
            miAnimated.Checked = view == "animated";
            Settings.Default.DisplayMode = view;
        }

        private void miFull_Click(object sender, EventArgs e)
        {
            SetViewChecked("full");
        }

        private void miPreview_Click(object sender, EventArgs e)
        {
            SetViewChecked("preview");
        }

        private void miAnimated_Click(object sender, EventArgs e)
        {
            SetViewChecked("animated");
        }

        private void miNew_Click(object sender, EventArgs e)
        {
            selectedPose = null;
            selectedFrame = null;
            lastImageName = null;
            lastBitmap = null;
            var poses = new List<Pose>();
            var spriteData = new SpriteData() { Image = "", Poses = poses };
            spriteLogic = new SpriteLogic(spriteData, null, Settings.Default.SoundPlayback);
            PopulateSprite(spriteData);
            miAdd_Click(sender, e);
            miAddFrame_Click(sender, e);
            pnlSprite.Invalidate();
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            var result = ofdSprite.ShowDialog();
            if (result != DialogResult.OK) return;

            OpenSprite(ofdSprite.FileName);
        }

        private bool OpenSprite(string path)
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

                lastImageName = null;
                lastBitmap = null;
                spriteLogic = new SpriteLogic(spriteData, path, Settings.Default.SoundPlayback);
                PopulateSprite(spriteData);
                if (spriteData.Poses.Count > 0)
                {
                    spriteLogic.SetPose(spriteData.Poses[0].NameWithTags(), Environment.TickCount);
                    lstPoses.SelectedIndex = 0;
                }

                if (lstFrames.Items.Count > 0)
                {
                    changeSelectedFrame(0);
                }

                pnlSprite.Invalidate();

                AddRecentFile(path);
            }
            catch (Exception ex)
            {
                stlMessage.Text = "Error: Couldn't open file " + path + ": " + ex.Message;
                return false;
            }

            return true;
        }

        private void AddRecentFile(string path)
        {
            var fileSet = new HashSet<string>();
            var fileList = new List<string>();
            fileSet.Add(path);
            fileList.Add(path);
            foreach (var file in Settings.Default.RecentFiles)
            {
                if (!fileSet.Contains(file))
                {
                    fileSet.Add(file);
                    fileList.Add(file);
                }
            }
            Settings.Default.RecentFiles.Clear();
            foreach (var file in fileList.Take(8))
            {
                Settings.Default.RecentFiles.Add(file);
            }
            PopulateRecentFiles();
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            if (spriteLogic.OpenedFileName == null)
            {
                miSaveAs_Click(sender, e);
            }

            SaveSprite(spriteLogic.OpenedFileName);
        }

        private bool SaveSprite(string filename)
        {
            stlMessage.Text = "";
            try
            {
                SpriteData.Save(spriteLogic.SpriteData, filename);
            }
            catch (Exception ex)
            {
                stlMessage.Text = $"Error: Couldn't save file {filename}: {ex.Message}";
                return false;
            }

            return true;
        }

        private void miSaveAs_Click(object sender, EventArgs e)
        {
            var result = sfdSprite.ShowDialog();
            if (result != DialogResult.OK) return;

            if (SaveSprite(sfdSprite.FileName))
            {
                spriteLogic.OpenedFileName = sfdSprite.FileName;
                Text = $"Sprite Editor - {Path.GetFileName(spriteLogic.OpenedFileName)}";
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
            if (lstFrames.SelectedIndex == -1) return;

            changeSelectedFrame(lstFrames.SelectedIndex);
            PopulateFrame(selectedFrame);
        }

        private void mnuFrame_Opening(object sender, CancelEventArgs e)
        {
            miRemoveFrame.Enabled = lstFrames.SelectedIndex != -1;
            miCopyFrame.Enabled = miRemoveFrame.Enabled;
            miPasteFrame.Enabled = copiedFrame != null;
        }

        private void miCopyFrame_Click(object sender, EventArgs e)
        {
            if (lstFrames.SelectedIndex == -1) return;

            copiedFrame = selectedPose.Frames[lstFrames.SelectedIndex];
        }

        private void miPasteFrame_Click(object sender, EventArgs e)
        {
            if (selectedPose == null || copiedFrame == null) return;

            AddExistingFrame(new Frame(copiedFrame));
        }

        private void AddExistingFrame(Frame frameToAdd)
        {
            selectedPose.Frames.Add(frameToAdd);
            PopulatePose(selectedPose);
            changeSelectedFrame(lstFrames.Items.Count - 1);
            spriteLogic.Reset(Environment.TickCount);
        }

        private void miCopy_Click(object sender, EventArgs e)
        {
            if (lstPoses.SelectedIndex == -1) return;

            var poses = spriteLogic.SpriteData.Poses;
            copiedPose = poses[lstPoses.SelectedIndex];
        }

        private void miPaste_Click(object sender, EventArgs e)
        {
            if (copiedPose == null) return;

            var poses = spriteLogic.SpriteData.Poses;
            var poseClone = new Pose(copiedPose);
            if (poseClone.Tags.ContainsKey("Name") && poseClone.Tags["Name"] != "")
            {
                poseClone.Tags["Name"] += " Copy";
            }

            poses.Add(poseClone);
            PopulateSprite(spriteLogic.SpriteData);
            PopulateFrame(null);
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
            if (string.IsNullOrEmpty(selectedPath)) return;

            if (spriteLogic.OpenedFileName != null)
            {
                selectedPath = Utilities.MakeRelativePath(
                    spriteLogic.OpenedFileName, selectedPath);
            }

            spriteLogic.SpriteData.BaseDirectory = selectedPath;
            txtBase.Text = selectedPath;
            if (!string.IsNullOrEmpty(spriteLogic.SpriteData.Image))
            {
                SetImage(spriteLogic.SpriteData.Image, "sprite");
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
            if (selectedPose == null) return;

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
                PopulateSprite(spriteLogic.SpriteData);
            }
        }

        private void ChangeState(string newState)
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
                PopulateSprite(spriteLogic.SpriteData);
            }
        }

        private void cbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedPose == null) return;

            ChangeState((string)cbState.SelectedItem);
        }

        private void cbState_TextChanged(object sender, EventArgs e)
        {
            ChangeState(cbState.Text);
        }

        private void miAddMultiple_Click(object sender, EventArgs e)
        {
            if (selectedPose == null) return;

            var img = string.IsNullOrEmpty(selectedPose.Image) ?
                spriteLogic.SpriteData.Image : selectedPose.Image;
            var bmp = OpenBitmap(img);
            if (bmp == null)
            {
                stlMessage.Text = $"Error: Couldn't load bitmap {img}";
                return;
            }
            addFramesForm.ShowDialog(bmp);
        }

        private void btnBrowsePoseImage_Click(object sender, EventArgs e)
        {
            if (selectedPose == null) return;

            var result = ofdImage.ShowDialog();
            if (result != DialogResult.OK) return;

            var fullFilename = ofdImage.FileName;
            SetImage(fullFilename, "pose");
        }

        private void btnPoseTransColor_Click(object sender, EventArgs e)
        {
            if (selectedPose == null) return;

            cdTransparentColor.ShowDialog();
            var hex = cdTransparentColor.Color.ToHex();
            selectedPose.TransparentColor = hex;
            btnPoseTransColor.BackColor = cdTransparentColor.Color;
        }

        private void btnBrowseSound_Click(object sender, EventArgs e)
        {
            if (selectedFrame == null) return;

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
            selectedFrame.Sound.Filename = path;
            txtPitch.Enabled = true;
            txtVolume.Enabled = true;

            spriteLogic.PlaySound(selectedFrame.Sound);
        }

        private void frmSprite_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers != Keys.Control) return;

            switch (e.KeyCode)
            {
                case Keys.Add:
                case Keys.Oemplus:
                    Zoom(scaleIndex + 1);
                    break;
                case Keys.Subtract:
                case Keys.OemMinus:
                    Zoom(scaleIndex - 1);
                    break;
                case Keys.D0:
                case Keys.NumPad0:
                    Zoom(1);
                    break;
            }
        }

        private void Zoom(int newIndex)
        {
            if (newIndex != scaleIndex && newIndex >= 0 && newIndex <= 5)
            {
                scaleIndex = newIndex;
                pnlSprite.Invalidate();
                Settings.Default.ZoomLevel = scaleIndex;
            }
            CheckMagnificationMenuItem();
        }

        private void miMagnification50_Click(object sender, EventArgs e)
        {
            Zoom(0);
        }

        private void miMagnification100_Click(object sender, EventArgs e)
        {
            Zoom(1);
        }

        private void miMagnification200_Click(object sender, EventArgs e)
        {
            Zoom(2);
        }

        private void miMagnification400_Click(object sender, EventArgs e)
        {
            Zoom(3);
        }

        private void miMagnification800_Click(object sender, EventArgs e)
        {
            Zoom(4);
        }

        private void miMagnification1600_Click(object sender, EventArgs e)
        {
            Zoom(5);
        }

        private void miMagnificationZoomIn_Click(object sender, EventArgs e)
        {
            Zoom(scaleIndex + 1);
        }

        private void miMagnificationZoomOut_Click(object sender, EventArgs e)
        {
            Zoom(scaleIndex - 1);
        }

        private void pnlSprite_MouseHover(object sender, EventArgs e)
        {
            pnlSprite.Focus();
        }

        private void pnlSprite_MouseWheel(object sender, MouseEventArgs e)
        {
            if ((ModifierKeys & Keys.Control) != Keys.Control)
            {
                return;
            }

            if (e.Delta > 0)
            {
                Zoom(scaleIndex + 1);
            }
            else if (e.Delta < 0)
            {
                Zoom(scaleIndex - 1);
            }
        }

        private void CheckMagnificationMenuItem()
        {
            miMagnification50.Checked = scaleIndex == 0;
            miMagnification100.Checked = scaleIndex == 1;
            miMagnification200.Checked = scaleIndex == 2;
            miMagnification400.Checked = scaleIndex == 3;
            miMagnification800.Checked = scaleIndex == 4;
            miMagnification1600.Checked = scaleIndex == 5;
        }

        private void miRecentFile_Click(object sender, EventArgs e)
        {
            var mi = sender as ToolStripMenuItem;
            OpenSprite(mi.Text);
        }

        private void lstFrames_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                miRemoveFrame_Click(sender, e);
            }
        }

        private void lstPoses_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                miRemove_Click(sender, e);
            }
        }

        private void chkRequireCompletion_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedPose == null) return;

            selectedPose.RequireCompletion = chkRequireCompletion.Checked;
        }

        private void cbDefaultPose_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (string)cbDefaultPose.SelectedItem;
            if (string.IsNullOrEmpty(selected)) return;

            spriteLogic.SpriteData.DefaultPose = selected;
        }

        private void fswUpdatedImageWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            stlMessage.Text = $"Image {e.Name} changed outside the application.";
            if (!Settings.Default.AutoReloadImages) return;
            lastImageName = null;
        }

        private void miAutoReload_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.AutoReloadImages = miAutoReload.Checked;
        }

        private void miGridSelection_CheckedChanged(object sender, EventArgs e)
        {
            if (miGridSelection.Checked)
            {
                SetViewChecked("full");
            }
            Settings.Default.UseGridSelection = miGridSelection.Checked;
        }

        private void miTransparent_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.UseTransparentColor = miTransparent.Checked;
            pnlSprite.Invalidate();
        }

        private void txtPitch_TextChanged(object sender, EventArgs e)
        {
            if (selectedFrame == null) return;

            if (float.TryParse(txtPitch.Text, out float pitch))
            {
                selectedFrame.Sound.Pitch = pitch;
                spriteLogic.PlaySound(selectedFrame.Sound);
            }
            else
            {
                selectedFrame.Sound.Pitch = null;
            }
        }

        private void txtVolume_TextChanged(object sender, EventArgs e)
        {
            if (selectedFrame == null) return;

            if (float.TryParse(txtVolume.Text, out float volume))
            {
                selectedFrame.Sound.Volume = volume;
                spriteLogic.PlaySound(selectedFrame.Sound);
            }
            else
            {
                selectedFrame.Sound.Volume = null;
            }
        }

        private void btnRemoveSound_Click(object sender, EventArgs e)
        {
            if (selectedFrame == null) return;

            txtSound.Text = "";
            txtPitch.Text = "";
            txtPitch.Enabled = false;
            txtVolume.Text = "";
            txtVolume.Enabled = false;
            selectedFrame.Sound = new Sound();
        }

        private void pnlSprite_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left || selectedPose == null || !miFull.Checked) return;
            var bitmapPos = MouseToBitmapPosition(e.Location);
            if (!MouseWithinBitmapBounds(bitmapPos)) return;

            var newFrame = new Frame();
            var gridWidth = Settings.Default.GridWidth;
            var gridHeight = Settings.Default.GridHeight;
            newFrame.Rectangle.X = gridWidth * (int)(bitmapPos.X / (float)gridWidth);
            newFrame.Rectangle.Y = gridHeight * (int)(bitmapPos.Y / (float)gridHeight);
            newFrame.Rectangle.Width = gridWidth;
            newFrame.Rectangle.Height = gridHeight;
            AddExistingFrame(newFrame);
        }
    }
}

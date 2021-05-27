using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SpriteEditor
{
    public partial class frmAddFrames : Form
    {
        private readonly FrmSprite mainForm;
        private Bitmap bitmap;
        private const string defaultPoseName = "Normal";

        public frmAddFrames()
        {
            InitializeComponent();
        }

        public frmAddFrames(FrmSprite mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        public void ShowDialog(Bitmap bitmap)
        {
            this.bitmap = bitmap;
            ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtPattern.ForeColor = Color.Black;
            try
            {
                if (chkDirectional.Checked)
                {
                    var poses = getPoses();
                    if (poses.Count == 0)
                    {
                        DialogResult = DialogResult.None;
                        return;
                    }
                    mainForm.AddPoses(poses);
                }
                else
                {
                    var frames = getFrames();
                    if (frames.Count == 0)
                    {
                        DialogResult = DialogResult.None;
                        return;
                    }
                    mainForm.AddFrames(frames);
                }
            }
            catch (ArgumentException ex)
            {
                mainForm.ShowError(ex.Message);
            }

            Hide();
        }

        private List<Pose> getPoses()
        {
            var poses = new List<Pose>();
            if (!int.TryParse(txtStartX.Text, out var startX) ||
                !int.TryParse(txtStartY.Text, out var startY) ||
                !int.TryParse(txtFrameWidth.Text, out var frameWidth) ||
                !int.TryParse(txtFrameHeight.Text, out var frameHeight) ||
                !int.TryParse(txtFrameCount.Text, out var frameCount) ||
                frameCount < 1)
            {
                return poses;
            }

            var start = new IntVec2(startX, startY);
            var frameSize = new IntVec2(frameWidth, frameHeight);

            string framePattern = txtPattern.Text;

            if (string.IsNullOrEmpty(framePattern) && frameCount > 1)
            {
                // Generates a frane pattern like 2,3,4,1
                var range = Enumerable.Range(1, frameCount);
                framePattern = string.Join(",", range.Skip(1).Concat(range.Take(1)));
            }

            var comparer = StringComparer.OrdinalIgnoreCase;
            var directionMap = new Dictionary<string, string>(comparer)
            {
                { "Up", "Up" },
                { "Right", "Right" },
                { "Down", "Down" },
                { "Left", "Left" },
                { "Up|Left", "Up|Left" },
                { "Up|Right", "Up|Right" },
                { "Down|Left", "Down|Left" },
                { "Down|Right", "Down|Right" },
                { "U", "Up" },
                { "R", "Right" },
                { "D", "Down" },
                { "L", "Left" },
                { "UL", "Up|Left" },
                { "UR", "Up|Right" },
                { "DL", "Down|Left" },
                { "DR", "Down|Right" },
            };

            // Handle patterns like Up,Right,Down,Left or U,R,D,L
            string directionPattern = !string.IsNullOrEmpty(txtDirectionPattern.Text)
                ? txtDirectionPattern.Text : "Up,Right,Down,Left";
            var parts = directionPattern.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim());

            foreach (var direction in parts)
            {
                if (!directionMap.ContainsKey(direction))
                {
                    txtPattern.ForeColor = Color.Red;
                    txtPattern.Focus();
                    return new List<Pose>();
                }

                var facePose = new Pose
                {
                    Tags = new Dictionary<string, string>()
                    {
                        { "Name", defaultPoseName },
                        { "State", "Face" },
                        { "Direction", directionMap[direction] }
                    },
                    Frames = getFrames(start, frameSize, 1)
                };
                poses.Add(facePose);

                var walkPose = new Pose
                {
                    Tags = new Dictionary<string, string>()
                    {
                        { "Name", defaultPoseName },
                        { "State", "Walk" },
                        { "Direction", directionMap[direction] }
                    },
                    Frames = getFrames(start, frameSize, frameCount, pattern: framePattern)
                };
                poses.Add(walkPose);
                start.Y += frameSize.Y;
            }

            return poses;
        }

        private List<Frame> getFrames()
        {
            if (!int.TryParse(txtStartX.Text, out var startX) ||
                !int.TryParse(txtStartY.Text, out var startY) ||
                !int.TryParse(txtFrameWidth.Text, out var frameWidth) ||
                !int.TryParse(txtFrameHeight.Text, out var frameHeight) ||
                !int.TryParse(txtFrameCount.Text, out var frameCount))
            {
                return new List<Frame>();
            }
            if (!int.TryParse(txtPerRow.Text, out var perRow))
            {
                perRow = frameCount;
            }

            var start = new IntVec2(startX, startY);
            var frameSize = new IntVec2(frameWidth, frameHeight);
            try
            {
                return getFrames(start, frameSize, frameCount, perRow, chkRectangular.Checked, chkVertical.Checked, txtPattern.Text);
            }
            catch (PatternException)
            {
                txtPattern.ForeColor = Color.Red;
                txtPattern.Focus();
                return new List<Frame>();
            }
        }

        private List<Frame> getFrames(IntVec2 start, IntVec2 frameSize, int frameCount, int perRow = 1, bool rectangular = false, bool vertical = false, string pattern = "")
        {
            if (!rectangular)
            {
                perRow = frameCount;
            }

            int maxFrames = frameCount / perRow;
            if (frameCount % perRow != 0)
            {
                maxFrames++;
            }

            int maxRow = vertical ? perRow : maxFrames;
            int maxColumn = vertical ? maxFrames : perRow;

            var newFrames = getFrames(start, frameSize, frameCount, maxRow, maxColumn);

            if (string.IsNullOrWhiteSpace(pattern))
            {
                return newFrames;
            }

            var parts = pattern.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            var indexes = new List<int>();
            foreach (var part in parts)
            {
                if (int.TryParse(part, out int result))
                {
                    indexes.Add(result);
                }
                else
                {
                    throw new PatternException();
                }
            }

            var indexedFrames = new List<Frame>();
            foreach (var index in indexes)
            {
                if (index < 1 || index > newFrames.Count)
                {
                    throw new PatternException();
                }
                indexedFrames.Add(new Frame(newFrames[index - 1]));
            }
            return indexedFrames;
        }

        private List<Frame> getFrames(IntVec2 start, IntVec2 frameSize, int frameCount, int maxRow, int maxColumn)
        {
            List<Frame> newFrames = new List<Frame>();
            int counter = 1;
            for (int row = 0; row < maxRow; row++)
            {
                for (int column = 0; column < maxColumn; column++)
                {
                    int x = start.X + column * frameSize.X;
                    int y = start.Y + row * frameSize.Y;
                    if (x < 0 || y < 0 || x + frameSize.X > bitmap.Width || y + frameSize.Y > bitmap.Height)
                    {
                        throw new ArgumentException("Error: Invalid frame positions " + row + ", " + column);
                    }

                    Rect rect = new Rect(x, y, frameSize.X, frameSize.Y);
                    newFrames.Add(new Frame() { Rectangle = rect });

                    if (++counter > frameCount)
                    {
                        return newFrames;
                    }
                }
            }
            return newFrames;
        }

        private void chkRectangular_CheckedChanged(object sender, EventArgs e)
        {
            txtPerRow.Enabled = chkRectangular.Checked;
        }

        private void chkDirectional_CheckedChanged(object sender, EventArgs e)
        {
            chkRectangular.Enabled = !chkDirectional.Checked;
            chkVertical.Enabled = !chkDirectional.Checked;
            txtPerRow.Enabled = !chkDirectional.Checked && chkRectangular.Checked;
            txtDirectionPattern.Enabled = chkDirectional.Checked;
        }

        private class PatternException : ArgumentException
        {
        }
    }
}

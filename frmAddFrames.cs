using SpriteEditor.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Windows.Forms;

namespace SpriteEditor
{
    [SupportedOSPlatform("windows")]
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

        public void ShowDialog(Bitmap bitmap, IWin32Window owner = null)
        {
            this.bitmap = bitmap;
            ShowDialog(owner);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtStartX.ForeColor = Color.Black;
            txtStartY.ForeColor = Color.Black;
            txtFrameWidth.ForeColor = Color.Black;
            txtFrameHeight.ForeColor = Color.Black;
            txtFrameCount.ForeColor = Color.Black;
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
        private void getControlValue(Control control, out int value, int minValue = 0)
        {
            if (!int.TryParse(control.Text, out value) || value < minValue)
            {
                throw new InputException(control);
            }
        }

        private void highlightControlError(Control control)
        {
            if (!string.IsNullOrWhiteSpace(control.Text))
            {
                control.ForeColor = Color.Red;
            }
            control.Focus();
        }

        private List<Pose> getPoses()
        {

            int startX, startY, frameWidth, frameHeight, frameCount;
            try
            {
                getControlValue(txtStartX, out startX);
                getControlValue(txtStartY, out startY);
                getControlValue(txtFrameWidth, out frameWidth, 1);
                getControlValue(txtFrameHeight, out frameHeight, 1);
                getControlValue(txtFrameCount, out frameCount, 1);
            }
            catch (InputException ex)
            {
                highlightControlError(ex.Control);   
                return [];
            }

            var start = new IntVec2(startX, startY);
            var frameSize = new IntVec2(frameWidth, frameHeight);

            string framePattern = txtPattern.Text;

            if (string.IsNullOrEmpty(framePattern) && frameCount > 1)
            {
                // Generates a frame pattern like 2,3,4,1
                var range = Enumerable.Range(1, frameCount);
                framePattern = string.Join(",", range.Skip(1).Concat(range.Take(1)));
            }

            var poses = new List<Pose>();
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
            var parts = directionPattern.Split([','], StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim());

            foreach (var inputDirection in parts)
            {
                if (!directionMap.TryGetValue(inputDirection, out string direction))
                {
                    highlightControlError(txtPattern);
                    return [];
                }

                var facePose = new Pose
                {
                    Tags = new Dictionary<string, string>()
                    {
                        { "Name", defaultPoseName },
                        { "State", "Face" },
                        { "Direction", direction }
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
                        { "Direction", direction }
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
            int startX, startY, frameWidth, frameHeight, frameCount;
            try
            {
                getControlValue(txtStartX, out startX);
                getControlValue(txtStartY, out startY);
                getControlValue(txtFrameWidth, out frameWidth, 1);
                getControlValue(txtFrameHeight, out frameHeight, 1);
                getControlValue(txtFrameCount, out frameCount, 1);
            }
            catch (InputException ex)
            {
                highlightControlError(ex.Control);
                return [];
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
                highlightControlError(txtPattern);
                return [];
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

            var newFrames = getFrames(start, frameSize, frameCount, maxRow, maxColumn, vertical);

            if (string.IsNullOrWhiteSpace(pattern))
            {
                return newFrames;
            }

            var parts = pattern.Split([','], StringSplitOptions.RemoveEmptyEntries);
            var indexes = new List<int>();
            foreach (var part in parts)
            {
                if (int.TryParse(part, out int result))
                {
                    indexes.Add(result);
                }
                else if (part.Contains('-'))
                {
                    var ranges = part.Split('-');
                    if (ranges.Length != 2)
                    {
                        throw new PatternException();
                    }
                    if (!int.TryParse(ranges[0], out int rangeStart)
                        || !int.TryParse(ranges[1], out int rangeEnd)
                        || rangeStart > rangeEnd)
                    {
                        throw new PatternException();
                    }
                    for (var i = rangeStart; i <= rangeEnd; i++)
                    {
                        indexes.Add(i);
                    }
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

        private List<Frame> getFrames(IntVec2 start, IntVec2 frameSize, int frameCount, int maxRow, int maxColumn, bool vertical)
        {
            List<Frame> newFrames = [];
            var outerMax = vertical ? maxColumn : maxRow;
            var innerMax = vertical ? maxRow : maxColumn;
            int counter = 1;
            for (int outer = 0; outer < outerMax; outer++)
            {
                for (int inner = 0; inner < innerMax; inner++)
                {
                    int column = vertical ? outer : inner;
                    int row = vertical ? inner : outer;
                    int x = start.X + column * frameSize.X;
                    int y = start.Y + row * frameSize.Y;
                    if (x < 0 || y < 0 || x + frameSize.X > bitmap.Width || y + frameSize.Y > bitmap.Height)
                    {
                        throw new ArgumentException("Error: Invalid frame positions " + outer + ", " + inner);
                    }

                    Rect rect = new(x, y, frameSize.X, frameSize.Y);
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

        private class InputException(Control control) : ArgumentException
        {
            public Control Control { get; private set; } = control;
        }
    }
}

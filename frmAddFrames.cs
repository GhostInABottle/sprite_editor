using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SpriteEditor
{
    public partial class frmAddFrames : Form
    {
        private FrmSprite mainForm;
        private Bitmap bitmap;

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
                var frames = getFrames();
                if (frames.Count == 0)
                {
                    DialogResult = DialogResult.None;
                    return;
                }
                mainForm.AddFrames(frames);
            }
            catch (ArgumentException ex)
            {
                mainForm.ShowError(ex.Message);
            }

            Hide();
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



            if (!chkRectangular.Checked)
            {
                perRow = frameCount;
            }

            int maxFrames = frameCount / perRow;
            if (frameCount % perRow != 0)
            {
                maxFrames++;
            }

            int maxRow = chkVertical.Checked ? perRow : maxFrames;
            int maxColumn = chkVertical.Checked ? maxFrames : perRow;

            var newFrames = getFrames(startX, startY, frameWidth, frameHeight, frameCount, maxRow, maxColumn);

            if (!string.IsNullOrWhiteSpace(txtPattern.Text))
            {
                var parts = txtPattern.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                var indexes = new List<int>();
                foreach (var part in parts)
                {
                    if (int.TryParse(part, out int result))
                    {

                        indexes.Add(result);
                    }
                    else
                    {
                        txtPattern.ForeColor = Color.Red;
                        txtPattern.Focus();
                        return new List<Frame>();
                    }
                }

                var indexedFrames = new List<Frame>();
                foreach (var index in indexes)
                {
                    if (index < 1 || index > newFrames.Count)
                    {
                        txtPattern.ForeColor = Color.Red;
                        txtPattern.Focus();
                        return new List<Frame>();
                    }
                    indexedFrames.Add(ObjectCopier.Clone(newFrames[index - 1]));
                }
                return indexedFrames;
            }

            return newFrames;
        }

        private List<Frame> getFrames(int startX, int startY, int frameWidth, int frameHeight, int frameCount, int maxRow, int maxColumn)
        {
            List<Frame> newFrames = new List<Frame>();
            int counter = 1;
            for (int row = 0; row < maxRow; row++)
            {
                for (int column = 0; column < maxColumn; column++)
                {
                    int x = startX + column * frameWidth;
                    int y = startY + row * frameHeight;
                    if (x < 0 || y < 0 || x + frameWidth > bitmap.Width || y + frameHeight > bitmap.Height)
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

        private void chkRectangular_CheckedChanged(object sender, EventArgs e)
        {
            txtPerRow.Enabled = chkRectangular.Checked;
        }
    }
}

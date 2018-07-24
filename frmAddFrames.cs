using System;
using System.Windows.Forms;

namespace SpriteEditor
{
    public partial class frmAddFrames : Form
    {
        private FrmSprite mainForm;

        public frmAddFrames()
        {
            InitializeComponent();
        }

        public frmAddFrames(FrmSprite mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtStartX.Text, out var startX) ||
                !int.TryParse(txtStartY.Text, out var startY) ||
                !int.TryParse(txtFrameWidth.Text, out var frameWidth) ||
                !int.TryParse(txtFrameHeight.Text, out var frameHeight) ||
                !int.TryParse(txtFrameCount.Text, out var frameCount))
            {
                return;
            }

            if (!int.TryParse(txtPerRow.Text, out var perRow))
            {
                perRow = frameCount;
            }

            mainForm.AddFrames(
                startX,
                startY,
                frameWidth,
                frameHeight,
                frameCount,
                chkVertical.Checked,
                chkRectangular.Checked,
                perRow);

            Hide();
        }

        private void chkRectangular_CheckedChanged(object sender, EventArgs e)
        {
            txtPerRow.Enabled = chkRectangular.Checked;
        }
    }
}

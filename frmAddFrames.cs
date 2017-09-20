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
            if (!int.TryParse(txtStartX.Text, out int startX) ||
                !int.TryParse(txtStartY.Text, out int startY) ||
                !int.TryParse(txtFrameWidth.Text, out int frameWidth) ||
                !int.TryParse(txtFrameHeight.Text, out int frameHeight) ||
                !int.TryParse(txtFrameCount.Text, out int frameCount))
            {
                return;
            }

            if (!int.TryParse(txtPerRow.Text, out int perRow))
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

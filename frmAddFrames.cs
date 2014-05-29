using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpriteEditor
{
    public partial class frmAddFrames : Form
    {
        private frmSprite mainForm;
        public frmAddFrames()
        {
            InitializeComponent();
        }
        public frmAddFrames(frmSprite mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int startX, startY, frameWidth, frameHeight, frameCount, perRow;
            if (!int.TryParse(txtStartX.Text, out startX)) return;
            if (!int.TryParse(txtStartY.Text, out startY)) return;
            if (!int.TryParse(txtFrameWidth.Text, out frameWidth)) return;
            if (!int.TryParse(txtFrameHeight.Text, out frameHeight)) return;
            if (!int.TryParse(txtFrameCount.Text, out frameCount)) return;
            if (!int.TryParse(txtPerRow.Text, out perRow))
                perRow = frameCount;
            mainForm.AddFrames(startX, startY, frameWidth, frameHeight,
                frameCount, chkVertical.Checked, chkRectangular.Checked, perRow);
            Hide();
        }

        private void chkRectangular_CheckedChanged(object sender, EventArgs e)
        {
            txtPerRow.Enabled = chkRectangular.Checked;
        }

    }
}

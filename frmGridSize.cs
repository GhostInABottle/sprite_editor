using SpriteEditor.Properties;
using System;
using System.Windows.Forms;

namespace SpriteEditor
{
    public partial class frmGridSize : Form
    {
        public frmGridSize()
        {
            InitializeComponent();
        }

        private void btnGridColor_Click(object sender, EventArgs e)
        {
            cdGridColor.ShowDialog();
            btnGridColor.BackColor = cdGridColor.Color;
        }

        private void frmGridSize_Load(object sender, EventArgs e)
        {
            nudGridWidth.Value = Settings.Default.GridWidth;
            nudGridHeight.Value = Settings.Default.GridHeight;
            cdGridColor.Color = Settings.Default.GridColor;
            btnGridColor.BackColor = cdGridColor.Color;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Settings.Default.GridWidth = (int)nudGridWidth.Value;
            Settings.Default.GridHeight = (int)nudGridHeight.Value;
            Settings.Default.GridColor = cdGridColor.Color;
            Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}

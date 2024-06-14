using System;
using System.Windows.Forms;

namespace SpriteEditor
{
    public partial class frmOffset : Form
    {
        public frmOffset()
        {
            InitializeComponent();
        }

        private void frmGridSize_Load(object sender, EventArgs e)
        {
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        public int OffsetX => (int)nudOffsetX.Value;
        public int OffsetY => (int)nudOffsetY.Value;
    }
}

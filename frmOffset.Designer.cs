namespace SpriteEditor
{
    partial class frmOffset
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nudOffsetX = new System.Windows.Forms.NumericUpDown();
            lblOffsetX = new System.Windows.Forms.Label();
            lblOffsetY = new System.Windows.Forms.Label();
            nudOffsetY = new System.Windows.Forms.NumericUpDown();
            btnOK = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)nudOffsetX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudOffsetY).BeginInit();
            SuspendLayout();
            // 
            // nudOffsetX
            // 
            nudOffsetX.Location = new System.Drawing.Point(88, 14);
            nudOffsetX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            nudOffsetX.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            nudOffsetX.Minimum = new decimal(new int[] { 2000, 0, 0, int.MinValue });
            nudOffsetX.Name = "nudOffsetX";
            nudOffsetX.Size = new System.Drawing.Size(117, 23);
            nudOffsetX.TabIndex = 0;
            // 
            // lblOffsetX
            // 
            lblOffsetX.AutoSize = true;
            lblOffsetX.Location = new System.Drawing.Point(14, 16);
            lblOffsetX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOffsetX.Name = "lblOffsetX";
            lblOffsetX.Size = new System.Drawing.Size(51, 15);
            lblOffsetX.TabIndex = 1;
            lblOffsetX.Text = "X-Offset";
            // 
            // lblOffsetY
            // 
            lblOffsetY.AutoSize = true;
            lblOffsetY.Location = new System.Drawing.Point(14, 46);
            lblOffsetY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOffsetY.Name = "lblOffsetY";
            lblOffsetY.Size = new System.Drawing.Size(51, 15);
            lblOffsetY.TabIndex = 3;
            lblOffsetY.Text = "Y-Offset";
            // 
            // nudOffsetY
            // 
            nudOffsetY.Location = new System.Drawing.Point(88, 44);
            nudOffsetY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            nudOffsetY.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            nudOffsetY.Minimum = new decimal(new int[] { 2000, 0, 0, int.MinValue });
            nudOffsetY.Name = "nudOffsetY";
            nudOffsetY.Size = new System.Drawing.Size(117, 23);
            nudOffsetY.TabIndex = 2;
            // 
            // btnOK
            // 
            btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnOK.Location = new System.Drawing.Point(13, 73);
            btnOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(88, 27);
            btnOK.TabIndex = 6;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(114, 73);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(88, 27);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmOffset
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(215, 113);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(lblOffsetY);
            Controls.Add(nudOffsetY);
            Controls.Add(lblOffsetX);
            Controls.Add(nudOffsetX);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmOffset";
            ShowInTaskbar = false;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Adjust Offset";
            TopMost = true;
            Load += frmGridSize_Load;
            ((System.ComponentModel.ISupportInitialize)nudOffsetX).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudOffsetY).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudOffsetX;
        private System.Windows.Forms.Label lblOffsetX;
        private System.Windows.Forms.Label lblOffsetY;
        private System.Windows.Forms.NumericUpDown nudOffsetY;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}

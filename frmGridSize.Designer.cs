namespace SpriteEditor
{
    partial class frmGridSize
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
            nudGridWidth = new System.Windows.Forms.NumericUpDown();
            lblGridWidth = new System.Windows.Forms.Label();
            lblGridHeight = new System.Windows.Forms.Label();
            nudGridHeight = new System.Windows.Forms.NumericUpDown();
            lblGridColor = new System.Windows.Forms.Label();
            cdGridColor = new System.Windows.Forms.ColorDialog();
            btnGridColor = new System.Windows.Forms.Button();
            btnOK = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)nudGridWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudGridHeight).BeginInit();
            SuspendLayout();
            // 
            // nudGridWidth
            // 
            nudGridWidth.Location = new System.Drawing.Point(88, 14);
            nudGridWidth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            nudGridWidth.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudGridWidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudGridWidth.Name = "nudGridWidth";
            nudGridWidth.Size = new System.Drawing.Size(117, 23);
            nudGridWidth.TabIndex = 0;
            nudGridWidth.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblGridWidth
            // 
            lblGridWidth.AutoSize = true;
            lblGridWidth.Location = new System.Drawing.Point(14, 16);
            lblGridWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblGridWidth.Name = "lblGridWidth";
            lblGridWidth.Size = new System.Drawing.Size(64, 15);
            lblGridWidth.TabIndex = 1;
            lblGridWidth.Text = "Grid Width";
            // 
            // lblGridHeight
            // 
            lblGridHeight.AutoSize = true;
            lblGridHeight.Location = new System.Drawing.Point(14, 46);
            lblGridHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblGridHeight.Name = "lblGridHeight";
            lblGridHeight.Size = new System.Drawing.Size(68, 15);
            lblGridHeight.TabIndex = 3;
            lblGridHeight.Text = "Grid Height";
            // 
            // nudGridHeight
            // 
            nudGridHeight.Location = new System.Drawing.Point(88, 44);
            nudGridHeight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            nudGridHeight.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudGridHeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudGridHeight.Name = "nudGridHeight";
            nudGridHeight.Size = new System.Drawing.Size(117, 23);
            nudGridHeight.TabIndex = 2;
            nudGridHeight.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblGridColor
            // 
            lblGridColor.AutoSize = true;
            lblGridColor.Location = new System.Drawing.Point(14, 74);
            lblGridColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblGridColor.Name = "lblGridColor";
            lblGridColor.Size = new System.Drawing.Size(61, 15);
            lblGridColor.TabIndex = 4;
            lblGridColor.Text = "Grid Color";
            // 
            // cdGridColor
            // 
            cdGridColor.Color = System.Drawing.Color.Green;
            // 
            // btnGridColor
            // 
            btnGridColor.Location = new System.Drawing.Point(88, 74);
            btnGridColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnGridColor.Name = "btnGridColor";
            btnGridColor.Size = new System.Drawing.Size(22, 21);
            btnGridColor.TabIndex = 5;
            btnGridColor.UseVisualStyleBackColor = false;
            btnGridColor.Click += btnGridColor_Click;
            // 
            // btnOK
            // 
            btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnOK.Location = new System.Drawing.Point(14, 118);
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
            btnCancel.Location = new System.Drawing.Point(113, 118);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(88, 27);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmGridSize
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(215, 158);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(btnGridColor);
            Controls.Add(lblGridColor);
            Controls.Add(lblGridHeight);
            Controls.Add(nudGridHeight);
            Controls.Add(lblGridWidth);
            Controls.Add(nudGridWidth);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmGridSize";
            ShowInTaskbar = false;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Grid Size";
            TopMost = true;
            Load += frmGridSize_Load;
            ((System.ComponentModel.ISupportInitialize)nudGridWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudGridHeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudGridWidth;
        private System.Windows.Forms.Label lblGridWidth;
        private System.Windows.Forms.Label lblGridHeight;
        private System.Windows.Forms.NumericUpDown nudGridHeight;
        private System.Windows.Forms.Label lblGridColor;
        private System.Windows.Forms.ColorDialog cdGridColor;
        private System.Windows.Forms.Button btnGridColor;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}

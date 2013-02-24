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
            this.nudGridWidth = new System.Windows.Forms.NumericUpDown();
            this.lblGridWidth = new System.Windows.Forms.Label();
            this.lblGridHeight = new System.Windows.Forms.Label();
            this.nudGridHeight = new System.Windows.Forms.NumericUpDown();
            this.lblGridColor = new System.Windows.Forms.Label();
            this.cdGridColor = new System.Windows.Forms.ColorDialog();
            this.btnGridColor = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudGridWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGridHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // nudGridWidth
            // 
            this.nudGridWidth.Location = new System.Drawing.Point(75, 12);
            this.nudGridWidth.Name = "nudGridWidth";
            this.nudGridWidth.Size = new System.Drawing.Size(100, 20);
            this.nudGridWidth.TabIndex = 0;
            // 
            // lblGridWidth
            // 
            this.lblGridWidth.AutoSize = true;
            this.lblGridWidth.Location = new System.Drawing.Point(12, 14);
            this.lblGridWidth.Name = "lblGridWidth";
            this.lblGridWidth.Size = new System.Drawing.Size(57, 13);
            this.lblGridWidth.TabIndex = 1;
            this.lblGridWidth.Text = "Grid Width";
            // 
            // lblGridHeight
            // 
            this.lblGridHeight.AutoSize = true;
            this.lblGridHeight.Location = new System.Drawing.Point(12, 40);
            this.lblGridHeight.Name = "lblGridHeight";
            this.lblGridHeight.Size = new System.Drawing.Size(60, 13);
            this.lblGridHeight.TabIndex = 3;
            this.lblGridHeight.Text = "Grid Height";
            // 
            // nudGridHeight
            // 
            this.nudGridHeight.Location = new System.Drawing.Point(75, 38);
            this.nudGridHeight.Name = "nudGridHeight";
            this.nudGridHeight.Size = new System.Drawing.Size(100, 20);
            this.nudGridHeight.TabIndex = 2;
            // 
            // lblGridColor
            // 
            this.lblGridColor.AutoSize = true;
            this.lblGridColor.Location = new System.Drawing.Point(12, 64);
            this.lblGridColor.Name = "lblGridColor";
            this.lblGridColor.Size = new System.Drawing.Size(53, 13);
            this.lblGridColor.TabIndex = 4;
            this.lblGridColor.Text = "Grid Color";
            // 
            // cdGridColor
            // 
            this.cdGridColor.Color = System.Drawing.Color.Green;
            // 
            // btnGridColor
            // 
            this.btnGridColor.Location = new System.Drawing.Point(75, 64);
            this.btnGridColor.Name = "btnGridColor";
            this.btnGridColor.Size = new System.Drawing.Size(19, 18);
            this.btnGridColor.TabIndex = 5;
            this.btnGridColor.UseVisualStyleBackColor = false;
            this.btnGridColor.Click += new System.EventHandler(this.btnGridColor_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 102);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(97, 102);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmGridSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 137);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnGridColor);
            this.Controls.Add(this.lblGridColor);
            this.Controls.Add(this.lblGridHeight);
            this.Controls.Add(this.nudGridHeight);
            this.Controls.Add(this.lblGridWidth);
            this.Controls.Add(this.nudGridWidth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGridSize";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Grid Size";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmGridSize_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudGridWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGridHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

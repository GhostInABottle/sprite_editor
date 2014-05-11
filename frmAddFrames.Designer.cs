namespace SpriteEditor
{
    partial class frmAddFrames
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
            this.lblStartingX = new System.Windows.Forms.Label();
            this.lblStartingY = new System.Windows.Forms.Label();
            this.lblFrameWidth = new System.Windows.Forms.Label();
            this.lblFrameHeight = new System.Windows.Forms.Label();
            this.lblFrameCount = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtStartX = new System.Windows.Forms.TextBox();
            this.txtStartY = new System.Windows.Forms.TextBox();
            this.txtFrameWidth = new System.Windows.Forms.TextBox();
            this.txtFrameHeight = new System.Windows.Forms.TextBox();
            this.txtFrameCount = new System.Windows.Forms.TextBox();
            this.chkVertical = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblStartingX
            // 
            this.lblStartingX.AutoSize = true;
            this.lblStartingX.Location = new System.Drawing.Point(10, 17);
            this.lblStartingX.Name = "lblStartingX";
            this.lblStartingX.Size = new System.Drawing.Size(53, 13);
            this.lblStartingX.TabIndex = 0;
            this.lblStartingX.Text = "Starting X";
            // 
            // lblStartingY
            // 
            this.lblStartingY.AutoSize = true;
            this.lblStartingY.Location = new System.Drawing.Point(137, 17);
            this.lblStartingY.Name = "lblStartingY";
            this.lblStartingY.Size = new System.Drawing.Size(53, 13);
            this.lblStartingY.TabIndex = 1;
            this.lblStartingY.Text = "Starting Y";
            // 
            // lblFrameWidth
            // 
            this.lblFrameWidth.AutoSize = true;
            this.lblFrameWidth.Location = new System.Drawing.Point(10, 51);
            this.lblFrameWidth.Name = "lblFrameWidth";
            this.lblFrameWidth.Size = new System.Drawing.Size(67, 13);
            this.lblFrameWidth.TabIndex = 2;
            this.lblFrameWidth.Text = "Frame Width";
            // 
            // lblFrameHeight
            // 
            this.lblFrameHeight.AutoSize = true;
            this.lblFrameHeight.Location = new System.Drawing.Point(137, 51);
            this.lblFrameHeight.Name = "lblFrameHeight";
            this.lblFrameHeight.Size = new System.Drawing.Size(70, 13);
            this.lblFrameHeight.TabIndex = 3;
            this.lblFrameHeight.Text = "Frame Height";
            // 
            // lblFrameCount
            // 
            this.lblFrameCount.AutoSize = true;
            this.lblFrameCount.Location = new System.Drawing.Point(10, 83);
            this.lblFrameCount.Name = "lblFrameCount";
            this.lblFrameCount.Size = new System.Drawing.Size(67, 13);
            this.lblFrameCount.TabIndex = 4;
            this.lblFrameCount.Text = "Frame Count";
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(83, 112);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 32);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtStartX
            // 
            this.txtStartX.Location = new System.Drawing.Point(83, 17);
            this.txtStartX.Name = "txtStartX";
            this.txtStartX.Size = new System.Drawing.Size(45, 20);
            this.txtStartX.TabIndex = 7;
            // 
            // txtStartY
            // 
            this.txtStartY.Location = new System.Drawing.Point(213, 17);
            this.txtStartY.Name = "txtStartY";
            this.txtStartY.Size = new System.Drawing.Size(45, 20);
            this.txtStartY.TabIndex = 8;
            // 
            // txtFrameWidth
            // 
            this.txtFrameWidth.Location = new System.Drawing.Point(83, 48);
            this.txtFrameWidth.Name = "txtFrameWidth";
            this.txtFrameWidth.Size = new System.Drawing.Size(45, 20);
            this.txtFrameWidth.TabIndex = 9;
            // 
            // txtFrameHeight
            // 
            this.txtFrameHeight.Location = new System.Drawing.Point(213, 51);
            this.txtFrameHeight.Name = "txtFrameHeight";
            this.txtFrameHeight.Size = new System.Drawing.Size(45, 20);
            this.txtFrameHeight.TabIndex = 10;
            // 
            // txtFrameCount
            // 
            this.txtFrameCount.Location = new System.Drawing.Point(83, 80);
            this.txtFrameCount.Name = "txtFrameCount";
            this.txtFrameCount.Size = new System.Drawing.Size(45, 20);
            this.txtFrameCount.TabIndex = 11;
            // 
            // chkVertical
            // 
            this.chkVertical.AutoSize = true;
            this.chkVertical.Location = new System.Drawing.Point(140, 83);
            this.chkVertical.Name = "chkVertical";
            this.chkVertical.Size = new System.Drawing.Size(98, 17);
            this.chkVertical.TabIndex = 12;
            this.chkVertical.Text = "Vertical Frames";
            this.chkVertical.UseVisualStyleBackColor = true;
            // 
            // frmAddFrames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 156);
            this.Controls.Add(this.chkVertical);
            this.Controls.Add(this.txtFrameCount);
            this.Controls.Add(this.txtFrameHeight);
            this.Controls.Add(this.txtFrameWidth);
            this.Controls.Add(this.txtStartY);
            this.Controls.Add(this.txtStartX);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblFrameCount);
            this.Controls.Add(this.lblFrameHeight);
            this.Controls.Add(this.lblFrameWidth);
            this.Controls.Add(this.lblStartingY);
            this.Controls.Add(this.lblStartingX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmAddFrames";
            this.Text = "Add Frames";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStartingX;
        private System.Windows.Forms.Label lblStartingY;
        private System.Windows.Forms.Label lblFrameWidth;
        private System.Windows.Forms.Label lblFrameHeight;
        private System.Windows.Forms.Label lblFrameCount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtStartX;
        private System.Windows.Forms.TextBox txtStartY;
        private System.Windows.Forms.TextBox txtFrameWidth;
        private System.Windows.Forms.TextBox txtFrameHeight;
        private System.Windows.Forms.TextBox txtFrameCount;
        private System.Windows.Forms.CheckBox chkVertical;
    }
}
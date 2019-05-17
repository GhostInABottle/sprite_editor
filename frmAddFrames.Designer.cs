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
            this.txtPerRow = new System.Windows.Forms.TextBox();
            this.lblPerRow = new System.Windows.Forms.Label();
            this.chkVertical = new System.Windows.Forms.CheckBox();
            this.chkRectangular = new System.Windows.Forms.CheckBox();
            this.lblPattern = new System.Windows.Forms.Label();
            this.txtPattern = new System.Windows.Forms.TextBox();
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
            this.lblFrameWidth.Location = new System.Drawing.Point(10, 43);
            this.lblFrameWidth.Name = "lblFrameWidth";
            this.lblFrameWidth.Size = new System.Drawing.Size(67, 13);
            this.lblFrameWidth.TabIndex = 2;
            this.lblFrameWidth.Text = "Frame Width";
            // 
            // lblFrameHeight
            // 
            this.lblFrameHeight.AutoSize = true;
            this.lblFrameHeight.Location = new System.Drawing.Point(137, 43);
            this.lblFrameHeight.Name = "lblFrameHeight";
            this.lblFrameHeight.Size = new System.Drawing.Size(70, 13);
            this.lblFrameHeight.TabIndex = 3;
            this.lblFrameHeight.Text = "Frame Height";
            // 
            // lblFrameCount
            // 
            this.lblFrameCount.AutoSize = true;
            this.lblFrameCount.Location = new System.Drawing.Point(137, 69);
            this.lblFrameCount.Name = "lblFrameCount";
            this.lblFrameCount.Size = new System.Drawing.Size(67, 13);
            this.lblFrameCount.TabIndex = 4;
            this.lblFrameCount.Text = "Frame Count";
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(83, 144);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 32);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtStartX
            // 
            this.txtStartX.Location = new System.Drawing.Point(83, 14);
            this.txtStartX.Name = "txtStartX";
            this.txtStartX.Size = new System.Drawing.Size(45, 20);
            this.txtStartX.TabIndex = 7;
            // 
            // txtStartY
            // 
            this.txtStartY.Location = new System.Drawing.Point(213, 14);
            this.txtStartY.Name = "txtStartY";
            this.txtStartY.Size = new System.Drawing.Size(45, 20);
            this.txtStartY.TabIndex = 8;
            // 
            // txtFrameWidth
            // 
            this.txtFrameWidth.Location = new System.Drawing.Point(83, 40);
            this.txtFrameWidth.Name = "txtFrameWidth";
            this.txtFrameWidth.Size = new System.Drawing.Size(45, 20);
            this.txtFrameWidth.TabIndex = 9;
            // 
            // txtFrameHeight
            // 
            this.txtFrameHeight.Location = new System.Drawing.Point(213, 40);
            this.txtFrameHeight.Name = "txtFrameHeight";
            this.txtFrameHeight.Size = new System.Drawing.Size(45, 20);
            this.txtFrameHeight.TabIndex = 10;
            // 
            // txtFrameCount
            // 
            this.txtFrameCount.Location = new System.Drawing.Point(213, 66);
            this.txtFrameCount.Name = "txtFrameCount";
            this.txtFrameCount.Size = new System.Drawing.Size(45, 20);
            this.txtFrameCount.TabIndex = 11;
            // 
            // txtPerRow
            // 
            this.txtPerRow.Enabled = false;
            this.txtPerRow.Location = new System.Drawing.Point(213, 92);
            this.txtPerRow.Name = "txtPerRow";
            this.txtPerRow.Size = new System.Drawing.Size(45, 20);
            this.txtPerRow.TabIndex = 14;
            // 
            // lblPerRow
            // 
            this.lblPerRow.AutoSize = true;
            this.lblPerRow.Location = new System.Drawing.Point(137, 95);
            this.lblPerRow.Name = "lblPerRow";
            this.lblPerRow.Size = new System.Drawing.Size(76, 13);
            this.lblPerRow.TabIndex = 13;
            this.lblPerRow.Text = "Per Row/Clmn";
            // 
            // chkVertical
            // 
            this.chkVertical.AutoSize = true;
            this.chkVertical.Location = new System.Drawing.Point(13, 66);
            this.chkVertical.Name = "chkVertical";
            this.chkVertical.Size = new System.Drawing.Size(106, 17);
            this.chkVertical.TabIndex = 12;
            this.chkVertical.Text = "Vertical Direction";
            this.chkVertical.UseVisualStyleBackColor = true;
            // 
            // chkRectangular
            // 
            this.chkRectangular.AutoSize = true;
            this.chkRectangular.Location = new System.Drawing.Point(13, 89);
            this.chkRectangular.Name = "chkRectangular";
            this.chkRectangular.Size = new System.Drawing.Size(84, 17);
            this.chkRectangular.TabIndex = 15;
            this.chkRectangular.Text = "Rectangular";
            this.chkRectangular.UseVisualStyleBackColor = true;
            this.chkRectangular.CheckedChanged += new System.EventHandler(this.chkRectangular_CheckedChanged);
            // 
            // lblPattern
            // 
            this.lblPattern.AutoSize = true;
            this.lblPattern.Location = new System.Drawing.Point(10, 121);
            this.lblPattern.Name = "lblPattern";
            this.lblPattern.Size = new System.Drawing.Size(41, 13);
            this.lblPattern.TabIndex = 16;
            this.lblPattern.Text = "Pattern";
            // 
            // txtPattern
            // 
            this.txtPattern.Location = new System.Drawing.Point(57, 118);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(201, 20);
            this.txtPattern.TabIndex = 17;
            // 
            // frmAddFrames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 184);
            this.Controls.Add(this.txtPattern);
            this.Controls.Add(this.lblPattern);
            this.Controls.Add(this.chkRectangular);
            this.Controls.Add(this.txtPerRow);
            this.Controls.Add(this.lblPerRow);
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
        private System.Windows.Forms.TextBox txtPerRow;
        private System.Windows.Forms.Label lblPerRow;
        private System.Windows.Forms.CheckBox chkVertical;
        private System.Windows.Forms.CheckBox chkRectangular;
        private System.Windows.Forms.Label lblPattern;
        private System.Windows.Forms.TextBox txtPattern;
    }
}
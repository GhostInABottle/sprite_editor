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
            lblStartingX = new System.Windows.Forms.Label();
            lblStartingY = new System.Windows.Forms.Label();
            lblFrameWidth = new System.Windows.Forms.Label();
            lblFrameHeight = new System.Windows.Forms.Label();
            lblFrameCount = new System.Windows.Forms.Label();
            btnAdd = new System.Windows.Forms.Button();
            txtStartX = new System.Windows.Forms.TextBox();
            txtStartY = new System.Windows.Forms.TextBox();
            txtFrameWidth = new System.Windows.Forms.TextBox();
            txtFrameHeight = new System.Windows.Forms.TextBox();
            txtFrameCount = new System.Windows.Forms.TextBox();
            txtPerRow = new System.Windows.Forms.TextBox();
            lblPerRow = new System.Windows.Forms.Label();
            chkVertical = new System.Windows.Forms.CheckBox();
            chkRectangular = new System.Windows.Forms.CheckBox();
            lblPattern = new System.Windows.Forms.Label();
            txtPattern = new System.Windows.Forms.TextBox();
            chkDirectional = new System.Windows.Forms.CheckBox();
            lblDirPattern = new System.Windows.Forms.Label();
            txtDirectionPattern = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // lblStartingX
            // 
            lblStartingX.AutoSize = true;
            lblStartingX.Location = new System.Drawing.Point(12, 20);
            lblStartingX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblStartingX.Name = "lblStartingX";
            lblStartingX.Size = new System.Drawing.Size(58, 15);
            lblStartingX.TabIndex = 0;
            lblStartingX.Text = "Starting X";
            // 
            // lblStartingY
            // 
            lblStartingY.AutoSize = true;
            lblStartingY.Location = new System.Drawing.Point(160, 20);
            lblStartingY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblStartingY.Name = "lblStartingY";
            lblStartingY.Size = new System.Drawing.Size(58, 15);
            lblStartingY.TabIndex = 1;
            lblStartingY.Text = "Starting Y";
            // 
            // lblFrameWidth
            // 
            lblFrameWidth.AutoSize = true;
            lblFrameWidth.Location = new System.Drawing.Point(12, 50);
            lblFrameWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFrameWidth.Name = "lblFrameWidth";
            lblFrameWidth.Size = new System.Drawing.Size(75, 15);
            lblFrameWidth.TabIndex = 2;
            lblFrameWidth.Text = "Frame Width";
            // 
            // lblFrameHeight
            // 
            lblFrameHeight.AutoSize = true;
            lblFrameHeight.Location = new System.Drawing.Point(160, 50);
            lblFrameHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFrameHeight.Name = "lblFrameHeight";
            lblFrameHeight.Size = new System.Drawing.Size(79, 15);
            lblFrameHeight.TabIndex = 3;
            lblFrameHeight.Text = "Frame Height";
            // 
            // lblFrameCount
            // 
            lblFrameCount.AutoSize = true;
            lblFrameCount.Location = new System.Drawing.Point(12, 80);
            lblFrameCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFrameCount.Name = "lblFrameCount";
            lblFrameCount.Size = new System.Drawing.Size(76, 15);
            lblFrameCount.TabIndex = 4;
            lblFrameCount.Text = "Frame Count";
            // 
            // btnAdd
            // 
            btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnAdd.Location = new System.Drawing.Point(97, 196);
            btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(125, 37);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtStartX
            // 
            txtStartX.Location = new System.Drawing.Point(97, 16);
            txtStartX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtStartX.Name = "txtStartX";
            txtStartX.Size = new System.Drawing.Size(52, 23);
            txtStartX.TabIndex = 7;
            txtStartX.Text = "0";
            // 
            // txtStartY
            // 
            txtStartY.Location = new System.Drawing.Point(248, 16);
            txtStartY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtStartY.Name = "txtStartY";
            txtStartY.Size = new System.Drawing.Size(52, 23);
            txtStartY.TabIndex = 8;
            txtStartY.Text = "0";
            // 
            // txtFrameWidth
            // 
            txtFrameWidth.Location = new System.Drawing.Point(97, 46);
            txtFrameWidth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtFrameWidth.Name = "txtFrameWidth";
            txtFrameWidth.Size = new System.Drawing.Size(52, 23);
            txtFrameWidth.TabIndex = 9;
            // 
            // txtFrameHeight
            // 
            txtFrameHeight.Location = new System.Drawing.Point(248, 46);
            txtFrameHeight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtFrameHeight.Name = "txtFrameHeight";
            txtFrameHeight.Size = new System.Drawing.Size(52, 23);
            txtFrameHeight.TabIndex = 10;
            // 
            // txtFrameCount
            // 
            txtFrameCount.Location = new System.Drawing.Point(97, 76);
            txtFrameCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtFrameCount.Name = "txtFrameCount";
            txtFrameCount.Size = new System.Drawing.Size(52, 23);
            txtFrameCount.TabIndex = 11;
            // 
            // txtPerRow
            // 
            txtPerRow.Enabled = false;
            txtPerRow.Location = new System.Drawing.Point(248, 76);
            txtPerRow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtPerRow.Name = "txtPerRow";
            txtPerRow.Size = new System.Drawing.Size(52, 23);
            txtPerRow.TabIndex = 14;
            // 
            // lblPerRow
            // 
            lblPerRow.AutoSize = true;
            lblPerRow.Location = new System.Drawing.Point(156, 80);
            lblPerRow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPerRow.Name = "lblPerRow";
            lblPerRow.Size = new System.Drawing.Size(84, 15);
            lblPerRow.TabIndex = 13;
            lblPerRow.Text = "Per Row/Clmn";
            // 
            // chkVertical
            // 
            chkVertical.AutoSize = true;
            chkVertical.Location = new System.Drawing.Point(14, 111);
            chkVertical.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkVertical.Name = "chkVertical";
            chkVertical.Size = new System.Drawing.Size(64, 19);
            chkVertical.TabIndex = 12;
            chkVertical.Text = "Vertical";
            chkVertical.UseVisualStyleBackColor = true;
            // 
            // chkRectangular
            // 
            chkRectangular.AutoSize = true;
            chkRectangular.Location = new System.Drawing.Point(92, 111);
            chkRectangular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkRectangular.Name = "chkRectangular";
            chkRectangular.Size = new System.Drawing.Size(89, 19);
            chkRectangular.TabIndex = 15;
            chkRectangular.Text = "Rectangular";
            chkRectangular.UseVisualStyleBackColor = true;
            chkRectangular.CheckedChanged += chkRectangular_CheckedChanged;
            // 
            // lblPattern
            // 
            lblPattern.AutoSize = true;
            lblPattern.Location = new System.Drawing.Point(10, 141);
            lblPattern.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPattern.Name = "lblPattern";
            lblPattern.Size = new System.Drawing.Size(81, 15);
            lblPattern.TabIndex = 16;
            lblPattern.Text = "Frame Pattern";
            // 
            // txtPattern
            // 
            txtPattern.Location = new System.Drawing.Point(97, 137);
            txtPattern.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtPattern.Name = "txtPattern";
            txtPattern.Size = new System.Drawing.Size(204, 23);
            txtPattern.TabIndex = 17;
            // 
            // chkDirectional
            // 
            chkDirectional.AutoSize = true;
            chkDirectional.Location = new System.Drawing.Point(197, 111);
            chkDirectional.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkDirectional.Name = "chkDirectional";
            chkDirectional.Size = new System.Drawing.Size(83, 19);
            chkDirectional.TabIndex = 18;
            chkDirectional.Text = "Directional";
            chkDirectional.UseVisualStyleBackColor = true;
            chkDirectional.CheckedChanged += chkDirectional_CheckedChanged;
            // 
            // lblDirPattern
            // 
            lblDirPattern.AutoSize = true;
            lblDirPattern.Location = new System.Drawing.Point(12, 168);
            lblDirPattern.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDirPattern.Name = "lblDirPattern";
            lblDirPattern.Size = new System.Drawing.Size(66, 15);
            lblDirPattern.TabIndex = 19;
            lblDirPattern.Text = "Dir. Pattern";
            // 
            // txtDirectionPattern
            // 
            txtDirectionPattern.Enabled = false;
            txtDirectionPattern.Location = new System.Drawing.Point(97, 165);
            txtDirectionPattern.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtDirectionPattern.Name = "txtDirectionPattern";
            txtDirectionPattern.Size = new System.Drawing.Size(204, 23);
            txtDirectionPattern.TabIndex = 20;
            // 
            // frmAddFrames
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(318, 247);
            Controls.Add(txtDirectionPattern);
            Controls.Add(lblDirPattern);
            Controls.Add(chkDirectional);
            Controls.Add(txtPattern);
            Controls.Add(lblPattern);
            Controls.Add(chkRectangular);
            Controls.Add(txtPerRow);
            Controls.Add(lblPerRow);
            Controls.Add(chkVertical);
            Controls.Add(txtFrameCount);
            Controls.Add(txtFrameHeight);
            Controls.Add(txtFrameWidth);
            Controls.Add(txtStartY);
            Controls.Add(txtStartX);
            Controls.Add(btnAdd);
            Controls.Add(lblFrameCount);
            Controls.Add(lblFrameHeight);
            Controls.Add(lblFrameWidth);
            Controls.Add(lblStartingY);
            Controls.Add(lblStartingX);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frmAddFrames";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Add Frames";
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.CheckBox chkDirectional;
        private System.Windows.Forms.Label lblDirPattern;
        private System.Windows.Forms.TextBox txtDirectionPattern;
    }
}
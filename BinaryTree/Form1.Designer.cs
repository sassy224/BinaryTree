namespace BinaryTree
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtBaseX = new System.Windows.Forms.TextBox();
            this.lblBaseX = new System.Windows.Forms.Label();
            this.lblBaseY = new System.Windows.Forms.Label();
            this.txtBaseY = new System.Windows.Forms.TextBox();
            this.lblTreeLevel = new System.Windows.Forms.Label();
            this.txtTreeLevel = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // btnCheck
            // 
            this.btnCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCheck.Location = new System.Drawing.Point(84, 422);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(65, 23);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreate.Location = new System.Drawing.Point(12, 422);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(66, 23);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(538, 351);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblMsg
            // 
            this.lblMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMsg.AutoEllipsis = true;
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(13, 374);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(55, 13);
            this.lblMsg.TabIndex = 6;
            this.lblMsg.Text = "Messages";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Node Count:";
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(513, 399);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(13, 13);
            this.lblCount.TabIndex = 8;
            this.lblCount.Text = "0";
            // 
            // txtBaseX
            // 
            this.txtBaseX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBaseX.Location = new System.Drawing.Point(60, 396);
            this.txtBaseX.Name = "txtBaseX";
            this.txtBaseX.Size = new System.Drawing.Size(29, 20);
            this.txtBaseX.TabIndex = 12;
            this.txtBaseX.TextChanged += new System.EventHandler(this.txtBaseX_TextChanged);
            // 
            // lblBaseX
            // 
            this.lblBaseX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBaseX.AutoSize = true;
            this.lblBaseX.Location = new System.Drawing.Point(13, 399);
            this.lblBaseX.Name = "lblBaseX";
            this.lblBaseX.Size = new System.Drawing.Size(41, 13);
            this.lblBaseX.TabIndex = 13;
            this.lblBaseX.Text = "Base X";
            // 
            // lblBaseY
            // 
            this.lblBaseY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBaseY.AutoSize = true;
            this.lblBaseY.Location = new System.Drawing.Point(95, 399);
            this.lblBaseY.Name = "lblBaseY";
            this.lblBaseY.Size = new System.Drawing.Size(41, 13);
            this.lblBaseY.TabIndex = 14;
            this.lblBaseY.Text = "Base Y";
            // 
            // txtBaseY
            // 
            this.txtBaseY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBaseY.Location = new System.Drawing.Point(142, 396);
            this.txtBaseY.Name = "txtBaseY";
            this.txtBaseY.Size = new System.Drawing.Size(29, 20);
            this.txtBaseY.TabIndex = 15;
            this.txtBaseY.TextChanged += new System.EventHandler(this.txtBaseY_TextChanged);
            // 
            // lblTreeLevel
            // 
            this.lblTreeLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTreeLevel.AutoSize = true;
            this.lblTreeLevel.Location = new System.Drawing.Point(178, 399);
            this.lblTreeLevel.Name = "lblTreeLevel";
            this.lblTreeLevel.Size = new System.Drawing.Size(107, 13);
            this.lblTreeLevel.TabIndex = 16;
            this.lblTreeLevel.Text = "Tree level (max is 10)";
            // 
            // txtTreeLevel
            // 
            this.txtTreeLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTreeLevel.Location = new System.Drawing.Point(291, 396);
            this.txtTreeLevel.Name = "txtTreeLevel";
            this.txtTreeLevel.Size = new System.Drawing.Size(29, 20);
            this.txtTreeLevel.TabIndex = 17;
            this.txtTreeLevel.TextChanged += new System.EventHandler(this.txtTreeLevel_TextChanged);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(14, 354);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(24, 13);
            this.lblTime.TabIndex = 18;
            this.lblTime.Text = "test";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 449);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtTreeLevel);
            this.Controls.Add(this.lblTreeLevel);
            this.Controls.Add(this.txtBaseY);
            this.Controls.Add(this.lblBaseY);
            this.Controls.Add(this.lblBaseX);
            this.Controls.Add(this.txtBaseX);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.textBox1);
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "Binary Tree";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TextBox txtBaseX;
        private System.Windows.Forms.Label lblBaseX;
        private System.Windows.Forms.Label lblBaseY;
        private System.Windows.Forms.TextBox txtBaseY;
        private System.Windows.Forms.Label lblTreeLevel;
        private System.Windows.Forms.TextBox txtTreeLevel;
        private System.Windows.Forms.Label lblTime;
    }
}


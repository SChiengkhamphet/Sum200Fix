namespace Sum200
{
    partial class frmMain
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
            this.btnStart = new System.Windows.Forms.Button();
            this.txtHalfway = new System.Windows.Forms.TextBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.lblHalfway = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(13, 13);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtHalfway
            // 
            this.txtHalfway.Location = new System.Drawing.Point(12, 55);
            this.txtHalfway.Name = "txtHalfway";
            this.txtHalfway.Size = new System.Drawing.Size(75, 22);
            this.txtHalfway.TabIndex = 1;
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(13, 84);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(73, 22);
            this.txtSum.TabIndex = 2;
            // 
            // lblHalfway
            // 
            this.lblHalfway.AutoSize = true;
            this.lblHalfway.Location = new System.Drawing.Point(94, 59);
            this.lblHalfway.Name = "lblHalfway";
            this.lblHalfway.Size = new System.Drawing.Size(57, 17);
            this.lblHalfway.TabIndex = 3;
            this.lblHalfway.Text = "Halfway";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(93, 88);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(36, 17);
            this.lblSum.TabIndex = 4;
            this.lblSum.Text = "Sum";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 183);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.lblHalfway);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.txtHalfway);
            this.Controls.Add(this.btnStart);
            this.Name = "frmMain";
            this.Text = "Sum 200";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtHalfway;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label lblHalfway;
        private System.Windows.Forms.Label lblSum;
    }
}


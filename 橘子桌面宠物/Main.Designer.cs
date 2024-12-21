namespace 橘子桌面宠物
{
    partial class Main
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
            if (disposing && components is not null)
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
            this.mainPictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPictureBox1
            // 
            this.mainPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.mainPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.mainPictureBox1.Name = "mainPictureBox1";
            this.mainPictureBox1.Size = new System.Drawing.Size(147, 105);
            this.mainPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainPictureBox1.TabIndex = 0;
            this.mainPictureBox1.TabStop = false;
            this.mainPictureBox1.Click += new System.EventHandler(this.mainPictureBox1_Click);
            this.mainPictureBox1.DoubleClick += new System.EventHandler(this.mainPictureBox1_DoubleClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(147, 105);
            this.Controls.Add(this.mainPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPictureBox1;
    }
}
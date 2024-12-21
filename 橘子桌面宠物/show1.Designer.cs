namespace 橘子桌面宠物
{
    partial class show1
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
            this.showLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showLabel1
            // 
            this.showLabel1.AutoSize = true;
            this.showLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showLabel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.showLabel1.Location = new System.Drawing.Point(0, 0);
            this.showLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.showLabel1.Name = "showLabel1";
            this.showLabel1.Size = new System.Drawing.Size(109, 20);
            this.showLabel1.TabIndex = 0;
            this.showLabel1.Text = "显示的东西";
            // 
            // show1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(154, 43);
            this.Controls.Add(this.showLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "show1";
            this.Text = "show1";
            this.Load += new System.EventHandler(this.show1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label showLabel1;
    }
}
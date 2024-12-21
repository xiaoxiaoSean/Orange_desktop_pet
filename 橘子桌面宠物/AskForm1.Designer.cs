namespace 橘子桌面宠物
{
    partial class AskForm1
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
            this.mainLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.askBox1 = new System.Windows.Forms.TextBox();
            this.askButton1 = new System.Windows.Forms.Button();
            this.mainLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayoutPanel1
            // 
            this.mainLayoutPanel1.ColumnCount = 2;
            this.mainLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.mainLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainLayoutPanel1.Controls.Add(this.askBox1, 0, 0);
            this.mainLayoutPanel1.Controls.Add(this.askButton1, 1, 0);
            this.mainLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutPanel1.Name = "mainLayoutPanel1";
            this.mainLayoutPanel1.RowCount = 1;
            this.mainLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayoutPanel1.Size = new System.Drawing.Size(437, 168);
            this.mainLayoutPanel1.TabIndex = 0;
            // 
            // askBox1
            // 
            this.askBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.askBox1.Location = new System.Drawing.Point(3, 3);
            this.askBox1.Multiline = true;
            this.askBox1.Name = "askBox1";
            this.askBox1.Size = new System.Drawing.Size(343, 162);
            this.askBox1.TabIndex = 0;
            // 
            // askButton1
            // 
            this.askButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.askButton1.Location = new System.Drawing.Point(352, 3);
            this.askButton1.Name = "askButton1";
            this.askButton1.Size = new System.Drawing.Size(82, 162);
            this.askButton1.TabIndex = 1;
            this.askButton1.Text = "开问";
            this.askButton1.UseVisualStyleBackColor = true;
            this.askButton1.Click += new System.EventHandler(this.askButton1_Click);
            // 
            // AskForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 168);
            this.Controls.Add(this.mainLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AskForm1";
            this.Text = "AskForm1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AskForm1_Load);
            this.mainLayoutPanel1.ResumeLayout(false);
            this.mainLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel1;
        private System.Windows.Forms.TextBox askBox1;
        private System.Windows.Forms.Button askButton1;
    }
}
namespace 橘子桌面宠物
{
    partial class AnswerForm1
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
            this.answerBox1 = new System.Windows.Forms.TextBox();
            this.mainLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayoutPanel1
            // 
            this.mainLayoutPanel1.ColumnCount = 2;
            this.mainLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.5F));
            this.mainLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.5F));
            this.mainLayoutPanel1.Controls.Add(this.answerBox1, 0, 1);
            this.mainLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutPanel1.Name = "mainLayoutPanel1";
            this.mainLayoutPanel1.RowCount = 2;
            this.mainLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.mainLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.mainLayoutPanel1.TabIndex = 0;
            // 
            // answerBox1
            // 
            this.answerBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answerBox1.Location = new System.Drawing.Point(33, 58);
            this.answerBox1.Multiline = true;
            this.answerBox1.Name = "answerBox1";
            this.answerBox1.Size = new System.Drawing.Size(103, 298);
            this.answerBox1.TabIndex = 0;
            // 
            // AnswerForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnswerForm1";
            this.Text = "回答";
            this.Load += new System.EventHandler(this.AnswerForm1_Load);
            this.mainLayoutPanel1.ResumeLayout(false);
            this.mainLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel1;
        private System.Windows.Forms.TextBox answerBox1;
    }
}
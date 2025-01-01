namespace 橘子桌面宠物
{
    partial class AnswerForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.copyButton = new System.Windows.Forms.Button();
            this.poweredByBox = new System.Windows.Forms.TextBox();
            this.saveAsButton = new System.Windows.Forms.Button();
            this.closeThisWindowsButton = new System.Windows.Forms.Button();
            this.answerBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.answerBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 339F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.2749F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.7251F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.tableLayoutPanel2.Controls.Add(this.copyButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.poweredByBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.saveAsButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.closeThisWindowsButton, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 389);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 58);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // copyButton
            // 
            this.copyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyButton.Location = new System.Drawing.Point(3, 3);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(108, 52);
            this.copyButton.TabIndex = 0;
            this.copyButton.Text = "复制到剪切板";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // poweredByBox
            // 
            this.poweredByBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.poweredByBox.Location = new System.Drawing.Point(117, 3);
            this.poweredByBox.Name = "poweredByBox";
            this.poweredByBox.ReadOnly = true;
            this.poweredByBox.Size = new System.Drawing.Size(246, 25);
            this.poweredByBox.TabIndex = 1;
            this.poweredByBox.Text = "Powered By Kimi AI";
            // 
            // saveAsButton
            // 
            this.saveAsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveAsButton.Location = new System.Drawing.Point(369, 3);
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(151, 52);
            this.saveAsButton.TabIndex = 2;
            this.saveAsButton.Text = "保存为...";
            this.saveAsButton.UseVisualStyleBackColor = true;
            this.saveAsButton.Click += new System.EventHandler(this.saveAsButton_Click);
            // 
            // closeThisWindowsButton
            // 
            this.closeThisWindowsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeThisWindowsButton.Location = new System.Drawing.Point(526, 3);
            this.closeThisWindowsButton.Name = "closeThisWindowsButton";
            this.closeThisWindowsButton.Size = new System.Drawing.Size(265, 52);
            this.closeThisWindowsButton.TabIndex = 3;
            this.closeThisWindowsButton.Text = "关闭本窗口";
            this.closeThisWindowsButton.UseVisualStyleBackColor = true;
            this.closeThisWindowsButton.Click += new System.EventHandler(this.closeThisWindowsButton_Click);
            // 
            // answerBox
            // 
            this.answerBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answerBox.Location = new System.Drawing.Point(3, 50);
            this.answerBox.Multiline = true;
            this.answerBox.Name = "answerBox";
            this.answerBox.ReadOnly = true;
            this.answerBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.answerBox.Size = new System.Drawing.Size(794, 333);
            this.answerBox.TabIndex = 1;
            this.answerBox.Text = "来自AI的回答";
            // 
            // AnswerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AnswerForm";
            this.ShowInTaskbar = false;
            this.Text = "回答窗口";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AnswerForm_Load);
            this.MouseEnter += new System.EventHandler(this.AnswerForm_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.AnswerForm_MouseLeave);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button copyButton;
        private TextBox poweredByBox;
        private TextBox answerBox;
        private Button saveAsButton;
        private Button closeThisWindowsButton;
    }
}
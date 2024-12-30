namespace 橘子桌面宠物
{
    partial class SettingsForm1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.homePage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelHomePage = new System.Windows.Forms.TableLayoutPanel();
            this.animationPage = new System.Windows.Forms.TabPage();
            this.aboutPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelInAboutPage = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.homePage.SuspendLayout();
            this.aboutPage.SuspendLayout();
            this.tableLayoutPanelInAboutPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.homePage);
            this.tabControl1.Controls.Add(this.animationPage);
            this.tabControl1.Controls.Add(this.aboutPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // homePage
            // 
            this.homePage.Controls.Add(this.tableLayoutPanelHomePage);
            this.homePage.Location = new System.Drawing.Point(4, 25);
            this.homePage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.homePage.Name = "homePage";
            this.homePage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.homePage.Size = new System.Drawing.Size(792, 421);
            this.homePage.TabIndex = 0;
            this.homePage.Text = "主页";
            this.homePage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelHomePage
            // 
            this.tableLayoutPanelHomePage.ColumnCount = 1;
            this.tableLayoutPanelHomePage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelHomePage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelHomePage.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanelHomePage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanelHomePage.Name = "tableLayoutPanelHomePage";
            this.tableLayoutPanelHomePage.RowCount = 4;
            this.tableLayoutPanelHomePage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.80203F));
            this.tableLayoutPanelHomePage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanelHomePage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanelHomePage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanelHomePage.Size = new System.Drawing.Size(786, 417);
            this.tableLayoutPanelHomePage.TabIndex = 0;
            // 
            // animationPage
            // 
            this.animationPage.Location = new System.Drawing.Point(4, 25);
            this.animationPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.animationPage.Name = "animationPage";
            this.animationPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.animationPage.Size = new System.Drawing.Size(792, 421);
            this.animationPage.TabIndex = 1;
            this.animationPage.Text = "动画";
            this.animationPage.UseVisualStyleBackColor = true;
            // 
            // aboutPage
            // 
            this.aboutPage.Controls.Add(this.tableLayoutPanelInAboutPage);
            this.aboutPage.Location = new System.Drawing.Point(4, 25);
            this.aboutPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aboutPage.Name = "aboutPage";
            this.aboutPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aboutPage.Size = new System.Drawing.Size(792, 421);
            this.aboutPage.TabIndex = 2;
            this.aboutPage.Text = "关于";
            this.aboutPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelInAboutPage
            // 
            this.tableLayoutPanelInAboutPage.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanelInAboutPage.ColumnCount = 1;
            this.tableLayoutPanelInAboutPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.56489F));
            this.tableLayoutPanelInAboutPage.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelInAboutPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelInAboutPage.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanelInAboutPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanelInAboutPage.Name = "tableLayoutPanelInAboutPage";
            this.tableLayoutPanelInAboutPage.RowCount = 2;
            this.tableLayoutPanelInAboutPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelInAboutPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 309F));
            this.tableLayoutPanelInAboutPage.Size = new System.Drawing.Size(786, 417);
            this.tableLayoutPanelInAboutPage.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(780, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "这是一段文字";
            this.label1.DoubleClick += new System.EventHandler(this.label1_DoubleClick);
            // 
            // SettingsForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SettingsForm1";
            this.Text = "SettingsForm1";
            this.tabControl1.ResumeLayout(false);
            this.homePage.ResumeLayout(false);
            this.aboutPage.ResumeLayout(false);
            this.tableLayoutPanelInAboutPage.ResumeLayout(false);
            this.tableLayoutPanelInAboutPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage homePage;
        private TabPage animationPage;
        private TableLayoutPanel tableLayoutPanelHomePage;
        private TabPage aboutPage;
        private TableLayoutPanel tableLayoutPanelInAboutPage;
        private Label label1;
    }
}
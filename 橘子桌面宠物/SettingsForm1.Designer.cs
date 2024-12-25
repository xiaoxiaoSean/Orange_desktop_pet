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
            this.animationPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelHp = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.homePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.homePage);
            this.tabControl1.Controls.Add(this.animationPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // homePage
            // 
            this.homePage.Controls.Add(this.tableLayoutPanelHp);
            this.homePage.Location = new System.Drawing.Point(4, 25);
            this.homePage.Name = "homePage";
            this.homePage.Padding = new System.Windows.Forms.Padding(3);
            this.homePage.Size = new System.Drawing.Size(792, 421);
            this.homePage.TabIndex = 0;
            this.homePage.Text = "主页";
            this.homePage.UseVisualStyleBackColor = true;
            // 
            // animationPage
            // 
            this.animationPage.Location = new System.Drawing.Point(4, 25);
            this.animationPage.Name = "animationPage";
            this.animationPage.Padding = new System.Windows.Forms.Padding(3);
            this.animationPage.Size = new System.Drawing.Size(792, 421);
            this.animationPage.TabIndex = 1;
            this.animationPage.Text = "动画";
            this.animationPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelHp
            // 
            this.tableLayoutPanelHp.ColumnCount = 1;
            this.tableLayoutPanelHp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelHp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelHp.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelHp.Name = "tableLayoutPanelHp";
            this.tableLayoutPanelHp.RowCount = 4;
            this.tableLayoutPanelHp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.80203F));
            this.tableLayoutPanelHp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanelHp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanelHp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanelHp.Size = new System.Drawing.Size(786, 415);
            this.tableLayoutPanelHp.TabIndex = 0;
            // 
            // SettingsForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "SettingsForm1";
            this.Text = "SettingsForm1";
            this.tabControl1.ResumeLayout(false);
            this.homePage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage homePage;
        private TabPage animationPage;
        private TableLayoutPanel tableLayoutPanelHp;
    }
}
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.橘子桌面宠物ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.监视器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cPUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.使用率ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.速度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.随机存取存储器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gPUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.mainPictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.橘子桌面宠物ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.监视器ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 100);
            this.contextMenuStrip1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.contextMenuStrip1_MouseClick);
            // 
            // 橘子桌面宠物ToolStripMenuItem
            // 
            this.橘子桌面宠物ToolStripMenuItem.Name = "橘子桌面宠物ToolStripMenuItem";
            this.橘子桌面宠物ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.橘子桌面宠物ToolStripMenuItem.Text = "橘子桌面宠物";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.设置ToolStripMenuItem.Text = "设置";
            this.设置ToolStripMenuItem.Click += new System.EventHandler(this.设置ToolStripMenuItem_Click);
            // 
            // 监视器ToolStripMenuItem
            // 
            this.监视器ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cPUToolStripMenuItem,
            this.随机存取存储器ToolStripMenuItem,
            this.gPUToolStripMenuItem});
            this.监视器ToolStripMenuItem.Name = "监视器ToolStripMenuItem";
            this.监视器ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.监视器ToolStripMenuItem.Text = "监视器";
            // 
            // cPUToolStripMenuItem
            // 
            this.cPUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.使用率ToolStripMenuItem,
            this.速度ToolStripMenuItem});
            this.cPUToolStripMenuItem.Name = "cPUToolStripMenuItem";
            this.cPUToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.cPUToolStripMenuItem.Text = "CPU";
            // 
            // 使用率ToolStripMenuItem
            // 
            this.使用率ToolStripMenuItem.Name = "使用率ToolStripMenuItem";
            this.使用率ToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.使用率ToolStripMenuItem.Text = "使用率";
            this.使用率ToolStripMenuItem.Click += new System.EventHandler(this.使用率ToolStripMenuItem_Click);
            // 
            // 速度ToolStripMenuItem
            // 
            this.速度ToolStripMenuItem.Name = "速度ToolStripMenuItem";
            this.速度ToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.速度ToolStripMenuItem.Text = "速度";
            this.速度ToolStripMenuItem.Click += new System.EventHandler(this.速度ToolStripMenuItem_Click);
            // 
            // 随机存取存储器ToolStripMenuItem
            // 
            this.随机存取存储器ToolStripMenuItem.Name = "随机存取存储器ToolStripMenuItem";
            this.随机存取存储器ToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.随机存取存储器ToolStripMenuItem.Text = "随机存取存储器(RAM)";
            this.随机存取存储器ToolStripMenuItem.Click += new System.EventHandler(this.随机存取存储器ToolStripMenuItem_Click);
            // 
            // gPUToolStripMenuItem
            // 
            this.gPUToolStripMenuItem.Name = "gPUToolStripMenuItem";
            this.gPUToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.gPUToolStripMenuItem.Text = "GPU";
            this.gPUToolStripMenuItem.Click += new System.EventHandler(this.gPUToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "橘子桌面宠物";
            this.notifyIcon1.Visible = true;
            // 
            // mainPictureBox1
            // 
            this.mainPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.mainPictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPictureBox1.Name = "mainPictureBox1";
            this.mainPictureBox1.Size = new System.Drawing.Size(196, 131);
            this.mainPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainPictureBox1.TabIndex = 0;
            this.mainPictureBox1.TabStop = false;
            this.mainPictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.mainPictureBox1_DragEnter);
            this.mainPictureBox1.DoubleClick += new System.EventHandler(this.mainPictureBox1_DoubleClick);
            this.mainPictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainPictureBox1_MouseClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 131);
            this.Controls.Add(this.mainPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPictureBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem 橘子桌面宠物ToolStripMenuItem;
        private ToolStripMenuItem 设置ToolStripMenuItem;
        private ToolStripMenuItem 退出ToolStripMenuItem;
        private NotifyIcon notifyIcon1;
        private ToolStripMenuItem 监视器ToolStripMenuItem;
        private ToolStripMenuItem cPUToolStripMenuItem;
        private ToolStripMenuItem 随机存取存储器ToolStripMenuItem;
        private ToolStripMenuItem gPUToolStripMenuItem;
        private ToolStripMenuItem 使用率ToolStripMenuItem;
        private ToolStripMenuItem 速度ToolStripMenuItem;
    }
}
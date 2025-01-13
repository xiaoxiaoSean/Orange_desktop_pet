namespace 橘子桌面宠物
{
    partial class RAMmonitor
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cPU监视器橘子桌面宠物ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.DoubleClick += new System.EventHandler(this.label1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cPU监视器橘子桌面宠物ToolStripMenuItem,
            this.关闭ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(250, 52);
            // 
            // cPU监视器橘子桌面宠物ToolStripMenuItem
            // 
            this.cPU监视器橘子桌面宠物ToolStripMenuItem.Name = "cPU监视器橘子桌面宠物ToolStripMenuItem";
            this.cPU监视器橘子桌面宠物ToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.cPU监视器橘子桌面宠物ToolStripMenuItem.Text = "CPU监视器-橘子桌面宠物";
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.关闭ToolStripMenuItem.Text = "关闭";
            // 
            // RAMmonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 323);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RAMmonitor";
            this.Text = "CPUmonitor";
            this.Load += new System.EventHandler(this.RAMmonitor_Load);
            this.DoubleClick += new System.EventHandler(this.RAMmonitor_DoubleClick);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RAMmonitor_MouseClick);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem cPU监视器橘子桌面宠物ToolStripMenuItem;
        private ToolStripMenuItem 关闭ToolStripMenuItem;
    }
}
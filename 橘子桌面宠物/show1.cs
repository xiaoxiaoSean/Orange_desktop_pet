using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 橘子桌面宠物
{
    public partial class show1 : Form
    {
        public show1()
        {
            InitializeComponent();
        }

        private async void show1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            string? r=null;
            await Task.Delay(100);
            try
            {
                r = File.ReadAllText(Application.StartupPath + "\\data\\cache\\show1.txt");
            }
            catch (Exception ex)
            {
                showLabel1.Text = "发生错误了喵"+ex;
            }
            if (r?.Contains("能量值")==true)
            {
                do
                {
                    try
                    {
                        r = File.ReadAllText(Application.StartupPath + "\\data\\cache\\show1.txt");
                        showLabel1.Text = r;
                    }
                    catch (Exception ex)
                    {
                        showLabel1.Text = "发生错误了喵" + ex;
                    }
                    this.Size = new Size(showLabel1.Size.Width, showLabel1.Size.Height);
                    this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Size.Width- Screen.PrimaryScreen.Bounds.Width/20, Screen.PrimaryScreen.Bounds.Height * 74 / 100 - Screen.PrimaryScreen.Bounds.Height / 5 - this.Size.Height);
                    await Task.Delay(10);
                } while (true);
            }
            else
            {
                try
                {
                    r = File.ReadAllText(Application.StartupPath + "\\data\\cache\\show1.txt");
                    showLabel1.Text = r;
                }
                catch (Exception ex)
                {
                    showLabel1.Text = "发生错误了喵" + ex;
                }
                this.Size = new Size(showLabel1.Size.Width, showLabel1.Size.Height);
                this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Size.Width, Screen.PrimaryScreen.Bounds.Height * 74 / 100 - Screen.PrimaryScreen.Bounds.Height / 5 - this.Size.Height);
            }        
            await Task.Delay(2000);
            this.Close();
            this.Dispose();
            this.Hide();
        }
    }
}

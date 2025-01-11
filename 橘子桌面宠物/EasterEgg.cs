using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 橘子桌面宠物
{
    public partial class EasterEgg : Form
    {
        public EasterEgg()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void EasterEgg_Load(object sender, EventArgs e)
        {
            //TransparencyKey = BackColor;
            toolTip1.SetToolTip(pictureBox1, "双击以退出");
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.Opacity = 0.00;
            //pictureBox1.Load(Application.StartupPath + "\\image\\DONTDELETETHISFILE.dontdeletethisfile");
            for (double i = 0.00; i < 100.00; i += 0.01)
            {
                this.Opacity = i;
                await Task.Delay(10);
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EasterEgg_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

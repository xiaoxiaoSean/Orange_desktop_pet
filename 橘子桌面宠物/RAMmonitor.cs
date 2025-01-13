using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreHardwareMonitor.Hardware;
namespace 橘子桌面宠物
{
    public partial class RAMmonitor : Form
    {
        public RAMmonitor()
        {
            InitializeComponent();
        }
        Computer computer = new Computer()
        {
            IsCpuEnabled = true,
            IsGpuEnabled = true,
            IsMemoryEnabled = true,
            IsMotherboardEnabled = true,
            IsControllerEnabled = true,
            IsNetworkEnabled = true,
            IsStorageEnabled = true,
            IsBatteryEnabled = true,
        };
        bool isEditing = false;
        public float GetRAMUsage()
        {
            foreach (IHardware hardware in computer.Hardware)
            {
                if (hardware.HardwareType == HardwareType.Memory)
                {
                    foreach (ISensor sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Load)
                        {
                            return sensor.Value ?? 0;
                        }
                    }
                }
            }
            return 0;
        }
        private async void RAMmonitor_Load(object sender, EventArgs e)
        {
            this.TopMost= true;
            contextMenuStrip1.Visible = false;
            this.ShowInTaskbar = false;
            label1.Text = "CPU监视器正在准备中，请稍候";
            computer.Open();
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width / 6, Screen.PrimaryScreen.Bounds.Height / 30);
            do
            {
                if (!isEditing)
                {
                    label1.Text = "CPU占用率：" + GetRAMUsage().ToString() + "%";
                    computer.Reset();
                    await Task.Delay(1000);
                }
                else
                {
                    Point mp = MousePosition;
                    mp.X=mp.X-this.Size.Width/2;
                    mp.Y=mp.Y-this.Size.Height/2;
                    this.Location = mp;
                    label1.Text ="双击可以退出位置编辑模式...";
                    await Task.Delay(1);
                }
            } while (true);

        }

        private void RAMmonitor_DoubleClick(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                isEditing = true;
            }
            else
            {
                isEditing = false;
            }
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                isEditing = true;
            }
            else
            {
                isEditing = false;
            }
        }

        private void RAMmonitor_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button is MouseButtons.Right)
            {
                contextMenuStrip1.Show(this, Point.Empty);
            }
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.Hide();
        }
    }
}

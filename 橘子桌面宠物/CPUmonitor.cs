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
    public partial class CPUmonitor : Form
    {
        public CPUmonitor()
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
        public float GetCpuUsage()
        {
            foreach (IHardware hardware in computer.Hardware)
            {
                if (hardware.HardwareType == HardwareType.Cpu)
                {
                    foreach (ISensor sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Load && sensor.Name == "CPU Total")
                        {
                            return sensor.Value??0;
                        }
                    }
                }
            }
            return 0;
        }
        private async void CPUmonitor_Load(object sender, EventArgs e)
        {
            this.TopMost= true;
            this.ShowInTaskbar = false;
            label1.Text = "CPU监视器正在准备中，请稍候";
            computer.Open();
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width / 6, Screen.PrimaryScreen.Bounds.Height / 30);
            do
            {
                if (!isEditing)
                {
                    label1.Text = "CPU占用率：" + GetCpuUsage().ToString() + "%";
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

        private void CPUmonitor_DoubleClick(object sender, EventArgs e)
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
    }
}

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
               label1.Text = "CPU占用率：" + GetCpuUsage().ToString() + "%";
                computer.Reset();
                await Task.Delay(1000);
            } while (true);

        }

        private void CPUmonitor_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CPUmonitor_MouseEnter(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void CPUmonitor_MouseLeave(object sender, EventArgs e)
        {
            this.FormBorderStyle= FormBorderStyle.None;
        }
    }
}

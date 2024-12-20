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
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using Newtonsoft.Json.Linq;
using HtmlAgilityPack;
using System.Net;
using System.Net.Sockets;
using System.Speech.Synthesis;
using ppt=Microsoft.Office.Interop.PowerPoint;
namespace 橘子桌面宠物
{   
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            start();
        }
        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern int mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        const int MOUSEEVENTF_MOVE = 0x0001;
        const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        const int MOUSEEVENTF_LEFTUP = 0x0004;
        const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        const int MOUSEEVENTF_RIGHTUP = 0x0010;
        const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        const int MOUSEEVENTF_MIDDLEUP = 0x0040;
        const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        //bool isMouseLocation = false;
        Point mouseLocation = new Point();
        Point mousePoint1 = new Point();
        int power = 100;
        bool isThinking = false;
        bool isThinkingSmall = false;
        int catchMousePicture = 0;
        int pictureStatus = 0;
        async void start()
        {
            await Task.Run(() => updateMouseLocation());
            //await Task.Run(() => Consume_power());
        }
        void SpeakVoice(string speakText)
        {
            synthesizer.Speak(speakText);
            return;
        }
        AskForm1 showAskForm1 = new AskForm1();
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        bool isOrigin = true;
        async void isThinkingOrNot()
        {
            do
            {
                try
                {
                    if (File.ReadAllText(Application.StartupPath + "\\data\\cache\\isThinking.txt") == "1")
                    {
                        isThinking = true;
                        // synthesizer.Speak("Tom喵正在思考中");
                        if (isOrigin)
                        {
                            this.Location=new Point(this.Location.X, this.Location.Y- Screen.PrimaryScreen.Bounds.Height/ 200);
                            isOrigin = false;
                        }
                        else
                        {
                            this.Location = new Point(this.Location.X, this.Location.Y+ Screen.PrimaryScreen.Bounds.Height / 200);
                            isOrigin = true;
                        }
                    }
                    else
                    {
                        isThinking = false;
                        if (!isOrigin)
                        {
                           this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Size.Width, Screen.PrimaryScreen.Bounds.Height * 74 / 100);
                            isOrigin = true;
                        }
                    }
                }
                catch (Exception)
                {
                    
                }
                await Task.Delay(10);
            } while (true);
        }
        public void SendMessage(string message)
        {
            try
            {
                TcpClient client = new TcpClient("server", int.Parse("2053"));
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);
                stream.Close();
                client.Close();
            }
            catch (Exception)
            {
            }
        }

        /*async void Consume_power()
        {
            File.WriteAllText(Application.StartupPath + "\\data\\cache\\show1.txt", "能量值" + power + "%");
            show1 show1_show = new show1();
            show1_show.Show();
            do
            {
                File.WriteAllText(Application.StartupPath + "\\data\\cache\\show1.txt", "能量值" + power + "%");
                if (power != 0)
                {
                    power--;
                    await Task.Delay(1000);
                }
                else
                {
                    string[] foods = Directory.GetFileSystemEntries(Application.StartupPath + "\\foods");
                    try
                    {
                        if (foods[1] == null)
                        {
                            MessageBox.Show("此猫已饿死");
                            this.Close();
                            this.Dispose();
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show("此猫已饿死");
                        this.Close();
                        this.Dispose();
                    }
                    foreach (string food in foods)
                    {
                        if (food==null)
                        {
                            MessageBox.Show("此猫已饿死");
                            this.Close();
                            this.Dispose();
                        }
                        await Task.Delay(100);
                        power++;
                        try
                        {
                            File.Delete(food);
                        }
                        catch (UnauthorizedAccessException)
                        {
                            MessageBox.Show("你已对这只猫下毒(文件夹)，此猫已死");
                            this.Close();
                            this.Dispose();
                        }
                    }
                }
            } while (true);
        }*/
        async void MoveTo(Point toPoint)
        {
            if (this.Location.X > toPoint.X)
            {
                for (int i = this.Location.X; i > toPoint.X; i--)
                {
                    this.Location = new Point(i, this.Location.Y);
                }
            }
            if (this.Location.X < toPoint.X)
            {
                for (int i = this.Location.X; i < toPoint.X; i++)
                {
                    this.Location = new Point(i, this.Location.Y);
                }
            }
            if (this.Location.Y > toPoint.Y)
            {
                for (int i = this.Location.Y; i > toPoint.Y; i--)
                {
                    this.Location = new Point(this.Location.X, i);
                }
            }
            if (this.Location.Y < toPoint.Y)
            {
                for (int i = this.Location.Y; i < toPoint.Y; i++)
                {
                    this.Location = new Point(this.Location.X, i);
                }
            }
            await Task.Delay(10);
        }
        private async void Main_Load(object sender, EventArgs e)
        {
            synthesizer.SetOutputToDefaultAudioDevice();
            //await Task.Run(() => SpeakVoice("我是Tom喵"));
            this.TopMost = true;
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width/4, Screen.PrimaryScreen.Bounds.Height/4);
            this.Location=new Point(Screen.PrimaryScreen.Bounds.Width-this.Size.Width,Screen.PrimaryScreen.Bounds.Height*74/100);
            mainPictureBox1.Load(Application.StartupPath + "\\image\\start1.png");
            this.TransparencyKey = this.BackColor;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            mainPictureBox1.BackColor = TransparencyKey;
            await Task.Delay(100);
            MoveTo(new Point(Screen.PrimaryScreen.Bounds.Width - this.Size.Width, Screen.PrimaryScreen.Bounds.Height * 74 / 100-Screen.PrimaryScreen.Bounds.Height * 20 / 100));
            MoveTo(new Point(Screen.PrimaryScreen.Bounds.Width - this.Size.Width, Screen.PrimaryScreen.Bounds.Height * 74 / 100 ));
            MoveTo(new Point(Screen.PrimaryScreen.Bounds.Width - this.Size.Width, Screen.PrimaryScreen.Bounds.Height * 74 / 100 - Screen.PrimaryScreen.Bounds.Height * 10 / 100));
            MoveTo(new Point(Screen.PrimaryScreen.Bounds.Width - this.Size.Width, Screen.PrimaryScreen.Bounds.Height * 74 / 100));
            MoveTo(new Point(Screen.PrimaryScreen.Bounds.Width - this.Size.Width, Screen.PrimaryScreen.Bounds.Height * 74 / 100 - Screen.PrimaryScreen.Bounds.Height * 5 / 100));
            MoveTo(new Point(Screen.PrimaryScreen.Bounds.Width - this.Size.Width, Screen.PrimaryScreen.Bounds.Height * 74 / 100));
            pictureStatus = 0;
            await Task.Run(() => isThinkingOrNot());
            /*try
            {
                await Task.Run(() => SendMessage("[INFO] TIME=" + DateTime.Now + ",screen_width=" + Screen.PrimaryScreen.Bounds.Width + ",screen_height=" + Screen.PrimaryScreen.Bounds.Height + ",System_infomation=" + System.Runtime.InteropServices.RuntimeInformation.OSDescription));//这将会上报信息，为了统计用户数量
            }
            catch (Exception)
            {

            }*/
            mainPictureBox1.Load(Application.StartupPath + "\\image\\normal1.png");
            //初始化txt
            File.WriteAllText(Application.StartupPath + "\\data\\cache\\isThinking.txt", "0");
            File.WriteAllText(Application.StartupPath + "\\data\\cache\\isAskFormShow.txt", "0");
            do
            {
                if (File.ReadAllText(Application.StartupPath + "\\data\\cache\\isAskFormShow.txt")=="0")
                {
                    /* do
                    {
                        switch (catchMousePicture)
                        {
                            default:
                                break;
                            case 1:
                                mainPictureBox1.Load(Application.StartupPath + "\\image\\left.png");
                                break;
                            case 2:
                                mainPictureBox1.Load(Application.StartupPath + "\\image\\right.png");
                                break;
                            case 3:
                                mainPictureBox1.Load(Application.StartupPath + "\\image\\up.png");
                                break;
                            case 4:
                                mainPictureBox1.Load(Application.StartupPath + "\\image\\down.png");
                                break;
                        }
                        await Task.Delay(10);
                    } while (this.Location == mouseLocation);*/
                    this.Size = new Size(Screen.PrimaryScreen.Bounds.Width / 4, Screen.PrimaryScreen.Bounds.Height / 4);
                }
                else
                {
                    if (MousePosition.X >= Screen.PrimaryScreen.Bounds.Width * 7 / 10 && MousePosition.Y >= Screen.PrimaryScreen.Bounds.Height * 7 / 10)
                    {
                        //MoveTo(MousePosition);
                    }
                    else
                    {
                        MoveTo(new Point(Screen.PrimaryScreen.Bounds.Width - this.Size.Width, Screen.PrimaryScreen.Bounds.Height * 74 / 100));
                    }
                    await Task.Delay(10);
                    if (isThinking == true)
                    {
                        if (isThinkingSmall == true)
                        {
                            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width / 9, Screen.PrimaryScreen.Bounds.Height / 9);
                            isThinkingSmall = false;
                            await Task.Delay(500);
                        }
                        else
                        {
                            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width / 7, Screen.PrimaryScreen.Bounds.Height / 7);
                            isThinkingSmall = true;
                            await Task.Delay(500);
                        }
                    }
                    else
                    {
                        this.Size = new Size(Screen.PrimaryScreen.Bounds.Width / 7, Screen.PrimaryScreen.Bounds.Height / 7);
                    }
                }
                await Task.Delay(10);
            } while (true);
        }
        async void catch_mouse()
        {
            for (int i = 0; i < 400; i++)
            {
                mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, mousePoint1.X * 65536 / Screen.PrimaryScreen.WorkingArea.Width, mousePoint1.Y * 65536 / Screen.PrimaryScreen.WorkingArea.Height, 0, 0);
                await Task.Delay(10);
            }
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width / 5, Screen.PrimaryScreen.Bounds.Height / 5);
            mainPictureBox1.Load(Application.StartupPath + "\\image\\normal1.png");
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Size.Width, Screen.PrimaryScreen.Bounds.Height * 74 / 100);
            File.WriteAllText(Application.StartupPath + "\\data\\cache\\show1.txt", "算了算了，我也不想做个病毒程序，这次就放你一马，下次不可以点我了啊！");
            show1 show1_show = new show1();
            show1_show.Show();
        }
        async void AutoSetLocation()
        {
           // await Task.Run(() => SpeakVoice("好好好，敢抓我是吧，看我抢你鼠标"));
            do
            {
                if (power==0)
                {
                    
                }
                else
                {
                    if (this.Location.X > mouseLocation.X)
                    {
                        for (int i = this.Location.X; i > mouseLocation.X; i--)
                        {
                            if (pictureStatus!=1)
                            {
                                mainPictureBox1.Load(Application.StartupPath + "\\image\\left.png");
                                pictureStatus = 1;
                            }
                            this.Location = new Point(i, this.Location.Y);
                            //mainPictureBox1.Load(Application.StartupPath + "\\image\\left.png");
                            //catchMousePicture = 1;
                        }
                    }
                    if (this.Location.X < mouseLocation.X)
                    {
                        for (int i = this.Location.X; i < mouseLocation.X; i++)
                        {
                            if (pictureStatus != 2)
                            {
                                mainPictureBox1.Load(Application.StartupPath + "\\image\\right.png");
                                pictureStatus = 2;
                            }
                            this.Location = new Point(i, this.Location.Y);
                            //mainPictureBox1.Load(Application.StartupPath + "\\image\\right.png");
                            //catchMousePicture = 2;
                        }
                    }
                    if (this.Location.Y > mouseLocation.Y)
                    {
                        for (int i = this.Location.Y; i > mouseLocation.Y; i--)
                        {
                            if (pictureStatus != 3)
                            {
                                mainPictureBox1.Load(Application.StartupPath + "\\image\\up.png");
                                pictureStatus = 3;
                            }
                            this.Location = new Point(this.Location.X, i);
                            //mainPictureBox1.Load(Application.StartupPath + "\\image\\up.png");
                            //catchMousePicture = 3;
                        }
                    }
                    if (this.Location.Y < mouseLocation.Y)
                    {
                        for (int i = this.Location.Y; i < mouseLocation.Y; i++)
                        {
                            if (pictureStatus != 4)
                            {
                                mainPictureBox1.Load(Application.StartupPath + "\\image\\down.png");
                                pictureStatus = 4;
                            }
                            this.Location = new Point(this.Location.X, i);
                           // mainPictureBox1.Load(Application.StartupPath + "\\image\\down.png");
                            //catchMousePicture =4;
                        }
                    }
                    if (this.Location == mouseLocation)
                    {
                        File.WriteAllText(Application.StartupPath + "\\data\\cache\\show1.txt", "抢到啦！");
                        mousePoint1 = MousePosition;
                        show1 show1_show = new show1();
                        show1_show.Show();
                        pictureStatus = 0;
                        catch_mouse();
                        break;
                    }
                }
                this.TopMost = true;
            } while (true);
        }
        void updateMouseLocation()
        {
            do
            {
                mouseLocation = MousePosition;
                mouseLocation.X += Screen.PrimaryScreen.Bounds.Width / 200;
                mouseLocation.Y += Screen.PrimaryScreen.Bounds.Height / 200;
            } while (true);
        }

        private async void mainPictureBox1_DoubleClick(object sender, EventArgs e)
        {
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width / 7, Screen.PrimaryScreen.Bounds.Height / 7);
            mainPictureBox1.Load(Application.StartupPath + "\\image\\fall_down.png");
            await Task.Delay(1000);
            //mainPictureBox1.Load(Application.StartupPath + "\\image\\miao1.jpg");
            await Task.Delay(100);
           // await Task.Run(() => SpeakVoice("气死我了，我抢你鼠标！"));
            File.WriteAllText(Application.StartupPath + "\\data\\cache\\show1.txt", "气死我了，我抢你鼠标！");
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width / 8, Screen.PrimaryScreen.Bounds.Height / 8);
            show1 show1_show = new show1();
            show1_show.Show();
            await Task.Delay(1000);
            pictureStatus = 0;
            this.Invoke((EventHandler)delegate
            {
                AutoSetLocation();
            });                    
        }

        private void mainPictureBox1_Click(object sender, EventArgs e)
        {
            if (File.ReadAllText(Application.StartupPath + "\\data\\cache\\isAskFormShow.txt")=="1")
            {
                showAskForm1.Hide();
                File.WriteAllText(Application.StartupPath + "\\data\\cache\\isAskFormShow.txt", "0");
            }
            else
            {
                showAskForm1.Show();
                File.WriteAllText(Application.StartupPath + "\\data\\cache\\isAskFormShow.txt", "1");
            }
           
        }
    }
}

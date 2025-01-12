using System.Reflection;
using System.Runtime.InteropServices;
using System.Speech.Synthesis;

namespace 橘子桌面宠物;

public partial class Main : Form
{
    private const int MOUSEEVENTF_MOVE = 0b1;
    // private const int MOUSEEVENTF_LEFTDOWN = 0b10;
    // private const int MOUSEEVENTF_LEFTUP = 0b100;
    // private const int MOUSEEVENTF_RIGHTDOWN = 0b1000;
    // private const int MOUSEEVENTF_RIGHTUP = 0b10000;
    // private const int MOUSEEVENTF_MIDDLEDOWN = 0b100000;
    // private const int MOUSEEVENTF_MIDDLEUP = 0b1000000;
    private const int MOUSEEVENTF_ABSOLUTE = 0b1000000000000000;

    private readonly AskForm1 showAskForm1 = new();
    private readonly SpeechSynthesizer synthesizer = new();
    // private int catchMousePicture;
    // private bool isMouseLocation;
    private bool isOrigin = true;
    private bool isThinking;
    private bool isThinkingSmall;
    private int mainLoadPleaseDelayDuringMoving;
    private Point mainLoadThisIsPoint = Point.Empty;
    private Point mouseLocation = Point.Empty;
    private Point mousePoint1 = Point.Empty;
    private bool nearMouse;
    private int pictureStatus;
    private bool pleaseMoveMainLoad;
    private int power = 100;
public Main()
    {
        InitializeComponent();
        start();
    }

    // private void SpeakVoice(string speakText)
    // {
    //     synthesizer.Speak(speakText);
    // }

    [DllImport("user32")]
    private static extern int mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

    private void start()
    {
        Task.Factory.StartNew(updateMouseLocation, TaskCreationOptions.LongRunning);
        // Task.Factory.StartNew(Consume_power, TaskCreationOptions.LongRunning);
    }

    private void isThinkingOrNot()
    {
        do
        {
            try
            {
                if (File.ReadAllText(Application.StartupPath + "\\data\\cache\\isThinking.txt") is "1")
                {
                    isThinking = true;
                    // SpeakVoice("Tom喵正在思考中");
                    if (isOrigin)
                    {
                        MoveTo(new Point(Location.X, Location.Y - (Screen.PrimaryScreen.Bounds.Height / 200)));
                        isOrigin = false;
                    }
                    else
                    {
                        MoveTo(new Point(Location.X, Location.Y + (Screen.PrimaryScreen.Bounds.Height / 200)));
                        isOrigin = true;
                    }
                }
                else
                {
                    isThinking = false;
                    if (!isOrigin)
                    {
                        MoveTo(new Point(Screen.PrimaryScreen.Bounds.Width - Size.Width, Screen.PrimaryScreen.Bounds.Height * 74 / 100));
                        isOrigin = true;
                    }
                }
            }
            catch (Exception)
            {
                continue;
            }

            Thread.Sleep(10);
        } while (true);
    }

    // public async Task SendMessage(string message)
    // {
    //     try
    //     {
    //         using TcpClient client = new("server", int.Parse("2053"));
    //         byte[] data = Encoding.ASCII.GetBytes(message);
    //         using NetworkStream stream = client.GetStream();
    //         await stream.WriteAsync(data, 0, data.Length);
    //     }
    //     catch (Exception)
    //     {
    //     }
    // }

    // private void Consume_power()
    // {
    //     File.WriteAllText(Application.StartupPath + "\\data\\cache\\show1.txt", "能量值" + power + "%");
    //     show1 show1_show = new();
    //     show1_show.Show();
    //     do
    //     {
    //         File.WriteAllText(Application.StartupPath + "\\data\\cache\\show1.txt", "能量值" + power + "%");
    //         if (power is not 0)
    //         {
    //             power--;
    //             Thread.Sleep(1000);
    //         }
    //         else
    //         {
    //             string?[] foods = Directory.GetFileSystemEntries(Application.StartupPath + "\\foods");
    //             try
    //             {
    //                 if (foods[1] is null)
    //                 {
    //                     MessageBox.Show("此猫已饿死");
    //                     Close();
    //                     Dispose();
    //                 }
    //             }
    //             catch (IndexOutOfRangeException)
    //             {
    //                 MessageBox.Show("此猫已饿死");
    //                 Close();
    //                 Dispose();
    //             }

    //             foreach (string? food in foods)
    //             {
    //                 if (food is null)
    //                 {
    //                     MessageBox.Show("此猫已饿死");
    //                     Close();
    //                     Dispose();
    //                 }

    //                 Thread.Sleep(100);
    //                 power++;
    //                 try
    //                 {
    //                     File.Delete(food);
    //                 }
    //                 catch (UnauthorizedAccessException)
    //                 {
    //                     MessageBox.Show("你已对这只猫下毒(文件夹)，此猫已死");
    //                     Close();
    //                     Dispose();
    //                 }
    //             }
    //         }
    //     } while (true);
    // }

    private async Task EditSize(Size toSize)
    {
        int times = 0;
        const int pfreq = 1;
        const int wfreq = 20;
        if (Size.Width > toSize.Width)
        {
            for (int i = Size.Width; i > toSize.Width; i -= wfreq)
            {
                Size = Size with { Width = i };
                if (times < pfreq)
                {
                    times++;
                }
                else
                {
                    mainPictureBox1.Refresh();
                    times = 0;
                }

                // await Task.Delay(1);
            }
        }

        if (Size.Width < toSize.Width)
        {
            for (int i = Size.Width; i < toSize.Width; i += wfreq)
            {
                Size = Size with { Width = i };
                if (times < pfreq)
                {
                    times++;
                }
                else
                {
                    mainPictureBox1.Refresh();
                    times = 0;
                }

                // await Task.Delay(1);
            }
        }

        if (Size.Height > toSize.Height)
        {
            for (int i = Size.Height; i > toSize.Height; i -= wfreq)
            {
                Size = Size with { Height = i };
                if (times < pfreq)
                {
                    times++;
                }
                else
                {
                    mainPictureBox1.Refresh();
                    times = 0;
                }

                // await Task.Delay(1);
            }
        }

        if (Size.Height < toSize.Height)
        {
            for (int i = Size.Height; i < toSize.Height; i += wfreq)
            {
                Size = Size with { Height = i };
                if (times < pfreq)
                {
                    times++;
                }
                else
                {
                    mainPictureBox1.Refresh();
                    times = 0;
                }

                // await Task.Delay(1);
            }
        }

        await Task.Delay(10);
    }

    private async Task MoveToWithDelay(Point toPoint, int delayTime)
    {
        if (Location.X > toPoint.X)
        {
            for (int i = Location.X; i > toPoint.X; i--)
            {
                Location = Location with { X = i };
                await Task.Delay(delayTime);
            }
        }

        if (Location.X < toPoint.X)
        {
            for (int i = Location.X; i < toPoint.X; i++)
            {
                Location = Location with { X = i };
                await Task.Delay(delayTime);
            }
        }

        if (Location.Y > toPoint.Y)
        {
            for (int i = Location.Y; i > toPoint.Y; i--)
            {
                Location = Location with { Y = i };
                await Task.Delay(delayTime);
            }
        }

        if (Location.Y < toPoint.Y)
        {
            for (int i = Location.Y; i < toPoint.Y; i++)
            {
                Location = Location with { Y = i };
                await Task.Delay(delayTime);
            }
        }

        await Task.Delay(10);
    }

    private async Task MoveTo(Point toPoint)
    {
        if (Location.X > toPoint.X)
        {
            for (int i = Location.X; i > toPoint.X; i--)
            {
                Location = Location with { X = i };
                // await Task.Delay(1);
            }
        }

        if (Location.X < toPoint.X)
        {
            for (int i = Location.X; i < toPoint.X; i++)
            {
                Location = Location with { X = i };
                // await Task.Delay(1);
            }
        }

        if (Location.Y > toPoint.Y)
        {
            for (int i = Location.Y; i > toPoint.Y; i--)
            {
                Location = Location with { Y = i };
                // await Task.Delay(1);
            }
        }

        if (Location.Y < toPoint.Y)
        {
            for (int i = Location.Y; i < toPoint.Y; i++)
            {
                Location = Location with { Y = i };
                // await Task.Delay(1);
            }
        }

        await Task.Delay(10);
    }

    // private void MouseAnim()
    // {
    //     do
    //     {
    //         Point mp = mouseLocation;
    //         // MessageBox.Show("mouse_anim is ready");
    //         // MessageBox.Show(Screen.PrimaryScreen.Bounds.Width + "," + mp.X);
    //         if (!nearMouse)
    //         {
    //             MoveTo(new(Screen.PrimaryScreen.Bounds.Width - Size.Width, Screen.PrimaryScreen.Bounds.Height * 74 / 100)).Wait();
    //         }

    //         if (Screen.PrimaryScreen.Bounds.Width - (Screen.PrimaryScreen.Bounds.Width / 4) - mouseLocation.X <= Screen.PrimaryScreen.Bounds.Width / 100 && Screen.PrimaryScreen.Bounds.Width - mouseLocation.X > Size.Width - (Screen.PrimaryScreen.Bounds.Width / 50))
    //         {
    //             mp = mp with { X = mp.X - (Screen.PrimaryScreen.Bounds.Width / 200) };
    //             mainLoadThisIsPoint = mp;
    //             mainLoadPleaseDelayDuringMoving = 2;
    //             pleaseMoveMainLoad = true;
    //             nearMouse = true;
    //             // MessageBox.Show("mouse_anim 1," + mouseLocation.X + "," + Location.X);
    //             continue;
    //         }

    //         nearMouse = false;
    //         Thread.Sleep(100);
    //     } while (true);
    // }

    private async void Main_Load(object sender, EventArgs e)
    {
        synthesizer.SetOutputToDefaultAudioDevice();
        // SpeakVoice("我是Tom喵");
        contextMenuStrip1.Visible = false;
        TopMost = true;
        await EditSize(new(Screen.PrimaryScreen.Bounds.Width / 4, Screen.PrimaryScreen.Bounds.Height / 4));
        Location = new(Screen.PrimaryScreen.Bounds.Width - Size.Width, Screen.PrimaryScreen.Bounds.Height * 74 / 100);
        mainPictureBox1.Image = Properties.Resources.start1;
        TransparencyKey = BackColor;
        ShowIcon = false;
        ShowInTaskbar = false;
        mainPictureBox1.BackColor = TransparencyKey;
        await Task.Delay(100);
        await MoveTo(new(Screen.PrimaryScreen.Bounds.Width - Size.Width, (Screen.PrimaryScreen.Bounds.Height * 74 / 100) - (Screen.PrimaryScreen.Bounds.Height * 20 / 100)));
        await MoveTo(new(Screen.PrimaryScreen.Bounds.Width - Size.Width, Screen.PrimaryScreen.Bounds.Height * 74 / 100));
        await MoveTo(new(Screen.PrimaryScreen.Bounds.Width - Size.Width, (Screen.PrimaryScreen.Bounds.Height * 74 / 100) - (Screen.PrimaryScreen.Bounds.Height * 10 / 100)));
        await MoveTo(new(Screen.PrimaryScreen.Bounds.Width - Size.Width, Screen.PrimaryScreen.Bounds.Height * 74 / 100));
        await MoveTo(new(Screen.PrimaryScreen.Bounds.Width - Size.Width, (Screen.PrimaryScreen.Bounds.Height * 74 / 100) - (Screen.PrimaryScreen.Bounds.Height * 5 / 100)));
        await MoveTo(new(Screen.PrimaryScreen.Bounds.Width - Size.Width, Screen.PrimaryScreen.Bounds.Height * 74 / 100));
        pictureStatus = 0;
        _ = Task.Factory.StartNew(isThinkingOrNot, TaskCreationOptions.LongRunning);
        // _ = Task.Factory.StartNew(MouseAnim, TaskCreationOptions.LongRunning);
        // try
        // {
        //     await SendMessage("[INFO] TIME=" + DateTime.Now + ",screen_width=" + Screen.PrimaryScreen.Bounds.Width + ",screen_height=" + Screen.PrimaryScreen.Bounds.Height + ",System_information=" + RuntimeInformation.OSDescription); // 这将会上报信息，为了统计用户数量
        // }
        // catch (Exception)
        // {
        // }

        mainPictureBox1.Image = Properties.Resources.normal1;
        // 初始化txt
        if (!Directory.Exists(Application.StartupPath + "\\data"))
        {
            Directory.CreateDirectory(Application.StartupPath + "\\data");
        }

        if (!Directory.Exists(Application.StartupPath + "\\data\\cache"))
        {
            Directory.CreateDirectory(Application.StartupPath + "\\data\\cache");
        }

        File.WriteAllText(Application.StartupPath + "\\data\\cache\\isThinking.txt", "0");
        File.WriteAllText(Application.StartupPath + "\\data\\cache\\isAskFormShow.txt", "0");
        do
        {
            if (pleaseMoveMainLoad)
            {
                await MoveToWithDelay(mainLoadThisIsPoint, mainLoadPleaseDelayDuringMoving);
                mainLoadThisIsPoint = Point.Empty;
                mainLoadPleaseDelayDuringMoving = 0;
                pleaseMoveMainLoad = false;
            }

            if (File.ReadAllText(Application.StartupPath + "\\data\\cache\\isAskFormShow.txt") is "0")
            {
                // do
                // {
                //     switch (catchMousePicture)
                //     {
                //         case 1:
                //             mainPictureBox1.Load(Application.StartupPath + "\\image\\left.png");
                //             break;
                //         case 2:
                //             mainPictureBox1.Load(Application.StartupPath + "\\image\\right.png");
                //             break;
                //         case 3:
                //             mainPictureBox1.Load(Application.StartupPath + "\\image\\up.png");
                //             break;
                //         case 4:
                //             mainPictureBox1.Load(Application.StartupPath + "\\image\\down.png");
                //             break;
                //     }

                //     await Task.Delay(10);
                // } while (Location == mouseLocation);

                await EditSize(new(Screen.PrimaryScreen.Bounds.Width / 4, Screen.PrimaryScreen.Bounds.Height / 4));
                if (!nearMouse)
                {
                    await MoveTo(new(Screen.PrimaryScreen.Bounds.Width - Size.Width, Screen.PrimaryScreen.Bounds.Height * 74 / 100));
                }
            }
            else
            {
                if (MousePosition.X >= Screen.PrimaryScreen.Bounds.Width * 7 / 10 && MousePosition.Y >= Screen.PrimaryScreen.Bounds.Height * 7 / 10)
                {
                    // await MoveTo(MousePosition);
                }
                else
                {
                    await MoveTo(new(Screen.PrimaryScreen.Bounds.Width - Size.Width, Screen.PrimaryScreen.Bounds.Height * 74 / 100));
                }

                await Task.Delay(10);
                if (isThinking)
                {
                    if (isThinkingSmall)
                    {
                        await EditSize(new(Screen.PrimaryScreen.Bounds.Width / 9, Screen.PrimaryScreen.Bounds.Height / 9));
                        isThinkingSmall = false;
                        await Task.Delay(500);
                    }
                    else
                    {
                        await EditSize(new(Screen.PrimaryScreen.Bounds.Width / 7, Screen.PrimaryScreen.Bounds.Height / 7));
                        isThinkingSmall = true;
                        await Task.Delay(500);
                    }
                }
                else
                {
                    await EditSize(new(Screen.PrimaryScreen.Bounds.Width / 7, Screen.PrimaryScreen.Bounds.Height / 7));
                }
            }

            await Task.Delay(10);
        } while (true);
    }

    private async Task catch_mouse()
    {
        for (int i = 0; i < 400; i++)
        {
            mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, mousePoint1.X * 65536 / Screen.PrimaryScreen.WorkingArea.Width, mousePoint1.Y * 65536 / Screen.PrimaryScreen.WorkingArea.Height, 0, 0);
            await Task.Delay(10);
        }

        await EditSize(new(Screen.PrimaryScreen.Bounds.Width / 5, Screen.PrimaryScreen.Bounds.Height / 5));
        mainPictureBox1.Image = Properties.Resources.normal1;
        Location = new(Screen.PrimaryScreen.Bounds.Width - Size.Width, Screen.PrimaryScreen.Bounds.Height * 74 / 100);
        File.WriteAllText(Application.StartupPath + "\\data\\cache\\show1.txt", "算了算了，我也不想做个病毒程序，这次就放你一马，下次不可以点我了啊！");
        show1 show1_show = new();
        show1_show.Show();
    }

    private async Task AutoSetLocation()
    {
        // SpeakVoice("好好好，敢抓我是吧，看我抢你鼠标");
        do
        {
            if (power is not 0)
            {
                if (Location.X > mouseLocation.X)
                {
                    for (int i = Location.X; i > mouseLocation.X; i--)
                    {
                        if (pictureStatus is not 1)
                        {
                            mainPictureBox1.Image=Properties.Resources.left;
                            await Task.Delay(1);
                            pictureStatus = 1;
                        }
                        if (Location==mouseLocation)
                        {
                            File.WriteAllText(Application.StartupPath + "\\data\\cache\\show1.txt", "抢到啦！");
                            mousePoint1 = MousePosition;
                            show1 show1_show = new();
                            show1_show.Show();
                            pictureStatus = 0;
                            await catch_mouse();
                            break;
                        }
                        Location = Location with { X = i };
                        await Task.Delay(1);
                        // mainPictureBox1.Load(Application.StartupPath + "\\image\\left.png");
                        // catchMousePicture = 1;
                    }
                }

                if (Location.X < mouseLocation.X)
                {
                    for (int i = Location.X; i < mouseLocation.X; i++)
                    {
                        if (pictureStatus is not 2)
                        {
                            mainPictureBox1.Image = Properties.Resources.right;
                            await Task.Delay(1);
                            pictureStatus = 2;
                        }
                        if (Location == mouseLocation)
                        {
                            File.WriteAllText(Application.StartupPath + "\\data\\cache\\show1.txt", "抢到啦！");
                            mousePoint1 = MousePosition;
                            show1 show1_show = new();
                            show1_show.Show();
                            pictureStatus = 0;
                            await catch_mouse();
                            break;
                        }
                        Location = Location with { X = i };
                        await Task.Delay(1);
                        // mainPictureBox1.Load(Application.StartupPath + "\\image\\right.png");
                        // catchMousePicture = 2;
                    }
                }

                if (Location.Y > mouseLocation.Y)
                {
                    for (int i = Location.Y; i > mouseLocation.Y; i--)
                    {
                        if (pictureStatus is not 3)
                        {
                            mainPictureBox1.Image = Properties.Resources.up;
                            await Task.Delay(1);
                            pictureStatus = 3;
                        }
                        if (Location == mouseLocation)
                        {
                            File.WriteAllText(Application.StartupPath + "\\data\\cache\\show1.txt", "抢到啦！");
                            mousePoint1 = MousePosition;
                            show1 show1_show = new();
                            show1_show.Show();
                            pictureStatus = 0;
                            await catch_mouse();
                            break;
                        }
                        Location = Location with { Y = i };
                        await Task.Delay(1);
                        // mainPictureBox1.Load(Application.StartupPath + "\\image\\up.png");
                        // catchMousePicture = 3;
                    }
                }

                if (Location.Y < mouseLocation.Y)
                {
                    for (int i = Location.Y; i < mouseLocation.Y; i++)
                    {
                        if (pictureStatus is not 4)
                        {
                            mainPictureBox1.Image = Properties.Resources.down;
                            await Task.Delay(1);
                            pictureStatus = 4;
                        }
                        if (Location == mouseLocation)
                        {
                            File.WriteAllText(Application.StartupPath + "\\data\\cache\\show1.txt", "抢到啦！");
                            mousePoint1 = MousePosition;
                            show1 show1_show = new();
                            show1_show.Show();
                            pictureStatus = 0;
                            await catch_mouse();
                            break;
                        }
                        Location = Location with { Y = i };
                        await Task.Delay(1);
                        // mainPictureBox1.Load(Application.StartupPath + "\\image\\down.png");
                        // catchMousePicture = 4;
                    }
                }

                if (Location == mouseLocation)
                {
                    File.WriteAllText(Application.StartupPath + "\\data\\cache\\show1.txt", "抢到啦！");
                    mousePoint1 = MousePosition;
                    show1 show1_show = new();
                    show1_show.Show();
                    pictureStatus = 0;
                    await catch_mouse();
                    break;
                }
            }

            TopMost = true;
        } while (true);
        showAskForm1.Hide();
        File.WriteAllText(Application.StartupPath + "\\data\\cache\\isAskFormShow.txt", "0");
    }

    private void updateMouseLocation()
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
        await EditSize(new(Screen.PrimaryScreen.Bounds.Width / 7, Screen.PrimaryScreen.Bounds.Height / 7));
        mainPictureBox1.Image = Properties.Resources.fall_down;
        await Task.Delay(1000);
        // mainPictureBox1.Load(Application.StartupPath + "\\image\\miao1.jpg");
        // await Task.Delay(100);
        // SpeakVoice("气死我了，我抢你鼠标！");
        File.WriteAllText(Application.StartupPath + "\\data\\cache\\show1.txt", "气死我了，我抢你鼠标！");
        await EditSize(new(Screen.PrimaryScreen.Bounds.Width / 8, Screen.PrimaryScreen.Bounds.Height / 8));
        show1 show1_show = new();
        show1_show.Show();
        await Task.Delay(1000);
        pictureStatus = 0;
        await AutoSetLocation();
    }

    private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        SettingsForm1 settingsForm1=new SettingsForm1();
        settingsForm1.ShowDialog();
    }

    private void mainPictureBox1_MouseClick(object sender, MouseEventArgs e)
    {
        if (e.Button is MouseButtons.Right)
        {
            contextMenuStrip1.Show(this, Point.Empty);
        }
        else
        {
            if (File.Exists(Application.StartupPath + "\\data\\cache\\isAskFormShow.txt") && File.ReadAllText(Application.StartupPath + "\\data\\cache\\isAskFormShow.txt") is "1")
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

    private void contextMenuStrip1_MouseClick(object sender, MouseEventArgs e)
    {
    }

    private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("要退出橘子桌面宠物吗？\n 这将会清除所有内容","退出 橘子桌面宠物",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
        {
            this.Close();
            Application.Exit();
        }
    }

    private void 随机存取存储器ToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void cPUToolStripMenuItem_Click(object sender, EventArgs e)
    {
        CPUmonitor cPUmonitor = new CPUmonitor();
        cPUmonitor.Show();
    }
}
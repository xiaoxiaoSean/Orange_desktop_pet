using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Speech.Synthesis;
using System.Text;
using System.IO;

namespace 橘子桌面宠物;

public partial class Main : Form
{
    private const int MOUSEEVENTF_MOVE = 0x0001;
    private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
    private const int MOUSEEVENTF_LEFTUP = 0x0004;
    private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
    private const int MOUSEEVENTF_RIGHTUP = 0x0010;
    private const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
    private const int MOUSEEVENTF_MIDDLEUP = 0x0040;
    private const int MOUSEEVENTF_ABSOLUTE = 0x8000;
    private readonly int power = 100;

    //void SpeakVoice(string speakText)
    //{
    //    synthesizer.Speak(speakText);
    //    return;
    //}

    private readonly AskForm1 showAskForm1 = new();
    private readonly SpeechSynthesizer synthesizer = new();
    private bool isOrigin = true;
    private bool isThinking;
    private bool isThinkingSmall;

    //bool isMouseLocation = false;
    private Point mouseLocation;
    private Point mousePoint1;

    //int catchMousePicture = 0;
    private int pictureStatus;

    public Main()
    {
        InitializeComponent();
        start();
    }

    [DllImport("user32")]
    private static extern int mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

    private void start()
    {
        Task.Factory.StartNew(updateMouseLocation, TaskCreationOptions.LongRunning);
        //await Task.Run(() => Consume_power());
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
                    // synthesizer.Speak("Tom喵正在思考中");
                    if (isOrigin)
                    {
                        Location = new(Location.X, Location.Y - (Screen.PrimaryScreen.Bounds.Height / 200));
                        isOrigin = false;
                    }
                    else
                    {
                        Location = new(Location.X, Location.Y + (Screen.PrimaryScreen.Bounds.Height / 200));
                        isOrigin = true;
                    }
                }
                else
                {
                    isThinking = false;
                    if (!isOrigin)
                    {
                        Location = new(Screen.PrimaryScreen.Bounds.Width - Size.Width, Screen.PrimaryScreen.Bounds.Height * 74 / 100);
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

    //public void SendMessage(string message)
    //{
    //    try
    //    {
    //        TcpClient client = new("server", int.Parse("2053"));
    //        byte[] data = Encoding.ASCII.GetBytes(message);
    //        NetworkStream stream = client.GetStream();
    //        stream.Write(data, 0, data.Length);
    //        stream.Close();
    //        client.Close();
    //    }
    //    catch (Exception)
    //    {
    //    }
    //}

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
    private async Task EditSize(Size toSize)
    {
        int times = 0;
        int pfreq = 1;
        int wfreq = 20;
        if (Size.Width > toSize.Width)
        {
            for (int i = Size.Width; i > toSize.Width; i-=20)
            {
                Size=Size with { Width = i };
                if (times<pfreq)
                {
                    times++;
                }
                else
                {
                    mainPictureBox1.Refresh();
                    times = 0;
                }
                //await Task.DelaHeight(1);
            }
        }

        if (Size.Width < toSize.Width)
        {
            for (int i = Size.Width; i < toSize.Width; i+=20)
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
                //await Task.DelaHeight(1);
            }
        }

        if (Size.Height > toSize.Height)
        {
            for (int i = Size.Height; i > toSize.Height; i-=20)
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
                //await Task.DelaHeight(1);
            }
        }

        if (Size.Height < toSize.Height)
        {
            for (int i = Size.Height; i < toSize.Height; i+=20)
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
                //await Task.DelaHeight(1);
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
                //await Task.Delay(1);
            }
        }

        if (Location.X < toPoint.X)
        {
            for (int i = Location.X; i < toPoint.X; i++)
            {
                Location = Location with { X = i };
                //await Task.Delay(1);
            }
        }

        if (Location.Y > toPoint.Y)
        {
            for (int i = Location.Y; i > toPoint.Y; i--)
            {
                Location = Location with { Y = i };
                //await Task.Delay(1);
            }
        }

        if (Location.Y < toPoint.Y)
        {
            for (int i = Location.Y; i < toPoint.Y; i++)
            {
                Location = Location with { Y = i };
                //await Task.Delay(1);
            }
        }

        await Task.Delay(10);
    }

    private async void Main_Load(object sender, EventArgs e)
    {
        synthesizer.SetOutputToDefaultAudioDevice();
        //await Task.Run(() => SpeakVoice("我是Tom喵"));
        TopMost = true;
      EditSize(new Size(Screen.PrimaryScreen.Bounds.Width / 4, Screen.PrimaryScreen.Bounds.Height / 4));
        Location = new(Screen.PrimaryScreen.Bounds.Width - Size.Width, Screen.PrimaryScreen.Bounds.Height * 74 / 100);
        mainPictureBox1.Load(Application.StartupPath + "\\image\\start1.png");
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
        Task.Factory.StartNew(isThinkingOrNot, TaskCreationOptions.LongRunning);
        /*try
        {
            await Task.Run(() => SendMessage("[INFO] TIME=" + DateTime.Now + ",screen_width=" + Screen.PrimaryScreen.Bounds.Width + ",screen_height=" + Screen.PrimaryScreen.Bounds.Height + ",System_information=" + System.Runtime.InteropServices.RuntimeInformation.OSDescription));//这将会上报信息，为了统计用户数量
        }
        catch (Exception)
        {
        }*/
        mainPictureBox1.Load(Application.StartupPath + "\\image\\normal1.png");
        //初始化txt
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
            if (File.ReadAllText(Application.StartupPath + "\\data\\cache\\isAskFormShow.txt") is "0")
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
                EditSize( new(Screen.PrimaryScreen.Bounds.Width / 4, Screen.PrimaryScreen.Bounds.Height / 4));
                MoveTo(new Point(Screen.PrimaryScreen.Bounds.Width - Size.Width, Screen.PrimaryScreen.Bounds.Height * 74 / 100));
            }
            else
            {
                if (MousePosition.X >= Screen.PrimaryScreen.Bounds.Width * 7 / 10 && MousePosition.Y >= Screen.PrimaryScreen.Bounds.Height * 7 / 10)
                {
                    //MoveTo(MousePosition);
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
                        EditSize( new(Screen.PrimaryScreen.Bounds.Width / 9, Screen.PrimaryScreen.Bounds.Height / 9));
                        isThinkingSmall = false;
                        await Task.Delay(500);
                    }
                    else
                    {
                        EditSize( new(Screen.PrimaryScreen.Bounds.Width / 7, Screen.PrimaryScreen.Bounds.Height / 7));
                        isThinkingSmall = true;
                        await Task.Delay(500);
                    }
                }
                else
                {
                    EditSize( new(Screen.PrimaryScreen.Bounds.Width / 7, Screen.PrimaryScreen.Bounds.Height / 7));
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

        EditSize( new(Screen.PrimaryScreen.Bounds.Width / 5, Screen.PrimaryScreen.Bounds.Height / 5));
        mainPictureBox1.Load(Application.StartupPath + "\\image\\normal1.png");
        Location = new(Screen.PrimaryScreen.Bounds.Width - Size.Width, Screen.PrimaryScreen.Bounds.Height * 74 / 100);
        File.WriteAllText(Application.StartupPath + "\\data\\cache\\show1.txt", "算了算了，我也不想做个病毒程序，这次就放你一马，下次不可以点我了啊！");
        show1 show1_show = new();
        show1_show.Show();
    }

    private async Task AutoSetLocation()
    {
        // await Task.Run(() => SpeakVoice("好好好，敢抓我是吧，看我抢你鼠标"));
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
                            mainPictureBox1.Load(Application.StartupPath + "\\image\\left.png");
                            pictureStatus = 1;
                        }

                        Location = Location with { X = i };
                        //mainPictureBox1.Load(Application.StartupPath + "\\image\\left.png");
                        //catchMousePicture = 1;
                    }
                }

                if (Location.X < mouseLocation.X)
                {
                    for (int i = Location.X; i < mouseLocation.X; i++)
                    {
                        if (pictureStatus is not 2)
                        {
                            mainPictureBox1.Load(Application.StartupPath + "\\image\\right.png");
                            pictureStatus = 2;
                        }

                        Location = Location with { X = i };
                        //mainPictureBox1.Load(Application.StartupPath + "\\image\\right.png");
                        //catchMousePicture = 2;
                    }
                }

                if (Location.Y > mouseLocation.Y)
                {
                    for (int i = Location.Y; i > mouseLocation.Y; i--)
                    {
                        if (pictureStatus is not 3)
                        {
                            mainPictureBox1.Load(Application.StartupPath + "\\image\\up.png");
                            pictureStatus = 3;
                        }

                        Location = Location with { Y = i };
                        //mainPictureBox1.Load(Application.StartupPath + "\\image\\up.png");
                        //catchMousePicture = 3;
                    }
                }

                if (Location.Y < mouseLocation.Y)
                {
                    for (int i = Location.Y; i < mouseLocation.Y; i++)
                    {
                        if (pictureStatus is not 4)
                        {
                            mainPictureBox1.Load(Application.StartupPath + "\\image\\down.png");
                            pictureStatus = 4;
                        }

                        Location = Location with { Y = i };
                        // mainPictureBox1.Load(Application.StartupPath + "\\image\\down.png");
                        //catchMousePicture =4;
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
        EditSize( new(Screen.PrimaryScreen.Bounds.Width / 7, Screen.PrimaryScreen.Bounds.Height / 7));
        mainPictureBox1.Load(Application.StartupPath + "\\image\\fall_down.png");
        await Task.Delay(1000);
        //mainPictureBox1.Load(Application.StartupPath + "\\image\\miao1.jpg");
        await Task.Delay(100);
        // await Task.Run(() => SpeakVoice("气死我了，我抢你鼠标！"));
        File.WriteAllText(Application.StartupPath + "\\data\\cache\\show1.txt", "气死我了，我抢你鼠标！");
        EditSize( new(Screen.PrimaryScreen.Bounds.Width / 8, Screen.PrimaryScreen.Bounds.Height / 8));
        show1 show1_show = new();
        show1_show.Show();
        await Task.Delay(1000);
        pictureStatus = 0;
        await AutoSetLocation();
    }

    private void mainPictureBox1_Click(object sender, EventArgs e)
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

namespace 橘子桌面宠物;

public partial class show1 : Form
{
    public show1()
    {
        InitializeComponent();
    }

    private async void show1_Load(object sender, EventArgs e)
    {
        TopMost = true;
        string r = string.Empty;
        await Task.Delay(100);
        try
        {
            r = File.ReadAllText(Application.StartupPath + "\\data\\cache\\show1.txt");
        }
        catch (Exception ex)
        {
            showLabel1.Text = "发生错误了喵" + ex;
        }

        if (r.Contains("能量值"))
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

                Size = new(showLabel1.Size.Width, showLabel1.Size.Height);
                Location = new(Screen.PrimaryScreen.Bounds.Width - Size.Width - (Screen.PrimaryScreen.Bounds.Width / 20), (Screen.PrimaryScreen.Bounds.Height * 74 / 100) - (Screen.PrimaryScreen.Bounds.Height / 5) - Size.Height);
                await Task.Delay(10);
            } while (true);
        }

        try
        {
            r = File.ReadAllText(Application.StartupPath + "\\data\\cache\\show1.txt");
            showLabel1.Text = r;
        }
        catch (Exception ex)
        {
            showLabel1.Text = "发生错误了喵" + ex;
        }

        Size = new(showLabel1.Size.Width, showLabel1.Size.Height);
        Location = new(Screen.PrimaryScreen.Bounds.Width - Size.Width, (Screen.PrimaryScreen.Bounds.Height * 74 / 100) - (Screen.PrimaryScreen.Bounds.Height / 5) - Size.Height);
        await Task.Delay(2000);
        Close();
        Dispose();
        Hide();
    }
}
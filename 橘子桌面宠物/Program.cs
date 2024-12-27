namespace 橘子桌面宠物;
using System.Threading;
internal static class Program
{
    /// <summary>
    /// 应用程序的主入口点。
    /// </summary>
    [STAThread]
    private static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Mutex mt=new Mutex(true,"orange_desktop_pet");
        if (mt.WaitOne(0, false)) {
            Application.Run(new Main());
        }
        else
        {
            MessageBox.Show("此程序已有一个实例在运行，不能同时运行多个实例","橘子桌面宠物");
            Application.Exit();
        }
    }
}
using Prog7312_POE_Part2;
using System;
using System.Windows.Forms;

namespace Prog7312_POE_Part2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            bool createdNew;
            using (var mutex = new System.Threading.Mutex(true, "Prog7311_POE_Part2", out createdNew))
            {
                if (!createdNew)
                {
                    MessageBox.Show("Application is already running!");
                    return;
                }

                Application.EnableVisualStyles();
                Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainMenu());
            }
        }
    }
}

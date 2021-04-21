using System;
using System.Windows.Forms;

namespace RegProcess
{
    internal static class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            Application.ThreadException += Application_ThreadException;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

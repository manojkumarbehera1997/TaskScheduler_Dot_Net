using System;
using System.Windows.Forms;

namespace MDMTask
{
    static class Program
    {
        public static Processes objProcesses;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //objProcesses = new Processes();
            //Application.Run(objProcesses);
            Application.Run(new frmTaskScheduler());
        }
    }
}

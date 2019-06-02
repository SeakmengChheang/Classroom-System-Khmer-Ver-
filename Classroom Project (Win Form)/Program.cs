using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classroom_Project__Win_Form_
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //? Detect whether the program is already running
            string processName = Process.GetCurrentProcess().ProcessName;
            if (Process.GetProcesses().Count(p => p.ProcessName == processName) > 1) {
                new Animation.msgBoxErrorAnimation("កម្មវិធីត្រូវបានបើករួចហើយ").ShowDialog();
                Application.Exit();
                return;

                //DialogResult dr = MessageBox.Show("កម្មវិធីត្រូវបានបើករួចហើយ សូមបិទកម្មវិធីមុនដោយចូលទៅ\n Task Manager ឬចុច OK ដើម្បីបិទកម្មវិធីដែលបើករួច។", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                //if (dr == DialogResult.OK)
                //{
                //    Process[] allAppProcesses = Process.GetProcessesByName(processName);
                //    allAppProcesses[0].Kill();
                //}
                //else
                //    return;
            }

            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException += new UnhandledExceptionEventHandler(Handler);

            //WindowsFormsSettings.ForceDirectXPaint();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException);
            Application.Run(new Login());
        }

        static void Handler(object sender, UnhandledExceptionEventArgs e)
        {
            if (!File.Exists(frmMain.FilePath + "\\errors.log"))
                File.Create(frmMain.FilePath + "\\errors.log").Close();

            Exception ex = (Exception) e.ExceptionObject;
            StringBuilder error = new StringBuilder();
            error.Append("#" + DateTime.Now + Environment.NewLine);
            error.Append("Method: " + ex.TargetSite + Environment.NewLine);
            error.Append("ExceptionMsg: " + ex.Message + Environment.NewLine);
            error.Append("Line: " + ex.StackTrace + Environment.NewLine + Environment.NewLine);

            File.AppendAllText(frmMain.FilePath + "\\errors.log", error.ToString());

            new Animation.Error_Report().ShowDialog();

            Application.Exit();
        }
        
    }
}

using Core.Logging;
using MyFormsApp_ILMerge.Logging.Actions;
using System;
using System.Threading;
using System.Windows.Forms;

namespace MyFormsApp_ILMerge
{
    /// <summary>
    /// Defines the behaviors of the application.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            LogFileManager.InitializeLogging(
                false, true,
                infrastructureType: LoggingInfrastructureType.PostSharp,
                logFileName: Get.LogFilePath()
            );

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.SetUnhandledExceptionMode(
                UnhandledExceptionMode.CatchException
            );
            Application.ThreadException += OnThreadException;

            Application.Run(new MainWindow());
        }

        private static void OnThreadException(object sender,
            ThreadExceptionEventArgs e)
        {
            MessageBox.Show(
                e.Exception.Message, Application.ProductName,
                MessageBoxButtons.OK, MessageBoxIcon.Stop,
                MessageBoxDefaultButton.Button1
            );

            // dump all the exception info to the log
            DebugUtils.LogException(e.Exception);
        }
    }
}
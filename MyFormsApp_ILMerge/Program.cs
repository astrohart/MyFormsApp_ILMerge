using Core.Assemblies.Info;
using Core.Logging;
using Core.Logging.Constants;
using Core.Win32.Interact;
using MyFormsApp_ILMerge.Logging.Actions;
using MyFormsApp_ILMerge.Properties;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace MyFormsApp_ILMerge
{
    /// <summary> Defines the behaviors of the application. </summary>
    public static class Program
    {
        /// <summary> The main entry point for the application. </summary>
        [STAThread]
        public static void Main()
        {
            SetupLogging();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SetProcessDpiAwareness((int)DpiAwareness.PerMonitorAware);

            Application.SetUnhandledExceptionMode(
                UnhandledExceptionMode.CatchException
            );
            Application.ThreadException += OnThreadException;

            Application.Run(new MainWindow());
        }

        private static void OnThreadException(
            object sender,
            ThreadExceptionEventArgs e
        )
        {
            MessageBox.Show(
                e.Exception.Message, Application.ProductName,
                MessageBoxButtons.OK, MessageBoxIcon.Stop,
                MessageBoxDefaultButton.Button1
            );

            // dump all the exception info to the log
            DebugUtils.LogException(e.Exception);
        }

        [DllImport("Shcore.dll")]
        private static extern int SetProcessDpiAwareness(
            int PROCESS_DPI_AWARENESS
        );

        private static void SetupLogging()
        {
            try
            {
                LogFileManager.InitializeLogging(
                    muteConsole: false,
                    infrastructureType: LoggingInfrastructureType.PostSharp,
                    logFileName: Get.LogFilePath(),
                    applicationName: Get.ApplicationProductName()
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                Messages.ShowStopError(
                    $"{Resources.Error_CannotSetupLogging.Replace("%APPNAME%", AssemblyMetadata.ShortProductName)}\n\n{ex.Message}"
                );
            }
        }

        // According to https://msdn.microsoft.com/en-us/library/windows/desktop/dn280512(v=vs.85).aspx
        private enum DpiAwareness
        {
            None = 0,
            SystemAware = 1,
            PerMonitorAware = 2
        }
    }
}
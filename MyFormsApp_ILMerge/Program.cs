using Core.Assemblies.Info;
using Core.Logging;
using Core.Logging.Constants;
using Core.Win32.Interact;
using MyFormsApp_ILMerge.Properties;
using System;
using System.IO;
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
                Messages.ShowInformation($"Log file path is '{Get.LogFilePath()}'.");

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

        /// <summary>
        /// Exposes static methods to obtain data from various data sources.
        /// </summary>
        private static class Get
        {
            /// <summary>
            /// A <see cref="T:System.String" /> containing the final piece of the path of the
            /// log file.
            /// </summary>
            private static readonly string LOG_FILE_PATH_TERMINATOR =
                $@"{AssemblyCompany}\{AssemblyProduct}\Logs\{AssemblyTitle}_log.txt";

            /// <summary>
            /// Gets a <see cref="T:System.String" /> that contains the product name defined
            /// for this application.
            /// </summary>
            /// <remarks>
            /// This property is really an alias for the
            /// <see cref="P:xyLOGIX.Core.Assemblies.Info.AssemblyMetadata.AssemblyCompany" />
            /// property.
            /// </remarks>
            private static string AssemblyCompany
                => AssemblyMetadata.AssemblyCompany;

            /// <summary>
            /// Gets a <see cref="T:System.String" /> that contains the product name defined
            /// for this application.
            /// </summary>
            /// <remarks>
            /// This property is really an alias for the
            /// <see cref="P:xyLOGIX.Core.Assemblies.Info.AssemblyMetadata.ShortProductName" />
            /// property.
            /// </remarks>
            private static string AssemblyProduct
                => AssemblyMetadata.ShortProductName;

            /// <summary>
            /// Gets a <see cref="T:System.String" /> that contains the assembly title defined
            /// for this application.
            /// </summary>
            /// <remarks>
            /// This property is really an alias for the
            /// <see cref="P:xyLOGIX.Core.Assemblies.Info.AssemblyMetadata.AssemblyTitle" />
            /// property --- except that all whitespace is replace with underscores.
            /// </remarks>
            private static string AssemblyTitle
                => AssemblyMetadata.AssemblyTitle.Replace(" ", "_");

            /// <summary>
            /// Gets a <see cref="T:System.String" /> that contains a user-friendly name for
            /// the software product of which this application or class library is a part.
            /// </summary>
            /// <returns>
            /// A <see cref="T:System.String" /> that contains a user-friendly name for the
            /// software product of which this application or class library is a part.
            /// </returns>
            public static string ApplicationProductName()
            {
                string result;

                try
                {
                    result = AssemblyProduct;
                }
                catch (Exception ex)
                {
                    // dump all the exception info to the log
                    DebugUtils.LogException(ex);

                    result = string.Empty;
                }

                return result;
            }

            /// <summary>
            /// Obtains a <see cref="T:System.String" /> that contains the fully-qualified
            /// pathname of the file that should be used for logging messages.
            /// </summary>
            /// <returns>
            /// A <see cref="T:System.String" /> that contains the fully-qualified pathname of
            /// the file that should be used for logging messages.
            /// </returns>
            public static string LogFilePath()
                => Path.Combine(
                    Environment.GetFolderPath(
                        Environment.SpecialFolder.CommonApplicationData
                    ), LOG_FILE_PATH_TERMINATOR
                );
        }
    }
}
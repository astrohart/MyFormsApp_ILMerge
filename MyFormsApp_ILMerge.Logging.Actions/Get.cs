using Alphaleonis.Win32.Filesystem;
using Core.Assemblies.Info;
using Core.Logging;
using System;

namespace MyFormsApp_ILMerge.Logging.Actions
{
    /// <summary>
    /// Exposes static methods to obtain data from various data sources.
    /// </summary>
    public static class Get
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
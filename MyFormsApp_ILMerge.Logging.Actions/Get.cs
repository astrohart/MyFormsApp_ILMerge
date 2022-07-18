using Alphaleonis.Win32.Filesystem;
using System;

namespace MyFormsApp_ILMerge.Logging.Actions
{
    /// <summary>
    /// Exposes static methods used in order to obtain information from various data
    /// sources.
    /// </summary>
    public static class Get
    {
        /// <summary>
        /// Obtains a string that is the fully-qualified pathname of the location on the
        /// disk where this application's log file should be written.
        /// </summary>
        /// <returns>
        /// Fully-qualified pathname of the location on the disk where this
        /// application's log file should be written.
        /// </returns>
        public static string LogFilePath()
            => Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.CommonApplicationData
                ),
                @"xyLOGIX, LLC\MyFormsApp_ILMerge\Logs\MyFormsApp_ILMerge_log.txt"
            );
    }
}

using Alphaleonis.Win32.Filesystem;
using MyFormsApp_ILMerge.Models.Constants;
using MyFormsApp_ILMerge.Models.Interfaces;
using System;

namespace MyFormsApp_ILMerge.Models
{
    /// <summary>
    /// Models the data from a text file.
    /// </summary>
    public class TextFileModel : FileModelBase<string>, ITextFileModel
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static TextFileModel() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected TextFileModel() { }

        /// <summary>
        /// Gets a <see cref="T:MyFormsApp_ILMerge.Models.Constants.FileType" />
        /// enumeration value that describes which type of file this object models.
        /// </summary>
        public override FileType FileType
            => FileType.Text;

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MyFormsApp_ILMerge.Models.Interfaces.ITextFileModel" /> interface.
        /// </summary>
        public static ITextFileModel Instance { get; } = new TextFileModel();

        /// <summary>
        /// Loads the data from the file on the disk with the specified pathname.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> containing the fully-qualified
        /// pathname of the file to be loaded.
        /// </param>
        /// <returns>
        /// A <see cref="T:System.String" /> that contains the file's data, or blank if
        /// either an issue occurred during the loading process, or if the file does not
        /// exist at the specified <paramref name="pathname" />.
        /// </returns>
        public override string LoadFrom(string pathname)
        {
            var result = string.Empty;

            try
            {
                if (string.IsNullOrWhiteSpace(pathname))
                    return result;
                if (!File.Exists(pathname)) return result;

                result = File.ReadAllText(pathname);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

                result = string.Empty;
            }

            return result;
        }
    }
}
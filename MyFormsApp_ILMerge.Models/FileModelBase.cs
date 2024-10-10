using MyFormsApp_ILMerge.Models.Constants;
using MyFormsApp_ILMerge.Models.Interfaces;

namespace MyFormsApp_ILMerge.Models
{
    /// <summary>
    /// Defines the events, methods, properties, and behaviors for all models
    /// of files of any type.
    /// </summary>
    public abstract class FileModelBase<T> : IFileModel<T>
    {
        /// <summary>
        /// Gets or sets a <see cref="T:System.String" /> that contains the
        /// fully-qualified pathname of the file.
        /// </summary>
        /// <remarks>
        /// If the value of this property is <see langword="null" /> or the blank
        /// string, then this means that a file is not currently loaded.
        /// </remarks>
        public string FileName { get; protected set; }

        /// <summary>
        /// Gets a <see cref="T:MyFormsApp_ILMerge.Models.Constants.FileType" />
        /// enumeration value that describes which type of file this object models.
        /// </summary>
        public abstract FileType FileType { get; }

        /// <summary> Loads the data from the file on the disk with the specified pathname. </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> containing
        /// the fully-qualified pathname of the file to be loaded.
        /// </param>
        /// <returns>
        /// Reference to a <typeparamref name="T" /> that represents the file's
        /// data.
        /// </returns>
        public abstract T LoadFrom(string pathname);
    }
}
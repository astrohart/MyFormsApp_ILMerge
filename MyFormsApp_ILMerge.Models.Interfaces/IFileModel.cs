using MyFormsApp_ILMerge.Models.Constants;

namespace MyFormsApp_ILMerge.Models.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that
    /// models a file on the disk.
    /// </summary>
    /// <remarks>
    /// Right now, for the purposes of this ILMerge demo app, we only support
    /// the loading of data from files on the disk, not the saving of the data.
    /// </remarks>
    /// <typeparam name="T">
    /// Specifies the name of the class or primitive type that
    /// encapsulates the file's data.
    /// </typeparam>
    public interface IFileModel<T>
    {
        /// <summary>
        /// Gets or sets a <see cref="T:System.String" /> that contains the
        /// fully-qualified pathname of the file.
        /// </summary>
        /// <remarks>
        /// If the value of this property is <see langword="null" /> or the blank
        /// string, then this means that a file is not currently loaded.
        /// </remarks>
        string FileName { [DebuggerStepThrough] get; }

        /// <summary>
        /// Gets a <see cref="T:MyFormsApp_ILMerge.Models.Constants.FileType" />
        /// enumeration value that describes which type of file this object models.
        /// </summary>
        FileType FileType { [DebuggerStepThrough] get; }

        /// <summary> Loads the data from the file on the disk with the specified pathname. </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> containing
        /// the fully-qualified pathname of the file to be loaded.
        /// </param>
        /// <returns>
        /// Reference to a <typeparamref name="T" /> that represents the file's
        /// data.
        /// </returns>
        T LoadFrom(string pathname);
    }
}
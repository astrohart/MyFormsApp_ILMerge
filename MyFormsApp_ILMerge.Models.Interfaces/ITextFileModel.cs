using MyFormsApp_ILMerge.Models.Constants;

namespace MyFormsApp_ILMerge.Models.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of the model of a
    /// text file.
    /// </summary>
    public interface ITextFileModel
    {
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
        /// A <see cref="T:System.String" /> that contains the file's data, or
        /// blank if either an issue occurred during the loading process, or if the file
        /// does not exist at the specified <paramref name="pathname" />.
        /// </returns>
        string LoadFrom(string pathname);
    }
}
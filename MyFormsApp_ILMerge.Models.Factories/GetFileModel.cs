using MyFormsApp_ILMerge.Models.Constants;
using MyFormsApp_ILMerge.Models.Interfaces;
using System;

namespace MyFormsApp_ILMerge.Models.Factories
{
    /// <summary>
    /// Obtains references to instances of objects that implement the
    /// <see cref="T:MyFormsApp_ILMerge.Models.Interfaces.IFileModel{T}" /> interface
    /// that change depending on the strategy desired.
    /// </summary>
    public static class GetFileModel
    {
        /// <summary>
        /// Obtains a reference to an instance of an object that implements the
        /// <see cref="T:MyFormsApp_ILMerge.Models.Interfaces.IFileModel{T}" />
        /// interface which corresponds to the specified meeting
        /// <paramref name="fileType" />.
        /// </summary>
        /// <param name="fileType">
        /// (Required.) One of the
        /// <see cref="T:MyFormsApp_ILMerge.Models.Constants.FileType" /> enumeration
        /// values that describes the type of file that is to be accessed.
        /// </param>
        /// <typeparam name="T">
        /// Name of the class or primitive type that encapsulates the
        /// file's data.
        /// </typeparam>
        /// <returns>
        /// Reference to the instance of the object that implements the
        /// <see cref="T:MyFormsApp_ILMerge.Models.Interfaces.IFileModel{T}" />
        /// interface which corresponds to the specific enumeration value that is
        /// specified for the argument of the <paramref name="fileType" /> parameter.
        /// </returns>
        /// <remarks>
        /// This method will throw an exception if there are no types implemented
        /// that correspond to the enumeration value passed for the argument of the
        /// <paramref name="fileType" /> parameter.
        /// </remarks>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if there is no corresponding concrete type defined that implements the
        /// <see cref="T:MyFormsApp_ILMerge.Models.Interfaces.IFileModel{T}" />
        /// interface and which corresponds to the specific enumeration value that
        /// was passed for the argument of the <paramref name="fileType" /> parameter, if
        /// it is not supported.
        /// </exception>
        public static IFileModel<T> For<T>(FileType fileType)
        {
            IFileModel<T> result;

            try
            {
                switch (fileType)
                {
                    case FileType.Text:
                        result = (IFileModel<T>)TextFileModel.Instance;
                        break;

                    default:
                        throw new ArgumentOutOfRangeException(
                            nameof(fileType), fileType,
                            $"The file type, '{fileType}', is not supported."
                        );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

                result = default;
            }

            return result;
        }
    }
}
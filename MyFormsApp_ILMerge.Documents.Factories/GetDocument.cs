using MyFormsApp_ILMerge.Documents.Interfaces;

namespace MyFormsApp_ILMerge.Documents.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:MyFormsApp_ILMerge.Documents.IDocument" /> interface.
    /// </summary>
    public static class GetDocument
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:MyFormsApp_ILMerge.Documents.Interfaces.IDocument" /> interface,
        /// and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:MyFormsApp_ILMerge.Documents.Interfaces.IDocument" /> interface.
        /// </returns>
        public static IDocument SoleInstance()
            => Document.Instance;
    }
}
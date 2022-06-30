namespace MyFormsApp_ILMerge.Documents
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a document template
    /// object.
    /// </summary>
    public interface IDocTemplate
    {
        /// <summary>
        /// Opens the document having the specified <paramref name="path" />.
        /// </summary>
        /// <param name="path">
        /// (Required.) A <see cref="T:System.String" /> containing the fully-qualified
        /// pathname of the file you wish to open.
        /// </param>
        void OpenDocumentFile(string path);

        /// <summary>
        /// Sets the caption(s) of all views that are displaying documents of this type.
        /// </summary>
        void SetCaption();
    }
}
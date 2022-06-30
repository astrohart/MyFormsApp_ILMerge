using System;

namespace MyFormsApp_ILMerge.Documents
{
    /// <summary>
    /// Defines the behaviors of a document object.
    /// </summary>
    /// <remarks>
    /// Document objects manage the interaction between the application and
    /// the file system.
    /// </remarks>
    public class Document : IDocument
    {
        private string _fileContents;

        /// <summary>
        /// Initializes static instances of the
        /// <see cref="T:MyFormsApp_ILMerge.Documents.Document" /> class.
        /// </summary>
        /// <remarks>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </remarks>
        static Document() { }

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MyFormsApp_ILMerge.Documents.Document" /> and returns a reference
        /// to it.
        /// </summary>
        /// <remarks>
        /// This empty, protected constructor to prohibit direct allocation of this class.
        /// </remarks>
        protected Document() { }

        /// <summary>
        /// Gets a <see cref="T:System.Boolean" />  value that indicates whether this
        /// document has been modified.
        /// </summary>
        public bool Dirty { get; private set; }

        /// <summary>
        /// Gets or sets the contents of the file that is currently open.
        /// </summary>
        public string FileContents
        {
            get => _fileContents;
            set
            {
                var incomingData = value;
                SetDirty(!incomingData.Equals(_fileContents));
                _fileContents = incomingData;
            }
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of the file that is currently open.
        /// </summary>
        /// <remarks>
        /// If the value of this property is <see langword="null" /> or the empty
        /// string, then no document is loaded, or the user is working on a new document.
        /// </remarks>
        public string FileName { get; private set; }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MyFormsApp_ILMerge.Documents.Document" />.
        /// </summary>
        public static Document Instance { get; } = new Document();

        /// <summary>
        /// Occurs when the document's data has been updated.
        /// </summary>
        /// <remarks>
        /// This event serves to let the views of this document know that they
        /// need to update themselves to display the most recent data.
        /// </remarks>
        public event EventHandler DataUpdated;

        /// <summary>
        /// Occurs when the user attempts to open a file whose type this document object
        /// does not support.
        /// </summary>
        public event EventHandler FileTypeNotSupported;

        /// <summary>
        /// Specifies whether the document that is currently open may be closed.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the user can close the currently-open
        /// document; <see langword="false" /> otherwise.
        /// </returns>
        public bool CloseDocument()
            => throw new NotImplementedException();

        /// <summary>
        /// Determines whether the document object will open the file with the specified
        /// <paramref name="pathname" />.
        /// <para />
        /// It does this by matching the extension of the file whose
        /// <paramref name="pathname" /> is provided against a static value.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> containing the fully-qualified
        /// pathname of the file to be checked.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the type of file specified by the extension
        /// of <paramref name="pathname" /> is supported; <see langword="false" />
        /// otherwise.
        /// </returns>
        public bool IsFileTypeSupported(string pathname)
            => throw new NotImplementedException();

        /// <summary>
        /// Opens a document with the specified <paramref name="pathname" />.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> containing the fully-qualified
        /// pathname of the file to be opened.
        /// </param>
        /// <returns></returns>
        public bool OpenDocument(string pathname)
            => throw new NotImplementedException();

        /// <summary>
        /// Sets the value of the
        /// <see cref="P:MyFormsApp_ILMerge.Documents.IDocument.Dirty" /> property.
        /// </summary>
        /// <param name="dirty">
        /// (Optional.)  Default is <see langword="true" />.  Set to
        /// <see langword="true" /> to mark the document as dirty; <see langword="false" />
        /// otherwise.
        /// </param>
        public void SetDirty(bool dirty = true)
            => throw new NotImplementedException();

        /// <summary>
        /// Sets the value of the
        /// <see cref="P:MyFormsApp_ILMerge.Documents.IDocument.FileName" /> property.
        /// </summary>
        /// <param name="fileName">
        /// (Optional.) String containing the fully-qualified
        /// pathname of the document that is currently open.
        /// </param>
        /// <remarks>
        /// Set the value of the <paramref name="fileName" /> parameter to the
        /// blank string (the default) in order to mark this as a new document.
        /// </remarks>
        public void SetFileName(string fileName = "")
            => throw new NotImplementedException();

        /// <summary>
        /// Raises the
        /// <see cref="E:MyFormsApp_ILMerge.Documents.Document.FileTypeNotSupported" />
        /// event.
        /// </summary>
        protected virtual void OnFileTypeNotSupported()
            => FileTypeNotSupported?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the <see cref="E:MyFormsApp_ILMerge.Documents.Document.DataUpdated" />
        /// event.
        /// </summary>
        protected virtual void UpdateAllViews()
            => DataUpdated?.Invoke(this, EventArgs.Empty);
    }
}
using PostSharp.Patterns.Model;
using Alphaleonis.Win32.Filesystem;
using Core.Logging;
using Core.Logging.Constants;
using Core.Win32.Interact;
using MyFormsApp_ILMerge.Documents.Constants;
using MyFormsApp_ILMerge.Documents.Events;
using MyFormsApp_ILMerge.Documents.Interfaces;
using MyFormsApp_ILMerge.Models.Constants;
using MyFormsApp_ILMerge.Models.Factories;
using MyFormsApp_ILMerge.Models.Interfaces;
using System;
using System.Windows.Forms;

namespace MyFormsApp_ILMerge.Documents
{
    /// <summary> Defines the behaviors of a document object. </summary>
    /// <remarks>
    /// Document objects manage the interaction between the application and
    /// the file system.
    /// </remarks>
    public class Document : IDocument
    {
        /// <summary>
        /// One of the
        /// <see cref="T:MyFormsApp_ILMerge.Documents.Constants.DocumentState" />
        /// enumeration values that indicates the current state of the document.
        /// </summary>
        private DocumentState _currentState;

        /// <summary>
        /// Initializes static instances of the
        /// <see cref="T:MyFormsApp_ILMerge.Documents.Document" /> class.
        /// </summary>
        /// <remarks>
        /// Empty, static constructor to prohibit direct allocation of this
        /// class.
        /// </remarks>
        static Document() { }

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MyFormsApp_ILMerge.Documents.Document" /> and returns a reference
        /// to it.
        /// </summary>
        /// <remarks>
        /// This empty, protected constructor to prohibit direct allocation of
        /// this class.
        /// </remarks>
        protected Document()
            => SetDocumentState(
                DocumentState.Idle
            ); // start this object out in the Idle state

        /// <summary>
        /// Gets one of the
        /// <see cref="T:MyFormsApp_ILMerge.Documents.Constants.DocumentState" />
        /// enumeration values that explain what state the document object is in.
        /// </summary>
        public DocumentState CurrentState
        {
            get => _currentState;
            private set
            {
                var oldState = _currentState;

                _currentState = value;

                if (oldState == value)
                    return;

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** INFO: Document state changed from '{oldState}' to '{value}'."
                );
                OnDocumentStateChanged(
                    new DocumentStateChangedEventArgs(value, oldState)
                );
            }
        }

        /// <summary>
        /// Gets a <see cref="T:System.Boolean" />  value that indicates whether
        /// this document has been modified.
        /// </summary>
        public bool Dirty { get; private set; }

        /// <summary>
        /// Gets or sets a reference to an instance of an object that implements
        /// the <see cref="T:MyFormsApp_ILMerge.Documents.Interfaces.IDocTemplate" />
        /// interface and which plays the role of the document template that "owns" this
        /// document object.
        /// </summary>
        public IDocTemplate DocTemplate { get; set; }

        /// <summary> Gets or sets the contents of the file that is currently open. </summary>
        public string FileContents { get; private set; }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains the
        /// fully-qualified pathname of the file that is currently open.
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
        /// Gets a reference to an instance of the object that implements the
        /// <see cref="T:MyFormsApp_ILMerge.Models.Interfaces.ITextFileModel" /> interface.
        /// </summary>
        /// <remarks>This object is responsible for loading and saving the file's data.</remarks>
        private static ITextFileModel TextFileModel { get; } =
            GetFileModel.For<string>(FileType.Text) as ITextFileModel;

        /// <summary> Occurs when the document's data has been updated. </summary>
        /// <remarks>
        /// This event serves to let the views of this document know that they
        /// need to update themselves to display the most recent data.
        /// </remarks>
        [WeakEvent]
        public event EventHandler DataUpdated;

        /// <summary> Occurs when the state of the document changes. </summary>
        [WeakEvent]
        public event DocumentStateChangedEventHandler DocumentStateChanged;

        /// <summary>
        /// Occurs when the user attempts to open a file whose type this document
        /// object does not support.
        /// </summary>
        [WeakEvent]
        public event EventHandler FileTypeNotSupported;

        /// <summary> Specifies whether the document that is currently open may be closed. </summary>
        /// <remarks>
        /// <b>NOTE: </b>If we had Saving functionality enabled in this
        /// application, then this method would do more than simply return
        /// <see langword="true" />, as it does in its current implementation.
        /// <para />
        /// However, since we really mean for this application to demonstrate using
        /// <c>ILMerge</c>, we do not care about asking whether the user wants to save
        /// their modified changes before closing.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the user can close the currently-open
        /// document; <see langword="false" /> otherwise.
        /// </returns>
        public bool CloseDocument()
            => true;

        /// <summary>
        /// Determines whether the document object will open the file with the
        /// specified <paramref name="pathname" />.
        /// <para />
        /// It does this by matching the extension of the file whose
        /// <paramref name="pathname" /> is provided against a static value.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> containing
        /// the fully-qualified pathname of the file to be checked.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the type of file specified by the
        /// extension of <paramref name="pathname" /> is supported;
        /// <see langword="false" /> otherwise.
        /// </returns>
        public bool IsFileTypeSupported(string pathname)
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(pathname))
                    return result;
                if (!File.Exists(pathname)) return result;

                result = ".txt".Equals(Path.GetExtension(pathname));
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        // since this app does not have save functionality
        /// <summary> Opens a document with the specified <paramref name="pathname" />. </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> containing
        /// the fully-qualified pathname of the file to be opened.
        /// </param>
        /// <returns></returns>
        public bool OpenDocument(string pathname)
        {
            var result = false;

            // Read the data
            try
            {
                if (string.IsNullOrWhiteSpace(pathname)) return result;
                if (!File.Exists(pathname)) return result;

                // Check if we can close the current file
                if (!CloseDocument()) return result;

                // Check whether this is a type of file that we support
                if (!IsFileTypeSupported(pathname))
                {
                    OnFileTypeNotSupported();
                    return result;
                }

                SetDocumentState(DocumentState.Opening);

                // Clear existing data
                FileContents = string.Empty;

                // Load the new data from the file with the specified pathname
                FileContents = TextFileModel.LoadFrom(pathname);

                // Check that the Open operation succeeded. It could be a zero-length
                // file, so make sure to test for that as well as whether the FileContents
                // property has a non-blank value.
                result = new FileInfo(pathname).Length == 0 ||
                         !string.IsNullOrEmpty(FileContents);

                if (result)
                {
                    SetDocumentState(DocumentState.Opened);
                    UpdateAllViews();
                }
            }
            catch (Exception ex)
            {
                Messages.ShowStopError(ex.Message);

                MessageBox.Show(
                    ex.Message, Application.ProductName, MessageBoxButtons.OK,
                    MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1
                );

                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            // Updating the value of the FileContents property above
            // has the effect of setting the Dirty flag to true and
            // updating all the views.

            // For a newly-opened document, it's not dirty, so set the
            // value to false instead.  But do this ONLY if the Open
            // operation actually worked!

            if (!result) return result;

            SetDirty(false);
            SetFileName(pathname);

            return result;
        }

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
        {
            Dirty = dirty;
            DocTemplate.SetCaption();
        }

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
        {
            FileName = fileName;
            DocTemplate.SetCaption();
        }

        /// <summary>
        /// Raises the
        /// <see cref="E:MyFormsApp_ILMerge.Documents.Document.DocumentStateChanged" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see cref="T:MyFormsApp_ILMerge.Documents.Events.DocumentStateChangedEventArgs" />
        /// that corresponds to what the old and new states of the document object are.
        /// </param>
        protected virtual void OnDocumentStateChanged(
            DocumentStateChangedEventArgs e
        )
            => DocumentStateChanged?.Invoke(this, e);

        /// <summary>
        /// Raises the
        /// <see cref="E:MyFormsApp_ILMerge.Documents.Document.FileTypeNotSupported" />
        /// event.
        /// </summary>
        protected virtual void OnFileTypeNotSupported()
            => FileTypeNotSupported?.Invoke(this, EventArgs.Empty);

        /// <summary> Sets the new state of the document object. </summary>
        /// <param name="newState">
        /// (Required.) A
        /// <see cref="T:MyFormsApp_ILMerge.Documents.Constants.DocumentState" />
        /// enumeration value that corresponds to what the new state of the document object
        /// should be.
        /// </param>
        protected void SetDocumentState(DocumentState newState)
        {
            CurrentState = newState;

            return;
        }

        /// <summary>
        /// Raises the
        /// <see cref="E:MyFormsApp_ILMerge.Documents.Document.DataUpdated" /> event.
        /// </summary>
        protected virtual void UpdateAllViews()
            => DataUpdated?.Invoke(this, EventArgs.Empty);
    }
}

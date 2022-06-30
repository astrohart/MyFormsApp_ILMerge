using MyFormsApp_ILMerge.Documents.Constants;
using MyFormsApp_ILMerge.Documents.Events;
using System;

namespace MyFormsApp_ILMerge.Documents
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a document object.
    /// </summary>
    /// <remarks>
    /// A document object serves to manage the exchange of data between a file
    /// on the disk and a view that displays the data.
    /// <para />
    /// Shoutout to Chris Sells, and his book, "Windows Forms 2.0 Programming," for
    /// inspiring the design of this interface.
    /// </remarks>
    public interface IDocument
    {
        /// <summary>
        /// Gets a <see cref="T:System.Boolean" />  value that indicates whether this
        /// document has been modified.
        /// </summary>
        bool Dirty { get; }

        /// <summary>
        /// Gets or sets the contents of the file that is currently open.
        /// </summary>
        string FileContents { get; set; }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of the file that is currently open.
        /// </summary>
        /// <remarks>
        /// If the value of this property is <see langword="null" /> or the empty
        /// string, then no document is loaded, or the user is working on a new document.
        /// </remarks>
        string FileName { get; }

        /// <summary>
        /// Gets one of the
        /// <see cref="T:MyFormsApp_ILMerge.Documents.Constants.DocumentState" />
        /// enumeration values that explain what state the document object is in.
        /// </summary>
        DocumentState CurrentState { get; }

        /// <summary>
        /// Occurs when the document's data has been updated.
        /// </summary>
        /// <remarks>
        /// This event serves to let the views of this document know that they
        /// need to update themselves to display the most recent data.
        /// </remarks>
        event EventHandler DataUpdated;

        /// <summary>
        /// Occurs when the user attempts to open a file whose type this document object
        /// does not support.
        /// </summary>
        event EventHandler FileTypeNotSupported;

        /// <summary>
        /// Specifies whether the document that is currently open may be closed.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the user can close the currently-open
        /// document; <see langword="false" /> otherwise.
        /// </returns>
        bool CloseDocument();

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
        bool IsFileTypeSupported(string pathname);

        /// <summary>
        /// Opens a document with the specified <paramref name="pathname" />.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> containing the fully-qualified
        /// pathname of the file to be opened.
        /// </param>
        /// <returns></returns>
        bool OpenDocument(string pathname);

        /// <summary>
        /// Sets the value of the
        /// <see cref="P:MyFormsApp_ILMerge.Documents.IDocument.Dirty" /> property.
        /// </summary>
        /// <param name="dirty">
        /// (Optional.)  Default is <see langword="true" />.  Set to
        /// <see langword="true" /> to mark the document as dirty; <see langword="false" />
        /// otherwise.
        /// </param>
        void SetDirty(bool dirty = true);

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
        void SetFileName(string fileName = "");

        /// <summary>
        /// Occurs when the state of the document changes.
        /// </summary>
        event DocumentStateChangedEventHandler DocumentStateChanged;
    }
}
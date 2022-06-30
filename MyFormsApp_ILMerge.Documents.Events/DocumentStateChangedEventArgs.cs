using MyFormsApp_ILMerge.Documents.Constants;
using System;

namespace MyFormsApp_ILMerge.Documents.Events
{
    /// <summary>
    /// Provides information for DocumentStateChanged event handlers.
    /// </summary>
    public class DocumentStateChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MyFormsApp_ILMerge.Documents.Events.DocumentStateChangedEventArgs" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="newState">
        /// (Required.) The
        /// <see cref="T:MyFormsApp_ILMerge.Documents.Constants.DocumentState" />
        /// enumeration value that explains what the new state of the document object is.
        /// </param>
        /// <param name="oldState">
        /// (Required.) The
        /// <see cref="T:MyFormsApp_ILMerge.Documents.Constants.DocumentState" />
        /// enumeration value that explains what the old state of the document object is.
        /// </param>
        public DocumentStateChangedEventArgs(DocumentState newState,
            DocumentState oldState)
        {
            NewState = newState;
            OldState = oldState;
        }

        /// <summary>
        /// Gets the <see cref="T:MyFormsApp_ILMerge.Documents.Constants.DocumentState" />
        /// enumeration value that explains what the new state of the document object is.
        /// </summary>
        public DocumentState NewState { get; }

        /// <summary>
        /// Gets the <see cref="T:MyFormsApp_ILMerge.Documents.Constants.DocumentState" />
        /// enumeration value that explains what state the document object used to be in.
        /// </summary>
        public DocumentState OldState { get; }
    }
}
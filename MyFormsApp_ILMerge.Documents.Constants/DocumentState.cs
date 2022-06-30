namespace MyFormsApp_ILMerge.Documents.Constants
{
    /// <summary>
    /// Values that explain what state a document object is in.
    /// </summary>
    public enum DocumentState
    {
        /// <summary>
        /// The document is in the process of opening a file.
        /// </summary>
        Opening,

        /// <summary>
        /// The document has completed the task of opening a file.
        /// </summary>
        Opened,

        /// <summary>
        /// The document object is not currently carrying out any tasks.
        /// </summary>
        Idle,

        /// <summary>
        /// The document is in an unknown state.
        /// </summary>
        Unknown = -1
    }
}
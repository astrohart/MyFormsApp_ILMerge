namespace MyFormsApp_ILMerge.Documents.Events
{
///  <summary> Represents a handler for a <c>DocumentStateChanged</c> event. </summary> <param name="sender"> Reference to the instance of the object that raised the event. </param> <param name="e"> A <see cref="T:MyFormsApp_ILMerge.Documents.Events.DocumentStateChangedEventArgs" /> that contains the event data. </param> <remarks> This delegate merely specifies the signature of all methods that handle the <c>DocumentStateChanged</c> event. </remarks>
    public delegate void DocumentStateChangedEventHandler(object sender,
        DocumentStateChangedEventArgs e);
}

<a name='assembly'></a>
# MyFormsApp_ILMerge.Documents

## Contents

- [Document](#T-MyFormsApp_ILMerge-Documents-Document 'MyFormsApp_ILMerge.Documents.Document')
  - [#ctor()](#M-MyFormsApp_ILMerge-Documents-Document-#ctor 'MyFormsApp_ILMerge.Documents.Document.#ctor')
  - [CurrentState](#P-MyFormsApp_ILMerge-Documents-Document-CurrentState 'MyFormsApp_ILMerge.Documents.Document.CurrentState')
  - [Dirty](#P-MyFormsApp_ILMerge-Documents-Document-Dirty 'MyFormsApp_ILMerge.Documents.Document.Dirty')
  - [DocTemplate](#P-MyFormsApp_ILMerge-Documents-Document-DocTemplate 'MyFormsApp_ILMerge.Documents.Document.DocTemplate')
  - [FileContents](#P-MyFormsApp_ILMerge-Documents-Document-FileContents 'MyFormsApp_ILMerge.Documents.Document.FileContents')
  - [FileName](#P-MyFormsApp_ILMerge-Documents-Document-FileName 'MyFormsApp_ILMerge.Documents.Document.FileName')
  - [Instance](#P-MyFormsApp_ILMerge-Documents-Document-Instance 'MyFormsApp_ILMerge.Documents.Document.Instance')
  - [TextFileModel](#P-MyFormsApp_ILMerge-Documents-Document-TextFileModel 'MyFormsApp_ILMerge.Documents.Document.TextFileModel')
  - [#cctor()](#M-MyFormsApp_ILMerge-Documents-Document-#cctor 'MyFormsApp_ILMerge.Documents.Document.#cctor')
  - [CloseDocument()](#M-MyFormsApp_ILMerge-Documents-Document-CloseDocument 'MyFormsApp_ILMerge.Documents.Document.CloseDocument')
  - [IsFileTypeSupported(pathname)](#M-MyFormsApp_ILMerge-Documents-Document-IsFileTypeSupported-System-String- 'MyFormsApp_ILMerge.Documents.Document.IsFileTypeSupported(System.String)')
  - [OnDocumentStateChanged(e)](#M-MyFormsApp_ILMerge-Documents-Document-OnDocumentStateChanged-MyFormsApp_ILMerge-Documents-Events-DocumentStateChangedEventArgs- 'MyFormsApp_ILMerge.Documents.Document.OnDocumentStateChanged(MyFormsApp_ILMerge.Documents.Events.DocumentStateChangedEventArgs)')
  - [OnFileTypeNotSupported()](#M-MyFormsApp_ILMerge-Documents-Document-OnFileTypeNotSupported 'MyFormsApp_ILMerge.Documents.Document.OnFileTypeNotSupported')
  - [OpenDocument(pathname)](#M-MyFormsApp_ILMerge-Documents-Document-OpenDocument-System-String- 'MyFormsApp_ILMerge.Documents.Document.OpenDocument(System.String)')
  - [SetDirty(dirty)](#M-MyFormsApp_ILMerge-Documents-Document-SetDirty-System-Boolean- 'MyFormsApp_ILMerge.Documents.Document.SetDirty(System.Boolean)')
  - [SetDocumentState(newState)](#M-MyFormsApp_ILMerge-Documents-Document-SetDocumentState-MyFormsApp_ILMerge-Documents-Constants-DocumentState- 'MyFormsApp_ILMerge.Documents.Document.SetDocumentState(MyFormsApp_ILMerge.Documents.Constants.DocumentState)')
  - [SetFileName(fileName)](#M-MyFormsApp_ILMerge-Documents-Document-SetFileName-System-String- 'MyFormsApp_ILMerge.Documents.Document.SetFileName(System.String)')
  - [UpdateAllViews()](#M-MyFormsApp_ILMerge-Documents-Document-UpdateAllViews 'MyFormsApp_ILMerge.Documents.Document.UpdateAllViews')
- [Resources](#T-MyFormsApp_ILMerge-Documents-Properties-Resources 'MyFormsApp_ILMerge.Documents.Properties.Resources')
  - [Culture](#P-MyFormsApp_ILMerge-Documents-Properties-Resources-Culture 'MyFormsApp_ILMerge.Documents.Properties.Resources.Culture')
  - [ResourceManager](#P-MyFormsApp_ILMerge-Documents-Properties-Resources-ResourceManager 'MyFormsApp_ILMerge.Documents.Properties.Resources.ResourceManager')

<a name='T-MyFormsApp_ILMerge-Documents-Document'></a>
## Document `type`

##### Namespace

MyFormsApp_ILMerge.Documents

##### Summary

Defines the behaviors of a document object.

##### Remarks

Document objects manage the interaction between the application and
the file system.

<a name='M-MyFormsApp_ILMerge-Documents-Document-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[Document](#T-MyFormsApp_ILMerge-Documents-Document 'MyFormsApp_ILMerge.Documents.Document') and returns a reference
to it.

##### Parameters

This constructor has no parameters.

##### Remarks

This empty, protected constructor to prohibit direct allocation of
this class.

<a name='P-MyFormsApp_ILMerge-Documents-Document-CurrentState'></a>
### CurrentState `property`

##### Summary

Gets one of the
[DocumentState](#T-MyFormsApp_ILMerge-Documents-Constants-DocumentState 'MyFormsApp_ILMerge.Documents.Constants.DocumentState')
enumeration values that explain what state the document object is in.

<a name='P-MyFormsApp_ILMerge-Documents-Document-Dirty'></a>
### Dirty `property`

##### Summary

Gets a [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') value that indicates whether
this document has been modified.

<a name='P-MyFormsApp_ILMerge-Documents-Document-DocTemplate'></a>
### DocTemplate `property`

##### Summary

Gets or sets a reference to an instance of an object that implements
the [IDocTemplate](#T-MyFormsApp_ILMerge-Documents-Interfaces-IDocTemplate 'MyFormsApp_ILMerge.Documents.Interfaces.IDocTemplate')
interface and which plays the role of the document template that "owns" this
document object.

<a name='P-MyFormsApp_ILMerge-Documents-Document-FileContents'></a>
### FileContents `property`

##### Summary

Gets or sets the contents of the file that is currently open.

<a name='P-MyFormsApp_ILMerge-Documents-Document-FileName'></a>
### FileName `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the
fully-qualified pathname of the file that is currently open.

##### Remarks

If the value of this property is `null` or the empty
string, then no document is loaded, or the user is working on a new document.

<a name='P-MyFormsApp_ILMerge-Documents-Document-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[Document](#T-MyFormsApp_ILMerge-Documents-Document 'MyFormsApp_ILMerge.Documents.Document').

<a name='P-MyFormsApp_ILMerge-Documents-Document-TextFileModel'></a>
### TextFileModel `property`

##### Summary

Gets a reference to an instance of the object that implements the
[ITextFileModel](#T-MyFormsApp_ILMerge-Models-Interfaces-ITextFileModel 'MyFormsApp_ILMerge.Models.Interfaces.ITextFileModel') interface.

##### Remarks

This object is responsible for loading and saving the file's data.

<a name='M-MyFormsApp_ILMerge-Documents-Document-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static instances of the
[Document](#T-MyFormsApp_ILMerge-Documents-Document 'MyFormsApp_ILMerge.Documents.Document') class.

##### Parameters

This method has no parameters.

##### Remarks

Empty, static constructor to prohibit direct allocation of this
class.

<a name='M-MyFormsApp_ILMerge-Documents-Document-CloseDocument'></a>
### CloseDocument() `method`

##### Summary

Specifies whether the document that is currently open may be closed.

##### Returns

`true` if the user can close the currently-open
document; `false` otherwise.

##### Parameters

This method has no parameters.

<a name='M-MyFormsApp_ILMerge-Documents-Document-IsFileTypeSupported-System-String-'></a>
### IsFileTypeSupported(pathname) `method`

##### Summary

Determines whether the document object will open the file with the
specified `pathname`.



It does this by matching the extension of the file whose
`pathname` is provided against a static value.

##### Returns

`true` if the type of file specified by the
extension of `pathname` is supported;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing
the fully-qualified pathname of the file to be checked. |

<a name='M-MyFormsApp_ILMerge-Documents-Document-OnDocumentStateChanged-MyFormsApp_ILMerge-Documents-Events-DocumentStateChangedEventArgs-'></a>
### OnDocumentStateChanged(e) `method`

##### Summary

Raises the
[](#E-MyFormsApp_ILMerge-Documents-Document-DocumentStateChanged 'MyFormsApp_ILMerge.Documents.Document.DocumentStateChanged')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MyFormsApp_ILMerge.Documents.Events.DocumentStateChangedEventArgs](#T-MyFormsApp_ILMerge-Documents-Events-DocumentStateChangedEventArgs 'MyFormsApp_ILMerge.Documents.Events.DocumentStateChangedEventArgs') | A
[DocumentStateChangedEventArgs](#T-MyFormsApp_ILMerge-Documents-Events-DocumentStateChangedEventArgs 'MyFormsApp_ILMerge.Documents.Events.DocumentStateChangedEventArgs')
that corresponds to what the old and new states of the document object are. |

<a name='M-MyFormsApp_ILMerge-Documents-Document-OnFileTypeNotSupported'></a>
### OnFileTypeNotSupported() `method`

##### Summary

Raises the
[](#E-MyFormsApp_ILMerge-Documents-Document-FileTypeNotSupported 'MyFormsApp_ILMerge.Documents.Document.FileTypeNotSupported')
event.

##### Parameters

This method has no parameters.

<a name='M-MyFormsApp_ILMerge-Documents-Document-OpenDocument-System-String-'></a>
### OpenDocument(pathname) `method`

##### Summary

Opens a document with the specified `pathname`.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing
the fully-qualified pathname of the file to be opened. |

<a name='M-MyFormsApp_ILMerge-Documents-Document-SetDirty-System-Boolean-'></a>
### SetDirty(dirty) `method`

##### Summary

Sets the value of the
[Dirty](#P-MyFormsApp_ILMerge-Documents-IDocument-Dirty 'MyFormsApp_ILMerge.Documents.IDocument.Dirty') property.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dirty | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Optional.)  Default is `true`.  Set to
`true` to mark the document as dirty; `false`
otherwise. |

<a name='M-MyFormsApp_ILMerge-Documents-Document-SetDocumentState-MyFormsApp_ILMerge-Documents-Constants-DocumentState-'></a>
### SetDocumentState(newState) `method`

##### Summary

Sets the new state of the document object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| newState | [MyFormsApp_ILMerge.Documents.Constants.DocumentState](#T-MyFormsApp_ILMerge-Documents-Constants-DocumentState 'MyFormsApp_ILMerge.Documents.Constants.DocumentState') | (Required.) A
[DocumentState](#T-MyFormsApp_ILMerge-Documents-Constants-DocumentState 'MyFormsApp_ILMerge.Documents.Constants.DocumentState')
enumeration value that corresponds to what the new state of the document object
should be. |

<a name='M-MyFormsApp_ILMerge-Documents-Document-SetFileName-System-String-'></a>
### SetFileName(fileName) `method`

##### Summary

Sets the value of the
[FileName](#P-MyFormsApp_ILMerge-Documents-IDocument-FileName 'MyFormsApp_ILMerge.Documents.IDocument.FileName') property.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) String containing the fully-qualified
pathname of the document that is currently open. |

##### Remarks

Set the value of the `fileName` parameter to the
blank string (the default) in order to mark this as a new document.

<a name='M-MyFormsApp_ILMerge-Documents-Document-UpdateAllViews'></a>
### UpdateAllViews() `method`

##### Summary

Raises the
[](#E-MyFormsApp_ILMerge-Documents-Document-DataUpdated 'MyFormsApp_ILMerge.Documents.Document.DataUpdated') event.

##### Parameters

This method has no parameters.

<a name='T-MyFormsApp_ILMerge-Documents-Properties-Resources'></a>
## Resources `type`

##### Namespace

MyFormsApp_ILMerge.Documents.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MyFormsApp_ILMerge-Documents-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all resource lookups using this strongly typed resource class.

<a name='P-MyFormsApp_ILMerge-Documents-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

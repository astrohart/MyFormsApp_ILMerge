<a name='assembly'></a>
# MyFormsApp_ILMerge.Documents.Interfaces

## Contents

- [IDocTemplate](#T-MyFormsApp_ILMerge-Documents-Interfaces-IDocTemplate 'MyFormsApp_ILMerge.Documents.Interfaces.IDocTemplate')
  - [OpenDocumentFile(path)](#M-MyFormsApp_ILMerge-Documents-Interfaces-IDocTemplate-OpenDocumentFile-System-String- 'MyFormsApp_ILMerge.Documents.Interfaces.IDocTemplate.OpenDocumentFile(System.String)')
  - [SetCaption()](#M-MyFormsApp_ILMerge-Documents-Interfaces-IDocTemplate-SetCaption 'MyFormsApp_ILMerge.Documents.Interfaces.IDocTemplate.SetCaption')
- [IDocument](#T-MyFormsApp_ILMerge-Documents-Interfaces-IDocument 'MyFormsApp_ILMerge.Documents.Interfaces.IDocument')
  - [CurrentState](#P-MyFormsApp_ILMerge-Documents-Interfaces-IDocument-CurrentState 'MyFormsApp_ILMerge.Documents.Interfaces.IDocument.CurrentState')
  - [Dirty](#P-MyFormsApp_ILMerge-Documents-Interfaces-IDocument-Dirty 'MyFormsApp_ILMerge.Documents.Interfaces.IDocument.Dirty')
  - [DocTemplate](#P-MyFormsApp_ILMerge-Documents-Interfaces-IDocument-DocTemplate 'MyFormsApp_ILMerge.Documents.Interfaces.IDocument.DocTemplate')
  - [FileContents](#P-MyFormsApp_ILMerge-Documents-Interfaces-IDocument-FileContents 'MyFormsApp_ILMerge.Documents.Interfaces.IDocument.FileContents')
  - [FileName](#P-MyFormsApp_ILMerge-Documents-Interfaces-IDocument-FileName 'MyFormsApp_ILMerge.Documents.Interfaces.IDocument.FileName')
  - [CloseDocument()](#M-MyFormsApp_ILMerge-Documents-Interfaces-IDocument-CloseDocument 'MyFormsApp_ILMerge.Documents.Interfaces.IDocument.CloseDocument')
  - [IsFileTypeSupported(pathname)](#M-MyFormsApp_ILMerge-Documents-Interfaces-IDocument-IsFileTypeSupported-System-String- 'MyFormsApp_ILMerge.Documents.Interfaces.IDocument.IsFileTypeSupported(System.String)')
  - [OpenDocument(pathname)](#M-MyFormsApp_ILMerge-Documents-Interfaces-IDocument-OpenDocument-System-String- 'MyFormsApp_ILMerge.Documents.Interfaces.IDocument.OpenDocument(System.String)')
  - [SetDirty(dirty)](#M-MyFormsApp_ILMerge-Documents-Interfaces-IDocument-SetDirty-System-Boolean- 'MyFormsApp_ILMerge.Documents.Interfaces.IDocument.SetDirty(System.Boolean)')
  - [SetFileName(fileName)](#M-MyFormsApp_ILMerge-Documents-Interfaces-IDocument-SetFileName-System-String- 'MyFormsApp_ILMerge.Documents.Interfaces.IDocument.SetFileName(System.String)')
- [Resources](#T-MyFormsApp_ILMerge-Documents-Interfaces-Properties-Resources 'MyFormsApp_ILMerge.Documents.Interfaces.Properties.Resources')
  - [Culture](#P-MyFormsApp_ILMerge-Documents-Interfaces-Properties-Resources-Culture 'MyFormsApp_ILMerge.Documents.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MyFormsApp_ILMerge-Documents-Interfaces-Properties-Resources-ResourceManager 'MyFormsApp_ILMerge.Documents.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MyFormsApp_ILMerge-Documents-Interfaces-IDocTemplate'></a>
## IDocTemplate `type`

##### Namespace

MyFormsApp_ILMerge.Documents.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a document template
object.

##### Remarks

Shoutout to Chris Sells, and his book, "Windows Forms 2.0 Programming," for
inspiring the design of this interface.

<a name='M-MyFormsApp_ILMerge-Documents-Interfaces-IDocTemplate-OpenDocumentFile-System-String-'></a>
### OpenDocumentFile(path) `method`

##### Summary

Opens the document having the specified `path`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the fully-qualified
pathname of the file you wish to open. |

<a name='M-MyFormsApp_ILMerge-Documents-Interfaces-IDocTemplate-SetCaption'></a>
### SetCaption() `method`

##### Summary

Sets the caption(s) of all views that are displaying documents of this type.

##### Parameters

This method has no parameters.

<a name='T-MyFormsApp_ILMerge-Documents-Interfaces-IDocument'></a>
## IDocument `type`

##### Namespace

MyFormsApp_ILMerge.Documents.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a document object.

##### Remarks

A document object serves to manage the exchange of data between a file
on the disk and a view that displays the data.



Shoutout to Chris Sells, and his book, "Windows Forms 2.0 Programming," for
inspiring the design of this interface.

<a name='P-MyFormsApp_ILMerge-Documents-Interfaces-IDocument-CurrentState'></a>
### CurrentState `property`

##### Summary

Gets one of the
[DocumentState](#T-MyFormsApp_ILMerge-Documents-Constants-DocumentState 'MyFormsApp_ILMerge.Documents.Constants.DocumentState')
enumeration values that explain what state the document object is in.

<a name='P-MyFormsApp_ILMerge-Documents-Interfaces-IDocument-Dirty'></a>
### Dirty `property`

##### Summary

Gets a [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') value that indicates whether this
document has been modified.

<a name='P-MyFormsApp_ILMerge-Documents-Interfaces-IDocument-DocTemplate'></a>
### DocTemplate `property`

##### Summary

Gets or sets a reference to an instance of an object that implements the
[IDocTemplate](#T-MyFormsApp_ILMerge-Documents-Interfaces-IDocTemplate 'MyFormsApp_ILMerge.Documents.Interfaces.IDocTemplate') interface
and which plays the role of the document template that "owns" this document
object.

<a name='P-MyFormsApp_ILMerge-Documents-Interfaces-IDocument-FileContents'></a>
### FileContents `property`

##### Summary

Gets or sets the contents of the file that is currently open.

<a name='P-MyFormsApp_ILMerge-Documents-Interfaces-IDocument-FileName'></a>
### FileName `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the file that is currently open.

##### Remarks

If the value of this property is `null` or the empty
string, then no document is loaded, or the user is working on a new document.

<a name='M-MyFormsApp_ILMerge-Documents-Interfaces-IDocument-CloseDocument'></a>
### CloseDocument() `method`

##### Summary

Specifies whether the document that is currently open may be closed.

##### Returns

`true` if the user can close the currently-open
document; `false` otherwise.

##### Parameters

This method has no parameters.

<a name='M-MyFormsApp_ILMerge-Documents-Interfaces-IDocument-IsFileTypeSupported-System-String-'></a>
### IsFileTypeSupported(pathname) `method`

##### Summary

Determines whether the document object will open the file with the specified
`pathname`.



It does this by matching the extension of the file whose
`pathname` is provided against a static value.

##### Returns

`true` if the type of file specified by the extension
of `pathname` is supported; `false`
otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the fully-qualified
pathname of the file to be checked. |

<a name='M-MyFormsApp_ILMerge-Documents-Interfaces-IDocument-OpenDocument-System-String-'></a>
### OpenDocument(pathname) `method`

##### Summary

Opens a document with the specified `pathname`.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the fully-qualified
pathname of the file to be opened. |

<a name='M-MyFormsApp_ILMerge-Documents-Interfaces-IDocument-SetDirty-System-Boolean-'></a>
### SetDirty(dirty) `method`

##### Summary

Sets the value of the
[Dirty](#P-MyFormsApp_ILMerge-Documents-Interfaces-IDocument-Dirty 'MyFormsApp_ILMerge.Documents.Interfaces.IDocument.Dirty')
property.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dirty | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Optional.)  Default is `true`.  Set to
`true` to mark the document as dirty; `false`
otherwise. |

<a name='M-MyFormsApp_ILMerge-Documents-Interfaces-IDocument-SetFileName-System-String-'></a>
### SetFileName(fileName) `method`

##### Summary

Sets the value of the
[FileName](#P-MyFormsApp_ILMerge-Documents-Interfaces-IDocument-FileName 'MyFormsApp_ILMerge.Documents.Interfaces.IDocument.FileName')
property.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) String containing the fully-qualified
pathname of the document that is currently open. |

##### Remarks

Set the value of the `fileName` parameter to the
blank string (the default) in order to mark this as a new document.

<a name='T-MyFormsApp_ILMerge-Documents-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MyFormsApp_ILMerge.Documents.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MyFormsApp_ILMerge-Documents-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MyFormsApp_ILMerge-Documents-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

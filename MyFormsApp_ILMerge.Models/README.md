<a name='assembly'></a>
# MyFormsApp_ILMerge.Models

## Contents

- [FileModelBase\`1](#T-MyFormsApp_ILMerge-Models-FileModelBase`1 'MyFormsApp_ILMerge.Models.FileModelBase`1')
  - [FileName](#P-MyFormsApp_ILMerge-Models-FileModelBase`1-FileName 'MyFormsApp_ILMerge.Models.FileModelBase`1.FileName')
  - [FileType](#P-MyFormsApp_ILMerge-Models-FileModelBase`1-FileType 'MyFormsApp_ILMerge.Models.FileModelBase`1.FileType')
  - [LoadFrom(pathname)](#M-MyFormsApp_ILMerge-Models-FileModelBase`1-LoadFrom-System-String- 'MyFormsApp_ILMerge.Models.FileModelBase`1.LoadFrom(System.String)')
- [Resources](#T-MyFormsApp_ILMerge-Models-Properties-Resources 'MyFormsApp_ILMerge.Models.Properties.Resources')
  - [Culture](#P-MyFormsApp_ILMerge-Models-Properties-Resources-Culture 'MyFormsApp_ILMerge.Models.Properties.Resources.Culture')
  - [ResourceManager](#P-MyFormsApp_ILMerge-Models-Properties-Resources-ResourceManager 'MyFormsApp_ILMerge.Models.Properties.Resources.ResourceManager')
- [TextFileModel](#T-MyFormsApp_ILMerge-Models-TextFileModel 'MyFormsApp_ILMerge.Models.TextFileModel')
  - [#ctor()](#M-MyFormsApp_ILMerge-Models-TextFileModel-#ctor 'MyFormsApp_ILMerge.Models.TextFileModel.#ctor')
  - [FileType](#P-MyFormsApp_ILMerge-Models-TextFileModel-FileType 'MyFormsApp_ILMerge.Models.TextFileModel.FileType')
  - [Instance](#P-MyFormsApp_ILMerge-Models-TextFileModel-Instance 'MyFormsApp_ILMerge.Models.TextFileModel.Instance')
  - [#cctor()](#M-MyFormsApp_ILMerge-Models-TextFileModel-#cctor 'MyFormsApp_ILMerge.Models.TextFileModel.#cctor')
  - [LoadFrom(pathname)](#M-MyFormsApp_ILMerge-Models-TextFileModel-LoadFrom-System-String- 'MyFormsApp_ILMerge.Models.TextFileModel.LoadFrom(System.String)')

<a name='T-MyFormsApp_ILMerge-Models-FileModelBase`1'></a>
## FileModelBase\`1 `type`

##### Namespace

MyFormsApp_ILMerge.Models

##### Summary

Defines the events, methods, properties, and behaviors for all models
of files of any type.

<a name='P-MyFormsApp_ILMerge-Models-FileModelBase`1-FileName'></a>
### FileName `property`

##### Summary

Gets or sets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the
fully-qualified pathname of the file.

##### Remarks

If the value of this property is `null` or the blank
string, then this means that a file is not currently loaded.

<a name='P-MyFormsApp_ILMerge-Models-FileModelBase`1-FileType'></a>
### FileType `property`

##### Summary

Gets a [FileType](#T-MyFormsApp_ILMerge-Models-Constants-FileType 'MyFormsApp_ILMerge.Models.Constants.FileType')
enumeration value that describes which type of file this object models.

<a name='M-MyFormsApp_ILMerge-Models-FileModelBase`1-LoadFrom-System-String-'></a>
### LoadFrom(pathname) `method`

##### Summary

Loads the data from the file on the disk with the specified pathname.

##### Returns

Reference to a `T` that represents the file's
data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing
the fully-qualified pathname of the file to be loaded. |

<a name='T-MyFormsApp_ILMerge-Models-Properties-Resources'></a>
## Resources `type`

##### Namespace

MyFormsApp_ILMerge.Models.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MyFormsApp_ILMerge-Models-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all resource lookups using this strongly typed resource class.

<a name='P-MyFormsApp_ILMerge-Models-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MyFormsApp_ILMerge-Models-TextFileModel'></a>
## TextFileModel `type`

##### Namespace

MyFormsApp_ILMerge.Models

##### Summary

Models the data from a text file.

<a name='M-MyFormsApp_ILMerge-Models-TextFileModel-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this
class.

##### Parameters

This constructor has no parameters.

<a name='P-MyFormsApp_ILMerge-Models-TextFileModel-FileType'></a>
### FileType `property`

##### Summary

Gets a [FileType](#T-MyFormsApp_ILMerge-Models-Constants-FileType 'MyFormsApp_ILMerge.Models.Constants.FileType')
enumeration value that describes which type of file this object models.

<a name='P-MyFormsApp_ILMerge-Models-TextFileModel-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that
implements the
[ITextFileModel](#T-MyFormsApp_ILMerge-Models-Interfaces-ITextFileModel 'MyFormsApp_ILMerge.Models.Interfaces.ITextFileModel') interface.

<a name='M-MyFormsApp_ILMerge-Models-TextFileModel-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this
class.

##### Parameters

This method has no parameters.

<a name='M-MyFormsApp_ILMerge-Models-TextFileModel-LoadFrom-System-String-'></a>
### LoadFrom(pathname) `method`

##### Summary

Loads the data from the file on the disk with the specified pathname.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the file's data, or
blank if either an issue occurred during the loading process, or if the file
does not exist at the specified `pathname`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing
the fully-qualified pathname of the file to be loaded. |

<a name='assembly'></a>
# MyFormsApp_ILMerge.Models.Interfaces

## Contents

- [IFileModel\`1](#T-MyFormsApp_ILMerge-Models-Interfaces-IFileModel`1 'MyFormsApp_ILMerge.Models.Interfaces.IFileModel`1')
  - [FileName](#P-MyFormsApp_ILMerge-Models-Interfaces-IFileModel`1-FileName 'MyFormsApp_ILMerge.Models.Interfaces.IFileModel`1.FileName')
  - [FileType](#P-MyFormsApp_ILMerge-Models-Interfaces-IFileModel`1-FileType 'MyFormsApp_ILMerge.Models.Interfaces.IFileModel`1.FileType')
  - [LoadFrom(pathname)](#M-MyFormsApp_ILMerge-Models-Interfaces-IFileModel`1-LoadFrom-System-String- 'MyFormsApp_ILMerge.Models.Interfaces.IFileModel`1.LoadFrom(System.String)')
- [ITextFileModel](#T-MyFormsApp_ILMerge-Models-Interfaces-ITextFileModel 'MyFormsApp_ILMerge.Models.Interfaces.ITextFileModel')
  - [FileType](#P-MyFormsApp_ILMerge-Models-Interfaces-ITextFileModel-FileType 'MyFormsApp_ILMerge.Models.Interfaces.ITextFileModel.FileType')
  - [LoadFrom(pathname)](#M-MyFormsApp_ILMerge-Models-Interfaces-ITextFileModel-LoadFrom-System-String- 'MyFormsApp_ILMerge.Models.Interfaces.ITextFileModel.LoadFrom(System.String)')
- [Resources](#T-MyFormsApp_ILMerge-Models-Interfaces-Properties-Resources 'MyFormsApp_ILMerge.Models.Interfaces.Properties.Resources')
  - [Culture](#P-MyFormsApp_ILMerge-Models-Interfaces-Properties-Resources-Culture 'MyFormsApp_ILMerge.Models.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MyFormsApp_ILMerge-Models-Interfaces-Properties-Resources-ResourceManager 'MyFormsApp_ILMerge.Models.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MyFormsApp_ILMerge-Models-Interfaces-IFileModel`1'></a>
## IFileModel\`1 `type`

##### Namespace

MyFormsApp_ILMerge.Models.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an object that
models a file on the disk.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Specifies the name of the class or primitive type that
encapsulates the file's data. |

##### Remarks

Right now, for the purposes of this ILMerge demo app, we only support
the loading of data from files on the disk, not the saving of the data.

<a name='P-MyFormsApp_ILMerge-Models-Interfaces-IFileModel`1-FileName'></a>
### FileName `property`

##### Summary

Gets or sets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the
fully-qualified pathname of the file.

##### Remarks

If the value of this property is `null` or the blank
string, then this means that a file is not currently loaded.

<a name='P-MyFormsApp_ILMerge-Models-Interfaces-IFileModel`1-FileType'></a>
### FileType `property`

##### Summary

Gets a [FileType](#T-MyFormsApp_ILMerge-Models-Constants-FileType 'MyFormsApp_ILMerge.Models.Constants.FileType')
enumeration value that describes which type of file this object models.

<a name='M-MyFormsApp_ILMerge-Models-Interfaces-IFileModel`1-LoadFrom-System-String-'></a>
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

<a name='T-MyFormsApp_ILMerge-Models-Interfaces-ITextFileModel'></a>
## ITextFileModel `type`

##### Namespace

MyFormsApp_ILMerge.Models.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of the model of a
text file.

<a name='P-MyFormsApp_ILMerge-Models-Interfaces-ITextFileModel-FileType'></a>
### FileType `property`

##### Summary

Gets a [FileType](#T-MyFormsApp_ILMerge-Models-Constants-FileType 'MyFormsApp_ILMerge.Models.Constants.FileType')
enumeration value that describes which type of file this object models.

<a name='M-MyFormsApp_ILMerge-Models-Interfaces-ITextFileModel-LoadFrom-System-String-'></a>
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

<a name='T-MyFormsApp_ILMerge-Models-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MyFormsApp_ILMerge.Models.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MyFormsApp_ILMerge-Models-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all resource lookups using this strongly typed resource class.

<a name='P-MyFormsApp_ILMerge-Models-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

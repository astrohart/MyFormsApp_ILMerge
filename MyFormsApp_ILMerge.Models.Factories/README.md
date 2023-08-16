<a name='assembly'></a>
# MyFormsApp_ILMerge.Models.Factories

## Contents

- [GetFileModel](#T-MyFormsApp_ILMerge-Models-Factories-GetFileModel 'MyFormsApp_ILMerge.Models.Factories.GetFileModel')
  - [For\`\`1(fileType)](#M-MyFormsApp_ILMerge-Models-Factories-GetFileModel-For``1-MyFormsApp_ILMerge-Models-Constants-FileType- 'MyFormsApp_ILMerge.Models.Factories.GetFileModel.For``1(MyFormsApp_ILMerge.Models.Constants.FileType)')
- [Resources](#T-MyFormsApp_ILMerge-Models-Factories-Properties-Resources 'MyFormsApp_ILMerge.Models.Factories.Properties.Resources')
  - [Culture](#P-MyFormsApp_ILMerge-Models-Factories-Properties-Resources-Culture 'MyFormsApp_ILMerge.Models.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MyFormsApp_ILMerge-Models-Factories-Properties-Resources-ResourceManager 'MyFormsApp_ILMerge.Models.Factories.Properties.Resources.ResourceManager')

<a name='T-MyFormsApp_ILMerge-Models-Factories-GetFileModel'></a>
## GetFileModel `type`

##### Namespace

MyFormsApp_ILMerge.Models.Factories

##### Summary

Obtains references to instances of objects that implement the
[IFileModel{T}](#T-MyFormsApp_ILMerge-Models-Interfaces-IFileModel{T} 'MyFormsApp_ILMerge.Models.Interfaces.IFileModel{T}') interface
that change depending on the strategy desired.

<a name='M-MyFormsApp_ILMerge-Models-Factories-GetFileModel-For``1-MyFormsApp_ILMerge-Models-Constants-FileType-'></a>
### For\`\`1(fileType) `method`

##### Summary

Obtains a reference to an instance of an object that implements the
[IFileModel{T}](#T-MyFormsApp_ILMerge-Models-Interfaces-IFileModel{T} 'MyFormsApp_ILMerge.Models.Interfaces.IFileModel{T}')
interface which corresponds to the specified meeting
`fileType`.

##### Returns

Reference to the instance of the object that implements the
[IFileModel{T}](#T-MyFormsApp_ILMerge-Models-Interfaces-IFileModel{T} 'MyFormsApp_ILMerge.Models.Interfaces.IFileModel{T}')
interface which corresponds to the specific enumeration value that is
specified for the argument of the `fileType` parameter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fileType | [MyFormsApp_ILMerge.Models.Constants.FileType](#T-MyFormsApp_ILMerge-Models-Constants-FileType 'MyFormsApp_ILMerge.Models.Constants.FileType') | (Required.) One of the
[FileType](#T-MyFormsApp_ILMerge-Models-Constants-FileType 'MyFormsApp_ILMerge.Models.Constants.FileType') enumeration
values that describes the type of file that is to be accessed. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Name of the class or primitive type that encapsulates the
file's data. |

##### Remarks

This method will throw an exception if there are no types implemented
that correspond to the enumeration value passed for the argument of the
`fileType` parameter.



If the specified `fileType` is not supported, then the method
returns `null`.

<a name='T-MyFormsApp_ILMerge-Models-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MyFormsApp_ILMerge.Models.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MyFormsApp_ILMerge-Models-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MyFormsApp_ILMerge-Models-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

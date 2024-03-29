<a name='assembly'></a>
# MyFormsApp_ILMerge

## Contents

- [Get](#T-MyFormsApp_ILMerge-Program-Get 'MyFormsApp_ILMerge.Program.Get')
  - [LOG_FILE_PATH_TERMINATOR](#F-MyFormsApp_ILMerge-Program-Get-LOG_FILE_PATH_TERMINATOR 'MyFormsApp_ILMerge.Program.Get.LOG_FILE_PATH_TERMINATOR')
  - [AssemblyCompany](#P-MyFormsApp_ILMerge-Program-Get-AssemblyCompany 'MyFormsApp_ILMerge.Program.Get.AssemblyCompany')
  - [AssemblyProduct](#P-MyFormsApp_ILMerge-Program-Get-AssemblyProduct 'MyFormsApp_ILMerge.Program.Get.AssemblyProduct')
  - [AssemblyTitle](#P-MyFormsApp_ILMerge-Program-Get-AssemblyTitle 'MyFormsApp_ILMerge.Program.Get.AssemblyTitle')
  - [ApplicationProductName()](#M-MyFormsApp_ILMerge-Program-Get-ApplicationProductName 'MyFormsApp_ILMerge.Program.Get.ApplicationProductName')
  - [LogFilePath()](#M-MyFormsApp_ILMerge-Program-Get-LogFilePath 'MyFormsApp_ILMerge.Program.Get.LogFilePath')
- [MainWindow](#T-MyFormsApp_ILMerge-MainWindow 'MyFormsApp_ILMerge.MainWindow')
  - [#ctor()](#M-MyFormsApp_ILMerge-MainWindow-#ctor 'MyFormsApp_ILMerge.MainWindow.#ctor')
  - [components](#F-MyFormsApp_ILMerge-MainWindow-components 'MyFormsApp_ILMerge.MainWindow.components')
  - [Document](#P-MyFormsApp_ILMerge-MainWindow-Document 'MyFormsApp_ILMerge.MainWindow.Document')
  - [Dispose(disposing)](#M-MyFormsApp_ILMerge-MainWindow-Dispose-System-Boolean- 'MyFormsApp_ILMerge.MainWindow.Dispose(System.Boolean)')
  - [InitializeComponent()](#M-MyFormsApp_ILMerge-MainWindow-InitializeComponent 'MyFormsApp_ILMerge.MainWindow.InitializeComponent')
  - [OnLoad(e)](#M-MyFormsApp_ILMerge-MainWindow-OnLoad-System-EventArgs- 'MyFormsApp_ILMerge.MainWindow.OnLoad(System.EventArgs)')
  - [OpenDocumentFile(path)](#M-MyFormsApp_ILMerge-MainWindow-OpenDocumentFile-System-String- 'MyFormsApp_ILMerge.MainWindow.OpenDocumentFile(System.String)')
  - [SetCaption()](#M-MyFormsApp_ILMerge-MainWindow-SetCaption 'MyFormsApp_ILMerge.MainWindow.SetCaption')
- [Program](#T-MyFormsApp_ILMerge-Program 'MyFormsApp_ILMerge.Program')
  - [Main()](#M-MyFormsApp_ILMerge-Program-Main 'MyFormsApp_ILMerge.Program.Main')
- [Resources](#T-MyFormsApp_ILMerge-Properties-Resources 'MyFormsApp_ILMerge.Properties.Resources')
  - [Culture](#P-MyFormsApp_ILMerge-Properties-Resources-Culture 'MyFormsApp_ILMerge.Properties.Resources.Culture')
  - [Error_CannotSetupLogging](#P-MyFormsApp_ILMerge-Properties-Resources-Error_CannotSetupLogging 'MyFormsApp_ILMerge.Properties.Resources.Error_CannotSetupLogging')
  - [Error_FileTypeNotSupported](#P-MyFormsApp_ILMerge-Properties-Resources-Error_FileTypeNotSupported 'MyFormsApp_ILMerge.Properties.Resources.Error_FileTypeNotSupported')
  - [ResourceManager](#P-MyFormsApp_ILMerge-Properties-Resources-ResourceManager 'MyFormsApp_ILMerge.Properties.Resources.ResourceManager')

<a name='T-MyFormsApp_ILMerge-Program-Get'></a>
## Get `type`

##### Namespace

MyFormsApp_ILMerge.Program

##### Summary

Exposes static methods to obtain data from various data sources.

<a name='F-MyFormsApp_ILMerge-Program-Get-LOG_FILE_PATH_TERMINATOR'></a>
### LOG_FILE_PATH_TERMINATOR `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the final piece of the path of the
log file.

<a name='P-MyFormsApp_ILMerge-Program-Get-AssemblyCompany'></a>
### AssemblyCompany `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the product name defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyCompany](#P-xyLOGIX-Core-Assemblies-Info-AssemblyMetadata-AssemblyCompany 'xyLOGIX.Core.Assemblies.Info.AssemblyMetadata.AssemblyCompany')
property.

<a name='P-MyFormsApp_ILMerge-Program-Get-AssemblyProduct'></a>
### AssemblyProduct `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the product name defined
for this application.

##### Remarks

This property is really an alias for the
[ShortProductName](#P-xyLOGIX-Core-Assemblies-Info-AssemblyMetadata-ShortProductName 'xyLOGIX.Core.Assemblies.Info.AssemblyMetadata.ShortProductName')
property.

<a name='P-MyFormsApp_ILMerge-Program-Get-AssemblyTitle'></a>
### AssemblyTitle `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the assembly title defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyTitle](#P-xyLOGIX-Core-Assemblies-Info-AssemblyMetadata-AssemblyTitle 'xyLOGIX.Core.Assemblies.Info.AssemblyMetadata.AssemblyTitle')
property --- except that all whitespace is replace with underscores.

<a name='M-MyFormsApp_ILMerge-Program-Get-ApplicationProductName'></a>
### ApplicationProductName() `method`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains a user-friendly name for
the software product of which this application or class library is a part.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains a user-friendly name for the
software product of which this application or class library is a part.

##### Parameters

This method has no parameters.

<a name='M-MyFormsApp_ILMerge-Program-Get-LogFilePath'></a>
### LogFilePath() `method`

##### Summary

Obtains a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the file that should be used for logging messages.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified pathname of
the file that should be used for logging messages.

##### Parameters

This method has no parameters.

<a name='T-MyFormsApp_ILMerge-MainWindow'></a>
## MainWindow `type`

##### Namespace

MyFormsApp_ILMerge

##### Summary

The main window of the application.

<a name='M-MyFormsApp_ILMerge-MainWindow-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[MainWindow](#T-MyFormsApp_ILMerge-MainWindow 'MyFormsApp_ILMerge.MainWindow') and returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='F-MyFormsApp_ILMerge-MainWindow-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='P-MyFormsApp_ILMerge-MainWindow-Document'></a>
### Document `property`

##### Summary

Gets a reference to the sole instance of an object that implements
the [IDocument](#T-MyFormsApp_ILMerge-Documents-Interfaces-IDocument 'MyFormsApp_ILMerge.Documents.Interfaces.IDocument')
interface.

<a name='M-MyFormsApp_ILMerge-MainWindow-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-MyFormsApp_ILMerge-MainWindow-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='M-MyFormsApp_ILMerge-MainWindow-OnLoad-System-EventArgs-'></a>
### OnLoad(e) `method`

##### Summary

Raises the [](#E-System-Windows-Forms-Form-Load 'System.Windows.Forms.Form.Load') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

<a name='M-MyFormsApp_ILMerge-MainWindow-OpenDocumentFile-System-String-'></a>
### OpenDocumentFile(path) `method`

##### Summary

Opens the document having the specified `path`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the
fully-qualified pathname of the file you wish to open. |

<a name='M-MyFormsApp_ILMerge-MainWindow-SetCaption'></a>
### SetCaption() `method`

##### Summary

Sets the caption(s) of all views that are displaying documents of
this type.

##### Parameters

This method has no parameters.

<a name='T-MyFormsApp_ILMerge-Program'></a>
## Program `type`

##### Namespace

MyFormsApp_ILMerge

##### Summary

Defines the behaviors of the application.

<a name='M-MyFormsApp_ILMerge-Program-Main'></a>
### Main() `method`

##### Summary

The main entry point for the application.

##### Parameters

This method has no parameters.

<a name='T-MyFormsApp_ILMerge-Properties-Resources'></a>
## Resources `type`

##### Namespace

MyFormsApp_ILMerge.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MyFormsApp_ILMerge-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MyFormsApp_ILMerge-Properties-Resources-Error_CannotSetupLogging'></a>
### Error_CannotSetupLogging `property`

##### Summary

Looks up a localized string similar to %APPNAME% failed to configure the infrastructure for producing a log file.

The application will now close..

<a name='P-MyFormsApp_ILMerge-Properties-Resources-Error_FileTypeNotSupported'></a>
### Error_FileTypeNotSupported `property`

##### Summary

Looks up a localized string similar to {0}
This file is not of a type supported by this application..

<a name='P-MyFormsApp_ILMerge-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

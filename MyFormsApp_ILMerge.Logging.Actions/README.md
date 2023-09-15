<a name='assembly'></a>
# MyFormsApp_ILMerge.Logging.Actions

## Contents

- [Get](#T-MyFormsApp_ILMerge-Logging-Actions-Get 'MyFormsApp_ILMerge.Logging.Actions.Get')
  - [LOG_FILE_PATH_TERMINATOR](#F-MyFormsApp_ILMerge-Logging-Actions-Get-LOG_FILE_PATH_TERMINATOR 'MyFormsApp_ILMerge.Logging.Actions.Get.LOG_FILE_PATH_TERMINATOR')
  - [AssemblyCompany](#P-MyFormsApp_ILMerge-Logging-Actions-Get-AssemblyCompany 'MyFormsApp_ILMerge.Logging.Actions.Get.AssemblyCompany')
  - [AssemblyProduct](#P-MyFormsApp_ILMerge-Logging-Actions-Get-AssemblyProduct 'MyFormsApp_ILMerge.Logging.Actions.Get.AssemblyProduct')
  - [AssemblyTitle](#P-MyFormsApp_ILMerge-Logging-Actions-Get-AssemblyTitle 'MyFormsApp_ILMerge.Logging.Actions.Get.AssemblyTitle')
  - [ApplicationProductName()](#M-MyFormsApp_ILMerge-Logging-Actions-Get-ApplicationProductName 'MyFormsApp_ILMerge.Logging.Actions.Get.ApplicationProductName')
  - [LogFilePath()](#M-MyFormsApp_ILMerge-Logging-Actions-Get-LogFilePath 'MyFormsApp_ILMerge.Logging.Actions.Get.LogFilePath')
- [Resources](#T-MyFormsApp_ILMerge-Logging-Actions-Properties-Resources 'MyFormsApp_ILMerge.Logging.Actions.Properties.Resources')
  - [Culture](#P-MyFormsApp_ILMerge-Logging-Actions-Properties-Resources-Culture 'MyFormsApp_ILMerge.Logging.Actions.Properties.Resources.Culture')
  - [ResourceManager](#P-MyFormsApp_ILMerge-Logging-Actions-Properties-Resources-ResourceManager 'MyFormsApp_ILMerge.Logging.Actions.Properties.Resources.ResourceManager')

<a name='T-MyFormsApp_ILMerge-Logging-Actions-Get'></a>
## Get `type`

##### Namespace

MyFormsApp_ILMerge.Logging.Actions

##### Summary

Exposes static methods to obtain data from various data sources.

<a name='F-MyFormsApp_ILMerge-Logging-Actions-Get-LOG_FILE_PATH_TERMINATOR'></a>
### LOG_FILE_PATH_TERMINATOR `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the final piece of the path of the
log file.

<a name='P-MyFormsApp_ILMerge-Logging-Actions-Get-AssemblyCompany'></a>
### AssemblyCompany `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the product name defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyCompany](#P-xyLOGIX-Core-Assemblies-Info-AssemblyMetadata-AssemblyCompany 'xyLOGIX.Core.Assemblies.Info.AssemblyMetadata.AssemblyCompany')
property.

<a name='P-MyFormsApp_ILMerge-Logging-Actions-Get-AssemblyProduct'></a>
### AssemblyProduct `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the product name defined
for this application.

##### Remarks

This property is really an alias for the
[ShortProductName](#P-xyLOGIX-Core-Assemblies-Info-AssemblyMetadata-ShortProductName 'xyLOGIX.Core.Assemblies.Info.AssemblyMetadata.ShortProductName')
property.

<a name='P-MyFormsApp_ILMerge-Logging-Actions-Get-AssemblyTitle'></a>
### AssemblyTitle `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the assembly title defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyTitle](#P-xyLOGIX-Core-Assemblies-Info-AssemblyMetadata-AssemblyTitle 'xyLOGIX.Core.Assemblies.Info.AssemblyMetadata.AssemblyTitle')
property --- except that all whitespace is replace with underscores.

<a name='M-MyFormsApp_ILMerge-Logging-Actions-Get-ApplicationProductName'></a>
### ApplicationProductName() `method`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains a user-friendly name for
the software product of which this application or class library is a part.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains a user-friendly name for the
software product of which this application or class library is a part.

##### Parameters

This method has no parameters.

<a name='M-MyFormsApp_ILMerge-Logging-Actions-Get-LogFilePath'></a>
### LogFilePath() `method`

##### Summary

Obtains a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the file that should be used for logging messages.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified pathname of
the file that should be used for logging messages.

##### Parameters

This method has no parameters.

<a name='T-MyFormsApp_ILMerge-Logging-Actions-Properties-Resources'></a>
## Resources `type`

##### Namespace

MyFormsApp_ILMerge.Logging.Actions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MyFormsApp_ILMerge-Logging-Actions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all resource lookups using this strongly typed resource class.

<a name='P-MyFormsApp_ILMerge-Logging-Actions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

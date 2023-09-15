<a name='assembly'></a>
# MyFormsApp_ILMerge.Documents.Events

## Contents

- [DocumentStateChangedEventArgs](#T-MyFormsApp_ILMerge-Documents-Events-DocumentStateChangedEventArgs 'MyFormsApp_ILMerge.Documents.Events.DocumentStateChangedEventArgs')
  - [#ctor(newState,oldState)](#M-MyFormsApp_ILMerge-Documents-Events-DocumentStateChangedEventArgs-#ctor-MyFormsApp_ILMerge-Documents-Constants-DocumentState,MyFormsApp_ILMerge-Documents-Constants-DocumentState- 'MyFormsApp_ILMerge.Documents.Events.DocumentStateChangedEventArgs.#ctor(MyFormsApp_ILMerge.Documents.Constants.DocumentState,MyFormsApp_ILMerge.Documents.Constants.DocumentState)')
  - [NewState](#P-MyFormsApp_ILMerge-Documents-Events-DocumentStateChangedEventArgs-NewState 'MyFormsApp_ILMerge.Documents.Events.DocumentStateChangedEventArgs.NewState')
  - [OldState](#P-MyFormsApp_ILMerge-Documents-Events-DocumentStateChangedEventArgs-OldState 'MyFormsApp_ILMerge.Documents.Events.DocumentStateChangedEventArgs.OldState')
- [DocumentStateChangedEventHandler](#T-MyFormsApp_ILMerge-Documents-Events-DocumentStateChangedEventHandler 'MyFormsApp_ILMerge.Documents.Events.DocumentStateChangedEventHandler')
- [Resources](#T-MyFormsApp_ILMerge-Documents-Events-Properties-Resources 'MyFormsApp_ILMerge.Documents.Events.Properties.Resources')
  - [Culture](#P-MyFormsApp_ILMerge-Documents-Events-Properties-Resources-Culture 'MyFormsApp_ILMerge.Documents.Events.Properties.Resources.Culture')
  - [ResourceManager](#P-MyFormsApp_ILMerge-Documents-Events-Properties-Resources-ResourceManager 'MyFormsApp_ILMerge.Documents.Events.Properties.Resources.ResourceManager')

<a name='T-MyFormsApp_ILMerge-Documents-Events-DocumentStateChangedEventArgs'></a>
## DocumentStateChangedEventArgs `type`

##### Namespace

MyFormsApp_ILMerge.Documents.Events

##### Summary

Provides information for DocumentStateChanged event handlers.

<a name='M-MyFormsApp_ILMerge-Documents-Events-DocumentStateChangedEventArgs-#ctor-MyFormsApp_ILMerge-Documents-Constants-DocumentState,MyFormsApp_ILMerge-Documents-Constants-DocumentState-'></a>
### #ctor(newState,oldState) `constructor`

##### Summary

Constructs a new instance of
[DocumentStateChangedEventArgs](#T-MyFormsApp_ILMerge-Documents-Events-DocumentStateChangedEventArgs 'MyFormsApp_ILMerge.Documents.Events.DocumentStateChangedEventArgs')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| newState | [MyFormsApp_ILMerge.Documents.Constants.DocumentState](#T-MyFormsApp_ILMerge-Documents-Constants-DocumentState 'MyFormsApp_ILMerge.Documents.Constants.DocumentState') | (Required.) The
[DocumentState](#T-MyFormsApp_ILMerge-Documents-Constants-DocumentState 'MyFormsApp_ILMerge.Documents.Constants.DocumentState')
enumeration value that corresponds to what the new state of the document object
is. |
| oldState | [MyFormsApp_ILMerge.Documents.Constants.DocumentState](#T-MyFormsApp_ILMerge-Documents-Constants-DocumentState 'MyFormsApp_ILMerge.Documents.Constants.DocumentState') | (Required.) The
[DocumentState](#T-MyFormsApp_ILMerge-Documents-Constants-DocumentState 'MyFormsApp_ILMerge.Documents.Constants.DocumentState')
enumeration value that corresponds to what the old state of the document object
is. |

<a name='P-MyFormsApp_ILMerge-Documents-Events-DocumentStateChangedEventArgs-NewState'></a>
### NewState `property`

##### Summary

Gets the
[DocumentState](#T-MyFormsApp_ILMerge-Documents-Constants-DocumentState 'MyFormsApp_ILMerge.Documents.Constants.DocumentState')
enumeration value that corresponds to what the new state of the document object
is.

<a name='P-MyFormsApp_ILMerge-Documents-Events-DocumentStateChangedEventArgs-OldState'></a>
### OldState `property`

##### Summary

Gets the
[DocumentState](#T-MyFormsApp_ILMerge-Documents-Constants-DocumentState 'MyFormsApp_ILMerge.Documents.Constants.DocumentState')
enumeration value that corresponds to what state the document object used to be
in.

<a name='T-MyFormsApp_ILMerge-Documents-Events-DocumentStateChangedEventHandler'></a>
## DocumentStateChangedEventHandler `type`

##### Namespace

MyFormsApp_ILMerge.Documents.Events

##### Summary

Represents a handler for a `DocumentStateChanged` event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MyFormsApp_ILMerge.Documents.Events.DocumentStateChangedEventHandler](#T-T-MyFormsApp_ILMerge-Documents-Events-DocumentStateChangedEventHandler 'T:MyFormsApp_ILMerge.Documents.Events.DocumentStateChangedEventHandler') | Reference to the instance of the object that raised the
event. |

##### Remarks

This delegate merely specifies the signature of all methods that
handle the `DocumentStateChanged` event.

<a name='T-MyFormsApp_ILMerge-Documents-Events-Properties-Resources'></a>
## Resources `type`

##### Namespace

MyFormsApp_ILMerge.Documents.Events.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MyFormsApp_ILMerge-Documents-Events-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all resource lookups using this strongly typed resource class.

<a name='P-MyFormsApp_ILMerge-Documents-Events-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

# IPluginExecutionContext

Defines the contextual information passed to a plug-in at run-time. Contains information that describes the run-time environment that the plug-in is executing in, information related to the execution pipeline, and entity business information.

## Namespace:   
```cs
Microsoft.Xrm.Sdk
```
## Assembly:
```cs
Microsoft.Xrm.Sdk (in Microsoft.Xrm.Sdk.dll)
```
## Synatx:
```cs
public interface IPluginExecutionContext : IExecutionContext
```

## Properties

### IExecutionContext.BusinessUnitId
Gets the GUID of the business unit that the user making the request, also known as the calling user, belongs to.

#### Synatx
```cs
Guid BusinessUnitId { get; }
```
#### Property Value
The GUID of the business unit. This property corresponds to the BusinessUnitId property, which is the primary key for the BusinessUnit entity.



### ExecutionContext.CorrelationId Property

Gets the GUID for tracking plug-in or custom workflow activity execution.

#### Syntax
```cs
Guid CorrelationId { get; }
```
#### Property Value
**Type:** System.Guid
The GUID for tracking plug-in or custom workflow activity execution.

#### Remarks
This property is used by the platform for infinite loop prevention. In most cases, this property can be ignored.



### IExecutionContext.Depth Property
Gets the current depth of execution in the call stack.

Syntax
```cs
int Depth { get; }
```
#### Property Value
Type: System.Int32
T the current depth of execution in the call stack.

#### Remarks
Used by the platform for infinite loop prevention. In most cases, this property can be ignored.

Every time a running plug-in or Workflow issues a message request to the Web services that triggers another plug-in or Workflow to execute, the Depth property of the execution context is increased. If the depth property increments to its maximum value within the configured time limit, the platform considers this behavior an infinite loop and further plug-in or Workflow execution is aborted.

The maximum depth (8) and time limit (one hour) are configurable by the Microsoft Dynamics 365 administrator using the PowerShell command Set-CrmSetting. The setting is WorkflowSettings.MaxDepth. For more information, see, “Administer the deployment using Windows PowerShell” in the Deploying and administering Microsoft Dynamics CRM.

### IExecutionContext.InitiatingUserId Property
11/28/2016
2 minutes to read
 

Applies To: Dynamics 365 (online), Dynamics 365 (on-premises), Dynamics CRM 2016, Dynamics CRM Online

Gets the GUID of the system user account under which the current pipeline is executing.

Namespace:   Microsoft.Xrm.Sdk
Assembly:  Microsoft.Xrm.Sdk (in Microsoft.Xrm.Sdk.dll)

Syntax
C#

Copy
Guid InitiatingUserId { get; }
Property Value
Type: System.Guid

Type: Guid
The GUID of the system user account under which the current pipeline is executing. This property corresponds to the SystemUserId property, which is the primary key for the SystemUser entity.

### IExecutionContext.InputParameters Property
11/28/2016
2 minutes to read
 

Applies To: Dynamics 365 (online), Dynamics 365 (on-premises), Dynamics CRM 2016, Dynamics CRM Online

Gets the parameters of the request message that triggered the event that caused the plug-in to execute.

Namespace:   Microsoft.Xrm.Sdk
Assembly:  Microsoft.Xrm.Sdk (in Microsoft.Xrm.Sdk.dll)

Syntax
C#

Copy
ParameterCollection InputParameters { get; }
Property Value
Type: Microsoft.Xrm.Sdk.ParameterCollection

Type: ParameterCollection
The parameters of the request message that triggered the event that caused the plug-in to execute.

### IExecutionContext.IsExecutingOffline Property
11/28/2016
2 minutes to read
 

Applies To: Dynamics 365 (online), Dynamics 365 (on-premises), Dynamics CRM 2016, Dynamics CRM Online

Gets whether the plug-in is executing from the Microsoft Dynamics 365 for Microsoft Office Outlook with Offline Access client while it is offline.

Namespace:   Microsoft.Xrm.Sdk
Assembly:  Microsoft.Xrm.Sdk (in Microsoft.Xrm.Sdk.dll)

Syntax
C#

Copy
bool IsExecutingOffline { get; }
Property Value
Type: System.Boolean

Type: Boolean
true if the plug-in is executing from the Microsoft Dynamics 365 for Microsoft Office Outlook with Offline Access client while it is offline; otherwise, false.

### IExecutionContext.IsInTransaction Property
11/28/2016
2 minutes to read
 

Applies To: Dynamics 365 (online), Dynamics 365 (on-premises), Dynamics CRM 2016, Dynamics CRM Online

Gets a value indicating if the plug-in is executing within the database transaction.

Namespace:   Microsoft.Xrm.Sdk
Assembly:  Microsoft.Xrm.Sdk (in Microsoft.Xrm.Sdk.dll)

Syntax
C#

Copy
bool IsInTransaction { get; }
Property Value
Type: System.Boolean

Type: Boolean
true if the plug-in is executing within the database transaction; otherwise, false.

### IExecutionContext.IsOfflinePlayback Property
11/28/2016
2 minutes to read
 

Applies To: Dynamics 365 (online), Dynamics 365 (on-premises), Dynamics CRM 2016, Dynamics CRM Online

Gets a value indicating if the plug-in is executing as a result of the Microsoft Dynamics 365 for Microsoft Office Outlook with Offline Access client transitioning from offline to online and synchronizing with the Microsoft Dynamics 365 server.

Namespace:   Microsoft.Xrm.Sdk
Assembly:  Microsoft.Xrm.Sdk (in Microsoft.Xrm.Sdk.dll)

Syntax
C#

Copy
bool IsOfflinePlayback { get; }
Property Value
Type: System.Boolean

Type: Boolean
true if the the plug-in is executing as a result of the Microsoft Dynamics 365 for Microsoft Office Outlook with Offline Access client transitioning from offline to online; otherwise, false.

### IExecutionContext.IsolationMode Property
11/28/2016
2 minutes to read
 

Applies To: Dynamics 365 (online), Dynamics 365 (on-premises), Dynamics CRM 2016, Dynamics CRM Online

Gets a value indicating if the plug-in is executing in the sandbox.

Namespace:   Microsoft.Xrm.Sdk
Assembly:  Microsoft.Xrm.Sdk (in Microsoft.Xrm.Sdk.dll)

Syntax
C#

Copy
int IsolationMode { get; }
Property Value
Type: System.Int32

Type: Int32
Indicates if the plug-in is executing in the sandbox.

Remarks
Allowable values are defined in the PluginAssemblyIsolationMode enumeration defined in SampleCode\CS\HelperCode\OptionSets.cs and SampleCode\VB\HelperCode\OptionSets.vb of the SDK download.

### IExecutionContext.MessageName Property
11/28/2016
2 minutes to read
 

Applies To: Dynamics 365 (online), Dynamics 365 (on-premises), Dynamics CRM 2016, Dynamics CRM Online

Gets the name of the Web service message that is being processed by the event execution pipeline.

Namespace:   Microsoft.Xrm.Sdk
Assembly:  Microsoft.Xrm.Sdk (in Microsoft.Xrm.Sdk.dll)

Syntax
C#

Copy
string MessageName { get; }
Property Value
Type: System.String

Type: String
The name of the Web service message being processed by the event execution pipeline.

### IExecutionContext.Mode Property
11/28/2016
2 minutes to read
 

Applies To: Dynamics 365 (online), Dynamics 365 (on-premises), Dynamics CRM 2016, Dynamics CRM Online

Gets the mode of plug-in execution.

Namespace:   Microsoft.Xrm.Sdk
Assembly:  Microsoft.Xrm.Sdk (in Microsoft.Xrm.Sdk.dll)

Syntax
C#

Copy
int Mode { get; }
Property Value
Type: System.Int32

Type: Int32
The mode of plug-in execution.

Remarks
Allowable values are defined in the SdkMessageProcessingStepMode enumeration defined in SampleCode\CS\HelperCode\OptionSets.cs and SampleCode\VB\HelperCode\OptionSets.vb of the SDK download.

### IExecutionContext.OperationCreatedOn Property
11/28/2016
2 minutes to read
 

Applies To: Dynamics 365 (online), Dynamics 365 (on-premises), Dynamics CRM 2016, Dynamics CRM Online

Gets the date and time that the related System Job was created.

Namespace:   Microsoft.Xrm.Sdk
Assembly:  Microsoft.Xrm.Sdk (in Microsoft.Xrm.Sdk.dll)

Syntax
C#

Copy
DateTime OperationCreatedOn { get; }
Property Value
Type: System.DateTime

Type: DateTime
The date and time that the related System Job was created.

Remarks
This property is used for the Microsoft Dynamics 365 to Microsoft Azure integration feature. It contains the same date and time value as the CreatedOn property of the related System Job entity.

### IExecutionContext.OperationId Property
Gets the GUID of the related System Job.

#### Syntax
```cs
Guid OperationId { get; }
```
#### Property Value
Type: System.Guid
The GUID of the related System Job. This corresponds to the AsyncOperationId attribute, which is the primary key for the System Job entity.

#### Remarks
This property is used for the Microsoft Dynamics 365 to Microsoft Azure integration feature.

### IExecutionContext.OrganizationId Property
11/28/2016
2 minutes to read
 

Applies To: Dynamics 365 (online), Dynamics 365 (on-premises), Dynamics CRM 2016, Dynamics CRM Online

Gets the GUID of the organization that the entity belongs to and the plug-in executes under.

Namespace:   Microsoft.Xrm.Sdk
Assembly:  Microsoft.Xrm.Sdk (in Microsoft.Xrm.Sdk.dll)

Syntax
C#

Copy
Guid OrganizationId { get; }
Property Value
Type: System.Guid

Type: Guid
The GUID of the organization that the entity belongs to and the plug-in executes under. This corresponds to the OrganizationId attribute, which is the primary key for the Organization entity.

### IExecutionContext.OrganizationName Property
11/28/2016
2 minutes to read
 

Applies To: Dynamics 365 (online), Dynamics 365 (on-premises), Dynamics CRM 2016, Dynamics CRM Online

Gets the unique name of the organization that the entity currently being processed belongs to and the plug-in executes under.

Namespace:   Microsoft.Xrm.Sdk
Assembly:  Microsoft.Xrm.Sdk (in Microsoft.Xrm.Sdk.dll)

Syntax
C#

Copy
string OrganizationName { get; }
Property Value
Type: System.String

Type: String
The unique name of the organization that the entity currently being processed belongs to and the plug-in executes under.

Remarks
See the Name attribute of the Organization entity.

### IExecutionContext.OutputParameters Property
11/28/2016
2 minutes to read
 

Applies To: Dynamics 365 (online), Dynamics 365 (on-premises), Dynamics CRM 2016, Dynamics CRM Online

Gets the parameters of the response message after the core platform operation has completed.

Namespace:   Microsoft.Xrm.Sdk
Assembly:  Microsoft.Xrm.Sdk (in Microsoft.Xrm.Sdk.dll)

Syntax
C#

Copy
ParameterCollection OutputParameters { get; }
Property Value
Type: Microsoft.Xrm.Sdk.ParameterCollection

Type: ParameterCollection
The parameters of the response message after the core platform operation has completed.

### IExecutionContext.OwningExtension Property
11/28/2016
2 minutes to read
 

Applies To: Dynamics 365 (online), Dynamics 365 (on-premises), Dynamics CRM 2016, Dynamics CRM Online

Gets a reference to the related SdkMessageProcessingingStep or ServiceEndpoint.

Namespace:   Microsoft.Xrm.Sdk
Assembly:  Microsoft.Xrm.Sdk (in Microsoft.Xrm.Sdk.dll)

Syntax
C#

Copy
EntityReference OwningExtension { get; }
Property Value
Type: Microsoft.Xrm.Sdk.EntityReference

Type: EntityReference
A reference to the related SdkMessageProcessingingStep or ServiceEndpoint.entity.

Remarks
An SdkMessageProcessingingStep entity is used for plug-in registration and a ServiceEndpoint entity is used for Microsoft Azure integration.

### IExecutionContext.PostEntityImages Property
11/28/2016
2 minutes to read
 

Applies To: Dynamics 365 (online), Dynamics 365 (on-premises), Dynamics CRM 2016, Dynamics CRM Online

Gets the properties of the primary entity after the core platform operation has been completed.

Namespace:   Microsoft.Xrm.Sdk
Assembly:  Microsoft.Xrm.Sdk (in Microsoft.Xrm.Sdk.dll)

Syntax
C#

Copy
EntityImageCollection PostEntityImages { get; }
Property Value
Type: Microsoft.Xrm.Sdk.EntityImageCollection

Type: EntityImageCollection
The properties of the primary entity after the core platform operation has been completed.

### IExecutionContext.PreEntityImages Property
11/28/2016
2 minutes to read
 

Applies To: Dynamics 365 (online), Dynamics 365 (on-premises), Dynamics CRM 2016, Dynamics CRM Online

Gets the properties of the primary entity before the core platform operation has begins.

Namespace:   Microsoft.Xrm.Sdk
Assembly:  Microsoft.Xrm.Sdk (in Microsoft.Xrm.Sdk.dll)

Syntax
C#

Copy
EntityImageCollection PreEntityImages { get; }
Property Value
Type: Microsoft.Xrm.Sdk.EntityImageCollection

Type: EntityImageCollection
The properties of the primary entity before the core platform operation has begins.

### IExecutionContext.PrimaryEntityId Property
11/28/2016
2 minutes to read
 

Applies To: Dynamics 365 (online), Dynamics 365 (on-premises), Dynamics CRM 2016, Dynamics CRM Online

Gets the GUID of the primary entity for which the pipeline is processing events.

Namespace:   Microsoft.Xrm.Sdk
Assembly:  Microsoft.Xrm.Sdk (in Microsoft.Xrm.Sdk.dll)

Syntax
C#

Copy
Guid PrimaryEntityId { get; }
Property Value
Type: System.Guid

Type: Guid
The GUID of the primary entity for which the pipeline is processing events. For example, if the event pipeline is processing an account, this corresponds to the AccountId attribute, which is the primary key for the Account entity.

### IExecutionContext.PrimaryEntityName Property
11/28/2016
2 minutes to read
 

Applies To: Dynamics 365 (online), Dynamics 365 (on-premises), Dynamics CRM 2016, Dynamics CRM Online

Gets the name of the primary entity for which the pipeline is processing events.

Namespace:   Microsoft.Xrm.Sdk
Assembly:  Microsoft.Xrm.Sdk (in Microsoft.Xrm.Sdk.dll)

Syntax
C#

Copy
string PrimaryEntityName { get; }
Property Value
Type: System.String

Type: String
The name of the primary entity for which the pipeline is processing events.

### IExecutionContext.RequestId Property
11/28/2016
2 minutes to read
 

Applies To: Dynamics 365 (online), Dynamics 365 (on-premises), Dynamics CRM 2016, Dynamics CRM Online

Gets the GUID of the request being processed by the event execution pipeline.

Namespace:   Microsoft.Xrm.Sdk
Assembly:  Microsoft.Xrm.Sdk (in Microsoft.Xrm.Sdk.dll)

Syntax
C#

Copy
Nullable<Guid> RequestId { get; }
Property Value
Type: System.Nullable<Guid>

Type: Nullable<Guid>
The GUID of the request being processed by the event execution pipeline. This corresponds to the RequestId property, which is the primary key for the OrganizationRequest class from which specialized request classes are derived.
  
  
### IExecutionContext.SecondaryEntityName Property
11/28/2016
2 minutes to read
 

Applies To: Dynamics 365 (online), Dynamics 365 (on-premises), Dynamics CRM 2016, Dynamics CRM Online

Gets the name of the secondary entity that has a relationship with the primary entity.

Namespace:   Microsoft.Xrm.Sdk
Assembly:  Microsoft.Xrm.Sdk (in Microsoft.Xrm.Sdk.dll)

Syntax
C#

Copy
string SecondaryEntityName { get; }
Property Value
Type: System.String

Type: String
The name of the secondary entity that has a relationship with the primary entity.

### IExecutionContext.SharedVariables Property
11/28/2016
2 minutes to read
 

Applies To: Dynamics 365 (online), Dynamics 365 (on-premises), Dynamics CRM 2016, Dynamics CRM Online

Gets the custom properties that are shared between plug-ins.

Namespace:   Microsoft.Xrm.Sdk
Assembly:  Microsoft.Xrm.Sdk (in Microsoft.Xrm.Sdk.dll)

Syntax
C#

Copy
ParameterCollection SharedVariables { get; }
Property Value
Type: Microsoft.Xrm.Sdk.ParameterCollection

Type: ParameterCollection
The custom properties that are shared between plug-ins.

### IExecutionContext.UserId Property
11/28/2016
2 minutes to read
 

Applies To: Dynamics 365 (online), Dynamics 365 (on-premises), Dynamics CRM 2016, Dynamics CRM Online

Gets the GUID of the system user for whom the plug-in invokes web service methods on behalf of.

Namespace:   Microsoft.Xrm.Sdk
Assembly:  Microsoft.Xrm.Sdk (in Microsoft.Xrm.Sdk.dll)

Syntax
C#

Copy
Guid UserId { get; }
Property Value
Type: System.Guid

Type: Guid
The GUID of the system user for whom the plug-in invokes web service methods on behalf of. This property corresponds to the SystemUserId property, which is the primary key for the SystemUser entity.

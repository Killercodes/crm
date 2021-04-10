# Impersonation in plug-ins

**Applies To:** Dynamics 365 (online), Dynamics 365 (on-premises), Dynamics CRM 2016, Dynamics CRM Online

Impersonation is used to execute business logic (custom code) on behalf of a Microsoft Dynamics 365 system user to provide a desired feature or service for that user. Any business logic executed within a plug-in, including Web service method calls and data access, is governed by the security privileges of the impersonated user.

Plug-ins not executed by either the sandbox or asynchronous service execute under the security account that is specified on the Identity tab of the CRMAppPool
Properties dialog box. The dialog box can be accessed by right-clicking the **CRMAppPool** application pool in Internet Information Services (IIS) Manager and then 
clicking Properties in the shortcut menu. By default, **CRMAppPool** uses the Network Service account identity but this can be changed by a system administrator 
during installation. If the **CRMAppPool** identity is changed to a system account other than Network Service, the new identity account must be added to the 
**PrivUserGroup group** in Active Directory. More information:  TechNet: Change a Microsoft Dynamics CRM service account or AppPool identity for more detailed 
instructions.

The two methods that can be employed to impersonate a user are discussed below.

## Impersonation during plug-in registration
One method to impersonate a system user within a plug-in is by specifying the impersonated user during plug-in registration. When registering a plug-in programmatically, if the SdkMessageProcessingStep.ImpersonatingUserId attribute is set to a specific Microsoft Dynamics 365 system user, Web service calls made by the plug-in execute on behalf of the impersonated user. If ImpersonatingUserId is set to a value of null or Guid.Empty during plug-in registration, the calling/logged on user or the standard "system" user is the impersonated user.

Whether the calling/logged on user or "system" user is used for impersonation is dependent on the request being processed by the pipeline and is beyond the scope of the SDK documentation. For more information about the "system" user, refer to the next topic.

 > **Note**
When you register a plug-in using the sample plug-in registration tool that is provided in the SDK download, service methods invoked by the plug-in execute under the account of the calling or logged on user by default unless you select a different user in the Run in User’s Context dropdown menu. For more information about the tool sample code, refer to the tool code under the SDK\Tools\PluginRegistration folder of the SDK package. Download the Microsoft Dynamics CRM SDK package.

## Impersonation during plug-in execution
Impersonation that was defined during plug-in registration can be altered in a plug-in at run time. Even if impersonation was not defined at plug-in registration, plug-in code can still use impersonation. The following discussion identifies the key properties and methods that play a role in impersonation when making Web service method calls in a plug-in.

The platform passes the impersonated user ID to a plug-in at run time through the UserId property. This property can have one of three different values as shown in the table below.

IMPERSONATION DURING PLUG-IN EXECUTION

UserId Value | Condition
--|--
Initiating user or "system" user | The **SdkMessageProcessingStep.ImpersonatingUserId** attribute is set to **null** or **Guid.Empty** at plug-in registration.
Impersonated user | The **ImpersonatingUserId** property is set to a valid system user ID at plug-in registration.
**system** user | The current pipeline was executed by the platform, not in direct response to a service method call.

The InitiatingUserId property of the execution context contains the ID of the system user that called the service method that ultimately caused the plug-in to execute.

 > **Important:**
**For plug-ins executing offline, any entities created by the plug-in are owned by the logged on user. Impersonation in plug-ins is not supported while in offline mode.**

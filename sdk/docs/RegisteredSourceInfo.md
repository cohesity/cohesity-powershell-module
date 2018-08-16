# IO.Swagger.Model.RegisteredSourceInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessInfo** | [**ConnectorParams**](ConnectorParams.md) | Specifies the parameters required to establish a connection with a particular environment. | [optional] 
**AuthenticationErrorMessage** | **string** | Specifies an authentication error message. This indicates the given credentials are rejected and the registration of the source is not successful. | [optional] 
**AuthenticationStatus** | **string** | Specifies the status of the authenticating to the Protection Source when registering it with Cohesity Cluster. If the status is &#39;kFinished&#39; and there is no error, registration is successful. Specifies the status of the authentication during the registration of a Protection Source. &#39;kPending&#39; indicates the authentication is in progress. &#39;kScheduled&#39; indicates the authentication is scheduled. &#39;kFinished&#39; indicates the authentication is completed. | [optional] 
**Environments** | **List&lt;string&gt;** | Specifies a list of applications environment that are registered with this Protection Source such as &#39;kSQL&#39;. Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. | [optional] 
**MinimumFreeSpaceGB** | **long?** | Specifies the minimum free space in GiB of the space expected to be available on the datastore where the virtual disks of the VM being backed up. If the amount of free space(in GiB) is lower than the value given by this field, backup will be aborted. Note that this field is applicable only to &#39;kVMware&#39; type of environments. | [optional] 
**NasMountCredentials** | [**NASServerCredentials_**](NASServerCredentials_.md) |  | [optional] 
**Password** | **string** | Specifies password of the username to access the target source. | [optional] 
**RefreshErrorMessage** | **string** | Specifies a message if there was any error encountered during the last rebuild of the Protection Source tree. If there was no error during the last rebuild, this field is reset. | [optional] 
**RefreshTimeUsecs** | **long?** | Specifies the Unix epoch time (in microseconds) when the Protection Source tree was most recently fetched and built. | [optional] 
**RegistrationTimeUsecs** | **long?** | Specifies the Unix epoch time (in microseconds) when the Protection Source was registered. | [optional] 
**ThrottlingPolicy** | [**ThrottlingPolicy**](ThrottlingPolicy.md) | Specifies the throttling policy that should be applied to all datastores under this registered Protection Source. | [optional] 
**ThrottlingPolicyOverrides** | [**List&lt;ThrottlingPolicyOverride&gt;**](ThrottlingPolicyOverride.md) | Specifies a list of Throttling Policy for datastores that override the common throttling policy specified for the registered Protection Source. For datastores not in this list, common policy will still apply. | [optional] 
**Username** | **string** | Specifies username to access the target source. | [optional] 
**WarningMessages** | **List&lt;string&gt;** | Though the registration may succeed, warning messages imply the host environment requires some cleanup or fixing. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


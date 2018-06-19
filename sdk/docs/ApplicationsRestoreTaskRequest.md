# IO.Swagger.Model.ApplicationsRestoreTaskRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApplicationEnvironment** | **string** | Specifies the Environment of the Application to restore like &#39;kSQL&#39;, or &#39;kExchange&#39;. overrideDescription: true | 
**ApplicationRestoreObjects** | [**List&lt;ApplicationRestoreObject&gt;**](ApplicationRestoreObject.md) | Specifies the Application Server objects whose data should be restored and the restore parameters for each of them. | [optional] 
**HostingProtectionSource** | [**RestoreObject**](RestoreObject.md) | Specifies the restore information for the Protection Source object that registered and hosts the Application Servers. This provides the snapshot details from which the applications should be restored. | 
**Name** | **string** | Specifies a name for the new task to be created. This field has to be set, and it needs to be unique across all restore tasks. | 
**Password** | **string** | Specifies password of the username to access the target source. | [optional] 
**Username** | **string** | Specifies username to access the target source. | [optional] 
**VlanParameters** | [**VlanParameters**](VlanParameters.md) | Specifies VLAN parameters for the restore operation. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


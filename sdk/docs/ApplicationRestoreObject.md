# IO.Swagger.Model.ApplicationRestoreObject
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApplicationServerId** | **long?** | Specifies the Application Server to restore (for example, kSQL). | [optional] 
**SqlRestoreParameters** | [**SqlRestoreParameters**](SqlRestoreParameters.md) | Specifies parameters specific to this Application Server. | [optional] 
**TargetHostId** | **long?** | Specifies the target host if the application is to be restored to a different host. If this is empty, then the application is restored to the original host, which is the hosting Protection Source. | [optional] 
**TargetRootNodeId** | **long?** | Specifies the registered root node, like vCenter, of targetHost. If this is empty, then it is assumed the root node of the target host is the same as the host Protection Source of the application. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# IO.Swagger.Model.SqlAagHostAndDatabases
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AagDatabases** | [**List&lt;AagAndDatabases&gt;**](AagAndDatabases.md) |  | [optional] 
**ApplicationNode** | [**ProtectionSourceNode**](ProtectionSourceNode.md) | Specifies the subtree used to store application-level Objects. Different environments use the subtree to store application-level information. For example for SQL Server, this subtree stores the SQL Server instances running on a VM or Physical hosts. | [optional] 
**Databases** | [**List&lt;ProtectionSource&gt;**](ProtectionSource.md) | Specifies all database entities found on the server. Database may or may not be in an AAG. | [optional] 
**ErrorMessage** | **string** | Specifies an error message when the host is not registered as an SQL host. | [optional] 
**UnknownHostName** | **string** | Specifies the name of the host that is not registered as an SQL server on Cohesity Cluser. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


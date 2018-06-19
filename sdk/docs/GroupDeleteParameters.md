# IO.Swagger.Model.GroupDeleteParameters
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Domain** | **string** | Specifies the domain associated with the groups to delete. Only groups associated with the same domain can be deleted by a single request. If no domain is specified, the specified groups are deleted from the LOCAL domain on the Cohesity Cluster. If a non-LOCAL domain is specified, the specified groups are deleted on the Cohesity Cluster. However, the referenced group principals on the Active Directory are not deleted. | [optional] 
**Names** | **List&lt;string&gt;** | Specifies the list of groups to delete on the Cohesity Cluster. Only groups from the same domain can be deleted by a single request. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


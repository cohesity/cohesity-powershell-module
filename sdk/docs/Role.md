# IO.Swagger.Model.Role
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedTimeMsecs** | **long?** | Specifies the epoch time in milliseconds when the role was created. | [optional] 
**Description** | **string** | Specifies a description about the role. | [optional] 
**IsCustomRole** | **bool?** | Specifies if the role is a user-defined custom role. If true, the role is a user-defined custom role that was created using the REST API, the Cohesity Dashboard or the CLI. If false, the role is a default system role that was created during Cluster creation. | [optional] 
**Label** | **string** | Specifies the label for the role as displayed on the Cohesity Dashboard such as &#39;Viewer&#39;. | [optional] 
**LastUpdatedTimeMsecs** | **long?** | Specifies the epoch time in milliseconds when the role was last modified. | [optional] 
**Name** | **string** | Specifies the internal Cluster name for the role such as COHESITY_VIEWER. For custom roles, the name and the label are the same. For default system roles, the name and label are different. | [optional] 
**Privileges** | **List&lt;string&gt;** | Specifies the privileges assigned to the role. When a user or group is assigned this role, these privileges define the operations the user or group can perform on the Cohesity Cluster. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


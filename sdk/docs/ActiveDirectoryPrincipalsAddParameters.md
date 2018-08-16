# IO.Swagger.Model.ActiveDirectoryPrincipalsAddParameters
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | Specifies a description about the user or group. | [optional] 
**Domain** | **string** | Specifies the domain of the Active Directory where the referenced principal is stored. | [optional] 
**ObjectClass** | **string** | Specifies the type of the referenced Active Directory principal. If &#39;kGroup&#39;, the referenced Active Directory principal is a group. If &#39;kUser&#39;, the referenced Active Directory principal is a user. &#39;kUser&#39; specifies a user object class. &#39;kGroup&#39; specifies a group object class. | [optional] 
**PrincipalName** | **string** | Specifies the name of the Active Directory principal, that will be referenced by the group or user. The name of the Active Directory principal is used for naming the new group or user on the Cohesity Cluster. | [optional] 
**Restricted** | **bool?** | Whether the principal is a restricted principal. A restricted principal can only view the objects he has permissions to. | [optional] 
**Roles** | **List&lt;string&gt;** | Specifies the Cohesity roles to associate with this user or group such as &#39;Admin&#39;, &#39;Ops&#39; or &#39;View&#39;. The Cohesity roles determine privileges on the Cohesity Cluster for this group or user. For example if the &#39;joe&#39; user is added for the Active Directory &#39;joe&#39; user principal and is associated with the Cohesity &#39;View&#39; role, &#39;joe&#39; can log in to the Cohesity Dashboard and has a read-only view of the data on the Cohesity Cluster. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


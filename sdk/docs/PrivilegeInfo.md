# IO.Swagger.Model.PrivilegeInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Category** | **string** | Specifies a category for the privilege such as &#39;Access Management&#39;. | [optional] 
**Description** | **string** | Specifies a description defining what the privilege provides. | [optional] 
**IsCustomRoleDefault** | **bool?** | Specifies if this privilege is automatically assigned to custom roles. | [optional] 
**IsSpecial** | **bool?** | Specifies if this privilege is automatically assigned to the default System Admin user called &#39;admin&#39;. If true, the privilege is NOT assigned to the default System Admin user called &#39;admin&#39;. By default, privileges are automatically assigned to the default System Admin user called &#39;admin&#39;. | [optional] 
**IsViewOnly** | **bool?** | Specifies if privilege is view-only privilege that cannot make changes. | [optional] 
**Label** | **string** | Specifies the label for the privilege as displayed on the Cohesity Dashboard such as &#39;Access Management View&#39;. | [optional] 
**Name** | **string** | Specifies the Cluster name for the privilege such as PRINCIPAL_VIEW. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


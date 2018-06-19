# IO.Swagger.Model.SmbPermission
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Access** | **string** | Specifies the read/write access to the SMB share. &#39;kReadyOnly&#39; indicates read only access to the SMB share. &#39;kReadWrite&#39; indicates read and write access to the SMB share. &#39;kFullControl&#39; indicates full administrative control of the SMB share. &#39;kSpecialAccess&#39; indicates custom permissions to the SMB share using access masks structures. | [optional] 
**Mode** | **string** | Specifies how the permission should be applied to folders and/or files. | [optional] 
**Sid** | **string** | Specifies the security identifier (SID) of the principal. | [optional] 
**SpecialAccessMask** | **int?** | Specifies custom access permissions. When the access mask from the Access Control Entry (ACE) cannot be mapped to one of the enums in &#39;access&#39;, this field is populated with the custom mask derived from the ACE and &#39;access&#39; is set to kSpecialAccess. This is a placeholder for storing an unmapped access permission and should not be set when creating and editing a View. | [optional] 
**SpecialType** | **int?** | Specifies a custom type. When the type from the Access Control Entry (ACE) cannot be mapped to one of the enums in &#39;type&#39;, this field is populated with the custom type derived from the ACE and &#39;type&#39; is set to kSpecialType. This is a placeholder for storing an unmapped type and should not be set when creating and editing a View. | [optional] 
**Type** | **string** | Specifies the type of permission. &#39;kAllow&#39; indicates access is allowed. &#39;kDeny&#39; indicates access is denied. &#39;kSpecialType&#39; indicates a type defined in the Access Control Entry (ACE) does not map to &#39;kAllow&#39; or &#39;kDeny&#39;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


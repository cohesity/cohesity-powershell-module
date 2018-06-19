# IO.Swagger.Model.IdMappingInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FallbackUserIdMappingInfo** | [**UserIdMapping**](UserIdMapping.md) | Specifies the fallback id mapping info which is used when an ID mapping for a user is not found via the above IdMappingInfo. Only supported for two types of fallback mapping types - &#39;kRid&#39; and &#39;kFixed&#39;. | [optional] 
**UnixRootSid** | **string** | Specifies the SID of the Active Directory domain user to be mapped to Unix root user. | [optional] 
**UserIdMappingInfo** | [**UserIdMapping**](UserIdMapping.md) | Specifies the information about how the Unix and Windows users are mapped for this domain. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


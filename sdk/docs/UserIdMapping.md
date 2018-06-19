# IO.Swagger.Model.UserIdMapping
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CentrifyZoneMapping** | [**CentrifyZone**](CentrifyZone.md) | Specifies a centrify zone when mapping type is set to &#39;kCentrify&#39;. It defines a centrify zone from which the user id mapping info would be derived. | [optional] 
**CustomAttributesMapping** | [**CustomUnixIdAttributes**](CustomUnixIdAttributes.md) | Specifies the custom attributes when mapping type is set to &#39;kCustomAttributes&#39;. It defines the attribute names to derive the mapping for a user of an Active Directory domain. | [optional] 
**FixedMapping** | [**FixedUnixIdMapping**](FixedUnixIdMapping.md) | Specifies the fields when mapping type is set to &#39;kFixed&#39;. It maps all Active Directory users of this domain to a fixed uid, and gid. | [optional] 
**Type** | **string** | Specifies the mapping type used. &#39;kRid&#39; indicates the kRid mapping type. &#39;kRfc2307&#39; indicates the kRfc2307 mapping type. &#39;kSfu30&#39; indicates the kSfu30 mapping type. &#39;kCentrify&#39; indicates the mapping type to refer to a centrify zone. &#39;kFixed&#39; indicates the mapping from all Active Directory users to a fixed Unix uid, and gid. &#39;kCustomAttributes&#39; indicates the mapping to derive from custom attributes defined in an AD domain. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


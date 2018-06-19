# IO.Swagger.Model.ActiveDirectoryEntry
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DomainName** | **string** | Specifies the fully qualified domain name (FQDN) of an Active Directory. | [optional] 
**FallbackUserIdMappingInfo** | [**UserIdMapping**](UserIdMapping.md) | Specifies the fallback id mapping info which is used when an ID mapping for a user is not found via the above IdMappingInfo. Only supported for two types of fallback mapping types - &#39;kRid&#39; and &#39;kFixed&#39;. | [optional] 
**MachineAccounts** | **List&lt;string&gt;** | Specifies an array of computer names used to identify the Cohesity Cluster on the domain. | [optional] 
**OuName** | **string** | Specifies an optional Organizational Unit name. | [optional] 
**Password** | **string** | Specifies the password for the specified userName. | [optional] 
**TrustedDomains** | **List&lt;string&gt;** |  | [optional] 
**UnixRootSid** | **string** | Specifies the SID of the Active Directory domain user to be mapped to Unix root user. | [optional] 
**UserIdMappingInfo** | [**UserIdMapping**](UserIdMapping.md) | Specifies the information about how the Unix and Windows users are mapped for this domain. | [optional] 
**UserName** | **string** | Specifies a userName that has administrative privileges in the domain. | [optional] 
**Workgroup** | **string** | Specifies an optional Workgroup name. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


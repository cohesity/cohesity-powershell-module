# IO.Swagger.Model.UpdateViewParam
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessSids** | **List&lt;string&gt;** | Specifies the list of security identifiers (SIDs) for the restricted Principals who have access to this View. | [optional] 
**Description** | **string** | Specifies an optional text description about the View. | [optional] 
**EnableFilerAuditLogging** | **bool?** | Specifies if Filer Audit Logging is enabled for this view. | [optional] 
**EnableMixedModePermissions** | **bool?** | If set, mixed mode (NFS and SMB) access is enabled for this view. | [optional] 
**EnableSmbAccessBasedEnumeration** | **bool?** | Specifies if access-based enumeration should be enabled. If &#39;true&#39;, only files and folders that the user has permissions to access are visible on the SMB share for that user. | [optional] 
**EnableSmbViewDiscovery** | **bool?** | If set, it enables discovery of view for SMB. | [optional] 
**FileExtensionFilter** | [**FileExtensionFilter**](FileExtensionFilter.md) | Optional filtering criteria that should be satisfied by all the files created in this view. It does not affect existing files. | [optional] 
**LogicalQuota** | [**QuotaPolicy**](QuotaPolicy.md) |  | [optional] 
**ProtocolAccess** | **string** | Specifies the supported Protocols for the View. | [optional] 
**Qos** | [**QoS**](QoS.md) | Specifies the Quality of Service (QoS) Policy for the View. | [optional] 
**SmbPermissionsInfo** | [**SmbPermissionsInfo**](SmbPermissionsInfo.md) | Specifies the SMB permissions for the View. | [optional] 
**StoragePolicyOverride** | [**StoragePolicyOverride**](StoragePolicyOverride.md) | Specifies if inline deduplication and compression settings inherited from the Storage Domain (View Box) should be disabled for this View. | [optional] 
**SubnetWhitelist** | [**List&lt;Subnet&gt;**](Subnet.md) | Specifies a list of Subnets with IP addresses that have permissions to access the View. (Overrides the Subnets specified at the global Cohesity Cluster level.) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


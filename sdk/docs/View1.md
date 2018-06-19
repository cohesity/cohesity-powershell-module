# IO.Swagger.Model.View1
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessSids** | **List&lt;string&gt;** | Specifies the list of security identifiers (SIDs) for the restricted Principals who have access to this View. | [optional] 
**Aliases** | [**List&lt;ViewAliasInfo&gt;**](ViewAliasInfo.md) | Aliases created for the view. A view alias allows a directory path inside a view to be mounted using the alias name. | [optional] 
**AllSmbMountPaths** | **List&lt;string&gt;** | Specifies the possible paths that can be used to mount this View as a SMB share. If Active Directory has multiple account names; each machine account has its own path. | [optional] 
**BasicMountPath** | **string** | Specifies the NFS mount path of the View (without the hostname information). This path is used to support NFS mounting of the paths specified in the nfsExportPathList on Windows systems. | [optional] 
**CaseInsensitiveNamesEnabled** | **bool?** | Specifies whether to support case insensitive file/folder names. This parameter can only be set during create and cannot be changed. | [optional] 
**CreateTimeMsecs** | **long?** | Specifies the time that the View was created in milliseconds. | [optional] 
**DataLockExpiryUsecs** | **long?** | DataLock (Write Once Read Many) lock expiry epoch time in microseconds. If a view is marked as a DataLock view, only a Data Security Officer (a user having Data Security Privilege) can delete the view until the lock expiry time. | [optional] 
**Description** | **string** | Specifies an optional text description about the View. | [optional] 
**EnableFilerAuditLogging** | **bool?** | Specifies if Filer Audit Logging is enabled for this view. | [optional] 
**EnableMixedModePermissions** | **bool?** | If set, mixed mode (NFS and SMB) access is enabled for this view. | [optional] 
**EnableSmbAccessBasedEnumeration** | **bool?** | Specifies if access-based enumeration should be enabled. If &#39;true&#39;, only files and folders that the user has permissions to access are visible on the SMB share for that user. | [optional] 
**EnableSmbViewDiscovery** | **bool?** | If set, it enables discovery of view for SMB. | [optional] 
**FileExtensionFilter** | [**FileExtensionFilter**](FileExtensionFilter.md) | Optional filtering criteria that should be satisfied by all the files created in this view. It does not affect existing files. | [optional] 
**LogicalQuota** | [**QuotaPolicy**](QuotaPolicy.md) |  | [optional] 
**LogicalUsageBytes** | **long?** | LogicalUsageBytes is the logical usage in bytes for the view. | [optional] 
**Name** | **string** | Specifies the name of the View. | [optional] 
**NfsMountPath** | **string** | Specifies the path for mounting this View as an NFS share. | [optional] 
**ProtocolAccess** | **string** | Specifies the supported Protocols for the View. | [optional] 
**Qos** | [**QoS**](QoS.md) | Specifies the Quality of Service (QoS) Policy for the View. | [optional] 
**SmbMountPath** | **string** | Specifies the main path for mounting this View as an SMB share. | [optional] 
**SmbPermissionsInfo** | [**SmbPermissionsInfo**](SmbPermissionsInfo.md) | Specifies the SMB permissions for the View. | [optional] 
**StoragePolicyOverride** | [**StoragePolicyOverride**](StoragePolicyOverride.md) | Specifies if inline deduplication and compression settings inherited from the Storage Domain (View Box) should be disabled for this View. | [optional] 
**SubnetWhitelist** | [**List&lt;Subnet&gt;**](Subnet.md) | Specifies a list of Subnets with IP addresses that have permissions to access the View. (Overrides the Subnets specified at the global Cohesity Cluster level.) | [optional] 
**ViewBoxId** | **long?** | Specifies the id of the Storage Domain (View Box) where the View is stored. | [optional] 
**ViewBoxName** | **string** | Specifies the name of the Storage Domain (View Box) where the View is stored. | [optional] 
**ViewId** | **long?** | Specifies an id of the View assigned by the Cohesity Cluster. | [optional] 
**ViewProtection** | [**ViewProtection**](ViewProtection.md) | Specifies information about the Protection Jobs protecting this View. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


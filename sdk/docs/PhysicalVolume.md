# IO.Swagger.Model.PhysicalVolume
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DevicePath** | **string** | Specifies the path to the device that hosts the volume locally. | [optional] 
**Guid** | **string** | Specifies an id for the Physical Volume. | [optional] 
**IsExtendedAttributesSupported** | **bool?** | Specifies whether this volume supports extended attributes (like ACLs) when performing file backups. | [optional] 
**IsProtected** | **bool?** | Specifies if a volume is protected by a Job. | [optional] 
**Label** | **string** | Specifies a volume label that can be used for displaying additional identifying information about a volume. | [optional] 
**LogicalSizeBytes** | **int?** | Specifies the logical size of the volume in bytes that is not reduced by change-block tracking, compression and deduplication. | [optional] 
**MountPoints** | **List&lt;string&gt;** | Specifies the mount points where the volume is mounted, for example: &#39;C:\\&#39;, &#39;/mnt/foo&#39; etc. | [optional] 
**NetworkPath** | **string** | Specifies the full path to connect to the network attached volume. For example, (IP or hostname):/path/to/share for NFS volumes). | [optional] 
**UsedSizeBytes** | **int?** | Specifies the size used by the volume in bytes. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


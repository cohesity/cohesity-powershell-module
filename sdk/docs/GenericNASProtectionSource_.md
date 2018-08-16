# IO.Swagger.Model.GenericNASProtectionSource_
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | Specifies a description about the Protection Source. | [optional] 
**MountPath** | **string** | Specifies the mount path of this NAS. For example, for a NFS mount point, this should be in the format of IP or hostname:/foo/bar. | [optional] 
**Name** | **string** | Specifies the name of the NetApp Object. | [optional] 
**Protocol** | **string** | Specifies the protocol used by the NAS server. Specifies the protocol used by a NAS server. &#39;kNfs3&#39; indicates NFS v3 protocol. &#39;kCifs1&#39; indicates CIFS v1.0 protocol. | [optional] 
**Type** | **string** | Specifies the type of a Protection Source Object in a generic NAS Source such as &#39;kGroup&#39;, or &#39;kHost&#39;. Specifies the kind of NAS mount. &#39;kGroup&#39; indicates top level node that holds individual NAS hosts. &#39;kHost&#39; indicates a single NAS path that can be mounted. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


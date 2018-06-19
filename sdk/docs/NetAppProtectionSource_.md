# IO.Swagger.Model.NetAppProtectionSource_
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClusterInfo** | [**NetappClusterInfo**](NetappClusterInfo.md) | Specifies information about a NetApp cluster and is only valid for a NetApp Object of type kCluster. | [optional] 
**IsTopLevel** | **bool?** | Specifies if this Object is a top level Object. Because a top level Object can either be a NetApp cluster or a Vserver, this cannot be determined only by type. | [optional] 
**Name** | **string** | Specifies the name of the NetApp Object. | [optional] 
**Type** | **string** | Specifies the type of managed NetApp Object in a NetApp Protection Source such as &#39;kCluster&#39;, &#39;kVserver&#39; or &#39;kVolume&#39;. | [optional] 
**Uuid** | **string** | Specifies the globally unique ID of this Object assigned by the NetApp server. | [optional] 
**VolumeInfo** | [**NetappVolumeInfo**](NetappVolumeInfo.md) | Specifies information about a NetApp volume and is only valid for a NetApp Object of type kVolume. | [optional] 
**VserverInfo** | [**NetappVserverInfo**](NetappVserverInfo.md) | Specifies information about a NetApp Vserver and is only valid for a NetApp Object of type kVserver. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# IO.Swagger.Model.NetappVserverInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DataProtocols** | **List&lt;string&gt;** | Specifies the set of data protocols supported by this Vserver. The kManagement protocol is not supported for this case. &#39;kNfs&#39; indicates NFS connections. &#39;kCifs&#39; indicates SMB (CIFS) connections. &#39;kIscsi&#39; indicates iSCSI connections. &#39;kFc&#39; indicates Fiber Channel connections. &#39;kFcache&#39; indicates Flex Cache connections. &#39;kHttp&#39; indicates HTTP connections. &#39;kNdmp&#39; indicates NDMP connections. &#39;kManagement&#39; indicates non-data connections used for management purposes. | [optional] 
**Interfaces** | [**List&lt;VserverNetworkInterface&gt;**](VserverNetworkInterface.md) | Specifies information about all interfaces on this Vserver. | [optional] 
**RootCifsShare** | [**CifsShareInfo**](CifsShareInfo.md) | Specifies the root &#39;c$&#39; CIFS share of this Vserver. If it exists, it can be used to mount all CIFS volumes that are junctioned under &#39;/&#39; on this Vserver. | [optional] 
**Type** | **string** | Specifies the type of this Vserver. Specifies the type of the NetApp Vserver. &#39;kData&#39; indicates the Vserver is used for data backup and restore. &#39;kAdmin&#39; indicates the Vserver is used for cluster-wide management. &#39;kSystem&#39; indicates the Vserver is used for cluster-scoped communications in an IPspace. &#39;kNode&#39; indicates the Vserver is used as the physical controller. &#39;kUnknown&#39; indicates the Vserver is used for an unknown purpose. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


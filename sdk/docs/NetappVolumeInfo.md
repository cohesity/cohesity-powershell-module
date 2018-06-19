# IO.Swagger.Model.NetappVolumeInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AggregateName** | **string** | Specifies the containing aggregate name of this volume. | [optional] 
**CapacityBytes** | **long?** | Specifies the total capacity in bytes of this volume. | [optional] 
**CifsShares** | [**List&lt;CifsShareInfo&gt;**](CifsShareInfo.md) | Specifies the set of CIFS Shares exported for this volume. | [optional] 
**CreationTimeUsecs** | **long?** | Specifies the creation time of the volume specified in Unix epoch time (in microseconds). | [optional] 
**DataProtocols** | **List&lt;string&gt;** | Specifies the set of data protocols supported by this volume. &#39;kNfs&#39; indicates NFS connections. &#39;kCifs&#39; indicates SMB (CIFS) connections. &#39;kIscsi&#39; indicates iSCSI connections. &#39;kFc&#39; indicates Fiber Channel connections. &#39;kFcache&#39; indicates Flex Cache connections. &#39;kHttp&#39; indicates HTTP connections. &#39;kNdmp&#39; indicates NDMP connections. &#39;kManagement&#39; indicates non-data connections used for management purposes. | [optional] 
**ExportPolicyName** | **string** | Specifies the name of the export policy (which defines the access permissions for the mount client) that has been assigned to this volume. | [optional] 
**JunctionPath** | **string** | Specifies the junction path of this volume. This path can be used to mount this volume via protocols such as NFS. | [optional] 
**Name** | **string** | Specifies the name of the NetApp Vserver that this volume belongs to. | [optional] 
**SecurityInfo** | [**VolumeSecurityInfo**](VolumeSecurityInfo.md) | Specifies the security information of this volume. | [optional] 
**State** | **string** | Specifies the state of this volume. Specifies the state of a NetApp Volume. &#39;kOnline&#39; indicates the volume is online. Read and write access to this volume is allowed. &#39;kRestricted&#39; indicates the volume is restricted. Some operations, such as parity reconstruction, are allowed, but data access is not allowed. &#39;kOffline&#39; indicates the volume is offline. No access to the volume is allowed. &#39;kMixed&#39; indicates the volume is in mixed state, which means its aggregates are not all in the same state. &#39;kUnknownState&#39; indicates the volume is in an unknown state. | [optional] 
**Type** | **string** | Specifies the NetApp type of this volume. Specifies the type of a NetApp Volume. &#39;kReadWrite&#39; indicates read-write volume. &#39;kLoadSharing&#39; indicates load-sharing volume. &#39;kDataProtection&#39; indicates data-protection volume. &#39;kDataCache&#39; indicates data-cache volume. &#39;kTmp&#39; indicates temporaray purpose. &#39;kUnknownType&#39; indicates unknown type. | [optional] 
**UsedBytes** | **long?** | Specifies the total space (in bytes) used in this volume. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# IO.Swagger.Model.DeviceTree
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CombineMethod** | **string** | Specifies how to combine the children of this node. The combining strategy for child devices. Some of these strategies imply constraint on the number of child devices. e.g. RAID5 will have 5 children. &#39;LINEAR&#39; indicates children are juxtaposed to form this device. &#39;STRIPE&#39; indicates children are striped. &#39;MIRROR&#39; indicates children are mirrored. &#39;RAID5&#39; &#39;RAID6&#39; &#39;ZERO&#39; &#39;THIN&#39; &#39;THINPOOL&#39; &#39;SNAPSHOT&#39; &#39;CACHE&#39; &#39;CACHEPOOL&#39; | [optional] 
**DeviceLength** | **long?** | Specifies the length of this device. This number should match the length that is calculated from the children and combining method. | [optional] 
**DeviceNodes** | [**List&lt;DeviceNode&gt;**](DeviceNode.md) |  | [optional] 
**StripeSize** | **int?** | Specifies the size of the striped data if the data is striped. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


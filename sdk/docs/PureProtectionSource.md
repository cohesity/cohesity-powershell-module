# IO.Swagger.Model.PureProtectionSource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Specifies a human readable name of the Protection Source. | [optional] 
**StorageArray** | [**PureStorageArray**](PureStorageArray.md) | Specifies a Pure Storage Array information. This is set only when the type is kStorageArray. | [optional] 
**Type** | **string** | Specifies the type of managed Object in a pure Protection Source like a kStorageArray or kVolume. Examples of Pure Objects include &#39;kStorageArray&#39; and &#39;kVolume&#39;. | [optional] 
**Volume** | [**PureVolume**](PureVolume.md) | Specifies a Pure Volume information within a storage array. This is set only when the type is kVolume. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


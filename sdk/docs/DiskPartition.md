# IO.Swagger.Model.DiskPartition
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LengthBytes** | **long?** | Specifies the length of the block in bytes. | [optional] 
**Number** | **long?** | Specifies a unique number of the partition within the linear disk file. | [optional] 
**OffsetBytes** | **long?** | Specifies the offset of the block (in bytes) from the beginning of the containing object such as a physical disk or a virtual disk file. | [optional] 
**TypeUuid** | **string** | Specifies the partition type uuid. If disk is unpartitioned, this field is not set. If disk is MBR partitioned, this field is set to a partition type. If disk is GPT partitioned, this field is set to a partition type GUID. | [optional] 
**Uuid** | **string** | Specifies the partition uuid. If disk is unpartitioned, this field is not set. If disk is MBR partitioned, this field is not set. If disk is GPT partitioned, this field is set to a partition GUID. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


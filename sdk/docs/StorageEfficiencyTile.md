# IO.Swagger.Model.StorageEfficiencyTile
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DataInBytes** | **long?** | Data brought into the cluster. This is the usage before data reduction if we ignore the zeroes and effects of cloning. | [optional] 
**DataInDedupedBytes** | **long?** | Morphed Usage before data is replicated to other nodes as per RF or Erasure Coding policy. | [optional] 
**DataReduction** | **long?** | Data Reduction is the ratio of DataInBytes to DataInDedupBytes. | [optional] 
**LastWeekDataInBytes** | **List&lt;long?&gt;** |  | [optional] 
**LastWeekDataInDedupedBytes** | **List&lt;long?&gt;** | Morphed usage before data is replicated in last 7 days in descening order of time. | [optional] 
**LastWeekDataReduction** | **List&lt;long?&gt;** |  | [optional] 
**LastWeekLogicalUsedBytes** | **List&lt;long?&gt;** |  | [optional] 
**LastWeekPhysicalUsedBytes** | **List&lt;long?&gt;** |  | [optional] 
**LastWeekStorageEfficiency** | **List&lt;long?&gt;** |  | [optional] 
**LogicalUsedBytes** | **long?** | Logical Data used on the cluster. | [optional] 
**StorageEfficiency** | **long?** | Storage Efficiency is the ratio of LogicalUsedBytes / RawUsedBytes. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


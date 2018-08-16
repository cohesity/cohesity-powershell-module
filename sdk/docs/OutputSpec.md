# IO.Swagger.Model.OutputSpec
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NumReduceShards** | **int?** | Number of reduce shards. | [optional] 
**OutputDir** | **string** | Name of output directory. | [optional] 
**PartitionId** | **long?** | Partition id where output will go. | [optional] 
**ReduceOutputPrefix** | **string** | Prefix of the reduce output files. File names will be: ${reduce_output_prefix}-00000-of-00100 if num_reduce_shards&#x3D;100 This name can contain some path components. e.g. \&quot;awb_results/run1\&quot; is a valid value. output_dir is deprecated. | [optional] 
**ViewBoxId** | **long?** | Viewbox id where the output will go. | [optional] 
**ViewName** | **string** | Name of the view where output will go. This will be filled up by yoda. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


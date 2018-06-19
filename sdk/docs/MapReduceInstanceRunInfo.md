# IO.Swagger.Model.MapReduceInstanceRunInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EndTime** | **long?** | Time when map redcue job completed. | [optional] 
**ErrorMessage** | **string** | If this run failed, then error message for failure. | [optional] 
**ExecutionStartTimeUsecs** | **long?** | Time (in usecs) when job was picked up for execution. | [optional] 
**FilesProcessed** | **int?** | Number of files processed in this run. | [optional] 
**MapDoneTimeUsecs** | **long?** | Time (in usecs) when map tasks were done. | [optional] 
**MapInputBytes** | **long?** | Total size of data processed by this run in bytes. | [optional] 
**MappersSpawned** | **int?** | Number of mappers spawned till now. | [optional] 
**NumMapOutputs** | **long?** | Number of outputs from mappers. | [optional] 
**NumReduceOutputs** | **long?** | Number of outputs from reducers. | [optional] 
**PercentageCompletion** | **float?** | Percentage completion of this run so far. | [optional] 
**PercentageMapperCompletion** | **float?** | Percentage of mapper phase completed. | [optional] 
**PercentageReducerCompletion** | **float?** | Percentage of reducer phase completed. | [optional] 
**ReducersSpawned** | **int?** | Number of reducers spawned till now. | [optional] 
**RemainingTimeMins** | **int?** | Expected remaining time in minutes for completion of this run. | [optional] 
**StartTime** | **long?** | Time when map reduce job was started by user. | [optional] 
**Status** | **int?** | Status of this run. | [optional] 
**TotalNumMappers** | **int?** | Total number of mappers to be spawned. | [optional] 
**TotalNumReducers** | **int?** | Total number of reducers to be spawned. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


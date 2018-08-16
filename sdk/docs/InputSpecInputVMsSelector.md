# IO.Swagger.Model.InputSpecInputVMsSelector
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FileTimeFilter** | [**InputSpecFileTimeFilter**](InputSpecFileTimeFilter.md) | Time filter for file&#39;s last change time. | [optional] 
**FilenameGlob** | **List&lt;string&gt;** | After VMDKs are selected as above, the files within them can be selected by using these predicates. | [optional] 
**JobIds** | **List&lt;long?&gt;** |  | [optional] 
**MaxSnapshotTimestamp** | **long?** | Exclusive end of snapshot_timestamp range. If missing, inf will be used as the timestamp range. | [optional] 
**MinSnapshotTimestamp** | **long?** | Inclusive. If missing, 0 will the default lower end of timestamp range | [optional] 
**PartitionIds** | **List&lt;long?&gt;** |  | [optional] 
**ProcessLatestOnly** | **bool?** | Boolean flag to indicate if only latest snapshot of each object should be processed. | [optional] 
**RootDir** | **string** | Within each volume, traversal will be rooted at this directory. A typical value here might be /home | [optional] 
**SourceEntityIds** | **List&lt;long?&gt;** |  | [optional] 
**ViewBoxIds** | **List&lt;long?&gt;** |  | [optional] 
**ViewNames** | **List&lt;string&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


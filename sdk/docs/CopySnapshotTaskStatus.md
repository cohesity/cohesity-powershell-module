# IO.Swagger.Model.CopySnapshotTaskStatus
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Error** | **string** | Specifies if an error occurred (if any) while running this task. This field is populated when the status is equal to &#39;kFailure&#39;. | [optional] 
**Source** | [**ProtectionSource**](ProtectionSource.md) | Specifies the source object whose snapshot is replicated. This is specified for replication targets. | [optional] 
**Stats** | [**CopyRunStats**](CopyRunStats.md) | Specifies the stats of the replication or the archival task. | [optional] 
**Status** | **string** | Specifies the status of the source object being protected. &#39;kAccepted&#39; indicates the task is queued to run but not yet running. &#39;kRunning&#39; indicates the task is running. &#39;kCanceling&#39; indicates a request to cancel the task has occurred but the task is not yet canceled. &#39;kCanceled&#39; indicates the task has been canceled. &#39;kSuccess&#39; indicates the task was successful. &#39;kFailure&#39; indicates the task failed. | [optional] 
**TaskEndTimeUsecs** | **long?** | Specifies the end time of the copy task. The end time is specified as a Unix epoch Timestamp (in microseconds). | [optional] 
**TaskStartTimeUsecs** | **long?** | Specifies the start time of the copy task. The start time is specified as a Unix epoch Timestamp (in microseconds). Copy run task is started after completing backup tasks. It may spawn sub-tasks to copy or replicate individual snapshots. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


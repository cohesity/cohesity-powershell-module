# IO.Swagger.Model.ProtectionSourceSnapshotInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CopyTasks** | [**List&lt;SnapshotCopyTask&gt;**](SnapshotCopyTask.md) | Specifies a list of copy tasks (such as replication and archival tasks). | [optional] 
**JobId** | **long?** | Specifies the id of the Protection Job. | [optional] 
**JobName** | **string** | Specifies the name of the Protection Job. | [optional] 
**JobRunId** | **long?** | Specifies the id of the Job Run. | [optional] 
**LastRunEndTimeUsecs** | **long?** | Specifies the end time of the last Job Run. The time is specified in Unix epoch Timestamp (in microseconds). | [optional] 
**LastRunStartTimeUsecs** | **long?** | Specifies the start time of the last Job Run. The time is specified in Unix epoch Timestamp (in microseconds). | [optional] 
**Message** | **string** | Specifies warning or error information when the Job Run is not successful. | [optional] 
**NumBytesRead** | **long?** | Specifies the total number of bytes read. | [optional] 
**NumLogicalBytesProtected** | **long?** | Specifies the total number of logical bytes that are protected. The logical size is when the data is fully hydrated or expanded. | [optional] 
**PaginationCookie** | **int?** | Specifies an opaque string to pass into the next request to get the next set of Snapshots for pagination purposes. If null, this is the last set of Snapshots or the number of Snapshots returned is equal to or less than the specified pageCount. | [optional] 
**RunStatus** | **string** | Specifies the type of the Job Run. &#39;kSuccess&#39; indicates that the Job Run was successful. &#39;kRunning&#39; indicates that the Job Run is currently running. &#39;kWarning&#39; indicates that the Job Run was successful but warnings were issued. &#39;kCancelled&#39; indicates that the Job Run was canceled. &#39;kError&#39; indicates the Job Run encountered an error and did not run to completion. | [optional] 
**RunType** | **string** | Specifies the status of the Job Run. &#39;kRegular&#39; indicates an incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


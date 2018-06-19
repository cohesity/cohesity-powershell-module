# IO.Swagger.Model.ProtectionSourcesSummaryStats
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FirstFailedRunTimeUsecs** | **long?** | Specifies the start time of the first failed Job Run protecting this Protection Source Object. The time is specified as a Unix epoch Timestamp (in microseconds). | [optional] 
**FirstSuccessfulRunTimeUsecs** | **long?** | Specifies the start time of the first successful Job Run protecting this Protection Source Object. The time is specified as a Unix epoch Timestamp (in microseconds). | [optional] 
**LastFailedRunTimeUsecs** | **long?** | Specifies the start time of the last failed Job Run protecting this Protection Source Object. The time is specified as a Unix epoch Timestamp (in microseconds). | [optional] 
**LastRunEndTimeUsecs** | **long?** | Specifies the end time of the last Job Run protecting this Protection Source Object. The time is specified as a Unix epoch Timestamp (in microseconds). | [optional] 
**LastRunErrorMsg** | **string** | Specifies the error message associated with last run, if the last run has failed. | [optional] 
**LastRunStartTimeUsecs** | **long?** | Specifies the start time of the last Job Run protecting this Protection Source Object. The time is specified as a Unix epoch Timestamp (in microseconds). | [optional] 
**LastRunStatus** | **string** | Specifies the Job Run status of the last Job Run protecting this Protection Source Object. &#39;kSuccess&#39; indicates that the Job Run was successful. &#39;kRunning&#39; indicates that the Job Run is currently running. &#39;kWarning&#39; indicates that the Job Run was successful but warnings were issued. &#39;kCancelled&#39; indicates that the Job Run was canceled. &#39;kError&#39; indicates the Job Run encountered an error and did not run to completion. | [optional] 
**LastRunType** | **string** | Specifies the Job Run type of the last Job Run protecting this Protection Source Object. &#39;kRegular&#39; indicates an incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time. | [optional] 
**LastSuccessfulRunTimeUsecs** | **long?** | Specifies the start time of the last successful Job Run protecting this Protection Source Object. The time is specified as a Unix epoch Timestamp (in microseconds). | [optional] 
**NumDataReadBytes** | **long?** | Specifies the total number of bytes read while protecting this Protection Source Object. | [optional] 
**NumErrors** | **int?** | Specifies the total number of errors reported during Job Runs of this Protection Source Object. | [optional] 
**NumLogicalBytesProtected** | **long?** | Specifies the total logical bytes protected for this Protection Source Object. The logical size is when the data is fully hydrated or expanded. | [optional] 
**NumSnapshots** | **int?** | Specifies the total number of Snapshots that are backing up this Protection Source Object. | [optional] 
**NumSuccessRuns** | **int?** | Specifies the total number of successful Job Runs protecting this Protection Source Object. | [optional] 
**NumWarnings** | **int?** | Specifies the total number of warnings reported during Job Runs of this Protection Source Object. | [optional] 
**ProtectionSource** | [**ProtectionSource3**](ProtectionSource3.md) |  | [optional] 
**RegisteredSource** | **string** | Specifies the name of the Registered Source that is the top level parent of the specified Protection Source Object. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


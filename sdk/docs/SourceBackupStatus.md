# IO.Swagger.Model.SourceBackupStatus
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrentSnapshotInfo** | [**SnapshotInfo**](SnapshotInfo.md) | Specifies details about the snapshot captured to backup the source object (such as a VM). | [optional] 
**Error** | **string** | Specifies if an error occurred (if any) while running this task. This field is populated when the status is equal to &#39;kFailure&#39;. | [optional] 
**IsFullBackup** | **bool?** | Specifies whether this is a &#39;kFull&#39; or &#39;kRegular&#39; backup of the Run. This may be true even if the scheduled backup type is &#39;kRegular&#39;. This will happen when this run corresponds to the first backup run of the Job or if no previous snapshot information is found. | [optional] 
**NumRestarts** | **int?** | Specifies the number of times the the task was restarted because of the changes on the backup source host. | [optional] 
**ParentSourceId** | **long?** | Specifies the id of the registered Protection Source that is the parent of the Objects that are protected by this Job Run. | [optional] 
**Quiesced** | **bool?** | Specifies if app-consistent snapshot was captured. This field is set to true, if an app-consistent snapshot was taken by quiescing applications and the file system before taking a backup. | [optional] 
**SlaViolated** | **bool?** | Specifies if the SLA was violated for the Job Run. This field is set to true, if time to complete the Job Run is longer than the SLA specified. This field is populated when the status is set to &#39;kSuccess&#39; or &#39;kFailure&#39;. | [optional] 
**Source** | [**ProtectionSource**](ProtectionSource.md) | Specifies the source object to protect. | [optional] 
**Stats** | [**BackupSourceStats**](BackupSourceStats.md) | Specifies the stats of the Backup Run task for the Protection Source. | [optional] 
**Status** | **string** | Specifies the status of the source object being protected. &#39;kAccepted&#39; indicates the task is queued to run but not yet running. &#39;kRunning&#39; indicates the task is running. &#39;kCanceling&#39; indicates a request to cancel the task has occurred but the task is not yet canceled. &#39;kCanceled&#39; indicates the task has been canceled. &#39;kSuccess&#39; indicates the task was successful. &#39;kFailure&#39; indicates the task failed. | [optional] 
**Warnings** | **List&lt;string&gt;** | Specifies the warnings that occurred (if any) while running this task. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


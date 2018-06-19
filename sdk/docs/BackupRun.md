# IO.Swagger.Model.BackupRun
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Environment** | **string** | Specifies the environment type that the task is protecting. Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. | [optional] 
**Error** | **string** | Specifies if an error occurred (if any) while running this task. This field is populated when the status is equal to &#39;kFailure&#39;. | [optional] 
**JobRunId** | **long?** | Specifies the id of the Job Run that ran the backup task and the copy tasks. | [optional] 
**Message** | **string** | Specifies a message after finishing the task successfully. This field is optionally populated when the status is equal to &#39;kSuccess&#39;. | [optional] 
**MetadataDeleted** | **bool?** | Specifies if the metadata and snapshots associated with this Job Run have been deleted. This field is set to true when the snapshots, which are marked for deletion, are removed by garbage collection. The associated metadata is also deleted. | [optional] 
**Quiesced** | **bool?** | Specifies if app-consistent snapshot was captured. This field is set to true, if an app-consistent snapshot was taken by quiescing applications and the file system before taking a backup. | [optional] 
**RunType** | **string** | Specifies the type of backup such as &#39;kRegular&#39;, &#39;kFull&#39;, &#39;kLog&#39; or &#39;kSystem&#39;. &#39;kRegular&#39; indicates a incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time. &#39;kSystem&#39; indicates a system backup. System backups are used to do bare metal recovery of the system to a specific point in time. | [optional] 
**SlaViolated** | **bool?** | Specifies if the SLA was violated for the Job Run. This field is set to true, if time to complete the Job Run is longer than the SLA specified. This field is populated when the status is set to &#39;kSuccess&#39; or &#39;kFailure&#39;. | [optional] 
**SnapshotsDeleted** | **bool?** | Specifies if backup snapshots associated with this Job Run have been marked for deletion because of the retention settings in the Policy or if they were manually deleted from the Cohesity Dashboard. | [optional] 
**SnapshotsDeletedTimeUsecs** | **long?** | Specifies if backup snapshots associated with this Job Run have been marked for deletion because of the retention settings in the Policy or if they were manually deleted from the Cohesity Dashboard. | [optional] 
**SourceBackupStatus** | [**List&lt;SourceBackupStatus&gt;**](SourceBackupStatus.md) | Specifies the status of backing up each source objects (such as VMs) associated with the job. | [optional] 
**Stats** | [**ProtectionJobRunStats**](ProtectionJobRunStats.md) | Specifies the aggregated stats of all Backup Run tasks in a Protection Run. | [optional] 
**Status** | **string** | Specifies the status of Backup task such as &#39;kRunning&#39;, &#39;kSuccess&#39;, &#39;kFailure&#39; etc. &#39;kAccepted&#39; indicates the task is queued to run but not yet running. &#39;kRunning&#39; indicates the task is running. &#39;kCanceling&#39; indicates a request to cancel the task has occurred but the task is not yet canceled. &#39;kCanceled&#39; indicates the task has been canceled. &#39;kSuccess&#39; indicates the task was successful. &#39;kFailure&#39; indicates the task failed. | [optional] 
**Warnings** | **List&lt;string&gt;** | Specifies the warnings that occurred (if any) while running this task. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


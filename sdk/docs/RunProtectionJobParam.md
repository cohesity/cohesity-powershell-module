# IO.Swagger.Model.RunProtectionJobParam
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CopyRunTargets** | [**List&lt;RunJobSnapshotTarget&gt;**](RunJobSnapshotTarget.md) | Optional parameter to be set if you want specific replication or archival associated with the policy to run. | [optional] 
**RunType** | **string** | Specifies the type of backup. If not specified, &#39;kRegular&#39; is assumed. &#39;kRegular&#39; indicates a incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time. &#39;kSystem&#39; indicates a system backup. System backups are used to do bare metal recovery of the system to a specific point in time. | [optional] 
**SourceIds** | **List&lt;long?&gt;** | Optional parameter if you want to back up only a subset of sources that are protected by the job in this run. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


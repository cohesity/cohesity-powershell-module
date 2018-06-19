# IO.Swagger.Model.SnapshotVersion
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AttemptNumber** | **long?** | Specifies the number of the attempts made by the Job Run to capture a snapshot of the object. For example, if an snapshot is successfully captured after three attempts, this field equals 3. | [optional] 
**DeltaSizeBytes** | **long?** | Specifies the size of the data captured from the source object. For a full backup (where Change Block Tracking is not utilized) this field is equal to logicalSizeBytes. For an incremental backup (where Change Block Tracking is utilized), this field specifies the size of the data that has changed since the last backup. | [optional] 
**IsAppConsistent** | **bool?** | Specifies if an app-consistent snapshot was captured. For example, was the VM was quiesced before the snapshot was captured. | [optional] 
**IsFullBackup** | **bool?** | Specifies if the snapshot is a full backup. For example, all blocks of the VM is captured and Change Block Tracking is not utilized. | [optional] 
**JobRunId** | **long?** | Specifies the id of the Job Run that captured the snapshot. | [optional] 
**LocalMountPath** | **string** | Specifies the local path relative to the View, without the ViewBox/View prefix. | [optional] 
**LogicalSizeBytes** | **long?** | Specifies the size of the snapshot if the data is fully hydrated or expanded and not reduced by change-block tracking, compression and deduplication. For example if a VMDK of size 100GB is created with thin provisioning and the disk size to store the VMDK is 20GB. The logical size of this object is 100GB and the physical size is 20GB. | [optional] 
**PhysicalSizeBytes** | **long?** | Specifies the amount of data actually used on the disk to store this object after being reduced by change-block tracking, compression and deduplication. | [optional] 
**PrimaryPhysicalSizeBytes** | **long?** | Specifies the total amount of disk space used to store this object on the primary storage. For example the total amount of disk space used to store the VM files (such as the VMDK files) on the primary datastore. | [optional] 
**StartedTimeUsecs** | **long?** | Specifies the time when the Job Run starts capturing a snapshot. Specified as a Unix epoch Timestamp (in microseconds). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# IO.Swagger.Model.BackupSourceStats
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdmittedTimeUsecs** | **long?** | Specifies the time the task was unqueued from the queue to start running. This field can be used to determine the following times: initial-wait-time &#x3D; admittedTimeUsecs - startTimeUsecs run-time &#x3D; endTimeUsecs - admittedTimeUsecs If the task ends up waiting in other queues, then actual run-time will be smaller than the run-time computed this way. This field is only populated for Backup tasks currently. | [optional] 
**EndTimeUsecs** | **long?** | Specifies the end time of the Protection Run. The end time is specified as a Unix epoch Timestamp (in microseconds). | [optional] 
**StartTimeUsecs** | **long?** | Specifies the start time of the Protection Run. The start time is specified as a Unix epoch Timestamp (in microseconds). This time is when the task is queued to an internal queue where tasks are waiting to run. | [optional] 
**TimeTakenUsecs** | **long?** | Specifies the actual execution time for the protection run to complete the backup task and the copy tasks. This time will not include the time waited in various internal queues. This field is only populated for Backup tasks currently. | [optional] 
**TotalBytesReadFromSource** | **long?** | Specifies the total amount of data read from the source (so far). | [optional] 
**TotalBytesToReadFromSource** | **long?** | Specifies the total amount of data expected to be read from the source. | [optional] 
**TotalLogicalBackupSizeBytes** | **long?** | Specifies the size of the source object (such as a VM) protected by this task on the primary storage after the snapshot is taken. The logical size of the data on the source if the data is fully hydrated or expanded and not reduced by change-block tracking, compression and deduplication. | [optional] 
**TotalPhysicalBackupSizeBytes** | **long?** | Specifies the total amount of physical space used on the Cohesity Cluster to store the protected object after being reduced by change-block tracking, compression and deduplication. For example, if the logical backup size is 1GB, but only 1MB was used on the Cohesity Cluster to store it, this field be equal to 1MB. | [optional] 
**TotalSourceSizeBytes** | **long?** | Specifies the size of the source object (such as a VM) protected by this task on the primary storage before the snapshot is taken. The logical size of the data on the source if the data is fully hydrated or expanded and not reduced by change-block tracking, compression and deduplication. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


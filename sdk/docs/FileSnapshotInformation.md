# IO.Swagger.Model.FileSnapshotInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HasArchivalCopy** | **bool?** | If true, this snapshot is located on an archival target (such as a tape or AWS). | [optional] 
**HasLocalCopy** | **bool?** | If true, this snapshot is located on a local Cohesity Cluster. | [optional] 
**HasRemoteCopy** | **bool?** | If true, this snapshot is located on a Remote Cohesity Cluster. | [optional] 
**ModifiedTimeUsecs** | **long?** | Specifies the time when the file or folder was last modified. Specified as a Unix epoch Timestamp (in microseconds). | [optional] 
**SizeBytes** | **long?** | Specifies the size of the file or folder in bytes. | [optional] 
**Snapshot** | [**SnapshotAttempt**](SnapshotAttempt.md) | Specifies the snapshot that contains the specified file or folder. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


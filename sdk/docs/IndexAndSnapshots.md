# IO.Swagger.Model.IndexAndSnapshots
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ArchiveTaskUid** | [**ArchiveTaskUid_**](ArchiveTaskUid_.md) |  | [optional] 
**EndTimeUsecs** | **long?** | Specifies the end time as a Unix epoch Timestamp (in microseconds). If set, only index and Snapshots for Protection Job Runs that started before the specified end time are restored. | [optional] 
**RemoteProtectionJobUid** | [**ProtectionJobUid_**](ProtectionJobUid_.md) |  | [optional] 
**StartTimeUsecs** | **long?** | Specifies the start time as a Unix epoch Timestamp (in microseconds). If set, only the index and Snapshots for Protection Job Runs that started after the specified start time are restored. | [optional] 
**ViewBoxId** | **long?** | Specifies the id of the local Storage Domain (View Box) where the index and the Snapshot will be restored to. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


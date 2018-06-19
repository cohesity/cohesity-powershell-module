# IO.Swagger.Model.RestoreObject_
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ArchivalTarget** | [**ArchivalTarget_**](ArchivalTarget_.md) |  | [optional] 
**JobId** | **long?** | Protection Job Id.  Specifies id of the Protection Job that backed up the objects to be restored. | [optional] 
**JobRunId** | **long?** | Specifies the id of the Job Run that captured the snapshot. | [optional] 
**JobUid** | [**UniversalId_**](UniversalId_.md) |  | [optional] 
**ProtectionSourceId** | **long?** | Specifies the id of the leaf object to recover, clone or recover files/folders from. | [optional] 
**StartedTimeUsecs** | **long?** | Specifies the time when the Job Run starts capturing a snapshot. Specified as a Unix epoch Timestamp (in microseconds). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


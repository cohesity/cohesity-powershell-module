# IO.Swagger.Model.CancelProtectionJobRunParam
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CopyTaskUid** | [**UniversalId**](UniversalId.md) | CopyTaskUid is the Uid of a copy task. If a particular copy task is to be cancelled, this field should be set to the id of that particular copy task. For example, if replication task is to be canceled, CopyTaskUid of the replication task has to be specified. | [optional] 
**JobRunId** | **long?** | Run Id of a Protection Job Run that needs to be cancelled. If this Run id does not match the id of an active Run in the Protection job, the job Run is not cancelled and an error will be returned. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# IO.Swagger.Model.ClusterAuditLog
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **string** | Specifies the action that caused the log to be generated. | [optional] 
**Details** | **string** | Specifies more information about the action. | [optional] 
**Domain** | **string** | Specifies the domain of the user who caused the action that generated the log. | [optional] 
**EntityId** | **string** | Specifies the id of the entity (object) that the action is invoked on. | [optional] 
**EntityName** | **string** | Specifies the entity (object) name that the action is invoked on. For example, if a Job called BackupEng is paused, this field returns BackupEng. | [optional] 
**EntityType** | **string** | Specifies the type of the entity (object) that the action is invoked on. For example, if a Job called BackupEng is paused, this field returns &#39;Protection Job&#39;. | [optional] 
**HumanTimestamp** | **string** | Specifies the time when the log was generated. The time is specified using a human readable timestamp. | [optional] 
**NewRecord** | **string** | Specifies the record after the action is invoked. | [optional] 
**PreviousRecord** | **string** | Specifies the record before the action is invoked. | [optional] 
**TimestampUsecs** | **long?** | Specifies the time when the log was generated. The time is specified using a Unix epoch Timestamp (in microseconds). | [optional] 
**UserName** | **string** | Specifies the user who caused the action that generated the log. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


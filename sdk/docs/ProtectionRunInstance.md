# IO.Swagger.Model.ProtectionRunInstance
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BackupRun** | [**BackupRun**](BackupRun.md) | Specifies details about the Backup task. A Backup task captures the original backup snapshots. | [optional] 
**CopyRun** | [**List&lt;CopyRun&gt;**](CopyRun.md) | Specifies details about the Copy tasks of this Job Run. A Copy task copies the captured snapshots to an external target or a Remote Cohesity Cluster. | [optional] 
**JobId** | **long?** | Specifies the id of the Protection Job that was run. | [optional] 
**JobName** | **string** | Specifies the name of the Protection Job name that was run. | [optional] 
**JobUid** | [**UniqueGlobalId6**](UniqueGlobalId6.md) |  | [optional] 
**ViewBoxId** | **long?** | Specifies the Storage Domain (View Box) to store the backed up data. Specify the id of the Storage Domain (View Box). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


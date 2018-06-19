# IO.Swagger.Model.CreateRemoteVaultRestoreTaskParameters
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RestoreObjects** | [**List&lt;IndexAndSnapshots&gt;**](IndexAndSnapshots.md) | Specifies the list of Snapshots and the index to be restored from the remote Vault. The data on the remote Vault may have been originally archived from multiple remote Clusters. | [optional] 
**SearchJobUid** | [**SearchJobUid_**](SearchJobUid_.md) |  | 
**TaskName** | **string** | Specifies a name of the restore task. | 
**VaultId** | **long?** | Specifies the id of the Vault that contains the index and Snapshots to restore to the current Cluster. This is the id assigned by the Cohesity Cluster when Vault was registered as an External Target. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


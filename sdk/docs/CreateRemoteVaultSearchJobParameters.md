# IO.Swagger.Model.CreateRemoteVaultSearchJobParameters
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClusterMatchString** | **string** | Filter by specifying a Cluster name prefix string. Only Clusters with names that start with this prefix string are returned in the search result. If not set, all Clusters archiving data to the Vault are returned in the search results. | [optional] 
**EncryptionKeys** | [**List&lt;VaultEncryptionKey&gt;**](VaultEncryptionKey.md) | Specifies an optional list of encryption keys that may be needed to search and restore data that was archived to a remote Vault. Archived data cannot be searched or restored without the corresponding encryption key used by the original Cluster to archive the data. Encryption keys can be uploaded using the REST API public/remoteVaults/encryptionKeys operation. If the key is already uploaded, this field does not need to be specified. | [optional] 
**EndTimeUsecs** | **long?** | Filter by a end time specified as a Unix epoch Timestamp (in microseconds). Only Job Runs that completed before the specified end time are included in the search results. | [optional] 
**JobMatchString** | **string** | Filter by specifying a Protection Job name prefix string. Only Protection Jobs with names that start with this prefix string are returned in the search result. If not set, all Protection Jobs archiving data to the Vault are returned in the search results. | [optional] 
**SearchJobName** | **string** | Specifies the search Job name. | 
**StartTimeUsecs** | **long?** | Filter by a start time specified as a Unix epoch Timestamp (in microseconds). Only Job Runs that started after the specified time are included in the search results. | [optional] 
**VaultId** | **long?** | Specifies the id of the Vault to search. This id was assigned by the local Cohesity Cluster when Vault was registered as an External Target. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


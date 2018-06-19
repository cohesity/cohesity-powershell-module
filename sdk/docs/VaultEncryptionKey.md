# IO.Swagger.Model.VaultEncryptionKey
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClusterName** | **string** | Specifies the name of the source Cohesity Cluster that archived the data on the Vault. | [optional] 
**EncryptionKeyData** | **string** | Specifies the encryption key data corresponding to the specified keyUid. It contains a Key Encryption Key (KEK) or a Encrypted Data Encryption Key (eDEK). | [optional] 
**KeyUid** | [**UniversalId1**](UniversalId1.md) |  | [optional] 
**VaultId** | **long?** | Specifies the id of the Vault whose data is encrypted by this key. | [optional] 
**VaultName** | **string** | Specifies the name of the Vault whose data is encrypted by this key. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


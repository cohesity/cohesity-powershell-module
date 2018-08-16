# IO.Swagger.Model.VaultConfig
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amazon** | [**AmazonCloudCredentials**](AmazonCloudCredentials.md) | Specifies the cloud credentials to connect to a Amazon service account. Glacier, S3, and S3-compatible clouds use this credential. | [optional] 
**Azure** | [**AzureCloudCredentials**](AzureCloudCredentials.md) | Specifies the cloud credentials to connect to a Microsoft Azure service account. | [optional] 
**BucketName** | **string** | Specifies the name of a storage location of the Vault, where objects are stored. For Google and AMS, this storage location is called a bucket. For Microsoft Azure, this storage location is called a container. For QStar and NAS, you do not specify a storage location. | [optional] 
**Google** | [**GoogleCloudCredentials**](GoogleCloudCredentials.md) | Specifies the cloud credentials to connect to a Google service account. | [optional] 
**Nas** | [**NasCredentials**](NasCredentials.md) | Specifies the server credentials to connect to a NetApp server. | [optional] 
**Qstar** | [**QStarServerCredentials**](QStarServerCredentials.md) | Specifies the server credentials to connect to a QStar service to manage the media Vault. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


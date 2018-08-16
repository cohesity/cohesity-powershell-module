# IO.Swagger.Model.Vault
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CompressionPolicy** | **string** | Specifies whether to send data to the Vault in a compressed format. &#39;kCompressionNone&#39; indicates that data is not compressed. &#39;kCompressionLow&#39; indicates that data is compressed. | [optional] 
**Config** | [**VaultConfig**](VaultConfig.md) | Specifies the settings required to connect to the Vault (External Target). | [optional] 
**CustomerManagingEncryptionKeys** | **bool?** | Specifies whether to manage the encryption key manually or let the Cohesity Cluster manage it. If true, you must get the encryption key store it outside the Cluster, before disaster strikes such as the source local Cohesity Cluster being down. You can get the encryption key by downloading it using the Cohesity Dashboard or by calling the GET /public/vaults/encryptionKey/{id} operation. | [optional] 
**DedupEnabled** | **bool?** | Specifies whether to deduplicate data before sending it to the Vault. | [optional] 
**Description** | **string** | Specifies a description about the Vault. | [optional] 
**DesiredWalLocation** | **int?** | Desired location for write ahead logs(wal). | [optional] 
**EncryptionKeyFileDownloaded** | **bool?** | Specifies if the encryption key file has been downloaded using the Cohesity Dashboard (Cohesity UI). If true, the encryption key has been downloaded using the Cohesity Dashboard. An encryption key can only be downloaded once using the Cohesity Dashboard. | [optional] 
**EncryptionPolicy** | **string** | Specifies whether to send and store data in an encrypted format. &#39;kEncryptionNone&#39; indicates the data is not encrypted. &#39;kEncryptionStrong&#39; indicates the data is encrypted. | [optional] 
**FullArchiveIntervalDays** | **long?** | Specifies the number days between full archives to the Vault. The current default is 90 days. This is only meaningful when incrementalArchivesEnabled is true and the Vault usage type is kArchival. | [optional] 
**Id** | **long?** | Specifies an id that identifies the Vault. | [optional] 
**IncrementalArchivesEnabled** | **bool?** | Specifies whether to perform incremental archival when sending data to the Vault. If false, only full backups are performed. If true, incremental backups are performed between the full backups. | [optional] 
**KeyFileDownloadTimeUsecs** | **long?** | Specifies the time (in microseconds) when the encryption key file was downloaded from the Cohesity Dashboard (Cohesity UI). An encryption key can only be downloaded once using the Cohesity Dashboard. | [optional] 
**KeyFileDownloadUser** | **string** | Specifies the user who downloaded the encryption key from the Cohesity Dashboard (Cohesity UI). This field is only populated if encryption is enabled for the Vault and customerManagingEncryptionKeys is true. | [optional] 
**Name** | **string** | Specifies the name of the Vault. | [optional] 
**Type** | **string** | Specifies the type of Vault. &#39;kNearline&#39; indicates a Google Nearline Vault. &#39;kColdline&#39; indicates a Google Coldline Vault. &#39;kGlacier&#39; indicates a AWS Glacier Vault. &#39;kS3&#39; indicates a AWS S3 Vault. &#39;kAzureStandard&#39; indicates a Microsoft Azure Standard Vault. &#39;kS3Compatible&#39; indicates a AWS S3 Compatible Vault. (See the online help for supported types.) &#39;kQStarTape&#39; indicates a QStar Tape Vault. &#39;kGoogleStandard&#39; indicates a Google Standard Vault. &#39;kGoogleDRA&#39; indicates a Google DRA Vault. &#39;kAWSGovCloud&#39; indicates a AWS Gov Cloud Vault. &#39;kNAS&#39; indicates a NAS Vault. &#39;kAzureGovCloud&#39; indicates an Microsoft Azure Gov Cloud Vault. | [optional] 
**UsageType** | **string** | Specifies the usage type of the Vault. &#39;kArchival&#39; indicates the Vault provides archive storage for backup data. &#39;kCloudSpill&#39; indicates the Vault provides additional storage for cold data. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


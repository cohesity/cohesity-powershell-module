# IO.Swagger.Model.DataTransferToVaultSummary
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DataTransferPerProtectionJob** | [**List&lt;DataTransferToVaultPerProtectionJob&gt;**](DataTransferToVaultPerProtectionJob.md) | Specifies the data transfer summary statistics for each Protection Job that is transferring data from this Cohesity Cluster to this Vault (External Target). | [optional] 
**LogicalDataTransferredBytesDuringTimeRange** | **List&lt;long?&gt;** | Specifies the logical data transferred from this Cohesity Cluster to this Vault during the time period specified using the startTimeMsecs and endTimeMsecs parameters. For each day in the time period, an array element is returned, for example if 7 days are specified, 7 array elements are returned. The logical size is when the data is fully hydrated or expanded. | [optional] 
**NumLogicalBytesTransferred** | **long?** | Specifies the total number of logical bytes that are transferred from this Cohesity Cluster to this Vault. The logical size is when the data is fully hydrated or expanded. | [optional] 
**NumPhysicalBytesTransferred** | **long?** | Specifies the total number of physical bytes that are transferred from this Cohesity Cluster to this Vault. | [optional] 
**NumProtectionJobs** | **long?** | Specifies the number of Protection Jobs that transfer data to this Vault. | [optional] 
**PhysicalDataTransferredBytesDuringTimeRange** | **List&lt;long?&gt;** | Specifies the physical data transferred from this Cohesity Cluster to this Vault during the time period specified using the startTimeMsecs and endTimeMsecs parameters. For each day in the time period, an array element is returned, for example if 7 days are specified, 7 array elements are returned. | [optional] 
**StorageConsumedBytes** | **long?** | Specifies the storage consumed on the Vault as of last day in the specified time range. | [optional] 
**VaultId** | **long?** | The vault Id associated with the vault. | [optional] 
**VaultName** | **string** | Specifies the name of the Vault (External Target). | [optional] 
**VaultType** | **string** | Specifies the type of Vault. &#39;kNearline&#39; indicates a Google Nearline Vault. &#39;kColdline&#39; indicates a Google Coldline Vault. &#39;kGlacier&#39; indicates a AWS Glacier Vault. &#39;kS3&#39; indicates a AWS S3 Vault. &#39;kAzureStandard&#39; indicates a Microsoft Azure Standard Vault. &#39;kS3Compatible&#39; indicates a AWS S3 Compatible Vault. (See the online help for supported types.) &#39;kQStarTape&#39; indicates a QStar Tape Vault. &#39;kGoogleStandard&#39; indicates a Google Standard Vault. &#39;kGoogleDRA&#39; indicates a Google DRA Vault. &#39;kAWSGovCloud&#39; indicates a AWS Gov Cloud Vault. &#39;kNAS&#39; indicates a NAS Vault. &#39;kAzureGovCloud&#39; indicates an Microsoft Azure Gov Cloud Vault. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


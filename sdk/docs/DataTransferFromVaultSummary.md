# IO.Swagger.Model.DataTransferFromVaultSummary
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DataTransferPerTask** | [**List&lt;DataTransferFromVaultPerTask&gt;**](DataTransferFromVaultPerTask.md) | Specifies the transfer of data from this Vault to this Cohesity Cluster for each clone or recover task. | [optional] 
**NumLogicalBytesTransferred** | **long?** | Specifies the total number of logical bytes that have been transferred from this Vault (External Target) to this Cohesity Cluster. The logical size is when the data is fully hydrated or expanded. | [optional] 
**NumPhysicalBytesTransferred** | **long?** | Specifies the total number of physical bytes that have been transferred from this Vault (External Target) to the Cohesity Cluster. | [optional] 
**NumTasks** | **long?** | Specifies the number of recover or clone tasks that have transferred data from this Vault (External Target) to this Cohesity Cluster. | [optional] 
**PhysicalDataTransferredBytesDuringTimeRange** | **List&lt;long?&gt;** | Specifies the physical data transferred from this Vault to the Cohesity Cluster during the time period specified using the startTimeMsecs and endTimeMsecs parameters. For each day in the time period, an array element is returned, for example if 7 days are specified, 7 array elements are returned. | [optional] 
**VaultName** | **string** | Specifies the name of the Vault (External Target). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


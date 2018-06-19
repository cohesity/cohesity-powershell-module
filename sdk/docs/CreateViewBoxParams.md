# IO.Swagger.Model.CreateViewBoxParams
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdDomainName** | **string** | Specifies an active directory domain that this view box is mapped to. | [optional] 
**ClusterPartitionId** | **long?** | Specifies the Cluster Partition id where the Storage Domain (View Box) is located. | 
**DefaultUserQuotaPolicy** | [**QuotaPolicy1**](QuotaPolicy1.md) |  | [optional] 
**DefaultViewQuotaPolicy** | [**QuotaPolicy2**](QuotaPolicy2.md) |  | [optional] 
**Name** | **string** | Specifies the name of the Storage Domain (View Box). | 
**PhysicalQuota** | [**QuotaPolicy3**](QuotaPolicy3.md) |  | [optional] 
**S3BucketsAllowed** | **bool?** | Specifies whether creation of a S3 bucket is allowed in this Storage Domain (View Box). When a new S3 bucket creation request arrives, we&#39;ll look at all the View Boxes and the first Storage Domain (View Box) that allows creating S3 buckets in it will be the one where the bucket will be placed. | [optional] 
**StoragePolicy** | [**StoragePolicy**](StoragePolicy.md) | Specifies the storage options applied to the Storage Domain (View Box). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


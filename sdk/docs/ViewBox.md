# IO.Swagger.Model.ViewBox
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdDomainName** | **string** | Specifies an active directory domain that this view box is mapped to. | [optional] 
**ClusterPartitionId** | **long?** | Specifies the Cluster Partition id where the Storage Domain (View Box) is located. | 
**ClusterPartitionName** | **string** | Specifies the Cohesity Cluster name where the Storage Domain (View Box) is located. | [optional] 
**DefaultUserQuotaPolicy** | [**QuotaPolicy1**](QuotaPolicy1.md) |  | [optional] 
**DefaultViewQuotaPolicy** | [**QuotaPolicy2**](QuotaPolicy2.md) |  | [optional] 
**Id** | **long?** | Specifies the Id of the Storage Domain (View Box). | [optional] 
**Name** | **string** | Specifies the name of the Storage Domain (View Box). | 
**PhysicalQuota** | [**QuotaPolicy3**](QuotaPolicy3.md) |  | [optional] 
**RemovalState** | **string** | Specifies the current removal state of the Storage Domain (View Box). &#39;kDontRemove&#39; means the state of object is functional and it is not being removed. &#39;kMarkedForRemoval&#39; means the object is being removed. &#39;kOkToRemove&#39; means the object has been removed on the Cohesity Cluster and if the object is physical, it can be removed from the Cohesity Cluster. | [optional] 
**S3BucketsAllowed** | **bool?** | Specifies whether creation of a S3 bucket is allowed in this Storage Domain (View Box). When a new S3 bucket creation request arrives, we&#39;ll look at all the View Boxes and the first Storage Domain (View Box) that allows creating S3 buckets in it will be the one where the bucket will be placed. | [optional] 
**Stats** | [**ViewBoxStats**](ViewBoxStats.md) | Specifies statistics about the Storage Domain (View Box). readOnly: true | [optional] 
**StoragePolicy** | [**StoragePolicy**](StoragePolicy.md) | Specifies the storage options applied to the Storage Domain (View Box). | [optional] 
**TreatFileSyncAsDataSync** | **bool?** | If &#39;true&#39;, when the Cohesity Cluster is writing to a file, the file modification time is not persisted synchronously during the file write, so the modification time may not be accurate. (Typically the file modification time is off by 30 seconds but it can be longer.) Only set to &#39;false&#39; if your environment requires a very accurate modification time. The default value is &#39;true&#39; which provides the best Cohesity Cluster performance. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


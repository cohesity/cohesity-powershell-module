# IO.Swagger.Model.HealthTile
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CapacityBytes** | **long?** | Raw Cluster Capacity in Bytes. This is not usable capacity and does not take replication factor into account. | [optional] 
**ClusterCloudUsageBytes** | **long?** | Usage in Bytes on the cloud. | [optional] 
**LastDayAlerts** | [**List&lt;Alert&gt;**](Alert.md) |  | [optional] 
**LastDayNumCriticals** | **long?** | Number of Critical Alerts. | [optional] 
**LastDayNumWarnings** | **long?** | Number of Warning Alerts. | [optional] 
**NumNodes** | **int?** | Number of nodes in the cluster. | [optional] 
**NumNodesWithIssues** | **int?** | Number of nodes in the cluster that are unhealthy. | [optional] 
**PercentFull** | **float?** | Percent the cluster is full. | [optional] 
**RawUsedBytes** | **long?** | Raw Bytes used in the cluster. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


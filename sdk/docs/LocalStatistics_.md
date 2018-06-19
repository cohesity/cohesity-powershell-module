# IO.Swagger.Model.LocalStatistics_
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DataInBytes** | **long?** | Data brought into the cluster. This is the usage before data reduction if we ignore the zeroes and effects of cloning. | [optional] 
**DataInBytesAfterReduction** | **long?** | Morphed Usage before data is replicated to other nodes as per RF or Erasure Coding policy. | [optional] 
**MinUsablePhysicalCapacityBytes** | **long?** | Specifies the minimum usable capacity available after erasure coding or RF. This will only be populated for cluster. If a cluster has multiple Domains (View Boxes) with different RF or erasure coding, this metric will be computed using the scheme that will provide least saving. | [optional] 
**NumBytesRead** | **long?** | Provides the total number of bytes read in the last 30 seconds. | [optional] 
**NumBytesWritten** | **long?** | Provides the total number of bytes written in the last 30 second. | [optional] 
**PhysicalCapacityBytes** | **long?** | Provides the total physical capacity in bytes as computed by the Cohesity Cluster. | [optional] 
**ReadIos** | **long?** | Provides the number of Read IOs that occurred in the last 30 seconds. | [optional] 
**ReadLatencyMsecs** | **double?** | Provides the Read latency in milliseconds for the Read IOs that occurred during the last 30 seconds. | [optional] 
**SystemCapacityBytes** | **long?** | Provides the total available capacity as computed by the Linux &#39;statfs&#39; command. | [optional] 
**SystemUsageBytes** | **long?** | Provides the usage of bytes, as computed by the Linux &#39;statfs&#39; command, after the size of the data is reduced by change-block tracking, compression and deduplication. | [optional] 
**TotalPhysicalRawUsageBytes** | **long?** | Provides the usage of bytes, as computed by the Cohesity Cluster, before the size of the data is reduced by change-block tracking, compression and deduplication. | [optional] 
**TotalPhysicalUsageBytes** | **long?** | Provides the total capacity, as computed by the Cohesity Cluster, after the size of the data has been reduced by change-block tracking, compression and deduplication. | [optional] 
**WriteIos** | **long?** | Provides the number of Write IOs that occurred in the last 30 seconds. | [optional] 
**WriteLatencyMsecs** | **double?** | Provides the Write latency in milliseconds for the Write IOs that occurred during the last 30 seconds. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


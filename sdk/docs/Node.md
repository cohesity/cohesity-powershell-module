# IO.Swagger.Model.Node
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CapacityByTier** | [**List&lt;CapacityByTier&gt;**](CapacityByTier.md) |  | [optional] 
**ChassisInfo** | [**ChassisInfo**](ChassisInfo.md) | ChassisInfo describes the information for the chassis of the node. | [optional] 
**ClusterPartitionId** | **long?** | ClusterPartitionId is the Id of the cluster partition to which the Node belongs. | [optional] 
**ClusterPartitionName** | **string** | ClusterPartitionName is the name of the cluster to which the Node belongs. | [optional] 
**DiskCount** | **long?** | DiskCount is the number of disks in a node. | [optional] 
**Id** | **long?** | Id is the Id of the Node. | [optional] 
**Ip** | **string** | Ip is the IP address of the Node. | [optional] 
**IsMarkedForRemoval** | **bool?** | IsMarkedForRemoval specifies whether the node has been marked for removal. | [optional] 
**MaxPhysicalCapacityBytes** | **long?** | MaxPhysicalCapacityBytes specifies the maximum physical capacity of the node in bytes. | [optional] 
**NodeHardwareInfo** | [**NodeHardwareInfo**](NodeHardwareInfo.md) | HardwareInfo describes the hardware of the node. | [optional] 
**NodeIncarnationId** | **long?** | NodeIncarnationId is the incarnation id  of this node. The incarnation id is changed every time the data is wiped from the node. Various services on a node is only run if incarnation id of the node matches the incarnation id of the cluster. Whenever a mismatch is detected, Nexus will stop all services and clean the data from the node. After clean operation is completed, Nexus will set the node incarnation id to cluster incarnation id and start the services. | [optional] 
**NodeSoftwareVersion** | **string** | NodeSoftwareVersion is the current version of Cohesity software installed on a node. | [optional] 
**OfflineMountPathsOfDisks** | **List&lt;string&gt;** | OfflineMountPathsOfDisks provides the corresponding mount paths for direct attached disks that are currently offline - access to these were detected to hang sometime in the past. After these disks have been fixed, their mount paths needs to be removed from the following list before these will be accessed again. | [optional] 
**RemovalState** | **string** | RemovalState specifies the removal state of the node. &#39;kDontRemove&#39; means the state of object is functional and it is not being removed. &#39;kMarkedForRemoval&#39; means the object is being removed. &#39;kOkToRemove&#39; means the object has been removed on the Cohesity Cluster and if the object is physical, it can be removed from the Cohesity Cluster. | [optional] 
**Stats** | [**NodeStats**](NodeStats.md) | Stats describes the node stats. | [optional] 
**SystemDisks** | [**List&lt;NodeSystemDiskInfo&gt;**](NodeSystemDiskInfo.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# IO.Swagger.Model.SnapshotTarget
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ArchivalTarget** | [**ArchivalTarget**](ArchivalTarget.md) | Specifies the Archival External Target for storing a copied Snapshot. If the type is not &#39;kLocal&#39;, either a replicationTarget or archivalTarget must be specified. | [optional] 
**ReplicationTarget** | [**ReplicationTarget**](ReplicationTarget.md) | Specifies the replication target (Remote Cluster) for storing a copied Snapshot. If the type is not &#39;kLocal&#39;, either a replicationTarget or archivalTarget must be specified. | [optional] 
**Type** | **string** | Specifies the type of a Snapshot target such as &#39;kLocal&#39;, &#39;kRemote&#39; or &#39;kArchival&#39;. &#39;kLocal&#39; means the Snapshot is stored on a local Cohesity Cluster. &#39;kRemote&#39; means the Snapshot is stored on a Remote Cohesity Cluster. (It was copied to the Remote Cohesity Cluster using replication.) &#39;kArchival&#39; means the Snapshot is stored on a Archival External Target (such as Tape or AWS). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


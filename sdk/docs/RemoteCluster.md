# IO.Swagger.Model.RemoteCluster
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllEndpointsReachable** | **bool?** | Specifies whether any endpoint (such as a Node) on the remote Cluster is reachable from this local Cluster. If true, a service running on the local Cluster can communicate directly with any of its peers running on the remote Cluster, without using a proxy. | [optional] 
**BandwidthLimit** | [**BandwidthLimit**](BandwidthLimit.md) | Specifies settings for limiting the data transfer rate between the local and remote Clusters. | [optional] 
**ClearInterfaces** | **bool?** |  | [optional] 
**ClearVlanId** | **bool?** | Specifies whether to clear the vlanId field, and thus stop using only the IPs in the VLAN for communicating with the remote Cluster. | [optional] 
**ClusterId** | **long?** | Specifies the unique id of the remote Cluster. | [optional] 
**ClusterIncarnationId** | **long?** | Specifies the unique incarnation id of the remote Cluster. This id is determined dynamically by contacting the remote Cluster. | [optional] 
**CompressionEnabled** | **bool?** | Specifies whether to compress the outbound data when transferring the replication data over the network to the remote Cluster. | [optional] 
**EncryptionKey** | **string** | Specifies the encryption key used for encrypting the replication data from a local Cluster to a remote Cluster. If a key is not specified, replication traffic encryption is disabled. When Snapshots are replicated from a local Cluster to a remote Cluster, the encryption key specified on the local Cluster must be the same as the key specified on the remote Cluster. | [optional] 
**LocalIps** | **List&lt;string&gt;** | Specifies the IP addresses of the interfaces in the local Cluster which will be used for communicating with the remote Cluster. | [optional] 
**Name** | **string** | Specifies the name of the remote Cluster. | [optional] 
**NetworkInterfaceGroup** | **string** | Specifies the group name of the network interfaces to use for communicating with the remote Cluster. | [optional] 
**NetworkInterfaceIds** | **List&lt;long?&gt;** | Specifies the ids of the network interfaces to use for communicating with the remote Cluster. | [optional] 
**PurposeRemoteAccess** | **bool?** | Whether the remote cluster will be used for remote access for SPOG. | [optional] 
**PurposeReplication** | **bool?** | Whether the remote cluster will be used for replication. | [optional] 
**RemoteAccessCredentials** | [**AccessTokenCredential**](AccessTokenCredential.md) | Optional field for the user credentials to connect to Iris for remote access for SPOG. If this is not specified, then credentials specified for replication set up will be used for remote access for SPOG. Allowing a different user credentials to be set up for SPOG permits having different roles for remote access for SPOG and replication set up. | [optional] 
**RemoteIps** | **List&lt;string&gt;** | Specifies the IP addresses of the Nodes on the remote Cluster to connect with. These IP addresses can also be VIPS. Specifying hostnames is not supported. | [optional] 
**UserName** | **string** | Specifies the Cohesity user name used to connect to the remote Cluster. | [optional] 
**ViewBoxPairInfo** | [**List&lt;ViewBoxPairInfo&gt;**](ViewBoxPairInfo.md) | Specifies pairings between Storage Domains (View Boxes) on the local Cluster with Storage Domains (View Boxes) on a remote Cluster that are used in replication. | [optional] 
**VlanId** | **int?** | Specifies the id of the VLAN to use when communicating with the remote Cluster. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


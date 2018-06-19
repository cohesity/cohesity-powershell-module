# IO.Swagger.Model.SupportedConfig
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MinNodesAllowed** | **int?** | Specifies the minimum number of Nodes supported for this Cluster type. For example, a Cohesity Cluster hosted directly on hardware must have at least 3 Nodes. | [optional] 
**SupportedErasureCoding** | **List&lt;string&gt;** | List the supported Erasure Coding options for the current number of Nodes (nodeCount) in this Cluster. Each string in the array is in the following format: \&quot;NumDataStripes:NumCodedStripes\&quot; For example if there are 3 nodes in the Cluster, the following Erasure Coding mode is returned: 2:1. See the Cohesity Dashboard help documentation for details. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


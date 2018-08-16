# IO.Swagger.Model.KvmProtectionSource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AgentError** | **string** | Specifies a message when the agent cannot be reached. | [optional] 
**AgentId** | **long?** | Specifies the ID of the Agent with which this KVM entity is associated when the entity represents a Delegate host or KVM host. | [optional] 
**ClusterId** | **string** | Specifies the cluster ID for &#39;kCluster&#39; objects. | [optional] 
**DatacenterId** | **string** | Specifies the ID of the &#39;kDatacenter&#39; objects. | [optional] 
**Description** | **string** | Specifies a description about the Protection Source. | [optional] 
**Name** | **string** | Specifies the name of the KVM entity. | [optional] 
**Type** | **string** | Specifies the type of KVM Protection Source entities such as &#39;kDatacenter&#39;, &#39;kCluster&#39;, &#39;kVirtualMachine&#39;, etc. Specifies the type of an KVM source entity. &#39;kOVirtManager&#39; indicates the root entity registerd with Cohesity cluster. &#39;kStandaloneHost&#39; indicates a host registered with Cohesity cluster. &#39;kDatacenter&#39; indicates a KVM datacenter managed by the OVirt manager. &#39;kCluster&#39; indicates a KVM cluster managed by the OVirt manager. &#39;kHost&#39; indicates a host within the KVM environment. &#39;kVirtualMachine&#39; indicates a virtual machine in the KVM enironment. &#39;kNetwork&#39; represents a network used by the virtual machine entity. &#39;kStorageDomain&#39; represents a storage domain in the KVM environment. | [optional] 
**Uuid** | **string** | Specifies the UUID of the Object. This is unique within the KVM environment. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


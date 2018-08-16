# IO.Swagger.Model.AcropolisProtectionSource_
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClusterUuid** | **string** | Specifies the UUID of the Acropolis cluster instance to which this entity belongs to. | [optional] 
**Description** | **string** | Specifies a description about the Protection Source. | [optional] 
**MountPath** | **bool?** | Specifies whether the the VM is an agent VM. This is applicable to acropolis entity of type kVirtualMachine. | [optional] 
**Name** | **string** | Specifies the name of the Acropolis Object. | [optional] 
**Type** | **string** | Specifies the type of an Acropolis Protection Source Object such as &#39;kPrismCentral&#39;, &#39;kHost&#39;, &#39;kNetwork&#39;, etc. Specifies the type of an Acropolis source entity. &#39;kPrismCentral&#39; indicates a collection of multiple Nutanix clusters. &#39;kStandaloneCluster&#39; indicates a single Nutanix cluster. &#39;kCluster&#39; indicates a Nutanix cluster manageed by a Prism Central. &#39;kHost&#39; indicates an Acropolis host. &#39;kVirtualMachine&#39; indicates a Virtual Machine. &#39;kNetwork&#39; indicates a Virtual Machine network object. &#39;kStorageContainer&#39; represents a storage container object. | [optional] 
**Uuid** | **string** | Specifies the UUID of the Acropolis Object. This is unique within the cluster instance. Together with clusterUuid, this entity is unique within the Acropolis environment. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


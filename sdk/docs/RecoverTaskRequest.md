# IO.Swagger.Model.RecoverTaskRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AcropolisParameters** | [**AcropolisRestoreParameters**](AcropolisRestoreParameters.md) | Specifies additional parameters for &#39;kAcropolis&#39; restore objects. | [optional] 
**ContinueOnError** | **bool?** | Specifies if the Restore Task should continue when some operations on some objects fail. If true, the Cohesity Cluster ignores intermittent errors and restores as many objects as possible. | [optional] 
**HypervParameters** | [**HypervRestoreParameters**](HypervRestoreParameters.md) | Specifies additional parameters for &#39;kHyperV&#39; restore objects. | [optional] 
**MountParameters** | [**MountVolumesParameters**](MountVolumesParameters.md) | Specifies parameters required for mounting volumes. | [optional] 
**Name** | **string** | Specifies the name of the Restore Task. This field must be set and must be a unique name. | 
**NewParentId** | **long?** | Specify a new registered parent Protection Source. If specified the selected objects are cloned or recovered to this new Protection Source. If not specified, objects are cloned or recovered to the original Protection Source that was managing them. | [optional] 
**Objects** | [**List&lt;RestoreObject&gt;**](RestoreObject.md) | Specifies a list of Protection Source objects or Protection Job objects (with specified Protection Source objects). | [optional] 
**Type** | **string** | Specifies the type of Restore Task such as &#39;kRecoverVMs&#39; or &#39;kMountVolumes&#39;. &#39;kRecoverVMs&#39; specifies a Restore Task that recovers VMs. &#39;kMountVolumes&#39; specifies a Restore Task that mounts volumes to mount points. | 
**VlanParameters** | [**VlanParameters**](VlanParameters.md) | Specifies VLAN parameters for the restore operation. | [optional] 
**VmwareParameters** | [**VmwareRestoreParameters**](VmwareRestoreParameters.md) | Specifies additional parameters for &#39;kVmware&#39; restore objects. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


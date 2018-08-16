# IO.Swagger.Model.RestoreObjectState
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Error** | [**RequestError**](RequestError.md) | Specifies if an error occurred during the restore operation. | [optional] 
**ObjectStatus** | **string** | Specifies the status of an object during a Restore Task. &#39;kFilesCloned&#39; indicates that the cloning has completed. &#39;kFetchedEntityInfo&#39; indicates that information about the object was fetched from the primary source. &#39;kVMCreated&#39; indicates that the new VM was created. &#39;kRelocationStarted&#39; indicates that restoring to a different resource pool has started. &#39;kFinished&#39; indicates that the Restore Task has finished. Whether it was successful or not is indicated by the error code that that is stored with the Restore Task. &#39;kAborted&#39; indicates that the Restore Task was aborted before trying to restore this object. This can happen if the Restore Task encounters a global error. For example during a &#39;kCloneVMs&#39; Restore Task, the datastore could not be mounted. The entire Restore Task is aborted before trying to create VMs on the primary source. | [optional] 
**ResourcePoolId** | **long?** | Specifies the id of the Resource Pool that the restored object is attached to. For a &#39;kRecoverVMs&#39; Restore Task, an object can be recovered back to its original resource pool. This means while recovering a set of objects, this field can reference different resource pools. For a &#39;kCloneVMs&#39; Restore Task, all objects are attached to the same resource pool. However, this field will still be populated. NOTE: This field may not be populated if the restore of the object fails. | [optional] 
**RestoredObjectId** | **long?** | Specifies the Id of the recovered or cloned object. NOTE: For a Restore Task that is recovering or cloning an object in the VMware environment, after the VM is created it is storage vMotioned to its primary datastore. If storage vMotion fails, the Cohesity Cluster marks the recovery task as failed. However, this field is still populated with the id of the recovered VM. This id can be used later to clean up the VM from primary environment (i.e, the vCenter Server). | [optional] 
**SourceObjectId** | **long?** | Specifies the Protection Source id of the object to be recovered or cloned. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


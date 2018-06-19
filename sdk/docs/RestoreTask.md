# IO.Swagger.Model.RestoreTask
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AcropolisParameters** | [**AcropolisRestoreParameters**](AcropolisRestoreParameters.md) | Specifies parameters for &#39;kAcropolis&#39; restore task. | [optional] 
**ArchiveTaskUid** | [**UniqueGlobalId8**](UniqueGlobalId8.md) |  | [optional] 
**CloneViewParameters** | [**View_**](View_.md) |  | [optional] 
**ContinueOnError** | **bool?** | Specifies if the Restore Task should continue when some operations on some objects fail. If true, the Cohesity Cluster ignores intermittent errors and restores as many objects as possible. | [optional] 
**DatastoreId** | **long?** | Specifies the datastore where the object&#39;s files are recovered to. This field is populated when objects are recovered to a different resource pool or to a different parent source. This field is not populated when objects are recovered to their original datastore locations in the original parent source. | [optional] 
**EndTimeUsecs** | **long?** | Specifies the end time of the Restore Task as a Unix epoch Timestamp (in microseconds). This field is only populated if the Restore Task completes. | [optional] 
**Error** | [**RestoreTaskError_**](RestoreTaskError_.md) |  | [optional] 
**FullViewName** | **string** | Specifies the full name of a View. | [optional] 
**HypervParameters** | [**HypervRestoreParameters**](HypervRestoreParameters.md) | Specifies additional parameters for &#39;kHyperV&#39; restore objects. | [optional] 
**Id** | **long?** | Specifies the id of the Restore Task assigned by Cohesity Cluster. | [optional] 
**MountVolumesState** | [**MountVolumesState**](MountVolumesState.md) | Specifies the states of mounting all the volumes onto a mount target for a &#39;kRecoverVMs&#39; Restore Task. | [optional] 
**Name** | **string** | Specifies the name of the Restore Task. This field must be set and must be a unique name. | 
**NewParentId** | **long?** | Specify a new registered parent Protection Source. If specified the selected objects are cloned or recovered to this new Protection Source. If not specified, objects are cloned or recovered to the original Protection Source that was managing them. | [optional] 
**Objects** | [**List&lt;RestoreObject&gt;**](RestoreObject.md) | Specifies a list of Protection Source objects or Protection Job objects (with specified Protection Source objects). | [optional] 
**RestoreObjectState** | [**List&lt;RestoreObjectState&gt;**](RestoreObjectState.md) | Specifies the states of all the objects for the &#39;kRecoverVMs&#39; and &#39;kCloneVMs&#39; Restore Tasks. | [optional] 
**StartTimeUsecs** | **long?** | Specifies the start time for the Restore Task as a Unix epoch Timestamp (in microseconds). | [optional] 
**Status** | **string** | Specifies the overall status of the Restore Task. &#39;kReadyToSchedule&#39; indicates the Restore Task is waiting to be scheduled. &#39;kProgressMonitorCreated&#39; indicates the progress monitor for the Restore Task has been created. &#39;kRetrievedFromArchive&#39; indicates that the objects to restore have been retrieved from the specified archive. A Task will only ever transition to this state if a retrieval is necessary. &#39;kAdmitted&#39; indicates the task has been admitted. After a task has been admitted, its status does not move back to &#39;kReadyToSchedule&#39; state even if it is rescheduled. &#39;kInProgress&#39; indicates that the Restore Task is in progress. &#39;kFinishingProgressMonitor&#39; indicates that the Restore Task is finishing its progress monitoring. &#39;kFinished&#39; indicates that the Restore Task has finished. The status indicating success or failure is found in the error code that is stored with the Restore Task. | [optional] 
**TargetViewCreated** | **bool?** | Is true if a new View was created by a &#39;kCloneVMs&#39; Restore Task. This field is only set for a &#39;kCloneVMs&#39; Restore Task. | [optional] 
**Type** | **string** | Specifies the type of Restore Task.  &#39;kRecoverVMs&#39; specifies a Restore Task that recovers VMs. &#39;kCloneVMs&#39; specifies a Restore Task that clones VMs. &#39;kCloneView&#39; specifies a Restore Task that clones a View. &#39;kMountVolumes&#39; specifies a Restore Task that mounts volumes. &#39;kRestoreFiles&#39; specifies a Restore Task that recovers files and folders. | [optional] 
**Username** | **string** | Specifies the Cohesity user who requested this Restore Task. | [optional] 
**ViewBoxId** | **long?** | Specifies the id of the Domain (View Box) where the View is stored. | [optional] 
**VlanParameters** | [**VlanParameters**](VlanParameters.md) | Specifies VLAN parameters for the restore operation. | [optional] 
**VmwareParameters** | [**VmwareRestoreParameters**](VmwareRestoreParameters.md) | Specifies additional parameters for &#39;kVmware&#39; restore objects. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


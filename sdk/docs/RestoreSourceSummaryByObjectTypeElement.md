# IO.Swagger.Model.RestoreSourceSummaryByObjectTypeElement
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DatastoreId** | **long?** | Specifies the datastore where the object&#39;s files are recovered to. This field is populated when objects are recovered to a different resource pool or to a different parent source. This field is not populated when objects are recovered to their original datastore locations in the original parent source. | [optional] 
**FileRestoreInfo** | [**List&lt;FileRestoreInfo&gt;**](FileRestoreInfo.md) |  | [optional] 
**Name** | **string** | Specifies the name of the Restore Task. This field must be set and must be a unique name. | 
**Objects** | [**List&lt;RestoreObject&gt;**](RestoreObject.md) | Specifies a list of Protection Source objects or Protection Job objects (with specified Protection Source objects). | [optional] 
**ProtectionSourceName** | **string** | The protection source name. | [optional] 
**StartTimeUsecs** | **long?** | Specifies the start time of the Restore Task as a Unix epoch Timestamp (in microseconds). | [optional] 
**Type** | **string** | Specify the object type to filter with. Specifies the type of Restore Task.  &#39;kRecoverVMs&#39; specifies a Restore Task that recovers VMs. &#39;kCloneVMs&#39; specifies a Restore Task that clones VMs. &#39;kCloneView&#39; specifies a Restore Task that clones a View. &#39;kMountVolumes&#39; specifies a Restore Task that mounts volumes. &#39;kRestoreFiles&#39; specifies a Restore Task that recovers files and folders. | [optional] 
**Username** | **string** | Specifies the Cohesity user who requested this Restore Task. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


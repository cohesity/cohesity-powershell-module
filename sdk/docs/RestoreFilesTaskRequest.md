# IO.Swagger.Model.RestoreFilesTaskRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContinueOnError** | **bool?** | Specifies if the Restore Task should continue even if the copy operation of some files and folders fails. If true, the Cohesity Cluster ignores intermittent errors and recovers as many files and folders as possible. If false, the Restore Task stops recovering when a copy operation fails. | [optional] 
**Filenames** | **List&lt;string&gt;** | Specifies the files and folders to recover from the snapshot. | [optional] 
**Name** | **string** | Specifies the name of the Restore Task. This field must be set and must be a unique name. | [optional] 
**NewBaseDirectory** | **string** | Specifies an optional root folder where to recover the selected files and folders. By default, files and folders are restored to their original path. | [optional] 
**Overwrite** | **bool?** | If true, any existing files and folders on the operating system are overwritten by the recovered files or folders. This is the default. If false, existing files and folders are not overwritten. | [optional] 
**Password** | **string** | Specifies password of the username to access the target source. | [optional] 
**PreserveAttributes** | **bool?** | If true, the Restore Tasks preserves the original file and folder attributes. This is the default. | [optional] 
**SourceObjectInfo** | [**RestoreObject_**](RestoreObject_.md) |  | [optional] 
**TargetHostType** | **string** | Specifies the target host types to be restored. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. | [optional] 
**TargetParentSourceId** | **long?** | Specifies the registered source (such as a vCenter Server) that contains the target protection source (such as a VM) where the files and folders are recovered to. This field is not required for a Physical Server. | [optional] 
**TargetSourceId** | **long?** | Specifies the id of the target protection source (such as a VM) where the files and folders are recovered to. | [optional] 
**Username** | **string** | Specifies username to access the target source. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


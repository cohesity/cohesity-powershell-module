# IO.Swagger.Model.FileSearchResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DocumentType** | **string** | Specifies the inferred document type. | [optional] 
**FileVersions** | [**List&lt;FileVersion&gt;**](FileVersion.md) | Specifies the different snapshot versions of a file or folder that were captured at different times. | [optional] 
**Filename** | **string** | Specifies the name of the found file or folder. | [optional] 
**IsFolder** | **bool?** | Specifies if the found item is a folder. If true, the found item is a folder. | [optional] 
**JobId** | **long?** | Specifies the Job id for the Protection Job that is currently associated with object that contains the backed up file or folder. If the file or folder was backed up on current Cohesity Cluster, this field contains the id for the Job that captured the object that contains the file or folder. If the file or folder was backed up on a Primary Cluster and replicated to this Cohesity Cluster, a new Inactive Job is created, the object that contains the file or folder is now associated with new Inactive Job, and this field contains the id of the new Inactive Job. | [optional] 
**JobUid** | [**UniqueGlobalId2**](UniqueGlobalId2.md) |  | [optional] 
**RegisteredSourceId** | **long?** | Specifies the id of the top-level registered source (such as a vCenter Server) where the source object that contains the the file or folder is stored. | [optional] 
**SourceId** | **long?** | Specifies the source id of the object that contains the file or folder. | [optional] 
**ViewBoxId** | **long?** | Specifies the id of the Domain (View Box) where the source object that contains the file or folder is stored. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


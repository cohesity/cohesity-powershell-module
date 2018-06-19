# IO.Swagger.Model.FilePathParameters
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BackupFilePath** | **string** | Specifies absolute path to a file or a directory in a Physical Server to protect. | [optional] 
**ExcludedFilePaths** | **List&lt;string&gt;** | Specifies absolute paths to descendant files or subdirectories of backupFilePath that should not be protected. | [optional] 
**SkipNestedVolumes** | **bool?** | Specifies if any subdirectories under backupFilePath, where local or network volumes are mounted, should be excluded from being protected. If true, the volumes are not protected. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


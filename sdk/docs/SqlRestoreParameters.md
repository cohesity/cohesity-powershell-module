# IO.Swagger.Model.SqlRestoreParameters
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CaptureTailLogs** | **bool?** | Set this to true if tail logs are to be captured before the restore operation. This is only applicable if we are restoring the SQL database to its hosting Protection Source, and the database is not being renamed. | [optional] 
**KeepOffline** | **bool?** | Set this to true if we want to restore the database and do not want to bring it online after restore.  This is only applicable if we are restoring the database back to its original location. | [optional] 
**NewDatabaseName** | **string** | Specifies optionally a new name for the restored database. | [optional] 
**NewInstanceName** | **string** | Specifies an instance name of the SQL Server that should be restored. SQL application has many instances. Each instance has a unique name. One of the instances that should be restored must be set in this field. | [optional] 
**RestoreTimeSecs** | **long?** | Specifies the time in the past to which the SQL database needs to be restored. This allows for granular recovery of SQL databases. If this is not set, the SQL database will be restored from the full/incremental snapshot. | [optional] 
**TargetDataFilesDirectory** | **string** | Specifies the directory where to put the database data files. Missing directory will be automatically created. This field must be set if restoring to a different target host. | [optional] 
**TargetLogFilesDirectory** | **string** | Specifies the directory where to put the database log files. Missing directory will be automatically created. This field must be set if restoring to a different target host. | [optional] 
**TargetSecondaryDataFilesDirectoryList** | [**List&lt;FilenamePatternToDirectory&gt;**](FilenamePatternToDirectory.md) | If this option is specified and the destination folders do not exist they will be automatically created. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


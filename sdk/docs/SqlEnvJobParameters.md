# IO.Swagger.Model.SqlEnvJobParameters
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AagPreference** | **string** | kPrimaryReplicaOnly implies backups should always occur on the primary replica. kSecondaryReplicaOnly implies backups should always occur on the secondary replica. kPreferSecondaryReplica implies secondary replica is preferred for backups. kAnyReplica implies no preference of about whether backups are performed on the primary replica or on a secondary replica. If no secondary replica is available, then performing backups on the primary replica is acceptable. | [optional] 
**AagPreferenceFromSqlServer** | **bool?** | If true, AAG preferences are taken from the SQL server host. If this is set to false or not given, preferences can be overridden by aagBackupPreference. | [optional] 
**BackupSystemDatabases** | **bool?** | If true, system databases are backed up. If this is set to false, system databases are not backed up. If this field is not specified, default value is true. | [optional] 
**BackupType** | **string** | kSqlVSSVolume implies volume based VSS full backup. kSqlVSSFile implies file based VSS full backup. | [optional] 
**BackupVolumesOnly** | **bool?** | If set to true, only the volumes associated with databases should be backed up. The user cannot select additional volumes at host level for backup.  If set to false, all the volumes on the host machine will be backed up. In this case, the user can further select the exact set of volumes using host level params.  Note that the volumes associated with selected databases will always be included in the backup. | [optional] 
**IsCopyOnlyFull** | **bool?** | If true, the backup is a full backup with the copy-only option specified. | [optional] 
**UserDatabasePreference** | **string** | kBackupAllDatabases implies to backup all databases. kBackupAllExceptAAGDatabases implies not to backup AAG databases. kBackupOnlyAAGDatabases implies to backup only AAG databases. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


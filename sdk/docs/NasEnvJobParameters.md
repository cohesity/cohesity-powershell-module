# IO.Swagger.Model.NasEnvJobParameters
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContinueOnError** | **bool?** | Specifies if the backup should continue on with other Protection Sources even if the backup operation of some Protection Source fails. If true, the Cohesity Cluster ignores the errors and continues with remaining Protection Sources in the job. If false, the backup operation stops when an error occurs. This does not apply to non-snapshot based generic NAS backup jobs. If not set, default value is true. | [optional] 
**FilePathFilters** | [**FilePathFilter**](FilePathFilter.md) | Specifies filters on the backup objects like files and directories. Specifying filters decide which objects within a source should be backed up. If this field is not specified, then all of the objects within the source will be backed up. | [optional] 
**NasProtocol** | **string** | Specifies the preferred protocol to use for backup. This does not apply to generic NAS and will be ignored. Specifies the protocol used by a NAS server. &#39;kNfs3&#39; indicates NFS v3 protocol. &#39;kCifs1&#39; indicates CIFS v1.0 protocol. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# IO.Swagger.Model.VmwareEnvJobParameters
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExcludedDisks** | [**List&lt;DiskUnit&gt;**](DiskUnit.md) | Specifies the list of Disks to be excluded from backing up. These disks are excluded from all Protection Sources in the Protection Job. | [optional] 
**FallbackToCrashConsistent** | **bool?** | If true, takes a crash-consistent snapshot when app-consistent snapshot fails. Otherwise, the snapshot attempt is marked failed. | [optional] 
**SkipPhysicalRdmDisks** | **bool?** | If true, skip physical RDM disks when backing up VMs. Otherwise, backup of VMs having physical RDM will fail. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


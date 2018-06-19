# IO.Swagger.Model.HypervVirtualMachine
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsHighlyAvailable** | **bool?** | Specifies whether the VM is Highly Availabile or not. | [optional] 
**Version** | **string** | Specifies the version of the VM. For example, 8.0, 5.0 etc. | [optional] 
**VmBackupStatus** | **string** | Specifies the status of the VM for backup purpose. overrideDescription: true Specifies the backup status of a HyperV Virtual Machine object. &#39;kSupported&#39; indicates the agent on the VM can do backup. &#39;kUnsupportedConfig&#39; indicates the agent on the VM cannot do backup. &#39;kMissing&#39; indicates the VM is not found in SCVMM. | [optional] 
**VmBackupType** | **string** | Specifies the type of backup supported by the VM. overrideDescription: true Specifies the type of an HyperV datastore object. &#39;kRctBackup&#39; indicates backup is done using RCT/checkpoints. &#39;kVssBackup&#39; indicates backup is done using VSS. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# IO.Swagger.Model.MountVolumesParameters
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BringDisksOnline** | **bool?** | Optional setting that determines if the volumes are brought online on the mount target after attaching the disks. This field is only set for VMs. The Cohesity Cluster always attempts to mount Physical servers. If true and the mount target is a VM, to mount the volumes VMware Tools must be installed on the guest operating system of the VM and login credentials to the mount target must be specified. NOTE: If automount is configured for a Windows system, the volumes may be automatically brought online. | [optional] 
**Password** | **string** | Specifies password of the username to access the target source. | [optional] 
**TargetSourceId** | **long?** | Specifies the target Protection Source id where the volumes will be mounted. NOTE: The source that was backed up and the mount target must be the same type, for example if the source is a VMware VM, then the mount target must also be a VMware VM. The mount target must be registered on the Cohesity Cluster. | [optional] 
**Username** | **string** | Specifies username to access the target source. | [optional] 
**VolumeNames** | **List&lt;string&gt;** | Optionally specify the names of volumes to mount. If none are specified, all volumes of the Server are mounted on the target. To get the names of the volumes, call the GET /public/restore/vms/volumesInformation operation. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


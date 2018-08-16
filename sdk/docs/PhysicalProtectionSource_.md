# IO.Swagger.Model.PhysicalProtectionSource_
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Agents** | [**List&lt;AgentInformation&gt;**](AgentInformation.md) | Specifiles the agents running on the Physical Protection Source and the status information. | [optional] 
**HostType** | **string** | Specifies the environment type for the host. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. | [optional] 
**Id** | [**UniqueGlobalId4**](UniqueGlobalId4.md) |  | [optional] 
**Name** | **string** | Specifies a human readable name of the Protection Source. | [optional] 
**Type** | **string** | Specifies the type of managed Object in a Physical Protection Source. &#39;kHost&#39; indicates a single physical server. &#39;kWindowsCluster&#39; indicates a Microsoft Windows cluster. | [optional] 
**Volumes** | [**List&lt;PhysicalVolume&gt;**](PhysicalVolume.md) | Specifies the volumes available on the physical host. These fields are populated only for the kPhysicalHost type. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


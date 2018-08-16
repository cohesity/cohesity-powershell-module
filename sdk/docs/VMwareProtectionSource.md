# IO.Swagger.Model.VMwareProtectionSource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AgentId** | **long?** | Specifies the id of the persistent agent. | [optional] 
**Agents** | [**List&lt;AgentInformation&gt;**](AgentInformation.md) | This is set only if the Virtual Machine has persistent agent. | [optional] 
**ConnectionState** | **string** | Specifies the connection state of the Object and are only valid for ESXi hosts (&#39;kHostSystem&#39;) or Virtual Machines (&#39;kVirtualMachine&#39;). These enums are equivalent to the connection states documented in VMware&#39;s reference documentation. Examples of Cohesity connection states include &#39;kConnected&#39;, &#39;kDisconnected&#39;, &#39;kInacccessible&#39;, etc. | [optional] 
**DatastoreInfo** | [**DatastoreInfo**](DatastoreInfo.md) | Specifies additional information of entities of type &#39;kDatastore&#39;. | [optional] 
**FolderType** | **string** | Specifies the folder type for the &#39;kFolder&#39; Object. &#39;kVMFolder&#39; indicates folder can hold VMs or vApps. &#39;kHostFolder&#39; indicates folder can hold hosts and compute resources. &#39;kDatastoreFolder&#39; indicates folder can hold datastores and storage pods. &#39;kNetworkFolder&#39; indicates folder can hold networks and switches. &#39;kRootFolder&#39; indicates folder can hold datacenters. | [optional] 
**HasPersistentAgent** | **bool?** | Set to true if a persistent agent is running on the Virtual Machine. This is populated for entities of type &#39;kVirtualMachine&#39;. | [optional] 
**HostType** | **string** | Specifies the host type for the &#39;kVirtualMachine&#39; Object. &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. | [optional] 
**Id** | [**VMwareObjectId**](VMwareObjectId.md) | Specifies the UUID of the VMware Protection Source. | [optional] 
**Name** | **string** | Specifies a human readable name of the Protection Source. | [optional] 
**TagAttributes** | [**List&lt;TagAttribute&gt;**](TagAttribute.md) | Specifies the optional list of VM Tag attributes associated with this Object. | [optional] 
**ToolsRunningStatus** | **string** | Specifies the status of VMware Tools for the guest OS on the VM. This is only valid for the &#39;kVirtualMachine&#39; type. &#39;kGuestToolsRunning&#39; means the VMware tools are running on the guest OS. &#39;kGuestToolsNotRunning&#39; means the VMware tools are not running on the guest OS. &#39;kUnknown&#39; means the state of the VMware tools on the guest OS is not known. &#39;kGuestToolsExecutingScripts&#39; means the guest OS is currently executing scripts using VMware tools. | [optional] 
**Type** | **string** | Specifies the type of managed Object in a VMware Protection Source. Examples of VMware Objects include &#39;kVCenter&#39;, &#39;kFolder&#39;, &#39;kDatacenter&#39;, &#39;kResourcePool&#39;, &#39;kDatastore&#39;, &#39;kVirtualMachine&#39;, etc. | [optional] 
**VirtualDisks** | [**List&lt;VirtualDiskInfo&gt;**](VirtualDiskInfo.md) | This is populated for entities of type &#39;kVirtualMachine&#39;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# IO.Swagger.Model.AzureProtectionSource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HostType** | **string** | Specifies the OS type of the Protection Source of type &#39;kVirtualMachine&#39; such as &#39;kWindows&#39; or &#39;kLinux&#39;. overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. | [optional] 
**IpAddresses** | **List&lt;string&gt;** |  | [optional] 
**Location** | **string** | Specifies the physical location of the resource group. | [optional] 
**MemoryMbytes** | **long?** | Specifies the amount of memory in MegaBytes of the Azure resource of type &#39;kComputeOptions&#39;. | [optional] 
**Name** | **string** | Specifies the name of the Azure Object set by the Cloud Provider. If the provider did not set a name for the object, this field is not set. | [optional] 
**NumCores** | **int?** | Specifies the number of CPU cores of the Azure resource of type &#39;kComputeOptions&#39;. | [optional] 
**ResourceId** | **string** | Specifies the unique Id of the resource in Azure environment. | [optional] 
**Type** | **string** | Specifies the type of an Azure Protection Source Object such as &#39;kStorageContainer&#39;, &#39;kVirtualMachine&#39;, &#39;kVirtualNetwork&#39;, etc. Specifies the type of an Azure source entity. &#39;kSubscription&#39; indicates a billing unit within Azure account. &#39;kResourceGroup&#39; indicates a container that holds related resources. &#39;kVirtualMachine&#39; indicates a Virtual Machine in Azure environment. &#39;kStorageAccount&#39; represents a collection of storage containers. &#39;kStorageKey&#39; indicates a key required to access the storage account. &#39;kStorageContainer&#39; represents a storage container within a storage account. &#39;kStorageBlob&#39; represents a storage blog within a storage container. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kVirtualNetwork&#39; represents a virtual network. &#39;kSubnet&#39; represents a subnet within the virtual network. &#39;kComputeOptions&#39; indicates the number of CPU cores and memory size available for a type of a Virtual Machine. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


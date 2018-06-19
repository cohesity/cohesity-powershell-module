# IO.Swagger.Model.AWSProtectionSource_
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HostType** | **string** | Specifies the OS type of the Protection Source of type &#39;kVirtualMachine&#39; such as &#39;kWindows&#39; or &#39;kLinux&#39;. overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. | [optional] 
**IpAddresses** | **string** | Specifies the IP address of the entity of type &#39;kVirtualMachine&#39;. | [optional] 
**Name** | **string** | Specifies the name of the AWS Object set by the Cloud Provider. | [optional] 
**OwnerId** | **string** | Specifies the owner id of the resource in AWS environment. With type, name and ownerId gives a globally unique identity to the AWS entity. | [optional] 
**RegionId** | **string** | Specifies the region Id of the entity if the entity is an EC2 instance. | [optional] 
**ResourceId** | **string** | Specifies the unique Id of the resource given by the cloud provider. | [optional] 
**Type** | **string** | Specifies the type of an AWS Protection Source Object such as &#39;kStorageContainer&#39;, &#39;kVirtualMachine&#39;, &#39;kVirtualNetwork&#39;, etc. Specifies the type of an AWS source entity. &#39;kIAMUser&#39; indicates a unique user within an AWS account. &#39;kRegion&#39; indicates a geographical region in the global infrastructure. &#39;kAvailabilityZone&#39; indicates an availability zone within a region. &#39;kEC2Instance&#39; indicates a Virtual Machine running in AWS environment. &#39;kVPC&#39; indicates a virtual private cloud (VPC) network within AWS. &#39;kSubnet&#39; indicates a subnet inside the VPC. &#39;kNetworkSecurityGroup&#39; represents a network security group. &#39;kInstanceType&#39; represents various machine types. &#39;kKeyPair&#39; represents a pair of public and private key used to login into a Virtual Machine. | [optional] 
**UserAccountId** | **string** | Specifies the account id derived from the ARN of the user. | [optional] 
**UserResourceName** | **string** | Specifies the Amazon Resource Name (ARN) of the user. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


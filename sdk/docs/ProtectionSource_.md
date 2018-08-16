# IO.Swagger.Model.ProtectionSource_
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AcropolisProtectionSource** | [**AcropolisProtectionSource_**](AcropolisProtectionSource_.md) |  | [optional] 
**AwsProtectionSource** | [**AWSProtectionSource_**](AWSProtectionSource_.md) |  | [optional] 
**AzureProtectionSource** | [**AzureProtectionSource_**](AzureProtectionSource_.md) |  | [optional] 
**Environment** | **string** | Specifies the environment (such as &#39;kVMware&#39; or &#39;kSQL&#39;) where the Protection Source exists. Depending on the environment, one of the following Protection Sources are initialized.  NOTE: kPuppeteer refers to Cohesity&#39;s Remote Adapter. Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. | [optional] 
**HypervProtectionSource** | [**HyperVProtectionSource_**](HyperVProtectionSource_.md) |  | [optional] 
**Id** | **long?** | Specifies an id of the Protection Source. | [optional] 
**KvmProtectionSource** | [**KVMProtectionSource_**](KVMProtectionSource_.md) |  | [optional] 
**Name** | **string** | Specifies a name of the Protection Source. | [optional] 
**NasProtectionSource** | [**GenericNASProtectionSource_**](GenericNASProtectionSource_.md) |  | [optional] 
**NetappProtectionSource** | [**NetAppProtectionSource_**](NetAppProtectionSource_.md) |  | [optional] 
**ParentId** | **long?** | Specifies an id of the parent of the Protection Source. | [optional] 
**PhysicalProtectionSource** | [**PhysicalProtectionSource_**](PhysicalProtectionSource_.md) |  | [optional] 
**PureProtectionSource** | [**PureProtectionSource_**](PureProtectionSource_.md) |  | [optional] 
**SqlProtectionSource** | [**SQLProtectionSource_**](SQLProtectionSource_.md) |  | [optional] 
**ViewProtectionSource** | [**ViewProtectionSource_**](ViewProtectionSource_.md) |  | [optional] 
**VmWareProtectionSource** | [**VMwareProtectionSource_**](VMwareProtectionSource_.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


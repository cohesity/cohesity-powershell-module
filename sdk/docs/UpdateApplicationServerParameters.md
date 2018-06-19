# IO.Swagger.Model.UpdateApplicationServerParameters
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Applications** | **List&lt;string&gt;** | Specifies the types of applications such as &#39;kSQL&#39;, &#39;kExchange&#39; running on the Protection Source. overrideDescription: true Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. | [optional] 
**HasPersistentAgent** | **bool?** | Set this to true if a persistent agent is running on the host. If this is specified, then credentials would not be used to log into the host environment. This mechanism may be used in environments such as VMware to get around UAC permission issues by running the agent as a service with the right credentials. If this field is not specified, credentials must be specified. | [optional] 
**Password** | **string** | Specifies password of the username to access the target source. | [optional] 
**ProtectionSourceId** | **long?** | Specifies the Id of the Protection Source that contains one or more Application Servers running on it. | [optional] 
**Username** | **string** | Specifies username to access the target source. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


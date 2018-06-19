# IO.Swagger.Model.ConnectorParams
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Endpoint** | **string** | Specify an IP address or URL of the environment. (such as the IP address of the vCenter Server for a VMware environment). | [optional] 
**Environment** | **string** | Specifies the environment like VMware, SQL, where the Protection Source exists. Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. | [optional] 
**Id** | **long?** | Specifies a Unique id that is generated when the Source is registered. This is a convenience field that is used to maintain an index to different connection params. | [optional] 
**Version** | **long?** | Version is updated each time the connector parameters are updated. This is used to discard older connector parameters. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


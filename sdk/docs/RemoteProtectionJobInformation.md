# IO.Swagger.Model.RemoteProtectionJobInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClusterName** | **string** | Specifies the name of the original Cluster that archived the data to the Vault. | [optional] 
**Environment** | **string** | Specifies the environment type (such as kVMware or kSQL) of the original archived Protection Job. Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. | [optional] 
**JobName** | **string** | Specifies the name of the Protection Job on the original Cluster. | [optional] 
**JobUid** | [**ProtectionJobUid1**](ProtectionJobUid1.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


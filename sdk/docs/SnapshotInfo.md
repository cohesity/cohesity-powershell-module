# IO.Swagger.Model.SnapshotInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Environment** | **string** | Specifies the environment type (such as kVMware or kSQL) that contains the source to backup. Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. | [optional] 
**RelativeSnapshotDirectory** | **string** | Specifies the relative directory path from root path where the snapshot is stored. | [optional] 
**RootPath** | **string** | Specifies the root path where the snapshot is stored, using the following format: \&quot;/ViewBox/ViewName/fs\&quot;. | [optional] 
**ViewName** | **string** | Specifies the name of the View that is cloned. NOTE: This field is only populated for View cloning. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


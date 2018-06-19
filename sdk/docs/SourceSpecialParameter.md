# IO.Swagger.Model.SourceSpecialParameter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PhysicalSpecialParameters** | [**PhysicalSpecialParameters**](PhysicalSpecialParameters.md) | Specifies additional special parameters that are applicable only to Sources of &#39;kHost&#39; type in a kPhysical environment. | [optional] 
**SkipIndexing** | **bool?** | Specifies not to index the objects in the Protection Source when backing up. | [optional] 
**SourceId** | **long?** | Specifies the object id of the Protection Source that these special settings apply. This field must refer to a leaf node such a VM or a Physical Server. | [optional] 
**SqlSpecialParameters** | [**SqlSpecialParameters**](SqlSpecialParameters.md) | Specifies additional special parameters that are applicable only to Protection Sources of &#39;kSQL&#39; type. | [optional] 
**TruncateExchangeLog** | **bool?** | If true, after the Cohesity Cluster successfully captures a Snapshot during a Job Run, the Cluster truncates the Exchange transaction logs on a Microsoft Exchange Server. The default value is false. This field is deprecated. Use the field in ApplicationParameters inside source specific parameter. deprecated: true | [optional] 
**VmCredentials** | [**VMCredentials_**](VMCredentials_.md) |  | [optional] 
**VmwareSpecialParameters** | [**VmwareSpecialParameters**](VmwareSpecialParameters.md) | Specifies additional special parameters that are applicable only to Protection Sources of &#39;kVMware&#39; type. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


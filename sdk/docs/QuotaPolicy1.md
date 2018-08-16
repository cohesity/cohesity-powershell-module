# IO.Swagger.Model.QuotaPolicy1
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AlertLimit** | **string** | AlertLimitBytes converted to GiB format for report purposes. | [optional] 
**HardLimit** | **string** | HardLimitBytes converted to GiB format for report purposes. | [optional] 
**AlertLimitBytes** | **long?** | Specifies if an alert should be triggered when the usage of this resource exceeds this quota limit. This limit is optional and is specified in bytes. If no value is specified, there is no limit. | [optional] 
**AlertThresholdPercentage** | **long?** | Supported only for user quota policy. Specifies when the uage goes above an alert threshold percentage which is: HardLimitBytes * AlertThresholdPercentage, eg: 80% of HardLimitBytes Can only be set if HardLimitBytes is set. Cannot be set if AlertLimitBytes is already set. | [optional] 
**HardLimitBytes** | **long?** | Specifies an optional quota limit on the usage allowed for this resource. This limit is specified in bytes. If no value is specified, there is no limit. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


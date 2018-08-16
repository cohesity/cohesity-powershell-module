# IO.Swagger.Model.EntitySchemaProtoTimeSeriesDescriptor
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MetricDescriptiveName** | **string** | Specifies a descriptive name for the metric that is displayed in the Advanced Diagnostics of the Cohesity Dashboard. For example for the &#39;kUnmorphedUsageBytes&#39; metric, the descriptive name is \&quot;Total Logical Space Used\&quot;. | [optional] 
**MetricName** | **string** | Specifies the name of the metric such as &#39;kUnmorphedUsageBytes&#39;. It should be unique in an entity schema. | [optional] 
**MetricUnit** | [**EntitySchemaProtoTimeSeriesDescriptorMetricUnit**](EntitySchemaProtoTimeSeriesDescriptorMetricUnit.md) |  | [optional] 
**RawMetricPublishIntervalHintSecs** | **int?** | Specifies a suggestion for the interval to collect raw data points. | [optional] 
**TimeToLiveSecs** | **long?** | Specifies how long the data point will be stored. | [optional] 
**ValueType** | **int?** | Specifies the value type for this metric. A metric of type &#39;string\&quot; is not supported, instead use &#39;bytes&#39;. Note that an aggregate metric of type &#39;bytes&#39; is not supported. 0 specifies a value type of Int64. 1 specifies a value type of Double. 2 specifies a value type of String. 3 specifies a value type of Bytes. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


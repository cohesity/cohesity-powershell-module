# IO.Swagger.Model.MetricDataPoint
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Data** | [**ValueData**](ValueData.md) | Corresponding value of a metric at the given timestamp. When client adds or pushes the stats, this field must be specified. When Stats module, returns the time series data, this field could be empty if data point is not available for the given timestamp. | [optional] 
**TimestampMsecs** | **long?** | Specifies a timestamp when the metric data point was captured. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


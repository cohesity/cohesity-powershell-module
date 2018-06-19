# IO.Swagger.Model.BandwidthLimit
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BandwidthLimitOverrides** | [**List&lt;BandwidthLimitOverride&gt;**](BandwidthLimitOverride.md) | Specifies a list of override bandwidth limits and time periods when those limits override the rateLimitBytesPerSec limit. If overlapping time periods are specified, the last one in the array takes precedence. | [optional] 
**RateLimitBytesPerSec** | **long?** | Specifies the maximum allowed data transfer rate between the local Cluster and remote Clusters. The value is specified in bytes per second. If not set, the data transfer rate is not limited. | [optional] 
**Timezone** | **string** | Specifies a time zone for the specified time period. The time zone is defined in the following format: \&quot;Area/Location\&quot;, for example: \&quot;America/New_York\&quot;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


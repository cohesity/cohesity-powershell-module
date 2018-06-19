# IO.Swagger.Api.StatisticsApi

All URIs are relative to *https://localhost/irisservices/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetEntities**](StatisticsApi.md#getentities) | **GET** /public/statistics/entities | Lists the entities for the specified schema.
[**GetEntitiesSchema**](StatisticsApi.md#getentitiesschema) | **GET** /public/statistics/entitiesSchema | List the entity schemas filtered by the specified parameters.
[**GetEntitySchemaByName**](StatisticsApi.md#getentityschemabyname) | **GET** /public/statistics/entitiesSchema/{schemaName} | Get the entity schema for the specified schema.
[**GetTimeSeriesStats**](StatisticsApi.md#gettimeseriesstats) | **GET** /public/statistics/timeSeriesStats | List a series of data points for an entity of a metric in a schema, during the specified time period.


<a name="getentities"></a>
# **GetEntities**
> List<EntityProto> GetEntities (string schemaName, List<string> metricNames = null, bool? includeAggrMetricSources = null)

Lists the entities for the specified schema.

An entity is an object found on the Cohesity Cluster, such as a disk or a Node. In the Cohesity Dashboard, similar functionality is provided in Advanced Diagnostics.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEntitiesExample
    {
        public void main()
        {
            var apiInstance = new StatisticsApi();
            var schemaName = schemaName_example;  // string | Specifies the entity schema to search for entities.
            var metricNames = new List<string>(); // List<string> | Specifies the list of metric names to return such as 'kRandomIos' which corresponds to 'Random IOs' in Advanced Diagnostics of the Cohesity Dashboard. (optional) 
            var includeAggrMetricSources = true;  // bool? | Specifies whether to include the sources of aggregate metrics of an entity. (optional) 

            try
            {
                // Lists the entities for the specified schema.
                List&lt;EntityProto&gt; result = apiInstance.GetEntities(schemaName, metricNames, includeAggrMetricSources);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StatisticsApi.GetEntities: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **schemaName** | **string**| Specifies the entity schema to search for entities. | 
 **metricNames** | [**List&lt;string&gt;**](string.md)| Specifies the list of metric names to return such as &#39;kRandomIos&#39; which corresponds to &#39;Random IOs&#39; in Advanced Diagnostics of the Cohesity Dashboard. | [optional] 
 **includeAggrMetricSources** | **bool?**| Specifies whether to include the sources of aggregate metrics of an entity. | [optional] 

### Return type

[**List<EntityProto>**](EntityProto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getentitiesschema"></a>
# **GetEntitiesSchema**
> List<EntitySchemaProto> GetEntitiesSchema (List<string> metricNames = null, List<string> schemaNames = null)

List the entity schemas filtered by the specified parameters.

An entity schema specifies the meta-data associated with entity such as the list of attributes and a time series of data. For example for a Disk entity, the entity schema specifies the Node that is using this Disk, the type of the Disk, and Metrics about the Disk such as Space Usage, Read IOs and Write IOs. Metrics define data points (time series data) to track over a period of time for a specific interval. If no parameters are specified, all entity schemas found on the Cohesity Cluster are returned. Specifying parameters filters the results that are returned. In the Cohesity Dashboard, similar functionality is provided in Advanced Diagnostics.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEntitiesSchemaExample
    {
        public void main()
        {
            var apiInstance = new StatisticsApi();
            var metricNames = new List<string>(); // List<string> | Specifies the list of metric names to filter by such as 'kRandomIos' which corresponds to 'Random IOs' in Advanced Diagnostics of the Cohesity Dashboard. (optional) 
            var schemaNames = new List<string>(); // List<string> | Specifies the list of schema names to filter by such as 'kIceboxJobVaultStats' which corresponds to 'External Target Job Stats' in Advanced Diagnostics of the Cohesity Dashboard. (optional) 

            try
            {
                // List the entity schemas filtered by the specified parameters.
                List&lt;EntitySchemaProto&gt; result = apiInstance.GetEntitiesSchema(metricNames, schemaNames);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StatisticsApi.GetEntitiesSchema: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **metricNames** | [**List&lt;string&gt;**](string.md)| Specifies the list of metric names to filter by such as &#39;kRandomIos&#39; which corresponds to &#39;Random IOs&#39; in Advanced Diagnostics of the Cohesity Dashboard. | [optional] 
 **schemaNames** | [**List&lt;string&gt;**](string.md)| Specifies the list of schema names to filter by such as &#39;kIceboxJobVaultStats&#39; which corresponds to &#39;External Target Job Stats&#39; in Advanced Diagnostics of the Cohesity Dashboard. | [optional] 

### Return type

[**List<EntitySchemaProto>**](EntitySchemaProto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getentityschemabyname"></a>
# **GetEntitySchemaByName**
> List<EntitySchemaProto> GetEntitySchemaByName (string schemaName)

Get the entity schema for the specified schema.

An entity schema specifies the meta-data associated with entity such as the list of attributes and a time series of data. For example for a Disk entity, the entity schema specifies the Node that is using this Disk, the type of the Disk, and Metrics about the Disk such as Space Usage, Read IOs and Write IOs. Metrics define data points (time series data) to track over a period of time for a specific interval. In the Cohesity Dashboard, similar functionality is provided in Advanced Diagnostics.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEntitySchemaByNameExample
    {
        public void main()
        {
            var apiInstance = new StatisticsApi();
            var schemaName = schemaName_example;  // string | Name of the Schema

            try
            {
                // Get the entity schema for the specified schema.
                List&lt;EntitySchemaProto&gt; result = apiInstance.GetEntitySchemaByName(schemaName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StatisticsApi.GetEntitySchemaByName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **schemaName** | **string**| Name of the Schema | 

### Return type

[**List<EntitySchemaProto>**](EntitySchemaProto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettimeseriesstats"></a>
# **GetTimeSeriesStats**
> MetricDataBlock GetTimeSeriesStats (string schemaName, string entityId, string metricName, long? startTimeMsecs, int? rollupIntervalSecs = null, long? endTimeMsecs = null, string rollupFunction = null)

List a series of data points for an entity of a metric in a schema, during the specified time period.

A Metric specifies a data point (such as CPU usage and IOPS) to track over a period of time. For example for a disk in the Cluster, you can report on the 'Disk Health' (kDiskAwaitTimeMsecs) Metric of the 'Disk Health Metrics' (kSentryDiskStats) Schema for the last week. You must specify the 'k' names as input and not the descriptive names. You must also specify the id of the entity that you are reporting on such as a Cluster, disk drive, job, etc. Get the entityId by running the GET /public/statistics/entities operation. In the Cohesity Dashboard, similar functionality is provided in Advanced Diagnostics.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTimeSeriesStatsExample
    {
        public void main()
        {
            var apiInstance = new StatisticsApi();
            var schemaName = schemaName_example;  // string | Specifies the name of entity schema such as 'kIceboxJobVaultStats'.
            var entityId = entityId_example;  // string | Specifies the id of the entity represented as a string. Get the entityId by running the GET public/statistics/entities operation.
            var metricName = metricName_example;  // string | Specifies the name of the metric such as the 'kDiskAwaitTimeMsecs' which is displayed as 'Disk Health' in Advanced Diagnostics of the Cohesity Dashboard.
            var startTimeMsecs = 789;  // long? | Specifies the start time for the series of metric data. Specify the start time as a Unix epoch Timestamp (in milliseconds).
            var rollupIntervalSecs = 56;  // int? | Specifies the time interval granularity (in seconds) for the specified rollup function. Only specify a value if Rollup function is also specified. (optional) 
            var endTimeMsecs = 789;  // long? | Specifies the end time for the series of metric data. Specify the end time as a Unix epoch Timestamp (in milliseconds). If not specified, the data points up to the current time are returned. (optional) 
            var rollupFunction = rollupFunction_example;  // string | Specifies the rollup function to apply to the data points for the time interval specified by rollupInternalSecs. The following rollup functions are available: sum, average, count, max, min, median, percentile95, latest, and rate. For more information about the functions, see the Advanced Diagnostics in the Cohesity online help. If not specified, raw data is returned. (optional) 

            try
            {
                // List a series of data points for an entity of a metric in a schema, during the specified time period.
                MetricDataBlock result = apiInstance.GetTimeSeriesStats(schemaName, entityId, metricName, startTimeMsecs, rollupIntervalSecs, endTimeMsecs, rollupFunction);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StatisticsApi.GetTimeSeriesStats: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **schemaName** | **string**| Specifies the name of entity schema such as &#39;kIceboxJobVaultStats&#39;. | 
 **entityId** | **string**| Specifies the id of the entity represented as a string. Get the entityId by running the GET public/statistics/entities operation. | 
 **metricName** | **string**| Specifies the name of the metric such as the &#39;kDiskAwaitTimeMsecs&#39; which is displayed as &#39;Disk Health&#39; in Advanced Diagnostics of the Cohesity Dashboard. | 
 **startTimeMsecs** | **long?**| Specifies the start time for the series of metric data. Specify the start time as a Unix epoch Timestamp (in milliseconds). | 
 **rollupIntervalSecs** | **int?**| Specifies the time interval granularity (in seconds) for the specified rollup function. Only specify a value if Rollup function is also specified. | [optional] 
 **endTimeMsecs** | **long?**| Specifies the end time for the series of metric data. Specify the end time as a Unix epoch Timestamp (in milliseconds). If not specified, the data points up to the current time are returned. | [optional] 
 **rollupFunction** | **string**| Specifies the rollup function to apply to the data points for the time interval specified by rollupInternalSecs. The following rollup functions are available: sum, average, count, max, min, median, percentile95, latest, and rate. For more information about the functions, see the Advanced Diagnostics in the Cohesity online help. If not specified, raw data is returned. | [optional] 

### Return type

[**MetricDataBlock**](MetricDataBlock.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


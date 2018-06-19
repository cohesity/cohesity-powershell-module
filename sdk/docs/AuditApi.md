# IO.Swagger.Api.AuditApi

All URIs are relative to *https://localhost/irisservices/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SearchClusterAuditLogs**](AuditApi.md#searchclusterauditlogs) | **GET** /public/auditLogs/cluster | List the cluster audit logs on the Cohesity Cluster that match the filter criteria specified using parameters.


<a name="searchclusterauditlogs"></a>
# **SearchClusterAuditLogs**
> ClusterAuditLogsSearchResult SearchClusterAuditLogs (long? startIndex = null, long? pageCount = null, List<string> domains = null, List<string> entityTypes = null, List<string> actions = null, string search = null, List<string> userNames = null, long? startTimeUsecs = null, long? endTimeUsecs = null, string outputFormat = null)

List the cluster audit logs on the Cohesity Cluster that match the filter criteria specified using parameters.

When actions (such as a login or a Job being paused) occur on the Cohesity Cluster, the Cluster generates Audit Logs. If no parameters are specified, all logs currently on the Cohesity Cluster are returned. Specifying parameters filters the results that are returned.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchClusterAuditLogsExample
    {
        public void main()
        {
            var apiInstance = new AuditApi();
            var startIndex = 789;  // long? | Specifies an index number that can be used to return subsets of items in multiple requests. Break up the items to return into multiple requests by setting pageCount and startIndex to return a subsets of items in the search result. For example, set startIndex to 0 to get the first set of pageCount items for the first request. Increment startIndex by pageCount to get the next set of pageCount items for a next request. Continue until all items are returned and therefore the total number of returned items is equal to totalCount. Default value is 0. (optional) 
            var pageCount = 789;  // long? | Limit the number of items to return in the response for pagination purposes. Default value is 1000. (optional) 
            var domains = new List<string>(); // List<string> | Filter by domains of users who cause the actions that trigger Cluster audit logs. (optional) 
            var entityTypes = new List<string>(); // List<string> | Filter by entity types involved in the actions that generate the Cluster audit logs, such as User, Protection Job, View, etc. For a complete list, see the Category drop-down in the Admin > Audit Logs page of the Cohesity Dashboard. (optional) 
            var actions = new List<string>(); // List<string> | Filter by the actions that generate Cluster audit logs such as Activate, Cancel, Clone, Create, etc. For a complete list, see the Actions drop-down in the Admin > Audit Logs page of the Cohesity Dashboard. (optional) 
            var search = search_example;  // string | Filter by matching a substring in entity name or details of the Cluster audit log. (optional) 
            var userNames = new List<string>(); // List<string> | Filter by user names who cause the actions that generate Cluster Audit Logs. (optional) 
            var startTimeUsecs = 789;  // long? | Filter by a start time. Only Cluster audit logs that were generated after the specified time are returned. Specify the start time as a Unix epoch Timestamp (in microseconds). (optional) 
            var endTimeUsecs = 789;  // long? | Filter by a end time specified as a Unix epoch Timestamp (in microseconds). Only Cluster audit logs that were generated before the specified end time are returned. (optional) 
            var outputFormat = outputFormat_example;  // string | Specifies the format of the output such as csv and json. If not specified, the json format is returned. If csv is specified, a comma-separated list with a heading row is returned. (optional) 

            try
            {
                // List the cluster audit logs on the Cohesity Cluster that match the filter criteria specified using parameters.
                ClusterAuditLogsSearchResult result = apiInstance.SearchClusterAuditLogs(startIndex, pageCount, domains, entityTypes, actions, search, userNames, startTimeUsecs, endTimeUsecs, outputFormat);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuditApi.SearchClusterAuditLogs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startIndex** | **long?**| Specifies an index number that can be used to return subsets of items in multiple requests. Break up the items to return into multiple requests by setting pageCount and startIndex to return a subsets of items in the search result. For example, set startIndex to 0 to get the first set of pageCount items for the first request. Increment startIndex by pageCount to get the next set of pageCount items for a next request. Continue until all items are returned and therefore the total number of returned items is equal to totalCount. Default value is 0. | [optional] 
 **pageCount** | **long?**| Limit the number of items to return in the response for pagination purposes. Default value is 1000. | [optional] 
 **domains** | [**List&lt;string&gt;**](string.md)| Filter by domains of users who cause the actions that trigger Cluster audit logs. | [optional] 
 **entityTypes** | [**List&lt;string&gt;**](string.md)| Filter by entity types involved in the actions that generate the Cluster audit logs, such as User, Protection Job, View, etc. For a complete list, see the Category drop-down in the Admin &gt; Audit Logs page of the Cohesity Dashboard. | [optional] 
 **actions** | [**List&lt;string&gt;**](string.md)| Filter by the actions that generate Cluster audit logs such as Activate, Cancel, Clone, Create, etc. For a complete list, see the Actions drop-down in the Admin &gt; Audit Logs page of the Cohesity Dashboard. | [optional] 
 **search** | **string**| Filter by matching a substring in entity name or details of the Cluster audit log. | [optional] 
 **userNames** | [**List&lt;string&gt;**](string.md)| Filter by user names who cause the actions that generate Cluster Audit Logs. | [optional] 
 **startTimeUsecs** | **long?**| Filter by a start time. Only Cluster audit logs that were generated after the specified time are returned. Specify the start time as a Unix epoch Timestamp (in microseconds). | [optional] 
 **endTimeUsecs** | **long?**| Filter by a end time specified as a Unix epoch Timestamp (in microseconds). Only Cluster audit logs that were generated before the specified end time are returned. | [optional] 
 **outputFormat** | **string**| Specifies the format of the output such as csv and json. If not specified, the json format is returned. If csv is specified, a comma-separated list with a heading row is returned. | [optional] 

### Return type

[**ClusterAuditLogsSearchResult**](ClusterAuditLogsSearchResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


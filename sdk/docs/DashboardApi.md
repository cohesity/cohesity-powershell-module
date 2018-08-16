# IO.Swagger.Api.DashboardApi

All URIs are relative to *https://localhost/irisservices/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDashboard**](DashboardApi.md#getdashboard) | **GET** /public/dashboard | Returns the dashboard that match the filter criteria specified using parameters.


<a name="getdashboard"></a>
# **GetDashboard**
> DashboardResponse GetDashboard (long? clusterId = null, bool? allClusters = null)

Returns the dashboard that match the filter criteria specified using parameters.

If no parameters are specified, dashboard for the local cluster is returned.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDashboardExample
    {
        public void main()
        {
            var apiInstance = new DashboardApi();
            var clusterId = 789;  // long? | Id of the remote cluster for which to fetch the data. If value is not specified, it is assumed to be local cluster. (optional) 
            var allClusters = true;  // bool? | Summary data for all clusters. If this is set to true, ClusterId will be ignored. (optional) 

            try
            {
                // Returns the dashboard that match the filter criteria specified using parameters.
                DashboardResponse result = apiInstance.GetDashboard(clusterId, allClusters);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DashboardApi.GetDashboard: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clusterId** | **long?**| Id of the remote cluster for which to fetch the data. If value is not specified, it is assumed to be local cluster. | [optional] 
 **allClusters** | **bool?**| Summary data for all clusters. If this is set to true, ClusterId will be ignored. | [optional] 

### Return type

[**DashboardResponse**](DashboardResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# IO.Swagger.Api.StaticRouteApi

All URIs are relative to *https://localhost/irisservices/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetStaticRoutes**](StaticRouteApi.md#getstaticroutes) | **GET** /public/staticRoutes | List the Static Routes for the Cohesity Cluster.
[**RemoveStaticRoute**](StaticRouteApi.md#removestaticroute) | **DELETE** /public/staticRoutes/{ip} | Remove the specified Static Route from the Cohesity Cluster.
[**UpdateStaticRoute**](StaticRouteApi.md#updatestaticroute) | **PUT** /public/staticRoutes/{ip} | Create or update a Static Route on the Cohesity Cluster.


<a name="getstaticroutes"></a>
# **GetStaticRoutes**
> List<StaticRoute> GetStaticRoutes ()

List the Static Routes for the Cohesity Cluster.

Returns the Static Routes for the Cohesity Cluster.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStaticRoutesExample
    {
        public void main()
        {
            var apiInstance = new StaticRouteApi();

            try
            {
                // List the Static Routes for the Cohesity Cluster.
                List&lt;StaticRoute&gt; result = apiInstance.GetStaticRoutes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaticRouteApi.GetStaticRoutes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<StaticRoute>**](StaticRoute.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removestaticroute"></a>
# **RemoveStaticRoute**
> void RemoveStaticRoute (string ip)

Remove the specified Static Route from the Cohesity Cluster.

Returns the delete status upon completion.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RemoveStaticRouteExample
    {
        public void main()
        {
            var apiInstance = new StaticRouteApi();
            var ip = ip_example;  // string | Specifies the subnet IP of the route destination network.

            try
            {
                // Remove the specified Static Route from the Cohesity Cluster.
                apiInstance.RemoveStaticRoute(ip);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaticRouteApi.RemoveStaticRoute: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ip** | **string**| Specifies the subnet IP of the route destination network. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatestaticroute"></a>
# **UpdateStaticRoute**
> StaticRoute UpdateStaticRoute (string ip, StaticRoute body = null)

Create or update a Static Route on the Cohesity Cluster.

Returns the created or updated Static Route on the Cohesity Cluster.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateStaticRouteExample
    {
        public void main()
        {
            var apiInstance = new StaticRouteApi();
            var ip = ip_example;  // string | Specifies the subnet IP of the route destination network.
            var body = new StaticRoute(); // StaticRoute |  (optional) 

            try
            {
                // Create or update a Static Route on the Cohesity Cluster.
                StaticRoute result = apiInstance.UpdateStaticRoute(ip, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaticRouteApi.UpdateStaticRoute: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ip** | **string**| Specifies the subnet IP of the route destination network. | 
 **body** | [**StaticRoute**](StaticRoute.md)|  | [optional] 

### Return type

[**StaticRoute**](StaticRoute.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


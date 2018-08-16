# IO.Swagger.Api.ClusterApi

All URIs are relative to *https://localhost/irisservices/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBasicClusterInfo**](ClusterApi.md#getbasicclusterinfo) | **GET** /public/basicClusterInfo | List details about the Cohesity Cluster such as the name, type, version, language, locale and domains. This operation does not require authentication.
[**GetCluster**](ClusterApi.md#getcluster) | **GET** /public/cluster | List details about this Cohesity Cluster.
[**UpdateClusterParams**](ClusterApi.md#updateclusterparams) | **PUT** /public/cluster | Update the configuration of this Cohesity Cluster.


<a name="getbasicclusterinfo"></a>
# **GetBasicClusterInfo**
> BasicClusterInfo GetBasicClusterInfo ()

List details about the Cohesity Cluster such as the name, type, version, language, locale and domains. This operation does not require authentication.

All Active Directory domains that are currently joined to the Cohesity Cluster are returned. In addition, the default LOCAL domain on the Cohesity Cluster is returned as the first element of the domains array in the response.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBasicClusterInfoExample
    {
        public void main()
        {
            var apiInstance = new ClusterApi();

            try
            {
                // List details about the Cohesity Cluster such as the name, type, version, language, locale and domains. This operation does not require authentication.
                BasicClusterInfo result = apiInstance.GetBasicClusterInfo();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClusterApi.GetBasicClusterInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**BasicClusterInfo**](BasicClusterInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcluster"></a>
# **GetCluster**
> Cluster GetCluster (bool? fetchStats = null)

List details about this Cohesity Cluster.

Returns information about this Cohesity Cluster.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClusterExample
    {
        public void main()
        {
            var apiInstance = new ClusterApi();
            var fetchStats = true;  // bool? | If 'true', also get statistics about the Cohesity Cluster. (optional) 

            try
            {
                // List details about this Cohesity Cluster.
                Cluster result = apiInstance.GetCluster(fetchStats);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClusterApi.GetCluster: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fetchStats** | **bool?**| If &#39;true&#39;, also get statistics about the Cohesity Cluster. | [optional] 

### Return type

[**Cluster**](Cluster.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateclusterparams"></a>
# **UpdateClusterParams**
> Cluster UpdateClusterParams (UpdateClusterParams body = null)

Update the configuration of this Cohesity Cluster.

Returns the updated Cluster configuration.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateClusterParamsExample
    {
        public void main()
        {
            var apiInstance = new ClusterApi();
            var body = new UpdateClusterParams(); // UpdateClusterParams | Update Cluster Parameter. (optional) 

            try
            {
                // Update the configuration of this Cohesity Cluster.
                Cluster result = apiInstance.UpdateClusterParams(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClusterApi.UpdateClusterParams: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateClusterParams**](UpdateClusterParams.md)| Update Cluster Parameter. | [optional] 

### Return type

[**Cluster**](Cluster.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# IO.Swagger.Api.PrivilegesApi

All URIs are relative to *https://localhost/irisservices/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPrivileges**](PrivilegesApi.md#getprivileges) | **GET** /public/privileges | List the privileges defined on the Cohesity Cluster.


<a name="getprivileges"></a>
# **GetPrivileges**
> List<PrivilegeInfo> GetPrivileges (string name = null)

List the privileges defined on the Cohesity Cluster.

If the 'name' parameter is not specified, all privileges defined on the Cohesity Cluster are returned. In addition, information about each privilege is returned such as the associated category, description, name,  etc. If an exact privilege name (such as PRINCIPAL_VIEW) is specified in the 'name' parameter, only information about that single privilege is returned.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPrivilegesExample
    {
        public void main()
        {
            var apiInstance = new PrivilegesApi();
            var name = name_example;  // string | Specifies the name of the privilege. (optional) 

            try
            {
                // List the privileges defined on the Cohesity Cluster.
                List&lt;PrivilegeInfo&gt; result = apiInstance.GetPrivileges(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrivilegesApi.GetPrivileges: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Specifies the name of the privilege. | [optional] 

### Return type

[**List<PrivilegeInfo>**](PrivilegeInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


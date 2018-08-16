# IO.Swagger.Api.SMBFileOpensApi

All URIs are relative to *https://localhost/irisservices/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CloseSmbFileOpen**](SMBFileOpensApi.md#closesmbfileopen) | **POST** /public/smbFileOpens | Closes an active SMB file open.
[**GetSmbFileOpens**](SMBFileOpensApi.md#getsmbfileopens) | **GET** /public/smbFileOpens | List the active SMB file opens that match the filter criteria specified using parameters.


<a name="closesmbfileopen"></a>
# **CloseSmbFileOpen**
> void CloseSmbFileOpen (CloseSmbFileOpenParameters body)

Closes an active SMB file open.

Returns nothing upon success.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CloseSmbFileOpenExample
    {
        public void main()
        {
            var apiInstance = new SMBFileOpensApi();
            var body = new CloseSmbFileOpenParameters(); // CloseSmbFileOpenParameters | Request to close an active SMB file open.

            try
            {
                // Closes an active SMB file open.
                apiInstance.CloseSmbFileOpen(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMBFileOpensApi.CloseSmbFileOpen: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CloseSmbFileOpenParameters**](CloseSmbFileOpenParameters.md)| Request to close an active SMB file open. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsmbfileopens"></a>
# **GetSmbFileOpens**
> SmbActiveFileOpensResponse GetSmbFileOpens (string viewName = null, int? pageCount = null, string cookie = null, string filePath = null)

List the active SMB file opens that match the filter criteria specified using parameters.

If no parameters are specified, all active SMB file opens currently on the Cohesity Cluster are returned. Specifying parameters filters the results that are returned.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSmbFileOpensExample
    {
        public void main()
        {
            var apiInstance = new SMBFileOpensApi();
            var viewName = viewName_example;  // string | Specifies the name of the View in which to search. If a view name is not specified, all the views in the Cluster is searched. This field is mandatory if filePath field is specified. (optional) 
            var pageCount = 56;  // int? | Specifies the maximum number of active opens to return in the response. This field cannot be set above 1000. If this is not set, maximum of 1000 entries are returned. (optional) 
            var cookie = cookie_example;  // string | Specifies the opaque string returned in the previous response. If this is set, next set of active opens just after the previous response are returned. If this is not set, first set of active opens are returned. (optional) 
            var filePath = filePath_example;  // string | Specifies the filepath in the view relative to the root filesystem. If this field is specified, viewName field must also be specified. (optional) 

            try
            {
                // List the active SMB file opens that match the filter criteria specified using parameters.
                SmbActiveFileOpensResponse result = apiInstance.GetSmbFileOpens(viewName, pageCount, cookie, filePath);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMBFileOpensApi.GetSmbFileOpens: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **viewName** | **string**| Specifies the name of the View in which to search. If a view name is not specified, all the views in the Cluster is searched. This field is mandatory if filePath field is specified. | [optional] 
 **pageCount** | **int?**| Specifies the maximum number of active opens to return in the response. This field cannot be set above 1000. If this is not set, maximum of 1000 entries are returned. | [optional] 
 **cookie** | **string**| Specifies the opaque string returned in the previous response. If this is set, next set of active opens just after the previous response are returned. If this is not set, first set of active opens are returned. | [optional] 
 **filePath** | **string**| Specifies the filepath in the view relative to the root filesystem. If this field is specified, viewName field must also be specified. | [optional] 

### Return type

[**SmbActiveFileOpensResponse**](SmbActiveFileOpensResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


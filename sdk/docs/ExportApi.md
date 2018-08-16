# IO.Swagger.Api.ExportApi

All URIs are relative to *https://localhost/irisservices/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExportConfig**](ExportApi.md#exportconfig) | **POST** /public/export/config | 


<a name="exportconfig"></a>
# **ExportConfig**
> void ExportConfig (ExportParameters body)



Export metadata into Json files

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExportConfigExample
    {
        public void main()
        {
            var apiInstance = new ExportApi();
            var body = new ExportParameters(); // ExportParameters | Request to open an exported config file to prepare for importing.

            try
            {
                apiInstance.ExportConfig(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExportApi.ExportConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ExportParameters**](ExportParameters.md)| Request to open an exported config file to prepare for importing. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


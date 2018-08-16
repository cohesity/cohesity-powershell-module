# IO.Swagger.Api.ImportApi

All URIs are relative to *https://localhost/irisservices/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ImportConfig**](ImportApi.md#importconfig) | **PUT** /public/import/config | Import config into local cluster.


<a name="importconfig"></a>
# **ImportConfig**
> void ImportConfig (ImportConfigurations body)

Import config into local cluster.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportConfigExample
    {
        public void main()
        {
            var apiInstance = new ImportApi();
            var body = new ImportConfigurations(); // ImportConfigurations | Request to import configurations from an exported file.

            try
            {
                // Import config into local cluster.
                apiInstance.ImportConfig(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportApi.ImportConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ImportConfigurations**](ImportConfigurations.md)| Request to import configurations from an exported file. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# IO.Swagger.Api.CertificatesApi

All URIs are relative to *https://localhost/irisservices/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteWebServerCertificate**](CertificatesApi.md#deletewebservercertificate) | **DELETE** /public/certificates/webServer | Delete the SSL Certificate in the Cluster.
[**GetWebServerCertificate**](CertificatesApi.md#getwebservercertificate) | **GET** /public/certificates/webServer | Get the Server Certificate configured on the Cluster.
[**UpdateWebServerCertificate**](CertificatesApi.md#updatewebservercertificate) | **PUT** /public/certificates/webServer | Update the Web Server Certificate on the Cluster.


<a name="deletewebservercertificate"></a>
# **DeleteWebServerCertificate**
> void DeleteWebServerCertificate ()

Delete the SSL Certificate in the Cluster.

Returns delete status upon completion.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteWebServerCertificateExample
    {
        public void main()
        {
            var apiInstance = new CertificatesApi();

            try
            {
                // Delete the SSL Certificate in the Cluster.
                apiInstance.DeleteWebServerCertificate();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CertificatesApi.DeleteWebServerCertificate: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebservercertificate"></a>
# **GetWebServerCertificate**
> SslCertificateConfig GetWebServerCertificate ()

Get the Server Certificate configured on the Cluster.

Returns the Server Certificate configured on the cluster.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetWebServerCertificateExample
    {
        public void main()
        {
            var apiInstance = new CertificatesApi();

            try
            {
                // Get the Server Certificate configured on the Cluster.
                SslCertificateConfig result = apiInstance.GetWebServerCertificate();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CertificatesApi.GetWebServerCertificate: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**SslCertificateConfig**](SslCertificateConfig.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatewebservercertificate"></a>
# **UpdateWebServerCertificate**
> SslCertificateConfig UpdateWebServerCertificate (SslCertificateConfig body = null)

Update the Web Server Certificate on the Cluster.

Returns the updated Web Server Certificate on the cluster.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateWebServerCertificateExample
    {
        public void main()
        {
            var apiInstance = new CertificatesApi();
            var body = new SslCertificateConfig(); // SslCertificateConfig |  (optional) 

            try
            {
                // Update the Web Server Certificate on the Cluster.
                SslCertificateConfig result = apiInstance.UpdateWebServerCertificate(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CertificatesApi.UpdateWebServerCertificate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SslCertificateConfig**](SslCertificateConfig.md)|  | [optional] 

### Return type

[**SslCertificateConfig**](SslCertificateConfig.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


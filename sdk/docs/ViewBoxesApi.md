# IO.Swagger.Api.ViewBoxesApi

All URIs are relative to *https://localhost/irisservices/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateViewBox**](ViewBoxesApi.md#createviewbox) | **POST** /public/viewBoxes | Create a Domain (View Box).
[**GetViewBoxById**](ViewBoxesApi.md#getviewboxbyid) | **GET** /public/viewBoxes/{id} | List details about a single Domain (View Box).
[**GetViewBoxes**](ViewBoxesApi.md#getviewboxes) | **GET** /public/viewBoxes | List Domains (View Boxes) filtered by the specified parameters.
[**UpdateViewBox**](ViewBoxesApi.md#updateviewbox) | **PUT** /public/viewBoxes/{id} | Update a Domain (View Box).


<a name="createviewbox"></a>
# **CreateViewBox**
> ViewBox CreateViewBox (CreateViewBoxParams body)

Create a Domain (View Box).

Returns the created Domain (View Box).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateViewBoxExample
    {
        public void main()
        {
            var apiInstance = new ViewBoxesApi();
            var body = new CreateViewBoxParams(); // CreateViewBoxParams | Request to create a Storage Domain (View Box) configuration.

            try
            {
                // Create a Domain (View Box).
                ViewBox result = apiInstance.CreateViewBox(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewBoxesApi.CreateViewBox: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateViewBoxParams**](CreateViewBoxParams.md)| Request to create a Storage Domain (View Box) configuration. | 

### Return type

[**ViewBox**](ViewBox.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getviewboxbyid"></a>
# **GetViewBoxById**
> ViewBox GetViewBoxById (long? id)

List details about a single Domain (View Box).

Returns the Domain (View Box) corresponding to the specified Domain (View Box) Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetViewBoxByIdExample
    {
        public void main()
        {
            var apiInstance = new ViewBoxesApi();
            var id = 789;  // long? | Id of the Storage Domain (View Box)

            try
            {
                // List details about a single Domain (View Box).
                ViewBox result = apiInstance.GetViewBoxById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewBoxesApi.GetViewBoxById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the Storage Domain (View Box) | 

### Return type

[**ViewBox**](ViewBox.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getviewboxes"></a>
# **GetViewBoxes**
> List<ViewBox> GetViewBoxes (List<long?> ids = null, List<string> names = null, List<long?> clusterPartitionIds = null, bool? fetchStats = null)

List Domains (View Boxes) filtered by the specified parameters.

If no parameters are specified, all Domains (View Boxes) currently on the Cohesity Cluster are returned. Specifying parameters filters the results that are returned.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetViewBoxesExample
    {
        public void main()
        {
            var apiInstance = new ViewBoxesApi();
            var ids = new List<long?>(); // List<long?> | Filter by a list of Storage Domain (View Box) ids. If empty, View Boxes are not filtered by id. (optional) 
            var names = new List<string>(); // List<string> | Filter by a list of Storage Domain (View Box) Names. If empty, Storage Domains (View Boxes) are not filtered by Name. (optional) 
            var clusterPartitionIds = new List<long?>(); // List<long?> | Filter by a list of Cluster Partition Ids. (optional) 
            var fetchStats = true;  // bool? | Specifies whether to include usage and performance statistics. (optional) 

            try
            {
                // List Domains (View Boxes) filtered by the specified parameters.
                List&lt;ViewBox&gt; result = apiInstance.GetViewBoxes(ids, names, clusterPartitionIds, fetchStats);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewBoxesApi.GetViewBoxes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ids** | [**List&lt;long?&gt;**](long?.md)| Filter by a list of Storage Domain (View Box) ids. If empty, View Boxes are not filtered by id. | [optional] 
 **names** | [**List&lt;string&gt;**](string.md)| Filter by a list of Storage Domain (View Box) Names. If empty, Storage Domains (View Boxes) are not filtered by Name. | [optional] 
 **clusterPartitionIds** | [**List&lt;long?&gt;**](long?.md)| Filter by a list of Cluster Partition Ids. | [optional] 
 **fetchStats** | **bool?**| Specifies whether to include usage and performance statistics. | [optional] 

### Return type

[**List<ViewBox>**](ViewBox.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateviewbox"></a>
# **UpdateViewBox**
> ViewBox UpdateViewBox (long? id, CreateViewBoxParams body)

Update a Domain (View Box).

Returns the updated Domain (View Box).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateViewBoxExample
    {
        public void main()
        {
            var apiInstance = new ViewBoxesApi();
            var id = 789;  // long? | Id of the Storage Domain (View Box)
            var body = new CreateViewBoxParams(); // CreateViewBoxParams | Request to update a Storage Domain (View Box) configuration.

            try
            {
                // Update a Domain (View Box).
                ViewBox result = apiInstance.UpdateViewBox(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewBoxesApi.UpdateViewBox: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the Storage Domain (View Box) | 
 **body** | [**CreateViewBoxParams**](CreateViewBoxParams.md)| Request to update a Storage Domain (View Box) configuration. | 

### Return type

[**ViewBox**](ViewBox.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


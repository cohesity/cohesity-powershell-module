# IO.Swagger.Api.AlertsApi

All URIs are relative to *https://localhost/irisservices/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateResolution**](AlertsApi.md#createresolution) | **POST** /public/alertResolutions | Create an Alert Resolution.
[**GetAlertById**](AlertsApi.md#getalertbyid) | **GET** /public/alerts/{id} | List details about a single Alert.
[**GetAlerts**](AlertsApi.md#getalerts) | **GET** /public/alerts | List the Alerts on the Cohesity Cluster.
[**GetResolutionById**](AlertsApi.md#getresolutionbyid) | **GET** /public/alertResolutions/{id} | List details about a single Alert Resolution.
[**GetResolutions**](AlertsApi.md#getresolutions) | **GET** /public/alertResolutions | List the Alert Resolutions on the Cohesity Cluster.
[**UpdateResolution**](AlertsApi.md#updateresolution) | **PUT** /public/alertResolutions/{id} | Apply an existing Alert Resolution to additional Alerts.


<a name="createresolution"></a>
# **CreateResolution**
> AlertResolution CreateResolution (AlertResolutionRequest body)

Create an Alert Resolution.

Create an Alert Resolution and apply it to one or more Alerts. Mark the Alerts as resolved.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateResolutionExample
    {
        public void main()
        {
            var apiInstance = new AlertsApi();
            var body = new AlertResolutionRequest(); // AlertResolutionRequest | Request to create an Alert Resolution and apply it to the specified Alerts.

            try
            {
                // Create an Alert Resolution.
                AlertResolution result = apiInstance.CreateResolution(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.CreateResolution: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AlertResolutionRequest**](AlertResolutionRequest.md)| Request to create an Alert Resolution and apply it to the specified Alerts. | 

### Return type

[**AlertResolution**](AlertResolution.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalertbyid"></a>
# **GetAlertById**
> Alert GetAlertById (string id)

List details about a single Alert.

Returns the Alert object corresponding to the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAlertByIdExample
    {
        public void main()
        {
            var apiInstance = new AlertsApi();
            var id = id_example;  // string | Unique id of the Alert to return.

            try
            {
                // List details about a single Alert.
                Alert result = apiInstance.GetAlertById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.GetAlertById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Unique id of the Alert to return. | 

### Return type

[**Alert**](Alert.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalerts"></a>
# **GetAlerts**
> List<Alert> GetAlerts (int? maxAlerts, List<string> alertIdList = null, List<int?> alertTypeList = null, List<string> alertStateList = null, List<string> alertSeverityList = null, List<long?> resolutionIdList = null, List<string> alertCategoryList = null, long? startDateUsecs = null, long? endDateUsecs = null)

List the Alerts on the Cohesity Cluster.

Returns all Alert objects found on the Cohesity Cluster that match the filter criteria specified using parameters. The Cohesity Cluster creates an Alert when a potential problem is found or when a threshold has been exceeded on the Cohesity Cluster. If no filter parameters are specified, all Alert objects are returned. Each object provides details about the Alert such as the Status and Severity.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAlertsExample
    {
        public void main()
        {
            var apiInstance = new AlertsApi();
            var maxAlerts = 56;  // int? | Limit the number of returned Alerts. The newest Alerts are returned.
            var alertIdList = new List<string>(); // List<string> | Filter by a list of Alert ids. (optional) 
            var alertTypeList = new List<int?>(); // List<int?> | Filter by a list of Alert Types. (optional) 
            var alertStateList = alertStateList_example;  // List<string> | Filter by a list of Alert States such as 'kOpen' and 'kResolved'. (optional) 
            var alertSeverityList = alertSeverityList_example;  // List<string> | Filter by a list of Alert Severities such as 'kCritical', 'kWarning' and 'kInfo'. (optional) 
            var resolutionIdList = new List<long?>(); // List<long?> | Filter by a list of Resolution Ids. (optional) 
            var alertCategoryList = alertCategoryList_example;  // List<string> | Filter by a list of Alert Categories such as 'kDisk', 'kNode', 'kCluster', 'kNodeHealth', 'kClusterHealth', 'kBackupRestore', 'kEncryption' and 'kArchivalRestore'. (optional) 
            var startDateUsecs = 789;  // long? | Filter by Start Date and Time by specifying a Unix epoch time in microseconds. (optional) 
            var endDateUsecs = 789;  // long? | Filter by End Date and Time by specifying a Unix epoch time in microseconds. (optional) 

            try
            {
                // List the Alerts on the Cohesity Cluster.
                List&lt;Alert&gt; result = apiInstance.GetAlerts(maxAlerts, alertIdList, alertTypeList, alertStateList, alertSeverityList, resolutionIdList, alertCategoryList, startDateUsecs, endDateUsecs);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.GetAlerts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **maxAlerts** | **int?**| Limit the number of returned Alerts. The newest Alerts are returned. | 
 **alertIdList** | [**List&lt;string&gt;**](string.md)| Filter by a list of Alert ids. | [optional] 
 **alertTypeList** | [**List&lt;int?&gt;**](int?.md)| Filter by a list of Alert Types. | [optional] 
 **alertStateList** | **List&lt;string&gt;**| Filter by a list of Alert States such as &#39;kOpen&#39; and &#39;kResolved&#39;. | [optional] 
 **alertSeverityList** | **List&lt;string&gt;**| Filter by a list of Alert Severities such as &#39;kCritical&#39;, &#39;kWarning&#39; and &#39;kInfo&#39;. | [optional] 
 **resolutionIdList** | [**List&lt;long?&gt;**](long?.md)| Filter by a list of Resolution Ids. | [optional] 
 **alertCategoryList** | **List&lt;string&gt;**| Filter by a list of Alert Categories such as &#39;kDisk&#39;, &#39;kNode&#39;, &#39;kCluster&#39;, &#39;kNodeHealth&#39;, &#39;kClusterHealth&#39;, &#39;kBackupRestore&#39;, &#39;kEncryption&#39; and &#39;kArchivalRestore&#39;. | [optional] 
 **startDateUsecs** | **long?**| Filter by Start Date and Time by specifying a Unix epoch time in microseconds. | [optional] 
 **endDateUsecs** | **long?**| Filter by End Date and Time by specifying a Unix epoch time in microseconds. | [optional] 

### Return type

[**List<Alert>**](Alert.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getresolutionbyid"></a>
# **GetResolutionById**
> AlertResolution GetResolutionById (long? id)

List details about a single Alert Resolution.

Returns the Alert Resolution object corresponding to passed in Alert Resolution Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetResolutionByIdExample
    {
        public void main()
        {
            var apiInstance = new AlertsApi();
            var id = 789;  // long? | Unique id of the Alert Resolution to return.

            try
            {
                // List details about a single Alert Resolution.
                AlertResolution result = apiInstance.GetResolutionById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.GetResolutionById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Unique id of the Alert Resolution to return. | 

### Return type

[**AlertResolution**](AlertResolution.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getresolutions"></a>
# **GetResolutions**
> List<AlertResolution> GetResolutions (int? maxResolutions, List<long?> resolutionIdList = null, List<string> alertIdList = null, long? startDateUsecs = null, long? endDateUsecs = null)

List the Alert Resolutions on the Cohesity Cluster.

Returns all Alert Resolution objects found on the Cohesity Cluster that match the filter criteria specified using parameters. If no filter parameters are specified, all Alert Resolution objects are returned. Each object provides details about the Alert Resolution such as the resolution summary and details.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetResolutionsExample
    {
        public void main()
        {
            var apiInstance = new AlertsApi();
            var maxResolutions = 56;  // int? | Limit the number of returned Alert Resolutions. The newest Resolutions are returned.
            var resolutionIdList = new List<long?>(); // List<long?> | Filter by a list of Alert Resolution ids. (optional) 
            var alertIdList = new List<string>(); // List<string> | Filter by a list of Alert ids. (optional) 
            var startDateUsecs = 789;  // long? | Filter by Start Date and Time by specifying a Unix epoch time in microseconds. (optional) 
            var endDateUsecs = 789;  // long? | Filter by End Date and Time by specifying a Unix epoch time in microseconds. (optional) 

            try
            {
                // List the Alert Resolutions on the Cohesity Cluster.
                List&lt;AlertResolution&gt; result = apiInstance.GetResolutions(maxResolutions, resolutionIdList, alertIdList, startDateUsecs, endDateUsecs);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.GetResolutions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **maxResolutions** | **int?**| Limit the number of returned Alert Resolutions. The newest Resolutions are returned. | 
 **resolutionIdList** | [**List&lt;long?&gt;**](long?.md)| Filter by a list of Alert Resolution ids. | [optional] 
 **alertIdList** | [**List&lt;string&gt;**](string.md)| Filter by a list of Alert ids. | [optional] 
 **startDateUsecs** | **long?**| Filter by Start Date and Time by specifying a Unix epoch time in microseconds. | [optional] 
 **endDateUsecs** | **long?**| Filter by End Date and Time by specifying a Unix epoch time in microseconds. | [optional] 

### Return type

[**List<AlertResolution>**](AlertResolution.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateresolution"></a>
# **UpdateResolution**
> AlertResolution UpdateResolution (long? id, UpdateResolutionParams body)

Apply an existing Alert Resolution to additional Alerts.

Apply an existing Alert Resolution to one or more additional Alerts. Mark those additional Alerts as resolved.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateResolutionExample
    {
        public void main()
        {
            var apiInstance = new AlertsApi();
            var id = 789;  // long? | Unique id of the Alert Resolution to return.
            var body = new UpdateResolutionParams(); // UpdateResolutionParams | Request to apply an existing resolution to the specified Alerts.

            try
            {
                // Apply an existing Alert Resolution to additional Alerts.
                AlertResolution result = apiInstance.UpdateResolution(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.UpdateResolution: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Unique id of the Alert Resolution to return. | 
 **body** | [**UpdateResolutionParams**](UpdateResolutionParams.md)| Request to apply an existing resolution to the specified Alerts. | 

### Return type

[**AlertResolution**](AlertResolution.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# IO.Swagger.Api.AnalyticsApi

All URIs are relative to *https://localhost/irisservices/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AnalyzeJar**](AnalyticsApi.md#analyzejar) | **POST** /public/analytics/analyzeJar | Analyze the uploaded jar.
[**CancelMapReduceInstanceRun**](AnalyticsApi.md#cancelmapreduceinstancerun) | **PUT** /public/analytics/cancelAppInstanceRun/{id} | Cancel a specific map reduce instance run.
[**CreateApplication**](AnalyticsApi.md#createapplication) | **POST** /public/analytics/apps | Create an Application.
[**CreateMapper**](AnalyticsApi.md#createmapper) | **POST** /public/analytics/mappers | Create a Mapper.
[**CreateReducer**](AnalyticsApi.md#createreducer) | **POST** /public/analytics/reducers | Create a Reducer.
[**DeleteApplication**](AnalyticsApi.md#deleteapplication) | **DELETE** /public/analytics/apps/{id} | Delete an Application.
[**DeleteMapReduceInstanceRun**](AnalyticsApi.md#deletemapreduceinstancerun) | **DELETE** /public/analytics/mrAppRun/{id} | Delete a Map-Reduce Application Instance Run.
[**DeleteMapper**](AnalyticsApi.md#deletemapper) | **DELETE** /public/analytics/mappers/{id} | Delete a Mapper.
[**DeleteReducer**](AnalyticsApi.md#deletereducer) | **DELETE** /public/analytics/reducers/{id} | Delete a Reducer.
[**DeleteUploadedJar**](AnalyticsApi.md#deleteuploadedjar) | **DELETE** /public/analytics/uploadJar | Delete the uploaded jar from temporary locaation.
[**DownloadMRBaseJar**](AnalyticsApi.md#downloadmrbasejar) | **GET** /public/analytics/mrBaseJar | Downloads the map reduce base jar.
[**DownloadMROutputFiles**](AnalyticsApi.md#downloadmroutputfiles) | **GET** /public/analytics/mrOutputfiles | Download map reduce base instance run output files from Yoda.
[**GetApplicationById**](AnalyticsApi.md#getapplicationbyid) | **GET** /public/analytics/apps/{id} | List details about a single Application.
[**GetApplications**](AnalyticsApi.md#getapplications) | **GET** /public/analytics/apps | List Applications filtered by the specified parameters.
[**GetMRUploadJarPath**](AnalyticsApi.md#getmruploadjarpath) | **GET** /public/analytics/uploadJarPath | Get details about the mounted path to upload Jars.
[**GetMapReduceAppRuns**](AnalyticsApi.md#getmapreduceappruns) | **GET** /public/analytics/mrAppRuns | List map reduce application runs filtered by the specified parameters.
[**GetMapperById**](AnalyticsApi.md#getmapperbyid) | **GET** /public/analytics/mappers/{id} | List details about a single Mapper.
[**GetMappers**](AnalyticsApi.md#getmappers) | **GET** /public/analytics/mappers | List Mappers filtered by the specified parameters.
[**GetReducerById**](AnalyticsApi.md#getreducerbyid) | **GET** /public/analytics/reducers/{id} | List details about a single Reducer.
[**GetReducers**](AnalyticsApi.md#getreducers) | **GET** /public/analytics/reducers | List Reducers filtered by the specified parameters.
[**RunMapReduceAppInstance**](AnalyticsApi.md#runmapreduceappinstance) | **PUT** /public/analytics/runAppInstance | Run a map-reduce application instance.
[**UpdateApplication**](AnalyticsApi.md#updateapplication) | **PUT** /public/analytics/apps/{id} | Update an Application.
[**UpdateMapper**](AnalyticsApi.md#updatemapper) | **PUT** /public/analytics/mappers/{id} | Update a Mapper.
[**UpdateReducer**](AnalyticsApi.md#updatereducer) | **PUT** /public/analytics/reducers/{id} | Update a Reducer.
[**UploadJar**](AnalyticsApi.md#uploadjar) | **POST** /public/analytics/uploadJar | Upload a jar to pre-specified Yoda internal view.


<a name="analyzejar"></a>
# **AnalyzeJar**
> AnalyseJarResult AnalyzeJar (AnalyseJarArg body = null)

Analyze the uploaded jar.

Returns the result of the jar analysis.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AnalyzeJarExample
    {
        public void main()
        {
            var apiInstance = new AnalyticsApi();
            var body = new AnalyseJarArg(); // AnalyseJarArg |  (optional) 

            try
            {
                // Analyze the uploaded jar.
                AnalyseJarResult result = apiInstance.AnalyzeJar(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyzeJar: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AnalyseJarArg**](AnalyseJarArg.md)|  | [optional] 

### Return type

[**AnalyseJarResult**](AnalyseJarResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelmapreduceinstancerun"></a>
# **CancelMapReduceInstanceRun**
> KillMapReduceInstanceResult CancelMapReduceInstanceRun (long? id)

Cancel a specific map reduce instance run.

Returns the result.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CancelMapReduceInstanceRunExample
    {
        public void main()
        {
            var apiInstance = new AnalyticsApi();
            var id = 789;  // long? | 

            try
            {
                // Cancel a specific map reduce instance run.
                KillMapReduceInstanceResult result = apiInstance.CancelMapReduceInstanceRun(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.CancelMapReduceInstanceRun: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**|  | 

### Return type

[**KillMapReduceInstanceResult**](KillMapReduceInstanceResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createapplication"></a>
# **CreateApplication**
> MapReduceInfo CreateApplication (MapReduceInfo body = null)

Create an Application.

Returns the created application.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateApplicationExample
    {
        public void main()
        {
            var apiInstance = new AnalyticsApi();
            var body = new MapReduceInfo(); // MapReduceInfo |  (optional) 

            try
            {
                // Create an Application.
                MapReduceInfo result = apiInstance.CreateApplication(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.CreateApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MapReduceInfo**](MapReduceInfo.md)|  | [optional] 

### Return type

[**MapReduceInfo**](MapReduceInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createmapper"></a>
# **CreateMapper**
> MapperInfo CreateMapper (MapperInfo body = null)

Create a Mapper.

Returns the created mapper.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateMapperExample
    {
        public void main()
        {
            var apiInstance = new AnalyticsApi();
            var body = new MapperInfo(); // MapperInfo |  (optional) 

            try
            {
                // Create a Mapper.
                MapperInfo result = apiInstance.CreateMapper(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.CreateMapper: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MapperInfo**](MapperInfo.md)|  | [optional] 

### Return type

[**MapperInfo**](MapperInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createreducer"></a>
# **CreateReducer**
> ReducerInfo CreateReducer (ReducerInfo body = null)

Create a Reducer.

Returns the created reducer.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateReducerExample
    {
        public void main()
        {
            var apiInstance = new AnalyticsApi();
            var body = new ReducerInfo(); // ReducerInfo |  (optional) 

            try
            {
                // Create a Reducer.
                ReducerInfo result = apiInstance.CreateReducer(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.CreateReducer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReducerInfo**](ReducerInfo.md)|  | [optional] 

### Return type

[**ReducerInfo**](ReducerInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteapplication"></a>
# **DeleteApplication**
> void DeleteApplication (long? id)

Delete an Application.

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
    public class DeleteApplicationExample
    {
        public void main()
        {
            var apiInstance = new AnalyticsApi();
            var id = 789;  // long? | 

            try
            {
                // Delete an Application.
                apiInstance.DeleteApplication(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.DeleteApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemapreduceinstancerun"></a>
# **DeleteMapReduceInstanceRun**
> void DeleteMapReduceInstanceRun (long? id)

Delete a Map-Reduce Application Instance Run.

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
    public class DeleteMapReduceInstanceRunExample
    {
        public void main()
        {
            var apiInstance = new AnalyticsApi();
            var id = 789;  // long? | 

            try
            {
                // Delete a Map-Reduce Application Instance Run.
                apiInstance.DeleteMapReduceInstanceRun(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.DeleteMapReduceInstanceRun: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemapper"></a>
# **DeleteMapper**
> void DeleteMapper (long? id)

Delete a Mapper.

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
    public class DeleteMapperExample
    {
        public void main()
        {
            var apiInstance = new AnalyticsApi();
            var id = 789;  // long? | 

            try
            {
                // Delete a Mapper.
                apiInstance.DeleteMapper(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.DeleteMapper: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletereducer"></a>
# **DeleteReducer**
> void DeleteReducer (long? id)

Delete a Reducer.

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
    public class DeleteReducerExample
    {
        public void main()
        {
            var apiInstance = new AnalyticsApi();
            var id = 789;  // long? | 

            try
            {
                // Delete a Reducer.
                apiInstance.DeleteReducer(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.DeleteReducer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteuploadedjar"></a>
# **DeleteUploadedJar**
> void DeleteUploadedJar (UploadMRJarViewPathWrapper body = null)

Delete the uploaded jar from temporary locaation.

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
    public class DeleteUploadedJarExample
    {
        public void main()
        {
            var apiInstance = new AnalyticsApi();
            var body = new UploadMRJarViewPathWrapper(); // UploadMRJarViewPathWrapper |  (optional) 

            try
            {
                // Delete the uploaded jar from temporary locaation.
                apiInstance.DeleteUploadedJar(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.DeleteUploadedJar: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UploadMRJarViewPathWrapper**](UploadMRJarViewPathWrapper.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="downloadmrbasejar"></a>
# **DownloadMRBaseJar**
> ExtractFileRangeResult DownloadMRBaseJar ()

Downloads the map reduce base jar.

Returns a struct containing the map reduce base jar from the cluster.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DownloadMRBaseJarExample
    {
        public void main()
        {
            var apiInstance = new AnalyticsApi();

            try
            {
                // Downloads the map reduce base jar.
                ExtractFileRangeResult result = apiInstance.DownloadMRBaseJar();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.DownloadMRBaseJar: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ExtractFileRangeResult**](ExtractFileRangeResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="downloadmroutputfiles"></a>
# **DownloadMROutputFiles**
> ExtractFileRangeResult DownloadMROutputFiles (string filePath = null, long? startOffset = null, long? lengthBytes = null, bool? isNfsFile = null, long? partitionId = null, long? viewBoxId = null, string viewName = null)

Download map reduce base instance run output files from Yoda.

Returns a struct containing the map reduce instance run output files from Yoda.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DownloadMROutputFilesExample
    {
        public void main()
        {
            var apiInstance = new AnalyticsApi();
            var filePath = filePath_example;  // string | filepath of the file on NFS. (optional) 
            var startOffset = 789;  // long? | start offset from where bytes will be read. (optional) 
            var lengthBytes = 789;  // long? | Number of bytes to be read from start_offset. (optional) 
            var isNfsFile = true;  // bool? | If true, then extracts file from NFS, else from local file system. (optional) 
            var partitionId = 789;  // long? | Cluster partition id for the file to be read. (optional) 
            var viewBoxId = 789;  // long? | View box id for the file to be read. Required for nfs files only. (optional) 
            var viewName = viewName_example;  // string | View name for the file to be read. Required for nfs files only. (optional) 

            try
            {
                // Download map reduce base instance run output files from Yoda.
                ExtractFileRangeResult result = apiInstance.DownloadMROutputFiles(filePath, startOffset, lengthBytes, isNfsFile, partitionId, viewBoxId, viewName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.DownloadMROutputFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filePath** | **string**| filepath of the file on NFS. | [optional] 
 **startOffset** | **long?**| start offset from where bytes will be read. | [optional] 
 **lengthBytes** | **long?**| Number of bytes to be read from start_offset. | [optional] 
 **isNfsFile** | **bool?**| If true, then extracts file from NFS, else from local file system. | [optional] 
 **partitionId** | **long?**| Cluster partition id for the file to be read. | [optional] 
 **viewBoxId** | **long?**| View box id for the file to be read. Required for nfs files only. | [optional] 
 **viewName** | **string**| View name for the file to be read. Required for nfs files only. | [optional] 

### Return type

[**ExtractFileRangeResult**](ExtractFileRangeResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapplicationbyid"></a>
# **GetApplicationById**
> MapReduceInfo GetApplicationById (long? id)

List details about a single Application.

Returns the Application corresponding to the specified Application Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetApplicationByIdExample
    {
        public void main()
        {
            var apiInstance = new AnalyticsApi();
            var id = 789;  // long? | 

            try
            {
                // List details about a single Application.
                MapReduceInfo result = apiInstance.GetApplicationById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetApplicationById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**|  | 

### Return type

[**MapReduceInfo**](MapReduceInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapplications"></a>
# **GetApplications**
> ApplicationsWrapper GetApplications ()

List Applications filtered by the specified parameters.

If no parameters are specified, all Applications currently on the Cohesity Cluster are returned. Specifying parameters filters the results that are returned.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetApplicationsExample
    {
        public void main()
        {
            var apiInstance = new AnalyticsApi();

            try
            {
                // List Applications filtered by the specified parameters.
                ApplicationsWrapper result = apiInstance.GetApplications();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetApplications: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ApplicationsWrapper**](ApplicationsWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmruploadjarpath"></a>
# **GetMRUploadJarPath**
> GetMRJarUploadPathResult GetMRUploadJarPath ()

Get details about the mounted path to upload Jars.

Returns the mounted path to upload Jars.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMRUploadJarPathExample
    {
        public void main()
        {
            var apiInstance = new AnalyticsApi();

            try
            {
                // Get details about the mounted path to upload Jars.
                GetMRJarUploadPathResult result = apiInstance.GetMRUploadJarPath();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetMRUploadJarPath: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**GetMRJarUploadPathResult**](GetMRJarUploadPathResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmapreduceappruns"></a>
# **GetMapReduceAppRuns**
> ApplicationsWrapper GetMapReduceAppRuns (GetMapReduceAppRunsParams body = null)

List map reduce application runs filtered by the specified parameters.

If no parameters are specified, all map reduce application instance runs currently on the Cohesity Cluster are returned. Specifying parameters filters the results that are returned.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMapReduceAppRunsExample
    {
        public void main()
        {
            var apiInstance = new AnalyticsApi();
            var body = new GetMapReduceAppRunsParams(); // GetMapReduceAppRunsParams |  (optional) 

            try
            {
                // List map reduce application runs filtered by the specified parameters.
                ApplicationsWrapper result = apiInstance.GetMapReduceAppRuns(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetMapReduceAppRuns: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GetMapReduceAppRunsParams**](GetMapReduceAppRunsParams.md)|  | [optional] 

### Return type

[**ApplicationsWrapper**](ApplicationsWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmapperbyid"></a>
# **GetMapperById**
> MapperInfo GetMapperById (long? id)

List details about a single Mapper.

Returns the Mapper corresponding to the specified Mapper Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMapperByIdExample
    {
        public void main()
        {
            var apiInstance = new AnalyticsApi();
            var id = 789;  // long? | 

            try
            {
                // List details about a single Mapper.
                MapperInfo result = apiInstance.GetMapperById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetMapperById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**|  | 

### Return type

[**MapperInfo**](MapperInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmappers"></a>
# **GetMappers**
> MappersWrapper GetMappers ()

List Mappers filtered by the specified parameters.

If no parameters are specified, all Mappers currently on the Cohesity Cluster are returned. Specifying parameters filters the results that are returned.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMappersExample
    {
        public void main()
        {
            var apiInstance = new AnalyticsApi();

            try
            {
                // List Mappers filtered by the specified parameters.
                MappersWrapper result = apiInstance.GetMappers();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetMappers: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**MappersWrapper**](MappersWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreducerbyid"></a>
# **GetReducerById**
> ReducerInfo GetReducerById (long? id)

List details about a single Reducer.

Returns the Reducer corresponding to the specified Reducer Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetReducerByIdExample
    {
        public void main()
        {
            var apiInstance = new AnalyticsApi();
            var id = 789;  // long? | 

            try
            {
                // List details about a single Reducer.
                ReducerInfo result = apiInstance.GetReducerById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetReducerById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**|  | 

### Return type

[**ReducerInfo**](ReducerInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreducers"></a>
# **GetReducers**
> ReducersWrapper GetReducers ()

List Reducers filtered by the specified parameters.

If no parameters are specified, all Reducers currently on the Cohesity Cluster are returned. Specifying parameters filters the results that are returned.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetReducersExample
    {
        public void main()
        {
            var apiInstance = new AnalyticsApi();

            try
            {
                // List Reducers filtered by the specified parameters.
                ReducersWrapper result = apiInstance.GetReducers();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetReducers: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ReducersWrapper**](ReducersWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="runmapreduceappinstance"></a>
# **RunMapReduceAppInstance**
> RunMapReduceInstanceResult RunMapReduceAppInstance (RunMapReduceParams body = null)

Run a map-reduce application instance.

Returns the updated Application.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RunMapReduceAppInstanceExample
    {
        public void main()
        {
            var apiInstance = new AnalyticsApi();
            var body = new RunMapReduceParams(); // RunMapReduceParams |  (optional) 

            try
            {
                // Run a map-reduce application instance.
                RunMapReduceInstanceResult result = apiInstance.RunMapReduceAppInstance(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.RunMapReduceAppInstance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RunMapReduceParams**](RunMapReduceParams.md)|  | [optional] 

### Return type

[**RunMapReduceInstanceResult**](RunMapReduceInstanceResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateapplication"></a>
# **UpdateApplication**
> MapReduceInfo UpdateApplication (long? id, MapReduceInfo body = null)

Update an Application.

Returns the updated Application.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateApplicationExample
    {
        public void main()
        {
            var apiInstance = new AnalyticsApi();
            var id = 789;  // long? | 
            var body = new MapReduceInfo(); // MapReduceInfo |  (optional) 

            try
            {
                // Update an Application.
                MapReduceInfo result = apiInstance.UpdateApplication(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.UpdateApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**|  | 
 **body** | [**MapReduceInfo**](MapReduceInfo.md)|  | [optional] 

### Return type

[**MapReduceInfo**](MapReduceInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemapper"></a>
# **UpdateMapper**
> MapperInfo UpdateMapper (long? id, MapperInfo body = null)

Update a Mapper.

Returns the updated Mapper.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateMapperExample
    {
        public void main()
        {
            var apiInstance = new AnalyticsApi();
            var id = 789;  // long? | 
            var body = new MapperInfo(); // MapperInfo |  (optional) 

            try
            {
                // Update a Mapper.
                MapperInfo result = apiInstance.UpdateMapper(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.UpdateMapper: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**|  | 
 **body** | [**MapperInfo**](MapperInfo.md)|  | [optional] 

### Return type

[**MapperInfo**](MapperInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatereducer"></a>
# **UpdateReducer**
> ReducerInfo UpdateReducer (long? id, ReducerInfo body = null)

Update a Reducer.

Returns the updated reducer.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateReducerExample
    {
        public void main()
        {
            var apiInstance = new AnalyticsApi();
            var id = 789;  // long? | 
            var body = new ReducerInfo(); // ReducerInfo |  (optional) 

            try
            {
                // Update a Reducer.
                ReducerInfo result = apiInstance.UpdateReducer(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.UpdateReducer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**|  | 
 **body** | [**ReducerInfo**](ReducerInfo.md)|  | [optional] 

### Return type

[**ReducerInfo**](ReducerInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadjar"></a>
# **UploadJar**
> UploadMRJarViewPathWrapper UploadJar ()

Upload a jar to pre-specified Yoda internal view.

Returns a struct containing the jar name and local mount path where the jar will be uploaded.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UploadJarExample
    {
        public void main()
        {
            var apiInstance = new AnalyticsApi();

            try
            {
                // Upload a jar to pre-specified Yoda internal view.
                UploadMRJarViewPathWrapper result = apiInstance.UploadJar();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.UploadJar: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**UploadMRJarViewPathWrapper**](UploadMRJarViewPathWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


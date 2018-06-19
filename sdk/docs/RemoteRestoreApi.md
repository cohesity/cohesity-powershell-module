# IO.Swagger.Api.RemoteRestoreApi

All URIs are relative to *https://localhost/irisservices/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateRemoteVaultRestoreTask**](RemoteRestoreApi.md#createremotevaultrestoretask) | **POST** /public/remoteVaults/restoreTasks | Create a remote Vault restore task. (CloudRetrieve)
[**CreateRemoteVaultSearchJob**](RemoteRestoreApi.md#createremotevaultsearchjob) | **POST** /public/remoteVaults/searchJobs | Create a search of a remote Vault. (CloudRetrieve)
[**GetRemoteVaultSearchJobResults**](RemoteRestoreApi.md#getremotevaultsearchjobresults) | **GET** /public/remoteVaults/searchJobResults | List details about the Job Runs of Protection Jobs found by a single search of a remote Vault. (CloudRetrieve)
[**ListRemoteVaultRestoreTasks**](RemoteRestoreApi.md#listremotevaultrestoretasks) | **GET** /public/remoteVaults/restoreTasks | List the remote Vault restore tasks that have completed or are running on this Cohesity Cluster. (CloudRetrieve)
[**ListRemoteVaultSearchJobById**](RemoteRestoreApi.md#listremotevaultsearchjobbyid) | **GET** /public/remoteVaults/searchJobs/{id} | List details about a single search Job of a remote Vault. (CloudRetrieve)
[**ListRemoteVaultSearchJobs**](RemoteRestoreApi.md#listremotevaultsearchjobs) | **GET** /public/remoteVaults/searchJobs | List all the searches of remote Vaults. (CloudRetrieve)
[**StopRemoteVaultSearchJob**](RemoteRestoreApi.md#stopremotevaultsearchjob) | **DELETE** /public/remoteVaults/searchJobs | Stop a search of a remote Vault (External Target). (CloudRetrieve)
[**UploadVaultEncryptionKeys**](RemoteRestoreApi.md#uploadvaultencryptionkeys) | **PUT** /public/remoteVaults/encryptionKeys/{id} | Upload the encryption keys required to restore data from a remote Vault. (CloudRetrieve)


<a name="createremotevaultrestoretask"></a>
# **CreateRemoteVaultRestoreTask**
> UniversalId CreateRemoteVaultRestoreTask (CreateRemoteVaultRestoreTaskParameters body)

Create a remote Vault restore task. (CloudRetrieve)

Returns the id of the remote Vault restore Task that was created.  After a Vault is searched by a search Job, this operation can be called to create a task that restores the indexes and/or the Snapshots of a Protection Job, which were archived on a remote Vault (External Target). This is part of the CloudRetrieve functionality for finding and restoring archived data from remote Vaults to an alternative (non-original) Cluster.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateRemoteVaultRestoreTaskExample
    {
        public void main()
        {
            var apiInstance = new RemoteRestoreApi();
            var body = new CreateRemoteVaultRestoreTaskParameters(); // CreateRemoteVaultRestoreTaskParameters | Request to create a remote Vault restore task.

            try
            {
                // Create a remote Vault restore task. (CloudRetrieve)
                UniversalId result = apiInstance.CreateRemoteVaultRestoreTask(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RemoteRestoreApi.CreateRemoteVaultRestoreTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateRemoteVaultRestoreTaskParameters**](CreateRemoteVaultRestoreTaskParameters.md)| Request to create a remote Vault restore task. | 

### Return type

[**UniversalId**](UniversalId.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createremotevaultsearchjob"></a>
# **CreateRemoteVaultSearchJob**
> CreatedRemoteVaultSearchJobUid CreateRemoteVaultSearchJob (CreateRemoteVaultSearchJobParameters body)

Create a search of a remote Vault. (CloudRetrieve)

A search Job finds Protection Jobs that archived data to a Vault (External Target) which also match the specified search criteria. The results can be optionally filtered by specifying a Cluster match string, a Protection Job match string, a start time and an end time. This is part of the CloudRetrieve functionality for finding and restoring archived data from remote Vaults to an alternative (non-original) Cluster.  NOTE: A Vault is equivalent to an External Target in the Cohesity Dashboard. A search Job is equivalent to a search task in the Cohesity Dashboard.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateRemoteVaultSearchJobExample
    {
        public void main()
        {
            var apiInstance = new RemoteRestoreApi();
            var body = new CreateRemoteVaultSearchJobParameters(); // CreateRemoteVaultSearchJobParameters | Request to create a search of a remote Vault.

            try
            {
                // Create a search of a remote Vault. (CloudRetrieve)
                CreatedRemoteVaultSearchJobUid result = apiInstance.CreateRemoteVaultSearchJob(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RemoteRestoreApi.CreateRemoteVaultSearchJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateRemoteVaultSearchJobParameters**](CreateRemoteVaultSearchJobParameters.md)| Request to create a search of a remote Vault. | 

### Return type

[**CreatedRemoteVaultSearchJobUid**](CreatedRemoteVaultSearchJobUid.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getremotevaultsearchjobresults"></a>
# **GetRemoteVaultSearchJobResults**
> RemoteVaultSearchJobResults GetRemoteVaultSearchJobResults (long? searchJobId, long? clusterId, long? clusterIncarnationId, string cookie = null, int? pageCount = null, string clusterName = null)

List details about the Job Runs of Protection Jobs found by a single search of a remote Vault. (CloudRetrieve)

Specify a unique id of the search Job using a combination of the searchJobId, clusterId, and clusterIncarnationId parameters, which are all required.  The results can be optionally filtered by the remote Cluster name. This is part of the CloudRetrieve functionality for finding and restoring archived data from a remote Vault.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRemoteVaultSearchJobResultsExample
    {
        public void main()
        {
            var apiInstance = new RemoteRestoreApi();
            var searchJobId = 789;  // long? | Specifies the id of the remote Vault search Job assigned by the Cohesity Cluster. Used in combination with the clusterId and clusterIncarnationId to uniquely identify the search Job.
            var clusterId = 789;  // long? | Specifies the Cohesity Cluster id where the search Job was created. Used in combination with the searchJobId and clusterIncarnationId to uniquely identify the search Job.
            var clusterIncarnationId = 789;  // long? | Specifies the incarnation id of the Cohesity Cluster where the search Job was created. Used in combination with the searchJobId and clusterId to uniquely identify the search Job.
            var cookie = cookie_example;  // string | Specifies the opaque string cookie returned by the previous response, to get next set of results. Used in combination with pageCount to support pagination. (optional) 
            var pageCount = 56;  // int? | Specifies the number of Protection Jobs to return in the response to support pagination. (optional) 
            var clusterName = clusterName_example;  // string | Optionally filter the result by the remote Cohesity Cluster name. (optional) 

            try
            {
                // List details about the Job Runs of Protection Jobs found by a single search of a remote Vault. (CloudRetrieve)
                RemoteVaultSearchJobResults result = apiInstance.GetRemoteVaultSearchJobResults(searchJobId, clusterId, clusterIncarnationId, cookie, pageCount, clusterName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RemoteRestoreApi.GetRemoteVaultSearchJobResults: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchJobId** | **long?**| Specifies the id of the remote Vault search Job assigned by the Cohesity Cluster. Used in combination with the clusterId and clusterIncarnationId to uniquely identify the search Job. | 
 **clusterId** | **long?**| Specifies the Cohesity Cluster id where the search Job was created. Used in combination with the searchJobId and clusterIncarnationId to uniquely identify the search Job. | 
 **clusterIncarnationId** | **long?**| Specifies the incarnation id of the Cohesity Cluster where the search Job was created. Used in combination with the searchJobId and clusterId to uniquely identify the search Job. | 
 **cookie** | **string**| Specifies the opaque string cookie returned by the previous response, to get next set of results. Used in combination with pageCount to support pagination. | [optional] 
 **pageCount** | **int?**| Specifies the number of Protection Jobs to return in the response to support pagination. | [optional] 
 **clusterName** | **string**| Optionally filter the result by the remote Cohesity Cluster name. | [optional] 

### Return type

[**RemoteVaultSearchJobResults**](RemoteVaultSearchJobResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listremotevaultrestoretasks"></a>
# **ListRemoteVaultRestoreTasks**
> List<RemoteVaultRestoreTaskStatus> ListRemoteVaultRestoreTasks ()

List the remote Vault restore tasks that have completed or are running on this Cohesity Cluster. (CloudRetrieve)

A remote Vault restore task can restore archived data from a Vault (External Target) to this local Cluster. This is part of the CloudRetrieve functionality for finding and restoring archived data from remote Vaults to an alternative (non-original) Cluster.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListRemoteVaultRestoreTasksExample
    {
        public void main()
        {
            var apiInstance = new RemoteRestoreApi();

            try
            {
                // List the remote Vault restore tasks that have completed or are running on this Cohesity Cluster. (CloudRetrieve)
                List&lt;RemoteVaultRestoreTaskStatus&gt; result = apiInstance.ListRemoteVaultRestoreTasks();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RemoteRestoreApi.ListRemoteVaultRestoreTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<RemoteVaultRestoreTaskStatus>**](RemoteVaultRestoreTaskStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listremotevaultsearchjobbyid"></a>
# **ListRemoteVaultSearchJobById**
> RemoteVaultSearchJobInformation ListRemoteVaultSearchJobById (long? id)

List details about a single search Job of a remote Vault. (CloudRetrieve)

Specify an id for a completed or running search Job. A search Job finds data that has been archived to a Vault (External Target). The returned results do not include Job Run (Snapshot) information. It is part of the CloudRetrieve functionality for finding and restoring archived data from remote Vaults to an alternative (non-original) Cluster.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListRemoteVaultSearchJobByIdExample
    {
        public void main()
        {
            var apiInstance = new RemoteRestoreApi();
            var id = 789;  // long? | Specifies the id of the remote Vault search Job to return.

            try
            {
                // List details about a single search Job of a remote Vault. (CloudRetrieve)
                RemoteVaultSearchJobInformation result = apiInstance.ListRemoteVaultSearchJobById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RemoteRestoreApi.ListRemoteVaultSearchJobById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Specifies the id of the remote Vault search Job to return. | 

### Return type

[**RemoteVaultSearchJobInformation**](RemoteVaultSearchJobInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listremotevaultsearchjobs"></a>
# **ListRemoteVaultSearchJobs**
> List<RemoteVaultSearchJobInformation> ListRemoteVaultSearchJobs ()

List all the searches of remote Vaults. (CloudRetrieve)

List all the searches of remote Vaults (External Targets) that have run or are running on this Cohesity Cluster. A search finds Protection Jobs that have archived to a Vault (External Target). This is part of the CloudRetrieve functionality for finding and restoring archived data from remote Vaults to an alternative (non-original) Cluster.  NOTE: A Vault is equivalent to an External Target in the Cohesity Dashboard. A search Job is equivalent to a search task in the Cohesity Dashboard.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListRemoteVaultSearchJobsExample
    {
        public void main()
        {
            var apiInstance = new RemoteRestoreApi();

            try
            {
                // List all the searches of remote Vaults. (CloudRetrieve)
                List&lt;RemoteVaultSearchJobInformation&gt; result = apiInstance.ListRemoteVaultSearchJobs();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RemoteRestoreApi.ListRemoteVaultSearchJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<RemoteVaultSearchJobInformation>**](RemoteVaultSearchJobInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stopremotevaultsearchjob"></a>
# **StopRemoteVaultSearchJob**
> void StopRemoteVaultSearchJob (StopRemoteVaultSearchJobParameters body)

Stop a search of a remote Vault (External Target). (CloudRetrieve)

This is part of the CloudRetrieve functionality for finding and restoring archived data from remote Vaults to an alternative (non-original) Cluster.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StopRemoteVaultSearchJobExample
    {
        public void main()
        {
            var apiInstance = new RemoteRestoreApi();
            var body = new StopRemoteVaultSearchJobParameters(); // StopRemoteVaultSearchJobParameters | Request to stop a Remote Vault Search Job.

            try
            {
                // Stop a search of a remote Vault (External Target). (CloudRetrieve)
                apiInstance.StopRemoteVaultSearchJob(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RemoteRestoreApi.StopRemoteVaultSearchJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**StopRemoteVaultSearchJobParameters**](StopRemoteVaultSearchJobParameters.md)| Request to stop a Remote Vault Search Job. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadvaultencryptionkeys"></a>
# **UploadVaultEncryptionKeys**
> void UploadVaultEncryptionKeys (long? id, List<VaultEncryptionKey> body = null)

Upload the encryption keys required to restore data from a remote Vault. (CloudRetrieve)

This request contains multiple files stored as multipart mime data. Each file has a key used to encrypt data between a remote Cluster and the remote Vault. Content of the file should be same as the file downloaded from the remote Cluster.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UploadVaultEncryptionKeysExample
    {
        public void main()
        {
            var apiInstance = new RemoteRestoreApi();
            var id = 789;  // long? | Specifies a unique id of the Vault.
            var body = new List<VaultEncryptionKey>(); // List<VaultEncryptionKey> | Request to upload encryption keys of a remote Vault. (optional) 

            try
            {
                // Upload the encryption keys required to restore data from a remote Vault. (CloudRetrieve)
                apiInstance.UploadVaultEncryptionKeys(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RemoteRestoreApi.UploadVaultEncryptionKeys: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Specifies a unique id of the Vault. | 
 **body** | [**List&lt;VaultEncryptionKey&gt;**](VaultEncryptionKey.md)| Request to upload encryption keys of a remote Vault. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


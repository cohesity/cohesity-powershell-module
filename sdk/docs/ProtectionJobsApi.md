# IO.Swagger.Api.ProtectionJobsApi

All URIs are relative to *https://localhost/irisservices/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChangeProtectionJobState**](ProtectionJobsApi.md#changeprotectionjobstate) | **POST** /public/protectionJobState/{id} | Pause future Runs or resume future Runs of the specified Protection Job.
[**CreateProtectionJob**](ProtectionJobsApi.md#createprotectionjob) | **POST** /public/protectionJobs | Create a Protection Job.
[**DeleteProtectionJob**](ProtectionJobsApi.md#deleteprotectionjob) | **DELETE** /public/protectionJobs/{id} | Delete a Protection Job.
[**GetProtectionJobById**](ProtectionJobsApi.md#getprotectionjobbyid) | **GET** /public/protectionJobs/{id} | List details about single Protection Job.
[**GetProtectionJobs**](ProtectionJobsApi.md#getprotectionjobs) | **GET** /public/protectionJobs | List Protections Jobs filtered by the specified parameters.
[**RunProtectionJob**](ProtectionJobsApi.md#runprotectionjob) | **POST** /public/protectionJobs/run/{id} | Immediately execute a single Protection Job Run.
[**UpdateProtectionJob**](ProtectionJobsApi.md#updateprotectionjob) | **PUT** /public/protectionJobs/{id} | Update a Protection Job.


<a name="changeprotectionjobstate"></a>
# **ChangeProtectionJobState**
> void ChangeProtectionJobState (long? id, ChangeProtectionJobStateParam body = null)

Pause future Runs or resume future Runs of the specified Protection Job.

If the Protection Job is currently running (not paused) and true is passed in, this operation stops any new Runs of this Protection Job from stating and executing. However, any existing Runs that were already executing will continue to run. If this Projection Job is paused and false is passed in, this operation restores the Job to a running state and new Runs are started as defined by the schedule in the Policy associated with the Job.  Returns success if the paused state is changed.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ChangeProtectionJobStateExample
    {
        public void main()
        {
            var apiInstance = new ProtectionJobsApi();
            var id = 789;  // long? | Specifies a unique id of the Protection Job.
            var body = new ChangeProtectionJobStateParam(); // ChangeProtectionJobStateParam |  (optional) 

            try
            {
                // Pause future Runs or resume future Runs of the specified Protection Job.
                apiInstance.ChangeProtectionJobState(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtectionJobsApi.ChangeProtectionJobState: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Specifies a unique id of the Protection Job. | 
 **body** | [**ChangeProtectionJobStateParam**](ChangeProtectionJobStateParam.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createprotectionjob"></a>
# **CreateProtectionJob**
> ProtectionJob CreateProtectionJob (ProtectionJobRequestBody body)

Create a Protection Job.

Returns the created Protection Job.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateProtectionJobExample
    {
        public void main()
        {
            var apiInstance = new ProtectionJobsApi();
            var body = new ProtectionJobRequestBody(); // ProtectionJobRequestBody | Request to create a Protection Job.

            try
            {
                // Create a Protection Job.
                ProtectionJob result = apiInstance.CreateProtectionJob(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtectionJobsApi.CreateProtectionJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProtectionJobRequestBody**](ProtectionJobRequestBody.md)| Request to create a Protection Job. | 

### Return type

[**ProtectionJob**](ProtectionJob.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteprotectionjob"></a>
# **DeleteProtectionJob**
> void DeleteProtectionJob (long? id, bool? deleteSnapshots = null)

Delete a Protection Job.

Returns Success if the Protection Job is deleted.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteProtectionJobExample
    {
        public void main()
        {
            var apiInstance = new ProtectionJobsApi();
            var id = 789;  // long? | Specifies a unique id of the Protection Job.
            var deleteSnapshots = true;  // bool? | Specifies if Snapshots generated by the Protection Job should also be deleted when the Job is deleted. (optional) 

            try
            {
                // Delete a Protection Job.
                apiInstance.DeleteProtectionJob(id, deleteSnapshots);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtectionJobsApi.DeleteProtectionJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Specifies a unique id of the Protection Job. | 
 **deleteSnapshots** | **bool?**| Specifies if Snapshots generated by the Protection Job should also be deleted when the Job is deleted. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprotectionjobbyid"></a>
# **GetProtectionJobById**
> ProtectionJob GetProtectionJobById (long? id)

List details about single Protection Job.

Returns the Protection Job corresponding to the specified Job id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProtectionJobByIdExample
    {
        public void main()
        {
            var apiInstance = new ProtectionJobsApi();
            var id = 789;  // long? | Specifies a unique id of the Protection Job.

            try
            {
                // List details about single Protection Job.
                ProtectionJob result = apiInstance.GetProtectionJobById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtectionJobsApi.GetProtectionJobById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Specifies a unique id of the Protection Job. | 

### Return type

[**ProtectionJob**](ProtectionJob.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprotectionjobs"></a>
# **GetProtectionJobs**
> List<ProtectionJob> GetProtectionJobs (List<string> policyIds = null, List<string> environments = null, bool? isActive = null, bool? isDeleted = null, bool? includeLastRunAndStats = null, List<long?> ids = null, List<string> names = null)

List Protections Jobs filtered by the specified parameters.

If no parameters are specified, all Protection Jobs currently on the Cohesity Cluster are returned. Specifying parameters filters the results that are returned.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProtectionJobsExample
    {
        public void main()
        {
            var apiInstance = new ProtectionJobsApi();
            var policyIds = new List<string>(); // List<string> | Filter by Policy ids that are associated with Protection Jobs. Only Jobs associated with the specified Policy ids, are returned. (optional) 
            var environments = environments_example;  // List<string> | Filter by environment types such as 'kVMware', 'kView', 'kSQL' 'kPuppeteer', 'kPhysical', 'kPure', 'kNetapp', 'kGenericNas', 'kHyperV', 'kAcropolis', 'kAzure'. Only Jobs protecting the specified environment types are returned. NOTE: 'kPuppeteer' refers to Cohesity's Remote Adapter. (optional) 
            var isActive = true;  // bool? | Filter by Inactive or Active Jobs. If not set, all Inactive and Active Jobs are returned. If true, only Active Jobs are returned. If false, only Inactive Jobs are returned. When you create a Protection Job on a Primary Cluster with a replication schedule, the Cluster creates an Inactive copy of the Job on the Remote Cluster. In addition, when an Active and running Job is deactivated, the Job becomes Inactive. (optional) 
            var isDeleted = true;  // bool? | If true, return only Protection Jobs that have been deleted but still have Snapshots associated with them. If false, return all Protection Jobs except those Jobs that have been deleted and still have Snapshots associated with them. A Job that is deleted with all its Snapshots is not returned for either of these cases. (optional) 
            var includeLastRunAndStats = true;  // bool? | If true, return the last Protection Run of the Job and the summary stats. (optional) 
            var ids = new List<long?>(); // List<long?> | Filter by a list of Protection Job ids. (optional) 
            var names = new List<string>(); // List<string> | Filter by a list of Protection Job names. (optional) 

            try
            {
                // List Protections Jobs filtered by the specified parameters.
                List&lt;ProtectionJob&gt; result = apiInstance.GetProtectionJobs(policyIds, environments, isActive, isDeleted, includeLastRunAndStats, ids, names);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtectionJobsApi.GetProtectionJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **policyIds** | [**List&lt;string&gt;**](string.md)| Filter by Policy ids that are associated with Protection Jobs. Only Jobs associated with the specified Policy ids, are returned. | [optional] 
 **environments** | **List&lt;string&gt;**| Filter by environment types such as &#39;kVMware&#39;, &#39;kView&#39;, &#39;kSQL&#39; &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp&#39;, &#39;kGenericNas&#39;, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. Only Jobs protecting the specified environment types are returned. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. | [optional] 
 **isActive** | **bool?**| Filter by Inactive or Active Jobs. If not set, all Inactive and Active Jobs are returned. If true, only Active Jobs are returned. If false, only Inactive Jobs are returned. When you create a Protection Job on a Primary Cluster with a replication schedule, the Cluster creates an Inactive copy of the Job on the Remote Cluster. In addition, when an Active and running Job is deactivated, the Job becomes Inactive. | [optional] 
 **isDeleted** | **bool?**| If true, return only Protection Jobs that have been deleted but still have Snapshots associated with them. If false, return all Protection Jobs except those Jobs that have been deleted and still have Snapshots associated with them. A Job that is deleted with all its Snapshots is not returned for either of these cases. | [optional] 
 **includeLastRunAndStats** | **bool?**| If true, return the last Protection Run of the Job and the summary stats. | [optional] 
 **ids** | [**List&lt;long?&gt;**](long?.md)| Filter by a list of Protection Job ids. | [optional] 
 **names** | [**List&lt;string&gt;**](string.md)| Filter by a list of Protection Job names. | [optional] 

### Return type

[**List<ProtectionJob>**](ProtectionJob.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="runprotectionjob"></a>
# **RunProtectionJob**
> void RunProtectionJob (long? id, RunProtectionJobParam body)

Immediately execute a single Protection Job Run.

Immediately excute a single Job Run and ignore the schedule defined in the Policy. A Protection Policy associated with the Job may define up to three backup run types: 1) Regular (CBT utilized), 2) Full (CBT not utilized) and 3) Log. The passed in run type defines what type of backup is done by the Job Run. The schedule defined in the Policy for the backup run type is ignored but other settings such as the snapshot retention and retry settings are used. Returns success if the Job Run starts.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RunProtectionJobExample
    {
        public void main()
        {
            var apiInstance = new ProtectionJobsApi();
            var id = 789;  // long? | Specifies a unique id of the Protection Job.
            var body = new RunProtectionJobParam(); // RunProtectionJobParam | Specifies the type of backup. If not specified, the 'kRegular' backup is run.

            try
            {
                // Immediately execute a single Protection Job Run.
                apiInstance.RunProtectionJob(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtectionJobsApi.RunProtectionJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Specifies a unique id of the Protection Job. | 
 **body** | [**RunProtectionJobParam**](RunProtectionJobParam.md)| Specifies the type of backup. If not specified, the &#39;kRegular&#39; backup is run. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateprotectionjob"></a>
# **UpdateProtectionJob**
> ProtectionJob UpdateProtectionJob (ProtectionJobRequestBody body, long? id)

Update a Protection Job.

Returns the updated Protection Job.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateProtectionJobExample
    {
        public void main()
        {
            var apiInstance = new ProtectionJobsApi();
            var body = new ProtectionJobRequestBody(); // ProtectionJobRequestBody | Request to update a protection job.
            var id = 789;  // long? | Specifies a unique id of the Protection Job.

            try
            {
                // Update a Protection Job.
                ProtectionJob result = apiInstance.UpdateProtectionJob(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtectionJobsApi.UpdateProtectionJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProtectionJobRequestBody**](ProtectionJobRequestBody.md)| Request to update a protection job. | 
 **id** | **long?**| Specifies a unique id of the Protection Job. | 

### Return type

[**ProtectionJob**](ProtectionJob.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


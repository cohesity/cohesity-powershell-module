# IO.Swagger.Api.ProtectionRunsApi

All URIs are relative to *https://localhost/irisservices/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelProtectionJobRun**](ProtectionRunsApi.md#cancelprotectionjobrun) | **POST** /public/protectionRuns/cancel/{id} | Cancel a Protection Job run.
[**GetProtectionRuns**](ProtectionRunsApi.md#getprotectionruns) | **GET** /public/protectionRuns | List Protection Job Runs filtered by the specified parameters.
[**UpdateProtectionRuns**](ProtectionRunsApi.md#updateprotectionruns) | **PUT** /public/protectionRuns | Update how long Protection Job Runs and their snapshots are retained on the Cohesity Cluster.


<a name="cancelprotectionjobrun"></a>
# **CancelProtectionJobRun**
> void CancelProtectionJobRun (long? id, CancelProtectionJobRunParam body = null)

Cancel a Protection Job run.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CancelProtectionJobRunExample
    {
        public void main()
        {
            var apiInstance = new ProtectionRunsApi();
            var id = 789;  // long? | Specifies a unique id of the Protection Job.
            var body = new CancelProtectionJobRunParam(); // CancelProtectionJobRunParam |  (optional) 

            try
            {
                // Cancel a Protection Job run.
                apiInstance.CancelProtectionJobRun(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtectionRunsApi.CancelProtectionJobRun: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Specifies a unique id of the Protection Job. | 
 **body** | [**CancelProtectionJobRunParam**](CancelProtectionJobRunParam.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprotectionruns"></a>
# **GetProtectionRuns**
> List<ProtectionRunInstance> GetProtectionRuns (long? jobId = null, long? startedTimeUsecs = null, long? endTimeUsecs = null, long? numRuns = null, bool? excludeTasks = null, long? sourceId = null, bool? excludeErrorRuns = null, long? startTimeUsecs = null, List<string> runTypes = null, bool? excludeNonRestoreableRuns = null)

List Protection Job Runs filtered by the specified parameters.

If no parameters are specified, Job Runs currently on the Cohesity Cluster are returned. Both running and completed Job Runs are reported. Specifying parameters filters the results that are returned.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProtectionRunsExample
    {
        public void main()
        {
            var apiInstance = new ProtectionRunsApi();
            var jobId = 789;  // long? | Filter by a Protection Job that is specified by id. If not specified, all Job Runs for all Protection Jobs are returned. (optional) 
            var startedTimeUsecs = 789;  // long? | Return a specific Job Run by specifying a time and a jobId. Specify the time when the Job Run started as a Unix epoch Timestamp (in microseconds). If this field is specified, jobId must also be specified. (optional) 
            var endTimeUsecs = 789;  // long? | Filter by a end time specified as a Unix epoch Timestamp (in microseconds). Only Job Runs that completed before the specified end time are returned. (optional) 
            var numRuns = 789;  // long? | Specify the number of Job Runs to return. The newest Job Runs are returned. (optional) 
            var excludeTasks = true;  // bool? | If true, the individual backup status for all the objects protected by the Job Run are not populated in the response. For example in a VMware environment, the status of backing up each VM associated with a Job is not returned. (optional) 
            var sourceId = 789;  // long? | Filter by source id. Only Job Runs protecting the specified source (such as a VM or View) are returned. The source id is assigned by the Cohesity Cluster. (optional) 
            var excludeErrorRuns = true;  // bool? | Filter out Jobs Runs with errors by setting this field to 'true'. If not set or set to 'false', Job Runs with errors are returned. (optional) 
            var startTimeUsecs = 789;  // long? | Filter by a start time. Only Job Runs that started after the specified time are returned. Specify the start time as a Unix epoch Timestamp (in microseconds). (optional) 
            var runTypes = new List<string>(); // List<string> | Filter by run type such as 'kFull', 'kRegular' or 'kLog'. If not specified, Job Runs of all types are returned. (optional) 
            var excludeNonRestoreableRuns = true;  // bool? | Filter out jobs runs that cannot be restored by setting this field to 'true'. If not set or set to 'false', Runs without any successful object will be returned. The default value is false. (optional) 

            try
            {
                // List Protection Job Runs filtered by the specified parameters.
                List&lt;ProtectionRunInstance&gt; result = apiInstance.GetProtectionRuns(jobId, startedTimeUsecs, endTimeUsecs, numRuns, excludeTasks, sourceId, excludeErrorRuns, startTimeUsecs, runTypes, excludeNonRestoreableRuns);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtectionRunsApi.GetProtectionRuns: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | **long?**| Filter by a Protection Job that is specified by id. If not specified, all Job Runs for all Protection Jobs are returned. | [optional] 
 **startedTimeUsecs** | **long?**| Return a specific Job Run by specifying a time and a jobId. Specify the time when the Job Run started as a Unix epoch Timestamp (in microseconds). If this field is specified, jobId must also be specified. | [optional] 
 **endTimeUsecs** | **long?**| Filter by a end time specified as a Unix epoch Timestamp (in microseconds). Only Job Runs that completed before the specified end time are returned. | [optional] 
 **numRuns** | **long?**| Specify the number of Job Runs to return. The newest Job Runs are returned. | [optional] 
 **excludeTasks** | **bool?**| If true, the individual backup status for all the objects protected by the Job Run are not populated in the response. For example in a VMware environment, the status of backing up each VM associated with a Job is not returned. | [optional] 
 **sourceId** | **long?**| Filter by source id. Only Job Runs protecting the specified source (such as a VM or View) are returned. The source id is assigned by the Cohesity Cluster. | [optional] 
 **excludeErrorRuns** | **bool?**| Filter out Jobs Runs with errors by setting this field to &#39;true&#39;. If not set or set to &#39;false&#39;, Job Runs with errors are returned. | [optional] 
 **startTimeUsecs** | **long?**| Filter by a start time. Only Job Runs that started after the specified time are returned. Specify the start time as a Unix epoch Timestamp (in microseconds). | [optional] 
 **runTypes** | [**List&lt;string&gt;**](string.md)| Filter by run type such as &#39;kFull&#39;, &#39;kRegular&#39; or &#39;kLog&#39;. If not specified, Job Runs of all types are returned. | [optional] 
 **excludeNonRestoreableRuns** | **bool?**| Filter out jobs runs that cannot be restored by setting this field to &#39;true&#39;. If not set or set to &#39;false&#39;, Runs without any successful object will be returned. The default value is false. | [optional] 

### Return type

[**List<ProtectionRunInstance>**](ProtectionRunInstance.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateprotectionruns"></a>
# **UpdateProtectionRuns**
> void UpdateProtectionRuns (UpdateProtectionJobRunsParam body)

Update how long Protection Job Runs and their snapshots are retained on the Cohesity Cluster.

Update the expiration date (retention period) for the specified Protection Job Runs and their snapshots. After an expiration time is reached, the Job Run and its snapshots are deleted. If an expiration time of 0 is specified, a Job Run and its snapshots are immediately deleted.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateProtectionRunsExample
    {
        public void main()
        {
            var apiInstance = new ProtectionRunsApi();
            var body = new UpdateProtectionJobRunsParam(); // UpdateProtectionJobRunsParam | Request to update the expiration time of Protection Job Runs.

            try
            {
                // Update how long Protection Job Runs and their snapshots are retained on the Cohesity Cluster.
                apiInstance.UpdateProtectionRuns(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtectionRunsApi.UpdateProtectionRuns: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateProtectionJobRunsParam**](UpdateProtectionJobRunsParam.md)| Request to update the expiration time of Protection Job Runs. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


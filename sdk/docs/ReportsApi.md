# IO.Swagger.Api.ReportsApi

All URIs are relative to *https://localhost/irisservices/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDataTransferFromVaultsReportRequest**](ReportsApi.md#getdatatransferfromvaultsreportrequest) | **GET** /public/reports/dataTransferFromVaults | Get summary statistics about transferring data from Vaults (External Targets) to this Cohesity Cluster.
[**GetDataTransferToVaultsReportRequest**](ReportsApi.md#getdatatransfertovaultsreportrequest) | **GET** /public/reports/dataTransferToVaults | Get summary statistics about transferring data from the Cohesity Cluster to Vaults (External Targets).
[**GetProtectionSourcesJobRunsReportRequest**](ReportsApi.md#getprotectionsourcesjobrunsreportrequest) | **GET** /public/reports/protectionSourcesJobRuns | Get protection details about the specified list of leaf Protection Source Objects (such as a VMs).
[**GetProtectionSourcesJobsSummaryReportRequest**](ReportsApi.md#getprotectionsourcesjobssummaryreportrequest) | **GET** /public/reports/protectionSourcesJobsSummary | Get Job Run (Snapshot) summary statistics about the leaf Protection Sources Objects that match the specified filter criteria.
[**GetRestoreSummaryByObjectTypeReport**](ReportsApi.md#getrestoresummarybyobjecttypereport) | **GET** /public/reports/restoreSummaryByObjectType | 


<a name="getdatatransferfromvaultsreportrequest"></a>
# **GetDataTransferFromVaultsReportRequest**
> DataTransferFromVaultsSummaryResponse GetDataTransferFromVaultsReportRequest (long? endTimeMsecs = null, List<long?> vaultIds = null, string outputFormat = null, long? startTimeMsecs = null)

Get summary statistics about transferring data from Vaults (External Targets) to this Cohesity Cluster.

A Vault can provide an additional Cloud Tier where cold data of the Cohesity Cluster is stored in the Cloud. A Vault can also provide archive storage for backup data. This archive data is stored on Tapes and in Cloud Vaults.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDataTransferFromVaultsReportRequestExample
    {
        public void main()
        {
            var apiInstance = new ReportsApi();
            var endTimeMsecs = 789;  // long? | Filter by end time. Specify the end time as a Unix epoch Timestamp (in milliseconds). If startTimeMsecs and endTimeMsecs are not specified, the time period is the last 7 days. (optional) 
            var vaultIds = new List<long?>(); // List<long?> | Filter by a list of Vault ids. (optional) 
            var outputFormat = outputFormat_example;  // string | Specifies the format for the output such as 'csv' or 'json'. If not specified, the json format is returned. If 'csv' is specified, a comma-separated list with a heading row is returned. (optional) 
            var startTimeMsecs = 789;  // long? | Filter by a start time. Specify the start time as a Unix epoch Timestamp (in milliseconds). If startTimeMsecs and endTimeMsecs are not specified, the time period is the last 7 days. (optional) 

            try
            {
                // Get summary statistics about transferring data from Vaults (External Targets) to this Cohesity Cluster.
                DataTransferFromVaultsSummaryResponse result = apiInstance.GetDataTransferFromVaultsReportRequest(endTimeMsecs, vaultIds, outputFormat, startTimeMsecs);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.GetDataTransferFromVaultsReportRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **endTimeMsecs** | **long?**| Filter by end time. Specify the end time as a Unix epoch Timestamp (in milliseconds). If startTimeMsecs and endTimeMsecs are not specified, the time period is the last 7 days. | [optional] 
 **vaultIds** | [**List&lt;long?&gt;**](long?.md)| Filter by a list of Vault ids. | [optional] 
 **outputFormat** | **string**| Specifies the format for the output such as &#39;csv&#39; or &#39;json&#39;. If not specified, the json format is returned. If &#39;csv&#39; is specified, a comma-separated list with a heading row is returned. | [optional] 
 **startTimeMsecs** | **long?**| Filter by a start time. Specify the start time as a Unix epoch Timestamp (in milliseconds). If startTimeMsecs and endTimeMsecs are not specified, the time period is the last 7 days. | [optional] 

### Return type

[**DataTransferFromVaultsSummaryResponse**](DataTransferFromVaultsSummaryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdatatransfertovaultsreportrequest"></a>
# **GetDataTransferToVaultsReportRequest**
> DataTransferToVaultsSummaryResponse GetDataTransferToVaultsReportRequest (long? startTimeMsecs = null, long? endTimeMsecs = null, List<long?> vaultIds = null, string outputFormat = null)

Get summary statistics about transferring data from the Cohesity Cluster to Vaults (External Targets).

A Vault can provide an additional Cloud Tier where cold data of the Cohesity Cluster can be stored in the Cloud. A Vault can also provide archive storage for backup data. This archive data is stored on Tapes and in Cloud Vaults.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDataTransferToVaultsReportRequestExample
    {
        public void main()
        {
            var apiInstance = new ReportsApi();
            var startTimeMsecs = 789;  // long? | Filter by a start time. Specify the start time as a Unix epoch Timestamp (in milliseconds). If startTimeMsecs and endTimeMsecs are not specified, the time period is the last 7 days. (optional) 
            var endTimeMsecs = 789;  // long? | Filter by end time. Specify the end time as a Unix epoch Timestamp (in milliseconds). If startTimeMsecs and endTimeMsecs are not specified, the time period is the last 7 days. (optional) 
            var vaultIds = new List<long?>(); // List<long?> | Filter by a list of Vault ids. (optional) 
            var outputFormat = outputFormat_example;  // string | Specifies the format for the output such as 'csv' or 'json'. If not specified, the json format is returned. If 'csv' is specified, a comma-separated list with a heading row is returned. (optional) 

            try
            {
                // Get summary statistics about transferring data from the Cohesity Cluster to Vaults (External Targets).
                DataTransferToVaultsSummaryResponse result = apiInstance.GetDataTransferToVaultsReportRequest(startTimeMsecs, endTimeMsecs, vaultIds, outputFormat);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.GetDataTransferToVaultsReportRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startTimeMsecs** | **long?**| Filter by a start time. Specify the start time as a Unix epoch Timestamp (in milliseconds). If startTimeMsecs and endTimeMsecs are not specified, the time period is the last 7 days. | [optional] 
 **endTimeMsecs** | **long?**| Filter by end time. Specify the end time as a Unix epoch Timestamp (in milliseconds). If startTimeMsecs and endTimeMsecs are not specified, the time period is the last 7 days. | [optional] 
 **vaultIds** | [**List&lt;long?&gt;**](long?.md)| Filter by a list of Vault ids. | [optional] 
 **outputFormat** | **string**| Specifies the format for the output such as &#39;csv&#39; or &#39;json&#39;. If not specified, the json format is returned. If &#39;csv&#39; is specified, a comma-separated list with a heading row is returned. | [optional] 

### Return type

[**DataTransferToVaultsSummaryResponse**](DataTransferToVaultsSummaryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprotectionsourcesjobrunsreportrequest"></a>
# **GetProtectionSourcesJobRunsReportRequest**
> List<ProtectionSourcesJobRunsReportElement> GetProtectionSourcesJobRunsReportRequest (List<long?> protectionSourceIds, List<string> environments = null, string outputFormat = null, int? pageCount = null, List<string> runStatus = null, List<long?> jobIds = null, long? startTimeUsecs = null, long? endTimeUsecs = null)

Get protection details about the specified list of leaf Protection Source Objects (such as a VMs).

Returns the Snapshots that contain backups of the specified Protection Source Objects and match the specified filter criteria.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProtectionSourcesJobRunsReportRequestExample
    {
        public void main()
        {
            var apiInstance = new ReportsApi();
            var protectionSourceIds = new List<long?>(); // List<long?> | Filter by a list of leaf Protection Sources Objects (such as VMs). Snapshots of the specified Protection Source Objects are returned.
            var environments = environments_example;  // List<string> | Filter by a list of environment types such as 'kVMware', 'kView', 'kSQL' 'kPuppeteer', 'kPhysical', 'kPure', 'kNetapp', 'kGenericNas', 'kHyperV', 'kAcropolis', or 'kAzure'. Snapshots of leaf Protection Source Objects for the specified environment types are returned. NOTE: 'kPuppeteer' refers to Cohesity's Remote Adapter. (optional) 
            var outputFormat = outputFormat_example;  // string | Specifies the format for the output such as 'cvs' or 'json'. If not specified, the json format is returned. If 'csv' is specified, a comma-separated list with a heading row is returned. (optional) 
            var pageCount = 56;  // int? | Specifies the number of Snapshots to return in the response for pagination purposes. Used in combination with the paginationCookie in the response to return multiple sets of Snapshots. (optional) 
            var runStatus = runStatus_example;  // List<string> | Filter by a list of run statuses such as 'kRunning', 'kSuccess', 'kFailure' etc. Snapshots of Job Runs with the specified run statuses are reported. 'kSuccess' indicates that the Job Run was successful. 'kRunning' indicates that the Job Run is currently running. 'kWarning' indicates that the Job Run was successful but warnings were issued. 'kCancelled' indicates that the Job Run was canceled. 'kError' indicates the Job Run encountered an error and did not run to completion. (optional) 
            var jobIds = new List<long?>(); // List<long?> | Filter by a list of Job ids. Snapshots for the specified Protection Jobs are listed. (optional) 
            var startTimeUsecs = 789;  // long? | Filter by a start time. Snapshots that started after the specified time are returned. Specify the start time as a Unix epoch Timestamp (in microseconds). (optional) 
            var endTimeUsecs = 789;  // long? | Filter by a end time. Snapshots that ended before the specified time are returned. Specify the end time as a Unix epoch Timestamp (in microseconds). (optional) 

            try
            {
                // Get protection details about the specified list of leaf Protection Source Objects (such as a VMs).
                List&lt;ProtectionSourcesJobRunsReportElement&gt; result = apiInstance.GetProtectionSourcesJobRunsReportRequest(protectionSourceIds, environments, outputFormat, pageCount, runStatus, jobIds, startTimeUsecs, endTimeUsecs);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.GetProtectionSourcesJobRunsReportRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **protectionSourceIds** | [**List&lt;long?&gt;**](long?.md)| Filter by a list of leaf Protection Sources Objects (such as VMs). Snapshots of the specified Protection Source Objects are returned. | 
 **environments** | **List&lt;string&gt;**| Filter by a list of environment types such as &#39;kVMware&#39;, &#39;kView&#39;, &#39;kSQL&#39; &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp&#39;, &#39;kGenericNas&#39;, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, or &#39;kAzure&#39;. Snapshots of leaf Protection Source Objects for the specified environment types are returned. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. | [optional] 
 **outputFormat** | **string**| Specifies the format for the output such as &#39;cvs&#39; or &#39;json&#39;. If not specified, the json format is returned. If &#39;csv&#39; is specified, a comma-separated list with a heading row is returned. | [optional] 
 **pageCount** | **int?**| Specifies the number of Snapshots to return in the response for pagination purposes. Used in combination with the paginationCookie in the response to return multiple sets of Snapshots. | [optional] 
 **runStatus** | **List&lt;string&gt;**| Filter by a list of run statuses such as &#39;kRunning&#39;, &#39;kSuccess&#39;, &#39;kFailure&#39; etc. Snapshots of Job Runs with the specified run statuses are reported. &#39;kSuccess&#39; indicates that the Job Run was successful. &#39;kRunning&#39; indicates that the Job Run is currently running. &#39;kWarning&#39; indicates that the Job Run was successful but warnings were issued. &#39;kCancelled&#39; indicates that the Job Run was canceled. &#39;kError&#39; indicates the Job Run encountered an error and did not run to completion. | [optional] 
 **jobIds** | [**List&lt;long?&gt;**](long?.md)| Filter by a list of Job ids. Snapshots for the specified Protection Jobs are listed. | [optional] 
 **startTimeUsecs** | **long?**| Filter by a start time. Snapshots that started after the specified time are returned. Specify the start time as a Unix epoch Timestamp (in microseconds). | [optional] 
 **endTimeUsecs** | **long?**| Filter by a end time. Snapshots that ended before the specified time are returned. Specify the end time as a Unix epoch Timestamp (in microseconds). | [optional] 

### Return type

[**List<ProtectionSourcesJobRunsReportElement>**](ProtectionSourcesJobRunsReportElement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprotectionsourcesjobssummaryreportrequest"></a>
# **GetProtectionSourcesJobsSummaryReportRequest**
> List<ProtectionSourcesSummaryStats> GetProtectionSourcesJobsSummaryReportRequest (List<long?> protectionSourceIds = null, List<string> statuses = null, string outputFormat = null, long? registeredSourceId = null, List<long?> jobIds = null, long? startTimeUsecs = null, long? endTimeUsecs = null, List<string> environments = null)

Get Job Run (Snapshot) summary statistics about the leaf Protection Sources Objects that match the specified filter criteria.

For example, if two Job ids are passed in, Snapshot summary statistics about all the leaf Objects that have been protected by the two specified Jobs are reported. For example if a top level registered Source id is passed in, summary statistics about all the Snapshots backing up leaf Objects in the specified Source are reported.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProtectionSourcesJobsSummaryReportRequestExample
    {
        public void main()
        {
            var apiInstance = new ReportsApi();
            var protectionSourceIds = new List<long?>(); // List<long?> | Filter by a list of leaf Protection Sources Objects (such as VMs). Snapshot summary statistics for the listed Protection Source Objects are reported. (optional) 
            var statuses = statuses_example;  // List<string> | Filter by a list of run statuses. 'kSuccess' indicates that the Job Run was successful. 'kRunning' indicates that the Job Run is currently running. 'kWarning' indicates that the Job Run was successful but warnings were issued. 'kCancelled' indicates that the Job Run was canceled. 'kError' indicates the Job Run encountered an error and did not run to completion. (optional) 
            var outputFormat = outputFormat_example;  // string | Specifies the format for the output such as 'csv' or 'json'. If not specified, the json format is returned. If 'csv' is specified, a comma-separated list with a heading row is returned. (optional) 
            var registeredSourceId = 789;  // long? | Specifies an id of a top level Registered Source such as a vCenter Server. If specified, Snapshot summary statistics for all the leaf Protection Sources (such as VMs) that are children of this Registered Source are reported. NOTE: If specified, filtering by other fields is not supported. (optional) 
            var jobIds = new List<long?>(); // List<long?> | Filter by a list of Job ids. Snapshots summary statistics for the specified Protection Jobs are reported. (optional) 
            var startTimeUsecs = 789;  // long? | Filter by a start time. Snapshot summary statistics for Job Runs that started after the specified time are reported. Specify the start time as a Unix epoch Timestamp (in microseconds). (optional) 
            var endTimeUsecs = 789;  // long? | Filter by end time. Snapshot summary statistics for Job Runs that ended before the specified time are returned. Specify the end time as a Unix epoch Timestamp (in microseconds). (optional) 
            var environments = environments_example;  // List<string> | Filter by a list of environment types such as 'kVMware', 'kView', 'kSQL' 'kPuppeteer', 'kPhysical', 'kPure', or 'kNetapp'. Snapshot summary statistics about the leaf Protection Source Objects of specified environment types are reported. NOTE: 'kPuppeteer' refers to Cohesity's Remote Adapter. (optional) 

            try
            {
                // Get Job Run (Snapshot) summary statistics about the leaf Protection Sources Objects that match the specified filter criteria.
                List&lt;ProtectionSourcesSummaryStats&gt; result = apiInstance.GetProtectionSourcesJobsSummaryReportRequest(protectionSourceIds, statuses, outputFormat, registeredSourceId, jobIds, startTimeUsecs, endTimeUsecs, environments);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.GetProtectionSourcesJobsSummaryReportRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **protectionSourceIds** | [**List&lt;long?&gt;**](long?.md)| Filter by a list of leaf Protection Sources Objects (such as VMs). Snapshot summary statistics for the listed Protection Source Objects are reported. | [optional] 
 **statuses** | **List&lt;string&gt;**| Filter by a list of run statuses. &#39;kSuccess&#39; indicates that the Job Run was successful. &#39;kRunning&#39; indicates that the Job Run is currently running. &#39;kWarning&#39; indicates that the Job Run was successful but warnings were issued. &#39;kCancelled&#39; indicates that the Job Run was canceled. &#39;kError&#39; indicates the Job Run encountered an error and did not run to completion. | [optional] 
 **outputFormat** | **string**| Specifies the format for the output such as &#39;csv&#39; or &#39;json&#39;. If not specified, the json format is returned. If &#39;csv&#39; is specified, a comma-separated list with a heading row is returned. | [optional] 
 **registeredSourceId** | **long?**| Specifies an id of a top level Registered Source such as a vCenter Server. If specified, Snapshot summary statistics for all the leaf Protection Sources (such as VMs) that are children of this Registered Source are reported. NOTE: If specified, filtering by other fields is not supported. | [optional] 
 **jobIds** | [**List&lt;long?&gt;**](long?.md)| Filter by a list of Job ids. Snapshots summary statistics for the specified Protection Jobs are reported. | [optional] 
 **startTimeUsecs** | **long?**| Filter by a start time. Snapshot summary statistics for Job Runs that started after the specified time are reported. Specify the start time as a Unix epoch Timestamp (in microseconds). | [optional] 
 **endTimeUsecs** | **long?**| Filter by end time. Snapshot summary statistics for Job Runs that ended before the specified time are returned. Specify the end time as a Unix epoch Timestamp (in microseconds). | [optional] 
 **environments** | **List&lt;string&gt;**| Filter by a list of environment types such as &#39;kVMware&#39;, &#39;kView&#39;, &#39;kSQL&#39; &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, or &#39;kNetapp&#39;. Snapshot summary statistics about the leaf Protection Source Objects of specified environment types are reported. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. | [optional] 

### Return type

[**List<ProtectionSourcesSummaryStats>**](ProtectionSourcesSummaryStats.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrestoresummarybyobjecttypereport"></a>
# **GetRestoreSummaryByObjectTypeReport**
> List<RestoreSourceSummaryByObjectTypeElement> GetRestoreSummaryByObjectTypeReport (List<string> recoveredFrom = null, string recoverTaskName = null, string status = null, string outputFormat = null, long? startTimeUsecs = null, long? endTimeUsecs = null, string type = null, string userName = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRestoreSummaryByObjectTypeReportExample
    {
        public void main()
        {
            var apiInstance = new ReportsApi();
            var recoveredFrom = new List<string>(); // List<string> | Specifies the targets from which the recovery happend. (optional) 
            var recoverTaskName = recoverTaskName_example;  // string | Specifies the recover task name. (optional) 
            var status = status_example;  // string | Specifies the overall status of the Restore Task to filter. 'kReadyToSchedule' indicates the Restore Task is waiting to be scheduled. 'kProgressMonitorCreated' indicates the progress monitor for the Restore Task has been created. 'kRetrievedFromArchive' indicates that the objects to restore have been retrieved from the specified archive. A Task will only ever transition to this state if a retrieval is necessary. 'kAdmitted' indicates the task has been admitted. After a task has been admitted, its status does not move back to 'kReadyToSchedule' state even if it is rescheduled. 'kInProgress' indicates that the Restore Task is in progress. 'kFinishingProgressMonitor' indicates that the Restore Task is finishing its progress monitoring. 'kFinished' indicates that the Restore Task has finished. The status indicating success or failure is found in the error code that is stored with the Restore Task. (optional) 
            var outputFormat = outputFormat_example;  // string | Specifies the format for the output such as 'csv' or 'json'. If not specified, the json format is returned. If 'csv' is specified, a comma-separated list with a heading row is returned. (optional) 
            var startTimeUsecs = 789;  // long? | Filter by a start time specified as a Unix epoch Timestamp (in microseconds). (optional) 
            var endTimeUsecs = 789;  // long? | Filter by an end time specified as a Unix epoch Timestamp (in microseconds). (optional) 
            var type = type_example;  // string | Specify the object type to filter with. Specifies the type of Restore Task.  'kRecoverVMs' specifies a Restore Task that recovers VMs. 'kCloneVMs' specifies a Restore Task that clones VMs. 'kCloneView' specifies a Restore Task that clones a View. 'kMountVolumes' specifies a Restore Task that mounts volumes. 'kRestoreFiles' specifies a Restore Task that recovers files and folders. (optional) 
            var userName = userName_example;  // string | Specify the user name to filter with. (optional) 

            try
            {
                List&lt;RestoreSourceSummaryByObjectTypeElement&gt; result = apiInstance.GetRestoreSummaryByObjectTypeReport(recoveredFrom, recoverTaskName, status, outputFormat, startTimeUsecs, endTimeUsecs, type, userName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.GetRestoreSummaryByObjectTypeReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recoveredFrom** | [**List&lt;string&gt;**](string.md)| Specifies the targets from which the recovery happend. | [optional] 
 **recoverTaskName** | **string**| Specifies the recover task name. | [optional] 
 **status** | **string**| Specifies the overall status of the Restore Task to filter. &#39;kReadyToSchedule&#39; indicates the Restore Task is waiting to be scheduled. &#39;kProgressMonitorCreated&#39; indicates the progress monitor for the Restore Task has been created. &#39;kRetrievedFromArchive&#39; indicates that the objects to restore have been retrieved from the specified archive. A Task will only ever transition to this state if a retrieval is necessary. &#39;kAdmitted&#39; indicates the task has been admitted. After a task has been admitted, its status does not move back to &#39;kReadyToSchedule&#39; state even if it is rescheduled. &#39;kInProgress&#39; indicates that the Restore Task is in progress. &#39;kFinishingProgressMonitor&#39; indicates that the Restore Task is finishing its progress monitoring. &#39;kFinished&#39; indicates that the Restore Task has finished. The status indicating success or failure is found in the error code that is stored with the Restore Task. | [optional] 
 **outputFormat** | **string**| Specifies the format for the output such as &#39;csv&#39; or &#39;json&#39;. If not specified, the json format is returned. If &#39;csv&#39; is specified, a comma-separated list with a heading row is returned. | [optional] 
 **startTimeUsecs** | **long?**| Filter by a start time specified as a Unix epoch Timestamp (in microseconds). | [optional] 
 **endTimeUsecs** | **long?**| Filter by an end time specified as a Unix epoch Timestamp (in microseconds). | [optional] 
 **type** | **string**| Specify the object type to filter with. Specifies the type of Restore Task.  &#39;kRecoverVMs&#39; specifies a Restore Task that recovers VMs. &#39;kCloneVMs&#39; specifies a Restore Task that clones VMs. &#39;kCloneView&#39; specifies a Restore Task that clones a View. &#39;kMountVolumes&#39; specifies a Restore Task that mounts volumes. &#39;kRestoreFiles&#39; specifies a Restore Task that recovers files and folders. | [optional] 
 **userName** | **string**| Specify the user name to filter with. | [optional] 

### Return type

[**List<RestoreSourceSummaryByObjectTypeElement>**](RestoreSourceSummaryByObjectTypeElement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


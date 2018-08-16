# IO.Swagger.Api.RestoreTasksApi

All URIs are relative to *https://localhost/irisservices/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelRestoreTask**](RestoreTasksApi.md#cancelrestoretask) | **PUT** /public/restore/tasks/cancel/{id} | Cancel a recover or clone task with specified id.
[**CreateApplicationsCloneTask**](RestoreTasksApi.md#createapplicationsclonetask) | **POST** /public/restore/applicationsClone | Create a Restore Task for cloning Applications like SQL Databases.
[**CreateApplicationsRecoverTask**](RestoreTasksApi.md#createapplicationsrecovertask) | **POST** /public/restore/applicationsRecover | Create a Restore Task for recovering Applications like SQL Databases.
[**CreateCloneTask**](RestoreTasksApi.md#createclonetask) | **POST** /public/restore/clone | Create a Restore Task for cloning VMs or a View.
[**CreateRecoverTask**](RestoreTasksApi.md#createrecovertask) | **POST** /public/restore/recover | Create a Restore Task for recovering VMs or instantly mounting volumes.
[**CreateRestoreFilesTask**](RestoreTasksApi.md#createrestorefilestask) | **POST** /public/restore/files | Create a Restore Task for recovering files and folders.
[**GetFileSnapshotsInformation**](RestoreTasksApi.md#getfilesnapshotsinformation) | **GET** /public/restore/files/snapshotsInformation | Get the information about snapshots that contain the specified file or folder. In addition, information about the file or folder is provided.
[**GetRestoreTaskById**](RestoreTasksApi.md#getrestoretaskbyid) | **GET** /public/restore/tasks/{id} | List details about a single Restore Task.
[**GetRestoreTasks**](RestoreTasksApi.md#getrestoretasks) | **GET** /public/restore/tasks | List the Restore Tasks filtered by the specified parameters.
[**GetVmVolumesInformation**](RestoreTasksApi.md#getvmvolumesinformation) | **GET** /public/restore/vms/volumesInformation | Get information about the logical volumes found in a VM.
[**SearchObjects**](RestoreTasksApi.md#searchobjects) | **GET** /public/restore/objects | Find backup objects that match the specified search and filter criteria on the Cohesity Cluster.
[**SearchRestoredFiles**](RestoreTasksApi.md#searchrestoredfiles) | **GET** /public/restore/files | Search for files and folders to recover that match the specified search and filter criteria on the Cohesity Cluster.


<a name="cancelrestoretask"></a>
# **CancelRestoreTask**
> void CancelRestoreTask (long? id)

Cancel a recover or clone task with specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CancelRestoreTaskExample
    {
        public void main()
        {
            var apiInstance = new RestoreTasksApi();
            var id = 789;  // long? | Specifies a unique id for the Restore Task.

            try
            {
                // Cancel a recover or clone task with specified id.
                apiInstance.CancelRestoreTask(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RestoreTasksApi.CancelRestoreTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Specifies a unique id for the Restore Task. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createapplicationsclonetask"></a>
# **CreateApplicationsCloneTask**
> RestoreTask CreateApplicationsCloneTask (ApplicationsRestoreTaskRequest body)

Create a Restore Task for cloning Applications like SQL Databases.

Returns the created Restore Task.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateApplicationsCloneTaskExample
    {
        public void main()
        {
            var apiInstance = new RestoreTasksApi();
            var body = new ApplicationsRestoreTaskRequest(); // ApplicationsRestoreTaskRequest | Request to create a Restore Task for cloning Applications like SQL DB.

            try
            {
                // Create a Restore Task for cloning Applications like SQL Databases.
                RestoreTask result = apiInstance.CreateApplicationsCloneTask(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RestoreTasksApi.CreateApplicationsCloneTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApplicationsRestoreTaskRequest**](ApplicationsRestoreTaskRequest.md)| Request to create a Restore Task for cloning Applications like SQL DB. | 

### Return type

[**RestoreTask**](RestoreTask.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createapplicationsrecovertask"></a>
# **CreateApplicationsRecoverTask**
> RestoreTask CreateApplicationsRecoverTask (ApplicationsRestoreTaskRequest body)

Create a Restore Task for recovering Applications like SQL Databases.

Returns the created Restore Task.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateApplicationsRecoverTaskExample
    {
        public void main()
        {
            var apiInstance = new RestoreTasksApi();
            var body = new ApplicationsRestoreTaskRequest(); // ApplicationsRestoreTaskRequest | Request to create a Restore Task for recovering Applications like SQL DB. volumes to mount points.

            try
            {
                // Create a Restore Task for recovering Applications like SQL Databases.
                RestoreTask result = apiInstance.CreateApplicationsRecoverTask(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RestoreTasksApi.CreateApplicationsRecoverTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApplicationsRestoreTaskRequest**](ApplicationsRestoreTaskRequest.md)| Request to create a Restore Task for recovering Applications like SQL DB. volumes to mount points. | 

### Return type

[**RestoreTask**](RestoreTask.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createclonetask"></a>
# **CreateCloneTask**
> RestoreTask CreateCloneTask (CloneTaskRequest body)

Create a Restore Task for cloning VMs or a View.

Returns the created Restore Task that clones VMs or a View.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateCloneTaskExample
    {
        public void main()
        {
            var apiInstance = new RestoreTasksApi();
            var body = new CloneTaskRequest(); // CloneTaskRequest | Request to create a Restore Task for cloning VMs or a View.

            try
            {
                // Create a Restore Task for cloning VMs or a View.
                RestoreTask result = apiInstance.CreateCloneTask(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RestoreTasksApi.CreateCloneTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CloneTaskRequest**](CloneTaskRequest.md)| Request to create a Restore Task for cloning VMs or a View. | 

### Return type

[**RestoreTask**](RestoreTask.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrecovertask"></a>
# **CreateRecoverTask**
> RestoreTask CreateRecoverTask (RecoverTaskRequest body)

Create a Restore Task for recovering VMs or instantly mounting volumes.

Returns the created Restore Task. This operation returns the following types of Restore Tasks: 1) A Restore Task that recovers VMs back to the original location or a new location. 2) A Restore Task that mounts the volumes of a Server (such as a VM or Physical Server) onto the specified target system. The Snapshots of the Server that contains the volumes that are mounted is determined by Array of Objects. The content of the Server is available from the mount point for the Granular Level Recovery (GLR) of application data. For example recovering Microsoft Exchange data using Kroll Ontrack® PowerControls™.  NOTE: Volumes are mounted \"instantly\" if the Snapshot is stored locally on the Cohesity Cluster. If the Snapshot is archival target, it will take longer because it must be retrieved.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateRecoverTaskExample
    {
        public void main()
        {
            var apiInstance = new RestoreTasksApi();
            var body = new RecoverTaskRequest(); // RecoverTaskRequest | Request to create a Restore Task for recovering VMs or mounting volumes to mount points.

            try
            {
                // Create a Restore Task for recovering VMs or instantly mounting volumes.
                RestoreTask result = apiInstance.CreateRecoverTask(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RestoreTasksApi.CreateRecoverTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecoverTaskRequest**](RecoverTaskRequest.md)| Request to create a Restore Task for recovering VMs or mounting volumes to mount points. | 

### Return type

[**RestoreTask**](RestoreTask.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrestorefilestask"></a>
# **CreateRestoreFilesTask**
> RestoreTask CreateRestoreFilesTask (RestoreFilesTaskRequest body)

Create a Restore Task for recovering files and folders.

Returns the created Restore Task that recovers files and folders.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateRestoreFilesTaskExample
    {
        public void main()
        {
            var apiInstance = new RestoreTasksApi();
            var body = new RestoreFilesTaskRequest(); // RestoreFilesTaskRequest | Request to create a Restore Task for recovering files or folders.

            try
            {
                // Create a Restore Task for recovering files and folders.
                RestoreTask result = apiInstance.CreateRestoreFilesTask(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RestoreTasksApi.CreateRestoreFilesTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RestoreFilesTaskRequest**](RestoreFilesTaskRequest.md)| Request to create a Restore Task for recovering files or folders. | 

### Return type

[**RestoreTask**](RestoreTask.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfilesnapshotsinformation"></a>
# **GetFileSnapshotsInformation**
> List<FileSnapshotInformation> GetFileSnapshotsInformation (long? jobId, long? clusterId, long? clusterIncarnationId, long? sourceId, string filename)

Get the information about snapshots that contain the specified file or folder. In addition, information about the file or folder is provided.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFileSnapshotsInformationExample
    {
        public void main()
        {
            var apiInstance = new RestoreTasksApi();
            var jobId = 789;  // long? | Specifies the id of the Job that captured the snapshots. These snapshots are searched for the specified files or folders. This field is required.
            var clusterId = 789;  // long? | Specifies the Cohesity Cluster id where the Job was created. This field is required.
            var clusterIncarnationId = 789;  // long? | Specifies the incarnation id of the Cohesity Cluster where the Job was created. An incarnation id is generated when a Cohesity Cluster is initially created. This field is required.
            var sourceId = 789;  // long? | Specifies the id of the Protection Source object (such as a VM) to search. When a Job Run executes, snapshots of the specified Protection Source object are captured. This operation searches the snapshots of the object for the file or folder. This field is required.
            var filename = filename_example;  // string | Specifies the name of the file or folder to find in the snapshots. This field is required.

            try
            {
                // Get the information about snapshots that contain the specified file or folder. In addition, information about the file or folder is provided.
                List&lt;FileSnapshotInformation&gt; result = apiInstance.GetFileSnapshotsInformation(jobId, clusterId, clusterIncarnationId, sourceId, filename);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RestoreTasksApi.GetFileSnapshotsInformation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | **long?**| Specifies the id of the Job that captured the snapshots. These snapshots are searched for the specified files or folders. This field is required. | 
 **clusterId** | **long?**| Specifies the Cohesity Cluster id where the Job was created. This field is required. | 
 **clusterIncarnationId** | **long?**| Specifies the incarnation id of the Cohesity Cluster where the Job was created. An incarnation id is generated when a Cohesity Cluster is initially created. This field is required. | 
 **sourceId** | **long?**| Specifies the id of the Protection Source object (such as a VM) to search. When a Job Run executes, snapshots of the specified Protection Source object are captured. This operation searches the snapshots of the object for the file or folder. This field is required. | 
 **filename** | **string**| Specifies the name of the file or folder to find in the snapshots. This field is required. | 

### Return type

[**List<FileSnapshotInformation>**](FileSnapshotInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrestoretaskbyid"></a>
# **GetRestoreTaskById**
> RestoreTask GetRestoreTaskById (long? id)

List details about a single Restore Task.

Returns the Restore Task corresponding to the specified Restore Task id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRestoreTaskByIdExample
    {
        public void main()
        {
            var apiInstance = new RestoreTasksApi();
            var id = 789;  // long? | Specifies a unique id for the Restore Task.

            try
            {
                // List details about a single Restore Task.
                RestoreTask result = apiInstance.GetRestoreTaskById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RestoreTasksApi.GetRestoreTaskById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Specifies a unique id for the Restore Task. | 

### Return type

[**RestoreTask**](RestoreTask.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrestoretasks"></a>
# **GetRestoreTasks**
> List<RestoreTask> GetRestoreTasks (List<long?> taskIds = null, long? startTimeUsecs = null, long? endTimeUsecs = null, long? pageCount = null, List<string> taskTypes = null)

List the Restore Tasks filtered by the specified parameters.

If no parameters are specified, all Restore Tasks found on the Cohesity Cluster are returned. Both running and completed Restore Tasks are reported. Specifying parameters filters the results that are returned.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRestoreTasksExample
    {
        public void main()
        {
            var apiInstance = new RestoreTasksApi();
            var taskIds = new List<long?>(); // List<long?> | Filter by a list of Restore Task ids. (optional) 
            var startTimeUsecs = 789;  // long? | Filter by a start time specified as a Unix epoch Timestamp (in microseconds). All Restore Tasks (both completed and running) on the Cohesity Cluster that started after the specified start time but before the specified end time are returned. If not set, the start time is creation time of the Cohesity Cluster. (optional) 
            var endTimeUsecs = 789;  // long? | Filter by an end time specified as a Unix epoch Timestamp (in microseconds). All Restore Tasks (both completed and running) on the Cohesity Cluster that started after the specified start time but before the specified end time are returned. If not set, the end time is the current time. (optional) 
            var pageCount = 789;  // long? | Specifies the number of completed Restore Tasks to return in the response for pagination purposes. Running Restore Tasks are always returned. The newest completed Restore Tasks are returned. (optional) 
            var taskTypes = new List<string>(); // List<string> | Filter by the types of Restore Tasks such as 'kRecoverVMs', 'kCloneVMs', 'kCloneView' or 'kMountVolumes'. (optional) 

            try
            {
                // List the Restore Tasks filtered by the specified parameters.
                List&lt;RestoreTask&gt; result = apiInstance.GetRestoreTasks(taskIds, startTimeUsecs, endTimeUsecs, pageCount, taskTypes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RestoreTasksApi.GetRestoreTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskIds** | [**List&lt;long?&gt;**](long?.md)| Filter by a list of Restore Task ids. | [optional] 
 **startTimeUsecs** | **long?**| Filter by a start time specified as a Unix epoch Timestamp (in microseconds). All Restore Tasks (both completed and running) on the Cohesity Cluster that started after the specified start time but before the specified end time are returned. If not set, the start time is creation time of the Cohesity Cluster. | [optional] 
 **endTimeUsecs** | **long?**| Filter by an end time specified as a Unix epoch Timestamp (in microseconds). All Restore Tasks (both completed and running) on the Cohesity Cluster that started after the specified start time but before the specified end time are returned. If not set, the end time is the current time. | [optional] 
 **pageCount** | **long?**| Specifies the number of completed Restore Tasks to return in the response for pagination purposes. Running Restore Tasks are always returned. The newest completed Restore Tasks are returned. | [optional] 
 **taskTypes** | [**List&lt;string&gt;**](string.md)| Filter by the types of Restore Tasks such as &#39;kRecoverVMs&#39;, &#39;kCloneVMs&#39;, &#39;kCloneView&#39; or &#39;kMountVolumes&#39;. | [optional] 

### Return type

[**List<RestoreTask>**](RestoreTask.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvmvolumesinformation"></a>
# **GetVmVolumesInformation**
> List<VmVolumesInformation> GetVmVolumesInformation (long? attemptNumber = null, long? sourceId = null, bool? supportedVolumesOnly = null, long? jobId = null, long? clusterIncarnationId = null, long? startedTimeUsecs = null, long? originalJobId = null, long? clusterId = null, long? jobRunId = null)

Get information about the logical volumes found in a VM.

All fields must be specified for this operation. To get values for these fields, invoke the GET /public/restore/objects operation. A specific Job Run is defined by the jobRunId, startedTimeUsecs, and attemptNumber fields.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetVmVolumesInformationExample
    {
        public void main()
        {
            var apiInstance = new RestoreTasksApi();
            var attemptNumber = 789;  // long? | Specifies the number of the attempts made by the Job Run to capture a snapshot of the object. For example, if an snapshot is successfully captured after three attempts, this field equals 3. (optional) 
            var sourceId = 789;  // long? | Specifies the id of the VM object to search for volumes. (optional) 
            var supportedVolumesOnly = true;  // bool? | Specifies to return only supported volumes information. Unsupported volumes are not returned if this flag is set to true. Default is false. (optional) 
            var jobId = 789;  // long? | Specifies the Job id for the Protection Job that is currently associated with the object. If the object was backed up on current Cohesity Cluster, this field contains the id for the Job that captured this backup object. If the object was backed up on a Primary Cluster and replicated to this Cohesity Cluster, a new Inactive Job is created, the object is now associated with new Inactive Job, and this field contains the id of the new Inactive Job. (optional) 
            var clusterIncarnationId = 789;  // long? | Specifies the incarnation id of the Cohesity Cluster where the Job was created. An incarnation id is generated when a Cohesity Cluster is initially created. (optional) 
            var startedTimeUsecs = 789;  // long? | Specifies the time when the Job Run starts capturing a snapshot. Specified as a Unix epoch Timestamp (in microseconds). (optional) 
            var originalJobId = 789;  // long? | Specifies the id for the Protection Job that originally captured the snapshots of the original object. If the object was backed up on a Primary Cluster replicated to this Cohesity Cluster, and a new Inactive Job is created, this field still contains the id of the original Job and NOT the id of the new Inactive Job. This field is used in combination with the clusterId and clusterIncarnationId to uniquely identify a Job. (optional) 
            var clusterId = 789;  // long? | Specifies the Cohesity Cluster id where the Job was created. (optional) 
            var jobRunId = 789;  // long? | Specifies the id of the Job Run that captured the snapshot. (optional) 

            try
            {
                // Get information about the logical volumes found in a VM.
                List&lt;VmVolumesInformation&gt; result = apiInstance.GetVmVolumesInformation(attemptNumber, sourceId, supportedVolumesOnly, jobId, clusterIncarnationId, startedTimeUsecs, originalJobId, clusterId, jobRunId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RestoreTasksApi.GetVmVolumesInformation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attemptNumber** | **long?**| Specifies the number of the attempts made by the Job Run to capture a snapshot of the object. For example, if an snapshot is successfully captured after three attempts, this field equals 3. | [optional] 
 **sourceId** | **long?**| Specifies the id of the VM object to search for volumes. | [optional] 
 **supportedVolumesOnly** | **bool?**| Specifies to return only supported volumes information. Unsupported volumes are not returned if this flag is set to true. Default is false. | [optional] 
 **jobId** | **long?**| Specifies the Job id for the Protection Job that is currently associated with the object. If the object was backed up on current Cohesity Cluster, this field contains the id for the Job that captured this backup object. If the object was backed up on a Primary Cluster and replicated to this Cohesity Cluster, a new Inactive Job is created, the object is now associated with new Inactive Job, and this field contains the id of the new Inactive Job. | [optional] 
 **clusterIncarnationId** | **long?**| Specifies the incarnation id of the Cohesity Cluster where the Job was created. An incarnation id is generated when a Cohesity Cluster is initially created. | [optional] 
 **startedTimeUsecs** | **long?**| Specifies the time when the Job Run starts capturing a snapshot. Specified as a Unix epoch Timestamp (in microseconds). | [optional] 
 **originalJobId** | **long?**| Specifies the id for the Protection Job that originally captured the snapshots of the original object. If the object was backed up on a Primary Cluster replicated to this Cohesity Cluster, and a new Inactive Job is created, this field still contains the id of the original Job and NOT the id of the new Inactive Job. This field is used in combination with the clusterId and clusterIncarnationId to uniquely identify a Job. | [optional] 
 **clusterId** | **long?**| Specifies the Cohesity Cluster id where the Job was created. | [optional] 
 **jobRunId** | **long?**| Specifies the id of the Job Run that captured the snapshot. | [optional] 

### Return type

[**List<VmVolumesInformation>**](VmVolumesInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchobjects"></a>
# **SearchObjects**
> ObjectSearchResults SearchObjects (List<long?> jobIds = null, List<long?> viewBoxIds = null, List<string> environments = null, long? startIndex = null, List<string> operatingSystems = null, string application = null, long? ownerEntityId = null, string search = null, List<long?> registeredSourceIds = null, long? startTimeUsecs = null, long? endTimeUsecs = null, long? pageCount = null)

Find backup objects that match the specified search and filter criteria on the Cohesity Cluster.

If no search pattern or filter parameters are specified, all backup objects currently found on the Cohesity Cluster are returned. Only leaf objects that have been protected by a Job are returned such as VMs, Views and databases. Specify a search pattern or parameters to filter the results that are returned.  The term \"items\" below refers to leaf backup objects such as VMs, Views and databases.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchObjectsExample
    {
        public void main()
        {
            var apiInstance = new RestoreTasksApi();
            var jobIds = new List<long?>(); // List<long?> | Filter by a list of Protection Job ids. Only items backed up by the specified Jobs are listed. (optional) 
            var viewBoxIds = new List<long?>(); // List<long?> | Filter by a list of Domains (View Boxes) ids. Only items stored in the listed Domains (View Boxes) are returned. (optional) 
            var environments = environments_example;  // List<string> | Filter by environment types such as 'kVMware', 'kView', 'kSQL', 'kPuppeteer', 'kPhysical', 'kPure' 'kNetapp' 'kGenericNas', 'kHyperV', 'kAcropolis', or 'kAzure'. Only items from the specified environment types are returned. NOTE: 'kPuppeteer' refers to Cohesity's Remote Adapter. (optional) 
            var startIndex = 789;  // long? | Specifies an index number that can be used to return subsets of items in multiple requests. Break up the items to return into multiple requests by setting pageCount and using startIndex to return a subsets of items. For example, set startIndex to 0 to get the first set of items for the first request. Increment startIndex by pageCount to get the next set of items for a next request. Continue until all items are returned and therefore the total number of returned items is equal to totalCount. (optional) 
            var operatingSystems = new List<string>(); // List<string> | Filter by the Operating Systems running on VMs and Physical Servers. This filter is applicable only to VMs and physical servers. (optional) 
            var application = application_example;  // string | Filter by application when the environment type is kSQL. For example, if SQL is specified the SQL databases are returned. (optional) 
            var ownerEntityId = 789;  // long? | Filter objects by the Entity id of the owner VM. For example, if a ownerEntityId is provided while searching for SQL databases, only SQL databases belonging to the VM with the specified id are returned. ownerEntityId is only significant if application is set to SQL. (optional) 
            var search = search_example;  // string | Filter by searching for sub-strings in the item name. The specified string can match any part of the item name. For example: \"vm\" or \"123\" both match the item name of \"vm-123\". (optional) 
            var registeredSourceIds = new List<long?>(); // List<long?> | Filter by a list of Registered Sources ids. Only items from the listed Registered Sources are returned. (optional) 
            var startTimeUsecs = 789;  // long? | Filter by backup completion time by specifying a backup completion start and end times. Specified as a Unix epoch Timestamp (in microseconds). Only items created by backups that completed between the specified start and end times are returned. (optional) 
            var endTimeUsecs = 789;  // long? | Filter by backup completion time by specify a backup completion start and end times. Specified as a Unix epoch Timestamp (in microseconds). Only items created by backups that completed between the specified start and end times are returned. (optional) 
            var pageCount = 789;  // long? | Limit the number of items to return in the response for pagination purposes. (optional) 

            try
            {
                // Find backup objects that match the specified search and filter criteria on the Cohesity Cluster.
                ObjectSearchResults result = apiInstance.SearchObjects(jobIds, viewBoxIds, environments, startIndex, operatingSystems, application, ownerEntityId, search, registeredSourceIds, startTimeUsecs, endTimeUsecs, pageCount);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RestoreTasksApi.SearchObjects: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobIds** | [**List&lt;long?&gt;**](long?.md)| Filter by a list of Protection Job ids. Only items backed up by the specified Jobs are listed. | [optional] 
 **viewBoxIds** | [**List&lt;long?&gt;**](long?.md)| Filter by a list of Domains (View Boxes) ids. Only items stored in the listed Domains (View Boxes) are returned. | [optional] 
 **environments** | **List&lt;string&gt;**| Filter by environment types such as &#39;kVMware&#39;, &#39;kView&#39;, &#39;kSQL&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39; &#39;kNetapp&#39; &#39;kGenericNas&#39;, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, or &#39;kAzure&#39;. Only items from the specified environment types are returned. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. | [optional] 
 **startIndex** | **long?**| Specifies an index number that can be used to return subsets of items in multiple requests. Break up the items to return into multiple requests by setting pageCount and using startIndex to return a subsets of items. For example, set startIndex to 0 to get the first set of items for the first request. Increment startIndex by pageCount to get the next set of items for a next request. Continue until all items are returned and therefore the total number of returned items is equal to totalCount. | [optional] 
 **operatingSystems** | [**List&lt;string&gt;**](string.md)| Filter by the Operating Systems running on VMs and Physical Servers. This filter is applicable only to VMs and physical servers. | [optional] 
 **application** | **string**| Filter by application when the environment type is kSQL. For example, if SQL is specified the SQL databases are returned. | [optional] 
 **ownerEntityId** | **long?**| Filter objects by the Entity id of the owner VM. For example, if a ownerEntityId is provided while searching for SQL databases, only SQL databases belonging to the VM with the specified id are returned. ownerEntityId is only significant if application is set to SQL. | [optional] 
 **search** | **string**| Filter by searching for sub-strings in the item name. The specified string can match any part of the item name. For example: \&quot;vm\&quot; or \&quot;123\&quot; both match the item name of \&quot;vm-123\&quot;. | [optional] 
 **registeredSourceIds** | [**List&lt;long?&gt;**](long?.md)| Filter by a list of Registered Sources ids. Only items from the listed Registered Sources are returned. | [optional] 
 **startTimeUsecs** | **long?**| Filter by backup completion time by specifying a backup completion start and end times. Specified as a Unix epoch Timestamp (in microseconds). Only items created by backups that completed between the specified start and end times are returned. | [optional] 
 **endTimeUsecs** | **long?**| Filter by backup completion time by specify a backup completion start and end times. Specified as a Unix epoch Timestamp (in microseconds). Only items created by backups that completed between the specified start and end times are returned. | [optional] 
 **pageCount** | **long?**| Limit the number of items to return in the response for pagination purposes. | [optional] 

### Return type

[**ObjectSearchResults**](ObjectSearchResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchrestoredfiles"></a>
# **SearchRestoredFiles**
> FileSearchResults SearchRestoredFiles (long? startTimeUsecs = null, long? endTimeUsecs = null, List<long?> sourceIds = null, long? startIndex = null, long? pageCount = null, bool? folderOnly = null, string search = null, List<long?> jobIds = null, List<long?> registeredSourceIds = null, List<long?> viewBoxIds = null, List<string> environments = null)

Search for files and folders to recover that match the specified search and filter criteria on the Cohesity Cluster.

Use the files and folders returned by this operation to populate the list of files and folders to recover in the POST /public/restore/files operation. If no search pattern or filter parameters are specified, all files and folders currently found on the Cohesity Cluster are returned. Specify a search pattern or parameters to filter the results that are returned.  The term \"items\" below refers to files and folders that are found in the source objects (such as VMs).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchRestoredFilesExample
    {
        public void main()
        {
            var apiInstance = new RestoreTasksApi();
            var startTimeUsecs = 789;  // long? | Filter by backup completion time by specifying a backup completion start and end times. Specified as a Unix epoch Timestamp (in microseconds). Only items created by backups that completed between the specified start and end times are returned. (optional) 
            var endTimeUsecs = 789;  // long? | Filter by backup completion time by specify a backup completion start and end times. Specified as a Unix epoch Timestamp (in microseconds). Only items created by backups that completed between the specified start and end times are returned. (optional) 
            var sourceIds = new List<long?>(); // List<long?> | Filter by source ids. Only files and folders found in the listed sources (such as VMs) are returned. (optional) 
            var startIndex = 789;  // long? | Specifies an index number that can be used to return subsets of items in multiple requests. Break up the items to return into multiple requests by setting pageCount and using startIndex to return a subsets of items. For example, set startIndex to 0 to get the first set of items for the first request. Increment startIndex by pageCount to get the next set of items for a next request. Continue until all items are returned and therefore the total number of returned items is equal to totalCount. (optional) 
            var pageCount = 789;  // long? | Limit the number of items to return in the response for pagination purposes. (optional) 
            var folderOnly = true;  // bool? | Filter by folders or files. If true, only folders are returned. If false, only files are returned. If not specified, both files and folders are returned. (optional) 
            var search = search_example;  // string | Filter by searching for sub-strings in the item name. The specified string can match any part of the item name. For example: \"vm\" or \"123\" both match the item name of \"vm-123\". (optional) 
            var jobIds = new List<long?>(); // List<long?> | Filter by a list of Protection Job ids. Only items backed up by the specified Jobs are listed. (optional) 
            var registeredSourceIds = new List<long?>(); // List<long?> | Filter by a list of Registered Sources ids. Only items from the listed Registered Sources are returned. (optional) 
            var viewBoxIds = new List<long?>(); // List<long?> | Filter by a list of Domains (View Boxes) ids. Only items stored in the listed Domains (View Boxes) are returned. (optional) 
            var environments = environments_example;  // List<string> | Filter by environment types such as 'kVMware', 'kView', 'kSQL', 'kPuppeteer', 'kPhysical', 'kPure' 'kNetapp' or 'kGenericNas'. Only items from the specified environment types are returned. NOTE: 'kPuppeteer' refers to Cohesity's Remote Adapter. (optional) 

            try
            {
                // Search for files and folders to recover that match the specified search and filter criteria on the Cohesity Cluster.
                FileSearchResults result = apiInstance.SearchRestoredFiles(startTimeUsecs, endTimeUsecs, sourceIds, startIndex, pageCount, folderOnly, search, jobIds, registeredSourceIds, viewBoxIds, environments);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RestoreTasksApi.SearchRestoredFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startTimeUsecs** | **long?**| Filter by backup completion time by specifying a backup completion start and end times. Specified as a Unix epoch Timestamp (in microseconds). Only items created by backups that completed between the specified start and end times are returned. | [optional] 
 **endTimeUsecs** | **long?**| Filter by backup completion time by specify a backup completion start and end times. Specified as a Unix epoch Timestamp (in microseconds). Only items created by backups that completed between the specified start and end times are returned. | [optional] 
 **sourceIds** | [**List&lt;long?&gt;**](long?.md)| Filter by source ids. Only files and folders found in the listed sources (such as VMs) are returned. | [optional] 
 **startIndex** | **long?**| Specifies an index number that can be used to return subsets of items in multiple requests. Break up the items to return into multiple requests by setting pageCount and using startIndex to return a subsets of items. For example, set startIndex to 0 to get the first set of items for the first request. Increment startIndex by pageCount to get the next set of items for a next request. Continue until all items are returned and therefore the total number of returned items is equal to totalCount. | [optional] 
 **pageCount** | **long?**| Limit the number of items to return in the response for pagination purposes. | [optional] 
 **folderOnly** | **bool?**| Filter by folders or files. If true, only folders are returned. If false, only files are returned. If not specified, both files and folders are returned. | [optional] 
 **search** | **string**| Filter by searching for sub-strings in the item name. The specified string can match any part of the item name. For example: \&quot;vm\&quot; or \&quot;123\&quot; both match the item name of \&quot;vm-123\&quot;. | [optional] 
 **jobIds** | [**List&lt;long?&gt;**](long?.md)| Filter by a list of Protection Job ids. Only items backed up by the specified Jobs are listed. | [optional] 
 **registeredSourceIds** | [**List&lt;long?&gt;**](long?.md)| Filter by a list of Registered Sources ids. Only items from the listed Registered Sources are returned. | [optional] 
 **viewBoxIds** | [**List&lt;long?&gt;**](long?.md)| Filter by a list of Domains (View Boxes) ids. Only items stored in the listed Domains (View Boxes) are returned. | [optional] 
 **environments** | **List&lt;string&gt;**| Filter by environment types such as &#39;kVMware&#39;, &#39;kView&#39;, &#39;kSQL&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39; &#39;kNetapp&#39; or &#39;kGenericNas&#39;. Only items from the specified environment types are returned. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. | [optional] 

### Return type

[**FileSearchResults**](FileSearchResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


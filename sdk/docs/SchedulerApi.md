# IO.Swagger.Api.SchedulerApi

All URIs are relative to *https://localhost/irisservices/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSchedulerJob**](SchedulerApi.md#createschedulerjob) | **POST** /public/scheduler | Create an email report scheduler job.
[**DeleteSchedulerJobs**](SchedulerApi.md#deleteschedulerjobs) | **DELETE** /public/scheduler | Delete one or more email report schedule jobs.
[**GetSchedulerJobs**](SchedulerApi.md#getschedulerjobs) | **GET** /public/scheduler | List the email report schedule jobs that are scheduled to run.
[**UpdateSchedulerJob**](SchedulerApi.md#updateschedulerjob) | **PUT** /public/scheduler | Update an existing email report schedule job.


<a name="createschedulerjob"></a>
# **CreateSchedulerJob**
> SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameter CreateSchedulerJob (SchedulerProtoSchedulerJob body)

Create an email report scheduler job.

Returns the created email report scheduler job. An email report scheduler job generates a report with the specified parameters and sends that report to the specified email accounts according to the defined schedule. This operation may also be used to send a report once (with no schedule), by setting the EnableRecurring field to false.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateSchedulerJobExample
    {
        public void main()
        {
            var apiInstance = new SchedulerApi();
            var body = new SchedulerProtoSchedulerJob(); // SchedulerProtoSchedulerJob | 

            try
            {
                // Create an email report scheduler job.
                SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameter result = apiInstance.CreateSchedulerJob(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchedulerApi.CreateSchedulerJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SchedulerProtoSchedulerJob**](SchedulerProtoSchedulerJob.md)|  | 

### Return type

[**SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameter**](SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteschedulerjobs"></a>
# **DeleteSchedulerJobs**
> void DeleteSchedulerJobs (List<long?> ids = null)

Delete one or more email report schedule jobs.

Specify a list of email report schedule job ids to unschedule and delete.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteSchedulerJobsExample
    {
        public void main()
        {
            var apiInstance = new SchedulerApi();
            var ids = ;  // List<long?> | Array of ids (optional) 

            try
            {
                // Delete one or more email report schedule jobs.
                apiInstance.DeleteSchedulerJobs(ids);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchedulerApi.DeleteSchedulerJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ids** | **List&lt;long?&gt;**| Array of ids | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getschedulerjobs"></a>
# **GetSchedulerJobs**
> SchedulerProto GetSchedulerJobs ()

List the email report schedule jobs that are scheduled to run.

Returns all the email report scheduler jobs that are scheduled to run. An email report scheduler job generates a report with the specified parameters and sends that report to the specified email accounts according to the defined schedule.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSchedulerJobsExample
    {
        public void main()
        {
            var apiInstance = new SchedulerApi();

            try
            {
                // List the email report schedule jobs that are scheduled to run.
                SchedulerProto result = apiInstance.GetSchedulerJobs();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchedulerApi.GetSchedulerJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**SchedulerProto**](SchedulerProto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateschedulerjob"></a>
# **UpdateSchedulerJob**
> SchedulerProtoSchedulerJob UpdateSchedulerJob (SchedulerProtoSchedulerJob body = null)

Update an existing email report schedule job.

Returns the updated email report scheduler job.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateSchedulerJobExample
    {
        public void main()
        {
            var apiInstance = new SchedulerApi();
            var body = new SchedulerProtoSchedulerJob(); // SchedulerProtoSchedulerJob | Update Job Parameter. (optional) 

            try
            {
                // Update an existing email report schedule job.
                SchedulerProtoSchedulerJob result = apiInstance.UpdateSchedulerJob(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchedulerApi.UpdateSchedulerJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SchedulerProtoSchedulerJob**](SchedulerProtoSchedulerJob.md)| Update Job Parameter. | [optional] 

### Return type

[**SchedulerProtoSchedulerJob**](SchedulerProtoSchedulerJob.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


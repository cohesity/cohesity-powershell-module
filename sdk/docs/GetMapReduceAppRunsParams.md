# IO.Swagger.Model.GetMapReduceAppRunsParams
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AppId** | **long?** | ApplicationId is the Id of the map reduce application. | [optional] 
**AppInstanceId** | **long?** | ApplicationInstanceId is the Id of the map reduce application instance. | [optional] 
**IncludeDetails** | **bool?** | If this flag is true, then send details of instance, else send only RunInfo. | [optional] 
**LastNumInstances** | **int?** | Give last N instance of an app based on end time. | [optional] 
**MaxRunEndTimeInSecs** | **long?** | MaxRunEndTimestampInSecs specifies the maximum job run end timestamp in seconds. App run instances with end time less than equal to MaxRunEndTimestampInSecs will be selected. Default is LONG_MAX (inf). | [optional] 
**MaxRunStartTimeInSecs** | **long?** | MaxRunStartTimestampInSecs specifies the maximum job run start timestamp in seconds. App run instances with start time less than equal to MaxRunStartTimestampInSecs will be selected. Default is LONG_MAX (inf). | [optional] 
**MinRunEndTimeInSecs** | **long?** | MinRunEndTimestampInSecs specifies the minimum job run end timestamp in seconds. App run instances with end time greater than equal to MinRunEndTimestampInSecs will be selected. Default is 0, i.e. beginning of time. | [optional] 
**MinRunStartTimeInSecs** | **long?** | MinRunStartTimestampInSecs specifies the minimum job run start timestamp in seconds. App run instances with start time greater than equal to MinRunStartTimestampInSecs will be selected. Default is 0, i.e. beginning of time. | [optional] 
**PageSize** | **int?** | Number of results to be displayed on a page. | [optional] 
**RunStatus** | **string** | Filter instances based on the map reduce application run status. | [optional] 
**StartOffset** | **int?** | Start offset for pagination from where result needs to be fetched. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


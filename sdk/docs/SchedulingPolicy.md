# IO.Swagger.Model.SchedulingPolicy
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContinuousSchedule** | [**ContinuousSchedule_**](ContinuousSchedule_.md) |  | [optional] 
**DailySchedule** | [**DailyWeeklySchedule_**](DailyWeeklySchedule_.md) |  | [optional] 
**MonthlySchedule** | [**MonthlySchedule_**](MonthlySchedule_.md) |  | [optional] 
**Periodicity** | **string** | Specifies how often to start new Job Runs of a Protection Job. &#39;kDaily&#39; means new Job Runs start daily. &#39;kMonthly&#39; means new Job Runs start monthly. &#39;kContinuous&#39; means new Job Runs repetitively start at the beginning of the specified time interval (in hours or minutes). &#39;kOneOff&#39; means this is an additional schedule. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


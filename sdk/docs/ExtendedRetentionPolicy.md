# IO.Swagger.Model.ExtendedRetentionPolicy
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DaysToKeep** | **long?** | Specifies the number of days to retain copied Snapshots on the target. | [optional] 
**Multiplier** | **int?** | Specifies a factor to multiply the periodicity by, to determine the copy schedule. For example if set to 2 and the periodicity is hourly, then Snapshots from the first eligible Job Run for every 2 hour period is copied. | [optional] 
**Periodicity** | **string** | Specifies the frequency that Snapshots should be copied to the specified target. Used in combination with multipiler. &#39;kEvery&#39; means that the Snapshot copy occurs after the number of Job Runs equals the number specified in the multiplier. &#39;kHour&#39; means that the Snapshot copy occurs hourly at the frequency set in the multiplier, for example if multiplier is 2, the copy occurs every 2 hours. &#39;kDay&#39; means that the Snapshot copy occurs daily at the frequency set in the multiplier. &#39;kWeek&#39; means that the Snapshot copy occurs weekly at the frequency set in the multiplier. &#39;kMonth&#39; means that the Snapshot copy occurs monthly at the frequency set in the multiplier. &#39;kYear&#39; means that the Snapshot copy occurs yearly at the frequency set in the multiplier. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


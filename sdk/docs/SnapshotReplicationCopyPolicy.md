# IO.Swagger.Model.SnapshotReplicationCopyPolicy
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CopyPartial** | **bool?** | Specifies if Snapshots are copied from the first completely successful Job Run or the first partially successful Job Run occurring at the start of the replication schedule. If true, Snapshots are copied from the first Job Run occurring at the start of the replication schedule, even if first Job Run was not completely successful i.e. Snapshots were not captured for all Objects in the Job. If false, Snapshots are copied from the first Job Run occurring at the start of the replication schedule that was completely successful i.e. Snapshots for all the Objects in the Job were successfully captured. | [optional] 
**DaysToKeep** | **long?** | Specifies the number of days to retain copied Snapshots on the target. | [optional] 
**Multiplier** | **int?** | Specifies a factor to multiply the periodicity by, to determine the copy schedule. For example if set to 2 and the periodicity is hourly, then Snapshots from the first eligible Job Run for every 2 hour period is copied. | [optional] 
**Periodicity** | **string** | Specifies the frequency that Snapshots should be copied to the specified target. Used in combination with multipiler. &#39;kEvery&#39; means that the Snapshot copy occurs after the number of Job Runs equals the number specified in the multiplier. &#39;kHour&#39; means that the Snapshot copy occurs hourly at the frequency set in the multiplier, for example if multiplier is 2, the copy occurs every 2 hours. &#39;kDay&#39; means that the Snapshot copy occurs daily at the frequency set in the multiplier. &#39;kWeek&#39; means that the Snapshot copy occurs weekly at the frequency set in the multiplier. &#39;kMonth&#39; means that the Snapshot copy occurs monthly at the frequency set in the multiplier. &#39;kYear&#39; means that the Snapshot copy occurs yearly at the frequency set in the multiplier. | [optional] 
**Target** | [**ReplicationTarget_**](ReplicationTarget_.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


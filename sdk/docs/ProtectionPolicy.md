# IO.Swagger.Model.ProtectionPolicy
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BlackoutPeriods** | [**List&lt;BlackoutPeriod&gt;**](BlackoutPeriod.md) | If specified, this field defines black periods when new Job Runs are not started. If a Job Run has been scheduled but not yet executed and the blackout period starts, the behavior depends on the policy field AbortInBlackoutPeriod. | [optional] 
**CloudDeployPolicies** | [**List&lt;SnapshotCloudCopyPolicy&gt;**](SnapshotCloudCopyPolicy.md) | Specifies settings for copying Snapshots to Cloud. CloudDeploy target where backup snapshots may be converted and stored. It also defines the retention of copied Snapshots on the Cloud. | [optional] 
**DaysToKeep** | **long?** | Specifies how many days to retain Snapshots on the Cohesity Cluster. | [optional] 
**DaysToKeepLog** | **long?** | Specifies the number of days to retain log run if Log Schedule exists. | [optional] 
**DaysToKeepSystem** | **long?** | Specifies the number of days to retain system backups made for bare metal recovery. This field is applicable if systemSchedulingPolicy is specified. | [optional] 
**Description** | **string** | Description of the Protection Policy. | [optional] 
**ExtendedRetentionPolicies** | [**List&lt;ExtendedRetentionPolicy&gt;**](ExtendedRetentionPolicy.md) | Specifies additional retention policies that should be applied to the backup snapshots. A backup snapshot will be retained up to a time that is the maximum of all retention policies that are applicable to it. | [optional] 
**FullSchedulingPolicy** | [**FullNoCBTJobPolicy_**](FullNoCBTJobPolicy_.md) |  | [optional] 
**Id** | **string** | Specifies a unique Policy id assigned by the Cohesity Cluster. | [optional] 
**IncrementalSchedulingPolicy** | [**CBTbasedJobPolicy_**](CBTbasedJobPolicy_.md) |  | [optional] 
**LastModifiedTimeMsecs** | **long?** | Specifies the epoch time (in milliseconds) when the Protection Policy was last modified. | [optional] 
**LogSchedulingPolicy** | [**SchedulingPolicy**](SchedulingPolicy.md) | Specifies the Log backup schedule of a Protection Job and how long log files captured by this schedule are retained on the Cohesity Cluster. | [optional] 
**Name** | **string** | Specifies the name of the Protection Policy. | [optional] 
**Retries** | **int?** | Specifies the number of times to retry capturing Snapshots before the Job Run fails. | [optional] 
**RetryIntervalMins** | **int?** | Specifies the number of minutes before retrying a failed Protection Job. | [optional] 
**SkipIntervalMins** | **int?** | Specifies the period of time before skipping the execution of new Job Runs if an existing queued Job Run of the same Protection Job has not started. For example if this field is set to 30 minutes and a Job Run is scheduled to start at 5:00 AM every day but does not start due to conflicts (such as too many Jobs are running). If the new Job Run does not start by 5:30AM, the Cohesity Cluster will skip the new Job Run. If the original Job Run completes before 5:30AM the next day, a new Job Run is created and starts executing. This field is optional. | [optional] 
**SnapshotArchivalCopyPolicies** | [**List&lt;SnapshotArchivalCopyPolicy&gt;**](SnapshotArchivalCopyPolicy.md) | Specifies settings for copying Snapshots to  Archival External Targets (such as AWS or Tape). It also defines the retention of copied Snapshots on an External Targets such as AWS and Tape. | [optional] 
**SnapshotReplicationCopyPolicies** | [**List&lt;SnapshotReplicationCopyPolicy&gt;**](SnapshotReplicationCopyPolicy.md) | Specifies settings for copying Snapshots to Remote Clusters. It also defines the retention of copied Snapshots on a Remote Cluster. | [optional] 
**SystemSchedulingPolicy** | [**SchedulingPolicy**](SchedulingPolicy.md) | Specifies the system backup schedule for agents running on servers to run low frequency backup jobs. Images created as part of the backup can be used to perform a \&quot;bare metal\&quot; recovery. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


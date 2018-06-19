# IO.Swagger.Model.RemoteVaultSearchJobResults
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClusterCount** | **int?** | Specifies number of Clusters that have archived to the remote Vault that match the criteria specified in the search Job, up to this point in the search. If the search is complete, the total number of Clusters that have archived to the remote Vault and that match the search criteria for the search Job, are reported. If the search was not complete, a partial number is reported. | [optional] 
**ClusterMatchString** | **string** | Specifies the value of the clusterMatchSting if it was set in the original search Job. | [optional] 
**Cookie** | **string** | Specifies an opaque string to pass to the next request to get the next set of search results. This is provided to support pagination. If null, this is the last set of search results. | [optional] 
**EndTimeUsecs** | **long?** | Specifies the value of endTimeUsecs if it was set in the original search Job. End time is recorded as a Unix epoch Timestamp (in microseconds). | [optional] 
**Error** | **string** | Specifies the error message if the search fails. | [optional] 
**JobCount** | **int?** | Specifies number of Protection Jobs that have archived to the remote Vault that match the criteria specified in the search Job. If the search is complete, the total number of Protection Jobs that have archived to the remote Vault and match the search criteria for the search Job, are reported. If the search is not complete, a partial number is reported. | [optional] 
**JobMatchString** | **string** | Specifies the value of the jobMatchSting if it was set in the original search Job. | [optional] 
**ProtectionJobs** | [**List&lt;RemoteProtectionJobRunInformation&gt;**](RemoteProtectionJobRunInformation.md) | Specifies a list of Protection Jobs that have archived data to a remote Vault and that also match the filter criteria. | [optional] 
**SearchJobStatus** | **string** | Specifies the status of the search Job. &#39;kJobRunning&#39; indicates that the Job/task is currently running. &#39;kJobFinished&#39; indicates that the Job/task completed and finished. &#39;kJobFailed&#39; indicates that the Job/task failed and did not complete. &#39;kJobCanceled&#39; indicates that the Job/task was canceled. &#39;kJobPaused&#39; indicates the Job/task is paused. | [optional] 
**SearchJobUid** | [**SearchJobId_**](SearchJobId_.md) |  | [optional] 
**StartTimeUsecs** | **long?** | Specifies the value of startTimeUsecs if it was set in the original search Job. Start time is recorded as a Unix epoch Timestamp (in microseconds). | [optional] 
**VaultId** | **long?** | Specifies the id of the remote Vault that was searched. | [optional] 
**VaultName** | **string** | Specifies the name of the remote Vault that was searched. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


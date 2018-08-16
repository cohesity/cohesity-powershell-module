# IO.Swagger.Model.UserQuotaSummaryForView
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DefaultUserQuotaPolicy** | [**QuotaPolicy**](QuotaPolicy.md) | Default quota policy applied to all the users in the view who doesn&#39;t have a policy override. | [optional] 
**NumUsersAboveAlertThreshold** | **long?** | Number of users who has exceeded their specified alert limit. | [optional] 
**NumUsersAboveHardLimit** | **long?** | Number of users who has exceeded their specified quota hard limit. | [optional] 
**TotalNumUsers** | **long?** | Total number of users who has either a user quota policy override specified or has non-zero logical usage. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


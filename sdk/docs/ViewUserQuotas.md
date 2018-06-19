# IO.Swagger.Model.ViewUserQuotas
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cookie** | **string** | This cookie can be used in the succeeding call to list user quotas and usages to get the next set of user quota overrides. If set to nil, it means that there&#39;s no more results that the server could provide. | [optional] 
**QuotaAndUsageInAllViews** | [**List&lt;QuotaAndUsageInView&gt;**](QuotaAndUsageInView.md) |  | [optional] 
**SummaryForUser** | [**UserQuotaSummaryForUser**](UserQuotaSummaryForUser.md) | UserQuotaSummaryForUser is the summary for user quotas in all views for a user. | [optional] 
**SummaryForView** | [**UserQuotaSummaryForView**](UserQuotaSummaryForView.md) | UserQuotaSummaryForView is the summary for user quotas in a view. | [optional] 
**UserQuotaSettings** | [**UserQuotaSettings**](UserQuotaSettings.md) | The default user quota policy for this view. | [optional] 
**UsersQuotaAndUsage** | [**List&lt;UserQuotaAndUsage&gt;**](UserQuotaAndUsage.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


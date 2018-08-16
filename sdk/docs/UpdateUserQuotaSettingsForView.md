# IO.Swagger.Model.UpdateUserQuotaSettingsForView
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DefaultUserQuotaPolicy** | [**QuotaPolicy**](QuotaPolicy.md) | The default user quota policy for this view. | [optional] 
**EnableUserQuota** | **bool?** | If set, it enables/disables the user quota overrides for a view. Otherwise, it leaves it at it&#39;s previous state. | [optional] 
**InheritDefaultPolicyFromViewbox** | **bool?** | If set to true, the default_policy in view metadata will be cleared and the default policy from viewbox will take effect for all users in the view. | [optional] 
**ViewName** | **string** | View name of input view. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# IO.Swagger.Model.UserParameters
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | Specifies a description about the user. | [optional] 
**Domain** | **string** | Specifies the fully qualified domain name (FQDN) of an Active Directory or LOCAL for the default LOCAL domain on the Cohesity Cluster. A user is uniquely identified by combination of the username and the domain. | [optional] 
**EffectiveTimeMsecs** | **long?** | Specifies the epoch time in milliseconds when the user becomes effective. Until that time, the user cannot log in. | [optional] 
**EmailAddress** | **string** | Specifies the email address of the user. | [optional] 
**Password** | **string** | Specifies the password of this user. | [optional] 
**Restricted** | **bool?** | Whether the user is a restricted user. A restricted user can only view the objects he has permissions to. | [optional] 
**Roles** | **List&lt;string&gt;** | Specifies the Cohesity roles to associate with the user such as such as &#39;Admin&#39;, &#39;Ops&#39; or &#39;View&#39;. The Cohesity roles determine privileges on the Cohesity Cluster for this user. | [optional] 
**Username** | **string** | Specifies the login name of the user. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


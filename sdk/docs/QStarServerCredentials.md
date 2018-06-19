# IO.Swagger.Model.QStarServerCredentials
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | **string** | Specifies the IP address or DNS name of the server where QStar service is running. | [optional] 
**IntegralVolumeNames** | **List&lt;string&gt;** | Specifies a list of existing Integral Volume names available on the QStar server for storing objects. | [optional] 
**Password** | **string** | Specifies the password used to access the QStar host. | [optional] 
**Port** | **int?** | Specifies the listening port where QStar WEB API service is running. | [optional] 
**ShareType** | **string** | Specifies the sharing protocol type used by QStar to mount the integral volume. See the Cohesity online help for the recommended protocol for your environment. | [optional] 
**UseHttps** | **bool?** | Specifies whether to use http or https to connect to the service. If true, a secure connection (https) is used. | [optional] 
**Username** | **string** | Specifies the account name used to access the QStar host. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


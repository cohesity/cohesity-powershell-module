# IO.Swagger.Model.DashboardResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Dashboard** | [**Dashboard**](Dashboard.md) | Specifies the dashboard of the local cluster or a remote cluster whose id is set in clusterId query parameter when the query parameter allClusters is not given or set to false. Otherwise this field is populated with aggregated dashboard values for all the dashboards in the dashboards field. | [optional] 
**Dashboards** | [**List&lt;Dashboard&gt;**](Dashboard.md) | Specifies a list of dashboards of all the clusters in the SPOG setup if the query parameter allClusters is set to true. Otherwise this field is not populated. When populated the dashboard field is also populated with aggregated dashboard values. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


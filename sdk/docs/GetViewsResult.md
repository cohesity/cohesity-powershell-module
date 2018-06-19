# IO.Swagger.Model.GetViewsResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LastResult** | **bool?** | If false, more Views are available to return. If the number of Views to return exceeds the number of Views specified in maxCount (default of 1000) of the original GET /public/views request, the first set of Views are returned and this field returns false. To get the next set of Views, in the next GET /public/views request send the last id from the previous viewList. | [optional] 
**Views** | [**List&lt;View&gt;**](View.md) | Specifies the list of Views returned in this response. The list is sorted by decreasing View ids. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


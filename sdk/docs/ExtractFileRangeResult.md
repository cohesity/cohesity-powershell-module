# IO.Swagger.Model.ExtractFileRangeResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Data** | **List&lt;int?&gt;** |  | [optional] 
**Eof** | **bool?** | Will be true if start_offset &gt; file length or EOF is reached. This is an alternative to using file_length to determine when entire file is read. Used when fetching from a view. | [optional] 
**Error** | [**ErrorProto**](ErrorProto.md) | Success/error status of the operation. | [optional] 
**FileLength** | **long?** | The total length of the file. This field would be set provided no error had occurred (indicated by error field above). | [optional] 
**StartOffset** | **long?** | The offset from which data was read. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


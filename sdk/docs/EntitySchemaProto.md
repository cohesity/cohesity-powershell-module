# IO.Swagger.Model.EntitySchemaProto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AttributesDescriptor** | [**EntitySchemaProtoAttributesDescriptor**](EntitySchemaProtoAttributesDescriptor.md) |  | [optional] 
**IsInternalSchema** | **bool?** | Specifies if this schema should be displayed in Advanced Diagnostics of the Cohesity Dashboard. If false, the schema is displayed. | [optional] 
**Name** | **string** | Specifies a name that uniquely identifies an entity schema such as &#39;kBridgeClusterStats&#39;. | [optional] 
**SchemaDescriptiveName** | **string** | Specifies the name of the Schema as displayed in Advanced Diagnostics of the Cohesity Dashboard. For example for the &#39;kBridgeClusterStats&#39; Schema, the descriptive name is &#39;Cluster Physical Stats&#39;. | [optional] 
**SchemaHelpText** | **string** | Specifies an optional informational description about the schema. | [optional] 
**TimeSeriesDescriptorVec** | [**List&lt;EntitySchemaProtoTimeSeriesDescriptor&gt;**](EntitySchemaProtoTimeSeriesDescriptor.md) | List of time series of data (set of data points) for metrics. | [optional] 
**Version** | **long?** | Specifies the version of the entity schema. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


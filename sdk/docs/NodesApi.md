# IO.Swagger.Api.NodesApi

All URIs are relative to *https://localhost/irisservices/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetNodeById**](NodesApi.md#getnodebyid) | **GET** /public/nodes/{id} | List details about a single node.
[**GetNodes**](NodesApi.md#getnodes) | **GET** /public/nodes | List Nodes of the cluster.


<a name="getnodebyid"></a>
# **GetNodeById**
> List<Node> GetNodeById (long? id)

List details about a single node.

Returns the Node corresponding to the specified Node Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetNodeByIdExample
    {
        public void main()
        {
            var apiInstance = new NodesApi();
            var id = 789;  // long? | Id of the Node

            try
            {
                // List details about a single node.
                List&lt;Node&gt; result = apiInstance.GetNodeById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodesApi.GetNodeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the Node | 

### Return type

[**List<Node>**](Node.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnodes"></a>
# **GetNodes**
> List<Node> GetNodes ()

List Nodes of the cluster.

If no parameters are specified, all Nodes currently on the Cohesity Cluster are returned. Specifying parameters filters the results that are returned.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetNodesExample
    {
        public void main()
        {
            var apiInstance = new NodesApi();

            try
            {
                // List Nodes of the cluster.
                List&lt;Node&gt; result = apiInstance.GetNodes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodesApi.GetNodes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Node>**](Node.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


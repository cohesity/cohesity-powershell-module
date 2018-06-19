# IO.Swagger.Api.ClusterPartitionsApi

All URIs are relative to *https://localhost/irisservices/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetClusterPartitionById**](ClusterPartitionsApi.md#getclusterpartitionbyid) | **GET** /public/clusterPartitions/{id} | List details about a single Cluster Partition.
[**GetClusterPartitions**](ClusterPartitionsApi.md#getclusterpartitions) | **GET** /public/clusterPartitions | List Cluster Partitions filtered by the specified parameters.


<a name="getclusterpartitionbyid"></a>
# **GetClusterPartitionById**
> ClusterPartition GetClusterPartitionById (long? id)

List details about a single Cluster Partition.

Returns the Cluster Partition corresponding to the specified Cluster Partition Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClusterPartitionByIdExample
    {
        public void main()
        {
            var apiInstance = new ClusterPartitionsApi();
            var id = 789;  // long? | Specifies a unique id of the Cluster Partition to return.

            try
            {
                // List details about a single Cluster Partition.
                ClusterPartition result = apiInstance.GetClusterPartitionById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClusterPartitionsApi.GetClusterPartitionById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Specifies a unique id of the Cluster Partition to return. | 

### Return type

[**ClusterPartition**](ClusterPartition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclusterpartitions"></a>
# **GetClusterPartitions**
> List<ClusterPartition> GetClusterPartitions (List<long?> ids = null, List<string> names = null)

List Cluster Partitions filtered by the specified parameters.

If no parameters are specified, all Cluster Partitions currently on the Cohesity Cluster are returned. Specifying parameters filters the results that are returned.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClusterPartitionsExample
    {
        public void main()
        {
            var apiInstance = new ClusterPartitionsApi();
            var ids = new List<long?>(); // List<long?> | Array of Cluster Partition Ids.  Filter by a list of Cluster Partition ids. If empty, the Cluster Partitions are not filtered by id. (optional) 
            var names = new List<string>(); // List<string> | Array of Cluster Partition Names.  Filter by a list of Cluster Partition Names. If empty, the Cluster Partitions are not filtered by names. (optional) 

            try
            {
                // List Cluster Partitions filtered by the specified parameters.
                List&lt;ClusterPartition&gt; result = apiInstance.GetClusterPartitions(ids, names);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClusterPartitionsApi.GetClusterPartitions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ids** | [**List&lt;long?&gt;**](long?.md)| Array of Cluster Partition Ids.  Filter by a list of Cluster Partition ids. If empty, the Cluster Partitions are not filtered by id. | [optional] 
 **names** | [**List&lt;string&gt;**](string.md)| Array of Cluster Partition Names.  Filter by a list of Cluster Partition Names. If empty, the Cluster Partitions are not filtered by names. | [optional] 

### Return type

[**List<ClusterPartition>**](ClusterPartition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


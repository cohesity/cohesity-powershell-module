# IO.Swagger.Api.RemoteClusterApi

All URIs are relative to *https://localhost/irisservices/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateRemoteCluster**](RemoteClusterApi.md#createremotecluster) | **POST** /public/remoteClusters | Register a remote Cluster on this local Cluster for replication.
[**DeleteRemoteCluster**](RemoteClusterApi.md#deleteremotecluster) | **DELETE** /public/remoteClusters/{id} | Delete a remote Cluster registration connection.
[**GetRemoteClusterById**](RemoteClusterApi.md#getremoteclusterbyid) | **GET** /public/remoteClusters/{id} | List details about a single remote Cluster registered on this local Cluster.
[**GetRemoteClusters**](RemoteClusterApi.md#getremoteclusters) | **GET** /public/remoteClusters | List the remote Cohesity Clusters that are registered on this local Cohesity Cluster that match the filter criteria specified using parameters.
[**GetReplicationEncryptionKey**](RemoteClusterApi.md#getreplicationencryptionkey) | **GET** /public/replicationEncryptionKey | Get the encryption key on this Cluster.
[**UpdateRemoteCluster**](RemoteClusterApi.md#updateremotecluster) | **PUT** /public/remoteClusters/{id} | Update the connection settings of the registered remote Cluster.


<a name="createremotecluster"></a>
# **CreateRemoteCluster**
> RemoteCluster CreateRemoteCluster (RegisterRemoteCluster body)

Register a remote Cluster on this local Cluster for replication.

For a Protection Job to replicate Snapshots from one Cluster to another Cluster, the Clusters must be paired together by registering each Cluster on the other Cluster. For example, Cluster A must be registered on Cluster B and Cluster B must be registered on Cluster A.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateRemoteClusterExample
    {
        public void main()
        {
            var apiInstance = new RemoteClusterApi();
            var body = new RegisterRemoteCluster(); // RegisterRemoteCluster | Request to register a remote Cluster.

            try
            {
                // Register a remote Cluster on this local Cluster for replication.
                RemoteCluster result = apiInstance.CreateRemoteCluster(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RemoteClusterApi.CreateRemoteCluster: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RegisterRemoteCluster**](RegisterRemoteCluster.md)| Request to register a remote Cluster. | 

### Return type

[**RemoteCluster**](RemoteCluster.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteremotecluster"></a>
# **DeleteRemoteCluster**
> void DeleteRemoteCluster (long? id)

Delete a remote Cluster registration connection.

Delete the specified remote Cluster registration connection on this Cluster.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteRemoteClusterExample
    {
        public void main()
        {
            var apiInstance = new RemoteClusterApi();
            var id = 789;  // long? | id of the remote Cluster

            try
            {
                // Delete a remote Cluster registration connection.
                apiInstance.DeleteRemoteCluster(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RemoteClusterApi.DeleteRemoteCluster: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| id of the remote Cluster | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getremoteclusterbyid"></a>
# **GetRemoteClusterById**
> List<RemoteCluster> GetRemoteClusterById (long? id)

List details about a single remote Cluster registered on this local Cluster.

Returns the details about the remote Cluster with the specified Cluster id that is registered on this local Cluster.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRemoteClusterByIdExample
    {
        public void main()
        {
            var apiInstance = new RemoteClusterApi();
            var id = 789;  // long? | id of the remote Cluster

            try
            {
                // List details about a single remote Cluster registered on this local Cluster.
                List&lt;RemoteCluster&gt; result = apiInstance.GetRemoteClusterById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RemoteClusterApi.GetRemoteClusterById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| id of the remote Cluster | 

### Return type

[**List<RemoteCluster>**](RemoteCluster.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getremoteclusters"></a>
# **GetRemoteClusters**
> List<RemoteCluster> GetRemoteClusters (List<string> clusterNames = null, bool? purposeReplication = null, bool? purposeRemoteAccess = null, List<long?> clusterIds = null)

List the remote Cohesity Clusters that are registered on this local Cohesity Cluster that match the filter criteria specified using parameters.

Cohesity Clusters involved in replication, must be registered to each other. For example, if Cluster A is replicating Snapshots to Cluster B, Cluster B must be registered on Cluster A and Cluster B must be registered on Cluster A.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRemoteClustersExample
    {
        public void main()
        {
            var apiInstance = new RemoteClusterApi();
            var clusterNames = new List<string>(); // List<string> | Filter by a list of Cluster names. (optional) 
            var purposeReplication = true;  // bool? | Filter for purpose as Replication. (optional) 
            var purposeRemoteAccess = true;  // bool? | Filter for purpose as Remote Access. (optional) 
            var clusterIds = new List<long?>(); // List<long?> | Filter by a list of Cluster ids. (optional) 

            try
            {
                // List the remote Cohesity Clusters that are registered on this local Cohesity Cluster that match the filter criteria specified using parameters.
                List&lt;RemoteCluster&gt; result = apiInstance.GetRemoteClusters(clusterNames, purposeReplication, purposeRemoteAccess, clusterIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RemoteClusterApi.GetRemoteClusters: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clusterNames** | [**List&lt;string&gt;**](string.md)| Filter by a list of Cluster names. | [optional] 
 **purposeReplication** | **bool?**| Filter for purpose as Replication. | [optional] 
 **purposeRemoteAccess** | **bool?**| Filter for purpose as Remote Access. | [optional] 
 **clusterIds** | [**List&lt;long?&gt;**](long?.md)| Filter by a list of Cluster ids. | [optional] 

### Return type

[**List<RemoteCluster>**](RemoteCluster.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreplicationencryptionkey"></a>
# **GetReplicationEncryptionKey**
> ReplicationEncryptionKeyReponse GetReplicationEncryptionKey ()

Get the encryption key on this Cluster.

Get the encryption key that is used for encrypting replication data between this Cluster and a remote Cluster.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetReplicationEncryptionKeyExample
    {
        public void main()
        {
            var apiInstance = new RemoteClusterApi();

            try
            {
                // Get the encryption key on this Cluster.
                ReplicationEncryptionKeyReponse result = apiInstance.GetReplicationEncryptionKey();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RemoteClusterApi.GetReplicationEncryptionKey: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ReplicationEncryptionKeyReponse**](ReplicationEncryptionKeyReponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateremotecluster"></a>
# **UpdateRemoteCluster**
> RemoteCluster UpdateRemoteCluster (long? id, RegisterRemoteCluster body)

Update the connection settings of the registered remote Cluster.

Update the connection settings of the specified remote Cluster that is registered on this Cluster.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateRemoteClusterExample
    {
        public void main()
        {
            var apiInstance = new RemoteClusterApi();
            var id = 789;  // long? | id of the remote Cluster
            var body = new RegisterRemoteCluster(); // RegisterRemoteCluster | Request to update a remote Cluster.

            try
            {
                // Update the connection settings of the registered remote Cluster.
                RemoteCluster result = apiInstance.UpdateRemoteCluster(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RemoteClusterApi.UpdateRemoteCluster: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| id of the remote Cluster | 
 **body** | [**RegisterRemoteCluster**](RegisterRemoteCluster.md)| Request to update a remote Cluster. | 

### Return type

[**RemoteCluster**](RemoteCluster.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


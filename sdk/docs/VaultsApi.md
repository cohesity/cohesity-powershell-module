# IO.Swagger.Api.VaultsApi

All URIs are relative to *https://localhost/irisservices/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateVault**](VaultsApi.md#createvault) | **POST** /public/vaults | Create a new Vault (External Target).
[**DeleteVault**](VaultsApi.md#deletevault) | **DELETE** /public/vaults/{id} | Delete a Vault (External Target).
[**GetArchiveMediaInfo**](VaultsApi.md#getarchivemediainfo) | **GET** /public/vaults/archiveMediaInfo | List the media information for the specified archive service.
[**GetVaultById**](VaultsApi.md#getvaultbyid) | **GET** /public/vaults/{id} | List details about a single Vault (External Target).
[**GetVaultEncryptionKeyInfo**](VaultsApi.md#getvaultencryptionkeyinfo) | **GET** /public/vaults/encryptionKey/{id} | Get encryption information for a Vault (External Target). A Vault is equivalent to an External Target in the Cohesity Dashboard.
[**GetVaults**](VaultsApi.md#getvaults) | **GET** /public/vaults | List the Vaults (External Targets) registered on the Cohesity Cluster filtered by the specified parameters.
[**UpdateVault**](VaultsApi.md#updatevault) | **PUT** /public/vaults/{id} | Update a Vault (External Target).


<a name="createvault"></a>
# **CreateVault**
> Vault CreateVault (Vault body)

Create a new Vault (External Target).

Returns the created Vault. A Vault is equivalent to an External Target in the Cohesity Dashboard.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateVaultExample
    {
        public void main()
        {
            var apiInstance = new VaultsApi();
            var body = new Vault(); // Vault | Request to create a new Vault.

            try
            {
                // Create a new Vault (External Target).
                Vault result = apiInstance.CreateVault(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VaultsApi.CreateVault: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Vault**](Vault.md)| Request to create a new Vault. | 

### Return type

[**Vault**](Vault.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevault"></a>
# **DeleteVault**
> void DeleteVault (long? id)

Delete a Vault (External Target).

Returns delete status upon completion. A Vault is equivalent to an External Target in the Cohesity Dashboard.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteVaultExample
    {
        public void main()
        {
            var apiInstance = new VaultsApi();
            var id = 789;  // long? | Specifies a unique id of the Vault.

            try
            {
                // Delete a Vault (External Target).
                apiInstance.DeleteVault(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VaultsApi.DeleteVault: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Specifies a unique id of the Vault. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getarchivemediainfo"></a>
# **GetArchiveMediaInfo**
> List<TapeMediaInformation> GetArchiveMediaInfo (long? clusterIncarnationId, long? qstarArchiveJobId, long? clusterId, long? qstarRestoreTaskId = null, List<long?> entityIds = null)

List the media information for the specified archive service.

Returns the media information about the specified archive service uid (such as a QStar tape archive service).  An archive service uid is uniquely identified using a combination of the following fields: clusterIncarnationId, entityIds and clusterId. These are all required fields.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetArchiveMediaInfoExample
    {
        public void main()
        {
            var apiInstance = new VaultsApi();
            var clusterIncarnationId = 789;  // long? | Specifies the incarnation id of the Cohesity Cluster that archived to a QStar media Vault.
            var qstarArchiveJobId = 789;  // long? | Specifies the id of the Job that archived to a QStar media Vault.
            var clusterId = 789;  // long? | Specifies the id of the Cohesity Cluster that archived to a QStar media Vault.
            var qstarRestoreTaskId = 789;  // long? | Specifies the id of the restore task to optionally filter by. The restore task that is restoring data from the specified media Vault. (optional) 
            var entityIds = new List<long?>(); // List<long?> | Specifies an array of entityIds to optionally filter by. An entityId is a unique id for a VM assigned by the Cohesity Cluster. (optional) 

            try
            {
                // List the media information for the specified archive service.
                List&lt;TapeMediaInformation&gt; result = apiInstance.GetArchiveMediaInfo(clusterIncarnationId, qstarArchiveJobId, clusterId, qstarRestoreTaskId, entityIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VaultsApi.GetArchiveMediaInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clusterIncarnationId** | **long?**| Specifies the incarnation id of the Cohesity Cluster that archived to a QStar media Vault. | 
 **qstarArchiveJobId** | **long?**| Specifies the id of the Job that archived to a QStar media Vault. | 
 **clusterId** | **long?**| Specifies the id of the Cohesity Cluster that archived to a QStar media Vault. | 
 **qstarRestoreTaskId** | **long?**| Specifies the id of the restore task to optionally filter by. The restore task that is restoring data from the specified media Vault. | [optional] 
 **entityIds** | [**List&lt;long?&gt;**](long?.md)| Specifies an array of entityIds to optionally filter by. An entityId is a unique id for a VM assigned by the Cohesity Cluster. | [optional] 

### Return type

[**List<TapeMediaInformation>**](TapeMediaInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvaultbyid"></a>
# **GetVaultById**
> Vault GetVaultById (long? id)

List details about a single Vault (External Target).

Returns the Vault corresponding to the specified Vault Id. A Vault is equivalent to an External Target in the Cohesity Dashboard.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetVaultByIdExample
    {
        public void main()
        {
            var apiInstance = new VaultsApi();
            var id = 789;  // long? | Specifies a unique id of the Vault.

            try
            {
                // List details about a single Vault (External Target).
                Vault result = apiInstance.GetVaultById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VaultsApi.GetVaultById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Specifies a unique id of the Vault. | 

### Return type

[**Vault**](Vault.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvaultencryptionkeyinfo"></a>
# **GetVaultEncryptionKeyInfo**
> VaultEncryptionKey GetVaultEncryptionKeyInfo (long? id)

Get encryption information for a Vault (External Target). A Vault is equivalent to an External Target in the Cohesity Dashboard.

Get encryption information (such as the encryption key) for the specified Vault (External Target). To restore data to a remote Cluster (for example to support a disaster recovery scenario), you must get the encryption key of the Vault and store it outside the local source Cluster, before disaster strikes. If you have the encryption key and the local source Cluster goes down, you can restore the data to a remote Cluster from the Vault. The local source Cluster is the Cluster that archived the data on the Vault.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetVaultEncryptionKeyInfoExample
    {
        public void main()
        {
            var apiInstance = new VaultsApi();
            var id = 789;  // long? | Specifies a unique id of the Vault.

            try
            {
                // Get encryption information for a Vault (External Target). A Vault is equivalent to an External Target in the Cohesity Dashboard.
                VaultEncryptionKey result = apiInstance.GetVaultEncryptionKeyInfo(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VaultsApi.GetVaultEncryptionKeyInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Specifies a unique id of the Vault. | 

### Return type

[**VaultEncryptionKey**](VaultEncryptionKey.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvaults"></a>
# **GetVaults**
> List<Vault> GetVaults (string name = null, bool? includeMarkedForRemoval = null, long? id = null)

List the Vaults (External Targets) registered on the Cohesity Cluster filtered by the specified parameters.

If no parameters are specified, all Vaults (External Targets) currently registered on the Cohesity Cluster are returned. Specifying parameters filters the results that are returned. A Vault is equivalent to an External Target in the Cohesity Dashboard.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetVaultsExample
    {
        public void main()
        {
            var apiInstance = new VaultsApi();
            var name = name_example;  // string | Specifies the name of the Vault to return. If empty, all Vaults are returned. (optional) 
            var includeMarkedForRemoval = true;  // bool? | Specifies if Vaults that are marked for removal should be returned. (optional) 
            var id = 789;  // long? | Specifies the id of Vault to return. If empty, all Vaults are returned. (optional) 

            try
            {
                // List the Vaults (External Targets) registered on the Cohesity Cluster filtered by the specified parameters.
                List&lt;Vault&gt; result = apiInstance.GetVaults(name, includeMarkedForRemoval, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VaultsApi.GetVaults: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Specifies the name of the Vault to return. If empty, all Vaults are returned. | [optional] 
 **includeMarkedForRemoval** | **bool?**| Specifies if Vaults that are marked for removal should be returned. | [optional] 
 **id** | **long?**| Specifies the id of Vault to return. If empty, all Vaults are returned. | [optional] 

### Return type

[**List<Vault>**](Vault.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatevault"></a>
# **UpdateVault**
> Vault UpdateVault (long? id, Vault body)

Update a Vault (External Target).

Update the settings of a Vault. A Vault is equivalent to an External Target in the Cohesity Dashboard. Returns the updated Vault.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateVaultExample
    {
        public void main()
        {
            var apiInstance = new VaultsApi();
            var id = 789;  // long? | Specifies a unique id of the Vault.
            var body = new Vault(); // Vault | Request to update a Vault's settings.

            try
            {
                // Update a Vault (External Target).
                Vault result = apiInstance.UpdateVault(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VaultsApi.UpdateVault: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Specifies a unique id of the Vault. | 
 **body** | [**Vault**](Vault.md)| Request to update a Vault&#39;s settings. | 

### Return type

[**Vault**](Vault.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


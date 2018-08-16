# IO.Swagger.Api.VlanApi

All URIs are relative to *https://localhost/irisservices/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetVlanById**](VlanApi.md#getvlanbyid) | **GET** /public/vlans/{id} | List the details about a single VLAN.
[**GetVlans**](VlanApi.md#getvlans) | **GET** /public/vlans | List the VLANs for the Cohesity Cluster.
[**RemoveVlan**](VlanApi.md#removevlan) | **DELETE** /public/vlans/{id} | Remove the specified VLAN from the Cohesity Cluster.
[**UpdateVlan**](VlanApi.md#updatevlan) | **PUT** /public/vlans/{id} | Creates or updates a VLAN of the Cohesity Cluster.


<a name="getvlanbyid"></a>
# **GetVlanById**
> Vlan GetVlanById (int? id)

List the details about a single VLAN.

Returns the VLAN corresponding to the specified VLAN ID.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetVlanByIdExample
    {
        public void main()
        {
            var apiInstance = new VlanApi();
            var id = 56;  // int? | Specifies the id of the VLAN.

            try
            {
                // List the details about a single VLAN.
                Vlan result = apiInstance.GetVlanById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VlanApi.GetVlanById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Specifies the id of the VLAN. | 

### Return type

[**Vlan**](Vlan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvlans"></a>
# **GetVlans**
> List<Vlan> GetVlans ()

List the VLANs for the Cohesity Cluster.

Returns the VLANs for the Cohesity Cluster.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetVlansExample
    {
        public void main()
        {
            var apiInstance = new VlanApi();

            try
            {
                // List the VLANs for the Cohesity Cluster.
                List&lt;Vlan&gt; result = apiInstance.GetVlans();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VlanApi.GetVlans: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Vlan>**](Vlan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removevlan"></a>
# **RemoveVlan**
> void RemoveVlan (int? id)

Remove the specified VLAN from the Cohesity Cluster.

Returns the delete status upon completion.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RemoveVlanExample
    {
        public void main()
        {
            var apiInstance = new VlanApi();
            var id = 56;  // int? | Specifies the id of the VLAN.

            try
            {
                // Remove the specified VLAN from the Cohesity Cluster.
                apiInstance.RemoveVlan(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VlanApi.RemoveVlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Specifies the id of the VLAN. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatevlan"></a>
# **UpdateVlan**
> Vlan UpdateVlan (int? id, Vlan body = null)

Creates or updates a VLAN of the Cohesity Cluster.

Returns the created or updated VLAN on the Cohesity Cluster.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateVlanExample
    {
        public void main()
        {
            var apiInstance = new VlanApi();
            var id = 56;  // int? | Specifies the id of the VLAN.
            var body = new Vlan(); // Vlan |  (optional) 

            try
            {
                // Creates or updates a VLAN of the Cohesity Cluster.
                Vlan result = apiInstance.UpdateVlan(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VlanApi.UpdateVlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Specifies the id of the VLAN. | 
 **body** | [**Vlan**](Vlan.md)|  | [optional] 

### Return type

[**Vlan**](Vlan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


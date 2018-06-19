# IO.Swagger.Api.ProtectionPoliciesApi

All URIs are relative to *https://localhost/irisservices/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateProtectionPolicy**](ProtectionPoliciesApi.md#createprotectionpolicy) | **POST** /public/protectionPolicies | Create a Protection Policy.
[**DeleteProtectionPolicy**](ProtectionPoliciesApi.md#deleteprotectionpolicy) | **DELETE** /public/protectionPolicies/{id} | Delete a Protection Policy.
[**GetProtectionPolicies**](ProtectionPoliciesApi.md#getprotectionpolicies) | **GET** /public/protectionPolicies | List Protection Policies filtered by some parameters.
[**GetProtectionPolicyById**](ProtectionPoliciesApi.md#getprotectionpolicybyid) | **GET** /public/protectionPolicies/{id} | List details about a single Protection Policy.
[**UpdateProtectionPolicy**](ProtectionPoliciesApi.md#updateprotectionpolicy) | **PUT** /public/protectionPolicies/{id} | Update a Protection Policy.


<a name="createprotectionpolicy"></a>
# **CreateProtectionPolicy**
> ProtectionPolicy CreateProtectionPolicy (ProtectionPolicyRequest body)

Create a Protection Policy.

Returns the created Protection Policy.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateProtectionPolicyExample
    {
        public void main()
        {
            var apiInstance = new ProtectionPoliciesApi();
            var body = new ProtectionPolicyRequest(); // ProtectionPolicyRequest | Request to create a Protection Policy.

            try
            {
                // Create a Protection Policy.
                ProtectionPolicy result = apiInstance.CreateProtectionPolicy(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtectionPoliciesApi.CreateProtectionPolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProtectionPolicyRequest**](ProtectionPolicyRequest.md)| Request to create a Protection Policy. | 

### Return type

[**ProtectionPolicy**](ProtectionPolicy.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteprotectionpolicy"></a>
# **DeleteProtectionPolicy**
> void DeleteProtectionPolicy (string id)

Delete a Protection Policy.

Returns Success if the Protection Policy is deleted.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteProtectionPolicyExample
    {
        public void main()
        {
            var apiInstance = new ProtectionPoliciesApi();
            var id = id_example;  // string | Specifies a unique id of the Protection Policy to return.

            try
            {
                // Delete a Protection Policy.
                apiInstance.DeleteProtectionPolicy(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtectionPoliciesApi.DeleteProtectionPolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Specifies a unique id of the Protection Policy to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprotectionpolicies"></a>
# **GetProtectionPolicies**
> List<ProtectionPolicy> GetProtectionPolicies (List<string> environments = null, List<string> ids = null, List<string> names = null)

List Protection Policies filtered by some parameters.

If no parameters are specified, all Protection Policies currently on the Cohesity Cluster are returned. Specifying parameters filters the results that are returned.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProtectionPoliciesExample
    {
        public void main()
        {
            var apiInstance = new ProtectionPoliciesApi();
            var environments = environments_example;  // List<string> | Filter by Environment type such as 'kView', 'kSQL', 'kVMware', 'kPuppeteer' 'kPhysical', 'kPure', 'kNetapp', 'kGenericNas', 'kHyperV', 'kAcropolis', or 'kAzure' Only Policies protecting the specified environment type are returned. NOTE: 'kPuppeteer' refers to Cohesity's Remote Adapter. (optional) 
            var ids = new List<string>(); // List<string> | Filter by a list of Protection Policy ids. (optional) 
            var names = new List<string>(); // List<string> | Filter by a list of Protection Policy names. (optional) 

            try
            {
                // List Protection Policies filtered by some parameters.
                List&lt;ProtectionPolicy&gt; result = apiInstance.GetProtectionPolicies(environments, ids, names);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtectionPoliciesApi.GetProtectionPolicies: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **environments** | **List&lt;string&gt;**| Filter by Environment type such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39; &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp&#39;, &#39;kGenericNas&#39;, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, or &#39;kAzure&#39; Only Policies protecting the specified environment type are returned. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. | [optional] 
 **ids** | [**List&lt;string&gt;**](string.md)| Filter by a list of Protection Policy ids. | [optional] 
 **names** | [**List&lt;string&gt;**](string.md)| Filter by a list of Protection Policy names. | [optional] 

### Return type

[**List<ProtectionPolicy>**](ProtectionPolicy.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprotectionpolicybyid"></a>
# **GetProtectionPolicyById**
> ProtectionPolicy GetProtectionPolicyById (string id)

List details about a single Protection Policy.

Returns the Protection Policy corresponding to the specified Policy Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProtectionPolicyByIdExample
    {
        public void main()
        {
            var apiInstance = new ProtectionPoliciesApi();
            var id = id_example;  // string | Specifies a unique id of the Protection Policy to return.

            try
            {
                // List details about a single Protection Policy.
                ProtectionPolicy result = apiInstance.GetProtectionPolicyById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtectionPoliciesApi.GetProtectionPolicyById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Specifies a unique id of the Protection Policy to return. | 

### Return type

[**ProtectionPolicy**](ProtectionPolicy.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateprotectionpolicy"></a>
# **UpdateProtectionPolicy**
> ProtectionPolicy UpdateProtectionPolicy (ProtectionPolicyRequest body, string id)

Update a Protection Policy.

Returns the updated Protection Policy.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateProtectionPolicyExample
    {
        public void main()
        {
            var apiInstance = new ProtectionPoliciesApi();
            var body = new ProtectionPolicyRequest(); // ProtectionPolicyRequest | Request to update a Protection Policy.
            var id = id_example;  // string | Specifies a unique id of the Protection Policy to return.

            try
            {
                // Update a Protection Policy.
                ProtectionPolicy result = apiInstance.UpdateProtectionPolicy(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtectionPoliciesApi.UpdateProtectionPolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProtectionPolicyRequest**](ProtectionPolicyRequest.md)| Request to update a Protection Policy. | 
 **id** | **string**| Specifies a unique id of the Protection Policy to return. | 

### Return type

[**ProtectionPolicy**](ProtectionPolicy.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


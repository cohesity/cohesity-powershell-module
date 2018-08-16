# IO.Swagger.Api.RolesApi

All URIs are relative to *https://localhost/irisservices/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateRole**](RolesApi.md#createrole) | **POST** /public/roles | Create a new custom role.
[**DeleteRoles**](RolesApi.md#deleteroles) | **DELETE** /public/roles | Delete one or more custom Roles.
[**GetRoles**](RolesApi.md#getroles) | **GET** /public/roles | List the roles defined on the Cohesity Cluster.
[**UpdateRole**](RolesApi.md#updaterole) | **PUT** /public/roles/{name} | Update a user-defined custom role.


<a name="createrole"></a>
# **CreateRole**
> Role CreateRole (RoleCreateParameters body = null)

Create a new custom role.

Returns the new custom role that was created. A custom role is a user-defined role that is created using the REST API, the Cohesity Cluster or the CLI.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateRoleExample
    {
        public void main()
        {
            var apiInstance = new RolesApi();
            var body = new RoleCreateParameters(); // RoleCreateParameters | Request to create a new custom Role. (optional) 

            try
            {
                // Create a new custom role.
                Role result = apiInstance.CreateRole(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.CreateRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RoleCreateParameters**](RoleCreateParameters.md)| Request to create a new custom Role. | [optional] 

### Return type

[**Role**](Role.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteroles"></a>
# **DeleteRoles**
> void DeleteRoles (RoleDeleteParameters body = null)

Delete one or more custom Roles.

Returns Success if all the specified Roles are deleted.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteRolesExample
    {
        public void main()
        {
            var apiInstance = new RolesApi();
            var body = new RoleDeleteParameters(); // RoleDeleteParameters | Request to delete one or more Roles. (optional) 

            try
            {
                // Delete one or more custom Roles.
                apiInstance.DeleteRoles(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.DeleteRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RoleDeleteParameters**](RoleDeleteParameters.md)| Request to delete one or more Roles. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getroles"></a>
# **GetRoles**
> List<Role> GetRoles (string name = null)

List the roles defined on the Cohesity Cluster.

If the 'name' parameter is not specified, all roles defined on the Cohesity Cluster are returned. In addition, information about each role is returned such as the name, description, assigned privileges, etc. If an exact role name (such as COHESITY_VIEWER) is specified in the 'name' parameter, only information about that single role is returned.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRolesExample
    {
        public void main()
        {
            var apiInstance = new RolesApi();
            var name = name_example;  // string | Specifies the name of the role. (optional) 

            try
            {
                // List the roles defined on the Cohesity Cluster.
                List&lt;Role&gt; result = apiInstance.GetRoles(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.GetRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Specifies the name of the role. | [optional] 

### Return type

[**List<Role>**](Role.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterole"></a>
# **UpdateRole**
> Role UpdateRole (string name, RoleUpdateParameters body = null)

Update a user-defined custom role.

For example, you could update the privileges assigned to a Role. Returns the updated role.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateRoleExample
    {
        public void main()
        {
            var apiInstance = new RolesApi();
            var name = name_example;  // string | Specifies the name of the role to update.
            var body = new RoleUpdateParameters(); // RoleUpdateParameters | Request to update a custom role. (optional) 

            try
            {
                // Update a user-defined custom role.
                Role result = apiInstance.UpdateRole(name, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.UpdateRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Specifies the name of the role to update. | 
 **body** | [**RoleUpdateParameters**](RoleUpdateParameters.md)| Request to update a custom role. | [optional] 

### Return type

[**Role**](Role.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


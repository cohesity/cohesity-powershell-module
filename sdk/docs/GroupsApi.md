# IO.Swagger.Api.GroupsApi

All URIs are relative to *https://localhost/irisservices/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateGroup**](GroupsApi.md#creategroup) | **POST** /public/groups | Create or add a new group to the Cohesity Cluster.
[**DeleteGroups**](GroupsApi.md#deletegroups) | **DELETE** /public/groups | Delete one or more groups on the Cohesity Cluster.
[**GetGroups**](GroupsApi.md#getgroups) | **GET** /public/groups | List the groups that match the filter criteria specified using parameters.
[**UpdateGroup**](GroupsApi.md#updategroup) | **PUT** /public/groups | Update an existing group on the Cohesity Cluster. Only group settings on the Cohesity Cluster are updated. No changes are made to the referenced group principal on the Active Directory.


<a name="creategroup"></a>
# **CreateGroup**
> Group CreateGroup (GroupParameters body = null)

Create or add a new group to the Cohesity Cluster.

If an Active Directory domain is specified, a new group is added to the Cohesity Cluster for the specified Active Directory group principal. If the LOCAL domain is specified, a new group is created directly in the default LOCAL domain on the Cohesity Cluster.  Returns the created or added group.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateGroupExample
    {
        public void main()
        {
            var apiInstance = new GroupsApi();
            var body = new GroupParameters(); // GroupParameters | Request to add or create a Group. (optional) 

            try
            {
                // Create or add a new group to the Cohesity Cluster.
                Group result = apiInstance.CreateGroup(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.CreateGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GroupParameters**](GroupParameters.md)| Request to add or create a Group. | [optional] 

### Return type

[**Group**](Group.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegroups"></a>
# **DeleteGroups**
> void DeleteGroups (GroupDeleteParameters body = null)

Delete one or more groups on the Cohesity Cluster.

If the group on the Cohesity Cluster was added for an Active Directory user, the referenced principal group on the Active Directory domain is NOT deleted. Only the group on the Cohesity Cluster is deleted.  Returns Success if the specified groups are deleted.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteGroupsExample
    {
        public void main()
        {
            var apiInstance = new GroupsApi();
            var body = new GroupDeleteParameters(); // GroupDeleteParameters | Request to delete one or more groups on the Cohesity Cluster. (optional) 

            try
            {
                // Delete one or more groups on the Cohesity Cluster.
                apiInstance.DeleteGroups(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.DeleteGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GroupDeleteParameters**](GroupDeleteParameters.md)| Request to delete one or more groups on the Cohesity Cluster. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroups"></a>
# **GetGroups**
> List<Group> GetGroups (string name = null, string domain = null)

List the groups that match the filter criteria specified using parameters.

If no parameters are specified, all groups currently on the Cohesity Cluster are returned. Specifying parameters filters the results that are returned.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetGroupsExample
    {
        public void main()
        {
            var apiInstance = new GroupsApi();
            var name = name_example;  // string | Optionally specify a group name to filter by. (optional) 
            var domain = domain_example;  // string | If no domain is specified, all groups on the Cohesity Cluster are searched. If a domain is specified, only groups on the Cohesity Cluster associated with that domain are searched. (optional) 

            try
            {
                // List the groups that match the filter criteria specified using parameters.
                List&lt;Group&gt; result = apiInstance.GetGroups(name, domain);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Optionally specify a group name to filter by. | [optional] 
 **domain** | **string**| If no domain is specified, all groups on the Cohesity Cluster are searched. If a domain is specified, only groups on the Cohesity Cluster associated with that domain are searched. | [optional] 

### Return type

[**List<Group>**](Group.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategroup"></a>
# **UpdateGroup**
> Group UpdateGroup (GroupParameters body = null)

Update an existing group on the Cohesity Cluster. Only group settings on the Cohesity Cluster are updated. No changes are made to the referenced group principal on the Active Directory.

Returns the group that was updated on the Cohesity Cluster.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateGroupExample
    {
        public void main()
        {
            var apiInstance = new GroupsApi();
            var body = new GroupParameters(); // GroupParameters | Request to update a group. (optional) 

            try
            {
                // Update an existing group on the Cohesity Cluster. Only group settings on the Cohesity Cluster are updated. No changes are made to the referenced group principal on the Active Directory.
                Group result = apiInstance.UpdateGroup(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.UpdateGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GroupParameters**](GroupParameters.md)| Request to update a group. | [optional] 

### Return type

[**Group**](Group.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


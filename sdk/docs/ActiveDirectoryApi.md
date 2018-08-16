# IO.Swagger.Api.ActiveDirectoryApi

All URIs are relative to *https://localhost/irisservices/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddActiveDirectoryPrincipals**](ActiveDirectoryApi.md#addactivedirectoryprincipals) | **POST** /public/activeDirectory/principals | Add multiple groups or users on the Cohesity Cluster for the specified Active Directory principals. In addition, assign Cohesity roles to the users or groups to define their Cohesity privileges.
[**CreateActiveDirectoryEntry**](ActiveDirectoryApi.md#createactivedirectoryentry) | **POST** /public/activeDirectory | Join the Cohesity Cluster to the specified Active Directory.
[**DeleteActiveDirectoryEntry**](ActiveDirectoryApi.md#deleteactivedirectoryentry) | **DELETE** /public/activeDirectory | Deletes the join with the Active Directory.
[**GetActiveDirectoryEntry**](ActiveDirectoryApi.md#getactivedirectoryentry) | **GET** /public/activeDirectory | Lists the Active Directories that the Cohesity Cluster has joined.
[**ListCentrifyZones**](ActiveDirectoryApi.md#listcentrifyzones) | **GET** /public/activeDirectory/centrifyZones | Fetches the list centrify zones of an active directory domain.
[**SearchActiveDirectoryPrincipals**](ActiveDirectoryApi.md#searchactivedirectoryprincipals) | **GET** /public/activeDirectory/principals | List the user and group principals in the Active Directory that match the filter criteria specified using parameters.
[**UpdateActiveDirectoryIdMapping**](ActiveDirectoryApi.md#updateactivedirectoryidmapping) | **PUT** /public/activeDirectory/{name}/idMappingInfo | Updates the user id mapping info of an Active Directory.
[**UpdateActiveDirectoryMachineAccounts**](ActiveDirectoryApi.md#updateactivedirectorymachineaccounts) | **POST** /public/activeDirectory/{name}/machineAccounts | Updates the machine accounts of an Active Directory.


<a name="addactivedirectoryprincipals"></a>
# **AddActiveDirectoryPrincipals**
> List<AddedActiveDirectoryPrincipal> AddActiveDirectoryPrincipals (List<ActiveDirectoryPrincipalsAddParameters> body = null)

Add multiple groups or users on the Cohesity Cluster for the specified Active Directory principals. In addition, assign Cohesity roles to the users or groups to define their Cohesity privileges.

After a group or user has been added to a Cohesity Cluster, the referenced Active Directory principal can be used by the Cohesity Cluster. In addition, this operation maps Cohesity roles with a group or user and this mapping defines the privileges allowed on the Cohesity Cluster for the group or user. For example if an 'management' group is created on the Cohesity Cluster for the Active Directory 'management' principal group and is associated with the Cohesity 'View' role, all users in the referenced Active Directory 'management' principal group can log in to the Cohesity Dashboard but will only have view-only privileges. These users cannot create new Protection Jobs, Policies, Views, etc.  NOTE: Local Cohesity users and groups cannot be created by this operation. Local Cohesity users or groups do not have an associated Active Directory principals and are created directly in the default LOCAL domain.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddActiveDirectoryPrincipalsExample
    {
        public void main()
        {
            var apiInstance = new ActiveDirectoryApi();
            var body = new List<ActiveDirectoryPrincipalsAddParameters>(); // List<ActiveDirectoryPrincipalsAddParameters> | Request to add groups or users to the Cohesity Cluster. (optional) 

            try
            {
                // Add multiple groups or users on the Cohesity Cluster for the specified Active Directory principals. In addition, assign Cohesity roles to the users or groups to define their Cohesity privileges.
                List&lt;AddedActiveDirectoryPrincipal&gt; result = apiInstance.AddActiveDirectoryPrincipals(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActiveDirectoryApi.AddActiveDirectoryPrincipals: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;ActiveDirectoryPrincipalsAddParameters&gt;**](ActiveDirectoryPrincipalsAddParameters.md)| Request to add groups or users to the Cohesity Cluster. | [optional] 

### Return type

[**List<AddedActiveDirectoryPrincipal>**](AddedActiveDirectoryPrincipal.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createactivedirectoryentry"></a>
# **CreateActiveDirectoryEntry**
> ActiveDirectoryEntry CreateActiveDirectoryEntry (ActiveDirectoryEntry body)

Join the Cohesity Cluster to the specified Active Directory.

After a Cohesity Cluster has been joined to an Active Directory domain, the users and groups in the domain can be authenticated on the Cohesity Cluster using their Active Directory credentials.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateActiveDirectoryEntryExample
    {
        public void main()
        {
            var apiInstance = new ActiveDirectoryApi();
            var body = new ActiveDirectoryEntry(); // ActiveDirectoryEntry | Request to join an Active Directory.

            try
            {
                // Join the Cohesity Cluster to the specified Active Directory.
                ActiveDirectoryEntry result = apiInstance.CreateActiveDirectoryEntry(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActiveDirectoryApi.CreateActiveDirectoryEntry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ActiveDirectoryEntry**](ActiveDirectoryEntry.md)| Request to join an Active Directory. | 

### Return type

[**ActiveDirectoryEntry**](ActiveDirectoryEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteactivedirectoryentry"></a>
# **DeleteActiveDirectoryEntry**
> void DeleteActiveDirectoryEntry (ActiveDirectoryEntry body)

Deletes the join with the Active Directory.

Deletes the join of the Cohesity Cluster to the specified Active Directory domain. After the deletion, the Cohesity Cluster no longer has access to the principals on the Active Directory. For example, you can no longer log in to the Cohesity Cluster with a user defined in a principal group of the Active Directory domain.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteActiveDirectoryEntryExample
    {
        public void main()
        {
            var apiInstance = new ActiveDirectoryApi();
            var body = new ActiveDirectoryEntry(); // ActiveDirectoryEntry | Request to delete a join with an Active Directory.

            try
            {
                // Deletes the join with the Active Directory.
                apiInstance.DeleteActiveDirectoryEntry(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActiveDirectoryApi.DeleteActiveDirectoryEntry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ActiveDirectoryEntry**](ActiveDirectoryEntry.md)| Request to delete a join with an Active Directory. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getactivedirectoryentry"></a>
# **GetActiveDirectoryEntry**
> List<ActiveDirectoryEntry> GetActiveDirectoryEntry ()

Lists the Active Directories that the Cohesity Cluster has joined.

After a Cohesity Cluster has been joined to an Active Directory domain, the users and groups in the domain can be authenticated on the Cohesity Cluster using their Active Directory credentials.  NOTE: The userName and password fields are not populated by this operation.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetActiveDirectoryEntryExample
    {
        public void main()
        {
            var apiInstance = new ActiveDirectoryApi();

            try
            {
                // Lists the Active Directories that the Cohesity Cluster has joined.
                List&lt;ActiveDirectoryEntry&gt; result = apiInstance.GetActiveDirectoryEntry();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActiveDirectoryApi.GetActiveDirectoryEntry: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ActiveDirectoryEntry>**](ActiveDirectoryEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcentrifyzones"></a>
# **ListCentrifyZones**
> List<ListCentrifyZone> ListCentrifyZones (string domainName = null)

Fetches the list centrify zones of an active directory domain.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListCentrifyZonesExample
    {
        public void main()
        {
            var apiInstance = new ActiveDirectoryApi();
            var domainName = domainName_example;  // string | Specifies the fully qualified domain name (FQDN) of an Active Directory. (optional) 

            try
            {
                // Fetches the list centrify zones of an active directory domain.
                List&lt;ListCentrifyZone&gt; result = apiInstance.ListCentrifyZones(domainName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActiveDirectoryApi.ListCentrifyZones: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **domainName** | **string**| Specifies the fully qualified domain name (FQDN) of an Active Directory. | [optional] 

### Return type

[**List<ListCentrifyZone>**](ListCentrifyZone.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchactivedirectoryprincipals"></a>
# **SearchActiveDirectoryPrincipals**
> List<ActiveDirectoryPrincipal> SearchActiveDirectoryPrincipals (string domain = null, string objectClass = null, string search = null, List<string> sids = null)

List the user and group principals in the Active Directory that match the filter criteria specified using parameters.

Optionally limit the search results by specifying security identifiers (SIDs), an object class (user or group) or a substring. You can specify SIDs or a substring but not both.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchActiveDirectoryPrincipalsExample
    {
        public void main()
        {
            var apiInstance = new ActiveDirectoryApi();
            var domain = domain_example;  // string | Specifies the domain name of the principals to search. If specified the principals in that domain are searched. Domain could be an Active Directory domain joined by the Cluster or any one of the trusted domains of the Active Directory domain or the LOCAL domain. If not specified, all the domains are searched. (optional) 
            var objectClass = objectClass_example;  // string | Optionally filter by a principal object class such as 'kGroup' or 'kUser'. If 'kGroup' is specified, only group principals are returned. If 'kUser' is specified, only user principals are returned. If not specified, both group and user principals are returned. 'kUser' specifies a user object class. 'kGroup' specifies a group object class. (optional) 
            var search = search_example;  // string | Optionally filter by matching a substring. Only principals in the with a name or sAMAccountName that matches part or all of the specified substring are returned. If specified, a 'sids' parameter should not be specified. (optional) 
            var sids = new List<string>(); // List<string> | Optionally filter by a list of security identifiers (SIDs) found in the specified domain. Only principals matching the specified SIDs are returned. If specified, a 'search' parameter should not be specified. (optional) 

            try
            {
                // List the user and group principals in the Active Directory that match the filter criteria specified using parameters.
                List&lt;ActiveDirectoryPrincipal&gt; result = apiInstance.SearchActiveDirectoryPrincipals(domain, objectClass, search, sids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActiveDirectoryApi.SearchActiveDirectoryPrincipals: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **domain** | **string**| Specifies the domain name of the principals to search. If specified the principals in that domain are searched. Domain could be an Active Directory domain joined by the Cluster or any one of the trusted domains of the Active Directory domain or the LOCAL domain. If not specified, all the domains are searched. | [optional] 
 **objectClass** | **string**| Optionally filter by a principal object class such as &#39;kGroup&#39; or &#39;kUser&#39;. If &#39;kGroup&#39; is specified, only group principals are returned. If &#39;kUser&#39; is specified, only user principals are returned. If not specified, both group and user principals are returned. &#39;kUser&#39; specifies a user object class. &#39;kGroup&#39; specifies a group object class. | [optional] 
 **search** | **string**| Optionally filter by matching a substring. Only principals in the with a name or sAMAccountName that matches part or all of the specified substring are returned. If specified, a &#39;sids&#39; parameter should not be specified. | [optional] 
 **sids** | [**List&lt;string&gt;**](string.md)| Optionally filter by a list of security identifiers (SIDs) found in the specified domain. Only principals matching the specified SIDs are returned. If specified, a &#39;search&#39; parameter should not be specified. | [optional] 

### Return type

[**List<ActiveDirectoryPrincipal>**](ActiveDirectoryPrincipal.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateactivedirectoryidmapping"></a>
# **UpdateActiveDirectoryIdMapping**
> ActiveDirectoryEntry UpdateActiveDirectoryIdMapping (IdMappingInfo body, string name)

Updates the user id mapping info of an Active Directory.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateActiveDirectoryIdMappingExample
    {
        public void main()
        {
            var apiInstance = new ActiveDirectoryApi();
            var body = new IdMappingInfo(); // IdMappingInfo | Request to update user id mapping of an Active Directory.
            var name = name_example;  // string | Specifies the Active Directory Domain Name.

            try
            {
                // Updates the user id mapping info of an Active Directory.
                ActiveDirectoryEntry result = apiInstance.UpdateActiveDirectoryIdMapping(body, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActiveDirectoryApi.UpdateActiveDirectoryIdMapping: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**IdMappingInfo**](IdMappingInfo.md)| Request to update user id mapping of an Active Directory. | 
 **name** | **string**| Specifies the Active Directory Domain Name. | 

### Return type

[**ActiveDirectoryEntry**](ActiveDirectoryEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateactivedirectorymachineaccounts"></a>
# **UpdateActiveDirectoryMachineAccounts**
> ActiveDirectoryEntry UpdateActiveDirectoryMachineAccounts (UpdateMachineAccountsParams body, string name)

Updates the machine accounts of an Active Directory.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateActiveDirectoryMachineAccountsExample
    {
        public void main()
        {
            var apiInstance = new ActiveDirectoryApi();
            var body = new UpdateMachineAccountsParams(); // UpdateMachineAccountsParams | Request to update machine accounts of an Active Directory.
            var name = name_example;  // string | Specifies the Active Directory Domain Name.

            try
            {
                // Updates the machine accounts of an Active Directory.
                ActiveDirectoryEntry result = apiInstance.UpdateActiveDirectoryMachineAccounts(body, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActiveDirectoryApi.UpdateActiveDirectoryMachineAccounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateMachineAccountsParams**](UpdateMachineAccountsParams.md)| Request to update machine accounts of an Active Directory. | 
 **name** | **string**| Specifies the Active Directory Domain Name. | 

### Return type

[**ActiveDirectoryEntry**](ActiveDirectoryEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# IO.Swagger.Api.PrincipalsApi

All URIs are relative to *https://localhost/irisservices/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateUser**](PrincipalsApi.md#createuser) | **POST** /public/users | Create or add a new user to the Cohesity Cluster.
[**DeleteUsers**](PrincipalsApi.md#deleteusers) | **DELETE** /public/users | Delete one or more users on the Cohesity Cluster.
[**GetUserPrivileges**](PrincipalsApi.md#getuserprivileges) | **GET** /public/users/privileges | List the privileges of the session user.
[**GetUsers**](PrincipalsApi.md#getusers) | **GET** /public/users | List the users on the Cohesity Cluster that match the filter criteria specified using parameters.
[**ListSourcesForPrincipals**](PrincipalsApi.md#listsourcesforprincipals) | **GET** /public/principals/protectionSources | Returns the Protection Sources objects and View names that the principals have permissions to access.
[**ResetS3SecretKey**](PrincipalsApi.md#resets3secretkey) | **POST** /public/users/s3SecretKey | Reset the S3 secret access key for the specified user on the Cohesity Cluster.
[**SearchPrincipals**](PrincipalsApi.md#searchprincipals) | **GET** /public/principals/searchPrincipals | List the user and group principals that match the filter criteria specified using parameters.
[**UpdateSourcesForPrincipals**](PrincipalsApi.md#updatesourcesforprincipals) | **PUT** /public/principals/protectionSources | Set the Protection Sources and Views that the specified principal has permissions to access.
[**UpdateUser**](PrincipalsApi.md#updateuser) | **PUT** /public/users | Update an existing user on the Cohesity Cluster. Only user settings on the Cohesity Cluster are updated. No changes are made to the referenced user principal on the Active Directory.


<a name="createuser"></a>
# **CreateUser**
> User CreateUser (UserParameters body = null)

Create or add a new user to the Cohesity Cluster.

If an Active Directory domain is specified, a new user is added to the Cohesity Cluster for the specified Active Directory user principal. If the LOCAL domain is specified, a new user is created directly in the default LOCAL domain on the Cohesity Cluster.  Returns the created or added user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateUserExample
    {
        public void main()
        {
            var apiInstance = new PrincipalsApi();
            var body = new UserParameters(); // UserParameters | Request to add or create a new user. (optional) 

            try
            {
                // Create or add a new user to the Cohesity Cluster.
                User result = apiInstance.CreateUser(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrincipalsApi.CreateUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserParameters**](UserParameters.md)| Request to add or create a new user. | [optional] 

### Return type

[**User**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteusers"></a>
# **DeleteUsers**
> void DeleteUsers (UserDeleteParameters body = null)

Delete one or more users on the Cohesity Cluster.

Only users from the same domain can be deleted by a single request. If the Cohesity user was created for an Active Directory user, the referenced principal user on the Active Directory domain is NOT deleted. Only the user on the Cohesity Cluster is deleted. Returns Success if the specified users are deleted.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteUsersExample
    {
        public void main()
        {
            var apiInstance = new PrincipalsApi();
            var body = new UserDeleteParameters(); // UserDeleteParameters | Request to delete one or more users on the Cohesity Cluster. (optional) 

            try
            {
                // Delete one or more users on the Cohesity Cluster.
                apiInstance.DeleteUsers(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrincipalsApi.DeleteUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserDeleteParameters**](UserDeleteParameters.md)| Request to delete one or more users on the Cohesity Cluster. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserprivileges"></a>
# **GetUserPrivileges**
> List<string> GetUserPrivileges ()

List the privileges of the session user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserPrivilegesExample
    {
        public void main()
        {
            var apiInstance = new PrincipalsApi();

            try
            {
                // List the privileges of the session user.
                List&lt;string&gt; result = apiInstance.GetUserPrivileges();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrincipalsApi.GetUserPrivileges: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusers"></a>
# **GetUsers**
> List<User> GetUsers (List<string> usernames = null, List<string> emailAddresses = null, string domain = null)

List the users on the Cohesity Cluster that match the filter criteria specified using parameters.

If no parameters are specified, all users currently on the Cohesity Cluster are returned. Specifying parameters filters the results that are returned.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUsersExample
    {
        public void main()
        {
            var apiInstance = new PrincipalsApi();
            var usernames = new List<string>(); // List<string> | Optionally specify a list of usernames to filter by. (optional) 
            var emailAddresses = new List<string>(); // List<string> | Optionally specify a list of email addresses to filter by. (optional) 
            var domain = domain_example;  // string | Optionally specify a domain to filter by. If no domain is specified, all users on the Cohesity Cluster are searched. If a domain is specified, only users on the Cohesity Cluster associated with that domain are searched. (optional) 

            try
            {
                // List the users on the Cohesity Cluster that match the filter criteria specified using parameters.
                List&lt;User&gt; result = apiInstance.GetUsers(usernames, emailAddresses, domain);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrincipalsApi.GetUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **usernames** | [**List&lt;string&gt;**](string.md)| Optionally specify a list of usernames to filter by. | [optional] 
 **emailAddresses** | [**List&lt;string&gt;**](string.md)| Optionally specify a list of email addresses to filter by. | [optional] 
 **domain** | **string**| Optionally specify a domain to filter by. If no domain is specified, all users on the Cohesity Cluster are searched. If a domain is specified, only users on the Cohesity Cluster associated with that domain are searched. | [optional] 

### Return type

[**List<User>**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsourcesforprincipals"></a>
# **ListSourcesForPrincipals**
> List<SourcesForSid> ListSourcesForPrincipals (List<string> sids = null)

Returns the Protection Sources objects and View names that the principals have permissions to access.

From the passed in list principals (specified by SIDs), return the list of Protection Sources objects and View names that each principal has permission to access.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListSourcesForPrincipalsExample
    {
        public void main()
        {
            var apiInstance = new PrincipalsApi();
            var sids = new List<string>(); // List<string> | Specifies a list of security identifiers (SIDs) that specify user or group principals. (optional) 

            try
            {
                // Returns the Protection Sources objects and View names that the principals have permissions to access.
                List&lt;SourcesForSid&gt; result = apiInstance.ListSourcesForPrincipals(sids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrincipalsApi.ListSourcesForPrincipals: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sids** | [**List&lt;string&gt;**](string.md)| Specifies a list of security identifiers (SIDs) that specify user or group principals. | [optional] 

### Return type

[**List<SourcesForSid>**](SourcesForSid.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resets3secretkey"></a>
# **ResetS3SecretKey**
> NewS3SecretAccessKey ResetS3SecretKey (ResetS3SecretKeyParameters body = null)

Reset the S3 secret access key for the specified user on the Cohesity Cluster.

Returns the new key that was generated.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ResetS3SecretKeyExample
    {
        public void main()
        {
            var apiInstance = new PrincipalsApi();
            var body = new ResetS3SecretKeyParameters(); // ResetS3SecretKeyParameters | Request to reset the S3 secret access key for the specified Cohesity user. (optional) 

            try
            {
                // Reset the S3 secret access key for the specified user on the Cohesity Cluster.
                NewS3SecretAccessKey result = apiInstance.ResetS3SecretKey(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrincipalsApi.ResetS3SecretKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ResetS3SecretKeyParameters**](ResetS3SecretKeyParameters.md)| Request to reset the S3 secret access key for the specified Cohesity user. | [optional] 

### Return type

[**NewS3SecretAccessKey**](NewS3SecretAccessKey.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchprincipals"></a>
# **SearchPrincipals**
> List<Principal> SearchPrincipals (string domain = null, string objectClass = null, string search = null, List<string> sids = null)

List the user and group principals that match the filter criteria specified using parameters.

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
    public class SearchPrincipalsExample
    {
        public void main()
        {
            var apiInstance = new PrincipalsApi();
            var domain = domain_example;  // string | Specifies the domain name of the principals to search. If specified the principals in that domain are searched. Domain could be an Active Directory domain joined by the Cluster or any one of the trusted domains of the Active Directory domain or the LOCAL domain. If not specified, all the domains are searched. (optional) 
            var objectClass = objectClass_example;  // string | Optionally filter by a principal object class such as 'kGroup' or 'kUser'. If 'kGroup' is specified, only group principals are returned. If 'kUser' is specified, only user principals are returned. If not specified, both group and user principals are returned. 'kUser' specifies a user object class. 'kGroup' specifies a group object class. (optional) 
            var search = search_example;  // string | Optionally filter by matching a substring. Only principals in the with a name or sAMAccountName that matches part or all of the specified substring are returned. If specified, a 'sids' parameter should not be specified. (optional) 
            var sids = new List<string>(); // List<string> | Optionally filter by a list of security identifiers (SIDs) found in the specified domain. Only principals matching the specified SIDs are returned. If specified, a 'search' parameter should not be specified. (optional) 

            try
            {
                // List the user and group principals that match the filter criteria specified using parameters.
                List&lt;Principal&gt; result = apiInstance.SearchPrincipals(domain, objectClass, search, sids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrincipalsApi.SearchPrincipals: " + e.Message );
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

[**List<Principal>**](Principal.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesourcesforprincipals"></a>
# **UpdateSourcesForPrincipals**
> void UpdateSourcesForPrincipals (UpdateSourcesForPrincipalsParams body)

Set the Protection Sources and Views that the specified principal has permissions to access.

Specify the security identifier (SID) of the principal to grant access permissions for.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateSourcesForPrincipalsExample
    {
        public void main()
        {
            var apiInstance = new PrincipalsApi();
            var body = new UpdateSourcesForPrincipalsParams(); // UpdateSourcesForPrincipalsParams | Request to set access permissions to Protection Sources and Views for a principal.

            try
            {
                // Set the Protection Sources and Views that the specified principal has permissions to access.
                apiInstance.UpdateSourcesForPrincipals(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrincipalsApi.UpdateSourcesForPrincipals: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateSourcesForPrincipalsParams**](UpdateSourcesForPrincipalsParams.md)| Request to set access permissions to Protection Sources and Views for a principal. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuser"></a>
# **UpdateUser**
> User UpdateUser (UserParameters body = null)

Update an existing user on the Cohesity Cluster. Only user settings on the Cohesity Cluster are updated. No changes are made to the referenced user principal on the Active Directory.

Returns the user that was updated on the Cohesity Cluster.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateUserExample
    {
        public void main()
        {
            var apiInstance = new PrincipalsApi();
            var body = new UserParameters(); // UserParameters | Request to update an existing user. (optional) 

            try
            {
                // Update an existing user on the Cohesity Cluster. Only user settings on the Cohesity Cluster are updated. No changes are made to the referenced user principal on the Active Directory.
                User result = apiInstance.UpdateUser(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrincipalsApi.UpdateUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserParameters**](UserParameters.md)| Request to update an existing user. | [optional] 

### Return type

[**User**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# IO.Swagger.Api.ViewsApi

All URIs are relative to *https://localhost/irisservices/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CloneDirectory**](ViewsApi.md#clonedirectory) | **POST** /public/views/cloneDirectory | Clone a directory of a view.
[**CloneView**](ViewsApi.md#cloneview) | **POST** /public/views/clone | Clone a View.
[**CreateView**](ViewsApi.md#createview) | **POST** /public/views | Create a View.
[**CreateViewAlias**](ViewsApi.md#createviewalias) | **POST** /public/viewAliases | Create a View Alias. A View Alias allows a directory inside the view to be mounted without specifying the entire path.
[**CreateViewUserQuota**](ViewsApi.md#createviewuserquota) | **POST** /public/viewUserQuotas | Create a new quota policy for a user in a view.
[**DeleteView**](ViewsApi.md#deleteview) | **DELETE** /public/views/{name} | Delete a View.
[**DeleteViewAlias**](ViewsApi.md#deleteviewalias) | **DELETE** /public/viewAliases/{name} | Delete a View Alias.
[**DeleteViewUsersQuota**](ViewsApi.md#deleteviewusersquota) | **DELETE** /public/viewUserQuotas | Delete the quota policy overrides for users in a view.
[**GetViewByName**](ViewsApi.md#getviewbyname) | **GET** /public/views/{name} | List details about a single View.
[**GetViewUserQuotas**](ViewsApi.md#getviewuserquotas) | **GET** /public/viewUserQuotas | Get the quota policies, usage and summary for a view for all its users. It can also fetch the quota policies, usage and summary for a user in all his views.
[**GetViews**](ViewsApi.md#getviews) | **GET** /public/views | List Views filtered by some parameters.
[**GetViewsByShareName**](ViewsApi.md#getviewsbysharename) | **GET** /public/shares | List shares filtered by name.
[**OverwriteView**](ViewsApi.md#overwriteview) | **POST** /public/views/overwrite | Overwrites a Target view with contents of a Source view.
[**RenameView**](ViewsApi.md#renameview) | **POST** /public/views/rename/{name} | Rename a View.
[**UpdateUserQuotaSettings**](ViewsApi.md#updateuserquotasettings) | **PUT** /public/viewUserQuotasSettings | Update the user quota settings in a view.
[**UpdateView**](ViewsApi.md#updateview) | **PUT** /public/views/{name} | Update a View.
[**UpdateViewUserQuota**](ViewsApi.md#updateviewuserquota) | **PUT** /public/viewUserQuotas | Update a new quota policy for a user in a view.


<a name="clonedirectory"></a>
# **CloneDirectory**
> void CloneDirectory (CloneDirectoryParams body)

Clone a directory of a view.

Returns error if op fails.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CloneDirectoryExample
    {
        public void main()
        {
            var apiInstance = new ViewsApi();
            var body = new CloneDirectoryParams(); // CloneDirectoryParams | Request to clone a directory.

            try
            {
                // Clone a directory of a view.
                apiInstance.CloneDirectory(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.CloneDirectory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CloneDirectoryParams**](CloneDirectoryParams.md)| Request to clone a directory. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cloneview"></a>
# **CloneView**
> View CloneView (CloneViewRequest body)

Clone a View.

Returns the cloned View.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CloneViewExample
    {
        public void main()
        {
            var apiInstance = new ViewsApi();
            var body = new CloneViewRequest(); // CloneViewRequest | Request to clone a View.

            try
            {
                // Clone a View.
                View result = apiInstance.CloneView(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.CloneView: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CloneViewRequest**](CloneViewRequest.md)| Request to clone a View. | 

### Return type

[**View**](View.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createview"></a>
# **CreateView**
> View CreateView (CreateViewRequest body)

Create a View.

Returns the created View.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateViewExample
    {
        public void main()
        {
            var apiInstance = new ViewsApi();
            var body = new CreateViewRequest(); // CreateViewRequest | Request to create a View.

            try
            {
                // Create a View.
                View result = apiInstance.CreateView(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.CreateView: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateViewRequest**](CreateViewRequest.md)| Request to create a View. | 

### Return type

[**View**](View.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createviewalias"></a>
# **CreateViewAlias**
> ViewAlias CreateViewAlias (ViewAlias body)

Create a View Alias. A View Alias allows a directory inside the view to be mounted without specifying the entire path.

Returns the created View Alias.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateViewAliasExample
    {
        public void main()
        {
            var apiInstance = new ViewsApi();
            var body = new ViewAlias(); // ViewAlias | Request to create a View.

            try
            {
                // Create a View Alias. A View Alias allows a directory inside the view to be mounted without specifying the entire path.
                ViewAlias result = apiInstance.CreateViewAlias(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.CreateViewAlias: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ViewAlias**](ViewAlias.md)| Request to create a View. | 

### Return type

[**ViewAlias**](ViewAlias.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createviewuserquota"></a>
# **CreateViewUserQuota**
> UserQuotaAndUsage CreateViewUserQuota (ViewUserQuotaParameters body = null)

Create a new quota policy for a user in a view.

Returns error if op fails.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateViewUserQuotaExample
    {
        public void main()
        {
            var apiInstance = new ViewsApi();
            var body = new ViewUserQuotaParameters(); // ViewUserQuotaParameters | update user quota params. (optional) 

            try
            {
                // Create a new quota policy for a user in a view.
                UserQuotaAndUsage result = apiInstance.CreateViewUserQuota(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.CreateViewUserQuota: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ViewUserQuotaParameters**](ViewUserQuotaParameters.md)| update user quota params. | [optional] 

### Return type

[**UserQuotaAndUsage**](UserQuotaAndUsage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteview"></a>
# **DeleteView**
> void DeleteView (string name)

Delete a View.

Returns delete status upon completion.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteViewExample
    {
        public void main()
        {
            var apiInstance = new ViewsApi();
            var name = name_example;  // string | Specifies the View name.

            try
            {
                // Delete a View.
                apiInstance.DeleteView(name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.DeleteView: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Specifies the View name. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteviewalias"></a>
# **DeleteViewAlias**
> void DeleteViewAlias (string name)

Delete a View Alias.

Returns delete status upon completion.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteViewAliasExample
    {
        public void main()
        {
            var apiInstance = new ViewsApi();
            var name = name_example;  // string | Specifies the View Alias name.

            try
            {
                // Delete a View Alias.
                apiInstance.DeleteViewAlias(name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.DeleteViewAlias: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Specifies the View Alias name. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteviewusersquota"></a>
# **DeleteViewUsersQuota**
> void DeleteViewUsersQuota (DeleteViewUsersQuotaParameters body = null)

Delete the quota policy overrides for users in a view.

Returns error if op fails.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteViewUsersQuotaExample
    {
        public void main()
        {
            var apiInstance = new ViewsApi();
            var body = new DeleteViewUsersQuotaParameters(); // DeleteViewUsersQuotaParameters | update user quota params. (optional) 

            try
            {
                // Delete the quota policy overrides for users in a view.
                apiInstance.DeleteViewUsersQuota(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.DeleteViewUsersQuota: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeleteViewUsersQuotaParameters**](DeleteViewUsersQuotaParameters.md)| update user quota params. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getviewbyname"></a>
# **GetViewByName**
> View GetViewByName (string name)

List details about a single View.

Returns the View corresponding to the specified View name.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetViewByNameExample
    {
        public void main()
        {
            var apiInstance = new ViewsApi();
            var name = name_example;  // string | Specifies the View name.

            try
            {
                // List details about a single View.
                View result = apiInstance.GetViewByName(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.GetViewByName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Specifies the View name. | 

### Return type

[**View**](View.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getviewuserquotas"></a>
# **GetViewUserQuotas**
> ViewUserQuotas GetViewUserQuotas (string viewName = null, bool? excludeUsersWithinAlertThreshold = null, int? unixUid = null, long? maxViewId = null, string cookie = null, string outputFormat = null, bool? includeUsage = null, string sid = null, bool? summaryOnly = null, long? pageCount = null)

Get the quota policies, usage and summary for a view for all its users. It can also fetch the quota policies, usage and summary for a user in all his views.

Returns error if op fails.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetViewUserQuotasExample
    {
        public void main()
        {
            var apiInstance = new ViewsApi();
            var viewName = viewName_example;  // string | Specifies the name of the input view. If given, there could be three scenarios with the viewName input parameter: It gives the user quota overrides for this view, and the user quota settings. Returns 'usersQuotaAndUsage'. If given along with the user id, it returns the quota policy for this user on this view. Returns 'usersQuotaAndUsage'. If given along with SummaryOnly as true, a user quota summary for this view would be returned. Returns 'summaryForView'. If not given, then the user id is checked. (optional) 
            var excludeUsersWithinAlertThreshold = true;  // bool? | This field can be set only when includeUsage is set to true. By default, all the users with logical usage > 0 will be returned in the result. If this field is set to true, only the list of users who has exceeded the alert threshold will be returned. (optional) 
            var unixUid = 56;  // int? | If interested in a user via unix-identifier, include UnixUid. Otherwise, If valid unix-id to SID mappings are available (i.e., when mixed mode is enabled) the server will perform the necessary id mapping and return the correct usage irrespective of whether the unix id / SID is provided. (optional) 
            var maxViewId = 789;  // long? | Related to fetching a particular user's quota and usage in all his views. It only pertains to the scenario where either UnixUid or Sid is specified, and ViewName is nil. Specify the maxViewId for All the views returned would have view_id's less than or equal to the given MaxViewId if it is >= 0. (optional) 
            var cookie = cookie_example;  // string | Cookie should be used from previous call to list user quota overrides. It resumes (or gives the next set of values) from the result of the previous call. (optional) 
            var outputFormat = outputFormat_example;  // string | OutputFormat is the Output format for the output. If it is not specified, default is json. (optional) 
            var includeUsage = true;  // bool? | If set to true, the logical usage info is included only for users with quota overrides. By default, it is set to false. (optional) 
            var sid = sid_example;  // string | If interested in a user via smb_client, include SID. Otherwise, If valid unix-id to SID mappings are available (i.e., when mixed mode is enabled) the server will perform the necessary id mapping and return the correct usage irrespective of whether the unix id / SID is provided. The string is of following format - S-1-IdentifierAuthority-SubAuthority1-SubAuthority2-...-SubAuthorityn. (optional) 
            var summaryOnly = true;  // bool? | Specifies a flag to just return a summary. If set to true, and if ViewName is not nil, it returns the summary of users for a view. Otherwise if UserId not nil, and ViewName is nil then it fetches the summary for a user in his views.  By default, it is set to false. (optional) 
            var pageCount = 789;  // long? | Specifies the max entries that should be returned in the result. (optional) 

            try
            {
                // Get the quota policies, usage and summary for a view for all its users. It can also fetch the quota policies, usage and summary for a user in all his views.
                ViewUserQuotas result = apiInstance.GetViewUserQuotas(viewName, excludeUsersWithinAlertThreshold, unixUid, maxViewId, cookie, outputFormat, includeUsage, sid, summaryOnly, pageCount);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.GetViewUserQuotas: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **viewName** | **string**| Specifies the name of the input view. If given, there could be three scenarios with the viewName input parameter: It gives the user quota overrides for this view, and the user quota settings. Returns &#39;usersQuotaAndUsage&#39;. If given along with the user id, it returns the quota policy for this user on this view. Returns &#39;usersQuotaAndUsage&#39;. If given along with SummaryOnly as true, a user quota summary for this view would be returned. Returns &#39;summaryForView&#39;. If not given, then the user id is checked. | [optional] 
 **excludeUsersWithinAlertThreshold** | **bool?**| This field can be set only when includeUsage is set to true. By default, all the users with logical usage &gt; 0 will be returned in the result. If this field is set to true, only the list of users who has exceeded the alert threshold will be returned. | [optional] 
 **unixUid** | **int?**| If interested in a user via unix-identifier, include UnixUid. Otherwise, If valid unix-id to SID mappings are available (i.e., when mixed mode is enabled) the server will perform the necessary id mapping and return the correct usage irrespective of whether the unix id / SID is provided. | [optional] 
 **maxViewId** | **long?**| Related to fetching a particular user&#39;s quota and usage in all his views. It only pertains to the scenario where either UnixUid or Sid is specified, and ViewName is nil. Specify the maxViewId for All the views returned would have view_id&#39;s less than or equal to the given MaxViewId if it is &gt;&#x3D; 0. | [optional] 
 **cookie** | **string**| Cookie should be used from previous call to list user quota overrides. It resumes (or gives the next set of values) from the result of the previous call. | [optional] 
 **outputFormat** | **string**| OutputFormat is the Output format for the output. If it is not specified, default is json. | [optional] 
 **includeUsage** | **bool?**| If set to true, the logical usage info is included only for users with quota overrides. By default, it is set to false. | [optional] 
 **sid** | **string**| If interested in a user via smb_client, include SID. Otherwise, If valid unix-id to SID mappings are available (i.e., when mixed mode is enabled) the server will perform the necessary id mapping and return the correct usage irrespective of whether the unix id / SID is provided. The string is of following format - S-1-IdentifierAuthority-SubAuthority1-SubAuthority2-...-SubAuthorityn. | [optional] 
 **summaryOnly** | **bool?**| Specifies a flag to just return a summary. If set to true, and if ViewName is not nil, it returns the summary of users for a view. Otherwise if UserId not nil, and ViewName is nil then it fetches the summary for a user in his views.  By default, it is set to false. | [optional] 
 **pageCount** | **long?**| Specifies the max entries that should be returned in the result. | [optional] 

### Return type

[**ViewUserQuotas**](ViewUserQuotas.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getviews"></a>
# **GetViews**
> GetViewsResult GetViews (bool? includeInactive = null, bool? matchAliasNames = null, List<string> viewNames = null, List<long?> viewBoxIds = null, List<string> viewBoxNames = null, bool? matchPartialNames = null, int? maxCount = null, long? maxViewId = null, List<long?> jobIds = null, bool? sortByLogicalUsage = null)

List Views filtered by some parameters.

If no parameters are specified, all Views on the Cohesity Cluster are returned. Specifying parameters filters the results that are returned. NOTE: If maxCount is set and the number of Views returned exceeds the maxCount, there are more Views to return. To get the next set of Views, send another request and specify the id of the last View returned in viewList from the previous response.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetViewsExample
    {
        public void main()
        {
            var apiInstance = new ViewsApi();
            var includeInactive = true;  // bool? | Specifies if inactive Views on this Remote Cluster (which have Snapshots copied by replication) should also be returned. Inactive Views are not counted towards the maxCount. By default, this field is set to false. (optional) 
            var matchAliasNames = true;  // bool? | If true, view aliases are also matched with the names in viewNames. (optional) 
            var viewNames = new List<string>(); // List<string> | Filter by a list of View names. (optional) 
            var viewBoxIds = new List<long?>(); // List<long?> | Filter by a list of Storage Domains (View Boxes) specified by id. (optional) 
            var viewBoxNames = new List<string>(); // List<string> | Filter by a list of View Box names. (optional) 
            var matchPartialNames = true;  // bool? | If true, the names in viewNames are matched by prefix rather than exactly matched. (optional) 
            var maxCount = 56;  // int? | Specifies a limit on the number of Views returned. (optional) 
            var maxViewId = 789;  // long? | If the number of Views to return exceeds the maxCount specified in the original request, specify the id of the last View from the viewList in the previous response to get the next set of Views. (optional) 
            var jobIds = new List<long?>(); // List<long?> | Filter by Protection Job ids. Return Views that are being protected by listed Jobs, which are specified by ids. (optional) 
            var sortByLogicalUsage = true;  // bool? | If set to true, the list is sorted descending by logical usage. (optional) 

            try
            {
                // List Views filtered by some parameters.
                GetViewsResult result = apiInstance.GetViews(includeInactive, matchAliasNames, viewNames, viewBoxIds, viewBoxNames, matchPartialNames, maxCount, maxViewId, jobIds, sortByLogicalUsage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.GetViews: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **includeInactive** | **bool?**| Specifies if inactive Views on this Remote Cluster (which have Snapshots copied by replication) should also be returned. Inactive Views are not counted towards the maxCount. By default, this field is set to false. | [optional] 
 **matchAliasNames** | **bool?**| If true, view aliases are also matched with the names in viewNames. | [optional] 
 **viewNames** | [**List&lt;string&gt;**](string.md)| Filter by a list of View names. | [optional] 
 **viewBoxIds** | [**List&lt;long?&gt;**](long?.md)| Filter by a list of Storage Domains (View Boxes) specified by id. | [optional] 
 **viewBoxNames** | [**List&lt;string&gt;**](string.md)| Filter by a list of View Box names. | [optional] 
 **matchPartialNames** | **bool?**| If true, the names in viewNames are matched by prefix rather than exactly matched. | [optional] 
 **maxCount** | **int?**| Specifies a limit on the number of Views returned. | [optional] 
 **maxViewId** | **long?**| If the number of Views to return exceeds the maxCount specified in the original request, specify the id of the last View from the viewList in the previous response to get the next set of Views. | [optional] 
 **jobIds** | [**List&lt;long?&gt;**](long?.md)| Filter by Protection Job ids. Return Views that are being protected by listed Jobs, which are specified by ids. | [optional] 
 **sortByLogicalUsage** | **bool?**| If set to true, the list is sorted descending by logical usage. | [optional] 

### Return type

[**GetViewsResult**](GetViewsResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getviewsbysharename"></a>
# **GetViewsByShareName**
> GetViewsByShareNameResult GetViewsByShareName (string shareName = null, int? maxCount = null, string paginationCookie = null)

List shares filtered by name.

If no parameters are specified, all shares on the Cohesity Cluster are returned. Specifying share name/prefix filters the results that are returned. NOTE: If maxCount is set and the number of Views returned exceeds the maxCount, there are more Views to return. To get the next set of Views, send another request and specify the pagination cookie from the previous response.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetViewsByShareNameExample
    {
        public void main()
        {
            var apiInstance = new ViewsApi();
            var shareName = shareName_example;  // string | The share name(substring) that needs to be searched against existing views and aliases. (optional) 
            var maxCount = 56;  // int? | Specifies a limit on the number of Views returned. (optional) 
            var paginationCookie = paginationCookie_example;  // string | Expected to be empty in the first call to GetViewsByShareName. To get the next set of results, set this value to the pagination cookie value returned  in the response of the previous call. (optional) 

            try
            {
                // List shares filtered by name.
                GetViewsByShareNameResult result = apiInstance.GetViewsByShareName(shareName, maxCount, paginationCookie);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.GetViewsByShareName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shareName** | **string**| The share name(substring) that needs to be searched against existing views and aliases. | [optional] 
 **maxCount** | **int?**| Specifies a limit on the number of Views returned. | [optional] 
 **paginationCookie** | **string**| Expected to be empty in the first call to GetViewsByShareName. To get the next set of results, set this value to the pagination cookie value returned  in the response of the previous call. | [optional] 

### Return type

[**GetViewsByShareNameResult**](GetViewsByShareNameResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="overwriteview"></a>
# **OverwriteView**
> View OverwriteView (OverwriteViewParam body)

Overwrites a Target view with contents of a Source view.

Specifies source and target view names as params. Returns the modified Target View.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OverwriteViewExample
    {
        public void main()
        {
            var apiInstance = new ViewsApi();
            var body = new OverwriteViewParam(); // OverwriteViewParam | Request to overwrite a Target view with contents of a Source view.

            try
            {
                // Overwrites a Target view with contents of a Source view.
                View result = apiInstance.OverwriteView(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.OverwriteView: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OverwriteViewParam**](OverwriteViewParam.md)| Request to overwrite a Target view with contents of a Source view. | 

### Return type

[**View**](View.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="renameview"></a>
# **RenameView**
> View RenameView (RenameViewParam body, string name)

Rename a View.

Specify original name of the View in the 'name' parameter. Returns the renamed View.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RenameViewExample
    {
        public void main()
        {
            var apiInstance = new ViewsApi();
            var body = new RenameViewParam(); // RenameViewParam | Request to rename a View.
            var name = name_example;  // string | Specifies the View name.

            try
            {
                // Rename a View.
                View result = apiInstance.RenameView(body, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.RenameView: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RenameViewParam**](RenameViewParam.md)| Request to rename a View. | 
 **name** | **string**| Specifies the View name. | 

### Return type

[**View**](View.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuserquotasettings"></a>
# **UpdateUserQuotaSettings**
> UserQuotaSettings UpdateUserQuotaSettings (UpdateUserQuotaSettingsForView body = null)

Update the user quota settings in a view.

Returns error if op fails.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateUserQuotaSettingsExample
    {
        public void main()
        {
            var apiInstance = new ViewsApi();
            var body = new UpdateUserQuotaSettingsForView(); // UpdateUserQuotaSettingsForView | update user quota metadata params. (optional) 

            try
            {
                // Update the user quota settings in a view.
                UserQuotaSettings result = apiInstance.UpdateUserQuotaSettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.UpdateUserQuotaSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateUserQuotaSettingsForView**](UpdateUserQuotaSettingsForView.md)| update user quota metadata params. | [optional] 

### Return type

[**UserQuotaSettings**](UserQuotaSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateview"></a>
# **UpdateView**
> View UpdateView (string name, UpdateViewParam body)

Update a View.

Returns the updated View.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateViewExample
    {
        public void main()
        {
            var apiInstance = new ViewsApi();
            var name = name_example;  // string | Specifies the View name.
            var body = new UpdateViewParam(); // UpdateViewParam | Request to update a view.

            try
            {
                // Update a View.
                View result = apiInstance.UpdateView(name, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.UpdateView: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Specifies the View name. | 
 **body** | [**UpdateViewParam**](UpdateViewParam.md)| Request to update a view. | 

### Return type

[**View**](View.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateviewuserquota"></a>
# **UpdateViewUserQuota**
> UserQuotaAndUsage UpdateViewUserQuota (ViewUserQuotaParameters body = null)

Update a new quota policy for a user in a view.

Returns error if op fails.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateViewUserQuotaExample
    {
        public void main()
        {
            var apiInstance = new ViewsApi();
            var body = new ViewUserQuotaParameters(); // ViewUserQuotaParameters | update user quota params. (optional) 

            try
            {
                // Update a new quota policy for a user in a view.
                UserQuotaAndUsage result = apiInstance.UpdateViewUserQuota(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.UpdateViewUserQuota: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ViewUserQuotaParameters**](ViewUserQuotaParameters.md)| update user quota params. | [optional] 

### Return type

[**UserQuotaAndUsage**](UserQuotaAndUsage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# IO.Swagger.Api.PreferencesApi

All URIs are relative to *https://localhost/irisservices/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetUserPreferences**](PreferencesApi.md#getuserpreferences) | **GET** /public/sessionUser/preferences | List the preferences of the session user.
[**UpdateUserPreferences**](PreferencesApi.md#updateuserpreferences) | **PUT** /public/sessionUser/preferences | Update the preferences of the session user


<a name="getuserpreferences"></a>
# **GetUserPreferences**
> List<UserPreferencesProtoUserPreferencesPreference> GetUserPreferences ()

List the preferences of the session user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserPreferencesExample
    {
        public void main()
        {
            var apiInstance = new PreferencesApi();

            try
            {
                // List the preferences of the session user.
                List&lt;UserPreferencesProtoUserPreferencesPreference&gt; result = apiInstance.GetUserPreferences();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PreferencesApi.GetUserPreferences: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<UserPreferencesProtoUserPreferencesPreference>**](UserPreferencesProtoUserPreferencesPreference.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuserpreferences"></a>
# **UpdateUserPreferences**
> List<UserPreferencesProtoUserPreferencesPreference> UpdateUserPreferences (List<UserPreferencesProtoUserPreferencesPreference> body = null)

Update the preferences of the session user

Returns the updated user preferences.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateUserPreferencesExample
    {
        public void main()
        {
            var apiInstance = new PreferencesApi();
            var body = new List<UserPreferencesProtoUserPreferencesPreference>(); // List<UserPreferencesProtoUserPreferencesPreference> | Request to create or update User Preferences (optional) 

            try
            {
                // Update the preferences of the session user
                List&lt;UserPreferencesProtoUserPreferencesPreference&gt; result = apiInstance.UpdateUserPreferences(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PreferencesApi.UpdateUserPreferences: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;UserPreferencesProtoUserPreferencesPreference&gt;**](UserPreferencesProtoUserPreferencesPreference.md)| Request to create or update User Preferences | [optional] 

### Return type

[**List<UserPreferencesProtoUserPreferencesPreference>**](UserPreferencesProtoUserPreferencesPreference.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


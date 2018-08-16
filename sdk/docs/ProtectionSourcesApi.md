# IO.Swagger.Api.ProtectionSourcesApi

All URIs are relative to *https://localhost/irisservices/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetProtectionSourcesObjectById**](ProtectionSourcesApi.md#getprotectionsourcesobjectbyid) | **GET** /public/protectionSources/objects/{id} | Get details about a single Protection Source Object.
[**GetProtectionSourcesObjects**](ProtectionSourcesApi.md#getprotectionsourcesobjects) | **GET** /public/protectionSources/objects | List details about Protection Source objects.
[**ListApplicationServers**](ProtectionSourcesApi.md#listapplicationservers) | **GET** /public/protectionSources/applicationServers | Returns the registered Application Servers and their Object subtrees.
[**ListProtectedVms**](ProtectionSourcesApi.md#listprotectedvms) | **GET** /public/protectionSources/protectedVms | Returns the list of protected VMs in a registered Protection Source tree.
[**ListProtectionSources**](ProtectionSourcesApi.md#listprotectionsources) | **GET** /public/protectionSources | Returns the registered Protection Sources and their Object subtrees.
[**ListProtectionSourcesRegistrationInfo**](ProtectionSourcesApi.md#listprotectionsourcesregistrationinfo) | **GET** /public/protectionSources/registrationInfo | 
[**ListProtectionSourcesRootNodes**](ProtectionSourcesApi.md#listprotectionsourcesrootnodes) | **GET** /public/protectionSources/rootNodes | Returns the top level (root) Protection Sources with registration information.
[**ListSqlAagHostsAndDatabases**](ProtectionSourcesApi.md#listsqlaaghostsanddatabases) | **GET** /public/protectionSources/sqlAagHostsAndDatabases | Returns the registered Protection Sources and their Object subtrees.
[**ListVirtualMachines**](ProtectionSourcesApi.md#listvirtualmachines) | **GET** /public/protectionSources/virtualMachines | Returns the Virtual Machines in a vCenter Server.
[**RefreshProtectionSourceById**](ProtectionSourcesApi.md#refreshprotectionsourcebyid) | **POST** /public/protectionSources/refresh/{id} | Refresh the Object hierarchy of the Protection Sources tree.
[**RegisterApplicationServers**](ProtectionSourcesApi.md#registerapplicationservers) | **POST** /public/protectionSources/applicationServers | Register a Protection Source as running one or more Application Servers like Microsoft SQL servers or Microsoft Exchange servers.
[**RegisterProtectionSource**](ProtectionSourcesApi.md#registerprotectionsource) | **POST** /public/protectionSources/register | Register a Protection Source.
[**UnregisterApplicationServers**](ProtectionSourcesApi.md#unregisterapplicationservers) | **DELETE** /public/protectionSources/applicationServers/{id} | Unregister Application Servers like Microsoft SQL servers or Microsoft Exchange servers running on a Protection Source.
[**UpdateApplicationServers**](ProtectionSourcesApi.md#updateapplicationservers) | **PUT** /public/protectionSources/applicationServers | Modifies the registration parameters of Application Servers in a Protection Source.
[**UpgradePhysicalAgents**](ProtectionSourcesApi.md#upgradephysicalagents) | **POST** /public/physicalAgents/upgrade | Initiate a request to upgrade Cohesity agents on one or more Physical Servers registered on the Cohesity Cluster.


<a name="getprotectionsourcesobjectbyid"></a>
# **GetProtectionSourcesObjectById**
> ProtectionSource GetProtectionSourcesObjectById (long? id)

Get details about a single Protection Source Object.

Returns the Protection Source object corresponding to the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProtectionSourcesObjectByIdExample
    {
        public void main()
        {
            var apiInstance = new ProtectionSourcesApi();
            var id = 789;  // long? | Specifies a unique id of the Protection Source to return.

            try
            {
                // Get details about a single Protection Source Object.
                ProtectionSource result = apiInstance.GetProtectionSourcesObjectById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtectionSourcesApi.GetProtectionSourcesObjectById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Specifies a unique id of the Protection Source to return. | 

### Return type

[**ProtectionSource**](ProtectionSource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprotectionsourcesobjects"></a>
# **GetProtectionSourcesObjects**
> List<ProtectionSource> GetProtectionSourcesObjects (List<long?> objectIds = null)

List details about Protection Source objects.

Returns the Protection Source objects corresponding to the specified ids.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProtectionSourcesObjectsExample
    {
        public void main()
        {
            var apiInstance = new ProtectionSourcesApi();
            var objectIds = new List<long?>(); // List<long?> | Specifies the ids of the Protection Source objects to return. (optional) 

            try
            {
                // List details about Protection Source objects.
                List&lt;ProtectionSource&gt; result = apiInstance.GetProtectionSourcesObjects(objectIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtectionSourcesApi.GetProtectionSourcesObjects: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **objectIds** | [**List&lt;long?&gt;**](long?.md)| Specifies the ids of the Protection Source objects to return. | [optional] 

### Return type

[**List<ProtectionSource>**](ProtectionSource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listapplicationservers"></a>
# **ListApplicationServers**
> List<RegisteredApplicationServer> ListApplicationServers (long? protectionSourcesRootNodeId = null, string environment = null, string application = null)

Returns the registered Application Servers and their Object subtrees.

Given the root node id of a Protection Source tree, returns the list of Application Servers registered under that tree based on the filters.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListApplicationServersExample
    {
        public void main()
        {
            var apiInstance = new ProtectionSourcesApi();
            var protectionSourcesRootNodeId = 789;  // long? | Specifies the Protection Source Id of the root node of a Protection Sources tree. A root node represents a registered Source on the Cohesity Cluster, such as a vCenter Server. (optional) 
            var environment = environment_example;  // string | Specifies the environment such as 'kPhysical' or 'kVMware' of the Protection Source tree. overrideDescription: true Supported environment types include 'kView', 'kSQL', 'kVMware', 'kPuppeteer', 'kPhysical', 'kPure', 'kNetapp, 'kGenericNas, 'kHyperV', 'kAcropolis', 'kAzure'. NOTE: 'kPuppeteer' refers to Cohesity's Remote Adapter. (optional) 
            var application = application_example;  // string | Specifies the application such as 'kSQL', 'kExchange' running on the Protection Source. overrideDescription: true Supported environment types include 'kView', 'kSQL', 'kVMware', 'kPuppeteer', 'kPhysical', 'kPure', 'kNetapp, 'kGenericNas, 'kHyperV', 'kAcropolis', 'kAzure'. NOTE: 'kPuppeteer' refers to Cohesity's Remote Adapter. (optional) 

            try
            {
                // Returns the registered Application Servers and their Object subtrees.
                List&lt;RegisteredApplicationServer&gt; result = apiInstance.ListApplicationServers(protectionSourcesRootNodeId, environment, application);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtectionSourcesApi.ListApplicationServers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **protectionSourcesRootNodeId** | **long?**| Specifies the Protection Source Id of the root node of a Protection Sources tree. A root node represents a registered Source on the Cohesity Cluster, such as a vCenter Server. | [optional] 
 **environment** | **string**| Specifies the environment such as &#39;kPhysical&#39; or &#39;kVMware&#39; of the Protection Source tree. overrideDescription: true Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. | [optional] 
 **application** | **string**| Specifies the application such as &#39;kSQL&#39;, &#39;kExchange&#39; running on the Protection Source. overrideDescription: true Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. | [optional] 

### Return type

[**List<RegisteredApplicationServer>**](RegisteredApplicationServer.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listprotectedvms"></a>
# **ListProtectedVms**
> List<ProtectedVmInfo> ListProtectedVms (string environment, long? id)

Returns the list of protected VMs in a registered Protection Source tree.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListProtectedVmsExample
    {
        public void main()
        {
            var apiInstance = new ProtectionSourcesApi();
            var environment = environment_example;  // string | Specifies the environment type of the registered Protection Source such as 'kVMware', 'kSQL', 'kView' 'kPhysical', 'kPuppeteer', 'kPure', 'kNetapp', 'kGenericNas', 'kHyperV', 'kAcropolis', or 'kAzure'. For example, set this parameter to 'kVMware' if the registered Protection Source is of 'kVMware' environment type. Supported environment types include 'kView', 'kSQL', 'kVMware', 'kPuppeteer', 'kPhysical', 'kPure', 'kNetapp, 'kGenericNas, 'kHyperV', 'kAcropolis', 'kAzure'. NOTE: 'kPuppeteer' refers to Cohesity's Remote Adapter.
            var id = 789;  // long? | Specifies the Id of a registered Protection Source of the type given in environment.

            try
            {
                // Returns the list of protected VMs in a registered Protection Source tree.
                List&lt;ProtectedVmInfo&gt; result = apiInstance.ListProtectedVms(environment, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtectionSourcesApi.ListProtectedVms: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **environment** | **string**| Specifies the environment type of the registered Protection Source such as &#39;kVMware&#39;, &#39;kSQL&#39;, &#39;kView&#39; &#39;kPhysical&#39;, &#39;kPuppeteer&#39;, &#39;kPure&#39;, &#39;kNetapp&#39;, &#39;kGenericNas&#39;, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, or &#39;kAzure&#39;. For example, set this parameter to &#39;kVMware&#39; if the registered Protection Source is of &#39;kVMware&#39; environment type. Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. | 
 **id** | **long?**| Specifies the Id of a registered Protection Source of the type given in environment. | 

### Return type

[**List<ProtectedVmInfo>**](ProtectedVmInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listprotectionsources"></a>
# **ListProtectionSources**
> List<ProtectionSourceNode> ListProtectionSources (bool? includeDatastores = null, bool? includeNetworks = null, bool? includeVMFolders = null, List<string> environments = null, string environment = null, long? id = null, List<string> excludeTypes = null)

Returns the registered Protection Sources and their Object subtrees.

If no parameters are specified, all Protection Sources that are registered on the Cohesity Cluster are returned. In addition, an Object subtree gathered from each Source is returned. For example, the Cohesity Cluster interrogates a Source VMware vCenter Server and creates an hierarchical Object subtree that mirrors the Inventory tree on vCenter Server. The contents of the Object tree is returned as a \"nodes\" hierarchy of \"protectionSource\"s. Specifying parameters can alter the results that are returned.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListProtectionSourcesExample
    {
        public void main()
        {
            var apiInstance = new ProtectionSourcesApi();
            var includeDatastores = true;  // bool? | Set this parameter to true to also return kDatastore object types found in the Source in addition to their Object subtrees. By default, datastores are not returned. (optional) 
            var includeNetworks = true;  // bool? | Set this parameter to true to also return kNetwork object types found in the Source in addition to their Object subtrees. By default, network objects are not returned. (optional) 
            var includeVMFolders = true;  // bool? | Set this parameter to true to also return kVMFolder object types found in the Source in addition to their Object subtrees. By default, VM folder objects are not returned. (optional) 
            var environments = environments_example;  // List<string> | Return only Protection Sources that match the passed in environment type such as 'kVMware', 'kSQL', 'kView' 'kPhysical', 'kPuppeteer', 'kPure', 'kNetapp', 'kGenericNas', 'kHyperV', 'kAcropolis', or 'kAzure'. For example, set this parameter to 'kVMware' to only return the Sources (and their Object subtrees) found in the 'kVMware' (VMware vCenter Server) environment.  NOTE: 'kPuppeteer' refers to Cohesity's Remote Adapter. (optional) 
            var environment = environment_example;  // string | This field is deprecated. Use environments instead. deprecated: true (optional) 
            var id = 789;  // long? | Return the Object subtree for the passed in Protection Source id. (optional) 
            var excludeTypes = excludeTypes_example;  // List<string> | Filter out the Object types (and their subtrees) that match the passed in types such as 'kVCenter', 'kFolder', 'kDatacenter', 'kComputeResource', 'kResourcePool', 'kDatastore', 'kHostSystem', 'kVirtualMachine', etc. For example, set this parameter to 'kResourcePool' to exclude Resource Pool Objects from being returned. (optional) 

            try
            {
                // Returns the registered Protection Sources and their Object subtrees.
                List&lt;ProtectionSourceNode&gt; result = apiInstance.ListProtectionSources(includeDatastores, includeNetworks, includeVMFolders, environments, environment, id, excludeTypes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtectionSourcesApi.ListProtectionSources: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **includeDatastores** | **bool?**| Set this parameter to true to also return kDatastore object types found in the Source in addition to their Object subtrees. By default, datastores are not returned. | [optional] 
 **includeNetworks** | **bool?**| Set this parameter to true to also return kNetwork object types found in the Source in addition to their Object subtrees. By default, network objects are not returned. | [optional] 
 **includeVMFolders** | **bool?**| Set this parameter to true to also return kVMFolder object types found in the Source in addition to their Object subtrees. By default, VM folder objects are not returned. | [optional] 
 **environments** | **List&lt;string&gt;**| Return only Protection Sources that match the passed in environment type such as &#39;kVMware&#39;, &#39;kSQL&#39;, &#39;kView&#39; &#39;kPhysical&#39;, &#39;kPuppeteer&#39;, &#39;kPure&#39;, &#39;kNetapp&#39;, &#39;kGenericNas&#39;, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, or &#39;kAzure&#39;. For example, set this parameter to &#39;kVMware&#39; to only return the Sources (and their Object subtrees) found in the &#39;kVMware&#39; (VMware vCenter Server) environment.  NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. | [optional] 
 **environment** | **string**| This field is deprecated. Use environments instead. deprecated: true | [optional] 
 **id** | **long?**| Return the Object subtree for the passed in Protection Source id. | [optional] 
 **excludeTypes** | **List&lt;string&gt;**| Filter out the Object types (and their subtrees) that match the passed in types such as &#39;kVCenter&#39;, &#39;kFolder&#39;, &#39;kDatacenter&#39;, &#39;kComputeResource&#39;, &#39;kResourcePool&#39;, &#39;kDatastore&#39;, &#39;kHostSystem&#39;, &#39;kVirtualMachine&#39;, etc. For example, set this parameter to &#39;kResourcePool&#39; to exclude Resource Pool Objects from being returned. | [optional] 

### Return type

[**List<ProtectionSourceNode>**](ProtectionSourceNode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listprotectionsourcesregistrationinfo"></a>
# **ListProtectionSourcesRegistrationInfo**
> GetRegistrationInfoResponse ListProtectionSourcesRegistrationInfo (List<string> viewNames = null, List<string> environments = null, List<long?> ids = null)



Returns the registration and protection information of the registered Protection Sources.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListProtectionSourcesRegistrationInfoExample
    {
        public void main()
        {
            var apiInstance = new ProtectionSourcesApi();
            var viewNames = new List<string>(); // List<string> | Return only the Views whose names are specified in the list. (optional) 
            var environments = environments_example;  // List<string> | Return only Protection Sources that match the passed in environment type such as 'kVMware', 'kSQL', 'kView' 'kPhysical', 'kPuppeteer', 'kPure', 'kNetapp', 'kGenericNas', 'kHyperV', 'kAcropolis', or 'kAzure'. For example, set this parameter to 'kVMware' to only return the Sources (and their Object subtrees) found in the 'kVMware' (VMware vCenter Server) environment.  NOTE: 'kPuppeteer' refers to Cohesity's Remote Adapter. (optional) 
            var ids = new List<long?>(); // List<long?> | Return only the registered root nodes whose Ids are given in the list. (optional) 

            try
            {
                GetRegistrationInfoResponse result = apiInstance.ListProtectionSourcesRegistrationInfo(viewNames, environments, ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtectionSourcesApi.ListProtectionSourcesRegistrationInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **viewNames** | [**List&lt;string&gt;**](string.md)| Return only the Views whose names are specified in the list. | [optional] 
 **environments** | **List&lt;string&gt;**| Return only Protection Sources that match the passed in environment type such as &#39;kVMware&#39;, &#39;kSQL&#39;, &#39;kView&#39; &#39;kPhysical&#39;, &#39;kPuppeteer&#39;, &#39;kPure&#39;, &#39;kNetapp&#39;, &#39;kGenericNas&#39;, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, or &#39;kAzure&#39;. For example, set this parameter to &#39;kVMware&#39; to only return the Sources (and their Object subtrees) found in the &#39;kVMware&#39; (VMware vCenter Server) environment.  NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. | [optional] 
 **ids** | [**List&lt;long?&gt;**](long?.md)| Return only the registered root nodes whose Ids are given in the list. | [optional] 

### Return type

[**GetRegistrationInfoResponse**](GetRegistrationInfoResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listprotectionsourcesrootnodes"></a>
# **ListProtectionSourcesRootNodes**
> List<ProtectionSourceNode> ListProtectionSourcesRootNodes (long? id = null, List<string> environments = null, string environment = null)

Returns the top level (root) Protection Sources with registration information.

Returns the root Protection Sources and the registration information for each of these Sources.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListProtectionSourcesRootNodesExample
    {
        public void main()
        {
            var apiInstance = new ProtectionSourcesApi();
            var id = 789;  // long? | Return the registration information for the Protection Source id. (optional) 
            var environments = environments_example;  // List<string> | Return only the root Protection Sources that match the passed in environment type such as 'kVMware', 'kSQL', 'kView', 'kPuppeteer', 'kPhysical', 'kPure', 'kNetapp', 'kGenericNas', 'kHyperV', 'kAcropolis' 'kAzure'. For example, set this parameter to 'kVMware' to only return the root Protection Sources found in the 'kVMware' (VMware vCenter) environment. In addition, the registration information for each Source is returned.  NOTE: 'kPuppeteer' refers to Cohesity's Remote Adapter. (optional) 
            var environment = environment_example;  // string | This field is deprecated. Use environments instead. deprecated: true (optional) 

            try
            {
                // Returns the top level (root) Protection Sources with registration information.
                List&lt;ProtectionSourceNode&gt; result = apiInstance.ListProtectionSourcesRootNodes(id, environments, environment);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtectionSourcesApi.ListProtectionSourcesRootNodes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Return the registration information for the Protection Source id. | [optional] 
 **environments** | **List&lt;string&gt;**| Return only the root Protection Sources that match the passed in environment type such as &#39;kVMware&#39;, &#39;kSQL&#39;, &#39;kView&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp&#39;, &#39;kGenericNas&#39;, &#39;kHyperV&#39;, &#39;kAcropolis&#39; &#39;kAzure&#39;. For example, set this parameter to &#39;kVMware&#39; to only return the root Protection Sources found in the &#39;kVMware&#39; (VMware vCenter) environment. In addition, the registration information for each Source is returned.  NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. | [optional] 
 **environment** | **string**| This field is deprecated. Use environments instead. deprecated: true | [optional] 

### Return type

[**List<ProtectionSourceNode>**](ProtectionSourceNode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsqlaaghostsanddatabases"></a>
# **ListSqlAagHostsAndDatabases**
> List<SqlAagHostAndDatabases> ListSqlAagHostsAndDatabases (List<long?> sqlProtectionSourceIds)

Returns the registered Protection Sources and their Object subtrees.

Given a list of Protection Source Ids registered as SQL servers, returns AAGs found and the databases in AAG(Always on Availablity Group).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListSqlAagHostsAndDatabasesExample
    {
        public void main()
        {
            var apiInstance = new ProtectionSourcesApi();
            var sqlProtectionSourceIds = new List<long?>(); // List<long?> | Specifies a list of Ids of Protection Sources registered as SQL servers. These sources may have one or more SQL databases in them. Some of them may be part of AAGs(Always on Availability Group).

            try
            {
                // Returns the registered Protection Sources and their Object subtrees.
                List&lt;SqlAagHostAndDatabases&gt; result = apiInstance.ListSqlAagHostsAndDatabases(sqlProtectionSourceIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtectionSourcesApi.ListSqlAagHostsAndDatabases: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sqlProtectionSourceIds** | [**List&lt;long?&gt;**](long?.md)| Specifies a list of Ids of Protection Sources registered as SQL servers. These sources may have one or more SQL databases in them. Some of them may be part of AAGs(Always on Availability Group). | 

### Return type

[**List<SqlAagHostAndDatabases>**](SqlAagHostAndDatabases.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listvirtualmachines"></a>
# **ListVirtualMachines**
> List<ProtectionSource> ListVirtualMachines (long? vCenterId = null, List<string> names = null, List<string> uuids = null, bool? _protected = null)

Returns the Virtual Machines in a vCenter Server.

Returns all Virtual Machines found in all the vCenter Servers registered on the Cohesity Cluster that match the filter criteria specified using parameters. If an id is specified, only VMs found in the specified vCenter Server are returned. Only VM Objects are returned. Other VMware Objects such as datacenters are not returned.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListVirtualMachinesExample
    {
        public void main()
        {
            var apiInstance = new ProtectionSourcesApi();
            var vCenterId = 789;  // long? | Limit the VMs returned to the set of VMs found in a specific vCenter Server. Pass in the root Protection Source id for the vCenter Server to search for VMs. (optional) 
            var names = new List<string>(); // List<string> | Limit the returned VMs to those that exactly match the passed in VM name. To match multiple VM names, specify multiple \"names\" parameters that each specify a single VM name. The string must exactly match the passed in VM name and wild cards are not supported. (optional) 
            var uuids = new List<string>(); // List<string> | Limit the returned VMs to those that exactly match the passed in UUIDs. (optional) 
            var _protected = true;  // bool? | Limit the returned VMs to those that have been protected by a Protection Job. By default, both protected and unprotected VMs are returned. (optional) 

            try
            {
                // Returns the Virtual Machines in a vCenter Server.
                List&lt;ProtectionSource&gt; result = apiInstance.ListVirtualMachines(vCenterId, names, uuids, _protected);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtectionSourcesApi.ListVirtualMachines: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vCenterId** | **long?**| Limit the VMs returned to the set of VMs found in a specific vCenter Server. Pass in the root Protection Source id for the vCenter Server to search for VMs. | [optional] 
 **names** | [**List&lt;string&gt;**](string.md)| Limit the returned VMs to those that exactly match the passed in VM name. To match multiple VM names, specify multiple \&quot;names\&quot; parameters that each specify a single VM name. The string must exactly match the passed in VM name and wild cards are not supported. | [optional] 
 **uuids** | [**List&lt;string&gt;**](string.md)| Limit the returned VMs to those that exactly match the passed in UUIDs. | [optional] 
 **_protected** | **bool?**| Limit the returned VMs to those that have been protected by a Protection Job. By default, both protected and unprotected VMs are returned. | [optional] 

### Return type

[**List<ProtectionSource>**](ProtectionSource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="refreshprotectionsourcebyid"></a>
# **RefreshProtectionSourceById**
> void RefreshProtectionSourceById (long? id)

Refresh the Object hierarchy of the Protection Sources tree.

Force an immediate refresh between the specified Protection Source tree on the Cohesity Cluster and the Inventory tree in the associated vCenter Server.  For example if a new VM is added to the vCenter Server, after a refresh, a new Protection Source node for this VM is added to the Protection Sources tree.  Success indicates the forced refresh has been started. The amount of time to complete a refresh depends on the size of the Object hierarchies.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RefreshProtectionSourceByIdExample
    {
        public void main()
        {
            var apiInstance = new ProtectionSourcesApi();
            var id = 789;  // long? | Id of the root node of the Protection Sources tree to refresh.  Force a refresh of the Object hierarchy for the passed in Protection Sources Id.

            try
            {
                // Refresh the Object hierarchy of the Protection Sources tree.
                apiInstance.RefreshProtectionSourceById(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtectionSourcesApi.RefreshProtectionSourceById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the root node of the Protection Sources tree to refresh.  Force a refresh of the Object hierarchy for the passed in Protection Sources Id. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="registerapplicationservers"></a>
# **RegisterApplicationServers**
> ProtectionSource RegisterApplicationServers (RegisterApplicationServersParameters body)

Register a Protection Source as running one or more Application Servers like Microsoft SQL servers or Microsoft Exchange servers.

Registering Application Servers will help Cohesity Cluster such that any application specific data can be backed up.  Returns the Protection Source registered upon success.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RegisterApplicationServersExample
    {
        public void main()
        {
            var apiInstance = new ProtectionSourcesApi();
            var body = new RegisterApplicationServersParameters(); // RegisterApplicationServersParameters | Request to register Application Servers in a Protection Source.

            try
            {
                // Register a Protection Source as running one or more Application Servers like Microsoft SQL servers or Microsoft Exchange servers.
                ProtectionSource result = apiInstance.RegisterApplicationServers(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtectionSourcesApi.RegisterApplicationServers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RegisterApplicationServersParameters**](RegisterApplicationServersParameters.md)| Request to register Application Servers in a Protection Source. | 

### Return type

[**ProtectionSource**](ProtectionSource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="registerprotectionsource"></a>
# **RegisterProtectionSource**
> ProtectionSource RegisterProtectionSource (RegisterProtectionSourceParameters body)

Register a Protection Source.

Register a Protection Source on the Cohesity Cluster. It could be the root node of a vCenter Server or a physcical server.  Returns the newly registered Protection Source upon success.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RegisterProtectionSourceExample
    {
        public void main()
        {
            var apiInstance = new ProtectionSourcesApi();
            var body = new RegisterProtectionSourceParameters(); // RegisterProtectionSourceParameters | Request to register a protection source.

            try
            {
                // Register a Protection Source.
                ProtectionSource result = apiInstance.RegisterProtectionSource(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtectionSourcesApi.RegisterProtectionSource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RegisterProtectionSourceParameters**](RegisterProtectionSourceParameters.md)| Request to register a protection source. | 

### Return type

[**ProtectionSource**](ProtectionSource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unregisterapplicationservers"></a>
# **UnregisterApplicationServers**
> ProtectionSource UnregisterApplicationServers (long? id)

Unregister Application Servers like Microsoft SQL servers or Microsoft Exchange servers running on a Protection Source.

Unregistering Application Servers will fail if the Protection Source is currently being backed up.  Returns the Protection Source whose Application Servers are unregistered upon success.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UnregisterApplicationServersExample
    {
        public void main()
        {
            var apiInstance = new ProtectionSourcesApi();
            var id = 789;  // long? | Specifies a unique id of the Protection Source to unregister the Application Servers. If the Protection Source is currently being backed up, unregister operation will fail.

            try
            {
                // Unregister Application Servers like Microsoft SQL servers or Microsoft Exchange servers running on a Protection Source.
                ProtectionSource result = apiInstance.UnregisterApplicationServers(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtectionSourcesApi.UnregisterApplicationServers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Specifies a unique id of the Protection Source to unregister the Application Servers. If the Protection Source is currently being backed up, unregister operation will fail. | 

### Return type

[**ProtectionSource**](ProtectionSource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateapplicationservers"></a>
# **UpdateApplicationServers**
> ProtectionSource UpdateApplicationServers (UpdateApplicationServerParameters body)

Modifies the registration parameters of Application Servers in a Protection Source.

Returns the Protection Source whose registration parameters of its Application Servers are modified upon success.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateApplicationServersExample
    {
        public void main()
        {
            var apiInstance = new ProtectionSourcesApi();
            var body = new UpdateApplicationServerParameters(); // UpdateApplicationServerParameters | Request to modify the Application Servers registration of a Protection Source.

            try
            {
                // Modifies the registration parameters of Application Servers in a Protection Source.
                ProtectionSource result = apiInstance.UpdateApplicationServers(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtectionSourcesApi.UpdateApplicationServers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateApplicationServerParameters**](UpdateApplicationServerParameters.md)| Request to modify the Application Servers registration of a Protection Source. | 

### Return type

[**ProtectionSource**](ProtectionSource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upgradephysicalagents"></a>
# **UpgradePhysicalAgents**
> UpgradePhysicalAgentsMessage UpgradePhysicalAgents (UpgradePhysicalServerAgents body = null)

Initiate a request to upgrade Cohesity agents on one or more Physical Servers registered on the Cohesity Cluster.

If the request is successful, the Cohesity agents on the specified Physical Servers are upgraded to the agent release currently available from this Cohesity Cluster. For example if the Cluster is upgraded from 3.7.1 to 4.0, the agents on the specified Physical Servers can be upgraded to 4.0 using this POST operation. To get the agentIds to pass into this operation, call GET /public/protectionSources with the environment set to 'KPhysical'. In addition this GET operation returns the agentUpgradability field, that indicates if an agent can be upgraded. Use the agentUpgradability field to determine which Physical Servers to upgrade using this POST /public/physicalAgents/upgrade operation.  WARNING: Only agents at a particular Cohesity release can be upgraded using this operation. See the Cohesity online help for details.  Returns the status of the upgrade initiation.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpgradePhysicalAgentsExample
    {
        public void main()
        {
            var apiInstance = new ProtectionSourcesApi();
            var body = new UpgradePhysicalServerAgents(); // UpgradePhysicalServerAgents | Request to upgrade agents on Physical Servers. (optional) 

            try
            {
                // Initiate a request to upgrade Cohesity agents on one or more Physical Servers registered on the Cohesity Cluster.
                UpgradePhysicalAgentsMessage result = apiInstance.UpgradePhysicalAgents(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtectionSourcesApi.UpgradePhysicalAgents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpgradePhysicalServerAgents**](UpgradePhysicalServerAgents.md)| Request to upgrade agents on Physical Servers. | [optional] 

### Return type

[**UpgradePhysicalAgentsMessage**](UpgradePhysicalAgentsMessage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


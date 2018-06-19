# IO.Swagger.Model.AgentInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CbmrVersion** | **string** | Specifies the version if Cristie BMR product is installed on the host. | [optional] 
**Id** | **long?** | Specifies the agent&#39;s id. | [optional] 
**Name** | **string** | Specifies the agent&#39;s name. | [optional] 
**RegistrationInfo** | [**RegisteredSourceInfo**](RegisteredSourceInfo.md) | Specifies registration information for an Agent. | [optional] 
**SourceSideDedupEnabled** | **bool?** | Specifies whether source side dedup is enabled or not. | [optional] 
**Status** | **string** | Specifies the agent status. Specifies the status of the agent running on a physical source. &#39;kUnknown&#39; indicates the Agent is not known. No attempt to connect to the Agent has occurred. &#39;kUnreachable&#39; indicates the Agent is not reachable. &#39;kHealthy&#39; indicates the Agent is healthy. &#39;kDegraded&#39; indicates the Agent is running but in a degraded state. | [optional] 
**StatusMessage** | **string** | Specifies additional details about the agent status. | [optional] 
**Upgradability** | **string** | Specifies the upgradability of the agent running on the physical server. Specifies the upgradability of the agent running on the physical server. &#39;kUpgradable&#39; indicates the Agent can be upgraded to the agent software version on the cluster. &#39;kCurrent&#39; indicates the Agent is running the latest version. &#39;kUnknown&#39; indicates the Agent&#39;s version is not known. &#39;kNonUpgradableInvalidVersion&#39; indicates the Agent&#39;s version is invalid. &#39;kNonUpgradableAgentIsNewer&#39; indicates the Agent&#39;s version is newer than the agent software version the cluster. &#39;kNonUpgradableAgentIsOld&#39; indicates the Agent&#39;s version is too old that does not support upgrades. | [optional] 
**UpgradeStatus** | **string** | Specifies the status of the upgrade of the agent on a physical server. Specifies the status of the upgrade of the agent on a physical server. &#39;kIdle&#39; indicates there is no agent upgrade in progress. &#39;kAccepted&#39; indicates the Agent upgrade is accepted. &#39;kStarted&#39; indicates the Agent upgrade is in progress. &#39;kFinished&#39; indicates the Agent upgrade is completed. | [optional] 
**UpgradeStatusMessage** | **string** | Specifies detailed message about the agent upgrade failure. This field is not set for successful upgrade. | [optional] 
**Version** | **string** | Specifies the version of the Agent software. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


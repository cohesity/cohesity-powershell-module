# IO.Swagger.Model.Cluster
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BondingMode** | **string** | Specifies the bonding mode to use when bonding NICs to this Cluster. &#39;KActiveBackup&#39; indicates an Active-backup policy bonding mode. &#39;K802_3ad&#39; indicates an EEE 802.3ad Dynamic link aggregation bonding mode. &#39;KBalanceAlb&#39; indicates a Adaptive load balancing bonding mode. | [optional] 
**ClusterAuditLogConfig** | [**ClusterAuditLogConfiguration**](ClusterAuditLogConfiguration.md) | Cluster Audit Log Configuration. | [optional] 
**ClusterSoftwareVersion** | **string** | Specifies the current release of the Cohesity software running on this Cohesity Cluster. | [optional] 
**ClusterType** | **string** | Specifies the type of Cluster such as kPhysical. &#39;kPhysical&#39; indicates the Cohesity Cluster is hosted directly on hardware. &#39;kVirtualRobo&#39; indicates the Cohesity Cluster is hosted in a VM on a ESXi Host of a VMware vCenter Server using Cohesity&#39;s Virtual Edition. &#39;kMicrosoftCloud&#39; indicates the Cohesity Cluster is hosed in a VM on Microsoft Azure using Cohesity&#39;s Cloud Edition. &#39;kAmazonCloud&#39; indicates the Cohesity Cluster is hosed in a VM on Amazon S3 using Cohesity&#39;s Cloud Edition. &#39;kGoogleCloud&#39; indicates the Cohesity Cluster is hosed in a VM on Google Cloud Platform using Cohesity&#39;s Cloud Edition. | [optional] 
**CreatedTimeMsecs** | **long?** | Specifies the time when the Cohesity Cluster was created. This value is specified as a Unix epoch Timestamp (in microseconds). | [optional] 
**CurrentOpScheduledTimeSecs** | **long?** | Specifies the time scheduled by the Cohesity Cluster to start the current running operation. | [optional] 
**CurrentOperation** | **string** | Specifies the current Cluster-level operation in progress. &#39;kUpgrade&#39; indicates the Cohesity Cluster is upgrading to a new release. &#39;kRemoveNode&#39; indicates the Cohesity Cluster is removing a Node from the Cluster. &#39;kNone&#39; indicates no action is occurring on the Cohesity Cluster. | [optional] 
**CurrentTimeMsecs** | **long?** | Specifies the current system time on the Cohesity Cluster. This value is specified as a Unix epoch Timestamp (in microseconds). | [optional] 
**DnsServerIps** | **List&lt;string&gt;** | Specifies the IP addresses of the DNS Servers used by the Cohesity Cluster. | [optional] 
**DomainNames** | **List&lt;string&gt;** | The first domain name specified in the array is the fully qualified domain name assigned to the Cohesity Cluster. Any additional domain names specified are used for the domain search list for hostname look-up. | [optional] 
**EnableActiveMonitoring** | **bool?** | Specifies if Cohesity can receive monitoring information from the Cohesity Cluster. If &#39;true&#39;, remote monitoring of the Cohesity Cluster is allowed. | [optional] 
**EnableUpgradePkgPolling** | **bool?** | If &#39;true&#39;, Cohesity&#39;s upgrade server is polled for new releases. | [optional] 
**EncryptionEnabled** | **bool?** | If &#39;true&#39;, the entire Cohesity Cluster is encrypted including all View Boxes. | [optional] 
**EncryptionKeyRotationPeriodSecs** | **long?** | Specifies the period of time (in seconds) when encryption keys are rotated. By default, the encryption keys are rotated every 77760000 seconds (30 days). | [optional] 
**EulaConfig** | [**EULAAcceptanceInformation_**](EULAAcceptanceInformation_.md) |  | [optional] 
**FilerAuditLogConfig** | [**FilerAuditLogConfiguration**](FilerAuditLogConfiguration.md) | Filer Audit Log Configuration. | [optional] 
**FipsModeEnabled** | **bool?** | Specifies if the Cohesity Cluster should operate in the FIPS mode, which is compliant with the Federal Information Processing Standard 140-2 certification. | [optional] 
**Gateway** | **string** | Specifies the gateway IP address. | [optional] 
**HardwareInfo** | [**ClusterHardwareInfo**](ClusterHardwareInfo.md) | Specifies a hardware type for motherboard of the nodes that make up this Cohesity Cluster such as S2600WB for Ivy Bridge or S2600TP for Haswell. | [optional] 
**Id** | **long?** | Specifies the unique id of Cohesity Cluster. | [optional] 
**IncarnationId** | **long?** | Specifies the unique incarnation id of the Cohesity Cluster. | [optional] 
**IsDocumentationLocal** | **bool?** | Specifies what version of the documentation is used. If &#39;true&#39;, the version of documentation stored locally on the Cohesity Cluster is used. If &#39;false&#39;, the documentation stored on a Cohesity Web Server is used. The default is &#39;false&#39;. Cohesity recommends accessing the Help from the Cohesity Web site which provides the newest and most complete version of Help. | [optional] 
**LanguageLocale** | **string** | Specifies the language and locale for this Cohesity Cluster. | [optional] 
**Mtu** | **int?** | Specifies the Maxium Transmission Unit (MTU) in bytes of the network. | [optional] 
**Name** | **string** | Specifies the name of the Cohesity Cluster. | [optional] 
**NodeCount** | **long?** | Specifies the number of Nodes in the Cohesity Cluster. | [optional] 
**NtpSettings** | [**NtpSettingsConfig**](NtpSettingsConfig.md) | Specifies if the ntp/master slave scheme should be disabled for this cluster. | [optional] 
**ReverseTunnelEnabled** | **bool?** | If &#39;true&#39;, Cohesity&#39;s Remote Tunnel is enabled. Cohesity can access the Cluster and provide remote assistance via a Remote Tunnel. | [optional] 
**SmbAdDisabled** | **bool?** | Specifies if Active Directory should be disabled for authentication of SMB shares. If &#39;true&#39;, Active Directory is disabled. | [optional] 
**Stats** | [**ClusterStats**](ClusterStats.md) | Specifies statistics about this Cohesity Cluster. | [optional] 
**SupportedConfig** | [**SupportedConfig**](SupportedConfig.md) | Information about supported configuration. For example, it contains minimum number of nodes supported for the cluster. | [optional] 
**SyslogServers** | [**List&lt;SyslogServer&gt;**](SyslogServer.md) | Specifies a list of Syslog servers to send audit logs to. | [optional] 
**TargetSoftwareVersion** | **string** | Specifies the Cohesity release that this Cluster is being upgraded to if an upgrade operation is in progress. | [optional] 
**Timezone** | **string** | Specifies the timezone to use for showing time in emails, reports, filer audit logs, etc. | [optional] 
**TurboMode** | **bool?** | Specifies if the cluster is in Turbo mode. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


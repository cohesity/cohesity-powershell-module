# IO.Swagger.Model.UpdateClusterParams
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BondingMode** | **string** | Specifies the bonding mode to use when bonding NICs to this Cluster. &#39;KActiveBackup&#39; indicates an Active-backup policy bonding mode. &#39;K802_3ad&#39; indicates an EEE 802.3ad Dynamic link aggregation bonding mode. &#39;KBalanceAlb&#39; indicates a Adaptive load balancing bonding mode. | [optional] 
**ClusterAuditLogConfig** | [**ClusterAuditLogConfiguration**](ClusterAuditLogConfiguration.md) | Cluster Audit Log Configuration. | [optional] 
**DnsServerIps** | **List&lt;string&gt;** | Specifies the IP addresses of the DNS Servers used by the Cohesity Cluster. | [optional] 
**DomainNames** | **List&lt;string&gt;** | The first domain name specified in the array is the fully qualified domain name assigned to the Cohesity Cluster. Any additional domain names specified are used for the domain search list for hostname look-up. | [optional] 
**EnableActiveMonitoring** | **bool?** | Specifies if Cohesity can receive monitoring information from the Cohesity Cluster. If &#39;true&#39;, remote monitoring of the Cohesity Cluster is allowed. | [optional] 
**EnableUpgradePkgPolling** | **bool?** | If &#39;true&#39;, Cohesity&#39;s upgrade server is polled for new releases. | [optional] 
**EncryptionKeyRotationPeriodSecs** | **long?** | Specifies the period of time (in seconds) when encryption keys are rotated. By default, the encryption keys are rotated every 77760000 seconds (30 days). | [optional] 
**FilerAuditLogConfig** | [**FilerAuditLogConfiguration**](FilerAuditLogConfiguration.md) | Filer Audit Log Configuration. | [optional] 
**Gateway** | **string** | Specifies the gateway IP address. | [optional] 
**IsDocumentationLocal** | **bool?** | Specifies what version of the documentation is used. If &#39;true&#39;, the version of documentation stored locally on the Cohesity Cluster is used. If &#39;false&#39;, the documentation stored on a Cohesity Web Server is used. The default is &#39;false&#39;. Cohesity recommends accessing the Help from the Cohesity Web site which provides the newest and most complete version of Help. | [optional] 
**LanguageLocale** | **string** | Specifies the language and locale for this Cohesity Cluster. | [optional] 
**Mtu** | **int?** | Specifies the Maxium Transmission Unit (MTU) in bytes of the network. | [optional] 
**Name** | **string** | Specifies the name of the Cohesity Cluster. | [optional] 
**NtpSettings** | [**NtpSettingsConfig**](NtpSettingsConfig.md) | Specifies if the ntp/master slave scheme should be disabled for this cluster. | [optional] 
**ReverseTunnelEnabled** | **bool?** | If &#39;true&#39;, Cohesity&#39;s Remote Tunnel is enabled. Cohesity can access the Cluster and provide remote assistance via a Remote Tunnel. | [optional] 
**SmbAdDisabled** | **bool?** | Specifies if Active Directory should be disabled for authentication of SMB shares. If &#39;true&#39;, Active Directory is disabled. | [optional] 
**SyslogServers** | [**List&lt;SyslogServer&gt;**](SyslogServer.md) | Specifies a list of Syslog servers to send audit logs to. | [optional] 
**Timezone** | **string** | Specifies the timezone to use for showing time in emails, reports, filer audit logs, etc. | [optional] 
**TurboMode** | **bool?** | Specifies if the cluster is in Turbo mode. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


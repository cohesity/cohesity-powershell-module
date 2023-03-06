// Copyright 2019 Cohesity Inc.


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Cohesity.Model
{
    /// <summary>
    /// Specifies the configuration settings that can be updated on the Cohesity Cluster.
    /// </summary>
    [DataContract]
    public partial class UpdateClusterParams :  IEquatable<UpdateClusterParams>
    {
        /// <summary>
        /// Specifies the level which &#39;MetadataFaultToleranceFactor&#39; applies to. &#39;kNode&#39; indicates &#39;MetadataFaultToleranceFactor&#39; applies to Node level. &#39;kChassis&#39; indicates &#39;MetadataFaultToleranceFactor&#39; applies to Chassis level. &#39;kRack&#39; indicates &#39;MetadataFaultToleranceFactor&#39; applies to Rack level.
        /// </summary>
        /// <value>Specifies the level which &#39;MetadataFaultToleranceFactor&#39; applies to. &#39;kNode&#39; indicates &#39;MetadataFaultToleranceFactor&#39; applies to Node level. &#39;kChassis&#39; indicates &#39;MetadataFaultToleranceFactor&#39; applies to Chassis level. &#39;kRack&#39; indicates &#39;MetadataFaultToleranceFactor&#39; applies to Rack level.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FaultToleranceLevelEnum
        {
            /// <summary>
            /// Enum KNode for value: kNode
            /// </summary>
            [EnumMember(Value = "kNode")]
            KNode = 1,

            /// <summary>
            /// Enum KChassis for value: kChassis
            /// </summary>
            [EnumMember(Value = "kChassis")]
            KChassis = 2,

            /// <summary>
            /// Enum KRack for value: kRack
            /// </summary>
            [EnumMember(Value = "kRack")]
            KRack = 3

        }

        /// <summary>
        /// Specifies the level which &#39;MetadataFaultToleranceFactor&#39; applies to. &#39;kNode&#39; indicates &#39;MetadataFaultToleranceFactor&#39; applies to Node level. &#39;kChassis&#39; indicates &#39;MetadataFaultToleranceFactor&#39; applies to Chassis level. &#39;kRack&#39; indicates &#39;MetadataFaultToleranceFactor&#39; applies to Rack level.
        /// </summary>
        /// <value>Specifies the level which &#39;MetadataFaultToleranceFactor&#39; applies to. &#39;kNode&#39; indicates &#39;MetadataFaultToleranceFactor&#39; applies to Node level. &#39;kChassis&#39; indicates &#39;MetadataFaultToleranceFactor&#39; applies to Chassis level. &#39;kRack&#39; indicates &#39;MetadataFaultToleranceFactor&#39; applies to Rack level.</value>
        [DataMember(Name="faultToleranceLevel", EmitDefaultValue=true)]
        public FaultToleranceLevelEnum? FaultToleranceLevel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateClusterParams" /> class.
        /// </summary>
        /// <param name="amqpTargetConfig">amqpTargetConfig.</param>
        /// <param name="appsSubnet">appsSubnet.</param>
        /// <param name="bannerEnabled">Specifies whether UI banner is enabled on the cluster or not. When banner is enabled, UI will make an additional API call to fetch the banner and show at the login page..</param>
        /// <param name="clusterAuditLogConfig">clusterAuditLogConfig.</param>
        /// <param name="dnsServerIps">Array of IP Addresses of DNS Servers.  Specifies the IP addresses of the DNS Servers used by the Cohesity Cluster..</param>
        /// <param name="domainNames">Array of Domain Names.  The first domain name specified in the array is the fully qualified domain name assigned to the Cohesity Cluster. Any additional domain names specified are used for the domain search list for hostname look-up..</param>
        /// <param name="enableActiveMonitoring">Specifies if Cohesity can receive monitoring information from the Cohesity Cluster. If &#39;true&#39;, remote monitoring of the Cohesity Cluster is allowed..</param>
        /// <param name="enablePatchesDownload">Specifies whether to enable downloading patches from Cohesity download site..</param>
        /// <param name="enableUpgradePkgPolling">If &#39;true&#39;, Cohesity&#39;s upgrade server is polled for new releases..</param>
        /// <param name="encryptionKeyRotationPeriodSecs">Specifies the period of time (in seconds) when encryption keys are rotated. By default, the encryption keys are rotated every 77760000 seconds (30 days)..</param>
        /// <param name="faultToleranceLevel">Specifies the level which &#39;MetadataFaultToleranceFactor&#39; applies to. &#39;kNode&#39; indicates &#39;MetadataFaultToleranceFactor&#39; applies to Node level. &#39;kChassis&#39; indicates &#39;MetadataFaultToleranceFactor&#39; applies to Chassis level. &#39;kRack&#39; indicates &#39;MetadataFaultToleranceFactor&#39; applies to Rack level..</param>
        /// <param name="filerAuditLogConfig">filerAuditLogConfig.</param>
        /// <param name="gateway">Specifies the gateway IP address..</param>
        /// <param name="googleAnalyticsEnabled">Specifies whether Google Analytics is enabled..</param>
        /// <param name="isDocumentationLocal">Specifies what version of the documentation is used. If &#39;true&#39;, the version of documentation stored locally on the Cohesity Cluster is used. If &#39;false&#39;, the documentation stored on a Cohesity Web Server is used. The default is &#39;false&#39;. Cohesity recommends accessing the Help from the Cohesity Web site which provides the newest and most complete version of Help..</param>
        /// <param name="kmsServerId">Specifies the KMS Server Id. This can only be set when the encryption is enabled on cluster..</param>
        /// <param name="languageLocale">Specifies the language and locale for this Cohesity Cluster..</param>
        /// <param name="localAuthDomainName">Domain name for SMB local authentication..</param>
        /// <param name="localGroupsEnabled">Specifies whether to enable local groups on cluster. Once it is enabled, it cannot be disabled..</param>
        /// <param name="metadataFaultToleranceFactor">Specifies metadata fault tolerance setting for the cluster. This denotes the number of simultaneous failures[node] supported by metadata services like gandalf and scribe..</param>
        /// <param name="multiTenancyEnabled">Specifies if multi tenancy is enabled in the cluster. Authentication &amp; Authorization will always use tenant_id, however, some UI elements may be disabled when multi tenancy is disabled..</param>
        /// <param name="name">Specifies the name of the Cohesity Cluster..</param>
        /// <param name="ntpSettings">ntpSettings.</param>
        /// <param name="pcieSsdTierRebalanceDelaySecs">Specifies the rebalance delay in seconds for cluster PcieSSD storage tier..</param>
        /// <param name="protoRpcEncryptionEnabled">Specifies if protorpc encryption is enabled or not..</param>
        /// <param name="reverseTunnelEnabled">If &#39;true&#39;, Cohesity&#39;s Remote Tunnel is enabled. Cohesity can access the Cluster and provide remote assistance via a Remote Tunnel..</param>
        /// <param name="reverseTunnelEndTimeMsecs">ReverseTunnelEndTimeMsecs specifies the end time in milliseconds since epoch until when the reverse tunnel will stay enabled..</param>
        /// <param name="securityModeDod">Specifies if Security Mode DOD is enabled or not..</param>
        /// <param name="smbAdDisabled">Specifies if Active Directory should be disabled for authentication of SMB shares. If &#39;true&#39;, Active Directory is disabled..</param>
        /// <param name="smbMultichannelEnabled">Specifies whether SMB multichannel is enabled on the cluster. When this is set to true, then any SMB3 multichannel enabled client can establish multiple TCP connection per session to the Server..</param>
        /// <param name="stigMode">TODO(mitch) StigMode is deprecated. Should it still be in this list??.</param>
        /// <param name="syslogServers">Syslog servers..</param>
        /// <param name="tenantViewboxSharingEnabled">In case multi tenancy is enabled, this flag controls whether multiple tenants can be placed on the same viewbox. Once set to true, this flag should never become false..</param>
        /// <param name="tieringAuditLogConfig">tieringAuditLogConfig.</param>
        /// <param name="timezone">Specifies the timezone to use for showing time in emails, reports, filer audit logs, etc..</param>
        /// <param name="turboMode">Specifies if the cluster is in Turbo mode..</param>
        /// <param name="useHeimdall">Specifies whether to enable Heimdall which tells whether services should use temporary fleet instances to mount disks by talking to Heimdall..</param>
        public UpdateClusterParams(AMQPTargetConfig amqpTargetConfig = default(AMQPTargetConfig), Subnet appsSubnet = default(Subnet), bool? bannerEnabled = default(bool?), ClusterAuditLogConfiguration clusterAuditLogConfig = default(ClusterAuditLogConfiguration), List<string> dnsServerIps = default(List<string>), List<string> domainNames = default(List<string>), bool? enableActiveMonitoring = default(bool?), bool? enablePatchesDownload = default(bool?), bool? enableUpgradePkgPolling = default(bool?), long? encryptionKeyRotationPeriodSecs = default(long?), FaultToleranceLevelEnum? faultToleranceLevel = default(FaultToleranceLevelEnum?), FilerAuditLogConfiguration filerAuditLogConfig = default(FilerAuditLogConfiguration), string gateway = default(string), bool? googleAnalyticsEnabled = default(bool?), bool? isDocumentationLocal = default(bool?), long? kmsServerId = default(long?), string languageLocale = default(string), string localAuthDomainName = default(string), bool? localGroupsEnabled = default(bool?), int? metadataFaultToleranceFactor = default(int?), bool? multiTenancyEnabled = default(bool?), string name = default(string), NtpSettingsConfig ntpSettings = default(NtpSettingsConfig), int? pcieSsdTierRebalanceDelaySecs = default(int?), bool? protoRpcEncryptionEnabled = default(bool?), bool? reverseTunnelEnabled = default(bool?), long? reverseTunnelEndTimeMsecs = default(long?), bool? securityModeDod = default(bool?), bool? smbAdDisabled = default(bool?), bool? smbMultichannelEnabled = default(bool?), bool? stigMode = default(bool?), List<OldSyslogServer> syslogServers = default(List<OldSyslogServer>), bool? tenantViewboxSharingEnabled = default(bool?), TieringAuditLogConfiguration tieringAuditLogConfig = default(TieringAuditLogConfiguration), string timezone = default(string), bool? turboMode = default(bool?), bool? useHeimdall = default(bool?))
        {
            this.BannerEnabled = bannerEnabled;
            this.DnsServerIps = dnsServerIps;
            this.DomainNames = domainNames;
            this.EnableActiveMonitoring = enableActiveMonitoring;
            this.EnablePatchesDownload = enablePatchesDownload;
            this.EnableUpgradePkgPolling = enableUpgradePkgPolling;
            this.EncryptionKeyRotationPeriodSecs = encryptionKeyRotationPeriodSecs;
            this.FaultToleranceLevel = faultToleranceLevel;
            this.Gateway = gateway;
            this.GoogleAnalyticsEnabled = googleAnalyticsEnabled;
            this.IsDocumentationLocal = isDocumentationLocal;
            this.KmsServerId = kmsServerId;
            this.LanguageLocale = languageLocale;
            this.LocalAuthDomainName = localAuthDomainName;
            this.LocalGroupsEnabled = localGroupsEnabled;
            this.MetadataFaultToleranceFactor = metadataFaultToleranceFactor;
            this.MultiTenancyEnabled = multiTenancyEnabled;
            this.Name = name;
            this.PcieSsdTierRebalanceDelaySecs = pcieSsdTierRebalanceDelaySecs;
            this.ProtoRpcEncryptionEnabled = protoRpcEncryptionEnabled;
            this.ReverseTunnelEnabled = reverseTunnelEnabled;
            this.ReverseTunnelEndTimeMsecs = reverseTunnelEndTimeMsecs;
            this.SecurityModeDod = securityModeDod;
            this.SmbAdDisabled = smbAdDisabled;
            this.SmbMultichannelEnabled = smbMultichannelEnabled;
            this.StigMode = stigMode;
            this.SyslogServers = syslogServers;
            this.TenantViewboxSharingEnabled = tenantViewboxSharingEnabled;
            this.Timezone = timezone;
            this.TurboMode = turboMode;
            this.UseHeimdall = useHeimdall;
            this.AmqpTargetConfig = amqpTargetConfig;
            this.AppsSubnet = appsSubnet;
            this.BannerEnabled = bannerEnabled;
            this.ClusterAuditLogConfig = clusterAuditLogConfig;
            this.DnsServerIps = dnsServerIps;
            this.DomainNames = domainNames;
            this.EnableActiveMonitoring = enableActiveMonitoring;
            this.EnablePatchesDownload = enablePatchesDownload;
            this.EnableUpgradePkgPolling = enableUpgradePkgPolling;
            this.EncryptionKeyRotationPeriodSecs = encryptionKeyRotationPeriodSecs;
            this.FaultToleranceLevel = faultToleranceLevel;
            this.FilerAuditLogConfig = filerAuditLogConfig;
            this.Gateway = gateway;
            this.GoogleAnalyticsEnabled = googleAnalyticsEnabled;
            this.IsDocumentationLocal = isDocumentationLocal;
            this.KmsServerId = kmsServerId;
            this.LanguageLocale = languageLocale;
            this.LocalAuthDomainName = localAuthDomainName;
            this.LocalGroupsEnabled = localGroupsEnabled;
            this.MetadataFaultToleranceFactor = metadataFaultToleranceFactor;
            this.MultiTenancyEnabled = multiTenancyEnabled;
            this.Name = name;
            this.NtpSettings = ntpSettings;
            this.PcieSsdTierRebalanceDelaySecs = pcieSsdTierRebalanceDelaySecs;
            this.ProtoRpcEncryptionEnabled = protoRpcEncryptionEnabled;
            this.ReverseTunnelEnabled = reverseTunnelEnabled;
            this.ReverseTunnelEndTimeMsecs = reverseTunnelEndTimeMsecs;
            this.SecurityModeDod = securityModeDod;
            this.SmbAdDisabled = smbAdDisabled;
            this.SmbMultichannelEnabled = smbMultichannelEnabled;
            this.StigMode = stigMode;
            this.SyslogServers = syslogServers;
            this.TenantViewboxSharingEnabled = tenantViewboxSharingEnabled;
            this.TieringAuditLogConfig = tieringAuditLogConfig;
            this.Timezone = timezone;
            this.TurboMode = turboMode;
            this.UseHeimdall = useHeimdall;
        }
        
        /// <summary>
        /// Gets or Sets AmqpTargetConfig
        /// </summary>
        [DataMember(Name="amqpTargetConfig", EmitDefaultValue=false)]
        public AMQPTargetConfig AmqpTargetConfig { get; set; }

        /// <summary>
        /// Gets or Sets AppsSubnet
        /// </summary>
        [DataMember(Name="appsSubnet", EmitDefaultValue=false)]
        public Subnet AppsSubnet { get; set; }

        /// <summary>
        /// Specifies whether UI banner is enabled on the cluster or not. When banner is enabled, UI will make an additional API call to fetch the banner and show at the login page.
        /// </summary>
        /// <value>Specifies whether UI banner is enabled on the cluster or not. When banner is enabled, UI will make an additional API call to fetch the banner and show at the login page.</value>
        [DataMember(Name="bannerEnabled", EmitDefaultValue=true)]
        public bool? BannerEnabled { get; set; }

        /// <summary>
        /// Gets or Sets ClusterAuditLogConfig
        /// </summary>
        [DataMember(Name="clusterAuditLogConfig", EmitDefaultValue=false)]
        public ClusterAuditLogConfiguration ClusterAuditLogConfig { get; set; }

        /// <summary>
        /// Array of IP Addresses of DNS Servers.  Specifies the IP addresses of the DNS Servers used by the Cohesity Cluster.
        /// </summary>
        /// <value>Array of IP Addresses of DNS Servers.  Specifies the IP addresses of the DNS Servers used by the Cohesity Cluster.</value>
        [DataMember(Name="dnsServerIps", EmitDefaultValue=true)]
        public List<string> DnsServerIps { get; set; }

        /// <summary>
        /// Array of Domain Names.  The first domain name specified in the array is the fully qualified domain name assigned to the Cohesity Cluster. Any additional domain names specified are used for the domain search list for hostname look-up.
        /// </summary>
        /// <value>Array of Domain Names.  The first domain name specified in the array is the fully qualified domain name assigned to the Cohesity Cluster. Any additional domain names specified are used for the domain search list for hostname look-up.</value>
        [DataMember(Name="domainNames", EmitDefaultValue=true)]
        public List<string> DomainNames { get; set; }

        /// <summary>
        /// Specifies if Cohesity can receive monitoring information from the Cohesity Cluster. If &#39;true&#39;, remote monitoring of the Cohesity Cluster is allowed.
        /// </summary>
        /// <value>Specifies if Cohesity can receive monitoring information from the Cohesity Cluster. If &#39;true&#39;, remote monitoring of the Cohesity Cluster is allowed.</value>
        [DataMember(Name="enableActiveMonitoring", EmitDefaultValue=true)]
        public bool? EnableActiveMonitoring { get; set; }

        /// <summary>
        /// Specifies whether to enable downloading patches from Cohesity download site.
        /// </summary>
        /// <value>Specifies whether to enable downloading patches from Cohesity download site.</value>
        [DataMember(Name="enablePatchesDownload", EmitDefaultValue=true)]
        public bool? EnablePatchesDownload { get; set; }

        /// <summary>
        /// If &#39;true&#39;, Cohesity&#39;s upgrade server is polled for new releases.
        /// </summary>
        /// <value>If &#39;true&#39;, Cohesity&#39;s upgrade server is polled for new releases.</value>
        [DataMember(Name="enableUpgradePkgPolling", EmitDefaultValue=true)]
        public bool? EnableUpgradePkgPolling { get; set; }

        /// <summary>
        /// Specifies the period of time (in seconds) when encryption keys are rotated. By default, the encryption keys are rotated every 77760000 seconds (30 days).
        /// </summary>
        /// <value>Specifies the period of time (in seconds) when encryption keys are rotated. By default, the encryption keys are rotated every 77760000 seconds (30 days).</value>
        [DataMember(Name="encryptionKeyRotationPeriodSecs", EmitDefaultValue=true)]
        public long? EncryptionKeyRotationPeriodSecs { get; set; }

        /// <summary>
        /// Gets or Sets FilerAuditLogConfig
        /// </summary>
        [DataMember(Name="filerAuditLogConfig", EmitDefaultValue=false)]
        public FilerAuditLogConfiguration FilerAuditLogConfig { get; set; }

        /// <summary>
        /// Specifies the gateway IP address.
        /// </summary>
        /// <value>Specifies the gateway IP address.</value>
        [DataMember(Name="gateway", EmitDefaultValue=true)]
        public string Gateway { get; set; }

        /// <summary>
        /// Specifies whether Google Analytics is enabled.
        /// </summary>
        /// <value>Specifies whether Google Analytics is enabled.</value>
        [DataMember(Name="googleAnalyticsEnabled", EmitDefaultValue=true)]
        public bool? GoogleAnalyticsEnabled { get; set; }

        /// <summary>
        /// Specifies what version of the documentation is used. If &#39;true&#39;, the version of documentation stored locally on the Cohesity Cluster is used. If &#39;false&#39;, the documentation stored on a Cohesity Web Server is used. The default is &#39;false&#39;. Cohesity recommends accessing the Help from the Cohesity Web site which provides the newest and most complete version of Help.
        /// </summary>
        /// <value>Specifies what version of the documentation is used. If &#39;true&#39;, the version of documentation stored locally on the Cohesity Cluster is used. If &#39;false&#39;, the documentation stored on a Cohesity Web Server is used. The default is &#39;false&#39;. Cohesity recommends accessing the Help from the Cohesity Web site which provides the newest and most complete version of Help.</value>
        [DataMember(Name="isDocumentationLocal", EmitDefaultValue=true)]
        public bool? IsDocumentationLocal { get; set; }

        /// <summary>
        /// Specifies the KMS Server Id. This can only be set when the encryption is enabled on cluster.
        /// </summary>
        /// <value>Specifies the KMS Server Id. This can only be set when the encryption is enabled on cluster.</value>
        [DataMember(Name="kmsServerId", EmitDefaultValue=true)]
        public long? KmsServerId { get; set; }

        /// <summary>
        /// Specifies the language and locale for this Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the language and locale for this Cohesity Cluster.</value>
        [DataMember(Name="languageLocale", EmitDefaultValue=true)]
        public string LanguageLocale { get; set; }

        /// <summary>
        /// Domain name for SMB local authentication.
        /// </summary>
        /// <value>Domain name for SMB local authentication.</value>
        [DataMember(Name="localAuthDomainName", EmitDefaultValue=true)]
        public string LocalAuthDomainName { get; set; }

        /// <summary>
        /// Specifies whether to enable local groups on cluster. Once it is enabled, it cannot be disabled.
        /// </summary>
        /// <value>Specifies whether to enable local groups on cluster. Once it is enabled, it cannot be disabled.</value>
        [DataMember(Name="localGroupsEnabled", EmitDefaultValue=true)]
        public bool? LocalGroupsEnabled { get; set; }

        /// <summary>
        /// Specifies metadata fault tolerance setting for the cluster. This denotes the number of simultaneous failures[node] supported by metadata services like gandalf and scribe.
        /// </summary>
        /// <value>Specifies metadata fault tolerance setting for the cluster. This denotes the number of simultaneous failures[node] supported by metadata services like gandalf and scribe.</value>
        [DataMember(Name="metadataFaultToleranceFactor", EmitDefaultValue=true)]
        public int? MetadataFaultToleranceFactor { get; set; }

        /// <summary>
        /// Specifies if multi tenancy is enabled in the cluster. Authentication &amp; Authorization will always use tenant_id, however, some UI elements may be disabled when multi tenancy is disabled.
        /// </summary>
        /// <value>Specifies if multi tenancy is enabled in the cluster. Authentication &amp; Authorization will always use tenant_id, however, some UI elements may be disabled when multi tenancy is disabled.</value>
        [DataMember(Name="multiTenancyEnabled", EmitDefaultValue=true)]
        public bool? MultiTenancyEnabled { get; set; }

        /// <summary>
        /// Specifies the name of the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the name of the Cohesity Cluster.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets NtpSettings
        /// </summary>
        [DataMember(Name="ntpSettings", EmitDefaultValue=false)]
        public NtpSettingsConfig NtpSettings { get; set; }

        /// <summary>
        /// Specifies the rebalance delay in seconds for cluster PcieSSD storage tier.
        /// </summary>
        /// <value>Specifies the rebalance delay in seconds for cluster PcieSSD storage tier.</value>
        [DataMember(Name="pcieSsdTierRebalanceDelaySecs", EmitDefaultValue=true)]
        public int? PcieSsdTierRebalanceDelaySecs { get; set; }

        /// <summary>
        /// Specifies if protorpc encryption is enabled or not.
        /// </summary>
        /// <value>Specifies if protorpc encryption is enabled or not.</value>
        [DataMember(Name="protoRpcEncryptionEnabled", EmitDefaultValue=true)]
        public bool? ProtoRpcEncryptionEnabled { get; set; }

        /// <summary>
        /// If &#39;true&#39;, Cohesity&#39;s Remote Tunnel is enabled. Cohesity can access the Cluster and provide remote assistance via a Remote Tunnel.
        /// </summary>
        /// <value>If &#39;true&#39;, Cohesity&#39;s Remote Tunnel is enabled. Cohesity can access the Cluster and provide remote assistance via a Remote Tunnel.</value>
        [DataMember(Name="reverseTunnelEnabled", EmitDefaultValue=true)]
        public bool? ReverseTunnelEnabled { get; set; }

        /// <summary>
        /// ReverseTunnelEndTimeMsecs specifies the end time in milliseconds since epoch until when the reverse tunnel will stay enabled.
        /// </summary>
        /// <value>ReverseTunnelEndTimeMsecs specifies the end time in milliseconds since epoch until when the reverse tunnel will stay enabled.</value>
        [DataMember(Name="reverseTunnelEndTimeMsecs", EmitDefaultValue=true)]
        public long? ReverseTunnelEndTimeMsecs { get; set; }

        /// <summary>
        /// Specifies if Security Mode DOD is enabled or not.
        /// </summary>
        /// <value>Specifies if Security Mode DOD is enabled or not.</value>
        [DataMember(Name="securityModeDod", EmitDefaultValue=true)]
        public bool? SecurityModeDod { get; set; }

        /// <summary>
        /// Specifies if Active Directory should be disabled for authentication of SMB shares. If &#39;true&#39;, Active Directory is disabled.
        /// </summary>
        /// <value>Specifies if Active Directory should be disabled for authentication of SMB shares. If &#39;true&#39;, Active Directory is disabled.</value>
        [DataMember(Name="smbAdDisabled", EmitDefaultValue=true)]
        public bool? SmbAdDisabled { get; set; }

        /// <summary>
        /// Specifies whether SMB multichannel is enabled on the cluster. When this is set to true, then any SMB3 multichannel enabled client can establish multiple TCP connection per session to the Server.
        /// </summary>
        /// <value>Specifies whether SMB multichannel is enabled on the cluster. When this is set to true, then any SMB3 multichannel enabled client can establish multiple TCP connection per session to the Server.</value>
        [DataMember(Name="smbMultichannelEnabled", EmitDefaultValue=true)]
        public bool? SmbMultichannelEnabled { get; set; }

        /// <summary>
        /// TODO(mitch) StigMode is deprecated. Should it still be in this list??
        /// </summary>
        /// <value>TODO(mitch) StigMode is deprecated. Should it still be in this list??</value>
        [DataMember(Name="stigMode", EmitDefaultValue=true)]
        public bool? StigMode { get; set; }

        /// <summary>
        /// Syslog servers.
        /// </summary>
        /// <value>Syslog servers.</value>
        [DataMember(Name="syslogServers", EmitDefaultValue=true)]
        public List<OldSyslogServer> SyslogServers { get; set; }

        /// <summary>
        /// In case multi tenancy is enabled, this flag controls whether multiple tenants can be placed on the same viewbox. Once set to true, this flag should never become false.
        /// </summary>
        /// <value>In case multi tenancy is enabled, this flag controls whether multiple tenants can be placed on the same viewbox. Once set to true, this flag should never become false.</value>
        [DataMember(Name="tenantViewboxSharingEnabled", EmitDefaultValue=true)]
        public bool? TenantViewboxSharingEnabled { get; set; }

        /// <summary>
        /// Gets or Sets TieringAuditLogConfig
        /// </summary>
        [DataMember(Name="tieringAuditLogConfig", EmitDefaultValue=false)]
        public TieringAuditLogConfiguration TieringAuditLogConfig { get; set; }

        /// <summary>
        /// Specifies the timezone to use for showing time in emails, reports, filer audit logs, etc.
        /// </summary>
        /// <value>Specifies the timezone to use for showing time in emails, reports, filer audit logs, etc.</value>
        [DataMember(Name="timezone", EmitDefaultValue=true)]
        public string Timezone { get; set; }

        /// <summary>
        /// Specifies if the cluster is in Turbo mode.
        /// </summary>
        /// <value>Specifies if the cluster is in Turbo mode.</value>
        [DataMember(Name="turboMode", EmitDefaultValue=true)]
        public bool? TurboMode { get; set; }

        /// <summary>
        /// Specifies whether to enable Heimdall which tells whether services should use temporary fleet instances to mount disks by talking to Heimdall.
        /// </summary>
        /// <value>Specifies whether to enable Heimdall which tells whether services should use temporary fleet instances to mount disks by talking to Heimdall.</value>
        [DataMember(Name="useHeimdall", EmitDefaultValue=true)]
        public bool? UseHeimdall { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString() { return ToJson(); }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateClusterParams);
        }

        /// <summary>
        /// Returns true if UpdateClusterParams instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateClusterParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateClusterParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AmqpTargetConfig == input.AmqpTargetConfig ||
                    (this.AmqpTargetConfig != null &&
                    this.AmqpTargetConfig.Equals(input.AmqpTargetConfig))
                ) && 
                (
                    this.AppsSubnet == input.AppsSubnet ||
                    (this.AppsSubnet != null &&
                    this.AppsSubnet.Equals(input.AppsSubnet))
                ) && 
                (
                    this.BannerEnabled == input.BannerEnabled ||
                    (this.BannerEnabled != null &&
                    this.BannerEnabled.Equals(input.BannerEnabled))
                ) && 
                (
                    this.ClusterAuditLogConfig == input.ClusterAuditLogConfig ||
                    (this.ClusterAuditLogConfig != null &&
                    this.ClusterAuditLogConfig.Equals(input.ClusterAuditLogConfig))
                ) && 
                (
                    this.DnsServerIps == input.DnsServerIps ||
                    this.DnsServerIps != null &&
                    input.DnsServerIps != null &&
                    this.DnsServerIps.SequenceEqual(input.DnsServerIps)
                ) && 
                (
                    this.DomainNames == input.DomainNames ||
                    this.DomainNames != null &&
                    input.DomainNames != null &&
                    this.DomainNames.SequenceEqual(input.DomainNames)
                ) && 
                (
                    this.EnableActiveMonitoring == input.EnableActiveMonitoring ||
                    (this.EnableActiveMonitoring != null &&
                    this.EnableActiveMonitoring.Equals(input.EnableActiveMonitoring))
                ) && 
                (
                    this.EnablePatchesDownload == input.EnablePatchesDownload ||
                    (this.EnablePatchesDownload != null &&
                    this.EnablePatchesDownload.Equals(input.EnablePatchesDownload))
                ) && 
                (
                    this.EnableUpgradePkgPolling == input.EnableUpgradePkgPolling ||
                    (this.EnableUpgradePkgPolling != null &&
                    this.EnableUpgradePkgPolling.Equals(input.EnableUpgradePkgPolling))
                ) && 
                (
                    this.EncryptionKeyRotationPeriodSecs == input.EncryptionKeyRotationPeriodSecs ||
                    (this.EncryptionKeyRotationPeriodSecs != null &&
                    this.EncryptionKeyRotationPeriodSecs.Equals(input.EncryptionKeyRotationPeriodSecs))
                ) && 
                (
                    this.FaultToleranceLevel == input.FaultToleranceLevel ||
                    this.FaultToleranceLevel.Equals(input.FaultToleranceLevel)
                ) && 
                (
                    this.FilerAuditLogConfig == input.FilerAuditLogConfig ||
                    (this.FilerAuditLogConfig != null &&
                    this.FilerAuditLogConfig.Equals(input.FilerAuditLogConfig))
                ) && 
                (
                    this.Gateway == input.Gateway ||
                    (this.Gateway != null &&
                    this.Gateway.Equals(input.Gateway))
                ) && 
                (
                    this.GoogleAnalyticsEnabled == input.GoogleAnalyticsEnabled ||
                    (this.GoogleAnalyticsEnabled != null &&
                    this.GoogleAnalyticsEnabled.Equals(input.GoogleAnalyticsEnabled))
                ) && 
                (
                    this.IsDocumentationLocal == input.IsDocumentationLocal ||
                    (this.IsDocumentationLocal != null &&
                    this.IsDocumentationLocal.Equals(input.IsDocumentationLocal))
                ) && 
                (
                    this.KmsServerId == input.KmsServerId ||
                    (this.KmsServerId != null &&
                    this.KmsServerId.Equals(input.KmsServerId))
                ) && 
                (
                    this.LanguageLocale == input.LanguageLocale ||
                    (this.LanguageLocale != null &&
                    this.LanguageLocale.Equals(input.LanguageLocale))
                ) && 
                (
                    this.LocalAuthDomainName == input.LocalAuthDomainName ||
                    (this.LocalAuthDomainName != null &&
                    this.LocalAuthDomainName.Equals(input.LocalAuthDomainName))
                ) && 
                (
                    this.LocalGroupsEnabled == input.LocalGroupsEnabled ||
                    (this.LocalGroupsEnabled != null &&
                    this.LocalGroupsEnabled.Equals(input.LocalGroupsEnabled))
                ) && 
                (
                    this.MetadataFaultToleranceFactor == input.MetadataFaultToleranceFactor ||
                    (this.MetadataFaultToleranceFactor != null &&
                    this.MetadataFaultToleranceFactor.Equals(input.MetadataFaultToleranceFactor))
                ) && 
                (
                    this.MultiTenancyEnabled == input.MultiTenancyEnabled ||
                    (this.MultiTenancyEnabled != null &&
                    this.MultiTenancyEnabled.Equals(input.MultiTenancyEnabled))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NtpSettings == input.NtpSettings ||
                    (this.NtpSettings != null &&
                    this.NtpSettings.Equals(input.NtpSettings))
                ) && 
                (
                    this.PcieSsdTierRebalanceDelaySecs == input.PcieSsdTierRebalanceDelaySecs ||
                    (this.PcieSsdTierRebalanceDelaySecs != null &&
                    this.PcieSsdTierRebalanceDelaySecs.Equals(input.PcieSsdTierRebalanceDelaySecs))
                ) && 
                (
                    this.ProtoRpcEncryptionEnabled == input.ProtoRpcEncryptionEnabled ||
                    (this.ProtoRpcEncryptionEnabled != null &&
                    this.ProtoRpcEncryptionEnabled.Equals(input.ProtoRpcEncryptionEnabled))
                ) && 
                (
                    this.ReverseTunnelEnabled == input.ReverseTunnelEnabled ||
                    (this.ReverseTunnelEnabled != null &&
                    this.ReverseTunnelEnabled.Equals(input.ReverseTunnelEnabled))
                ) && 
                (
                    this.ReverseTunnelEndTimeMsecs == input.ReverseTunnelEndTimeMsecs ||
                    (this.ReverseTunnelEndTimeMsecs != null &&
                    this.ReverseTunnelEndTimeMsecs.Equals(input.ReverseTunnelEndTimeMsecs))
                ) && 
                (
                    this.SecurityModeDod == input.SecurityModeDod ||
                    (this.SecurityModeDod != null &&
                    this.SecurityModeDod.Equals(input.SecurityModeDod))
                ) && 
                (
                    this.SmbAdDisabled == input.SmbAdDisabled ||
                    (this.SmbAdDisabled != null &&
                    this.SmbAdDisabled.Equals(input.SmbAdDisabled))
                ) && 
                (
                    this.SmbMultichannelEnabled == input.SmbMultichannelEnabled ||
                    (this.SmbMultichannelEnabled != null &&
                    this.SmbMultichannelEnabled.Equals(input.SmbMultichannelEnabled))
                ) && 
                (
                    this.StigMode == input.StigMode ||
                    (this.StigMode != null &&
                    this.StigMode.Equals(input.StigMode))
                ) && 
                (
                    this.SyslogServers == input.SyslogServers ||
                    this.SyslogServers != null &&
                    input.SyslogServers != null &&
                    this.SyslogServers.SequenceEqual(input.SyslogServers)
                ) && 
                (
                    this.TenantViewboxSharingEnabled == input.TenantViewboxSharingEnabled ||
                    (this.TenantViewboxSharingEnabled != null &&
                    this.TenantViewboxSharingEnabled.Equals(input.TenantViewboxSharingEnabled))
                ) && 
                (
                    this.TieringAuditLogConfig == input.TieringAuditLogConfig ||
                    (this.TieringAuditLogConfig != null &&
                    this.TieringAuditLogConfig.Equals(input.TieringAuditLogConfig))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && 
                (
                    this.TurboMode == input.TurboMode ||
                    (this.TurboMode != null &&
                    this.TurboMode.Equals(input.TurboMode))
                ) && 
                (
                    this.UseHeimdall == input.UseHeimdall ||
                    (this.UseHeimdall != null &&
                    this.UseHeimdall.Equals(input.UseHeimdall))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AmqpTargetConfig != null)
                    hashCode = hashCode * 59 + this.AmqpTargetConfig.GetHashCode();
                if (this.AppsSubnet != null)
                    hashCode = hashCode * 59 + this.AppsSubnet.GetHashCode();
                if (this.BannerEnabled != null)
                    hashCode = hashCode * 59 + this.BannerEnabled.GetHashCode();
                if (this.ClusterAuditLogConfig != null)
                    hashCode = hashCode * 59 + this.ClusterAuditLogConfig.GetHashCode();
                if (this.DnsServerIps != null)
                    hashCode = hashCode * 59 + this.DnsServerIps.GetHashCode();
                if (this.DomainNames != null)
                    hashCode = hashCode * 59 + this.DomainNames.GetHashCode();
                if (this.EnableActiveMonitoring != null)
                    hashCode = hashCode * 59 + this.EnableActiveMonitoring.GetHashCode();
                if (this.EnablePatchesDownload != null)
                    hashCode = hashCode * 59 + this.EnablePatchesDownload.GetHashCode();
                if (this.EnableUpgradePkgPolling != null)
                    hashCode = hashCode * 59 + this.EnableUpgradePkgPolling.GetHashCode();
                if (this.EncryptionKeyRotationPeriodSecs != null)
                    hashCode = hashCode * 59 + this.EncryptionKeyRotationPeriodSecs.GetHashCode();
                hashCode = hashCode * 59 + this.FaultToleranceLevel.GetHashCode();
                if (this.FilerAuditLogConfig != null)
                    hashCode = hashCode * 59 + this.FilerAuditLogConfig.GetHashCode();
                if (this.Gateway != null)
                    hashCode = hashCode * 59 + this.Gateway.GetHashCode();
                if (this.GoogleAnalyticsEnabled != null)
                    hashCode = hashCode * 59 + this.GoogleAnalyticsEnabled.GetHashCode();
                if (this.IsDocumentationLocal != null)
                    hashCode = hashCode * 59 + this.IsDocumentationLocal.GetHashCode();
                if (this.KmsServerId != null)
                    hashCode = hashCode * 59 + this.KmsServerId.GetHashCode();
                if (this.LanguageLocale != null)
                    hashCode = hashCode * 59 + this.LanguageLocale.GetHashCode();
                if (this.LocalAuthDomainName != null)
                    hashCode = hashCode * 59 + this.LocalAuthDomainName.GetHashCode();
                if (this.LocalGroupsEnabled != null)
                    hashCode = hashCode * 59 + this.LocalGroupsEnabled.GetHashCode();
                if (this.MetadataFaultToleranceFactor != null)
                    hashCode = hashCode * 59 + this.MetadataFaultToleranceFactor.GetHashCode();
                if (this.MultiTenancyEnabled != null)
                    hashCode = hashCode * 59 + this.MultiTenancyEnabled.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NtpSettings != null)
                    hashCode = hashCode * 59 + this.NtpSettings.GetHashCode();
                if (this.PcieSsdTierRebalanceDelaySecs != null)
                    hashCode = hashCode * 59 + this.PcieSsdTierRebalanceDelaySecs.GetHashCode();
                if (this.ProtoRpcEncryptionEnabled != null)
                    hashCode = hashCode * 59 + this.ProtoRpcEncryptionEnabled.GetHashCode();
                if (this.ReverseTunnelEnabled != null)
                    hashCode = hashCode * 59 + this.ReverseTunnelEnabled.GetHashCode();
                if (this.ReverseTunnelEndTimeMsecs != null)
                    hashCode = hashCode * 59 + this.ReverseTunnelEndTimeMsecs.GetHashCode();
                if (this.SecurityModeDod != null)
                    hashCode = hashCode * 59 + this.SecurityModeDod.GetHashCode();
                if (this.SmbAdDisabled != null)
                    hashCode = hashCode * 59 + this.SmbAdDisabled.GetHashCode();
                if (this.SmbMultichannelEnabled != null)
                    hashCode = hashCode * 59 + this.SmbMultichannelEnabled.GetHashCode();
                if (this.StigMode != null)
                    hashCode = hashCode * 59 + this.StigMode.GetHashCode();
                if (this.SyslogServers != null)
                    hashCode = hashCode * 59 + this.SyslogServers.GetHashCode();
                if (this.TenantViewboxSharingEnabled != null)
                    hashCode = hashCode * 59 + this.TenantViewboxSharingEnabled.GetHashCode();
                if (this.TieringAuditLogConfig != null)
                    hashCode = hashCode * 59 + this.TieringAuditLogConfig.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.TurboMode != null)
                    hashCode = hashCode * 59 + this.TurboMode.GetHashCode();
                if (this.UseHeimdall != null)
                    hashCode = hashCode * 59 + this.UseHeimdall.GetHashCode();
                return hashCode;
            }
        }

    }

}


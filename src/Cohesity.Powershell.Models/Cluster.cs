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
    /// Specifies information about the Cohesity Cluster.
    /// </summary>
    [DataContract]
    public partial class Cluster :  IEquatable<Cluster>
    {
        /// <summary>
        /// Specifies the type of Cluster such as kPhysical. &#39;kPhysical&#39; indicates the Cohesity Cluster is hosted directly on hardware. &#39;kVirtualRobo&#39; indicates the Cohesity Cluster is hosted in a VM on a ESXi Host of a VMware vCenter Server using Cohesity&#39;s Virtual Edition. &#39;kMicrosoftCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Microsoft Azure using Cohesity&#39;s Cloud Edition. &#39;kAmazonCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Amazon S3 using Cohesity&#39;s Cloud Edition. &#39;kGoogleCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Google Cloud Platform using Cohesity&#39;s Cloud Edition.
        /// </summary>
        /// <value>Specifies the type of Cluster such as kPhysical. &#39;kPhysical&#39; indicates the Cohesity Cluster is hosted directly on hardware. &#39;kVirtualRobo&#39; indicates the Cohesity Cluster is hosted in a VM on a ESXi Host of a VMware vCenter Server using Cohesity&#39;s Virtual Edition. &#39;kMicrosoftCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Microsoft Azure using Cohesity&#39;s Cloud Edition. &#39;kAmazonCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Amazon S3 using Cohesity&#39;s Cloud Edition. &#39;kGoogleCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Google Cloud Platform using Cohesity&#39;s Cloud Edition.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ClusterTypeEnum
        {
            /// <summary>
            /// Enum KPhysical for value: kPhysical
            /// </summary>
            [EnumMember(Value = "kPhysical")]
            KPhysical = 1,

            /// <summary>
            /// Enum KVirtualRobo for value: kVirtualRobo
            /// </summary>
            [EnumMember(Value = "kVirtualRobo")]
            KVirtualRobo = 2,

            /// <summary>
            /// Enum KMicrosoftCloud for value: kMicrosoftCloud
            /// </summary>
            [EnumMember(Value = "kMicrosoftCloud")]
            KMicrosoftCloud = 3,

            /// <summary>
            /// Enum KAmazonCloud for value: kAmazonCloud
            /// </summary>
            [EnumMember(Value = "kAmazonCloud")]
            KAmazonCloud = 4,

            /// <summary>
            /// Enum KGoogleCloud for value: kGoogleCloud
            /// </summary>
            [EnumMember(Value = "kGoogleCloud")]
            KGoogleCloud = 5

        }

        /// <summary>
        /// Specifies the type of Cluster such as kPhysical. &#39;kPhysical&#39; indicates the Cohesity Cluster is hosted directly on hardware. &#39;kVirtualRobo&#39; indicates the Cohesity Cluster is hosted in a VM on a ESXi Host of a VMware vCenter Server using Cohesity&#39;s Virtual Edition. &#39;kMicrosoftCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Microsoft Azure using Cohesity&#39;s Cloud Edition. &#39;kAmazonCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Amazon S3 using Cohesity&#39;s Cloud Edition. &#39;kGoogleCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Google Cloud Platform using Cohesity&#39;s Cloud Edition.
        /// </summary>
        /// <value>Specifies the type of Cluster such as kPhysical. &#39;kPhysical&#39; indicates the Cohesity Cluster is hosted directly on hardware. &#39;kVirtualRobo&#39; indicates the Cohesity Cluster is hosted in a VM on a ESXi Host of a VMware vCenter Server using Cohesity&#39;s Virtual Edition. &#39;kMicrosoftCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Microsoft Azure using Cohesity&#39;s Cloud Edition. &#39;kAmazonCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Amazon S3 using Cohesity&#39;s Cloud Edition. &#39;kGoogleCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Google Cloud Platform using Cohesity&#39;s Cloud Edition.</value>
        [DataMember(Name="clusterType", EmitDefaultValue=true)]
        public ClusterTypeEnum? ClusterType { get; set; }
        /// <summary>
        /// Specifies the current Cluster-level operation in progress. &#39;kUpgrade&#39; indicates the Cohesity Cluster is upgrading to a new release. &#39;kRemoveNode&#39; indicates the Cohesity Cluster is removing a Node from the Cluster. &#39;kNone&#39; indicates no action is occurring on the Cohesity Cluster. &#39;kDestroy&#39; indicates the Cohesity Cluster is getting destoryed. &#39;kClean&#39; indicates the Cohesity Cluster is getting cleaned. &#39;kRestartServices&#39; indicates the Cohesity Cluster is restarting the services.
        /// </summary>
        /// <value>Specifies the current Cluster-level operation in progress. &#39;kUpgrade&#39; indicates the Cohesity Cluster is upgrading to a new release. &#39;kRemoveNode&#39; indicates the Cohesity Cluster is removing a Node from the Cluster. &#39;kNone&#39; indicates no action is occurring on the Cohesity Cluster. &#39;kDestroy&#39; indicates the Cohesity Cluster is getting destoryed. &#39;kClean&#39; indicates the Cohesity Cluster is getting cleaned. &#39;kRestartServices&#39; indicates the Cohesity Cluster is restarting the services.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CurrentOperationEnum
        {
            /// <summary>
            /// Enum KRemoveNode for value: kRemoveNode
            /// </summary>
            [EnumMember(Value = "kRemoveNode")]
            KRemoveNode = 1,

            /// <summary>
            /// Enum KUpgrade for value: kUpgrade
            /// </summary>
            [EnumMember(Value = "kUpgrade")]
            KUpgrade = 2,

            /// <summary>
            /// Enum KNone for value: kNone
            /// </summary>
            [EnumMember(Value = "kNone")]
            KNone = 3,

            /// <summary>
            /// Enum KDestroy for value: kDestroy
            /// </summary>
            [EnumMember(Value = "kDestroy")]
            KDestroy = 4,

            /// <summary>
            /// Enum KClean for value: kClean
            /// </summary>
            [EnumMember(Value = "kClean")]
            KClean = 5,

            /// <summary>
            /// Enum KRestartServices for value: kRestartServices
            /// </summary>
            [EnumMember(Value = "kRestartServices")]
            KRestartServices = 6

        }

        /// <summary>
        /// Specifies the current Cluster-level operation in progress. &#39;kUpgrade&#39; indicates the Cohesity Cluster is upgrading to a new release. &#39;kRemoveNode&#39; indicates the Cohesity Cluster is removing a Node from the Cluster. &#39;kNone&#39; indicates no action is occurring on the Cohesity Cluster. &#39;kDestroy&#39; indicates the Cohesity Cluster is getting destoryed. &#39;kClean&#39; indicates the Cohesity Cluster is getting cleaned. &#39;kRestartServices&#39; indicates the Cohesity Cluster is restarting the services.
        /// </summary>
        /// <value>Specifies the current Cluster-level operation in progress. &#39;kUpgrade&#39; indicates the Cohesity Cluster is upgrading to a new release. &#39;kRemoveNode&#39; indicates the Cohesity Cluster is removing a Node from the Cluster. &#39;kNone&#39; indicates no action is occurring on the Cohesity Cluster. &#39;kDestroy&#39; indicates the Cohesity Cluster is getting destoryed. &#39;kClean&#39; indicates the Cohesity Cluster is getting cleaned. &#39;kRestartServices&#39; indicates the Cohesity Cluster is restarting the services.</value>
        [DataMember(Name="currentOperation", EmitDefaultValue=true)]
        public CurrentOperationEnum? CurrentOperation { get; set; }
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
        /// Initializes a new instance of the <see cref="Cluster" /> class.
        /// </summary>
        /// <param name="appsSettings">appsSettings.</param>
        /// <param name="assignedRacksCount">Specifies the number of racks in cluster with at least one rack assigned..</param>
        /// <param name="availableMetadataSpace">Information about storage available for metadata.</param>
        /// <param name="bannerEnabled">Specifies whether UI banner is enabled on the cluster or not. When banner is enabled, UI will make an additional API call to fetch the banner and show at the login page..</param>
        /// <param name="chassisCount">Specifies the number of chassis in cluster..</param>
        /// <param name="clusterAuditLogConfig">clusterAuditLogConfig.</param>
        /// <param name="clusterSoftwareVersion">Specifies the current release of the Cohesity software running on this Cohesity Cluster..</param>
        /// <param name="clusterType">Specifies the type of Cluster such as kPhysical. &#39;kPhysical&#39; indicates the Cohesity Cluster is hosted directly on hardware. &#39;kVirtualRobo&#39; indicates the Cohesity Cluster is hosted in a VM on a ESXi Host of a VMware vCenter Server using Cohesity&#39;s Virtual Edition. &#39;kMicrosoftCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Microsoft Azure using Cohesity&#39;s Cloud Edition. &#39;kAmazonCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Amazon S3 using Cohesity&#39;s Cloud Edition. &#39;kGoogleCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Google Cloud Platform using Cohesity&#39;s Cloud Edition..</param>
        /// <param name="createdTimeMsecs">Specifies the time when the Cohesity Cluster was created. This value is specified as a Unix epoch Timestamp (in microseconds)..</param>
        /// <param name="currentOpScheduledTimeSecs">Specifies the time scheduled by the Cohesity Cluster to start the current running operation..</param>
        /// <param name="currentOperation">Specifies the current Cluster-level operation in progress. &#39;kUpgrade&#39; indicates the Cohesity Cluster is upgrading to a new release. &#39;kRemoveNode&#39; indicates the Cohesity Cluster is removing a Node from the Cluster. &#39;kNone&#39; indicates no action is occurring on the Cohesity Cluster. &#39;kDestroy&#39; indicates the Cohesity Cluster is getting destoryed. &#39;kClean&#39; indicates the Cohesity Cluster is getting cleaned. &#39;kRestartServices&#39; indicates the Cohesity Cluster is restarting the services..</param>
        /// <param name="currentTimeMsecs">Specifies the current system time on the Cohesity Cluster. This value is specified as a Unix epoch Timestamp (in microseconds)..</param>
        /// <param name="dnsServerIps">Array of IP Addresses of DNS Servers.  Specifies the IP addresses of the DNS Servers used by the Cohesity Cluster..</param>
        /// <param name="domainNames">Array of Domain Names.  The first domain name specified in the array is the fully qualified domain name assigned to the Cohesity Cluster. Any additional domain names specified are used for the domain search list for hostname look-up..</param>
        /// <param name="enableActiveMonitoring">Specifies if Cohesity can receive monitoring information from the Cohesity Cluster. If &#39;true&#39;, remote monitoring of the Cohesity Cluster is allowed..</param>
        /// <param name="enableUpgradePkgPolling">If &#39;true&#39;, Cohesity&#39;s upgrade server is polled for new releases..</param>
        /// <param name="encryptionEnabled">If &#39;true&#39;, the entire Cohesity Cluster is encrypted including all View Boxes..</param>
        /// <param name="encryptionKeyRotationPeriodSecs">Specifies the period of time (in seconds) when encryption keys are rotated. By default, the encryption keys are rotated every 77760000 seconds (30 days)..</param>
        /// <param name="eulaConfig">Specifies the End User License Agreement (EULA) acceptance information..</param>
        /// <param name="faultToleranceLevel">Specifies the level which &#39;MetadataFaultToleranceFactor&#39; applies to. &#39;kNode&#39; indicates &#39;MetadataFaultToleranceFactor&#39; applies to Node level. &#39;kChassis&#39; indicates &#39;MetadataFaultToleranceFactor&#39; applies to Chassis level. &#39;kRack&#39; indicates &#39;MetadataFaultToleranceFactor&#39; applies to Rack level..</param>
        /// <param name="filerAuditLogConfig">filerAuditLogConfig.</param>
        /// <param name="fipsModeEnabled">Specifies if the Cohesity Cluster should operate in the FIPS mode, which is compliant with the Federal Information Processing Standard 140-2 certification..</param>
        /// <param name="gateway">Specifies the gateway IP address..</param>
        /// <param name="googleAnalyticsEnabled">Specifies whether Google Analytics is enabled..</param>
        /// <param name="hardwareInfo">hardwareInfo.</param>
        /// <param name="id">Specifies the unique id of Cohesity Cluster..</param>
        /// <param name="incarnationId">Specifies the unique incarnation id of the Cohesity Cluster..</param>
        /// <param name="ipPreference">IP preference.</param>
        /// <param name="isDocumentationLocal">Specifies what version of the documentation is used. If &#39;true&#39;, the version of documentation stored locally on the Cohesity Cluster is used. If &#39;false&#39;, the documentation stored on a Cohesity Web Server is used. The default is &#39;false&#39;. Cohesity recommends accessing the Help from the Cohesity Web site which provides the newest and most complete version of Help..</param>
        /// <param name="languageLocale">Specifies the language and locale for this Cohesity Cluster..</param>
        /// <param name="licenseState">Specifies the Licensing State information..</param>
        /// <param name="localAuthDomainName">Domain name for SMB local authentication..</param>
        /// <param name="localGroupsEnabled">Specifies whether to enable local groups on cluster. Once it is enabled, it cannot be disabled..</param>
        /// <param name="metadataFaultToleranceFactor">Specifies metadata fault tolerance setting for the cluster. This denotes the number of simultaneous failures[node] supported by metadata services like gandalf and scribe..</param>
        /// <param name="multiTenancyEnabled">Specifies if multi tenancy is enabled in the cluster. Authentication &amp; Authorization will always use tenant_id, however, some UI elements may be disabled when multi tenancy is disabled..</param>
        /// <param name="name">Specifies the name of the Cohesity Cluster..</param>
        /// <param name="nodeCount">Specifies the number of Nodes in the Cohesity Cluster..</param>
        /// <param name="nodeIps">IP addresses of nodes in the cluster.</param>
        /// <param name="ntpSettings">ntpSettings.</param>
        /// <param name="pcieSsdTierRebalanceDelaySecs">Specifies the rebalance delay in seconds for cluster PcieSSD storage tier..</param>
        /// <param name="proxyVMSubnet">The subnet reserved for ProxyVM.</param>
        /// <param name="reverseTunnelEnabled">If &#39;true&#39;, Cohesity&#39;s Remote Tunnel is enabled. Cohesity can access the Cluster and provide remote assistance via a Remote Tunnel..</param>
        /// <param name="reverseTunnelEndTimeMsecs">ReverseTunnelEndTimeMsecs specifies the end time in milliseconds since epoch until when the reverse tunnel will stay enabled..</param>
        /// <param name="schemaInfoList">Specifies the time series schema info of the cluster..</param>
        /// <param name="smbAdDisabled">Specifies if Active Directory should be disabled for authentication of SMB shares. If &#39;true&#39;, Active Directory is disabled..</param>
        /// <param name="stats">stats.</param>
        /// <param name="stigMode">Specifies if STIG mode is enabled or not..</param>
        /// <param name="supportedConfig">supportedConfig.</param>
        /// <param name="targetSoftwareVersion">Specifies the Cohesity release that this Cluster is being upgraded to if an upgrade operation is in progress..</param>
        /// <param name="tenantViewboxSharingEnabled">In case multi tenancy is enabled, this flag controls whether multiple tenants can be placed on the same viewbox. Once set to true, this flag should never become false..</param>
        /// <param name="timezone">Specifies the timezone to use for showing time in emails, reports, filer audit logs, etc..</param>
        /// <param name="turboMode">Specifies if the cluster is in Turbo mode..</param>
        /// <param name="usedMetadataSpacePct">UsedMetadataSpacePct measures the percentage about storage used for metadata over the total storage available for metadata.</param>
        public Cluster(AppsConfig appsSettings = default(AppsConfig), int? assignedRacksCount = default(int?), long? availableMetadataSpace = default(long?), bool? bannerEnabled = default(bool?), int? chassisCount = default(int?), ClusterAuditLogConfiguration clusterAuditLogConfig = default(ClusterAuditLogConfiguration), string clusterSoftwareVersion = default(string), ClusterTypeEnum? clusterType = default(ClusterTypeEnum?), long? createdTimeMsecs = default(long?), long? currentOpScheduledTimeSecs = default(long?), CurrentOperationEnum? currentOperation = default(CurrentOperationEnum?), long? currentTimeMsecs = default(long?), List<string> dnsServerIps = default(List<string>), List<string> domainNames = default(List<string>), bool? enableActiveMonitoring = default(bool?), bool? enableUpgradePkgPolling = default(bool?), bool? encryptionEnabled = default(bool?), long? encryptionKeyRotationPeriodSecs = default(long?), EulaConfig eulaConfig = default(EulaConfig), FaultToleranceLevelEnum? faultToleranceLevel = default(FaultToleranceLevelEnum?), FilerAuditLogConfiguration filerAuditLogConfig = default(FilerAuditLogConfiguration), bool? fipsModeEnabled = default(bool?), string gateway = default(string), bool? googleAnalyticsEnabled = default(bool?), ClusterHardwareInfo hardwareInfo = default(ClusterHardwareInfo), long? id = default(long?), long? incarnationId = default(long?), int? ipPreference = default(int?), bool? isDocumentationLocal = default(bool?), string languageLocale = default(string), LicenseState licenseState = default(LicenseState), string localAuthDomainName = default(string), bool? localGroupsEnabled = default(bool?), int? metadataFaultToleranceFactor = default(int?), bool? multiTenancyEnabled = default(bool?), string name = default(string), long? nodeCount = default(long?), string nodeIps = default(string), NtpSettingsConfig ntpSettings = default(NtpSettingsConfig), int? pcieSsdTierRebalanceDelaySecs = default(int?), string proxyVMSubnet = default(string), bool? reverseTunnelEnabled = default(bool?), long? reverseTunnelEndTimeMsecs = default(long?), List<SchemaInfo> schemaInfoList = default(List<SchemaInfo>), bool? smbAdDisabled = default(bool?), ClusterStats stats = default(ClusterStats), bool? stigMode = default(bool?), SupportedConfig supportedConfig = default(SupportedConfig), string targetSoftwareVersion = default(string), bool? tenantViewboxSharingEnabled = default(bool?), string timezone = default(string), bool? turboMode = default(bool?), double? usedMetadataSpacePct = default(double?))
        {
            this.AssignedRacksCount = assignedRacksCount;
            this.AvailableMetadataSpace = availableMetadataSpace;
            this.BannerEnabled = bannerEnabled;
            this.ChassisCount = chassisCount;
            this.ClusterSoftwareVersion = clusterSoftwareVersion;
            this.ClusterType = clusterType;
            this.CreatedTimeMsecs = createdTimeMsecs;
            this.CurrentOpScheduledTimeSecs = currentOpScheduledTimeSecs;
            this.CurrentOperation = currentOperation;
            this.CurrentTimeMsecs = currentTimeMsecs;
            this.DnsServerIps = dnsServerIps;
            this.DomainNames = domainNames;
            this.EnableActiveMonitoring = enableActiveMonitoring;
            this.EnableUpgradePkgPolling = enableUpgradePkgPolling;
            this.EncryptionEnabled = encryptionEnabled;
            this.EncryptionKeyRotationPeriodSecs = encryptionKeyRotationPeriodSecs;
            this.EulaConfig = eulaConfig;
            this.FaultToleranceLevel = faultToleranceLevel;
            this.FipsModeEnabled = fipsModeEnabled;
            this.Gateway = gateway;
            this.GoogleAnalyticsEnabled = googleAnalyticsEnabled;
            this.Id = id;
            this.IncarnationId = incarnationId;
            this.IpPreference = ipPreference;
            this.IsDocumentationLocal = isDocumentationLocal;
            this.LanguageLocale = languageLocale;
            this.LicenseState = licenseState;
            this.LocalAuthDomainName = localAuthDomainName;
            this.LocalGroupsEnabled = localGroupsEnabled;
            this.MetadataFaultToleranceFactor = metadataFaultToleranceFactor;
            this.MultiTenancyEnabled = multiTenancyEnabled;
            this.Name = name;
            this.NodeCount = nodeCount;
            this.NodeIps = nodeIps;
            this.PcieSsdTierRebalanceDelaySecs = pcieSsdTierRebalanceDelaySecs;
            this.ProxyVMSubnet = proxyVMSubnet;
            this.ReverseTunnelEnabled = reverseTunnelEnabled;
            this.ReverseTunnelEndTimeMsecs = reverseTunnelEndTimeMsecs;
            this.SchemaInfoList = schemaInfoList;
            this.SmbAdDisabled = smbAdDisabled;
            this.StigMode = stigMode;
            this.TargetSoftwareVersion = targetSoftwareVersion;
            this.TenantViewboxSharingEnabled = tenantViewboxSharingEnabled;
            this.Timezone = timezone;
            this.TurboMode = turboMode;
            this.UsedMetadataSpacePct = usedMetadataSpacePct;
            this.AppsSettings = appsSettings;
            this.AssignedRacksCount = assignedRacksCount;
            this.AvailableMetadataSpace = availableMetadataSpace;
            this.BannerEnabled = bannerEnabled;
            this.ChassisCount = chassisCount;
            this.ClusterAuditLogConfig = clusterAuditLogConfig;
            this.ClusterSoftwareVersion = clusterSoftwareVersion;
            this.ClusterType = clusterType;
            this.CreatedTimeMsecs = createdTimeMsecs;
            this.CurrentOpScheduledTimeSecs = currentOpScheduledTimeSecs;
            this.CurrentOperation = currentOperation;
            this.CurrentTimeMsecs = currentTimeMsecs;
            this.DnsServerIps = dnsServerIps;
            this.DomainNames = domainNames;
            this.EnableActiveMonitoring = enableActiveMonitoring;
            this.EnableUpgradePkgPolling = enableUpgradePkgPolling;
            this.EncryptionEnabled = encryptionEnabled;
            this.EncryptionKeyRotationPeriodSecs = encryptionKeyRotationPeriodSecs;
            this.EulaConfig = eulaConfig;
            this.FaultToleranceLevel = faultToleranceLevel;
            this.FilerAuditLogConfig = filerAuditLogConfig;
            this.FipsModeEnabled = fipsModeEnabled;
            this.Gateway = gateway;
            this.GoogleAnalyticsEnabled = googleAnalyticsEnabled;
            this.HardwareInfo = hardwareInfo;
            this.Id = id;
            this.IncarnationId = incarnationId;
            this.IpPreference = ipPreference;
            this.IsDocumentationLocal = isDocumentationLocal;
            this.LanguageLocale = languageLocale;
            this.LicenseState = licenseState;
            this.LocalAuthDomainName = localAuthDomainName;
            this.LocalGroupsEnabled = localGroupsEnabled;
            this.MetadataFaultToleranceFactor = metadataFaultToleranceFactor;
            this.MultiTenancyEnabled = multiTenancyEnabled;
            this.Name = name;
            this.NodeCount = nodeCount;
            this.NodeIps = nodeIps;
            this.NtpSettings = ntpSettings;
            this.PcieSsdTierRebalanceDelaySecs = pcieSsdTierRebalanceDelaySecs;
            this.ProxyVMSubnet = proxyVMSubnet;
            this.ReverseTunnelEnabled = reverseTunnelEnabled;
            this.ReverseTunnelEndTimeMsecs = reverseTunnelEndTimeMsecs;
            this.SchemaInfoList = schemaInfoList;
            this.SmbAdDisabled = smbAdDisabled;
            this.Stats = stats;
            this.StigMode = stigMode;
            this.SupportedConfig = supportedConfig;
            this.TargetSoftwareVersion = targetSoftwareVersion;
            this.TenantViewboxSharingEnabled = tenantViewboxSharingEnabled;
            this.Timezone = timezone;
            this.TurboMode = turboMode;
            this.UsedMetadataSpacePct = usedMetadataSpacePct;
        }
        
        /// <summary>
        /// Gets or Sets AppsSettings
        /// </summary>
        [DataMember(Name="appsSettings", EmitDefaultValue=false)]
        public AppsConfig AppsSettings { get; set; }

        /// <summary>
        /// Specifies the number of racks in cluster with at least one rack assigned.
        /// </summary>
        /// <value>Specifies the number of racks in cluster with at least one rack assigned.</value>
        [DataMember(Name="assignedRacksCount", EmitDefaultValue=true)]
        public int? AssignedRacksCount { get; set; }

        /// <summary>
        /// Information about storage available for metadata
        /// </summary>
        /// <value>Information about storage available for metadata</value>
        [DataMember(Name="availableMetadataSpace", EmitDefaultValue=true)]
        public long? AvailableMetadataSpace { get; set; }

        /// <summary>
        /// Specifies whether UI banner is enabled on the cluster or not. When banner is enabled, UI will make an additional API call to fetch the banner and show at the login page.
        /// </summary>
        /// <value>Specifies whether UI banner is enabled on the cluster or not. When banner is enabled, UI will make an additional API call to fetch the banner and show at the login page.</value>
        [DataMember(Name="bannerEnabled", EmitDefaultValue=true)]
        public bool? BannerEnabled { get; set; }

        /// <summary>
        /// Specifies the number of chassis in cluster.
        /// </summary>
        /// <value>Specifies the number of chassis in cluster.</value>
        [DataMember(Name="chassisCount", EmitDefaultValue=true)]
        public int? ChassisCount { get; set; }

        /// <summary>
        /// Gets or Sets ClusterAuditLogConfig
        /// </summary>
        [DataMember(Name="clusterAuditLogConfig", EmitDefaultValue=false)]
        public ClusterAuditLogConfiguration ClusterAuditLogConfig { get; set; }

        /// <summary>
        /// Specifies the current release of the Cohesity software running on this Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the current release of the Cohesity software running on this Cohesity Cluster.</value>
        [DataMember(Name="clusterSoftwareVersion", EmitDefaultValue=true)]
        public string ClusterSoftwareVersion { get; set; }

        /// <summary>
        /// Specifies the time when the Cohesity Cluster was created. This value is specified as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the time when the Cohesity Cluster was created. This value is specified as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="createdTimeMsecs", EmitDefaultValue=true)]
        public long? CreatedTimeMsecs { get; set; }

        /// <summary>
        /// Specifies the time scheduled by the Cohesity Cluster to start the current running operation.
        /// </summary>
        /// <value>Specifies the time scheduled by the Cohesity Cluster to start the current running operation.</value>
        [DataMember(Name="currentOpScheduledTimeSecs", EmitDefaultValue=true)]
        public long? CurrentOpScheduledTimeSecs { get; set; }

        /// <summary>
        /// Specifies the current system time on the Cohesity Cluster. This value is specified as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the current system time on the Cohesity Cluster. This value is specified as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="currentTimeMsecs", EmitDefaultValue=true)]
        public long? CurrentTimeMsecs { get; set; }

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
        /// If &#39;true&#39;, Cohesity&#39;s upgrade server is polled for new releases.
        /// </summary>
        /// <value>If &#39;true&#39;, Cohesity&#39;s upgrade server is polled for new releases.</value>
        [DataMember(Name="enableUpgradePkgPolling", EmitDefaultValue=true)]
        public bool? EnableUpgradePkgPolling { get; set; }

        /// <summary>
        /// If &#39;true&#39;, the entire Cohesity Cluster is encrypted including all View Boxes.
        /// </summary>
        /// <value>If &#39;true&#39;, the entire Cohesity Cluster is encrypted including all View Boxes.</value>
        [DataMember(Name="encryptionEnabled", EmitDefaultValue=true)]
        public bool? EncryptionEnabled { get; set; }

        /// <summary>
        /// Specifies the period of time (in seconds) when encryption keys are rotated. By default, the encryption keys are rotated every 77760000 seconds (30 days).
        /// </summary>
        /// <value>Specifies the period of time (in seconds) when encryption keys are rotated. By default, the encryption keys are rotated every 77760000 seconds (30 days).</value>
        [DataMember(Name="encryptionKeyRotationPeriodSecs", EmitDefaultValue=true)]
        public long? EncryptionKeyRotationPeriodSecs { get; set; }

        /// <summary>
        /// Specifies the End User License Agreement (EULA) acceptance information.
        /// </summary>
        /// <value>Specifies the End User License Agreement (EULA) acceptance information.</value>
        [DataMember(Name="eulaConfig", EmitDefaultValue=true)]
        public EulaConfig EulaConfig { get; set; }

        /// <summary>
        /// Gets or Sets FilerAuditLogConfig
        /// </summary>
        [DataMember(Name="filerAuditLogConfig", EmitDefaultValue=false)]
        public FilerAuditLogConfiguration FilerAuditLogConfig { get; set; }

        /// <summary>
        /// Specifies if the Cohesity Cluster should operate in the FIPS mode, which is compliant with the Federal Information Processing Standard 140-2 certification.
        /// </summary>
        /// <value>Specifies if the Cohesity Cluster should operate in the FIPS mode, which is compliant with the Federal Information Processing Standard 140-2 certification.</value>
        [DataMember(Name="fipsModeEnabled", EmitDefaultValue=true)]
        public bool? FipsModeEnabled { get; set; }

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
        /// Gets or Sets HardwareInfo
        /// </summary>
        [DataMember(Name="hardwareInfo", EmitDefaultValue=false)]
        public ClusterHardwareInfo HardwareInfo { get; set; }

        /// <summary>
        /// Specifies the unique id of Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the unique id of Cohesity Cluster.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Specifies the unique incarnation id of the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the unique incarnation id of the Cohesity Cluster.</value>
        [DataMember(Name="incarnationId", EmitDefaultValue=true)]
        public long? IncarnationId { get; set; }

        /// <summary>
        /// IP preference
        /// </summary>
        /// <value>IP preference</value>
        [DataMember(Name="ipPreference", EmitDefaultValue=true)]
        public int? IpPreference { get; set; }

        /// <summary>
        /// Specifies what version of the documentation is used. If &#39;true&#39;, the version of documentation stored locally on the Cohesity Cluster is used. If &#39;false&#39;, the documentation stored on a Cohesity Web Server is used. The default is &#39;false&#39;. Cohesity recommends accessing the Help from the Cohesity Web site which provides the newest and most complete version of Help.
        /// </summary>
        /// <value>Specifies what version of the documentation is used. If &#39;true&#39;, the version of documentation stored locally on the Cohesity Cluster is used. If &#39;false&#39;, the documentation stored on a Cohesity Web Server is used. The default is &#39;false&#39;. Cohesity recommends accessing the Help from the Cohesity Web site which provides the newest and most complete version of Help.</value>
        [DataMember(Name="isDocumentationLocal", EmitDefaultValue=true)]
        public bool? IsDocumentationLocal { get; set; }

        /// <summary>
        /// Specifies the language and locale for this Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the language and locale for this Cohesity Cluster.</value>
        [DataMember(Name="languageLocale", EmitDefaultValue=true)]
        public string LanguageLocale { get; set; }

        /// <summary>
        /// Specifies the Licensing State information.
        /// </summary>
        /// <value>Specifies the Licensing State information.</value>
        [DataMember(Name="licenseState", EmitDefaultValue=true)]
        public LicenseState LicenseState { get; set; }

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
        /// Specifies the number of Nodes in the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the number of Nodes in the Cohesity Cluster.</value>
        [DataMember(Name="nodeCount", EmitDefaultValue=true)]
        public long? NodeCount { get; set; }

        /// <summary>
        /// IP addresses of nodes in the cluster
        /// </summary>
        /// <value>IP addresses of nodes in the cluster</value>
        [DataMember(Name="nodeIps", EmitDefaultValue=true)]
        public string NodeIps { get; set; }

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
        /// The subnet reserved for ProxyVM
        /// </summary>
        /// <value>The subnet reserved for ProxyVM</value>
        [DataMember(Name="proxyVMSubnet", EmitDefaultValue=true)]
        public string ProxyVMSubnet { get; set; }

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
        /// Specifies the time series schema info of the cluster.
        /// </summary>
        /// <value>Specifies the time series schema info of the cluster.</value>
        [DataMember(Name="schemaInfoList", EmitDefaultValue=true)]
        public List<SchemaInfo> SchemaInfoList { get; set; }

        /// <summary>
        /// Specifies if Active Directory should be disabled for authentication of SMB shares. If &#39;true&#39;, Active Directory is disabled.
        /// </summary>
        /// <value>Specifies if Active Directory should be disabled for authentication of SMB shares. If &#39;true&#39;, Active Directory is disabled.</value>
        [DataMember(Name="smbAdDisabled", EmitDefaultValue=true)]
        public bool? SmbAdDisabled { get; set; }

        /// <summary>
        /// Gets or Sets Stats
        /// </summary>
        [DataMember(Name="stats", EmitDefaultValue=false)]
        public ClusterStats Stats { get; set; }

        /// <summary>
        /// Specifies if STIG mode is enabled or not.
        /// </summary>
        /// <value>Specifies if STIG mode is enabled or not.</value>
        [DataMember(Name="stigMode", EmitDefaultValue=true)]
        public bool? StigMode { get; set; }

        /// <summary>
        /// Gets or Sets SupportedConfig
        /// </summary>
        [DataMember(Name="supportedConfig", EmitDefaultValue=false)]
        public SupportedConfig SupportedConfig { get; set; }

        /// <summary>
        /// Specifies the Cohesity release that this Cluster is being upgraded to if an upgrade operation is in progress.
        /// </summary>
        /// <value>Specifies the Cohesity release that this Cluster is being upgraded to if an upgrade operation is in progress.</value>
        [DataMember(Name="targetSoftwareVersion", EmitDefaultValue=true)]
        public string TargetSoftwareVersion { get; set; }

        /// <summary>
        /// In case multi tenancy is enabled, this flag controls whether multiple tenants can be placed on the same viewbox. Once set to true, this flag should never become false.
        /// </summary>
        /// <value>In case multi tenancy is enabled, this flag controls whether multiple tenants can be placed on the same viewbox. Once set to true, this flag should never become false.</value>
        [DataMember(Name="tenantViewboxSharingEnabled", EmitDefaultValue=true)]
        public bool? TenantViewboxSharingEnabled { get; set; }

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
        /// UsedMetadataSpacePct measures the percentage about storage used for metadata over the total storage available for metadata
        /// </summary>
        /// <value>UsedMetadataSpacePct measures the percentage about storage used for metadata over the total storage available for metadata</value>
        [DataMember(Name="usedMetadataSpacePct", EmitDefaultValue=true)]
        public double? UsedMetadataSpacePct { get; set; }

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
            return this.Equals(input as Cluster);
        }

        /// <summary>
        /// Returns true if Cluster instances are equal
        /// </summary>
        /// <param name="input">Instance of Cluster to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Cluster input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppsSettings == input.AppsSettings ||
                    (this.AppsSettings != null &&
                    this.AppsSettings.Equals(input.AppsSettings))
                ) && 
                (
                    this.AssignedRacksCount == input.AssignedRacksCount ||
                    (this.AssignedRacksCount != null &&
                    this.AssignedRacksCount.Equals(input.AssignedRacksCount))
                ) && 
                (
                    this.AvailableMetadataSpace == input.AvailableMetadataSpace ||
                    (this.AvailableMetadataSpace != null &&
                    this.AvailableMetadataSpace.Equals(input.AvailableMetadataSpace))
                ) && 
                (
                    this.BannerEnabled == input.BannerEnabled ||
                    (this.BannerEnabled != null &&
                    this.BannerEnabled.Equals(input.BannerEnabled))
                ) && 
                (
                    this.ChassisCount == input.ChassisCount ||
                    (this.ChassisCount != null &&
                    this.ChassisCount.Equals(input.ChassisCount))
                ) && 
                (
                    this.ClusterAuditLogConfig == input.ClusterAuditLogConfig ||
                    (this.ClusterAuditLogConfig != null &&
                    this.ClusterAuditLogConfig.Equals(input.ClusterAuditLogConfig))
                ) && 
                (
                    this.ClusterSoftwareVersion == input.ClusterSoftwareVersion ||
                    (this.ClusterSoftwareVersion != null &&
                    this.ClusterSoftwareVersion.Equals(input.ClusterSoftwareVersion))
                ) && 
                (
                    this.ClusterType == input.ClusterType ||
                    this.ClusterType.Equals(input.ClusterType)
                ) && 
                (
                    this.CreatedTimeMsecs == input.CreatedTimeMsecs ||
                    (this.CreatedTimeMsecs != null &&
                    this.CreatedTimeMsecs.Equals(input.CreatedTimeMsecs))
                ) && 
                (
                    this.CurrentOpScheduledTimeSecs == input.CurrentOpScheduledTimeSecs ||
                    (this.CurrentOpScheduledTimeSecs != null &&
                    this.CurrentOpScheduledTimeSecs.Equals(input.CurrentOpScheduledTimeSecs))
                ) && 
                (
                    this.CurrentOperation == input.CurrentOperation ||
                    this.CurrentOperation.Equals(input.CurrentOperation)
                ) && 
                (
                    this.CurrentTimeMsecs == input.CurrentTimeMsecs ||
                    (this.CurrentTimeMsecs != null &&
                    this.CurrentTimeMsecs.Equals(input.CurrentTimeMsecs))
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
                    this.EnableUpgradePkgPolling == input.EnableUpgradePkgPolling ||
                    (this.EnableUpgradePkgPolling != null &&
                    this.EnableUpgradePkgPolling.Equals(input.EnableUpgradePkgPolling))
                ) && 
                (
                    this.EncryptionEnabled == input.EncryptionEnabled ||
                    (this.EncryptionEnabled != null &&
                    this.EncryptionEnabled.Equals(input.EncryptionEnabled))
                ) && 
                (
                    this.EncryptionKeyRotationPeriodSecs == input.EncryptionKeyRotationPeriodSecs ||
                    (this.EncryptionKeyRotationPeriodSecs != null &&
                    this.EncryptionKeyRotationPeriodSecs.Equals(input.EncryptionKeyRotationPeriodSecs))
                ) && 
                (
                    this.EulaConfig == input.EulaConfig ||
                    (this.EulaConfig != null &&
                    this.EulaConfig.Equals(input.EulaConfig))
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
                    this.FipsModeEnabled == input.FipsModeEnabled ||
                    (this.FipsModeEnabled != null &&
                    this.FipsModeEnabled.Equals(input.FipsModeEnabled))
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
                    this.HardwareInfo == input.HardwareInfo ||
                    (this.HardwareInfo != null &&
                    this.HardwareInfo.Equals(input.HardwareInfo))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IncarnationId == input.IncarnationId ||
                    (this.IncarnationId != null &&
                    this.IncarnationId.Equals(input.IncarnationId))
                ) && 
                (
                    this.IpPreference == input.IpPreference ||
                    (this.IpPreference != null &&
                    this.IpPreference.Equals(input.IpPreference))
                ) && 
                (
                    this.IsDocumentationLocal == input.IsDocumentationLocal ||
                    (this.IsDocumentationLocal != null &&
                    this.IsDocumentationLocal.Equals(input.IsDocumentationLocal))
                ) && 
                (
                    this.LanguageLocale == input.LanguageLocale ||
                    (this.LanguageLocale != null &&
                    this.LanguageLocale.Equals(input.LanguageLocale))
                ) && 
                (
                    this.LicenseState == input.LicenseState ||
                    (this.LicenseState != null &&
                    this.LicenseState.Equals(input.LicenseState))
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
                    this.NodeCount == input.NodeCount ||
                    (this.NodeCount != null &&
                    this.NodeCount.Equals(input.NodeCount))
                ) && 
                (
                    this.NodeIps == input.NodeIps ||
                    (this.NodeIps != null &&
                    this.NodeIps.Equals(input.NodeIps))
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
                    this.ProxyVMSubnet == input.ProxyVMSubnet ||
                    (this.ProxyVMSubnet != null &&
                    this.ProxyVMSubnet.Equals(input.ProxyVMSubnet))
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
                    this.SchemaInfoList == input.SchemaInfoList ||
                    this.SchemaInfoList != null &&
                    input.SchemaInfoList != null &&
                    this.SchemaInfoList.SequenceEqual(input.SchemaInfoList)
                ) && 
                (
                    this.SmbAdDisabled == input.SmbAdDisabled ||
                    (this.SmbAdDisabled != null &&
                    this.SmbAdDisabled.Equals(input.SmbAdDisabled))
                ) && 
                (
                    this.Stats == input.Stats ||
                    (this.Stats != null &&
                    this.Stats.Equals(input.Stats))
                ) && 
                (
                    this.StigMode == input.StigMode ||
                    (this.StigMode != null &&
                    this.StigMode.Equals(input.StigMode))
                ) && 
                (
                    this.SupportedConfig == input.SupportedConfig ||
                    (this.SupportedConfig != null &&
                    this.SupportedConfig.Equals(input.SupportedConfig))
                ) && 
                (
                    this.TargetSoftwareVersion == input.TargetSoftwareVersion ||
                    (this.TargetSoftwareVersion != null &&
                    this.TargetSoftwareVersion.Equals(input.TargetSoftwareVersion))
                ) && 
                (
                    this.TenantViewboxSharingEnabled == input.TenantViewboxSharingEnabled ||
                    (this.TenantViewboxSharingEnabled != null &&
                    this.TenantViewboxSharingEnabled.Equals(input.TenantViewboxSharingEnabled))
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
                    this.UsedMetadataSpacePct == input.UsedMetadataSpacePct ||
                    (this.UsedMetadataSpacePct != null &&
                    this.UsedMetadataSpacePct.Equals(input.UsedMetadataSpacePct))
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
                if (this.AppsSettings != null)
                    hashCode = hashCode * 59 + this.AppsSettings.GetHashCode();
                if (this.AssignedRacksCount != null)
                    hashCode = hashCode * 59 + this.AssignedRacksCount.GetHashCode();
                if (this.AvailableMetadataSpace != null)
                    hashCode = hashCode * 59 + this.AvailableMetadataSpace.GetHashCode();
                if (this.BannerEnabled != null)
                    hashCode = hashCode * 59 + this.BannerEnabled.GetHashCode();
                if (this.ChassisCount != null)
                    hashCode = hashCode * 59 + this.ChassisCount.GetHashCode();
                if (this.ClusterAuditLogConfig != null)
                    hashCode = hashCode * 59 + this.ClusterAuditLogConfig.GetHashCode();
                if (this.ClusterSoftwareVersion != null)
                    hashCode = hashCode * 59 + this.ClusterSoftwareVersion.GetHashCode();
                hashCode = hashCode * 59 + this.ClusterType.GetHashCode();
                if (this.CreatedTimeMsecs != null)
                    hashCode = hashCode * 59 + this.CreatedTimeMsecs.GetHashCode();
                if (this.CurrentOpScheduledTimeSecs != null)
                    hashCode = hashCode * 59 + this.CurrentOpScheduledTimeSecs.GetHashCode();
                hashCode = hashCode * 59 + this.CurrentOperation.GetHashCode();
                if (this.CurrentTimeMsecs != null)
                    hashCode = hashCode * 59 + this.CurrentTimeMsecs.GetHashCode();
                if (this.DnsServerIps != null)
                    hashCode = hashCode * 59 + this.DnsServerIps.GetHashCode();
                if (this.DomainNames != null)
                    hashCode = hashCode * 59 + this.DomainNames.GetHashCode();
                if (this.EnableActiveMonitoring != null)
                    hashCode = hashCode * 59 + this.EnableActiveMonitoring.GetHashCode();
                if (this.EnableUpgradePkgPolling != null)
                    hashCode = hashCode * 59 + this.EnableUpgradePkgPolling.GetHashCode();
                if (this.EncryptionEnabled != null)
                    hashCode = hashCode * 59 + this.EncryptionEnabled.GetHashCode();
                if (this.EncryptionKeyRotationPeriodSecs != null)
                    hashCode = hashCode * 59 + this.EncryptionKeyRotationPeriodSecs.GetHashCode();
                if (this.EulaConfig != null)
                    hashCode = hashCode * 59 + this.EulaConfig.GetHashCode();
                hashCode = hashCode * 59 + this.FaultToleranceLevel.GetHashCode();
                if (this.FilerAuditLogConfig != null)
                    hashCode = hashCode * 59 + this.FilerAuditLogConfig.GetHashCode();
                if (this.FipsModeEnabled != null)
                    hashCode = hashCode * 59 + this.FipsModeEnabled.GetHashCode();
                if (this.Gateway != null)
                    hashCode = hashCode * 59 + this.Gateway.GetHashCode();
                if (this.GoogleAnalyticsEnabled != null)
                    hashCode = hashCode * 59 + this.GoogleAnalyticsEnabled.GetHashCode();
                if (this.HardwareInfo != null)
                    hashCode = hashCode * 59 + this.HardwareInfo.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IncarnationId != null)
                    hashCode = hashCode * 59 + this.IncarnationId.GetHashCode();
                if (this.IpPreference != null)
                    hashCode = hashCode * 59 + this.IpPreference.GetHashCode();
                if (this.IsDocumentationLocal != null)
                    hashCode = hashCode * 59 + this.IsDocumentationLocal.GetHashCode();
                if (this.LanguageLocale != null)
                    hashCode = hashCode * 59 + this.LanguageLocale.GetHashCode();
                if (this.LicenseState != null)
                    hashCode = hashCode * 59 + this.LicenseState.GetHashCode();
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
                if (this.NodeCount != null)
                    hashCode = hashCode * 59 + this.NodeCount.GetHashCode();
                if (this.NodeIps != null)
                    hashCode = hashCode * 59 + this.NodeIps.GetHashCode();
                if (this.NtpSettings != null)
                    hashCode = hashCode * 59 + this.NtpSettings.GetHashCode();
                if (this.PcieSsdTierRebalanceDelaySecs != null)
                    hashCode = hashCode * 59 + this.PcieSsdTierRebalanceDelaySecs.GetHashCode();
                if (this.ProxyVMSubnet != null)
                    hashCode = hashCode * 59 + this.ProxyVMSubnet.GetHashCode();
                if (this.ReverseTunnelEnabled != null)
                    hashCode = hashCode * 59 + this.ReverseTunnelEnabled.GetHashCode();
                if (this.ReverseTunnelEndTimeMsecs != null)
                    hashCode = hashCode * 59 + this.ReverseTunnelEndTimeMsecs.GetHashCode();
                if (this.SchemaInfoList != null)
                    hashCode = hashCode * 59 + this.SchemaInfoList.GetHashCode();
                if (this.SmbAdDisabled != null)
                    hashCode = hashCode * 59 + this.SmbAdDisabled.GetHashCode();
                if (this.Stats != null)
                    hashCode = hashCode * 59 + this.Stats.GetHashCode();
                if (this.StigMode != null)
                    hashCode = hashCode * 59 + this.StigMode.GetHashCode();
                if (this.SupportedConfig != null)
                    hashCode = hashCode * 59 + this.SupportedConfig.GetHashCode();
                if (this.TargetSoftwareVersion != null)
                    hashCode = hashCode * 59 + this.TargetSoftwareVersion.GetHashCode();
                if (this.TenantViewboxSharingEnabled != null)
                    hashCode = hashCode * 59 + this.TenantViewboxSharingEnabled.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.TurboMode != null)
                    hashCode = hashCode * 59 + this.TurboMode.GetHashCode();
                if (this.UsedMetadataSpacePct != null)
                    hashCode = hashCode * 59 + this.UsedMetadataSpacePct.GetHashCode();
                return hashCode;
            }
        }

    }

}


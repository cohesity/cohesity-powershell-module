// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// Specifies information about the Cohesity Cluster.
    /// </summary>
    [DataContract]
    public partial class Cluster :  IEquatable<Cluster>
    {
        /// <summary>
        /// Specifies the bonding mode to use when bonding NICs to this Cluster. &#39;KActiveBackup&#39; indicates an Active-backup policy bonding mode. &#39;K802_3ad&#39; indicates an EEE 802.3ad Dynamic link aggregation bonding mode. &#39;KBalanceAlb&#39; indicates a Adaptive load balancing bonding mode.
        /// </summary>
        /// <value>Specifies the bonding mode to use when bonding NICs to this Cluster. &#39;KActiveBackup&#39; indicates an Active-backup policy bonding mode. &#39;K802_3ad&#39; indicates an EEE 802.3ad Dynamic link aggregation bonding mode. &#39;KBalanceAlb&#39; indicates a Adaptive load balancing bonding mode.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BondingModeEnum
        {
            
            /// <summary>
            /// Enum ActiveBackup for value: ActiveBackup
            /// </summary>
            [EnumMember(Value = "ActiveBackup")]
            ActiveBackup = 1,
            
            /// <summary>
            /// Enum _8023ad for value: 802_3ad
            /// </summary>
            [EnumMember(Value = "802_3ad")]
            _8023ad = 2,
            
            /// <summary>
            /// Enum BalanceAlb for value: BalanceAlb
            /// </summary>
            [EnumMember(Value = "BalanceAlb")]
            BalanceAlb = 3
        }

        /// <summary>
        /// Specifies the bonding mode to use when bonding NICs to this Cluster. &#39;KActiveBackup&#39; indicates an Active-backup policy bonding mode. &#39;K802_3ad&#39; indicates an EEE 802.3ad Dynamic link aggregation bonding mode. &#39;KBalanceAlb&#39; indicates a Adaptive load balancing bonding mode.
        /// </summary>
        /// <value>Specifies the bonding mode to use when bonding NICs to this Cluster. &#39;KActiveBackup&#39; indicates an Active-backup policy bonding mode. &#39;K802_3ad&#39; indicates an EEE 802.3ad Dynamic link aggregation bonding mode. &#39;KBalanceAlb&#39; indicates a Adaptive load balancing bonding mode.</value>
        [DataMember(Name="bondingMode", EmitDefaultValue=false)]
        public BondingModeEnum? BondingMode { get; set; }
        /// <summary>
        /// Specifies the type of Cluster such as kPhysical. &#39;kPhysical&#39; indicates the Cohesity Cluster is hosted directly on hardware. &#39;kVirtualRobo&#39; indicates the Cohesity Cluster is hosted in a VM on a ESXi Host of a VMware vCenter Server using Cohesity&#39;s Virtual Edition. &#39;kMicrosoftCloud&#39; indicates the Cohesity Cluster is hosed in a VM on Microsoft Azure using Cohesity&#39;s Cloud Edition. &#39;kAmazonCloud&#39; indicates the Cohesity Cluster is hosed in a VM on Amazon S3 using Cohesity&#39;s Cloud Edition. &#39;kGoogleCloud&#39; indicates the Cohesity Cluster is hosed in a VM on Google Cloud Platform using Cohesity&#39;s Cloud Edition.
        /// </summary>
        /// <value>Specifies the type of Cluster such as kPhysical. &#39;kPhysical&#39; indicates the Cohesity Cluster is hosted directly on hardware. &#39;kVirtualRobo&#39; indicates the Cohesity Cluster is hosted in a VM on a ESXi Host of a VMware vCenter Server using Cohesity&#39;s Virtual Edition. &#39;kMicrosoftCloud&#39; indicates the Cohesity Cluster is hosed in a VM on Microsoft Azure using Cohesity&#39;s Cloud Edition. &#39;kAmazonCloud&#39; indicates the Cohesity Cluster is hosed in a VM on Amazon S3 using Cohesity&#39;s Cloud Edition. &#39;kGoogleCloud&#39; indicates the Cohesity Cluster is hosed in a VM on Google Cloud Platform using Cohesity&#39;s Cloud Edition.</value>
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
        /// Specifies the type of Cluster such as kPhysical. &#39;kPhysical&#39; indicates the Cohesity Cluster is hosted directly on hardware. &#39;kVirtualRobo&#39; indicates the Cohesity Cluster is hosted in a VM on a ESXi Host of a VMware vCenter Server using Cohesity&#39;s Virtual Edition. &#39;kMicrosoftCloud&#39; indicates the Cohesity Cluster is hosed in a VM on Microsoft Azure using Cohesity&#39;s Cloud Edition. &#39;kAmazonCloud&#39; indicates the Cohesity Cluster is hosed in a VM on Amazon S3 using Cohesity&#39;s Cloud Edition. &#39;kGoogleCloud&#39; indicates the Cohesity Cluster is hosed in a VM on Google Cloud Platform using Cohesity&#39;s Cloud Edition.
        /// </summary>
        /// <value>Specifies the type of Cluster such as kPhysical. &#39;kPhysical&#39; indicates the Cohesity Cluster is hosted directly on hardware. &#39;kVirtualRobo&#39; indicates the Cohesity Cluster is hosted in a VM on a ESXi Host of a VMware vCenter Server using Cohesity&#39;s Virtual Edition. &#39;kMicrosoftCloud&#39; indicates the Cohesity Cluster is hosed in a VM on Microsoft Azure using Cohesity&#39;s Cloud Edition. &#39;kAmazonCloud&#39; indicates the Cohesity Cluster is hosed in a VM on Amazon S3 using Cohesity&#39;s Cloud Edition. &#39;kGoogleCloud&#39; indicates the Cohesity Cluster is hosed in a VM on Google Cloud Platform using Cohesity&#39;s Cloud Edition.</value>
        [DataMember(Name="clusterType", EmitDefaultValue=false)]
        public ClusterTypeEnum? ClusterType { get; set; }
        /// <summary>
        /// Specifies the current Cluster-level operation in progress. &#39;kUpgrade&#39; indicates the Cohesity Cluster is upgrading to a new release. &#39;kRemoveNode&#39; indicates the Cohesity Cluster is removing a Node from the Cluster. &#39;kNone&#39; indicates no action is occurring on the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the current Cluster-level operation in progress. &#39;kUpgrade&#39; indicates the Cohesity Cluster is upgrading to a new release. &#39;kRemoveNode&#39; indicates the Cohesity Cluster is removing a Node from the Cluster. &#39;kNone&#39; indicates no action is occurring on the Cohesity Cluster.</value>
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
            KNone = 3
        }

        /// <summary>
        /// Specifies the current Cluster-level operation in progress. &#39;kUpgrade&#39; indicates the Cohesity Cluster is upgrading to a new release. &#39;kRemoveNode&#39; indicates the Cohesity Cluster is removing a Node from the Cluster. &#39;kNone&#39; indicates no action is occurring on the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the current Cluster-level operation in progress. &#39;kUpgrade&#39; indicates the Cohesity Cluster is upgrading to a new release. &#39;kRemoveNode&#39; indicates the Cohesity Cluster is removing a Node from the Cluster. &#39;kNone&#39; indicates no action is occurring on the Cohesity Cluster.</value>
        [DataMember(Name="currentOperation", EmitDefaultValue=false)]
        public CurrentOperationEnum? CurrentOperation { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Cluster" /> class.
        /// </summary>
        /// <param name="bondingMode">Specifies the bonding mode to use when bonding NICs to this Cluster. &#39;KActiveBackup&#39; indicates an Active-backup policy bonding mode. &#39;K802_3ad&#39; indicates an EEE 802.3ad Dynamic link aggregation bonding mode. &#39;KBalanceAlb&#39; indicates a Adaptive load balancing bonding mode..</param>
        /// <param name="clusterAuditLogConfig">Cluster Audit Log Configuration..</param>
        /// <param name="clusterSoftwareVersion">Specifies the current release of the Cohesity software running on this Cohesity Cluster..</param>
        /// <param name="clusterType">Specifies the type of Cluster such as kPhysical. &#39;kPhysical&#39; indicates the Cohesity Cluster is hosted directly on hardware. &#39;kVirtualRobo&#39; indicates the Cohesity Cluster is hosted in a VM on a ESXi Host of a VMware vCenter Server using Cohesity&#39;s Virtual Edition. &#39;kMicrosoftCloud&#39; indicates the Cohesity Cluster is hosed in a VM on Microsoft Azure using Cohesity&#39;s Cloud Edition. &#39;kAmazonCloud&#39; indicates the Cohesity Cluster is hosed in a VM on Amazon S3 using Cohesity&#39;s Cloud Edition. &#39;kGoogleCloud&#39; indicates the Cohesity Cluster is hosed in a VM on Google Cloud Platform using Cohesity&#39;s Cloud Edition..</param>
        /// <param name="createdTimeMsecs">Specifies the time when the Cohesity Cluster was created. This value is specified as a Unix epoch Timestamp (in microseconds)..</param>
        /// <param name="currentOpScheduledTimeSecs">Specifies the time scheduled by the Cohesity Cluster to start the current running operation..</param>
        /// <param name="currentOperation">Specifies the current Cluster-level operation in progress. &#39;kUpgrade&#39; indicates the Cohesity Cluster is upgrading to a new release. &#39;kRemoveNode&#39; indicates the Cohesity Cluster is removing a Node from the Cluster. &#39;kNone&#39; indicates no action is occurring on the Cohesity Cluster..</param>
        /// <param name="currentTimeMsecs">Specifies the current system time on the Cohesity Cluster. This value is specified as a Unix epoch Timestamp (in microseconds)..</param>
        /// <param name="dnsServerIps">Specifies the IP addresses of the DNS Servers used by the Cohesity Cluster..</param>
        /// <param name="domainNames">The first domain name specified in the array is the fully qualified domain name assigned to the Cohesity Cluster. Any additional domain names specified are used for the domain search list for hostname look-up..</param>
        /// <param name="enableActiveMonitoring">Specifies if Cohesity can receive monitoring information from the Cohesity Cluster. If &#39;true&#39;, remote monitoring of the Cohesity Cluster is allowed..</param>
        /// <param name="enableUpgradePkgPolling">If &#39;true&#39;, Cohesity&#39;s upgrade server is polled for new releases..</param>
        /// <param name="encryptionEnabled">If &#39;true&#39;, the entire Cohesity Cluster is encrypted including all View Boxes..</param>
        /// <param name="encryptionKeyRotationPeriodSecs">Specifies the period of time (in seconds) when encryption keys are rotated. By default, the encryption keys are rotated every 77760000 seconds (30 days)..</param>
        /// <param name="eulaConfig">eulaConfig.</param>
        /// <param name="filerAuditLogConfig">Filer Audit Log Configuration..</param>
        /// <param name="fipsModeEnabled">Specifies if the Cohesity Cluster should operate in the FIPS mode, which is compliant with the Federal Information Processing Standard 140-2 certification..</param>
        /// <param name="gateway">Specifies the gateway IP address..</param>
        /// <param name="hardwareInfo">Specifies a hardware type for motherboard of the nodes that make up this Cohesity Cluster such as S2600WB for Ivy Bridge or S2600TP for Haswell..</param>
        /// <param name="id">Specifies the unique id of Cohesity Cluster..</param>
        /// <param name="incarnationId">Specifies the unique incarnation id of the Cohesity Cluster..</param>
        /// <param name="isDocumentationLocal">Specifies what version of the documentation is used. If &#39;true&#39;, the version of documentation stored locally on the Cohesity Cluster is used. If &#39;false&#39;, the documentation stored on a Cohesity Web Server is used. The default is &#39;false&#39;. Cohesity recommends accessing the Help from the Cohesity Web site which provides the newest and most complete version of Help..</param>
        /// <param name="languageLocale">Specifies the language and locale for this Cohesity Cluster..</param>
        /// <param name="mtu">Specifies the Maxium Transmission Unit (MTU) in bytes of the network..</param>
        /// <param name="name">Specifies the name of the Cohesity Cluster..</param>
        /// <param name="nodeCount">Specifies the number of Nodes in the Cohesity Cluster..</param>
        /// <param name="ntpSettings">Specifies if the ntp/master slave scheme should be disabled for this cluster..</param>
        /// <param name="reverseTunnelEnabled">If &#39;true&#39;, Cohesity&#39;s Remote Tunnel is enabled. Cohesity can access the Cluster and provide remote assistance via a Remote Tunnel..</param>
        /// <param name="smbAdDisabled">Specifies if Active Directory should be disabled for authentication of SMB shares. If &#39;true&#39;, Active Directory is disabled..</param>
        /// <param name="stats">Specifies statistics about this Cohesity Cluster..</param>
        /// <param name="supportedConfig">Information about supported configuration. For example, it contains minimum number of nodes supported for the cluster..</param>
        /// <param name="syslogServers">Specifies a list of Syslog servers to send audit logs to..</param>
        /// <param name="targetSoftwareVersion">Specifies the Cohesity release that this Cluster is being upgraded to if an upgrade operation is in progress..</param>
        /// <param name="timezone">Specifies the timezone to use for showing time in emails, reports, filer audit logs, etc..</param>
        /// <param name="turboMode">Specifies if the cluster is in Turbo mode..</param>
        public Cluster(BondingModeEnum? bondingMode = default(BondingModeEnum?), ClusterAuditLogConfiguration clusterAuditLogConfig = default(ClusterAuditLogConfiguration), string clusterSoftwareVersion = default(string), ClusterTypeEnum? clusterType = default(ClusterTypeEnum?), long? createdTimeMsecs = default(long?), long? currentOpScheduledTimeSecs = default(long?), CurrentOperationEnum? currentOperation = default(CurrentOperationEnum?), long? currentTimeMsecs = default(long?), List<string> dnsServerIps = default(List<string>), List<string> domainNames = default(List<string>), bool? enableActiveMonitoring = default(bool?), bool? enableUpgradePkgPolling = default(bool?), bool? encryptionEnabled = default(bool?), long? encryptionKeyRotationPeriodSecs = default(long?), EULAAcceptanceInformation_ eulaConfig = default(EULAAcceptanceInformation_), FilerAuditLogConfiguration filerAuditLogConfig = default(FilerAuditLogConfiguration), bool? fipsModeEnabled = default(bool?), string gateway = default(string), ClusterHardwareInfo hardwareInfo = default(ClusterHardwareInfo), long? id = default(long?), long? incarnationId = default(long?), bool? isDocumentationLocal = default(bool?), string languageLocale = default(string), int? mtu = default(int?), string name = default(string), long? nodeCount = default(long?), NtpSettingsConfig ntpSettings = default(NtpSettingsConfig), bool? reverseTunnelEnabled = default(bool?), bool? smbAdDisabled = default(bool?), ClusterStats stats = default(ClusterStats), SupportedConfig supportedConfig = default(SupportedConfig), List<SyslogServer> syslogServers = default(List<SyslogServer>), string targetSoftwareVersion = default(string), string timezone = default(string), bool? turboMode = default(bool?))
        {
            this.BondingMode = bondingMode;
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
            this.FilerAuditLogConfig = filerAuditLogConfig;
            this.FipsModeEnabled = fipsModeEnabled;
            this.Gateway = gateway;
            this.HardwareInfo = hardwareInfo;
            this.Id = id;
            this.IncarnationId = incarnationId;
            this.IsDocumentationLocal = isDocumentationLocal;
            this.LanguageLocale = languageLocale;
            this.Mtu = mtu;
            this.Name = name;
            this.NodeCount = nodeCount;
            this.NtpSettings = ntpSettings;
            this.ReverseTunnelEnabled = reverseTunnelEnabled;
            this.SmbAdDisabled = smbAdDisabled;
            this.Stats = stats;
            this.SupportedConfig = supportedConfig;
            this.SyslogServers = syslogServers;
            this.TargetSoftwareVersion = targetSoftwareVersion;
            this.Timezone = timezone;
            this.TurboMode = turboMode;
        }
        

        /// <summary>
        /// Cluster Audit Log Configuration.
        /// </summary>
        /// <value>Cluster Audit Log Configuration.</value>
        [DataMember(Name="clusterAuditLogConfig", EmitDefaultValue=false)]
        public ClusterAuditLogConfiguration ClusterAuditLogConfig { get; set; }

        /// <summary>
        /// Specifies the current release of the Cohesity software running on this Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the current release of the Cohesity software running on this Cohesity Cluster.</value>
        [DataMember(Name="clusterSoftwareVersion", EmitDefaultValue=false)]
        public string ClusterSoftwareVersion { get; set; }


        /// <summary>
        /// Specifies the time when the Cohesity Cluster was created. This value is specified as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the time when the Cohesity Cluster was created. This value is specified as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="createdTimeMsecs", EmitDefaultValue=false)]
        public long? CreatedTimeMsecs { get; set; }

        /// <summary>
        /// Specifies the time scheduled by the Cohesity Cluster to start the current running operation.
        /// </summary>
        /// <value>Specifies the time scheduled by the Cohesity Cluster to start the current running operation.</value>
        [DataMember(Name="currentOpScheduledTimeSecs", EmitDefaultValue=false)]
        public long? CurrentOpScheduledTimeSecs { get; set; }


        /// <summary>
        /// Specifies the current system time on the Cohesity Cluster. This value is specified as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the current system time on the Cohesity Cluster. This value is specified as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="currentTimeMsecs", EmitDefaultValue=false)]
        public long? CurrentTimeMsecs { get; set; }

        /// <summary>
        /// Specifies the IP addresses of the DNS Servers used by the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the IP addresses of the DNS Servers used by the Cohesity Cluster.</value>
        [DataMember(Name="dnsServerIps", EmitDefaultValue=false)]
        public List<string> DnsServerIps { get; set; }

        /// <summary>
        /// The first domain name specified in the array is the fully qualified domain name assigned to the Cohesity Cluster. Any additional domain names specified are used for the domain search list for hostname look-up.
        /// </summary>
        /// <value>The first domain name specified in the array is the fully qualified domain name assigned to the Cohesity Cluster. Any additional domain names specified are used for the domain search list for hostname look-up.</value>
        [DataMember(Name="domainNames", EmitDefaultValue=false)]
        public List<string> DomainNames { get; set; }

        /// <summary>
        /// Specifies if Cohesity can receive monitoring information from the Cohesity Cluster. If &#39;true&#39;, remote monitoring of the Cohesity Cluster is allowed.
        /// </summary>
        /// <value>Specifies if Cohesity can receive monitoring information from the Cohesity Cluster. If &#39;true&#39;, remote monitoring of the Cohesity Cluster is allowed.</value>
        [DataMember(Name="enableActiveMonitoring", EmitDefaultValue=false)]
        public bool? EnableActiveMonitoring { get; set; }

        /// <summary>
        /// If &#39;true&#39;, Cohesity&#39;s upgrade server is polled for new releases.
        /// </summary>
        /// <value>If &#39;true&#39;, Cohesity&#39;s upgrade server is polled for new releases.</value>
        [DataMember(Name="enableUpgradePkgPolling", EmitDefaultValue=false)]
        public bool? EnableUpgradePkgPolling { get; set; }

        /// <summary>
        /// If &#39;true&#39;, the entire Cohesity Cluster is encrypted including all View Boxes.
        /// </summary>
        /// <value>If &#39;true&#39;, the entire Cohesity Cluster is encrypted including all View Boxes.</value>
        [DataMember(Name="encryptionEnabled", EmitDefaultValue=false)]
        public bool? EncryptionEnabled { get; set; }

        /// <summary>
        /// Specifies the period of time (in seconds) when encryption keys are rotated. By default, the encryption keys are rotated every 77760000 seconds (30 days).
        /// </summary>
        /// <value>Specifies the period of time (in seconds) when encryption keys are rotated. By default, the encryption keys are rotated every 77760000 seconds (30 days).</value>
        [DataMember(Name="encryptionKeyRotationPeriodSecs", EmitDefaultValue=false)]
        public long? EncryptionKeyRotationPeriodSecs { get; set; }

        /// <summary>
        /// Gets or Sets EulaConfig
        /// </summary>
        [DataMember(Name="eulaConfig", EmitDefaultValue=false)]
        public EULAAcceptanceInformation_ EulaConfig { get; set; }

        /// <summary>
        /// Filer Audit Log Configuration.
        /// </summary>
        /// <value>Filer Audit Log Configuration.</value>
        [DataMember(Name="filerAuditLogConfig", EmitDefaultValue=false)]
        public FilerAuditLogConfiguration FilerAuditLogConfig { get; set; }

        /// <summary>
        /// Specifies if the Cohesity Cluster should operate in the FIPS mode, which is compliant with the Federal Information Processing Standard 140-2 certification.
        /// </summary>
        /// <value>Specifies if the Cohesity Cluster should operate in the FIPS mode, which is compliant with the Federal Information Processing Standard 140-2 certification.</value>
        [DataMember(Name="fipsModeEnabled", EmitDefaultValue=false)]
        public bool? FipsModeEnabled { get; set; }

        /// <summary>
        /// Specifies the gateway IP address.
        /// </summary>
        /// <value>Specifies the gateway IP address.</value>
        [DataMember(Name="gateway", EmitDefaultValue=false)]
        public string Gateway { get; set; }

        /// <summary>
        /// Specifies a hardware type for motherboard of the nodes that make up this Cohesity Cluster such as S2600WB for Ivy Bridge or S2600TP for Haswell.
        /// </summary>
        /// <value>Specifies a hardware type for motherboard of the nodes that make up this Cohesity Cluster such as S2600WB for Ivy Bridge or S2600TP for Haswell.</value>
        [DataMember(Name="hardwareInfo", EmitDefaultValue=false)]
        public ClusterHardwareInfo HardwareInfo { get; set; }

        /// <summary>
        /// Specifies the unique id of Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the unique id of Cohesity Cluster.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Specifies the unique incarnation id of the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the unique incarnation id of the Cohesity Cluster.</value>
        [DataMember(Name="incarnationId", EmitDefaultValue=false)]
        public long? IncarnationId { get; set; }

        /// <summary>
        /// Specifies what version of the documentation is used. If &#39;true&#39;, the version of documentation stored locally on the Cohesity Cluster is used. If &#39;false&#39;, the documentation stored on a Cohesity Web Server is used. The default is &#39;false&#39;. Cohesity recommends accessing the Help from the Cohesity Web site which provides the newest and most complete version of Help.
        /// </summary>
        /// <value>Specifies what version of the documentation is used. If &#39;true&#39;, the version of documentation stored locally on the Cohesity Cluster is used. If &#39;false&#39;, the documentation stored on a Cohesity Web Server is used. The default is &#39;false&#39;. Cohesity recommends accessing the Help from the Cohesity Web site which provides the newest and most complete version of Help.</value>
        [DataMember(Name="isDocumentationLocal", EmitDefaultValue=false)]
        public bool? IsDocumentationLocal { get; set; }

        /// <summary>
        /// Specifies the language and locale for this Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the language and locale for this Cohesity Cluster.</value>
        [DataMember(Name="languageLocale", EmitDefaultValue=false)]
        public string LanguageLocale { get; set; }

        /// <summary>
        /// Specifies the Maxium Transmission Unit (MTU) in bytes of the network.
        /// </summary>
        /// <value>Specifies the Maxium Transmission Unit (MTU) in bytes of the network.</value>
        [DataMember(Name="mtu", EmitDefaultValue=false)]
        public int? Mtu { get; set; }

        /// <summary>
        /// Specifies the name of the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the name of the Cohesity Cluster.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the number of Nodes in the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the number of Nodes in the Cohesity Cluster.</value>
        [DataMember(Name="nodeCount", EmitDefaultValue=false)]
        public long? NodeCount { get; set; }

        /// <summary>
        /// Specifies if the ntp/master slave scheme should be disabled for this cluster.
        /// </summary>
        /// <value>Specifies if the ntp/master slave scheme should be disabled for this cluster.</value>
        [DataMember(Name="ntpSettings", EmitDefaultValue=false)]
        public NtpSettingsConfig NtpSettings { get; set; }

        /// <summary>
        /// If &#39;true&#39;, Cohesity&#39;s Remote Tunnel is enabled. Cohesity can access the Cluster and provide remote assistance via a Remote Tunnel.
        /// </summary>
        /// <value>If &#39;true&#39;, Cohesity&#39;s Remote Tunnel is enabled. Cohesity can access the Cluster and provide remote assistance via a Remote Tunnel.</value>
        [DataMember(Name="reverseTunnelEnabled", EmitDefaultValue=false)]
        public bool? ReverseTunnelEnabled { get; set; }

        /// <summary>
        /// Specifies if Active Directory should be disabled for authentication of SMB shares. If &#39;true&#39;, Active Directory is disabled.
        /// </summary>
        /// <value>Specifies if Active Directory should be disabled for authentication of SMB shares. If &#39;true&#39;, Active Directory is disabled.</value>
        [DataMember(Name="smbAdDisabled", EmitDefaultValue=false)]
        public bool? SmbAdDisabled { get; set; }

        /// <summary>
        /// Specifies statistics about this Cohesity Cluster.
        /// </summary>
        /// <value>Specifies statistics about this Cohesity Cluster.</value>
        [DataMember(Name="stats", EmitDefaultValue=false)]
        public ClusterStats Stats { get; set; }

        /// <summary>
        /// Information about supported configuration. For example, it contains minimum number of nodes supported for the cluster.
        /// </summary>
        /// <value>Information about supported configuration. For example, it contains minimum number of nodes supported for the cluster.</value>
        [DataMember(Name="supportedConfig", EmitDefaultValue=false)]
        public SupportedConfig SupportedConfig { get; set; }

        /// <summary>
        /// Specifies a list of Syslog servers to send audit logs to.
        /// </summary>
        /// <value>Specifies a list of Syslog servers to send audit logs to.</value>
        [DataMember(Name="syslogServers", EmitDefaultValue=false)]
        public List<SyslogServer> SyslogServers { get; set; }

        /// <summary>
        /// Specifies the Cohesity release that this Cluster is being upgraded to if an upgrade operation is in progress.
        /// </summary>
        /// <value>Specifies the Cohesity release that this Cluster is being upgraded to if an upgrade operation is in progress.</value>
        [DataMember(Name="targetSoftwareVersion", EmitDefaultValue=false)]
        public string TargetSoftwareVersion { get; set; }

        /// <summary>
        /// Specifies the timezone to use for showing time in emails, reports, filer audit logs, etc.
        /// </summary>
        /// <value>Specifies the timezone to use for showing time in emails, reports, filer audit logs, etc.</value>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Specifies if the cluster is in Turbo mode.
        /// </summary>
        /// <value>Specifies if the cluster is in Turbo mode.</value>
        [DataMember(Name="turboMode", EmitDefaultValue=false)]
        public bool? TurboMode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }
  
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
                    this.BondingMode == input.BondingMode ||
                    (this.BondingMode != null &&
                    this.BondingMode.Equals(input.BondingMode))
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
                    (this.ClusterType != null &&
                    this.ClusterType.Equals(input.ClusterType))
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
                    (this.CurrentOperation != null &&
                    this.CurrentOperation.Equals(input.CurrentOperation))
                ) && 
                (
                    this.CurrentTimeMsecs == input.CurrentTimeMsecs ||
                    (this.CurrentTimeMsecs != null &&
                    this.CurrentTimeMsecs.Equals(input.CurrentTimeMsecs))
                ) && 
                (
                    this.DnsServerIps == input.DnsServerIps ||
                    this.DnsServerIps != null &&
                    this.DnsServerIps.SequenceEqual(input.DnsServerIps)
                ) && 
                (
                    this.DomainNames == input.DomainNames ||
                    this.DomainNames != null &&
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
                    this.Mtu == input.Mtu ||
                    (this.Mtu != null &&
                    this.Mtu.Equals(input.Mtu))
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
                    this.NtpSettings == input.NtpSettings ||
                    (this.NtpSettings != null &&
                    this.NtpSettings.Equals(input.NtpSettings))
                ) && 
                (
                    this.ReverseTunnelEnabled == input.ReverseTunnelEnabled ||
                    (this.ReverseTunnelEnabled != null &&
                    this.ReverseTunnelEnabled.Equals(input.ReverseTunnelEnabled))
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
                    this.SupportedConfig == input.SupportedConfig ||
                    (this.SupportedConfig != null &&
                    this.SupportedConfig.Equals(input.SupportedConfig))
                ) && 
                (
                    this.SyslogServers == input.SyslogServers ||
                    this.SyslogServers != null &&
                    this.SyslogServers.SequenceEqual(input.SyslogServers)
                ) && 
                (
                    this.TargetSoftwareVersion == input.TargetSoftwareVersion ||
                    (this.TargetSoftwareVersion != null &&
                    this.TargetSoftwareVersion.Equals(input.TargetSoftwareVersion))
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
                if (this.BondingMode != null)
                    hashCode = hashCode * 59 + this.BondingMode.GetHashCode();
                if (this.ClusterAuditLogConfig != null)
                    hashCode = hashCode * 59 + this.ClusterAuditLogConfig.GetHashCode();
                if (this.ClusterSoftwareVersion != null)
                    hashCode = hashCode * 59 + this.ClusterSoftwareVersion.GetHashCode();
                if (this.ClusterType != null)
                    hashCode = hashCode * 59 + this.ClusterType.GetHashCode();
                if (this.CreatedTimeMsecs != null)
                    hashCode = hashCode * 59 + this.CreatedTimeMsecs.GetHashCode();
                if (this.CurrentOpScheduledTimeSecs != null)
                    hashCode = hashCode * 59 + this.CurrentOpScheduledTimeSecs.GetHashCode();
                if (this.CurrentOperation != null)
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
                if (this.FilerAuditLogConfig != null)
                    hashCode = hashCode * 59 + this.FilerAuditLogConfig.GetHashCode();
                if (this.FipsModeEnabled != null)
                    hashCode = hashCode * 59 + this.FipsModeEnabled.GetHashCode();
                if (this.Gateway != null)
                    hashCode = hashCode * 59 + this.Gateway.GetHashCode();
                if (this.HardwareInfo != null)
                    hashCode = hashCode * 59 + this.HardwareInfo.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IncarnationId != null)
                    hashCode = hashCode * 59 + this.IncarnationId.GetHashCode();
                if (this.IsDocumentationLocal != null)
                    hashCode = hashCode * 59 + this.IsDocumentationLocal.GetHashCode();
                if (this.LanguageLocale != null)
                    hashCode = hashCode * 59 + this.LanguageLocale.GetHashCode();
                if (this.Mtu != null)
                    hashCode = hashCode * 59 + this.Mtu.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NodeCount != null)
                    hashCode = hashCode * 59 + this.NodeCount.GetHashCode();
                if (this.NtpSettings != null)
                    hashCode = hashCode * 59 + this.NtpSettings.GetHashCode();
                if (this.ReverseTunnelEnabled != null)
                    hashCode = hashCode * 59 + this.ReverseTunnelEnabled.GetHashCode();
                if (this.SmbAdDisabled != null)
                    hashCode = hashCode * 59 + this.SmbAdDisabled.GetHashCode();
                if (this.Stats != null)
                    hashCode = hashCode * 59 + this.Stats.GetHashCode();
                if (this.SupportedConfig != null)
                    hashCode = hashCode * 59 + this.SupportedConfig.GetHashCode();
                if (this.SyslogServers != null)
                    hashCode = hashCode * 59 + this.SyslogServers.GetHashCode();
                if (this.TargetSoftwareVersion != null)
                    hashCode = hashCode * 59 + this.TargetSoftwareVersion.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.TurboMode != null)
                    hashCode = hashCode * 59 + this.TurboMode.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


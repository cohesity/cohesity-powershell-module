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
        /// Specifies the type from which the cluster was claimed to Helios. &#39;kCohesity&#39; implies Cohesity cluster is claimed. &#39;kIBMStroageProtect&#39; implies IBM storage protect cluster is claimed.
        /// </summary>
        /// <value>Specifies the type from which the cluster was claimed to Helios. &#39;kCohesity&#39; implies Cohesity cluster is claimed. &#39;kIBMStroageProtect&#39; implies IBM storage protect cluster is claimed.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ClaimTypeEnum
        {
            /// <summary>
            /// Enum KCohesity for value: kCohesity
            /// </summary>
            [EnumMember(Value = "kCohesity")]
            KCohesity = 1,

            /// <summary>
            /// Enum KIBMStorageProtect for value: kIBMStorageProtect
            /// </summary>
            [EnumMember(Value = "kIBMStorageProtect")]
            KIBMStorageProtect = 2

        }

        /// <summary>
        /// Specifies the type from which the cluster was claimed to Helios. &#39;kCohesity&#39; implies Cohesity cluster is claimed. &#39;kIBMStroageProtect&#39; implies IBM storage protect cluster is claimed.
        /// </summary>
        /// <value>Specifies the type from which the cluster was claimed to Helios. &#39;kCohesity&#39; implies Cohesity cluster is claimed. &#39;kIBMStroageProtect&#39; implies IBM storage protect cluster is claimed.</value>
        [DataMember(Name="claimType", EmitDefaultValue=true)]
        public ClaimTypeEnum? ClaimType { get; set; }
        /// <summary>
        /// Specifies the type of Deployment for Cluster such as kCDC, kIBMBaaS. &#39;kStandAlone&#39; indicates the StandAlone/Default deployment of Cluster. &#39;kCDC&#39; indicates the Cluster is deployed by Cohesity &#39;kIBMBaaS&#39; indicates the Cluster deployed by IBM
        /// </summary>
        /// <value>Specifies the type of Deployment for Cluster such as kCDC, kIBMBaaS. &#39;kStandAlone&#39; indicates the StandAlone/Default deployment of Cluster. &#39;kCDC&#39; indicates the Cluster is deployed by Cohesity &#39;kIBMBaaS&#39; indicates the Cluster deployed by IBM</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ClusterDeploymentTypeEnum
        {
            /// <summary>
            /// Enum KStandAlone for value: kStandAlone
            /// </summary>
            [EnumMember(Value = "kStandAlone")]
            KStandAlone = 1,

            /// <summary>
            /// Enum KCDC for value: kCDC
            /// </summary>
            [EnumMember(Value = "kCDC")]
            KCDC = 2,

            /// <summary>
            /// Enum KIBMBaaS for value: kIBMBaaS
            /// </summary>
            [EnumMember(Value = "kIBMBaaS")]
            KIBMBaaS = 3

        }

        /// <summary>
        /// Specifies the type of Deployment for Cluster such as kCDC, kIBMBaaS. &#39;kStandAlone&#39; indicates the StandAlone/Default deployment of Cluster. &#39;kCDC&#39; indicates the Cluster is deployed by Cohesity &#39;kIBMBaaS&#39; indicates the Cluster deployed by IBM
        /// </summary>
        /// <value>Specifies the type of Deployment for Cluster such as kCDC, kIBMBaaS. &#39;kStandAlone&#39; indicates the StandAlone/Default deployment of Cluster. &#39;kCDC&#39; indicates the Cluster is deployed by Cohesity &#39;kIBMBaaS&#39; indicates the Cluster deployed by IBM</value>
        [DataMember(Name="clusterDeploymentType", EmitDefaultValue=true)]
        public ClusterDeploymentTypeEnum? ClusterDeploymentType { get; set; }
        /// <summary>
        /// Specifies the size of Cloud Edition(CE) Cluster such as kSmall, kNextGen. Specifies the clustersize of the cloud edition(CE) clusters. &#39;kSmall&#39; indicates small cluster size of CE. &#39;kMedium&#39; indicates medium cluster size of CE. &#39;kLarge&#39; indicates large cluster size of CE. &#39;kXLarge&#39; indicates extra large cluster size of CE. &#39;kNextGen&#39; indicates next gen CE.
        /// </summary>
        /// <value>Specifies the size of Cloud Edition(CE) Cluster such as kSmall, kNextGen. Specifies the clustersize of the cloud edition(CE) clusters. &#39;kSmall&#39; indicates small cluster size of CE. &#39;kMedium&#39; indicates medium cluster size of CE. &#39;kLarge&#39; indicates large cluster size of CE. &#39;kXLarge&#39; indicates extra large cluster size of CE. &#39;kNextGen&#39; indicates next gen CE.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ClusterSizeEnum
        {
            /// <summary>
            /// Enum KSmall for value: kSmall
            /// </summary>
            [EnumMember(Value = "kSmall")]
            KSmall = 1,

            /// <summary>
            /// Enum KMedium for value: kMedium
            /// </summary>
            [EnumMember(Value = "kMedium")]
            KMedium = 2,

            /// <summary>
            /// Enum KLarge for value: kLarge
            /// </summary>
            [EnumMember(Value = "kLarge")]
            KLarge = 3,

            /// <summary>
            /// Enum KXLarge for value: kXLarge
            /// </summary>
            [EnumMember(Value = "kXLarge")]
            KXLarge = 4,

            /// <summary>
            /// Enum KNextGen for value: kNextGen
            /// </summary>
            [EnumMember(Value = "kNextGen")]
            KNextGen = 5

        }

        /// <summary>
        /// Specifies the size of Cloud Edition(CE) Cluster such as kSmall, kNextGen. Specifies the clustersize of the cloud edition(CE) clusters. &#39;kSmall&#39; indicates small cluster size of CE. &#39;kMedium&#39; indicates medium cluster size of CE. &#39;kLarge&#39; indicates large cluster size of CE. &#39;kXLarge&#39; indicates extra large cluster size of CE. &#39;kNextGen&#39; indicates next gen CE.
        /// </summary>
        /// <value>Specifies the size of Cloud Edition(CE) Cluster such as kSmall, kNextGen. Specifies the clustersize of the cloud edition(CE) clusters. &#39;kSmall&#39; indicates small cluster size of CE. &#39;kMedium&#39; indicates medium cluster size of CE. &#39;kLarge&#39; indicates large cluster size of CE. &#39;kXLarge&#39; indicates extra large cluster size of CE. &#39;kNextGen&#39; indicates next gen CE.</value>
        [DataMember(Name="clusterSize", EmitDefaultValue=true)]
        public ClusterSizeEnum? ClusterSize { get; set; }
        /// <summary>
        /// Specifies the type of Cluster such as kPhysical. &#39;kPhysical&#39; indicates the Cohesity Cluster is hosted directly on hardware. &#39;kVirtualRobo&#39; indicates the Cohesity Cluster is hosted in a VM on a ESXi Host of a VMware vCenter Server using Cohesity&#39;s Virtual Edition. &#39;kMicrosoftCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Microsoft Azure using Cohesity&#39;s Cloud Edition. &#39;kAmazonCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Amazon S3 using Cohesity&#39;s Cloud Edition. &#39;kGoogleCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Google Cloud Platform using Cohesity&#39;s Cloud Edition. &#39;kIBMCloud&#39; indicates the Cohesity Cluster is hosted in a VM on IBM Cloud
        /// </summary>
        /// <value>Specifies the type of Cluster such as kPhysical. &#39;kPhysical&#39; indicates the Cohesity Cluster is hosted directly on hardware. &#39;kVirtualRobo&#39; indicates the Cohesity Cluster is hosted in a VM on a ESXi Host of a VMware vCenter Server using Cohesity&#39;s Virtual Edition. &#39;kMicrosoftCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Microsoft Azure using Cohesity&#39;s Cloud Edition. &#39;kAmazonCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Amazon S3 using Cohesity&#39;s Cloud Edition. &#39;kGoogleCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Google Cloud Platform using Cohesity&#39;s Cloud Edition. &#39;kIBMCloud&#39; indicates the Cohesity Cluster is hosted in a VM on IBM Cloud</value>
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
            KGoogleCloud = 5,

            /// <summary>
            /// Enum KIBMCloud for value: kIBMCloud
            /// </summary>
            [EnumMember(Value = "kIBMCloud")]
            KIBMCloud = 6

        }

        /// <summary>
        /// Specifies the type of Cluster such as kPhysical. &#39;kPhysical&#39; indicates the Cohesity Cluster is hosted directly on hardware. &#39;kVirtualRobo&#39; indicates the Cohesity Cluster is hosted in a VM on a ESXi Host of a VMware vCenter Server using Cohesity&#39;s Virtual Edition. &#39;kMicrosoftCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Microsoft Azure using Cohesity&#39;s Cloud Edition. &#39;kAmazonCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Amazon S3 using Cohesity&#39;s Cloud Edition. &#39;kGoogleCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Google Cloud Platform using Cohesity&#39;s Cloud Edition. &#39;kIBMCloud&#39; indicates the Cohesity Cluster is hosted in a VM on IBM Cloud
        /// </summary>
        /// <value>Specifies the type of Cluster such as kPhysical. &#39;kPhysical&#39; indicates the Cohesity Cluster is hosted directly on hardware. &#39;kVirtualRobo&#39; indicates the Cohesity Cluster is hosted in a VM on a ESXi Host of a VMware vCenter Server using Cohesity&#39;s Virtual Edition. &#39;kMicrosoftCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Microsoft Azure using Cohesity&#39;s Cloud Edition. &#39;kAmazonCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Amazon S3 using Cohesity&#39;s Cloud Edition. &#39;kGoogleCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Google Cloud Platform using Cohesity&#39;s Cloud Edition. &#39;kIBMCloud&#39; indicates the Cohesity Cluster is hosted in a VM on IBM Cloud</value>
        [DataMember(Name="clusterType", EmitDefaultValue=true)]
        public ClusterTypeEnum? ClusterType { get; set; }
        /// <summary>
        /// Specifies the current Cluster-level operation in progress. &#39;kUpgrade&#39; indicates the Cohesity Cluster is upgrading to a new release. &#39;kRemoveNode&#39; indicates the Cohesity Cluster is removing a Node  from the Cluster.  &#39;kNone&#39; indicates no action is occurring on the Cohesity Cluster. &#39;kDestroy&#39; indicates the Cohesity Cluster is getting destoryed. &#39;kClean&#39; indicates the Cohesity Cluster is getting cleaned. &#39;kRestartServices&#39; indicates the Cohesity Cluster is restarting the services. &#39;kRestartSystemServices&#39; indicates the Cohesity Cluster is restarting the system services.
        /// </summary>
        /// <value>Specifies the current Cluster-level operation in progress. &#39;kUpgrade&#39; indicates the Cohesity Cluster is upgrading to a new release. &#39;kRemoveNode&#39; indicates the Cohesity Cluster is removing a Node  from the Cluster.  &#39;kNone&#39; indicates no action is occurring on the Cohesity Cluster. &#39;kDestroy&#39; indicates the Cohesity Cluster is getting destoryed. &#39;kClean&#39; indicates the Cohesity Cluster is getting cleaned. &#39;kRestartServices&#39; indicates the Cohesity Cluster is restarting the services. &#39;kRestartSystemServices&#39; indicates the Cohesity Cluster is restarting the system services.</value>
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
            KRestartServices = 6,

            /// <summary>
            /// Enum KRestartSystemServices for value: kRestartSystemServices
            /// </summary>
            [EnumMember(Value = "kRestartSystemServices")]
            KRestartSystemServices = 7

        }

        /// <summary>
        /// Specifies the current Cluster-level operation in progress. &#39;kUpgrade&#39; indicates the Cohesity Cluster is upgrading to a new release. &#39;kRemoveNode&#39; indicates the Cohesity Cluster is removing a Node  from the Cluster.  &#39;kNone&#39; indicates no action is occurring on the Cohesity Cluster. &#39;kDestroy&#39; indicates the Cohesity Cluster is getting destoryed. &#39;kClean&#39; indicates the Cohesity Cluster is getting cleaned. &#39;kRestartServices&#39; indicates the Cohesity Cluster is restarting the services. &#39;kRestartSystemServices&#39; indicates the Cohesity Cluster is restarting the system services.
        /// </summary>
        /// <value>Specifies the current Cluster-level operation in progress. &#39;kUpgrade&#39; indicates the Cohesity Cluster is upgrading to a new release. &#39;kRemoveNode&#39; indicates the Cohesity Cluster is removing a Node  from the Cluster.  &#39;kNone&#39; indicates no action is occurring on the Cohesity Cluster. &#39;kDestroy&#39; indicates the Cohesity Cluster is getting destoryed. &#39;kClean&#39; indicates the Cohesity Cluster is getting cleaned. &#39;kRestartServices&#39; indicates the Cohesity Cluster is restarting the services. &#39;kRestartSystemServices&#39; indicates the Cohesity Cluster is restarting the system services.</value>
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
        /// Specifies the type of Cohesity Software. &#39;kOneHelios&#39; indicates the one helios Cohesity Cluster. &#39;kNetBackup&#39; indicates the NetBackup Cohesity Cluster. &#39;kRegular&#39; indicates the regular Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the type of Cohesity Software. &#39;kOneHelios&#39; indicates the one helios Cohesity Cluster. &#39;kNetBackup&#39; indicates the NetBackup Cohesity Cluster. &#39;kRegular&#39; indicates the regular Cohesity Cluster.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SoftwareTypeEnum
        {
            /// <summary>
            /// Enum KOneHelios for value: kOneHelios
            /// </summary>
            [EnumMember(Value = "kOneHelios")]
            KOneHelios = 1,

            /// <summary>
            /// Enum KRegular for value: kRegular
            /// </summary>
            [EnumMember(Value = "kRegular")]
            KRegular = 2

        }

        /// <summary>
        /// Specifies the type of Cohesity Software. &#39;kOneHelios&#39; indicates the one helios Cohesity Cluster. &#39;kNetBackup&#39; indicates the NetBackup Cohesity Cluster. &#39;kRegular&#39; indicates the regular Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the type of Cohesity Software. &#39;kOneHelios&#39; indicates the one helios Cohesity Cluster. &#39;kNetBackup&#39; indicates the NetBackup Cohesity Cluster. &#39;kRegular&#39; indicates the regular Cohesity Cluster.</value>
        [DataMember(Name="softwareType", EmitDefaultValue=true)]
        public SoftwareTypeEnum? SoftwareType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Cluster" /> class.
        /// </summary>
        /// <param name="aesEncryptionMode">Specifies the default AES Encryption mode on the cluster..</param>
        /// <param name="amqpTargetConfig">amqpTargetConfig.</param>
        /// <param name="appsSubnet">appsSubnet.</param>
        /// <param name="assignedRacksCount">Specifies the number of racks in cluster with at least one rack assigned..</param>
        /// <param name="attemptAgentPortsUpgrade">To attempt agent connection on port 21213 first.</param>
        /// <param name="authSupportForPkgDownloads">Bool specifying if cluster can support authHeaders for upgrade.</param>
        /// <param name="availableMetadataSpace">Information about storage available for metadata.</param>
        /// <param name="bannerEnabled">Specifies whether UI banner is enabled on the cluster or not. When banner is enabled, UI will make an additional API call to fetch the banner and show at the login page..</param>
        /// <param name="centralizedPatchingEnabled">Bool specifying if cluster can support patching via Helios.</param>
        /// <param name="chassisCount">Specifies the number of chassis in cluster..</param>
        /// <param name="claimType">Specifies the type from which the cluster was claimed to Helios. &#39;kCohesity&#39; implies Cohesity cluster is claimed. &#39;kIBMStroageProtect&#39; implies IBM storage protect cluster is claimed..</param>
        /// <param name="cloudRf1Enabled">Specifies if the Cloud RF1 is enabled on the cluster..</param>
        /// <param name="clusterAuditLogConfig">clusterAuditLogConfig.</param>
        /// <param name="clusterDeploymentType">Specifies the type of Deployment for Cluster such as kCDC, kIBMBaaS. &#39;kStandAlone&#39; indicates the StandAlone/Default deployment of Cluster. &#39;kCDC&#39; indicates the Cluster is deployed by Cohesity &#39;kIBMBaaS&#39; indicates the Cluster deployed by IBM.</param>
        /// <param name="clusterSize">Specifies the size of Cloud Edition(CE) Cluster such as kSmall, kNextGen. Specifies the clustersize of the cloud edition(CE) clusters. &#39;kSmall&#39; indicates small cluster size of CE. &#39;kMedium&#39; indicates medium cluster size of CE. &#39;kLarge&#39; indicates large cluster size of CE. &#39;kXLarge&#39; indicates extra large cluster size of CE. &#39;kNextGen&#39; indicates next gen CE..</param>
        /// <param name="clusterSoftwareVersion">Specifies the current release of the Cohesity software running on this Cohesity Cluster..</param>
        /// <param name="clusterType">Specifies the type of Cluster such as kPhysical. &#39;kPhysical&#39; indicates the Cohesity Cluster is hosted directly on hardware. &#39;kVirtualRobo&#39; indicates the Cohesity Cluster is hosted in a VM on a ESXi Host of a VMware vCenter Server using Cohesity&#39;s Virtual Edition. &#39;kMicrosoftCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Microsoft Azure using Cohesity&#39;s Cloud Edition. &#39;kAmazonCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Amazon S3 using Cohesity&#39;s Cloud Edition. &#39;kGoogleCloud&#39; indicates the Cohesity Cluster is hosted in a VM on Google Cloud Platform using Cohesity&#39;s Cloud Edition. &#39;kIBMCloud&#39; indicates the Cohesity Cluster is hosted in a VM on IBM Cloud.</param>
        /// <param name="createdTimeMsecs">Specifies the time when the Cohesity Cluster was created. This value is specified as a Unix epoch Timestamp (in microseconds)..</param>
        /// <param name="currentOpScheduledTimeSecs">Specifies the time scheduled by the Cohesity Cluster to start the current running operation..</param>
        /// <param name="currentOperation">Specifies the current Cluster-level operation in progress. &#39;kUpgrade&#39; indicates the Cohesity Cluster is upgrading to a new release. &#39;kRemoveNode&#39; indicates the Cohesity Cluster is removing a Node  from the Cluster.  &#39;kNone&#39; indicates no action is occurring on the Cohesity Cluster. &#39;kDestroy&#39; indicates the Cohesity Cluster is getting destoryed. &#39;kClean&#39; indicates the Cohesity Cluster is getting cleaned. &#39;kRestartServices&#39; indicates the Cohesity Cluster is restarting the services. &#39;kRestartSystemServices&#39; indicates the Cohesity Cluster is restarting the system services..</param>
        /// <param name="currentTimeMsecs">Specifies the current system time on the Cohesity Cluster. This value is specified as a Unix epoch Timestamp (in microseconds)..</param>
        /// <param name="dnsServerIps">Array of IP Addresses of DNS Servers.  Specifies the IP addresses of the DNS Servers used by the Cohesity Cluster..</param>
        /// <param name="domainNames">Array of Domain Names.  The first domain name specified in the array is the fully qualified domain name assigned to the Cohesity Cluster. Any additional domain names specified are used for the domain search list for hostname look-up..</param>
        /// <param name="enableActiveMonitoring">Specifies if Cohesity can receive monitoring information from the Cohesity Cluster. If &#39;true&#39;, remote monitoring of the Cohesity Cluster is allowed..</param>
        /// <param name="enablePatchesDownload">Specifies whether to enable downloading patches from Cohesity download site..</param>
        /// <param name="enableUpgradePkgPolling">If &#39;true&#39;, Cohesity&#39;s upgrade server is polled for new releases..</param>
        /// <param name="encryptionEnabled">If &#39;true&#39;, the entire Cohesity Cluster is encrypted including all View Boxes..</param>
        /// <param name="encryptionKeyRotationPeriodSecs">Specifies the period of time (in seconds) when encryption keys are rotated. By default, the encryption keys are rotated every 77760000 seconds (30 days)..</param>
        /// <param name="eulaConfig">Specifies the End User License Agreement (EULA) acceptance information..</param>
        /// <param name="faultToleranceLevel">Specifies the level which &#39;MetadataFaultToleranceFactor&#39; applies to. &#39;kNode&#39; indicates &#39;MetadataFaultToleranceFactor&#39; applies to Node level. &#39;kChassis&#39; indicates &#39;MetadataFaultToleranceFactor&#39; applies to Chassis level. &#39;kRack&#39; indicates &#39;MetadataFaultToleranceFactor&#39; applies to Rack level..</param>
        /// <param name="filerAuditLogConfig">filerAuditLogConfig.</param>
        /// <param name="fipsCertVersion">FIPS Certification Version.</param>
        /// <param name="fipsModeEnabled">Specifies if the Cohesity Cluster should operate in the FIPS mode, which is compliant with the Federal Information Processing Standard 140-2 certification..</param>
        /// <param name="gateway">Specifies the gateway IP address..</param>
        /// <param name="googleAnalyticsEnabled">Specifies whether Google Analytics is enabled..</param>
        /// <param name="hardwareEncryptionEnabled">Specifies if hardware encryption(SED) is enabled..</param>
        /// <param name="hardwareInfo">hardwareInfo.</param>
        /// <param name="ibmServiceInstanceId">Specifies the IBM Service instance id. Applicable only in case of Ibm One Helios..</param>
        /// <param name="ibmServiceInstanceName">Specifies the IBM Service instance name. Applicable only in case of Ibm One Helios..</param>
        /// <param name="id">Specifies the unique id of Cohesity Cluster..</param>
        /// <param name="incarnationId">Specifies the unique incarnation id of the Cohesity Cluster..</param>
        /// <param name="ipPreference">IP preference.</param>
        /// <param name="isAthenaSubnetClash">Specifies whether or not athena subnet is clashing with some other internal subnet.</param>
        /// <param name="isClusterMfaEnabled">Specifies if MFA is enabled on cluster..</param>
        /// <param name="isDocumentationLocal">Specifies what version of the documentation is used. If &#39;true&#39;, the version of documentation stored locally on the Cohesity Cluster is used. If &#39;false&#39;, the documentation stored on a Cohesity Web Server is used. The default is &#39;false&#39;. Cohesity recommends accessing the Help from the Cohesity Web site which provides the newest and most complete version of Help..</param>
        /// <param name="isFortKnoxSelfManagedVaultCluster">Specifies if the cluster is a FortKnox Onprem Vault Cluster..</param>
        /// <param name="isPatchApplyAborted">Specifies that the patch apply was aborted..</param>
        /// <param name="isPatchRevertAborted">Specifies that the patch revert was aborted..</param>
        /// <param name="isUpgradeAborted">Flag to indicate if the current upgrade has been aborted..</param>
        /// <param name="kmsServerId">Specifies the KMS Server Id. This can only be set when the encryption is enabled on cluster..</param>
        /// <param name="languageLocale">Specifies the language and locale for this Cohesity Cluster..</param>
        /// <param name="licenseState">Specifies the Licensing State information..</param>
        /// <param name="loadBalancerVipConfig">loadBalancerVipConfig.</param>
        /// <param name="localAuthDomainName">Domain name for SMB local authentication..</param>
        /// <param name="localGroupsEnabled">Specifies whether to enable local groups on cluster. Once it is enabled, it cannot be disabled..</param>
        /// <param name="metadataFaultToleranceFactor">Specifies metadata fault tolerance setting for the cluster. This denotes the number of simultaneous failures[node] supported by metadata services like gandalf and scribe..</param>
        /// <param name="minimumFailureDomainsNeeded">Specifies minimum failure domains needed in the cluster..</param>
        /// <param name="multiTenancyEnabled">Specifies if multi tenancy is enabled in the cluster. Authentication &amp; Authorization will always use tenant_id, however, some UI elements may be disabled when multi tenancy is disabled..</param>
        /// <param name="name">Specifies the name of the Cohesity Cluster..</param>
        /// <param name="netbackupServicesConfig">netbackupServicesConfig.</param>
        /// <param name="nodeCount">Specifies the number of Nodes in the Cohesity Cluster..</param>
        /// <param name="nodeIps">IP addresses of nodes in the cluster.</param>
        /// <param name="ntpSettings">ntpSettings.</param>
        /// <param name="patchApplyFailureErrorMessage">Specifies the error message for a failed patch apply..</param>
        /// <param name="patchRevertFailureErrorMessage">Specifies the error message for a failed patch revert..</param>
        /// <param name="patchRevertVersion">Specifies the target version for reverting the patch..</param>
        /// <param name="patchTargetVersion">Specifies the target version for applying the patch..</param>
        /// <param name="patchV2RevertsAllowed">Bool specifying if cluster can support patch reverts (Patch v2 only)..</param>
        /// <param name="patchVersion">Specifies the patch version applied to cluster..</param>
        /// <param name="pcieSsdTierRebalanceDelaySecs">Specifies the rebalance delay in seconds for cluster PcieSSD storage tier..</param>
        /// <param name="protoRpcEncryptionEnabled">Specifies if protorpc encryption is enabled or not..</param>
        /// <param name="proxyVMSubnet">The subnet reserved for ProxyVM.</param>
        /// <param name="reverseTunnelEnableExtension">ReverseTunnelEnableExtension specifies if the reverse tunnel should be extended..</param>
        /// <param name="reverseTunnelEnabled">If &#39;true&#39;, Cohesity&#39;s Remote Tunnel is enabled. Cohesity can access the Cluster and provide remote assistance via a Remote Tunnel..</param>
        /// <param name="reverseTunnelEndTimeMsecs">ReverseTunnelEndTimeMsecs specifies the end time in milliseconds since epoch until when the reverse tunnel will stay enabled..</param>
        /// <param name="reverseTunnelExtensionDurationHours">ReverseTunnelExtensionDurationHours specifies the number of hours to extend the reverse tunnel..</param>
        /// <param name="s3VirtualHostedDomainNames">Specifies the list of domain names for S3 Virtual Hosted Style Paths. If set, all the Cohesity S3 Views in the cluster can be accessed using any of the specified domain names..</param>
        /// <param name="sataHddTierAdmissionControl">Specifies the admission control for cluster SATAHDD storage tier..</param>
        /// <param name="schemaInfoList">Specifies the time series schema info of the cluster..</param>
        /// <param name="securityModeDod">Specifies if Security Mode DOD is enabled or not..</param>
        /// <param name="smbAdDisabled">Specifies if Active Directory should be disabled for authentication of SMB shares. If &#39;true&#39;, Active Directory is disabled..</param>
        /// <param name="smbMultichannelEnabled">Specifies whether SMB multichannel is enabled on the cluster. When this is set to true, then any SMB3 multichannel enabled client can establish multiple TCP connection per session to the Server..</param>
        /// <param name="softwareType">Specifies the type of Cohesity Software. &#39;kOneHelios&#39; indicates the one helios Cohesity Cluster. &#39;kNetBackup&#39; indicates the NetBackup Cohesity Cluster. &#39;kRegular&#39; indicates the regular Cohesity Cluster..</param>
        /// <param name="splitKeyHostAccess">Specifies if split key host access is enabled..</param>
        /// <param name="stats">stats.</param>
        /// <param name="stigMode">TODO(mitch) StigMode is deprecated. Should it still be in this list??.</param>
        /// <param name="supportedConfig">supportedConfig.</param>
        /// <param name="syslogServers">Syslog servers..</param>
        /// <param name="targetSoftwareVersion">Specifies the Cohesity release that this Cluster is being upgraded to if an upgrade operation is in progress..</param>
        /// <param name="tenantViewboxSharingEnabled">In case multi tenancy is enabled, this flag controls whether multiple tenants can be placed on the same viewbox. Once set to true, this flag should never become false..</param>
        /// <param name="tieringAuditLogConfig">tieringAuditLogConfig.</param>
        /// <param name="timezone">Specifies the timezone to use for showing time in emails, reports, filer audit logs, etc..</param>
        /// <param name="tlsEnabled">Specifies if the TLS is enabled on the remote cluster..</param>
        /// <param name="trustDomain">Trust Domain..</param>
        /// <param name="turboMode">Specifies if the cluster is in Turbo mode..</param>
        /// <param name="upgradeFailureErrorString">Error string to capture why the upgrade failed..</param>
        /// <param name="useDefaultAgentPorts">To use default ports 50051 &amp; 21213.</param>
        /// <param name="useHeimdall">Specifies whether to enable Heimdall which tells whether services should use temporary fleet instances to mount disks by talking to Heimdall..</param>
        /// <param name="usedMetadataSpacePct">UsedMetadataSpacePct measures the percentage about storage used for metadata over the total storage available for metadata.</param>
        /// <param name="virtualDataplaneIdentifier">Virtual dataplane id for the cluster. This will be used to mask the changes in cluster id in scenarios like tenant migration.</param>
        public Cluster(string aesEncryptionMode = default(string), AMQPTargetConfig amqpTargetConfig = default(AMQPTargetConfig), Subnet appsSubnet = default(Subnet), int? assignedRacksCount = default(int?), bool? attemptAgentPortsUpgrade = default(bool?), bool? authSupportForPkgDownloads = default(bool?), long? availableMetadataSpace = default(long?), bool? bannerEnabled = default(bool?), bool? centralizedPatchingEnabled = default(bool?), int? chassisCount = default(int?), ClaimTypeEnum? claimType = default(ClaimTypeEnum?), bool? cloudRf1Enabled = default(bool?), ClusterAuditLogConfiguration clusterAuditLogConfig = default(ClusterAuditLogConfiguration), ClusterDeploymentTypeEnum? clusterDeploymentType = default(ClusterDeploymentTypeEnum?), ClusterSizeEnum? clusterSize = default(ClusterSizeEnum?), string clusterSoftwareVersion = default(string), ClusterTypeEnum? clusterType = default(ClusterTypeEnum?), long? createdTimeMsecs = default(long?), long? currentOpScheduledTimeSecs = default(long?), CurrentOperationEnum? currentOperation = default(CurrentOperationEnum?), long? currentTimeMsecs = default(long?), List<string> dnsServerIps = default(List<string>), List<string> domainNames = default(List<string>), bool? enableActiveMonitoring = default(bool?), bool? enablePatchesDownload = default(bool?), bool? enableUpgradePkgPolling = default(bool?), bool? encryptionEnabled = default(bool?), long? encryptionKeyRotationPeriodSecs = default(long?), EulaConfig eulaConfig = default(EulaConfig), FaultToleranceLevelEnum? faultToleranceLevel = default(FaultToleranceLevelEnum?), FilerAuditLogConfiguration filerAuditLogConfig = default(FilerAuditLogConfiguration), string fipsCertVersion = default(string), bool? fipsModeEnabled = default(bool?), string gateway = default(string), bool? googleAnalyticsEnabled = default(bool?), bool? hardwareEncryptionEnabled = default(bool?), ClusterHardwareInfo hardwareInfo = default(ClusterHardwareInfo), string ibmServiceInstanceId = default(string), string ibmServiceInstanceName = default(string), long? id = default(long?), long? incarnationId = default(long?), int? ipPreference = default(int?), bool? isAthenaSubnetClash = default(bool?), bool? isClusterMfaEnabled = default(bool?), bool? isDocumentationLocal = default(bool?), bool? isFortKnoxSelfManagedVaultCluster = default(bool?), bool? isPatchApplyAborted = default(bool?), bool? isPatchRevertAborted = default(bool?), bool? isUpgradeAborted = default(bool?), long? kmsServerId = default(long?), string languageLocale = default(string), LicenseState licenseState = default(LicenseState), LoadBalancerVipConfig loadBalancerVipConfig = default(LoadBalancerVipConfig), string localAuthDomainName = default(string), bool? localGroupsEnabled = default(bool?), int? metadataFaultToleranceFactor = default(int?), int? minimumFailureDomainsNeeded = default(int?), bool? multiTenancyEnabled = default(bool?), string name = default(string), NetbackupServicesConfig netbackupServicesConfig = default(NetbackupServicesConfig), long? nodeCount = default(long?), string nodeIps = default(string), NtpSettingsConfig ntpSettings = default(NtpSettingsConfig), string patchApplyFailureErrorMessage = default(string), string patchRevertFailureErrorMessage = default(string), string patchRevertVersion = default(string), string patchTargetVersion = default(string), bool? patchV2RevertsAllowed = default(bool?), string patchVersion = default(string), int? pcieSsdTierRebalanceDelaySecs = default(int?), bool? protoRpcEncryptionEnabled = default(bool?), string proxyVMSubnet = default(string), bool? reverseTunnelEnableExtension = default(bool?), bool? reverseTunnelEnabled = default(bool?), long? reverseTunnelEndTimeMsecs = default(long?), long? reverseTunnelExtensionDurationHours = default(long?), List<string> s3VirtualHostedDomainNames = default(List<string>), int? sataHddTierAdmissionControl = default(int?), List<SchemaInfo> schemaInfoList = default(List<SchemaInfo>), bool? securityModeDod = default(bool?), bool? smbAdDisabled = default(bool?), bool? smbMultichannelEnabled = default(bool?), SoftwareTypeEnum? softwareType = default(SoftwareTypeEnum?), bool? splitKeyHostAccess = default(bool?), ClusterStats stats = default(ClusterStats), bool? stigMode = default(bool?), SupportedConfig supportedConfig = default(SupportedConfig), List<OldSyslogServer> syslogServers = default(List<OldSyslogServer>), string targetSoftwareVersion = default(string), bool? tenantViewboxSharingEnabled = default(bool?), TieringAuditLogConfiguration tieringAuditLogConfig = default(TieringAuditLogConfiguration), string timezone = default(string), bool? tlsEnabled = default(bool?), string trustDomain = default(string), bool? turboMode = default(bool?), string upgradeFailureErrorString = default(string), bool? useDefaultAgentPorts = default(bool?), bool? useHeimdall = default(bool?), double? usedMetadataSpacePct = default(double?), string virtualDataplaneIdentifier = default(string))
        {
            this.AesEncryptionMode = aesEncryptionMode;
            this.AssignedRacksCount = assignedRacksCount;
            this.AttemptAgentPortsUpgrade = attemptAgentPortsUpgrade;
            this.AuthSupportForPkgDownloads = authSupportForPkgDownloads;
            this.AvailableMetadataSpace = availableMetadataSpace;
            this.BannerEnabled = bannerEnabled;
            this.CentralizedPatchingEnabled = centralizedPatchingEnabled;
            this.ChassisCount = chassisCount;
            this.ClaimType = claimType;
            this.CloudRf1Enabled = cloudRf1Enabled;
            this.ClusterDeploymentType = clusterDeploymentType;
            this.ClusterSize = clusterSize;
            this.ClusterSoftwareVersion = clusterSoftwareVersion;
            this.ClusterType = clusterType;
            this.CreatedTimeMsecs = createdTimeMsecs;
            this.CurrentOpScheduledTimeSecs = currentOpScheduledTimeSecs;
            this.CurrentOperation = currentOperation;
            this.CurrentTimeMsecs = currentTimeMsecs;
            this.DnsServerIps = dnsServerIps;
            this.DomainNames = domainNames;
            this.EnableActiveMonitoring = enableActiveMonitoring;
            this.EnablePatchesDownload = enablePatchesDownload;
            this.EnableUpgradePkgPolling = enableUpgradePkgPolling;
            this.EncryptionEnabled = encryptionEnabled;
            this.EncryptionKeyRotationPeriodSecs = encryptionKeyRotationPeriodSecs;
            this.EulaConfig = eulaConfig;
            this.FaultToleranceLevel = faultToleranceLevel;
            this.FipsCertVersion = fipsCertVersion;
            this.FipsModeEnabled = fipsModeEnabled;
            this.Gateway = gateway;
            this.GoogleAnalyticsEnabled = googleAnalyticsEnabled;
            this.HardwareEncryptionEnabled = hardwareEncryptionEnabled;
            this.IbmServiceInstanceId = ibmServiceInstanceId;
            this.IbmServiceInstanceName = ibmServiceInstanceName;
            this.Id = id;
            this.IncarnationId = incarnationId;
            this.IpPreference = ipPreference;
            this.IsAthenaSubnetClash = isAthenaSubnetClash;
            this.IsClusterMfaEnabled = isClusterMfaEnabled;
            this.IsDocumentationLocal = isDocumentationLocal;
            this.IsFortKnoxSelfManagedVaultCluster = isFortKnoxSelfManagedVaultCluster;
            this.IsPatchApplyAborted = isPatchApplyAborted;
            this.IsPatchRevertAborted = isPatchRevertAborted;
            this.IsUpgradeAborted = isUpgradeAborted;
            this.KmsServerId = kmsServerId;
            this.LanguageLocale = languageLocale;
            this.LicenseState = licenseState;
            this.LocalAuthDomainName = localAuthDomainName;
            this.LocalGroupsEnabled = localGroupsEnabled;
            this.MetadataFaultToleranceFactor = metadataFaultToleranceFactor;
            this.MinimumFailureDomainsNeeded = minimumFailureDomainsNeeded;
            this.MultiTenancyEnabled = multiTenancyEnabled;
            this.Name = name;
            this.NodeCount = nodeCount;
            this.NodeIps = nodeIps;
            this.PatchApplyFailureErrorMessage = patchApplyFailureErrorMessage;
            this.PatchRevertFailureErrorMessage = patchRevertFailureErrorMessage;
            this.PatchRevertVersion = patchRevertVersion;
            this.PatchTargetVersion = patchTargetVersion;
            this.PatchV2RevertsAllowed = patchV2RevertsAllowed;
            this.PatchVersion = patchVersion;
            this.PcieSsdTierRebalanceDelaySecs = pcieSsdTierRebalanceDelaySecs;
            this.ProtoRpcEncryptionEnabled = protoRpcEncryptionEnabled;
            this.ProxyVMSubnet = proxyVMSubnet;
            this.ReverseTunnelEnableExtension = reverseTunnelEnableExtension;
            this.ReverseTunnelEnabled = reverseTunnelEnabled;
            this.ReverseTunnelEndTimeMsecs = reverseTunnelEndTimeMsecs;
            this.ReverseTunnelExtensionDurationHours = reverseTunnelExtensionDurationHours;
            this.S3VirtualHostedDomainNames = s3VirtualHostedDomainNames;
            this.SataHddTierAdmissionControl = sataHddTierAdmissionControl;
            this.SchemaInfoList = schemaInfoList;
            this.SecurityModeDod = securityModeDod;
            this.SmbAdDisabled = smbAdDisabled;
            this.SmbMultichannelEnabled = smbMultichannelEnabled;
            this.SoftwareType = softwareType;
            this.SplitKeyHostAccess = splitKeyHostAccess;
            this.StigMode = stigMode;
            this.SyslogServers = syslogServers;
            this.TargetSoftwareVersion = targetSoftwareVersion;
            this.TenantViewboxSharingEnabled = tenantViewboxSharingEnabled;
            this.Timezone = timezone;
            this.TlsEnabled = tlsEnabled;
            this.TrustDomain = trustDomain;
            this.TurboMode = turboMode;
            this.UpgradeFailureErrorString = upgradeFailureErrorString;
            this.UseDefaultAgentPorts = useDefaultAgentPorts;
            this.UseHeimdall = useHeimdall;
            this.UsedMetadataSpacePct = usedMetadataSpacePct;
            this.VirtualDataplaneIdentifier = virtualDataplaneIdentifier;
            this.AesEncryptionMode = aesEncryptionMode;
            this.AmqpTargetConfig = amqpTargetConfig;
            this.AppsSubnet = appsSubnet;
            this.AssignedRacksCount = assignedRacksCount;
            this.AttemptAgentPortsUpgrade = attemptAgentPortsUpgrade;
            this.AuthSupportForPkgDownloads = authSupportForPkgDownloads;
            this.AvailableMetadataSpace = availableMetadataSpace;
            this.BannerEnabled = bannerEnabled;
            this.CentralizedPatchingEnabled = centralizedPatchingEnabled;
            this.ChassisCount = chassisCount;
            this.ClaimType = claimType;
            this.CloudRf1Enabled = cloudRf1Enabled;
            this.ClusterAuditLogConfig = clusterAuditLogConfig;
            this.ClusterDeploymentType = clusterDeploymentType;
            this.ClusterSize = clusterSize;
            this.ClusterSoftwareVersion = clusterSoftwareVersion;
            this.ClusterType = clusterType;
            this.CreatedTimeMsecs = createdTimeMsecs;
            this.CurrentOpScheduledTimeSecs = currentOpScheduledTimeSecs;
            this.CurrentOperation = currentOperation;
            this.CurrentTimeMsecs = currentTimeMsecs;
            this.DnsServerIps = dnsServerIps;
            this.DomainNames = domainNames;
            this.EnableActiveMonitoring = enableActiveMonitoring;
            this.EnablePatchesDownload = enablePatchesDownload;
            this.EnableUpgradePkgPolling = enableUpgradePkgPolling;
            this.EncryptionEnabled = encryptionEnabled;
            this.EncryptionKeyRotationPeriodSecs = encryptionKeyRotationPeriodSecs;
            this.EulaConfig = eulaConfig;
            this.FaultToleranceLevel = faultToleranceLevel;
            this.FilerAuditLogConfig = filerAuditLogConfig;
            this.FipsCertVersion = fipsCertVersion;
            this.FipsModeEnabled = fipsModeEnabled;
            this.Gateway = gateway;
            this.GoogleAnalyticsEnabled = googleAnalyticsEnabled;
            this.HardwareEncryptionEnabled = hardwareEncryptionEnabled;
            this.HardwareInfo = hardwareInfo;
            this.IbmServiceInstanceId = ibmServiceInstanceId;
            this.IbmServiceInstanceName = ibmServiceInstanceName;
            this.Id = id;
            this.IncarnationId = incarnationId;
            this.IpPreference = ipPreference;
            this.IsAthenaSubnetClash = isAthenaSubnetClash;
            this.IsClusterMfaEnabled = isClusterMfaEnabled;
            this.IsDocumentationLocal = isDocumentationLocal;
            this.IsFortKnoxSelfManagedVaultCluster = isFortKnoxSelfManagedVaultCluster;
            this.IsPatchApplyAborted = isPatchApplyAborted;
            this.IsPatchRevertAborted = isPatchRevertAborted;
            this.IsUpgradeAborted = isUpgradeAborted;
            this.KmsServerId = kmsServerId;
            this.LanguageLocale = languageLocale;
            this.LicenseState = licenseState;
            this.LoadBalancerVipConfig = loadBalancerVipConfig;
            this.LocalAuthDomainName = localAuthDomainName;
            this.LocalGroupsEnabled = localGroupsEnabled;
            this.MetadataFaultToleranceFactor = metadataFaultToleranceFactor;
            this.MinimumFailureDomainsNeeded = minimumFailureDomainsNeeded;
            this.MultiTenancyEnabled = multiTenancyEnabled;
            this.Name = name;
            this.NetbackupServicesConfig = netbackupServicesConfig;
            this.NodeCount = nodeCount;
            this.NodeIps = nodeIps;
            this.NtpSettings = ntpSettings;
            this.PatchApplyFailureErrorMessage = patchApplyFailureErrorMessage;
            this.PatchRevertFailureErrorMessage = patchRevertFailureErrorMessage;
            this.PatchRevertVersion = patchRevertVersion;
            this.PatchTargetVersion = patchTargetVersion;
            this.PatchV2RevertsAllowed = patchV2RevertsAllowed;
            this.PatchVersion = patchVersion;
            this.PcieSsdTierRebalanceDelaySecs = pcieSsdTierRebalanceDelaySecs;
            this.ProtoRpcEncryptionEnabled = protoRpcEncryptionEnabled;
            this.ProxyVMSubnet = proxyVMSubnet;
            this.ReverseTunnelEnableExtension = reverseTunnelEnableExtension;
            this.ReverseTunnelEnabled = reverseTunnelEnabled;
            this.ReverseTunnelEndTimeMsecs = reverseTunnelEndTimeMsecs;
            this.ReverseTunnelExtensionDurationHours = reverseTunnelExtensionDurationHours;
            this.S3VirtualHostedDomainNames = s3VirtualHostedDomainNames;
            this.SataHddTierAdmissionControl = sataHddTierAdmissionControl;
            this.SchemaInfoList = schemaInfoList;
            this.SecurityModeDod = securityModeDod;
            this.SmbAdDisabled = smbAdDisabled;
            this.SmbMultichannelEnabled = smbMultichannelEnabled;
            this.SoftwareType = softwareType;
            this.SplitKeyHostAccess = splitKeyHostAccess;
            this.Stats = stats;
            this.StigMode = stigMode;
            this.SupportedConfig = supportedConfig;
            this.SyslogServers = syslogServers;
            this.TargetSoftwareVersion = targetSoftwareVersion;
            this.TenantViewboxSharingEnabled = tenantViewboxSharingEnabled;
            this.TieringAuditLogConfig = tieringAuditLogConfig;
            this.Timezone = timezone;
            this.TlsEnabled = tlsEnabled;
            this.TrustDomain = trustDomain;
            this.TurboMode = turboMode;
            this.UpgradeFailureErrorString = upgradeFailureErrorString;
            this.UseDefaultAgentPorts = useDefaultAgentPorts;
            this.UseHeimdall = useHeimdall;
            this.UsedMetadataSpacePct = usedMetadataSpacePct;
            this.VirtualDataplaneIdentifier = virtualDataplaneIdentifier;
        }
        
        /// <summary>
        /// Specifies the default AES Encryption mode on the cluster.
        /// </summary>
        /// <value>Specifies the default AES Encryption mode on the cluster.</value>
        [DataMember(Name="aesEncryptionMode", EmitDefaultValue=true)]
        public string AesEncryptionMode { get; set; }

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
        /// Specifies the number of racks in cluster with at least one rack assigned.
        /// </summary>
        /// <value>Specifies the number of racks in cluster with at least one rack assigned.</value>
        [DataMember(Name="assignedRacksCount", EmitDefaultValue=true)]
        public int? AssignedRacksCount { get; set; }

        /// <summary>
        /// To attempt agent connection on port 21213 first
        /// </summary>
        /// <value>To attempt agent connection on port 21213 first</value>
        [DataMember(Name="attemptAgentPortsUpgrade", EmitDefaultValue=true)]
        public bool? AttemptAgentPortsUpgrade { get; set; }

        /// <summary>
        /// Bool specifying if cluster can support authHeaders for upgrade
        /// </summary>
        /// <value>Bool specifying if cluster can support authHeaders for upgrade</value>
        [DataMember(Name="authSupportForPkgDownloads", EmitDefaultValue=true)]
        public bool? AuthSupportForPkgDownloads { get; set; }

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
        /// Bool specifying if cluster can support patching via Helios
        /// </summary>
        /// <value>Bool specifying if cluster can support patching via Helios</value>
        [DataMember(Name="centralizedPatchingEnabled", EmitDefaultValue=true)]
        public bool? CentralizedPatchingEnabled { get; set; }

        /// <summary>
        /// Specifies the number of chassis in cluster.
        /// </summary>
        /// <value>Specifies the number of chassis in cluster.</value>
        [DataMember(Name="chassisCount", EmitDefaultValue=true)]
        public int? ChassisCount { get; set; }

        /// <summary>
        /// Specifies if the Cloud RF1 is enabled on the cluster.
        /// </summary>
        /// <value>Specifies if the Cloud RF1 is enabled on the cluster.</value>
        [DataMember(Name="cloudRf1Enabled", EmitDefaultValue=true)]
        public bool? CloudRf1Enabled { get; set; }

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
        /// Specifies the number of disks on the cluster by Storage Tier.
        /// </summary>
        /// <value>Specifies the number of disks on the cluster by Storage Tier.</value>
        [DataMember(Name="diskCountByTier", EmitDefaultValue=true)]
        public List<CountByTier> DiskCountByTier { get; private set; }

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
        /// FIPS Certification Version
        /// </summary>
        /// <value>FIPS Certification Version</value>
        [DataMember(Name="fipsCertVersion", EmitDefaultValue=true)]
        public string FipsCertVersion { get; set; }

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
        /// Specifies if hardware encryption(SED) is enabled.
        /// </summary>
        /// <value>Specifies if hardware encryption(SED) is enabled.</value>
        [DataMember(Name="hardwareEncryptionEnabled", EmitDefaultValue=true)]
        public bool? HardwareEncryptionEnabled { get; set; }

        /// <summary>
        /// Gets or Sets HardwareInfo
        /// </summary>
        [DataMember(Name="hardwareInfo", EmitDefaultValue=false)]
        public ClusterHardwareInfo HardwareInfo { get; set; }

        /// <summary>
        /// Specifies list of FQDN hostname of the cluster.
        /// </summary>
        /// <value>Specifies list of FQDN hostname of the cluster.</value>
        [DataMember(Name="hostNames", EmitDefaultValue=true)]
        public List<string> HostNames { get; private set; }

        /// <summary>
        /// Specifies the IBM Service instance id. Applicable only in case of Ibm One Helios.
        /// </summary>
        /// <value>Specifies the IBM Service instance id. Applicable only in case of Ibm One Helios.</value>
        [DataMember(Name="ibmServiceInstanceId", EmitDefaultValue=true)]
        public string IbmServiceInstanceId { get; set; }

        /// <summary>
        /// Specifies the IBM Service instance name. Applicable only in case of Ibm One Helios.
        /// </summary>
        /// <value>Specifies the IBM Service instance name. Applicable only in case of Ibm One Helios.</value>
        [DataMember(Name="ibmServiceInstanceName", EmitDefaultValue=true)]
        public string IbmServiceInstanceName { get; set; }

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
        /// Specifies whether or not athena subnet is clashing with some other internal subnet
        /// </summary>
        /// <value>Specifies whether or not athena subnet is clashing with some other internal subnet</value>
        [DataMember(Name="isAthenaSubnetClash", EmitDefaultValue=true)]
        public bool? IsAthenaSubnetClash { get; set; }

        /// <summary>
        /// Specifies if MFA is enabled on cluster.
        /// </summary>
        /// <value>Specifies if MFA is enabled on cluster.</value>
        [DataMember(Name="isClusterMfaEnabled", EmitDefaultValue=true)]
        public bool? IsClusterMfaEnabled { get; set; }

        /// <summary>
        /// Specifies what version of the documentation is used. If &#39;true&#39;, the version of documentation stored locally on the Cohesity Cluster is used. If &#39;false&#39;, the documentation stored on a Cohesity Web Server is used. The default is &#39;false&#39;. Cohesity recommends accessing the Help from the Cohesity Web site which provides the newest and most complete version of Help.
        /// </summary>
        /// <value>Specifies what version of the documentation is used. If &#39;true&#39;, the version of documentation stored locally on the Cohesity Cluster is used. If &#39;false&#39;, the documentation stored on a Cohesity Web Server is used. The default is &#39;false&#39;. Cohesity recommends accessing the Help from the Cohesity Web site which provides the newest and most complete version of Help.</value>
        [DataMember(Name="isDocumentationLocal", EmitDefaultValue=true)]
        public bool? IsDocumentationLocal { get; set; }

        /// <summary>
        /// Specifies if the cluster is a FortKnox Onprem Vault Cluster.
        /// </summary>
        /// <value>Specifies if the cluster is a FortKnox Onprem Vault Cluster.</value>
        [DataMember(Name="isFortKnoxSelfManagedVaultCluster", EmitDefaultValue=true)]
        public bool? IsFortKnoxSelfManagedVaultCluster { get; set; }

        /// <summary>
        /// Specifies that the patch apply was aborted.
        /// </summary>
        /// <value>Specifies that the patch apply was aborted.</value>
        [DataMember(Name="isPatchApplyAborted", EmitDefaultValue=true)]
        public bool? IsPatchApplyAborted { get; set; }

        /// <summary>
        /// Specifies that the patch revert was aborted.
        /// </summary>
        /// <value>Specifies that the patch revert was aborted.</value>
        [DataMember(Name="isPatchRevertAborted", EmitDefaultValue=true)]
        public bool? IsPatchRevertAborted { get; set; }

        /// <summary>
        /// Flag to indicate if the current upgrade has been aborted.
        /// </summary>
        /// <value>Flag to indicate if the current upgrade has been aborted.</value>
        [DataMember(Name="isUpgradeAborted", EmitDefaultValue=true)]
        public bool? IsUpgradeAborted { get; set; }

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
        /// Specifies the Licensing State information.
        /// </summary>
        /// <value>Specifies the Licensing State information.</value>
        [DataMember(Name="licenseState", EmitDefaultValue=true)]
        public LicenseState LicenseState { get; set; }

        /// <summary>
        /// Gets or Sets LoadBalancerVipConfig
        /// </summary>
        [DataMember(Name="loadBalancerVipConfig", EmitDefaultValue=false)]
        public LoadBalancerVipConfig LoadBalancerVipConfig { get; set; }

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
        /// Specifies minimum failure domains needed in the cluster.
        /// </summary>
        /// <value>Specifies minimum failure domains needed in the cluster.</value>
        [DataMember(Name="minimumFailureDomainsNeeded", EmitDefaultValue=true)]
        public int? MinimumFailureDomainsNeeded { get; set; }

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
        /// Gets or Sets NetbackupServicesConfig
        /// </summary>
        [DataMember(Name="netbackupServicesConfig", EmitDefaultValue=false)]
        public NetbackupServicesConfig NetbackupServicesConfig { get; set; }

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
        /// Specifies the error message for a failed patch apply.
        /// </summary>
        /// <value>Specifies the error message for a failed patch apply.</value>
        [DataMember(Name="patchApplyFailureErrorMessage", EmitDefaultValue=true)]
        public string PatchApplyFailureErrorMessage { get; set; }

        /// <summary>
        /// Specifies the error message for a failed patch revert.
        /// </summary>
        /// <value>Specifies the error message for a failed patch revert.</value>
        [DataMember(Name="patchRevertFailureErrorMessage", EmitDefaultValue=true)]
        public string PatchRevertFailureErrorMessage { get; set; }

        /// <summary>
        /// Specifies the target version for reverting the patch.
        /// </summary>
        /// <value>Specifies the target version for reverting the patch.</value>
        [DataMember(Name="patchRevertVersion", EmitDefaultValue=true)]
        public string PatchRevertVersion { get; set; }

        /// <summary>
        /// Specifies the target version for applying the patch.
        /// </summary>
        /// <value>Specifies the target version for applying the patch.</value>
        [DataMember(Name="patchTargetVersion", EmitDefaultValue=true)]
        public string PatchTargetVersion { get; set; }

        /// <summary>
        /// Bool specifying if cluster can support patch reverts (Patch v2 only).
        /// </summary>
        /// <value>Bool specifying if cluster can support patch reverts (Patch v2 only).</value>
        [DataMember(Name="patchV2RevertsAllowed", EmitDefaultValue=true)]
        public bool? PatchV2RevertsAllowed { get; set; }

        /// <summary>
        /// Specifies the patch version applied to cluster.
        /// </summary>
        /// <value>Specifies the patch version applied to cluster.</value>
        [DataMember(Name="patchVersion", EmitDefaultValue=true)]
        public string PatchVersion { get; set; }

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
        /// The subnet reserved for ProxyVM
        /// </summary>
        /// <value>The subnet reserved for ProxyVM</value>
        [DataMember(Name="proxyVMSubnet", EmitDefaultValue=true)]
        public string ProxyVMSubnet { get; set; }

        /// <summary>
        /// ReverseTunnelEnableExtension specifies if the reverse tunnel should be extended.
        /// </summary>
        /// <value>ReverseTunnelEnableExtension specifies if the reverse tunnel should be extended.</value>
        [DataMember(Name="reverseTunnelEnableExtension", EmitDefaultValue=true)]
        public bool? ReverseTunnelEnableExtension { get; set; }

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
        /// ReverseTunnelExtensionDurationHours specifies the number of hours to extend the reverse tunnel.
        /// </summary>
        /// <value>ReverseTunnelExtensionDurationHours specifies the number of hours to extend the reverse tunnel.</value>
        [DataMember(Name="reverseTunnelExtensionDurationHours", EmitDefaultValue=true)]
        public long? ReverseTunnelExtensionDurationHours { get; set; }

        /// <summary>
        /// Specifies the list of domain names for S3 Virtual Hosted Style Paths. If set, all the Cohesity S3 Views in the cluster can be accessed using any of the specified domain names.
        /// </summary>
        /// <value>Specifies the list of domain names for S3 Virtual Hosted Style Paths. If set, all the Cohesity S3 Views in the cluster can be accessed using any of the specified domain names.</value>
        [DataMember(Name="s3VirtualHostedDomainNames", EmitDefaultValue=true)]
        public List<string> S3VirtualHostedDomainNames { get; set; }

        /// <summary>
        /// Specifies the admission control for cluster SATAHDD storage tier.
        /// </summary>
        /// <value>Specifies the admission control for cluster SATAHDD storage tier.</value>
        [DataMember(Name="sataHddTierAdmissionControl", EmitDefaultValue=true)]
        public int? SataHddTierAdmissionControl { get; set; }

        /// <summary>
        /// Specifies the time series schema info of the cluster.
        /// </summary>
        /// <value>Specifies the time series schema info of the cluster.</value>
        [DataMember(Name="schemaInfoList", EmitDefaultValue=true)]
        public List<SchemaInfo> SchemaInfoList { get; set; }

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
        /// Specifies if split key host access is enabled.
        /// </summary>
        /// <value>Specifies if split key host access is enabled.</value>
        [DataMember(Name="splitKeyHostAccess", EmitDefaultValue=true)]
        public bool? SplitKeyHostAccess { get; set; }

        /// <summary>
        /// Gets or Sets Stats
        /// </summary>
        [DataMember(Name="stats", EmitDefaultValue=false)]
        public ClusterStats Stats { get; set; }

        /// <summary>
        /// TODO(mitch) StigMode is deprecated. Should it still be in this list??
        /// </summary>
        /// <value>TODO(mitch) StigMode is deprecated. Should it still be in this list??</value>
        [DataMember(Name="stigMode", EmitDefaultValue=true)]
        public bool? StigMode { get; set; }

        /// <summary>
        /// Gets or Sets SupportedConfig
        /// </summary>
        [DataMember(Name="supportedConfig", EmitDefaultValue=false)]
        public SupportedConfig SupportedConfig { get; set; }

        /// <summary>
        /// Syslog servers.
        /// </summary>
        /// <value>Syslog servers.</value>
        [DataMember(Name="syslogServers", EmitDefaultValue=true)]
        public List<OldSyslogServer> SyslogServers { get; set; }

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
        /// Specifies if the TLS is enabled on the remote cluster.
        /// </summary>
        /// <value>Specifies if the TLS is enabled on the remote cluster.</value>
        [DataMember(Name="tlsEnabled", EmitDefaultValue=true)]
        public bool? TlsEnabled { get; set; }

        /// <summary>
        /// Trust Domain.
        /// </summary>
        /// <value>Trust Domain.</value>
        [DataMember(Name="trustDomain", EmitDefaultValue=true)]
        public string TrustDomain { get; set; }

        /// <summary>
        /// Specifies if the cluster is in Turbo mode.
        /// </summary>
        /// <value>Specifies if the cluster is in Turbo mode.</value>
        [DataMember(Name="turboMode", EmitDefaultValue=true)]
        public bool? TurboMode { get; set; }

        /// <summary>
        /// Error string to capture why the upgrade failed.
        /// </summary>
        /// <value>Error string to capture why the upgrade failed.</value>
        [DataMember(Name="upgradeFailureErrorString", EmitDefaultValue=true)]
        public string UpgradeFailureErrorString { get; set; }

        /// <summary>
        /// To use default ports 50051 &amp; 21213
        /// </summary>
        /// <value>To use default ports 50051 &amp; 21213</value>
        [DataMember(Name="useDefaultAgentPorts", EmitDefaultValue=true)]
        public bool? UseDefaultAgentPorts { get; set; }

        /// <summary>
        /// Specifies whether to enable Heimdall which tells whether services should use temporary fleet instances to mount disks by talking to Heimdall.
        /// </summary>
        /// <value>Specifies whether to enable Heimdall which tells whether services should use temporary fleet instances to mount disks by talking to Heimdall.</value>
        [DataMember(Name="useHeimdall", EmitDefaultValue=true)]
        public bool? UseHeimdall { get; set; }

        /// <summary>
        /// UsedMetadataSpacePct measures the percentage about storage used for metadata over the total storage available for metadata
        /// </summary>
        /// <value>UsedMetadataSpacePct measures the percentage about storage used for metadata over the total storage available for metadata</value>
        [DataMember(Name="usedMetadataSpacePct", EmitDefaultValue=true)]
        public double? UsedMetadataSpacePct { get; set; }

        /// <summary>
        /// Virtual dataplane id for the cluster. This will be used to mask the changes in cluster id in scenarios like tenant migration
        /// </summary>
        /// <value>Virtual dataplane id for the cluster. This will be used to mask the changes in cluster id in scenarios like tenant migration</value>
        [DataMember(Name="virtualDataplaneIdentifier", EmitDefaultValue=true)]
        public string VirtualDataplaneIdentifier { get; set; }

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
                    this.AesEncryptionMode == input.AesEncryptionMode ||
                    (this.AesEncryptionMode != null &&
                    this.AesEncryptionMode.Equals(input.AesEncryptionMode))
                ) && 
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
                    this.AssignedRacksCount == input.AssignedRacksCount ||
                    (this.AssignedRacksCount != null &&
                    this.AssignedRacksCount.Equals(input.AssignedRacksCount))
                ) && 
                (
                    this.AttemptAgentPortsUpgrade == input.AttemptAgentPortsUpgrade ||
                    (this.AttemptAgentPortsUpgrade != null &&
                    this.AttemptAgentPortsUpgrade.Equals(input.AttemptAgentPortsUpgrade))
                ) && 
                (
                    this.AuthSupportForPkgDownloads == input.AuthSupportForPkgDownloads ||
                    (this.AuthSupportForPkgDownloads != null &&
                    this.AuthSupportForPkgDownloads.Equals(input.AuthSupportForPkgDownloads))
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
                    this.CentralizedPatchingEnabled == input.CentralizedPatchingEnabled ||
                    (this.CentralizedPatchingEnabled != null &&
                    this.CentralizedPatchingEnabled.Equals(input.CentralizedPatchingEnabled))
                ) && 
                (
                    this.ChassisCount == input.ChassisCount ||
                    (this.ChassisCount != null &&
                    this.ChassisCount.Equals(input.ChassisCount))
                ) && 
                (
                    this.ClaimType == input.ClaimType ||
                    this.ClaimType.Equals(input.ClaimType)
                ) && 
                (
                    this.CloudRf1Enabled == input.CloudRf1Enabled ||
                    (this.CloudRf1Enabled != null &&
                    this.CloudRf1Enabled.Equals(input.CloudRf1Enabled))
                ) && 
                (
                    this.ClusterAuditLogConfig == input.ClusterAuditLogConfig ||
                    (this.ClusterAuditLogConfig != null &&
                    this.ClusterAuditLogConfig.Equals(input.ClusterAuditLogConfig))
                ) && 
                (
                    this.ClusterDeploymentType == input.ClusterDeploymentType ||
                    this.ClusterDeploymentType.Equals(input.ClusterDeploymentType)
                ) && 
                (
                    this.ClusterSize == input.ClusterSize ||
                    this.ClusterSize.Equals(input.ClusterSize)
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
                    this.DiskCountByTier == input.DiskCountByTier ||
                    this.DiskCountByTier != null &&
                    input.DiskCountByTier != null &&
                    this.DiskCountByTier.SequenceEqual(input.DiskCountByTier)
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
                    this.FipsCertVersion == input.FipsCertVersion ||
                    (this.FipsCertVersion != null &&
                    this.FipsCertVersion.Equals(input.FipsCertVersion))
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
                    this.HardwareEncryptionEnabled == input.HardwareEncryptionEnabled ||
                    (this.HardwareEncryptionEnabled != null &&
                    this.HardwareEncryptionEnabled.Equals(input.HardwareEncryptionEnabled))
                ) && 
                (
                    this.HardwareInfo == input.HardwareInfo ||
                    (this.HardwareInfo != null &&
                    this.HardwareInfo.Equals(input.HardwareInfo))
                ) && 
                (
                    this.HostNames == input.HostNames ||
                    this.HostNames != null &&
                    input.HostNames != null &&
                    this.HostNames.SequenceEqual(input.HostNames)
                ) && 
                (
                    this.IbmServiceInstanceId == input.IbmServiceInstanceId ||
                    (this.IbmServiceInstanceId != null &&
                    this.IbmServiceInstanceId.Equals(input.IbmServiceInstanceId))
                ) && 
                (
                    this.IbmServiceInstanceName == input.IbmServiceInstanceName ||
                    (this.IbmServiceInstanceName != null &&
                    this.IbmServiceInstanceName.Equals(input.IbmServiceInstanceName))
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
                    this.IsAthenaSubnetClash == input.IsAthenaSubnetClash ||
                    (this.IsAthenaSubnetClash != null &&
                    this.IsAthenaSubnetClash.Equals(input.IsAthenaSubnetClash))
                ) && 
                (
                    this.IsClusterMfaEnabled == input.IsClusterMfaEnabled ||
                    (this.IsClusterMfaEnabled != null &&
                    this.IsClusterMfaEnabled.Equals(input.IsClusterMfaEnabled))
                ) && 
                (
                    this.IsDocumentationLocal == input.IsDocumentationLocal ||
                    (this.IsDocumentationLocal != null &&
                    this.IsDocumentationLocal.Equals(input.IsDocumentationLocal))
                ) && 
                (
                    this.IsFortKnoxSelfManagedVaultCluster == input.IsFortKnoxSelfManagedVaultCluster ||
                    (this.IsFortKnoxSelfManagedVaultCluster != null &&
                    this.IsFortKnoxSelfManagedVaultCluster.Equals(input.IsFortKnoxSelfManagedVaultCluster))
                ) && 
                (
                    this.IsPatchApplyAborted == input.IsPatchApplyAborted ||
                    (this.IsPatchApplyAborted != null &&
                    this.IsPatchApplyAborted.Equals(input.IsPatchApplyAborted))
                ) && 
                (
                    this.IsPatchRevertAborted == input.IsPatchRevertAborted ||
                    (this.IsPatchRevertAborted != null &&
                    this.IsPatchRevertAborted.Equals(input.IsPatchRevertAborted))
                ) && 
                (
                    this.IsUpgradeAborted == input.IsUpgradeAborted ||
                    (this.IsUpgradeAborted != null &&
                    this.IsUpgradeAborted.Equals(input.IsUpgradeAborted))
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
                    this.LicenseState == input.LicenseState ||
                    (this.LicenseState != null &&
                    this.LicenseState.Equals(input.LicenseState))
                ) && 
                (
                    this.LoadBalancerVipConfig == input.LoadBalancerVipConfig ||
                    (this.LoadBalancerVipConfig != null &&
                    this.LoadBalancerVipConfig.Equals(input.LoadBalancerVipConfig))
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
                    this.MinimumFailureDomainsNeeded == input.MinimumFailureDomainsNeeded ||
                    (this.MinimumFailureDomainsNeeded != null &&
                    this.MinimumFailureDomainsNeeded.Equals(input.MinimumFailureDomainsNeeded))
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
                    this.NetbackupServicesConfig == input.NetbackupServicesConfig ||
                    (this.NetbackupServicesConfig != null &&
                    this.NetbackupServicesConfig.Equals(input.NetbackupServicesConfig))
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
                    this.PatchApplyFailureErrorMessage == input.PatchApplyFailureErrorMessage ||
                    (this.PatchApplyFailureErrorMessage != null &&
                    this.PatchApplyFailureErrorMessage.Equals(input.PatchApplyFailureErrorMessage))
                ) && 
                (
                    this.PatchRevertFailureErrorMessage == input.PatchRevertFailureErrorMessage ||
                    (this.PatchRevertFailureErrorMessage != null &&
                    this.PatchRevertFailureErrorMessage.Equals(input.PatchRevertFailureErrorMessage))
                ) && 
                (
                    this.PatchRevertVersion == input.PatchRevertVersion ||
                    (this.PatchRevertVersion != null &&
                    this.PatchRevertVersion.Equals(input.PatchRevertVersion))
                ) && 
                (
                    this.PatchTargetVersion == input.PatchTargetVersion ||
                    (this.PatchTargetVersion != null &&
                    this.PatchTargetVersion.Equals(input.PatchTargetVersion))
                ) && 
                (
                    this.PatchV2RevertsAllowed == input.PatchV2RevertsAllowed ||
                    (this.PatchV2RevertsAllowed != null &&
                    this.PatchV2RevertsAllowed.Equals(input.PatchV2RevertsAllowed))
                ) && 
                (
                    this.PatchVersion == input.PatchVersion ||
                    (this.PatchVersion != null &&
                    this.PatchVersion.Equals(input.PatchVersion))
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
                    this.ProxyVMSubnet == input.ProxyVMSubnet ||
                    (this.ProxyVMSubnet != null &&
                    this.ProxyVMSubnet.Equals(input.ProxyVMSubnet))
                ) && 
                (
                    this.ReverseTunnelEnableExtension == input.ReverseTunnelEnableExtension ||
                    (this.ReverseTunnelEnableExtension != null &&
                    this.ReverseTunnelEnableExtension.Equals(input.ReverseTunnelEnableExtension))
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
                    this.ReverseTunnelExtensionDurationHours == input.ReverseTunnelExtensionDurationHours ||
                    (this.ReverseTunnelExtensionDurationHours != null &&
                    this.ReverseTunnelExtensionDurationHours.Equals(input.ReverseTunnelExtensionDurationHours))
                ) && 
                (
                    this.S3VirtualHostedDomainNames == input.S3VirtualHostedDomainNames ||
                    this.S3VirtualHostedDomainNames != null &&
                    input.S3VirtualHostedDomainNames != null &&
                    this.S3VirtualHostedDomainNames.SequenceEqual(input.S3VirtualHostedDomainNames)
                ) && 
                (
                    this.SataHddTierAdmissionControl == input.SataHddTierAdmissionControl ||
                    (this.SataHddTierAdmissionControl != null &&
                    this.SataHddTierAdmissionControl.Equals(input.SataHddTierAdmissionControl))
                ) && 
                (
                    this.SchemaInfoList == input.SchemaInfoList ||
                    this.SchemaInfoList != null &&
                    input.SchemaInfoList != null &&
                    this.SchemaInfoList.SequenceEqual(input.SchemaInfoList)
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
                    this.SoftwareType == input.SoftwareType ||
                    this.SoftwareType.Equals(input.SoftwareType)
                ) && 
                (
                    this.SplitKeyHostAccess == input.SplitKeyHostAccess ||
                    (this.SplitKeyHostAccess != null &&
                    this.SplitKeyHostAccess.Equals(input.SplitKeyHostAccess))
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
                    this.SyslogServers == input.SyslogServers ||
                    this.SyslogServers != null &&
                    input.SyslogServers != null &&
                    this.SyslogServers.SequenceEqual(input.SyslogServers)
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
                    this.TlsEnabled == input.TlsEnabled ||
                    (this.TlsEnabled != null &&
                    this.TlsEnabled.Equals(input.TlsEnabled))
                ) && 
                (
                    this.TrustDomain == input.TrustDomain ||
                    (this.TrustDomain != null &&
                    this.TrustDomain.Equals(input.TrustDomain))
                ) && 
                (
                    this.TurboMode == input.TurboMode ||
                    (this.TurboMode != null &&
                    this.TurboMode.Equals(input.TurboMode))
                ) && 
                (
                    this.UpgradeFailureErrorString == input.UpgradeFailureErrorString ||
                    (this.UpgradeFailureErrorString != null &&
                    this.UpgradeFailureErrorString.Equals(input.UpgradeFailureErrorString))
                ) && 
                (
                    this.UseDefaultAgentPorts == input.UseDefaultAgentPorts ||
                    (this.UseDefaultAgentPorts != null &&
                    this.UseDefaultAgentPorts.Equals(input.UseDefaultAgentPorts))
                ) && 
                (
                    this.UseHeimdall == input.UseHeimdall ||
                    (this.UseHeimdall != null &&
                    this.UseHeimdall.Equals(input.UseHeimdall))
                ) && 
                (
                    this.UsedMetadataSpacePct == input.UsedMetadataSpacePct ||
                    (this.UsedMetadataSpacePct != null &&
                    this.UsedMetadataSpacePct.Equals(input.UsedMetadataSpacePct))
                ) && 
                (
                    this.VirtualDataplaneIdentifier == input.VirtualDataplaneIdentifier ||
                    (this.VirtualDataplaneIdentifier != null &&
                    this.VirtualDataplaneIdentifier.Equals(input.VirtualDataplaneIdentifier))
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
                if (this.AesEncryptionMode != null)
                    hashCode = hashCode * 59 + this.AesEncryptionMode.GetHashCode();
                if (this.AmqpTargetConfig != null)
                    hashCode = hashCode * 59 + this.AmqpTargetConfig.GetHashCode();
                if (this.AppsSubnet != null)
                    hashCode = hashCode * 59 + this.AppsSubnet.GetHashCode();
                if (this.AssignedRacksCount != null)
                    hashCode = hashCode * 59 + this.AssignedRacksCount.GetHashCode();
                if (this.AttemptAgentPortsUpgrade != null)
                    hashCode = hashCode * 59 + this.AttemptAgentPortsUpgrade.GetHashCode();
                if (this.AuthSupportForPkgDownloads != null)
                    hashCode = hashCode * 59 + this.AuthSupportForPkgDownloads.GetHashCode();
                if (this.AvailableMetadataSpace != null)
                    hashCode = hashCode * 59 + this.AvailableMetadataSpace.GetHashCode();
                if (this.BannerEnabled != null)
                    hashCode = hashCode * 59 + this.BannerEnabled.GetHashCode();
                if (this.CentralizedPatchingEnabled != null)
                    hashCode = hashCode * 59 + this.CentralizedPatchingEnabled.GetHashCode();
                if (this.ChassisCount != null)
                    hashCode = hashCode * 59 + this.ChassisCount.GetHashCode();
                hashCode = hashCode * 59 + this.ClaimType.GetHashCode();
                if (this.CloudRf1Enabled != null)
                    hashCode = hashCode * 59 + this.CloudRf1Enabled.GetHashCode();
                if (this.ClusterAuditLogConfig != null)
                    hashCode = hashCode * 59 + this.ClusterAuditLogConfig.GetHashCode();
                hashCode = hashCode * 59 + this.ClusterDeploymentType.GetHashCode();
                hashCode = hashCode * 59 + this.ClusterSize.GetHashCode();
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
                if (this.DiskCountByTier != null)
                    hashCode = hashCode * 59 + this.DiskCountByTier.GetHashCode();
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
                if (this.EncryptionEnabled != null)
                    hashCode = hashCode * 59 + this.EncryptionEnabled.GetHashCode();
                if (this.EncryptionKeyRotationPeriodSecs != null)
                    hashCode = hashCode * 59 + this.EncryptionKeyRotationPeriodSecs.GetHashCode();
                if (this.EulaConfig != null)
                    hashCode = hashCode * 59 + this.EulaConfig.GetHashCode();
                hashCode = hashCode * 59 + this.FaultToleranceLevel.GetHashCode();
                if (this.FilerAuditLogConfig != null)
                    hashCode = hashCode * 59 + this.FilerAuditLogConfig.GetHashCode();
                if (this.FipsCertVersion != null)
                    hashCode = hashCode * 59 + this.FipsCertVersion.GetHashCode();
                if (this.FipsModeEnabled != null)
                    hashCode = hashCode * 59 + this.FipsModeEnabled.GetHashCode();
                if (this.Gateway != null)
                    hashCode = hashCode * 59 + this.Gateway.GetHashCode();
                if (this.GoogleAnalyticsEnabled != null)
                    hashCode = hashCode * 59 + this.GoogleAnalyticsEnabled.GetHashCode();
                if (this.HardwareEncryptionEnabled != null)
                    hashCode = hashCode * 59 + this.HardwareEncryptionEnabled.GetHashCode();
                if (this.HardwareInfo != null)
                    hashCode = hashCode * 59 + this.HardwareInfo.GetHashCode();
                if (this.HostNames != null)
                    hashCode = hashCode * 59 + this.HostNames.GetHashCode();
                if (this.IbmServiceInstanceId != null)
                    hashCode = hashCode * 59 + this.IbmServiceInstanceId.GetHashCode();
                if (this.IbmServiceInstanceName != null)
                    hashCode = hashCode * 59 + this.IbmServiceInstanceName.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IncarnationId != null)
                    hashCode = hashCode * 59 + this.IncarnationId.GetHashCode();
                if (this.IpPreference != null)
                    hashCode = hashCode * 59 + this.IpPreference.GetHashCode();
                if (this.IsAthenaSubnetClash != null)
                    hashCode = hashCode * 59 + this.IsAthenaSubnetClash.GetHashCode();
                if (this.IsClusterMfaEnabled != null)
                    hashCode = hashCode * 59 + this.IsClusterMfaEnabled.GetHashCode();
                if (this.IsDocumentationLocal != null)
                    hashCode = hashCode * 59 + this.IsDocumentationLocal.GetHashCode();
                if (this.IsFortKnoxSelfManagedVaultCluster != null)
                    hashCode = hashCode * 59 + this.IsFortKnoxSelfManagedVaultCluster.GetHashCode();
                if (this.IsPatchApplyAborted != null)
                    hashCode = hashCode * 59 + this.IsPatchApplyAborted.GetHashCode();
                if (this.IsPatchRevertAborted != null)
                    hashCode = hashCode * 59 + this.IsPatchRevertAborted.GetHashCode();
                if (this.IsUpgradeAborted != null)
                    hashCode = hashCode * 59 + this.IsUpgradeAborted.GetHashCode();
                if (this.KmsServerId != null)
                    hashCode = hashCode * 59 + this.KmsServerId.GetHashCode();
                if (this.LanguageLocale != null)
                    hashCode = hashCode * 59 + this.LanguageLocale.GetHashCode();
                if (this.LicenseState != null)
                    hashCode = hashCode * 59 + this.LicenseState.GetHashCode();
                if (this.LoadBalancerVipConfig != null)
                    hashCode = hashCode * 59 + this.LoadBalancerVipConfig.GetHashCode();
                if (this.LocalAuthDomainName != null)
                    hashCode = hashCode * 59 + this.LocalAuthDomainName.GetHashCode();
                if (this.LocalGroupsEnabled != null)
                    hashCode = hashCode * 59 + this.LocalGroupsEnabled.GetHashCode();
                if (this.MetadataFaultToleranceFactor != null)
                    hashCode = hashCode * 59 + this.MetadataFaultToleranceFactor.GetHashCode();
                if (this.MinimumFailureDomainsNeeded != null)
                    hashCode = hashCode * 59 + this.MinimumFailureDomainsNeeded.GetHashCode();
                if (this.MultiTenancyEnabled != null)
                    hashCode = hashCode * 59 + this.MultiTenancyEnabled.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NetbackupServicesConfig != null)
                    hashCode = hashCode * 59 + this.NetbackupServicesConfig.GetHashCode();
                if (this.NodeCount != null)
                    hashCode = hashCode * 59 + this.NodeCount.GetHashCode();
                if (this.NodeIps != null)
                    hashCode = hashCode * 59 + this.NodeIps.GetHashCode();
                if (this.NtpSettings != null)
                    hashCode = hashCode * 59 + this.NtpSettings.GetHashCode();
                if (this.PatchApplyFailureErrorMessage != null)
                    hashCode = hashCode * 59 + this.PatchApplyFailureErrorMessage.GetHashCode();
                if (this.PatchRevertFailureErrorMessage != null)
                    hashCode = hashCode * 59 + this.PatchRevertFailureErrorMessage.GetHashCode();
                if (this.PatchRevertVersion != null)
                    hashCode = hashCode * 59 + this.PatchRevertVersion.GetHashCode();
                if (this.PatchTargetVersion != null)
                    hashCode = hashCode * 59 + this.PatchTargetVersion.GetHashCode();
                if (this.PatchV2RevertsAllowed != null)
                    hashCode = hashCode * 59 + this.PatchV2RevertsAllowed.GetHashCode();
                if (this.PatchVersion != null)
                    hashCode = hashCode * 59 + this.PatchVersion.GetHashCode();
                if (this.PcieSsdTierRebalanceDelaySecs != null)
                    hashCode = hashCode * 59 + this.PcieSsdTierRebalanceDelaySecs.GetHashCode();
                if (this.ProtoRpcEncryptionEnabled != null)
                    hashCode = hashCode * 59 + this.ProtoRpcEncryptionEnabled.GetHashCode();
                if (this.ProxyVMSubnet != null)
                    hashCode = hashCode * 59 + this.ProxyVMSubnet.GetHashCode();
                if (this.ReverseTunnelEnableExtension != null)
                    hashCode = hashCode * 59 + this.ReverseTunnelEnableExtension.GetHashCode();
                if (this.ReverseTunnelEnabled != null)
                    hashCode = hashCode * 59 + this.ReverseTunnelEnabled.GetHashCode();
                if (this.ReverseTunnelEndTimeMsecs != null)
                    hashCode = hashCode * 59 + this.ReverseTunnelEndTimeMsecs.GetHashCode();
                if (this.ReverseTunnelExtensionDurationHours != null)
                    hashCode = hashCode * 59 + this.ReverseTunnelExtensionDurationHours.GetHashCode();
                if (this.S3VirtualHostedDomainNames != null)
                    hashCode = hashCode * 59 + this.S3VirtualHostedDomainNames.GetHashCode();
                if (this.SataHddTierAdmissionControl != null)
                    hashCode = hashCode * 59 + this.SataHddTierAdmissionControl.GetHashCode();
                if (this.SchemaInfoList != null)
                    hashCode = hashCode * 59 + this.SchemaInfoList.GetHashCode();
                if (this.SecurityModeDod != null)
                    hashCode = hashCode * 59 + this.SecurityModeDod.GetHashCode();
                if (this.SmbAdDisabled != null)
                    hashCode = hashCode * 59 + this.SmbAdDisabled.GetHashCode();
                if (this.SmbMultichannelEnabled != null)
                    hashCode = hashCode * 59 + this.SmbMultichannelEnabled.GetHashCode();
                hashCode = hashCode * 59 + this.SoftwareType.GetHashCode();
                if (this.SplitKeyHostAccess != null)
                    hashCode = hashCode * 59 + this.SplitKeyHostAccess.GetHashCode();
                if (this.Stats != null)
                    hashCode = hashCode * 59 + this.Stats.GetHashCode();
                if (this.StigMode != null)
                    hashCode = hashCode * 59 + this.StigMode.GetHashCode();
                if (this.SupportedConfig != null)
                    hashCode = hashCode * 59 + this.SupportedConfig.GetHashCode();
                if (this.SyslogServers != null)
                    hashCode = hashCode * 59 + this.SyslogServers.GetHashCode();
                if (this.TargetSoftwareVersion != null)
                    hashCode = hashCode * 59 + this.TargetSoftwareVersion.GetHashCode();
                if (this.TenantViewboxSharingEnabled != null)
                    hashCode = hashCode * 59 + this.TenantViewboxSharingEnabled.GetHashCode();
                if (this.TieringAuditLogConfig != null)
                    hashCode = hashCode * 59 + this.TieringAuditLogConfig.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.TlsEnabled != null)
                    hashCode = hashCode * 59 + this.TlsEnabled.GetHashCode();
                if (this.TrustDomain != null)
                    hashCode = hashCode * 59 + this.TrustDomain.GetHashCode();
                if (this.TurboMode != null)
                    hashCode = hashCode * 59 + this.TurboMode.GetHashCode();
                if (this.UpgradeFailureErrorString != null)
                    hashCode = hashCode * 59 + this.UpgradeFailureErrorString.GetHashCode();
                if (this.UseDefaultAgentPorts != null)
                    hashCode = hashCode * 59 + this.UseDefaultAgentPorts.GetHashCode();
                if (this.UseHeimdall != null)
                    hashCode = hashCode * 59 + this.UseHeimdall.GetHashCode();
                if (this.UsedMetadataSpacePct != null)
                    hashCode = hashCode * 59 + this.UsedMetadataSpacePct.GetHashCode();
                if (this.VirtualDataplaneIdentifier != null)
                    hashCode = hashCode * 59 + this.VirtualDataplaneIdentifier.GetHashCode();
                return hashCode;
            }
        }

    }

}


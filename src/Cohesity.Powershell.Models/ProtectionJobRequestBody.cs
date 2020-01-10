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
    /// Specifies information about a Protection Job.
    /// </summary>
    [DataContract]
    public partial class ProtectionJobRequestBody :  IEquatable<ProtectionJobRequestBody>
    {
        /// <summary>
        /// Defines AlertingPolicy
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AlertingPolicyEnum
        {
            /// <summary>
            /// Enum KSuccess for value: kSuccess
            /// </summary>
            [EnumMember(Value = "kSuccess")]
            KSuccess = 1,

            /// <summary>
            /// Enum KFailure for value: kFailure
            /// </summary>
            [EnumMember(Value = "kFailure")]
            KFailure = 2,

            /// <summary>
            /// Enum KSlaViolation for value: kSlaViolation
            /// </summary>
            [EnumMember(Value = "kSlaViolation")]
            KSlaViolation = 3

        }


        /// <summary>
        /// Array of Job Events.  During Job Runs, the following Job Events are generated: 1) Job succeeds 2) Job fails 3) Job violates the SLA These Job Events can cause Alerts to be generated. &#39;kSuccess&#39; means the Protection Job succeeded. &#39;kFailure&#39; means the Protection Job failed. &#39;kSlaViolation&#39; means the Protection Job took longer than the time period specified in the SLA.
        /// </summary>
        /// <value>Array of Job Events.  During Job Runs, the following Job Events are generated: 1) Job succeeds 2) Job fails 3) Job violates the SLA These Job Events can cause Alerts to be generated. &#39;kSuccess&#39; means the Protection Job succeeded. &#39;kFailure&#39; means the Protection Job failed. &#39;kSlaViolation&#39; means the Protection Job took longer than the time period specified in the SLA.</value>
        [DataMember(Name="alertingPolicy", EmitDefaultValue=true)]
        public List<AlertingPolicyEnum> AlertingPolicy { get; set; }
        /// <summary>
        /// Specifies the environment type (such as kVMware or kSQL) of the Protection Source this Job is protecting. Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;Nimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Genreric Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhsicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kVCD&#39; indicates the VMware&#39;s Virtual cloud Director Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment.
        /// </summary>
        /// <value>Specifies the environment type (such as kVMware or kSQL) of the Protection Source this Job is protecting. Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;Nimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Genreric Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhsicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kVCD&#39; indicates the VMware&#39;s Virtual cloud Director Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EnvironmentEnum
        {
            /// <summary>
            /// Enum KVMware for value: kVMware
            /// </summary>
            [EnumMember(Value = "kVMware")]
            KVMware = 1,

            /// <summary>
            /// Enum KHyperV for value: kHyperV
            /// </summary>
            [EnumMember(Value = "kHyperV")]
            KHyperV = 2,

            /// <summary>
            /// Enum KSQL for value: kSQL
            /// </summary>
            [EnumMember(Value = "kSQL")]
            KSQL = 3,

            /// <summary>
            /// Enum KView for value: kView
            /// </summary>
            [EnumMember(Value = "kView")]
            KView = 4,

            /// <summary>
            /// Enum KPuppeteer for value: kPuppeteer
            /// </summary>
            [EnumMember(Value = "kPuppeteer")]
            KPuppeteer = 5,

            /// <summary>
            /// Enum KPhysical for value: kPhysical
            /// </summary>
            [EnumMember(Value = "kPhysical")]
            KPhysical = 6,

            /// <summary>
            /// Enum KPure for value: kPure
            /// </summary>
            [EnumMember(Value = "kPure")]
            KPure = 7,

            /// <summary>
            /// Enum KNimble for value: kNimble
            /// </summary>
            [EnumMember(Value = "kNimble")]
            KNimble = 8,

            /// <summary>
            /// Enum KAzure for value: kAzure
            /// </summary>
            [EnumMember(Value = "kAzure")]
            KAzure = 9,

            /// <summary>
            /// Enum KNetapp for value: kNetapp
            /// </summary>
            [EnumMember(Value = "kNetapp")]
            KNetapp = 10,

            /// <summary>
            /// Enum KAgent for value: kAgent
            /// </summary>
            [EnumMember(Value = "kAgent")]
            KAgent = 11,

            /// <summary>
            /// Enum KGenericNas for value: kGenericNas
            /// </summary>
            [EnumMember(Value = "kGenericNas")]
            KGenericNas = 12,

            /// <summary>
            /// Enum KAcropolis for value: kAcropolis
            /// </summary>
            [EnumMember(Value = "kAcropolis")]
            KAcropolis = 13,

            /// <summary>
            /// Enum KPhysicalFiles for value: kPhysicalFiles
            /// </summary>
            [EnumMember(Value = "kPhysicalFiles")]
            KPhysicalFiles = 14,

            /// <summary>
            /// Enum KIsilon for value: kIsilon
            /// </summary>
            [EnumMember(Value = "kIsilon")]
            KIsilon = 15,

            /// <summary>
            /// Enum KGPFS for value: kGPFS
            /// </summary>
            [EnumMember(Value = "kGPFS")]
            KGPFS = 16,

            /// <summary>
            /// Enum KKVM for value: kKVM
            /// </summary>
            [EnumMember(Value = "kKVM")]
            KKVM = 17,

            /// <summary>
            /// Enum KAWS for value: kAWS
            /// </summary>
            [EnumMember(Value = "kAWS")]
            KAWS = 18,

            /// <summary>
            /// Enum KExchange for value: kExchange
            /// </summary>
            [EnumMember(Value = "kExchange")]
            KExchange = 19,

            /// <summary>
            /// Enum KHyperVVSS for value: kHyperVVSS
            /// </summary>
            [EnumMember(Value = "kHyperVVSS")]
            KHyperVVSS = 20,

            /// <summary>
            /// Enum KOracle for value: kOracle
            /// </summary>
            [EnumMember(Value = "kOracle")]
            KOracle = 21,

            /// <summary>
            /// Enum KGCP for value: kGCP
            /// </summary>
            [EnumMember(Value = "kGCP")]
            KGCP = 22,

            /// <summary>
            /// Enum KFlashBlade for value: kFlashBlade
            /// </summary>
            [EnumMember(Value = "kFlashBlade")]
            KFlashBlade = 23,

            /// <summary>
            /// Enum KAWSNative for value: kAWSNative
            /// </summary>
            [EnumMember(Value = "kAWSNative")]
            KAWSNative = 24,

            /// <summary>
            /// Enum KVCD for value: kVCD
            /// </summary>
            [EnumMember(Value = "kVCD")]
            KVCD = 25,

            /// <summary>
            /// Enum KO365 for value: kO365
            /// </summary>
            [EnumMember(Value = "kO365")]
            KO365 = 26,

            /// <summary>
            /// Enum KO365Outlook for value: kO365Outlook
            /// </summary>
            [EnumMember(Value = "kO365Outlook")]
            KO365Outlook = 27,

            /// <summary>
            /// Enum KHyperFlex for value: kHyperFlex
            /// </summary>
            [EnumMember(Value = "kHyperFlex")]
            KHyperFlex = 28,

            /// <summary>
            /// Enum KGCPNative for value: kGCPNative
            /// </summary>
            [EnumMember(Value = "kGCPNative")]
            KGCPNative = 29,

            /// <summary>
            /// Enum KAzureNative for value: kAzureNative
            /// </summary>
            [EnumMember(Value = "kAzureNative")]
            KAzureNative = 30,

            /// <summary>
            /// Enum KKubernetes for value: kKubernetes
            /// </summary>
            [EnumMember(Value = "kKubernetes")]
            KKubernetes = 31,

            /// <summary>
            /// Enum KElastifile for value: kElastifile
            /// </summary>
            [EnumMember(Value = "kElastifile")]
            KElastifile = 32,

            /// <summary>
            /// Enum KAD for value: kAD
            /// </summary>
            [EnumMember(Value = "kAD")]
            KAD = 33

        }

        /// <summary>
        /// Specifies the environment type (such as kVMware or kSQL) of the Protection Source this Job is protecting. Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;Nimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Genreric Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhsicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kVCD&#39; indicates the VMware&#39;s Virtual cloud Director Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment.
        /// </summary>
        /// <value>Specifies the environment type (such as kVMware or kSQL) of the Protection Source this Job is protecting. Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;Nimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Genreric Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhsicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kVCD&#39; indicates the VMware&#39;s Virtual cloud Director Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment.</value>
        [DataMember(Name="environment", EmitDefaultValue=true)]
        public EnvironmentEnum? Environment { get; set; }
        /// <summary>
        /// Specifies the priority of execution for a Protection Job. Cohesity supports concurrent backups but if the number of Jobs exceeds the ability to process Jobs, the specified priority determines the execution Job priority. This field also specifies the replication priority. &#39;kLow&#39; indicates lowest execution priority for a Protection job. &#39;kMedium&#39; indicates medium execution priority for a Protection job. &#39;kHigh&#39; indicates highest execution priority for a Protection job.
        /// </summary>
        /// <value>Specifies the priority of execution for a Protection Job. Cohesity supports concurrent backups but if the number of Jobs exceeds the ability to process Jobs, the specified priority determines the execution Job priority. This field also specifies the replication priority. &#39;kLow&#39; indicates lowest execution priority for a Protection job. &#39;kMedium&#39; indicates medium execution priority for a Protection job. &#39;kHigh&#39; indicates highest execution priority for a Protection job.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PriorityEnum
        {
            /// <summary>
            /// Enum KLow for value: kLow
            /// </summary>
            [EnumMember(Value = "kLow")]
            KLow = 1,

            /// <summary>
            /// Enum KMedium for value: kMedium
            /// </summary>
            [EnumMember(Value = "kMedium")]
            KMedium = 2,

            /// <summary>
            /// Enum KHigh for value: kHigh
            /// </summary>
            [EnumMember(Value = "kHigh")]
            KHigh = 3

        }

        /// <summary>
        /// Specifies the priority of execution for a Protection Job. Cohesity supports concurrent backups but if the number of Jobs exceeds the ability to process Jobs, the specified priority determines the execution Job priority. This field also specifies the replication priority. &#39;kLow&#39; indicates lowest execution priority for a Protection job. &#39;kMedium&#39; indicates medium execution priority for a Protection job. &#39;kHigh&#39; indicates highest execution priority for a Protection job.
        /// </summary>
        /// <value>Specifies the priority of execution for a Protection Job. Cohesity supports concurrent backups but if the number of Jobs exceeds the ability to process Jobs, the specified priority determines the execution Job priority. This field also specifies the replication priority. &#39;kLow&#39; indicates lowest execution priority for a Protection job. &#39;kMedium&#39; indicates medium execution priority for a Protection job. &#39;kHigh&#39; indicates highest execution priority for a Protection job.</value>
        [DataMember(Name="priority", EmitDefaultValue=true)]
        public PriorityEnum? Priority { get; set; }
        /// <summary>
        /// Specifies the QoS policy type to use for this Protection Job. &#39;kBackupHDD&#39; indicates the Cohesity Cluster writes data directly to the HDD tier for this Protection Job. This is the recommended setting. &#39;kBackupSSD&#39; indicates the Cohesity Cluster writes data directly to the SSD tier for this Protection Job. Only specify this policy if you need fast ingest speed for a small number of Protection Jobs.
        /// </summary>
        /// <value>Specifies the QoS policy type to use for this Protection Job. &#39;kBackupHDD&#39; indicates the Cohesity Cluster writes data directly to the HDD tier for this Protection Job. This is the recommended setting. &#39;kBackupSSD&#39; indicates the Cohesity Cluster writes data directly to the SSD tier for this Protection Job. Only specify this policy if you need fast ingest speed for a small number of Protection Jobs.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum QosTypeEnum
        {
            /// <summary>
            /// Enum KBackupHDD for value: kBackupHDD
            /// </summary>
            [EnumMember(Value = "kBackupHDD")]
            KBackupHDD = 1,

            /// <summary>
            /// Enum KBackupSSD for value: kBackupSSD
            /// </summary>
            [EnumMember(Value = "kBackupSSD")]
            KBackupSSD = 2

        }

        /// <summary>
        /// Specifies the QoS policy type to use for this Protection Job. &#39;kBackupHDD&#39; indicates the Cohesity Cluster writes data directly to the HDD tier for this Protection Job. This is the recommended setting. &#39;kBackupSSD&#39; indicates the Cohesity Cluster writes data directly to the SSD tier for this Protection Job. Only specify this policy if you need fast ingest speed for a small number of Protection Jobs.
        /// </summary>
        /// <value>Specifies the QoS policy type to use for this Protection Job. &#39;kBackupHDD&#39; indicates the Cohesity Cluster writes data directly to the HDD tier for this Protection Job. This is the recommended setting. &#39;kBackupSSD&#39; indicates the Cohesity Cluster writes data directly to the SSD tier for this Protection Job. Only specify this policy if you need fast ingest speed for a small number of Protection Jobs.</value>
        [DataMember(Name="qosType", EmitDefaultValue=true)]
        public QosTypeEnum? QosType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionJobRequestBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProtectionJobRequestBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionJobRequestBody" /> class.
        /// </summary>
        /// <param name="abortInBlackoutPeriod">If true, the Cohesity Cluster aborts any currently executing Job Runs of this Protection Job when a blackout period specified for this Job starts, even if the Job Run started before the blackout period began. If false, a Job Run continues to execute, if the Job Run started before the blackout period starts..</param>
        /// <param name="alertingConfig">alertingConfig.</param>
        /// <param name="alertingPolicy">Array of Job Events.  During Job Runs, the following Job Events are generated: 1) Job succeeds 2) Job fails 3) Job violates the SLA These Job Events can cause Alerts to be generated. &#39;kSuccess&#39; means the Protection Job succeeded. &#39;kFailure&#39; means the Protection Job failed. &#39;kSlaViolation&#39; means the Protection Job took longer than the time period specified in the SLA..</param>
        /// <param name="cloudParameters">cloudParameters.</param>
        /// <param name="continueOnQuiesceFailure">Whether to continue backing up on quiesce failure..</param>
        /// <param name="createRemoteView">Specifies whether to create a remote view name to use for view overwrite..</param>
        /// <param name="dataMigrationPolicy">dataMigrationPolicy.</param>
        /// <param name="dedupDisabledSourceIds">List of source ids for which source side dedup is disabled from the backup job..</param>
        /// <param name="description">Specifies a text description about the Protection Job..</param>
        /// <param name="endTimeUsecs">Specifies the epoch time (in microseconds) after which the Protection Job becomes dormant..</param>
        /// <param name="environment">Specifies the environment type (such as kVMware or kSQL) of the Protection Source this Job is protecting. Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;Nimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Genreric Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhsicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kVCD&#39; indicates the VMware&#39;s Virtual cloud Director Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment..</param>
        /// <param name="environmentParameters">environmentParameters.</param>
        /// <param name="excludeSourceIds">Array of Excluded Source Objects.  List of Object ids from a Protection Source that should not be protected and are excluded from being backed up by the Protection Job. Leaf and non-leaf Objects may be in this list and an Object in this list must have an ancestor in the sourceId list..</param>
        /// <param name="excludeVmTagIds">Array of Arrays of VM Tag Ids that Specify VMs to Exclude.  Optionally specify a list of VMs to exclude from protecting by listing Protection Source ids of VM Tags in this two dimensional array. Using this two dimensional array of Tag ids, the Cluster generates a list of VMs to exclude from protecting, which are derived from intersections of the inner arrays and union of the outer array, as shown by the following example. For example a Datacenter is selected to be protected but you want to exclude all the &#39;Former Employees&#39; VMs in the East and West but keep all the VMs for &#39;Former Employees&#39; in the South which are also stored in this Datacenter, by specifying the following tag id array: [ [1000, 2221], [1000, 3031] ], where 1000 is the &#39;Former Employee&#39; VM Tag id, 2221 is the &#39;East&#39; VM Tag id and 3031 is the &#39;West&#39; VM Tag id. The first inner array [1000, 2221] produces a list of VMs that are both tagged with &#39;Former Employees&#39; and &#39;East&#39; (an intersection). The second inner array [1000, 3031] produces a list of VMs that are both tagged with &#39;Former Employees&#39; and &#39;West&#39; (an intersection). The outer array combines the list of VMs from the two inner arrays. The list of resulting VMs are excluded from being protected this Job..</param>
        /// <param name="fullProtectionSlaTimeMins">If specified, this setting is number of minutes that a Job Run of a Full (no CBT) backup schedule is expected to complete, which is known as a Service-Level Agreement (SLA). A SLA violation is reported when the run time of a Job Run exceeds the SLA time period specified for this backup schedule..</param>
        /// <param name="fullProtectionStartTime">Specifies the time of day to start the Full Protection Schedule. This is optional and only applicable if the Protection Policy defines a monthly or a daily Full (no CBT) Protection Schedule. Default value is 02:00 AM. deprecated: true.</param>
        /// <param name="incrementalProtectionSlaTimeMins">If specified, this setting is number of minutes that a Job Run of a CBT-based backup schedule is expected to complete, which is known as a Service-Level Agreement (SLA). A SLA violation is reported when the run time of a Job Run exceeds the SLA time period specified for this backup schedule..</param>
        /// <param name="incrementalProtectionStartTime">Specifies the time of day to start the CBT-based Protection Schedule. This is optional and only applicable if the Protection Policy defines a monthly or a daily CBT-based Protection Schedule. Default value is 02:00 AM. deprecated: true.</param>
        /// <param name="indexingPolicy">indexingPolicy.</param>
        /// <param name="isDirectArchiveEnabled">Specifies if this is a direct archive backup job..</param>
        /// <param name="isNativeFormat">Specifies if native format should be used for archiving, applicable for only direct archive jobs..</param>
        /// <param name="leverageStorageSnapshots">Specifies whether to leverage the storage array based snapshots for this backup job. To leverage storage snapshots, the storage array has to be registered as a source. If storage based snapshots can not be taken, job will fallback to the default backup method..</param>
        /// <param name="leverageStorageSnapshotsForHyperflex">Specifies whether to leverage Hyperflex as the storage snapshot array.</param>
        /// <param name="name">Specifies the name of the Protection Job. (required).</param>
        /// <param name="parentSourceId">Specifies the id of the registered Protection Source that is the parent of the Objects that may be protected by this Job. For example when a vCenter Server is registered on a Cohesity Cluster, the Cohesity Cluster assigns a unique id to this field that represents the vCenter Server..</param>
        /// <param name="performSourceSideDedup">Specifies whether source side dedupe should be performed or not..</param>
        /// <param name="policyId">Specifies the unique id of the Protection Policy associated with the Protection Job. The Policy provides retry settings, Protection Schedules, Priority, SLA, etc. The Job defines the Storage Domain (View Box), the Objects to Protect (if applicable), Start Time, Indexing settings, etc. (required).</param>
        /// <param name="postBackupScript">Specifies the script associated with the backup job. This field must be specified for &#39;kPhysical&#39; jobs. This script will be executed post backup run..</param>
        /// <param name="preBackupScript">Specifies the script associated with the backup job. This field must be specified for &#39;kPhysical&#39; jobs. This script will be executed pre backup run. The &#39;remoteScript&#39; field will be used for remote adapter jobs and &#39;preBackupScript&#39; field will be used for &#39;kPhysical&#39; jobs..</param>
        /// <param name="priority">Specifies the priority of execution for a Protection Job. Cohesity supports concurrent backups but if the number of Jobs exceeds the ability to process Jobs, the specified priority determines the execution Job priority. This field also specifies the replication priority. &#39;kLow&#39; indicates lowest execution priority for a Protection job. &#39;kMedium&#39; indicates medium execution priority for a Protection job. &#39;kHigh&#39; indicates highest execution priority for a Protection job..</param>
        /// <param name="qosType">Specifies the QoS policy type to use for this Protection Job. &#39;kBackupHDD&#39; indicates the Cohesity Cluster writes data directly to the HDD tier for this Protection Job. This is the recommended setting. &#39;kBackupSSD&#39; indicates the Cohesity Cluster writes data directly to the SSD tier for this Protection Job. Only specify this policy if you need fast ingest speed for a small number of Protection Jobs..</param>
        /// <param name="quiesce">Indicates if the App-Consistent option is enabled for this Job. If the option is enabled, the Cohesity Cluster quiesces the file system and applications before taking Application-Consistent Snapshots. VMware Tools must be installed on the guest Operating System..</param>
        /// <param name="remoteScript">For a Remote Adapter &#39;kPuppeteer&#39; Job, this field specifies the settings about the remote script that will be executed by this Job. Only specify this field for Remote Adapter &#39;kPuppeteer&#39; Jobs..</param>
        /// <param name="remoteViewName">Specifies the remote view name to use for view overwrite..</param>
        /// <param name="sourceIds">Array of Protected Source Objects.  Specifies the list of Object ids from the Protection Source to protect (or back up) by the Protection Job. An Object in this list may be descendant of another Object in this list. For example a Datacenter could be selected but its child Host excluded. However, a child VM under the Host could be explicitly selected to be protected. Both the Datacenter and the VM are listed..</param>
        /// <param name="sourceSpecialParameters">Array of Special Source Parameters.  Specifies additional settings that can apply to a subset of the Sources listed in the Protection Job. For example, you can specify a list of files and folders to protect instead of protecting the entire Physical Server. If this field&#39;s setting conflicts with environmentParameters, then this setting will be used..</param>
        /// <param name="startTime">Specifies the time of day to start the Protection Schedule. This is optional and only applicable if the Protection Policy defines a monthly or a daily Protection Schedule. Default value is 02:00 AM..</param>
        /// <param name="timezone">Specifies the timezone to use when calculating time for this Protection Job such as the Job start time. Specify the timezone in the following format: \&quot;Area/Location\&quot;, for example: \&quot;America/New_York\&quot;..</param>
        /// <param name="userSpecifiedTags">Tags associated with the job. User can specify tags/keywords that can indexed by Yoda and can be later searched in UI. For example, user can create a &#39;kPuppeteer&#39; job to backup Oracle DB for &#39;payroll&#39; department. User can specify following tags: &#39;payroll&#39;, &#39;Oracle_DB&#39;..</param>
        /// <param name="viewBoxId">Specifies the Storage Domain (View Box) id where this Job writes data. (required).</param>
        /// <param name="viewName">For a Remote Adapter &#39;kPuppeteer&#39; Job or a &#39;kView&#39; Job, this field specifies a View name that should be protected. Specify this field when creating a Protection Job for the first time for a View. If this field is specified, ParentSourceId, SourceIds, and ExcludeSourceIds should not be specified..</param>
        /// <param name="vmTagIds">Array of Arrays of VMs Tags Ids that Specify VMs to Protect.  Optionally specify a list of VMs to protect by listing Protection Source ids of VM Tags in this two dimensional array. Using this two dimensional array of Tag ids, the Cluster generates a list of VMs to protect which are derived from intersections of the inner arrays and union of the outer array, as shown by the following example. To protect only &#39;Eng&#39; VMs in the East and all the VMs in the West, specify the following tag id array: [ [1101, 2221], [3031] ], where 1101 is the &#39;Eng&#39; VM Tag id, 2221 is the &#39;East&#39; VM Tag id and 3031 is the &#39;West&#39; VM Tag id. The inner array [1101, 2221] produces a list of VMs that are both tagged with &#39;Eng&#39; and &#39;East&#39; (an intersection). The outer array combines the list from the inner array with list of VMs tagged with &#39;West&#39; (a union). The list of resulting VMs are protected by this Job..</param>
        public ProtectionJobRequestBody(bool? abortInBlackoutPeriod = default(bool?), AlertingConfig alertingConfig = default(AlertingConfig), List<AlertingPolicyEnum> alertingPolicy = default(List<AlertingPolicyEnum>), CloudParameters cloudParameters = default(CloudParameters), bool? continueOnQuiesceFailure = default(bool?), bool? createRemoteView = default(bool?), DataMigrationPolicy dataMigrationPolicy = default(DataMigrationPolicy), List<long> dedupDisabledSourceIds = default(List<long>), string description = default(string), long? endTimeUsecs = default(long?), EnvironmentEnum? environment = default(EnvironmentEnum?), EnvironmentTypeJobParameters environmentParameters = default(EnvironmentTypeJobParameters), List<long> excludeSourceIds = default(List<long>), List<List<long>> excludeVmTagIds = default(List<List<long>>), long? fullProtectionSlaTimeMins = default(long?), TimeOfDay fullProtectionStartTime = default(TimeOfDay), long? incrementalProtectionSlaTimeMins = default(long?), TimeOfDay incrementalProtectionStartTime = default(TimeOfDay), IndexingPolicy indexingPolicy = default(IndexingPolicy), bool? isDirectArchiveEnabled = default(bool?), bool? isNativeFormat = default(bool?), bool? leverageStorageSnapshots = default(bool?), bool? leverageStorageSnapshotsForHyperflex = default(bool?), string name = default(string), long? parentSourceId = default(long?), bool? performSourceSideDedup = default(bool?), string policyId = default(string), BackupScript postBackupScript = default(BackupScript), BackupScript preBackupScript = default(BackupScript), PriorityEnum? priority = default(PriorityEnum?), QosTypeEnum? qosType = default(QosTypeEnum?), bool? quiesce = default(bool?), RemoteJobScript remoteScript = default(RemoteJobScript), string remoteViewName = default(string), List<long> sourceIds = default(List<long>), List<SourceSpecialParameter> sourceSpecialParameters = default(List<SourceSpecialParameter>), TimeOfDay startTime = default(TimeOfDay), string timezone = default(string), List<string> userSpecifiedTags = default(List<string>), long? viewBoxId = default(long?), string viewName = default(string), List<List<long>> vmTagIds = default(List<List<long>>))
        {
            this.AbortInBlackoutPeriod = abortInBlackoutPeriod;
            this.AlertingPolicy = alertingPolicy;
            this.ContinueOnQuiesceFailure = continueOnQuiesceFailure;
            this.CreateRemoteView = createRemoteView;
            this.DedupDisabledSourceIds = dedupDisabledSourceIds;
            this.Description = description;
            this.EndTimeUsecs = endTimeUsecs;
            this.Environment = environment;
            this.ExcludeSourceIds = excludeSourceIds;
            this.ExcludeVmTagIds = excludeVmTagIds;
            this.FullProtectionSlaTimeMins = fullProtectionSlaTimeMins;
            this.FullProtectionStartTime = fullProtectionStartTime;
            this.IncrementalProtectionSlaTimeMins = incrementalProtectionSlaTimeMins;
            this.IncrementalProtectionStartTime = incrementalProtectionStartTime;
            this.IsDirectArchiveEnabled = isDirectArchiveEnabled;
            this.IsNativeFormat = isNativeFormat;
            this.LeverageStorageSnapshots = leverageStorageSnapshots;
            this.LeverageStorageSnapshotsForHyperflex = leverageStorageSnapshotsForHyperflex;
            this.Name = name;
            this.ParentSourceId = parentSourceId;
            this.PerformSourceSideDedup = performSourceSideDedup;
            this.PolicyId = policyId;
            this.PostBackupScript = postBackupScript;
            this.PreBackupScript = preBackupScript;
            this.Priority = priority;
            this.QosType = qosType;
            this.Quiesce = quiesce;
            this.RemoteScript = remoteScript;
            this.RemoteViewName = remoteViewName;
            this.SourceIds = sourceIds;
            this.SourceSpecialParameters = sourceSpecialParameters;
            this.StartTime = startTime;
            this.Timezone = timezone;
            this.UserSpecifiedTags = userSpecifiedTags;
            this.ViewBoxId = viewBoxId;
            this.ViewName = viewName;
            this.VmTagIds = vmTagIds;
            this.AbortInBlackoutPeriod = abortInBlackoutPeriod;
            this.AlertingConfig = alertingConfig;
            this.AlertingPolicy = alertingPolicy;
            this.CloudParameters = cloudParameters;
            this.ContinueOnQuiesceFailure = continueOnQuiesceFailure;
            this.CreateRemoteView = createRemoteView;
            this.DataMigrationPolicy = dataMigrationPolicy;
            this.DedupDisabledSourceIds = dedupDisabledSourceIds;
            this.Description = description;
            this.EndTimeUsecs = endTimeUsecs;
            this.Environment = environment;
            this.EnvironmentParameters = environmentParameters;
            this.ExcludeSourceIds = excludeSourceIds;
            this.ExcludeVmTagIds = excludeVmTagIds;
            this.FullProtectionSlaTimeMins = fullProtectionSlaTimeMins;
            this.FullProtectionStartTime = fullProtectionStartTime;
            this.IncrementalProtectionSlaTimeMins = incrementalProtectionSlaTimeMins;
            this.IncrementalProtectionStartTime = incrementalProtectionStartTime;
            this.IndexingPolicy = indexingPolicy;
            this.IsDirectArchiveEnabled = isDirectArchiveEnabled;
            this.IsNativeFormat = isNativeFormat;
            this.LeverageStorageSnapshots = leverageStorageSnapshots;
            this.LeverageStorageSnapshotsForHyperflex = leverageStorageSnapshotsForHyperflex;
            this.ParentSourceId = parentSourceId;
            this.PerformSourceSideDedup = performSourceSideDedup;
            this.PostBackupScript = postBackupScript;
            this.PreBackupScript = preBackupScript;
            this.Priority = priority;
            this.QosType = qosType;
            this.Quiesce = quiesce;
            this.RemoteScript = remoteScript;
            this.RemoteViewName = remoteViewName;
            this.SourceIds = sourceIds;
            this.SourceSpecialParameters = sourceSpecialParameters;
            this.StartTime = startTime;
            this.Timezone = timezone;
            this.UserSpecifiedTags = userSpecifiedTags;
            this.ViewName = viewName;
            this.VmTagIds = vmTagIds;
        }
        
        /// <summary>
        /// If true, the Cohesity Cluster aborts any currently executing Job Runs of this Protection Job when a blackout period specified for this Job starts, even if the Job Run started before the blackout period began. If false, a Job Run continues to execute, if the Job Run started before the blackout period starts.
        /// </summary>
        /// <value>If true, the Cohesity Cluster aborts any currently executing Job Runs of this Protection Job when a blackout period specified for this Job starts, even if the Job Run started before the blackout period began. If false, a Job Run continues to execute, if the Job Run started before the blackout period starts.</value>
        [DataMember(Name="abortInBlackoutPeriod", EmitDefaultValue=true)]
        public bool? AbortInBlackoutPeriod { get; set; }

        /// <summary>
        /// Gets or Sets AlertingConfig
        /// </summary>
        [DataMember(Name="alertingConfig", EmitDefaultValue=false)]
        public AlertingConfig AlertingConfig { get; set; }

        /// <summary>
        /// Gets or Sets CloudParameters
        /// </summary>
        [DataMember(Name="cloudParameters", EmitDefaultValue=false)]
        public CloudParameters CloudParameters { get; set; }

        /// <summary>
        /// Whether to continue backing up on quiesce failure.
        /// </summary>
        /// <value>Whether to continue backing up on quiesce failure.</value>
        [DataMember(Name="continueOnQuiesceFailure", EmitDefaultValue=true)]
        public bool? ContinueOnQuiesceFailure { get; set; }

        /// <summary>
        /// Specifies whether to create a remote view name to use for view overwrite.
        /// </summary>
        /// <value>Specifies whether to create a remote view name to use for view overwrite.</value>
        [DataMember(Name="createRemoteView", EmitDefaultValue=true)]
        public bool? CreateRemoteView { get; set; }

        /// <summary>
        /// Gets or Sets DataMigrationPolicy
        /// </summary>
        [DataMember(Name="dataMigrationPolicy", EmitDefaultValue=false)]
        public DataMigrationPolicy DataMigrationPolicy { get; set; }

        /// <summary>
        /// List of source ids for which source side dedup is disabled from the backup job.
        /// </summary>
        /// <value>List of source ids for which source side dedup is disabled from the backup job.</value>
        [DataMember(Name="dedupDisabledSourceIds", EmitDefaultValue=true)]
        public List<long> DedupDisabledSourceIds { get; set; }

        /// <summary>
        /// Specifies a text description about the Protection Job.
        /// </summary>
        /// <value>Specifies a text description about the Protection Job.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies the epoch time (in microseconds) after which the Protection Job becomes dormant.
        /// </summary>
        /// <value>Specifies the epoch time (in microseconds) after which the Protection Job becomes dormant.</value>
        [DataMember(Name="endTimeUsecs", EmitDefaultValue=true)]
        public long? EndTimeUsecs { get; set; }

        /// <summary>
        /// Gets or Sets EnvironmentParameters
        /// </summary>
        [DataMember(Name="environmentParameters", EmitDefaultValue=false)]
        public EnvironmentTypeJobParameters EnvironmentParameters { get; set; }

        /// <summary>
        /// Array of Excluded Source Objects.  List of Object ids from a Protection Source that should not be protected and are excluded from being backed up by the Protection Job. Leaf and non-leaf Objects may be in this list and an Object in this list must have an ancestor in the sourceId list.
        /// </summary>
        /// <value>Array of Excluded Source Objects.  List of Object ids from a Protection Source that should not be protected and are excluded from being backed up by the Protection Job. Leaf and non-leaf Objects may be in this list and an Object in this list must have an ancestor in the sourceId list.</value>
        [DataMember(Name="excludeSourceIds", EmitDefaultValue=true)]
        public List<long> ExcludeSourceIds { get; set; }

        /// <summary>
        /// Array of Arrays of VM Tag Ids that Specify VMs to Exclude.  Optionally specify a list of VMs to exclude from protecting by listing Protection Source ids of VM Tags in this two dimensional array. Using this two dimensional array of Tag ids, the Cluster generates a list of VMs to exclude from protecting, which are derived from intersections of the inner arrays and union of the outer array, as shown by the following example. For example a Datacenter is selected to be protected but you want to exclude all the &#39;Former Employees&#39; VMs in the East and West but keep all the VMs for &#39;Former Employees&#39; in the South which are also stored in this Datacenter, by specifying the following tag id array: [ [1000, 2221], [1000, 3031] ], where 1000 is the &#39;Former Employee&#39; VM Tag id, 2221 is the &#39;East&#39; VM Tag id and 3031 is the &#39;West&#39; VM Tag id. The first inner array [1000, 2221] produces a list of VMs that are both tagged with &#39;Former Employees&#39; and &#39;East&#39; (an intersection). The second inner array [1000, 3031] produces a list of VMs that are both tagged with &#39;Former Employees&#39; and &#39;West&#39; (an intersection). The outer array combines the list of VMs from the two inner arrays. The list of resulting VMs are excluded from being protected this Job.
        /// </summary>
        /// <value>Array of Arrays of VM Tag Ids that Specify VMs to Exclude.  Optionally specify a list of VMs to exclude from protecting by listing Protection Source ids of VM Tags in this two dimensional array. Using this two dimensional array of Tag ids, the Cluster generates a list of VMs to exclude from protecting, which are derived from intersections of the inner arrays and union of the outer array, as shown by the following example. For example a Datacenter is selected to be protected but you want to exclude all the &#39;Former Employees&#39; VMs in the East and West but keep all the VMs for &#39;Former Employees&#39; in the South which are also stored in this Datacenter, by specifying the following tag id array: [ [1000, 2221], [1000, 3031] ], where 1000 is the &#39;Former Employee&#39; VM Tag id, 2221 is the &#39;East&#39; VM Tag id and 3031 is the &#39;West&#39; VM Tag id. The first inner array [1000, 2221] produces a list of VMs that are both tagged with &#39;Former Employees&#39; and &#39;East&#39; (an intersection). The second inner array [1000, 3031] produces a list of VMs that are both tagged with &#39;Former Employees&#39; and &#39;West&#39; (an intersection). The outer array combines the list of VMs from the two inner arrays. The list of resulting VMs are excluded from being protected this Job.</value>
        [DataMember(Name="excludeVmTagIds", EmitDefaultValue=true)]
        public List<List<long>> ExcludeVmTagIds { get; set; }

        /// <summary>
        /// If specified, this setting is number of minutes that a Job Run of a Full (no CBT) backup schedule is expected to complete, which is known as a Service-Level Agreement (SLA). A SLA violation is reported when the run time of a Job Run exceeds the SLA time period specified for this backup schedule.
        /// </summary>
        /// <value>If specified, this setting is number of minutes that a Job Run of a Full (no CBT) backup schedule is expected to complete, which is known as a Service-Level Agreement (SLA). A SLA violation is reported when the run time of a Job Run exceeds the SLA time period specified for this backup schedule.</value>
        [DataMember(Name="fullProtectionSlaTimeMins", EmitDefaultValue=true)]
        public long? FullProtectionSlaTimeMins { get; set; }

        /// <summary>
        /// Specifies the time of day to start the Full Protection Schedule. This is optional and only applicable if the Protection Policy defines a monthly or a daily Full (no CBT) Protection Schedule. Default value is 02:00 AM. deprecated: true
        /// </summary>
        /// <value>Specifies the time of day to start the Full Protection Schedule. This is optional and only applicable if the Protection Policy defines a monthly or a daily Full (no CBT) Protection Schedule. Default value is 02:00 AM. deprecated: true</value>
        [DataMember(Name="fullProtectionStartTime", EmitDefaultValue=true)]
        public TimeOfDay FullProtectionStartTime { get; set; }

        /// <summary>
        /// If specified, this setting is number of minutes that a Job Run of a CBT-based backup schedule is expected to complete, which is known as a Service-Level Agreement (SLA). A SLA violation is reported when the run time of a Job Run exceeds the SLA time period specified for this backup schedule.
        /// </summary>
        /// <value>If specified, this setting is number of minutes that a Job Run of a CBT-based backup schedule is expected to complete, which is known as a Service-Level Agreement (SLA). A SLA violation is reported when the run time of a Job Run exceeds the SLA time period specified for this backup schedule.</value>
        [DataMember(Name="incrementalProtectionSlaTimeMins", EmitDefaultValue=true)]
        public long? IncrementalProtectionSlaTimeMins { get; set; }

        /// <summary>
        /// Specifies the time of day to start the CBT-based Protection Schedule. This is optional and only applicable if the Protection Policy defines a monthly or a daily CBT-based Protection Schedule. Default value is 02:00 AM. deprecated: true
        /// </summary>
        /// <value>Specifies the time of day to start the CBT-based Protection Schedule. This is optional and only applicable if the Protection Policy defines a monthly or a daily CBT-based Protection Schedule. Default value is 02:00 AM. deprecated: true</value>
        [DataMember(Name="incrementalProtectionStartTime", EmitDefaultValue=true)]
        public TimeOfDay IncrementalProtectionStartTime { get; set; }

        /// <summary>
        /// Gets or Sets IndexingPolicy
        /// </summary>
        [DataMember(Name="indexingPolicy", EmitDefaultValue=false)]
        public IndexingPolicy IndexingPolicy { get; set; }

        /// <summary>
        /// Specifies if this is a direct archive backup job.
        /// </summary>
        /// <value>Specifies if this is a direct archive backup job.</value>
        [DataMember(Name="isDirectArchiveEnabled", EmitDefaultValue=true)]
        public bool? IsDirectArchiveEnabled { get; set; }

        /// <summary>
        /// Specifies if native format should be used for archiving, applicable for only direct archive jobs.
        /// </summary>
        /// <value>Specifies if native format should be used for archiving, applicable for only direct archive jobs.</value>
        [DataMember(Name="isNativeFormat", EmitDefaultValue=true)]
        public bool? IsNativeFormat { get; set; }

        /// <summary>
        /// Specifies whether to leverage the storage array based snapshots for this backup job. To leverage storage snapshots, the storage array has to be registered as a source. If storage based snapshots can not be taken, job will fallback to the default backup method.
        /// </summary>
        /// <value>Specifies whether to leverage the storage array based snapshots for this backup job. To leverage storage snapshots, the storage array has to be registered as a source. If storage based snapshots can not be taken, job will fallback to the default backup method.</value>
        [DataMember(Name="leverageStorageSnapshots", EmitDefaultValue=true)]
        public bool? LeverageStorageSnapshots { get; set; }

        /// <summary>
        /// Specifies whether to leverage Hyperflex as the storage snapshot array
        /// </summary>
        /// <value>Specifies whether to leverage Hyperflex as the storage snapshot array</value>
        [DataMember(Name="leverageStorageSnapshotsForHyperflex", EmitDefaultValue=true)]
        public bool? LeverageStorageSnapshotsForHyperflex { get; set; }

        /// <summary>
        /// Specifies the name of the Protection Job.
        /// </summary>
        /// <value>Specifies the name of the Protection Job.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the id of the registered Protection Source that is the parent of the Objects that may be protected by this Job. For example when a vCenter Server is registered on a Cohesity Cluster, the Cohesity Cluster assigns a unique id to this field that represents the vCenter Server.
        /// </summary>
        /// <value>Specifies the id of the registered Protection Source that is the parent of the Objects that may be protected by this Job. For example when a vCenter Server is registered on a Cohesity Cluster, the Cohesity Cluster assigns a unique id to this field that represents the vCenter Server.</value>
        [DataMember(Name="parentSourceId", EmitDefaultValue=true)]
        public long? ParentSourceId { get; set; }

        /// <summary>
        /// Specifies whether source side dedupe should be performed or not.
        /// </summary>
        /// <value>Specifies whether source side dedupe should be performed or not.</value>
        [DataMember(Name="performSourceSideDedup", EmitDefaultValue=true)]
        public bool? PerformSourceSideDedup { get; set; }

        /// <summary>
        /// Specifies the unique id of the Protection Policy associated with the Protection Job. The Policy provides retry settings, Protection Schedules, Priority, SLA, etc. The Job defines the Storage Domain (View Box), the Objects to Protect (if applicable), Start Time, Indexing settings, etc.
        /// </summary>
        /// <value>Specifies the unique id of the Protection Policy associated with the Protection Job. The Policy provides retry settings, Protection Schedules, Priority, SLA, etc. The Job defines the Storage Domain (View Box), the Objects to Protect (if applicable), Start Time, Indexing settings, etc.</value>
        [DataMember(Name="policyId", EmitDefaultValue=true)]
        public string PolicyId { get; set; }

        /// <summary>
        /// Specifies the script associated with the backup job. This field must be specified for &#39;kPhysical&#39; jobs. This script will be executed post backup run.
        /// </summary>
        /// <value>Specifies the script associated with the backup job. This field must be specified for &#39;kPhysical&#39; jobs. This script will be executed post backup run.</value>
        [DataMember(Name="postBackupScript", EmitDefaultValue=true)]
        public BackupScript PostBackupScript { get; set; }

        /// <summary>
        /// Specifies the script associated with the backup job. This field must be specified for &#39;kPhysical&#39; jobs. This script will be executed pre backup run. The &#39;remoteScript&#39; field will be used for remote adapter jobs and &#39;preBackupScript&#39; field will be used for &#39;kPhysical&#39; jobs.
        /// </summary>
        /// <value>Specifies the script associated with the backup job. This field must be specified for &#39;kPhysical&#39; jobs. This script will be executed pre backup run. The &#39;remoteScript&#39; field will be used for remote adapter jobs and &#39;preBackupScript&#39; field will be used for &#39;kPhysical&#39; jobs.</value>
        [DataMember(Name="preBackupScript", EmitDefaultValue=true)]
        public BackupScript PreBackupScript { get; set; }

        /// <summary>
        /// Indicates if the App-Consistent option is enabled for this Job. If the option is enabled, the Cohesity Cluster quiesces the file system and applications before taking Application-Consistent Snapshots. VMware Tools must be installed on the guest Operating System.
        /// </summary>
        /// <value>Indicates if the App-Consistent option is enabled for this Job. If the option is enabled, the Cohesity Cluster quiesces the file system and applications before taking Application-Consistent Snapshots. VMware Tools must be installed on the guest Operating System.</value>
        [DataMember(Name="quiesce", EmitDefaultValue=true)]
        public bool? Quiesce { get; set; }

        /// <summary>
        /// For a Remote Adapter &#39;kPuppeteer&#39; Job, this field specifies the settings about the remote script that will be executed by this Job. Only specify this field for Remote Adapter &#39;kPuppeteer&#39; Jobs.
        /// </summary>
        /// <value>For a Remote Adapter &#39;kPuppeteer&#39; Job, this field specifies the settings about the remote script that will be executed by this Job. Only specify this field for Remote Adapter &#39;kPuppeteer&#39; Jobs.</value>
        [DataMember(Name="remoteScript", EmitDefaultValue=true)]
        public RemoteJobScript RemoteScript { get; set; }

        /// <summary>
        /// Specifies the remote view name to use for view overwrite.
        /// </summary>
        /// <value>Specifies the remote view name to use for view overwrite.</value>
        [DataMember(Name="remoteViewName", EmitDefaultValue=true)]
        public string RemoteViewName { get; set; }

        /// <summary>
        /// Array of Protected Source Objects.  Specifies the list of Object ids from the Protection Source to protect (or back up) by the Protection Job. An Object in this list may be descendant of another Object in this list. For example a Datacenter could be selected but its child Host excluded. However, a child VM under the Host could be explicitly selected to be protected. Both the Datacenter and the VM are listed.
        /// </summary>
        /// <value>Array of Protected Source Objects.  Specifies the list of Object ids from the Protection Source to protect (or back up) by the Protection Job. An Object in this list may be descendant of another Object in this list. For example a Datacenter could be selected but its child Host excluded. However, a child VM under the Host could be explicitly selected to be protected. Both the Datacenter and the VM are listed.</value>
        [DataMember(Name="sourceIds", EmitDefaultValue=true)]
        public List<long> SourceIds { get; set; }

        /// <summary>
        /// Array of Special Source Parameters.  Specifies additional settings that can apply to a subset of the Sources listed in the Protection Job. For example, you can specify a list of files and folders to protect instead of protecting the entire Physical Server. If this field&#39;s setting conflicts with environmentParameters, then this setting will be used.
        /// </summary>
        /// <value>Array of Special Source Parameters.  Specifies additional settings that can apply to a subset of the Sources listed in the Protection Job. For example, you can specify a list of files and folders to protect instead of protecting the entire Physical Server. If this field&#39;s setting conflicts with environmentParameters, then this setting will be used.</value>
        [DataMember(Name="sourceSpecialParameters", EmitDefaultValue=true)]
        public List<SourceSpecialParameter> SourceSpecialParameters { get; set; }

        /// <summary>
        /// Specifies the time of day to start the Protection Schedule. This is optional and only applicable if the Protection Policy defines a monthly or a daily Protection Schedule. Default value is 02:00 AM.
        /// </summary>
        /// <value>Specifies the time of day to start the Protection Schedule. This is optional and only applicable if the Protection Policy defines a monthly or a daily Protection Schedule. Default value is 02:00 AM.</value>
        [DataMember(Name="startTime", EmitDefaultValue=true)]
        public TimeOfDay StartTime { get; set; }

        /// <summary>
        /// Specifies the timezone to use when calculating time for this Protection Job such as the Job start time. Specify the timezone in the following format: \&quot;Area/Location\&quot;, for example: \&quot;America/New_York\&quot;.
        /// </summary>
        /// <value>Specifies the timezone to use when calculating time for this Protection Job such as the Job start time. Specify the timezone in the following format: \&quot;Area/Location\&quot;, for example: \&quot;America/New_York\&quot;.</value>
        [DataMember(Name="timezone", EmitDefaultValue=true)]
        public string Timezone { get; set; }

        /// <summary>
        /// Tags associated with the job. User can specify tags/keywords that can indexed by Yoda and can be later searched in UI. For example, user can create a &#39;kPuppeteer&#39; job to backup Oracle DB for &#39;payroll&#39; department. User can specify following tags: &#39;payroll&#39;, &#39;Oracle_DB&#39;.
        /// </summary>
        /// <value>Tags associated with the job. User can specify tags/keywords that can indexed by Yoda and can be later searched in UI. For example, user can create a &#39;kPuppeteer&#39; job to backup Oracle DB for &#39;payroll&#39; department. User can specify following tags: &#39;payroll&#39;, &#39;Oracle_DB&#39;.</value>
        [DataMember(Name="userSpecifiedTags", EmitDefaultValue=true)]
        public List<string> UserSpecifiedTags { get; set; }

        /// <summary>
        /// Specifies the Storage Domain (View Box) id where this Job writes data.
        /// </summary>
        /// <value>Specifies the Storage Domain (View Box) id where this Job writes data.</value>
        [DataMember(Name="viewBoxId", EmitDefaultValue=true)]
        public long? ViewBoxId { get; set; }

        /// <summary>
        /// For a Remote Adapter &#39;kPuppeteer&#39; Job or a &#39;kView&#39; Job, this field specifies a View name that should be protected. Specify this field when creating a Protection Job for the first time for a View. If this field is specified, ParentSourceId, SourceIds, and ExcludeSourceIds should not be specified.
        /// </summary>
        /// <value>For a Remote Adapter &#39;kPuppeteer&#39; Job or a &#39;kView&#39; Job, this field specifies a View name that should be protected. Specify this field when creating a Protection Job for the first time for a View. If this field is specified, ParentSourceId, SourceIds, and ExcludeSourceIds should not be specified.</value>
        [DataMember(Name="viewName", EmitDefaultValue=true)]
        public string ViewName { get; set; }

        /// <summary>
        /// Array of Arrays of VMs Tags Ids that Specify VMs to Protect.  Optionally specify a list of VMs to protect by listing Protection Source ids of VM Tags in this two dimensional array. Using this two dimensional array of Tag ids, the Cluster generates a list of VMs to protect which are derived from intersections of the inner arrays and union of the outer array, as shown by the following example. To protect only &#39;Eng&#39; VMs in the East and all the VMs in the West, specify the following tag id array: [ [1101, 2221], [3031] ], where 1101 is the &#39;Eng&#39; VM Tag id, 2221 is the &#39;East&#39; VM Tag id and 3031 is the &#39;West&#39; VM Tag id. The inner array [1101, 2221] produces a list of VMs that are both tagged with &#39;Eng&#39; and &#39;East&#39; (an intersection). The outer array combines the list from the inner array with list of VMs tagged with &#39;West&#39; (a union). The list of resulting VMs are protected by this Job.
        /// </summary>
        /// <value>Array of Arrays of VMs Tags Ids that Specify VMs to Protect.  Optionally specify a list of VMs to protect by listing Protection Source ids of VM Tags in this two dimensional array. Using this two dimensional array of Tag ids, the Cluster generates a list of VMs to protect which are derived from intersections of the inner arrays and union of the outer array, as shown by the following example. To protect only &#39;Eng&#39; VMs in the East and all the VMs in the West, specify the following tag id array: [ [1101, 2221], [3031] ], where 1101 is the &#39;Eng&#39; VM Tag id, 2221 is the &#39;East&#39; VM Tag id and 3031 is the &#39;West&#39; VM Tag id. The inner array [1101, 2221] produces a list of VMs that are both tagged with &#39;Eng&#39; and &#39;East&#39; (an intersection). The outer array combines the list from the inner array with list of VMs tagged with &#39;West&#39; (a union). The list of resulting VMs are protected by this Job.</value>
        [DataMember(Name="vmTagIds", EmitDefaultValue=true)]
        public List<List<long>> VmTagIds { get; set; }

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
            return this.Equals(input as ProtectionJobRequestBody);
        }

        /// <summary>
        /// Returns true if ProtectionJobRequestBody instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectionJobRequestBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectionJobRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AbortInBlackoutPeriod == input.AbortInBlackoutPeriod ||
                    (this.AbortInBlackoutPeriod != null &&
                    this.AbortInBlackoutPeriod.Equals(input.AbortInBlackoutPeriod))
                ) && 
                (
                    this.AlertingConfig == input.AlertingConfig ||
                    (this.AlertingConfig != null &&
                    this.AlertingConfig.Equals(input.AlertingConfig))
                ) && 
                (
                    this.AlertingPolicy == input.AlertingPolicy ||
                    this.AlertingPolicy.SequenceEqual(input.AlertingPolicy)
                ) && 
                (
                    this.CloudParameters == input.CloudParameters ||
                    (this.CloudParameters != null &&
                    this.CloudParameters.Equals(input.CloudParameters))
                ) && 
                (
                    this.ContinueOnQuiesceFailure == input.ContinueOnQuiesceFailure ||
                    (this.ContinueOnQuiesceFailure != null &&
                    this.ContinueOnQuiesceFailure.Equals(input.ContinueOnQuiesceFailure))
                ) && 
                (
                    this.CreateRemoteView == input.CreateRemoteView ||
                    (this.CreateRemoteView != null &&
                    this.CreateRemoteView.Equals(input.CreateRemoteView))
                ) && 
                (
                    this.DataMigrationPolicy == input.DataMigrationPolicy ||
                    (this.DataMigrationPolicy != null &&
                    this.DataMigrationPolicy.Equals(input.DataMigrationPolicy))
                ) && 
                (
                    this.DedupDisabledSourceIds == input.DedupDisabledSourceIds ||
                    this.DedupDisabledSourceIds != null &&
                    input.DedupDisabledSourceIds != null &&
                    this.DedupDisabledSourceIds.SequenceEqual(input.DedupDisabledSourceIds)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.EndTimeUsecs == input.EndTimeUsecs ||
                    (this.EndTimeUsecs != null &&
                    this.EndTimeUsecs.Equals(input.EndTimeUsecs))
                ) && 
                (
                    this.Environment == input.Environment ||
                    this.Environment.Equals(input.Environment)
                ) && 
                (
                    this.EnvironmentParameters == input.EnvironmentParameters ||
                    (this.EnvironmentParameters != null &&
                    this.EnvironmentParameters.Equals(input.EnvironmentParameters))
                ) && 
                (
                    this.ExcludeSourceIds == input.ExcludeSourceIds ||
                    this.ExcludeSourceIds != null &&
                    input.ExcludeSourceIds != null &&
                    this.ExcludeSourceIds.SequenceEqual(input.ExcludeSourceIds)
                ) && 
                (
                    this.ExcludeVmTagIds == input.ExcludeVmTagIds ||
                    this.ExcludeVmTagIds != null &&
                    input.ExcludeVmTagIds != null &&
                    this.ExcludeVmTagIds.SequenceEqual(input.ExcludeVmTagIds)
                ) && 
                (
                    this.FullProtectionSlaTimeMins == input.FullProtectionSlaTimeMins ||
                    (this.FullProtectionSlaTimeMins != null &&
                    this.FullProtectionSlaTimeMins.Equals(input.FullProtectionSlaTimeMins))
                ) && 
                (
                    this.FullProtectionStartTime == input.FullProtectionStartTime ||
                    (this.FullProtectionStartTime != null &&
                    this.FullProtectionStartTime.Equals(input.FullProtectionStartTime))
                ) && 
                (
                    this.IncrementalProtectionSlaTimeMins == input.IncrementalProtectionSlaTimeMins ||
                    (this.IncrementalProtectionSlaTimeMins != null &&
                    this.IncrementalProtectionSlaTimeMins.Equals(input.IncrementalProtectionSlaTimeMins))
                ) && 
                (
                    this.IncrementalProtectionStartTime == input.IncrementalProtectionStartTime ||
                    (this.IncrementalProtectionStartTime != null &&
                    this.IncrementalProtectionStartTime.Equals(input.IncrementalProtectionStartTime))
                ) && 
                (
                    this.IndexingPolicy == input.IndexingPolicy ||
                    (this.IndexingPolicy != null &&
                    this.IndexingPolicy.Equals(input.IndexingPolicy))
                ) && 
                (
                    this.IsDirectArchiveEnabled == input.IsDirectArchiveEnabled ||
                    (this.IsDirectArchiveEnabled != null &&
                    this.IsDirectArchiveEnabled.Equals(input.IsDirectArchiveEnabled))
                ) && 
                (
                    this.IsNativeFormat == input.IsNativeFormat ||
                    (this.IsNativeFormat != null &&
                    this.IsNativeFormat.Equals(input.IsNativeFormat))
                ) && 
                (
                    this.LeverageStorageSnapshots == input.LeverageStorageSnapshots ||
                    (this.LeverageStorageSnapshots != null &&
                    this.LeverageStorageSnapshots.Equals(input.LeverageStorageSnapshots))
                ) && 
                (
                    this.LeverageStorageSnapshotsForHyperflex == input.LeverageStorageSnapshotsForHyperflex ||
                    (this.LeverageStorageSnapshotsForHyperflex != null &&
                    this.LeverageStorageSnapshotsForHyperflex.Equals(input.LeverageStorageSnapshotsForHyperflex))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ParentSourceId == input.ParentSourceId ||
                    (this.ParentSourceId != null &&
                    this.ParentSourceId.Equals(input.ParentSourceId))
                ) && 
                (
                    this.PerformSourceSideDedup == input.PerformSourceSideDedup ||
                    (this.PerformSourceSideDedup != null &&
                    this.PerformSourceSideDedup.Equals(input.PerformSourceSideDedup))
                ) && 
                (
                    this.PolicyId == input.PolicyId ||
                    (this.PolicyId != null &&
                    this.PolicyId.Equals(input.PolicyId))
                ) && 
                (
                    this.PostBackupScript == input.PostBackupScript ||
                    (this.PostBackupScript != null &&
                    this.PostBackupScript.Equals(input.PostBackupScript))
                ) && 
                (
                    this.PreBackupScript == input.PreBackupScript ||
                    (this.PreBackupScript != null &&
                    this.PreBackupScript.Equals(input.PreBackupScript))
                ) && 
                (
                    this.Priority == input.Priority ||
                    this.Priority.Equals(input.Priority)
                ) && 
                (
                    this.QosType == input.QosType ||
                    this.QosType.Equals(input.QosType)
                ) && 
                (
                    this.Quiesce == input.Quiesce ||
                    (this.Quiesce != null &&
                    this.Quiesce.Equals(input.Quiesce))
                ) && 
                (
                    this.RemoteScript == input.RemoteScript ||
                    (this.RemoteScript != null &&
                    this.RemoteScript.Equals(input.RemoteScript))
                ) && 
                (
                    this.RemoteViewName == input.RemoteViewName ||
                    (this.RemoteViewName != null &&
                    this.RemoteViewName.Equals(input.RemoteViewName))
                ) && 
                (
                    this.SourceIds == input.SourceIds ||
                    this.SourceIds != null &&
                    input.SourceIds != null &&
                    this.SourceIds.SequenceEqual(input.SourceIds)
                ) && 
                (
                    this.SourceSpecialParameters == input.SourceSpecialParameters ||
                    this.SourceSpecialParameters != null &&
                    input.SourceSpecialParameters != null &&
                    this.SourceSpecialParameters.SequenceEqual(input.SourceSpecialParameters)
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && 
                (
                    this.UserSpecifiedTags == input.UserSpecifiedTags ||
                    this.UserSpecifiedTags != null &&
                    input.UserSpecifiedTags != null &&
                    this.UserSpecifiedTags.SequenceEqual(input.UserSpecifiedTags)
                ) && 
                (
                    this.ViewBoxId == input.ViewBoxId ||
                    (this.ViewBoxId != null &&
                    this.ViewBoxId.Equals(input.ViewBoxId))
                ) && 
                (
                    this.ViewName == input.ViewName ||
                    (this.ViewName != null &&
                    this.ViewName.Equals(input.ViewName))
                ) && 
                (
                    this.VmTagIds == input.VmTagIds ||
                    this.VmTagIds != null &&
                    input.VmTagIds != null &&
                    this.VmTagIds.SequenceEqual(input.VmTagIds)
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
                if (this.AbortInBlackoutPeriod != null)
                    hashCode = hashCode * 59 + this.AbortInBlackoutPeriod.GetHashCode();
                if (this.AlertingConfig != null)
                    hashCode = hashCode * 59 + this.AlertingConfig.GetHashCode();
                hashCode = hashCode * 59 + this.AlertingPolicy.GetHashCode();
                if (this.CloudParameters != null)
                    hashCode = hashCode * 59 + this.CloudParameters.GetHashCode();
                if (this.ContinueOnQuiesceFailure != null)
                    hashCode = hashCode * 59 + this.ContinueOnQuiesceFailure.GetHashCode();
                if (this.CreateRemoteView != null)
                    hashCode = hashCode * 59 + this.CreateRemoteView.GetHashCode();
                if (this.DataMigrationPolicy != null)
                    hashCode = hashCode * 59 + this.DataMigrationPolicy.GetHashCode();
                if (this.DedupDisabledSourceIds != null)
                    hashCode = hashCode * 59 + this.DedupDisabledSourceIds.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EndTimeUsecs != null)
                    hashCode = hashCode * 59 + this.EndTimeUsecs.GetHashCode();
                hashCode = hashCode * 59 + this.Environment.GetHashCode();
                if (this.EnvironmentParameters != null)
                    hashCode = hashCode * 59 + this.EnvironmentParameters.GetHashCode();
                if (this.ExcludeSourceIds != null)
                    hashCode = hashCode * 59 + this.ExcludeSourceIds.GetHashCode();
                if (this.ExcludeVmTagIds != null)
                    hashCode = hashCode * 59 + this.ExcludeVmTagIds.GetHashCode();
                if (this.FullProtectionSlaTimeMins != null)
                    hashCode = hashCode * 59 + this.FullProtectionSlaTimeMins.GetHashCode();
                if (this.FullProtectionStartTime != null)
                    hashCode = hashCode * 59 + this.FullProtectionStartTime.GetHashCode();
                if (this.IncrementalProtectionSlaTimeMins != null)
                    hashCode = hashCode * 59 + this.IncrementalProtectionSlaTimeMins.GetHashCode();
                if (this.IncrementalProtectionStartTime != null)
                    hashCode = hashCode * 59 + this.IncrementalProtectionStartTime.GetHashCode();
                if (this.IndexingPolicy != null)
                    hashCode = hashCode * 59 + this.IndexingPolicy.GetHashCode();
                if (this.IsDirectArchiveEnabled != null)
                    hashCode = hashCode * 59 + this.IsDirectArchiveEnabled.GetHashCode();
                if (this.IsNativeFormat != null)
                    hashCode = hashCode * 59 + this.IsNativeFormat.GetHashCode();
                if (this.LeverageStorageSnapshots != null)
                    hashCode = hashCode * 59 + this.LeverageStorageSnapshots.GetHashCode();
                if (this.LeverageStorageSnapshotsForHyperflex != null)
                    hashCode = hashCode * 59 + this.LeverageStorageSnapshotsForHyperflex.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ParentSourceId != null)
                    hashCode = hashCode * 59 + this.ParentSourceId.GetHashCode();
                if (this.PerformSourceSideDedup != null)
                    hashCode = hashCode * 59 + this.PerformSourceSideDedup.GetHashCode();
                if (this.PolicyId != null)
                    hashCode = hashCode * 59 + this.PolicyId.GetHashCode();
                if (this.PostBackupScript != null)
                    hashCode = hashCode * 59 + this.PostBackupScript.GetHashCode();
                if (this.PreBackupScript != null)
                    hashCode = hashCode * 59 + this.PreBackupScript.GetHashCode();
                hashCode = hashCode * 59 + this.Priority.GetHashCode();
                hashCode = hashCode * 59 + this.QosType.GetHashCode();
                if (this.Quiesce != null)
                    hashCode = hashCode * 59 + this.Quiesce.GetHashCode();
                if (this.RemoteScript != null)
                    hashCode = hashCode * 59 + this.RemoteScript.GetHashCode();
                if (this.RemoteViewName != null)
                    hashCode = hashCode * 59 + this.RemoteViewName.GetHashCode();
                if (this.SourceIds != null)
                    hashCode = hashCode * 59 + this.SourceIds.GetHashCode();
                if (this.SourceSpecialParameters != null)
                    hashCode = hashCode * 59 + this.SourceSpecialParameters.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.UserSpecifiedTags != null)
                    hashCode = hashCode * 59 + this.UserSpecifiedTags.GetHashCode();
                if (this.ViewBoxId != null)
                    hashCode = hashCode * 59 + this.ViewBoxId.GetHashCode();
                if (this.ViewName != null)
                    hashCode = hashCode * 59 + this.ViewName.GetHashCode();
                if (this.VmTagIds != null)
                    hashCode = hashCode * 59 + this.VmTagIds.GetHashCode();
                return hashCode;
            }
        }

    }

}


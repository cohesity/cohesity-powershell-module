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
    /// ConsumerStats is the stats of a single consumer. A consumer is a entity which consumes the storage space of a storage domain. A consumer can be a View, Protection Job or a Replication Job.
    /// </summary>
    [DataContract]
    public partial class ConsumerStats :  IEquatable<ConsumerStats>
    {
        /// <summary>
        /// Specifies the type of the consumer. Type of the consumer can be one of the following three,  &#39;kViews&#39;, indicates the stats info of Views used per organization (tenant) per view box (storage domain). &#39;kProtectionRuns&#39;, indicates the stats info of Protection Runs used per organization (tenant) per view box (storage domain). &#39;kReplicationRuns&#39;, indicates the stats info of Replication In used per organization (tenant) per view box (storage domain). &#39;kViewProtectionRuns&#39;, indicates the stats info of View Protection Runs used per organization (tenant) per view box (storage domain).
        /// </summary>
        /// <value>Specifies the type of the consumer. Type of the consumer can be one of the following three,  &#39;kViews&#39;, indicates the stats info of Views used per organization (tenant) per view box (storage domain). &#39;kProtectionRuns&#39;, indicates the stats info of Protection Runs used per organization (tenant) per view box (storage domain). &#39;kReplicationRuns&#39;, indicates the stats info of Replication In used per organization (tenant) per view box (storage domain). &#39;kViewProtectionRuns&#39;, indicates the stats info of View Protection Runs used per organization (tenant) per view box (storage domain).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ConsumerTypeEnum
        {
            /// <summary>
            /// Enum KViews for value: kViews
            /// </summary>
            [EnumMember(Value = "kViews")]
            KViews = 1,

            /// <summary>
            /// Enum KProtectionRuns for value: kProtectionRuns
            /// </summary>
            [EnumMember(Value = "kProtectionRuns")]
            KProtectionRuns = 2,

            /// <summary>
            /// Enum KReplicationRuns for value: kReplicationRuns
            /// </summary>
            [EnumMember(Value = "kReplicationRuns")]
            KReplicationRuns = 3,

            /// <summary>
            /// Enum KViewProtectionRuns for value: kViewProtectionRuns
            /// </summary>
            [EnumMember(Value = "kViewProtectionRuns")]
            KViewProtectionRuns = 4

        }

        /// <summary>
        /// Specifies the type of the consumer. Type of the consumer can be one of the following three,  &#39;kViews&#39;, indicates the stats info of Views used per organization (tenant) per view box (storage domain). &#39;kProtectionRuns&#39;, indicates the stats info of Protection Runs used per organization (tenant) per view box (storage domain). &#39;kReplicationRuns&#39;, indicates the stats info of Replication In used per organization (tenant) per view box (storage domain). &#39;kViewProtectionRuns&#39;, indicates the stats info of View Protection Runs used per organization (tenant) per view box (storage domain).
        /// </summary>
        /// <value>Specifies the type of the consumer. Type of the consumer can be one of the following three,  &#39;kViews&#39;, indicates the stats info of Views used per organization (tenant) per view box (storage domain). &#39;kProtectionRuns&#39;, indicates the stats info of Protection Runs used per organization (tenant) per view box (storage domain). &#39;kReplicationRuns&#39;, indicates the stats info of Replication In used per organization (tenant) per view box (storage domain). &#39;kViewProtectionRuns&#39;, indicates the stats info of View Protection Runs used per organization (tenant) per view box (storage domain).</value>
        [DataMember(Name="consumerType", EmitDefaultValue=true)]
        public ConsumerTypeEnum? ConsumerType { get; set; }
        /// <summary>
        /// Specifies the source environment of the protection job. Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;kNimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kHpe3Par&#39; indicates the Hpe 3Par Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Generic Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhysicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIbmFlashSystem&#39; indicates the IBM Flash System Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment. &#39;kAD&#39; indicates Active Directory Protection Source environment. &#39;kRDSSnapshotManager&#39; indicates AWS RDS Protection Source environment. &#39;kCassandra&#39; indicates Cassandra Protection Source environment. &#39;kMongoDB&#39; indicates MongoDB Protection Source environment. &#39;kCouchbase&#39; indicates Couchbase Protection Source environment. &#39;kHdfs&#39; indicates Hdfs Protection Source environment. &#39;kHive&#39; indicates Hive Protection Source environment. &#39;kHBase&#39; indicates HBase Protection Source environment. &#39;kUDA&#39; indicates Universal Data Adapter Protection Source environment. &#39;kSAPHANA&#39; indicates SAP HANA protection source environment. &#39;kDB2&#39; indicates DB2 Protection Source environment. &#39;kO365Teams&#39; indicates the Office365 Teams Protection Source environment. &#39;kO365Group&#39; indicates the Office365 Groups Protection Source environment. &#39;kO365Exchange&#39; indicates the Office365 Mailbox Protection Source environment. &#39;kO365OneDrive&#39; indicates the Office365 OneDrive Protection Source environment. &#39;kO365Sharepoint&#39; indicates the Office365 SharePoint Protection Source environment. &#39;kO365PublicFolders&#39; indicates the Office365 PublicFolders Protection Source environment. &#39;kPostgres&#39; indicates the Postgres Protection Source environment. kHpe3Par, kIbmFlashSystem, kAzure, kNetapp, kAgent, kGenericNas, kAcropolis, kPhysicalFiles, kIsilon, kGPFS, kKVM, kAWS, kExchange, kHyperVVSS, kOracle, kGCP, kFlashBlade, kAWSNative, kO365, kO365Outlook, kHyperFlex, kGCPNative, kAzureNative, kKubernetes, kElastifile, kAD, kRDSSnapshotManager, kCassandra, kMongoDB, kCouchbase, kHdfs, kHive, kHBase, kUDA, kSAPHANA, kO365Teams, kO365Group, kO365Exchange, kO365OneDrive, kO365Sharepoint, kO365PublicFolders, kMongoDBPhysical, kPostgres
        /// </summary>
        /// <value>Specifies the source environment of the protection job. Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;kNimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kHpe3Par&#39; indicates the Hpe 3Par Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Generic Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhysicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIbmFlashSystem&#39; indicates the IBM Flash System Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment. &#39;kAD&#39; indicates Active Directory Protection Source environment. &#39;kRDSSnapshotManager&#39; indicates AWS RDS Protection Source environment. &#39;kCassandra&#39; indicates Cassandra Protection Source environment. &#39;kMongoDB&#39; indicates MongoDB Protection Source environment. &#39;kCouchbase&#39; indicates Couchbase Protection Source environment. &#39;kHdfs&#39; indicates Hdfs Protection Source environment. &#39;kHive&#39; indicates Hive Protection Source environment. &#39;kHBase&#39; indicates HBase Protection Source environment. &#39;kUDA&#39; indicates Universal Data Adapter Protection Source environment. &#39;kSAPHANA&#39; indicates SAP HANA protection source environment. &#39;kDB2&#39; indicates DB2 Protection Source environment. &#39;kO365Teams&#39; indicates the Office365 Teams Protection Source environment. &#39;kO365Group&#39; indicates the Office365 Groups Protection Source environment. &#39;kO365Exchange&#39; indicates the Office365 Mailbox Protection Source environment. &#39;kO365OneDrive&#39; indicates the Office365 OneDrive Protection Source environment. &#39;kO365Sharepoint&#39; indicates the Office365 SharePoint Protection Source environment. &#39;kO365PublicFolders&#39; indicates the Office365 PublicFolders Protection Source environment. &#39;kPostgres&#39; indicates the Postgres Protection Source environment. kHpe3Par, kIbmFlashSystem, kAzure, kNetapp, kAgent, kGenericNas, kAcropolis, kPhysicalFiles, kIsilon, kGPFS, kKVM, kAWS, kExchange, kHyperVVSS, kOracle, kGCP, kFlashBlade, kAWSNative, kO365, kO365Outlook, kHyperFlex, kGCPNative, kAzureNative, kKubernetes, kElastifile, kAD, kRDSSnapshotManager, kCassandra, kMongoDB, kCouchbase, kHdfs, kHive, kHBase, kUDA, kSAPHANA, kO365Teams, kO365Group, kO365Exchange, kO365OneDrive, kO365Sharepoint, kO365PublicFolders, kMongoDBPhysical, kPostgres</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProtectionEnvironmentEnum
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
            KNimble = 8

        }

        /// <summary>
        /// Specifies the source environment of the protection job. Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;kNimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kHpe3Par&#39; indicates the Hpe 3Par Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Generic Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhysicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIbmFlashSystem&#39; indicates the IBM Flash System Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment. &#39;kAD&#39; indicates Active Directory Protection Source environment. &#39;kRDSSnapshotManager&#39; indicates AWS RDS Protection Source environment. &#39;kCassandra&#39; indicates Cassandra Protection Source environment. &#39;kMongoDB&#39; indicates MongoDB Protection Source environment. &#39;kCouchbase&#39; indicates Couchbase Protection Source environment. &#39;kHdfs&#39; indicates Hdfs Protection Source environment. &#39;kHive&#39; indicates Hive Protection Source environment. &#39;kHBase&#39; indicates HBase Protection Source environment. &#39;kUDA&#39; indicates Universal Data Adapter Protection Source environment. &#39;kSAPHANA&#39; indicates SAP HANA protection source environment. &#39;kDB2&#39; indicates DB2 Protection Source environment. &#39;kO365Teams&#39; indicates the Office365 Teams Protection Source environment. &#39;kO365Group&#39; indicates the Office365 Groups Protection Source environment. &#39;kO365Exchange&#39; indicates the Office365 Mailbox Protection Source environment. &#39;kO365OneDrive&#39; indicates the Office365 OneDrive Protection Source environment. &#39;kO365Sharepoint&#39; indicates the Office365 SharePoint Protection Source environment. &#39;kO365PublicFolders&#39; indicates the Office365 PublicFolders Protection Source environment. &#39;kPostgres&#39; indicates the Postgres Protection Source environment. kHpe3Par, kIbmFlashSystem, kAzure, kNetapp, kAgent, kGenericNas, kAcropolis, kPhysicalFiles, kIsilon, kGPFS, kKVM, kAWS, kExchange, kHyperVVSS, kOracle, kGCP, kFlashBlade, kAWSNative, kO365, kO365Outlook, kHyperFlex, kGCPNative, kAzureNative, kKubernetes, kElastifile, kAD, kRDSSnapshotManager, kCassandra, kMongoDB, kCouchbase, kHdfs, kHive, kHBase, kUDA, kSAPHANA, kO365Teams, kO365Group, kO365Exchange, kO365OneDrive, kO365Sharepoint, kO365PublicFolders, kMongoDBPhysical, kPostgres
        /// </summary>
        /// <value>Specifies the source environment of the protection job. Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;kNimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kHpe3Par&#39; indicates the Hpe 3Par Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Generic Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhysicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIbmFlashSystem&#39; indicates the IBM Flash System Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment. &#39;kAD&#39; indicates Active Directory Protection Source environment. &#39;kRDSSnapshotManager&#39; indicates AWS RDS Protection Source environment. &#39;kCassandra&#39; indicates Cassandra Protection Source environment. &#39;kMongoDB&#39; indicates MongoDB Protection Source environment. &#39;kCouchbase&#39; indicates Couchbase Protection Source environment. &#39;kHdfs&#39; indicates Hdfs Protection Source environment. &#39;kHive&#39; indicates Hive Protection Source environment. &#39;kHBase&#39; indicates HBase Protection Source environment. &#39;kUDA&#39; indicates Universal Data Adapter Protection Source environment. &#39;kSAPHANA&#39; indicates SAP HANA protection source environment. &#39;kDB2&#39; indicates DB2 Protection Source environment. &#39;kO365Teams&#39; indicates the Office365 Teams Protection Source environment. &#39;kO365Group&#39; indicates the Office365 Groups Protection Source environment. &#39;kO365Exchange&#39; indicates the Office365 Mailbox Protection Source environment. &#39;kO365OneDrive&#39; indicates the Office365 OneDrive Protection Source environment. &#39;kO365Sharepoint&#39; indicates the Office365 SharePoint Protection Source environment. &#39;kO365PublicFolders&#39; indicates the Office365 PublicFolders Protection Source environment. &#39;kPostgres&#39; indicates the Postgres Protection Source environment. kHpe3Par, kIbmFlashSystem, kAzure, kNetapp, kAgent, kGenericNas, kAcropolis, kPhysicalFiles, kIsilon, kGPFS, kKVM, kAWS, kExchange, kHyperVVSS, kOracle, kGCP, kFlashBlade, kAWSNative, kO365, kO365Outlook, kHyperFlex, kGCPNative, kAzureNative, kKubernetes, kElastifile, kAD, kRDSSnapshotManager, kCassandra, kMongoDB, kCouchbase, kHdfs, kHive, kHBase, kUDA, kSAPHANA, kO365Teams, kO365Group, kO365Exchange, kO365OneDrive, kO365Sharepoint, kO365PublicFolders, kMongoDBPhysical, kPostgres</value>
        [DataMember(Name="protectionEnvironment", EmitDefaultValue=true)]
        public ProtectionEnvironmentEnum? ProtectionEnvironment { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsumerStats" /> class.
        /// </summary>
        /// <param name="consumerType">Specifies the type of the consumer. Type of the consumer can be one of the following three,  &#39;kViews&#39;, indicates the stats info of Views used per organization (tenant) per view box (storage domain). &#39;kProtectionRuns&#39;, indicates the stats info of Protection Runs used per organization (tenant) per view box (storage domain). &#39;kReplicationRuns&#39;, indicates the stats info of Replication In used per organization (tenant) per view box (storage domain). &#39;kViewProtectionRuns&#39;, indicates the stats info of View Protection Runs used per organization (tenant) per view box (storage domain)..</param>
        /// <param name="groupList">Specifies a list of groups associated to this consumer..</param>
        /// <param name="id">Specifies the id of the consumer..</param>
        /// <param name="jobUid">jobUid.</param>
        /// <param name="name">Specifies the name of the consumer..</param>
        /// <param name="protectionEnvironment">Specifies the source environment of the protection job. Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;kNimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kHpe3Par&#39; indicates the Hpe 3Par Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Generic Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhysicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIbmFlashSystem&#39; indicates the IBM Flash System Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment. &#39;kAD&#39; indicates Active Directory Protection Source environment. &#39;kRDSSnapshotManager&#39; indicates AWS RDS Protection Source environment. &#39;kCassandra&#39; indicates Cassandra Protection Source environment. &#39;kMongoDB&#39; indicates MongoDB Protection Source environment. &#39;kCouchbase&#39; indicates Couchbase Protection Source environment. &#39;kHdfs&#39; indicates Hdfs Protection Source environment. &#39;kHive&#39; indicates Hive Protection Source environment. &#39;kHBase&#39; indicates HBase Protection Source environment. &#39;kUDA&#39; indicates Universal Data Adapter Protection Source environment. &#39;kSAPHANA&#39; indicates SAP HANA protection source environment. &#39;kDB2&#39; indicates DB2 Protection Source environment. &#39;kO365Teams&#39; indicates the Office365 Teams Protection Source environment. &#39;kO365Group&#39; indicates the Office365 Groups Protection Source environment. &#39;kO365Exchange&#39; indicates the Office365 Mailbox Protection Source environment. &#39;kO365OneDrive&#39; indicates the Office365 OneDrive Protection Source environment. &#39;kO365Sharepoint&#39; indicates the Office365 SharePoint Protection Source environment. &#39;kO365PublicFolders&#39; indicates the Office365 PublicFolders Protection Source environment. &#39;kPostgres&#39; indicates the Postgres Protection Source environment. kHpe3Par, kIbmFlashSystem, kAzure, kNetapp, kAgent, kGenericNas, kAcropolis, kPhysicalFiles, kIsilon, kGPFS, kKVM, kAWS, kExchange, kHyperVVSS, kOracle, kGCP, kFlashBlade, kAWSNative, kO365, kO365Outlook, kHyperFlex, kGCPNative, kAzureNative, kKubernetes, kElastifile, kAD, kRDSSnapshotManager, kCassandra, kMongoDB, kCouchbase, kHdfs, kHive, kHBase, kUDA, kSAPHANA, kO365Teams, kO365Group, kO365Exchange, kO365OneDrive, kO365Sharepoint, kO365PublicFolders, kMongoDBPhysical, kPostgres.</param>
        /// <param name="protectionPolicyName">Specifies the name of the protection policy for &#39;kProtectionRuns&#39; and &#39;kReplicationRuns&#39; consumer..</param>
        /// <param name="quotaHardLimitBytes">Specifies the hard limit of logical quota of the consumer. This field will be returned only if consumer type is view..</param>
        /// <param name="schemaInfoList">Specifies a list of schemaInfos of the consumer..</param>
        /// <param name="stats">stats.</param>
        public ConsumerStats(ConsumerTypeEnum? consumerType = default(ConsumerTypeEnum?), List<StatsGroup> groupList = default(List<StatsGroup>), long? id = default(long?), UniversalIdProto jobUid = default(UniversalIdProto), string name = default(string), ProtectionEnvironmentEnum? protectionEnvironment = default(ProtectionEnvironmentEnum?), string protectionPolicyName = default(string), long? quotaHardLimitBytes = default(long?), List<UsageSchemaInfo> schemaInfoList = default(List<UsageSchemaInfo>), DataUsageStats stats = default(DataUsageStats))
        {
            this.ConsumerType = consumerType;
            this.GroupList = groupList;
            this.Id = id;
            this.Name = name;
            this.ProtectionEnvironment = protectionEnvironment;
            this.ProtectionPolicyName = protectionPolicyName;
            this.QuotaHardLimitBytes = quotaHardLimitBytes;
            this.SchemaInfoList = schemaInfoList;
            this.ConsumerType = consumerType;
            this.GroupList = groupList;
            this.Id = id;
            this.JobUid = jobUid;
            this.Name = name;
            this.ProtectionEnvironment = protectionEnvironment;
            this.ProtectionPolicyName = protectionPolicyName;
            this.QuotaHardLimitBytes = quotaHardLimitBytes;
            this.SchemaInfoList = schemaInfoList;
            this.Stats = stats;
        }
        
        /// <summary>
        /// Specifies a list of groups associated to this consumer.
        /// </summary>
        /// <value>Specifies a list of groups associated to this consumer.</value>
        [DataMember(Name="groupList", EmitDefaultValue=true)]
        public List<StatsGroup> GroupList { get; set; }

        /// <summary>
        /// Specifies the id of the consumer.
        /// </summary>
        /// <value>Specifies the id of the consumer.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets JobUid
        /// </summary>
        [DataMember(Name="jobUid", EmitDefaultValue=false)]
        public UniversalIdProto JobUid { get; set; }

        /// <summary>
        /// Specifies the name of the consumer.
        /// </summary>
        /// <value>Specifies the name of the consumer.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the name of the protection policy for &#39;kProtectionRuns&#39; and &#39;kReplicationRuns&#39; consumer.
        /// </summary>
        /// <value>Specifies the name of the protection policy for &#39;kProtectionRuns&#39; and &#39;kReplicationRuns&#39; consumer.</value>
        [DataMember(Name="protectionPolicyName", EmitDefaultValue=true)]
        public string ProtectionPolicyName { get; set; }

        /// <summary>
        /// Specifies the hard limit of logical quota of the consumer. This field will be returned only if consumer type is view.
        /// </summary>
        /// <value>Specifies the hard limit of logical quota of the consumer. This field will be returned only if consumer type is view.</value>
        [DataMember(Name="quotaHardLimitBytes", EmitDefaultValue=true)]
        public long? QuotaHardLimitBytes { get; set; }

        /// <summary>
        /// Specifies a list of schemaInfos of the consumer.
        /// </summary>
        /// <value>Specifies a list of schemaInfos of the consumer.</value>
        [DataMember(Name="schemaInfoList", EmitDefaultValue=true)]
        public List<UsageSchemaInfo> SchemaInfoList { get; set; }

        /// <summary>
        /// Gets or Sets Stats
        /// </summary>
        [DataMember(Name="stats", EmitDefaultValue=false)]
        public DataUsageStats Stats { get; set; }

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
            return this.Equals(input as ConsumerStats);
        }

        /// <summary>
        /// Returns true if ConsumerStats instances are equal
        /// </summary>
        /// <param name="input">Instance of ConsumerStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsumerStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConsumerType == input.ConsumerType ||
                    this.ConsumerType.Equals(input.ConsumerType)
                ) && 
                (
                    this.GroupList == input.GroupList ||
                    this.GroupList != null &&
                    input.GroupList != null &&
                    this.GroupList.SequenceEqual(input.GroupList)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.JobUid == input.JobUid ||
                    (this.JobUid != null &&
                    this.JobUid.Equals(input.JobUid))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ProtectionEnvironment == input.ProtectionEnvironment ||
                    this.ProtectionEnvironment.Equals(input.ProtectionEnvironment)
                ) && 
                (
                    this.ProtectionPolicyName == input.ProtectionPolicyName ||
                    (this.ProtectionPolicyName != null &&
                    this.ProtectionPolicyName.Equals(input.ProtectionPolicyName))
                ) && 
                (
                    this.QuotaHardLimitBytes == input.QuotaHardLimitBytes ||
                    (this.QuotaHardLimitBytes != null &&
                    this.QuotaHardLimitBytes.Equals(input.QuotaHardLimitBytes))
                ) && 
                (
                    this.SchemaInfoList == input.SchemaInfoList ||
                    this.SchemaInfoList != null &&
                    input.SchemaInfoList != null &&
                    this.SchemaInfoList.SequenceEqual(input.SchemaInfoList)
                ) && 
                (
                    this.Stats == input.Stats ||
                    (this.Stats != null &&
                    this.Stats.Equals(input.Stats))
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
                hashCode = hashCode * 59 + this.ConsumerType.GetHashCode();
                if (this.GroupList != null)
                    hashCode = hashCode * 59 + this.GroupList.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.JobUid != null)
                    hashCode = hashCode * 59 + this.JobUid.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.ProtectionEnvironment.GetHashCode();
                if (this.ProtectionPolicyName != null)
                    hashCode = hashCode * 59 + this.ProtectionPolicyName.GetHashCode();
                if (this.QuotaHardLimitBytes != null)
                    hashCode = hashCode * 59 + this.QuotaHardLimitBytes.GetHashCode();
                if (this.SchemaInfoList != null)
                    hashCode = hashCode * 59 + this.SchemaInfoList.GetHashCode();
                if (this.Stats != null)
                    hashCode = hashCode * 59 + this.Stats.GetHashCode();
                return hashCode;
            }
        }

    }

}


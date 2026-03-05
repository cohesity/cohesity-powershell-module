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
    /// Specifies the parameters required to establish a connection with a particular environment.
    /// </summary>
    [DataContract]
    public partial class ConnectorParameters :  IEquatable<ConnectorParameters>
    {
        /// <summary>
        /// Specifies the environment like VMware, SQL, where the Protection Source exists. Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;kNimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kHpe3Par&#39; indicates the Hpe 3Par Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Generic Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhysicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIbmFlashSystem&#39; indicates the IBM Flash System Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment. &#39;kAD&#39; indicates Active Directory Protection Source environment. &#39;kRDSSnapshotManager&#39; indicates AWS RDS Protection Source environment. &#39;kCassandra&#39; indicates Cassandra Protection Source environment. &#39;kMongoDB&#39; indicates MongoDB Protection Source environment. &#39;kCouchbase&#39; indicates Couchbase Protection Source environment. &#39;kHdfs&#39; indicates Hdfs Protection Source environment. &#39;kHive&#39; indicates Hive Protection Source environment. &#39;kHBase&#39; indicates HBase Protection Source environment. &#39;kUDA&#39; indicates Universal Data Adapter Protection Source environment. &#39;kSAPHANA&#39; indicates SAP HANA protection source environment. &#39;kDB2&#39; indicates DB2 Protection Source environment. &#39;kO365Teams&#39; indicates the Office365 Teams Protection Source environment. &#39;kO365Group&#39; indicates the Office365 Groups Protection Source environment. &#39;kO365Exchange&#39; indicates the Office365 Mailbox Protection Source environment. &#39;kO365OneDrive&#39; indicates the Office365 OneDrive Protection Source environment. &#39;kO365Sharepoint&#39; indicates the Office365 SharePoint Protection Source environment. &#39;kO365PublicFolders&#39; indicates the Office365 PublicFolders Protection Source environment. &#39;kPostgres&#39; indicates the Postgres Protection Source environment. kHpe3Par, kIbmFlashSystem, kAzure, kNetapp, kAgent, kGenericNas, kAcropolis, kPhysicalFiles, kIsilon, kGPFS, kKVM, kAWS, kExchange, kHyperVVSS, kOracle, kGCP, kFlashBlade, kAWSNative, kO365, kO365Outlook, kHyperFlex, kGCPNative, kAzureNative, kKubernetes, kElastifile, kAD, kRDSSnapshotManager, kCassandra, kMongoDB, kCouchbase, kHdfs, kHive, kHBase, kUDA, kSAPHANA, kO365Teams, kO365Group, kO365Exchange, kO365OneDrive, kO365Sharepoint, kO365PublicFolders, kMongoDBPhysical, kPostgres
        /// </summary>
        /// <value>Specifies the environment like VMware, SQL, where the Protection Source exists. Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;kNimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kHpe3Par&#39; indicates the Hpe 3Par Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Generic Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhysicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIbmFlashSystem&#39; indicates the IBM Flash System Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment. &#39;kAD&#39; indicates Active Directory Protection Source environment. &#39;kRDSSnapshotManager&#39; indicates AWS RDS Protection Source environment. &#39;kCassandra&#39; indicates Cassandra Protection Source environment. &#39;kMongoDB&#39; indicates MongoDB Protection Source environment. &#39;kCouchbase&#39; indicates Couchbase Protection Source environment. &#39;kHdfs&#39; indicates Hdfs Protection Source environment. &#39;kHive&#39; indicates Hive Protection Source environment. &#39;kHBase&#39; indicates HBase Protection Source environment. &#39;kUDA&#39; indicates Universal Data Adapter Protection Source environment. &#39;kSAPHANA&#39; indicates SAP HANA protection source environment. &#39;kDB2&#39; indicates DB2 Protection Source environment. &#39;kO365Teams&#39; indicates the Office365 Teams Protection Source environment. &#39;kO365Group&#39; indicates the Office365 Groups Protection Source environment. &#39;kO365Exchange&#39; indicates the Office365 Mailbox Protection Source environment. &#39;kO365OneDrive&#39; indicates the Office365 OneDrive Protection Source environment. &#39;kO365Sharepoint&#39; indicates the Office365 SharePoint Protection Source environment. &#39;kO365PublicFolders&#39; indicates the Office365 PublicFolders Protection Source environment. &#39;kPostgres&#39; indicates the Postgres Protection Source environment. kHpe3Par, kIbmFlashSystem, kAzure, kNetapp, kAgent, kGenericNas, kAcropolis, kPhysicalFiles, kIsilon, kGPFS, kKVM, kAWS, kExchange, kHyperVVSS, kOracle, kGCP, kFlashBlade, kAWSNative, kO365, kO365Outlook, kHyperFlex, kGCPNative, kAzureNative, kKubernetes, kElastifile, kAD, kRDSSnapshotManager, kCassandra, kMongoDB, kCouchbase, kHdfs, kHive, kHBase, kUDA, kSAPHANA, kO365Teams, kO365Group, kO365Exchange, kO365OneDrive, kO365Sharepoint, kO365PublicFolders, kMongoDBPhysical, kPostgres</value>
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
            KNimble = 8

        }

        /// <summary>
        /// Specifies the environment like VMware, SQL, where the Protection Source exists. Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;kNimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kHpe3Par&#39; indicates the Hpe 3Par Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Generic Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhysicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIbmFlashSystem&#39; indicates the IBM Flash System Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment. &#39;kAD&#39; indicates Active Directory Protection Source environment. &#39;kRDSSnapshotManager&#39; indicates AWS RDS Protection Source environment. &#39;kCassandra&#39; indicates Cassandra Protection Source environment. &#39;kMongoDB&#39; indicates MongoDB Protection Source environment. &#39;kCouchbase&#39; indicates Couchbase Protection Source environment. &#39;kHdfs&#39; indicates Hdfs Protection Source environment. &#39;kHive&#39; indicates Hive Protection Source environment. &#39;kHBase&#39; indicates HBase Protection Source environment. &#39;kUDA&#39; indicates Universal Data Adapter Protection Source environment. &#39;kSAPHANA&#39; indicates SAP HANA protection source environment. &#39;kDB2&#39; indicates DB2 Protection Source environment. &#39;kO365Teams&#39; indicates the Office365 Teams Protection Source environment. &#39;kO365Group&#39; indicates the Office365 Groups Protection Source environment. &#39;kO365Exchange&#39; indicates the Office365 Mailbox Protection Source environment. &#39;kO365OneDrive&#39; indicates the Office365 OneDrive Protection Source environment. &#39;kO365Sharepoint&#39; indicates the Office365 SharePoint Protection Source environment. &#39;kO365PublicFolders&#39; indicates the Office365 PublicFolders Protection Source environment. &#39;kPostgres&#39; indicates the Postgres Protection Source environment. kHpe3Par, kIbmFlashSystem, kAzure, kNetapp, kAgent, kGenericNas, kAcropolis, kPhysicalFiles, kIsilon, kGPFS, kKVM, kAWS, kExchange, kHyperVVSS, kOracle, kGCP, kFlashBlade, kAWSNative, kO365, kO365Outlook, kHyperFlex, kGCPNative, kAzureNative, kKubernetes, kElastifile, kAD, kRDSSnapshotManager, kCassandra, kMongoDB, kCouchbase, kHdfs, kHive, kHBase, kUDA, kSAPHANA, kO365Teams, kO365Group, kO365Exchange, kO365OneDrive, kO365Sharepoint, kO365PublicFolders, kMongoDBPhysical, kPostgres
        /// </summary>
        /// <value>Specifies the environment like VMware, SQL, where the Protection Source exists. Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;kNimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kHpe3Par&#39; indicates the Hpe 3Par Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Generic Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhysicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIbmFlashSystem&#39; indicates the IBM Flash System Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment. &#39;kAD&#39; indicates Active Directory Protection Source environment. &#39;kRDSSnapshotManager&#39; indicates AWS RDS Protection Source environment. &#39;kCassandra&#39; indicates Cassandra Protection Source environment. &#39;kMongoDB&#39; indicates MongoDB Protection Source environment. &#39;kCouchbase&#39; indicates Couchbase Protection Source environment. &#39;kHdfs&#39; indicates Hdfs Protection Source environment. &#39;kHive&#39; indicates Hive Protection Source environment. &#39;kHBase&#39; indicates HBase Protection Source environment. &#39;kUDA&#39; indicates Universal Data Adapter Protection Source environment. &#39;kSAPHANA&#39; indicates SAP HANA protection source environment. &#39;kDB2&#39; indicates DB2 Protection Source environment. &#39;kO365Teams&#39; indicates the Office365 Teams Protection Source environment. &#39;kO365Group&#39; indicates the Office365 Groups Protection Source environment. &#39;kO365Exchange&#39; indicates the Office365 Mailbox Protection Source environment. &#39;kO365OneDrive&#39; indicates the Office365 OneDrive Protection Source environment. &#39;kO365Sharepoint&#39; indicates the Office365 SharePoint Protection Source environment. &#39;kO365PublicFolders&#39; indicates the Office365 PublicFolders Protection Source environment. &#39;kPostgres&#39; indicates the Postgres Protection Source environment. kHpe3Par, kIbmFlashSystem, kAzure, kNetapp, kAgent, kGenericNas, kAcropolis, kPhysicalFiles, kIsilon, kGPFS, kKVM, kAWS, kExchange, kHyperVVSS, kOracle, kGCP, kFlashBlade, kAWSNative, kO365, kO365Outlook, kHyperFlex, kGCPNative, kAzureNative, kKubernetes, kElastifile, kAD, kRDSSnapshotManager, kCassandra, kMongoDB, kCouchbase, kHdfs, kHive, kHBase, kUDA, kSAPHANA, kO365Teams, kO365Group, kO365Exchange, kO365OneDrive, kO365Sharepoint, kO365PublicFolders, kMongoDBPhysical, kPostgres</value>
        [DataMember(Name="environment", EmitDefaultValue=true)]
        public EnvironmentEnum? Environment { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorParameters" /> class.
        /// </summary>
        /// <param name="connectionId">ID of the Bifrost (HyX or Rigel) network realm (i.e. a connection) associated with the source..</param>
        /// <param name="connectorGroupId">Specifies the Id of the connector group. Each connector group is collection of Rigel/hyx. Each entity will be tagged with connector group id..</param>
        /// <param name="endpoint">Specify an IP address or URL of the environment. (such as the IP address of the vCenter Server for a VMware environment)..</param>
        /// <param name="environment">Specifies the environment like VMware, SQL, where the Protection Source exists. Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;kNimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kHpe3Par&#39; indicates the Hpe 3Par Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Generic Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhysicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIbmFlashSystem&#39; indicates the IBM Flash System Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment. &#39;kAD&#39; indicates Active Directory Protection Source environment. &#39;kRDSSnapshotManager&#39; indicates AWS RDS Protection Source environment. &#39;kCassandra&#39; indicates Cassandra Protection Source environment. &#39;kMongoDB&#39; indicates MongoDB Protection Source environment. &#39;kCouchbase&#39; indicates Couchbase Protection Source environment. &#39;kHdfs&#39; indicates Hdfs Protection Source environment. &#39;kHive&#39; indicates Hive Protection Source environment. &#39;kHBase&#39; indicates HBase Protection Source environment. &#39;kUDA&#39; indicates Universal Data Adapter Protection Source environment. &#39;kSAPHANA&#39; indicates SAP HANA protection source environment. &#39;kDB2&#39; indicates DB2 Protection Source environment. &#39;kO365Teams&#39; indicates the Office365 Teams Protection Source environment. &#39;kO365Group&#39; indicates the Office365 Groups Protection Source environment. &#39;kO365Exchange&#39; indicates the Office365 Mailbox Protection Source environment. &#39;kO365OneDrive&#39; indicates the Office365 OneDrive Protection Source environment. &#39;kO365Sharepoint&#39; indicates the Office365 SharePoint Protection Source environment. &#39;kO365PublicFolders&#39; indicates the Office365 PublicFolders Protection Source environment. &#39;kPostgres&#39; indicates the Postgres Protection Source environment. kHpe3Par, kIbmFlashSystem, kAzure, kNetapp, kAgent, kGenericNas, kAcropolis, kPhysicalFiles, kIsilon, kGPFS, kKVM, kAWS, kExchange, kHyperVVSS, kOracle, kGCP, kFlashBlade, kAWSNative, kO365, kO365Outlook, kHyperFlex, kGCPNative, kAzureNative, kKubernetes, kElastifile, kAD, kRDSSnapshotManager, kCassandra, kMongoDB, kCouchbase, kHdfs, kHive, kHBase, kUDA, kSAPHANA, kO365Teams, kO365Group, kO365Exchange, kO365OneDrive, kO365Sharepoint, kO365PublicFolders, kMongoDBPhysical, kPostgres.</param>
        /// <param name="id">Specifies a Unique id that is generated when the Source is registered. This is a convenience field that is used to maintain an index to different connection params..</param>
        /// <param name="version">Version is updated each time the connector parameters are updated. This is used to discard older connector parameters..</param>
        public ConnectorParameters(long? connectionId = default(long?), long? connectorGroupId = default(long?), string endpoint = default(string), EnvironmentEnum? environment = default(EnvironmentEnum?), long? id = default(long?), long? version = default(long?))
        {
            this.ConnectionId = connectionId;
            this.ConnectorGroupId = connectorGroupId;
            this.Endpoint = endpoint;
            this.Environment = environment;
            this.Id = id;
            this.Version = version;
            this.ConnectionId = connectionId;
            this.ConnectorGroupId = connectorGroupId;
            this.Endpoint = endpoint;
            this.Environment = environment;
            this.Id = id;
            this.Version = version;
        }
        
        /// <summary>
        /// ID of the Bifrost (HyX or Rigel) network realm (i.e. a connection) associated with the source.
        /// </summary>
        /// <value>ID of the Bifrost (HyX or Rigel) network realm (i.e. a connection) associated with the source.</value>
        [DataMember(Name="connectionId", EmitDefaultValue=true)]
        public long? ConnectionId { get; set; }

        /// <summary>
        /// Specifies the Id of the connector group. Each connector group is collection of Rigel/hyx. Each entity will be tagged with connector group id.
        /// </summary>
        /// <value>Specifies the Id of the connector group. Each connector group is collection of Rigel/hyx. Each entity will be tagged with connector group id.</value>
        [DataMember(Name="connectorGroupId", EmitDefaultValue=true)]
        public long? ConnectorGroupId { get; set; }

        /// <summary>
        /// Specify an IP address or URL of the environment. (such as the IP address of the vCenter Server for a VMware environment).
        /// </summary>
        /// <value>Specify an IP address or URL of the environment. (such as the IP address of the vCenter Server for a VMware environment).</value>
        [DataMember(Name="endpoint", EmitDefaultValue=true)]
        public string Endpoint { get; set; }

        /// <summary>
        /// Specifies a Unique id that is generated when the Source is registered. This is a convenience field that is used to maintain an index to different connection params.
        /// </summary>
        /// <value>Specifies a Unique id that is generated when the Source is registered. This is a convenience field that is used to maintain an index to different connection params.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Version is updated each time the connector parameters are updated. This is used to discard older connector parameters.
        /// </summary>
        /// <value>Version is updated each time the connector parameters are updated. This is used to discard older connector parameters.</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public long? Version { get; set; }

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
            return this.Equals(input as ConnectorParameters);
        }

        /// <summary>
        /// Returns true if ConnectorParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ConnectorParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectorParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConnectionId == input.ConnectionId ||
                    (this.ConnectionId != null &&
                    this.ConnectionId.Equals(input.ConnectionId))
                ) && 
                (
                    this.ConnectorGroupId == input.ConnectorGroupId ||
                    (this.ConnectorGroupId != null &&
                    this.ConnectorGroupId.Equals(input.ConnectorGroupId))
                ) && 
                (
                    this.Endpoint == input.Endpoint ||
                    (this.Endpoint != null &&
                    this.Endpoint.Equals(input.Endpoint))
                ) && 
                (
                    this.Environment == input.Environment ||
                    this.Environment.Equals(input.Environment)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.ConnectionId != null)
                    hashCode = hashCode * 59 + this.ConnectionId.GetHashCode();
                if (this.ConnectorGroupId != null)
                    hashCode = hashCode * 59 + this.ConnectorGroupId.GetHashCode();
                if (this.Endpoint != null)
                    hashCode = hashCode * 59 + this.Endpoint.GetHashCode();
                hashCode = hashCode * 59 + this.Environment.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}


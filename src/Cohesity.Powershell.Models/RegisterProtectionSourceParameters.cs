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
    /// Specifies the parameters required to register a Protection Source.
    /// </summary>
    [DataContract]
    public partial class RegisterProtectionSourceParameters :  IEquatable<RegisterProtectionSourceParameters>
    {
        /// <summary>
        /// Specifies the entity type if the environment is kAcropolis. overrideDescription: true
        /// </summary>
        /// <value>Specifies the entity type if the environment is kAcropolis. overrideDescription: true</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AcropolisTypeEnum
        {
            /// <summary>
            /// Enum KPrismCentral for value: kPrismCentral
            /// </summary>
            [EnumMember(Value = "kPrismCentral")]
            KPrismCentral = 1,

            /// <summary>
            /// Enum KStandaloneCluster for value: kStandaloneCluster
            /// </summary>
            [EnumMember(Value = "kStandaloneCluster")]
            KStandaloneCluster = 2,

            /// <summary>
            /// Enum KCluster for value: kCluster
            /// </summary>
            [EnumMember(Value = "kCluster")]
            KCluster = 3,

            /// <summary>
            /// Enum KHost for value: kHost
            /// </summary>
            [EnumMember(Value = "kHost")]
            KHost = 4,

            /// <summary>
            /// Enum KVirtualMachine for value: kVirtualMachine
            /// </summary>
            [EnumMember(Value = "kVirtualMachine")]
            KVirtualMachine = 5,

            /// <summary>
            /// Enum KNetwork for value: kNetwork
            /// </summary>
            [EnumMember(Value = "kNetwork")]
            KNetwork = 6,

            /// <summary>
            /// Enum KStorageContainer for value: kStorageContainer
            /// </summary>
            [EnumMember(Value = "kStorageContainer")]
            KStorageContainer = 7

        }

        /// <summary>
        /// Specifies the entity type if the environment is kAcropolis. overrideDescription: true
        /// </summary>
        /// <value>Specifies the entity type if the environment is kAcropolis. overrideDescription: true</value>
        [DataMember(Name="acropolisType", EmitDefaultValue=true)]
        public AcropolisTypeEnum? AcropolisType { get; set; }
        /// <summary>
        /// Specifies the environment such as &#39;kPhysical&#39; or &#39;kVMware&#39; of the Protection Source. overrideDescription: true Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;kNimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Generic Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhysicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment. &#39;kAD&#39; indicates Active Directory Protection Source environment. &#39;kRDSSnapshotManager&#39; indicates AWS RDS Protection Source environment. &#39;kCassandra&#39; indicates Cassandra Protection Source environment. &#39;kMongoDB&#39; indicates MongoDB Protection Source environment. &#39;kCouchbase&#39; indicates Couchbase Protection Source environment. &#39;kHdfs&#39; indicates Hdfs Protection Source environment. &#39;kHive&#39; indicates Hive Protection Source environment. &#39;kHBase&#39; indicates HBase Protection Source environment. &#39;kUDA&#39; indicates Universal Data Adapter Protection Source environment. &#39;kO365Teams&#39; indicates the Office365 Teams Protection Source environment. &#39;kO365Group&#39; indicates the Office365 Groups Protection Source environment. &#39;kO365Exchange&#39; indicates the Office365 Mailbox Protection Source environment. &#39;kO365OneDrive&#39; indicates the Office365 OneDrive Protection Source environment. &#39;kO365Sharepoint&#39; indicates the Office365 SharePoint Protection Source environment. &#39;kO365PublicFolders&#39; indicates the Office365 PublicFolders Protection Source environment.
        /// </summary>
        /// <value>Specifies the environment such as &#39;kPhysical&#39; or &#39;kVMware&#39; of the Protection Source. overrideDescription: true Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;Nimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Generic Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhsicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment. &#39;kAD&#39; indicates Active Directory Protection Source environment. &#39;kRDSSnapshotManager&#39; indicates AWS RDS Protection Source environment.</value>
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
            /// Enum KO365 for value: kO365
            /// </summary>
            [EnumMember(Value = "kO365")]
            KO365 = 25,

            /// <summary>
            /// Enum KO365Outlook for value: kO365Outlook
            /// </summary>
            [EnumMember(Value = "kO365Outlook")]
            KO365Outlook = 26,

            /// <summary>
            /// Enum KHyperFlex for value: kHyperFlex
            /// </summary>
            [EnumMember(Value = "kHyperFlex")]
            KHyperFlex = 27,

            /// <summary>
            /// Enum KGCPNative for value: kGCPNative
            /// </summary>
            [EnumMember(Value = "kGCPNative")]
            KGCPNative = 28,

            /// <summary>
            /// Enum KAzureNative for value: kAzureNative
            /// </summary>
            [EnumMember(Value = "kAzureNative")]
            KAzureNative = 29,

            /// <summary>
            /// Enum KKubernetes for value: kKubernetes
            /// </summary>
            [EnumMember(Value = "kKubernetes")]
            KKubernetes = 30,

            /// <summary>
            /// Enum KElastifile for value: kElastifile
            /// </summary>
            [EnumMember(Value = "kElastifile")]
            KElastifile = 31,

            /// <summary>
            /// Enum KAD for value: kAD
            /// </summary>
            [EnumMember(Value = "kAD")]
            KAD = 32,

            /// <summary>
            /// Enum KRDSSnapshotManager for value: kRDSSnapshotManager
            /// </summary>
            [EnumMember(Value = "kRDSSnapshotManager")]
            KRDSSnapshotManager = 33,

            /// <summary>
            /// Enum KCassandra for value: kCassandra
            /// </summary>
            [EnumMember(Value = "kCassandra")]
            KCassandra = 34,

            /// <summary>
            /// Enum KMongoDB for value: kMongoDB
            /// </summary>
            [EnumMember(Value = "kMongoDB")]
            KMongoDB = 35,

            /// <summary>
            /// Enum KCouchbase for value: kCouchbase
            /// </summary>
            [EnumMember(Value = "kCouchbase")]
            KCouchbase = 36,

            /// <summary>
            /// Enum KHdfs for value: kHdfs
            /// </summary>
            [EnumMember(Value = "kHdfs")]
            KHdfs = 37,

            /// <summary>
            /// Enum KHive for value: kHive
            /// </summary>
            [EnumMember(Value = "kHive")]
            KHive = 38,

            /// <summary>
            /// Enum KHBase for value: kHBase
            /// </summary>
            [EnumMember(Value = "kHBase")]
            KHBase = 39,

            /// <summary>
            /// Enum KUDA for value: kUDA
            /// </summary>
            [EnumMember(Value = "kUDA")]
            KUDA = 40,

            /// <summary>
            /// Enum KO365Teams for value: kO365Teams
            /// </summary>
            [EnumMember(Value = "kO365Teams")]
            KO365Teams = 41,

            /// <summary>
            /// Enum KO365Group for value: kO365Group
            /// </summary>
            [EnumMember(Value = "kO365Group")]
            KO365Group = 42,

            /// <summary>
            /// Enum KO365Exchange for value: kO365Exchange
            /// </summary>
            [EnumMember(Value = "kO365Exchange")]
            KO365Exchange = 43,

            /// <summary>
            /// Enum KO365OneDrive for value: kO365OneDrive
            /// </summary>
            [EnumMember(Value = "kO365OneDrive")]
            KO365OneDrive = 44,

            /// <summary>
            /// Enum KO365Sharepoint for value: kO365Sharepoint
            /// </summary>
            [EnumMember(Value = "kO365Sharepoint")]
            KO365Sharepoint = 45,

            /// <summary>
            /// Enum KO365PublicFolders for value: kO365PublicFolders
            /// </summary>
            [EnumMember(Value = "kO365PublicFolders")]
            KO365PublicFolders = 46,

			/// Enum KVCD for value: kVCD
            /// </summary>
            [EnumMember(Value = "kVCD")]
            KVCD = 47

        }

        /// <summary>
        /// Specifies the environment such as &#39;kPhysical&#39; or &#39;kVMware&#39; of the Protection Source. overrideDescription: true Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;kNimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Generic Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhysicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment. &#39;kAD&#39; indicates Active Directory Protection Source environment. &#39;kRDSSnapshotManager&#39; indicates AWS RDS Protection Source environment. &#39;kCassandra&#39; indicates Cassandra Protection Source environment. &#39;kMongoDB&#39; indicates MongoDB Protection Source environment. &#39;kCouchbase&#39; indicates Couchbase Protection Source environment. &#39;kHdfs&#39; indicates Hdfs Protection Source environment. &#39;kHive&#39; indicates Hive Protection Source environment. &#39;kHBase&#39; indicates HBase Protection Source environment. &#39;kUDA&#39; indicates Universal Data Adapter Protection Source environment. &#39;kO365Teams&#39; indicates the Office365 Teams Protection Source environment. &#39;kO365Group&#39; indicates the Office365 Groups Protection Source environment. &#39;kO365Exchange&#39; indicates the Office365 Mailbox Protection Source environment. &#39;kO365OneDrive&#39; indicates the Office365 OneDrive Protection Source environment. &#39;kO365Sharepoint&#39; indicates the Office365 SharePoint Protection Source environment. &#39;kO365PublicFolders&#39; indicates the Office365 PublicFolders Protection Source environment.
        /// </summary>
        /// <value>Specifies the environment such as &#39;kPhysical&#39; or &#39;kVMware&#39; of the Protection Source. overrideDescription: true Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;kNimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Generic Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhysicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment. &#39;kAD&#39; indicates Active Directory Protection Source environment. &#39;kRDSSnapshotManager&#39; indicates AWS RDS Protection Source environment. &#39;kCassandra&#39; indicates Cassandra Protection Source environment. &#39;kMongoDB&#39; indicates MongoDB Protection Source environment. &#39;kCouchbase&#39; indicates Couchbase Protection Source environment. &#39;kHdfs&#39; indicates Hdfs Protection Source environment. &#39;kHive&#39; indicates Hive Protection Source environment. &#39;kHBase&#39; indicates HBase Protection Source environment. &#39;kUDA&#39; indicates Universal Data Adapter Protection Source environment. &#39;kO365Teams&#39; indicates the Office365 Teams Protection Source environment. &#39;kO365Group&#39; indicates the Office365 Groups Protection Source environment. &#39;kO365Exchange&#39; indicates the Office365 Mailbox Protection Source environment. &#39;kO365OneDrive&#39; indicates the Office365 OneDrive Protection Source environment. &#39;kO365Sharepoint&#39; indicates the Office365 SharePoint Protection Source environment. &#39;kO365PublicFolders&#39; indicates the Office365 PublicFolders Protection Source environment.</value>
        [DataMember(Name="environment", EmitDefaultValue=true)]
        public EnvironmentEnum? Environment { get; set; }
        /// <summary>
        /// Specifies the optional OS type of the Protection Source (such as kWindows or kLinux). overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kSapOracle&#39; indicates the Sap Oracle database system developed by SAP SE. &#39;kCockroachDB&#39; indicates the CockroachDB database system. &#39;kMySQL&#39; indicates the MySQL database system. &#39;kOther&#39; indicates the other types of operating system.
        /// </summary>
        /// <value>Specifies the optional OS type of the Protection Source (such as kWindows or kLinux). overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kSapOracle&#39; indicates the Sap Oracle database system developed by SAP SE. &#39;kCockroachDB&#39; indicates the CockroachDB database system. &#39;kMySQL&#39; indicates the MySQL database system. &#39;kOther&#39; indicates the other types of operating system.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HostTypeEnum
        {
            /// <summary>
            /// Enum KLinux for value: kLinux
            /// </summary>
            [EnumMember(Value = "kLinux")]
            KLinux = 1,

            /// <summary>
            /// Enum KWindows for value: kWindows
            /// </summary>
            [EnumMember(Value = "kWindows")]
            KWindows = 2,

            /// <summary>
            /// Enum KAix for value: kAix
            /// </summary>
            [EnumMember(Value = "kAix")]
            KAix = 3,

            /// <summary>
            /// Enum KSolaris for value: kSolaris
            /// </summary>
            [EnumMember(Value = "kSolaris")]
            KSolaris = 4,

            /// <summary>
            /// Enum KSapHana for value: kSapHana
            /// </summary>
            [EnumMember(Value = "kSapHana")]
            KSapHana = 5,

            /// <summary>
            /// Enum KSapOracle for value: kSapOracle
            /// </summary>
            [EnumMember(Value = "kSapOracle")]
            KSapOracle = 6,

            /// <summary>
            /// Enum KCockroachDB for value: kCockroachDB
            /// </summary>
            [EnumMember(Value = "kCockroachDB")]
            KCockroachDB = 7,

            /// <summary>
            /// Enum KMySQL for value: kMySQL
            /// </summary>
            [EnumMember(Value = "kMySQL")]
            KMySQL = 8,

            /// <summary>
            /// Enum KOther for value: kOther
            /// </summary>
            [EnumMember(Value = "kOther")]
            KOther = 9

        }

        /// <summary>
        /// Specifies the optional OS type of the Protection Source (such as kWindows or kLinux). overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kSapOracle&#39; indicates the Sap Oracle database system developed by SAP SE. &#39;kCockroachDB&#39; indicates the CockroachDB database system. &#39;kMySQL&#39; indicates the MySQL database system. &#39;kOther&#39; indicates the other types of operating system.
        /// </summary>
        /// <value>Specifies the optional OS type of the Protection Source (such as kWindows or kLinux). overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kSapOracle&#39; indicates the Sap Oracle database system developed by SAP SE. &#39;kCockroachDB&#39; indicates the CockroachDB database system. &#39;kMySQL&#39; indicates the MySQL database system. &#39;kOther&#39; indicates the other types of operating system.</value>
        [DataMember(Name="hostType", EmitDefaultValue=true)]
        public HostTypeEnum? HostType { get; set; }
        /// <summary>
        /// Specifies the entity type if the environment is kHyperV. overrideDescription: true
        /// </summary>
        /// <value>Specifies the entity type if the environment is kHyperV. overrideDescription: true</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HyperVTypeEnum
        {
            /// <summary>
            /// Enum KSCVMMServer for value: kSCVMMServer
            /// </summary>
            [EnumMember(Value = "kSCVMMServer")]
            KSCVMMServer = 1,

            /// <summary>
            /// Enum KStandaloneHost for value: kStandaloneHost
            /// </summary>
            [EnumMember(Value = "kStandaloneHost")]
            KStandaloneHost = 2,

            /// <summary>
            /// Enum KStandaloneCluster for value: kStandaloneCluster
            /// </summary>
            [EnumMember(Value = "kStandaloneCluster")]
            KStandaloneCluster = 3,

            /// <summary>
            /// Enum KHostGroup for value: kHostGroup
            /// </summary>
            [EnumMember(Value = "kHostGroup")]
            KHostGroup = 4,

            /// <summary>
            /// Enum KHypervHost for value: kHypervHost
            /// </summary>
            [EnumMember(Value = "kHypervHost")]
            KHypervHost = 5,

            /// <summary>
            /// Enum KHostCluster for value: kHostCluster
            /// </summary>
            [EnumMember(Value = "kHostCluster")]
            KHostCluster = 6,

            /// <summary>
            /// Enum KVirtualMachine for value: kVirtualMachine
            /// </summary>
            [EnumMember(Value = "kVirtualMachine")]
            KVirtualMachine = 7,

            /// <summary>
            /// Enum KNetwork for value: kNetwork
            /// </summary>
            [EnumMember(Value = "kNetwork")]
            KNetwork = 8,

            /// <summary>
            /// Enum KDatastore for value: kDatastore
            /// </summary>
            [EnumMember(Value = "kDatastore")]
            KDatastore = 9,

            /// <summary>
            /// Enum KTag for value: kTag
            /// </summary>
            [EnumMember(Value = "kTag")]
            KTag = 10,

            /// <summary>
            /// Enum KCustomProperty for value: kCustomProperty
            /// </summary>
            [EnumMember(Value = "kCustomProperty")]
            KCustomProperty = 11

        }

        /// <summary>
        /// Specifies the entity type if the environment is kHyperV. overrideDescription: true
        /// </summary>
        /// <value>Specifies the entity type if the environment is kHyperV. overrideDescription: true</value>
        [DataMember(Name="hyperVType", EmitDefaultValue=true)]
        public HyperVTypeEnum? HyperVType { get; set; }
        /// <summary>
        /// Specifies the entity type if the environment is kKubernetes. overrideDescription: true
        /// </summary>
        /// <value>Specifies the entity type if the environment is kKubernetes. overrideDescription: true</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum KubernetesTypeEnum
        {
            /// <summary>
            /// Enum KCluster for value: kCluster
            /// </summary>
            [EnumMember(Value = "kCluster")]
            KCluster = 1,

            /// <summary>
            /// Enum KNamespace for value: kNamespace
            /// </summary>
            [EnumMember(Value = "kNamespace")]
            KNamespace = 2,

            /// <summary>
            /// Enum KService for value: kService
            /// </summary>
            [EnumMember(Value = "kService")]
            KService = 3

        }

        /// <summary>
        /// Specifies the entity type if the environment is kKubernetes. overrideDescription: true
        /// </summary>
        /// <value>Specifies the entity type if the environment is kKubernetes. overrideDescription: true</value>
        [DataMember(Name="kubernetesType", EmitDefaultValue=true)]
        public KubernetesTypeEnum? KubernetesType { get; set; }
        /// <summary>
        /// Specifies the entity type if the environment is kKVM. overrideDescription: true
        /// </summary>
        /// <value>Specifies the entity type if the environment is kKVM. overrideDescription: true</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum KvmTypeEnum
        {
            /// <summary>
            /// Enum KOVirtManager for value: kOVirtManager
            /// </summary>
            [EnumMember(Value = "kOVirtManager")]
            KOVirtManager = 1,

            /// <summary>
            /// Enum KStandaloneHost for value: kStandaloneHost
            /// </summary>
            [EnumMember(Value = "kStandaloneHost")]
            KStandaloneHost = 2,

            /// <summary>
            /// Enum KDatacenter for value: kDatacenter
            /// </summary>
            [EnumMember(Value = "kDatacenter")]
            KDatacenter = 3,

            /// <summary>
            /// Enum KCluster for value: kCluster
            /// </summary>
            [EnumMember(Value = "kCluster")]
            KCluster = 4,

            /// <summary>
            /// Enum KHost for value: kHost
            /// </summary>
            [EnumMember(Value = "kHost")]
            KHost = 5,

            /// <summary>
            /// Enum KVirtualMachine for value: kVirtualMachine
            /// </summary>
            [EnumMember(Value = "kVirtualMachine")]
            KVirtualMachine = 6,

            /// <summary>
            /// Enum KNetwork for value: kNetwork
            /// </summary>
            [EnumMember(Value = "kNetwork")]
            KNetwork = 7,

            /// <summary>
            /// Enum KStorageDomain for value: kStorageDomain
            /// </summary>
            [EnumMember(Value = "kStorageDomain")]
            KStorageDomain = 8,

            /// <summary>
            /// Enum KVNicProfile for value: kVNicProfile
            /// </summary>
            [EnumMember(Value = "kVNicProfile")]
            KVNicProfile = 9

        }

        /// <summary>
        /// Specifies the entity type if the environment is kKVM. overrideDescription: true
        /// </summary>
        /// <value>Specifies the entity type if the environment is kKVM. overrideDescription: true</value>
        [DataMember(Name="kvmType", EmitDefaultValue=true)]
        public KvmTypeEnum? KvmType { get; set; }
        /// <summary>
        /// Specifies the entity type such as &#39;kCluster,&#39; if the environment is kNetapp.
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kCluster,&#39; if the environment is kNetapp.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NetappTypeEnum
        {
            /// <summary>
            /// Enum KCluster for value: kCluster
            /// </summary>
            [EnumMember(Value = "kCluster")]
            KCluster = 1,

            /// <summary>
            /// Enum KVserver for value: kVserver
            /// </summary>
            [EnumMember(Value = "kVserver")]
            KVserver = 2,

            /// <summary>
            /// Enum KVolume for value: kVolume
            /// </summary>
            [EnumMember(Value = "kVolume")]
            KVolume = 3

        }

        /// <summary>
        /// Specifies the entity type such as &#39;kCluster,&#39; if the environment is kNetapp.
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kCluster,&#39; if the environment is kNetapp.</value>
        [DataMember(Name="netappType", EmitDefaultValue=true)]
        public NetappTypeEnum? NetappType { get; set; }
        /// <summary>
        /// Specifies the entity type such as &#39;kStorageArray&#39; if the environment is kNimble. overrideDescription: true
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kStorageArray&#39; if the environment is kNimble. overrideDescription: true</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NimbleTypeEnum
        {
            /// <summary>
            /// Enum KStorageArray for value: kStorageArray
            /// </summary>
            [EnumMember(Value = "kStorageArray")]
            KStorageArray = 1,

            /// <summary>
            /// Enum KVolume for value: kVolume
            /// </summary>
            [EnumMember(Value = "kVolume")]
            KVolume = 2

        }

        /// <summary>
        /// Specifies the entity type such as &#39;kStorageArray&#39; if the environment is kNimble. overrideDescription: true
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kStorageArray&#39; if the environment is kNimble. overrideDescription: true</value>
        [DataMember(Name="nimbleType", EmitDefaultValue=true)]
        public NimbleTypeEnum? NimbleType { get; set; }
        /// <summary>
        /// Specifies the entity type such as &#39;kDomain&#39;, &#39;kOutlook&#39;, &#39;kMailbox&#39;, if the environment is kO365.
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kDomain&#39;, &#39;kOutlook&#39;, &#39;kMailbox&#39;, if the environment is kO365.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum Office365TypeEnum
        {
            /// <summary>
            /// Enum KDomain for value: kDomain
            /// </summary>
            [EnumMember(Value = "kDomain")]
            KDomain = 1,

            /// <summary>
            /// Enum KOutlook for value: kOutlook
            /// </summary>
            [EnumMember(Value = "kOutlook")]
            KOutlook = 2,

            /// <summary>
            /// Enum KMailbox for value: kMailbox
            /// </summary>
            [EnumMember(Value = "kMailbox")]
            KMailbox = 3

        }

        /// <summary>
        /// Specifies the entity type such as &#39;kDomain&#39;, &#39;kOutlook&#39;, &#39;kMailbox&#39;, if the environment is kO365.
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kDomain&#39;, &#39;kOutlook&#39;, &#39;kMailbox&#39;, if the environment is kO365.</value>
        [DataMember(Name="office365Type", EmitDefaultValue=true)]
        public Office365TypeEnum? Office365Type { get; set; }
        /// <summary>
        /// Specifies the entity type such as &#39;kPhysicalHost&#39; if the environment is kPhysical. overrideDescription: true
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kPhysicalHost&#39; if the environment is kPhysical. overrideDescription: true</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PhysicalTypeEnum
        {
            /// <summary>
            /// Enum KGroup for value: kGroup
            /// </summary>
            [EnumMember(Value = "kGroup")]
            KGroup = 1,

            /// <summary>
            /// Enum KHost for value: kHost
            /// </summary>
            [EnumMember(Value = "kHost")]
            KHost = 2,

            /// <summary>
            /// Enum KWindowsCluster for value: kWindowsCluster
            /// </summary>
            [EnumMember(Value = "kWindowsCluster")]
            KWindowsCluster = 3,

            /// <summary>
            /// Enum KOracleRACCluster for value: kOracleRACCluster
            /// </summary>
            [EnumMember(Value = "kOracleRACCluster")]
            KOracleRACCluster = 4,

            /// <summary>
            /// Enum KOracleAPCluster for value: kOracleAPCluster
            /// </summary>
            [EnumMember(Value = "kOracleAPCluster")]
            KOracleAPCluster = 5

        }

        /// <summary>
        /// Specifies the entity type such as &#39;kPhysicalHost&#39; if the environment is kPhysical. overrideDescription: true
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kPhysicalHost&#39; if the environment is kPhysical. overrideDescription: true</value>
        [DataMember(Name="physicalType", EmitDefaultValue=true)]
        public PhysicalTypeEnum? PhysicalType { get; set; }
        /// <summary>
        /// Specifies the entity type such as &#39;kStorageArray&#39; if the environment is kPure. overrideDescription: true
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kStorageArray&#39; if the environment is kPure. overrideDescription: true</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PureTypeEnum
        {
            /// <summary>
            /// Enum KStorageArray for value: kStorageArray
            /// </summary>
            [EnumMember(Value = "kStorageArray")]
            KStorageArray = 1,

            /// <summary>
            /// Enum KVolume for value: kVolume
            /// </summary>
            [EnumMember(Value = "kVolume")]
            KVolume = 2

        }

        /// <summary>
        /// Specifies the entity type such as &#39;kStorageArray&#39; if the environment is kPure. overrideDescription: true
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kStorageArray&#39; if the environment is kPure. overrideDescription: true</value>
        [DataMember(Name="pureType", EmitDefaultValue=true)]
        public PureTypeEnum? PureType { get; set; }
        /// <summary>
        /// Specifies the entity type such as &#39;kVCenter&#39; if the environment is kKMware. overrideDescription: true
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kVCenter&#39; if the environment is kKMware. overrideDescription: true</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VmwareTypeEnum
        {
            /// <summary>
            /// Enum KVCenter for value: kVCenter
            /// </summary>
            [EnumMember(Value = "kVCenter")]
            KVCenter = 1,

            /// <summary>
            /// Enum KFolder for value: kFolder
            /// </summary>
            [EnumMember(Value = "kFolder")]
            KFolder = 2,

            /// <summary>
            /// Enum KDatacenter for value: kDatacenter
            /// </summary>
            [EnumMember(Value = "kDatacenter")]
            KDatacenter = 3,

            /// <summary>
            /// Enum KComputeResource for value: kComputeResource
            /// </summary>
            [EnumMember(Value = "kComputeResource")]
            KComputeResource = 4,

            /// <summary>
            /// Enum KClusterComputeResource for value: kClusterComputeResource
            /// </summary>
            [EnumMember(Value = "kClusterComputeResource")]
            KClusterComputeResource = 5,

            /// <summary>
            /// Enum KResourcePool for value: kResourcePool
            /// </summary>
            [EnumMember(Value = "kResourcePool")]
            KResourcePool = 6,

            /// <summary>
            /// Enum KDatastore for value: kDatastore
            /// </summary>
            [EnumMember(Value = "kDatastore")]
            KDatastore = 7,

            /// <summary>
            /// Enum KHostSystem for value: kHostSystem
            /// </summary>
            [EnumMember(Value = "kHostSystem")]
            KHostSystem = 8,

            /// <summary>
            /// Enum KVirtualMachine for value: kVirtualMachine
            /// </summary>
            [EnumMember(Value = "kVirtualMachine")]
            KVirtualMachine = 9,

            /// <summary>
            /// Enum KVirtualApp for value: kVirtualApp
            /// </summary>
            [EnumMember(Value = "kVirtualApp")]
            KVirtualApp = 10,

            /// <summary>
            /// Enum KStandaloneHost for value: kStandaloneHost
            /// </summary>
            [EnumMember(Value = "kStandaloneHost")]
            KStandaloneHost = 11,

            /// <summary>
            /// Enum KStoragePod for value: kStoragePod
            /// </summary>
            [EnumMember(Value = "kStoragePod")]
            KStoragePod = 12,

            /// <summary>
            /// Enum KNetwork for value: kNetwork
            /// </summary>
            [EnumMember(Value = "kNetwork")]
            KNetwork = 13,

            /// <summary>
            /// Enum KDistributedVirtualPortgroup for value: kDistributedVirtualPortgroup
            /// </summary>
            [EnumMember(Value = "kDistributedVirtualPortgroup")]
            KDistributedVirtualPortgroup = 14,

            /// <summary>
            /// Enum KTagCategory for value: kTagCategory
            /// </summary>
            [EnumMember(Value = "kTagCategory")]
            KTagCategory = 15,

            /// <summary>
            /// Enum KTag for value: kTag
            /// </summary>
            [EnumMember(Value = "kTag")]
            KTag = 16,

            /// <summary>
            /// Enum KOpaqueNetwork for value: kOpaqueNetwork
            /// </summary>
            [EnumMember(Value = "kOpaqueNetwork")]
            KOpaqueNetwork = 17,

            /// <summary>
            /// Enum KvCloudDirector for value: kvCloudDirector
            /// </summary>
            [EnumMember(Value = "kvCloudDirector")]
            KvCloudDirector = 18,

            /// <summary>
            /// Enum KOrganization for value: kOrganization
            /// </summary>
            [EnumMember(Value = "kOrganization")]
            KOrganization = 19,

            /// <summary>
            /// Enum KVirtualDatacenter for value: kVirtualDatacenter
            /// </summary>
            [EnumMember(Value = "kVirtualDatacenter")]
            KVirtualDatacenter = 20,

            /// <summary>
            /// Enum KCatalog for value: kCatalog
            /// </summary>
            [EnumMember(Value = "kCatalog")]
            KCatalog = 21,

            /// <summary>
            /// Enum KOrgMetadata for value: kOrgMetadata
            /// </summary>
            [EnumMember(Value = "kOrgMetadata")]
            KOrgMetadata = 22,

            /// <summary>
            /// Enum KStoragePolicy for value: kStoragePolicy
            /// </summary>
            [EnumMember(Value = "kStoragePolicy")]
            KStoragePolicy = 23

        }

        /// <summary>
        /// Specifies the entity type such as &#39;kVCenter&#39; if the environment is kKMware. overrideDescription: true
        /// </summary>
        /// <value>Specifies the entity type such as &#39;kVCenter&#39; if the environment is kKMware. overrideDescription: true</value>
        [DataMember(Name="vmwareType", EmitDefaultValue=true)]
        public VmwareTypeEnum? VmwareType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterProtectionSourceParameters" /> class.
        /// </summary>
        /// <param name="isStorageArraySnapshotEnabled">Specifies if this source entity has enabled storage array snapshot or not..</param>
        /// <param name="acropolisType">Specifies the entity type if the environment is kAcropolis. overrideDescription: true.</param>
        /// <param name="agentEndpoint">Specifies the agent endpoint if it is different from the source endpoint..</param>
        /// <param name="allowedIpAddresses">Specifies the list of IP Addresses on the registered source to be exclusively allowed for doing any type of IO operations..</param>
        /// <param name="awsCredentials">awsCredentials.</param>
        /// <param name="awsFleetParams">awsFleetParams.</param>
        /// <param name="azureCredentials">azureCredentials.</param>
        /// <param name="blacklistedIpAddresses">This field is deprecated. Use DeniedIpAddresses instead. deprecated: true.</param>
        /// <param name="clusterNetworkInfo">clusterNetworkInfo.</param>
        /// <param name="deniedIpAddresses">Specifies the list of IP Addresses on the registered source to be denied for doing any type of IO operations..</param>
        /// <param name="encryptionKey">If set, user has encrypted the credential with &#39;user_ecryption_key&#39;. It is assumed that credentials are first encrypted using internal magento key and then encrypted using user encryption key..</param>
        /// <param name="endpoint">Specifies the network endpoint of the Protection Source where it is reachable. It could be an URL or hostname or an IP address of the Protection Source..</param>
        /// <param name="environment">Specifies the environment such as &#39;kPhysical&#39; or &#39;kVMware&#39; of the Protection Source. overrideDescription: true Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;kNimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Generic Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhysicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment. &#39;kAD&#39; indicates Active Directory Protection Source environment. &#39;kRDSSnapshotManager&#39; indicates AWS RDS Protection Source environment. &#39;kCassandra&#39; indicates Cassandra Protection Source environment. &#39;kMongoDB&#39; indicates MongoDB Protection Source environment. &#39;kCouchbase&#39; indicates Couchbase Protection Source environment. &#39;kHdfs&#39; indicates Hdfs Protection Source environment. &#39;kHive&#39; indicates Hive Protection Source environment. &#39;kHBase&#39; indicates HBase Protection Source environment. &#39;kUDA&#39; indicates Universal Data Adapter Protection Source environment. &#39;kO365Teams&#39; indicates the Office365 Teams Protection Source environment. &#39;kO365Group&#39; indicates the Office365 Groups Protection Source environment. &#39;kO365Exchange&#39; indicates the Office365 Mailbox Protection Source environment. &#39;kO365OneDrive&#39; indicates the Office365 OneDrive Protection Source environment. &#39;kO365Sharepoint&#39; indicates the Office365 SharePoint Protection Source environment. &#39;kO365PublicFolders&#39; indicates the Office365 PublicFolders Protection Source environment..</param>
        /// <param name="exchangeDagProtectionPreference">exchangeDagProtectionPreference.</param>
        /// <param name="forceRegister">ForceRegister is applicable to Physical Environment. By default, the agent running on a physical host will fail the registration, if it is already registered as part of another cluster. By setting this option to true, agent can be forced to register with the current cluster. This is a hidden parameter and should not be documented externally..</param>
        /// <param name="gcpCredentials">gcpCredentials.</param>
        /// <param name="hostType">Specifies the optional OS type of the Protection Source (such as kWindows or kLinux). overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kSapOracle&#39; indicates the Sap Oracle database system developed by SAP SE. &#39;kCockroachDB&#39; indicates the CockroachDB database system. &#39;kMySQL&#39; indicates the MySQL database system. &#39;kOther&#39; indicates the other types of operating system..</param>
        /// <param name="hyperVType">Specifies the entity type if the environment is kHyperV. overrideDescription: true.</param>
        /// <param name="isInternalEncrypted">Set to true if credentials are encrypted by internal magneto key..</param>
        /// <param name="isProxyHost">Specifies if the physical host has to be registered as a proxy host..</param>
        /// <param name="isilonParams">isilonParams.</param>
        /// <param name="kubernetesCredentials">kubernetesCredentials.</param>
        /// <param name="kubernetesParams">kubernetesParams.</param>
        /// <param name="kubernetesType">Specifies the entity type if the environment is kKubernetes. overrideDescription: true.</param>
        /// <param name="kvmType">Specifies the entity type if the environment is kKVM. overrideDescription: true.</param>
        /// <param name="nasMountCredentials">Specifies the server credentials to connect to a NetApp server. This field is required for mounting SMB volumes on NetApp servers..</param>
        /// <param name="netappType">Specifies the entity type such as &#39;kCluster,&#39; if the environment is kNetapp..</param>
        /// <param name="nimbleType">Specifies the entity type such as &#39;kStorageArray&#39; if the environment is kNimble. overrideDescription: true.</param>
        /// <param name="office365CredentialsList">Office365 Source Credentials.  Specifies credentials needed to authenticate &amp; authorize user for Office365 using MS Graph APIs..</param>
        /// <param name="office365Region">Specifies the region for Office365..</param>
        /// <param name="office365ServiceAccountCredentialsList">Office365 Service Account Credentials.  Specifies credentials for improving mailbox backup performance for O365..</param>
        /// <param name="office365Type">Specifies the entity type such as &#39;kDomain&#39;, &#39;kOutlook&#39;, &#39;kMailbox&#39;, if the environment is kO365..</param>
        /// <param name="password">Specifies password of the username to access the target source..</param>
        /// <param name="physicalParams">physicalParams.</param>
        /// <param name="physicalType">Specifies the entity type such as &#39;kPhysicalHost&#39; if the environment is kPhysical. overrideDescription: true.</param>
        /// <param name="proxyHostSourceIdList">Specifies the list of the protection source id of the windows physical host which will be used during the protection and recovery of the sites that belong to a office365 domain..</param>
        /// <param name="pureType">Specifies the entity type such as &#39;kStorageArray&#39; if the environment is kPure. overrideDescription: true.</param>
        /// <param name="sourceSideDedupEnabled">This controls whether to use source side dedup on the source or not. This is only applicable to sources which support source side dedup (e.g., Linux physical servers)..</param>
        /// <param name="sslVerification">sslVerification.</param>
        /// <param name="subnets">Specifies the list of subnet IP addresses and CIDR prefix for enabeling network data transfer. Currently, only Subnet IP and NetbaskBits are valid input fields. All other fields provided as input will be ignored..</param>
        /// <param name="throttlingPolicy">Specifies the throttling policy that should be applied to this Source..</param>
        /// <param name="throttlingPolicyOverrides">Array of Throttling Policy Overrides for Datastores.  Specifies a list of Throttling Policy for datastores that override the common throttling policy specified for the registered Protection Source. For datastores not in this list, common policy will still apply..</param>
        /// <param name="useExistingCredentials">Specifies whether to use existing Office365 credentials like password and client secret for app id&#39;s..</param>
        /// <param name="useOAuthForExchangeOnline">Specifies whether OAuth should be used for authentication in case of Exchange Online..</param>
        /// <param name="username">Specifies username to access the target source..</param>
        /// <param name="vlanParams">vlanParams.</param>
        /// <param name="vmwareParams">vmwareParams.</param>
        /// <param name="vmwareType">Specifies the entity type such as &#39;kVCenter&#39; if the environment is kKMware. overrideDescription: true.</param>
        public RegisterProtectionSourceParameters(bool? isStorageArraySnapshotEnabled = default(bool?), AcropolisTypeEnum? acropolisType = default(AcropolisTypeEnum?), string agentEndpoint = default(string), List<string> allowedIpAddresses = default(List<string>), AwsCredentials awsCredentials = default(AwsCredentials), AwsFleetParams awsFleetParams = default(AwsFleetParams), AzureCredentials azureCredentials = default(AzureCredentials), List<string> blacklistedIpAddresses = default(List<string>), FleetNetworkParams clusterNetworkInfo = default(FleetNetworkParams), List<string> deniedIpAddresses = default(List<string>), string encryptionKey = default(string), string endpoint = default(string), EnvironmentEnum? environment = default(EnvironmentEnum?), ExchangeDAGProtectionPreference exchangeDagProtectionPreference = default(ExchangeDAGProtectionPreference), bool? forceRegister = default(bool?), GcpCredentials gcpCredentials = default(GcpCredentials), HostTypeEnum? hostType = default(HostTypeEnum?), HyperVTypeEnum? hyperVType = default(HyperVTypeEnum?), bool? isInternalEncrypted = default(bool?), bool? isProxyHost = default(bool?), RegisteredProtectionSourceIsilonParams isilonParams = default(RegisteredProtectionSourceIsilonParams), KubernetesCredentials kubernetesCredentials = default(KubernetesCredentials), KubernetesParams kubernetesParams = default(KubernetesParams), KubernetesTypeEnum? kubernetesType = default(KubernetesTypeEnum?), KvmTypeEnum? kvmType = default(KvmTypeEnum?), NasMountCredentialParams nasMountCredentials = default(NasMountCredentialParams), NetappTypeEnum? netappType = default(NetappTypeEnum?), NimbleTypeEnum? nimbleType = default(NimbleTypeEnum?), List<Office365Credentials> office365CredentialsList = default(List<Office365Credentials>), string office365Region = default(string), List<Credentials> office365ServiceAccountCredentialsList = default(List<Credentials>), Office365TypeEnum? office365Type = default(Office365TypeEnum?), string password = default(string), PhysicalParams physicalParams = default(PhysicalParams), PhysicalTypeEnum? physicalType = default(PhysicalTypeEnum?), List<long> proxyHostSourceIdList = default(List<long>), PureTypeEnum? pureType = default(PureTypeEnum?), bool? sourceSideDedupEnabled = default(bool?), SslVerification sslVerification = default(SslVerification), List<Subnet> subnets = default(List<Subnet>), ThrottlingPolicyParameters throttlingPolicy = default(ThrottlingPolicyParameters), List<ThrottlingPolicyOverride> throttlingPolicyOverrides = default(List<ThrottlingPolicyOverride>), bool? useExistingCredentials = default(bool?), bool? useOAuthForExchangeOnline = default(bool?), string username = default(string), VlanParameters vlanParams = default(VlanParameters), VmwareParams vmwareParams = default(VmwareParams), VmwareTypeEnum? vmwareType = default(VmwareTypeEnum?))
        {
            this.IsStorageArraySnapshotEnabled = isStorageArraySnapshotEnabled;
            this.AcropolisType = acropolisType;
            this.AgentEndpoint = agentEndpoint;
            this.AllowedIpAddresses = allowedIpAddresses;
            this.BlacklistedIpAddresses = blacklistedIpAddresses;
            this.DeniedIpAddresses = deniedIpAddresses;
            this.EncryptionKey = encryptionKey;
            this.Endpoint = endpoint;
            this.Environment = environment;
            this.ForceRegister = forceRegister;
            this.HostType = hostType;
            this.HyperVType = hyperVType;
            this.IsInternalEncrypted = isInternalEncrypted;
            this.IsProxyHost = isProxyHost;
            this.KubernetesType = kubernetesType;
            this.KvmType = kvmType;
            this.NasMountCredentials = nasMountCredentials;
            this.NetappType = netappType;
            this.NimbleType = nimbleType;
            this.Office365CredentialsList = office365CredentialsList;
            this.Office365Region = office365Region;
            this.Office365ServiceAccountCredentialsList = office365ServiceAccountCredentialsList;
            this.Office365Type = office365Type;
            this.Password = password;
            this.PhysicalType = physicalType;
            this.ProxyHostSourceIdList = proxyHostSourceIdList;
            this.PureType = pureType;
            this.SourceSideDedupEnabled = sourceSideDedupEnabled;
            this.Subnets = subnets;
            this.ThrottlingPolicy = throttlingPolicy;
            this.ThrottlingPolicyOverrides = throttlingPolicyOverrides;
            this.UseExistingCredentials = useExistingCredentials;
            this.UseOAuthForExchangeOnline = useOAuthForExchangeOnline;
            this.Username = username;
            this.VmwareType = vmwareType;
            this.IsStorageArraySnapshotEnabled = isStorageArraySnapshotEnabled;
            this.AcropolisType = acropolisType;
            this.AgentEndpoint = agentEndpoint;
            this.AllowedIpAddresses = allowedIpAddresses;
            this.AwsCredentials = awsCredentials;
            this.AwsFleetParams = awsFleetParams;
            this.AzureCredentials = azureCredentials;
            this.BlacklistedIpAddresses = blacklistedIpAddresses;
            this.ClusterNetworkInfo = clusterNetworkInfo;
            this.DeniedIpAddresses = deniedIpAddresses;
            this.EncryptionKey = encryptionKey;
            this.Endpoint = endpoint;
            this.Environment = environment;
            this.ExchangeDagProtectionPreference = exchangeDagProtectionPreference;
            this.ForceRegister = forceRegister;
            this.GcpCredentials = gcpCredentials;
            this.HostType = hostType;
            this.HyperVType = hyperVType;
            this.IsInternalEncrypted = isInternalEncrypted;
            this.IsProxyHost = isProxyHost;
            this.IsilonParams = isilonParams;
            this.KubernetesCredentials = kubernetesCredentials;
            this.KubernetesParams = kubernetesParams;
            this.KubernetesType = kubernetesType;
            this.KvmType = kvmType;
            this.NasMountCredentials = nasMountCredentials;
            this.NetappType = netappType;
            this.NimbleType = nimbleType;
            this.Office365CredentialsList = office365CredentialsList;
            this.Office365Region = office365Region;
            this.Office365ServiceAccountCredentialsList = office365ServiceAccountCredentialsList;
            this.Office365Type = office365Type;
            this.Password = password;
            this.PhysicalParams = physicalParams;
            this.PhysicalType = physicalType;
            this.ProxyHostSourceIdList = proxyHostSourceIdList;
            this.PureType = pureType;
            this.SourceSideDedupEnabled = sourceSideDedupEnabled;
            this.SslVerification = sslVerification;
            this.Subnets = subnets;
            this.ThrottlingPolicy = throttlingPolicy;
            this.ThrottlingPolicyOverrides = throttlingPolicyOverrides;
            this.UseExistingCredentials = useExistingCredentials;
            this.UseOAuthForExchangeOnline = useOAuthForExchangeOnline;
            this.Username = username;
            this.VlanParams = vlanParams;
            this.VmwareParams = vmwareParams;
            this.VmwareType = vmwareType;
        }
        
        /// <summary>
        /// Specifies if this source entity has enabled storage array snapshot or not.
        /// </summary>
        /// <value>Specifies if this source entity has enabled storage array snapshot or not.</value>
        [DataMember(Name="IsStorageArraySnapshotEnabled", EmitDefaultValue=true)]
        public bool? IsStorageArraySnapshotEnabled { get; set; }

        /// <summary>
        /// Specifies the agent endpoint if it is different from the source endpoint.
        /// </summary>
        /// <value>Specifies the agent endpoint if it is different from the source endpoint.</value>
        [DataMember(Name="agentEndpoint", EmitDefaultValue=true)]
        public string AgentEndpoint { get; set; }

        /// <summary>
        /// Specifies the list of IP Addresses on the registered source to be exclusively allowed for doing any type of IO operations.
        /// </summary>
        /// <value>Specifies the list of IP Addresses on the registered source to be exclusively allowed for doing any type of IO operations.</value>
        [DataMember(Name="allowedIpAddresses", EmitDefaultValue=true)]
        public List<string> AllowedIpAddresses { get; set; }

        /// <summary>
        /// Gets or Sets AwsCredentials
        /// </summary>
        [DataMember(Name="awsCredentials", EmitDefaultValue=false)]
        public AwsCredentials AwsCredentials { get; set; }

        /// <summary>
        /// Gets or Sets AwsFleetParams
        /// </summary>
        [DataMember(Name="awsFleetParams", EmitDefaultValue=false)]
        public AwsFleetParams AwsFleetParams { get; set; }

        /// <summary>
        /// Gets or Sets AzureCredentials
        /// </summary>
        [DataMember(Name="azureCredentials", EmitDefaultValue=false)]
        public AzureCredentials AzureCredentials { get; set; }

        /// <summary>
        /// This field is deprecated. Use DeniedIpAddresses instead. deprecated: true
        /// </summary>
        /// <value>This field is deprecated. Use DeniedIpAddresses instead. deprecated: true</value>
        [DataMember(Name="blacklistedIpAddresses", EmitDefaultValue=true)]
        public List<string> BlacklistedIpAddresses { get; set; }

        /// <summary>
        /// Gets or Sets ClusterNetworkInfo
        /// </summary>
        [DataMember(Name="clusterNetworkInfo", EmitDefaultValue=false)]
        public FleetNetworkParams ClusterNetworkInfo { get; set; }

        /// <summary>
        /// Specifies the list of IP Addresses on the registered source to be denied for doing any type of IO operations.
        /// </summary>
        /// <value>Specifies the list of IP Addresses on the registered source to be denied for doing any type of IO operations.</value>
        [DataMember(Name="deniedIpAddresses", EmitDefaultValue=true)]
        public List<string> DeniedIpAddresses { get; set; }

        /// <summary>
        /// If set, user has encrypted the credential with &#39;user_ecryption_key&#39;. It is assumed that credentials are first encrypted using internal magento key and then encrypted using user encryption key.
        /// </summary>
        /// <value>If set, user has encrypted the credential with &#39;user_ecryption_key&#39;. It is assumed that credentials are first encrypted using internal magento key and then encrypted using user encryption key.</value>
        [DataMember(Name="encryptionKey", EmitDefaultValue=true)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// Specifies the network endpoint of the Protection Source where it is reachable. It could be an URL or hostname or an IP address of the Protection Source.
        /// </summary>
        /// <value>Specifies the network endpoint of the Protection Source where it is reachable. It could be an URL or hostname or an IP address of the Protection Source.</value>
        [DataMember(Name="endpoint", EmitDefaultValue=true)]
        public string Endpoint { get; set; }

        /// <summary>
        /// Gets or Sets ExchangeDagProtectionPreference
        /// </summary>
        [DataMember(Name="exchangeDagProtectionPreference", EmitDefaultValue=false)]
        public ExchangeDAGProtectionPreference ExchangeDagProtectionPreference { get; set; }

        /// <summary>
        /// ForceRegister is applicable to Physical Environment. By default, the agent running on a physical host will fail the registration, if it is already registered as part of another cluster. By setting this option to true, agent can be forced to register with the current cluster. This is a hidden parameter and should not be documented externally.
        /// </summary>
        /// <value>ForceRegister is applicable to Physical Environment. By default, the agent running on a physical host will fail the registration, if it is already registered as part of another cluster. By setting this option to true, agent can be forced to register with the current cluster. This is a hidden parameter and should not be documented externally.</value>
        [DataMember(Name="forceRegister", EmitDefaultValue=true)]
        public bool? ForceRegister { get; set; }

        /// <summary>
        /// Gets or Sets GcpCredentials
        /// </summary>
        [DataMember(Name="gcpCredentials", EmitDefaultValue=false)]
        public GcpCredentials GcpCredentials { get; set; }

        /// <summary>
        /// Set to true if credentials are encrypted by internal magneto key.
        /// </summary>
        /// <value>Set to true if credentials are encrypted by internal magneto key.</value>
        [DataMember(Name="isInternalEncrypted", EmitDefaultValue=true)]
        public bool? IsInternalEncrypted { get; set; }

        /// <summary>
        /// Specifies if the physical host has to be registered as a proxy host.
        /// </summary>
        /// <value>Specifies if the physical host has to be registered as a proxy host.</value>
        [DataMember(Name="isProxyHost", EmitDefaultValue=true)]
        public bool? IsProxyHost { get; set; }

        /// <summary>
        /// Gets or Sets IsilonParams
        /// </summary>
        [DataMember(Name="isilonParams", EmitDefaultValue=false)]
        public RegisteredProtectionSourceIsilonParams IsilonParams { get; set; }

        /// <summary>
        /// Gets or Sets KubernetesCredentials
        /// </summary>
        [DataMember(Name="kubernetesCredentials", EmitDefaultValue=false)]
        public KubernetesCredentials KubernetesCredentials { get; set; }

        /// <summary>
        /// Gets or Sets KubernetesParams
        /// </summary>
        [DataMember(Name="kubernetesParams", EmitDefaultValue=false)]
        public KubernetesParams KubernetesParams { get; set; }

        /// <summary>
        /// Specifies the server credentials to connect to a NetApp server. This field is required for mounting SMB volumes on NetApp servers.
        /// </summary>
        /// <value>Specifies the server credentials to connect to a NetApp server. This field is required for mounting SMB volumes on NetApp servers.</value>
        [DataMember(Name="nasMountCredentials", EmitDefaultValue=true)]
        public NasMountCredentialParams NasMountCredentials { get; set; }

        /// <summary>
        /// Office365 Source Credentials.  Specifies credentials needed to authenticate &amp; authorize user for Office365 using MS Graph APIs.
        /// </summary>
        /// <value>Office365 Source Credentials.  Specifies credentials needed to authenticate &amp; authorize user for Office365 using MS Graph APIs.</value>
        [DataMember(Name="office365CredentialsList", EmitDefaultValue=true)]
        public List<Office365Credentials> Office365CredentialsList { get; set; }

        /// <summary>
        /// Specifies the region for Office365.
        /// </summary>
        /// <value>Specifies the region for Office365.</value>
        [DataMember(Name="office365Region", EmitDefaultValue=true)]
        public string Office365Region { get; set; }

        /// <summary>
        /// Office365 Service Account Credentials.  Specifies credentials for improving mailbox backup performance for O365.
        /// </summary>
        /// <value>Office365 Service Account Credentials.  Specifies credentials for improving mailbox backup performance for O365.</value>
        [DataMember(Name="office365ServiceAccountCredentialsList", EmitDefaultValue=true)]
        public List<Credentials> Office365ServiceAccountCredentialsList { get; set; }

        /// <summary>
        /// Specifies password of the username to access the target source.
        /// </summary>
        /// <value>Specifies password of the username to access the target source.</value>
        [DataMember(Name="password", EmitDefaultValue=true)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets PhysicalParams
        /// </summary>
        [DataMember(Name="physicalParams", EmitDefaultValue=false)]
        public PhysicalParams PhysicalParams { get; set; }

        /// <summary>
        /// Specifies the list of the protection source id of the windows physical host which will be used during the protection and recovery of the sites that belong to a office365 domain.
        /// </summary>
        /// <value>Specifies the list of the protection source id of the windows physical host which will be used during the protection and recovery of the sites that belong to a office365 domain.</value>
        [DataMember(Name="proxyHostSourceIdList", EmitDefaultValue=true)]
        public List<long> ProxyHostSourceIdList { get; set; }

        /// <summary>
        /// This controls whether to use source side dedup on the source or not. This is only applicable to sources which support source side dedup (e.g., Linux physical servers).
        /// </summary>
        /// <value>This controls whether to use source side dedup on the source or not. This is only applicable to sources which support source side dedup (e.g., Linux physical servers).</value>
        [DataMember(Name="sourceSideDedupEnabled", EmitDefaultValue=true)]
        public bool? SourceSideDedupEnabled { get; set; }

        /// <summary>
        /// Gets or Sets SslVerification
        /// </summary>
        [DataMember(Name="sslVerification", EmitDefaultValue=false)]
        public SslVerification SslVerification { get; set; }

        /// <summary>
        /// Specifies the list of subnet IP addresses and CIDR prefix for enabeling network data transfer. Currently, only Subnet IP and NetbaskBits are valid input fields. All other fields provided as input will be ignored.
        /// </summary>
        /// <value>Specifies the list of subnet IP addresses and CIDR prefix for enabeling network data transfer. Currently, only Subnet IP and NetbaskBits are valid input fields. All other fields provided as input will be ignored.</value>
        [DataMember(Name="subnets", EmitDefaultValue=true)]
        public List<Subnet> Subnets { get; set; }

        /// <summary>
        /// Specifies the throttling policy that should be applied to this Source.
        /// </summary>
        /// <value>Specifies the throttling policy that should be applied to this Source.</value>
        [DataMember(Name="throttlingPolicy", EmitDefaultValue=true)]
        public ThrottlingPolicyParameters ThrottlingPolicy { get; set; }

        /// <summary>
        /// Array of Throttling Policy Overrides for Datastores.  Specifies a list of Throttling Policy for datastores that override the common throttling policy specified for the registered Protection Source. For datastores not in this list, common policy will still apply.
        /// </summary>
        /// <value>Array of Throttling Policy Overrides for Datastores.  Specifies a list of Throttling Policy for datastores that override the common throttling policy specified for the registered Protection Source. For datastores not in this list, common policy will still apply.</value>
        [DataMember(Name="throttlingPolicyOverrides", EmitDefaultValue=true)]
        public List<ThrottlingPolicyOverride> ThrottlingPolicyOverrides { get; set; }

        /// <summary>
        /// Specifies whether to use existing Office365 credentials like password and client secret for app id&#39;s.
        /// </summary>
        /// <value>Specifies whether to use existing Office365 credentials like password and client secret for app id&#39;s.</value>
        [DataMember(Name="useExistingCredentials", EmitDefaultValue=true)]
        public bool? UseExistingCredentials { get; set; }

        /// <summary>
        /// Specifies whether OAuth should be used for authentication in case of Exchange Online.
        /// </summary>
        /// <value>Specifies whether OAuth should be used for authentication in case of Exchange Online.</value>
        [DataMember(Name="useOAuthForExchangeOnline", EmitDefaultValue=true)]
        public bool? UseOAuthForExchangeOnline { get; set; }

        /// <summary>
        /// Specifies username to access the target source.
        /// </summary>
        /// <value>Specifies username to access the target source.</value>
        [DataMember(Name="username", EmitDefaultValue=true)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets VlanParams
        /// </summary>
        [DataMember(Name="vlanParams", EmitDefaultValue=false)]
        public VlanParameters VlanParams { get; set; }

        /// <summary>
        /// Gets or Sets VmwareParams
        /// </summary>
        [DataMember(Name="vmwareParams", EmitDefaultValue=false)]
        public VmwareParams VmwareParams { get; set; }

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
            return this.Equals(input as RegisterProtectionSourceParameters);
        }

        /// <summary>
        /// Returns true if RegisterProtectionSourceParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of RegisterProtectionSourceParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegisterProtectionSourceParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsStorageArraySnapshotEnabled == input.IsStorageArraySnapshotEnabled ||
                    (this.IsStorageArraySnapshotEnabled != null &&
                    this.IsStorageArraySnapshotEnabled.Equals(input.IsStorageArraySnapshotEnabled))
                ) && 
                (
                    this.AcropolisType == input.AcropolisType ||
                    this.AcropolisType.Equals(input.AcropolisType)
                ) && 
                (
                    this.AgentEndpoint == input.AgentEndpoint ||
                    (this.AgentEndpoint != null &&
                    this.AgentEndpoint.Equals(input.AgentEndpoint))
                ) && 
                (
                    this.AllowedIpAddresses == input.AllowedIpAddresses ||
                    this.AllowedIpAddresses != null &&
                    input.AllowedIpAddresses != null &&
                    this.AllowedIpAddresses.Equals(input.AllowedIpAddresses)
                ) && 
                (
                    this.AwsCredentials == input.AwsCredentials ||
                    (this.AwsCredentials != null &&
                    this.AwsCredentials.Equals(input.AwsCredentials))
                ) && 
                (
                    this.AwsFleetParams == input.AwsFleetParams ||
                    (this.AwsFleetParams != null &&
                    this.AwsFleetParams.Equals(input.AwsFleetParams))
                ) && 
                (
                    this.AzureCredentials == input.AzureCredentials ||
                    (this.AzureCredentials != null &&
                    this.AzureCredentials.Equals(input.AzureCredentials))
                ) && 
                (
                    this.BlacklistedIpAddresses == input.BlacklistedIpAddresses ||
                    this.BlacklistedIpAddresses != null &&
                    input.BlacklistedIpAddresses != null &&
                    this.BlacklistedIpAddresses.Equals(input.BlacklistedIpAddresses)
                ) && 
                (
                    this.ClusterNetworkInfo == input.ClusterNetworkInfo ||
                    (this.ClusterNetworkInfo != null &&
                    this.ClusterNetworkInfo.Equals(input.ClusterNetworkInfo))
                ) && 
                (
                    this.DeniedIpAddresses == input.DeniedIpAddresses ||
                    this.DeniedIpAddresses != null &&
                    input.DeniedIpAddresses != null &&
                    this.DeniedIpAddresses.Equals(input.DeniedIpAddresses)
                ) && 
                (
                    this.EncryptionKey == input.EncryptionKey ||
                    (this.EncryptionKey != null &&
                    this.EncryptionKey.Equals(input.EncryptionKey))
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
                    this.ExchangeDagProtectionPreference == input.ExchangeDagProtectionPreference ||
                    (this.ExchangeDagProtectionPreference != null &&
                    this.ExchangeDagProtectionPreference.Equals(input.ExchangeDagProtectionPreference))
                ) && 
                (
                    this.ForceRegister == input.ForceRegister ||
                    (this.ForceRegister != null &&
                    this.ForceRegister.Equals(input.ForceRegister))
                ) && 
                (
                    this.GcpCredentials == input.GcpCredentials ||
                    (this.GcpCredentials != null &&
                    this.GcpCredentials.Equals(input.GcpCredentials))
                ) && 
                (
                    this.HostType == input.HostType ||
                    this.HostType.Equals(input.HostType)
                ) && 
                (
                    this.HyperVType == input.HyperVType ||
                    this.HyperVType.Equals(input.HyperVType)
                ) && 
                (
                    this.IsInternalEncrypted == input.IsInternalEncrypted ||
                    (this.IsInternalEncrypted != null &&
                    this.IsInternalEncrypted.Equals(input.IsInternalEncrypted))
                ) && 
                (
                    this.IsProxyHost == input.IsProxyHost ||
                    (this.IsProxyHost != null &&
                    this.IsProxyHost.Equals(input.IsProxyHost))
                ) && 
                (
                    this.IsilonParams == input.IsilonParams ||
                    (this.IsilonParams != null &&
                    this.IsilonParams.Equals(input.IsilonParams))
                ) && 
                (
                    this.KubernetesCredentials == input.KubernetesCredentials ||
                    (this.KubernetesCredentials != null &&
                    this.KubernetesCredentials.Equals(input.KubernetesCredentials))
                ) && 
                (
                    this.KubernetesParams == input.KubernetesParams ||
                    (this.KubernetesParams != null &&
                    this.KubernetesParams.Equals(input.KubernetesParams))
                ) && 
                (
                    this.KubernetesType == input.KubernetesType ||
                    this.KubernetesType.Equals(input.KubernetesType)
                ) && 
                (
                    this.KvmType == input.KvmType ||
                    this.KvmType.Equals(input.KvmType)
                ) && 
                (
                    this.NasMountCredentials == input.NasMountCredentials ||
                    (this.NasMountCredentials != null &&
                    this.NasMountCredentials.Equals(input.NasMountCredentials))
                ) && 
                (
                    this.NetappType == input.NetappType ||
                    this.NetappType.Equals(input.NetappType)
                ) && 
                (
                    this.NimbleType == input.NimbleType ||
                    this.NimbleType.Equals(input.NimbleType)
                ) && 
                (
                    this.Office365CredentialsList == input.Office365CredentialsList ||
                    this.Office365CredentialsList != null &&
                    input.Office365CredentialsList != null &&
                    this.Office365CredentialsList.Equals(input.Office365CredentialsList)
                ) && 
                (
                    this.Office365Region == input.Office365Region ||
                    (this.Office365Region != null &&
                    this.Office365Region.Equals(input.Office365Region))
                ) && 
                (
                    this.Office365ServiceAccountCredentialsList == input.Office365ServiceAccountCredentialsList ||
                    this.Office365ServiceAccountCredentialsList != null &&
                    input.Office365ServiceAccountCredentialsList != null &&
                    this.Office365ServiceAccountCredentialsList.Equals(input.Office365ServiceAccountCredentialsList)
                ) && 
                (
                    this.Office365Type == input.Office365Type ||
                    this.Office365Type.Equals(input.Office365Type)
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.PhysicalParams == input.PhysicalParams ||
                    (this.PhysicalParams != null &&
                    this.PhysicalParams.Equals(input.PhysicalParams))
                ) && 
                (
                    this.PhysicalType == input.PhysicalType ||
                    this.PhysicalType.Equals(input.PhysicalType)
                ) && 
                (
                    this.ProxyHostSourceIdList == input.ProxyHostSourceIdList ||
                    this.ProxyHostSourceIdList != null &&
                    input.ProxyHostSourceIdList != null &&
                    this.ProxyHostSourceIdList.Equals(input.ProxyHostSourceIdList)
                ) && 
                (
                    this.PureType == input.PureType ||
                    this.PureType.Equals(input.PureType)
                ) && 
                (
                    this.SourceSideDedupEnabled == input.SourceSideDedupEnabled ||
                    (this.SourceSideDedupEnabled != null &&
                    this.SourceSideDedupEnabled.Equals(input.SourceSideDedupEnabled))
                ) && 
                (
                    this.SslVerification == input.SslVerification ||
                    (this.SslVerification != null &&
                    this.SslVerification.Equals(input.SslVerification))
                ) && 
                (
                    this.Subnets == input.Subnets ||
                    this.Subnets != null &&
                    input.Subnets != null &&
                    this.Subnets.Equals(input.Subnets)
                ) && 
                (
                    this.ThrottlingPolicy == input.ThrottlingPolicy ||
                    (this.ThrottlingPolicy != null &&
                    this.ThrottlingPolicy.Equals(input.ThrottlingPolicy))
                ) && 
                (
                    this.ThrottlingPolicyOverrides == input.ThrottlingPolicyOverrides ||
                    this.ThrottlingPolicyOverrides != null &&
                    input.ThrottlingPolicyOverrides != null &&
                    this.ThrottlingPolicyOverrides.Equals(input.ThrottlingPolicyOverrides)
                ) && 
                (
                    this.UseExistingCredentials == input.UseExistingCredentials ||
                    (this.UseExistingCredentials != null &&
                    this.UseExistingCredentials.Equals(input.UseExistingCredentials))
                ) && 
                (
                    this.UseOAuthForExchangeOnline == input.UseOAuthForExchangeOnline ||
                    (this.UseOAuthForExchangeOnline != null &&
                    this.UseOAuthForExchangeOnline.Equals(input.UseOAuthForExchangeOnline))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.VlanParams == input.VlanParams ||
                    (this.VlanParams != null &&
                    this.VlanParams.Equals(input.VlanParams))
                ) && 
                (
                    this.VmwareParams == input.VmwareParams ||
                    (this.VmwareParams != null &&
                    this.VmwareParams.Equals(input.VmwareParams))
                ) && 
                (
                    this.VmwareType == input.VmwareType ||
                    this.VmwareType.Equals(input.VmwareType)
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
                if (this.IsStorageArraySnapshotEnabled != null)
                    hashCode = hashCode * 59 + this.IsStorageArraySnapshotEnabled.GetHashCode();
                hashCode = hashCode * 59 + this.AcropolisType.GetHashCode();
                if (this.AgentEndpoint != null)
                    hashCode = hashCode * 59 + this.AgentEndpoint.GetHashCode();
                if (this.AllowedIpAddresses != null)
                    hashCode = hashCode * 59 + this.AllowedIpAddresses.GetHashCode();
                if (this.AwsCredentials != null)
                    hashCode = hashCode * 59 + this.AwsCredentials.GetHashCode();
                if (this.AwsFleetParams != null)
                    hashCode = hashCode * 59 + this.AwsFleetParams.GetHashCode();
                if (this.AzureCredentials != null)
                    hashCode = hashCode * 59 + this.AzureCredentials.GetHashCode();
                if (this.BlacklistedIpAddresses != null)
                    hashCode = hashCode * 59 + this.BlacklistedIpAddresses.GetHashCode();
                if (this.ClusterNetworkInfo != null)
                    hashCode = hashCode * 59 + this.ClusterNetworkInfo.GetHashCode();
                if (this.DeniedIpAddresses != null)
                    hashCode = hashCode * 59 + this.DeniedIpAddresses.GetHashCode();
                if (this.EncryptionKey != null)
                    hashCode = hashCode * 59 + this.EncryptionKey.GetHashCode();
                if (this.Endpoint != null)
                    hashCode = hashCode * 59 + this.Endpoint.GetHashCode();
                hashCode = hashCode * 59 + this.Environment.GetHashCode();
                if (this.ExchangeDagProtectionPreference != null)
                    hashCode = hashCode * 59 + this.ExchangeDagProtectionPreference.GetHashCode();
                if (this.ForceRegister != null)
                    hashCode = hashCode * 59 + this.ForceRegister.GetHashCode();
                if (this.GcpCredentials != null)
                    hashCode = hashCode * 59 + this.GcpCredentials.GetHashCode();
                hashCode = hashCode * 59 + this.HostType.GetHashCode();
                hashCode = hashCode * 59 + this.HyperVType.GetHashCode();
                if (this.IsInternalEncrypted != null)
                    hashCode = hashCode * 59 + this.IsInternalEncrypted.GetHashCode();
                if (this.IsProxyHost != null)
                    hashCode = hashCode * 59 + this.IsProxyHost.GetHashCode();
                if (this.IsilonParams != null)
                    hashCode = hashCode * 59 + this.IsilonParams.GetHashCode();
                if (this.KubernetesCredentials != null)
                    hashCode = hashCode * 59 + this.KubernetesCredentials.GetHashCode();
                if (this.KubernetesParams != null)
                    hashCode = hashCode * 59 + this.KubernetesParams.GetHashCode();
                hashCode = hashCode * 59 + this.KubernetesType.GetHashCode();
                hashCode = hashCode * 59 + this.KvmType.GetHashCode();
                if (this.NasMountCredentials != null)
                    hashCode = hashCode * 59 + this.NasMountCredentials.GetHashCode();
                hashCode = hashCode * 59 + this.NetappType.GetHashCode();
                hashCode = hashCode * 59 + this.NimbleType.GetHashCode();
                if (this.Office365CredentialsList != null)
                    hashCode = hashCode * 59 + this.Office365CredentialsList.GetHashCode();
                if (this.Office365Region != null)
                    hashCode = hashCode * 59 + this.Office365Region.GetHashCode();
                if (this.Office365ServiceAccountCredentialsList != null)
                    hashCode = hashCode * 59 + this.Office365ServiceAccountCredentialsList.GetHashCode();
                hashCode = hashCode * 59 + this.Office365Type.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.PhysicalParams != null)
                    hashCode = hashCode * 59 + this.PhysicalParams.GetHashCode();
                hashCode = hashCode * 59 + this.PhysicalType.GetHashCode();
                if (this.ProxyHostSourceIdList != null)
                    hashCode = hashCode * 59 + this.ProxyHostSourceIdList.GetHashCode();
                hashCode = hashCode * 59 + this.PureType.GetHashCode();
                if (this.SourceSideDedupEnabled != null)
                    hashCode = hashCode * 59 + this.SourceSideDedupEnabled.GetHashCode();
                if (this.SslVerification != null)
                    hashCode = hashCode * 59 + this.SslVerification.GetHashCode();
                if (this.Subnets != null)
                    hashCode = hashCode * 59 + this.Subnets.GetHashCode();
                if (this.ThrottlingPolicy != null)
                    hashCode = hashCode * 59 + this.ThrottlingPolicy.GetHashCode();
                if (this.ThrottlingPolicyOverrides != null)
                    hashCode = hashCode * 59 + this.ThrottlingPolicyOverrides.GetHashCode();
                if (this.UseExistingCredentials != null)
                    hashCode = hashCode * 59 + this.UseExistingCredentials.GetHashCode();
                if (this.UseOAuthForExchangeOnline != null)
                    hashCode = hashCode * 59 + this.UseOAuthForExchangeOnline.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.VlanParams != null)
                    hashCode = hashCode * 59 + this.VlanParams.GetHashCode();
                if (this.VmwareParams != null)
                    hashCode = hashCode * 59 + this.VmwareParams.GetHashCode();
                hashCode = hashCode * 59 + this.VmwareType.GetHashCode();
                return hashCode;
            }
        }

    }

}


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
    /// RegisteredAppInfo
    /// </summary>
    [DataContract]
    public partial class RegisteredAppInfo :  IEquatable<RegisteredAppInfo>
    {
        /// <summary>
        /// Specifies the status of authenticating to the Protection Source when registering this application with Cohesity Cluster. If the status is &#39;kFinished&#39; and there is no error, registration is successful. Specifies the status of the authentication during the registration of a Protection Source. &#39;kPending&#39; indicates the authentication is in progress. &#39;kScheduled&#39; indicates the authentication is scheduled. &#39;kFinished&#39; indicates the authentication is completed. &#39;kRefreshInProgress&#39; indicates the refresh is in progress.
        /// </summary>
        /// <value>Specifies the status of authenticating to the Protection Source when registering this application with Cohesity Cluster. If the status is &#39;kFinished&#39; and there is no error, registration is successful. Specifies the status of the authentication during the registration of a Protection Source. &#39;kPending&#39; indicates the authentication is in progress. &#39;kScheduled&#39; indicates the authentication is scheduled. &#39;kFinished&#39; indicates the authentication is completed. &#39;kRefreshInProgress&#39; indicates the refresh is in progress.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AuthenticationStatusEnum
        {
            /// <summary>
            /// Enum KPending for value: kPending
            /// </summary>
            [EnumMember(Value = "kPending")]
            KPending = 1,

            /// <summary>
            /// Enum KScheduled for value: kScheduled
            /// </summary>
            [EnumMember(Value = "kScheduled")]
            KScheduled = 2,

            /// <summary>
            /// Enum KFinished for value: kFinished
            /// </summary>
            [EnumMember(Value = "kFinished")]
            KFinished = 3,

            /// <summary>
            /// Enum KRefreshInProgress for value: kRefreshInProgress
            /// </summary>
            [EnumMember(Value = "kRefreshInProgress")]
            KRefreshInProgress = 4

        }

        /// <summary>
        /// Specifies the status of authenticating to the Protection Source when registering this application with Cohesity Cluster. If the status is &#39;kFinished&#39; and there is no error, registration is successful. Specifies the status of the authentication during the registration of a Protection Source. &#39;kPending&#39; indicates the authentication is in progress. &#39;kScheduled&#39; indicates the authentication is scheduled. &#39;kFinished&#39; indicates the authentication is completed. &#39;kRefreshInProgress&#39; indicates the refresh is in progress.
        /// </summary>
        /// <value>Specifies the status of authenticating to the Protection Source when registering this application with Cohesity Cluster. If the status is &#39;kFinished&#39; and there is no error, registration is successful. Specifies the status of the authentication during the registration of a Protection Source. &#39;kPending&#39; indicates the authentication is in progress. &#39;kScheduled&#39; indicates the authentication is scheduled. &#39;kFinished&#39; indicates the authentication is completed. &#39;kRefreshInProgress&#39; indicates the refresh is in progress.</value>
        [DataMember(Name="authenticationStatus", EmitDefaultValue=true)]
        public AuthenticationStatusEnum? AuthenticationStatus { get; set; }
        /// <summary>
        /// Specifies the application environment. Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;kNimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Generic Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhysicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment. &#39;kAD&#39; indicates Active Directory Protection Source environment. &#39;kRDSSnapshotManager&#39; indicates AWS RDS Protection Source environment. &#39;kCassandra&#39; indicates Cassandra Protection Source environment. &#39;kMongoDB&#39; indicates MongoDB Protection Source environment. &#39;kCouchbase&#39; indicates Couchbase Protection Source environment. &#39;kHdfs&#39; indicates Hdfs Protection Source environment. &#39;kHive&#39; indicates Hive Protection Source environment. &#39;kHBase&#39; indicates HBase Protection Source environment. &#39;kUDA&#39; indicates Universal Data Adapter Protection Source environment. &#39;kO365Teams&#39; indicates the Office365 Teams Protection Source environment. &#39;kO365Group&#39; indicates the Office365 Groups Protection Source environment. &#39;kO365Exchange&#39; indicates the Office365 Mailbox Protection Source environment. &#39;kO365OneDrive&#39; indicates the Office365 OneDrive Protection Source environment. &#39;kO365Sharepoint&#39; indicates the Office365 SharePoint Protection Source environment. &#39;kO365PublicFolders&#39; indicates the Office365 PublicFolders Protection Source environment.
        /// </summary>
        /// <value>Specifies the application environment. Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;kNimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Generic Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhysicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment. &#39;kAD&#39; indicates Active Directory Protection Source environment. &#39;kRDSSnapshotManager&#39; indicates AWS RDS Protection Source environment. &#39;kCassandra&#39; indicates Cassandra Protection Source environment. &#39;kMongoDB&#39; indicates MongoDB Protection Source environment. &#39;kCouchbase&#39; indicates Couchbase Protection Source environment. &#39;kHdfs&#39; indicates Hdfs Protection Source environment. &#39;kHive&#39; indicates Hive Protection Source environment. &#39;kHBase&#39; indicates HBase Protection Source environment. &#39;kUDA&#39; indicates Universal Data Adapter Protection Source environment. &#39;kO365Teams&#39; indicates the Office365 Teams Protection Source environment. &#39;kO365Group&#39; indicates the Office365 Groups Protection Source environment. &#39;kO365Exchange&#39; indicates the Office365 Mailbox Protection Source environment. &#39;kO365OneDrive&#39; indicates the Office365 OneDrive Protection Source environment. &#39;kO365Sharepoint&#39; indicates the Office365 SharePoint Protection Source environment. &#39;kO365PublicFolders&#39; indicates the Office365 PublicFolders Protection Source environment.</value>
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
            KO365PublicFolders = 46

        }

        /// <summary>
        /// Specifies the application environment. Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;kNimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Generic Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhysicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment. &#39;kAD&#39; indicates Active Directory Protection Source environment. &#39;kRDSSnapshotManager&#39; indicates AWS RDS Protection Source environment. &#39;kCassandra&#39; indicates Cassandra Protection Source environment. &#39;kMongoDB&#39; indicates MongoDB Protection Source environment. &#39;kCouchbase&#39; indicates Couchbase Protection Source environment. &#39;kHdfs&#39; indicates Hdfs Protection Source environment. &#39;kHive&#39; indicates Hive Protection Source environment. &#39;kHBase&#39; indicates HBase Protection Source environment. &#39;kUDA&#39; indicates Universal Data Adapter Protection Source environment. &#39;kO365Teams&#39; indicates the Office365 Teams Protection Source environment. &#39;kO365Group&#39; indicates the Office365 Groups Protection Source environment. &#39;kO365Exchange&#39; indicates the Office365 Mailbox Protection Source environment. &#39;kO365OneDrive&#39; indicates the Office365 OneDrive Protection Source environment. &#39;kO365Sharepoint&#39; indicates the Office365 SharePoint Protection Source environment. &#39;kO365PublicFolders&#39; indicates the Office365 PublicFolders Protection Source environment.
        /// </summary>
        /// <value>Specifies the application environment. Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;kNimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Generic Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhysicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment. &#39;kAD&#39; indicates Active Directory Protection Source environment. &#39;kRDSSnapshotManager&#39; indicates AWS RDS Protection Source environment. &#39;kCassandra&#39; indicates Cassandra Protection Source environment. &#39;kMongoDB&#39; indicates MongoDB Protection Source environment. &#39;kCouchbase&#39; indicates Couchbase Protection Source environment. &#39;kHdfs&#39; indicates Hdfs Protection Source environment. &#39;kHive&#39; indicates Hive Protection Source environment. &#39;kHBase&#39; indicates HBase Protection Source environment. &#39;kUDA&#39; indicates Universal Data Adapter Protection Source environment. &#39;kO365Teams&#39; indicates the Office365 Teams Protection Source environment. &#39;kO365Group&#39; indicates the Office365 Groups Protection Source environment. &#39;kO365Exchange&#39; indicates the Office365 Mailbox Protection Source environment. &#39;kO365OneDrive&#39; indicates the Office365 OneDrive Protection Source environment. &#39;kO365Sharepoint&#39; indicates the Office365 SharePoint Protection Source environment. &#39;kO365PublicFolders&#39; indicates the Office365 PublicFolders Protection Source environment.</value>
        [DataMember(Name="environment", EmitDefaultValue=true)]
        public EnvironmentEnum? Environment { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisteredAppInfo" /> class.
        /// </summary>
        /// <param name="authenticationErrorMessage">Specifies an authentication error message. This indicates the given credentials are rejected and the registration of the application is not successful..</param>
        /// <param name="authenticationStatus">Specifies the status of authenticating to the Protection Source when registering this application with Cohesity Cluster. If the status is &#39;kFinished&#39; and there is no error, registration is successful. Specifies the status of the authentication during the registration of a Protection Source. &#39;kPending&#39; indicates the authentication is in progress. &#39;kScheduled&#39; indicates the authentication is scheduled. &#39;kFinished&#39; indicates the authentication is completed. &#39;kRefreshInProgress&#39; indicates the refresh is in progress..</param>
        /// <param name="environment">Specifies the application environment. Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;kNimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Generic Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhysicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment. &#39;kAD&#39; indicates Active Directory Protection Source environment. &#39;kRDSSnapshotManager&#39; indicates AWS RDS Protection Source environment. &#39;kCassandra&#39; indicates Cassandra Protection Source environment. &#39;kMongoDB&#39; indicates MongoDB Protection Source environment. &#39;kCouchbase&#39; indicates Couchbase Protection Source environment. &#39;kHdfs&#39; indicates Hdfs Protection Source environment. &#39;kHive&#39; indicates Hive Protection Source environment. &#39;kHBase&#39; indicates HBase Protection Source environment. &#39;kUDA&#39; indicates Universal Data Adapter Protection Source environment. &#39;kO365Teams&#39; indicates the Office365 Teams Protection Source environment. &#39;kO365Group&#39; indicates the Office365 Groups Protection Source environment. &#39;kO365Exchange&#39; indicates the Office365 Mailbox Protection Source environment. &#39;kO365OneDrive&#39; indicates the Office365 OneDrive Protection Source environment. &#39;kO365Sharepoint&#39; indicates the Office365 SharePoint Protection Source environment. &#39;kO365PublicFolders&#39; indicates the Office365 PublicFolders Protection Source environment..</param>
        /// <param name="hostSettingsCheckResults">Specifies the list of check results internally performed to verify status of various services such as &#39;AgnetRunning&#39;, &#39;SQLWriterRunning&#39; etc..</param>
        /// <param name="refreshErrorMessage">Specifies a message if there was any error encountered during the last rebuild of the application tree. If there was no error during the last rebuild, this field is reset..</param>
        public RegisteredAppInfo(string authenticationErrorMessage = default(string), AuthenticationStatusEnum? authenticationStatus = default(AuthenticationStatusEnum?), EnvironmentEnum? environment = default(EnvironmentEnum?), List<HostSettingsCheckResult> hostSettingsCheckResults = default(List<HostSettingsCheckResult>), string refreshErrorMessage = default(string))
        {
            this.AuthenticationErrorMessage = authenticationErrorMessage;
            this.AuthenticationStatus = authenticationStatus;
            this.Environment = environment;
            this.HostSettingsCheckResults = hostSettingsCheckResults;
            this.RefreshErrorMessage = refreshErrorMessage;
        }
        
        /// <summary>
        /// Specifies an authentication error message. This indicates the given credentials are rejected and the registration of the application is not successful.
        /// </summary>
        /// <value>Specifies an authentication error message. This indicates the given credentials are rejected and the registration of the application is not successful.</value>
        [DataMember(Name="authenticationErrorMessage", EmitDefaultValue=true)]
        public string AuthenticationErrorMessage { get; set; }

        /// <summary>
        /// Specifies the list of check results internally performed to verify status of various services such as &#39;AgnetRunning&#39;, &#39;SQLWriterRunning&#39; etc.
        /// </summary>
        /// <value>Specifies the list of check results internally performed to verify status of various services such as &#39;AgnetRunning&#39;, &#39;SQLWriterRunning&#39; etc.</value>
        [DataMember(Name="hostSettingsCheckResults", EmitDefaultValue=true)]
        public List<HostSettingsCheckResult> HostSettingsCheckResults { get; set; }

        /// <summary>
        /// Specifies a message if there was any error encountered during the last rebuild of the application tree. If there was no error during the last rebuild, this field is reset.
        /// </summary>
        /// <value>Specifies a message if there was any error encountered during the last rebuild of the application tree. If there was no error during the last rebuild, this field is reset.</value>
        [DataMember(Name="refreshErrorMessage", EmitDefaultValue=true)]
        public string RefreshErrorMessage { get; set; }

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
            return this.Equals(input as RegisteredAppInfo);
        }

        /// <summary>
        /// Returns true if RegisteredAppInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of RegisteredAppInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegisteredAppInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthenticationErrorMessage == input.AuthenticationErrorMessage ||
                    (this.AuthenticationErrorMessage != null &&
                    this.AuthenticationErrorMessage.Equals(input.AuthenticationErrorMessage))
                ) && 
                (
                    this.AuthenticationStatus == input.AuthenticationStatus ||
                    this.AuthenticationStatus.Equals(input.AuthenticationStatus)
                ) && 
                (
                    this.Environment == input.Environment ||
                    this.Environment.Equals(input.Environment)
                ) && 
                (
                    this.HostSettingsCheckResults == input.HostSettingsCheckResults ||
                    this.HostSettingsCheckResults != null &&
                    input.HostSettingsCheckResults != null &&
                    this.HostSettingsCheckResults.Equals(input.HostSettingsCheckResults)
                ) && 
                (
                    this.RefreshErrorMessage == input.RefreshErrorMessage ||
                    (this.RefreshErrorMessage != null &&
                    this.RefreshErrorMessage.Equals(input.RefreshErrorMessage))
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
                if (this.AuthenticationErrorMessage != null)
                    hashCode = hashCode * 59 + this.AuthenticationErrorMessage.GetHashCode();
                if (this.AuthenticationStatus != null)
					hashCode = hashCode * 59 + this.AuthenticationStatus.GetHashCode();
                if (this.Environment != null)
					hashCode = hashCode * 59 + this.Environment.GetHashCode();
                if (this.HostSettingsCheckResults != null)
                    hashCode = hashCode * 59 + this.HostSettingsCheckResults.GetHashCode();
                if (this.RefreshErrorMessage != null)
                    hashCode = hashCode * 59 + this.RefreshErrorMessage.GetHashCode();
                return hashCode;
            }
        }

    }

}


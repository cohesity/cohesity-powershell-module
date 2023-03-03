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
    /// Specifies information about a registered Source.
    /// </summary>
    [DataContract]
    public partial class RegisteredSourceInfo :  IEquatable<RegisteredSourceInfo>
    {
        /// <summary>
        /// Specifies the status of the authenticating to the Protection Source when registering it with Cohesity Cluster. If the status is &#39;kFinished&#39; and there is no error, registration is successful. Specifies the status of the authentication during the registration of a Protection Source. &#39;kPending&#39; indicates the authentication is in progress. &#39;kScheduled&#39; indicates the authentication is scheduled. &#39;kFinished&#39; indicates the authentication is completed. &#39;kRefreshInProgress&#39; indicates the refresh is in progress.
        /// </summary>
        /// <value>Specifies the status of the authenticating to the Protection Source when registering it with Cohesity Cluster. If the status is &#39;kFinished&#39; and there is no error, registration is successful. Specifies the status of the authentication during the registration of a Protection Source. &#39;kPending&#39; indicates the authentication is in progress. &#39;kScheduled&#39; indicates the authentication is scheduled. &#39;kFinished&#39; indicates the authentication is completed. &#39;kRefreshInProgress&#39; indicates the refresh is in progress.</value>
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
        /// Specifies the status of the authenticating to the Protection Source when registering it with Cohesity Cluster. If the status is &#39;kFinished&#39; and there is no error, registration is successful. Specifies the status of the authentication during the registration of a Protection Source. &#39;kPending&#39; indicates the authentication is in progress. &#39;kScheduled&#39; indicates the authentication is scheduled. &#39;kFinished&#39; indicates the authentication is completed. &#39;kRefreshInProgress&#39; indicates the refresh is in progress.
        /// </summary>
        /// <value>Specifies the status of the authenticating to the Protection Source when registering it with Cohesity Cluster. If the status is &#39;kFinished&#39; and there is no error, registration is successful. Specifies the status of the authentication during the registration of a Protection Source. &#39;kPending&#39; indicates the authentication is in progress. &#39;kScheduled&#39; indicates the authentication is scheduled. &#39;kFinished&#39; indicates the authentication is completed. &#39;kRefreshInProgress&#39; indicates the refresh is in progress.</value>
        [DataMember(Name="authenticationStatus", EmitDefaultValue=true)]
        public AuthenticationStatusEnum? AuthenticationStatus { get; set; }
        /// <summary>
        /// Defines Environments
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EnvironmentsEnum
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
        /// Specifies a list of applications environment that are registered with this Protection Source such as &#39;kSQL&#39;. Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;kNimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Generic Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhysicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment. &#39;kAD&#39; indicates Active Directory Protection Source environment. &#39;kRDSSnapshotManager&#39; indicates AWS RDS Protection Source environment. &#39;kCassandra&#39; indicates Cassandra Protection Source environment. &#39;kMongoDB&#39; indicates MongoDB Protection Source environment. &#39;kCouchbase&#39; indicates Couchbase Protection Source environment. &#39;kHdfs&#39; indicates Hdfs Protection Source environment. &#39;kHive&#39; indicates Hive Protection Source environment. &#39;kHBase&#39; indicates HBase Protection Source environment. &#39;kUDA&#39; indicates Universal Data Adapter Protection Source environment. &#39;kO365Teams&#39; indicates the Office365 Teams Protection Source environment. &#39;kO365Group&#39; indicates the Office365 Groups Protection Source environment. &#39;kO365Exchange&#39; indicates the Office365 Mailbox Protection Source environment. &#39;kO365OneDrive&#39; indicates the Office365 OneDrive Protection Source environment. &#39;kO365Sharepoint&#39; indicates the Office365 SharePoint Protection Source environment. &#39;kO365PublicFolders&#39; indicates the Office365 PublicFolders Protection Source environment.
        /// </summary>
        /// <value>Specifies a list of applications environment that are registered with this Protection Source such as &#39;kSQL&#39;. Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;kNimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Generic Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhysicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment. &#39;kAD&#39; indicates Active Directory Protection Source environment. &#39;kRDSSnapshotManager&#39; indicates AWS RDS Protection Source environment. &#39;kCassandra&#39; indicates Cassandra Protection Source environment. &#39;kMongoDB&#39; indicates MongoDB Protection Source environment. &#39;kCouchbase&#39; indicates Couchbase Protection Source environment. &#39;kHdfs&#39; indicates Hdfs Protection Source environment. &#39;kHive&#39; indicates Hive Protection Source environment. &#39;kHBase&#39; indicates HBase Protection Source environment. &#39;kUDA&#39; indicates Universal Data Adapter Protection Source environment. &#39;kO365Teams&#39; indicates the Office365 Teams Protection Source environment. &#39;kO365Group&#39; indicates the Office365 Groups Protection Source environment. &#39;kO365Exchange&#39; indicates the Office365 Mailbox Protection Source environment. &#39;kO365OneDrive&#39; indicates the Office365 OneDrive Protection Source environment. &#39;kO365Sharepoint&#39; indicates the Office365 SharePoint Protection Source environment. &#39;kO365PublicFolders&#39; indicates the Office365 PublicFolders Protection Source environment.</value>
        [DataMember(Name="environments", EmitDefaultValue=true)]
        public List<EnvironmentsEnum> Environments { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisteredSourceInfo" /> class.
        /// </summary>
        /// <param name="accessInfo">accessInfo.</param>
        /// <param name="allowedIpAddresses">Specifies the list of IP Addresses on the registered source to be exclusively allowed for doing any type of IO operations..</param>
        /// <param name="authenticationErrorMessage">Specifies an authentication error message. This indicates the given credentials are rejected and the registration of the source is not successful..</param>
        /// <param name="authenticationStatus">Specifies the status of the authenticating to the Protection Source when registering it with Cohesity Cluster. If the status is &#39;kFinished&#39; and there is no error, registration is successful. Specifies the status of the authentication during the registration of a Protection Source. &#39;kPending&#39; indicates the authentication is in progress. &#39;kScheduled&#39; indicates the authentication is scheduled. &#39;kFinished&#39; indicates the authentication is completed. &#39;kRefreshInProgress&#39; indicates the refresh is in progress..</param>
        /// <param name="blacklistedIpAddresses">This field is deprecated. Use DeniedIpAddresses instead. deprecated: true.</param>
        /// <param name="cassandraParams">cassandraParams.</param>
        /// <param name="couchbaseParams">couchbaseParams.</param>
        /// <param name="deniedIpAddresses">Specifies the list of IP Addresses on the registered source to be denied for doing any type of IO operations..</param>
        /// <param name="environments">Specifies a list of applications environment that are registered with this Protection Source such as &#39;kSQL&#39;. Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;kNimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Generic Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhysicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment. &#39;kAD&#39; indicates Active Directory Protection Source environment. &#39;kRDSSnapshotManager&#39; indicates AWS RDS Protection Source environment. &#39;kCassandra&#39; indicates Cassandra Protection Source environment. &#39;kMongoDB&#39; indicates MongoDB Protection Source environment. &#39;kCouchbase&#39; indicates Couchbase Protection Source environment. &#39;kHdfs&#39; indicates Hdfs Protection Source environment. &#39;kHive&#39; indicates Hive Protection Source environment. &#39;kHBase&#39; indicates HBase Protection Source environment. &#39;kUDA&#39; indicates Universal Data Adapter Protection Source environment. &#39;kO365Teams&#39; indicates the Office365 Teams Protection Source environment. &#39;kO365Group&#39; indicates the Office365 Groups Protection Source environment. &#39;kO365Exchange&#39; indicates the Office365 Mailbox Protection Source environment. &#39;kO365OneDrive&#39; indicates the Office365 OneDrive Protection Source environment. &#39;kO365Sharepoint&#39; indicates the Office365 SharePoint Protection Source environment. &#39;kO365PublicFolders&#39; indicates the Office365 PublicFolders Protection Source environment..</param>
        /// <param name="hbaseParams">hbaseParams.</param>
        /// <param name="hdfsParams">hdfsParams.</param>
        /// <param name="hiveParams">hiveParams.</param>
        /// <param name="isDbAuthenticated">Specifies if application entity dbAuthenticated or not. ex: oracle database..</param>
        /// <param name="isStorageArraySnapshotEnabled">Specifies if this source entity has enabled storage array snapshot or not..</param>
        /// <param name="isilonParams">isilonParams.</param>
        /// <param name="minimumFreeSpaceGB">Specifies the minimum free space in GiB of the space expected to be available on the datastore where the virtual disks of the VM being backed up. If the amount of free space(in GiB) is lower than the value given by this field, backup will be aborted. Note that this field is applicable only to &#39;kVMware&#39; type of environments..</param>
        /// <param name="mongodbParams">mongodbParams.</param>
        /// <param name="nasMountCredentials">Specifies the credentials required to mount directories on the NetApp server if given..</param>
        /// <param name="o365Params">o365Params.</param>
        /// <param name="office365CredentialsList">Office365 Source Credentials.  Specifies credentials needed to authenticate &amp; authorize user for Office365..</param>
        /// <param name="office365Region">Specifies the region for Office365..</param>
        /// <param name="office365ServiceAccountCredentialsList">Office365 Service Account Credentials.  Specifies credentials for improving mailbox backup performance for O365..</param>
        /// <param name="password">Specifies password of the username to access the target source..</param>
        /// <param name="physicalParams">physicalParams.</param>
        /// <param name="progressMonitorPath">Captures the current progress and pulse details w.r.t to either the registration or refresh..</param>
        /// <param name="refreshErrorMessage">Specifies a message if there was any error encountered during the last rebuild of the Protection Source tree. If there was no error during the last rebuild, this field is reset..</param>
        /// <param name="refreshTimeUsecs">Specifies the Unix epoch time (in microseconds) when the Protection Source tree was most recently fetched and built..</param>
        /// <param name="registeredAppsInfo">Specifies information of the applications registered on this protection source..</param>
        /// <param name="registrationTimeUsecs">Specifies the Unix epoch time (in microseconds) when the Protection Source was registered..</param>
        /// <param name="subnets">Specifies the list of subnets added during creation or updation of vmare source. Currently, this field will only be populated in case of VMware registration..</param>
        /// <param name="throttlingPolicy">throttlingPolicy.</param>
        /// <param name="throttlingPolicyOverrides">Array of Throttling Policy Overrides for Datastores.  Specifies a list of Throttling Policy for datastores that override the common throttling policy specified for the registered Protection Source. For datastores not in this list, common policy will still apply..</param>
        /// <param name="udaParams">udaParams.</param>
        /// <param name="useOAuthForExchangeOnline">Specifies whether OAuth should be used for authentication in case of Exchange Online..</param>
        /// <param name="useVmBiosUuid">Specifies if registered vCenter is using BIOS UUID to track virtual machines..</param>
        /// <param name="userMessages">Specifies the additional details encountered during registration. Though the registration may succeed, user messages imply the host environment requires some cleanup or fixing..</param>
        /// <param name="username">Specifies username to access the target source..</param>
        /// <param name="vlanParams">vlanParams.</param>
        /// <param name="warningMessages">Specifies a list of warnings encountered during registration. Though the registration may succeed, warning messages imply the host environment requires some cleanup or fixing..</param>
        public RegisteredSourceInfo(ConnectorParameters accessInfo = default(ConnectorParameters), List<string> allowedIpAddresses = default(List<string>), string authenticationErrorMessage = default(string), AuthenticationStatusEnum? authenticationStatus = default(AuthenticationStatusEnum?), List<string> blacklistedIpAddresses = default(List<string>), CassandraConnectParams cassandraParams = default(CassandraConnectParams), CouchbaseConnectParams couchbaseParams = default(CouchbaseConnectParams), List<string> deniedIpAddresses = default(List<string>), List<EnvironmentsEnum> environments = default(List<EnvironmentsEnum>), HBaseConnectParams hbaseParams = default(HBaseConnectParams), HdfsConnectParams hdfsParams = default(HdfsConnectParams), HiveConnectParams hiveParams = default(HiveConnectParams), bool? isDbAuthenticated = default(bool?), bool? isStorageArraySnapshotEnabled = default(bool?), RegisteredProtectionSourceIsilonParams isilonParams = default(RegisteredProtectionSourceIsilonParams), long? minimumFreeSpaceGB = default(long?), MongoDBConnectParams mongodbParams = default(MongoDBConnectParams), NasMountCredentialParams nasMountCredentials = default(NasMountCredentialParams), O365ConnectParams o365Params = default(O365ConnectParams), List<Office365Credentials> office365CredentialsList = default(List<Office365Credentials>), string office365Region = default(string), List<Credentials> office365ServiceAccountCredentialsList = default(List<Credentials>), string password = default(string), PhysicalParams physicalParams = default(PhysicalParams), string progressMonitorPath = default(string), string refreshErrorMessage = default(string), long? refreshTimeUsecs = default(long?), List<RegisteredAppInfo> registeredAppsInfo = default(List<RegisteredAppInfo>), long? registrationTimeUsecs = default(long?), List<Subnet> subnets = default(List<Subnet>), ThrottlingPolicyParameters throttlingPolicy = default(ThrottlingPolicyParameters), List<ThrottlingPolicyOverride> throttlingPolicyOverrides = default(List<ThrottlingPolicyOverride>), UdaConnectParams udaParams = default(UdaConnectParams), bool? useOAuthForExchangeOnline = default(bool?), bool? useVmBiosUuid = default(bool?), List<string> userMessages = default(List<string>), string username = default(string), VlanParameters vlanParams = default(VlanParameters), List<string> warningMessages = default(List<string>))
        {
            this.AllowedIpAddresses = allowedIpAddresses;
            this.AuthenticationErrorMessage = authenticationErrorMessage;
            this.AuthenticationStatus = authenticationStatus;
            this.BlacklistedIpAddresses = blacklistedIpAddresses;
            this.DeniedIpAddresses = deniedIpAddresses;
            this.Environments = environments;
            this.IsDbAuthenticated = isDbAuthenticated;
            this.IsStorageArraySnapshotEnabled = isStorageArraySnapshotEnabled;
            this.MinimumFreeSpaceGB = minimumFreeSpaceGB;
            this.NasMountCredentials = nasMountCredentials;
            this.Office365CredentialsList = office365CredentialsList;
            this.Office365Region = office365Region;
            this.Office365ServiceAccountCredentialsList = office365ServiceAccountCredentialsList;
            this.Password = password;
            this.ProgressMonitorPath = progressMonitorPath;
            this.RefreshErrorMessage = refreshErrorMessage;
            this.RefreshTimeUsecs = refreshTimeUsecs;
            this.RegisteredAppsInfo = registeredAppsInfo;
            this.RegistrationTimeUsecs = registrationTimeUsecs;
            this.Subnets = subnets;
            this.ThrottlingPolicyOverrides = throttlingPolicyOverrides;
            this.UseOAuthForExchangeOnline = useOAuthForExchangeOnline;
            this.UseVmBiosUuid = useVmBiosUuid;
            this.UserMessages = userMessages;
            this.Username = username;
            this.WarningMessages = warningMessages;
            this.AccessInfo = accessInfo;
            this.AllowedIpAddresses = allowedIpAddresses;
            this.AuthenticationErrorMessage = authenticationErrorMessage;
            this.AuthenticationStatus = authenticationStatus;
            this.BlacklistedIpAddresses = blacklistedIpAddresses;
            this.CassandraParams = cassandraParams;
            this.CouchbaseParams = couchbaseParams;
            this.DeniedIpAddresses = deniedIpAddresses;
            this.Environments = environments;
            this.HbaseParams = hbaseParams;
            this.HdfsParams = hdfsParams;
            this.HiveParams = hiveParams;
            this.IsDbAuthenticated = isDbAuthenticated;
            this.IsStorageArraySnapshotEnabled = isStorageArraySnapshotEnabled;
            this.IsilonParams = isilonParams;
            this.MinimumFreeSpaceGB = minimumFreeSpaceGB;
            this.MongodbParams = mongodbParams;
            this.NasMountCredentials = nasMountCredentials;
            this.O365Params = o365Params;
            this.Office365CredentialsList = office365CredentialsList;
            this.Office365Region = office365Region;
            this.Office365ServiceAccountCredentialsList = office365ServiceAccountCredentialsList;
            this.Password = password;
            this.PhysicalParams = physicalParams;
            this.ProgressMonitorPath = progressMonitorPath;
            this.RefreshErrorMessage = refreshErrorMessage;
            this.RefreshTimeUsecs = refreshTimeUsecs;
            this.RegisteredAppsInfo = registeredAppsInfo;
            this.RegistrationTimeUsecs = registrationTimeUsecs;
            this.Subnets = subnets;
            this.ThrottlingPolicy = throttlingPolicy;
            this.ThrottlingPolicyOverrides = throttlingPolicyOverrides;
            this.UdaParams = udaParams;
            this.UseOAuthForExchangeOnline = useOAuthForExchangeOnline;
            this.UseVmBiosUuid = useVmBiosUuid;
            this.UserMessages = userMessages;
            this.Username = username;
            this.VlanParams = vlanParams;
            this.WarningMessages = warningMessages;
        }
        
        /// <summary>
        /// Gets or Sets AccessInfo
        /// </summary>
        [DataMember(Name="accessInfo", EmitDefaultValue=false)]
        public ConnectorParameters AccessInfo { get; set; }

        /// <summary>
        /// Specifies the list of IP Addresses on the registered source to be exclusively allowed for doing any type of IO operations.
        /// </summary>
        /// <value>Specifies the list of IP Addresses on the registered source to be exclusively allowed for doing any type of IO operations.</value>
        [DataMember(Name="allowedIpAddresses", EmitDefaultValue=true)]
        public List<string> AllowedIpAddresses { get; set; }

        /// <summary>
        /// Specifies an authentication error message. This indicates the given credentials are rejected and the registration of the source is not successful.
        /// </summary>
        /// <value>Specifies an authentication error message. This indicates the given credentials are rejected and the registration of the source is not successful.</value>
        [DataMember(Name="authenticationErrorMessage", EmitDefaultValue=true)]
        public string AuthenticationErrorMessage { get; set; }

        /// <summary>
        /// This field is deprecated. Use DeniedIpAddresses instead. deprecated: true
        /// </summary>
        /// <value>This field is deprecated. Use DeniedIpAddresses instead. deprecated: true</value>
        [DataMember(Name="blacklistedIpAddresses", EmitDefaultValue=true)]
        public List<string> BlacklistedIpAddresses { get; set; }

        /// <summary>
        /// Gets or Sets CassandraParams
        /// </summary>
        [DataMember(Name="cassandraParams", EmitDefaultValue=false)]
        public CassandraConnectParams CassandraParams { get; set; }

        /// <summary>
        /// Gets or Sets CouchbaseParams
        /// </summary>
        [DataMember(Name="couchbaseParams", EmitDefaultValue=false)]
        public CouchbaseConnectParams CouchbaseParams { get; set; }

        /// <summary>
        /// Specifies the list of IP Addresses on the registered source to be denied for doing any type of IO operations.
        /// </summary>
        /// <value>Specifies the list of IP Addresses on the registered source to be denied for doing any type of IO operations.</value>
        [DataMember(Name="deniedIpAddresses", EmitDefaultValue=true)]
        public List<string> DeniedIpAddresses { get; set; }

        /// <summary>
        /// Gets or Sets HbaseParams
        /// </summary>
        [DataMember(Name="hbaseParams", EmitDefaultValue=false)]
        public HBaseConnectParams HbaseParams { get; set; }

        /// <summary>
        /// Gets or Sets HdfsParams
        /// </summary>
        [DataMember(Name="hdfsParams", EmitDefaultValue=false)]
        public HdfsConnectParams HdfsParams { get; set; }

        /// <summary>
        /// Gets or Sets HiveParams
        /// </summary>
        [DataMember(Name="hiveParams", EmitDefaultValue=false)]
        public HiveConnectParams HiveParams { get; set; }

        /// <summary>
        /// Specifies if application entity dbAuthenticated or not. ex: oracle database.
        /// </summary>
        /// <value>Specifies if application entity dbAuthenticated or not. ex: oracle database.</value>
        [DataMember(Name="isDbAuthenticated", EmitDefaultValue=true)]
        public bool? IsDbAuthenticated { get; set; }

        /// <summary>
        /// Specifies if this source entity has enabled storage array snapshot or not.
        /// </summary>
        /// <value>Specifies if this source entity has enabled storage array snapshot or not.</value>
        [DataMember(Name="isStorageArraySnapshotEnabled", EmitDefaultValue=true)]
        public bool? IsStorageArraySnapshotEnabled { get; set; }

        /// <summary>
        /// Gets or Sets IsilonParams
        /// </summary>
        [DataMember(Name="isilonParams", EmitDefaultValue=false)]
        public RegisteredProtectionSourceIsilonParams IsilonParams { get; set; }

        /// <summary>
        /// Specifies the minimum free space in GiB of the space expected to be available on the datastore where the virtual disks of the VM being backed up. If the amount of free space(in GiB) is lower than the value given by this field, backup will be aborted. Note that this field is applicable only to &#39;kVMware&#39; type of environments.
        /// </summary>
        /// <value>Specifies the minimum free space in GiB of the space expected to be available on the datastore where the virtual disks of the VM being backed up. If the amount of free space(in GiB) is lower than the value given by this field, backup will be aborted. Note that this field is applicable only to &#39;kVMware&#39; type of environments.</value>
        [DataMember(Name="minimumFreeSpaceGB", EmitDefaultValue=true)]
        public long? MinimumFreeSpaceGB { get; set; }

        /// <summary>
        /// Gets or Sets MongodbParams
        /// </summary>
        [DataMember(Name="mongodbParams", EmitDefaultValue=false)]
        public MongoDBConnectParams MongodbParams { get; set; }

        /// <summary>
        /// Specifies the credentials required to mount directories on the NetApp server if given.
        /// </summary>
        /// <value>Specifies the credentials required to mount directories on the NetApp server if given.</value>
        [DataMember(Name="nasMountCredentials", EmitDefaultValue=true)]
        public NasMountCredentialParams NasMountCredentials { get; set; }

        /// <summary>
        /// Gets or Sets O365Params
        /// </summary>
        [DataMember(Name="o365Params", EmitDefaultValue=false)]
        public O365ConnectParams O365Params { get; set; }

        /// <summary>
        /// Office365 Source Credentials.  Specifies credentials needed to authenticate &amp; authorize user for Office365.
        /// </summary>
        /// <value>Office365 Source Credentials.  Specifies credentials needed to authenticate &amp; authorize user for Office365.</value>
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
        /// Captures the current progress and pulse details w.r.t to either the registration or refresh.
        /// </summary>
        /// <value>Captures the current progress and pulse details w.r.t to either the registration or refresh.</value>
        [DataMember(Name="progressMonitorPath", EmitDefaultValue=true)]
        public string ProgressMonitorPath { get; set; }

        /// <summary>
        /// Specifies a message if there was any error encountered during the last rebuild of the Protection Source tree. If there was no error during the last rebuild, this field is reset.
        /// </summary>
        /// <value>Specifies a message if there was any error encountered during the last rebuild of the Protection Source tree. If there was no error during the last rebuild, this field is reset.</value>
        [DataMember(Name="refreshErrorMessage", EmitDefaultValue=true)]
        public string RefreshErrorMessage { get; set; }

        /// <summary>
        /// Specifies the Unix epoch time (in microseconds) when the Protection Source tree was most recently fetched and built.
        /// </summary>
        /// <value>Specifies the Unix epoch time (in microseconds) when the Protection Source tree was most recently fetched and built.</value>
        [DataMember(Name="refreshTimeUsecs", EmitDefaultValue=true)]
        public long? RefreshTimeUsecs { get; set; }

        /// <summary>
        /// Specifies information of the applications registered on this protection source.
        /// </summary>
        /// <value>Specifies information of the applications registered on this protection source.</value>
        [DataMember(Name="registeredAppsInfo", EmitDefaultValue=true)]
        public List<RegisteredAppInfo> RegisteredAppsInfo { get; set; }

        /// <summary>
        /// Specifies the Unix epoch time (in microseconds) when the Protection Source was registered.
        /// </summary>
        /// <value>Specifies the Unix epoch time (in microseconds) when the Protection Source was registered.</value>
        [DataMember(Name="registrationTimeUsecs", EmitDefaultValue=true)]
        public long? RegistrationTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the list of subnets added during creation or updation of vmare source. Currently, this field will only be populated in case of VMware registration.
        /// </summary>
        /// <value>Specifies the list of subnets added during creation or updation of vmare source. Currently, this field will only be populated in case of VMware registration.</value>
        [DataMember(Name="subnets", EmitDefaultValue=true)]
        public List<Subnet> Subnets { get; set; }

        /// <summary>
        /// Gets or Sets ThrottlingPolicy
        /// </summary>
        [DataMember(Name="throttlingPolicy", EmitDefaultValue=false)]
        public ThrottlingPolicyParameters ThrottlingPolicy { get; set; }

        /// <summary>
        /// Array of Throttling Policy Overrides for Datastores.  Specifies a list of Throttling Policy for datastores that override the common throttling policy specified for the registered Protection Source. For datastores not in this list, common policy will still apply.
        /// </summary>
        /// <value>Array of Throttling Policy Overrides for Datastores.  Specifies a list of Throttling Policy for datastores that override the common throttling policy specified for the registered Protection Source. For datastores not in this list, common policy will still apply.</value>
        [DataMember(Name="throttlingPolicyOverrides", EmitDefaultValue=true)]
        public List<ThrottlingPolicyOverride> ThrottlingPolicyOverrides { get; set; }

        /// <summary>
        /// Gets or Sets UdaParams
        /// </summary>
        [DataMember(Name="udaParams", EmitDefaultValue=false)]
        public UdaConnectParams UdaParams { get; set; }

        /// <summary>
        /// Specifies whether OAuth should be used for authentication in case of Exchange Online.
        /// </summary>
        /// <value>Specifies whether OAuth should be used for authentication in case of Exchange Online.</value>
        [DataMember(Name="useOAuthForExchangeOnline", EmitDefaultValue=true)]
        public bool? UseOAuthForExchangeOnline { get; set; }

        /// <summary>
        /// Specifies if registered vCenter is using BIOS UUID to track virtual machines.
        /// </summary>
        /// <value>Specifies if registered vCenter is using BIOS UUID to track virtual machines.</value>
        [DataMember(Name="useVmBiosUuid", EmitDefaultValue=true)]
        public bool? UseVmBiosUuid { get; set; }

        /// <summary>
        /// Specifies the additional details encountered during registration. Though the registration may succeed, user messages imply the host environment requires some cleanup or fixing.
        /// </summary>
        /// <value>Specifies the additional details encountered during registration. Though the registration may succeed, user messages imply the host environment requires some cleanup or fixing.</value>
        [DataMember(Name="userMessages", EmitDefaultValue=true)]
        public List<string> UserMessages { get; set; }

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
        /// Specifies a list of warnings encountered during registration. Though the registration may succeed, warning messages imply the host environment requires some cleanup or fixing.
        /// </summary>
        /// <value>Specifies a list of warnings encountered during registration. Though the registration may succeed, warning messages imply the host environment requires some cleanup or fixing.</value>
        [DataMember(Name="warningMessages", EmitDefaultValue=true)]
        public List<string> WarningMessages { get; set; }

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
            return this.Equals(input as RegisteredSourceInfo);
        }

        /// <summary>
        /// Returns true if RegisteredSourceInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of RegisteredSourceInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegisteredSourceInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessInfo == input.AccessInfo ||
                    (this.AccessInfo != null &&
                    this.AccessInfo.Equals(input.AccessInfo))
                ) && 
                (
                    this.AllowedIpAddresses == input.AllowedIpAddresses ||
                    this.AllowedIpAddresses != null &&
                    input.AllowedIpAddresses != null &&
                    this.AllowedIpAddresses.SequenceEqual(input.AllowedIpAddresses)
                ) && 
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
                    this.BlacklistedIpAddresses == input.BlacklistedIpAddresses ||
                    this.BlacklistedIpAddresses != null &&
                    input.BlacklistedIpAddresses != null &&
                    this.BlacklistedIpAddresses.SequenceEqual(input.BlacklistedIpAddresses)
                ) && 
                (
                    this.CassandraParams == input.CassandraParams ||
                    (this.CassandraParams != null &&
                    this.CassandraParams.Equals(input.CassandraParams))
                ) && 
                (
                    this.CouchbaseParams == input.CouchbaseParams ||
                    (this.CouchbaseParams != null &&
                    this.CouchbaseParams.Equals(input.CouchbaseParams))
                ) && 
                (
                    this.DeniedIpAddresses == input.DeniedIpAddresses ||
                    this.DeniedIpAddresses != null &&
                    input.DeniedIpAddresses != null &&
                    this.DeniedIpAddresses.SequenceEqual(input.DeniedIpAddresses)
                ) && 
                (
                    this.Environments == input.Environments ||
                    this.Environments.SequenceEqual(input.Environments)
                ) && 
                (
                    this.HbaseParams == input.HbaseParams ||
                    (this.HbaseParams != null &&
                    this.HbaseParams.Equals(input.HbaseParams))
                ) && 
                (
                    this.HdfsParams == input.HdfsParams ||
                    (this.HdfsParams != null &&
                    this.HdfsParams.Equals(input.HdfsParams))
                ) && 
                (
                    this.HiveParams == input.HiveParams ||
                    (this.HiveParams != null &&
                    this.HiveParams.Equals(input.HiveParams))
                ) && 
                (
                    this.IsDbAuthenticated == input.IsDbAuthenticated ||
                    (this.IsDbAuthenticated != null &&
                    this.IsDbAuthenticated.Equals(input.IsDbAuthenticated))
                ) && 
                (
                    this.IsStorageArraySnapshotEnabled == input.IsStorageArraySnapshotEnabled ||
                    (this.IsStorageArraySnapshotEnabled != null &&
                    this.IsStorageArraySnapshotEnabled.Equals(input.IsStorageArraySnapshotEnabled))
                ) && 
                (
                    this.IsilonParams == input.IsilonParams ||
                    (this.IsilonParams != null &&
                    this.IsilonParams.Equals(input.IsilonParams))
                ) && 
                (
                    this.MinimumFreeSpaceGB == input.MinimumFreeSpaceGB ||
                    (this.MinimumFreeSpaceGB != null &&
                    this.MinimumFreeSpaceGB.Equals(input.MinimumFreeSpaceGB))
                ) && 
                (
                    this.MongodbParams == input.MongodbParams ||
                    (this.MongodbParams != null &&
                    this.MongodbParams.Equals(input.MongodbParams))
                ) && 
                (
                    this.NasMountCredentials == input.NasMountCredentials ||
                    (this.NasMountCredentials != null &&
                    this.NasMountCredentials.Equals(input.NasMountCredentials))
                ) && 
                (
                    this.O365Params == input.O365Params ||
                    (this.O365Params != null &&
                    this.O365Params.Equals(input.O365Params))
                ) && 
                (
                    this.Office365CredentialsList == input.Office365CredentialsList ||
                    this.Office365CredentialsList != null &&
                    input.Office365CredentialsList != null &&
                    this.Office365CredentialsList.SequenceEqual(input.Office365CredentialsList)
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
                    this.Office365ServiceAccountCredentialsList.SequenceEqual(input.Office365ServiceAccountCredentialsList)
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
                    this.ProgressMonitorPath == input.ProgressMonitorPath ||
                    (this.ProgressMonitorPath != null &&
                    this.ProgressMonitorPath.Equals(input.ProgressMonitorPath))
                ) && 
                (
                    this.RefreshErrorMessage == input.RefreshErrorMessage ||
                    (this.RefreshErrorMessage != null &&
                    this.RefreshErrorMessage.Equals(input.RefreshErrorMessage))
                ) && 
                (
                    this.RefreshTimeUsecs == input.RefreshTimeUsecs ||
                    (this.RefreshTimeUsecs != null &&
                    this.RefreshTimeUsecs.Equals(input.RefreshTimeUsecs))
                ) && 
                (
                    this.RegisteredAppsInfo == input.RegisteredAppsInfo ||
                    this.RegisteredAppsInfo != null &&
                    input.RegisteredAppsInfo != null &&
                    this.RegisteredAppsInfo.SequenceEqual(input.RegisteredAppsInfo)
                ) && 
                (
                    this.RegistrationTimeUsecs == input.RegistrationTimeUsecs ||
                    (this.RegistrationTimeUsecs != null &&
                    this.RegistrationTimeUsecs.Equals(input.RegistrationTimeUsecs))
                ) && 
                (
                    this.Subnets == input.Subnets ||
                    this.Subnets != null &&
                    input.Subnets != null &&
                    this.Subnets.SequenceEqual(input.Subnets)
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
                    this.ThrottlingPolicyOverrides.SequenceEqual(input.ThrottlingPolicyOverrides)
                ) && 
                (
                    this.UdaParams == input.UdaParams ||
                    (this.UdaParams != null &&
                    this.UdaParams.Equals(input.UdaParams))
                ) && 
                (
                    this.UseOAuthForExchangeOnline == input.UseOAuthForExchangeOnline ||
                    (this.UseOAuthForExchangeOnline != null &&
                    this.UseOAuthForExchangeOnline.Equals(input.UseOAuthForExchangeOnline))
                ) && 
                (
                    this.UseVmBiosUuid == input.UseVmBiosUuid ||
                    (this.UseVmBiosUuid != null &&
                    this.UseVmBiosUuid.Equals(input.UseVmBiosUuid))
                ) && 
                (
                    this.UserMessages == input.UserMessages ||
                    this.UserMessages != null &&
                    input.UserMessages != null &&
                    this.UserMessages.SequenceEqual(input.UserMessages)
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
                    this.WarningMessages == input.WarningMessages ||
                    this.WarningMessages != null &&
                    input.WarningMessages != null &&
                    this.WarningMessages.SequenceEqual(input.WarningMessages)
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
                if (this.AccessInfo != null)
                    hashCode = hashCode * 59 + this.AccessInfo.GetHashCode();
                if (this.AllowedIpAddresses != null)
                    hashCode = hashCode * 59 + this.AllowedIpAddresses.GetHashCode();
                if (this.AuthenticationErrorMessage != null)
                    hashCode = hashCode * 59 + this.AuthenticationErrorMessage.GetHashCode();
                hashCode = hashCode * 59 + this.AuthenticationStatus.GetHashCode();
                if (this.BlacklistedIpAddresses != null)
                    hashCode = hashCode * 59 + this.BlacklistedIpAddresses.GetHashCode();
                if (this.CassandraParams != null)
                    hashCode = hashCode * 59 + this.CassandraParams.GetHashCode();
                if (this.CouchbaseParams != null)
                    hashCode = hashCode * 59 + this.CouchbaseParams.GetHashCode();
                if (this.DeniedIpAddresses != null)
                    hashCode = hashCode * 59 + this.DeniedIpAddresses.GetHashCode();
                hashCode = hashCode * 59 + this.Environments.GetHashCode();
                if (this.HbaseParams != null)
                    hashCode = hashCode * 59 + this.HbaseParams.GetHashCode();
                if (this.HdfsParams != null)
                    hashCode = hashCode * 59 + this.HdfsParams.GetHashCode();
                if (this.HiveParams != null)
                    hashCode = hashCode * 59 + this.HiveParams.GetHashCode();
                if (this.IsDbAuthenticated != null)
                    hashCode = hashCode * 59 + this.IsDbAuthenticated.GetHashCode();
                if (this.IsStorageArraySnapshotEnabled != null)
                    hashCode = hashCode * 59 + this.IsStorageArraySnapshotEnabled.GetHashCode();
                if (this.IsilonParams != null)
                    hashCode = hashCode * 59 + this.IsilonParams.GetHashCode();
                if (this.MinimumFreeSpaceGB != null)
                    hashCode = hashCode * 59 + this.MinimumFreeSpaceGB.GetHashCode();
                if (this.MongodbParams != null)
                    hashCode = hashCode * 59 + this.MongodbParams.GetHashCode();
                if (this.NasMountCredentials != null)
                    hashCode = hashCode * 59 + this.NasMountCredentials.GetHashCode();
                if (this.O365Params != null)
                    hashCode = hashCode * 59 + this.O365Params.GetHashCode();
                if (this.Office365CredentialsList != null)
                    hashCode = hashCode * 59 + this.Office365CredentialsList.GetHashCode();
                if (this.Office365Region != null)
                    hashCode = hashCode * 59 + this.Office365Region.GetHashCode();
                if (this.Office365ServiceAccountCredentialsList != null)
                    hashCode = hashCode * 59 + this.Office365ServiceAccountCredentialsList.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.PhysicalParams != null)
                    hashCode = hashCode * 59 + this.PhysicalParams.GetHashCode();
                if (this.ProgressMonitorPath != null)
                    hashCode = hashCode * 59 + this.ProgressMonitorPath.GetHashCode();
                if (this.RefreshErrorMessage != null)
                    hashCode = hashCode * 59 + this.RefreshErrorMessage.GetHashCode();
                if (this.RefreshTimeUsecs != null)
                    hashCode = hashCode * 59 + this.RefreshTimeUsecs.GetHashCode();
                if (this.RegisteredAppsInfo != null)
                    hashCode = hashCode * 59 + this.RegisteredAppsInfo.GetHashCode();
                if (this.RegistrationTimeUsecs != null)
                    hashCode = hashCode * 59 + this.RegistrationTimeUsecs.GetHashCode();
                if (this.Subnets != null)
                    hashCode = hashCode * 59 + this.Subnets.GetHashCode();
                if (this.ThrottlingPolicy != null)
                    hashCode = hashCode * 59 + this.ThrottlingPolicy.GetHashCode();
                if (this.ThrottlingPolicyOverrides != null)
                    hashCode = hashCode * 59 + this.ThrottlingPolicyOverrides.GetHashCode();
                if (this.UdaParams != null)
                    hashCode = hashCode * 59 + this.UdaParams.GetHashCode();
                if (this.UseOAuthForExchangeOnline != null)
                    hashCode = hashCode * 59 + this.UseOAuthForExchangeOnline.GetHashCode();
                if (this.UseVmBiosUuid != null)
                    hashCode = hashCode * 59 + this.UseVmBiosUuid.GetHashCode();
                if (this.UserMessages != null)
                    hashCode = hashCode * 59 + this.UserMessages.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.VlanParams != null)
                    hashCode = hashCode * 59 + this.VlanParams.GetHashCode();
                if (this.WarningMessages != null)
                    hashCode = hashCode * 59 + this.WarningMessages.GetHashCode();
                return hashCode;
            }
        }

    }

}


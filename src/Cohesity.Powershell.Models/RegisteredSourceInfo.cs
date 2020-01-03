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
        /// Specifies the status of the authenticating to the Protection Source when registering it with Cohesity Cluster. If the status is &#39;kFinished&#39; and there is no error, registration is successful. Specifies the status of the authentication during the registration of a Protection Source. &#39;kPending&#39; indicates the authentication is in progress. &#39;kScheduled&#39; indicates the authentication is scheduled. &#39;kFinished&#39; indicates the authentication is completed. &#39;kRefreshInProgress&#39; indicates the refresh is in progres.
        /// </summary>
        /// <value>Specifies the status of the authenticating to the Protection Source when registering it with Cohesity Cluster. If the status is &#39;kFinished&#39; and there is no error, registration is successful. Specifies the status of the authentication during the registration of a Protection Source. &#39;kPending&#39; indicates the authentication is in progress. &#39;kScheduled&#39; indicates the authentication is scheduled. &#39;kFinished&#39; indicates the authentication is completed. &#39;kRefreshInProgress&#39; indicates the refresh is in progres.</value>
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
        /// Specifies the status of the authenticating to the Protection Source when registering it with Cohesity Cluster. If the status is &#39;kFinished&#39; and there is no error, registration is successful. Specifies the status of the authentication during the registration of a Protection Source. &#39;kPending&#39; indicates the authentication is in progress. &#39;kScheduled&#39; indicates the authentication is scheduled. &#39;kFinished&#39; indicates the authentication is completed. &#39;kRefreshInProgress&#39; indicates the refresh is in progres.
        /// </summary>
        /// <value>Specifies the status of the authenticating to the Protection Source when registering it with Cohesity Cluster. If the status is &#39;kFinished&#39; and there is no error, registration is successful. Specifies the status of the authentication during the registration of a Protection Source. &#39;kPending&#39; indicates the authentication is in progress. &#39;kScheduled&#39; indicates the authentication is scheduled. &#39;kFinished&#39; indicates the authentication is completed. &#39;kRefreshInProgress&#39; indicates the refresh is in progres.</value>
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
        /// Specifies a list of applications environment that are registered with this Protection Source such as &#39;kSQL&#39;. Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;Nimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Genreric Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhsicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kVCD&#39; indicates the VMware&#39;s Virtual cloud Director Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment.
        /// </summary>
        /// <value>Specifies a list of applications environment that are registered with this Protection Source such as &#39;kSQL&#39;. Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;Nimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Genreric Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhsicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kVCD&#39; indicates the VMware&#39;s Virtual cloud Director Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment.</value>
        [DataMember(Name="environments", EmitDefaultValue=true)]
        public List<EnvironmentsEnum> Environments { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisteredSourceInfo" /> class.
        /// </summary>
        /// <param name="accessInfo">accessInfo.</param>
        /// <param name="authenticationErrorMessage">Specifies an authentication error message. This indicates the given credentials are rejected and the registration of the source is not successful..</param>
        /// <param name="authenticationStatus">Specifies the status of the authenticating to the Protection Source when registering it with Cohesity Cluster. If the status is &#39;kFinished&#39; and there is no error, registration is successful. Specifies the status of the authentication during the registration of a Protection Source. &#39;kPending&#39; indicates the authentication is in progress. &#39;kScheduled&#39; indicates the authentication is scheduled. &#39;kFinished&#39; indicates the authentication is completed. &#39;kRefreshInProgress&#39; indicates the refresh is in progres..</param>
        /// <param name="environments">Specifies a list of applications environment that are registered with this Protection Source such as &#39;kSQL&#39;. Supported environment types such as &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, etc. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter. &#39;kVMware&#39; indicates the VMware Protection Source environment. &#39;kHyperV&#39; indicates the HyperV Protection Source environment. &#39;kSQL&#39; indicates the SQL Protection Source environment. &#39;kView&#39; indicates the View Protection Source environment. &#39;kPuppeteer&#39; indicates the Cohesity&#39;s Remote Adapter. &#39;kPhysical&#39; indicates the physical Protection Source environment. &#39;kPure&#39; indicates the Pure Storage Protection Source environment. &#39;Nimble&#39; indicates the Nimble Storage Protection Source environment. &#39;kAzure&#39; indicates the Microsoft&#39;s Azure Protection Source environment. &#39;kNetapp&#39; indicates the Netapp Protection Source environment. &#39;kAgent&#39; indicates the Agent Protection Source environment. &#39;kGenericNas&#39; indicates the Genreric Network Attached Storage Protection Source environment. &#39;kAcropolis&#39; indicates the Acropolis Protection Source environment. &#39;kPhsicalFiles&#39; indicates the Physical Files Protection Source environment. &#39;kIsilon&#39; indicates the Dell EMC&#39;s Isilon Protection Source environment. &#39;kGPFS&#39; indicates IBM&#39;s GPFS Protection Source environment. &#39;kKVM&#39; indicates the KVM Protection Source environment. &#39;kAWS&#39; indicates the AWS Protection Source environment. &#39;kExchange&#39; indicates the Exchange Protection Source environment. &#39;kHyperVVSS&#39; indicates the HyperV VSS Protection Source environment. &#39;kOracle&#39; indicates the Oracle Protection Source environment. &#39;kGCP&#39; indicates the Google Cloud Platform Protection Source environment. &#39;kFlashBlade&#39; indicates the Flash Blade Protection Source environment. &#39;kAWSNative&#39; indicates the AWS Native Protection Source environment. &#39;kVCD&#39; indicates the VMware&#39;s Virtual cloud Director Protection Source environment. &#39;kO365&#39; indicates the Office 365 Protection Source environment. &#39;kO365Outlook&#39; indicates Office 365 outlook Protection Source environment. &#39;kHyperFlex&#39; indicates the Hyper Flex Protection Source environment. &#39;kGCPNative&#39; indicates the GCP Native Protection Source environment. &#39;kAzureNative&#39; indicates the Azure Native Protection Source environment. &#39;kKubernetes&#39; indicates a Kubernetes Protection Source environment. &#39;kElastifile&#39; indicates Elastifile Protection Source environment..</param>
        /// <param name="isDbAuthenticated">Specifies if application entity dbAuthenticated or not. ex: oracle database..</param>
        /// <param name="minimumFreeSpaceGB">Specifies the minimum free space in GiB of the space expected to be available on the datastore where the virtual disks of the VM being backed up. If the amount of free space(in GiB) is lower than the value given by this field, backup will be aborted. Note that this field is applicable only to &#39;kVMware&#39; type of environments..</param>
        /// <param name="nasMountCredentials">Specifies the credentials required to mount directories on the NetApp server if given..</param>
        /// <param name="office365Credentials">office365Credentials.</param>
        /// <param name="password">Specifies password of the username to access the target source..</param>
        /// <param name="refreshErrorMessage">Specifies a message if there was any error encountered during the last rebuild of the Protection Source tree. If there was no error during the last rebuild, this field is reset..</param>
        /// <param name="refreshTimeUsecs">Specifies the Unix epoch time (in microseconds) when the Protection Source tree was most recently fetched and built..</param>
        /// <param name="registeredAppsInfo">Specifies information of the applications registered on this protection source..</param>
        /// <param name="registrationTimeUsecs">Specifies the Unix epoch time (in microseconds) when the Protection Source was registered..</param>
        /// <param name="throttlingPolicy">throttlingPolicy.</param>
        /// <param name="throttlingPolicyOverrides">Array of Throttling Policy Overrides for Datastores.  Specifies a list of Throttling Policy for datastores that override the common throttling policy specified for the registered Protection Source. For datastores not in this list, common policy will still apply..</param>
        /// <param name="useVmBiosUuid">Specifies if registered vCenter is using BIOS UUID to track virtual machines..</param>
        /// <param name="username">Specifies username to access the target source..</param>
        /// <param name="warningMessages">Specifies a list of warnings encountered during registration. Though the registration may succeed, warning messages imply the host environment requires some cleanup or fixing..</param>
        public RegisteredSourceInfo(ConnectorParameters accessInfo = default(ConnectorParameters), string authenticationErrorMessage = default(string), AuthenticationStatusEnum? authenticationStatus = default(AuthenticationStatusEnum?), List<EnvironmentsEnum> environments = default(List<EnvironmentsEnum>), bool? isDbAuthenticated = default(bool?), long? minimumFreeSpaceGB = default(long?), NasMountCredentialParams nasMountCredentials = default(NasMountCredentialParams), Office365Credentials office365Credentials = default(Office365Credentials), string password = default(string), string refreshErrorMessage = default(string), long? refreshTimeUsecs = default(long?), List<RegisteredAppInfo> registeredAppsInfo = default(List<RegisteredAppInfo>), long? registrationTimeUsecs = default(long?), ThrottlingPolicyParameters throttlingPolicy = default(ThrottlingPolicyParameters), List<ThrottlingPolicyOverride> throttlingPolicyOverrides = default(List<ThrottlingPolicyOverride>), bool? useVmBiosUuid = default(bool?), string username = default(string), List<string> warningMessages = default(List<string>))
        {
            this.AuthenticationErrorMessage = authenticationErrorMessage;
            this.AuthenticationStatus = authenticationStatus;
            this.Environments = environments;
            this.IsDbAuthenticated = isDbAuthenticated;
            this.MinimumFreeSpaceGB = minimumFreeSpaceGB;
            this.NasMountCredentials = nasMountCredentials;
            this.Password = password;
            this.RefreshErrorMessage = refreshErrorMessage;
            this.RefreshTimeUsecs = refreshTimeUsecs;
            this.RegisteredAppsInfo = registeredAppsInfo;
            this.RegistrationTimeUsecs = registrationTimeUsecs;
            this.ThrottlingPolicyOverrides = throttlingPolicyOverrides;
            this.UseVmBiosUuid = useVmBiosUuid;
            this.Username = username;
            this.WarningMessages = warningMessages;
            this.AccessInfo = accessInfo;
            this.AuthenticationErrorMessage = authenticationErrorMessage;
            this.AuthenticationStatus = authenticationStatus;
            this.Environments = environments;
            this.IsDbAuthenticated = isDbAuthenticated;
            this.MinimumFreeSpaceGB = minimumFreeSpaceGB;
            this.NasMountCredentials = nasMountCredentials;
            this.Office365Credentials = office365Credentials;
            this.Password = password;
            this.RefreshErrorMessage = refreshErrorMessage;
            this.RefreshTimeUsecs = refreshTimeUsecs;
            this.RegisteredAppsInfo = registeredAppsInfo;
            this.RegistrationTimeUsecs = registrationTimeUsecs;
            this.ThrottlingPolicy = throttlingPolicy;
            this.ThrottlingPolicyOverrides = throttlingPolicyOverrides;
            this.UseVmBiosUuid = useVmBiosUuid;
            this.Username = username;
            this.WarningMessages = warningMessages;
        }
        
        /// <summary>
        /// Gets or Sets AccessInfo
        /// </summary>
        [DataMember(Name="accessInfo", EmitDefaultValue=false)]
        public ConnectorParameters AccessInfo { get; set; }

        /// <summary>
        /// Specifies an authentication error message. This indicates the given credentials are rejected and the registration of the source is not successful.
        /// </summary>
        /// <value>Specifies an authentication error message. This indicates the given credentials are rejected and the registration of the source is not successful.</value>
        [DataMember(Name="authenticationErrorMessage", EmitDefaultValue=true)]
        public string AuthenticationErrorMessage { get; set; }

        /// <summary>
        /// Specifies if application entity dbAuthenticated or not. ex: oracle database.
        /// </summary>
        /// <value>Specifies if application entity dbAuthenticated or not. ex: oracle database.</value>
        [DataMember(Name="isDbAuthenticated", EmitDefaultValue=true)]
        public bool? IsDbAuthenticated { get; set; }

        /// <summary>
        /// Specifies the minimum free space in GiB of the space expected to be available on the datastore where the virtual disks of the VM being backed up. If the amount of free space(in GiB) is lower than the value given by this field, backup will be aborted. Note that this field is applicable only to &#39;kVMware&#39; type of environments.
        /// </summary>
        /// <value>Specifies the minimum free space in GiB of the space expected to be available on the datastore where the virtual disks of the VM being backed up. If the amount of free space(in GiB) is lower than the value given by this field, backup will be aborted. Note that this field is applicable only to &#39;kVMware&#39; type of environments.</value>
        [DataMember(Name="minimumFreeSpaceGB", EmitDefaultValue=true)]
        public long? MinimumFreeSpaceGB { get; set; }

        /// <summary>
        /// Specifies the credentials required to mount directories on the NetApp server if given.
        /// </summary>
        /// <value>Specifies the credentials required to mount directories on the NetApp server if given.</value>
        [DataMember(Name="nasMountCredentials", EmitDefaultValue=true)]
        public NasMountCredentialParams NasMountCredentials { get; set; }

        /// <summary>
        /// Gets or Sets Office365Credentials
        /// </summary>
        [DataMember(Name="office365Credentials", EmitDefaultValue=false)]
        public Office365Credentials Office365Credentials { get; set; }

        /// <summary>
        /// Specifies password of the username to access the target source.
        /// </summary>
        /// <value>Specifies password of the username to access the target source.</value>
        [DataMember(Name="password", EmitDefaultValue=true)]
        public string Password { get; set; }

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
        /// Specifies if registered vCenter is using BIOS UUID to track virtual machines.
        /// </summary>
        /// <value>Specifies if registered vCenter is using BIOS UUID to track virtual machines.</value>
        [DataMember(Name="useVmBiosUuid", EmitDefaultValue=true)]
        public bool? UseVmBiosUuid { get; set; }

        /// <summary>
        /// Specifies username to access the target source.
        /// </summary>
        /// <value>Specifies username to access the target source.</value>
        [DataMember(Name="username", EmitDefaultValue=true)]
        public string Username { get; set; }

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
                    this.AuthenticationErrorMessage == input.AuthenticationErrorMessage ||
                    (this.AuthenticationErrorMessage != null &&
                    this.AuthenticationErrorMessage.Equals(input.AuthenticationErrorMessage))
                ) && 
                (
                    this.AuthenticationStatus == input.AuthenticationStatus ||
                    this.AuthenticationStatus.Equals(input.AuthenticationStatus)
                ) && 
                (
                    this.Environments == input.Environments ||
                    this.Environments.SequenceEqual(input.Environments)
                ) && 
                (
                    this.IsDbAuthenticated == input.IsDbAuthenticated ||
                    (this.IsDbAuthenticated != null &&
                    this.IsDbAuthenticated.Equals(input.IsDbAuthenticated))
                ) && 
                (
                    this.MinimumFreeSpaceGB == input.MinimumFreeSpaceGB ||
                    (this.MinimumFreeSpaceGB != null &&
                    this.MinimumFreeSpaceGB.Equals(input.MinimumFreeSpaceGB))
                ) && 
                (
                    this.NasMountCredentials == input.NasMountCredentials ||
                    (this.NasMountCredentials != null &&
                    this.NasMountCredentials.Equals(input.NasMountCredentials))
                ) && 
                (
                    this.Office365Credentials == input.Office365Credentials ||
                    (this.Office365Credentials != null &&
                    this.Office365Credentials.Equals(input.Office365Credentials))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
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
                    this.UseVmBiosUuid == input.UseVmBiosUuid ||
                    (this.UseVmBiosUuid != null &&
                    this.UseVmBiosUuid.Equals(input.UseVmBiosUuid))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                if (this.AuthenticationErrorMessage != null)
                    hashCode = hashCode * 59 + this.AuthenticationErrorMessage.GetHashCode();
                hashCode = hashCode * 59 + this.AuthenticationStatus.GetHashCode();
                hashCode = hashCode * 59 + this.Environments.GetHashCode();
                if (this.IsDbAuthenticated != null)
                    hashCode = hashCode * 59 + this.IsDbAuthenticated.GetHashCode();
                if (this.MinimumFreeSpaceGB != null)
                    hashCode = hashCode * 59 + this.MinimumFreeSpaceGB.GetHashCode();
                if (this.NasMountCredentials != null)
                    hashCode = hashCode * 59 + this.NasMountCredentials.GetHashCode();
                if (this.Office365Credentials != null)
                    hashCode = hashCode * 59 + this.Office365Credentials.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.RefreshErrorMessage != null)
                    hashCode = hashCode * 59 + this.RefreshErrorMessage.GetHashCode();
                if (this.RefreshTimeUsecs != null)
                    hashCode = hashCode * 59 + this.RefreshTimeUsecs.GetHashCode();
                if (this.RegisteredAppsInfo != null)
                    hashCode = hashCode * 59 + this.RegisteredAppsInfo.GetHashCode();
                if (this.RegistrationTimeUsecs != null)
                    hashCode = hashCode * 59 + this.RegistrationTimeUsecs.GetHashCode();
                if (this.ThrottlingPolicy != null)
                    hashCode = hashCode * 59 + this.ThrottlingPolicy.GetHashCode();
                if (this.ThrottlingPolicyOverrides != null)
                    hashCode = hashCode * 59 + this.ThrottlingPolicyOverrides.GetHashCode();
                if (this.UseVmBiosUuid != null)
                    hashCode = hashCode * 59 + this.UseVmBiosUuid.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.WarningMessages != null)
                    hashCode = hashCode * 59 + this.WarningMessages.GetHashCode();
                return hashCode;
            }
        }

    }

}


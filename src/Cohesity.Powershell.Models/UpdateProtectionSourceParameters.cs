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
    /// UpdateProtectionSourceParameters defines a public data definition for updating protection source.
    /// </summary>
    [DataContract]
    public partial class UpdateProtectionSourceParameters :  IEquatable<UpdateProtectionSourceParameters>
    {
        /// <summary>
        /// Specifies the optional OS type of the Protection Source (such as kWindows or kLinux). overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kSapOracle&#39; indicates the Sap Oracle database system developed by SAP SE. &#39;kCockroachDB&#39; indicates the CockroachDB database system. &#39;kMySQL&#39; indicates the MySQL database system. &#39;kSapSybase&#39; indicates the SapSybase database system. &#39;kSapMaxDB&#39; indicates the SapMaxDB database system. &#39;kSapSybaseIQ&#39; indicates the SapSybaseIQ database system. &#39;kDB2&#39; indicates the DB2 database system. &#39;kSapASE&#39; indicates the SapASE database system. &#39;kMariaDB&#39; indicates the MariaDB database system. &#39;kPostgreSQL&#39; indicates the PostgreSQL database system. &#39;kHPUX&#39; indicates the HPUX database system. &#39;kVOS&#39; indicates the VOS database system. &#39;kOther&#39; indicates the other types of operating system.
        /// </summary>
        /// <value>Specifies the optional OS type of the Protection Source (such as kWindows or kLinux). overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kSapOracle&#39; indicates the Sap Oracle database system developed by SAP SE. &#39;kCockroachDB&#39; indicates the CockroachDB database system. &#39;kMySQL&#39; indicates the MySQL database system. &#39;kSapSybase&#39; indicates the SapSybase database system. &#39;kSapMaxDB&#39; indicates the SapMaxDB database system. &#39;kSapSybaseIQ&#39; indicates the SapSybaseIQ database system. &#39;kDB2&#39; indicates the DB2 database system. &#39;kSapASE&#39; indicates the SapASE database system. &#39;kMariaDB&#39; indicates the MariaDB database system. &#39;kPostgreSQL&#39; indicates the PostgreSQL database system. &#39;kHPUX&#39; indicates the HPUX database system. &#39;kVOS&#39; indicates the VOS database system. &#39;kOther&#39; indicates the other types of operating system.</value>
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
            KOther = 9,

            /// <summary>
            /// Enum KSapSybase for value: kSapSybase
            /// </summary>
            [EnumMember(Value = "kSapSybase")]
            KSapSybase = 10,

            /// <summary>
            /// Enum KSapMaxDB for value: kSapMaxDB
            /// </summary>
            [EnumMember(Value = "kSapMaxDB")]
            KSapMaxDB = 11,

            /// <summary>
            /// Enum KSapSybaseIQ for value: kSapSybaseIQ
            /// </summary>
            [EnumMember(Value = "kSapSybaseIQ")]
            KSapSybaseIQ = 12,

            /// <summary>
            /// Enum KDB2 for value: kDB2
            /// </summary>
            [EnumMember(Value = "kDB2")]
            KDB2 = 13,

            /// <summary>
            /// Enum KSapASE for value: kSapASE
            /// </summary>
            [EnumMember(Value = "kSapASE")]
            KSapASE = 14,

            /// <summary>
            /// Enum KMariaDB for value: kMariaDB
            /// </summary>
            [EnumMember(Value = "kMariaDB")]
            KMariaDB = 15,

            /// <summary>
            /// Enum KPostgreSQL for value: kPostgreSQL
            /// </summary>
            [EnumMember(Value = "kPostgreSQL")]
            KPostgreSQL = 16,

            /// <summary>
            /// Enum KVOS for value: kVOS
            /// </summary>
            [EnumMember(Value = "kVOS")]
            KVOS = 17,

            /// <summary>
            /// Enum KHPUX for value: kHPUX
            /// </summary>
            [EnumMember(Value = "kHPUX")]
            KHPUX = 18

        }

        /// <summary>
        /// Specifies the optional OS type of the Protection Source (such as kWindows or kLinux). overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kSapOracle&#39; indicates the Sap Oracle database system developed by SAP SE. &#39;kCockroachDB&#39; indicates the CockroachDB database system. &#39;kMySQL&#39; indicates the MySQL database system. &#39;kSapSybase&#39; indicates the SapSybase database system. &#39;kSapMaxDB&#39; indicates the SapMaxDB database system. &#39;kSapSybaseIQ&#39; indicates the SapSybaseIQ database system. &#39;kDB2&#39; indicates the DB2 database system. &#39;kSapASE&#39; indicates the SapASE database system. &#39;kMariaDB&#39; indicates the MariaDB database system. &#39;kPostgreSQL&#39; indicates the PostgreSQL database system. &#39;kHPUX&#39; indicates the HPUX database system. &#39;kVOS&#39; indicates the VOS database system. &#39;kOther&#39; indicates the other types of operating system.
        /// </summary>
        /// <value>Specifies the optional OS type of the Protection Source (such as kWindows or kLinux). overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kSapOracle&#39; indicates the Sap Oracle database system developed by SAP SE. &#39;kCockroachDB&#39; indicates the CockroachDB database system. &#39;kMySQL&#39; indicates the MySQL database system. &#39;kSapSybase&#39; indicates the SapSybase database system. &#39;kSapMaxDB&#39; indicates the SapMaxDB database system. &#39;kSapSybaseIQ&#39; indicates the SapSybaseIQ database system. &#39;kDB2&#39; indicates the DB2 database system. &#39;kSapASE&#39; indicates the SapASE database system. &#39;kMariaDB&#39; indicates the MariaDB database system. &#39;kPostgreSQL&#39; indicates the PostgreSQL database system. &#39;kHPUX&#39; indicates the HPUX database system. &#39;kVOS&#39; indicates the VOS database system. &#39;kOther&#39; indicates the other types of operating system.</value>
        [DataMember(Name="hostType", EmitDefaultValue=true)]
        public HostTypeEnum? HostType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProtectionSourceParameters" /> class.
        /// </summary>
        /// <param name="isStorageArraySnapshotEnabled">Specifies if this source entity has enabled storage array snapshot or not..</param>
        /// <param name="agentEndpoint">Specifies the agent endpoint if it is different from the source endpoint..</param>
        /// <param name="allowedIpAddresses">Specifies the list of IP Addresses on the registered source to be exclusively allowed for doing any type of IO operations..</param>
        /// <param name="awsCredentials">awsCredentials.</param>
        /// <param name="awsFleetParams">awsFleetParams.</param>
        /// <param name="azureCredentials">azureCredentials.</param>
        /// <param name="blacklistedIpAddresses">This field is deprecated. Use DeniedIpAddresses instead. deprecated: true.</param>
        /// <param name="clusterNetworkInfo">clusterNetworkInfo.</param>
        /// <param name="connectionId">Specifies the Bifrost realm to be associated with the source root. Whenever needed, the workflows related to this source would then only use Bifrosts from the specified realm..</param>
        /// <param name="deniedIpAddresses">Specifies the list of IP Addresses on the registered source to be denied for doing any type of IO operations..</param>
        /// <param name="endpoint">Specifies the network endpoint of the Protection Source where it is reachable. It could be an URL or hostname or an IP address of the Protection Source..</param>
        /// <param name="exchangeDagProtectionPreference">exchangeDagProtectionPreference.</param>
        /// <param name="forceRegister">ForceRegister is applicable to Physical Environment. By default, the agent running on a physical host will fail the registration, if it is already registered as part of another cluster. By setting this option to true, agent can be forced to register with the current cluster. This is a hidden parameter and should not be documented externally..</param>
        /// <param name="gcpCredentials">gcpCredentials.</param>
        /// <param name="gcpFleetParams">gcpFleetParams.</param>
        /// <param name="hostType">Specifies the optional OS type of the Protection Source (such as kWindows or kLinux). overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kSapOracle&#39; indicates the Sap Oracle database system developed by SAP SE. &#39;kCockroachDB&#39; indicates the CockroachDB database system. &#39;kMySQL&#39; indicates the MySQL database system. &#39;kSapSybase&#39; indicates the SapSybase database system. &#39;kSapMaxDB&#39; indicates the SapMaxDB database system. &#39;kSapSybaseIQ&#39; indicates the SapSybaseIQ database system. &#39;kDB2&#39; indicates the DB2 database system. &#39;kSapASE&#39; indicates the SapASE database system. &#39;kMariaDB&#39; indicates the MariaDB database system. &#39;kPostgreSQL&#39; indicates the PostgreSQL database system. &#39;kHPUX&#39; indicates the HPUX database system. &#39;kVOS&#39; indicates the VOS database system. &#39;kOther&#39; indicates the other types of operating system..</param>
        /// <param name="isProxyHost">Specifies if the physical host has to be registered as a proxy host..</param>
        /// <param name="isilonParams">isilonParams.</param>
        /// <param name="kubernetesCredentials">kubernetesCredentials.</param>
        /// <param name="kubernetesParams">kubernetesParams.</param>
        /// <param name="minimumFreeSpaceGB">Specifies the minimum space in GB after which backup jobs will be canceled due to low space..</param>
        /// <param name="nasMountCredentials">Specifies the server credentials to connect to a NetApp server. This field is required for mounting SMB volumes on NetApp servers..</param>
        /// <param name="office365CredentialsList">Office365 Source Credentials.  Specifies credentials needed to authenticate &amp; authorize user for Office365 using MS Graph APIs..</param>
        /// <param name="office365Region">Specifies the region for Office365..</param>
        /// <param name="office365ServiceAccountCredentialsList">Office365 Service Account Credentials.  Specifies credentials for improving mailbox backup performance for O365..</param>
        /// <param name="password">Specifies password of the username to access the target source..</param>
        /// <param name="proxyHostSourceIdList">Specifies the list of the protection source id of the windows physical host which will be used during the protection and recovery of the sites that belong to a office365 domain..</param>
        /// <param name="reRegister">ReRegister is applicable to Physical Environment. By default, the agent running on a physical host will fail the registration, if it is already registered with the cluster. By setting this option to true, agent can be re-registered with the current cluster..</param>
        /// <param name="restoreConfig">RestoreConfig is applicable to Physical Environment. The ReRegister option needs to be true if RestoreConfig is true. By setting this option to true, the agent configuration can be restored..</param>
        /// <param name="sourceSideDedupEnabled">This controls whether to use source side dedup on the source or not. This is only applicable to sources which support source side dedup (e.g., Linux physical servers)..</param>
        /// <param name="sslVerification">sslVerification.</param>
        /// <param name="subnets">Specifies the list of subnet IP addresses and CIDR prefix for enabeling network data transfer. Currently, only Subnet IP and NetbaskBits are valid input fields. All other fields provided as input will be ignored..</param>
        /// <param name="throttlingPolicy">Specifies the throttling policy that should be applied to this Source..</param>
        /// <param name="throttlingPolicyOverrides">Array of Throttling Policy Overrides for Datastores.  Specifies a list of Throttling Policy for datastores that override the common throttling policy specified for the registered Protection Source. For datastores not in this list, common policy will still apply..</param>
        /// <param name="useExistingCredentials">Specifies whether to use existing Office365 credentials like password and client secret for app id&#39;s..</param>
        /// <param name="useOAuthForExchangeOnline">Specifies whether OAuth should be used for authentication in case of Exchange Online..</param>
        /// <param name="username">Specifies username to access the target source..</param>
        /// <param name="vlanParams">vlanParams.</param>
        public UpdateProtectionSourceParameters(bool? isStorageArraySnapshotEnabled = default(bool?), string agentEndpoint = default(string), List<string> allowedIpAddresses = default(List<string>), AwsCredentials awsCredentials = default(AwsCredentials), AwsFleetPublicParams awsFleetParams = default(AwsFleetPublicParams), AzureCredentials azureCredentials = default(AzureCredentials), List<string> blacklistedIpAddresses = default(List<string>), FleetNetworkParams clusterNetworkInfo = default(FleetNetworkParams), long? connectionId = default(long?), List<string> deniedIpAddresses = default(List<string>), string endpoint = default(string), ExchangeDAGProtectionPreference exchangeDagProtectionPreference = default(ExchangeDAGProtectionPreference), bool? forceRegister = default(bool?), GcpCredentials gcpCredentials = default(GcpCredentials), GcpFleetParams gcpFleetParams = default(GcpFleetParams), HostTypeEnum? hostType = default(HostTypeEnum?), bool? isProxyHost = default(bool?), RegisteredProtectionSourceIsilonParams isilonParams = default(RegisteredProtectionSourceIsilonParams), KubernetesCredentials kubernetesCredentials = default(KubernetesCredentials), KubernetesParams kubernetesParams = default(KubernetesParams), long? minimumFreeSpaceGB = default(long?), NasMountCredentialParams nasMountCredentials = default(NasMountCredentialParams), List<Office365Credentials> office365CredentialsList = default(List<Office365Credentials>), string office365Region = default(string), List<Credentials> office365ServiceAccountCredentialsList = default(List<Credentials>), string password = default(string), List<long> proxyHostSourceIdList = default(List<long>), bool? reRegister = default(bool?), bool? restoreConfig = default(bool?), bool? sourceSideDedupEnabled = default(bool?), SslVerification sslVerification = default(SslVerification), List<Subnet> subnets = default(List<Subnet>), ThrottlingPolicyParameters throttlingPolicy = default(ThrottlingPolicyParameters), List<ThrottlingPolicyOverride> throttlingPolicyOverrides = default(List<ThrottlingPolicyOverride>), bool? useExistingCredentials = default(bool?), bool? useOAuthForExchangeOnline = default(bool?), string username = default(string), VlanParameters vlanParams = default(VlanParameters))
        {
            this.IsStorageArraySnapshotEnabled = isStorageArraySnapshotEnabled;
            this.AgentEndpoint = agentEndpoint;
            this.AllowedIpAddresses = allowedIpAddresses;
            this.BlacklistedIpAddresses = blacklistedIpAddresses;
            this.ConnectionId = connectionId;
            this.DeniedIpAddresses = deniedIpAddresses;
            this.Endpoint = endpoint;
            this.ForceRegister = forceRegister;
            this.HostType = hostType;
            this.IsProxyHost = isProxyHost;
            this.MinimumFreeSpaceGB = minimumFreeSpaceGB;
            this.NasMountCredentials = nasMountCredentials;
            this.Office365CredentialsList = office365CredentialsList;
            this.Office365Region = office365Region;
            this.Office365ServiceAccountCredentialsList = office365ServiceAccountCredentialsList;
            this.Password = password;
            this.ProxyHostSourceIdList = proxyHostSourceIdList;
            this.ReRegister = reRegister;
            this.RestoreConfig = restoreConfig;
            this.SourceSideDedupEnabled = sourceSideDedupEnabled;
            this.Subnets = subnets;
            this.ThrottlingPolicy = throttlingPolicy;
            this.ThrottlingPolicyOverrides = throttlingPolicyOverrides;
            this.UseExistingCredentials = useExistingCredentials;
            this.UseOAuthForExchangeOnline = useOAuthForExchangeOnline;
            this.Username = username;
            this.IsStorageArraySnapshotEnabled = isStorageArraySnapshotEnabled;
            this.AgentEndpoint = agentEndpoint;
            this.AllowedIpAddresses = allowedIpAddresses;
            this.AwsCredentials = awsCredentials;
            this.AwsFleetParams = awsFleetParams;
            this.AzureCredentials = azureCredentials;
            this.BlacklistedIpAddresses = blacklistedIpAddresses;
            this.ClusterNetworkInfo = clusterNetworkInfo;
            this.ConnectionId = connectionId;
            this.DeniedIpAddresses = deniedIpAddresses;
            this.Endpoint = endpoint;
            this.ExchangeDagProtectionPreference = exchangeDagProtectionPreference;
            this.ForceRegister = forceRegister;
            this.GcpCredentials = gcpCredentials;
            this.GcpFleetParams = gcpFleetParams;
            this.HostType = hostType;
            this.IsProxyHost = isProxyHost;
            this.IsilonParams = isilonParams;
            this.KubernetesCredentials = kubernetesCredentials;
            this.KubernetesParams = kubernetesParams;
            this.MinimumFreeSpaceGB = minimumFreeSpaceGB;
            this.NasMountCredentials = nasMountCredentials;
            this.Office365CredentialsList = office365CredentialsList;
            this.Office365Region = office365Region;
            this.Office365ServiceAccountCredentialsList = office365ServiceAccountCredentialsList;
            this.Password = password;
            this.ProxyHostSourceIdList = proxyHostSourceIdList;
            this.ReRegister = reRegister;
            this.RestoreConfig = restoreConfig;
            this.SourceSideDedupEnabled = sourceSideDedupEnabled;
            this.SslVerification = sslVerification;
            this.Subnets = subnets;
            this.ThrottlingPolicy = throttlingPolicy;
            this.ThrottlingPolicyOverrides = throttlingPolicyOverrides;
            this.UseExistingCredentials = useExistingCredentials;
            this.UseOAuthForExchangeOnline = useOAuthForExchangeOnline;
            this.Username = username;
            this.VlanParams = vlanParams;
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
        public AwsFleetPublicParams AwsFleetParams { get; set; }

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
        /// Specifies the Bifrost realm to be associated with the source root. Whenever needed, the workflows related to this source would then only use Bifrosts from the specified realm.
        /// </summary>
        /// <value>Specifies the Bifrost realm to be associated with the source root. Whenever needed, the workflows related to this source would then only use Bifrosts from the specified realm.</value>
        [DataMember(Name="connectionId", EmitDefaultValue=true)]
        public long? ConnectionId { get; set; }

        /// <summary>
        /// Specifies the list of IP Addresses on the registered source to be denied for doing any type of IO operations.
        /// </summary>
        /// <value>Specifies the list of IP Addresses on the registered source to be denied for doing any type of IO operations.</value>
        [DataMember(Name="deniedIpAddresses", EmitDefaultValue=true)]
        public List<string> DeniedIpAddresses { get; set; }

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
        /// Gets or Sets GcpFleetParams
        /// </summary>
        [DataMember(Name="gcpFleetParams", EmitDefaultValue=false)]
        public GcpFleetParams GcpFleetParams { get; set; }

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
        /// Specifies the minimum space in GB after which backup jobs will be canceled due to low space.
        /// </summary>
        /// <value>Specifies the minimum space in GB after which backup jobs will be canceled due to low space.</value>
        [DataMember(Name="minimumFreeSpaceGB", EmitDefaultValue=true)]
        public long? MinimumFreeSpaceGB { get; set; }

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
        /// Specifies the list of the protection source id of the windows physical host which will be used during the protection and recovery of the sites that belong to a office365 domain.
        /// </summary>
        /// <value>Specifies the list of the protection source id of the windows physical host which will be used during the protection and recovery of the sites that belong to a office365 domain.</value>
        [DataMember(Name="proxyHostSourceIdList", EmitDefaultValue=true)]
        public List<long> ProxyHostSourceIdList { get; set; }

        /// <summary>
        /// ReRegister is applicable to Physical Environment. By default, the agent running on a physical host will fail the registration, if it is already registered with the cluster. By setting this option to true, agent can be re-registered with the current cluster.
        /// </summary>
        /// <value>ReRegister is applicable to Physical Environment. By default, the agent running on a physical host will fail the registration, if it is already registered with the cluster. By setting this option to true, agent can be re-registered with the current cluster.</value>
        [DataMember(Name="reRegister", EmitDefaultValue=true)]
        public bool? ReRegister { get; set; }

        /// <summary>
        /// RestoreConfig is applicable to Physical Environment. The ReRegister option needs to be true if RestoreConfig is true. By setting this option to true, the agent configuration can be restored.
        /// </summary>
        /// <value>RestoreConfig is applicable to Physical Environment. The ReRegister option needs to be true if RestoreConfig is true. By setting this option to true, the agent configuration can be restored.</value>
        [DataMember(Name="restoreConfig", EmitDefaultValue=true)]
        public bool? RestoreConfig { get; set; }

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
            return this.Equals(input as UpdateProtectionSourceParameters);
        }

        /// <summary>
        /// Returns true if UpdateProtectionSourceParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateProtectionSourceParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateProtectionSourceParameters input)
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
                    this.AgentEndpoint == input.AgentEndpoint ||
                    (this.AgentEndpoint != null &&
                    this.AgentEndpoint.Equals(input.AgentEndpoint))
                ) && 
                (
                    this.AllowedIpAddresses == input.AllowedIpAddresses ||
                    this.AllowedIpAddresses != null &&
                    input.AllowedIpAddresses != null &&
                    this.AllowedIpAddresses.SequenceEqual(input.AllowedIpAddresses)
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
                    this.BlacklistedIpAddresses.SequenceEqual(input.BlacklistedIpAddresses)
                ) && 
                (
                    this.ClusterNetworkInfo == input.ClusterNetworkInfo ||
                    (this.ClusterNetworkInfo != null &&
                    this.ClusterNetworkInfo.Equals(input.ClusterNetworkInfo))
                ) && 
                (
                    this.ConnectionId == input.ConnectionId ||
                    (this.ConnectionId != null &&
                    this.ConnectionId.Equals(input.ConnectionId))
                ) && 
                (
                    this.DeniedIpAddresses == input.DeniedIpAddresses ||
                    this.DeniedIpAddresses != null &&
                    input.DeniedIpAddresses != null &&
                    this.DeniedIpAddresses.SequenceEqual(input.DeniedIpAddresses)
                ) && 
                (
                    this.Endpoint == input.Endpoint ||
                    (this.Endpoint != null &&
                    this.Endpoint.Equals(input.Endpoint))
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
                    this.GcpFleetParams == input.GcpFleetParams ||
                    (this.GcpFleetParams != null &&
                    this.GcpFleetParams.Equals(input.GcpFleetParams))
                ) && 
                (
                    this.HostType == input.HostType ||
                    this.HostType.Equals(input.HostType)
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
                    this.ProxyHostSourceIdList == input.ProxyHostSourceIdList ||
                    this.ProxyHostSourceIdList != null &&
                    input.ProxyHostSourceIdList != null &&
                    this.ProxyHostSourceIdList.SequenceEqual(input.ProxyHostSourceIdList)
                ) && 
                (
                    this.ReRegister == input.ReRegister ||
                    (this.ReRegister != null &&
                    this.ReRegister.Equals(input.ReRegister))
                ) && 
                (
                    this.RestoreConfig == input.RestoreConfig ||
                    (this.RestoreConfig != null &&
                    this.RestoreConfig.Equals(input.RestoreConfig))
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
                if (this.ConnectionId != null)
                    hashCode = hashCode * 59 + this.ConnectionId.GetHashCode();
                if (this.DeniedIpAddresses != null)
                    hashCode = hashCode * 59 + this.DeniedIpAddresses.GetHashCode();
                if (this.Endpoint != null)
                    hashCode = hashCode * 59 + this.Endpoint.GetHashCode();
                if (this.ExchangeDagProtectionPreference != null)
                    hashCode = hashCode * 59 + this.ExchangeDagProtectionPreference.GetHashCode();
                if (this.ForceRegister != null)
                    hashCode = hashCode * 59 + this.ForceRegister.GetHashCode();
                if (this.GcpCredentials != null)
                    hashCode = hashCode * 59 + this.GcpCredentials.GetHashCode();
                if (this.GcpFleetParams != null)
                    hashCode = hashCode * 59 + this.GcpFleetParams.GetHashCode();
                hashCode = hashCode * 59 + this.HostType.GetHashCode();
                if (this.IsProxyHost != null)
                    hashCode = hashCode * 59 + this.IsProxyHost.GetHashCode();
                if (this.IsilonParams != null)
                    hashCode = hashCode * 59 + this.IsilonParams.GetHashCode();
                if (this.KubernetesCredentials != null)
                    hashCode = hashCode * 59 + this.KubernetesCredentials.GetHashCode();
                if (this.KubernetesParams != null)
                    hashCode = hashCode * 59 + this.KubernetesParams.GetHashCode();
                if (this.MinimumFreeSpaceGB != null)
                    hashCode = hashCode * 59 + this.MinimumFreeSpaceGB.GetHashCode();
                if (this.NasMountCredentials != null)
                    hashCode = hashCode * 59 + this.NasMountCredentials.GetHashCode();
                if (this.Office365CredentialsList != null)
                    hashCode = hashCode * 59 + this.Office365CredentialsList.GetHashCode();
                if (this.Office365Region != null)
                    hashCode = hashCode * 59 + this.Office365Region.GetHashCode();
                if (this.Office365ServiceAccountCredentialsList != null)
                    hashCode = hashCode * 59 + this.Office365ServiceAccountCredentialsList.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.ProxyHostSourceIdList != null)
                    hashCode = hashCode * 59 + this.ProxyHostSourceIdList.GetHashCode();
                if (this.ReRegister != null)
                    hashCode = hashCode * 59 + this.ReRegister.GetHashCode();
                if (this.RestoreConfig != null)
                    hashCode = hashCode * 59 + this.RestoreConfig.GetHashCode();
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
                return hashCode;
            }
        }

    }

}


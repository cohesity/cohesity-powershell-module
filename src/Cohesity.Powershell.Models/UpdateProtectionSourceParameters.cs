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
        /// Specifies the optional OS type of the Protection Source (such as kWindows or kLinux). overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kOther&#39; indicates the other types of operating system.
        /// </summary>
        /// <value>Specifies the optional OS type of the Protection Source (such as kWindows or kLinux). overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kOther&#39; indicates the other types of operating system.</value>
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
            /// Enum KOther for value: kOther
            /// </summary>
            [EnumMember(Value = "kOther")]
            KOther = 6

        }

        /// <summary>
        /// Specifies the optional OS type of the Protection Source (such as kWindows or kLinux). overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kOther&#39; indicates the other types of operating system.
        /// </summary>
        /// <value>Specifies the optional OS type of the Protection Source (such as kWindows or kLinux). overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kOther&#39; indicates the other types of operating system.</value>
        [DataMember(Name="hostType", EmitDefaultValue=true)]
        public HostTypeEnum? HostType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProtectionSourceParameters" /> class.
        /// </summary>
        /// <param name="agentEndpoint">Specifies the agent endpoint if it is different from the source endpoint..</param>
        /// <param name="awsCredentials">awsCredentials.</param>
        /// <param name="azureCredentials">azureCredentials.</param>
        /// <param name="endpoint">Specifies the network endpoint of the Protection Source where it is reachable. It could be an URL or hostname or an IP address of the Protection Source..</param>
        /// <param name="forceRegister">ForceRegister is applicable to Physical Environment. By default, the agent running on a physical host will fail the registration, if it is already registered as part of another cluster. By setting this option to true, agent can be forced to register with the current cluster. This is a hidden parameter and should not be documented externally..</param>
        /// <param name="gcpCredentials">gcpCredentials.</param>
        /// <param name="hostType">Specifies the optional OS type of the Protection Source (such as kWindows or kLinux). overrideDescription: true &#39;kLinux&#39; indicates the Linux operating system. &#39;kWindows&#39; indicates the Microsoft Windows operating system. &#39;kAix&#39; indicates the IBM AIX operating system. &#39;kSolaris&#39; indicates the Oracle Solaris operating system. &#39;kSapHana&#39; indicates the Sap Hana database system developed by SAP SE. &#39;kOther&#39; indicates the other types of operating system..</param>
        /// <param name="kubernetesCredentials">kubernetesCredentials.</param>
        /// <param name="minimumFreeSpaceGB">Specifies the minimum space in GB after which backup jobs will be canceled due to low space..</param>
        /// <param name="nasMountCredentials">Specifies the server credentials to connect to a NetApp server. This field is required for mounting SMB volumes on NetApp servers..</param>
        /// <param name="office365Credentials">office365Credentials.</param>
        /// <param name="password">Specifies password of the username to access the target source..</param>
        /// <param name="sourceSideDedupEnabled">This controls whether to use source side dedup on the source or not. This is only applicable to sources which support source side dedup (e.g., Linux physical servers)..</param>
        /// <param name="sslVerification">sslVerification.</param>
        /// <param name="throttlingPolicy">Specifies the throttling policy that should be applied to this Source..</param>
        /// <param name="throttlingPolicyOverrides">Array of Throttling Policy Overrides for Datastores.  Specifies a list of Throttling Policy for datastores that override the common throttling policy specified for the registered Protection Source. For datastores not in this list, common policy will still apply..</param>
        /// <param name="username">Specifies username to access the target source..</param>
        public UpdateProtectionSourceParameters(string agentEndpoint = default(string), AwsCredentials awsCredentials = default(AwsCredentials), AzureCredentials azureCredentials = default(AzureCredentials), string endpoint = default(string), bool? forceRegister = default(bool?), GcpCredentials gcpCredentials = default(GcpCredentials), HostTypeEnum? hostType = default(HostTypeEnum?), KubernetesCredentials kubernetesCredentials = default(KubernetesCredentials), long? minimumFreeSpaceGB = default(long?), NasMountCredentialParams nasMountCredentials = default(NasMountCredentialParams), Office365Credentials office365Credentials = default(Office365Credentials), string password = default(string), bool? sourceSideDedupEnabled = default(bool?), SslVerification sslVerification = default(SslVerification), ThrottlingPolicyParameters throttlingPolicy = default(ThrottlingPolicyParameters), List<ThrottlingPolicyOverride> throttlingPolicyOverrides = default(List<ThrottlingPolicyOverride>), string username = default(string))
        {
            this.AgentEndpoint = agentEndpoint;
            this.Endpoint = endpoint;
            this.ForceRegister = forceRegister;
            this.HostType = hostType;
            this.MinimumFreeSpaceGB = minimumFreeSpaceGB;
            this.NasMountCredentials = nasMountCredentials;
            this.Password = password;
            this.SourceSideDedupEnabled = sourceSideDedupEnabled;
            this.ThrottlingPolicy = throttlingPolicy;
            this.ThrottlingPolicyOverrides = throttlingPolicyOverrides;
            this.Username = username;
            this.AgentEndpoint = agentEndpoint;
            this.AwsCredentials = awsCredentials;
            this.AzureCredentials = azureCredentials;
            this.Endpoint = endpoint;
            this.ForceRegister = forceRegister;
            this.GcpCredentials = gcpCredentials;
            this.HostType = hostType;
            this.KubernetesCredentials = kubernetesCredentials;
            this.MinimumFreeSpaceGB = minimumFreeSpaceGB;
            this.NasMountCredentials = nasMountCredentials;
            this.Office365Credentials = office365Credentials;
            this.Password = password;
            this.SourceSideDedupEnabled = sourceSideDedupEnabled;
            this.SslVerification = sslVerification;
            this.ThrottlingPolicy = throttlingPolicy;
            this.ThrottlingPolicyOverrides = throttlingPolicyOverrides;
            this.Username = username;
        }
        
        /// <summary>
        /// Specifies the agent endpoint if it is different from the source endpoint.
        /// </summary>
        /// <value>Specifies the agent endpoint if it is different from the source endpoint.</value>
        [DataMember(Name="agentEndpoint", EmitDefaultValue=true)]
        public string AgentEndpoint { get; set; }

        /// <summary>
        /// Gets or Sets AwsCredentials
        /// </summary>
        [DataMember(Name="awsCredentials", EmitDefaultValue=false)]
        public AwsCredentials AwsCredentials { get; set; }

        /// <summary>
        /// Gets or Sets AzureCredentials
        /// </summary>
        [DataMember(Name="azureCredentials", EmitDefaultValue=false)]
        public AzureCredentials AzureCredentials { get; set; }

        /// <summary>
        /// Specifies the network endpoint of the Protection Source where it is reachable. It could be an URL or hostname or an IP address of the Protection Source.
        /// </summary>
        /// <value>Specifies the network endpoint of the Protection Source where it is reachable. It could be an URL or hostname or an IP address of the Protection Source.</value>
        [DataMember(Name="endpoint", EmitDefaultValue=true)]
        public string Endpoint { get; set; }

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
        /// Gets or Sets KubernetesCredentials
        /// </summary>
        [DataMember(Name="kubernetesCredentials", EmitDefaultValue=false)]
        public KubernetesCredentials KubernetesCredentials { get; set; }

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
        /// Specifies username to access the target source.
        /// </summary>
        /// <value>Specifies username to access the target source.</value>
        [DataMember(Name="username", EmitDefaultValue=true)]
        public string Username { get; set; }

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
                    this.AgentEndpoint == input.AgentEndpoint ||
                    (this.AgentEndpoint != null &&
                    this.AgentEndpoint.Equals(input.AgentEndpoint))
                ) && 
                (
                    this.AwsCredentials == input.AwsCredentials ||
                    (this.AwsCredentials != null &&
                    this.AwsCredentials.Equals(input.AwsCredentials))
                ) && 
                (
                    this.AzureCredentials == input.AzureCredentials ||
                    (this.AzureCredentials != null &&
                    this.AzureCredentials.Equals(input.AzureCredentials))
                ) && 
                (
                    this.Endpoint == input.Endpoint ||
                    (this.Endpoint != null &&
                    this.Endpoint.Equals(input.Endpoint))
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
                    this.KubernetesCredentials == input.KubernetesCredentials ||
                    (this.KubernetesCredentials != null &&
                    this.KubernetesCredentials.Equals(input.KubernetesCredentials))
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
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                if (this.AgentEndpoint != null)
                    hashCode = hashCode * 59 + this.AgentEndpoint.GetHashCode();
                if (this.AwsCredentials != null)
                    hashCode = hashCode * 59 + this.AwsCredentials.GetHashCode();
                if (this.AzureCredentials != null)
                    hashCode = hashCode * 59 + this.AzureCredentials.GetHashCode();
                if (this.Endpoint != null)
                    hashCode = hashCode * 59 + this.Endpoint.GetHashCode();
                if (this.ForceRegister != null)
                    hashCode = hashCode * 59 + this.ForceRegister.GetHashCode();
                if (this.GcpCredentials != null)
                    hashCode = hashCode * 59 + this.GcpCredentials.GetHashCode();
                hashCode = hashCode * 59 + this.HostType.GetHashCode();
                if (this.KubernetesCredentials != null)
                    hashCode = hashCode * 59 + this.KubernetesCredentials.GetHashCode();
                if (this.MinimumFreeSpaceGB != null)
                    hashCode = hashCode * 59 + this.MinimumFreeSpaceGB.GetHashCode();
                if (this.NasMountCredentials != null)
                    hashCode = hashCode * 59 + this.NasMountCredentials.GetHashCode();
                if (this.Office365Credentials != null)
                    hashCode = hashCode * 59 + this.Office365Credentials.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.SourceSideDedupEnabled != null)
                    hashCode = hashCode * 59 + this.SourceSideDedupEnabled.GetHashCode();
                if (this.SslVerification != null)
                    hashCode = hashCode * 59 + this.SslVerification.GetHashCode();
                if (this.ThrottlingPolicy != null)
                    hashCode = hashCode * 59 + this.ThrottlingPolicy.GetHashCode();
                if (this.ThrottlingPolicyOverrides != null)
                    hashCode = hashCode * 59 + this.ThrottlingPolicyOverrides.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                return hashCode;
            }
        }

    }

}


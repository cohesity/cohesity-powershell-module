// Copyright 2018 Cohesity Inc.

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;



namespace Cohesity.Models
{
    /// <summary>
    /// Specifies information about a registered Source.
    /// </summary>
    [DataContract]
    public partial class RegisteredSourceInfo :  IEquatable<RegisteredSourceInfo>
    {
        /// <summary>
        /// Specifies the status of the authenticating to the Protection Source when registering it with Cohesity Cluster. If the status is &#39;kFinished&#39; and there is no error, registration is successful. Specifies the status of the authentication during the registration of a Protection Source. &#39;kPending&#39; indicates the authentication is in progress. &#39;kScheduled&#39; indicates the authentication is scheduled. &#39;kFinished&#39; indicates the authentication is completed.
        /// </summary>
        /// <value>Specifies the status of the authenticating to the Protection Source when registering it with Cohesity Cluster. If the status is &#39;kFinished&#39; and there is no error, registration is successful. Specifies the status of the authentication during the registration of a Protection Source. &#39;kPending&#39; indicates the authentication is in progress. &#39;kScheduled&#39; indicates the authentication is scheduled. &#39;kFinished&#39; indicates the authentication is completed.</value>
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
            KFinished = 3
        }

        /// <summary>
        /// Specifies the status of the authenticating to the Protection Source when registering it with Cohesity Cluster. If the status is &#39;kFinished&#39; and there is no error, registration is successful. Specifies the status of the authentication during the registration of a Protection Source. &#39;kPending&#39; indicates the authentication is in progress. &#39;kScheduled&#39; indicates the authentication is scheduled. &#39;kFinished&#39; indicates the authentication is completed.
        /// </summary>
        /// <value>Specifies the status of the authenticating to the Protection Source when registering it with Cohesity Cluster. If the status is &#39;kFinished&#39; and there is no error, registration is successful. Specifies the status of the authentication during the registration of a Protection Source. &#39;kPending&#39; indicates the authentication is in progress. &#39;kScheduled&#39; indicates the authentication is scheduled. &#39;kFinished&#39; indicates the authentication is completed.</value>
        [DataMember(Name="authenticationStatus", EmitDefaultValue=false)]
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
            /// Enum KSQL for value: kSQL
            /// </summary>
            [EnumMember(Value = "kSQL")]
            KSQL = 2,
            
            /// <summary>
            /// Enum KView for value: kView
            /// </summary>
            [EnumMember(Value = "kView")]
            KView = 3,
            
            /// <summary>
            /// Enum KPuppeteer for value: kPuppeteer
            /// </summary>
            [EnumMember(Value = "kPuppeteer")]
            KPuppeteer = 4,
            
            /// <summary>
            /// Enum KPhysical for value: kPhysical
            /// </summary>
            [EnumMember(Value = "kPhysical")]
            KPhysical = 5,
            
            /// <summary>
            /// Enum KPure for value: kPure
            /// </summary>
            [EnumMember(Value = "kPure")]
            KPure = 6,
            
            /// <summary>
            /// Enum KNetapp for value: kNetapp
            /// </summary>
            [EnumMember(Value = "kNetapp")]
            KNetapp = 7,
            
            /// <summary>
            /// Enum KGenericNas for value: kGenericNas
            /// </summary>
            [EnumMember(Value = "kGenericNas")]
            KGenericNas = 8,
            
            /// <summary>
            /// Enum KHyperV for value: kHyperV
            /// </summary>
            [EnumMember(Value = "kHyperV")]
            KHyperV = 9,
            
            /// <summary>
            /// Enum KAcropolis for value: kAcropolis
            /// </summary>
            [EnumMember(Value = "kAcropolis")]
            KAcropolis = 10,
            
            /// <summary>
            /// Enum KAzure for value: kAzure
            /// </summary>
            [EnumMember(Value = "kAzure")]
            KAzure = 11
        }


        /// <summary>
        /// Specifies a list of applications environment that are registered with this Protection Source such as &#39;kSQL&#39;. Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter.
        /// </summary>
        /// <value>Specifies a list of applications environment that are registered with this Protection Source such as &#39;kSQL&#39;. Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter.</value>
        [DataMember(Name="environments", EmitDefaultValue=false)]
        public List<EnvironmentsEnum> Environments { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisteredSourceInfo" /> class.
        /// </summary>
        /// <param name="accessInfo">Specifies the parameters required to establish a connection with a particular environment..</param>
        /// <param name="authenticationErrorMessage">Specifies an authentication error message. This indicates the given credentials are rejected and the registration of the source is not successful..</param>
        /// <param name="authenticationStatus">Specifies the status of the authenticating to the Protection Source when registering it with Cohesity Cluster. If the status is &#39;kFinished&#39; and there is no error, registration is successful. Specifies the status of the authentication during the registration of a Protection Source. &#39;kPending&#39; indicates the authentication is in progress. &#39;kScheduled&#39; indicates the authentication is scheduled. &#39;kFinished&#39; indicates the authentication is completed..</param>
        /// <param name="environments">Specifies a list of applications environment that are registered with this Protection Source such as &#39;kSQL&#39;. Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter..</param>
        /// <param name="minimumFreeSpaceGB">Specifies the minimum free space in GiB of the space expected to be available on the datastore where the virtual disks of the VM being backed up. If the amount of free space(in GiB) is lower than the value given by this field, backup will be aborted. Note that this field is applicable only to &#39;kVMware&#39; type of environments..</param>
        /// <param name="nasMountCredentials">nasMountCredentials.</param>
        /// <param name="password">Specifies password of the username to access the target source..</param>
        /// <param name="refreshErrorMessage">Specifies a message if there was any error encountered during the last rebuild of the Protection Source tree. If there was no error during the last rebuild, this field is reset..</param>
        /// <param name="refreshTimeUsecs">Specifies the Unix epoch time (in microseconds) when the Protection Source tree was most recently fetched and built..</param>
        /// <param name="registrationTimeUsecs">Specifies the Unix epoch time (in microseconds) when the Protection Source was registered..</param>
        /// <param name="throttlingPolicy">Specifies the throttling policy that should be applied to all datastores under this registered Protection Source..</param>
        /// <param name="throttlingPolicyOverrides">Specifies a list of Throttling Policy for datastores that override the common throttling policy specified for the registered Protection Source. For datastores not in this list, common policy will still apply..</param>
        /// <param name="username">Specifies username to access the target source..</param>
        /// <param name="warningMessages">Though the registration may succeed, warning messages imply the host environment requires some cleanup or fixing..</param>
        public RegisteredSourceInfo(ConnectorParams accessInfo = default(ConnectorParams), string authenticationErrorMessage = default(string), AuthenticationStatusEnum? authenticationStatus = default(AuthenticationStatusEnum?), List<EnvironmentsEnum> environments = default(List<EnvironmentsEnum>), long? minimumFreeSpaceGB = default(long?), NASServerCredentials_ nasMountCredentials = default(NASServerCredentials_), string password = default(string), string refreshErrorMessage = default(string), long? refreshTimeUsecs = default(long?), long? registrationTimeUsecs = default(long?), ThrottlingPolicy throttlingPolicy = default(ThrottlingPolicy), List<ThrottlingPolicyOverride> throttlingPolicyOverrides = default(List<ThrottlingPolicyOverride>), string username = default(string), List<string> warningMessages = default(List<string>))
        {
            this.AccessInfo = accessInfo;
            this.AuthenticationErrorMessage = authenticationErrorMessage;
            this.AuthenticationStatus = authenticationStatus;
            this.Environments = environments;
            this.MinimumFreeSpaceGB = minimumFreeSpaceGB;
            this.NasMountCredentials = nasMountCredentials;
            this.Password = password;
            this.RefreshErrorMessage = refreshErrorMessage;
            this.RefreshTimeUsecs = refreshTimeUsecs;
            this.RegistrationTimeUsecs = registrationTimeUsecs;
            this.ThrottlingPolicy = throttlingPolicy;
            this.ThrottlingPolicyOverrides = throttlingPolicyOverrides;
            this.Username = username;
            this.WarningMessages = warningMessages;
        }
        
        /// <summary>
        /// Specifies the parameters required to establish a connection with a particular environment.
        /// </summary>
        /// <value>Specifies the parameters required to establish a connection with a particular environment.</value>
        [DataMember(Name="accessInfo", EmitDefaultValue=false)]
        public ConnectorParams AccessInfo { get; set; }

        /// <summary>
        /// Specifies an authentication error message. This indicates the given credentials are rejected and the registration of the source is not successful.
        /// </summary>
        /// <value>Specifies an authentication error message. This indicates the given credentials are rejected and the registration of the source is not successful.</value>
        [DataMember(Name="authenticationErrorMessage", EmitDefaultValue=false)]
        public string AuthenticationErrorMessage { get; set; }



        /// <summary>
        /// Specifies the minimum free space in GiB of the space expected to be available on the datastore where the virtual disks of the VM being backed up. If the amount of free space(in GiB) is lower than the value given by this field, backup will be aborted. Note that this field is applicable only to &#39;kVMware&#39; type of environments.
        /// </summary>
        /// <value>Specifies the minimum free space in GiB of the space expected to be available on the datastore where the virtual disks of the VM being backed up. If the amount of free space(in GiB) is lower than the value given by this field, backup will be aborted. Note that this field is applicable only to &#39;kVMware&#39; type of environments.</value>
        [DataMember(Name="minimumFreeSpaceGB", EmitDefaultValue=false)]
        public long? MinimumFreeSpaceGB { get; set; }

        /// <summary>
        /// Gets or Sets NasMountCredentials
        /// </summary>
        [DataMember(Name="nasMountCredentials", EmitDefaultValue=false)]
        public NASServerCredentials_ NasMountCredentials { get; set; }

        /// <summary>
        /// Specifies password of the username to access the target source.
        /// </summary>
        /// <value>Specifies password of the username to access the target source.</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Specifies a message if there was any error encountered during the last rebuild of the Protection Source tree. If there was no error during the last rebuild, this field is reset.
        /// </summary>
        /// <value>Specifies a message if there was any error encountered during the last rebuild of the Protection Source tree. If there was no error during the last rebuild, this field is reset.</value>
        [DataMember(Name="refreshErrorMessage", EmitDefaultValue=false)]
        public string RefreshErrorMessage { get; set; }

        /// <summary>
        /// Specifies the Unix epoch time (in microseconds) when the Protection Source tree was most recently fetched and built.
        /// </summary>
        /// <value>Specifies the Unix epoch time (in microseconds) when the Protection Source tree was most recently fetched and built.</value>
        [DataMember(Name="refreshTimeUsecs", EmitDefaultValue=false)]
        public long? RefreshTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the Unix epoch time (in microseconds) when the Protection Source was registered.
        /// </summary>
        /// <value>Specifies the Unix epoch time (in microseconds) when the Protection Source was registered.</value>
        [DataMember(Name="registrationTimeUsecs", EmitDefaultValue=false)]
        public long? RegistrationTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the throttling policy that should be applied to all datastores under this registered Protection Source.
        /// </summary>
        /// <value>Specifies the throttling policy that should be applied to all datastores under this registered Protection Source.</value>
        [DataMember(Name="throttlingPolicy", EmitDefaultValue=false)]
        public ThrottlingPolicy ThrottlingPolicy { get; set; }

        /// <summary>
        /// Specifies a list of Throttling Policy for datastores that override the common throttling policy specified for the registered Protection Source. For datastores not in this list, common policy will still apply.
        /// </summary>
        /// <value>Specifies a list of Throttling Policy for datastores that override the common throttling policy specified for the registered Protection Source. For datastores not in this list, common policy will still apply.</value>
        [DataMember(Name="throttlingPolicyOverrides", EmitDefaultValue=false)]
        public List<ThrottlingPolicyOverride> ThrottlingPolicyOverrides { get; set; }

        /// <summary>
        /// Specifies username to access the target source.
        /// </summary>
        /// <value>Specifies username to access the target source.</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Though the registration may succeed, warning messages imply the host environment requires some cleanup or fixing.
        /// </summary>
        /// <value>Though the registration may succeed, warning messages imply the host environment requires some cleanup or fixing.</value>
        [DataMember(Name="warningMessages", EmitDefaultValue=false)]
        public List<string> WarningMessages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }
  
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
                    (this.AuthenticationStatus != null &&
                    this.AuthenticationStatus.Equals(input.AuthenticationStatus))
                ) && 
                (
                    this.Environments == input.Environments ||
                    this.Environments != null &&
                    this.Environments.SequenceEqual(input.Environments)
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
                    this.ThrottlingPolicyOverrides.SequenceEqual(input.ThrottlingPolicyOverrides)
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.WarningMessages == input.WarningMessages ||
                    this.WarningMessages != null &&
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
                if (this.AuthenticationStatus != null)
                    hashCode = hashCode * 59 + this.AuthenticationStatus.GetHashCode();
                if (this.Environments != null)
                    hashCode = hashCode * 59 + this.Environments.GetHashCode();
                if (this.MinimumFreeSpaceGB != null)
                    hashCode = hashCode * 59 + this.MinimumFreeSpaceGB.GetHashCode();
                if (this.NasMountCredentials != null)
                    hashCode = hashCode * 59 + this.NasMountCredentials.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.RefreshErrorMessage != null)
                    hashCode = hashCode * 59 + this.RefreshErrorMessage.GetHashCode();
                if (this.RefreshTimeUsecs != null)
                    hashCode = hashCode * 59 + this.RefreshTimeUsecs.GetHashCode();
                if (this.RegistrationTimeUsecs != null)
                    hashCode = hashCode * 59 + this.RegistrationTimeUsecs.GetHashCode();
                if (this.ThrottlingPolicy != null)
                    hashCode = hashCode * 59 + this.ThrottlingPolicy.GetHashCode();
                if (this.ThrottlingPolicyOverrides != null)
                    hashCode = hashCode * 59 + this.ThrottlingPolicyOverrides.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.WarningMessages != null)
                    hashCode = hashCode * 59 + this.WarningMessages.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


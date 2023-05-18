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
    /// AzureKmsCredentials
    /// </summary>
    [DataContract]
    public partial class AzureKmsCredentials :  IEquatable<AzureKmsCredentials>
    {
        /// <summary>
        /// Specifies Authentication method to be used for API calls. &#39;kAzureAuthNone&#39; indicates no authentication. &#39;kAzureClientSecret&#39; indicates a client authentication. &#39;kAzureManagedIdentity&#39; indicates a Azure based authentication. &#39;kUseHelios&#39; indicates a Helios authentication.
        /// </summary>
        /// <value>Specifies Authentication method to be used for API calls. &#39;kAzureAuthNone&#39; indicates no authentication. &#39;kAzureClientSecret&#39; indicates a client authentication. &#39;kAzureManagedIdentity&#39; indicates a Azure based authentication. &#39;kUseHelios&#39; indicates a Helios authentication.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MicrosoftAuthMethodEnum
        {
            /// <summary>
            /// Enum KAzureAuthNone for value: kAzureAuthNone
            /// </summary>
            [EnumMember(Value = "kAzureAuthNone")]
            KAzureAuthNone = 1,

            /// <summary>
            /// Enum KAzureClientSecret for value: kAzureClientSecret
            /// </summary>
            [EnumMember(Value = "kAzureClientSecret")]
            KAzureClientSecret = 2,

            /// <summary>
            /// Enum KAzureManagedIdentity for value: kAzureManagedIdentity
            /// </summary>
            [EnumMember(Value = "kAzureManagedIdentity")]
            KAzureManagedIdentity = 3,

            /// <summary>
            /// Enum KUseHelios for value: kUseHelios
            /// </summary>
            [EnumMember(Value = "kUseHelios")]
            KUseHelios = 4

        }

        /// <summary>
        /// Specifies Authentication method to be used for API calls. &#39;kAzureAuthNone&#39; indicates no authentication. &#39;kAzureClientSecret&#39; indicates a client authentication. &#39;kAzureManagedIdentity&#39; indicates a Azure based authentication. &#39;kUseHelios&#39; indicates a Helios authentication.
        /// </summary>
        /// <value>Specifies Authentication method to be used for API calls. &#39;kAzureAuthNone&#39; indicates no authentication. &#39;kAzureClientSecret&#39; indicates a client authentication. &#39;kAzureManagedIdentity&#39; indicates a Azure based authentication. &#39;kUseHelios&#39; indicates a Helios authentication.</value>
        [DataMember(Name="microsoftAuthMethod", EmitDefaultValue=true)]
        public MicrosoftAuthMethodEnum? MicrosoftAuthMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AzureKmsCredentials" /> class.
        /// </summary>
        /// <param name="clientId">Specifies the client id assigned to the cluster..</param>
        /// <param name="clientSecretKey">Specifies the Secret access key needed to access the cloud account..</param>
        /// <param name="microsoftAuthMethod">Specifies Authentication method to be used for API calls. &#39;kAzureAuthNone&#39; indicates no authentication. &#39;kAzureClientSecret&#39; indicates a client authentication. &#39;kAzureManagedIdentity&#39; indicates a Azure based authentication. &#39;kUseHelios&#39; indicates a Helios authentication..</param>
        /// <param name="tenantId">Specifies the tenant id assigned to the cluster..</param>
        public AzureKmsCredentials(string clientId = default(string), string clientSecretKey = default(string), MicrosoftAuthMethodEnum? microsoftAuthMethod = default(MicrosoftAuthMethodEnum?), string tenantId = default(string))
        {
            this.ClientId = clientId;
            this.ClientSecretKey = clientSecretKey;
            this.MicrosoftAuthMethod = microsoftAuthMethod;
            this.TenantId = tenantId;
            this.ClientId = clientId;
            this.ClientSecretKey = clientSecretKey;
            this.MicrosoftAuthMethod = microsoftAuthMethod;
            this.TenantId = tenantId;
        }
        
        /// <summary>
        /// Specifies the client id assigned to the cluster.
        /// </summary>
        /// <value>Specifies the client id assigned to the cluster.</value>
        [DataMember(Name="clientId", EmitDefaultValue=true)]
        public string ClientId { get; set; }

        /// <summary>
        /// Specifies the Secret access key needed to access the cloud account.
        /// </summary>
        /// <value>Specifies the Secret access key needed to access the cloud account.</value>
        [DataMember(Name="clientSecretKey", EmitDefaultValue=true)]
        public string ClientSecretKey { get; set; }

        /// <summary>
        /// Specifies the tenant id assigned to the cluster.
        /// </summary>
        /// <value>Specifies the tenant id assigned to the cluster.</value>
        [DataMember(Name="tenantId", EmitDefaultValue=true)]
        public string TenantId { get; set; }

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
            return this.Equals(input as AzureKmsCredentials);
        }

        /// <summary>
        /// Returns true if AzureKmsCredentials instances are equal
        /// </summary>
        /// <param name="input">Instance of AzureKmsCredentials to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AzureKmsCredentials input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.ClientSecretKey == input.ClientSecretKey ||
                    (this.ClientSecretKey != null &&
                    this.ClientSecretKey.Equals(input.ClientSecretKey))
                ) && 
                (
                    this.MicrosoftAuthMethod == input.MicrosoftAuthMethod ||
                    this.MicrosoftAuthMethod.Equals(input.MicrosoftAuthMethod)
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
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
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.ClientSecretKey != null)
                    hashCode = hashCode * 59 + this.ClientSecretKey.GetHashCode();
                hashCode = hashCode * 59 + this.MicrosoftAuthMethod.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                return hashCode;
            }
        }

    }

}


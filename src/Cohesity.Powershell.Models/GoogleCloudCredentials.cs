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
    /// Specifies the cloud credentials to connect to a Google service account.
    /// </summary>
    [DataContract]
    public partial class GoogleCloudCredentials :  IEquatable<GoogleCloudCredentials>
    {
        /// <summary>
        /// Specifies the Google authentication method to be used for the request. Specifies the google authentication type to be used for API calls. &#39;kServiceAccountKeys&#39;: User will input a private key for the service account. &#39;kServiceAccountAttached&#39;: Assumes the identity of the service account attached to the GCP VM and retrieves an access token from the metadata server to authenticate calls to Google Cloud Storage &#39;kServiceAccountImpersonation&#39;: Assumes the identity of a specified service account, requiring that the GCP VM&#39;s attached service account has the necessary role to impersonate it. &#39;kHelios&#39;: Use Helios to acquire temporary credentials.
        /// </summary>
        /// <value>Specifies the Google authentication method to be used for the request. Specifies the google authentication type to be used for API calls. &#39;kServiceAccountKeys&#39;: User will input a private key for the service account. &#39;kServiceAccountAttached&#39;: Assumes the identity of the service account attached to the GCP VM and retrieves an access token from the metadata server to authenticate calls to Google Cloud Storage &#39;kServiceAccountImpersonation&#39;: Assumes the identity of a specified service account, requiring that the GCP VM&#39;s attached service account has the necessary role to impersonate it. &#39;kHelios&#39;: Use Helios to acquire temporary credentials.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AuthMethodEnum
        {
            /// <summary>
            /// Enum KServiceAccountKeys for value: kServiceAccountKeys
            /// </summary>
            [EnumMember(Value = "kServiceAccountKeys")]
            KServiceAccountKeys = 1,

            /// <summary>
            /// Enum KServiceAccountAttached for value: kServiceAccountAttached
            /// </summary>
            [EnumMember(Value = "kServiceAccountAttached")]
            KServiceAccountAttached = 2,

            /// <summary>
            /// Enum KServiceAccountImpersonation for value: kServiceAccountImpersonation
            /// </summary>
            [EnumMember(Value = "kServiceAccountImpersonation")]
            KServiceAccountImpersonation = 3,

            /// <summary>
            /// Enum KHelios for value: kHelios
            /// </summary>
            [EnumMember(Value = "kHelios")]
            KHelios = 4

        }

        /// <summary>
        /// Specifies the Google authentication method to be used for the request. Specifies the google authentication type to be used for API calls. &#39;kServiceAccountKeys&#39;: User will input a private key for the service account. &#39;kServiceAccountAttached&#39;: Assumes the identity of the service account attached to the GCP VM and retrieves an access token from the metadata server to authenticate calls to Google Cloud Storage &#39;kServiceAccountImpersonation&#39;: Assumes the identity of a specified service account, requiring that the GCP VM&#39;s attached service account has the necessary role to impersonate it. &#39;kHelios&#39;: Use Helios to acquire temporary credentials.
        /// </summary>
        /// <value>Specifies the Google authentication method to be used for the request. Specifies the google authentication type to be used for API calls. &#39;kServiceAccountKeys&#39;: User will input a private key for the service account. &#39;kServiceAccountAttached&#39;: Assumes the identity of the service account attached to the GCP VM and retrieves an access token from the metadata server to authenticate calls to Google Cloud Storage &#39;kServiceAccountImpersonation&#39;: Assumes the identity of a specified service account, requiring that the GCP VM&#39;s attached service account has the necessary role to impersonate it. &#39;kHelios&#39;: Use Helios to acquire temporary credentials.</value>
        [DataMember(Name="authMethod", EmitDefaultValue=true)]
        public AuthMethodEnum? AuthMethod { get; set; }
        /// <summary>
        /// Specifies the storage class of GCP. GoogleTierType specifies the storage class for Google. &#39;kGoogleStandard&#39; indicates a tier type of Google properties. &#39;kGoogleNearline&#39; indicates a tier type of Google properties that is not accessed frequently. &#39;kGoogleColdline&#39; indicates a tier type of Google properties that is rarely accessed. &#39;kGoogleRegional&#39; indicates a tier type of Google properties that stores frequently accessed data in the same region. &#39;kGoogleMultiRegional&#39; indicates a tier type of Google properties that is frequently accessed (\&quot;hot\&quot; objects) around the world.
        /// </summary>
        /// <value>Specifies the storage class of GCP. GoogleTierType specifies the storage class for Google. &#39;kGoogleStandard&#39; indicates a tier type of Google properties. &#39;kGoogleNearline&#39; indicates a tier type of Google properties that is not accessed frequently. &#39;kGoogleColdline&#39; indicates a tier type of Google properties that is rarely accessed. &#39;kGoogleRegional&#39; indicates a tier type of Google properties that stores frequently accessed data in the same region. &#39;kGoogleMultiRegional&#39; indicates a tier type of Google properties that is frequently accessed (\&quot;hot\&quot; objects) around the world.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TierTypeEnum
        {
            /// <summary>
            /// Enum KGoogleStandard for value: kGoogleStandard
            /// </summary>
            [EnumMember(Value = "kGoogleStandard")]
            KGoogleStandard = 1,

            /// <summary>
            /// Enum KGoogleNearline for value: kGoogleNearline
            /// </summary>
            [EnumMember(Value = "kGoogleNearline")]
            KGoogleNearline = 2,

            /// <summary>
            /// Enum KGoogleColdline for value: kGoogleColdline
            /// </summary>
            [EnumMember(Value = "kGoogleColdline")]
            KGoogleColdline = 3,

            /// <summary>
            /// Enum KGoogleRegional for value: kGoogleRegional
            /// </summary>
            [EnumMember(Value = "kGoogleRegional")]
            KGoogleRegional = 4,

            /// <summary>
            /// Enum KGoogleMultiRegional for value: kGoogleMultiRegional
            /// </summary>
            [EnumMember(Value = "kGoogleMultiRegional")]
            KGoogleMultiRegional = 5,

            /// <summary>
            /// Enum KGoogleArchive for value: kGoogleArchive
            /// </summary>
            [EnumMember(Value = "kGoogleArchive")]
            KGoogleArchive = 6

        }

        /// <summary>
        /// Specifies the storage class of GCP. GoogleTierType specifies the storage class for Google. &#39;kGoogleStandard&#39; indicates a tier type of Google properties. &#39;kGoogleNearline&#39; indicates a tier type of Google properties that is not accessed frequently. &#39;kGoogleColdline&#39; indicates a tier type of Google properties that is rarely accessed. &#39;kGoogleRegional&#39; indicates a tier type of Google properties that stores frequently accessed data in the same region. &#39;kGoogleMultiRegional&#39; indicates a tier type of Google properties that is frequently accessed (\&quot;hot\&quot; objects) around the world.
        /// </summary>
        /// <value>Specifies the storage class of GCP. GoogleTierType specifies the storage class for Google. &#39;kGoogleStandard&#39; indicates a tier type of Google properties. &#39;kGoogleNearline&#39; indicates a tier type of Google properties that is not accessed frequently. &#39;kGoogleColdline&#39; indicates a tier type of Google properties that is rarely accessed. &#39;kGoogleRegional&#39; indicates a tier type of Google properties that stores frequently accessed data in the same region. &#39;kGoogleMultiRegional&#39; indicates a tier type of Google properties that is frequently accessed (\&quot;hot\&quot; objects) around the world.</value>
        [DataMember(Name="tierType", EmitDefaultValue=true)]
        public TierTypeEnum? TierType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleCloudCredentials" /> class.
        /// </summary>
        /// <param name="authMethod">Specifies the Google authentication method to be used for the request. Specifies the google authentication type to be used for API calls. &#39;kServiceAccountKeys&#39;: User will input a private key for the service account. &#39;kServiceAccountAttached&#39;: Assumes the identity of the service account attached to the GCP VM and retrieves an access token from the metadata server to authenticate calls to Google Cloud Storage &#39;kServiceAccountImpersonation&#39;: Assumes the identity of a specified service account, requiring that the GCP VM&#39;s attached service account has the necessary role to impersonate it. &#39;kHelios&#39;: Use Helios to acquire temporary credentials..</param>
        /// <param name="clientEmailAddress">Specifies the client email address used to access Google Cloud Storage..</param>
        /// <param name="clientPrivateKey">Specifies the private key used to access Google Cloud Storage that is generated when the service account is created..</param>
        /// <param name="projectId">Specifies the project id of an existing Google Cloud project to store objects..</param>
        /// <param name="tierType">Specifies the storage class of GCP. GoogleTierType specifies the storage class for Google. &#39;kGoogleStandard&#39; indicates a tier type of Google properties. &#39;kGoogleNearline&#39; indicates a tier type of Google properties that is not accessed frequently. &#39;kGoogleColdline&#39; indicates a tier type of Google properties that is rarely accessed. &#39;kGoogleRegional&#39; indicates a tier type of Google properties that stores frequently accessed data in the same region. &#39;kGoogleMultiRegional&#39; indicates a tier type of Google properties that is frequently accessed (\&quot;hot\&quot; objects) around the world..</param>
        /// <param name="tiers">Specifies the list of all tiers for Google account..</param>
        public GoogleCloudCredentials(AuthMethodEnum? authMethod = default(AuthMethodEnum?), string clientEmailAddress = default(string), string clientPrivateKey = default(string), string projectId = default(string), TierTypeEnum? tierType = default(TierTypeEnum?), List<string> tiers = default(List<string>))
        {
            this.AuthMethod = authMethod;
            this.ClientEmailAddress = clientEmailAddress;
            this.ClientPrivateKey = clientPrivateKey;
            this.ProjectId = projectId;
            this.TierType = tierType;
            this.Tiers = tiers;
            this.AuthMethod = authMethod;
            this.ClientEmailAddress = clientEmailAddress;
            this.ClientPrivateKey = clientPrivateKey;
            this.ProjectId = projectId;
            this.TierType = tierType;
            this.Tiers = tiers;
        }
        
        /// <summary>
        /// Specifies the client email address used to access Google Cloud Storage.
        /// </summary>
        /// <value>Specifies the client email address used to access Google Cloud Storage.</value>
        [DataMember(Name="clientEmailAddress", EmitDefaultValue=true)]
        public string ClientEmailAddress { get; set; }

        /// <summary>
        /// Specifies the private key used to access Google Cloud Storage that is generated when the service account is created.
        /// </summary>
        /// <value>Specifies the private key used to access Google Cloud Storage that is generated when the service account is created.</value>
        [DataMember(Name="clientPrivateKey", EmitDefaultValue=true)]
        public string ClientPrivateKey { get; set; }

        /// <summary>
        /// Specifies the project id of an existing Google Cloud project to store objects.
        /// </summary>
        /// <value>Specifies the project id of an existing Google Cloud project to store objects.</value>
        [DataMember(Name="projectId", EmitDefaultValue=true)]
        public string ProjectId { get; set; }

        /// <summary>
        /// Specifies the list of all tiers for Google account.
        /// </summary>
        /// <value>Specifies the list of all tiers for Google account.</value>
        [DataMember(Name="tiers", EmitDefaultValue=true)]
        public List<string> Tiers { get; set; }

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
            return this.Equals(input as GoogleCloudCredentials);
        }

        /// <summary>
        /// Returns true if GoogleCloudCredentials instances are equal
        /// </summary>
        /// <param name="input">Instance of GoogleCloudCredentials to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoogleCloudCredentials input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthMethod == input.AuthMethod ||
                    this.AuthMethod.Equals(input.AuthMethod)
                ) && 
                (
                    this.ClientEmailAddress == input.ClientEmailAddress ||
                    (this.ClientEmailAddress != null &&
                    this.ClientEmailAddress.Equals(input.ClientEmailAddress))
                ) && 
                (
                    this.ClientPrivateKey == input.ClientPrivateKey ||
                    (this.ClientPrivateKey != null &&
                    this.ClientPrivateKey.Equals(input.ClientPrivateKey))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.TierType == input.TierType ||
                    this.TierType.Equals(input.TierType)
                ) && 
                (
                    this.Tiers == input.Tiers ||
                    this.Tiers != null &&
                    input.Tiers != null &&
                    this.Tiers.SequenceEqual(input.Tiers)
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
                hashCode = hashCode * 59 + this.AuthMethod.GetHashCode();
                if (this.ClientEmailAddress != null)
                    hashCode = hashCode * 59 + this.ClientEmailAddress.GetHashCode();
                if (this.ClientPrivateKey != null)
                    hashCode = hashCode * 59 + this.ClientPrivateKey.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                hashCode = hashCode * 59 + this.TierType.GetHashCode();
                if (this.Tiers != null)
                    hashCode = hashCode * 59 + this.Tiers.GetHashCode();
                return hashCode;
            }
        }

    }

}


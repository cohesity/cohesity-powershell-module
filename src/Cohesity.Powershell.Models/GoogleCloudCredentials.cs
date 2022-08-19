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
            KGoogleMultiRegional = 5

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
        /// <param name="clientEmailAddress">Specifies the client email address used to access Google Cloud Storage..</param>
        /// <param name="clientPrivateKey">Specifies the private key used to access Google Cloud Storage that is generated when the service account is created..</param>
        /// <param name="projectId">Specifies the project id of an existing Google Cloud project to store objects..</param>
        /// <param name="tierType">Specifies the storage class of GCP. GoogleTierType specifies the storage class for Google. &#39;kGoogleStandard&#39; indicates a tier type of Google properties. &#39;kGoogleNearline&#39; indicates a tier type of Google properties that is not accessed frequently. &#39;kGoogleColdline&#39; indicates a tier type of Google properties that is rarely accessed. &#39;kGoogleRegional&#39; indicates a tier type of Google properties that stores frequently accessed data in the same region. &#39;kGoogleMultiRegional&#39; indicates a tier type of Google properties that is frequently accessed (\&quot;hot\&quot; objects) around the world..</param>
        /// <param name="tiers">Specifies the list of all tiers for Google account..</param>
        public GoogleCloudCredentials(string clientEmailAddress = default(string), string clientPrivateKey = default(string), string projectId = default(string), TierTypeEnum? tierType = default(TierTypeEnum?), List<string> tiers = default(List<string>))
        {
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
                    this.Tiers.Equals(input.Tiers)
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
                if (this.ClientEmailAddress != null)
                    hashCode = hashCode * 59 + this.ClientEmailAddress.GetHashCode();
                if (this.ClientPrivateKey != null)
                    hashCode = hashCode * 59 + this.ClientPrivateKey.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.TierType != null)
					hashCode = hashCode * 59 + this.TierType.GetHashCode();
                if (this.Tiers != null)
                    hashCode = hashCode * 59 + this.Tiers.GetHashCode();
                return hashCode;
            }
        }

    }

}


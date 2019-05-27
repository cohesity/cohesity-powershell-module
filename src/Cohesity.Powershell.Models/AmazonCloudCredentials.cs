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
    /// Specifies the cloud credentials to connect to a Amazon service account. Glacier, S3, and S3-compatible clouds all use these credentials.
    /// </summary>
    [DataContract]
    public partial class AmazonCloudCredentials :  IEquatable<AmazonCloudCredentials>
    {
        /// <summary>
        /// Specifies the storage class of AWS. AmazonTierType specifies the storage class for AWS. &#39;kAmazonS3Standard&#39; indicates a tier type of Amazon properties that is accessed frequently. &#39;kAmazonS3StandardIA&#39; indicates a tier type of Amazon properties that is accessed less frequently, but requires rapid access when needed. &#39;kAmazonGlacier&#39; indicates a tier type of Amazon properties that is accessed rarely. &#39;kAmazonS3OneZoneIA&#39; indicates a tier type of Amazon properties for long-lived, but less frequently accessed data. &#39;kAmazonS3IntelligentTiering&#39; indicates a tier type of Amazon properties for data with unknown or changing access patterns.
        /// </summary>
        /// <value>Specifies the storage class of AWS. AmazonTierType specifies the storage class for AWS. &#39;kAmazonS3Standard&#39; indicates a tier type of Amazon properties that is accessed frequently. &#39;kAmazonS3StandardIA&#39; indicates a tier type of Amazon properties that is accessed less frequently, but requires rapid access when needed. &#39;kAmazonGlacier&#39; indicates a tier type of Amazon properties that is accessed rarely. &#39;kAmazonS3OneZoneIA&#39; indicates a tier type of Amazon properties for long-lived, but less frequently accessed data. &#39;kAmazonS3IntelligentTiering&#39; indicates a tier type of Amazon properties for data with unknown or changing access patterns.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TierTypeEnum
        {
            /// <summary>
            /// Enum KAmazonS3Standard for value: kAmazonS3Standard
            /// </summary>
            [EnumMember(Value = "kAmazonS3Standard")]
            KAmazonS3Standard = 1,

            /// <summary>
            /// Enum KAmazonS3StandardIA for value: kAmazonS3StandardIA
            /// </summary>
            [EnumMember(Value = "kAmazonS3StandardIA")]
            KAmazonS3StandardIA = 2,

            /// <summary>
            /// Enum KAmazonGlacier for value: kAmazonGlacier
            /// </summary>
            [EnumMember(Value = "kAmazonGlacier")]
            KAmazonGlacier = 3,

            /// <summary>
            /// Enum KAmazonS3OneZoneIA for value: kAmazonS3OneZoneIA
            /// </summary>
            [EnumMember(Value = "kAmazonS3OneZoneIA")]
            KAmazonS3OneZoneIA = 4,

            /// <summary>
            /// Enum KAmazonS3IntelligentTiering for value: kAmazonS3IntelligentTiering
            /// </summary>
            [EnumMember(Value = "kAmazonS3IntelligentTiering")]
            KAmazonS3IntelligentTiering = 5

        }

        /// <summary>
        /// Specifies the storage class of AWS. AmazonTierType specifies the storage class for AWS. &#39;kAmazonS3Standard&#39; indicates a tier type of Amazon properties that is accessed frequently. &#39;kAmazonS3StandardIA&#39; indicates a tier type of Amazon properties that is accessed less frequently, but requires rapid access when needed. &#39;kAmazonGlacier&#39; indicates a tier type of Amazon properties that is accessed rarely. &#39;kAmazonS3OneZoneIA&#39; indicates a tier type of Amazon properties for long-lived, but less frequently accessed data. &#39;kAmazonS3IntelligentTiering&#39; indicates a tier type of Amazon properties for data with unknown or changing access patterns.
        /// </summary>
        /// <value>Specifies the storage class of AWS. AmazonTierType specifies the storage class for AWS. &#39;kAmazonS3Standard&#39; indicates a tier type of Amazon properties that is accessed frequently. &#39;kAmazonS3StandardIA&#39; indicates a tier type of Amazon properties that is accessed less frequently, but requires rapid access when needed. &#39;kAmazonGlacier&#39; indicates a tier type of Amazon properties that is accessed rarely. &#39;kAmazonS3OneZoneIA&#39; indicates a tier type of Amazon properties for long-lived, but less frequently accessed data. &#39;kAmazonS3IntelligentTiering&#39; indicates a tier type of Amazon properties for data with unknown or changing access patterns.</value>
        [DataMember(Name="tierType", EmitDefaultValue=true)]
        public TierTypeEnum? TierType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AmazonCloudCredentials" /> class.
        /// </summary>
        /// <param name="accessKeyId">Specifies the access key for Amazon service account. See the Cohesity online help for the value to specify for this field based on the current S3 Compatible Vault (External Target) type. For example for Iron Mountain, specify the user name from Iron Mountain for this field..</param>
        /// <param name="c2sAccessPortal">c2sAccessPortal.</param>
        /// <param name="region">Specifies the region to use for the Amazon service account..</param>
        /// <param name="secretAccessKey">Specifies the secret access key for Amazon service account. See the Cohesity online help for the value to specify for this field based on the current S3-compatible Vault (External Target) type..</param>
        /// <param name="serviceUrl">Specifies the URL (Endpoint) for the service such as s3like.notamazon.com. This field is only significant for S3-compatible cloud services..</param>
        /// <param name="signatureVersion">Specifies the version of the S3 Compliance. This field must be set to 2 or 4 and the default version is 2. This field is only significant for S3-compatible cloud services. See the Cohesity online help for the supported S3-compatible Vault (External Target) types and the value to specify for this field based on the current S3-compatible Vault (External Target) type..</param>
        /// <param name="tierType">Specifies the storage class of AWS. AmazonTierType specifies the storage class for AWS. &#39;kAmazonS3Standard&#39; indicates a tier type of Amazon properties that is accessed frequently. &#39;kAmazonS3StandardIA&#39; indicates a tier type of Amazon properties that is accessed less frequently, but requires rapid access when needed. &#39;kAmazonGlacier&#39; indicates a tier type of Amazon properties that is accessed rarely. &#39;kAmazonS3OneZoneIA&#39; indicates a tier type of Amazon properties for long-lived, but less frequently accessed data. &#39;kAmazonS3IntelligentTiering&#39; indicates a tier type of Amazon properties for data with unknown or changing access patterns..</param>
        /// <param name="useHttps">Specifies whether to use http or https to connect to the service. If true, a secure connection (https) is used. This field is only significant for S3-compatible cloud services..</param>
        public AmazonCloudCredentials(string accessKeyId = default(string), C2SAccessPortal c2sAccessPortal = default(C2SAccessPortal), string region = default(string), string secretAccessKey = default(string), string serviceUrl = default(string), int? signatureVersion = default(int?), TierTypeEnum? tierType = default(TierTypeEnum?), bool? useHttps = default(bool?))
        {
            this.AccessKeyId = accessKeyId;
            this.Region = region;
            this.SecretAccessKey = secretAccessKey;
            this.ServiceUrl = serviceUrl;
            this.SignatureVersion = signatureVersion;
            this.TierType = tierType;
            this.UseHttps = useHttps;
            this.AccessKeyId = accessKeyId;
            this.C2sAccessPortal = c2sAccessPortal;
            this.Region = region;
            this.SecretAccessKey = secretAccessKey;
            this.ServiceUrl = serviceUrl;
            this.SignatureVersion = signatureVersion;
            this.TierType = tierType;
            this.UseHttps = useHttps;
        }
        
        /// <summary>
        /// Specifies the access key for Amazon service account. See the Cohesity online help for the value to specify for this field based on the current S3 Compatible Vault (External Target) type. For example for Iron Mountain, specify the user name from Iron Mountain for this field.
        /// </summary>
        /// <value>Specifies the access key for Amazon service account. See the Cohesity online help for the value to specify for this field based on the current S3 Compatible Vault (External Target) type. For example for Iron Mountain, specify the user name from Iron Mountain for this field.</value>
        [DataMember(Name="accessKeyId", EmitDefaultValue=true)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// Gets or Sets C2sAccessPortal
        /// </summary>
        [DataMember(Name="c2sAccessPortal", EmitDefaultValue=false)]
        public C2SAccessPortal C2sAccessPortal { get; set; }

        /// <summary>
        /// Specifies the region to use for the Amazon service account.
        /// </summary>
        /// <value>Specifies the region to use for the Amazon service account.</value>
        [DataMember(Name="region", EmitDefaultValue=true)]
        public string Region { get; set; }

        /// <summary>
        /// Specifies the secret access key for Amazon service account. See the Cohesity online help for the value to specify for this field based on the current S3-compatible Vault (External Target) type.
        /// </summary>
        /// <value>Specifies the secret access key for Amazon service account. See the Cohesity online help for the value to specify for this field based on the current S3-compatible Vault (External Target) type.</value>
        [DataMember(Name="secretAccessKey", EmitDefaultValue=true)]
        public string SecretAccessKey { get; set; }

        /// <summary>
        /// Specifies the URL (Endpoint) for the service such as s3like.notamazon.com. This field is only significant for S3-compatible cloud services.
        /// </summary>
        /// <value>Specifies the URL (Endpoint) for the service such as s3like.notamazon.com. This field is only significant for S3-compatible cloud services.</value>
        [DataMember(Name="serviceUrl", EmitDefaultValue=true)]
        public string ServiceUrl { get; set; }

        /// <summary>
        /// Specifies the version of the S3 Compliance. This field must be set to 2 or 4 and the default version is 2. This field is only significant for S3-compatible cloud services. See the Cohesity online help for the supported S3-compatible Vault (External Target) types and the value to specify for this field based on the current S3-compatible Vault (External Target) type.
        /// </summary>
        /// <value>Specifies the version of the S3 Compliance. This field must be set to 2 or 4 and the default version is 2. This field is only significant for S3-compatible cloud services. See the Cohesity online help for the supported S3-compatible Vault (External Target) types and the value to specify for this field based on the current S3-compatible Vault (External Target) type.</value>
        [DataMember(Name="signatureVersion", EmitDefaultValue=true)]
        public int? SignatureVersion { get; set; }

        /// <summary>
        /// Specifies whether to use http or https to connect to the service. If true, a secure connection (https) is used. This field is only significant for S3-compatible cloud services.
        /// </summary>
        /// <value>Specifies whether to use http or https to connect to the service. If true, a secure connection (https) is used. This field is only significant for S3-compatible cloud services.</value>
        [DataMember(Name="useHttps", EmitDefaultValue=true)]
        public bool? UseHttps { get; set; }

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
            return this.Equals(input as AmazonCloudCredentials);
        }

        /// <summary>
        /// Returns true if AmazonCloudCredentials instances are equal
        /// </summary>
        /// <param name="input">Instance of AmazonCloudCredentials to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AmazonCloudCredentials input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessKeyId == input.AccessKeyId ||
                    (this.AccessKeyId != null &&
                    this.AccessKeyId.Equals(input.AccessKeyId))
                ) && 
                (
                    this.C2sAccessPortal == input.C2sAccessPortal ||
                    (this.C2sAccessPortal != null &&
                    this.C2sAccessPortal.Equals(input.C2sAccessPortal))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.SecretAccessKey == input.SecretAccessKey ||
                    (this.SecretAccessKey != null &&
                    this.SecretAccessKey.Equals(input.SecretAccessKey))
                ) && 
                (
                    this.ServiceUrl == input.ServiceUrl ||
                    (this.ServiceUrl != null &&
                    this.ServiceUrl.Equals(input.ServiceUrl))
                ) && 
                (
                    this.SignatureVersion == input.SignatureVersion ||
                    (this.SignatureVersion != null &&
                    this.SignatureVersion.Equals(input.SignatureVersion))
                ) && 
                (
                    this.TierType == input.TierType ||
                    this.TierType.Equals(input.TierType)
                ) && 
                (
                    this.UseHttps == input.UseHttps ||
                    (this.UseHttps != null &&
                    this.UseHttps.Equals(input.UseHttps))
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
                if (this.AccessKeyId != null)
                    hashCode = hashCode * 59 + this.AccessKeyId.GetHashCode();
                if (this.C2sAccessPortal != null)
                    hashCode = hashCode * 59 + this.C2sAccessPortal.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.SecretAccessKey != null)
                    hashCode = hashCode * 59 + this.SecretAccessKey.GetHashCode();
                if (this.ServiceUrl != null)
                    hashCode = hashCode * 59 + this.ServiceUrl.GetHashCode();
                if (this.SignatureVersion != null)
                    hashCode = hashCode * 59 + this.SignatureVersion.GetHashCode();
                hashCode = hashCode * 59 + this.TierType.GetHashCode();
                if (this.UseHttps != null)
                    hashCode = hashCode * 59 + this.UseHttps.GetHashCode();
                return hashCode;
            }
        }

    }

}


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
        /// Specifies the auth method used for the request See the Cohesity online help for the value to specify for this field based on the current S3-compatible Vault (External Target) type. Specifies the authentication method to be used for API calls. &#39;kUseIAMUser&#39; indicates a user based authentication. &#39;kUseIAMRole&#39; indicates a role based authentication, used only for AWS CE.
        /// </summary>
        /// <value>Specifies the auth method used for the request See the Cohesity online help for the value to specify for this field based on the current S3-compatible Vault (External Target) type. Specifies the authentication method to be used for API calls. &#39;kUseIAMUser&#39; indicates a user based authentication. &#39;kUseIAMRole&#39; indicates a role based authentication, used only for AWS CE.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AuthMethodEnum
        {
            /// <summary>
            /// Enum KUseIAMUser for value: kUseIAMUser
            /// </summary>
            [EnumMember(Value = "kUseIAMUser")]
            KUseIAMUser = 1,

            /// <summary>
            /// Enum KUseIAMRole for value: kUseIAMRole
            /// </summary>
            [EnumMember(Value = "kUseIAMRole")]
            KUseIAMRole = 2

        }

        /// <summary>
        /// Specifies the auth method used for the request See the Cohesity online help for the value to specify for this field based on the current S3-compatible Vault (External Target) type. Specifies the authentication method to be used for API calls. &#39;kUseIAMUser&#39; indicates a user based authentication. &#39;kUseIAMRole&#39; indicates a role based authentication, used only for AWS CE.
        /// </summary>
        /// <value>Specifies the auth method used for the request See the Cohesity online help for the value to specify for this field based on the current S3-compatible Vault (External Target) type. Specifies the authentication method to be used for API calls. &#39;kUseIAMUser&#39; indicates a user based authentication. &#39;kUseIAMRole&#39; indicates a role based authentication, used only for AWS CE.</value>
        [DataMember(Name="authMethod", EmitDefaultValue=false)]
        public AuthMethodEnum? AuthMethod { get; set; }
        /// <summary>
        /// Specifies the storage class of AWS. AmazonTierType specifies the storage class for AWS. &#39;kAmazonS3Standard&#39; indicates a tier type of Amazon properties that is accessed frequently. &#39;kAmazonS3StandardIA&#39; indicates a tier type of Amazon properties that is accessed less frequently, but requires rapid access when needed. &#39;kAmazonGlacier&#39; indicates a tier type of Amazon properties that is accessed rarely. &#39;kAmazonS3OneZoneIA&#39; indicates a tier type of Amazon properties for long-lived, but less frequently accessed data. &#39;kAmazonS3IntelligentTiering&#39; indicates a tier type of Amazon properties for data with unknown or changing access patterns. &#39;kAmazonS3Glacier&#39; indicates a tier type of Amazon properties for data that provides secure, durable object storage for long-term data retention and digital preservation. It provides three options for access to archives, from a few minutes to several hours. &#39;kAmazonS3GlacierDeepArchive&#39; indicates a tier type of Amazon properties for data that provides secure, durable object storage for long-term data retention and digital preservation. It provides two access options ranging from 12 to 48 hours.
        /// </summary>
        /// <value>Specifies the storage class of AWS. AmazonTierType specifies the storage class for AWS. &#39;kAmazonS3Standard&#39; indicates a tier type of Amazon properties that is accessed frequently. &#39;kAmazonS3StandardIA&#39; indicates a tier type of Amazon properties that is accessed less frequently, but requires rapid access when needed. &#39;kAmazonGlacier&#39; indicates a tier type of Amazon properties that is accessed rarely. &#39;kAmazonS3OneZoneIA&#39; indicates a tier type of Amazon properties for long-lived, but less frequently accessed data. &#39;kAmazonS3IntelligentTiering&#39; indicates a tier type of Amazon properties for data with unknown or changing access patterns. &#39;kAmazonS3Glacier&#39; indicates a tier type of Amazon properties for data that provides secure, durable object storage for long-term data retention and digital preservation. It provides three options for access to archives, from a few minutes to several hours. &#39;kAmazonS3GlacierDeepArchive&#39; indicates a tier type of Amazon properties for data that provides secure, durable object storage for long-term data retention and digital preservation. It provides two access options ranging from 12 to 48 hours.</value>
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
            KAmazonS3IntelligentTiering = 5,

            /// <summary>
            /// Enum KAmazonS3Glacier for value: kAmazonS3Glacier
            /// </summary>
            [EnumMember(Value = "kAmazonS3Glacier")]
            KAmazonS3Glacier = 6,

            /// <summary>
            /// Enum KAmazonS3GlacierDeepArchive for value: kAmazonS3GlacierDeepArchive
            /// </summary>
            [EnumMember(Value = "kAmazonS3GlacierDeepArchive")]
            KAmazonS3GlacierDeepArchive = 7

        }

        /// <summary>
        /// Specifies the storage class of AWS. AmazonTierType specifies the storage class for AWS. &#39;kAmazonS3Standard&#39; indicates a tier type of Amazon properties that is accessed frequently. &#39;kAmazonS3StandardIA&#39; indicates a tier type of Amazon properties that is accessed less frequently, but requires rapid access when needed. &#39;kAmazonGlacier&#39; indicates a tier type of Amazon properties that is accessed rarely. &#39;kAmazonS3OneZoneIA&#39; indicates a tier type of Amazon properties for long-lived, but less frequently accessed data. &#39;kAmazonS3IntelligentTiering&#39; indicates a tier type of Amazon properties for data with unknown or changing access patterns. &#39;kAmazonS3Glacier&#39; indicates a tier type of Amazon properties for data that provides secure, durable object storage for long-term data retention and digital preservation. It provides three options for access to archives, from a few minutes to several hours. &#39;kAmazonS3GlacierDeepArchive&#39; indicates a tier type of Amazon properties for data that provides secure, durable object storage for long-term data retention and digital preservation. It provides two access options ranging from 12 to 48 hours.
        /// </summary>
        /// <value>Specifies the storage class of AWS. AmazonTierType specifies the storage class for AWS. &#39;kAmazonS3Standard&#39; indicates a tier type of Amazon properties that is accessed frequently. &#39;kAmazonS3StandardIA&#39; indicates a tier type of Amazon properties that is accessed less frequently, but requires rapid access when needed. &#39;kAmazonGlacier&#39; indicates a tier type of Amazon properties that is accessed rarely. &#39;kAmazonS3OneZoneIA&#39; indicates a tier type of Amazon properties for long-lived, but less frequently accessed data. &#39;kAmazonS3IntelligentTiering&#39; indicates a tier type of Amazon properties for data with unknown or changing access patterns. &#39;kAmazonS3Glacier&#39; indicates a tier type of Amazon properties for data that provides secure, durable object storage for long-term data retention and digital preservation. It provides three options for access to archives, from a few minutes to several hours. &#39;kAmazonS3GlacierDeepArchive&#39; indicates a tier type of Amazon properties for data that provides secure, durable object storage for long-term data retention and digital preservation. It provides two access options ranging from 12 to 48 hours.</value>
        [DataMember(Name="tierType", EmitDefaultValue=false)]
        public TierTypeEnum? TierType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AmazonCloudCredentials" /> class.
        /// </summary>
        /// <param name="isLambdaBasedGCEnabled">Specifies whether this vault supports AWS Lambda based GC. A Lambda function needs to be deployed in the customer&#39;s AWS environment or the IAM user should have permissions to create one..</param>
        /// <param name="accessKeyId">Specifies the access key for Amazon service account. See the Cohesity online help for the value to specify for this field based on the current S3 Compatible Vault (External Target) type. For example for Iron Mountain, specify the user name from Iron Mountain for this field..</param>
        /// <param name="authMethod">Specifies the auth method used for the request See the Cohesity online help for the value to specify for this field based on the current S3-compatible Vault (External Target) type. Specifies the authentication method to be used for API calls. &#39;kUseIAMUser&#39; indicates a user based authentication. &#39;kUseIAMRole&#39; indicates a role based authentication, used only for AWS CE..</param>
        /// <param name="c2sAccessPortal">c2sAccessPortal.</param>
        /// <param name="credentialBlob">Specifies the credential blob to authenticate with credential endpoint..</param>
        /// <param name="credentialEndpoint">Specifies the credential process that generates the security token..</param>
        /// <param name="iamRoleArn">Specifies the iam role arn Amazon service account. See the Cohesity online help for the value to specify for this field based on the current S3-compatible Vault (External Target) type..</param>
        /// <param name="readOnlyIamRoleArn">Specifies a read-only iam role arn Amazon service account. See the Cohesity online help for the value to specify for this field based on the current S3-compatible Vault (External Target) type..</param>
        /// <param name="region">Specifies the region to use for the Amazon service account..</param>
        /// <param name="secretAccessKey">Specifies the secret access key for Amazon service account. See the Cohesity online help for the value to specify for this field based on the current S3-compatible Vault (External Target) type..</param>
        /// <param name="serviceUrl">Specifies the URL (Endpoint) for the service such as s3like.notamazon.com. This field is only significant for S3-compatible cloud services..</param>
        /// <param name="signatureVersion">Specifies the version of the S3 Compliance. This field must be set to 2 or 4 and the default version is 2. This field is only significant for S3-compatible cloud services. See the Cohesity online help for the supported S3-compatible Vault (External Target) types and the value to specify for this field based on the current S3-compatible Vault (External Target) type..</param>
        /// <param name="tierType">Specifies the storage class of AWS. AmazonTierType specifies the storage class for AWS. &#39;kAmazonS3Standard&#39; indicates a tier type of Amazon properties that is accessed frequently. &#39;kAmazonS3StandardIA&#39; indicates a tier type of Amazon properties that is accessed less frequently, but requires rapid access when needed. &#39;kAmazonGlacier&#39; indicates a tier type of Amazon properties that is accessed rarely. &#39;kAmazonS3OneZoneIA&#39; indicates a tier type of Amazon properties for long-lived, but less frequently accessed data. &#39;kAmazonS3IntelligentTiering&#39; indicates a tier type of Amazon properties for data with unknown or changing access patterns. &#39;kAmazonS3Glacier&#39; indicates a tier type of Amazon properties for data that provides secure, durable object storage for long-term data retention and digital preservation. It provides three options for access to archives, from a few minutes to several hours. &#39;kAmazonS3GlacierDeepArchive&#39; indicates a tier type of Amazon properties for data that provides secure, durable object storage for long-term data retention and digital preservation. It provides two access options ranging from 12 to 48 hours..</param>
        /// <param name="tiers">Specifies the list of all tiers for Amazon account..</param>
        /// <param name="useHttps">Specifies whether to use http or https to connect to the service. If true, a secure connection (https) is used. This field is only significant for S3-compatible cloud services..</param>
        public AmazonCloudCredentials(bool? isLambdaBasedGCEnabled = default(bool?), string accessKeyId = default(string), AuthMethodEnum? authMethod = default(AuthMethodEnum?), C2SAccessPortal c2sAccessPortal = default(C2SAccessPortal), string credentialBlob = default(string), string credentialEndpoint = default(string), string iamRoleArn = default(string), string readOnlyIamRoleArn = default(string), string region = default(string), string secretAccessKey = default(string), string serviceUrl = default(string), int? signatureVersion = default(int?), TierTypeEnum? tierType = default(TierTypeEnum?), List<string> tiers = default(List<string>), bool? useHttps = default(bool?))
        {
            this.IsLambdaBasedGCEnabled = isLambdaBasedGCEnabled;
            this.AccessKeyId = accessKeyId;
            this.AuthMethod = authMethod;
            this.C2sAccessPortal = c2sAccessPortal;
            this.CredentialBlob = credentialBlob;
            this.CredentialEndpoint = credentialEndpoint;
            this.IamRoleArn = iamRoleArn;
            this.ReadOnlyIamRoleArn = readOnlyIamRoleArn;
            this.Region = region;
            this.SecretAccessKey = secretAccessKey;
            this.ServiceUrl = serviceUrl;
            this.SignatureVersion = signatureVersion;
            this.TierType = tierType;
            this.Tiers = tiers;
            this.UseHttps = useHttps;
        }
        
        /// <summary>
        /// Specifies whether this vault supports AWS Lambda based GC. A Lambda function needs to be deployed in the customer&#39;s AWS environment or the IAM user should have permissions to create one.
        /// </summary>
        /// <value>Specifies whether this vault supports AWS Lambda based GC. A Lambda function needs to be deployed in the customer&#39;s AWS environment or the IAM user should have permissions to create one.</value>
        [DataMember(Name="IsLambdaBasedGCEnabled", EmitDefaultValue=false)]
        public bool? IsLambdaBasedGCEnabled { get; set; }

        /// <summary>
        /// Specifies the access key for Amazon service account. See the Cohesity online help for the value to specify for this field based on the current S3 Compatible Vault (External Target) type. For example for Iron Mountain, specify the user name from Iron Mountain for this field.
        /// </summary>
        /// <value>Specifies the access key for Amazon service account. See the Cohesity online help for the value to specify for this field based on the current S3 Compatible Vault (External Target) type. For example for Iron Mountain, specify the user name from Iron Mountain for this field.</value>
        [DataMember(Name="accessKeyId", EmitDefaultValue=false)]
        public string AccessKeyId { get; set; }


        /// <summary>
        /// Gets or Sets C2sAccessPortal
        /// </summary>
        [DataMember(Name="c2sAccessPortal", EmitDefaultValue=false)]
        public C2SAccessPortal C2sAccessPortal { get; set; }

        /// <summary>
        /// Specifies the credential blob to authenticate with credential endpoint.
        /// </summary>
        /// <value>Specifies the credential blob to authenticate with credential endpoint.</value>
        [DataMember(Name="credentialBlob", EmitDefaultValue=false)]
        public string CredentialBlob { get; set; }

        /// <summary>
        /// Specifies the credential process that generates the security token.
        /// </summary>
        /// <value>Specifies the credential process that generates the security token.</value>
        [DataMember(Name="credentialEndpoint", EmitDefaultValue=false)]
        public string CredentialEndpoint { get; set; }

        /// <summary>
        /// Specifies the iam role arn Amazon service account. See the Cohesity online help for the value to specify for this field based on the current S3-compatible Vault (External Target) type.
        /// </summary>
        /// <value>Specifies the iam role arn Amazon service account. See the Cohesity online help for the value to specify for this field based on the current S3-compatible Vault (External Target) type.</value>
        [DataMember(Name="iamRoleArn", EmitDefaultValue=false)]
        public string IamRoleArn { get; set; }

        /// <summary>
        /// Specifies a read-only iam role arn Amazon service account. See the Cohesity online help for the value to specify for this field based on the current S3-compatible Vault (External Target) type.
        /// </summary>
        /// <value>Specifies a read-only iam role arn Amazon service account. See the Cohesity online help for the value to specify for this field based on the current S3-compatible Vault (External Target) type.</value>
        [DataMember(Name="readOnlyIamRoleArn", EmitDefaultValue=false)]
        public string ReadOnlyIamRoleArn { get; set; }

        /// <summary>
        /// Specifies the region to use for the Amazon service account.
        /// </summary>
        /// <value>Specifies the region to use for the Amazon service account.</value>
        [DataMember(Name="region", EmitDefaultValue=false)]
        public string Region { get; set; }

        /// <summary>
        /// Specifies the secret access key for Amazon service account. See the Cohesity online help for the value to specify for this field based on the current S3-compatible Vault (External Target) type.
        /// </summary>
        /// <value>Specifies the secret access key for Amazon service account. See the Cohesity online help for the value to specify for this field based on the current S3-compatible Vault (External Target) type.</value>
        [DataMember(Name="secretAccessKey", EmitDefaultValue=false)]
        public string SecretAccessKey { get; set; }

        /// <summary>
        /// Specifies the URL (Endpoint) for the service such as s3like.notamazon.com. This field is only significant for S3-compatible cloud services.
        /// </summary>
        /// <value>Specifies the URL (Endpoint) for the service such as s3like.notamazon.com. This field is only significant for S3-compatible cloud services.</value>
        [DataMember(Name="serviceUrl", EmitDefaultValue=false)]
        public string ServiceUrl { get; set; }

        /// <summary>
        /// Specifies the version of the S3 Compliance. This field must be set to 2 or 4 and the default version is 2. This field is only significant for S3-compatible cloud services. See the Cohesity online help for the supported S3-compatible Vault (External Target) types and the value to specify for this field based on the current S3-compatible Vault (External Target) type.
        /// </summary>
        /// <value>Specifies the version of the S3 Compliance. This field must be set to 2 or 4 and the default version is 2. This field is only significant for S3-compatible cloud services. See the Cohesity online help for the supported S3-compatible Vault (External Target) types and the value to specify for this field based on the current S3-compatible Vault (External Target) type.</value>
        [DataMember(Name="signatureVersion", EmitDefaultValue=false)]
        public int? SignatureVersion { get; set; }


        /// <summary>
        /// Specifies the list of all tiers for Amazon account.
        /// </summary>
        /// <value>Specifies the list of all tiers for Amazon account.</value>
        [DataMember(Name="tiers", EmitDefaultValue=false)]
        public List<string> Tiers { get; set; }

        /// <summary>
        /// Specifies whether to use http or https to connect to the service. If true, a secure connection (https) is used. This field is only significant for S3-compatible cloud services.
        /// </summary>
        /// <value>Specifies whether to use http or https to connect to the service. If true, a secure connection (https) is used. This field is only significant for S3-compatible cloud services.</value>
        [DataMember(Name="useHttps", EmitDefaultValue=false)]
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
                    this.IsLambdaBasedGCEnabled == input.IsLambdaBasedGCEnabled ||
                    (this.IsLambdaBasedGCEnabled != null &&
                    this.IsLambdaBasedGCEnabled.Equals(input.IsLambdaBasedGCEnabled))
                ) && 
                (
                    this.AccessKeyId == input.AccessKeyId ||
                    (this.AccessKeyId != null &&
                    this.AccessKeyId.Equals(input.AccessKeyId))
                ) && 
                (
                    this.AuthMethod == input.AuthMethod ||
                    (this.AuthMethod != null &&
                    this.AuthMethod.Equals(input.AuthMethod))
                ) && 
                (
                    this.C2sAccessPortal == input.C2sAccessPortal ||
                    (this.C2sAccessPortal != null &&
                    this.C2sAccessPortal.Equals(input.C2sAccessPortal))
                ) && 
                (
                    this.CredentialBlob == input.CredentialBlob ||
                    (this.CredentialBlob != null &&
                    this.CredentialBlob.Equals(input.CredentialBlob))
                ) && 
                (
                    this.CredentialEndpoint == input.CredentialEndpoint ||
                    (this.CredentialEndpoint != null &&
                    this.CredentialEndpoint.Equals(input.CredentialEndpoint))
                ) && 
                (
                    this.IamRoleArn == input.IamRoleArn ||
                    (this.IamRoleArn != null &&
                    this.IamRoleArn.Equals(input.IamRoleArn))
                ) && 
                (
                    this.ReadOnlyIamRoleArn == input.ReadOnlyIamRoleArn ||
                    (this.ReadOnlyIamRoleArn != null &&
                    this.ReadOnlyIamRoleArn.Equals(input.ReadOnlyIamRoleArn))
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
                    (this.TierType != null &&
                    this.TierType.Equals(input.TierType))
                ) && 
                (
                    this.Tiers == input.Tiers ||
                    this.Tiers != null &&
                    this.Tiers.Equals(input.Tiers)
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
                if (this.IsLambdaBasedGCEnabled != null)
                    hashCode = hashCode * 59 + this.IsLambdaBasedGCEnabled.GetHashCode();
                if (this.AccessKeyId != null)
                    hashCode = hashCode * 59 + this.AccessKeyId.GetHashCode();
                if (this.AuthMethod != null)
                    hashCode = hashCode * 59 + this.AuthMethod.GetHashCode();
                if (this.C2sAccessPortal != null)
                    hashCode = hashCode * 59 + this.C2sAccessPortal.GetHashCode();
                if (this.CredentialBlob != null)
                    hashCode = hashCode * 59 + this.CredentialBlob.GetHashCode();
                if (this.CredentialEndpoint != null)
                    hashCode = hashCode * 59 + this.CredentialEndpoint.GetHashCode();
                if (this.IamRoleArn != null)
                    hashCode = hashCode * 59 + this.IamRoleArn.GetHashCode();
                if (this.ReadOnlyIamRoleArn != null)
                    hashCode = hashCode * 59 + this.ReadOnlyIamRoleArn.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.SecretAccessKey != null)
                    hashCode = hashCode * 59 + this.SecretAccessKey.GetHashCode();
                if (this.ServiceUrl != null)
                    hashCode = hashCode * 59 + this.ServiceUrl.GetHashCode();
                if (this.SignatureVersion != null)
                    hashCode = hashCode * 59 + this.SignatureVersion.GetHashCode();
                if (this.TierType != null)
                    hashCode = hashCode * 59 + this.TierType.GetHashCode();
                if (this.Tiers != null)
                    hashCode = hashCode * 59 + this.Tiers.GetHashCode();
                if (this.UseHttps != null)
                    hashCode = hashCode * 59 + this.UseHttps.GetHashCode();
                return hashCode;
            }
        }

    }

}


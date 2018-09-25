// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// Specifies the cloud credentials to connect to a Amazon service account. Glacier, S3, and S3-compatible clouds all use these credentials.
    /// </summary>
    [DataContract]
    public partial class AmazonCloudCredentials :  IEquatable<AmazonCloudCredentials>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AmazonCloudCredentials" /> class.
        /// </summary>
        /// <param name="accessKeyId">Specifies the access key for Amazon service account. See the Cohesity online help for the value to specify for this field based on the current S3 Compatible Vault (External Target) type. For example for Iron Mountain, specify the user name from Iron Mountain for this field..</param>
        /// <param name="region">Specifies the region to use for the Amazon service account..</param>
        /// <param name="secretAccessKey">Specifies the secret access key for Amazon service account. See the Cohesity online help for the value to specify for this field based on the current S3-compatible Vault (External Target) type..</param>
        /// <param name="serviceUrl">Specifies the URL (Endpoint) for the service such as s3like.notamazon.com. This field is only significant for S3-compatible cloud services..</param>
        /// <param name="signatureVersion">Specifies the version of the S3 Compliance. This field must be set to 2 or 4 and the default version is 2. This field is only significant for S3-compatible cloud services. See the Cohesity online help for the supported S3-compatible Vault (External Target) types and the value to specify for this field based on the current S3-compatible Vault (External Target) type..</param>
        /// <param name="useHttps">Specifies whether to use http or https to connect to the service. If true, a secure connection (https) is used. This field is only significant for S3-compatible cloud services..</param>
        public AmazonCloudCredentials(string accessKeyId = default(string), string region = default(string), string secretAccessKey = default(string), string serviceUrl = default(string), int? signatureVersion = default(int?), bool? useHttps = default(bool?))
        {
            this.AccessKeyId = accessKeyId;
            this.Region = region;
            this.SecretAccessKey = secretAccessKey;
            this.ServiceUrl = serviceUrl;
            this.SignatureVersion = signatureVersion;
            this.UseHttps = useHttps;
        }
        
        /// <summary>
        /// Specifies the access key for Amazon service account. See the Cohesity online help for the value to specify for this field based on the current S3 Compatible Vault (External Target) type. For example for Iron Mountain, specify the user name from Iron Mountain for this field.
        /// </summary>
        /// <value>Specifies the access key for Amazon service account. See the Cohesity online help for the value to specify for this field based on the current S3 Compatible Vault (External Target) type. For example for Iron Mountain, specify the user name from Iron Mountain for this field.</value>
        [DataMember(Name="accessKeyId", EmitDefaultValue=false)]
        public string AccessKeyId { get; set; }

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
        /// Specifies whether to use http or https to connect to the service. If true, a secure connection (https) is used. This field is only significant for S3-compatible cloud services.
        /// </summary>
        /// <value>Specifies whether to use http or https to connect to the service. If true, a secure connection (https) is used. This field is only significant for S3-compatible cloud services.</value>
        [DataMember(Name="useHttps", EmitDefaultValue=false)]
        public bool? UseHttps { get; set; }

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
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.SecretAccessKey != null)
                    hashCode = hashCode * 59 + this.SecretAccessKey.GetHashCode();
                if (this.ServiceUrl != null)
                    hashCode = hashCode * 59 + this.ServiceUrl.GetHashCode();
                if (this.SignatureVersion != null)
                    hashCode = hashCode * 59 + this.SignatureVersion.GetHashCode();
                if (this.UseHttps != null)
                    hashCode = hashCode * 59 + this.UseHttps.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


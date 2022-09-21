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
    /// AwsKmsUpdateParams
    /// </summary>
    [DataContract]
    public partial class AwsKmsUpdateParams :  IEquatable<AwsKmsUpdateParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AwsKmsUpdateParams" /> class.
        /// </summary>
        /// <param name="accessKeyId">Access key id needed to access the cloud account. When update cluster config, should encrypte accessKeyId with cluster ID..</param>
        /// <param name="caCertificatePath">Specify the ca certificate path..</param>
        /// <param name="iamRoleArn">Specifies the IAM role which will be used to access the security credentials required for API calls..</param>
        /// <param name="secretAccessKey">Secret access key needed to access the cloud account. This is encrypted with the cluster id..</param>
        /// <param name="verifySSL">Specify whether to verify SSL when connect with AWS KMS. Default is true..</param>
        public AwsKmsUpdateParams(string accessKeyId = default(string), string caCertificatePath = default(string), string iamRoleArn = default(string), string secretAccessKey = default(string), bool? verifySSL = default(bool?))
        {
            this.AccessKeyId = accessKeyId;
            this.CaCertificatePath = caCertificatePath;
            this.IamRoleArn = iamRoleArn;
            this.SecretAccessKey = secretAccessKey;
            this.VerifySSL = verifySSL;
        }
        
        /// <summary>
        /// Access key id needed to access the cloud account. When update cluster config, should encrypte accessKeyId with cluster ID.
        /// </summary>
        /// <value>Access key id needed to access the cloud account. When update cluster config, should encrypte accessKeyId with cluster ID.</value>
        [DataMember(Name="accessKeyId", EmitDefaultValue=true)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// Specify the ca certificate path.
        /// </summary>
        /// <value>Specify the ca certificate path.</value>
        [DataMember(Name="caCertificatePath", EmitDefaultValue=true)]
        public string CaCertificatePath { get; set; }

        /// <summary>
        /// Specifies the IAM role which will be used to access the security credentials required for API calls.
        /// </summary>
        /// <value>Specifies the IAM role which will be used to access the security credentials required for API calls.</value>
        [DataMember(Name="iamRoleArn", EmitDefaultValue=true)]
        public string IamRoleArn { get; set; }

        /// <summary>
        /// Secret access key needed to access the cloud account. This is encrypted with the cluster id.
        /// </summary>
        /// <value>Secret access key needed to access the cloud account. This is encrypted with the cluster id.</value>
        [DataMember(Name="secretAccessKey", EmitDefaultValue=true)]
        public string SecretAccessKey { get; set; }

        /// <summary>
        /// Specify whether to verify SSL when connect with AWS KMS. Default is true.
        /// </summary>
        /// <value>Specify whether to verify SSL when connect with AWS KMS. Default is true.</value>
        [DataMember(Name="verifySSL", EmitDefaultValue=true)]
        public bool? VerifySSL { get; set; }

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
            return this.Equals(input as AwsKmsUpdateParams);
        }

        /// <summary>
        /// Returns true if AwsKmsUpdateParams instances are equal
        /// </summary>
        /// <param name="input">Instance of AwsKmsUpdateParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AwsKmsUpdateParams input)
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
                    this.CaCertificatePath == input.CaCertificatePath ||
                    (this.CaCertificatePath != null &&
                    this.CaCertificatePath.Equals(input.CaCertificatePath))
                ) && 
                (
                    this.IamRoleArn == input.IamRoleArn ||
                    (this.IamRoleArn != null &&
                    this.IamRoleArn.Equals(input.IamRoleArn))
                ) && 
                (
                    this.SecretAccessKey == input.SecretAccessKey ||
                    (this.SecretAccessKey != null &&
                    this.SecretAccessKey.Equals(input.SecretAccessKey))
                ) && 
                (
                    this.VerifySSL == input.VerifySSL ||
                    (this.VerifySSL != null &&
                    this.VerifySSL.Equals(input.VerifySSL))
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
                if (this.CaCertificatePath != null)
                    hashCode = hashCode * 59 + this.CaCertificatePath.GetHashCode();
                if (this.IamRoleArn != null)
                    hashCode = hashCode * 59 + this.IamRoleArn.GetHashCode();
                if (this.SecretAccessKey != null)
                    hashCode = hashCode * 59 + this.SecretAccessKey.GetHashCode();
                if (this.VerifySSL != null)
                    hashCode = hashCode * 59 + this.VerifySSL.GetHashCode();
                return hashCode;
            }
        }

    }

}


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
    /// AwsKmsConfiguration
    /// </summary>
    [DataContract]
    public partial class AwsKmsConfiguration :  IEquatable<AwsKmsConfiguration>
    {
        /// <summary>
        /// Specifies the authentication method to be used for API calls. Specifies the authentication method to be used for API calls. &#39;kUseIAMUser&#39; indicates a user based authentication. &#39;kUseIAMRole&#39; indicates a role based authentication, used only for AWS CE. &#39;kUseHelios&#39; indicates a Helios based authentication.
        /// </summary>
        /// <value>Specifies the authentication method to be used for API calls. Specifies the authentication method to be used for API calls. &#39;kUseIAMUser&#39; indicates a user based authentication. &#39;kUseIAMRole&#39; indicates a role based authentication, used only for AWS CE. &#39;kUseHelios&#39; indicates a Helios based authentication.</value>
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
            KUseIAMRole = 2,

            /// <summary>
            /// Enum KUseHelios for value: kUseHelios
            /// </summary>
            [EnumMember(Value = "kUseHelios")]
            KUseHelios = 3

        }

        /// <summary>
        /// Specifies the authentication method to be used for API calls. Specifies the authentication method to be used for API calls. &#39;kUseIAMUser&#39; indicates a user based authentication. &#39;kUseIAMRole&#39; indicates a role based authentication, used only for AWS CE. &#39;kUseHelios&#39; indicates a Helios based authentication.
        /// </summary>
        /// <value>Specifies the authentication method to be used for API calls. Specifies the authentication method to be used for API calls. &#39;kUseIAMUser&#39; indicates a user based authentication. &#39;kUseIAMRole&#39; indicates a role based authentication, used only for AWS CE. &#39;kUseHelios&#39; indicates a Helios based authentication.</value>
        [DataMember(Name="authMethod", EmitDefaultValue=true)]
        public AuthMethodEnum? AuthMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AwsKmsConfiguration" /> class.
        /// </summary>
        /// <param name="accessKeyId">Access key id needed to access the cloud account. When update cluster config, should encrypte accessKeyId with cluster ID..</param>
        /// <param name="authMethod">Specifies the authentication method to be used for API calls. Specifies the authentication method to be used for API calls. &#39;kUseIAMUser&#39; indicates a user based authentication. &#39;kUseIAMRole&#39; indicates a role based authentication, used only for AWS CE. &#39;kUseHelios&#39; indicates a Helios based authentication..</param>
        /// <param name="caCertificate">Specify the ca certificate path..</param>
        /// <param name="cmkAlias">The string alias of the CMK..</param>
        /// <param name="cmkArn">The Amazon Resource Number of AWS Customer Managed Key..</param>
        /// <param name="cmkKeyId">AWS keyId, and alias. Only need one of them to connect AWS. Alias is better, because keyId maybe rotated by AWS. The unique key id of the CMK..</param>
        /// <param name="iamRoleArn">Specifies the IAM role which will be used to access the security credentials required for API calls..</param>
        /// <param name="region">AWS region, e.g. us-east-1, us-west-2, for the AWS Glacier service to be used to authenticate resources within this region by the configured AWS account..</param>
        /// <param name="secretAccessKey">Secret access key needed to access the cloud account. This is encrypted with the cluster id..</param>
        /// <param name="verifySSL">Specify whether to verify SSL when connect with AWS KMS. Default is true..</param>
        public AwsKmsConfiguration(string accessKeyId = default(string), AuthMethodEnum? authMethod = default(AuthMethodEnum?), string caCertificate = default(string), string cmkAlias = default(string), string cmkArn = default(string), string cmkKeyId = default(string), string iamRoleArn = default(string), string region = default(string), string secretAccessKey = default(string), bool? verifySSL = default(bool?))
        {
            this.AccessKeyId = accessKeyId;
            this.AuthMethod = authMethod;
            this.CaCertificate = caCertificate;
            this.CmkAlias = cmkAlias;
            this.CmkArn = cmkArn;
            this.CmkKeyId = cmkKeyId;
            this.IamRoleArn = iamRoleArn;
            this.Region = region;
            this.SecretAccessKey = secretAccessKey;
            this.VerifySSL = verifySSL;
            this.AccessKeyId = accessKeyId;
            this.AuthMethod = authMethod;
            this.CaCertificate = caCertificate;
            this.CmkAlias = cmkAlias;
            this.CmkArn = cmkArn;
            this.CmkKeyId = cmkKeyId;
            this.IamRoleArn = iamRoleArn;
            this.Region = region;
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
        [DataMember(Name="caCertificate", EmitDefaultValue=true)]
        public string CaCertificate { get; set; }

        /// <summary>
        /// The string alias of the CMK.
        /// </summary>
        /// <value>The string alias of the CMK.</value>
        [DataMember(Name="cmkAlias", EmitDefaultValue=true)]
        public string CmkAlias { get; set; }

        /// <summary>
        /// The Amazon Resource Number of AWS Customer Managed Key.
        /// </summary>
        /// <value>The Amazon Resource Number of AWS Customer Managed Key.</value>
        [DataMember(Name="cmkArn", EmitDefaultValue=true)]
        public string CmkArn { get; set; }

        /// <summary>
        /// AWS keyId, and alias. Only need one of them to connect AWS. Alias is better, because keyId maybe rotated by AWS. The unique key id of the CMK.
        /// </summary>
        /// <value>AWS keyId, and alias. Only need one of them to connect AWS. Alias is better, because keyId maybe rotated by AWS. The unique key id of the CMK.</value>
        [DataMember(Name="cmkKeyId", EmitDefaultValue=true)]
        public string CmkKeyId { get; set; }

        /// <summary>
        /// Specifies the IAM role which will be used to access the security credentials required for API calls.
        /// </summary>
        /// <value>Specifies the IAM role which will be used to access the security credentials required for API calls.</value>
        [DataMember(Name="iamRoleArn", EmitDefaultValue=true)]
        public string IamRoleArn { get; set; }

        /// <summary>
        /// AWS region, e.g. us-east-1, us-west-2, for the AWS Glacier service to be used to authenticate resources within this region by the configured AWS account.
        /// </summary>
        /// <value>AWS region, e.g. us-east-1, us-west-2, for the AWS Glacier service to be used to authenticate resources within this region by the configured AWS account.</value>
        [DataMember(Name="region", EmitDefaultValue=true)]
        public string Region { get; set; }

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
            return this.Equals(input as AwsKmsConfiguration);
        }

        /// <summary>
        /// Returns true if AwsKmsConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of AwsKmsConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AwsKmsConfiguration input)
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
                    this.AuthMethod == input.AuthMethod ||
                    this.AuthMethod.Equals(input.AuthMethod)
                ) && 
                (
                    this.CaCertificate == input.CaCertificate ||
                    (this.CaCertificate != null &&
                    this.CaCertificate.Equals(input.CaCertificate))
                ) && 
                (
                    this.CmkAlias == input.CmkAlias ||
                    (this.CmkAlias != null &&
                    this.CmkAlias.Equals(input.CmkAlias))
                ) && 
                (
                    this.CmkArn == input.CmkArn ||
                    (this.CmkArn != null &&
                    this.CmkArn.Equals(input.CmkArn))
                ) && 
                (
                    this.CmkKeyId == input.CmkKeyId ||
                    (this.CmkKeyId != null &&
                    this.CmkKeyId.Equals(input.CmkKeyId))
                ) && 
                (
                    this.IamRoleArn == input.IamRoleArn ||
                    (this.IamRoleArn != null &&
                    this.IamRoleArn.Equals(input.IamRoleArn))
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
                hashCode = hashCode * 59 + this.AuthMethod.GetHashCode();
                if (this.CaCertificate != null)
                    hashCode = hashCode * 59 + this.CaCertificate.GetHashCode();
                if (this.CmkAlias != null)
                    hashCode = hashCode * 59 + this.CmkAlias.GetHashCode();
                if (this.CmkArn != null)
                    hashCode = hashCode * 59 + this.CmkArn.GetHashCode();
                if (this.CmkKeyId != null)
                    hashCode = hashCode * 59 + this.CmkKeyId.GetHashCode();
                if (this.IamRoleArn != null)
                    hashCode = hashCode * 59 + this.IamRoleArn.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.SecretAccessKey != null)
                    hashCode = hashCode * 59 + this.SecretAccessKey.GetHashCode();
                if (this.VerifySSL != null)
                    hashCode = hashCode * 59 + this.VerifySSL.GetHashCode();
                return hashCode;
            }
        }

    }

}


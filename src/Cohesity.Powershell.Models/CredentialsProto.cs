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
    /// Copied from: base/credentials.proto -&gt; message Credentials.
    /// </summary>
    [DataContract]
    public partial class CredentialsProto :  IEquatable<CredentialsProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialsProto" /> class.
        /// </summary>
        /// <param name="authMethod">Authentication method to be used for API calls..</param>
        /// <param name="awsManagedAd">awsManagedAd.</param>
        /// <param name="encryptedPassword">AES256 encrypted password. The key for encryption should be obtained from KMS. This field stores the encrypted password when the credentials are being sent to bifrost..</param>
        /// <param name="encryptedToken">AES256 encrypted token.</param>
        /// <param name="managedIdentityClientId">Managed Identity&#39;s client id associated with the Virtual Machine using actions can be performed. Used in case of DMaaS&#39;s dataplane clusters. For User-Assigned Managed Identity only..</param>
        /// <param name="password">This field is not used in storage, other than historical records. The field is only set for inflight rpcs..</param>
        /// <param name="token">The token to use for authentication. For example, in a SAN environment, this can be the API token that is used to create a REST session..</param>
        /// <param name="username">The username and password to use for authentication..</param>
        public CredentialsProto(int? authMethod = default(int?), CredentialsProtoAWSManagedADInfo awsManagedAd = default(CredentialsProtoAWSManagedADInfo), List<int> encryptedPassword = default(List<int>), List<int> encryptedToken = default(List<int>), string managedIdentityClientId = default(string), List<int> password = default(List<int>), string token = default(string), string username = default(string))
        {
            this.AuthMethod = authMethod;
            this.EncryptedPassword = encryptedPassword;
            this.EncryptedToken = encryptedToken;
            this.ManagedIdentityClientId = managedIdentityClientId;
            this.Password = password;
            this.Token = token;
            this.Username = username;
            this.AuthMethod = authMethod;
            this.AwsManagedAd = awsManagedAd;
            this.EncryptedPassword = encryptedPassword;
            this.EncryptedToken = encryptedToken;
            this.ManagedIdentityClientId = managedIdentityClientId;
            this.Password = password;
            this.Token = token;
            this.Username = username;
        }
        
        /// <summary>
        /// Authentication method to be used for API calls.
        /// </summary>
        /// <value>Authentication method to be used for API calls.</value>
        [DataMember(Name="authMethod", EmitDefaultValue=true)]
        public int? AuthMethod { get; set; }

        /// <summary>
        /// Gets or Sets AwsManagedAd
        /// </summary>
        [DataMember(Name="awsManagedAd", EmitDefaultValue=false)]
        public CredentialsProtoAWSManagedADInfo AwsManagedAd { get; set; }

        /// <summary>
        /// AES256 encrypted password. The key for encryption should be obtained from KMS. This field stores the encrypted password when the credentials are being sent to bifrost.
        /// </summary>
        /// <value>AES256 encrypted password. The key for encryption should be obtained from KMS. This field stores the encrypted password when the credentials are being sent to bifrost.</value>
        [DataMember(Name="encryptedPassword", EmitDefaultValue=true)]
        public List<int> EncryptedPassword { get; set; }

        /// <summary>
        /// AES256 encrypted token
        /// </summary>
        /// <value>AES256 encrypted token</value>
        [DataMember(Name="encryptedToken", EmitDefaultValue=true)]
        public List<int> EncryptedToken { get; set; }

        /// <summary>
        /// Managed Identity&#39;s client id associated with the Virtual Machine using actions can be performed. Used in case of DMaaS&#39;s dataplane clusters. For User-Assigned Managed Identity only.
        /// </summary>
        /// <value>Managed Identity&#39;s client id associated with the Virtual Machine using actions can be performed. Used in case of DMaaS&#39;s dataplane clusters. For User-Assigned Managed Identity only.</value>
        [DataMember(Name="managedIdentityClientId", EmitDefaultValue=true)]
        public string ManagedIdentityClientId { get; set; }

        /// <summary>
        /// This field is not used in storage, other than historical records. The field is only set for inflight rpcs.
        /// </summary>
        /// <value>This field is not used in storage, other than historical records. The field is only set for inflight rpcs.</value>
        [DataMember(Name="password", EmitDefaultValue=true)]
        public List<int> Password { get; set; }

        /// <summary>
        /// The token to use for authentication. For example, in a SAN environment, this can be the API token that is used to create a REST session.
        /// </summary>
        /// <value>The token to use for authentication. For example, in a SAN environment, this can be the API token that is used to create a REST session.</value>
        [DataMember(Name="token", EmitDefaultValue=true)]
        public string Token { get; set; }

        /// <summary>
        /// The username and password to use for authentication.
        /// </summary>
        /// <value>The username and password to use for authentication.</value>
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
            return this.Equals(input as CredentialsProto);
        }

        /// <summary>
        /// Returns true if CredentialsProto instances are equal
        /// </summary>
        /// <param name="input">Instance of CredentialsProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CredentialsProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthMethod == input.AuthMethod ||
                    (this.AuthMethod != null &&
                    this.AuthMethod.Equals(input.AuthMethod))
                ) && 
                (
                    this.AwsManagedAd == input.AwsManagedAd ||
                    (this.AwsManagedAd != null &&
                    this.AwsManagedAd.Equals(input.AwsManagedAd))
                ) && 
                (
                    this.EncryptedPassword == input.EncryptedPassword ||
                    this.EncryptedPassword != null &&
                    input.EncryptedPassword != null &&
                    this.EncryptedPassword.SequenceEqual(input.EncryptedPassword)
                ) && 
                (
                    this.EncryptedToken == input.EncryptedToken ||
                    this.EncryptedToken != null &&
                    input.EncryptedToken != null &&
                    this.EncryptedToken.SequenceEqual(input.EncryptedToken)
                ) && 
                (
                    this.ManagedIdentityClientId == input.ManagedIdentityClientId ||
                    (this.ManagedIdentityClientId != null &&
                    this.ManagedIdentityClientId.Equals(input.ManagedIdentityClientId))
                ) && 
                (
                    this.Password == input.Password ||
                    this.Password != null &&
                    input.Password != null &&
                    this.Password.SequenceEqual(input.Password)
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
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
                if (this.AuthMethod != null)
                    hashCode = hashCode * 59 + this.AuthMethod.GetHashCode();
                if (this.AwsManagedAd != null)
                    hashCode = hashCode * 59 + this.AwsManagedAd.GetHashCode();
                if (this.EncryptedPassword != null)
                    hashCode = hashCode * 59 + this.EncryptedPassword.GetHashCode();
                if (this.EncryptedToken != null)
                    hashCode = hashCode * 59 + this.EncryptedToken.GetHashCode();
                if (this.ManagedIdentityClientId != null)
                    hashCode = hashCode * 59 + this.ManagedIdentityClientId.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                return hashCode;
            }
        }

    }

}


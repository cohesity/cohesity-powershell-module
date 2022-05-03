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
    /// Specifies the Cohesity credentials required for generating an access token.
    /// </summary>
    [DataContract]
    public partial class AccessTokenCredential :  IEquatable<AccessTokenCredential>
    {
        /// <summary>
        /// Specifies OTP type for MFA verification. &#39;Totp&#39; implies the code is TOTP. &#39;Email&#39; implies the code is email OTP.
        /// </summary>
        /// <value>Specifies OTP type for MFA verification. &#39;Totp&#39; implies the code is TOTP. &#39;Email&#39; implies the code is email OTP.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OtpTypeEnum
        {
            /// <summary>
            /// Enum Totp for value: Totp
            /// </summary>
            [EnumMember(Value = "Totp")]
            Totp = 1,

            /// <summary>
            /// Enum Email for value: Email
            /// </summary>
            [EnumMember(Value = "Email")]
            Email = 2

        }

        /// <summary>
        /// Specifies OTP type for MFA verification. &#39;Totp&#39; implies the code is TOTP. &#39;Email&#39; implies the code is email OTP.
        /// </summary>
        /// <value>Specifies OTP type for MFA verification. &#39;Totp&#39; implies the code is TOTP. &#39;Email&#39; implies the code is email OTP.</value>
        [DataMember(Name="otpType", EmitDefaultValue=false)]
        public OtpTypeEnum? OtpType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessTokenCredential" /> class.
        /// </summary>
        /// <param name="certificate">Specifies the certificate for logging in the cert base auth cluster..</param>
        /// <param name="domain">Specifies the domain the user is logging in to. For a Local user model, the domain is always LOCAL. For LDAP/AD user models, the domain will map to an LDAP connection string. A user is uniquely identified by a combination of username and domain. If this is not set, LOCAL is assumed..</param>
        /// <param name="otpCode">Specifies OTP code for MFA verification..</param>
        /// <param name="otpType">Specifies OTP type for MFA verification. &#39;Totp&#39; implies the code is TOTP. &#39;Email&#39; implies the code is email OTP..</param>
        /// <param name="password">Specifies the password of the Cohesity user account..</param>
        /// <param name="privateKey">Specifies the matching private key of the above certificate..</param>
        /// <param name="username">Specifies the login name of the Cohesity user..</param>
        public AccessTokenCredential(string certificate = default(string), string domain = default(string), string otpCode = default(string), OtpTypeEnum? otpType = default(OtpTypeEnum?), string password = default(string), string privateKey = default(string), string username = default(string))
        {
            this.Certificate = certificate;
            this.Domain = domain;
            this.OtpCode = otpCode;
            this.OtpType = otpType;
            this.Password = password;
            this.PrivateKey = privateKey;
            this.Username = username;
        }
        
        /// <summary>
        /// Specifies the certificate for logging in the cert base auth cluster.
        /// </summary>
        /// <value>Specifies the certificate for logging in the cert base auth cluster.</value>
        [DataMember(Name="certificate", EmitDefaultValue=false)]
        public string Certificate { get; set; }

        /// <summary>
        /// Specifies the domain the user is logging in to. For a Local user model, the domain is always LOCAL. For LDAP/AD user models, the domain will map to an LDAP connection string. A user is uniquely identified by a combination of username and domain. If this is not set, LOCAL is assumed.
        /// </summary>
        /// <value>Specifies the domain the user is logging in to. For a Local user model, the domain is always LOCAL. For LDAP/AD user models, the domain will map to an LDAP connection string. A user is uniquely identified by a combination of username and domain. If this is not set, LOCAL is assumed.</value>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public string Domain { get; set; }

        /// <summary>
        /// Specifies OTP code for MFA verification.
        /// </summary>
        /// <value>Specifies OTP code for MFA verification.</value>
        [DataMember(Name="otpCode", EmitDefaultValue=false)]
        public string OtpCode { get; set; }


        /// <summary>
        /// Specifies the password of the Cohesity user account.
        /// </summary>
        /// <value>Specifies the password of the Cohesity user account.</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Specifies the matching private key of the above certificate.
        /// </summary>
        /// <value>Specifies the matching private key of the above certificate.</value>
        [DataMember(Name="privateKey", EmitDefaultValue=false)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// Specifies the login name of the Cohesity user.
        /// </summary>
        /// <value>Specifies the login name of the Cohesity user.</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
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
            return this.Equals(input as AccessTokenCredential);
        }

        /// <summary>
        /// Returns true if AccessTokenCredential instances are equal
        /// </summary>
        /// <param name="input">Instance of AccessTokenCredential to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessTokenCredential input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Certificate == input.Certificate ||
                    (this.Certificate != null &&
                    this.Certificate.Equals(input.Certificate))
                ) && 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.OtpCode == input.OtpCode ||
                    (this.OtpCode != null &&
                    this.OtpCode.Equals(input.OtpCode))
                ) && 
                (
                    this.OtpType == input.OtpType ||
                    (this.OtpType != null &&
                    this.OtpType.Equals(input.OtpType))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.PrivateKey == input.PrivateKey ||
                    (this.PrivateKey != null &&
                    this.PrivateKey.Equals(input.PrivateKey))
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
                if (this.Certificate != null)
                    hashCode = hashCode * 59 + this.Certificate.GetHashCode();
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.OtpCode != null)
                    hashCode = hashCode * 59 + this.OtpCode.GetHashCode();
                if (this.OtpType != null)
                    hashCode = hashCode * 59 + this.OtpType.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.PrivateKey != null)
                    hashCode = hashCode * 59 + this.PrivateKey.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                return hashCode;
            }
        }

    }

}


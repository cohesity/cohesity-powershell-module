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
    /// SMBMountUserCredentials
    /// </summary>
    [DataContract]
    public partial class SMBMountUserCredentials :  IEquatable<SMBMountUserCredentials>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SMBMountUserCredentials" /> class.
        /// </summary>
        /// <param name="domainName">Specifies the domain the user belongs to.</param>
        /// <param name="encryptedPassword">Used for storage, will be encrypted with AES.</param>
        /// <param name="isLocalUser">Specifies if the user is a local user or a domain user..</param>
        /// <param name="password">Not for storage, only to use on fly..</param>
        /// <param name="sid">Specifies the SID of the user that is selected..</param>
        /// <param name="username">Username of the user to use for SMB share..</param>
        public SMBMountUserCredentials(string domainName = default(string), string encryptedPassword = default(string), bool? isLocalUser = default(bool?), string password = default(string), string sid = default(string), string username = default(string))
        {
            this.DomainName = domainName;
            this.EncryptedPassword = encryptedPassword;
            this.IsLocalUser = isLocalUser;
            this.Password = password;
            this.Sid = sid;
            this.Username = username;
            this.DomainName = domainName;
            this.EncryptedPassword = encryptedPassword;
            this.IsLocalUser = isLocalUser;
            this.Password = password;
            this.Sid = sid;
            this.Username = username;
        }
        
        /// <summary>
        /// Specifies the domain the user belongs to
        /// </summary>
        /// <value>Specifies the domain the user belongs to</value>
        [DataMember(Name="domainName", EmitDefaultValue=true)]
        public string DomainName { get; set; }

        /// <summary>
        /// Used for storage, will be encrypted with AES
        /// </summary>
        /// <value>Used for storage, will be encrypted with AES</value>
        [DataMember(Name="encryptedPassword", EmitDefaultValue=true)]
        public string EncryptedPassword { get; set; }

        /// <summary>
        /// Specifies if the user is a local user or a domain user.
        /// </summary>
        /// <value>Specifies if the user is a local user or a domain user.</value>
        [DataMember(Name="isLocalUser", EmitDefaultValue=true)]
        public bool? IsLocalUser { get; set; }

        /// <summary>
        /// Not for storage, only to use on fly.
        /// </summary>
        /// <value>Not for storage, only to use on fly.</value>
        [DataMember(Name="password", EmitDefaultValue=true)]
        public string Password { get; set; }

        /// <summary>
        /// Specifies the SID of the user that is selected.
        /// </summary>
        /// <value>Specifies the SID of the user that is selected.</value>
        [DataMember(Name="sid", EmitDefaultValue=true)]
        public string Sid { get; set; }

        /// <summary>
        /// Username of the user to use for SMB share.
        /// </summary>
        /// <value>Username of the user to use for SMB share.</value>
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
            return this.Equals(input as SMBMountUserCredentials);
        }

        /// <summary>
        /// Returns true if SMBMountUserCredentials instances are equal
        /// </summary>
        /// <param name="input">Instance of SMBMountUserCredentials to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SMBMountUserCredentials input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DomainName == input.DomainName ||
                    (this.DomainName != null &&
                    this.DomainName.Equals(input.DomainName))
                ) && 
                (
                    this.EncryptedPassword == input.EncryptedPassword ||
                    (this.EncryptedPassword != null &&
                    this.EncryptedPassword.Equals(input.EncryptedPassword))
                ) && 
                (
                    this.IsLocalUser == input.IsLocalUser ||
                    (this.IsLocalUser != null &&
                    this.IsLocalUser.Equals(input.IsLocalUser))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Sid == input.Sid ||
                    (this.Sid != null &&
                    this.Sid.Equals(input.Sid))
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
                if (this.DomainName != null)
                    hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.EncryptedPassword != null)
                    hashCode = hashCode * 59 + this.EncryptedPassword.GetHashCode();
                if (this.IsLocalUser != null)
                    hashCode = hashCode * 59 + this.IsLocalUser.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Sid != null)
                    hashCode = hashCode * 59 + this.Sid.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                return hashCode;
            }
        }

    }

}


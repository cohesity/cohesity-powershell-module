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
    /// Specifies details about a user.
    /// </summary>
    [DataContract]
    public partial class User :  IEquatable<User>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="createdTimeMsecs">Specifies the epoch time in milliseconds when the user account was created on the Cohesity Cluster..</param>
        /// <param name="description">Specifies a description about the user..</param>
        /// <param name="domain">Specifies the fully qualified domain name (FQDN) of an Active Directory or LOCAL for the default LOCAL domain on the Cohesity Cluster. A user is uniquely identified by combination of the username and the domain..</param>
        /// <param name="effectiveTimeMsecs">Specifies the epoch time in milliseconds when the user becomes effective. Until that time, the user cannot log in..</param>
        /// <param name="emailAddress">Specifies the email address of the user..</param>
        /// <param name="lastUpdatedTimeMsecs">Specifies the epoch time in milliseconds when the user account was last modified on the Cohesity Cluster..</param>
        /// <param name="password">Specifies the password of this user..</param>
        /// <param name="restricted">Whether the user is a restricted user. A restricted user can only view the objects he has permissions to..</param>
        /// <param name="roles">Specifies the Cohesity roles to associate with the user such as such as &#39;Admin&#39;, &#39;Ops&#39; or &#39;View&#39;. The Cohesity roles determine privileges on the Cohesity Cluster for this user..</param>
        /// <param name="s3AccessKeyId">Specifies the S3 Account Access Key ID..</param>
        /// <param name="s3AccountId">Specifies the S3 Account Canonical User ID..</param>
        /// <param name="s3SecretKey">Specifies the S3 Account Secret Key..</param>
        /// <param name="sid">Specifies the unique Security ID (SID) of the user..</param>
        /// <param name="username">Specifies the login name of the user..</param>
        public User(long? createdTimeMsecs = default(long?), string description = default(string), string domain = default(string), long? effectiveTimeMsecs = default(long?), string emailAddress = default(string), long? lastUpdatedTimeMsecs = default(long?), string password = default(string), bool? restricted = default(bool?), List<string> roles = default(List<string>), string s3AccessKeyId = default(string), string s3AccountId = default(string), string s3SecretKey = default(string), string sid = default(string), string username = default(string))
        {
            this.CreatedTimeMsecs = createdTimeMsecs;
            this.Description = description;
            this.Domain = domain;
            this.EffectiveTimeMsecs = effectiveTimeMsecs;
            this.EmailAddress = emailAddress;
            this.LastUpdatedTimeMsecs = lastUpdatedTimeMsecs;
            this.Password = password;
            this.Restricted = restricted;
            this.Roles = roles;
            this.S3AccessKeyId = s3AccessKeyId;
            this.S3AccountId = s3AccountId;
            this.S3SecretKey = s3SecretKey;
            this.Sid = sid;
            this.Username = username;
        }
        
        /// <summary>
        /// Specifies the epoch time in milliseconds when the user account was created on the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the epoch time in milliseconds when the user account was created on the Cohesity Cluster.</value>
        [DataMember(Name="createdTimeMsecs", EmitDefaultValue=false)]
        public long? CreatedTimeMsecs { get; set; }

        /// <summary>
        /// Specifies a description about the user.
        /// </summary>
        /// <value>Specifies a description about the user.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies the fully qualified domain name (FQDN) of an Active Directory or LOCAL for the default LOCAL domain on the Cohesity Cluster. A user is uniquely identified by combination of the username and the domain.
        /// </summary>
        /// <value>Specifies the fully qualified domain name (FQDN) of an Active Directory or LOCAL for the default LOCAL domain on the Cohesity Cluster. A user is uniquely identified by combination of the username and the domain.</value>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public string Domain { get; set; }

        /// <summary>
        /// Specifies the epoch time in milliseconds when the user becomes effective. Until that time, the user cannot log in.
        /// </summary>
        /// <value>Specifies the epoch time in milliseconds when the user becomes effective. Until that time, the user cannot log in.</value>
        [DataMember(Name="effectiveTimeMsecs", EmitDefaultValue=false)]
        public long? EffectiveTimeMsecs { get; set; }

        /// <summary>
        /// Specifies the email address of the user.
        /// </summary>
        /// <value>Specifies the email address of the user.</value>
        [DataMember(Name="emailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Specifies the epoch time in milliseconds when the user account was last modified on the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the epoch time in milliseconds when the user account was last modified on the Cohesity Cluster.</value>
        [DataMember(Name="lastUpdatedTimeMsecs", EmitDefaultValue=false)]
        public long? LastUpdatedTimeMsecs { get; set; }

        /// <summary>
        /// Specifies the password of this user.
        /// </summary>
        /// <value>Specifies the password of this user.</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Whether the user is a restricted user. A restricted user can only view the objects he has permissions to.
        /// </summary>
        /// <value>Whether the user is a restricted user. A restricted user can only view the objects he has permissions to.</value>
        [DataMember(Name="restricted", EmitDefaultValue=false)]
        public bool? Restricted { get; set; }

        /// <summary>
        /// Specifies the Cohesity roles to associate with the user such as such as &#39;Admin&#39;, &#39;Ops&#39; or &#39;View&#39;. The Cohesity roles determine privileges on the Cohesity Cluster for this user.
        /// </summary>
        /// <value>Specifies the Cohesity roles to associate with the user such as such as &#39;Admin&#39;, &#39;Ops&#39; or &#39;View&#39;. The Cohesity roles determine privileges on the Cohesity Cluster for this user.</value>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// Specifies the S3 Account Access Key ID.
        /// </summary>
        /// <value>Specifies the S3 Account Access Key ID.</value>
        [DataMember(Name="s3AccessKeyId", EmitDefaultValue=false)]
        public string S3AccessKeyId { get; set; }

        /// <summary>
        /// Specifies the S3 Account Canonical User ID.
        /// </summary>
        /// <value>Specifies the S3 Account Canonical User ID.</value>
        [DataMember(Name="s3AccountId", EmitDefaultValue=false)]
        public string S3AccountId { get; set; }

        /// <summary>
        /// Specifies the S3 Account Secret Key.
        /// </summary>
        /// <value>Specifies the S3 Account Secret Key.</value>
        [DataMember(Name="s3SecretKey", EmitDefaultValue=false)]
        public string S3SecretKey { get; set; }

        /// <summary>
        /// Specifies the unique Security ID (SID) of the user.
        /// </summary>
        /// <value>Specifies the unique Security ID (SID) of the user.</value>
        [DataMember(Name="sid", EmitDefaultValue=false)]
        public string Sid { get; set; }

        /// <summary>
        /// Specifies the login name of the user.
        /// </summary>
        /// <value>Specifies the login name of the user.</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

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
            return this.Equals(input as User);
        }

        /// <summary>
        /// Returns true if User instances are equal
        /// </summary>
        /// <param name="input">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedTimeMsecs == input.CreatedTimeMsecs ||
                    (this.CreatedTimeMsecs != null &&
                    this.CreatedTimeMsecs.Equals(input.CreatedTimeMsecs))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.EffectiveTimeMsecs == input.EffectiveTimeMsecs ||
                    (this.EffectiveTimeMsecs != null &&
                    this.EffectiveTimeMsecs.Equals(input.EffectiveTimeMsecs))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.LastUpdatedTimeMsecs == input.LastUpdatedTimeMsecs ||
                    (this.LastUpdatedTimeMsecs != null &&
                    this.LastUpdatedTimeMsecs.Equals(input.LastUpdatedTimeMsecs))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Restricted == input.Restricted ||
                    (this.Restricted != null &&
                    this.Restricted.Equals(input.Restricted))
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
                ) && 
                (
                    this.S3AccessKeyId == input.S3AccessKeyId ||
                    (this.S3AccessKeyId != null &&
                    this.S3AccessKeyId.Equals(input.S3AccessKeyId))
                ) && 
                (
                    this.S3AccountId == input.S3AccountId ||
                    (this.S3AccountId != null &&
                    this.S3AccountId.Equals(input.S3AccountId))
                ) && 
                (
                    this.S3SecretKey == input.S3SecretKey ||
                    (this.S3SecretKey != null &&
                    this.S3SecretKey.Equals(input.S3SecretKey))
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
                if (this.CreatedTimeMsecs != null)
                    hashCode = hashCode * 59 + this.CreatedTimeMsecs.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.EffectiveTimeMsecs != null)
                    hashCode = hashCode * 59 + this.EffectiveTimeMsecs.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.LastUpdatedTimeMsecs != null)
                    hashCode = hashCode * 59 + this.LastUpdatedTimeMsecs.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Restricted != null)
                    hashCode = hashCode * 59 + this.Restricted.GetHashCode();
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
                if (this.S3AccessKeyId != null)
                    hashCode = hashCode * 59 + this.S3AccessKeyId.GetHashCode();
                if (this.S3AccountId != null)
                    hashCode = hashCode * 59 + this.S3AccountId.GetHashCode();
                if (this.S3SecretKey != null)
                    hashCode = hashCode * 59 + this.S3SecretKey.GetHashCode();
                if (this.Sid != null)
                    hashCode = hashCode * 59 + this.Sid.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


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
    /// Specifies the settings used to create/add a new user or modify an existing user.
    /// </summary>
    [DataContract]
    public partial class UserParameters :  IEquatable<UserParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserParameters" /> class.
        /// </summary>
        /// <param name="additionalGroupNames">Array of Additional Groups.  Specifies the names of additional groups this User may belong to..</param>
        /// <param name="clusterIdentifiers">Specifies the list of clusters this user has access to. If this is not specified, access will be granted to all clusters..</param>
        /// <param name="description">Specifies a description about the user..</param>
        /// <param name="domain">Specifies the fully qualified domain name (FQDN) of an Active Directory or LOCAL for the default LOCAL domain on the Cohesity Cluster. A user is uniquely identified by combination of the username and the domain..</param>
        /// <param name="effectiveTimeMsecs">Specifies the epoch time in milliseconds when the user becomes effective. Until that time, the user cannot log in..</param>
        /// <param name="emailAddress">Specifies the email address of the user..</param>
        /// <param name="expiredTimeMsecs">Specifies the epoch time in milliseconds when the user becomes expired. After that, the user cannot log in..</param>
        /// <param name="password">Specifies the password of this user..</param>
        /// <param name="primaryGroupName">Specifies the name of the primary group of this User..</param>
        /// <param name="privilegeIds">Array of Privileges.  Specifies the Cohesity privileges from the roles. This will be populated based on the union of all privileges in roles..</param>
        /// <param name="restricted">Whether the user is a restricted user. A restricted user can only view the objects he has permissions to..</param>
        /// <param name="roles">Array of Roles.  Specifies the Cohesity roles to associate with the user such as such as &#39;Admin&#39;, &#39;Ops&#39; or &#39;View&#39;. The Cohesity roles determine privileges on the Cohesity Cluster for this user..</param>
        /// <param name="username">Specifies the login name of the user..</param>
        public UserParameters(List<string> additionalGroupNames = default(List<string>), List<ClusterIdentifier> clusterIdentifiers = default(List<ClusterIdentifier>), string description = default(string), string domain = default(string), long? effectiveTimeMsecs = default(long?), string emailAddress = default(string), long? expiredTimeMsecs = default(long?), string password = default(string), string primaryGroupName = default(string), List<int> privilegeIds = default(List<int>), bool? restricted = default(bool?), List<string> roles = default(List<string>), string username = default(string))
        {
            this.AdditionalGroupNames = additionalGroupNames;
            this.ClusterIdentifiers = clusterIdentifiers;
            this.Description = description;
            this.Domain = domain;
            this.EffectiveTimeMsecs = effectiveTimeMsecs;
            this.EmailAddress = emailAddress;
            this.ExpiredTimeMsecs = expiredTimeMsecs;
            this.Password = password;
            this.PrimaryGroupName = primaryGroupName;
            this.PrivilegeIds = privilegeIds;
            this.Restricted = restricted;
            this.Roles = roles;
            this.Username = username;
            this.AdditionalGroupNames = additionalGroupNames;
            this.ClusterIdentifiers = clusterIdentifiers;
            this.Description = description;
            this.Domain = domain;
            this.EffectiveTimeMsecs = effectiveTimeMsecs;
            this.EmailAddress = emailAddress;
            this.ExpiredTimeMsecs = expiredTimeMsecs;
            this.Password = password;
            this.PrimaryGroupName = primaryGroupName;
            this.PrivilegeIds = privilegeIds;
            this.Restricted = restricted;
            this.Roles = roles;
            this.Username = username;
        }
        
        /// <summary>
        /// Array of Additional Groups.  Specifies the names of additional groups this User may belong to.
        /// </summary>
        /// <value>Array of Additional Groups.  Specifies the names of additional groups this User may belong to.</value>
        [DataMember(Name="additionalGroupNames", EmitDefaultValue=true)]
        public List<string> AdditionalGroupNames { get; set; }

        /// <summary>
        /// Specifies the list of clusters this user has access to. If this is not specified, access will be granted to all clusters.
        /// </summary>
        /// <value>Specifies the list of clusters this user has access to. If this is not specified, access will be granted to all clusters.</value>
        [DataMember(Name="clusterIdentifiers", EmitDefaultValue=true)]
        public List<ClusterIdentifier> ClusterIdentifiers { get; set; }

        /// <summary>
        /// Specifies a description about the user.
        /// </summary>
        /// <value>Specifies a description about the user.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies the fully qualified domain name (FQDN) of an Active Directory or LOCAL for the default LOCAL domain on the Cohesity Cluster. A user is uniquely identified by combination of the username and the domain.
        /// </summary>
        /// <value>Specifies the fully qualified domain name (FQDN) of an Active Directory or LOCAL for the default LOCAL domain on the Cohesity Cluster. A user is uniquely identified by combination of the username and the domain.</value>
        [DataMember(Name="domain", EmitDefaultValue=true)]
        public string Domain { get; set; }

        /// <summary>
        /// Specifies the epoch time in milliseconds when the user becomes effective. Until that time, the user cannot log in.
        /// </summary>
        /// <value>Specifies the epoch time in milliseconds when the user becomes effective. Until that time, the user cannot log in.</value>
        [DataMember(Name="effectiveTimeMsecs", EmitDefaultValue=true)]
        public long? EffectiveTimeMsecs { get; set; }

        /// <summary>
        /// Specifies the email address of the user.
        /// </summary>
        /// <value>Specifies the email address of the user.</value>
        [DataMember(Name="emailAddress", EmitDefaultValue=true)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Specifies the epoch time in milliseconds when the user becomes expired. After that, the user cannot log in.
        /// </summary>
        /// <value>Specifies the epoch time in milliseconds when the user becomes expired. After that, the user cannot log in.</value>
        [DataMember(Name="expiredTimeMsecs", EmitDefaultValue=true)]
        public long? ExpiredTimeMsecs { get; set; }

        /// <summary>
        /// Specifies the password of this user.
        /// </summary>
        /// <value>Specifies the password of this user.</value>
        [DataMember(Name="password", EmitDefaultValue=true)]
        public string Password { get; set; }

        /// <summary>
        /// Specifies the name of the primary group of this User.
        /// </summary>
        /// <value>Specifies the name of the primary group of this User.</value>
        [DataMember(Name="primaryGroupName", EmitDefaultValue=true)]
        public string PrimaryGroupName { get; set; }

        /// <summary>
        /// Array of Privileges.  Specifies the Cohesity privileges from the roles. This will be populated based on the union of all privileges in roles.
        /// </summary>
        /// <value>Array of Privileges.  Specifies the Cohesity privileges from the roles. This will be populated based on the union of all privileges in roles.</value>
        [DataMember(Name="privilegeIds", EmitDefaultValue=true)]
        public List<int> PrivilegeIds { get; set; }

        /// <summary>
        /// Whether the user is a restricted user. A restricted user can only view the objects he has permissions to.
        /// </summary>
        /// <value>Whether the user is a restricted user. A restricted user can only view the objects he has permissions to.</value>
        [DataMember(Name="restricted", EmitDefaultValue=true)]
        public bool? Restricted { get; set; }

        /// <summary>
        /// Array of Roles.  Specifies the Cohesity roles to associate with the user such as such as &#39;Admin&#39;, &#39;Ops&#39; or &#39;View&#39;. The Cohesity roles determine privileges on the Cohesity Cluster for this user.
        /// </summary>
        /// <value>Array of Roles.  Specifies the Cohesity roles to associate with the user such as such as &#39;Admin&#39;, &#39;Ops&#39; or &#39;View&#39;. The Cohesity roles determine privileges on the Cohesity Cluster for this user.</value>
        [DataMember(Name="roles", EmitDefaultValue=true)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// Specifies the login name of the user.
        /// </summary>
        /// <value>Specifies the login name of the user.</value>
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
            return this.Equals(input as UserParameters);
        }

        /// <summary>
        /// Returns true if UserParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of UserParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdditionalGroupNames == input.AdditionalGroupNames ||
                    this.AdditionalGroupNames != null &&
                    input.AdditionalGroupNames != null &&
                    this.AdditionalGroupNames.SequenceEqual(input.AdditionalGroupNames)
                ) && 
                (
                    this.ClusterIdentifiers == input.ClusterIdentifiers ||
                    this.ClusterIdentifiers != null &&
                    input.ClusterIdentifiers != null &&
                    this.ClusterIdentifiers.SequenceEqual(input.ClusterIdentifiers)
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
                    this.ExpiredTimeMsecs == input.ExpiredTimeMsecs ||
                    (this.ExpiredTimeMsecs != null &&
                    this.ExpiredTimeMsecs.Equals(input.ExpiredTimeMsecs))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.PrimaryGroupName == input.PrimaryGroupName ||
                    (this.PrimaryGroupName != null &&
                    this.PrimaryGroupName.Equals(input.PrimaryGroupName))
                ) && 
                (
                    this.PrivilegeIds == input.PrivilegeIds ||
                    this.PrivilegeIds != null &&
                    input.PrivilegeIds != null &&
                    this.PrivilegeIds.SequenceEqual(input.PrivilegeIds)
                ) && 
                (
                    this.Restricted == input.Restricted ||
                    (this.Restricted != null &&
                    this.Restricted.Equals(input.Restricted))
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    input.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
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
                if (this.AdditionalGroupNames != null)
                    hashCode = hashCode * 59 + this.AdditionalGroupNames.GetHashCode();
                if (this.ClusterIdentifiers != null)
                    hashCode = hashCode * 59 + this.ClusterIdentifiers.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.EffectiveTimeMsecs != null)
                    hashCode = hashCode * 59 + this.EffectiveTimeMsecs.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.ExpiredTimeMsecs != null)
                    hashCode = hashCode * 59 + this.ExpiredTimeMsecs.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.PrimaryGroupName != null)
                    hashCode = hashCode * 59 + this.PrimaryGroupName.GetHashCode();
                if (this.PrivilegeIds != null)
                    hashCode = hashCode * 59 + this.PrivilegeIds.GetHashCode();
                if (this.Restricted != null)
                    hashCode = hashCode * 59 + this.Restricted.GetHashCode();
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                return hashCode;
            }
        }

    }

}


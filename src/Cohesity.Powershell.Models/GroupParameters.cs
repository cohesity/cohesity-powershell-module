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
    /// Specifies the settings used to add/create a new group or modify an existing group.
    /// </summary>
    [DataContract]
    public partial class GroupParameters :  IEquatable<GroupParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupParameters" /> class.
        /// </summary>
        /// <param name="description">Specifies a description of the group..</param>
        /// <param name="domain">Specifies the domain of the group..</param>
        /// <param name="name">Specifies the name of the group..</param>
        /// <param name="restricted">Whether the group is a restricted group. Users belonging to a restricted group can only view objects they have permissions to..</param>
        /// <param name="roles">Array of Roles.  Specifies the Cohesity roles to associate with the group such as &#39;Admin&#39;, &#39;Ops&#39; or &#39;View&#39;. The Cohesity roles determine privileges on the Cohesity Cluster for all the users in this group..</param>
        /// <param name="smbPrincipals">Specifies the SMB principals. Principals will be added to this group only if IsSmbPrincipalOnly set to true..</param>
        /// <param name="tenantIds">Specifies the tenants to which the group belongs to. If not specified, session user&#39;s tenant id is assumed..</param>
        /// <param name="users">Specifies the SID of users who are members of the group. This field is used only for local groups..</param>
        public GroupParameters(string description = default(string), string domain = default(string), string name = default(string), bool? restricted = default(bool?), List<string> roles = default(List<string>), List<SmbPrincipal> smbPrincipals = default(List<SmbPrincipal>), List<string> tenantIds = default(List<string>), List<string> users = default(List<string>))
        {
            this.Description = description;
            this.Domain = domain;
            this.Name = name;
            this.Restricted = restricted;
            this.Roles = roles;
            this.SmbPrincipals = smbPrincipals;
            this.TenantIds = tenantIds;
            this.Users = users;
        }
        
        /// <summary>
        /// Specifies a description of the group.
        /// </summary>
        /// <value>Specifies a description of the group.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies the domain of the group.
        /// </summary>
        /// <value>Specifies the domain of the group.</value>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public string Domain { get; set; }

        /// <summary>
        /// Specifies the name of the group.
        /// </summary>
        /// <value>Specifies the name of the group.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Whether the group is a restricted group. Users belonging to a restricted group can only view objects they have permissions to.
        /// </summary>
        /// <value>Whether the group is a restricted group. Users belonging to a restricted group can only view objects they have permissions to.</value>
        [DataMember(Name="restricted", EmitDefaultValue=false)]
        public bool? Restricted { get; set; }

        /// <summary>
        /// Array of Roles.  Specifies the Cohesity roles to associate with the group such as &#39;Admin&#39;, &#39;Ops&#39; or &#39;View&#39;. The Cohesity roles determine privileges on the Cohesity Cluster for all the users in this group.
        /// </summary>
        /// <value>Array of Roles.  Specifies the Cohesity roles to associate with the group such as &#39;Admin&#39;, &#39;Ops&#39; or &#39;View&#39;. The Cohesity roles determine privileges on the Cohesity Cluster for all the users in this group.</value>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// Specifies the SMB principals. Principals will be added to this group only if IsSmbPrincipalOnly set to true.
        /// </summary>
        /// <value>Specifies the SMB principals. Principals will be added to this group only if IsSmbPrincipalOnly set to true.</value>
        [DataMember(Name="smbPrincipals", EmitDefaultValue=false)]
        public List<SmbPrincipal> SmbPrincipals { get; set; }

        /// <summary>
        /// Specifies the tenants to which the group belongs to. If not specified, session user&#39;s tenant id is assumed.
        /// </summary>
        /// <value>Specifies the tenants to which the group belongs to. If not specified, session user&#39;s tenant id is assumed.</value>
        [DataMember(Name="tenantIds", EmitDefaultValue=false)]
        public List<string> TenantIds { get; set; }

        /// <summary>
        /// Specifies the SID of users who are members of the group. This field is used only for local groups.
        /// </summary>
        /// <value>Specifies the SID of users who are members of the group. This field is used only for local groups.</value>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<string> Users { get; set; }

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
            return this.Equals(input as GroupParameters);
        }

        /// <summary>
        /// Returns true if GroupParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupParameters input)
        {
            if (input == null)
                return false;

            return 
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Restricted == input.Restricted ||
                    (this.Restricted != null &&
                    this.Restricted.Equals(input.Restricted))
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    this.Roles.Equals(input.Roles)
                ) && 
                (
                    this.SmbPrincipals == input.SmbPrincipals ||
                    this.SmbPrincipals != null &&
                    this.SmbPrincipals.Equals(input.SmbPrincipals)
                ) && 
                (
                    this.TenantIds == input.TenantIds ||
                    this.TenantIds != null &&
                    this.TenantIds.Equals(input.TenantIds)
                ) && 
                (
                    this.Users == input.Users ||
                    this.Users != null &&
                    this.Users.Equals(input.Users)
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Restricted != null)
                    hashCode = hashCode * 59 + this.Restricted.GetHashCode();
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
                if (this.SmbPrincipals != null)
                    hashCode = hashCode * 59 + this.SmbPrincipals.GetHashCode();
                if (this.TenantIds != null)
                    hashCode = hashCode * 59 + this.TenantIds.GetHashCode();
                if (this.Users != null)
                    hashCode = hashCode * 59 + this.Users.GetHashCode();
                return hashCode;
            }
        }

    }

}


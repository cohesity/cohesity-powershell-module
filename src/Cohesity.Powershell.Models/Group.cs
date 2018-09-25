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
    /// Specifies details about the group.
    /// </summary>
    [DataContract]
    public partial class Group :  IEquatable<Group>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Group" /> class.
        /// </summary>
        /// <param name="createdTimeMsecs">Specifies the epoch time in milliseconds when the group was created/added..</param>
        /// <param name="description">Specifies a description of the group..</param>
        /// <param name="domain">Specifies the domain of the group..</param>
        /// <param name="lastUpdatedTimeMsecs">Specifies the epoch time in milliseconds when the group was last modified..</param>
        /// <param name="name">Specifies the name of the group..</param>
        /// <param name="restricted">Whether the group is a restricted group. Users belonging to a restricted group can only view objects they have permissions to..</param>
        /// <param name="roles">Specifies the Cohesity roles to associate with the group such as &#39;Admin&#39;, &#39;Ops&#39; or &#39;View&#39;. The Cohesity roles determine privileges on the Cohesity Cluster for all the users in this group..</param>
        /// <param name="sid">Specifies the unique Security ID (SID) of the group..</param>
        public Group(long? createdTimeMsecs = default(long?), string description = default(string), string domain = default(string), long? lastUpdatedTimeMsecs = default(long?), string name = default(string), bool? restricted = default(bool?), List<string> roles = default(List<string>), string sid = default(string))
        {
            this.CreatedTimeMsecs = createdTimeMsecs;
            this.Description = description;
            this.Domain = domain;
            this.LastUpdatedTimeMsecs = lastUpdatedTimeMsecs;
            this.Name = name;
            this.Restricted = restricted;
            this.Roles = roles;
            this.Sid = sid;
        }
        
        /// <summary>
        /// Specifies the epoch time in milliseconds when the group was created/added.
        /// </summary>
        /// <value>Specifies the epoch time in milliseconds when the group was created/added.</value>
        [DataMember(Name="createdTimeMsecs", EmitDefaultValue=false)]
        public long? CreatedTimeMsecs { get; set; }

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
        /// Specifies the epoch time in milliseconds when the group was last modified.
        /// </summary>
        /// <value>Specifies the epoch time in milliseconds when the group was last modified.</value>
        [DataMember(Name="lastUpdatedTimeMsecs", EmitDefaultValue=false)]
        public long? LastUpdatedTimeMsecs { get; set; }

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
        /// Specifies the Cohesity roles to associate with the group such as &#39;Admin&#39;, &#39;Ops&#39; or &#39;View&#39;. The Cohesity roles determine privileges on the Cohesity Cluster for all the users in this group.
        /// </summary>
        /// <value>Specifies the Cohesity roles to associate with the group such as &#39;Admin&#39;, &#39;Ops&#39; or &#39;View&#39;. The Cohesity roles determine privileges on the Cohesity Cluster for all the users in this group.</value>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// Specifies the unique Security ID (SID) of the group.
        /// </summary>
        /// <value>Specifies the unique Security ID (SID) of the group.</value>
        [DataMember(Name="sid", EmitDefaultValue=false)]
        public string Sid { get; set; }

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
            return this.Equals(input as Group);
        }

        /// <summary>
        /// Returns true if Group instances are equal
        /// </summary>
        /// <param name="input">Instance of Group to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Group input)
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
                    this.LastUpdatedTimeMsecs == input.LastUpdatedTimeMsecs ||
                    (this.LastUpdatedTimeMsecs != null &&
                    this.LastUpdatedTimeMsecs.Equals(input.LastUpdatedTimeMsecs))
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
                    this.Roles.SequenceEqual(input.Roles)
                ) && 
                (
                    this.Sid == input.Sid ||
                    (this.Sid != null &&
                    this.Sid.Equals(input.Sid))
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
                if (this.LastUpdatedTimeMsecs != null)
                    hashCode = hashCode * 59 + this.LastUpdatedTimeMsecs.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Restricted != null)
                    hashCode = hashCode * 59 + this.Restricted.GetHashCode();
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
                if (this.Sid != null)
                    hashCode = hashCode * 59 + this.Sid.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


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
        /// <param name="roles">Specifies the Cohesity roles to associate with the group such as &#39;Admin&#39;, &#39;Ops&#39; or &#39;View&#39;. The Cohesity roles determine privileges on the Cohesity Cluster for all the users in this group..</param>
        public GroupParameters(string description = default(string), string domain = default(string), string name = default(string), bool? restricted = default(bool?), List<string> roles = default(List<string>))
        {
            this.Description = description;
            this.Domain = domain;
            this.Name = name;
            this.Restricted = restricted;
            this.Roles = roles;
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
        /// Specifies the Cohesity roles to associate with the group such as &#39;Admin&#39;, &#39;Ops&#39; or &#39;View&#39;. The Cohesity roles determine privileges on the Cohesity Cluster for all the users in this group.
        /// </summary>
        /// <value>Specifies the Cohesity roles to associate with the group such as &#39;Admin&#39;, &#39;Ops&#39; or &#39;View&#39;. The Cohesity roles determine privileges on the Cohesity Cluster for all the users in this group.</value>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public List<string> Roles { get; set; }

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
                    this.Roles.SequenceEqual(input.Roles)
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
                return hashCode;
            }
        }

        
    }

}


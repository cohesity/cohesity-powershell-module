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
    /// Specifies the parameters required to create a new custom role such as the name, description and the privileges to assign to the role.
    /// </summary>
    [DataContract]
    public partial class RoleCreateParameters :  IEquatable<RoleCreateParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleCreateParameters" /> class.
        /// </summary>
        /// <param name="description">Specifies a description about the role..</param>
        /// <param name="name">Specifies the name of the custom role..</param>
        /// <param name="privileges">Specifies the list of privileges to assign to the role..</param>
        public RoleCreateParameters(string description = default(string), string name = default(string), List<string> privileges = default(List<string>))
        {
            this.Description = description;
            this.Name = name;
            this.Privileges = privileges;
        }
        
        /// <summary>
        /// Specifies a description about the role.
        /// </summary>
        /// <value>Specifies a description about the role.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies the name of the custom role.
        /// </summary>
        /// <value>Specifies the name of the custom role.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the list of privileges to assign to the role.
        /// </summary>
        /// <value>Specifies the list of privileges to assign to the role.</value>
        [DataMember(Name="privileges", EmitDefaultValue=false)]
        public List<string> Privileges { get; set; }

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
            return this.Equals(input as RoleCreateParameters);
        }

        /// <summary>
        /// Returns true if RoleCreateParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of RoleCreateParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoleCreateParameters input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Privileges == input.Privileges ||
                    this.Privileges != null &&
                    this.Privileges.SequenceEqual(input.Privileges)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Privileges != null)
                    hashCode = hashCode * 59 + this.Privileges.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


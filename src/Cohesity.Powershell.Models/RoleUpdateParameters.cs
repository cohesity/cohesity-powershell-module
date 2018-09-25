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
    /// Specifies parameters required to update a role.
    /// </summary>
    [DataContract]
    public partial class RoleUpdateParameters :  IEquatable<RoleUpdateParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleUpdateParameters" /> class.
        /// </summary>
        /// <param name="description">Specifies a description about the role..</param>
        /// <param name="privileges">Specifies the list of privileges to assign to the role..</param>
        public RoleUpdateParameters(string description = default(string), List<string> privileges = default(List<string>))
        {
            this.Description = description;
            this.Privileges = privileges;
        }
        
        /// <summary>
        /// Specifies a description about the role.
        /// </summary>
        /// <value>Specifies a description about the role.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

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
            return this.Equals(input as RoleUpdateParameters);
        }

        /// <summary>
        /// Returns true if RoleUpdateParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of RoleUpdateParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoleUpdateParameters input)
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
                if (this.Privileges != null)
                    hashCode = hashCode * 59 + this.Privileges.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


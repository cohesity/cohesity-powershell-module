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
    /// Specifies the parameters required for deleting one or more roles.
    /// </summary>
    [DataContract]
    public partial class RoleDeleteParameters :  IEquatable<RoleDeleteParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleDeleteParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RoleDeleteParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleDeleteParameters" /> class.
        /// </summary>
        /// <param name="names">Specifies the list of roles to delete which are specified by role names. (required).</param>
        public RoleDeleteParameters(List<string> names = default(List<string>))
        {
            // to ensure "names" is required (not null)
            if (names == null)
            {
                throw new InvalidDataException("names is a required property for RoleDeleteParameters and cannot be null");
            }
            else
            {
                this.Names = names;
            }
        }
        
        /// <summary>
        /// Specifies the list of roles to delete which are specified by role names.
        /// </summary>
        /// <value>Specifies the list of roles to delete which are specified by role names.</value>
        [DataMember(Name="names", EmitDefaultValue=false)]
        public List<string> Names { get; set; }

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
            return this.Equals(input as RoleDeleteParameters);
        }

        /// <summary>
        /// Returns true if RoleDeleteParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of RoleDeleteParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoleDeleteParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Names == input.Names ||
                    this.Names != null &&
                    this.Names.SequenceEqual(input.Names)
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
                if (this.Names != null)
                    hashCode = hashCode * 59 + this.Names.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


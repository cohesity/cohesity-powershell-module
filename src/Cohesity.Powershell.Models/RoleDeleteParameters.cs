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
        /// <param name="names">Array of Role Names.  Specifies the list of roles to delete which are specified by role names. (required).</param>
        public RoleDeleteParameters(List<string> names = default(List<string>))
        {
            this.Names = names;
        }
        
        /// <summary>
        /// Array of Role Names.  Specifies the list of roles to delete which are specified by role names.
        /// </summary>
        /// <value>Array of Role Names.  Specifies the list of roles to delete which are specified by role names.</value>
        [DataMember(Name="names", EmitDefaultValue=true)]
        public List<string> Names { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoleDeleteParameters {\n");
            sb.Append("  Names: ").Append(Names).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
                    input.Names != null &&
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

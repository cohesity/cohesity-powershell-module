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
    /// Pattern
    /// </summary>
    [DataContract]
    public partial class Pattern :  IEquatable<Pattern>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pattern" /> class.
        /// </summary>
        /// <param name="isSystemDefined">Whether this pattern is system defined..</param>
        /// <param name="name">Name of the pattern. This is marked optional but is required..</param>
        /// <param name="type">Pattern type..</param>
        /// <param name="value">Value of the pattern. This is marked optional but is required..</param>
        public Pattern(bool? isSystemDefined = default(bool?), string name = default(string), int? type = default(int?), string value = default(string))
        {
            this.IsSystemDefined = isSystemDefined;
            this.Name = name;
            this.Type = type;
            this.Value = value;
            this.IsSystemDefined = isSystemDefined;
            this.Name = name;
            this.Type = type;
            this.Value = value;
        }
        
        /// <summary>
        /// Whether this pattern is system defined.
        /// </summary>
        /// <value>Whether this pattern is system defined.</value>
        [DataMember(Name="isSystemDefined", EmitDefaultValue=true)]
        public bool? IsSystemDefined { get; set; }

        /// <summary>
        /// Name of the pattern. This is marked optional but is required.
        /// </summary>
        /// <value>Name of the pattern. This is marked optional but is required.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Pattern type.
        /// </summary>
        /// <value>Pattern type.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public int? Type { get; set; }

        /// <summary>
        /// Value of the pattern. This is marked optional but is required.
        /// </summary>
        /// <value>Value of the pattern. This is marked optional but is required.</value>
        [DataMember(Name="value", EmitDefaultValue=true)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Pattern {\n");
            sb.Append("  IsSystemDefined: ").Append(IsSystemDefined).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as Pattern);
        }

        /// <summary>
        /// Returns true if Pattern instances are equal
        /// </summary>
        /// <param name="input">Instance of Pattern to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Pattern input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsSystemDefined == input.IsSystemDefined ||
                    (this.IsSystemDefined != null &&
                    this.IsSystemDefined.Equals(input.IsSystemDefined))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.IsSystemDefined != null)
                    hashCode = hashCode * 59 + this.IsSystemDefined.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }

    }

}

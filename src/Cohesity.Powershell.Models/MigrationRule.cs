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
    /// MigrationRule
    /// </summary>
    [DataContract]
    public partial class MigrationRule :  IEquatable<MigrationRule>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationRule" /> class.
        /// </summary>
        /// <param name="currentValue">The existing value of the fields that needs to be mutated. Currently, this is utilized by the kRegion and kZone rules..</param>
        /// <param name="newValue">The new value with which the fields need to be updated with. Currently, this is utilized by the kRegion and kZone rules..</param>
        /// <param name="type">What migration rule is being used..</param>
        public MigrationRule(string currentValue = default(string), string newValue = default(string), int? type = default(int?))
        {
            this.CurrentValue = currentValue;
            this.NewValue = newValue;
            this.Type = type;
            this.CurrentValue = currentValue;
            this.NewValue = newValue;
            this.Type = type;
        }
        
        /// <summary>
        /// The existing value of the fields that needs to be mutated. Currently, this is utilized by the kRegion and kZone rules.
        /// </summary>
        /// <value>The existing value of the fields that needs to be mutated. Currently, this is utilized by the kRegion and kZone rules.</value>
        [DataMember(Name="current_value", EmitDefaultValue=true)]
        public string CurrentValue { get; set; }

        /// <summary>
        /// The new value with which the fields need to be updated with. Currently, this is utilized by the kRegion and kZone rules.
        /// </summary>
        /// <value>The new value with which the fields need to be updated with. Currently, this is utilized by the kRegion and kZone rules.</value>
        [DataMember(Name="new_value", EmitDefaultValue=true)]
        public string NewValue { get; set; }

        /// <summary>
        /// What migration rule is being used.
        /// </summary>
        /// <value>What migration rule is being used.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public int? Type { get; set; }

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
            return this.Equals(input as MigrationRule);
        }

        /// <summary>
        /// Returns true if MigrationRule instances are equal
        /// </summary>
        /// <param name="input">Instance of MigrationRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MigrationRule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrentValue == input.CurrentValue ||
                    (this.CurrentValue != null &&
                    this.CurrentValue.Equals(input.CurrentValue))
                ) && 
                (
                    this.NewValue == input.NewValue ||
                    (this.NewValue != null &&
                    this.NewValue.Equals(input.NewValue))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.CurrentValue != null)
                    hashCode = hashCode * 59 + this.CurrentValue.GetHashCode();
                if (this.NewValue != null)
                    hashCode = hashCode * 59 + this.NewValue.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}


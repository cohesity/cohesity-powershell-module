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
    /// ConditionKeyValues
    /// </summary>
    [DataContract]
    public partial class ConditionKeyValues :  IEquatable<ConditionKeyValues>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionKeyValues" /> class.
        /// </summary>
        /// <param name="valueVec">This field specifies the values for the key..</param>
        public ConditionKeyValues(List<string> valueVec = default(List<string>))
        {
            this.ValueVec = valueVec;
            this.ValueVec = valueVec;
        }
        
        /// <summary>
        /// This field specifies the values for the key.
        /// </summary>
        /// <value>This field specifies the values for the key.</value>
        [DataMember(Name="valueVec", EmitDefaultValue=true)]
        public List<string> ValueVec { get; set; }

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
            return this.Equals(input as ConditionKeyValues);
        }

        /// <summary>
        /// Returns true if ConditionKeyValues instances are equal
        /// </summary>
        /// <param name="input">Instance of ConditionKeyValues to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConditionKeyValues input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ValueVec == input.ValueVec ||
                    this.ValueVec != null &&
                    input.ValueVec != null &&
                    this.ValueVec.Equals(input.ValueVec)
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
                if (this.ValueVec != null)
                    hashCode = hashCode * 59 + this.ValueVec.GetHashCode();
                return hashCode;
            }
        }

    }

}


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
    /// CompareADObjectsResultADAttributeValue
    /// </summary>
    [DataContract]
    public partial class CompareADObjectsResultADAttributeValue :  IEquatable<CompareADObjectsResultADAttributeValue>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompareADObjectsResultADAttributeValue" /> class.
        /// </summary>
        /// <param name="valueFlags">Object result flags of type ADAttributeValueFlags..</param>
        /// <param name="valueVec">String representation of attribute value. For single valued property, only one value will be present here. For multi-valued properties such as group membership, this field will contain values that are in same order as contained in AD. Each AD attribute value will be converted to string. If this property is not set, then the property has null value..</param>
        public CompareADObjectsResultADAttributeValue(int? valueFlags = default(int?), List<string> valueVec = default(List<string>))
        {
            this.ValueFlags = valueFlags;
            this.ValueVec = valueVec;
        }
        
        /// <summary>
        /// Object result flags of type ADAttributeValueFlags.
        /// </summary>
        /// <value>Object result flags of type ADAttributeValueFlags.</value>
        [DataMember(Name="valueFlags", EmitDefaultValue=false)]
        public int? ValueFlags { get; set; }

        /// <summary>
        /// String representation of attribute value. For single valued property, only one value will be present here. For multi-valued properties such as group membership, this field will contain values that are in same order as contained in AD. Each AD attribute value will be converted to string. If this property is not set, then the property has null value.
        /// </summary>
        /// <value>String representation of attribute value. For single valued property, only one value will be present here. For multi-valued properties such as group membership, this field will contain values that are in same order as contained in AD. Each AD attribute value will be converted to string. If this property is not set, then the property has null value.</value>
        [DataMember(Name="valueVec", EmitDefaultValue=false)]
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
            return this.Equals(input as CompareADObjectsResultADAttributeValue);
        }

        /// <summary>
        /// Returns true if CompareADObjectsResultADAttributeValue instances are equal
        /// </summary>
        /// <param name="input">Instance of CompareADObjectsResultADAttributeValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompareADObjectsResultADAttributeValue input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ValueFlags == input.ValueFlags ||
                    (this.ValueFlags != null &&
                    this.ValueFlags.Equals(input.ValueFlags))
                ) && 
                (
                    this.ValueVec == input.ValueVec ||
                    this.ValueVec != null &&
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
                if (this.ValueFlags != null)
                    hashCode = hashCode * 59 + this.ValueFlags.GetHashCode();
                if (this.ValueVec != null)
                    hashCode = hashCode * 59 + this.ValueVec.GetHashCode();
                return hashCode;
            }
        }

    }

}


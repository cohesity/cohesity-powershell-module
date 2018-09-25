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
    /// Specify data in the appropriate field for the current data type.
    /// </summary>
    [DataContract]
    public partial class ValueData :  IEquatable<ValueData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueData" /> class.
        /// </summary>
        /// <param name="bytesValue">Specifies the field to store an array of bytes if the current data type is bytes. Specify a value for this field when type is equal to 4..</param>
        /// <param name="doubleValue">Specifies the field to store data if the current data type is a double value. Specify a value for this field when type is equal to 2..</param>
        /// <param name="int64Value">Specifies the field to store data if the current data type is a int64 value. Specify a value for this field when type is equal to 1..</param>
        /// <param name="stringValue">Specifies the field to store data if the current data type is a string value. Specify a value for this field when type is equal to 3..</param>
        public ValueData(List<int?> bytesValue = default(List<int?>), double? doubleValue = default(double?), long? int64Value = default(long?), string stringValue = default(string))
        {
            this.BytesValue = bytesValue;
            this.DoubleValue = doubleValue;
            this.Int64Value = int64Value;
            this.StringValue = stringValue;
        }
        
        /// <summary>
        /// Specifies the field to store an array of bytes if the current data type is bytes. Specify a value for this field when type is equal to 4.
        /// </summary>
        /// <value>Specifies the field to store an array of bytes if the current data type is bytes. Specify a value for this field when type is equal to 4.</value>
        [DataMember(Name="bytesValue", EmitDefaultValue=false)]
        public List<int?> BytesValue { get; set; }

        /// <summary>
        /// Specifies the field to store data if the current data type is a double value. Specify a value for this field when type is equal to 2.
        /// </summary>
        /// <value>Specifies the field to store data if the current data type is a double value. Specify a value for this field when type is equal to 2.</value>
        [DataMember(Name="doubleValue", EmitDefaultValue=false)]
        public double? DoubleValue { get; set; }

        /// <summary>
        /// Specifies the field to store data if the current data type is a int64 value. Specify a value for this field when type is equal to 1.
        /// </summary>
        /// <value>Specifies the field to store data if the current data type is a int64 value. Specify a value for this field when type is equal to 1.</value>
        [DataMember(Name="int64Value", EmitDefaultValue=false)]
        public long? Int64Value { get; set; }

        /// <summary>
        /// Specifies the field to store data if the current data type is a string value. Specify a value for this field when type is equal to 3.
        /// </summary>
        /// <value>Specifies the field to store data if the current data type is a string value. Specify a value for this field when type is equal to 3.</value>
        [DataMember(Name="stringValue", EmitDefaultValue=false)]
        public string StringValue { get; set; }

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
            return this.Equals(input as ValueData);
        }

        /// <summary>
        /// Returns true if ValueData instances are equal
        /// </summary>
        /// <param name="input">Instance of ValueData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValueData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BytesValue == input.BytesValue ||
                    this.BytesValue != null &&
                    this.BytesValue.SequenceEqual(input.BytesValue)
                ) && 
                (
                    this.DoubleValue == input.DoubleValue ||
                    (this.DoubleValue != null &&
                    this.DoubleValue.Equals(input.DoubleValue))
                ) && 
                (
                    this.Int64Value == input.Int64Value ||
                    (this.Int64Value != null &&
                    this.Int64Value.Equals(input.Int64Value))
                ) && 
                (
                    this.StringValue == input.StringValue ||
                    (this.StringValue != null &&
                    this.StringValue.Equals(input.StringValue))
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
                if (this.BytesValue != null)
                    hashCode = hashCode * 59 + this.BytesValue.GetHashCode();
                if (this.DoubleValue != null)
                    hashCode = hashCode * 59 + this.DoubleValue.GetHashCode();
                if (this.Int64Value != null)
                    hashCode = hashCode * 59 + this.Int64Value.GetHashCode();
                if (this.StringValue != null)
                    hashCode = hashCode * 59 + this.StringValue.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


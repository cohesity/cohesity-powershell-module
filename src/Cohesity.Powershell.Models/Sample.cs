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
    /// Specifies a sample of data collected at a timestamp.
    /// </summary>
    [DataContract]
    public partial class Sample :  IEquatable<Sample>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Sample" /> class.
        /// </summary>
        /// <param name="floatValue">Specifies the value of the data sample if the type is float64. This field is nil if the type of the data is not a float value..</param>
        /// <param name="timestampMsecs">Specifies the timestamp when the data sample occured..</param>
        /// <param name="value">Specifies the value of the data sample if the type is int64. This field is nil if the type of the data is not an int value..</param>
        public Sample(double? floatValue = default(double?), long? timestampMsecs = default(long?), long? value = default(long?))
        {
            this.FloatValue = floatValue;
            this.TimestampMsecs = timestampMsecs;
            this.Value = value;
            this.FloatValue = floatValue;
            this.TimestampMsecs = timestampMsecs;
            this.Value = value;
        }
        
        /// <summary>
        /// Specifies the value of the data sample if the type is float64. This field is nil if the type of the data is not a float value.
        /// </summary>
        /// <value>Specifies the value of the data sample if the type is float64. This field is nil if the type of the data is not a float value.</value>
        [DataMember(Name="floatValue", EmitDefaultValue=true)]
        public double? FloatValue { get; set; }

        /// <summary>
        /// Specifies the timestamp when the data sample occured.
        /// </summary>
        /// <value>Specifies the timestamp when the data sample occured.</value>
        [DataMember(Name="timestampMsecs", EmitDefaultValue=true)]
        public long? TimestampMsecs { get; set; }

        /// <summary>
        /// Specifies the value of the data sample if the type is int64. This field is nil if the type of the data is not an int value.
        /// </summary>
        /// <value>Specifies the value of the data sample if the type is int64. This field is nil if the type of the data is not an int value.</value>
        [DataMember(Name="value", EmitDefaultValue=true)]
        public long? Value { get; set; }

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
            return this.Equals(input as Sample);
        }

        /// <summary>
        /// Returns true if Sample instances are equal
        /// </summary>
        /// <param name="input">Instance of Sample to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Sample input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FloatValue == input.FloatValue ||
                    (this.FloatValue != null &&
                    this.FloatValue.Equals(input.FloatValue))
                ) && 
                (
                    this.TimestampMsecs == input.TimestampMsecs ||
                    (this.TimestampMsecs != null &&
                    this.TimestampMsecs.Equals(input.TimestampMsecs))
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
                if (this.FloatValue != null)
                    hashCode = hashCode * 59 + this.FloatValue.GetHashCode();
                if (this.TimestampMsecs != null)
                    hashCode = hashCode * 59 + this.TimestampMsecs.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }

    }

}


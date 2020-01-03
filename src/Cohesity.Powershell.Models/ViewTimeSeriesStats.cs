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
    /// Specifies the View Time Series stats.
    /// </summary>
    [DataContract]
    public partial class ViewTimeSeriesStats :  IEquatable<ViewTimeSeriesStats>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewTimeSeriesStats" /> class.
        /// </summary>
        /// <param name="timestampMsecs">Specifies the timestamp in milliseconds..</param>
        /// <param name="value">Specifies the value of the specified metric at the timestamp..</param>
        public ViewTimeSeriesStats(long? timestampMsecs = default(long?), long? value = default(long?))
        {
            this.TimestampMsecs = timestampMsecs;
            this.Value = value;
            this.TimestampMsecs = timestampMsecs;
            this.Value = value;
        }
        
        /// <summary>
        /// Specifies the timestamp in milliseconds.
        /// </summary>
        /// <value>Specifies the timestamp in milliseconds.</value>
        [DataMember(Name="timestampMsecs", EmitDefaultValue=true)]
        public long? TimestampMsecs { get; set; }

        /// <summary>
        /// Specifies the value of the specified metric at the timestamp.
        /// </summary>
        /// <value>Specifies the value of the specified metric at the timestamp.</value>
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
            return this.Equals(input as ViewTimeSeriesStats);
        }

        /// <summary>
        /// Returns true if ViewTimeSeriesStats instances are equal
        /// </summary>
        /// <param name="input">Instance of ViewTimeSeriesStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewTimeSeriesStats input)
        {
            if (input == null)
                return false;

            return 
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
                if (this.TimestampMsecs != null)
                    hashCode = hashCode * 59 + this.TimestampMsecs.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }

    }

}


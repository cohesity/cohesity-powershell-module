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
    /// Specifies one data point of a metric.
    /// </summary>
    [DataContract]
    public partial class MetricValue :  IEquatable<MetricValue>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetricValue" /> class.
        /// </summary>
        /// <param name="metricName">Specifies the metric name..</param>
        /// <param name="timestampMsecs">Specifies the creation time of a data point as a Unix epoch Timestamp (in milliseconds)..</param>
        /// <param name="value">Specifies the value of the data point..</param>
        public MetricValue(string metricName = default(string), long? timestampMsecs = default(long?), Value value = default(Value))
        {
            this.MetricName = metricName;
            this.TimestampMsecs = timestampMsecs;
            this.Value = value;
        }
        
        /// <summary>
        /// Specifies the metric name.
        /// </summary>
        /// <value>Specifies the metric name.</value>
        [DataMember(Name="metricName", EmitDefaultValue=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// Specifies the creation time of a data point as a Unix epoch Timestamp (in milliseconds).
        /// </summary>
        /// <value>Specifies the creation time of a data point as a Unix epoch Timestamp (in milliseconds).</value>
        [DataMember(Name="timestampMsecs", EmitDefaultValue=false)]
        public long? TimestampMsecs { get; set; }

        /// <summary>
        /// Specifies the value of the data point.
        /// </summary>
        /// <value>Specifies the value of the data point.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public Value Value { get; set; }

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
            return this.Equals(input as MetricValue);
        }

        /// <summary>
        /// Returns true if MetricValue instances are equal
        /// </summary>
        /// <param name="input">Instance of MetricValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetricValue input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MetricName == input.MetricName ||
                    (this.MetricName != null &&
                    this.MetricName.Equals(input.MetricName))
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
                if (this.MetricName != null)
                    hashCode = hashCode * 59 + this.MetricName.GetHashCode();
                if (this.TimestampMsecs != null)
                    hashCode = hashCode * 59 + this.TimestampMsecs.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


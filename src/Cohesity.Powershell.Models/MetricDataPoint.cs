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
    /// Specifies information about a single data point in a time series.
    /// </summary>
    [DataContract]
    public partial class MetricDataPoint :  IEquatable<MetricDataPoint>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetricDataPoint" /> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="rollupFunction">If this is a rolled up data point, following enum denotes the rollup function used for rolling up. For a raw point this enum is not set..</param>
        /// <param name="timestampMsecs">Specifies a timestamp when the metric data point was captured..</param>
        public MetricDataPoint(ValueData data = default(ValueData), int? rollupFunction = default(int?), long? timestampMsecs = default(long?))
        {
            this.Data = data;
            this.RollupFunction = rollupFunction;
            this.TimestampMsecs = timestampMsecs;
        }
        
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public ValueData Data { get; set; }

        /// <summary>
        /// If this is a rolled up data point, following enum denotes the rollup function used for rolling up. For a raw point this enum is not set.
        /// </summary>
        /// <value>If this is a rolled up data point, following enum denotes the rollup function used for rolling up. For a raw point this enum is not set.</value>
        [DataMember(Name="rollupFunction", EmitDefaultValue=false)]
        public int? RollupFunction { get; set; }

        /// <summary>
        /// Specifies a timestamp when the metric data point was captured.
        /// </summary>
        /// <value>Specifies a timestamp when the metric data point was captured.</value>
        [DataMember(Name="timestampMsecs", EmitDefaultValue=false)]
        public long? TimestampMsecs { get; set; }

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
            return this.Equals(input as MetricDataPoint);
        }

        /// <summary>
        /// Returns true if MetricDataPoint instances are equal
        /// </summary>
        /// <param name="input">Instance of MetricDataPoint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetricDataPoint input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.RollupFunction == input.RollupFunction ||
                    (this.RollupFunction != null &&
                    this.RollupFunction.Equals(input.RollupFunction))
                ) && 
                (
                    this.TimestampMsecs == input.TimestampMsecs ||
                    (this.TimestampMsecs != null &&
                    this.TimestampMsecs.Equals(input.TimestampMsecs))
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
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.RollupFunction != null)
                    hashCode = hashCode * 59 + this.RollupFunction.GetHashCode();
                if (this.TimestampMsecs != null)
                    hashCode = hashCode * 59 + this.TimestampMsecs.GetHashCode();
                return hashCode;
            }
        }

    }

}


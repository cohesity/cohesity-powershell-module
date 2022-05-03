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
    /// Specifies the File distribution metrics.
    /// </summary>
    [DataContract]
    public partial class FileDistributionMetrics :  IEquatable<FileDistributionMetrics>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileDistributionMetrics" /> class.
        /// </summary>
        /// <param name="metricName">Specifies the name of the metric..</param>
        /// <param name="value">Specifies the value of specified metric name..</param>
        public FileDistributionMetrics(string metricName = default(string), long? value = default(long?))
        {
            this.MetricName = metricName;
            this.Value = value;
        }
        
        /// <summary>
        /// Specifies the name of the metric.
        /// </summary>
        /// <value>Specifies the name of the metric.</value>
        [DataMember(Name="metricName", EmitDefaultValue=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// Specifies the value of specified metric name.
        /// </summary>
        /// <value>Specifies the value of specified metric name.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
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
            return this.Equals(input as FileDistributionMetrics);
        }

        /// <summary>
        /// Returns true if FileDistributionMetrics instances are equal
        /// </summary>
        /// <param name="input">Instance of FileDistributionMetrics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileDistributionMetrics input)
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
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }

    }

}


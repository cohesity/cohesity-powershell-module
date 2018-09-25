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
    /// MetricDataBlock
    /// </summary>
    [DataContract]
    public partial class MetricDataBlock :  IEquatable<MetricDataBlock>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetricDataBlock" /> class.
        /// </summary>
        /// <param name="dataPointVec">Specifies a list of metric data points for a time series..</param>
        /// <param name="metricName">Specifies the name of a metric such as &#39;kDiskAwaitTimeMsecs&#39;..</param>
        /// <param name="type">Specifies the data type of the data points. 0 specifies a data point of type Int64. 1 specifies a data point of type Double. 2 specifies a data point of type String. 3 specifies a data point of type Bytes..</param>
        public MetricDataBlock(List<MetricDataPoint> dataPointVec = default(List<MetricDataPoint>), string metricName = default(string), int? type = default(int?))
        {
            this.DataPointVec = dataPointVec;
            this.MetricName = metricName;
            this.Type = type;
        }
        
        /// <summary>
        /// Specifies a list of metric data points for a time series.
        /// </summary>
        /// <value>Specifies a list of metric data points for a time series.</value>
        [DataMember(Name="dataPointVec", EmitDefaultValue=false)]
        public List<MetricDataPoint> DataPointVec { get; set; }

        /// <summary>
        /// Specifies the name of a metric such as &#39;kDiskAwaitTimeMsecs&#39;.
        /// </summary>
        /// <value>Specifies the name of a metric such as &#39;kDiskAwaitTimeMsecs&#39;.</value>
        [DataMember(Name="metricName", EmitDefaultValue=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// Specifies the data type of the data points. 0 specifies a data point of type Int64. 1 specifies a data point of type Double. 2 specifies a data point of type String. 3 specifies a data point of type Bytes.
        /// </summary>
        /// <value>Specifies the data type of the data points. 0 specifies a data point of type Int64. 1 specifies a data point of type Double. 2 specifies a data point of type String. 3 specifies a data point of type Bytes.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public int? Type { get; set; }

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
            return this.Equals(input as MetricDataBlock);
        }

        /// <summary>
        /// Returns true if MetricDataBlock instances are equal
        /// </summary>
        /// <param name="input">Instance of MetricDataBlock to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetricDataBlock input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DataPointVec == input.DataPointVec ||
                    this.DataPointVec != null &&
                    this.DataPointVec.SequenceEqual(input.DataPointVec)
                ) && 
                (
                    this.MetricName == input.MetricName ||
                    (this.MetricName != null &&
                    this.MetricName.Equals(input.MetricName))
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
                if (this.DataPointVec != null)
                    hashCode = hashCode * 59 + this.DataPointVec.GetHashCode();
                if (this.MetricName != null)
                    hashCode = hashCode * 59 + this.MetricName.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


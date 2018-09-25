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
    /// Specifies the meta-data required to define a time series of data (set of data points) for a metric.
    /// </summary>
    [DataContract]
    public partial class EntitySchemaProtoTimeSeriesDescriptor :  IEquatable<EntitySchemaProtoTimeSeriesDescriptor>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntitySchemaProtoTimeSeriesDescriptor" /> class.
        /// </summary>
        /// <param name="metricDescriptiveName">Specifies a descriptive name for the metric that is displayed in the Advanced Diagnostics of the Cohesity Dashboard. For example for the &#39;kUnmorphedUsageBytes&#39; metric, the descriptive name is \&quot;Total Logical Space Used\&quot;..</param>
        /// <param name="metricName">Specifies the name of the metric such as &#39;kUnmorphedUsageBytes&#39;. It should be unique in an entity schema..</param>
        /// <param name="metricUnit">metricUnit.</param>
        /// <param name="rawMetricPublishIntervalHintSecs">Specifies a suggestion for the interval to collect raw data points..</param>
        /// <param name="timeToLiveSecs">Specifies how long the data point will be stored..</param>
        /// <param name="valueType">Specifies the value type for this metric. A metric of type &#39;string\&quot; is not supported, instead use &#39;bytes&#39;. Note that an aggregate metric of type &#39;bytes&#39; is not supported. 0 specifies a value type of Int64. 1 specifies a value type of Double. 2 specifies a value type of String. 3 specifies a value type of Bytes..</param>
        public EntitySchemaProtoTimeSeriesDescriptor(string metricDescriptiveName = default(string), string metricName = default(string), EntitySchemaProtoTimeSeriesDescriptorMetricUnit metricUnit = default(EntitySchemaProtoTimeSeriesDescriptorMetricUnit), int? rawMetricPublishIntervalHintSecs = default(int?), long? timeToLiveSecs = default(long?), int? valueType = default(int?))
        {
            this.MetricDescriptiveName = metricDescriptiveName;
            this.MetricName = metricName;
            this.MetricUnit = metricUnit;
            this.RawMetricPublishIntervalHintSecs = rawMetricPublishIntervalHintSecs;
            this.TimeToLiveSecs = timeToLiveSecs;
            this.ValueType = valueType;
        }
        
        /// <summary>
        /// Specifies a descriptive name for the metric that is displayed in the Advanced Diagnostics of the Cohesity Dashboard. For example for the &#39;kUnmorphedUsageBytes&#39; metric, the descriptive name is \&quot;Total Logical Space Used\&quot;.
        /// </summary>
        /// <value>Specifies a descriptive name for the metric that is displayed in the Advanced Diagnostics of the Cohesity Dashboard. For example for the &#39;kUnmorphedUsageBytes&#39; metric, the descriptive name is \&quot;Total Logical Space Used\&quot;.</value>
        [DataMember(Name="metricDescriptiveName", EmitDefaultValue=false)]
        public string MetricDescriptiveName { get; set; }

        /// <summary>
        /// Specifies the name of the metric such as &#39;kUnmorphedUsageBytes&#39;. It should be unique in an entity schema.
        /// </summary>
        /// <value>Specifies the name of the metric such as &#39;kUnmorphedUsageBytes&#39;. It should be unique in an entity schema.</value>
        [DataMember(Name="metricName", EmitDefaultValue=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// Gets or Sets MetricUnit
        /// </summary>
        [DataMember(Name="metricUnit", EmitDefaultValue=false)]
        public EntitySchemaProtoTimeSeriesDescriptorMetricUnit MetricUnit { get; set; }

        /// <summary>
        /// Specifies a suggestion for the interval to collect raw data points.
        /// </summary>
        /// <value>Specifies a suggestion for the interval to collect raw data points.</value>
        [DataMember(Name="rawMetricPublishIntervalHintSecs", EmitDefaultValue=false)]
        public int? RawMetricPublishIntervalHintSecs { get; set; }

        /// <summary>
        /// Specifies how long the data point will be stored.
        /// </summary>
        /// <value>Specifies how long the data point will be stored.</value>
        [DataMember(Name="timeToLiveSecs", EmitDefaultValue=false)]
        public long? TimeToLiveSecs { get; set; }

        /// <summary>
        /// Specifies the value type for this metric. A metric of type &#39;string\&quot; is not supported, instead use &#39;bytes&#39;. Note that an aggregate metric of type &#39;bytes&#39; is not supported. 0 specifies a value type of Int64. 1 specifies a value type of Double. 2 specifies a value type of String. 3 specifies a value type of Bytes.
        /// </summary>
        /// <value>Specifies the value type for this metric. A metric of type &#39;string\&quot; is not supported, instead use &#39;bytes&#39;. Note that an aggregate metric of type &#39;bytes&#39; is not supported. 0 specifies a value type of Int64. 1 specifies a value type of Double. 2 specifies a value type of String. 3 specifies a value type of Bytes.</value>
        [DataMember(Name="valueType", EmitDefaultValue=false)]
        public int? ValueType { get; set; }

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
            return this.Equals(input as EntitySchemaProtoTimeSeriesDescriptor);
        }

        /// <summary>
        /// Returns true if EntitySchemaProtoTimeSeriesDescriptor instances are equal
        /// </summary>
        /// <param name="input">Instance of EntitySchemaProtoTimeSeriesDescriptor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntitySchemaProtoTimeSeriesDescriptor input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MetricDescriptiveName == input.MetricDescriptiveName ||
                    (this.MetricDescriptiveName != null &&
                    this.MetricDescriptiveName.Equals(input.MetricDescriptiveName))
                ) && 
                (
                    this.MetricName == input.MetricName ||
                    (this.MetricName != null &&
                    this.MetricName.Equals(input.MetricName))
                ) && 
                (
                    this.MetricUnit == input.MetricUnit ||
                    (this.MetricUnit != null &&
                    this.MetricUnit.Equals(input.MetricUnit))
                ) && 
                (
                    this.RawMetricPublishIntervalHintSecs == input.RawMetricPublishIntervalHintSecs ||
                    (this.RawMetricPublishIntervalHintSecs != null &&
                    this.RawMetricPublishIntervalHintSecs.Equals(input.RawMetricPublishIntervalHintSecs))
                ) && 
                (
                    this.TimeToLiveSecs == input.TimeToLiveSecs ||
                    (this.TimeToLiveSecs != null &&
                    this.TimeToLiveSecs.Equals(input.TimeToLiveSecs))
                ) && 
                (
                    this.ValueType == input.ValueType ||
                    (this.ValueType != null &&
                    this.ValueType.Equals(input.ValueType))
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
                if (this.MetricDescriptiveName != null)
                    hashCode = hashCode * 59 + this.MetricDescriptiveName.GetHashCode();
                if (this.MetricName != null)
                    hashCode = hashCode * 59 + this.MetricName.GetHashCode();
                if (this.MetricUnit != null)
                    hashCode = hashCode * 59 + this.MetricUnit.GetHashCode();
                if (this.RawMetricPublishIntervalHintSecs != null)
                    hashCode = hashCode * 59 + this.RawMetricPublishIntervalHintSecs.GetHashCode();
                if (this.TimeToLiveSecs != null)
                    hashCode = hashCode * 59 + this.TimeToLiveSecs.GetHashCode();
                if (this.ValueType != null)
                    hashCode = hashCode * 59 + this.ValueType.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


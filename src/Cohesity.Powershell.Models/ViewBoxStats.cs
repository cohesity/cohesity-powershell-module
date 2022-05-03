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
    /// Provides statistics about the Storage Domain (View Box).
    /// </summary>
    [DataContract]
    public partial class ViewBoxStats :  IEquatable<ViewBoxStats>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewBoxStats" /> class.
        /// </summary>
        /// <param name="cloudUsagePerfStats">cloudUsagePerfStats.</param>
        /// <param name="dataUsageStats">dataUsageStats.</param>
        /// <param name="id">Specifies the id of the Storage Domain (View Box)..</param>
        /// <param name="localUsagePerfStats">localUsagePerfStats.</param>
        /// <param name="logicalStats">logicalStats.</param>
        /// <param name="usagePerfStats">usagePerfStats.</param>
        public ViewBoxStats(UsageAndPerformanceStats cloudUsagePerfStats = default(UsageAndPerformanceStats), DataUsageStats dataUsageStats = default(DataUsageStats), long? id = default(long?), UsageAndPerformanceStats localUsagePerfStats = default(UsageAndPerformanceStats), LogicalStats logicalStats = default(LogicalStats), UsageAndPerformanceStats usagePerfStats = default(UsageAndPerformanceStats))
        {
            this.CloudUsagePerfStats = cloudUsagePerfStats;
            this.DataUsageStats = dataUsageStats;
            this.Id = id;
            this.LocalUsagePerfStats = localUsagePerfStats;
            this.LogicalStats = logicalStats;
            this.UsagePerfStats = usagePerfStats;
        }
        
        /// <summary>
        /// Gets or Sets CloudUsagePerfStats
        /// </summary>
        [DataMember(Name="cloudUsagePerfStats", EmitDefaultValue=false)]
        public UsageAndPerformanceStats CloudUsagePerfStats { get; set; }

        /// <summary>
        /// Gets or Sets DataUsageStats
        /// </summary>
        [DataMember(Name="dataUsageStats", EmitDefaultValue=false)]
        public DataUsageStats DataUsageStats { get; set; }

        /// <summary>
        /// Specifies the id of the Storage Domain (View Box).
        /// </summary>
        /// <value>Specifies the id of the Storage Domain (View Box).</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets LocalUsagePerfStats
        /// </summary>
        [DataMember(Name="localUsagePerfStats", EmitDefaultValue=false)]
        public UsageAndPerformanceStats LocalUsagePerfStats { get; set; }

        /// <summary>
        /// Gets or Sets LogicalStats
        /// </summary>
        [DataMember(Name="logicalStats", EmitDefaultValue=false)]
        public LogicalStats LogicalStats { get; set; }

        /// <summary>
        /// Gets or Sets UsagePerfStats
        /// </summary>
        [DataMember(Name="usagePerfStats", EmitDefaultValue=false)]
        public UsageAndPerformanceStats UsagePerfStats { get; set; }

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
            return this.Equals(input as ViewBoxStats);
        }

        /// <summary>
        /// Returns true if ViewBoxStats instances are equal
        /// </summary>
        /// <param name="input">Instance of ViewBoxStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewBoxStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CloudUsagePerfStats == input.CloudUsagePerfStats ||
                    (this.CloudUsagePerfStats != null &&
                    this.CloudUsagePerfStats.Equals(input.CloudUsagePerfStats))
                ) && 
                (
                    this.DataUsageStats == input.DataUsageStats ||
                    (this.DataUsageStats != null &&
                    this.DataUsageStats.Equals(input.DataUsageStats))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LocalUsagePerfStats == input.LocalUsagePerfStats ||
                    (this.LocalUsagePerfStats != null &&
                    this.LocalUsagePerfStats.Equals(input.LocalUsagePerfStats))
                ) && 
                (
                    this.LogicalStats == input.LogicalStats ||
                    (this.LogicalStats != null &&
                    this.LogicalStats.Equals(input.LogicalStats))
                ) && 
                (
                    this.UsagePerfStats == input.UsagePerfStats ||
                    (this.UsagePerfStats != null &&
                    this.UsagePerfStats.Equals(input.UsagePerfStats))
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
                if (this.CloudUsagePerfStats != null)
                    hashCode = hashCode * 59 + this.CloudUsagePerfStats.GetHashCode();
                if (this.DataUsageStats != null)
                    hashCode = hashCode * 59 + this.DataUsageStats.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LocalUsagePerfStats != null)
                    hashCode = hashCode * 59 + this.LocalUsagePerfStats.GetHashCode();
                if (this.LogicalStats != null)
                    hashCode = hashCode * 59 + this.LogicalStats.GetHashCode();
                if (this.UsagePerfStats != null)
                    hashCode = hashCode * 59 + this.UsagePerfStats.GetHashCode();
                return hashCode;
            }
        }

    }

}


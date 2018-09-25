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
    /// Specifies statistics about this Cohesity Cluster.
    /// </summary>
    [DataContract]
    public partial class ClusterStats :  IEquatable<ClusterStats>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterStats" /> class.
        /// </summary>
        /// <param name="cloudUsagePerfStats">cloudUsagePerfStats.</param>
        /// <param name="dataReductionRatio">Specifies the ratio of logical bytes (not reduced by change-block tracking, compression and deduplication) to physical bytes (reduced by change-block tracking, compression and deduplication)..</param>
        /// <param name="id">Specifies the id of the Cohesity Cluster..</param>
        /// <param name="localUsagePerfStats">localUsagePerfStats.</param>
        /// <param name="logicalStats">logicalStats.</param>
        /// <param name="usagePerfStats">usagePerfStats.</param>
        public ClusterStats(CloudTierStatistics_ cloudUsagePerfStats = default(CloudTierStatistics_), double? dataReductionRatio = default(double?), long? id = default(long?), LocalStatistics_ localUsagePerfStats = default(LocalStatistics_), LogicalStatistics_ logicalStats = default(LogicalStatistics_), LocalAndCloudTierStatistics_ usagePerfStats = default(LocalAndCloudTierStatistics_))
        {
            this.CloudUsagePerfStats = cloudUsagePerfStats;
            this.DataReductionRatio = dataReductionRatio;
            this.Id = id;
            this.LocalUsagePerfStats = localUsagePerfStats;
            this.LogicalStats = logicalStats;
            this.UsagePerfStats = usagePerfStats;
        }
        
        /// <summary>
        /// Gets or Sets CloudUsagePerfStats
        /// </summary>
        [DataMember(Name="cloudUsagePerfStats", EmitDefaultValue=false)]
        public CloudTierStatistics_ CloudUsagePerfStats { get; set; }

        /// <summary>
        /// Specifies the ratio of logical bytes (not reduced by change-block tracking, compression and deduplication) to physical bytes (reduced by change-block tracking, compression and deduplication).
        /// </summary>
        /// <value>Specifies the ratio of logical bytes (not reduced by change-block tracking, compression and deduplication) to physical bytes (reduced by change-block tracking, compression and deduplication).</value>
        [DataMember(Name="dataReductionRatio", EmitDefaultValue=false)]
        public double? DataReductionRatio { get; set; }

        /// <summary>
        /// Specifies the id of the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the id of the Cohesity Cluster.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets LocalUsagePerfStats
        /// </summary>
        [DataMember(Name="localUsagePerfStats", EmitDefaultValue=false)]
        public LocalStatistics_ LocalUsagePerfStats { get; set; }

        /// <summary>
        /// Gets or Sets LogicalStats
        /// </summary>
        [DataMember(Name="logicalStats", EmitDefaultValue=false)]
        public LogicalStatistics_ LogicalStats { get; set; }

        /// <summary>
        /// Gets or Sets UsagePerfStats
        /// </summary>
        [DataMember(Name="usagePerfStats", EmitDefaultValue=false)]
        public LocalAndCloudTierStatistics_ UsagePerfStats { get; set; }

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
            return this.Equals(input as ClusterStats);
        }

        /// <summary>
        /// Returns true if ClusterStats instances are equal
        /// </summary>
        /// <param name="input">Instance of ClusterStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClusterStats input)
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
                    this.DataReductionRatio == input.DataReductionRatio ||
                    (this.DataReductionRatio != null &&
                    this.DataReductionRatio.Equals(input.DataReductionRatio))
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
                if (this.DataReductionRatio != null)
                    hashCode = hashCode * 59 + this.DataReductionRatio.GetHashCode();
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


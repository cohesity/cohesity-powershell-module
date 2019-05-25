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
    /// Specifies statistics about this Cohesity Cluster.
    /// </summary>
    [DataContract]
    public partial class ClusterStats :  IEquatable<ClusterStats>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterStats" /> class.
        /// </summary>
        /// <param name="cloudUsagePerfStats">Provides usage and performance statistics for the remote data stored on a Cloud Tier by the Cohesity Cluster..</param>
        /// <param name="dataReductionRatio">Specifies the ratio of logical bytes (not reduced by change-block tracking, compression and deduplication) to physical bytes (reduced by change-block tracking, compression and deduplication)..</param>
        /// <param name="dataUsageStats">dataUsageStats.</param>
        /// <param name="id">Specifies the id of the Cohesity Cluster..</param>
        /// <param name="localUsagePerfStats">Provides usage and performance statistics for local data stored directly on the Cohesity Cluster..</param>
        /// <param name="logicalStats">Specifies the total logical data size of all the local and Cloud Tier data stored by the Cohesity Cluster before the data is reduced by change-block tracking, compression and deduplication. The size of the data if the data is fully hydrated or expanded..</param>
        /// <param name="usagePerfStats">Provides usage and performance statistics about the local data stored directly on the Cohesity Cluster and the remote data stored on a Cloud Tier for the Cohesity Cluster..</param>
        public ClusterStats(UsageAndPerformanceStats cloudUsagePerfStats = default(UsageAndPerformanceStats), double? dataReductionRatio = default(double?), DataUsageStats dataUsageStats = default(DataUsageStats), long? id = default(long?), UsageAndPerformanceStats localUsagePerfStats = default(UsageAndPerformanceStats), LogicalStats logicalStats = default(LogicalStats), UsageAndPerformanceStats usagePerfStats = default(UsageAndPerformanceStats))
        {
            this.CloudUsagePerfStats = cloudUsagePerfStats;
            this.DataReductionRatio = dataReductionRatio;
            this.Id = id;
            this.LocalUsagePerfStats = localUsagePerfStats;
            this.LogicalStats = logicalStats;
            this.UsagePerfStats = usagePerfStats;
            this.CloudUsagePerfStats = cloudUsagePerfStats;
            this.DataReductionRatio = dataReductionRatio;
            this.DataUsageStats = dataUsageStats;
            this.Id = id;
            this.LocalUsagePerfStats = localUsagePerfStats;
            this.LogicalStats = logicalStats;
            this.UsagePerfStats = usagePerfStats;
        }
        
        /// <summary>
        /// Provides usage and performance statistics for the remote data stored on a Cloud Tier by the Cohesity Cluster.
        /// </summary>
        /// <value>Provides usage and performance statistics for the remote data stored on a Cloud Tier by the Cohesity Cluster.</value>
        [DataMember(Name="cloudUsagePerfStats", EmitDefaultValue=true)]
        public UsageAndPerformanceStats CloudUsagePerfStats { get; set; }

        /// <summary>
        /// Specifies the ratio of logical bytes (not reduced by change-block tracking, compression and deduplication) to physical bytes (reduced by change-block tracking, compression and deduplication).
        /// </summary>
        /// <value>Specifies the ratio of logical bytes (not reduced by change-block tracking, compression and deduplication) to physical bytes (reduced by change-block tracking, compression and deduplication).</value>
        [DataMember(Name="dataReductionRatio", EmitDefaultValue=true)]
        public double? DataReductionRatio { get; set; }

        /// <summary>
        /// Gets or Sets DataUsageStats
        /// </summary>
        [DataMember(Name="dataUsageStats", EmitDefaultValue=false)]
        public DataUsageStats DataUsageStats { get; set; }

        /// <summary>
        /// Specifies the id of the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the id of the Cohesity Cluster.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Provides usage and performance statistics for local data stored directly on the Cohesity Cluster.
        /// </summary>
        /// <value>Provides usage and performance statistics for local data stored directly on the Cohesity Cluster.</value>
        [DataMember(Name="localUsagePerfStats", EmitDefaultValue=true)]
        public UsageAndPerformanceStats LocalUsagePerfStats { get; set; }

        /// <summary>
        /// Specifies the total logical data size of all the local and Cloud Tier data stored by the Cohesity Cluster before the data is reduced by change-block tracking, compression and deduplication. The size of the data if the data is fully hydrated or expanded.
        /// </summary>
        /// <value>Specifies the total logical data size of all the local and Cloud Tier data stored by the Cohesity Cluster before the data is reduced by change-block tracking, compression and deduplication. The size of the data if the data is fully hydrated or expanded.</value>
        [DataMember(Name="logicalStats", EmitDefaultValue=true)]
        public LogicalStats LogicalStats { get; set; }

        /// <summary>
        /// Provides usage and performance statistics about the local data stored directly on the Cohesity Cluster and the remote data stored on a Cloud Tier for the Cohesity Cluster.
        /// </summary>
        /// <value>Provides usage and performance statistics about the local data stored directly on the Cohesity Cluster and the remote data stored on a Cloud Tier for the Cohesity Cluster.</value>
        [DataMember(Name="usagePerfStats", EmitDefaultValue=true)]
        public UsageAndPerformanceStats UsagePerfStats { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusterStats {\n");
            sb.Append("  CloudUsagePerfStats: ").Append(CloudUsagePerfStats).Append("\n");
            sb.Append("  DataReductionRatio: ").Append(DataReductionRatio).Append("\n");
            sb.Append("  DataUsageStats: ").Append(DataUsageStats).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LocalUsagePerfStats: ").Append(LocalUsagePerfStats).Append("\n");
            sb.Append("  LogicalStats: ").Append(LogicalStats).Append("\n");
            sb.Append("  UsagePerfStats: ").Append(UsagePerfStats).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
                if (this.DataReductionRatio != null)
                    hashCode = hashCode * 59 + this.DataReductionRatio.GetHashCode();
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

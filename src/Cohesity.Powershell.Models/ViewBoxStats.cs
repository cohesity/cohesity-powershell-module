// Copyright 2018 Cohesity Inc.

using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Cohesity.Models
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
        /// <param name="cloudUsagePerfStats">Provides the usage statistics for the data stored in the cloud for the Storage Domain (View Box). Performance statistics are not populated..</param>
        /// <param name="id">Specifies the id of the Storage Domain (View Box)..</param>
        /// <param name="localUsagePerfStats">Provides usage statistics for the locally stored data on the Storage Domain (View Box). Performance statistics are not populated..</param>
        /// <param name="logicalStats">Provides the logical usage statistics for the Storage Domain (View Box)..</param>
        /// <param name="usagePerfStats">Provides usage and performance statistics for the Storage Domain (View Box) (includes both local and cloud data)..</param>
        public ViewBoxStats(UsageAndPerformanceStats cloudUsagePerfStats = default(UsageAndPerformanceStats), long? id = default(long?), UsageAndPerformanceStats localUsagePerfStats = default(UsageAndPerformanceStats), LogicalStats logicalStats = default(LogicalStats), UsageAndPerformanceStats usagePerfStats = default(UsageAndPerformanceStats))
        {
            this.CloudUsagePerfStats = cloudUsagePerfStats;
            this.Id = id;
            this.LocalUsagePerfStats = localUsagePerfStats;
            this.LogicalStats = logicalStats;
            this.UsagePerfStats = usagePerfStats;
        }
        
        /// <summary>
        /// Provides the usage statistics for the data stored in the cloud for the Storage Domain (View Box). Performance statistics are not populated.
        /// </summary>
        /// <value>Provides the usage statistics for the data stored in the cloud for the Storage Domain (View Box). Performance statistics are not populated.</value>
        [DataMember(Name="cloudUsagePerfStats", EmitDefaultValue=false)]
        public UsageAndPerformanceStats CloudUsagePerfStats { get; set; }

        /// <summary>
        /// Specifies the id of the Storage Domain (View Box).
        /// </summary>
        /// <value>Specifies the id of the Storage Domain (View Box).</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Provides usage statistics for the locally stored data on the Storage Domain (View Box). Performance statistics are not populated.
        /// </summary>
        /// <value>Provides usage statistics for the locally stored data on the Storage Domain (View Box). Performance statistics are not populated.</value>
        [DataMember(Name="localUsagePerfStats", EmitDefaultValue=false)]
        public UsageAndPerformanceStats LocalUsagePerfStats { get; set; }

        /// <summary>
        /// Provides the logical usage statistics for the Storage Domain (View Box).
        /// </summary>
        /// <value>Provides the logical usage statistics for the Storage Domain (View Box).</value>
        [DataMember(Name="logicalStats", EmitDefaultValue=false)]
        public LogicalStats LogicalStats { get; set; }

        /// <summary>
        /// Provides usage and performance statistics for the Storage Domain (View Box) (includes both local and cloud data).
        /// </summary>
        /// <value>Provides usage and performance statistics for the Storage Domain (View Box) (includes both local and cloud data).</value>
        [DataMember(Name="usagePerfStats", EmitDefaultValue=false)]
        public UsageAndPerformanceStats UsagePerfStats { get; set; }

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


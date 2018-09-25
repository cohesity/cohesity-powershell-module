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
    /// Stats for one copy task or aggregated stats of a Copy Run in a Protection Job Run.
    /// </summary>
    [DataContract]
    public partial class CopyRunStats :  IEquatable<CopyRunStats>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CopyRunStats" /> class.
        /// </summary>
        /// <param name="endTimeUsecs">Specifies the time when this replication ended. If not set, then the replication has not ended yet..</param>
        /// <param name="isIncremental">Specifies whether this archival is incremental for archival targets..</param>
        /// <param name="logicalBytesTransferred">Specifies the number of logical bytes transferred for this replication so far. This value can never exceed the total logical size of the replicated view..</param>
        /// <param name="logicalSizeBytes">Specifies the total amount of logical data to be transferred for this replication..</param>
        /// <param name="logicalTransferRateBps">Specifies average logical bytes transfer rate in bytes per second for archchival targets..</param>
        /// <param name="physicalBytesTransferred">Specifies the number of physical bytes sent over the wire for replication targets..</param>
        /// <param name="startTimeUsecs">Specifies the time when this replication was started. If not set, then replication has not been started yet..</param>
        public CopyRunStats(long? endTimeUsecs = default(long?), bool? isIncremental = default(bool?), long? logicalBytesTransferred = default(long?), long? logicalSizeBytes = default(long?), long? logicalTransferRateBps = default(long?), long? physicalBytesTransferred = default(long?), long? startTimeUsecs = default(long?))
        {
            this.EndTimeUsecs = endTimeUsecs;
            this.IsIncremental = isIncremental;
            this.LogicalBytesTransferred = logicalBytesTransferred;
            this.LogicalSizeBytes = logicalSizeBytes;
            this.LogicalTransferRateBps = logicalTransferRateBps;
            this.PhysicalBytesTransferred = physicalBytesTransferred;
            this.StartTimeUsecs = startTimeUsecs;
        }
        
        /// <summary>
        /// Specifies the time when this replication ended. If not set, then the replication has not ended yet.
        /// </summary>
        /// <value>Specifies the time when this replication ended. If not set, then the replication has not ended yet.</value>
        [DataMember(Name="endTimeUsecs", EmitDefaultValue=false)]
        public long? EndTimeUsecs { get; set; }

        /// <summary>
        /// Specifies whether this archival is incremental for archival targets.
        /// </summary>
        /// <value>Specifies whether this archival is incremental for archival targets.</value>
        [DataMember(Name="isIncremental", EmitDefaultValue=false)]
        public bool? IsIncremental { get; set; }

        /// <summary>
        /// Specifies the number of logical bytes transferred for this replication so far. This value can never exceed the total logical size of the replicated view.
        /// </summary>
        /// <value>Specifies the number of logical bytes transferred for this replication so far. This value can never exceed the total logical size of the replicated view.</value>
        [DataMember(Name="logicalBytesTransferred", EmitDefaultValue=false)]
        public long? LogicalBytesTransferred { get; set; }

        /// <summary>
        /// Specifies the total amount of logical data to be transferred for this replication.
        /// </summary>
        /// <value>Specifies the total amount of logical data to be transferred for this replication.</value>
        [DataMember(Name="logicalSizeBytes", EmitDefaultValue=false)]
        public long? LogicalSizeBytes { get; set; }

        /// <summary>
        /// Specifies average logical bytes transfer rate in bytes per second for archchival targets.
        /// </summary>
        /// <value>Specifies average logical bytes transfer rate in bytes per second for archchival targets.</value>
        [DataMember(Name="logicalTransferRateBps", EmitDefaultValue=false)]
        public long? LogicalTransferRateBps { get; set; }

        /// <summary>
        /// Specifies the number of physical bytes sent over the wire for replication targets.
        /// </summary>
        /// <value>Specifies the number of physical bytes sent over the wire for replication targets.</value>
        [DataMember(Name="physicalBytesTransferred", EmitDefaultValue=false)]
        public long? PhysicalBytesTransferred { get; set; }

        /// <summary>
        /// Specifies the time when this replication was started. If not set, then replication has not been started yet.
        /// </summary>
        /// <value>Specifies the time when this replication was started. If not set, then replication has not been started yet.</value>
        [DataMember(Name="startTimeUsecs", EmitDefaultValue=false)]
        public long? StartTimeUsecs { get; set; }

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
            return this.Equals(input as CopyRunStats);
        }

        /// <summary>
        /// Returns true if CopyRunStats instances are equal
        /// </summary>
        /// <param name="input">Instance of CopyRunStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CopyRunStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EndTimeUsecs == input.EndTimeUsecs ||
                    (this.EndTimeUsecs != null &&
                    this.EndTimeUsecs.Equals(input.EndTimeUsecs))
                ) && 
                (
                    this.IsIncremental == input.IsIncremental ||
                    (this.IsIncremental != null &&
                    this.IsIncremental.Equals(input.IsIncremental))
                ) && 
                (
                    this.LogicalBytesTransferred == input.LogicalBytesTransferred ||
                    (this.LogicalBytesTransferred != null &&
                    this.LogicalBytesTransferred.Equals(input.LogicalBytesTransferred))
                ) && 
                (
                    this.LogicalSizeBytes == input.LogicalSizeBytes ||
                    (this.LogicalSizeBytes != null &&
                    this.LogicalSizeBytes.Equals(input.LogicalSizeBytes))
                ) && 
                (
                    this.LogicalTransferRateBps == input.LogicalTransferRateBps ||
                    (this.LogicalTransferRateBps != null &&
                    this.LogicalTransferRateBps.Equals(input.LogicalTransferRateBps))
                ) && 
                (
                    this.PhysicalBytesTransferred == input.PhysicalBytesTransferred ||
                    (this.PhysicalBytesTransferred != null &&
                    this.PhysicalBytesTransferred.Equals(input.PhysicalBytesTransferred))
                ) && 
                (
                    this.StartTimeUsecs == input.StartTimeUsecs ||
                    (this.StartTimeUsecs != null &&
                    this.StartTimeUsecs.Equals(input.StartTimeUsecs))
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
                if (this.EndTimeUsecs != null)
                    hashCode = hashCode * 59 + this.EndTimeUsecs.GetHashCode();
                if (this.IsIncremental != null)
                    hashCode = hashCode * 59 + this.IsIncremental.GetHashCode();
                if (this.LogicalBytesTransferred != null)
                    hashCode = hashCode * 59 + this.LogicalBytesTransferred.GetHashCode();
                if (this.LogicalSizeBytes != null)
                    hashCode = hashCode * 59 + this.LogicalSizeBytes.GetHashCode();
                if (this.LogicalTransferRateBps != null)
                    hashCode = hashCode * 59 + this.LogicalTransferRateBps.GetHashCode();
                if (this.PhysicalBytesTransferred != null)
                    hashCode = hashCode * 59 + this.PhysicalBytesTransferred.GetHashCode();
                if (this.StartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.StartTimeUsecs.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


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
    /// Specifies a Job Run and the expiration time to update. The expiration time defines the retention period for the Job Run and its snapshots.
    /// </summary>
    [DataContract]
    public partial class UpdateProtectionJobRun :  IEquatable<UpdateProtectionJobRun>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProtectionJobRun" /> class.
        /// </summary>
        /// <param name="copyRunTargets">Specifies the retention for archival, replication or extended local retention..</param>
        /// <param name="expiryTimeUsecs">Specifies a new expiration time as a Unix epoch Timestamp (in microseconds). This expiration time defines the retention period for the snapshot. After an expiration time for a Job Run is reached, the Job Run and the snapshot captured by this Job Run are deleted. If 0 is specified, the Job Run and the snapshot are immediately deleted..</param>
        /// <param name="jobUid">jobUid.</param>
        /// <param name="runStartTimeUsecs">Specifies the start time of the Job Run to update. The start time is specified as a Unix epoch Timestamp (in microseconds). This uniquely identifies a snapshot. This parameter is required..</param>
        /// <param name="sourceIds">Ids of the Protection Sources. If this is specified, retention time will only be updated for the sources specified..</param>
        public UpdateProtectionJobRun(List<RunJobSnapshotTarget> copyRunTargets = default(List<RunJobSnapshotTarget>), long? expiryTimeUsecs = default(long?), UniqueGlobalId10 jobUid = default(UniqueGlobalId10), long? runStartTimeUsecs = default(long?), List<long?> sourceIds = default(List<long?>))
        {
            this.CopyRunTargets = copyRunTargets;
            this.ExpiryTimeUsecs = expiryTimeUsecs;
            this.JobUid = jobUid;
            this.RunStartTimeUsecs = runStartTimeUsecs;
            this.SourceIds = sourceIds;
        }
        
        /// <summary>
        /// Specifies the retention for archival, replication or extended local retention.
        /// </summary>
        /// <value>Specifies the retention for archival, replication or extended local retention.</value>
        [DataMember(Name="copyRunTargets", EmitDefaultValue=false)]
        public List<RunJobSnapshotTarget> CopyRunTargets { get; set; }

        /// <summary>
        /// Specifies a new expiration time as a Unix epoch Timestamp (in microseconds). This expiration time defines the retention period for the snapshot. After an expiration time for a Job Run is reached, the Job Run and the snapshot captured by this Job Run are deleted. If 0 is specified, the Job Run and the snapshot are immediately deleted.
        /// </summary>
        /// <value>Specifies a new expiration time as a Unix epoch Timestamp (in microseconds). This expiration time defines the retention period for the snapshot. After an expiration time for a Job Run is reached, the Job Run and the snapshot captured by this Job Run are deleted. If 0 is specified, the Job Run and the snapshot are immediately deleted.</value>
        [DataMember(Name="expiryTimeUsecs", EmitDefaultValue=false)]
        public long? ExpiryTimeUsecs { get; set; }

        /// <summary>
        /// Gets or Sets JobUid
        /// </summary>
        [DataMember(Name="jobUid", EmitDefaultValue=false)]
        public UniqueGlobalId10 JobUid { get; set; }

        /// <summary>
        /// Specifies the start time of the Job Run to update. The start time is specified as a Unix epoch Timestamp (in microseconds). This uniquely identifies a snapshot. This parameter is required.
        /// </summary>
        /// <value>Specifies the start time of the Job Run to update. The start time is specified as a Unix epoch Timestamp (in microseconds). This uniquely identifies a snapshot. This parameter is required.</value>
        [DataMember(Name="runStartTimeUsecs", EmitDefaultValue=false)]
        public long? RunStartTimeUsecs { get; set; }

        /// <summary>
        /// Ids of the Protection Sources. If this is specified, retention time will only be updated for the sources specified.
        /// </summary>
        /// <value>Ids of the Protection Sources. If this is specified, retention time will only be updated for the sources specified.</value>
        [DataMember(Name="sourceIds", EmitDefaultValue=false)]
        public List<long?> SourceIds { get; set; }

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
            return this.Equals(input as UpdateProtectionJobRun);
        }

        /// <summary>
        /// Returns true if UpdateProtectionJobRun instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateProtectionJobRun to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateProtectionJobRun input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CopyRunTargets == input.CopyRunTargets ||
                    this.CopyRunTargets != null &&
                    this.CopyRunTargets.SequenceEqual(input.CopyRunTargets)
                ) && 
                (
                    this.ExpiryTimeUsecs == input.ExpiryTimeUsecs ||
                    (this.ExpiryTimeUsecs != null &&
                    this.ExpiryTimeUsecs.Equals(input.ExpiryTimeUsecs))
                ) && 
                (
                    this.JobUid == input.JobUid ||
                    (this.JobUid != null &&
                    this.JobUid.Equals(input.JobUid))
                ) && 
                (
                    this.RunStartTimeUsecs == input.RunStartTimeUsecs ||
                    (this.RunStartTimeUsecs != null &&
                    this.RunStartTimeUsecs.Equals(input.RunStartTimeUsecs))
                ) && 
                (
                    this.SourceIds == input.SourceIds ||
                    this.SourceIds != null &&
                    this.SourceIds.SequenceEqual(input.SourceIds)
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
                if (this.CopyRunTargets != null)
                    hashCode = hashCode * 59 + this.CopyRunTargets.GetHashCode();
                if (this.ExpiryTimeUsecs != null)
                    hashCode = hashCode * 59 + this.ExpiryTimeUsecs.GetHashCode();
                if (this.JobUid != null)
                    hashCode = hashCode * 59 + this.JobUid.GetHashCode();
                if (this.RunStartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.RunStartTimeUsecs.GetHashCode();
                if (this.SourceIds != null)
                    hashCode = hashCode * 59 + this.SourceIds.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


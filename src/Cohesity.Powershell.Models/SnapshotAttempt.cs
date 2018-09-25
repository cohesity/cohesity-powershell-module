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
    /// Specifies information about a single snapshot.
    /// </summary>
    [DataContract]
    public partial class SnapshotAttempt :  IEquatable<SnapshotAttempt>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SnapshotAttempt" /> class.
        /// </summary>
        /// <param name="attemptNumber">Specifies the number of the attempts made by the Job Run to capture a snapshot of the object. For example, if an snapshot is successfully captured after three attempts, this field equals 3..</param>
        /// <param name="jobRunId">Specifies the id of the Job Run that captured the snapshot..</param>
        /// <param name="startedTimeUsecs">Specifies the time when the Job Run starts capturing a snapshot. Specified as a Unix epoch Timestamp (in microseconds)..</param>
        public SnapshotAttempt(long? attemptNumber = default(long?), long? jobRunId = default(long?), long? startedTimeUsecs = default(long?))
        {
            this.AttemptNumber = attemptNumber;
            this.JobRunId = jobRunId;
            this.StartedTimeUsecs = startedTimeUsecs;
        }
        
        /// <summary>
        /// Specifies the number of the attempts made by the Job Run to capture a snapshot of the object. For example, if an snapshot is successfully captured after three attempts, this field equals 3.
        /// </summary>
        /// <value>Specifies the number of the attempts made by the Job Run to capture a snapshot of the object. For example, if an snapshot is successfully captured after three attempts, this field equals 3.</value>
        [DataMember(Name="attemptNumber", EmitDefaultValue=false)]
        public long? AttemptNumber { get; set; }

        /// <summary>
        /// Specifies the id of the Job Run that captured the snapshot.
        /// </summary>
        /// <value>Specifies the id of the Job Run that captured the snapshot.</value>
        [DataMember(Name="jobRunId", EmitDefaultValue=false)]
        public long? JobRunId { get; set; }

        /// <summary>
        /// Specifies the time when the Job Run starts capturing a snapshot. Specified as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the time when the Job Run starts capturing a snapshot. Specified as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="startedTimeUsecs", EmitDefaultValue=false)]
        public long? StartedTimeUsecs { get; set; }

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
            return this.Equals(input as SnapshotAttempt);
        }

        /// <summary>
        /// Returns true if SnapshotAttempt instances are equal
        /// </summary>
        /// <param name="input">Instance of SnapshotAttempt to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SnapshotAttempt input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AttemptNumber == input.AttemptNumber ||
                    (this.AttemptNumber != null &&
                    this.AttemptNumber.Equals(input.AttemptNumber))
                ) && 
                (
                    this.JobRunId == input.JobRunId ||
                    (this.JobRunId != null &&
                    this.JobRunId.Equals(input.JobRunId))
                ) && 
                (
                    this.StartedTimeUsecs == input.StartedTimeUsecs ||
                    (this.StartedTimeUsecs != null &&
                    this.StartedTimeUsecs.Equals(input.StartedTimeUsecs))
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
                if (this.AttemptNumber != null)
                    hashCode = hashCode * 59 + this.AttemptNumber.GetHashCode();
                if (this.JobRunId != null)
                    hashCode = hashCode * 59 + this.JobRunId.GetHashCode();
                if (this.StartedTimeUsecs != null)
                    hashCode = hashCode * 59 + this.StartedTimeUsecs.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


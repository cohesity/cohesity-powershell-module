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
    /// Specifies the status of the copy task that copies the snapshot of a Protection Source object to a target.
    /// </summary>
    [DataContract]
    public partial class CopySnapshotTaskStatus :  IEquatable<CopySnapshotTaskStatus>
    {
        /// <summary>
        /// Specifies the status of the source object being protected. &#39;kAccepted&#39; indicates the task is queued to run but not yet running. &#39;kRunning&#39; indicates the task is running. &#39;kCanceling&#39; indicates a request to cancel the task has occurred but the task is not yet canceled. &#39;kCanceled&#39; indicates the task has been canceled. &#39;kSuccess&#39; indicates the task was successful. &#39;kFailure&#39; indicates the task failed.
        /// </summary>
        /// <value>Specifies the status of the source object being protected. &#39;kAccepted&#39; indicates the task is queued to run but not yet running. &#39;kRunning&#39; indicates the task is running. &#39;kCanceling&#39; indicates a request to cancel the task has occurred but the task is not yet canceled. &#39;kCanceled&#39; indicates the task has been canceled. &#39;kSuccess&#39; indicates the task was successful. &#39;kFailure&#39; indicates the task failed.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum KAccepted for value: kAccepted
            /// </summary>
            [EnumMember(Value = "kAccepted")]
            KAccepted = 1,
            
            /// <summary>
            /// Enum KRunning for value: kRunning
            /// </summary>
            [EnumMember(Value = "kRunning")]
            KRunning = 2,
            
            /// <summary>
            /// Enum KCanceling for value: kCanceling
            /// </summary>
            [EnumMember(Value = "kCanceling")]
            KCanceling = 3,
            
            /// <summary>
            /// Enum KCanceled for value: kCanceled
            /// </summary>
            [EnumMember(Value = "kCanceled")]
            KCanceled = 4,
            
            /// <summary>
            /// Enum KSuccess for value: kSuccess
            /// </summary>
            [EnumMember(Value = "kSuccess")]
            KSuccess = 5,
            
            /// <summary>
            /// Enum KFailure for value: kFailure
            /// </summary>
            [EnumMember(Value = "kFailure")]
            KFailure = 6
        }

        /// <summary>
        /// Specifies the status of the source object being protected. &#39;kAccepted&#39; indicates the task is queued to run but not yet running. &#39;kRunning&#39; indicates the task is running. &#39;kCanceling&#39; indicates a request to cancel the task has occurred but the task is not yet canceled. &#39;kCanceled&#39; indicates the task has been canceled. &#39;kSuccess&#39; indicates the task was successful. &#39;kFailure&#39; indicates the task failed.
        /// </summary>
        /// <value>Specifies the status of the source object being protected. &#39;kAccepted&#39; indicates the task is queued to run but not yet running. &#39;kRunning&#39; indicates the task is running. &#39;kCanceling&#39; indicates a request to cancel the task has occurred but the task is not yet canceled. &#39;kCanceled&#39; indicates the task has been canceled. &#39;kSuccess&#39; indicates the task was successful. &#39;kFailure&#39; indicates the task failed.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CopySnapshotTaskStatus" /> class.
        /// </summary>
        /// <param name="error">Specifies if an error occurred (if any) while running this task. This field is populated when the status is equal to &#39;kFailure&#39;..</param>
        /// <param name="source">Specifies the source object whose snapshot is replicated. This is specified for replication targets..</param>
        /// <param name="stats">Specifies the stats of the replication or the archival task..</param>
        /// <param name="status">Specifies the status of the source object being protected. &#39;kAccepted&#39; indicates the task is queued to run but not yet running. &#39;kRunning&#39; indicates the task is running. &#39;kCanceling&#39; indicates a request to cancel the task has occurred but the task is not yet canceled. &#39;kCanceled&#39; indicates the task has been canceled. &#39;kSuccess&#39; indicates the task was successful. &#39;kFailure&#39; indicates the task failed..</param>
        /// <param name="taskEndTimeUsecs">Specifies the end time of the copy task. The end time is specified as a Unix epoch Timestamp (in microseconds)..</param>
        /// <param name="taskStartTimeUsecs">Specifies the start time of the copy task. The start time is specified as a Unix epoch Timestamp (in microseconds). Copy run task is started after completing backup tasks. It may spawn sub-tasks to copy or replicate individual snapshots..</param>
        public CopySnapshotTaskStatus(string error = default(string), ProtectionSource source = default(ProtectionSource), CopyRunStats stats = default(CopyRunStats), StatusEnum? status = default(StatusEnum?), long? taskEndTimeUsecs = default(long?), long? taskStartTimeUsecs = default(long?))
        {
            this.Error = error;
            this.Source = source;
            this.Stats = stats;
            this.Status = status;
            this.TaskEndTimeUsecs = taskEndTimeUsecs;
            this.TaskStartTimeUsecs = taskStartTimeUsecs;
        }
        
        /// <summary>
        /// Specifies if an error occurred (if any) while running this task. This field is populated when the status is equal to &#39;kFailure&#39;.
        /// </summary>
        /// <value>Specifies if an error occurred (if any) while running this task. This field is populated when the status is equal to &#39;kFailure&#39;.</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }

        /// <summary>
        /// Specifies the source object whose snapshot is replicated. This is specified for replication targets.
        /// </summary>
        /// <value>Specifies the source object whose snapshot is replicated. This is specified for replication targets.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public ProtectionSource Source { get; set; }

        /// <summary>
        /// Specifies the stats of the replication or the archival task.
        /// </summary>
        /// <value>Specifies the stats of the replication or the archival task.</value>
        [DataMember(Name="stats", EmitDefaultValue=false)]
        public CopyRunStats Stats { get; set; }


        /// <summary>
        /// Specifies the end time of the copy task. The end time is specified as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the end time of the copy task. The end time is specified as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="taskEndTimeUsecs", EmitDefaultValue=false)]
        public long? TaskEndTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the start time of the copy task. The start time is specified as a Unix epoch Timestamp (in microseconds). Copy run task is started after completing backup tasks. It may spawn sub-tasks to copy or replicate individual snapshots.
        /// </summary>
        /// <value>Specifies the start time of the copy task. The start time is specified as a Unix epoch Timestamp (in microseconds). Copy run task is started after completing backup tasks. It may spawn sub-tasks to copy or replicate individual snapshots.</value>
        [DataMember(Name="taskStartTimeUsecs", EmitDefaultValue=false)]
        public long? TaskStartTimeUsecs { get; set; }

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
            return this.Equals(input as CopySnapshotTaskStatus);
        }

        /// <summary>
        /// Returns true if CopySnapshotTaskStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of CopySnapshotTaskStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CopySnapshotTaskStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Stats == input.Stats ||
                    (this.Stats != null &&
                    this.Stats.Equals(input.Stats))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.TaskEndTimeUsecs == input.TaskEndTimeUsecs ||
                    (this.TaskEndTimeUsecs != null &&
                    this.TaskEndTimeUsecs.Equals(input.TaskEndTimeUsecs))
                ) && 
                (
                    this.TaskStartTimeUsecs == input.TaskStartTimeUsecs ||
                    (this.TaskStartTimeUsecs != null &&
                    this.TaskStartTimeUsecs.Equals(input.TaskStartTimeUsecs))
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
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Stats != null)
                    hashCode = hashCode * 59 + this.Stats.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TaskEndTimeUsecs != null)
                    hashCode = hashCode * 59 + this.TaskEndTimeUsecs.GetHashCode();
                if (this.TaskStartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.TaskStartTimeUsecs.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


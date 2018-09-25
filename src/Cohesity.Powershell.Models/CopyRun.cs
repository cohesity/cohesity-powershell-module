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
    /// Specifies details about the Copy Run for a backup run of a Job Run. A Copy task copies snapshots resulted from a backup run to a snapshot target which could be &#39;kLocal&#39;, &#39;kArchival&#39;, or &#39;kRemote&#39;.
    /// </summary>
    [DataContract]
    public partial class CopyRun :  IEquatable<CopyRun>
    {
        /// <summary>
        /// Specifies the aggregated status of copy tasks such as &#39;kRunning&#39;, &#39;kSuccess&#39;, &#39;kFailure&#39; etc. &#39;kAccepted&#39; indicates the task is queued to run but not yet running. &#39;kRunning&#39; indicates the task is running. &#39;kCanceling&#39; indicates a request to cancel the task has occurred but the task is not yet canceled. &#39;kCanceled&#39; indicates the task has been canceled. &#39;kSuccess&#39; indicates the task was successful. &#39;kFailure&#39; indicates the task failed.
        /// </summary>
        /// <value>Specifies the aggregated status of copy tasks such as &#39;kRunning&#39;, &#39;kSuccess&#39;, &#39;kFailure&#39; etc. &#39;kAccepted&#39; indicates the task is queued to run but not yet running. &#39;kRunning&#39; indicates the task is running. &#39;kCanceling&#39; indicates a request to cancel the task has occurred but the task is not yet canceled. &#39;kCanceled&#39; indicates the task has been canceled. &#39;kSuccess&#39; indicates the task was successful. &#39;kFailure&#39; indicates the task failed.</value>
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
        /// Specifies the aggregated status of copy tasks such as &#39;kRunning&#39;, &#39;kSuccess&#39;, &#39;kFailure&#39; etc. &#39;kAccepted&#39; indicates the task is queued to run but not yet running. &#39;kRunning&#39; indicates the task is running. &#39;kCanceling&#39; indicates a request to cancel the task has occurred but the task is not yet canceled. &#39;kCanceled&#39; indicates the task has been canceled. &#39;kSuccess&#39; indicates the task was successful. &#39;kFailure&#39; indicates the task failed.
        /// </summary>
        /// <value>Specifies the aggregated status of copy tasks such as &#39;kRunning&#39;, &#39;kSuccess&#39;, &#39;kFailure&#39; etc. &#39;kAccepted&#39; indicates the task is queued to run but not yet running. &#39;kRunning&#39; indicates the task is running. &#39;kCanceling&#39; indicates a request to cancel the task has occurred but the task is not yet canceled. &#39;kCanceled&#39; indicates the task has been canceled. &#39;kSuccess&#39; indicates the task was successful. &#39;kFailure&#39; indicates the task failed.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CopyRun" /> class.
        /// </summary>
        /// <param name="copySnapshotTasks">Specifies the status information of each task that copies the snapshot taken for a Protection Source..</param>
        /// <param name="error">Specifies if an error occurred (if any) while running this task. This field is populated when the status is equal to &#39;kFailure&#39;..</param>
        /// <param name="expiryTimeUsecs">Specifies expiry time of the copies of the snapshots in this Protection Run..</param>
        /// <param name="runStartTimeUsecs">Specifies start time of the copy run..</param>
        /// <param name="stats">Specifies the aggregated information of all the copy tasks..</param>
        /// <param name="status">Specifies the aggregated status of copy tasks such as &#39;kRunning&#39;, &#39;kSuccess&#39;, &#39;kFailure&#39; etc. &#39;kAccepted&#39; indicates the task is queued to run but not yet running. &#39;kRunning&#39; indicates the task is running. &#39;kCanceling&#39; indicates a request to cancel the task has occurred but the task is not yet canceled. &#39;kCanceled&#39; indicates the task has been canceled. &#39;kSuccess&#39; indicates the task was successful. &#39;kFailure&#39; indicates the task failed..</param>
        /// <param name="target">Specifies the target of the copy task such as an external target or a Remote Cohesity Cluster..</param>
        /// <param name="taskUid">taskUid.</param>
        /// <param name="userActionMessage">Specifies a message to the user if any manual intervention is needed to make forward progress for the archival task. This message is mainly relevant for tape based archival tasks where a backup admin might be asked to load a new media when the tape library does not have any more media to use..</param>
        public CopyRun(List<CopySnapshotTaskStatus> copySnapshotTasks = default(List<CopySnapshotTaskStatus>), string error = default(string), long? expiryTimeUsecs = default(long?), long? runStartTimeUsecs = default(long?), CopyRunStats stats = default(CopyRunStats), StatusEnum? status = default(StatusEnum?), SnapshotTarget target = default(SnapshotTarget), UniqueGlobalId_ taskUid = default(UniqueGlobalId_), string userActionMessage = default(string))
        {
            this.CopySnapshotTasks = copySnapshotTasks;
            this.Error = error;
            this.ExpiryTimeUsecs = expiryTimeUsecs;
            this.RunStartTimeUsecs = runStartTimeUsecs;
            this.Stats = stats;
            this.Status = status;
            this.Target = target;
            this.TaskUid = taskUid;
            this.UserActionMessage = userActionMessage;
        }
        
        /// <summary>
        /// Specifies the status information of each task that copies the snapshot taken for a Protection Source.
        /// </summary>
        /// <value>Specifies the status information of each task that copies the snapshot taken for a Protection Source.</value>
        [DataMember(Name="copySnapshotTasks", EmitDefaultValue=false)]
        public List<CopySnapshotTaskStatus> CopySnapshotTasks { get; set; }

        /// <summary>
        /// Specifies if an error occurred (if any) while running this task. This field is populated when the status is equal to &#39;kFailure&#39;.
        /// </summary>
        /// <value>Specifies if an error occurred (if any) while running this task. This field is populated when the status is equal to &#39;kFailure&#39;.</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }

        /// <summary>
        /// Specifies expiry time of the copies of the snapshots in this Protection Run.
        /// </summary>
        /// <value>Specifies expiry time of the copies of the snapshots in this Protection Run.</value>
        [DataMember(Name="expiryTimeUsecs", EmitDefaultValue=false)]
        public long? ExpiryTimeUsecs { get; set; }

        /// <summary>
        /// Specifies start time of the copy run.
        /// </summary>
        /// <value>Specifies start time of the copy run.</value>
        [DataMember(Name="runStartTimeUsecs", EmitDefaultValue=false)]
        public long? RunStartTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the aggregated information of all the copy tasks.
        /// </summary>
        /// <value>Specifies the aggregated information of all the copy tasks.</value>
        [DataMember(Name="stats", EmitDefaultValue=false)]
        public CopyRunStats Stats { get; set; }


        /// <summary>
        /// Specifies the target of the copy task such as an external target or a Remote Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the target of the copy task such as an external target or a Remote Cohesity Cluster.</value>
        [DataMember(Name="target", EmitDefaultValue=false)]
        public SnapshotTarget Target { get; set; }

        /// <summary>
        /// Gets or Sets TaskUid
        /// </summary>
        [DataMember(Name="taskUid", EmitDefaultValue=false)]
        public UniqueGlobalId_ TaskUid { get; set; }

        /// <summary>
        /// Specifies a message to the user if any manual intervention is needed to make forward progress for the archival task. This message is mainly relevant for tape based archival tasks where a backup admin might be asked to load a new media when the tape library does not have any more media to use.
        /// </summary>
        /// <value>Specifies a message to the user if any manual intervention is needed to make forward progress for the archival task. This message is mainly relevant for tape based archival tasks where a backup admin might be asked to load a new media when the tape library does not have any more media to use.</value>
        [DataMember(Name="userActionMessage", EmitDefaultValue=false)]
        public string UserActionMessage { get; set; }

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
            return this.Equals(input as CopyRun);
        }

        /// <summary>
        /// Returns true if CopyRun instances are equal
        /// </summary>
        /// <param name="input">Instance of CopyRun to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CopyRun input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CopySnapshotTasks == input.CopySnapshotTasks ||
                    this.CopySnapshotTasks != null &&
                    this.CopySnapshotTasks.SequenceEqual(input.CopySnapshotTasks)
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.ExpiryTimeUsecs == input.ExpiryTimeUsecs ||
                    (this.ExpiryTimeUsecs != null &&
                    this.ExpiryTimeUsecs.Equals(input.ExpiryTimeUsecs))
                ) && 
                (
                    this.RunStartTimeUsecs == input.RunStartTimeUsecs ||
                    (this.RunStartTimeUsecs != null &&
                    this.RunStartTimeUsecs.Equals(input.RunStartTimeUsecs))
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
                    this.Target == input.Target ||
                    (this.Target != null &&
                    this.Target.Equals(input.Target))
                ) && 
                (
                    this.TaskUid == input.TaskUid ||
                    (this.TaskUid != null &&
                    this.TaskUid.Equals(input.TaskUid))
                ) && 
                (
                    this.UserActionMessage == input.UserActionMessage ||
                    (this.UserActionMessage != null &&
                    this.UserActionMessage.Equals(input.UserActionMessage))
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
                if (this.CopySnapshotTasks != null)
                    hashCode = hashCode * 59 + this.CopySnapshotTasks.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.ExpiryTimeUsecs != null)
                    hashCode = hashCode * 59 + this.ExpiryTimeUsecs.GetHashCode();
                if (this.RunStartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.RunStartTimeUsecs.GetHashCode();
                if (this.Stats != null)
                    hashCode = hashCode * 59 + this.Stats.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Target != null)
                    hashCode = hashCode * 59 + this.Target.GetHashCode();
                if (this.TaskUid != null)
                    hashCode = hashCode * 59 + this.TaskUid.GetHashCode();
                if (this.UserActionMessage != null)
                    hashCode = hashCode * 59 + this.UserActionMessage.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


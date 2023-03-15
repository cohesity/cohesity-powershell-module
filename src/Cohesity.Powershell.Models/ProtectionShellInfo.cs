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
    /// ProtectionShellInfo
    /// </summary>
    [DataContract]
    public partial class ProtectionShellInfo :  IEquatable<ProtectionShellInfo>
    {
        /// <summary>
        /// Specifies the type of backup such as &#39;kRegular&#39;, &#39;kFull&#39;, &#39;kLog&#39; or &#39;kSystem&#39;. &#39;kRegular&#39; indicates a incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time. &#39;kSystem&#39; indicates a system backup. System backups are used to do bare metal recovery of the system to a specific point in time.
        /// </summary>
        /// <value>Specifies the type of backup such as &#39;kRegular&#39;, &#39;kFull&#39;, &#39;kLog&#39; or &#39;kSystem&#39;. &#39;kRegular&#39; indicates a incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time. &#39;kSystem&#39; indicates a system backup. System backups are used to do bare metal recovery of the system to a specific point in time.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RunTypeEnum
        {
            /// <summary>
            /// Enum KRegular for value: kRegular
            /// </summary>
            [EnumMember(Value = "kRegular")]
            KRegular = 1,

            /// <summary>
            /// Enum KFull for value: kFull
            /// </summary>
            [EnumMember(Value = "kFull")]
            KFull = 2,

            /// <summary>
            /// Enum KLog for value: kLog
            /// </summary>
            [EnumMember(Value = "kLog")]
            KLog = 3,

            /// <summary>
            /// Enum KSystem for value: kSystem
            /// </summary>
            [EnumMember(Value = "kSystem")]
            KSystem = 4

        }

        /// <summary>
        /// Specifies the type of backup such as &#39;kRegular&#39;, &#39;kFull&#39;, &#39;kLog&#39; or &#39;kSystem&#39;. &#39;kRegular&#39; indicates a incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time. &#39;kSystem&#39; indicates a system backup. System backups are used to do bare metal recovery of the system to a specific point in time.
        /// </summary>
        /// <value>Specifies the type of backup such as &#39;kRegular&#39;, &#39;kFull&#39;, &#39;kLog&#39; or &#39;kSystem&#39;. &#39;kRegular&#39; indicates a incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time. &#39;kSystem&#39; indicates a system backup. System backups are used to do bare metal recovery of the system to a specific point in time.</value>
        [DataMember(Name="runType", EmitDefaultValue=true)]
        public RunTypeEnum? RunType { get; set; }
        /// <summary>
        /// Specifies the status of Backup task such as &#39;kRunning&#39;, &#39;kSuccess&#39;, &#39;kFailure&#39; etc. &#39;kAccepted&#39; indicates the task is queued to run but not yet running. &#39;kRunning&#39; indicates the task is running. &#39;kCanceling&#39; indicates a request to cancel the task has occurred but the task is not yet canceled. &#39;kCanceled&#39; indicates the task has been canceled. &#39;kSuccess&#39; indicates the task was successful. &#39;kFailure&#39; indicates the task failed. &#39;kWarning&#39; indicates the task has finished with warning. &#39;kOnHold&#39; indicates the task is kept onHold. &#39;kMissed&#39; indicates the task is missed. &#39;Finalizing&#39; indicates the task is finalizing.
        /// </summary>
        /// <value>Specifies the status of Backup task such as &#39;kRunning&#39;, &#39;kSuccess&#39;, &#39;kFailure&#39; etc. &#39;kAccepted&#39; indicates the task is queued to run but not yet running. &#39;kRunning&#39; indicates the task is running. &#39;kCanceling&#39; indicates a request to cancel the task has occurred but the task is not yet canceled. &#39;kCanceled&#39; indicates the task has been canceled. &#39;kSuccess&#39; indicates the task was successful. &#39;kFailure&#39; indicates the task failed. &#39;kWarning&#39; indicates the task has finished with warning. &#39;kOnHold&#39; indicates the task is kept onHold. &#39;kMissed&#39; indicates the task is missed. &#39;Finalizing&#39; indicates the task is finalizing.</value>
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
            KFailure = 6,

            /// <summary>
            /// Enum KWarning for value: kWarning
            /// </summary>
            [EnumMember(Value = "kWarning")]
            KWarning = 7,

            /// <summary>
            /// Enum KOnHold for value: kOnHold
            /// </summary>
            [EnumMember(Value = "kOnHold")]
            KOnHold = 8,

            /// <summary>
            /// Enum KMissed for value: kMissed
            /// </summary>
            [EnumMember(Value = "kMissed")]
            KMissed = 9,

            /// <summary>
            /// Enum KFinalizing for value: kFinalizing
            /// </summary>
            [EnumMember(Value = "kFinalizing")]
            KFinalizing = 10

        }

        /// <summary>
        /// Specifies the status of Backup task such as &#39;kRunning&#39;, &#39;kSuccess&#39;, &#39;kFailure&#39; etc. &#39;kAccepted&#39; indicates the task is queued to run but not yet running. &#39;kRunning&#39; indicates the task is running. &#39;kCanceling&#39; indicates a request to cancel the task has occurred but the task is not yet canceled. &#39;kCanceled&#39; indicates the task has been canceled. &#39;kSuccess&#39; indicates the task was successful. &#39;kFailure&#39; indicates the task failed. &#39;kWarning&#39; indicates the task has finished with warning. &#39;kOnHold&#39; indicates the task is kept onHold. &#39;kMissed&#39; indicates the task is missed. &#39;Finalizing&#39; indicates the task is finalizing.
        /// </summary>
        /// <value>Specifies the status of Backup task such as &#39;kRunning&#39;, &#39;kSuccess&#39;, &#39;kFailure&#39; etc. &#39;kAccepted&#39; indicates the task is queued to run but not yet running. &#39;kRunning&#39; indicates the task is running. &#39;kCanceling&#39; indicates a request to cancel the task has occurred but the task is not yet canceled. &#39;kCanceled&#39; indicates the task has been canceled. &#39;kSuccess&#39; indicates the task was successful. &#39;kFailure&#39; indicates the task failed. &#39;kWarning&#39; indicates the task has finished with warning. &#39;kOnHold&#39; indicates the task is kept onHold. &#39;kMissed&#39; indicates the task is missed. &#39;Finalizing&#39; indicates the task is finalizing.</value>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionShellInfo" /> class.
        /// </summary>
        /// <param name="endTimeUsecs">Specifies the end time of the Protection Run. The end time is specified as a Unix epoch Timestamp (in microseconds)..</param>
        /// <param name="error">Specifies if an error occurred (if any) while running this task. This field is populated when the status is equal to &#39;kFailure&#39;..</param>
        /// <param name="jobRunId">Specifies the id of the Job Run that ran the backup task and the copy tasks..</param>
        /// <param name="runType">Specifies the type of backup such as &#39;kRegular&#39;, &#39;kFull&#39;, &#39;kLog&#39; or &#39;kSystem&#39;. &#39;kRegular&#39; indicates a incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time. &#39;kSystem&#39; indicates a system backup. System backups are used to do bare metal recovery of the system to a specific point in time..</param>
        /// <param name="startTimeUsecs">Specifies the start time of the Protection Run. The start time is specified as a Unix epoch Timestamp (in microseconds). This time is when the task is queued to an internal queue where tasks are waiting to run..</param>
        /// <param name="status">Specifies the status of Backup task such as &#39;kRunning&#39;, &#39;kSuccess&#39;, &#39;kFailure&#39; etc. &#39;kAccepted&#39; indicates the task is queued to run but not yet running. &#39;kRunning&#39; indicates the task is running. &#39;kCanceling&#39; indicates a request to cancel the task has occurred but the task is not yet canceled. &#39;kCanceled&#39; indicates the task has been canceled. &#39;kSuccess&#39; indicates the task was successful. &#39;kFailure&#39; indicates the task failed. &#39;kWarning&#39; indicates the task has finished with warning. &#39;kOnHold&#39; indicates the task is kept onHold. &#39;kMissed&#39; indicates the task is missed. &#39;Finalizing&#39; indicates the task is finalizing..</param>
        public ProtectionShellInfo(long? endTimeUsecs = default(long?), string error = default(string), long? jobRunId = default(long?), RunTypeEnum? runType = default(RunTypeEnum?), long? startTimeUsecs = default(long?), StatusEnum? status = default(StatusEnum?))
        {
            this.EndTimeUsecs = endTimeUsecs;
            this.Error = error;
            this.JobRunId = jobRunId;
            this.RunType = runType;
            this.StartTimeUsecs = startTimeUsecs;
            this.Status = status;
            this.EndTimeUsecs = endTimeUsecs;
            this.Error = error;
            this.JobRunId = jobRunId;
            this.RunType = runType;
            this.StartTimeUsecs = startTimeUsecs;
            this.Status = status;
        }
        
        /// <summary>
        /// Specifies the end time of the Protection Run. The end time is specified as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the end time of the Protection Run. The end time is specified as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="endTimeUsecs", EmitDefaultValue=true)]
        public long? EndTimeUsecs { get; set; }

        /// <summary>
        /// Specifies if an error occurred (if any) while running this task. This field is populated when the status is equal to &#39;kFailure&#39;.
        /// </summary>
        /// <value>Specifies if an error occurred (if any) while running this task. This field is populated when the status is equal to &#39;kFailure&#39;.</value>
        [DataMember(Name="error", EmitDefaultValue=true)]
        public string Error { get; set; }

        /// <summary>
        /// Specifies the id of the Job Run that ran the backup task and the copy tasks.
        /// </summary>
        /// <value>Specifies the id of the Job Run that ran the backup task and the copy tasks.</value>
        [DataMember(Name="jobRunId", EmitDefaultValue=true)]
        public long? JobRunId { get; set; }

        /// <summary>
        /// Specifies the start time of the Protection Run. The start time is specified as a Unix epoch Timestamp (in microseconds). This time is when the task is queued to an internal queue where tasks are waiting to run.
        /// </summary>
        /// <value>Specifies the start time of the Protection Run. The start time is specified as a Unix epoch Timestamp (in microseconds). This time is when the task is queued to an internal queue where tasks are waiting to run.</value>
        [DataMember(Name="startTimeUsecs", EmitDefaultValue=true)]
        public long? StartTimeUsecs { get; set; }

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
            return this.Equals(input as ProtectionShellInfo);
        }

        /// <summary>
        /// Returns true if ProtectionShellInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectionShellInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectionShellInfo input)
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
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.JobRunId == input.JobRunId ||
                    (this.JobRunId != null &&
                    this.JobRunId.Equals(input.JobRunId))
                ) && 
                (
                    this.RunType == input.RunType ||
                    this.RunType.Equals(input.RunType)
                ) && 
                (
                    this.StartTimeUsecs == input.StartTimeUsecs ||
                    (this.StartTimeUsecs != null &&
                    this.StartTimeUsecs.Equals(input.StartTimeUsecs))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
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
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.JobRunId != null)
                    hashCode = hashCode * 59 + this.JobRunId.GetHashCode();
                hashCode = hashCode * 59 + this.RunType.GetHashCode();
                if (this.StartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.StartTimeUsecs.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }

    }

}


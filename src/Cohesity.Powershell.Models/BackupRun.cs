// Copyright 2018 Cohesity Inc.

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;



namespace Cohesity.Models
{
    /// <summary>
    /// Specifies details about the Backup task for a Job Run. A Backup task captures the original backup snapshots for each Protection Source in the Job.
    /// </summary>
    [DataContract]
    public partial class BackupRun :  IEquatable<BackupRun>
    {

        /// <summary>
        /// Specifies the environment type that the task is protecting. Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter.
        /// </summary>
        /// <value>Specifies the environment type that the task is protecting. Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter.</value>
        [DataMember(Name="environment", EmitDefaultValue=false)]
        public string Environment { get; set; }

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
        [DataMember(Name="runType", EmitDefaultValue=false)]
        public RunTypeEnum? RunType { get; set; }

        /// <summary>
        /// Specifies the status of Backup task such as &#39;kRunning&#39;, &#39;kSuccess&#39;, &#39;kFailure&#39; etc. &#39;kAccepted&#39; indicates the task is queued to run but not yet running. &#39;kRunning&#39; indicates the task is running. &#39;kCanceling&#39; indicates a request to cancel the task has occurred but the task is not yet canceled. &#39;kCanceled&#39; indicates the task has been canceled. &#39;kSuccess&#39; indicates the task was successful. &#39;kFailure&#39; indicates the task failed.
        /// </summary>
        /// <value>Specifies the status of Backup task such as &#39;kRunning&#39;, &#39;kSuccess&#39;, &#39;kFailure&#39; etc. &#39;kAccepted&#39; indicates the task is queued to run but not yet running. &#39;kRunning&#39; indicates the task is running. &#39;kCanceling&#39; indicates a request to cancel the task has occurred but the task is not yet canceled. &#39;kCanceled&#39; indicates the task has been canceled. &#39;kSuccess&#39; indicates the task was successful. &#39;kFailure&#39; indicates the task failed.</value>
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
        /// Specifies the status of Backup task such as &#39;kRunning&#39;, &#39;kSuccess&#39;, &#39;kFailure&#39; etc. &#39;kAccepted&#39; indicates the task is queued to run but not yet running. &#39;kRunning&#39; indicates the task is running. &#39;kCanceling&#39; indicates a request to cancel the task has occurred but the task is not yet canceled. &#39;kCanceled&#39; indicates the task has been canceled. &#39;kSuccess&#39; indicates the task was successful. &#39;kFailure&#39; indicates the task failed.
        /// </summary>
        /// <value>Specifies the status of Backup task such as &#39;kRunning&#39;, &#39;kSuccess&#39;, &#39;kFailure&#39; etc. &#39;kAccepted&#39; indicates the task is queued to run but not yet running. &#39;kRunning&#39; indicates the task is running. &#39;kCanceling&#39; indicates a request to cancel the task has occurred but the task is not yet canceled. &#39;kCanceled&#39; indicates the task has been canceled. &#39;kSuccess&#39; indicates the task was successful. &#39;kFailure&#39; indicates the task failed.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BackupRun" /> class.
        /// </summary>
        /// <param name="environment">Specifies the environment type that the task is protecting. Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter..</param>
        /// <param name="error">Specifies if an error occurred (if any) while running this task. This field is populated when the status is equal to &#39;kFailure&#39;..</param>
        /// <param name="jobRunId">Specifies the id of the Job Run that ran the backup task and the copy tasks..</param>
        /// <param name="message">Specifies a message after finishing the task successfully. This field is optionally populated when the status is equal to &#39;kSuccess&#39;..</param>
        /// <param name="metadataDeleted">Specifies if the metadata and snapshots associated with this Job Run have been deleted. This field is set to true when the snapshots, which are marked for deletion, are removed by garbage collection. The associated metadata is also deleted..</param>
        /// <param name="quiesced">Specifies if app-consistent snapshot was captured. This field is set to true, if an app-consistent snapshot was taken by quiescing applications and the file system before taking a backup..</param>
        /// <param name="runType">Specifies the type of backup such as &#39;kRegular&#39;, &#39;kFull&#39;, &#39;kLog&#39; or &#39;kSystem&#39;. &#39;kRegular&#39; indicates a incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time. &#39;kSystem&#39; indicates a system backup. System backups are used to do bare metal recovery of the system to a specific point in time..</param>
        /// <param name="slaViolated">Specifies if the SLA was violated for the Job Run. This field is set to true, if time to complete the Job Run is longer than the SLA specified. This field is populated when the status is set to &#39;kSuccess&#39; or &#39;kFailure&#39;..</param>
        /// <param name="snapshotsDeleted">Specifies if backup snapshots associated with this Job Run have been marked for deletion because of the retention settings in the Policy or if they were manually deleted from the Cohesity Dashboard..</param>
        /// <param name="snapshotsDeletedTimeUsecs">Specifies if backup snapshots associated with this Job Run have been marked for deletion because of the retention settings in the Policy or if they were manually deleted from the Cohesity Dashboard..</param>
        /// <param name="sourceBackupStatus">Specifies the status of backing up each source objects (such as VMs) associated with the job..</param>
        /// <param name="stats">Specifies the aggregated stats of all Backup Run tasks in a Protection Run..</param>
        /// <param name="status">Specifies the status of Backup task such as &#39;kRunning&#39;, &#39;kSuccess&#39;, &#39;kFailure&#39; etc. &#39;kAccepted&#39; indicates the task is queued to run but not yet running. &#39;kRunning&#39; indicates the task is running. &#39;kCanceling&#39; indicates a request to cancel the task has occurred but the task is not yet canceled. &#39;kCanceled&#39; indicates the task has been canceled. &#39;kSuccess&#39; indicates the task was successful. &#39;kFailure&#39; indicates the task failed..</param>
        /// <param name="warnings">Specifies the warnings that occurred (if any) while running this task..</param>
        public BackupRun(string environment = default(string), string error = default(string), long? jobRunId = default(long?), string message = default(string), bool? metadataDeleted = default(bool?), bool? quiesced = default(bool?), RunTypeEnum? runType = default(RunTypeEnum?), bool? slaViolated = default(bool?), bool? snapshotsDeleted = default(bool?), long? snapshotsDeletedTimeUsecs = default(long?), List<SourceBackupStatus> sourceBackupStatus = default(List<SourceBackupStatus>), ProtectionJobRunStats stats = default(ProtectionJobRunStats), StatusEnum? status = default(StatusEnum?), List<string> warnings = default(List<string>))
        {
            this.Environment = environment;
            this.Error = error;
            this.JobRunId = jobRunId;
            this.Message = message;
            this.MetadataDeleted = metadataDeleted;
            this.Quiesced = quiesced;
            this.RunType = runType;
            this.SlaViolated = slaViolated;
            this.SnapshotsDeleted = snapshotsDeleted;
            this.SnapshotsDeletedTimeUsecs = snapshotsDeletedTimeUsecs;
            this.SourceBackupStatus = sourceBackupStatus;
            this.Stats = stats;
            this.Status = status;
            this.Warnings = warnings;
        }
        

        /// <summary>
        /// Specifies if an error occurred (if any) while running this task. This field is populated when the status is equal to &#39;kFailure&#39;.
        /// </summary>
        /// <value>Specifies if an error occurred (if any) while running this task. This field is populated when the status is equal to &#39;kFailure&#39;.</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }

        /// <summary>
        /// Specifies the id of the Job Run that ran the backup task and the copy tasks.
        /// </summary>
        /// <value>Specifies the id of the Job Run that ran the backup task and the copy tasks.</value>
        [DataMember(Name="jobRunId", EmitDefaultValue=false)]
        public long? JobRunId { get; set; }

        /// <summary>
        /// Specifies a message after finishing the task successfully. This field is optionally populated when the status is equal to &#39;kSuccess&#39;.
        /// </summary>
        /// <value>Specifies a message after finishing the task successfully. This field is optionally populated when the status is equal to &#39;kSuccess&#39;.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Specifies if the metadata and snapshots associated with this Job Run have been deleted. This field is set to true when the snapshots, which are marked for deletion, are removed by garbage collection. The associated metadata is also deleted.
        /// </summary>
        /// <value>Specifies if the metadata and snapshots associated with this Job Run have been deleted. This field is set to true when the snapshots, which are marked for deletion, are removed by garbage collection. The associated metadata is also deleted.</value>
        [DataMember(Name="metadataDeleted", EmitDefaultValue=false)]
        public bool? MetadataDeleted { get; set; }

        /// <summary>
        /// Specifies if app-consistent snapshot was captured. This field is set to true, if an app-consistent snapshot was taken by quiescing applications and the file system before taking a backup.
        /// </summary>
        /// <value>Specifies if app-consistent snapshot was captured. This field is set to true, if an app-consistent snapshot was taken by quiescing applications and the file system before taking a backup.</value>
        [DataMember(Name="quiesced", EmitDefaultValue=false)]
        public bool? Quiesced { get; set; }


        /// <summary>
        /// Specifies if the SLA was violated for the Job Run. This field is set to true, if time to complete the Job Run is longer than the SLA specified. This field is populated when the status is set to &#39;kSuccess&#39; or &#39;kFailure&#39;.
        /// </summary>
        /// <value>Specifies if the SLA was violated for the Job Run. This field is set to true, if time to complete the Job Run is longer than the SLA specified. This field is populated when the status is set to &#39;kSuccess&#39; or &#39;kFailure&#39;.</value>
        [DataMember(Name="slaViolated", EmitDefaultValue=false)]
        public bool? SlaViolated { get; set; }

        /// <summary>
        /// Specifies if backup snapshots associated with this Job Run have been marked for deletion because of the retention settings in the Policy or if they were manually deleted from the Cohesity Dashboard.
        /// </summary>
        /// <value>Specifies if backup snapshots associated with this Job Run have been marked for deletion because of the retention settings in the Policy or if they were manually deleted from the Cohesity Dashboard.</value>
        [DataMember(Name="snapshotsDeleted", EmitDefaultValue=false)]
        public bool? SnapshotsDeleted { get; set; }

        /// <summary>
        /// Specifies if backup snapshots associated with this Job Run have been marked for deletion because of the retention settings in the Policy or if they were manually deleted from the Cohesity Dashboard.
        /// </summary>
        /// <value>Specifies if backup snapshots associated with this Job Run have been marked for deletion because of the retention settings in the Policy or if they were manually deleted from the Cohesity Dashboard.</value>
        [DataMember(Name="snapshotsDeletedTimeUsecs", EmitDefaultValue=false)]
        public long? SnapshotsDeletedTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the status of backing up each source objects (such as VMs) associated with the job.
        /// </summary>
        /// <value>Specifies the status of backing up each source objects (such as VMs) associated with the job.</value>
        [DataMember(Name="sourceBackupStatus", EmitDefaultValue=false)]
        public List<SourceBackupStatus> SourceBackupStatus { get; set; }

        /// <summary>
        /// Specifies the aggregated stats of all Backup Run tasks in a Protection Run.
        /// </summary>
        /// <value>Specifies the aggregated stats of all Backup Run tasks in a Protection Run.</value>
        [DataMember(Name="stats", EmitDefaultValue=false)]
        public ProtectionJobRunStats Stats { get; set; }


        /// <summary>
        /// Specifies the warnings that occurred (if any) while running this task.
        /// </summary>
        /// <value>Specifies the warnings that occurred (if any) while running this task.</value>
        [DataMember(Name="warnings", EmitDefaultValue=false)]
        public List<string> Warnings { get; set; }

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
            return this.Equals(input as BackupRun);
        }

        /// <summary>
        /// Returns true if BackupRun instances are equal
        /// </summary>
        /// <param name="input">Instance of BackupRun to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BackupRun input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Environment == input.Environment ||
                    (this.Environment != null &&
                    this.Environment.Equals(input.Environment))
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
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.MetadataDeleted == input.MetadataDeleted ||
                    (this.MetadataDeleted != null &&
                    this.MetadataDeleted.Equals(input.MetadataDeleted))
                ) && 
                (
                    this.Quiesced == input.Quiesced ||
                    (this.Quiesced != null &&
                    this.Quiesced.Equals(input.Quiesced))
                ) && 
                (
                    this.RunType == input.RunType ||
                    (this.RunType != null &&
                    this.RunType.Equals(input.RunType))
                ) && 
                (
                    this.SlaViolated == input.SlaViolated ||
                    (this.SlaViolated != null &&
                    this.SlaViolated.Equals(input.SlaViolated))
                ) && 
                (
                    this.SnapshotsDeleted == input.SnapshotsDeleted ||
                    (this.SnapshotsDeleted != null &&
                    this.SnapshotsDeleted.Equals(input.SnapshotsDeleted))
                ) && 
                (
                    this.SnapshotsDeletedTimeUsecs == input.SnapshotsDeletedTimeUsecs ||
                    (this.SnapshotsDeletedTimeUsecs != null &&
                    this.SnapshotsDeletedTimeUsecs.Equals(input.SnapshotsDeletedTimeUsecs))
                ) && 
                (
                    this.SourceBackupStatus == input.SourceBackupStatus ||
                    this.SourceBackupStatus != null &&
                    this.SourceBackupStatus.SequenceEqual(input.SourceBackupStatus)
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
                    this.Warnings == input.Warnings ||
                    this.Warnings != null &&
                    this.Warnings.SequenceEqual(input.Warnings)
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
                if (this.Environment != null)
                    hashCode = hashCode * 59 + this.Environment.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.JobRunId != null)
                    hashCode = hashCode * 59 + this.JobRunId.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.MetadataDeleted != null)
                    hashCode = hashCode * 59 + this.MetadataDeleted.GetHashCode();
                if (this.Quiesced != null)
                    hashCode = hashCode * 59 + this.Quiesced.GetHashCode();
                if (this.RunType != null)
                    hashCode = hashCode * 59 + this.RunType.GetHashCode();
                if (this.SlaViolated != null)
                    hashCode = hashCode * 59 + this.SlaViolated.GetHashCode();
                if (this.SnapshotsDeleted != null)
                    hashCode = hashCode * 59 + this.SnapshotsDeleted.GetHashCode();
                if (this.SnapshotsDeletedTimeUsecs != null)
                    hashCode = hashCode * 59 + this.SnapshotsDeletedTimeUsecs.GetHashCode();
                if (this.SourceBackupStatus != null)
                    hashCode = hashCode * 59 + this.SourceBackupStatus.GetHashCode();
                if (this.Stats != null)
                    hashCode = hashCode * 59 + this.Stats.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Warnings != null)
                    hashCode = hashCode * 59 + this.Warnings.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


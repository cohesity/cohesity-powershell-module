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
    /// Specifies the source object to protect and the current backup status.
    /// </summary>
    [DataContract]
    public partial class SourceBackupStatus :  IEquatable<SourceBackupStatus>
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
        /// Initializes a new instance of the <see cref="SourceBackupStatus" /> class.
        /// </summary>
        /// <param name="currentSnapshotInfo">Specifies details about the snapshot captured to backup the source object (such as a VM)..</param>
        /// <param name="error">Specifies if an error occurred (if any) while running this task. This field is populated when the status is equal to &#39;kFailure&#39;..</param>
        /// <param name="isFullBackup">Specifies whether this is a &#39;kFull&#39; or &#39;kRegular&#39; backup of the Run. This may be true even if the scheduled backup type is &#39;kRegular&#39;. This will happen when this run corresponds to the first backup run of the Job or if no previous snapshot information is found..</param>
        /// <param name="numRestarts">Specifies the number of times the the task was restarted because of the changes on the backup source host..</param>
        /// <param name="parentSourceId">Specifies the id of the registered Protection Source that is the parent of the Objects that are protected by this Job Run..</param>
        /// <param name="quiesced">Specifies if app-consistent snapshot was captured. This field is set to true, if an app-consistent snapshot was taken by quiescing applications and the file system before taking a backup..</param>
        /// <param name="slaViolated">Specifies if the SLA was violated for the Job Run. This field is set to true, if time to complete the Job Run is longer than the SLA specified. This field is populated when the status is set to &#39;kSuccess&#39; or &#39;kFailure&#39;..</param>
        /// <param name="source">Specifies the source object to protect..</param>
        /// <param name="stats">Specifies the stats of the Backup Run task for the Protection Source..</param>
        /// <param name="status">Specifies the status of the source object being protected. &#39;kAccepted&#39; indicates the task is queued to run but not yet running. &#39;kRunning&#39; indicates the task is running. &#39;kCanceling&#39; indicates a request to cancel the task has occurred but the task is not yet canceled. &#39;kCanceled&#39; indicates the task has been canceled. &#39;kSuccess&#39; indicates the task was successful. &#39;kFailure&#39; indicates the task failed..</param>
        /// <param name="warnings">Specifies the warnings that occurred (if any) while running this task..</param>
        public SourceBackupStatus(SnapshotInfo currentSnapshotInfo = default(SnapshotInfo), string error = default(string), bool? isFullBackup = default(bool?), int? numRestarts = default(int?), long? parentSourceId = default(long?), bool? quiesced = default(bool?), bool? slaViolated = default(bool?), ProtectionSource source = default(ProtectionSource), BackupSourceStats stats = default(BackupSourceStats), StatusEnum? status = default(StatusEnum?), List<string> warnings = default(List<string>))
        {
            this.CurrentSnapshotInfo = currentSnapshotInfo;
            this.Error = error;
            this.IsFullBackup = isFullBackup;
            this.NumRestarts = numRestarts;
            this.ParentSourceId = parentSourceId;
            this.Quiesced = quiesced;
            this.SlaViolated = slaViolated;
            this.Source = source;
            this.Stats = stats;
            this.Status = status;
            this.Warnings = warnings;
        }
        
        /// <summary>
        /// Specifies details about the snapshot captured to backup the source object (such as a VM).
        /// </summary>
        /// <value>Specifies details about the snapshot captured to backup the source object (such as a VM).</value>
        [DataMember(Name="currentSnapshotInfo", EmitDefaultValue=false)]
        public SnapshotInfo CurrentSnapshotInfo { get; set; }

        /// <summary>
        /// Specifies if an error occurred (if any) while running this task. This field is populated when the status is equal to &#39;kFailure&#39;.
        /// </summary>
        /// <value>Specifies if an error occurred (if any) while running this task. This field is populated when the status is equal to &#39;kFailure&#39;.</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }

        /// <summary>
        /// Specifies whether this is a &#39;kFull&#39; or &#39;kRegular&#39; backup of the Run. This may be true even if the scheduled backup type is &#39;kRegular&#39;. This will happen when this run corresponds to the first backup run of the Job or if no previous snapshot information is found.
        /// </summary>
        /// <value>Specifies whether this is a &#39;kFull&#39; or &#39;kRegular&#39; backup of the Run. This may be true even if the scheduled backup type is &#39;kRegular&#39;. This will happen when this run corresponds to the first backup run of the Job or if no previous snapshot information is found.</value>
        [DataMember(Name="isFullBackup", EmitDefaultValue=false)]
        public bool? IsFullBackup { get; set; }

        /// <summary>
        /// Specifies the number of times the the task was restarted because of the changes on the backup source host.
        /// </summary>
        /// <value>Specifies the number of times the the task was restarted because of the changes on the backup source host.</value>
        [DataMember(Name="numRestarts", EmitDefaultValue=false)]
        public int? NumRestarts { get; set; }

        /// <summary>
        /// Specifies the id of the registered Protection Source that is the parent of the Objects that are protected by this Job Run.
        /// </summary>
        /// <value>Specifies the id of the registered Protection Source that is the parent of the Objects that are protected by this Job Run.</value>
        [DataMember(Name="parentSourceId", EmitDefaultValue=false)]
        public long? ParentSourceId { get; set; }

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
        /// Specifies the source object to protect.
        /// </summary>
        /// <value>Specifies the source object to protect.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public ProtectionSource Source { get; set; }

        /// <summary>
        /// Specifies the stats of the Backup Run task for the Protection Source.
        /// </summary>
        /// <value>Specifies the stats of the Backup Run task for the Protection Source.</value>
        [DataMember(Name="stats", EmitDefaultValue=false)]
        public BackupSourceStats Stats { get; set; }


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
            return this.Equals(input as SourceBackupStatus);
        }

        /// <summary>
        /// Returns true if SourceBackupStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of SourceBackupStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SourceBackupStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrentSnapshotInfo == input.CurrentSnapshotInfo ||
                    (this.CurrentSnapshotInfo != null &&
                    this.CurrentSnapshotInfo.Equals(input.CurrentSnapshotInfo))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.IsFullBackup == input.IsFullBackup ||
                    (this.IsFullBackup != null &&
                    this.IsFullBackup.Equals(input.IsFullBackup))
                ) && 
                (
                    this.NumRestarts == input.NumRestarts ||
                    (this.NumRestarts != null &&
                    this.NumRestarts.Equals(input.NumRestarts))
                ) && 
                (
                    this.ParentSourceId == input.ParentSourceId ||
                    (this.ParentSourceId != null &&
                    this.ParentSourceId.Equals(input.ParentSourceId))
                ) && 
                (
                    this.Quiesced == input.Quiesced ||
                    (this.Quiesced != null &&
                    this.Quiesced.Equals(input.Quiesced))
                ) && 
                (
                    this.SlaViolated == input.SlaViolated ||
                    (this.SlaViolated != null &&
                    this.SlaViolated.Equals(input.SlaViolated))
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
                if (this.CurrentSnapshotInfo != null)
                    hashCode = hashCode * 59 + this.CurrentSnapshotInfo.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.IsFullBackup != null)
                    hashCode = hashCode * 59 + this.IsFullBackup.GetHashCode();
                if (this.NumRestarts != null)
                    hashCode = hashCode * 59 + this.NumRestarts.GetHashCode();
                if (this.ParentSourceId != null)
                    hashCode = hashCode * 59 + this.ParentSourceId.GetHashCode();
                if (this.Quiesced != null)
                    hashCode = hashCode * 59 + this.Quiesced.GetHashCode();
                if (this.SlaViolated != null)
                    hashCode = hashCode * 59 + this.SlaViolated.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
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


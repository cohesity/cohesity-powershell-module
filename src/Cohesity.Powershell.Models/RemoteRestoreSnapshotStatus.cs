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
    /// Specifies the status of a restore Snapshot task.
    /// </summary>
    [DataContract]
    public partial class RemoteRestoreSnapshotStatus :  IEquatable<RemoteRestoreSnapshotStatus>
    {
        /// <summary>
        /// Specifies the status of the indexing task. &#39;kJobRunning&#39; indicates that the Job/task is currently running. &#39;kJobFinished&#39; indicates that the Job/task completed and finished. &#39;kJobFailed&#39; indicates that the Job/task failed and did not complete. &#39;kJobCanceled&#39; indicates that the Job/task was canceled. &#39;kJobPaused&#39; indicates the Job/task is paused.
        /// </summary>
        /// <value>Specifies the status of the indexing task. &#39;kJobRunning&#39; indicates that the Job/task is currently running. &#39;kJobFinished&#39; indicates that the Job/task completed and finished. &#39;kJobFailed&#39; indicates that the Job/task failed and did not complete. &#39;kJobCanceled&#39; indicates that the Job/task was canceled. &#39;kJobPaused&#39; indicates the Job/task is paused.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SnapshotTaskStatusEnum
        {
            /// <summary>
            /// Enum KJobRunning for value: kJobRunning
            /// </summary>
            [EnumMember(Value = "kJobRunning")]
            KJobRunning = 1,

            /// <summary>
            /// Enum KJobFinished for value: kJobFinished
            /// </summary>
            [EnumMember(Value = "kJobFinished")]
            KJobFinished = 2,

            /// <summary>
            /// Enum KJobFailed for value: kJobFailed
            /// </summary>
            [EnumMember(Value = "kJobFailed")]
            KJobFailed = 3,

            /// <summary>
            /// Enum KJobCanceled for value: kJobCanceled
            /// </summary>
            [EnumMember(Value = "kJobCanceled")]
            KJobCanceled = 4,

            /// <summary>
            /// Enum KJobPaused for value: kJobPaused
            /// </summary>
            [EnumMember(Value = "kJobPaused")]
            KJobPaused = 5

        }

        /// <summary>
        /// Specifies the status of the indexing task. &#39;kJobRunning&#39; indicates that the Job/task is currently running. &#39;kJobFinished&#39; indicates that the Job/task completed and finished. &#39;kJobFailed&#39; indicates that the Job/task failed and did not complete. &#39;kJobCanceled&#39; indicates that the Job/task was canceled. &#39;kJobPaused&#39; indicates the Job/task is paused.
        /// </summary>
        /// <value>Specifies the status of the indexing task. &#39;kJobRunning&#39; indicates that the Job/task is currently running. &#39;kJobFinished&#39; indicates that the Job/task completed and finished. &#39;kJobFailed&#39; indicates that the Job/task failed and did not complete. &#39;kJobCanceled&#39; indicates that the Job/task was canceled. &#39;kJobPaused&#39; indicates the Job/task is paused.</value>
        [DataMember(Name="snapshotTaskStatus", EmitDefaultValue=true)]
        public SnapshotTaskStatusEnum? SnapshotTaskStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteRestoreSnapshotStatus" /> class.
        /// </summary>
        /// <param name="archiveTaskUid">Specifies the globally unique id of the archival task that archived the Snapshots to the remote Vault..</param>
        /// <param name="error">Specifies the error message if the indexing task fails..</param>
        /// <param name="expiryTimeUsecs">Specifies the time when the Snapshot expires on the remote Vault. This field is recorded as a Unix epoch Timestamp (in microseconds)..</param>
        /// <param name="jobRunId">Specifies the id of the Job Run that originally captured the Snapshot..</param>
        /// <param name="progressMonitorTask">Specifies the path to the progress monitor task that tracks the progress of building the index..</param>
        /// <param name="snapshotTaskStatus">Specifies the status of the indexing task. &#39;kJobRunning&#39; indicates that the Job/task is currently running. &#39;kJobFinished&#39; indicates that the Job/task completed and finished. &#39;kJobFailed&#39; indicates that the Job/task failed and did not complete. &#39;kJobCanceled&#39; indicates that the Job/task was canceled. &#39;kJobPaused&#39; indicates the Job/task is paused..</param>
        /// <param name="snapshotTaskUid">Specifies the globally unique id of the task capturing the Snapshot..</param>
        /// <param name="snapshotTimeUsecs">Specify the time the Snapshot was captured. This time is recorded as a Unix epoch Timestamp (in microseconds)..</param>
        public RemoteRestoreSnapshotStatus(UniversalId archiveTaskUid = default(UniversalId), string error = default(string), long? expiryTimeUsecs = default(long?), long? jobRunId = default(long?), string progressMonitorTask = default(string), SnapshotTaskStatusEnum? snapshotTaskStatus = default(SnapshotTaskStatusEnum?), UniversalId snapshotTaskUid = default(UniversalId), long? snapshotTimeUsecs = default(long?))
        {
            this.ArchiveTaskUid = archiveTaskUid;
            this.Error = error;
            this.ExpiryTimeUsecs = expiryTimeUsecs;
            this.JobRunId = jobRunId;
            this.ProgressMonitorTask = progressMonitorTask;
            this.SnapshotTaskStatus = snapshotTaskStatus;
            this.SnapshotTaskUid = snapshotTaskUid;
            this.SnapshotTimeUsecs = snapshotTimeUsecs;
            this.ArchiveTaskUid = archiveTaskUid;
            this.Error = error;
            this.ExpiryTimeUsecs = expiryTimeUsecs;
            this.JobRunId = jobRunId;
            this.ProgressMonitorTask = progressMonitorTask;
            this.SnapshotTaskStatus = snapshotTaskStatus;
            this.SnapshotTaskUid = snapshotTaskUid;
            this.SnapshotTimeUsecs = snapshotTimeUsecs;
        }
        
        /// <summary>
        /// Specifies the globally unique id of the archival task that archived the Snapshots to the remote Vault.
        /// </summary>
        /// <value>Specifies the globally unique id of the archival task that archived the Snapshots to the remote Vault.</value>
        [DataMember(Name="archiveTaskUid", EmitDefaultValue=true)]
        public UniversalId ArchiveTaskUid { get; set; }

        /// <summary>
        /// Specifies the error message if the indexing task fails.
        /// </summary>
        /// <value>Specifies the error message if the indexing task fails.</value>
        [DataMember(Name="error", EmitDefaultValue=true)]
        public string Error { get; set; }

        /// <summary>
        /// Specifies the time when the Snapshot expires on the remote Vault. This field is recorded as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the time when the Snapshot expires on the remote Vault. This field is recorded as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="expiryTimeUsecs", EmitDefaultValue=true)]
        public long? ExpiryTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the id of the Job Run that originally captured the Snapshot.
        /// </summary>
        /// <value>Specifies the id of the Job Run that originally captured the Snapshot.</value>
        [DataMember(Name="jobRunId", EmitDefaultValue=true)]
        public long? JobRunId { get; set; }

        /// <summary>
        /// Specifies the path to the progress monitor task that tracks the progress of building the index.
        /// </summary>
        /// <value>Specifies the path to the progress monitor task that tracks the progress of building the index.</value>
        [DataMember(Name="progressMonitorTask", EmitDefaultValue=true)]
        public string ProgressMonitorTask { get; set; }

        /// <summary>
        /// Specifies the globally unique id of the task capturing the Snapshot.
        /// </summary>
        /// <value>Specifies the globally unique id of the task capturing the Snapshot.</value>
        [DataMember(Name="snapshotTaskUid", EmitDefaultValue=true)]
        public UniversalId SnapshotTaskUid { get; set; }

        /// <summary>
        /// Specify the time the Snapshot was captured. This time is recorded as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specify the time the Snapshot was captured. This time is recorded as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="snapshotTimeUsecs", EmitDefaultValue=true)]
        public long? SnapshotTimeUsecs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemoteRestoreSnapshotStatus {\n");
            sb.Append("  ArchiveTaskUid: ").Append(ArchiveTaskUid).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  ExpiryTimeUsecs: ").Append(ExpiryTimeUsecs).Append("\n");
            sb.Append("  JobRunId: ").Append(JobRunId).Append("\n");
            sb.Append("  ProgressMonitorTask: ").Append(ProgressMonitorTask).Append("\n");
            sb.Append("  SnapshotTaskStatus: ").Append(SnapshotTaskStatus).Append("\n");
            sb.Append("  SnapshotTaskUid: ").Append(SnapshotTaskUid).Append("\n");
            sb.Append("  SnapshotTimeUsecs: ").Append(SnapshotTimeUsecs).Append("\n");
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
            return this.Equals(input as RemoteRestoreSnapshotStatus);
        }

        /// <summary>
        /// Returns true if RemoteRestoreSnapshotStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of RemoteRestoreSnapshotStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemoteRestoreSnapshotStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ArchiveTaskUid == input.ArchiveTaskUid ||
                    (this.ArchiveTaskUid != null &&
                    this.ArchiveTaskUid.Equals(input.ArchiveTaskUid))
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
                    this.JobRunId == input.JobRunId ||
                    (this.JobRunId != null &&
                    this.JobRunId.Equals(input.JobRunId))
                ) && 
                (
                    this.ProgressMonitorTask == input.ProgressMonitorTask ||
                    (this.ProgressMonitorTask != null &&
                    this.ProgressMonitorTask.Equals(input.ProgressMonitorTask))
                ) && 
                (
                    this.SnapshotTaskStatus == input.SnapshotTaskStatus ||
                    this.SnapshotTaskStatus.Equals(input.SnapshotTaskStatus)
                ) && 
                (
                    this.SnapshotTaskUid == input.SnapshotTaskUid ||
                    (this.SnapshotTaskUid != null &&
                    this.SnapshotTaskUid.Equals(input.SnapshotTaskUid))
                ) && 
                (
                    this.SnapshotTimeUsecs == input.SnapshotTimeUsecs ||
                    (this.SnapshotTimeUsecs != null &&
                    this.SnapshotTimeUsecs.Equals(input.SnapshotTimeUsecs))
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
                if (this.ArchiveTaskUid != null)
                    hashCode = hashCode * 59 + this.ArchiveTaskUid.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.ExpiryTimeUsecs != null)
                    hashCode = hashCode * 59 + this.ExpiryTimeUsecs.GetHashCode();
                if (this.JobRunId != null)
                    hashCode = hashCode * 59 + this.JobRunId.GetHashCode();
                if (this.ProgressMonitorTask != null)
                    hashCode = hashCode * 59 + this.ProgressMonitorTask.GetHashCode();
                hashCode = hashCode * 59 + this.SnapshotTaskStatus.GetHashCode();
                if (this.SnapshotTaskUid != null)
                    hashCode = hashCode * 59 + this.SnapshotTaskUid.GetHashCode();
                if (this.SnapshotTimeUsecs != null)
                    hashCode = hashCode * 59 + this.SnapshotTimeUsecs.GetHashCode();
                return hashCode;
            }
        }

    }

}

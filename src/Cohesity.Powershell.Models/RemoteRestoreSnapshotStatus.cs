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
        [DataMember(Name="snapshotTaskStatus", EmitDefaultValue=false)]
        public SnapshotTaskStatusEnum? SnapshotTaskStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteRestoreSnapshotStatus" /> class.
        /// </summary>
        /// <param name="archiveTaskUid">archiveTaskUid.</param>
        /// <param name="error">Specifies the error message if the indexing task fails..</param>
        /// <param name="expiryTimeUsecs">Specifies the time when the Snapshot expires on the remote Vault. This field is recorded as a Unix epoch Timestamp (in microseconds)..</param>
        /// <param name="jobRunId">Specifies the id of the Job Run that originally captured the Snapshot..</param>
        /// <param name="progressMonitorTask">Specifies the path to the progress monitor task that tracks the progress of building the index..</param>
        /// <param name="snapshotTaskStatus">Specifies the status of the indexing task. &#39;kJobRunning&#39; indicates that the Job/task is currently running. &#39;kJobFinished&#39; indicates that the Job/task completed and finished. &#39;kJobFailed&#39; indicates that the Job/task failed and did not complete. &#39;kJobCanceled&#39; indicates that the Job/task was canceled. &#39;kJobPaused&#39; indicates the Job/task is paused..</param>
        /// <param name="snapshotTaskUid">snapshotTaskUid.</param>
        /// <param name="snapshotTimeUsecs">Specify the time the Snapshot was captured. This time is recorded as a Unix epoch Timestamp (in microseconds)..</param>
        public RemoteRestoreSnapshotStatus(ArchiveTaskUid2 archiveTaskUid = default(ArchiveTaskUid2), string error = default(string), long? expiryTimeUsecs = default(long?), long? jobRunId = default(long?), string progressMonitorTask = default(string), SnapshotTaskStatusEnum? snapshotTaskStatus = default(SnapshotTaskStatusEnum?), SnapshotTaskUid_ snapshotTaskUid = default(SnapshotTaskUid_), long? snapshotTimeUsecs = default(long?))
        {
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
        /// Gets or Sets ArchiveTaskUid
        /// </summary>
        [DataMember(Name="archiveTaskUid", EmitDefaultValue=false)]
        public ArchiveTaskUid2 ArchiveTaskUid { get; set; }

        /// <summary>
        /// Specifies the error message if the indexing task fails.
        /// </summary>
        /// <value>Specifies the error message if the indexing task fails.</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }

        /// <summary>
        /// Specifies the time when the Snapshot expires on the remote Vault. This field is recorded as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the time when the Snapshot expires on the remote Vault. This field is recorded as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="expiryTimeUsecs", EmitDefaultValue=false)]
        public long? ExpiryTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the id of the Job Run that originally captured the Snapshot.
        /// </summary>
        /// <value>Specifies the id of the Job Run that originally captured the Snapshot.</value>
        [DataMember(Name="jobRunId", EmitDefaultValue=false)]
        public long? JobRunId { get; set; }

        /// <summary>
        /// Specifies the path to the progress monitor task that tracks the progress of building the index.
        /// </summary>
        /// <value>Specifies the path to the progress monitor task that tracks the progress of building the index.</value>
        [DataMember(Name="progressMonitorTask", EmitDefaultValue=false)]
        public string ProgressMonitorTask { get; set; }


        /// <summary>
        /// Gets or Sets SnapshotTaskUid
        /// </summary>
        [DataMember(Name="snapshotTaskUid", EmitDefaultValue=false)]
        public SnapshotTaskUid_ SnapshotTaskUid { get; set; }

        /// <summary>
        /// Specify the time the Snapshot was captured. This time is recorded as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specify the time the Snapshot was captured. This time is recorded as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="snapshotTimeUsecs", EmitDefaultValue=false)]
        public long? SnapshotTimeUsecs { get; set; }

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
                    (this.SnapshotTaskStatus != null &&
                    this.SnapshotTaskStatus.Equals(input.SnapshotTaskStatus))
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
                if (this.SnapshotTaskStatus != null)
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


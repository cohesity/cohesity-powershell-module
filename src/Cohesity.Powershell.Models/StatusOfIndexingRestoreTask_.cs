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
    /// Specifies the status of an indexing task that builds an index from the Protection Job metadata retrieved from the remote Vault. The index contains information about Job Runs (Snapshots) for a Protection Job and is required to restore Snapshots to this local Cluster.
    /// </summary>
    [DataContract]
    public partial class StatusOfIndexingRestoreTask_ :  IEquatable<StatusOfIndexingRestoreTask_>
    {
        /// <summary>
        /// Specifies the status of the indexing Job/task. &#39;kJobRunning&#39; indicates that the Job/task is currently running. &#39;kJobFinished&#39; indicates that the Job/task completed and finished. &#39;kJobFailed&#39; indicates that the Job/task failed and did not complete. &#39;kJobCanceled&#39; indicates that the Job/task was canceled. &#39;kJobPaused&#39; indicates the Job/task is paused.
        /// </summary>
        /// <value>Specifies the status of the indexing Job/task. &#39;kJobRunning&#39; indicates that the Job/task is currently running. &#39;kJobFinished&#39; indicates that the Job/task completed and finished. &#39;kJobFailed&#39; indicates that the Job/task failed and did not complete. &#39;kJobCanceled&#39; indicates that the Job/task was canceled. &#39;kJobPaused&#39; indicates the Job/task is paused.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IndexingTaskStatusEnum
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
        /// Specifies the status of the indexing Job/task. &#39;kJobRunning&#39; indicates that the Job/task is currently running. &#39;kJobFinished&#39; indicates that the Job/task completed and finished. &#39;kJobFailed&#39; indicates that the Job/task failed and did not complete. &#39;kJobCanceled&#39; indicates that the Job/task was canceled. &#39;kJobPaused&#39; indicates the Job/task is paused.
        /// </summary>
        /// <value>Specifies the status of the indexing Job/task. &#39;kJobRunning&#39; indicates that the Job/task is currently running. &#39;kJobFinished&#39; indicates that the Job/task completed and finished. &#39;kJobFailed&#39; indicates that the Job/task failed and did not complete. &#39;kJobCanceled&#39; indicates that the Job/task was canceled. &#39;kJobPaused&#39; indicates the Job/task is paused.</value>
        [DataMember(Name="indexingTaskStatus", EmitDefaultValue=false)]
        public IndexingTaskStatusEnum? IndexingTaskStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusOfIndexingRestoreTask_" /> class.
        /// </summary>
        /// <param name="endTimeUsecs">Specifies the end time of the time range that is being indexed. The indexing task is creating an index of the Job Runs that occurred between the startTimeUsecs and this endTimeUsecs. This field is recorded as a Unix epoch Timestamp (in microseconds)..</param>
        /// <param name="error">Specifies the error message if the indexing Job/task fails..</param>
        /// <param name="indexingTaskEndTimeUsecs">Specifies when the indexing task completed. This time is recorded as a Unix epoch Timestamp (in microseconds). This field is not set if the indexing task is still in progress..</param>
        /// <param name="indexingTaskStartTimeUsecs">Specifies when the indexing task started. This time is recorded as a Unix epoch Timestamp (in microseconds)..</param>
        /// <param name="indexingTaskStatus">Specifies the status of the indexing Job/task. &#39;kJobRunning&#39; indicates that the Job/task is currently running. &#39;kJobFinished&#39; indicates that the Job/task completed and finished. &#39;kJobFailed&#39; indicates that the Job/task failed and did not complete. &#39;kJobCanceled&#39; indicates that the Job/task was canceled. &#39;kJobPaused&#39; indicates the Job/task is paused..</param>
        /// <param name="indexingTaskUid">indexingTaskUid.</param>
        /// <param name="latestExpiryTimeUsecs">For all the Snapshots retrieved by this Job, specifies the latest time when a Snapshot expires..</param>
        /// <param name="progressMonitorTask">Specifies the path to progress monitor task to track the progress of building the index..</param>
        /// <param name="startTimeUsecs">Specifies the start time of the time range that is being indexed. The indexing task is creating an index of the Job Runs that occurred between this startTimeUsecs and the endTimeUsecs. This field is recorded as a Unix epoch Timestamp (in microseconds)..</param>
        public StatusOfIndexingRestoreTask_(long? endTimeUsecs = default(long?), string error = default(string), long? indexingTaskEndTimeUsecs = default(long?), long? indexingTaskStartTimeUsecs = default(long?), IndexingTaskStatusEnum? indexingTaskStatus = default(IndexingTaskStatusEnum?), IndexingTaskUid_ indexingTaskUid = default(IndexingTaskUid_), long? latestExpiryTimeUsecs = default(long?), string progressMonitorTask = default(string), long? startTimeUsecs = default(long?))
        {
            this.EndTimeUsecs = endTimeUsecs;
            this.Error = error;
            this.IndexingTaskEndTimeUsecs = indexingTaskEndTimeUsecs;
            this.IndexingTaskStartTimeUsecs = indexingTaskStartTimeUsecs;
            this.IndexingTaskStatus = indexingTaskStatus;
            this.IndexingTaskUid = indexingTaskUid;
            this.LatestExpiryTimeUsecs = latestExpiryTimeUsecs;
            this.ProgressMonitorTask = progressMonitorTask;
            this.StartTimeUsecs = startTimeUsecs;
        }
        
        /// <summary>
        /// Specifies the end time of the time range that is being indexed. The indexing task is creating an index of the Job Runs that occurred between the startTimeUsecs and this endTimeUsecs. This field is recorded as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the end time of the time range that is being indexed. The indexing task is creating an index of the Job Runs that occurred between the startTimeUsecs and this endTimeUsecs. This field is recorded as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="endTimeUsecs", EmitDefaultValue=false)]
        public long? EndTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the error message if the indexing Job/task fails.
        /// </summary>
        /// <value>Specifies the error message if the indexing Job/task fails.</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }

        /// <summary>
        /// Specifies when the indexing task completed. This time is recorded as a Unix epoch Timestamp (in microseconds). This field is not set if the indexing task is still in progress.
        /// </summary>
        /// <value>Specifies when the indexing task completed. This time is recorded as a Unix epoch Timestamp (in microseconds). This field is not set if the indexing task is still in progress.</value>
        [DataMember(Name="indexingTaskEndTimeUsecs", EmitDefaultValue=false)]
        public long? IndexingTaskEndTimeUsecs { get; set; }

        /// <summary>
        /// Specifies when the indexing task started. This time is recorded as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies when the indexing task started. This time is recorded as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="indexingTaskStartTimeUsecs", EmitDefaultValue=false)]
        public long? IndexingTaskStartTimeUsecs { get; set; }


        /// <summary>
        /// Gets or Sets IndexingTaskUid
        /// </summary>
        [DataMember(Name="indexingTaskUid", EmitDefaultValue=false)]
        public IndexingTaskUid_ IndexingTaskUid { get; set; }

        /// <summary>
        /// For all the Snapshots retrieved by this Job, specifies the latest time when a Snapshot expires.
        /// </summary>
        /// <value>For all the Snapshots retrieved by this Job, specifies the latest time when a Snapshot expires.</value>
        [DataMember(Name="latestExpiryTimeUsecs", EmitDefaultValue=false)]
        public long? LatestExpiryTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the path to progress monitor task to track the progress of building the index.
        /// </summary>
        /// <value>Specifies the path to progress monitor task to track the progress of building the index.</value>
        [DataMember(Name="progressMonitorTask", EmitDefaultValue=false)]
        public string ProgressMonitorTask { get; set; }

        /// <summary>
        /// Specifies the start time of the time range that is being indexed. The indexing task is creating an index of the Job Runs that occurred between this startTimeUsecs and the endTimeUsecs. This field is recorded as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the start time of the time range that is being indexed. The indexing task is creating an index of the Job Runs that occurred between this startTimeUsecs and the endTimeUsecs. This field is recorded as a Unix epoch Timestamp (in microseconds).</value>
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
            return this.Equals(input as StatusOfIndexingRestoreTask_);
        }

        /// <summary>
        /// Returns true if StatusOfIndexingRestoreTask_ instances are equal
        /// </summary>
        /// <param name="input">Instance of StatusOfIndexingRestoreTask_ to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatusOfIndexingRestoreTask_ input)
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
                    this.IndexingTaskEndTimeUsecs == input.IndexingTaskEndTimeUsecs ||
                    (this.IndexingTaskEndTimeUsecs != null &&
                    this.IndexingTaskEndTimeUsecs.Equals(input.IndexingTaskEndTimeUsecs))
                ) && 
                (
                    this.IndexingTaskStartTimeUsecs == input.IndexingTaskStartTimeUsecs ||
                    (this.IndexingTaskStartTimeUsecs != null &&
                    this.IndexingTaskStartTimeUsecs.Equals(input.IndexingTaskStartTimeUsecs))
                ) && 
                (
                    this.IndexingTaskStatus == input.IndexingTaskStatus ||
                    (this.IndexingTaskStatus != null &&
                    this.IndexingTaskStatus.Equals(input.IndexingTaskStatus))
                ) && 
                (
                    this.IndexingTaskUid == input.IndexingTaskUid ||
                    (this.IndexingTaskUid != null &&
                    this.IndexingTaskUid.Equals(input.IndexingTaskUid))
                ) && 
                (
                    this.LatestExpiryTimeUsecs == input.LatestExpiryTimeUsecs ||
                    (this.LatestExpiryTimeUsecs != null &&
                    this.LatestExpiryTimeUsecs.Equals(input.LatestExpiryTimeUsecs))
                ) && 
                (
                    this.ProgressMonitorTask == input.ProgressMonitorTask ||
                    (this.ProgressMonitorTask != null &&
                    this.ProgressMonitorTask.Equals(input.ProgressMonitorTask))
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
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.IndexingTaskEndTimeUsecs != null)
                    hashCode = hashCode * 59 + this.IndexingTaskEndTimeUsecs.GetHashCode();
                if (this.IndexingTaskStartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.IndexingTaskStartTimeUsecs.GetHashCode();
                if (this.IndexingTaskStatus != null)
                    hashCode = hashCode * 59 + this.IndexingTaskStatus.GetHashCode();
                if (this.IndexingTaskUid != null)
                    hashCode = hashCode * 59 + this.IndexingTaskUid.GetHashCode();
                if (this.LatestExpiryTimeUsecs != null)
                    hashCode = hashCode * 59 + this.LatestExpiryTimeUsecs.GetHashCode();
                if (this.ProgressMonitorTask != null)
                    hashCode = hashCode * 59 + this.ProgressMonitorTask.GetHashCode();
                if (this.StartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.StartTimeUsecs.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


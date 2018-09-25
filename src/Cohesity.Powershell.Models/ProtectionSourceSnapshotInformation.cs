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
    /// Specifies details about a Snapshot that backups up a leaf Protection Source Object.
    /// </summary>
    [DataContract]
    public partial class ProtectionSourceSnapshotInformation :  IEquatable<ProtectionSourceSnapshotInformation>
    {
        /// <summary>
        /// Specifies the type of the Job Run. &#39;kSuccess&#39; indicates that the Job Run was successful. &#39;kRunning&#39; indicates that the Job Run is currently running. &#39;kWarning&#39; indicates that the Job Run was successful but warnings were issued. &#39;kCancelled&#39; indicates that the Job Run was canceled. &#39;kError&#39; indicates the Job Run encountered an error and did not run to completion.
        /// </summary>
        /// <value>Specifies the type of the Job Run. &#39;kSuccess&#39; indicates that the Job Run was successful. &#39;kRunning&#39; indicates that the Job Run is currently running. &#39;kWarning&#39; indicates that the Job Run was successful but warnings were issued. &#39;kCancelled&#39; indicates that the Job Run was canceled. &#39;kError&#39; indicates the Job Run encountered an error and did not run to completion.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RunStatusEnum
        {
            
            /// <summary>
            /// Enum KSuccess for value: kSuccess
            /// </summary>
            [EnumMember(Value = "kSuccess")]
            KSuccess = 1,
            
            /// <summary>
            /// Enum KRunning for value: kRunning
            /// </summary>
            [EnumMember(Value = "kRunning")]
            KRunning = 2,
            
            /// <summary>
            /// Enum KWarning for value: kWarning
            /// </summary>
            [EnumMember(Value = "kWarning")]
            KWarning = 3,
            
            /// <summary>
            /// Enum KCancelled for value: kCancelled
            /// </summary>
            [EnumMember(Value = "kCancelled")]
            KCancelled = 4,
            
            /// <summary>
            /// Enum KError for value: kError
            /// </summary>
            [EnumMember(Value = "kError")]
            KError = 5
        }

        /// <summary>
        /// Specifies the type of the Job Run. &#39;kSuccess&#39; indicates that the Job Run was successful. &#39;kRunning&#39; indicates that the Job Run is currently running. &#39;kWarning&#39; indicates that the Job Run was successful but warnings were issued. &#39;kCancelled&#39; indicates that the Job Run was canceled. &#39;kError&#39; indicates the Job Run encountered an error and did not run to completion.
        /// </summary>
        /// <value>Specifies the type of the Job Run. &#39;kSuccess&#39; indicates that the Job Run was successful. &#39;kRunning&#39; indicates that the Job Run is currently running. &#39;kWarning&#39; indicates that the Job Run was successful but warnings were issued. &#39;kCancelled&#39; indicates that the Job Run was canceled. &#39;kError&#39; indicates the Job Run encountered an error and did not run to completion.</value>
        [DataMember(Name="runStatus", EmitDefaultValue=false)]
        public RunStatusEnum? RunStatus { get; set; }
        /// <summary>
        /// Specifies the status of the Job Run. &#39;kRegular&#39; indicates an incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time.
        /// </summary>
        /// <value>Specifies the status of the Job Run. &#39;kRegular&#39; indicates an incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time.</value>
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
            KLog = 3
        }

        /// <summary>
        /// Specifies the status of the Job Run. &#39;kRegular&#39; indicates an incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time.
        /// </summary>
        /// <value>Specifies the status of the Job Run. &#39;kRegular&#39; indicates an incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time.</value>
        [DataMember(Name="runType", EmitDefaultValue=false)]
        public RunTypeEnum? RunType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionSourceSnapshotInformation" /> class.
        /// </summary>
        /// <param name="copyTasks">Specifies a list of copy tasks (such as replication and archival tasks)..</param>
        /// <param name="jobId">Specifies the id of the Protection Job..</param>
        /// <param name="jobName">Specifies the name of the Protection Job..</param>
        /// <param name="jobRunId">Specifies the id of the Job Run..</param>
        /// <param name="lastRunEndTimeUsecs">Specifies the end time of the last Job Run. The time is specified in Unix epoch Timestamp (in microseconds)..</param>
        /// <param name="lastRunStartTimeUsecs">Specifies the start time of the last Job Run. The time is specified in Unix epoch Timestamp (in microseconds)..</param>
        /// <param name="message">Specifies warning or error information when the Job Run is not successful..</param>
        /// <param name="numBytesRead">Specifies the total number of bytes read..</param>
        /// <param name="numLogicalBytesProtected">Specifies the total number of logical bytes that are protected. The logical size is when the data is fully hydrated or expanded..</param>
        /// <param name="paginationCookie">Specifies an opaque string to pass into the next request to get the next set of Snapshots for pagination purposes. If null, this is the last set of Snapshots or the number of Snapshots returned is equal to or less than the specified pageCount..</param>
        /// <param name="runStatus">Specifies the type of the Job Run. &#39;kSuccess&#39; indicates that the Job Run was successful. &#39;kRunning&#39; indicates that the Job Run is currently running. &#39;kWarning&#39; indicates that the Job Run was successful but warnings were issued. &#39;kCancelled&#39; indicates that the Job Run was canceled. &#39;kError&#39; indicates the Job Run encountered an error and did not run to completion..</param>
        /// <param name="runType">Specifies the status of the Job Run. &#39;kRegular&#39; indicates an incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time..</param>
        public ProtectionSourceSnapshotInformation(List<SnapshotCopyTask> copyTasks = default(List<SnapshotCopyTask>), long? jobId = default(long?), string jobName = default(string), long? jobRunId = default(long?), long? lastRunEndTimeUsecs = default(long?), long? lastRunStartTimeUsecs = default(long?), string message = default(string), long? numBytesRead = default(long?), long? numLogicalBytesProtected = default(long?), int? paginationCookie = default(int?), RunStatusEnum? runStatus = default(RunStatusEnum?), RunTypeEnum? runType = default(RunTypeEnum?))
        {
            this.CopyTasks = copyTasks;
            this.JobId = jobId;
            this.JobName = jobName;
            this.JobRunId = jobRunId;
            this.LastRunEndTimeUsecs = lastRunEndTimeUsecs;
            this.LastRunStartTimeUsecs = lastRunStartTimeUsecs;
            this.Message = message;
            this.NumBytesRead = numBytesRead;
            this.NumLogicalBytesProtected = numLogicalBytesProtected;
            this.PaginationCookie = paginationCookie;
            this.RunStatus = runStatus;
            this.RunType = runType;
        }
        
        /// <summary>
        /// Specifies a list of copy tasks (such as replication and archival tasks).
        /// </summary>
        /// <value>Specifies a list of copy tasks (such as replication and archival tasks).</value>
        [DataMember(Name="copyTasks", EmitDefaultValue=false)]
        public List<SnapshotCopyTask> CopyTasks { get; set; }

        /// <summary>
        /// Specifies the id of the Protection Job.
        /// </summary>
        /// <value>Specifies the id of the Protection Job.</value>
        [DataMember(Name="jobId", EmitDefaultValue=false)]
        public long? JobId { get; set; }

        /// <summary>
        /// Specifies the name of the Protection Job.
        /// </summary>
        /// <value>Specifies the name of the Protection Job.</value>
        [DataMember(Name="jobName", EmitDefaultValue=false)]
        public string JobName { get; set; }

        /// <summary>
        /// Specifies the id of the Job Run.
        /// </summary>
        /// <value>Specifies the id of the Job Run.</value>
        [DataMember(Name="jobRunId", EmitDefaultValue=false)]
        public long? JobRunId { get; set; }

        /// <summary>
        /// Specifies the end time of the last Job Run. The time is specified in Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the end time of the last Job Run. The time is specified in Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="lastRunEndTimeUsecs", EmitDefaultValue=false)]
        public long? LastRunEndTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the start time of the last Job Run. The time is specified in Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the start time of the last Job Run. The time is specified in Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="lastRunStartTimeUsecs", EmitDefaultValue=false)]
        public long? LastRunStartTimeUsecs { get; set; }

        /// <summary>
        /// Specifies warning or error information when the Job Run is not successful.
        /// </summary>
        /// <value>Specifies warning or error information when the Job Run is not successful.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Specifies the total number of bytes read.
        /// </summary>
        /// <value>Specifies the total number of bytes read.</value>
        [DataMember(Name="numBytesRead", EmitDefaultValue=false)]
        public long? NumBytesRead { get; set; }

        /// <summary>
        /// Specifies the total number of logical bytes that are protected. The logical size is when the data is fully hydrated or expanded.
        /// </summary>
        /// <value>Specifies the total number of logical bytes that are protected. The logical size is when the data is fully hydrated or expanded.</value>
        [DataMember(Name="numLogicalBytesProtected", EmitDefaultValue=false)]
        public long? NumLogicalBytesProtected { get; set; }

        /// <summary>
        /// Specifies an opaque string to pass into the next request to get the next set of Snapshots for pagination purposes. If null, this is the last set of Snapshots or the number of Snapshots returned is equal to or less than the specified pageCount.
        /// </summary>
        /// <value>Specifies an opaque string to pass into the next request to get the next set of Snapshots for pagination purposes. If null, this is the last set of Snapshots or the number of Snapshots returned is equal to or less than the specified pageCount.</value>
        [DataMember(Name="paginationCookie", EmitDefaultValue=false)]
        public int? PaginationCookie { get; set; }



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
            return this.Equals(input as ProtectionSourceSnapshotInformation);
        }

        /// <summary>
        /// Returns true if ProtectionSourceSnapshotInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectionSourceSnapshotInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectionSourceSnapshotInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CopyTasks == input.CopyTasks ||
                    this.CopyTasks != null &&
                    this.CopyTasks.SequenceEqual(input.CopyTasks)
                ) && 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.JobName == input.JobName ||
                    (this.JobName != null &&
                    this.JobName.Equals(input.JobName))
                ) && 
                (
                    this.JobRunId == input.JobRunId ||
                    (this.JobRunId != null &&
                    this.JobRunId.Equals(input.JobRunId))
                ) && 
                (
                    this.LastRunEndTimeUsecs == input.LastRunEndTimeUsecs ||
                    (this.LastRunEndTimeUsecs != null &&
                    this.LastRunEndTimeUsecs.Equals(input.LastRunEndTimeUsecs))
                ) && 
                (
                    this.LastRunStartTimeUsecs == input.LastRunStartTimeUsecs ||
                    (this.LastRunStartTimeUsecs != null &&
                    this.LastRunStartTimeUsecs.Equals(input.LastRunStartTimeUsecs))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.NumBytesRead == input.NumBytesRead ||
                    (this.NumBytesRead != null &&
                    this.NumBytesRead.Equals(input.NumBytesRead))
                ) && 
                (
                    this.NumLogicalBytesProtected == input.NumLogicalBytesProtected ||
                    (this.NumLogicalBytesProtected != null &&
                    this.NumLogicalBytesProtected.Equals(input.NumLogicalBytesProtected))
                ) && 
                (
                    this.PaginationCookie == input.PaginationCookie ||
                    (this.PaginationCookie != null &&
                    this.PaginationCookie.Equals(input.PaginationCookie))
                ) && 
                (
                    this.RunStatus == input.RunStatus ||
                    (this.RunStatus != null &&
                    this.RunStatus.Equals(input.RunStatus))
                ) && 
                (
                    this.RunType == input.RunType ||
                    (this.RunType != null &&
                    this.RunType.Equals(input.RunType))
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
                if (this.CopyTasks != null)
                    hashCode = hashCode * 59 + this.CopyTasks.GetHashCode();
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.JobName != null)
                    hashCode = hashCode * 59 + this.JobName.GetHashCode();
                if (this.JobRunId != null)
                    hashCode = hashCode * 59 + this.JobRunId.GetHashCode();
                if (this.LastRunEndTimeUsecs != null)
                    hashCode = hashCode * 59 + this.LastRunEndTimeUsecs.GetHashCode();
                if (this.LastRunStartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.LastRunStartTimeUsecs.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.NumBytesRead != null)
                    hashCode = hashCode * 59 + this.NumBytesRead.GetHashCode();
                if (this.NumLogicalBytesProtected != null)
                    hashCode = hashCode * 59 + this.NumLogicalBytesProtected.GetHashCode();
                if (this.PaginationCookie != null)
                    hashCode = hashCode * 59 + this.PaginationCookie.GetHashCode();
                if (this.RunStatus != null)
                    hashCode = hashCode * 59 + this.RunStatus.GetHashCode();
                if (this.RunType != null)
                    hashCode = hashCode * 59 + this.RunType.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


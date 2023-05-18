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
    /// Specifies Job Run (Snapshot) summary statistics about the specified leaf Protection Source Object (such as a VM).
    /// </summary>
    [DataContract]
    public partial class ProtectionSourcesSummaryStats :  IEquatable<ProtectionSourcesSummaryStats>
    {
        /// <summary>
        /// Specifies the Job Run status of the last Job Run protecting this Protection Source Object. &#39;kSuccess&#39; indicates that the Job Run was successful. &#39;kRunning&#39; indicates that the Job Run is currently running. &#39;kWarning&#39; indicates that the Job Run was successful but warnings were issued. &#39;kCancelled&#39; indicates that the Job Run was canceled. &#39;kError&#39; indicates the Job Run encountered an error and did not run to completion.
        /// </summary>
        /// <value>Specifies the Job Run status of the last Job Run protecting this Protection Source Object. &#39;kSuccess&#39; indicates that the Job Run was successful. &#39;kRunning&#39; indicates that the Job Run is currently running. &#39;kWarning&#39; indicates that the Job Run was successful but warnings were issued. &#39;kCancelled&#39; indicates that the Job Run was canceled. &#39;kError&#39; indicates the Job Run encountered an error and did not run to completion.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LastRunStatusEnum
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
        /// Specifies the Job Run status of the last Job Run protecting this Protection Source Object. &#39;kSuccess&#39; indicates that the Job Run was successful. &#39;kRunning&#39; indicates that the Job Run is currently running. &#39;kWarning&#39; indicates that the Job Run was successful but warnings were issued. &#39;kCancelled&#39; indicates that the Job Run was canceled. &#39;kError&#39; indicates the Job Run encountered an error and did not run to completion.
        /// </summary>
        /// <value>Specifies the Job Run status of the last Job Run protecting this Protection Source Object. &#39;kSuccess&#39; indicates that the Job Run was successful. &#39;kRunning&#39; indicates that the Job Run is currently running. &#39;kWarning&#39; indicates that the Job Run was successful but warnings were issued. &#39;kCancelled&#39; indicates that the Job Run was canceled. &#39;kError&#39; indicates the Job Run encountered an error and did not run to completion.</value>
        [DataMember(Name="lastRunStatus", EmitDefaultValue=true)]
        public LastRunStatusEnum? LastRunStatus { get; set; }
        /// <summary>
        /// Specifies the Job Run type of the last Job Run protecting this Protection Source Object. &#39;kRegular&#39; indicates an incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time. &#39;kSystem&#39; indicates system volume backup. It produces an image for bare metal recovery.
        /// </summary>
        /// <value>Specifies the Job Run type of the last Job Run protecting this Protection Source Object. &#39;kRegular&#39; indicates an incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time. &#39;kSystem&#39; indicates system volume backup. It produces an image for bare metal recovery.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LastRunTypeEnum
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
        /// Specifies the Job Run type of the last Job Run protecting this Protection Source Object. &#39;kRegular&#39; indicates an incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time. &#39;kSystem&#39; indicates system volume backup. It produces an image for bare metal recovery.
        /// </summary>
        /// <value>Specifies the Job Run type of the last Job Run protecting this Protection Source Object. &#39;kRegular&#39; indicates an incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time. &#39;kSystem&#39; indicates system volume backup. It produces an image for bare metal recovery.</value>
        [DataMember(Name="lastRunType", EmitDefaultValue=true)]
        public LastRunTypeEnum? LastRunType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionSourcesSummaryStats" /> class.
        /// </summary>
        /// <param name="firstFailedRunTimeUsecs">Specifies the start time of the first failed Job Run protecting this Protection Source Object. The time is specified as a Unix epoch Timestamp (in microseconds)..</param>
        /// <param name="firstSuccessfulRunTimeUsecs">Specifies the start time of the first successful Job Run protecting this Protection Source Object. The time is specified as a Unix epoch Timestamp (in microseconds)..</param>
        /// <param name="lastFailedRunTimeUsecs">Specifies the start time of the last failed Job Run protecting this Protection Source Object. The time is specified as a Unix epoch Timestamp (in microseconds)..</param>
        /// <param name="lastRunEndTimeUsecs">Specifies the end time of the last Job Run protecting this Protection Source Object. The time is specified as a Unix epoch Timestamp (in microseconds)..</param>
        /// <param name="lastRunErrorMsg">Specifies the error message associated with last run, if the last run has failed..</param>
        /// <param name="lastRunStartTimeUsecs">Specifies the start time of the last Job Run protecting this Protection Source Object. The time is specified as a Unix epoch Timestamp (in microseconds)..</param>
        /// <param name="lastRunStatus">Specifies the Job Run status of the last Job Run protecting this Protection Source Object. &#39;kSuccess&#39; indicates that the Job Run was successful. &#39;kRunning&#39; indicates that the Job Run is currently running. &#39;kWarning&#39; indicates that the Job Run was successful but warnings were issued. &#39;kCancelled&#39; indicates that the Job Run was canceled. &#39;kError&#39; indicates the Job Run encountered an error and did not run to completion..</param>
        /// <param name="lastRunType">Specifies the Job Run type of the last Job Run protecting this Protection Source Object. &#39;kRegular&#39; indicates an incremental (CBT) backup. Incremental backups utilizing CBT (if supported) are captured of the target protection objects. The first run of a kRegular schedule captures all the blocks. &#39;kFull&#39; indicates a full (no CBT) backup. A complete backup (all blocks) of the target protection objects are always captured and Change Block Tracking (CBT) is not utilized. &#39;kLog&#39; indicates a Database Log backup. Capture the database transaction logs to allow rolling back to a specific point in time. &#39;kSystem&#39; indicates system volume backup. It produces an image for bare metal recovery..</param>
        /// <param name="lastSuccessfulRunTimeUsecs">Specifies the start time of the last successful Job Run protecting this Protection Source Object. The time is specified as a Unix epoch Timestamp (in microseconds)..</param>
        /// <param name="numDataReadBytes">Specifies the total number of bytes read while protecting this Protection Source Object..</param>
        /// <param name="numErrors">Specifies the total number of errors reported during Job Runs of this Protection Source Object..</param>
        /// <param name="numLogicalBytesProtected">Specifies the total logical bytes protected for this Protection Source Object. The logical size is when the data is fully hydrated or expanded..</param>
        /// <param name="numSnapshots">Specifies the total number of Snapshots that are backing up this Protection Source Object..</param>
        /// <param name="numSuccessRuns">Specifies the total number of successful Job Runs protecting this Protection Source Object..</param>
        /// <param name="numWarnings">Specifies the total number of warnings reported during Job Runs of this Protection Source Object..</param>
        /// <param name="protectionSource">Specifies the leaf Protection Source Object (such as VM). Snapshot summary statistics are reported for this Protection Source Object..</param>
        /// <param name="registeredSource">Specifies the name of the Registered Source that is the top level parent of the specified Protection Source Object..</param>
        /// <param name="tenants">Specifies basic information about tenants having access to the protection job..</param>
        public ProtectionSourcesSummaryStats(long? firstFailedRunTimeUsecs = default(long?), long? firstSuccessfulRunTimeUsecs = default(long?), long? lastFailedRunTimeUsecs = default(long?), long? lastRunEndTimeUsecs = default(long?), string lastRunErrorMsg = default(string), long? lastRunStartTimeUsecs = default(long?), LastRunStatusEnum? lastRunStatus = default(LastRunStatusEnum?), LastRunTypeEnum? lastRunType = default(LastRunTypeEnum?), long? lastSuccessfulRunTimeUsecs = default(long?), long? numDataReadBytes = default(long?), int? numErrors = default(int?), long? numLogicalBytesProtected = default(long?), int? numSnapshots = default(int?), int? numSuccessRuns = default(int?), int? numWarnings = default(int?), ProtectionSource protectionSource = default(ProtectionSource), string registeredSource = default(string), List<TenantInfo> tenants = default(List<TenantInfo>))
        {
            this.FirstFailedRunTimeUsecs = firstFailedRunTimeUsecs;
            this.FirstSuccessfulRunTimeUsecs = firstSuccessfulRunTimeUsecs;
            this.LastFailedRunTimeUsecs = lastFailedRunTimeUsecs;
            this.LastRunEndTimeUsecs = lastRunEndTimeUsecs;
            this.LastRunErrorMsg = lastRunErrorMsg;
            this.LastRunStartTimeUsecs = lastRunStartTimeUsecs;
            this.LastRunStatus = lastRunStatus;
            this.LastRunType = lastRunType;
            this.LastSuccessfulRunTimeUsecs = lastSuccessfulRunTimeUsecs;
            this.NumDataReadBytes = numDataReadBytes;
            this.NumErrors = numErrors;
            this.NumLogicalBytesProtected = numLogicalBytesProtected;
            this.NumSnapshots = numSnapshots;
            this.NumSuccessRuns = numSuccessRuns;
            this.NumWarnings = numWarnings;
            this.ProtectionSource = protectionSource;
            this.RegisteredSource = registeredSource;
            this.Tenants = tenants;
            this.FirstFailedRunTimeUsecs = firstFailedRunTimeUsecs;
            this.FirstSuccessfulRunTimeUsecs = firstSuccessfulRunTimeUsecs;
            this.LastFailedRunTimeUsecs = lastFailedRunTimeUsecs;
            this.LastRunEndTimeUsecs = lastRunEndTimeUsecs;
            this.LastRunErrorMsg = lastRunErrorMsg;
            this.LastRunStartTimeUsecs = lastRunStartTimeUsecs;
            this.LastRunStatus = lastRunStatus;
            this.LastRunType = lastRunType;
            this.LastSuccessfulRunTimeUsecs = lastSuccessfulRunTimeUsecs;
            this.NumDataReadBytes = numDataReadBytes;
            this.NumErrors = numErrors;
            this.NumLogicalBytesProtected = numLogicalBytesProtected;
            this.NumSnapshots = numSnapshots;
            this.NumSuccessRuns = numSuccessRuns;
            this.NumWarnings = numWarnings;
            this.ProtectionSource = protectionSource;
            this.RegisteredSource = registeredSource;
            this.Tenants = tenants;
        }
        
        /// <summary>
        /// Specifies the start time of the first failed Job Run protecting this Protection Source Object. The time is specified as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the start time of the first failed Job Run protecting this Protection Source Object. The time is specified as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="firstFailedRunTimeUsecs", EmitDefaultValue=true)]
        public long? FirstFailedRunTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the start time of the first successful Job Run protecting this Protection Source Object. The time is specified as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the start time of the first successful Job Run protecting this Protection Source Object. The time is specified as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="firstSuccessfulRunTimeUsecs", EmitDefaultValue=true)]
        public long? FirstSuccessfulRunTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the start time of the last failed Job Run protecting this Protection Source Object. The time is specified as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the start time of the last failed Job Run protecting this Protection Source Object. The time is specified as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="lastFailedRunTimeUsecs", EmitDefaultValue=true)]
        public long? LastFailedRunTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the end time of the last Job Run protecting this Protection Source Object. The time is specified as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the end time of the last Job Run protecting this Protection Source Object. The time is specified as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="lastRunEndTimeUsecs", EmitDefaultValue=true)]
        public long? LastRunEndTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the error message associated with last run, if the last run has failed.
        /// </summary>
        /// <value>Specifies the error message associated with last run, if the last run has failed.</value>
        [DataMember(Name="lastRunErrorMsg", EmitDefaultValue=true)]
        public string LastRunErrorMsg { get; set; }

        /// <summary>
        /// Specifies the start time of the last Job Run protecting this Protection Source Object. The time is specified as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the start time of the last Job Run protecting this Protection Source Object. The time is specified as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="lastRunStartTimeUsecs", EmitDefaultValue=true)]
        public long? LastRunStartTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the start time of the last successful Job Run protecting this Protection Source Object. The time is specified as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the start time of the last successful Job Run protecting this Protection Source Object. The time is specified as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="lastSuccessfulRunTimeUsecs", EmitDefaultValue=true)]
        public long? LastSuccessfulRunTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the total number of bytes read while protecting this Protection Source Object.
        /// </summary>
        /// <value>Specifies the total number of bytes read while protecting this Protection Source Object.</value>
        [DataMember(Name="numDataReadBytes", EmitDefaultValue=true)]
        public long? NumDataReadBytes { get; set; }

        /// <summary>
        /// Specifies the total number of errors reported during Job Runs of this Protection Source Object.
        /// </summary>
        /// <value>Specifies the total number of errors reported during Job Runs of this Protection Source Object.</value>
        [DataMember(Name="numErrors", EmitDefaultValue=true)]
        public int? NumErrors { get; set; }

        /// <summary>
        /// Specifies the total logical bytes protected for this Protection Source Object. The logical size is when the data is fully hydrated or expanded.
        /// </summary>
        /// <value>Specifies the total logical bytes protected for this Protection Source Object. The logical size is when the data is fully hydrated or expanded.</value>
        [DataMember(Name="numLogicalBytesProtected", EmitDefaultValue=true)]
        public long? NumLogicalBytesProtected { get; set; }

        /// <summary>
        /// Specifies the total number of Snapshots that are backing up this Protection Source Object.
        /// </summary>
        /// <value>Specifies the total number of Snapshots that are backing up this Protection Source Object.</value>
        [DataMember(Name="numSnapshots", EmitDefaultValue=true)]
        public int? NumSnapshots { get; set; }

        /// <summary>
        /// Specifies the total number of successful Job Runs protecting this Protection Source Object.
        /// </summary>
        /// <value>Specifies the total number of successful Job Runs protecting this Protection Source Object.</value>
        [DataMember(Name="numSuccessRuns", EmitDefaultValue=true)]
        public int? NumSuccessRuns { get; set; }

        /// <summary>
        /// Specifies the total number of warnings reported during Job Runs of this Protection Source Object.
        /// </summary>
        /// <value>Specifies the total number of warnings reported during Job Runs of this Protection Source Object.</value>
        [DataMember(Name="numWarnings", EmitDefaultValue=true)]
        public int? NumWarnings { get; set; }

        /// <summary>
        /// Specifies the leaf Protection Source Object (such as VM). Snapshot summary statistics are reported for this Protection Source Object.
        /// </summary>
        /// <value>Specifies the leaf Protection Source Object (such as VM). Snapshot summary statistics are reported for this Protection Source Object.</value>
        [DataMember(Name="protectionSource", EmitDefaultValue=true)]
        public ProtectionSource ProtectionSource { get; set; }

        /// <summary>
        /// Specifies the name of the Registered Source that is the top level parent of the specified Protection Source Object.
        /// </summary>
        /// <value>Specifies the name of the Registered Source that is the top level parent of the specified Protection Source Object.</value>
        [DataMember(Name="registeredSource", EmitDefaultValue=true)]
        public string RegisteredSource { get; set; }

        /// <summary>
        /// Specifies basic information about tenants having access to the protection job.
        /// </summary>
        /// <value>Specifies basic information about tenants having access to the protection job.</value>
        [DataMember(Name="tenants", EmitDefaultValue=true)]
        public List<TenantInfo> Tenants { get; set; }

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
            return this.Equals(input as ProtectionSourcesSummaryStats);
        }

        /// <summary>
        /// Returns true if ProtectionSourcesSummaryStats instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectionSourcesSummaryStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectionSourcesSummaryStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FirstFailedRunTimeUsecs == input.FirstFailedRunTimeUsecs ||
                    (this.FirstFailedRunTimeUsecs != null &&
                    this.FirstFailedRunTimeUsecs.Equals(input.FirstFailedRunTimeUsecs))
                ) && 
                (
                    this.FirstSuccessfulRunTimeUsecs == input.FirstSuccessfulRunTimeUsecs ||
                    (this.FirstSuccessfulRunTimeUsecs != null &&
                    this.FirstSuccessfulRunTimeUsecs.Equals(input.FirstSuccessfulRunTimeUsecs))
                ) && 
                (
                    this.LastFailedRunTimeUsecs == input.LastFailedRunTimeUsecs ||
                    (this.LastFailedRunTimeUsecs != null &&
                    this.LastFailedRunTimeUsecs.Equals(input.LastFailedRunTimeUsecs))
                ) && 
                (
                    this.LastRunEndTimeUsecs == input.LastRunEndTimeUsecs ||
                    (this.LastRunEndTimeUsecs != null &&
                    this.LastRunEndTimeUsecs.Equals(input.LastRunEndTimeUsecs))
                ) && 
                (
                    this.LastRunErrorMsg == input.LastRunErrorMsg ||
                    (this.LastRunErrorMsg != null &&
                    this.LastRunErrorMsg.Equals(input.LastRunErrorMsg))
                ) && 
                (
                    this.LastRunStartTimeUsecs == input.LastRunStartTimeUsecs ||
                    (this.LastRunStartTimeUsecs != null &&
                    this.LastRunStartTimeUsecs.Equals(input.LastRunStartTimeUsecs))
                ) && 
                (
                    this.LastRunStatus == input.LastRunStatus ||
                    this.LastRunStatus.Equals(input.LastRunStatus)
                ) && 
                (
                    this.LastRunType == input.LastRunType ||
                    this.LastRunType.Equals(input.LastRunType)
                ) && 
                (
                    this.LastSuccessfulRunTimeUsecs == input.LastSuccessfulRunTimeUsecs ||
                    (this.LastSuccessfulRunTimeUsecs != null &&
                    this.LastSuccessfulRunTimeUsecs.Equals(input.LastSuccessfulRunTimeUsecs))
                ) && 
                (
                    this.NumDataReadBytes == input.NumDataReadBytes ||
                    (this.NumDataReadBytes != null &&
                    this.NumDataReadBytes.Equals(input.NumDataReadBytes))
                ) && 
                (
                    this.NumErrors == input.NumErrors ||
                    (this.NumErrors != null &&
                    this.NumErrors.Equals(input.NumErrors))
                ) && 
                (
                    this.NumLogicalBytesProtected == input.NumLogicalBytesProtected ||
                    (this.NumLogicalBytesProtected != null &&
                    this.NumLogicalBytesProtected.Equals(input.NumLogicalBytesProtected))
                ) && 
                (
                    this.NumSnapshots == input.NumSnapshots ||
                    (this.NumSnapshots != null &&
                    this.NumSnapshots.Equals(input.NumSnapshots))
                ) && 
                (
                    this.NumSuccessRuns == input.NumSuccessRuns ||
                    (this.NumSuccessRuns != null &&
                    this.NumSuccessRuns.Equals(input.NumSuccessRuns))
                ) && 
                (
                    this.NumWarnings == input.NumWarnings ||
                    (this.NumWarnings != null &&
                    this.NumWarnings.Equals(input.NumWarnings))
                ) && 
                (
                    this.ProtectionSource == input.ProtectionSource ||
                    (this.ProtectionSource != null &&
                    this.ProtectionSource.Equals(input.ProtectionSource))
                ) && 
                (
                    this.RegisteredSource == input.RegisteredSource ||
                    (this.RegisteredSource != null &&
                    this.RegisteredSource.Equals(input.RegisteredSource))
                ) && 
                (
                    this.Tenants == input.Tenants ||
                    this.Tenants != null &&
                    input.Tenants != null &&
                    this.Tenants.SequenceEqual(input.Tenants)
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
                if (this.FirstFailedRunTimeUsecs != null)
                    hashCode = hashCode * 59 + this.FirstFailedRunTimeUsecs.GetHashCode();
                if (this.FirstSuccessfulRunTimeUsecs != null)
                    hashCode = hashCode * 59 + this.FirstSuccessfulRunTimeUsecs.GetHashCode();
                if (this.LastFailedRunTimeUsecs != null)
                    hashCode = hashCode * 59 + this.LastFailedRunTimeUsecs.GetHashCode();
                if (this.LastRunEndTimeUsecs != null)
                    hashCode = hashCode * 59 + this.LastRunEndTimeUsecs.GetHashCode();
                if (this.LastRunErrorMsg != null)
                    hashCode = hashCode * 59 + this.LastRunErrorMsg.GetHashCode();
                if (this.LastRunStartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.LastRunStartTimeUsecs.GetHashCode();
                hashCode = hashCode * 59 + this.LastRunStatus.GetHashCode();
                hashCode = hashCode * 59 + this.LastRunType.GetHashCode();
                if (this.LastSuccessfulRunTimeUsecs != null)
                    hashCode = hashCode * 59 + this.LastSuccessfulRunTimeUsecs.GetHashCode();
                if (this.NumDataReadBytes != null)
                    hashCode = hashCode * 59 + this.NumDataReadBytes.GetHashCode();
                if (this.NumErrors != null)
                    hashCode = hashCode * 59 + this.NumErrors.GetHashCode();
                if (this.NumLogicalBytesProtected != null)
                    hashCode = hashCode * 59 + this.NumLogicalBytesProtected.GetHashCode();
                if (this.NumSnapshots != null)
                    hashCode = hashCode * 59 + this.NumSnapshots.GetHashCode();
                if (this.NumSuccessRuns != null)
                    hashCode = hashCode * 59 + this.NumSuccessRuns.GetHashCode();
                if (this.NumWarnings != null)
                    hashCode = hashCode * 59 + this.NumWarnings.GetHashCode();
                if (this.ProtectionSource != null)
                    hashCode = hashCode * 59 + this.ProtectionSource.GetHashCode();
                if (this.RegisteredSource != null)
                    hashCode = hashCode * 59 + this.RegisteredSource.GetHashCode();
                if (this.Tenants != null)
                    hashCode = hashCode * 59 + this.Tenants.GetHashCode();
                return hashCode;
            }
        }

    }

}


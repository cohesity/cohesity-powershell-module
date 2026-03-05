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
    /// Specifies the fields for Protection job audit Response.
    /// </summary>
    [DataContract]
    public partial class ProtectionJobAuditTrail :  IEquatable<ProtectionJobAuditTrail>
    {
        /// <summary>
        /// Defines Changes
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChangesEnum
        {
            /// <summary>
            /// Enum KProtectionJobName for value: kProtectionJobName
            /// </summary>
            [EnumMember(Value = "kProtectionJobName")]
            KProtectionJobName = 1,

            /// <summary>
            /// Enum KProtectionJobDescription for value: kProtectionJobDescription
            /// </summary>
            [EnumMember(Value = "kProtectionJobDescription")]
            KProtectionJobDescription = 2,

            /// <summary>
            /// Enum KProtectionJobSources for value: kProtectionJobSources
            /// </summary>
            [EnumMember(Value = "kProtectionJobSources")]
            KProtectionJobSources = 3

        }


        /// <summary>
        /// Specifies the list of changed values in a Protection Job. kProtectionJobName implies that protection job has change in the name field kProtectionJobDescription implies that protection job has change in the description field. kProtectionJobSources implies that protection job has change in the source field. kProtectionJobSchedule implies that protection job has change in the schedule field. kProtectionJobFullSchedule implies that protection job has change in the full schedule field. kProtectionJobRetrySettings implies that protection job has change in the retry settings. kProtectionJobRetentionPolicy implies that protection job has change in the retention policy. kProtectionJobIndexingPolicy implies that protection job has change in the indexing policy. kProtectionJobAlertingPolicy implies that protection job has change in the alerting policy. kProtectionJobPriority implies that protection job has change in the alerting policy. kProtectionJobQuiesce implies that protection job has change in the Quiesce. kProtectionJobSla implies that protection job has change in the SLA settings. kProtectionJobPolicyId implies that protection job has change in the poilcy Id settings. kProtectionJobTimezone implies that protection job has change in the timezone settings. kProtectionJobFutureRunsPaused implies that protection job has change in the future run settings. kProtectionJobFutureRunsResumed implies that protection job has change in the future run resume settings. kSnapshotTargetPolicy implies that protection job has change in the snapshot target policy settings. kProtectionJobQOS implies that protection job has change in QOS settings. kProtectionJobInvalidField implies that the changed field is invalid. kProtectionJobPausedNoteChange implies that protection job has change in the paused note settings. kProtectionJobSchedule, kProtectionJobFullSchedule, kProtectionJobRetrySettings, kProtectionJobRetentionPolicy, kProtectionJobIndexingPolicy, kProtectionJobAlertingPolicy, kProtectionJobPriority, kProtectionJobQuiesce, kProtectionJobSla, kProtectionJobPolicyId, kProtectionJobTimezone, kProtectionJobFutureRunsPaused, kProtectionJobFutureRunsResumed, kSnapshotTargetPolicy, kProtectionJobBlackoutWindow, kProtectionJobQOS, kProtectionJobInvalidField, kProtectionJobPausedNoteChange
        /// </summary>
        /// <value>Specifies the list of changed values in a Protection Job. kProtectionJobName implies that protection job has change in the name field kProtectionJobDescription implies that protection job has change in the description field. kProtectionJobSources implies that protection job has change in the source field. kProtectionJobSchedule implies that protection job has change in the schedule field. kProtectionJobFullSchedule implies that protection job has change in the full schedule field. kProtectionJobRetrySettings implies that protection job has change in the retry settings. kProtectionJobRetentionPolicy implies that protection job has change in the retention policy. kProtectionJobIndexingPolicy implies that protection job has change in the indexing policy. kProtectionJobAlertingPolicy implies that protection job has change in the alerting policy. kProtectionJobPriority implies that protection job has change in the alerting policy. kProtectionJobQuiesce implies that protection job has change in the Quiesce. kProtectionJobSla implies that protection job has change in the SLA settings. kProtectionJobPolicyId implies that protection job has change in the poilcy Id settings. kProtectionJobTimezone implies that protection job has change in the timezone settings. kProtectionJobFutureRunsPaused implies that protection job has change in the future run settings. kProtectionJobFutureRunsResumed implies that protection job has change in the future run resume settings. kSnapshotTargetPolicy implies that protection job has change in the snapshot target policy settings. kProtectionJobQOS implies that protection job has change in QOS settings. kProtectionJobInvalidField implies that the changed field is invalid. kProtectionJobPausedNoteChange implies that protection job has change in the paused note settings. kProtectionJobSchedule, kProtectionJobFullSchedule, kProtectionJobRetrySettings, kProtectionJobRetentionPolicy, kProtectionJobIndexingPolicy, kProtectionJobAlertingPolicy, kProtectionJobPriority, kProtectionJobQuiesce, kProtectionJobSla, kProtectionJobPolicyId, kProtectionJobTimezone, kProtectionJobFutureRunsPaused, kProtectionJobFutureRunsResumed, kSnapshotTargetPolicy, kProtectionJobBlackoutWindow, kProtectionJobQOS, kProtectionJobInvalidField, kProtectionJobPausedNoteChange</value>
        [DataMember(Name="changes", EmitDefaultValue=true)]
        public List<ChangesEnum> Changes { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionJobAuditTrail" /> class.
        /// </summary>
        /// <param name="after">after.</param>
        /// <param name="before">before.</param>
        /// <param name="changes">Specifies the list of changed values in a Protection Job. kProtectionJobName implies that protection job has change in the name field kProtectionJobDescription implies that protection job has change in the description field. kProtectionJobSources implies that protection job has change in the source field. kProtectionJobSchedule implies that protection job has change in the schedule field. kProtectionJobFullSchedule implies that protection job has change in the full schedule field. kProtectionJobRetrySettings implies that protection job has change in the retry settings. kProtectionJobRetentionPolicy implies that protection job has change in the retention policy. kProtectionJobIndexingPolicy implies that protection job has change in the indexing policy. kProtectionJobAlertingPolicy implies that protection job has change in the alerting policy. kProtectionJobPriority implies that protection job has change in the alerting policy. kProtectionJobQuiesce implies that protection job has change in the Quiesce. kProtectionJobSla implies that protection job has change in the SLA settings. kProtectionJobPolicyId implies that protection job has change in the poilcy Id settings. kProtectionJobTimezone implies that protection job has change in the timezone settings. kProtectionJobFutureRunsPaused implies that protection job has change in the future run settings. kProtectionJobFutureRunsResumed implies that protection job has change in the future run resume settings. kSnapshotTargetPolicy implies that protection job has change in the snapshot target policy settings. kProtectionJobQOS implies that protection job has change in QOS settings. kProtectionJobInvalidField implies that the changed field is invalid. kProtectionJobPausedNoteChange implies that protection job has change in the paused note settings. kProtectionJobSchedule, kProtectionJobFullSchedule, kProtectionJobRetrySettings, kProtectionJobRetentionPolicy, kProtectionJobIndexingPolicy, kProtectionJobAlertingPolicy, kProtectionJobPriority, kProtectionJobQuiesce, kProtectionJobSla, kProtectionJobPolicyId, kProtectionJobTimezone, kProtectionJobFutureRunsPaused, kProtectionJobFutureRunsResumed, kSnapshotTargetPolicy, kProtectionJobBlackoutWindow, kProtectionJobQOS, kProtectionJobInvalidField, kProtectionJobPausedNoteChange.</param>
        public ProtectionJobAuditTrail(ProtectionJob after = default(ProtectionJob), ProtectionJob before = default(ProtectionJob), List<ChangesEnum> changes = default(List<ChangesEnum>))
        {
            this.Changes = changes;
            this.After = after;
            this.Before = before;
            this.Changes = changes;
        }
        
        /// <summary>
        /// Gets or Sets After
        /// </summary>
        [DataMember(Name="after", EmitDefaultValue=false)]
        public ProtectionJob After { get; set; }

        /// <summary>
        /// Gets or Sets Before
        /// </summary>
        [DataMember(Name="before", EmitDefaultValue=false)]
        public ProtectionJob Before { get; set; }

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
            return this.Equals(input as ProtectionJobAuditTrail);
        }

        /// <summary>
        /// Returns true if ProtectionJobAuditTrail instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectionJobAuditTrail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectionJobAuditTrail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.After == input.After ||
                    (this.After != null &&
                    this.After.Equals(input.After))
                ) && 
                (
                    this.Before == input.Before ||
                    (this.Before != null &&
                    this.Before.Equals(input.Before))
                ) && 
                (
                    this.Changes == input.Changes ||
                    this.Changes.SequenceEqual(input.Changes)
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
                if (this.After != null)
                    hashCode = hashCode * 59 + this.After.GetHashCode();
                if (this.Before != null)
                    hashCode = hashCode * 59 + this.Before.GetHashCode();
                hashCode = hashCode * 59 + this.Changes.GetHashCode();
                return hashCode;
            }
        }

    }

}


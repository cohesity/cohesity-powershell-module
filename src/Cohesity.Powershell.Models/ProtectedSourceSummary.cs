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
    /// ProtectedSourceSummary is the summary of all the Protection Runs for the Protection Jobs using the Specified Protection Policy. This is only populated for a policy of type kRPO.
    /// </summary>
    [DataContract]
    public partial class ProtectedSourceSummary :  IEquatable<ProtectedSourceSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectedSourceSummary" /> class.
        /// </summary>
        /// <param name="backupRun">backupRun.</param>
        /// <param name="copyRuns">Specifies details about the Copy tasks of the Job Run. A Copy task copies the captured snapshots to an external target or a Remote Cohesity Cluster..</param>
        /// <param name="isPaused">Specifies the status of the backup job..</param>
        /// <param name="nextProtectionRunTimeUsecs">Specifies the time at which the next Protection Run is scheduled for the given Protection Source in Unix epoch Time (microseconds)..</param>
        /// <param name="protectedSourceUid">protectedSourceUid.</param>
        /// <param name="protectionSource">protectionSource.</param>
        /// <param name="sourceParameters">Specifies additional special settings for a single Protected Source..</param>
        public ProtectedSourceSummary(BackupRun backupRun = default(BackupRun), List<CopyRun> copyRuns = default(List<CopyRun>), bool? isPaused = default(bool?), long? nextProtectionRunTimeUsecs = default(long?), UniversalId protectedSourceUid = default(UniversalId), ProtectionSource protectionSource = default(ProtectionSource), List<SourceSpecialParameter> sourceParameters = default(List<SourceSpecialParameter>))
        {
            this.CopyRuns = copyRuns;
            this.IsPaused = isPaused;
            this.NextProtectionRunTimeUsecs = nextProtectionRunTimeUsecs;
            this.SourceParameters = sourceParameters;
            this.BackupRun = backupRun;
            this.CopyRuns = copyRuns;
            this.IsPaused = isPaused;
            this.NextProtectionRunTimeUsecs = nextProtectionRunTimeUsecs;
            this.ProtectedSourceUid = protectedSourceUid;
            this.ProtectionSource = protectionSource;
            this.SourceParameters = sourceParameters;
        }
        
        /// <summary>
        /// Gets or Sets BackupRun
        /// </summary>
        [DataMember(Name="backupRun", EmitDefaultValue=false)]
        public BackupRun BackupRun { get; set; }

        /// <summary>
        /// Specifies details about the Copy tasks of the Job Run. A Copy task copies the captured snapshots to an external target or a Remote Cohesity Cluster.
        /// </summary>
        /// <value>Specifies details about the Copy tasks of the Job Run. A Copy task copies the captured snapshots to an external target or a Remote Cohesity Cluster.</value>
        [DataMember(Name="copyRuns", EmitDefaultValue=true)]
        public List<CopyRun> CopyRuns { get; set; }

        /// <summary>
        /// Specifies the status of the backup job.
        /// </summary>
        /// <value>Specifies the status of the backup job.</value>
        [DataMember(Name="isPaused", EmitDefaultValue=true)]
        public bool? IsPaused { get; set; }

        /// <summary>
        /// Specifies the time at which the next Protection Run is scheduled for the given Protection Source in Unix epoch Time (microseconds).
        /// </summary>
        /// <value>Specifies the time at which the next Protection Run is scheduled for the given Protection Source in Unix epoch Time (microseconds).</value>
        [DataMember(Name="nextProtectionRunTimeUsecs", EmitDefaultValue=true)]
        public long? NextProtectionRunTimeUsecs { get; set; }

        /// <summary>
        /// Gets or Sets ProtectedSourceUid
        /// </summary>
        [DataMember(Name="protectedSourceUid", EmitDefaultValue=false)]
        public UniversalId ProtectedSourceUid { get; set; }

        /// <summary>
        /// Gets or Sets ProtectionSource
        /// </summary>
        [DataMember(Name="protectionSource", EmitDefaultValue=false)]
        public ProtectionSource ProtectionSource { get; set; }

        /// <summary>
        /// Specifies additional special settings for a single Protected Source.
        /// </summary>
        /// <value>Specifies additional special settings for a single Protected Source.</value>
        [DataMember(Name="sourceParameters", EmitDefaultValue=true)]
        public List<SourceSpecialParameter> SourceParameters { get; set; }

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
            return this.Equals(input as ProtectedSourceSummary);
        }

        /// <summary>
        /// Returns true if ProtectedSourceSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectedSourceSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectedSourceSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackupRun == input.BackupRun ||
                    (this.BackupRun != null &&
                    this.BackupRun.Equals(input.BackupRun))
                ) && 
                (
                    this.CopyRuns == input.CopyRuns ||
                    this.CopyRuns != null &&
                    input.CopyRuns != null &&
                    this.CopyRuns.SequenceEqual(input.CopyRuns)
                ) && 
                (
                    this.IsPaused == input.IsPaused ||
                    (this.IsPaused != null &&
                    this.IsPaused.Equals(input.IsPaused))
                ) && 
                (
                    this.NextProtectionRunTimeUsecs == input.NextProtectionRunTimeUsecs ||
                    (this.NextProtectionRunTimeUsecs != null &&
                    this.NextProtectionRunTimeUsecs.Equals(input.NextProtectionRunTimeUsecs))
                ) && 
                (
                    this.ProtectedSourceUid == input.ProtectedSourceUid ||
                    (this.ProtectedSourceUid != null &&
                    this.ProtectedSourceUid.Equals(input.ProtectedSourceUid))
                ) && 
                (
                    this.ProtectionSource == input.ProtectionSource ||
                    (this.ProtectionSource != null &&
                    this.ProtectionSource.Equals(input.ProtectionSource))
                ) && 
                (
                    this.SourceParameters == input.SourceParameters ||
                    this.SourceParameters != null &&
                    input.SourceParameters != null &&
                    this.SourceParameters.SequenceEqual(input.SourceParameters)
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
                if (this.BackupRun != null)
                    hashCode = hashCode * 59 + this.BackupRun.GetHashCode();
                if (this.CopyRuns != null)
                    hashCode = hashCode * 59 + this.CopyRuns.GetHashCode();
                if (this.IsPaused != null)
                    hashCode = hashCode * 59 + this.IsPaused.GetHashCode();
                if (this.NextProtectionRunTimeUsecs != null)
                    hashCode = hashCode * 59 + this.NextProtectionRunTimeUsecs.GetHashCode();
                if (this.ProtectedSourceUid != null)
                    hashCode = hashCode * 59 + this.ProtectedSourceUid.GetHashCode();
                if (this.ProtectionSource != null)
                    hashCode = hashCode * 59 + this.ProtectionSource.GetHashCode();
                if (this.SourceParameters != null)
                    hashCode = hashCode * 59 + this.SourceParameters.GetHashCode();
                return hashCode;
            }
        }

    }

}


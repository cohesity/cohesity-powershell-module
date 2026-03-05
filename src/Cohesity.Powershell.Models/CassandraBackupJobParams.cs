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
    /// Contains any additional cassandra environment specific backup params at the job level.
    /// </summary>
    [DataContract]
    public partial class CassandraBackupJobParams :  IEquatable<CassandraBackupJobParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CassandraBackupJobParams" /> class.
        /// </summary>
        /// <param name="cassandraAdditionalInfo">cassandraAdditionalInfo.</param>
        /// <param name="graphHandlingEnabled">whether special graph handling is enabled.</param>
        /// <param name="isOnlyLogBackupJob">If this backup job is only responsible for the log backups. Presently this is used for cassandra log backups..</param>
        /// <param name="isSystemKsBackup">Whether this is a system keyspace backup.</param>
        /// <param name="jobStartTimeInUsecs">Start time of the current job (slave start time).</param>
        /// <param name="makePrimaryLogBackup">Make source primary for log-backup in this job run.</param>
        /// <param name="preserveSourceSnapshotForInstantRecovery">Keep snapshot files on source intact for instant recovery.</param>
        /// <param name="previousJobEndTimeInUsecs">End time of the previous job (set in snapshot_info).</param>
        /// <param name="retentionPeriodInSecs">Retention period in seconds. This is read from the policy currently attached to the protection job. This field is used only in case of log backups and ignored for other backups..</param>
        /// <param name="rolesGflagEnabled">Whether cassandra roles backup/restore is enabled or not..</param>
        /// <param name="selectedDataCenterVec">The data centers selected for backup..</param>
        public CassandraBackupJobParams(CassandraAdditionalParams cassandraAdditionalInfo = default(CassandraAdditionalParams), bool? graphHandlingEnabled = default(bool?), bool? isOnlyLogBackupJob = default(bool?), bool? isSystemKsBackup = default(bool?), long? jobStartTimeInUsecs = default(long?), bool? makePrimaryLogBackup = default(bool?), bool? preserveSourceSnapshotForInstantRecovery = default(bool?), long? previousJobEndTimeInUsecs = default(long?), long? retentionPeriodInSecs = default(long?), bool? rolesGflagEnabled = default(bool?), List<string> selectedDataCenterVec = default(List<string>))
        {
            this.GraphHandlingEnabled = graphHandlingEnabled;
            this.IsOnlyLogBackupJob = isOnlyLogBackupJob;
            this.IsSystemKsBackup = isSystemKsBackup;
            this.JobStartTimeInUsecs = jobStartTimeInUsecs;
            this.MakePrimaryLogBackup = makePrimaryLogBackup;
            this.PreserveSourceSnapshotForInstantRecovery = preserveSourceSnapshotForInstantRecovery;
            this.PreviousJobEndTimeInUsecs = previousJobEndTimeInUsecs;
            this.RetentionPeriodInSecs = retentionPeriodInSecs;
            this.RolesGflagEnabled = rolesGflagEnabled;
            this.SelectedDataCenterVec = selectedDataCenterVec;
            this.CassandraAdditionalInfo = cassandraAdditionalInfo;
            this.GraphHandlingEnabled = graphHandlingEnabled;
            this.IsOnlyLogBackupJob = isOnlyLogBackupJob;
            this.IsSystemKsBackup = isSystemKsBackup;
            this.JobStartTimeInUsecs = jobStartTimeInUsecs;
            this.MakePrimaryLogBackup = makePrimaryLogBackup;
            this.PreserveSourceSnapshotForInstantRecovery = preserveSourceSnapshotForInstantRecovery;
            this.PreviousJobEndTimeInUsecs = previousJobEndTimeInUsecs;
            this.RetentionPeriodInSecs = retentionPeriodInSecs;
            this.RolesGflagEnabled = rolesGflagEnabled;
            this.SelectedDataCenterVec = selectedDataCenterVec;
        }
        
        /// <summary>
        /// Gets or Sets CassandraAdditionalInfo
        /// </summary>
        [DataMember(Name="cassandraAdditionalInfo", EmitDefaultValue=false)]
        public CassandraAdditionalParams CassandraAdditionalInfo { get; set; }

        /// <summary>
        /// whether special graph handling is enabled
        /// </summary>
        /// <value>whether special graph handling is enabled</value>
        [DataMember(Name="graphHandlingEnabled", EmitDefaultValue=true)]
        public bool? GraphHandlingEnabled { get; set; }

        /// <summary>
        /// If this backup job is only responsible for the log backups. Presently this is used for cassandra log backups.
        /// </summary>
        /// <value>If this backup job is only responsible for the log backups. Presently this is used for cassandra log backups.</value>
        [DataMember(Name="isOnlyLogBackupJob", EmitDefaultValue=true)]
        public bool? IsOnlyLogBackupJob { get; set; }

        /// <summary>
        /// Whether this is a system keyspace backup
        /// </summary>
        /// <value>Whether this is a system keyspace backup</value>
        [DataMember(Name="isSystemKsBackup", EmitDefaultValue=true)]
        public bool? IsSystemKsBackup { get; set; }

        /// <summary>
        /// Start time of the current job (slave start time)
        /// </summary>
        /// <value>Start time of the current job (slave start time)</value>
        [DataMember(Name="jobStartTimeInUsecs", EmitDefaultValue=true)]
        public long? JobStartTimeInUsecs { get; set; }

        /// <summary>
        /// Make source primary for log-backup in this job run
        /// </summary>
        /// <value>Make source primary for log-backup in this job run</value>
        [DataMember(Name="makePrimaryLogBackup", EmitDefaultValue=true)]
        public bool? MakePrimaryLogBackup { get; set; }

        /// <summary>
        /// Keep snapshot files on source intact for instant recovery
        /// </summary>
        /// <value>Keep snapshot files on source intact for instant recovery</value>
        [DataMember(Name="preserveSourceSnapshotForInstantRecovery", EmitDefaultValue=true)]
        public bool? PreserveSourceSnapshotForInstantRecovery { get; set; }

        /// <summary>
        /// End time of the previous job (set in snapshot_info)
        /// </summary>
        /// <value>End time of the previous job (set in snapshot_info)</value>
        [DataMember(Name="previousJobEndTimeInUsecs", EmitDefaultValue=true)]
        public long? PreviousJobEndTimeInUsecs { get; set; }

        /// <summary>
        /// Retention period in seconds. This is read from the policy currently attached to the protection job. This field is used only in case of log backups and ignored for other backups.
        /// </summary>
        /// <value>Retention period in seconds. This is read from the policy currently attached to the protection job. This field is used only in case of log backups and ignored for other backups.</value>
        [DataMember(Name="retentionPeriodInSecs", EmitDefaultValue=true)]
        public long? RetentionPeriodInSecs { get; set; }

        /// <summary>
        /// Whether cassandra roles backup/restore is enabled or not.
        /// </summary>
        /// <value>Whether cassandra roles backup/restore is enabled or not.</value>
        [DataMember(Name="rolesGflagEnabled", EmitDefaultValue=true)]
        public bool? RolesGflagEnabled { get; set; }

        /// <summary>
        /// The data centers selected for backup.
        /// </summary>
        /// <value>The data centers selected for backup.</value>
        [DataMember(Name="selectedDataCenterVec", EmitDefaultValue=true)]
        public List<string> SelectedDataCenterVec { get; set; }

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
            return this.Equals(input as CassandraBackupJobParams);
        }

        /// <summary>
        /// Returns true if CassandraBackupJobParams instances are equal
        /// </summary>
        /// <param name="input">Instance of CassandraBackupJobParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CassandraBackupJobParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CassandraAdditionalInfo == input.CassandraAdditionalInfo ||
                    (this.CassandraAdditionalInfo != null &&
                    this.CassandraAdditionalInfo.Equals(input.CassandraAdditionalInfo))
                ) && 
                (
                    this.GraphHandlingEnabled == input.GraphHandlingEnabled ||
                    (this.GraphHandlingEnabled != null &&
                    this.GraphHandlingEnabled.Equals(input.GraphHandlingEnabled))
                ) && 
                (
                    this.IsOnlyLogBackupJob == input.IsOnlyLogBackupJob ||
                    (this.IsOnlyLogBackupJob != null &&
                    this.IsOnlyLogBackupJob.Equals(input.IsOnlyLogBackupJob))
                ) && 
                (
                    this.IsSystemKsBackup == input.IsSystemKsBackup ||
                    (this.IsSystemKsBackup != null &&
                    this.IsSystemKsBackup.Equals(input.IsSystemKsBackup))
                ) && 
                (
                    this.JobStartTimeInUsecs == input.JobStartTimeInUsecs ||
                    (this.JobStartTimeInUsecs != null &&
                    this.JobStartTimeInUsecs.Equals(input.JobStartTimeInUsecs))
                ) && 
                (
                    this.MakePrimaryLogBackup == input.MakePrimaryLogBackup ||
                    (this.MakePrimaryLogBackup != null &&
                    this.MakePrimaryLogBackup.Equals(input.MakePrimaryLogBackup))
                ) && 
                (
                    this.PreserveSourceSnapshotForInstantRecovery == input.PreserveSourceSnapshotForInstantRecovery ||
                    (this.PreserveSourceSnapshotForInstantRecovery != null &&
                    this.PreserveSourceSnapshotForInstantRecovery.Equals(input.PreserveSourceSnapshotForInstantRecovery))
                ) && 
                (
                    this.PreviousJobEndTimeInUsecs == input.PreviousJobEndTimeInUsecs ||
                    (this.PreviousJobEndTimeInUsecs != null &&
                    this.PreviousJobEndTimeInUsecs.Equals(input.PreviousJobEndTimeInUsecs))
                ) && 
                (
                    this.RetentionPeriodInSecs == input.RetentionPeriodInSecs ||
                    (this.RetentionPeriodInSecs != null &&
                    this.RetentionPeriodInSecs.Equals(input.RetentionPeriodInSecs))
                ) && 
                (
                    this.RolesGflagEnabled == input.RolesGflagEnabled ||
                    (this.RolesGflagEnabled != null &&
                    this.RolesGflagEnabled.Equals(input.RolesGflagEnabled))
                ) && 
                (
                    this.SelectedDataCenterVec == input.SelectedDataCenterVec ||
                    this.SelectedDataCenterVec != null &&
                    input.SelectedDataCenterVec != null &&
                    this.SelectedDataCenterVec.SequenceEqual(input.SelectedDataCenterVec)
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
                if (this.CassandraAdditionalInfo != null)
                    hashCode = hashCode * 59 + this.CassandraAdditionalInfo.GetHashCode();
                if (this.GraphHandlingEnabled != null)
                    hashCode = hashCode * 59 + this.GraphHandlingEnabled.GetHashCode();
                if (this.IsOnlyLogBackupJob != null)
                    hashCode = hashCode * 59 + this.IsOnlyLogBackupJob.GetHashCode();
                if (this.IsSystemKsBackup != null)
                    hashCode = hashCode * 59 + this.IsSystemKsBackup.GetHashCode();
                if (this.JobStartTimeInUsecs != null)
                    hashCode = hashCode * 59 + this.JobStartTimeInUsecs.GetHashCode();
                if (this.MakePrimaryLogBackup != null)
                    hashCode = hashCode * 59 + this.MakePrimaryLogBackup.GetHashCode();
                if (this.PreserveSourceSnapshotForInstantRecovery != null)
                    hashCode = hashCode * 59 + this.PreserveSourceSnapshotForInstantRecovery.GetHashCode();
                if (this.PreviousJobEndTimeInUsecs != null)
                    hashCode = hashCode * 59 + this.PreviousJobEndTimeInUsecs.GetHashCode();
                if (this.RetentionPeriodInSecs != null)
                    hashCode = hashCode * 59 + this.RetentionPeriodInSecs.GetHashCode();
                if (this.RolesGflagEnabled != null)
                    hashCode = hashCode * 59 + this.RolesGflagEnabled.GetHashCode();
                if (this.SelectedDataCenterVec != null)
                    hashCode = hashCode * 59 + this.SelectedDataCenterVec.GetHashCode();
                return hashCode;
            }
        }

    }

}


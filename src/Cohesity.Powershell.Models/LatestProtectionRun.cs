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
    /// Specifies the information about the latest Protection Run.
    /// </summary>
    [DataContract]
    public partial class LatestProtectionRun :  IEquatable<LatestProtectionRun>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LatestProtectionRun" /> class.
        /// </summary>
        /// <param name="backupRun">backupRun.</param>
        /// <param name="changeEventId">Specifies the event id which caused last update on this object..</param>
        /// <param name="copyRun">copyRun.</param>
        /// <param name="jobRunId">Specifies job run id of the latest successful Protection Job Run..</param>
        /// <param name="protectionJobRunUid">protectionJobRunUid.</param>
        /// <param name="snapshotTarget">Specifies the cluster id in case of local or replication snapshots and name of location in case of archival snapshots..</param>
        /// <param name="snapshotTargetType">Specifies the snapshot target type of the latest snapshot..</param>
        /// <param name="taskStatus">Specifies the task status of the Protecion Job Run in the final attempt..</param>
        /// <param name="uuid">Specifies the unique id of the Protection Source for which a snapshot is taken..</param>
        public LatestProtectionRun(SourceBackupStatus backupRun = default(SourceBackupStatus), long? changeEventId = default(long?), CopyRun copyRun = default(CopyRun), long? jobRunId = default(long?), RunUid protectionJobRunUid = default(RunUid), string snapshotTarget = default(string), int? snapshotTargetType = default(int?), int? taskStatus = default(int?), string uuid = default(string))
        {
            this.ChangeEventId = changeEventId;
            this.JobRunId = jobRunId;
            this.SnapshotTarget = snapshotTarget;
            this.SnapshotTargetType = snapshotTargetType;
            this.TaskStatus = taskStatus;
            this.Uuid = uuid;
            this.BackupRun = backupRun;
            this.ChangeEventId = changeEventId;
            this.CopyRun = copyRun;
            this.JobRunId = jobRunId;
            this.ProtectionJobRunUid = protectionJobRunUid;
            this.SnapshotTarget = snapshotTarget;
            this.SnapshotTargetType = snapshotTargetType;
            this.TaskStatus = taskStatus;
            this.Uuid = uuid;
        }
        
        /// <summary>
        /// Gets or Sets BackupRun
        /// </summary>
        [DataMember(Name="backupRun", EmitDefaultValue=false)]
        public SourceBackupStatus BackupRun { get; set; }

        /// <summary>
        /// Specifies the event id which caused last update on this object.
        /// </summary>
        /// <value>Specifies the event id which caused last update on this object.</value>
        [DataMember(Name="changeEventId", EmitDefaultValue=true)]
        public long? ChangeEventId { get; set; }

        /// <summary>
        /// Gets or Sets CopyRun
        /// </summary>
        [DataMember(Name="copyRun", EmitDefaultValue=false)]
        public CopyRun CopyRun { get; set; }

        /// <summary>
        /// Specifies job run id of the latest successful Protection Job Run.
        /// </summary>
        /// <value>Specifies job run id of the latest successful Protection Job Run.</value>
        [DataMember(Name="jobRunId", EmitDefaultValue=true)]
        public long? JobRunId { get; set; }

        /// <summary>
        /// Gets or Sets ProtectionJobRunUid
        /// </summary>
        [DataMember(Name="protectionJobRunUid", EmitDefaultValue=false)]
        public RunUid ProtectionJobRunUid { get; set; }

        /// <summary>
        /// Specifies the cluster id in case of local or replication snapshots and name of location in case of archival snapshots.
        /// </summary>
        /// <value>Specifies the cluster id in case of local or replication snapshots and name of location in case of archival snapshots.</value>
        [DataMember(Name="snapshotTarget", EmitDefaultValue=true)]
        public string SnapshotTarget { get; set; }

        /// <summary>
        /// Specifies the snapshot target type of the latest snapshot.
        /// </summary>
        /// <value>Specifies the snapshot target type of the latest snapshot.</value>
        [DataMember(Name="snapshotTargetType", EmitDefaultValue=true)]
        public int? SnapshotTargetType { get; set; }

        /// <summary>
        /// Specifies the task status of the Protecion Job Run in the final attempt.
        /// </summary>
        /// <value>Specifies the task status of the Protecion Job Run in the final attempt.</value>
        [DataMember(Name="taskStatus", EmitDefaultValue=true)]
        public int? TaskStatus { get; set; }

        /// <summary>
        /// Specifies the unique id of the Protection Source for which a snapshot is taken.
        /// </summary>
        /// <value>Specifies the unique id of the Protection Source for which a snapshot is taken.</value>
        [DataMember(Name="uuid", EmitDefaultValue=true)]
        public string Uuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LatestProtectionRun {\n");
            sb.Append("  BackupRun: ").Append(BackupRun).Append("\n");
            sb.Append("  ChangeEventId: ").Append(ChangeEventId).Append("\n");
            sb.Append("  CopyRun: ").Append(CopyRun).Append("\n");
            sb.Append("  JobRunId: ").Append(JobRunId).Append("\n");
            sb.Append("  ProtectionJobRunUid: ").Append(ProtectionJobRunUid).Append("\n");
            sb.Append("  SnapshotTarget: ").Append(SnapshotTarget).Append("\n");
            sb.Append("  SnapshotTargetType: ").Append(SnapshotTargetType).Append("\n");
            sb.Append("  TaskStatus: ").Append(TaskStatus).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
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
            return this.Equals(input as LatestProtectionRun);
        }

        /// <summary>
        /// Returns true if LatestProtectionRun instances are equal
        /// </summary>
        /// <param name="input">Instance of LatestProtectionRun to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LatestProtectionRun input)
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
                    this.ChangeEventId == input.ChangeEventId ||
                    (this.ChangeEventId != null &&
                    this.ChangeEventId.Equals(input.ChangeEventId))
                ) && 
                (
                    this.CopyRun == input.CopyRun ||
                    (this.CopyRun != null &&
                    this.CopyRun.Equals(input.CopyRun))
                ) && 
                (
                    this.JobRunId == input.JobRunId ||
                    (this.JobRunId != null &&
                    this.JobRunId.Equals(input.JobRunId))
                ) && 
                (
                    this.ProtectionJobRunUid == input.ProtectionJobRunUid ||
                    (this.ProtectionJobRunUid != null &&
                    this.ProtectionJobRunUid.Equals(input.ProtectionJobRunUid))
                ) && 
                (
                    this.SnapshotTarget == input.SnapshotTarget ||
                    (this.SnapshotTarget != null &&
                    this.SnapshotTarget.Equals(input.SnapshotTarget))
                ) && 
                (
                    this.SnapshotTargetType == input.SnapshotTargetType ||
                    (this.SnapshotTargetType != null &&
                    this.SnapshotTargetType.Equals(input.SnapshotTargetType))
                ) && 
                (
                    this.TaskStatus == input.TaskStatus ||
                    (this.TaskStatus != null &&
                    this.TaskStatus.Equals(input.TaskStatus))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
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
                if (this.ChangeEventId != null)
                    hashCode = hashCode * 59 + this.ChangeEventId.GetHashCode();
                if (this.CopyRun != null)
                    hashCode = hashCode * 59 + this.CopyRun.GetHashCode();
                if (this.JobRunId != null)
                    hashCode = hashCode * 59 + this.JobRunId.GetHashCode();
                if (this.ProtectionJobRunUid != null)
                    hashCode = hashCode * 59 + this.ProtectionJobRunUid.GetHashCode();
                if (this.SnapshotTarget != null)
                    hashCode = hashCode * 59 + this.SnapshotTarget.GetHashCode();
                if (this.SnapshotTargetType != null)
                    hashCode = hashCode * 59 + this.SnapshotTargetType.GetHashCode();
                if (this.TaskStatus != null)
                    hashCode = hashCode * 59 + this.TaskStatus.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                return hashCode;
            }
        }

    }

}

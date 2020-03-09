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
    /// RestoreObject
    /// </summary>
    [DataContract]
    public partial class RestoreObject :  IEquatable<RestoreObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreObject" /> class.
        /// </summary>
        /// <param name="archivalTarget">archivalTarget.</param>
        /// <param name="attemptNum">The attempt number of the job run to restore from..</param>
        /// <param name="cloudDeployTarget">cloudDeployTarget.</param>
        /// <param name="cloudReplicationTarget">cloudReplicationTarget.</param>
        /// <param name="entity">entity.</param>
        /// <param name="jobId">The job id from which to restore. This is used while communicating with yoda..</param>
        /// <param name="jobInstanceId">Id identifying a specific run to restore from. If this is not specified, and we need to restore from a run, the latest run is used. NOTE: This must be specified for RestoreFiles, RecoverDisks and GetVirtualDisks APIs..</param>
        /// <param name="jobUid">jobUid.</param>
        /// <param name="parentSource">parentSource.</param>
        /// <param name="pointInTimeRestoreTimeUsecs">The time to which the object needs to be restored. If this is not set, then the object will be restored to the full/incremental snapshot. This is applicable only if the object is protected using CDP..</param>
        /// <param name="restoreAcropolisVmParam">restoreAcropolisVmParam.</param>
        /// <param name="snapshotRelativeDirPath">The relative path to the directory containing the entity&#39;s snapshot..</param>
        /// <param name="startTimeUsecs">The start time of the specific job run. Iff &#39;job_instance_id&#39; is set, this field must be set. In-memory indices on the Magneto master are laid-out by the start time of the job, and this is how the master pulls up a specific run. NOTE: This must be specified for RestoreFiles, RecoverDisks and GetVirtualDisks APIs.</param>
        /// <param name="viewName">The name of the view where the object&#39;s snapshot is located..</param>
        /// <param name="vmHadIndependentDisks">This is applicable only to VMs and is set to true when the VM being recovered or cloned contained independent disks when it was backed up..</param>
        public RestoreObject(ArchivalTarget archivalTarget = default(ArchivalTarget), int? attemptNum = default(int?), CloudDeployTarget cloudDeployTarget = default(CloudDeployTarget), CloudDeployTarget cloudReplicationTarget = default(CloudDeployTarget), EntityProto entity = default(EntityProto), long? jobId = default(long?), long? jobInstanceId = default(long?), UniversalIdProto jobUid = default(UniversalIdProto), EntityProto parentSource = default(EntityProto), long? pointInTimeRestoreTimeUsecs = default(long?), RestoreAcropolisVMParam restoreAcropolisVmParam = default(RestoreAcropolisVMParam), string snapshotRelativeDirPath = default(string), long? startTimeUsecs = default(long?), string viewName = default(string), bool? vmHadIndependentDisks = default(bool?))
        {
            this.AttemptNum = attemptNum;
            this.JobId = jobId;
            this.JobInstanceId = jobInstanceId;
            this.PointInTimeRestoreTimeUsecs = pointInTimeRestoreTimeUsecs;
            this.SnapshotRelativeDirPath = snapshotRelativeDirPath;
            this.StartTimeUsecs = startTimeUsecs;
            this.ViewName = viewName;
            this.VmHadIndependentDisks = vmHadIndependentDisks;
            this.ArchivalTarget = archivalTarget;
            this.AttemptNum = attemptNum;
            this.CloudDeployTarget = cloudDeployTarget;
            this.CloudReplicationTarget = cloudReplicationTarget;
            this.Entity = entity;
            this.JobId = jobId;
            this.JobInstanceId = jobInstanceId;
            this.JobUid = jobUid;
            this.ParentSource = parentSource;
            this.PointInTimeRestoreTimeUsecs = pointInTimeRestoreTimeUsecs;
            this.RestoreAcropolisVmParam = restoreAcropolisVmParam;
            this.SnapshotRelativeDirPath = snapshotRelativeDirPath;
            this.StartTimeUsecs = startTimeUsecs;
            this.ViewName = viewName;
            this.VmHadIndependentDisks = vmHadIndependentDisks;
        }
        
        /// <summary>
        /// Gets or Sets ArchivalTarget
        /// </summary>
        [DataMember(Name="archivalTarget", EmitDefaultValue=false)]
        public ArchivalTarget ArchivalTarget { get; set; }

        /// <summary>
        /// The attempt number of the job run to restore from.
        /// </summary>
        /// <value>The attempt number of the job run to restore from.</value>
        [DataMember(Name="attemptNum", EmitDefaultValue=true)]
        public int? AttemptNum { get; set; }

        /// <summary>
        /// Gets or Sets CloudDeployTarget
        /// </summary>
        [DataMember(Name="cloudDeployTarget", EmitDefaultValue=false)]
        public CloudDeployTarget CloudDeployTarget { get; set; }

        /// <summary>
        /// Gets or Sets CloudReplicationTarget
        /// </summary>
        [DataMember(Name="cloudReplicationTarget", EmitDefaultValue=false)]
        public CloudDeployTarget CloudReplicationTarget { get; set; }

        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public EntityProto Entity { get; set; }

        /// <summary>
        /// The job id from which to restore. This is used while communicating with yoda.
        /// </summary>
        /// <value>The job id from which to restore. This is used while communicating with yoda.</value>
        [DataMember(Name="jobId", EmitDefaultValue=true)]
        public long? JobId { get; set; }

        /// <summary>
        /// Id identifying a specific run to restore from. If this is not specified, and we need to restore from a run, the latest run is used. NOTE: This must be specified for RestoreFiles, RecoverDisks and GetVirtualDisks APIs.
        /// </summary>
        /// <value>Id identifying a specific run to restore from. If this is not specified, and we need to restore from a run, the latest run is used. NOTE: This must be specified for RestoreFiles, RecoverDisks and GetVirtualDisks APIs.</value>
        [DataMember(Name="jobInstanceId", EmitDefaultValue=true)]
        public long? JobInstanceId { get; set; }

        /// <summary>
        /// Gets or Sets JobUid
        /// </summary>
        [DataMember(Name="jobUid", EmitDefaultValue=false)]
        public UniversalIdProto JobUid { get; set; }

        /// <summary>
        /// Gets or Sets ParentSource
        /// </summary>
        [DataMember(Name="parentSource", EmitDefaultValue=false)]
        public EntityProto ParentSource { get; set; }

        /// <summary>
        /// The time to which the object needs to be restored. If this is not set, then the object will be restored to the full/incremental snapshot. This is applicable only if the object is protected using CDP.
        /// </summary>
        /// <value>The time to which the object needs to be restored. If this is not set, then the object will be restored to the full/incremental snapshot. This is applicable only if the object is protected using CDP.</value>
        [DataMember(Name="pointInTimeRestoreTimeUsecs", EmitDefaultValue=true)]
        public long? PointInTimeRestoreTimeUsecs { get; set; }

        /// <summary>
        /// Gets or Sets RestoreAcropolisVmParam
        /// </summary>
        [DataMember(Name="restoreAcropolisVmParam", EmitDefaultValue=false)]
        public RestoreAcropolisVMParam RestoreAcropolisVmParam { get; set; }

        /// <summary>
        /// The relative path to the directory containing the entity&#39;s snapshot.
        /// </summary>
        /// <value>The relative path to the directory containing the entity&#39;s snapshot.</value>
        [DataMember(Name="snapshotRelativeDirPath", EmitDefaultValue=true)]
        public string SnapshotRelativeDirPath { get; set; }

        /// <summary>
        /// The start time of the specific job run. Iff &#39;job_instance_id&#39; is set, this field must be set. In-memory indices on the Magneto master are laid-out by the start time of the job, and this is how the master pulls up a specific run. NOTE: This must be specified for RestoreFiles, RecoverDisks and GetVirtualDisks APIs
        /// </summary>
        /// <value>The start time of the specific job run. Iff &#39;job_instance_id&#39; is set, this field must be set. In-memory indices on the Magneto master are laid-out by the start time of the job, and this is how the master pulls up a specific run. NOTE: This must be specified for RestoreFiles, RecoverDisks and GetVirtualDisks APIs</value>
        [DataMember(Name="startTimeUsecs", EmitDefaultValue=true)]
        public long? StartTimeUsecs { get; set; }

        /// <summary>
        /// The name of the view where the object&#39;s snapshot is located.
        /// </summary>
        /// <value>The name of the view where the object&#39;s snapshot is located.</value>
        [DataMember(Name="viewName", EmitDefaultValue=true)]
        public string ViewName { get; set; }

        /// <summary>
        /// This is applicable only to VMs and is set to true when the VM being recovered or cloned contained independent disks when it was backed up.
        /// </summary>
        /// <value>This is applicable only to VMs and is set to true when the VM being recovered or cloned contained independent disks when it was backed up.</value>
        [DataMember(Name="vmHadIndependentDisks", EmitDefaultValue=true)]
        public bool? VmHadIndependentDisks { get; set; }

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
            return this.Equals(input as RestoreObject);
        }

        /// <summary>
        /// Returns true if RestoreObject instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ArchivalTarget == input.ArchivalTarget ||
                    (this.ArchivalTarget != null &&
                    this.ArchivalTarget.Equals(input.ArchivalTarget))
                ) && 
                (
                    this.AttemptNum == input.AttemptNum ||
                    (this.AttemptNum != null &&
                    this.AttemptNum.Equals(input.AttemptNum))
                ) && 
                (
                    this.CloudDeployTarget == input.CloudDeployTarget ||
                    (this.CloudDeployTarget != null &&
                    this.CloudDeployTarget.Equals(input.CloudDeployTarget))
                ) && 
                (
                    this.CloudReplicationTarget == input.CloudReplicationTarget ||
                    (this.CloudReplicationTarget != null &&
                    this.CloudReplicationTarget.Equals(input.CloudReplicationTarget))
                ) && 
                (
                    this.Entity == input.Entity ||
                    (this.Entity != null &&
                    this.Entity.Equals(input.Entity))
                ) && 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.JobInstanceId == input.JobInstanceId ||
                    (this.JobInstanceId != null &&
                    this.JobInstanceId.Equals(input.JobInstanceId))
                ) && 
                (
                    this.JobUid == input.JobUid ||
                    (this.JobUid != null &&
                    this.JobUid.Equals(input.JobUid))
                ) && 
                (
                    this.ParentSource == input.ParentSource ||
                    (this.ParentSource != null &&
                    this.ParentSource.Equals(input.ParentSource))
                ) && 
                (
                    this.PointInTimeRestoreTimeUsecs == input.PointInTimeRestoreTimeUsecs ||
                    (this.PointInTimeRestoreTimeUsecs != null &&
                    this.PointInTimeRestoreTimeUsecs.Equals(input.PointInTimeRestoreTimeUsecs))
                ) && 
                (
                    this.RestoreAcropolisVmParam == input.RestoreAcropolisVmParam ||
                    (this.RestoreAcropolisVmParam != null &&
                    this.RestoreAcropolisVmParam.Equals(input.RestoreAcropolisVmParam))
                ) && 
                (
                    this.SnapshotRelativeDirPath == input.SnapshotRelativeDirPath ||
                    (this.SnapshotRelativeDirPath != null &&
                    this.SnapshotRelativeDirPath.Equals(input.SnapshotRelativeDirPath))
                ) && 
                (
                    this.StartTimeUsecs == input.StartTimeUsecs ||
                    (this.StartTimeUsecs != null &&
                    this.StartTimeUsecs.Equals(input.StartTimeUsecs))
                ) && 
                (
                    this.ViewName == input.ViewName ||
                    (this.ViewName != null &&
                    this.ViewName.Equals(input.ViewName))
                ) && 
                (
                    this.VmHadIndependentDisks == input.VmHadIndependentDisks ||
                    (this.VmHadIndependentDisks != null &&
                    this.VmHadIndependentDisks.Equals(input.VmHadIndependentDisks))
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
                if (this.ArchivalTarget != null)
                    hashCode = hashCode * 59 + this.ArchivalTarget.GetHashCode();
                if (this.AttemptNum != null)
                    hashCode = hashCode * 59 + this.AttemptNum.GetHashCode();
                if (this.CloudDeployTarget != null)
                    hashCode = hashCode * 59 + this.CloudDeployTarget.GetHashCode();
                if (this.CloudReplicationTarget != null)
                    hashCode = hashCode * 59 + this.CloudReplicationTarget.GetHashCode();
                if (this.Entity != null)
                    hashCode = hashCode * 59 + this.Entity.GetHashCode();
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.JobInstanceId != null)
                    hashCode = hashCode * 59 + this.JobInstanceId.GetHashCode();
                if (this.JobUid != null)
                    hashCode = hashCode * 59 + this.JobUid.GetHashCode();
                if (this.ParentSource != null)
                    hashCode = hashCode * 59 + this.ParentSource.GetHashCode();
                if (this.PointInTimeRestoreTimeUsecs != null)
                    hashCode = hashCode * 59 + this.PointInTimeRestoreTimeUsecs.GetHashCode();
                if (this.RestoreAcropolisVmParam != null)
                    hashCode = hashCode * 59 + this.RestoreAcropolisVmParam.GetHashCode();
                if (this.SnapshotRelativeDirPath != null)
                    hashCode = hashCode * 59 + this.SnapshotRelativeDirPath.GetHashCode();
                if (this.StartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.StartTimeUsecs.GetHashCode();
                if (this.ViewName != null)
                    hashCode = hashCode * 59 + this.ViewName.GetHashCode();
                if (this.VmHadIndependentDisks != null)
                    hashCode = hashCode * 59 + this.VmHadIndependentDisks.GetHashCode();
                return hashCode;
            }
        }

    }

}


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
        /// <param name="backupType">Backup type of corresponding backup run. Currently, this is only populated for restore tasks..</param>
        /// <param name="cloudDeployTarget">cloudDeployTarget.</param>
        /// <param name="cloudReplicationTarget">cloudReplicationTarget.</param>
        /// <param name="configVec">Common Configuration Parameters for recovery.</param>
        /// <param name="entity">entity.</param>
        /// <param name="hydrationTimeUsecs">The time to which CDP logs hydrated. This field is currently only applicable to MongoDb. This field is used during restore as the &#39;start time&#39; for copying the remaining cdp logs that are yet to be hydrated by agent..</param>
        /// <param name="jobId">The job id from which to restore. This is used while communicating with yoda..</param>
        /// <param name="jobInstanceId">Id identifying a specific run to restore from. If this is not specified, and we need to restore from a run, the latest run is used. NOTE: This must be specified for RestoreFiles, RecoverDisks and GetVirtualDisks APIs..</param>
        /// <param name="jobUid">jobUid.</param>
        /// <param name="nosqlRecoverParams">nosqlRecoverParams.</param>
        /// <param name="parentSource">parentSource.</param>
        /// <param name="pitPreferredArchivalTarget">pitPreferredArchivalTarget.</param>
        /// <param name="pointInTimeRestoreTimeUsecs">The time to which the object needs to be restored. If this is not set, then the object will be restored to the full/incremental snapshot. This is applicable only if the object is protected using CDP..</param>
        /// <param name="recoverFromStandby">This field indicates if the object should be recovered from standby if it is enabled..</param>
        /// <param name="restoreAcropolisVmParam">restoreAcropolisVmParam.</param>
        /// <param name="restoreExchangeParams">restoreExchangeParams.</param>
        /// <param name="restoreVappInfo">restoreVappInfo.</param>
        /// <param name="sanRecoverParams">sanRecoverParams.</param>
        /// <param name="sfdcRecoverParams">sfdcRecoverParams.</param>
        /// <param name="snapshotRelativeDirPath">The relative path to the directory containing the entity&#39;s snapshot..</param>
        /// <param name="startTimeUsecs">The start time of the specific job run. Iff &#39;job_instance_id&#39; is set, this field must be set. In-memory indices on the Magneto master are laid-out by the start time of the job, and this is how the master pulls up a specific run. NOTE: This must be specified for RestoreFiles, RecoverDisks and GetVirtualDisks APIs.</param>
        /// <param name="udaRecoverParams">udaRecoverParams.</param>
        /// <param name="viewName">The name of the view where the object&#39;s snapshot is located..</param>
        /// <param name="vmHadIndependentDisks">This is applicable only to VMs and is set to true when the VM being recovered or cloned contained independent disks when it was backed up..</param>
        public RestoreObject(ArchivalTarget archivalTarget = default(ArchivalTarget), int? attemptNum = default(int?), int? backupType = default(int?), CloudDeployTarget cloudDeployTarget = default(CloudDeployTarget), CloudDeployTarget cloudReplicationTarget = default(CloudDeployTarget), List<ConfigurationParams> configVec = default(List<ConfigurationParams>), EntityProto entity = default(EntityProto), long? hydrationTimeUsecs = default(long?), long? jobId = default(long?), long? jobInstanceId = default(long?), UniversalIdProto jobUid = default(UniversalIdProto), NoSqlRecoverParams nosqlRecoverParams = default(NoSqlRecoverParams), EntityProto parentSource = default(EntityProto), ArchivalTarget pitPreferredArchivalTarget = default(ArchivalTarget), long? pointInTimeRestoreTimeUsecs = default(long?), bool? recoverFromStandby = default(bool?), RestoreAcropolisVMParam restoreAcropolisVmParam = default(RestoreAcropolisVMParam), RestoreExchangeParams restoreExchangeParams = default(RestoreExchangeParams), RestoreVappInfo restoreVappInfo = default(RestoreVappInfo), SANRecoverParams sanRecoverParams = default(SANRecoverParams), SfdcRecoverParams sfdcRecoverParams = default(SfdcRecoverParams), string snapshotRelativeDirPath = default(string), long? startTimeUsecs = default(long?), UdaRecoverParams udaRecoverParams = default(UdaRecoverParams), string viewName = default(string), bool? vmHadIndependentDisks = default(bool?))
        {
            this.AttemptNum = attemptNum;
            this.BackupType = backupType;
            this.ConfigVec = configVec;
            this.HydrationTimeUsecs = hydrationTimeUsecs;
            this.JobId = jobId;
            this.JobInstanceId = jobInstanceId;
            this.PointInTimeRestoreTimeUsecs = pointInTimeRestoreTimeUsecs;
            this.RecoverFromStandby = recoverFromStandby;
            this.SnapshotRelativeDirPath = snapshotRelativeDirPath;
            this.StartTimeUsecs = startTimeUsecs;
            this.ViewName = viewName;
            this.VmHadIndependentDisks = vmHadIndependentDisks;
            this.ArchivalTarget = archivalTarget;
            this.AttemptNum = attemptNum;
            this.BackupType = backupType;
            this.CloudDeployTarget = cloudDeployTarget;
            this.CloudReplicationTarget = cloudReplicationTarget;
            this.ConfigVec = configVec;
            this.Entity = entity;
            this.HydrationTimeUsecs = hydrationTimeUsecs;
            this.JobId = jobId;
            this.JobInstanceId = jobInstanceId;
            this.JobUid = jobUid;
            this.NosqlRecoverParams = nosqlRecoverParams;
            this.ParentSource = parentSource;
            this.PitPreferredArchivalTarget = pitPreferredArchivalTarget;
            this.PointInTimeRestoreTimeUsecs = pointInTimeRestoreTimeUsecs;
            this.RecoverFromStandby = recoverFromStandby;
            this.RestoreAcropolisVmParam = restoreAcropolisVmParam;
            this.RestoreExchangeParams = restoreExchangeParams;
            this.RestoreVappInfo = restoreVappInfo;
            this.SanRecoverParams = sanRecoverParams;
            this.SfdcRecoverParams = sfdcRecoverParams;
            this.SnapshotRelativeDirPath = snapshotRelativeDirPath;
            this.StartTimeUsecs = startTimeUsecs;
            this.UdaRecoverParams = udaRecoverParams;
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
        /// Backup type of corresponding backup run. Currently, this is only populated for restore tasks.
        /// </summary>
        /// <value>Backup type of corresponding backup run. Currently, this is only populated for restore tasks.</value>
        [DataMember(Name="backupType", EmitDefaultValue=true)]
        public int? BackupType { get; set; }

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
        /// Common Configuration Parameters for recovery
        /// </summary>
        /// <value>Common Configuration Parameters for recovery</value>
        [DataMember(Name="configVec", EmitDefaultValue=true)]
        public List<ConfigurationParams> ConfigVec { get; set; }

        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public EntityProto Entity { get; set; }

        /// <summary>
        /// The time to which CDP logs hydrated. This field is currently only applicable to MongoDb. This field is used during restore as the &#39;start time&#39; for copying the remaining cdp logs that are yet to be hydrated by agent.
        /// </summary>
        /// <value>The time to which CDP logs hydrated. This field is currently only applicable to MongoDb. This field is used during restore as the &#39;start time&#39; for copying the remaining cdp logs that are yet to be hydrated by agent.</value>
        [DataMember(Name="hydrationTimeUsecs", EmitDefaultValue=true)]
        public long? HydrationTimeUsecs { get; set; }

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
        /// Gets or Sets NosqlRecoverParams
        /// </summary>
        [DataMember(Name="nosqlRecoverParams", EmitDefaultValue=false)]
        public NoSqlRecoverParams NosqlRecoverParams { get; set; }

        /// <summary>
        /// Gets or Sets ParentSource
        /// </summary>
        [DataMember(Name="parentSource", EmitDefaultValue=false)]
        public EntityProto ParentSource { get; set; }

        /// <summary>
        /// Gets or Sets PitPreferredArchivalTarget
        /// </summary>
        [DataMember(Name="pitPreferredArchivalTarget", EmitDefaultValue=false)]
        public ArchivalTarget PitPreferredArchivalTarget { get; set; }

        /// <summary>
        /// The time to which the object needs to be restored. If this is not set, then the object will be restored to the full/incremental snapshot. This is applicable only if the object is protected using CDP.
        /// </summary>
        /// <value>The time to which the object needs to be restored. If this is not set, then the object will be restored to the full/incremental snapshot. This is applicable only if the object is protected using CDP.</value>
        [DataMember(Name="pointInTimeRestoreTimeUsecs", EmitDefaultValue=true)]
        public long? PointInTimeRestoreTimeUsecs { get; set; }

        /// <summary>
        /// This field indicates if the object should be recovered from standby if it is enabled.
        /// </summary>
        /// <value>This field indicates if the object should be recovered from standby if it is enabled.</value>
        [DataMember(Name="recoverFromStandby", EmitDefaultValue=true)]
        public bool? RecoverFromStandby { get; set; }

        /// <summary>
        /// Gets or Sets RestoreAcropolisVmParam
        /// </summary>
        [DataMember(Name="restoreAcropolisVmParam", EmitDefaultValue=false)]
        public RestoreAcropolisVMParam RestoreAcropolisVmParam { get; set; }

        /// <summary>
        /// Gets or Sets RestoreExchangeParams
        /// </summary>
        [DataMember(Name="restoreExchangeParams", EmitDefaultValue=false)]
        public RestoreExchangeParams RestoreExchangeParams { get; set; }

        /// <summary>
        /// Gets or Sets RestoreVappInfo
        /// </summary>
        [DataMember(Name="restoreVappInfo", EmitDefaultValue=false)]
        public RestoreVappInfo RestoreVappInfo { get; set; }

        /// <summary>
        /// Gets or Sets SanRecoverParams
        /// </summary>
        [DataMember(Name="sanRecoverParams", EmitDefaultValue=false)]
        public SANRecoverParams SanRecoverParams { get; set; }

        /// <summary>
        /// Gets or Sets SfdcRecoverParams
        /// </summary>
        [DataMember(Name="sfdcRecoverParams", EmitDefaultValue=false)]
        public SfdcRecoverParams SfdcRecoverParams { get; set; }

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
        /// Gets or Sets UdaRecoverParams
        /// </summary>
        [DataMember(Name="udaRecoverParams", EmitDefaultValue=false)]
        public UdaRecoverParams UdaRecoverParams { get; set; }

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
                    this.BackupType == input.BackupType ||
                    (this.BackupType != null &&
                    this.BackupType.Equals(input.BackupType))
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
                    this.ConfigVec == input.ConfigVec ||
                    this.ConfigVec != null &&
                    input.ConfigVec != null &&
                    this.ConfigVec.SequenceEqual(input.ConfigVec)
                ) && 
                (
                    this.Entity == input.Entity ||
                    (this.Entity != null &&
                    this.Entity.Equals(input.Entity))
                ) && 
                (
                    this.HydrationTimeUsecs == input.HydrationTimeUsecs ||
                    (this.HydrationTimeUsecs != null &&
                    this.HydrationTimeUsecs.Equals(input.HydrationTimeUsecs))
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
                    this.NosqlRecoverParams == input.NosqlRecoverParams ||
                    (this.NosqlRecoverParams != null &&
                    this.NosqlRecoverParams.Equals(input.NosqlRecoverParams))
                ) && 
                (
                    this.ParentSource == input.ParentSource ||
                    (this.ParentSource != null &&
                    this.ParentSource.Equals(input.ParentSource))
                ) && 
                (
                    this.PitPreferredArchivalTarget == input.PitPreferredArchivalTarget ||
                    (this.PitPreferredArchivalTarget != null &&
                    this.PitPreferredArchivalTarget.Equals(input.PitPreferredArchivalTarget))
                ) && 
                (
                    this.PointInTimeRestoreTimeUsecs == input.PointInTimeRestoreTimeUsecs ||
                    (this.PointInTimeRestoreTimeUsecs != null &&
                    this.PointInTimeRestoreTimeUsecs.Equals(input.PointInTimeRestoreTimeUsecs))
                ) && 
                (
                    this.RecoverFromStandby == input.RecoverFromStandby ||
                    (this.RecoverFromStandby != null &&
                    this.RecoverFromStandby.Equals(input.RecoverFromStandby))
                ) && 
                (
                    this.RestoreAcropolisVmParam == input.RestoreAcropolisVmParam ||
                    (this.RestoreAcropolisVmParam != null &&
                    this.RestoreAcropolisVmParam.Equals(input.RestoreAcropolisVmParam))
                ) && 
                (
                    this.RestoreExchangeParams == input.RestoreExchangeParams ||
                    (this.RestoreExchangeParams != null &&
                    this.RestoreExchangeParams.Equals(input.RestoreExchangeParams))
                ) && 
                (
                    this.RestoreVappInfo == input.RestoreVappInfo ||
                    (this.RestoreVappInfo != null &&
                    this.RestoreVappInfo.Equals(input.RestoreVappInfo))
                ) && 
                (
                    this.SanRecoverParams == input.SanRecoverParams ||
                    (this.SanRecoverParams != null &&
                    this.SanRecoverParams.Equals(input.SanRecoverParams))
                ) && 
                (
                    this.SfdcRecoverParams == input.SfdcRecoverParams ||
                    (this.SfdcRecoverParams != null &&
                    this.SfdcRecoverParams.Equals(input.SfdcRecoverParams))
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
                    this.UdaRecoverParams == input.UdaRecoverParams ||
                    (this.UdaRecoverParams != null &&
                    this.UdaRecoverParams.Equals(input.UdaRecoverParams))
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
                if (this.BackupType != null)
                    hashCode = hashCode * 59 + this.BackupType.GetHashCode();
                if (this.CloudDeployTarget != null)
                    hashCode = hashCode * 59 + this.CloudDeployTarget.GetHashCode();
                if (this.CloudReplicationTarget != null)
                    hashCode = hashCode * 59 + this.CloudReplicationTarget.GetHashCode();
                if (this.ConfigVec != null)
                    hashCode = hashCode * 59 + this.ConfigVec.GetHashCode();
                if (this.Entity != null)
                    hashCode = hashCode * 59 + this.Entity.GetHashCode();
                if (this.HydrationTimeUsecs != null)
                    hashCode = hashCode * 59 + this.HydrationTimeUsecs.GetHashCode();
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.JobInstanceId != null)
                    hashCode = hashCode * 59 + this.JobInstanceId.GetHashCode();
                if (this.JobUid != null)
                    hashCode = hashCode * 59 + this.JobUid.GetHashCode();
                if (this.NosqlRecoverParams != null)
                    hashCode = hashCode * 59 + this.NosqlRecoverParams.GetHashCode();
                if (this.ParentSource != null)
                    hashCode = hashCode * 59 + this.ParentSource.GetHashCode();
                if (this.PitPreferredArchivalTarget != null)
                    hashCode = hashCode * 59 + this.PitPreferredArchivalTarget.GetHashCode();
                if (this.PointInTimeRestoreTimeUsecs != null)
                    hashCode = hashCode * 59 + this.PointInTimeRestoreTimeUsecs.GetHashCode();
                if (this.RecoverFromStandby != null)
                    hashCode = hashCode * 59 + this.RecoverFromStandby.GetHashCode();
                if (this.RestoreAcropolisVmParam != null)
                    hashCode = hashCode * 59 + this.RestoreAcropolisVmParam.GetHashCode();
                if (this.RestoreExchangeParams != null)
                    hashCode = hashCode * 59 + this.RestoreExchangeParams.GetHashCode();
                if (this.RestoreVappInfo != null)
                    hashCode = hashCode * 59 + this.RestoreVappInfo.GetHashCode();
                if (this.SanRecoverParams != null)
                    hashCode = hashCode * 59 + this.SanRecoverParams.GetHashCode();
                if (this.SfdcRecoverParams != null)
                    hashCode = hashCode * 59 + this.SfdcRecoverParams.GetHashCode();
                if (this.SnapshotRelativeDirPath != null)
                    hashCode = hashCode * 59 + this.SnapshotRelativeDirPath.GetHashCode();
                if (this.StartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.StartTimeUsecs.GetHashCode();
                if (this.UdaRecoverParams != null)
                    hashCode = hashCode * 59 + this.UdaRecoverParams.GetHashCode();
                if (this.ViewName != null)
                    hashCode = hashCode * 59 + this.ViewName.GetHashCode();
                if (this.VmHadIndependentDisks != null)
                    hashCode = hashCode * 59 + this.VmHadIndependentDisks.GetHashCode();
                return hashCode;
            }
        }

    }

}


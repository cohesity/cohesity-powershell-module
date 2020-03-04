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
    /// Proto to define the persistent information of a wrapper restore job that spawns multiple child restore tasks.
    /// </summary>
    [DataContract]
    public partial class PerformRestoreJobStateProto :  IEquatable<PerformRestoreJobStateProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PerformRestoreJobStateProto" /> class.
        /// </summary>
        /// <param name="admittedTimeUsecs">The time at which the restore job was admitted to run on a Magneto master. This field will be set only after the status changes to &#39;kAdmitted&#39;. Using this field, amount of time spent in the waiting/queued state and the amount of time taken taken to actually run the job can be determined. wait time &#x3D; admitted_time_usecs - start_time_usecs run time &#x3D; end_time_usecs - admitted_time_usecs.</param>
        /// <param name="cancellationRequested">Whether this restore job has a pending cancellation request..</param>
        /// <param name="continueRestoreOnError">Whether to continue with the restore operation if restore of any object fails..</param>
        /// <param name="deployVmsToCloudTaskState">deployVmsToCloudTaskState.</param>
        /// <param name="endTimeUsecs">If the restore job has finished, this field contains the end time for the job..</param>
        /// <param name="error">error.</param>
        /// <param name="name">The name of the restore job..</param>
        /// <param name="parentSourceConnectionParams">parentSourceConnectionParams.</param>
        /// <param name="powerStateConfig">powerStateConfig.</param>
        /// <param name="preserveTags">Whether to preserve tags for the clone op. This field is currently used by HyperV and VMWare..</param>
        /// <param name="progressMonitorTaskPath">Root path of a Pulse task tracking the progress of the restore job..</param>
        /// <param name="renameRestoredObjectParam">renameRestoredObjectParam.</param>
        /// <param name="restoreAcropolisVmsParams">restoreAcropolisVmsParams.</param>
        /// <param name="restoreJobId">A globally unique id for this restore job..</param>
        /// <param name="restoreKubernetesNamespacesParams">restoreKubernetesNamespacesParams.</param>
        /// <param name="restoreKvmVmsParams">restoreKvmVmsParams.</param>
        /// <param name="restoreParentSource">restoreParentSource.</param>
        /// <param name="restoreTaskStateProtoTmpl">restoreTaskStateProtoTmpl.</param>
        /// <param name="restoreTaskVec">Even if the user wanted to restore an entire job from the latest snapshot, this will have info of all the individual objects..</param>
        /// <param name="restoreVmwareVmParams">restoreVmwareVmParams.</param>
        /// <param name="restoredObjectsNetworkConfig">restoredObjectsNetworkConfig.</param>
        /// <param name="restoredToDifferentSource">Whether restore is being performed to a different parent source..</param>
        /// <param name="startTimeUsecs">The start time for this restore job..</param>
        /// <param name="status">Status of the restore job..</param>
        /// <param name="type">The type of restore being performed..</param>
        /// <param name="user">The user who requested this restore job..</param>
        /// <param name="userInfo">userInfo.</param>
        /// <param name="viewBoxId">The view box id to which the restore job belongs to..</param>
        public PerformRestoreJobStateProto(long? admittedTimeUsecs = default(long?), bool? cancellationRequested = default(bool?), bool? continueRestoreOnError = default(bool?), DeployVMsToCloudTaskStateProto deployVmsToCloudTaskState = default(DeployVMsToCloudTaskStateProto), long? endTimeUsecs = default(long?), ErrorProto error = default(ErrorProto), string name = default(string), ConnectorParams parentSourceConnectionParams = default(ConnectorParams), PowerStateConfigProto powerStateConfig = default(PowerStateConfigProto), bool? preserveTags = default(bool?), string progressMonitorTaskPath = default(string), RenameObjectParamProto renameRestoredObjectParam = default(RenameObjectParamProto), RestoreAcropolisVMsParams restoreAcropolisVmsParams = default(RestoreAcropolisVMsParams), long? restoreJobId = default(long?), RestoreKubernetesNamespacesParams restoreKubernetesNamespacesParams = default(RestoreKubernetesNamespacesParams), RestoreKVMVMsParams restoreKvmVmsParams = default(RestoreKVMVMsParams), EntityProto restoreParentSource = default(EntityProto), PerformRestoreTaskStateProto restoreTaskStateProtoTmpl = default(PerformRestoreTaskStateProto), List<PerformRestoreJobStateProtoRestoreTask> restoreTaskVec = default(List<PerformRestoreJobStateProtoRestoreTask>), RestoreVMwareVMParams restoreVmwareVmParams = default(RestoreVMwareVMParams), RestoredObjectNetworkConfigProto restoredObjectsNetworkConfig = default(RestoredObjectNetworkConfigProto), bool? restoredToDifferentSource = default(bool?), long? startTimeUsecs = default(long?), int? status = default(int?), int? type = default(int?), string user = default(string), UserInformation userInfo = default(UserInformation), long? viewBoxId = default(long?))
        {
            this.AdmittedTimeUsecs = admittedTimeUsecs;
            this.CancellationRequested = cancellationRequested;
            this.ContinueRestoreOnError = continueRestoreOnError;
            this.EndTimeUsecs = endTimeUsecs;
            this.Name = name;
            this.PreserveTags = preserveTags;
            this.ProgressMonitorTaskPath = progressMonitorTaskPath;
            this.RestoreJobId = restoreJobId;
            this.RestoreTaskVec = restoreTaskVec;
            this.RestoredToDifferentSource = restoredToDifferentSource;
            this.StartTimeUsecs = startTimeUsecs;
            this.Status = status;
            this.Type = type;
            this.User = user;
            this.ViewBoxId = viewBoxId;
            this.AdmittedTimeUsecs = admittedTimeUsecs;
            this.CancellationRequested = cancellationRequested;
            this.ContinueRestoreOnError = continueRestoreOnError;
            this.DeployVmsToCloudTaskState = deployVmsToCloudTaskState;
            this.EndTimeUsecs = endTimeUsecs;
            this.Error = error;
            this.Name = name;
            this.ParentSourceConnectionParams = parentSourceConnectionParams;
            this.PowerStateConfig = powerStateConfig;
            this.PreserveTags = preserveTags;
            this.ProgressMonitorTaskPath = progressMonitorTaskPath;
            this.RenameRestoredObjectParam = renameRestoredObjectParam;
            this.RestoreAcropolisVmsParams = restoreAcropolisVmsParams;
            this.RestoreJobId = restoreJobId;
            this.RestoreKubernetesNamespacesParams = restoreKubernetesNamespacesParams;
            this.RestoreKvmVmsParams = restoreKvmVmsParams;
            this.RestoreParentSource = restoreParentSource;
            this.RestoreTaskStateProtoTmpl = restoreTaskStateProtoTmpl;
            this.RestoreTaskVec = restoreTaskVec;
            this.RestoreVmwareVmParams = restoreVmwareVmParams;
            this.RestoredObjectsNetworkConfig = restoredObjectsNetworkConfig;
            this.RestoredToDifferentSource = restoredToDifferentSource;
            this.StartTimeUsecs = startTimeUsecs;
            this.Status = status;
            this.Type = type;
            this.User = user;
            this.UserInfo = userInfo;
            this.ViewBoxId = viewBoxId;
        }
        
        /// <summary>
        /// The time at which the restore job was admitted to run on a Magneto master. This field will be set only after the status changes to &#39;kAdmitted&#39;. Using this field, amount of time spent in the waiting/queued state and the amount of time taken taken to actually run the job can be determined. wait time &#x3D; admitted_time_usecs - start_time_usecs run time &#x3D; end_time_usecs - admitted_time_usecs
        /// </summary>
        /// <value>The time at which the restore job was admitted to run on a Magneto master. This field will be set only after the status changes to &#39;kAdmitted&#39;. Using this field, amount of time spent in the waiting/queued state and the amount of time taken taken to actually run the job can be determined. wait time &#x3D; admitted_time_usecs - start_time_usecs run time &#x3D; end_time_usecs - admitted_time_usecs</value>
        [DataMember(Name="admittedTimeUsecs", EmitDefaultValue=true)]
        public long? AdmittedTimeUsecs { get; set; }

        /// <summary>
        /// Whether this restore job has a pending cancellation request.
        /// </summary>
        /// <value>Whether this restore job has a pending cancellation request.</value>
        [DataMember(Name="cancellationRequested", EmitDefaultValue=true)]
        public bool? CancellationRequested { get; set; }

        /// <summary>
        /// Whether to continue with the restore operation if restore of any object fails.
        /// </summary>
        /// <value>Whether to continue with the restore operation if restore of any object fails.</value>
        [DataMember(Name="continueRestoreOnError", EmitDefaultValue=true)]
        public bool? ContinueRestoreOnError { get; set; }

        /// <summary>
        /// Gets or Sets DeployVmsToCloudTaskState
        /// </summary>
        [DataMember(Name="deployVmsToCloudTaskState", EmitDefaultValue=false)]
        public DeployVMsToCloudTaskStateProto DeployVmsToCloudTaskState { get; set; }

        /// <summary>
        /// If the restore job has finished, this field contains the end time for the job.
        /// </summary>
        /// <value>If the restore job has finished, this field contains the end time for the job.</value>
        [DataMember(Name="endTimeUsecs", EmitDefaultValue=true)]
        public long? EndTimeUsecs { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public ErrorProto Error { get; set; }

        /// <summary>
        /// The name of the restore job.
        /// </summary>
        /// <value>The name of the restore job.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ParentSourceConnectionParams
        /// </summary>
        [DataMember(Name="parentSourceConnectionParams", EmitDefaultValue=false)]
        public ConnectorParams ParentSourceConnectionParams { get; set; }

        /// <summary>
        /// Gets or Sets PowerStateConfig
        /// </summary>
        [DataMember(Name="powerStateConfig", EmitDefaultValue=false)]
        public PowerStateConfigProto PowerStateConfig { get; set; }

        /// <summary>
        /// Whether to preserve tags for the clone op. This field is currently used by HyperV and VMWare.
        /// </summary>
        /// <value>Whether to preserve tags for the clone op. This field is currently used by HyperV and VMWare.</value>
        [DataMember(Name="preserveTags", EmitDefaultValue=true)]
        public bool? PreserveTags { get; set; }

        /// <summary>
        /// Root path of a Pulse task tracking the progress of the restore job.
        /// </summary>
        /// <value>Root path of a Pulse task tracking the progress of the restore job.</value>
        [DataMember(Name="progressMonitorTaskPath", EmitDefaultValue=true)]
        public string ProgressMonitorTaskPath { get; set; }

        /// <summary>
        /// Gets or Sets RenameRestoredObjectParam
        /// </summary>
        [DataMember(Name="renameRestoredObjectParam", EmitDefaultValue=false)]
        public RenameObjectParamProto RenameRestoredObjectParam { get; set; }

        /// <summary>
        /// Gets or Sets RestoreAcropolisVmsParams
        /// </summary>
        [DataMember(Name="restoreAcropolisVmsParams", EmitDefaultValue=false)]
        public RestoreAcropolisVMsParams RestoreAcropolisVmsParams { get; set; }

        /// <summary>
        /// A globally unique id for this restore job.
        /// </summary>
        /// <value>A globally unique id for this restore job.</value>
        [DataMember(Name="restoreJobId", EmitDefaultValue=true)]
        public long? RestoreJobId { get; set; }

        /// <summary>
        /// Gets or Sets RestoreKubernetesNamespacesParams
        /// </summary>
        [DataMember(Name="restoreKubernetesNamespacesParams", EmitDefaultValue=false)]
        public RestoreKubernetesNamespacesParams RestoreKubernetesNamespacesParams { get; set; }

        /// <summary>
        /// Gets or Sets RestoreKvmVmsParams
        /// </summary>
        [DataMember(Name="restoreKvmVmsParams", EmitDefaultValue=false)]
        public RestoreKVMVMsParams RestoreKvmVmsParams { get; set; }

        /// <summary>
        /// Gets or Sets RestoreParentSource
        /// </summary>
        [DataMember(Name="restoreParentSource", EmitDefaultValue=false)]
        public EntityProto RestoreParentSource { get; set; }

        /// <summary>
        /// Gets or Sets RestoreTaskStateProtoTmpl
        /// </summary>
        [DataMember(Name="restoreTaskStateProtoTmpl", EmitDefaultValue=false)]
        public PerformRestoreTaskStateProto RestoreTaskStateProtoTmpl { get; set; }

        /// <summary>
        /// Even if the user wanted to restore an entire job from the latest snapshot, this will have info of all the individual objects.
        /// </summary>
        /// <value>Even if the user wanted to restore an entire job from the latest snapshot, this will have info of all the individual objects.</value>
        [DataMember(Name="restoreTaskVec", EmitDefaultValue=true)]
        public List<PerformRestoreJobStateProtoRestoreTask> RestoreTaskVec { get; set; }

        /// <summary>
        /// Gets or Sets RestoreVmwareVmParams
        /// </summary>
        [DataMember(Name="restoreVmwareVmParams", EmitDefaultValue=false)]
        public RestoreVMwareVMParams RestoreVmwareVmParams { get; set; }

        /// <summary>
        /// Gets or Sets RestoredObjectsNetworkConfig
        /// </summary>
        [DataMember(Name="restoredObjectsNetworkConfig", EmitDefaultValue=false)]
        public RestoredObjectNetworkConfigProto RestoredObjectsNetworkConfig { get; set; }

        /// <summary>
        /// Whether restore is being performed to a different parent source.
        /// </summary>
        /// <value>Whether restore is being performed to a different parent source.</value>
        [DataMember(Name="restoredToDifferentSource", EmitDefaultValue=true)]
        public bool? RestoredToDifferentSource { get; set; }

        /// <summary>
        /// The start time for this restore job.
        /// </summary>
        /// <value>The start time for this restore job.</value>
        [DataMember(Name="startTimeUsecs", EmitDefaultValue=true)]
        public long? StartTimeUsecs { get; set; }

        /// <summary>
        /// Status of the restore job.
        /// </summary>
        /// <value>Status of the restore job.</value>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public int? Status { get; set; }

        /// <summary>
        /// The type of restore being performed.
        /// </summary>
        /// <value>The type of restore being performed.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public int? Type { get; set; }

        /// <summary>
        /// The user who requested this restore job.
        /// </summary>
        /// <value>The user who requested this restore job.</value>
        [DataMember(Name="user", EmitDefaultValue=true)]
        public string User { get; set; }

        /// <summary>
        /// Gets or Sets UserInfo
        /// </summary>
        [DataMember(Name="userInfo", EmitDefaultValue=false)]
        public UserInformation UserInfo { get; set; }

        /// <summary>
        /// The view box id to which the restore job belongs to.
        /// </summary>
        /// <value>The view box id to which the restore job belongs to.</value>
        [DataMember(Name="viewBoxId", EmitDefaultValue=true)]
        public long? ViewBoxId { get; set; }

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
            return this.Equals(input as PerformRestoreJobStateProto);
        }

        /// <summary>
        /// Returns true if PerformRestoreJobStateProto instances are equal
        /// </summary>
        /// <param name="input">Instance of PerformRestoreJobStateProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PerformRestoreJobStateProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdmittedTimeUsecs == input.AdmittedTimeUsecs ||
                    (this.AdmittedTimeUsecs != null &&
                    this.AdmittedTimeUsecs.Equals(input.AdmittedTimeUsecs))
                ) && 
                (
                    this.CancellationRequested == input.CancellationRequested ||
                    (this.CancellationRequested != null &&
                    this.CancellationRequested.Equals(input.CancellationRequested))
                ) && 
                (
                    this.ContinueRestoreOnError == input.ContinueRestoreOnError ||
                    (this.ContinueRestoreOnError != null &&
                    this.ContinueRestoreOnError.Equals(input.ContinueRestoreOnError))
                ) && 
                (
                    this.DeployVmsToCloudTaskState == input.DeployVmsToCloudTaskState ||
                    (this.DeployVmsToCloudTaskState != null &&
                    this.DeployVmsToCloudTaskState.Equals(input.DeployVmsToCloudTaskState))
                ) && 
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ParentSourceConnectionParams == input.ParentSourceConnectionParams ||
                    (this.ParentSourceConnectionParams != null &&
                    this.ParentSourceConnectionParams.Equals(input.ParentSourceConnectionParams))
                ) && 
                (
                    this.PowerStateConfig == input.PowerStateConfig ||
                    (this.PowerStateConfig != null &&
                    this.PowerStateConfig.Equals(input.PowerStateConfig))
                ) && 
                (
                    this.PreserveTags == input.PreserveTags ||
                    (this.PreserveTags != null &&
                    this.PreserveTags.Equals(input.PreserveTags))
                ) && 
                (
                    this.ProgressMonitorTaskPath == input.ProgressMonitorTaskPath ||
                    (this.ProgressMonitorTaskPath != null &&
                    this.ProgressMonitorTaskPath.Equals(input.ProgressMonitorTaskPath))
                ) && 
                (
                    this.RenameRestoredObjectParam == input.RenameRestoredObjectParam ||
                    (this.RenameRestoredObjectParam != null &&
                    this.RenameRestoredObjectParam.Equals(input.RenameRestoredObjectParam))
                ) && 
                (
                    this.RestoreAcropolisVmsParams == input.RestoreAcropolisVmsParams ||
                    (this.RestoreAcropolisVmsParams != null &&
                    this.RestoreAcropolisVmsParams.Equals(input.RestoreAcropolisVmsParams))
                ) && 
                (
                    this.RestoreJobId == input.RestoreJobId ||
                    (this.RestoreJobId != null &&
                    this.RestoreJobId.Equals(input.RestoreJobId))
                ) && 
                (
                    this.RestoreKubernetesNamespacesParams == input.RestoreKubernetesNamespacesParams ||
                    (this.RestoreKubernetesNamespacesParams != null &&
                    this.RestoreKubernetesNamespacesParams.Equals(input.RestoreKubernetesNamespacesParams))
                ) && 
                (
                    this.RestoreKvmVmsParams == input.RestoreKvmVmsParams ||
                    (this.RestoreKvmVmsParams != null &&
                    this.RestoreKvmVmsParams.Equals(input.RestoreKvmVmsParams))
                ) && 
                (
                    this.RestoreParentSource == input.RestoreParentSource ||
                    (this.RestoreParentSource != null &&
                    this.RestoreParentSource.Equals(input.RestoreParentSource))
                ) && 
                (
                    this.RestoreTaskStateProtoTmpl == input.RestoreTaskStateProtoTmpl ||
                    (this.RestoreTaskStateProtoTmpl != null &&
                    this.RestoreTaskStateProtoTmpl.Equals(input.RestoreTaskStateProtoTmpl))
                ) && 
                (
                    this.RestoreTaskVec == input.RestoreTaskVec ||
                    this.RestoreTaskVec != null &&
                    input.RestoreTaskVec != null &&
                    this.RestoreTaskVec.SequenceEqual(input.RestoreTaskVec)
                ) && 
                (
                    this.RestoreVmwareVmParams == input.RestoreVmwareVmParams ||
                    (this.RestoreVmwareVmParams != null &&
                    this.RestoreVmwareVmParams.Equals(input.RestoreVmwareVmParams))
                ) && 
                (
                    this.RestoredObjectsNetworkConfig == input.RestoredObjectsNetworkConfig ||
                    (this.RestoredObjectsNetworkConfig != null &&
                    this.RestoredObjectsNetworkConfig.Equals(input.RestoredObjectsNetworkConfig))
                ) && 
                (
                    this.RestoredToDifferentSource == input.RestoredToDifferentSource ||
                    (this.RestoredToDifferentSource != null &&
                    this.RestoredToDifferentSource.Equals(input.RestoredToDifferentSource))
                ) && 
                (
                    this.StartTimeUsecs == input.StartTimeUsecs ||
                    (this.StartTimeUsecs != null &&
                    this.StartTimeUsecs.Equals(input.StartTimeUsecs))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.UserInfo == input.UserInfo ||
                    (this.UserInfo != null &&
                    this.UserInfo.Equals(input.UserInfo))
                ) && 
                (
                    this.ViewBoxId == input.ViewBoxId ||
                    (this.ViewBoxId != null &&
                    this.ViewBoxId.Equals(input.ViewBoxId))
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
                if (this.AdmittedTimeUsecs != null)
                    hashCode = hashCode * 59 + this.AdmittedTimeUsecs.GetHashCode();
                if (this.CancellationRequested != null)
                    hashCode = hashCode * 59 + this.CancellationRequested.GetHashCode();
                if (this.ContinueRestoreOnError != null)
                    hashCode = hashCode * 59 + this.ContinueRestoreOnError.GetHashCode();
                if (this.DeployVmsToCloudTaskState != null)
                    hashCode = hashCode * 59 + this.DeployVmsToCloudTaskState.GetHashCode();
                if (this.EndTimeUsecs != null)
                    hashCode = hashCode * 59 + this.EndTimeUsecs.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ParentSourceConnectionParams != null)
                    hashCode = hashCode * 59 + this.ParentSourceConnectionParams.GetHashCode();
                if (this.PowerStateConfig != null)
                    hashCode = hashCode * 59 + this.PowerStateConfig.GetHashCode();
                if (this.PreserveTags != null)
                    hashCode = hashCode * 59 + this.PreserveTags.GetHashCode();
                if (this.ProgressMonitorTaskPath != null)
                    hashCode = hashCode * 59 + this.ProgressMonitorTaskPath.GetHashCode();
                if (this.RenameRestoredObjectParam != null)
                    hashCode = hashCode * 59 + this.RenameRestoredObjectParam.GetHashCode();
                if (this.RestoreAcropolisVmsParams != null)
                    hashCode = hashCode * 59 + this.RestoreAcropolisVmsParams.GetHashCode();
                if (this.RestoreJobId != null)
                    hashCode = hashCode * 59 + this.RestoreJobId.GetHashCode();
                if (this.RestoreKubernetesNamespacesParams != null)
                    hashCode = hashCode * 59 + this.RestoreKubernetesNamespacesParams.GetHashCode();
                if (this.RestoreKvmVmsParams != null)
                    hashCode = hashCode * 59 + this.RestoreKvmVmsParams.GetHashCode();
                if (this.RestoreParentSource != null)
                    hashCode = hashCode * 59 + this.RestoreParentSource.GetHashCode();
                if (this.RestoreTaskStateProtoTmpl != null)
                    hashCode = hashCode * 59 + this.RestoreTaskStateProtoTmpl.GetHashCode();
                if (this.RestoreTaskVec != null)
                    hashCode = hashCode * 59 + this.RestoreTaskVec.GetHashCode();
                if (this.RestoreVmwareVmParams != null)
                    hashCode = hashCode * 59 + this.RestoreVmwareVmParams.GetHashCode();
                if (this.RestoredObjectsNetworkConfig != null)
                    hashCode = hashCode * 59 + this.RestoredObjectsNetworkConfig.GetHashCode();
                if (this.RestoredToDifferentSource != null)
                    hashCode = hashCode * 59 + this.RestoredToDifferentSource.GetHashCode();
                if (this.StartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.StartTimeUsecs.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.UserInfo != null)
                    hashCode = hashCode * 59 + this.UserInfo.GetHashCode();
                if (this.ViewBoxId != null)
                    hashCode = hashCode * 59 + this.ViewBoxId.GetHashCode();
                return hashCode;
            }
        }

    }

}


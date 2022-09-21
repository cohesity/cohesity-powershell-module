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
        /// <param name="nosqlConnectParams">nosqlConnectParams.</param>
        /// <param name="nosqlRecoverJobParams">nosqlRecoverJobParams.</param>
        /// <param name="objects">Information on the exact set of objects being restored (along with snapshots they are being recovered from). Even if the user wanted to restore an entire job form the latest snapshot, this will have individual objects and the exact snapshot they are bein restored from. If specified, this can only have leaf-level entities..</param>
        /// <param name="parentSourceConnectionParams">parentSourceConnectionParams.</param>
        /// <param name="physicalFlrParallelRestore">If enabled, magneto physical file restore will be enabled via job framework.</param>
        /// <param name="powerStateConfig">powerStateConfig.</param>
        /// <param name="preserveTags">Whether to preserve tags for the clone op. This field is currently used by HyperV and VMWare..</param>
        /// <param name="progressMonitorTaskPath">Root path of a Pulse task tracking the progress of the restore job..</param>
        /// <param name="renameRestoredObjectParam">renameRestoredObjectParam.</param>
        /// <param name="renameRestoredVappParam">renameRestoredVappParam.</param>
        /// <param name="restoreAcropolisVmsParams">restoreAcropolisVmsParams.</param>
        /// <param name="restoreGroupsParams">restoreGroupsParams.</param>
        /// <param name="restoreJobId">A unique id for this restore job within the cluster..</param>
        /// <param name="restoreJobUid">restoreJobUid.</param>
        /// <param name="restoreKubernetesNamespacesParams">restoreKubernetesNamespacesParams.</param>
        /// <param name="restoreKvmVmsParams">restoreKvmVmsParams.</param>
        /// <param name="restoreParentSource">restoreParentSource.</param>
        /// <param name="restorePublicFoldersParams">restorePublicFoldersParams.</param>
        /// <param name="restoreSiteParams">restoreSiteParams.</param>
        /// <param name="restoreTaskStateProtoTmpl">restoreTaskStateProtoTmpl.</param>
        /// <param name="restoreTaskVec">Even if the user wanted to restore an entire job from the latest snapshot, this will have info of all the individual objects..</param>
        /// <param name="restoreTeamsParams">restoreTeamsParams.</param>
        /// <param name="restoreVmwareVmParams">restoreVmwareVmParams.</param>
        /// <param name="restoredObjectsNetworkConfig">restoredObjectsNetworkConfig.</param>
        /// <param name="restoredToDifferentSource">Whether restore is being performed to a different parent source..</param>
        /// <param name="skipImageDeploy">This flag can be set to true to just create the image and not deploy the VM. This flag is set to true during the DR operation that is invoked via runbooks, the creation of image(AMI in case of AWS) and snapshots of the data disk is achieved by invoking a restore of type kConvertAndDeployVMs and orchestration of the VMs is achieved by runbooks..</param>
        /// <param name="skipRigelForRestore">Whether to skip Rigel for restore or not. This field is applicable only for DMaaS. This field is currently being used in DRaaS workflows only..</param>
        /// <param name="startTimeUsecs">The start time for this restore job..</param>
        /// <param name="status">Status of the restore job..</param>
        /// <param name="targetViewName">Name of the external view that the user specifies for restore operations. This field will be used to populate \&quot;full_view_name\&quot; field in PerformRestoreTaskStateProto so that each restore task uses the same view to clone the files into. This field currently only used for recovery type of kCloneVMs backed up using CDP VMs..</param>
        /// <param name="type">The type of restore being performed..</param>
        /// <param name="user">The user who requested this restore job..</param>
        /// <param name="userInfo">userInfo.</param>
        /// <param name="vcdConfig">vcdConfig.</param>
        /// <param name="viewBoxId">The view box id to which the restore job belongs to..</param>
        /// <param name="viewParams">viewParams.</param>
        /// <param name="warnings">Populate warnings on the job if any. The warning messages are propagated from the child restore tasks upon completion of the task..</param>
        public PerformRestoreJobStateProto(long? admittedTimeUsecs = default(long?), bool? cancellationRequested = default(bool?), bool? continueRestoreOnError = default(bool?), DeployVMsToCloudTaskStateProto deployVmsToCloudTaskState = default(DeployVMsToCloudTaskStateProto), long? endTimeUsecs = default(long?), ErrorProto error = default(ErrorProto), string name = default(string), NoSqlConnectParams nosqlConnectParams = default(NoSqlConnectParams), NoSqlRecoverJobParams nosqlRecoverJobParams = default(NoSqlRecoverJobParams), List<RestoreObject> objects = default(List<RestoreObject>), ConnectorParams parentSourceConnectionParams = default(ConnectorParams), bool? physicalFlrParallelRestore = default(bool?), PowerStateConfigProto powerStateConfig = default(PowerStateConfigProto), bool? preserveTags = default(bool?), string progressMonitorTaskPath = default(string), RenameObjectParamProto renameRestoredObjectParam = default(RenameObjectParamProto), RenameObjectParamProto renameRestoredVappParam = default(RenameObjectParamProto), RestoreAcropolisVMsParams restoreAcropolisVmsParams = default(RestoreAcropolisVMsParams), RestoreO365GroupsParams restoreGroupsParams = default(RestoreO365GroupsParams), long? restoreJobId = default(long?), UniversalIdProto restoreJobUid = default(UniversalIdProto), RestoreKubernetesNamespacesParams restoreKubernetesNamespacesParams = default(RestoreKubernetesNamespacesParams), RestoreKVMVMsParams restoreKvmVmsParams = default(RestoreKVMVMsParams), EntityProto restoreParentSource = default(EntityProto), RestoreO365PublicFoldersParams restorePublicFoldersParams = default(RestoreO365PublicFoldersParams), RestoreSiteParams restoreSiteParams = default(RestoreSiteParams), PerformRestoreTaskStateProto restoreTaskStateProtoTmpl = default(PerformRestoreTaskStateProto), List<PerformRestoreJobStateProtoRestoreTask> restoreTaskVec = default(List<PerformRestoreJobStateProtoRestoreTask>), RestoreO365TeamsParams restoreTeamsParams = default(RestoreO365TeamsParams), RestoreVMwareVMParams restoreVmwareVmParams = default(RestoreVMwareVMParams), RestoredObjectNetworkConfigProto restoredObjectsNetworkConfig = default(RestoredObjectNetworkConfigProto), bool? restoredToDifferentSource = default(bool?), bool? skipImageDeploy = default(bool?), bool? skipRigelForRestore = default(bool?), long? startTimeUsecs = default(long?), int? status = default(int?), string targetViewName = default(string), int? type = default(int?), string user = default(string), UserInformation userInfo = default(UserInformation), RestoredObjectVCDConfigProto vcdConfig = default(RestoredObjectVCDConfigProto), long? viewBoxId = default(long?), ViewParams viewParams = default(ViewParams), List<ErrorProto> warnings = default(List<ErrorProto>))
        {
            this.AdmittedTimeUsecs = admittedTimeUsecs;
            this.CancellationRequested = cancellationRequested;
            this.ContinueRestoreOnError = continueRestoreOnError;
            this.DeployVmsToCloudTaskState = deployVmsToCloudTaskState;
            this.EndTimeUsecs = endTimeUsecs;
            this.Error = error;
            this.Name = name;
            this.NosqlConnectParams = nosqlConnectParams;
            this.NosqlRecoverJobParams = nosqlRecoverJobParams;
            this.Objects = objects;
            this.ParentSourceConnectionParams = parentSourceConnectionParams;
            this.PhysicalFlrParallelRestore = physicalFlrParallelRestore;
            this.PowerStateConfig = powerStateConfig;
            this.PreserveTags = preserveTags;
            this.ProgressMonitorTaskPath = progressMonitorTaskPath;
            this.RenameRestoredObjectParam = renameRestoredObjectParam;
            this.RenameRestoredVappParam = renameRestoredVappParam;
            this.RestoreAcropolisVmsParams = restoreAcropolisVmsParams;
            this.RestoreGroupsParams = restoreGroupsParams;
            this.RestoreJobId = restoreJobId;
            this.RestoreJobUid = restoreJobUid;
            this.RestoreKubernetesNamespacesParams = restoreKubernetesNamespacesParams;
            this.RestoreKvmVmsParams = restoreKvmVmsParams;
            this.RestoreParentSource = restoreParentSource;
            this.RestorePublicFoldersParams = restorePublicFoldersParams;
            this.RestoreSiteParams = restoreSiteParams;
            this.RestoreTaskStateProtoTmpl = restoreTaskStateProtoTmpl;
            this.RestoreTaskVec = restoreTaskVec;
            this.RestoreTeamsParams = restoreTeamsParams;
            this.RestoreVmwareVmParams = restoreVmwareVmParams;
            this.RestoredObjectsNetworkConfig = restoredObjectsNetworkConfig;
            this.RestoredToDifferentSource = restoredToDifferentSource;
            this.SkipImageDeploy = skipImageDeploy;
            this.SkipRigelForRestore = skipRigelForRestore;
            this.StartTimeUsecs = startTimeUsecs;
            this.Status = status;
            this.TargetViewName = targetViewName;
            this.Type = type;
            this.User = user;
            this.UserInfo = userInfo;
            this.VcdConfig = vcdConfig;
            this.ViewBoxId = viewBoxId;
            this.ViewParams = viewParams;
            this.Warnings = warnings;
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
        /// Gets or Sets NosqlConnectParams
        /// </summary>
        [DataMember(Name="nosqlConnectParams", EmitDefaultValue=false)]
        public NoSqlConnectParams NosqlConnectParams { get; set; }

        /// <summary>
        /// Gets or Sets NosqlRecoverJobParams
        /// </summary>
        [DataMember(Name="nosqlRecoverJobParams", EmitDefaultValue=false)]
        public NoSqlRecoverJobParams NosqlRecoverJobParams { get; set; }

        /// <summary>
        /// Information on the exact set of objects being restored (along with snapshots they are being recovered from). Even if the user wanted to restore an entire job form the latest snapshot, this will have individual objects and the exact snapshot they are bein restored from. If specified, this can only have leaf-level entities.
        /// </summary>
        /// <value>Information on the exact set of objects being restored (along with snapshots they are being recovered from). Even if the user wanted to restore an entire job form the latest snapshot, this will have individual objects and the exact snapshot they are bein restored from. If specified, this can only have leaf-level entities.</value>
        [DataMember(Name="objects", EmitDefaultValue=true)]
        public List<RestoreObject> Objects { get; set; }

        /// <summary>
        /// Gets or Sets ParentSourceConnectionParams
        /// </summary>
        [DataMember(Name="parentSourceConnectionParams", EmitDefaultValue=false)]
        public ConnectorParams ParentSourceConnectionParams { get; set; }

        /// <summary>
        /// If enabled, magneto physical file restore will be enabled via job framework
        /// </summary>
        /// <value>If enabled, magneto physical file restore will be enabled via job framework</value>
        [DataMember(Name="physicalFlrParallelRestore", EmitDefaultValue=true)]
        public bool? PhysicalFlrParallelRestore { get; set; }

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
        /// Gets or Sets RenameRestoredVappParam
        /// </summary>
        [DataMember(Name="renameRestoredVappParam", EmitDefaultValue=false)]
        public RenameObjectParamProto RenameRestoredVappParam { get; set; }

        /// <summary>
        /// Gets or Sets RestoreAcropolisVmsParams
        /// </summary>
        [DataMember(Name="restoreAcropolisVmsParams", EmitDefaultValue=false)]
        public RestoreAcropolisVMsParams RestoreAcropolisVmsParams { get; set; }

        /// <summary>
        /// Gets or Sets RestoreGroupsParams
        /// </summary>
        [DataMember(Name="restoreGroupsParams", EmitDefaultValue=false)]
        public RestoreO365GroupsParams RestoreGroupsParams { get; set; }

        /// <summary>
        /// A unique id for this restore job within the cluster.
        /// </summary>
        /// <value>A unique id for this restore job within the cluster.</value>
        [DataMember(Name="restoreJobId", EmitDefaultValue=true)]
        public long? RestoreJobId { get; set; }

        /// <summary>
        /// Gets or Sets RestoreJobUid
        /// </summary>
        [DataMember(Name="restoreJobUid", EmitDefaultValue=false)]
        public UniversalIdProto RestoreJobUid { get; set; }

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
        /// Gets or Sets RestorePublicFoldersParams
        /// </summary>
        [DataMember(Name="restorePublicFoldersParams", EmitDefaultValue=false)]
        public RestoreO365PublicFoldersParams RestorePublicFoldersParams { get; set; }

        /// <summary>
        /// Gets or Sets RestoreSiteParams
        /// </summary>
        [DataMember(Name="restoreSiteParams", EmitDefaultValue=false)]
        public RestoreSiteParams RestoreSiteParams { get; set; }

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
        /// Gets or Sets RestoreTeamsParams
        /// </summary>
        [DataMember(Name="restoreTeamsParams", EmitDefaultValue=false)]
        public RestoreO365TeamsParams RestoreTeamsParams { get; set; }

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
        /// This flag can be set to true to just create the image and not deploy the VM. This flag is set to true during the DR operation that is invoked via runbooks, the creation of image(AMI in case of AWS) and snapshots of the data disk is achieved by invoking a restore of type kConvertAndDeployVMs and orchestration of the VMs is achieved by runbooks.
        /// </summary>
        /// <value>This flag can be set to true to just create the image and not deploy the VM. This flag is set to true during the DR operation that is invoked via runbooks, the creation of image(AMI in case of AWS) and snapshots of the data disk is achieved by invoking a restore of type kConvertAndDeployVMs and orchestration of the VMs is achieved by runbooks.</value>
        [DataMember(Name="skipImageDeploy", EmitDefaultValue=true)]
        public bool? SkipImageDeploy { get; set; }

        /// <summary>
        /// Whether to skip Rigel for restore or not. This field is applicable only for DMaaS. This field is currently being used in DRaaS workflows only.
        /// </summary>
        /// <value>Whether to skip Rigel for restore or not. This field is applicable only for DMaaS. This field is currently being used in DRaaS workflows only.</value>
        [DataMember(Name="skipRigelForRestore", EmitDefaultValue=true)]
        public bool? SkipRigelForRestore { get; set; }

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
        /// Name of the external view that the user specifies for restore operations. This field will be used to populate \&quot;full_view_name\&quot; field in PerformRestoreTaskStateProto so that each restore task uses the same view to clone the files into. This field currently only used for recovery type of kCloneVMs backed up using CDP VMs.
        /// </summary>
        /// <value>Name of the external view that the user specifies for restore operations. This field will be used to populate \&quot;full_view_name\&quot; field in PerformRestoreTaskStateProto so that each restore task uses the same view to clone the files into. This field currently only used for recovery type of kCloneVMs backed up using CDP VMs.</value>
        [DataMember(Name="targetViewName", EmitDefaultValue=true)]
        public string TargetViewName { get; set; }

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
        /// Gets or Sets VcdConfig
        /// </summary>
        [DataMember(Name="vcdConfig", EmitDefaultValue=false)]
        public RestoredObjectVCDConfigProto VcdConfig { get; set; }

        /// <summary>
        /// The view box id to which the restore job belongs to.
        /// </summary>
        /// <value>The view box id to which the restore job belongs to.</value>
        [DataMember(Name="viewBoxId", EmitDefaultValue=true)]
        public long? ViewBoxId { get; set; }

        /// <summary>
        /// Gets or Sets ViewParams
        /// </summary>
        [DataMember(Name="viewParams", EmitDefaultValue=false)]
        public ViewParams ViewParams { get; set; }

        /// <summary>
        /// Populate warnings on the job if any. The warning messages are propagated from the child restore tasks upon completion of the task.
        /// </summary>
        /// <value>Populate warnings on the job if any. The warning messages are propagated from the child restore tasks upon completion of the task.</value>
        [DataMember(Name="warnings", EmitDefaultValue=true)]
        public List<ErrorProto> Warnings { get; set; }

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
                    this.NosqlConnectParams == input.NosqlConnectParams ||
                    (this.NosqlConnectParams != null &&
                    this.NosqlConnectParams.Equals(input.NosqlConnectParams))
                ) && 
                (
                    this.NosqlRecoverJobParams == input.NosqlRecoverJobParams ||
                    (this.NosqlRecoverJobParams != null &&
                    this.NosqlRecoverJobParams.Equals(input.NosqlRecoverJobParams))
                ) && 
                (
                    this.Objects == input.Objects ||
                    this.Objects != null &&
                    input.Objects != null &&
                    this.Objects.Equals(input.Objects)
                ) && 
                (
                    this.ParentSourceConnectionParams == input.ParentSourceConnectionParams ||
                    (this.ParentSourceConnectionParams != null &&
                    this.ParentSourceConnectionParams.Equals(input.ParentSourceConnectionParams))
                ) && 
                (
                    this.PhysicalFlrParallelRestore == input.PhysicalFlrParallelRestore ||
                    (this.PhysicalFlrParallelRestore != null &&
                    this.PhysicalFlrParallelRestore.Equals(input.PhysicalFlrParallelRestore))
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
                    this.RenameRestoredVappParam == input.RenameRestoredVappParam ||
                    (this.RenameRestoredVappParam != null &&
                    this.RenameRestoredVappParam.Equals(input.RenameRestoredVappParam))
                ) && 
                (
                    this.RestoreAcropolisVmsParams == input.RestoreAcropolisVmsParams ||
                    (this.RestoreAcropolisVmsParams != null &&
                    this.RestoreAcropolisVmsParams.Equals(input.RestoreAcropolisVmsParams))
                ) && 
                (
                    this.RestoreGroupsParams == input.RestoreGroupsParams ||
                    (this.RestoreGroupsParams != null &&
                    this.RestoreGroupsParams.Equals(input.RestoreGroupsParams))
                ) && 
                (
                    this.RestoreJobId == input.RestoreJobId ||
                    (this.RestoreJobId != null &&
                    this.RestoreJobId.Equals(input.RestoreJobId))
                ) && 
                (
                    this.RestoreJobUid == input.RestoreJobUid ||
                    (this.RestoreJobUid != null &&
                    this.RestoreJobUid.Equals(input.RestoreJobUid))
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
                    this.RestorePublicFoldersParams == input.RestorePublicFoldersParams ||
                    (this.RestorePublicFoldersParams != null &&
                    this.RestorePublicFoldersParams.Equals(input.RestorePublicFoldersParams))
                ) && 
                (
                    this.RestoreSiteParams == input.RestoreSiteParams ||
                    (this.RestoreSiteParams != null &&
                    this.RestoreSiteParams.Equals(input.RestoreSiteParams))
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
                    this.RestoreTaskVec.Equals(input.RestoreTaskVec)
                ) && 
                (
                    this.RestoreTeamsParams == input.RestoreTeamsParams ||
                    (this.RestoreTeamsParams != null &&
                    this.RestoreTeamsParams.Equals(input.RestoreTeamsParams))
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
                    this.SkipImageDeploy == input.SkipImageDeploy ||
                    (this.SkipImageDeploy != null &&
                    this.SkipImageDeploy.Equals(input.SkipImageDeploy))
                ) && 
                (
                    this.SkipRigelForRestore == input.SkipRigelForRestore ||
                    (this.SkipRigelForRestore != null &&
                    this.SkipRigelForRestore.Equals(input.SkipRigelForRestore))
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
                    this.TargetViewName == input.TargetViewName ||
                    (this.TargetViewName != null &&
                    this.TargetViewName.Equals(input.TargetViewName))
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
                    this.VcdConfig == input.VcdConfig ||
                    (this.VcdConfig != null &&
                    this.VcdConfig.Equals(input.VcdConfig))
                ) && 
                (
                    this.ViewBoxId == input.ViewBoxId ||
                    (this.ViewBoxId != null &&
                    this.ViewBoxId.Equals(input.ViewBoxId))
                ) && 
                (
                    this.ViewParams == input.ViewParams ||
                    (this.ViewParams != null &&
                    this.ViewParams.Equals(input.ViewParams))
                ) && 
                (
                    this.Warnings == input.Warnings ||
                    this.Warnings != null &&
                    input.Warnings != null &&
                    this.Warnings.Equals(input.Warnings)
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
                if (this.NosqlConnectParams != null)
                    hashCode = hashCode * 59 + this.NosqlConnectParams.GetHashCode();
                if (this.NosqlRecoverJobParams != null)
                    hashCode = hashCode * 59 + this.NosqlRecoverJobParams.GetHashCode();
                if (this.Objects != null)
                    hashCode = hashCode * 59 + this.Objects.GetHashCode();
                if (this.ParentSourceConnectionParams != null)
                    hashCode = hashCode * 59 + this.ParentSourceConnectionParams.GetHashCode();
                if (this.PhysicalFlrParallelRestore != null)
                    hashCode = hashCode * 59 + this.PhysicalFlrParallelRestore.GetHashCode();
                if (this.PowerStateConfig != null)
                    hashCode = hashCode * 59 + this.PowerStateConfig.GetHashCode();
                if (this.PreserveTags != null)
                    hashCode = hashCode * 59 + this.PreserveTags.GetHashCode();
                if (this.ProgressMonitorTaskPath != null)
                    hashCode = hashCode * 59 + this.ProgressMonitorTaskPath.GetHashCode();
                if (this.RenameRestoredObjectParam != null)
                    hashCode = hashCode * 59 + this.RenameRestoredObjectParam.GetHashCode();
                if (this.RenameRestoredVappParam != null)
                    hashCode = hashCode * 59 + this.RenameRestoredVappParam.GetHashCode();
                if (this.RestoreAcropolisVmsParams != null)
                    hashCode = hashCode * 59 + this.RestoreAcropolisVmsParams.GetHashCode();
                if (this.RestoreGroupsParams != null)
                    hashCode = hashCode * 59 + this.RestoreGroupsParams.GetHashCode();
                if (this.RestoreJobId != null)
                    hashCode = hashCode * 59 + this.RestoreJobId.GetHashCode();
                if (this.RestoreJobUid != null)
                    hashCode = hashCode * 59 + this.RestoreJobUid.GetHashCode();
                if (this.RestoreKubernetesNamespacesParams != null)
                    hashCode = hashCode * 59 + this.RestoreKubernetesNamespacesParams.GetHashCode();
                if (this.RestoreKvmVmsParams != null)
                    hashCode = hashCode * 59 + this.RestoreKvmVmsParams.GetHashCode();
                if (this.RestoreParentSource != null)
                    hashCode = hashCode * 59 + this.RestoreParentSource.GetHashCode();
                if (this.RestorePublicFoldersParams != null)
                    hashCode = hashCode * 59 + this.RestorePublicFoldersParams.GetHashCode();
                if (this.RestoreSiteParams != null)
                    hashCode = hashCode * 59 + this.RestoreSiteParams.GetHashCode();
                if (this.RestoreTaskStateProtoTmpl != null)
                    hashCode = hashCode * 59 + this.RestoreTaskStateProtoTmpl.GetHashCode();
                if (this.RestoreTaskVec != null)
                    hashCode = hashCode * 59 + this.RestoreTaskVec.GetHashCode();
                if (this.RestoreTeamsParams != null)
                    hashCode = hashCode * 59 + this.RestoreTeamsParams.GetHashCode();
                if (this.RestoreVmwareVmParams != null)
                    hashCode = hashCode * 59 + this.RestoreVmwareVmParams.GetHashCode();
                if (this.RestoredObjectsNetworkConfig != null)
                    hashCode = hashCode * 59 + this.RestoredObjectsNetworkConfig.GetHashCode();
                if (this.RestoredToDifferentSource != null)
                    hashCode = hashCode * 59 + this.RestoredToDifferentSource.GetHashCode();
                if (this.SkipImageDeploy != null)
                    hashCode = hashCode * 59 + this.SkipImageDeploy.GetHashCode();
                if (this.SkipRigelForRestore != null)
                    hashCode = hashCode * 59 + this.SkipRigelForRestore.GetHashCode();
                if (this.StartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.StartTimeUsecs.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TargetViewName != null)
                    hashCode = hashCode * 59 + this.TargetViewName.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.UserInfo != null)
                    hashCode = hashCode * 59 + this.UserInfo.GetHashCode();
                if (this.VcdConfig != null)
                    hashCode = hashCode * 59 + this.VcdConfig.GetHashCode();
                if (this.ViewBoxId != null)
                    hashCode = hashCode * 59 + this.ViewBoxId.GetHashCode();
                if (this.ViewParams != null)
                    hashCode = hashCode * 59 + this.ViewParams.GetHashCode();
                if (this.Warnings != null)
                    hashCode = hashCode * 59 + this.Warnings.GetHashCode();
                return hashCode;
            }
        }

    }

}


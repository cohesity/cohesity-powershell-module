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
    /// DestroyClonedTaskStateProto
    /// </summary>
    [DataContract]
    public partial class DestroyClonedTaskStateProto :  IEquatable<DestroyClonedTaskStateProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestroyClonedTaskStateProto" /> class.
        /// </summary>
        /// <param name="actionExecutorTargetType">Denotes the target for action executor(Bridge/Bridge_Proxy) on which task on slave should execute actions..</param>
        /// <param name="cloneTaskName">The name of the clone task..</param>
        /// <param name="datastoreEntity">datastoreEntity.</param>
        /// <param name="deployVmsToCloudTaskState">deployVmsToCloudTaskState.</param>
        /// <param name="destroyCloneAppTaskInfo">destroyCloneAppTaskInfo.</param>
        /// <param name="destroyCloneVmTaskInfo">destroyCloneVmTaskInfo.</param>
        /// <param name="destroyMountVolumesTaskInfo">destroyMountVolumesTaskInfo.</param>
        /// <param name="endTimeUsecs">If the destroy clone task has finished, this field contains the end time of the task..</param>
        /// <param name="error">error.</param>
        /// <param name="folderEntity">folderEntity.</param>
        /// <param name="forceDelete">flag used to perform force delete, ignore error on delete steps.</param>
        /// <param name="fullViewName">The full external view name where cloned objects are placed..</param>
        /// <param name="parentSourceConnectionParams">parentSourceConnectionParams.</param>
        /// <param name="parentTaskId">The id of the task that triggered the destroy task. This will be used by refresh task to mark the destroy task as internal sub-task..</param>
        /// <param name="performCloneTaskId">The unique id of the task that performed the clone operation..</param>
        /// <param name="restoreType">The type of the restore/clone operation that is being destroyed..</param>
        /// <param name="scheduledConstituentId">Constituent id (and the gandalf session id) where this task has been scheduled. If -1, the task is not running at any slave. It&#39;s possible that the task was previously scheduled, but is now being re-scheduled..</param>
        /// <param name="scheduledGandalfSessionId">scheduledGandalfSessionId.</param>
        /// <param name="startTimeUsecs">The start time of this destroy clone task..</param>
        /// <param name="status">Status of the destroy clone task..</param>
        /// <param name="taskId">A globally unique id of this destroy clone task..</param>
        /// <param name="type">The type of environment that is being operated on..</param>
        /// <param name="user">The user who requested this destroy clone task..</param>
        /// <param name="userInfo">userInfo.</param>
        /// <param name="vcdConfig">vcdConfig.</param>
        /// <param name="viewBoxId">The view box id to which &#39;view_name&#39; belongs to..</param>
        /// <param name="viewNameDEPRECATED">The view name as provided by the user for the clone operation..</param>
        public DestroyClonedTaskStateProto(int? actionExecutorTargetType = default(int?), string cloneTaskName = default(string), EntityProto datastoreEntity = default(EntityProto), DeployVMsToCloudTaskStateProto deployVmsToCloudTaskState = default(DeployVMsToCloudTaskStateProto), DestroyCloneAppTaskInfoProto destroyCloneAppTaskInfo = default(DestroyCloneAppTaskInfoProto), DestroyClonedVMTaskInfoProto destroyCloneVmTaskInfo = default(DestroyClonedVMTaskInfoProto), DestroyMountVolumesTaskInfoProto destroyMountVolumesTaskInfo = default(DestroyMountVolumesTaskInfoProto), long? endTimeUsecs = default(long?), ErrorProto error = default(ErrorProto), EntityProto folderEntity = default(EntityProto), bool? forceDelete = default(bool?), string fullViewName = default(string), ConnectorParams parentSourceConnectionParams = default(ConnectorParams), long? parentTaskId = default(long?), long? performCloneTaskId = default(long?), int? restoreType = default(int?), long? scheduledConstituentId = default(long?), long? scheduledGandalfSessionId = default(long?), long? startTimeUsecs = default(long?), int? status = default(int?), long? taskId = default(long?), int? type = default(int?), string user = default(string), UserInformation userInfo = default(UserInformation), RestoredObjectVCDConfigProto vcdConfig = default(RestoredObjectVCDConfigProto), long? viewBoxId = default(long?), string viewNameDEPRECATED = default(string))
        {
            this.ActionExecutorTargetType = actionExecutorTargetType;
            this.CloneTaskName = cloneTaskName;
            this.DatastoreEntity = datastoreEntity;
            this.DeployVmsToCloudTaskState = deployVmsToCloudTaskState;
            this.DestroyCloneAppTaskInfo = destroyCloneAppTaskInfo;
            this.DestroyCloneVmTaskInfo = destroyCloneVmTaskInfo;
            this.DestroyMountVolumesTaskInfo = destroyMountVolumesTaskInfo;
            this.EndTimeUsecs = endTimeUsecs;
            this.Error = error;
            this.FolderEntity = folderEntity;
            this.ForceDelete = forceDelete;
            this.FullViewName = fullViewName;
            this.ParentSourceConnectionParams = parentSourceConnectionParams;
            this.ParentTaskId = parentTaskId;
            this.PerformCloneTaskId = performCloneTaskId;
            this.RestoreType = restoreType;
            this.ScheduledConstituentId = scheduledConstituentId;
            this.ScheduledGandalfSessionId = scheduledGandalfSessionId;
            this.StartTimeUsecs = startTimeUsecs;
            this.Status = status;
            this.TaskId = taskId;
            this.Type = type;
            this.User = user;
            this.UserInfo = userInfo;
            this.VcdConfig = vcdConfig;
            this.ViewBoxId = viewBoxId;
            this.ViewNameDEPRECATED = viewNameDEPRECATED;
        }
        
        /// <summary>
        /// Denotes the target for action executor(Bridge/Bridge_Proxy) on which task on slave should execute actions.
        /// </summary>
        /// <value>Denotes the target for action executor(Bridge/Bridge_Proxy) on which task on slave should execute actions.</value>
        [DataMember(Name="actionExecutorTargetType", EmitDefaultValue=false)]
        public int? ActionExecutorTargetType { get; set; }

        /// <summary>
        /// The name of the clone task.
        /// </summary>
        /// <value>The name of the clone task.</value>
        [DataMember(Name="cloneTaskName", EmitDefaultValue=false)]
        public string CloneTaskName { get; set; }

        /// <summary>
        /// Gets or Sets DatastoreEntity
        /// </summary>
        [DataMember(Name="datastoreEntity", EmitDefaultValue=false)]
        public EntityProto DatastoreEntity { get; set; }

        /// <summary>
        /// Gets or Sets DeployVmsToCloudTaskState
        /// </summary>
        [DataMember(Name="deployVmsToCloudTaskState", EmitDefaultValue=false)]
        public DeployVMsToCloudTaskStateProto DeployVmsToCloudTaskState { get; set; }

        /// <summary>
        /// Gets or Sets DestroyCloneAppTaskInfo
        /// </summary>
        [DataMember(Name="destroyCloneAppTaskInfo", EmitDefaultValue=false)]
        public DestroyCloneAppTaskInfoProto DestroyCloneAppTaskInfo { get; set; }

        /// <summary>
        /// Gets or Sets DestroyCloneVmTaskInfo
        /// </summary>
        [DataMember(Name="destroyCloneVmTaskInfo", EmitDefaultValue=false)]
        public DestroyClonedVMTaskInfoProto DestroyCloneVmTaskInfo { get; set; }

        /// <summary>
        /// Gets or Sets DestroyMountVolumesTaskInfo
        /// </summary>
        [DataMember(Name="destroyMountVolumesTaskInfo", EmitDefaultValue=false)]
        public DestroyMountVolumesTaskInfoProto DestroyMountVolumesTaskInfo { get; set; }

        /// <summary>
        /// If the destroy clone task has finished, this field contains the end time of the task.
        /// </summary>
        /// <value>If the destroy clone task has finished, this field contains the end time of the task.</value>
        [DataMember(Name="endTimeUsecs", EmitDefaultValue=false)]
        public long? EndTimeUsecs { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public ErrorProto Error { get; set; }

        /// <summary>
        /// Gets or Sets FolderEntity
        /// </summary>
        [DataMember(Name="folderEntity", EmitDefaultValue=false)]
        public EntityProto FolderEntity { get; set; }

        /// <summary>
        /// flag used to perform force delete, ignore error on delete steps
        /// </summary>
        /// <value>flag used to perform force delete, ignore error on delete steps</value>
        [DataMember(Name="forceDelete", EmitDefaultValue=false)]
        public bool? ForceDelete { get; set; }

        /// <summary>
        /// The full external view name where cloned objects are placed.
        /// </summary>
        /// <value>The full external view name where cloned objects are placed.</value>
        [DataMember(Name="fullViewName", EmitDefaultValue=false)]
        public string FullViewName { get; set; }

        /// <summary>
        /// Gets or Sets ParentSourceConnectionParams
        /// </summary>
        [DataMember(Name="parentSourceConnectionParams", EmitDefaultValue=false)]
        public ConnectorParams ParentSourceConnectionParams { get; set; }

        /// <summary>
        /// The id of the task that triggered the destroy task. This will be used by refresh task to mark the destroy task as internal sub-task.
        /// </summary>
        /// <value>The id of the task that triggered the destroy task. This will be used by refresh task to mark the destroy task as internal sub-task.</value>
        [DataMember(Name="parentTaskId", EmitDefaultValue=false)]
        public long? ParentTaskId { get; set; }

        /// <summary>
        /// The unique id of the task that performed the clone operation.
        /// </summary>
        /// <value>The unique id of the task that performed the clone operation.</value>
        [DataMember(Name="performCloneTaskId", EmitDefaultValue=false)]
        public long? PerformCloneTaskId { get; set; }

        /// <summary>
        /// The type of the restore/clone operation that is being destroyed.
        /// </summary>
        /// <value>The type of the restore/clone operation that is being destroyed.</value>
        [DataMember(Name="restoreType", EmitDefaultValue=false)]
        public int? RestoreType { get; set; }

        /// <summary>
        /// Constituent id (and the gandalf session id) where this task has been scheduled. If -1, the task is not running at any slave. It&#39;s possible that the task was previously scheduled, but is now being re-scheduled.
        /// </summary>
        /// <value>Constituent id (and the gandalf session id) where this task has been scheduled. If -1, the task is not running at any slave. It&#39;s possible that the task was previously scheduled, but is now being re-scheduled.</value>
        [DataMember(Name="scheduledConstituentId", EmitDefaultValue=false)]
        public long? ScheduledConstituentId { get; set; }

        /// <summary>
        /// Gets or Sets ScheduledGandalfSessionId
        /// </summary>
        [DataMember(Name="scheduledGandalfSessionId", EmitDefaultValue=false)]
        public long? ScheduledGandalfSessionId { get; set; }

        /// <summary>
        /// The start time of this destroy clone task.
        /// </summary>
        /// <value>The start time of this destroy clone task.</value>
        [DataMember(Name="startTimeUsecs", EmitDefaultValue=false)]
        public long? StartTimeUsecs { get; set; }

        /// <summary>
        /// Status of the destroy clone task.
        /// </summary>
        /// <value>Status of the destroy clone task.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }

        /// <summary>
        /// A globally unique id of this destroy clone task.
        /// </summary>
        /// <value>A globally unique id of this destroy clone task.</value>
        [DataMember(Name="taskId", EmitDefaultValue=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// The type of environment that is being operated on.
        /// </summary>
        /// <value>The type of environment that is being operated on.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public int? Type { get; set; }

        /// <summary>
        /// The user who requested this destroy clone task.
        /// </summary>
        /// <value>The user who requested this destroy clone task.</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
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
        /// The view box id to which &#39;view_name&#39; belongs to.
        /// </summary>
        /// <value>The view box id to which &#39;view_name&#39; belongs to.</value>
        [DataMember(Name="viewBoxId", EmitDefaultValue=false)]
        public long? ViewBoxId { get; set; }

        /// <summary>
        /// The view name as provided by the user for the clone operation.
        /// </summary>
        /// <value>The view name as provided by the user for the clone operation.</value>
        [DataMember(Name="viewName_DEPRECATED", EmitDefaultValue=false)]
        public string ViewNameDEPRECATED { get; set; }

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
            return this.Equals(input as DestroyClonedTaskStateProto);
        }

        /// <summary>
        /// Returns true if DestroyClonedTaskStateProto instances are equal
        /// </summary>
        /// <param name="input">Instance of DestroyClonedTaskStateProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestroyClonedTaskStateProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActionExecutorTargetType == input.ActionExecutorTargetType ||
                    (this.ActionExecutorTargetType != null &&
                    this.ActionExecutorTargetType.Equals(input.ActionExecutorTargetType))
                ) && 
                (
                    this.CloneTaskName == input.CloneTaskName ||
                    (this.CloneTaskName != null &&
                    this.CloneTaskName.Equals(input.CloneTaskName))
                ) && 
                (
                    this.DatastoreEntity == input.DatastoreEntity ||
                    (this.DatastoreEntity != null &&
                    this.DatastoreEntity.Equals(input.DatastoreEntity))
                ) && 
                (
                    this.DeployVmsToCloudTaskState == input.DeployVmsToCloudTaskState ||
                    (this.DeployVmsToCloudTaskState != null &&
                    this.DeployVmsToCloudTaskState.Equals(input.DeployVmsToCloudTaskState))
                ) && 
                (
                    this.DestroyCloneAppTaskInfo == input.DestroyCloneAppTaskInfo ||
                    (this.DestroyCloneAppTaskInfo != null &&
                    this.DestroyCloneAppTaskInfo.Equals(input.DestroyCloneAppTaskInfo))
                ) && 
                (
                    this.DestroyCloneVmTaskInfo == input.DestroyCloneVmTaskInfo ||
                    (this.DestroyCloneVmTaskInfo != null &&
                    this.DestroyCloneVmTaskInfo.Equals(input.DestroyCloneVmTaskInfo))
                ) && 
                (
                    this.DestroyMountVolumesTaskInfo == input.DestroyMountVolumesTaskInfo ||
                    (this.DestroyMountVolumesTaskInfo != null &&
                    this.DestroyMountVolumesTaskInfo.Equals(input.DestroyMountVolumesTaskInfo))
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
                    this.FolderEntity == input.FolderEntity ||
                    (this.FolderEntity != null &&
                    this.FolderEntity.Equals(input.FolderEntity))
                ) && 
                (
                    this.ForceDelete == input.ForceDelete ||
                    (this.ForceDelete != null &&
                    this.ForceDelete.Equals(input.ForceDelete))
                ) && 
                (
                    this.FullViewName == input.FullViewName ||
                    (this.FullViewName != null &&
                    this.FullViewName.Equals(input.FullViewName))
                ) && 
                (
                    this.ParentSourceConnectionParams == input.ParentSourceConnectionParams ||
                    (this.ParentSourceConnectionParams != null &&
                    this.ParentSourceConnectionParams.Equals(input.ParentSourceConnectionParams))
                ) && 
                (
                    this.ParentTaskId == input.ParentTaskId ||
                    (this.ParentTaskId != null &&
                    this.ParentTaskId.Equals(input.ParentTaskId))
                ) && 
                (
                    this.PerformCloneTaskId == input.PerformCloneTaskId ||
                    (this.PerformCloneTaskId != null &&
                    this.PerformCloneTaskId.Equals(input.PerformCloneTaskId))
                ) && 
                (
                    this.RestoreType == input.RestoreType ||
                    (this.RestoreType != null &&
                    this.RestoreType.Equals(input.RestoreType))
                ) && 
                (
                    this.ScheduledConstituentId == input.ScheduledConstituentId ||
                    (this.ScheduledConstituentId != null &&
                    this.ScheduledConstituentId.Equals(input.ScheduledConstituentId))
                ) && 
                (
                    this.ScheduledGandalfSessionId == input.ScheduledGandalfSessionId ||
                    (this.ScheduledGandalfSessionId != null &&
                    this.ScheduledGandalfSessionId.Equals(input.ScheduledGandalfSessionId))
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
                    this.TaskId == input.TaskId ||
                    (this.TaskId != null &&
                    this.TaskId.Equals(input.TaskId))
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
                    this.ViewNameDEPRECATED == input.ViewNameDEPRECATED ||
                    (this.ViewNameDEPRECATED != null &&
                    this.ViewNameDEPRECATED.Equals(input.ViewNameDEPRECATED))
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
                if (this.ActionExecutorTargetType != null)
                    hashCode = hashCode * 59 + this.ActionExecutorTargetType.GetHashCode();
                if (this.CloneTaskName != null)
                    hashCode = hashCode * 59 + this.CloneTaskName.GetHashCode();
                if (this.DatastoreEntity != null)
                    hashCode = hashCode * 59 + this.DatastoreEntity.GetHashCode();
                if (this.DeployVmsToCloudTaskState != null)
                    hashCode = hashCode * 59 + this.DeployVmsToCloudTaskState.GetHashCode();
                if (this.DestroyCloneAppTaskInfo != null)
                    hashCode = hashCode * 59 + this.DestroyCloneAppTaskInfo.GetHashCode();
                if (this.DestroyCloneVmTaskInfo != null)
                    hashCode = hashCode * 59 + this.DestroyCloneVmTaskInfo.GetHashCode();
                if (this.DestroyMountVolumesTaskInfo != null)
                    hashCode = hashCode * 59 + this.DestroyMountVolumesTaskInfo.GetHashCode();
                if (this.EndTimeUsecs != null)
                    hashCode = hashCode * 59 + this.EndTimeUsecs.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.FolderEntity != null)
                    hashCode = hashCode * 59 + this.FolderEntity.GetHashCode();
                if (this.ForceDelete != null)
                    hashCode = hashCode * 59 + this.ForceDelete.GetHashCode();
                if (this.FullViewName != null)
                    hashCode = hashCode * 59 + this.FullViewName.GetHashCode();
                if (this.ParentSourceConnectionParams != null)
                    hashCode = hashCode * 59 + this.ParentSourceConnectionParams.GetHashCode();
                if (this.ParentTaskId != null)
                    hashCode = hashCode * 59 + this.ParentTaskId.GetHashCode();
                if (this.PerformCloneTaskId != null)
                    hashCode = hashCode * 59 + this.PerformCloneTaskId.GetHashCode();
                if (this.RestoreType != null)
                    hashCode = hashCode * 59 + this.RestoreType.GetHashCode();
                if (this.ScheduledConstituentId != null)
                    hashCode = hashCode * 59 + this.ScheduledConstituentId.GetHashCode();
                if (this.ScheduledGandalfSessionId != null)
                    hashCode = hashCode * 59 + this.ScheduledGandalfSessionId.GetHashCode();
                if (this.StartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.StartTimeUsecs.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
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
                if (this.ViewNameDEPRECATED != null)
                    hashCode = hashCode * 59 + this.ViewNameDEPRECATED.GetHashCode();
                return hashCode;
            }
        }

    }

}


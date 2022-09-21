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
    /// RestoreTaskStateBaseProto
    /// </summary>
    [DataContract]
    public partial class RestoreTaskStateBaseProto :  IEquatable<RestoreTaskStateBaseProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreTaskStateBaseProto" /> class.
        /// </summary>
        /// <param name="cancellationRequested">Whether this task has a pending cancellation request..</param>
        /// <param name="endTimeUsecs">If the restore task has finished, this field contains the end time for the task..</param>
        /// <param name="error">error.</param>
        /// <param name="isInternal">Whether the restore task is internal. This is currently used by standby restore tasks..</param>
        /// <param name="name">The name of the restore task..</param>
        /// <param name="parentSourceConnectionParams">parentSourceConnectionParams.</param>
        /// <param name="preprocessingError">preprocessingError.</param>
        /// <param name="publicStatus">Iris-facing task state. This field is stamped during the export..</param>
        /// <param name="refreshStatus">Status of the refresh task..</param>
        /// <param name="restoreVlanParams">restoreVlanParams.</param>
        /// <param name="scheduledConstituentId">Constituent id (and the gandalf session id) where this task has been scheduled. If -1, the task is not running at any slave. It&#39;s possible that the task was previously scheduled, but is now being re-scheduled..</param>
        /// <param name="scheduledGandalfSessionId">scheduledGandalfSessionId.</param>
        /// <param name="startTimeUsecs">The start time for this restore task..</param>
        /// <param name="status">Status of the restore task..</param>
        /// <param name="taskId">A unique id for this task within the cluster..</param>
        /// <param name="taskUid">taskUid.</param>
        /// <param name="totalLogicalSizeBytes">Logical size of this restore task. This is the amount of data that needs to be transferred to restore the entity..</param>
        /// <param name="totalPhysicalSizeBytes">Physical size of this restore task. This is the amount of data that was actually transferred to restore the entity..</param>
        /// <param name="type">The type of restore being performed..</param>
        /// <param name="user">The user who requested this restore task..</param>
        /// <param name="userInfo">userInfo.</param>
        /// <param name="userMessages">Messages displayed to the user for this task (if any). Only valid if the status of the task is kFinished. This is used for informing the user with additional details when there is not an error..</param>
        /// <param name="warnings">The warnings encountered by this task (if any) during its execution..</param>
        public RestoreTaskStateBaseProto(bool? cancellationRequested = default(bool?), long? endTimeUsecs = default(long?), ErrorProto error = default(ErrorProto), bool? isInternal = default(bool?), string name = default(string), ConnectorParams parentSourceConnectionParams = default(ConnectorParams), ErrorProto preprocessingError = default(ErrorProto), int? publicStatus = default(int?), int? refreshStatus = default(int?), VlanParams restoreVlanParams = default(VlanParams), long? scheduledConstituentId = default(long?), long? scheduledGandalfSessionId = default(long?), long? startTimeUsecs = default(long?), int? status = default(int?), long? taskId = default(long?), UniversalIdProto taskUid = default(UniversalIdProto), long? totalLogicalSizeBytes = default(long?), long? totalPhysicalSizeBytes = default(long?), int? type = default(int?), string user = default(string), UserInformation userInfo = default(UserInformation), List<string> userMessages = default(List<string>), List<ErrorProto> warnings = default(List<ErrorProto>))
        {
            this.CancellationRequested = cancellationRequested;
            this.EndTimeUsecs = endTimeUsecs;
            this.Error = error;
            this.IsInternal = isInternal;
            this.Name = name;
            this.ParentSourceConnectionParams = parentSourceConnectionParams;
            this.PreprocessingError = preprocessingError;
            this.PublicStatus = publicStatus;
            this.RefreshStatus = refreshStatus;
            this.RestoreVlanParams = restoreVlanParams;
            this.ScheduledConstituentId = scheduledConstituentId;
            this.ScheduledGandalfSessionId = scheduledGandalfSessionId;
            this.StartTimeUsecs = startTimeUsecs;
            this.Status = status;
            this.TaskId = taskId;
            this.TaskUid = taskUid;
            this.TotalLogicalSizeBytes = totalLogicalSizeBytes;
            this.TotalPhysicalSizeBytes = totalPhysicalSizeBytes;
            this.Type = type;
            this.User = user;
            this.UserInfo = userInfo;
            this.UserMessages = userMessages;
            this.Warnings = warnings;
        }
        
        /// <summary>
        /// Whether this task has a pending cancellation request.
        /// </summary>
        /// <value>Whether this task has a pending cancellation request.</value>
        [DataMember(Name="cancellationRequested", EmitDefaultValue=true)]
        public bool? CancellationRequested { get; set; }

        /// <summary>
        /// If the restore task has finished, this field contains the end time for the task.
        /// </summary>
        /// <value>If the restore task has finished, this field contains the end time for the task.</value>
        [DataMember(Name="endTimeUsecs", EmitDefaultValue=true)]
        public long? EndTimeUsecs { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public ErrorProto Error { get; set; }

        /// <summary>
        /// Whether the restore task is internal. This is currently used by standby restore tasks.
        /// </summary>
        /// <value>Whether the restore task is internal. This is currently used by standby restore tasks.</value>
        [DataMember(Name="isInternal", EmitDefaultValue=true)]
        public bool? IsInternal { get; set; }

        /// <summary>
        /// The name of the restore task.
        /// </summary>
        /// <value>The name of the restore task.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ParentSourceConnectionParams
        /// </summary>
        [DataMember(Name="parentSourceConnectionParams", EmitDefaultValue=false)]
        public ConnectorParams ParentSourceConnectionParams { get; set; }

        /// <summary>
        /// Gets or Sets PreprocessingError
        /// </summary>
        [DataMember(Name="preprocessingError", EmitDefaultValue=false)]
        public ErrorProto PreprocessingError { get; set; }

        /// <summary>
        /// Iris-facing task state. This field is stamped during the export.
        /// </summary>
        /// <value>Iris-facing task state. This field is stamped during the export.</value>
        [DataMember(Name="publicStatus", EmitDefaultValue=true)]
        public int? PublicStatus { get; set; }

        /// <summary>
        /// Status of the refresh task.
        /// </summary>
        /// <value>Status of the refresh task.</value>
        [DataMember(Name="refreshStatus", EmitDefaultValue=true)]
        public int? RefreshStatus { get; set; }

        /// <summary>
        /// Gets or Sets RestoreVlanParams
        /// </summary>
        [DataMember(Name="restoreVlanParams", EmitDefaultValue=false)]
        public VlanParams RestoreVlanParams { get; set; }

        /// <summary>
        /// Constituent id (and the gandalf session id) where this task has been scheduled. If -1, the task is not running at any slave. It&#39;s possible that the task was previously scheduled, but is now being re-scheduled.
        /// </summary>
        /// <value>Constituent id (and the gandalf session id) where this task has been scheduled. If -1, the task is not running at any slave. It&#39;s possible that the task was previously scheduled, but is now being re-scheduled.</value>
        [DataMember(Name="scheduledConstituentId", EmitDefaultValue=true)]
        public long? ScheduledConstituentId { get; set; }

        /// <summary>
        /// Gets or Sets ScheduledGandalfSessionId
        /// </summary>
        [DataMember(Name="scheduledGandalfSessionId", EmitDefaultValue=true)]
        public long? ScheduledGandalfSessionId { get; set; }

        /// <summary>
        /// The start time for this restore task.
        /// </summary>
        /// <value>The start time for this restore task.</value>
        [DataMember(Name="startTimeUsecs", EmitDefaultValue=true)]
        public long? StartTimeUsecs { get; set; }

        /// <summary>
        /// Status of the restore task.
        /// </summary>
        /// <value>Status of the restore task.</value>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public int? Status { get; set; }

        /// <summary>
        /// A unique id for this task within the cluster.
        /// </summary>
        /// <value>A unique id for this task within the cluster.</value>
        [DataMember(Name="taskId", EmitDefaultValue=true)]
        public long? TaskId { get; set; }

        /// <summary>
        /// Gets or Sets TaskUid
        /// </summary>
        [DataMember(Name="taskUid", EmitDefaultValue=false)]
        public UniversalIdProto TaskUid { get; set; }

        /// <summary>
        /// Logical size of this restore task. This is the amount of data that needs to be transferred to restore the entity.
        /// </summary>
        /// <value>Logical size of this restore task. This is the amount of data that needs to be transferred to restore the entity.</value>
        [DataMember(Name="totalLogicalSizeBytes", EmitDefaultValue=true)]
        public long? TotalLogicalSizeBytes { get; set; }

        /// <summary>
        /// Physical size of this restore task. This is the amount of data that was actually transferred to restore the entity.
        /// </summary>
        /// <value>Physical size of this restore task. This is the amount of data that was actually transferred to restore the entity.</value>
        [DataMember(Name="totalPhysicalSizeBytes", EmitDefaultValue=true)]
        public long? TotalPhysicalSizeBytes { get; set; }

        /// <summary>
        /// The type of restore being performed.
        /// </summary>
        /// <value>The type of restore being performed.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public int? Type { get; set; }

        /// <summary>
        /// The user who requested this restore task.
        /// </summary>
        /// <value>The user who requested this restore task.</value>
        [DataMember(Name="user", EmitDefaultValue=true)]
        public string User { get; set; }

        /// <summary>
        /// Gets or Sets UserInfo
        /// </summary>
        [DataMember(Name="userInfo", EmitDefaultValue=false)]
        public UserInformation UserInfo { get; set; }

        /// <summary>
        /// Messages displayed to the user for this task (if any). Only valid if the status of the task is kFinished. This is used for informing the user with additional details when there is not an error.
        /// </summary>
        /// <value>Messages displayed to the user for this task (if any). Only valid if the status of the task is kFinished. This is used for informing the user with additional details when there is not an error.</value>
        [DataMember(Name="userMessages", EmitDefaultValue=true)]
        public List<string> UserMessages { get; set; }

        /// <summary>
        /// The warnings encountered by this task (if any) during its execution.
        /// </summary>
        /// <value>The warnings encountered by this task (if any) during its execution.</value>
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
            return this.Equals(input as RestoreTaskStateBaseProto);
        }

        /// <summary>
        /// Returns true if RestoreTaskStateBaseProto instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreTaskStateBaseProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreTaskStateBaseProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CancellationRequested == input.CancellationRequested ||
                    (this.CancellationRequested != null &&
                    this.CancellationRequested.Equals(input.CancellationRequested))
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
                    this.IsInternal == input.IsInternal ||
                    (this.IsInternal != null &&
                    this.IsInternal.Equals(input.IsInternal))
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
                    this.PreprocessingError == input.PreprocessingError ||
                    (this.PreprocessingError != null &&
                    this.PreprocessingError.Equals(input.PreprocessingError))
                ) && 
                (
                    this.PublicStatus == input.PublicStatus ||
                    (this.PublicStatus != null &&
                    this.PublicStatus.Equals(input.PublicStatus))
                ) && 
                (
                    this.RefreshStatus == input.RefreshStatus ||
                    (this.RefreshStatus != null &&
                    this.RefreshStatus.Equals(input.RefreshStatus))
                ) && 
                (
                    this.RestoreVlanParams == input.RestoreVlanParams ||
                    (this.RestoreVlanParams != null &&
                    this.RestoreVlanParams.Equals(input.RestoreVlanParams))
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
                    this.TaskUid == input.TaskUid ||
                    (this.TaskUid != null &&
                    this.TaskUid.Equals(input.TaskUid))
                ) && 
                (
                    this.TotalLogicalSizeBytes == input.TotalLogicalSizeBytes ||
                    (this.TotalLogicalSizeBytes != null &&
                    this.TotalLogicalSizeBytes.Equals(input.TotalLogicalSizeBytes))
                ) && 
                (
                    this.TotalPhysicalSizeBytes == input.TotalPhysicalSizeBytes ||
                    (this.TotalPhysicalSizeBytes != null &&
                    this.TotalPhysicalSizeBytes.Equals(input.TotalPhysicalSizeBytes))
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
                    this.UserMessages == input.UserMessages ||
                    this.UserMessages != null &&
                    input.UserMessages != null &&
                    this.UserMessages.Equals(input.UserMessages)
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
                if (this.CancellationRequested != null)
                    hashCode = hashCode * 59 + this.CancellationRequested.GetHashCode();
                if (this.EndTimeUsecs != null)
                    hashCode = hashCode * 59 + this.EndTimeUsecs.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.IsInternal != null)
                    hashCode = hashCode * 59 + this.IsInternal.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ParentSourceConnectionParams != null)
                    hashCode = hashCode * 59 + this.ParentSourceConnectionParams.GetHashCode();
                if (this.PreprocessingError != null)
                    hashCode = hashCode * 59 + this.PreprocessingError.GetHashCode();
                if (this.PublicStatus != null)
                    hashCode = hashCode * 59 + this.PublicStatus.GetHashCode();
                if (this.RefreshStatus != null)
                    hashCode = hashCode * 59 + this.RefreshStatus.GetHashCode();
                if (this.RestoreVlanParams != null)
                    hashCode = hashCode * 59 + this.RestoreVlanParams.GetHashCode();
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
                if (this.TaskUid != null)
                    hashCode = hashCode * 59 + this.TaskUid.GetHashCode();
                if (this.TotalLogicalSizeBytes != null)
                    hashCode = hashCode * 59 + this.TotalLogicalSizeBytes.GetHashCode();
                if (this.TotalPhysicalSizeBytes != null)
                    hashCode = hashCode * 59 + this.TotalPhysicalSizeBytes.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.UserInfo != null)
                    hashCode = hashCode * 59 + this.UserInfo.GetHashCode();
                if (this.UserMessages != null)
                    hashCode = hashCode * 59 + this.UserMessages.GetHashCode();
                if (this.Warnings != null)
                    hashCode = hashCode * 59 + this.Warnings.GetHashCode();
                return hashCode;
            }
        }

    }

}


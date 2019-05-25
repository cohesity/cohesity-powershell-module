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
    /// Structure that captures Task Notifications for a user.
    /// </summary>
    [DataContract]
    public partial class TaskNotification :  IEquatable<TaskNotification>
    {
        /// <summary>
        /// Status of the task. Status of the task. &#39;kSuccess&#39; indicates that task completed successfully. &#39;kError&#39; indicates that task encountered errors.
        /// </summary>
        /// <value>Status of the task. Status of the task. &#39;kSuccess&#39; indicates that task completed successfully. &#39;kError&#39; indicates that task encountered errors.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum KSuccess for value: kSuccess
            /// </summary>
            [EnumMember(Value = "kSuccess")]
            KSuccess = 1,

            /// <summary>
            /// Enum KError for value: kError
            /// </summary>
            [EnumMember(Value = "kError")]
            KError = 2

        }

        /// <summary>
        /// Status of the task. Status of the task. &#39;kSuccess&#39; indicates that task completed successfully. &#39;kError&#39; indicates that task encountered errors.
        /// </summary>
        /// <value>Status of the task. Status of the task. &#39;kSuccess&#39; indicates that task completed successfully. &#39;kError&#39; indicates that task encountered errors.</value>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Task type denotes which type of task this notification is for. This param is used to reflect the taskType. &#39;Restore&#39; notification type is generated upon completion of Restore tasks. &#39;Clone&#39; notification type is generated upon completion of Clone tasks. &#39;BackupNow&#39; notification type is generated upon completion of Backup tasks. &#39;FieldMessage&#39; notification type is generated when field message from Cohesity support is created.
        /// </summary>
        /// <value>Task type denotes which type of task this notification is for. This param is used to reflect the taskType. &#39;Restore&#39; notification type is generated upon completion of Restore tasks. &#39;Clone&#39; notification type is generated upon completion of Clone tasks. &#39;BackupNow&#39; notification type is generated upon completion of Backup tasks. &#39;FieldMessage&#39; notification type is generated when field message from Cohesity support is created.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TaskTypeEnum
        {
            /// <summary>
            /// Enum Restore for value: restore
            /// </summary>
            [EnumMember(Value = "restore")]
            Restore = 1,

            /// <summary>
            /// Enum Clone for value: clone
            /// </summary>
            [EnumMember(Value = "clone")]
            Clone = 2,

            /// <summary>
            /// Enum BackupNow for value: backupNow
            /// </summary>
            [EnumMember(Value = "backupNow")]
            BackupNow = 3,

            /// <summary>
            /// Enum FieldMessage for value: fieldMessage
            /// </summary>
            [EnumMember(Value = "fieldMessage")]
            FieldMessage = 4

        }

        /// <summary>
        /// Task type denotes which type of task this notification is for. This param is used to reflect the taskType. &#39;Restore&#39; notification type is generated upon completion of Restore tasks. &#39;Clone&#39; notification type is generated upon completion of Clone tasks. &#39;BackupNow&#39; notification type is generated upon completion of Backup tasks. &#39;FieldMessage&#39; notification type is generated when field message from Cohesity support is created.
        /// </summary>
        /// <value>Task type denotes which type of task this notification is for. This param is used to reflect the taskType. &#39;Restore&#39; notification type is generated upon completion of Restore tasks. &#39;Clone&#39; notification type is generated upon completion of Clone tasks. &#39;BackupNow&#39; notification type is generated upon completion of Backup tasks. &#39;FieldMessage&#39; notification type is generated when field message from Cohesity support is created.</value>
        [DataMember(Name="taskType", EmitDefaultValue=true)]
        public TaskTypeEnum? TaskType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskNotification" /> class.
        /// </summary>
        /// <param name="backupTask">backupTask.</param>
        /// <param name="cloneTask">cloneTask.</param>
        /// <param name="createdTimeSecs">Timestamp at which the notification was created..</param>
        /// <param name="description">Description holds the actual notification text generated for the event..</param>
        /// <param name="dismissed">Dismissed keeps track of whether a notification has been seen or not. User may choose to dismiss individual event or all notifications at once. Nil or 0 value represents false..</param>
        /// <param name="dismissedTimeSecs">Timestamp at which user dismissed this notification event..</param>
        /// <param name="fieldMessageTask">fieldMessageTask.</param>
        /// <param name="id">id identifies a user notification event uniquely. This can also be used to dismiss individual notifications..</param>
        /// <param name="recoveryTask">recoveryTask.</param>
        /// <param name="status">Status of the task. Status of the task. &#39;kSuccess&#39; indicates that task completed successfully. &#39;kError&#39; indicates that task encountered errors..</param>
        /// <param name="taskType">Task type denotes which type of task this notification is for. This param is used to reflect the taskType. &#39;Restore&#39; notification type is generated upon completion of Restore tasks. &#39;Clone&#39; notification type is generated upon completion of Clone tasks. &#39;BackupNow&#39; notification type is generated upon completion of Backup tasks. &#39;FieldMessage&#39; notification type is generated when field message from Cohesity support is created..</param>
        /// <param name="visited">Visited keeps track of whether a notification has been seen or not..</param>
        /// <param name="visitedTimeSecs">Timestamp at which user visited this notification event..</param>
        public TaskNotification(BackupTaskInfo backupTask = default(BackupTaskInfo), CloneTaskInfo cloneTask = default(CloneTaskInfo), long? createdTimeSecs = default(long?), string description = default(string), bool? dismissed = default(bool?), long? dismissedTimeSecs = default(long?), BasicTaskInfo fieldMessageTask = default(BasicTaskInfo), string id = default(string), RecoveryTaskInfo recoveryTask = default(RecoveryTaskInfo), StatusEnum? status = default(StatusEnum?), TaskTypeEnum? taskType = default(TaskTypeEnum?), bool? visited = default(bool?), long? visitedTimeSecs = default(long?))
        {
            this.CreatedTimeSecs = createdTimeSecs;
            this.Description = description;
            this.Dismissed = dismissed;
            this.DismissedTimeSecs = dismissedTimeSecs;
            this.Id = id;
            this.Status = status;
            this.TaskType = taskType;
            this.Visited = visited;
            this.VisitedTimeSecs = visitedTimeSecs;
            this.BackupTask = backupTask;
            this.CloneTask = cloneTask;
            this.CreatedTimeSecs = createdTimeSecs;
            this.Description = description;
            this.Dismissed = dismissed;
            this.DismissedTimeSecs = dismissedTimeSecs;
            this.FieldMessageTask = fieldMessageTask;
            this.Id = id;
            this.RecoveryTask = recoveryTask;
            this.Status = status;
            this.TaskType = taskType;
            this.Visited = visited;
            this.VisitedTimeSecs = visitedTimeSecs;
        }
        
        /// <summary>
        /// Gets or Sets BackupTask
        /// </summary>
        [DataMember(Name="backupTask", EmitDefaultValue=false)]
        public BackupTaskInfo BackupTask { get; set; }

        /// <summary>
        /// Gets or Sets CloneTask
        /// </summary>
        [DataMember(Name="cloneTask", EmitDefaultValue=false)]
        public CloneTaskInfo CloneTask { get; set; }

        /// <summary>
        /// Timestamp at which the notification was created.
        /// </summary>
        /// <value>Timestamp at which the notification was created.</value>
        [DataMember(Name="createdTimeSecs", EmitDefaultValue=true)]
        public long? CreatedTimeSecs { get; set; }

        /// <summary>
        /// Description holds the actual notification text generated for the event.
        /// </summary>
        /// <value>Description holds the actual notification text generated for the event.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Dismissed keeps track of whether a notification has been seen or not. User may choose to dismiss individual event or all notifications at once. Nil or 0 value represents false.
        /// </summary>
        /// <value>Dismissed keeps track of whether a notification has been seen or not. User may choose to dismiss individual event or all notifications at once. Nil or 0 value represents false.</value>
        [DataMember(Name="dismissed", EmitDefaultValue=true)]
        public bool? Dismissed { get; set; }

        /// <summary>
        /// Timestamp at which user dismissed this notification event.
        /// </summary>
        /// <value>Timestamp at which user dismissed this notification event.</value>
        [DataMember(Name="dismissedTimeSecs", EmitDefaultValue=true)]
        public long? DismissedTimeSecs { get; set; }

        /// <summary>
        /// Gets or Sets FieldMessageTask
        /// </summary>
        [DataMember(Name="fieldMessageTask", EmitDefaultValue=false)]
        public BasicTaskInfo FieldMessageTask { get; set; }

        /// <summary>
        /// id identifies a user notification event uniquely. This can also be used to dismiss individual notifications.
        /// </summary>
        /// <value>id identifies a user notification event uniquely. This can also be used to dismiss individual notifications.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets RecoveryTask
        /// </summary>
        [DataMember(Name="recoveryTask", EmitDefaultValue=false)]
        public RecoveryTaskInfo RecoveryTask { get; set; }

        /// <summary>
        /// Visited keeps track of whether a notification has been seen or not.
        /// </summary>
        /// <value>Visited keeps track of whether a notification has been seen or not.</value>
        [DataMember(Name="visited", EmitDefaultValue=true)]
        public bool? Visited { get; set; }

        /// <summary>
        /// Timestamp at which user visited this notification event.
        /// </summary>
        /// <value>Timestamp at which user visited this notification event.</value>
        [DataMember(Name="visitedTimeSecs", EmitDefaultValue=true)]
        public long? VisitedTimeSecs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskNotification {\n");
            sb.Append("  BackupTask: ").Append(BackupTask).Append("\n");
            sb.Append("  CloneTask: ").Append(CloneTask).Append("\n");
            sb.Append("  CreatedTimeSecs: ").Append(CreatedTimeSecs).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Dismissed: ").Append(Dismissed).Append("\n");
            sb.Append("  DismissedTimeSecs: ").Append(DismissedTimeSecs).Append("\n");
            sb.Append("  FieldMessageTask: ").Append(FieldMessageTask).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RecoveryTask: ").Append(RecoveryTask).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TaskType: ").Append(TaskType).Append("\n");
            sb.Append("  Visited: ").Append(Visited).Append("\n");
            sb.Append("  VisitedTimeSecs: ").Append(VisitedTimeSecs).Append("\n");
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
            return this.Equals(input as TaskNotification);
        }

        /// <summary>
        /// Returns true if TaskNotification instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskNotification input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackupTask == input.BackupTask ||
                    (this.BackupTask != null &&
                    this.BackupTask.Equals(input.BackupTask))
                ) && 
                (
                    this.CloneTask == input.CloneTask ||
                    (this.CloneTask != null &&
                    this.CloneTask.Equals(input.CloneTask))
                ) && 
                (
                    this.CreatedTimeSecs == input.CreatedTimeSecs ||
                    (this.CreatedTimeSecs != null &&
                    this.CreatedTimeSecs.Equals(input.CreatedTimeSecs))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Dismissed == input.Dismissed ||
                    (this.Dismissed != null &&
                    this.Dismissed.Equals(input.Dismissed))
                ) && 
                (
                    this.DismissedTimeSecs == input.DismissedTimeSecs ||
                    (this.DismissedTimeSecs != null &&
                    this.DismissedTimeSecs.Equals(input.DismissedTimeSecs))
                ) && 
                (
                    this.FieldMessageTask == input.FieldMessageTask ||
                    (this.FieldMessageTask != null &&
                    this.FieldMessageTask.Equals(input.FieldMessageTask))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.RecoveryTask == input.RecoveryTask ||
                    (this.RecoveryTask != null &&
                    this.RecoveryTask.Equals(input.RecoveryTask))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.TaskType == input.TaskType ||
                    this.TaskType.Equals(input.TaskType)
                ) && 
                (
                    this.Visited == input.Visited ||
                    (this.Visited != null &&
                    this.Visited.Equals(input.Visited))
                ) && 
                (
                    this.VisitedTimeSecs == input.VisitedTimeSecs ||
                    (this.VisitedTimeSecs != null &&
                    this.VisitedTimeSecs.Equals(input.VisitedTimeSecs))
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
                if (this.BackupTask != null)
                    hashCode = hashCode * 59 + this.BackupTask.GetHashCode();
                if (this.CloneTask != null)
                    hashCode = hashCode * 59 + this.CloneTask.GetHashCode();
                if (this.CreatedTimeSecs != null)
                    hashCode = hashCode * 59 + this.CreatedTimeSecs.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Dismissed != null)
                    hashCode = hashCode * 59 + this.Dismissed.GetHashCode();
                if (this.DismissedTimeSecs != null)
                    hashCode = hashCode * 59 + this.DismissedTimeSecs.GetHashCode();
                if (this.FieldMessageTask != null)
                    hashCode = hashCode * 59 + this.FieldMessageTask.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.RecoveryTask != null)
                    hashCode = hashCode * 59 + this.RecoveryTask.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.TaskType.GetHashCode();
                if (this.Visited != null)
                    hashCode = hashCode * 59 + this.Visited.GetHashCode();
                if (this.VisitedTimeSecs != null)
                    hashCode = hashCode * 59 + this.VisitedTimeSecs.GetHashCode();
                return hashCode;
            }
        }

    }

}

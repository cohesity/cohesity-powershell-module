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
        /// Task type denotes which type of task this notification is for. This param is used to reflect the taskType. &#39;Restore&#39; notification type is generated upon completion of Restore tasks. &#39;Clone&#39; notification type is generated upon completion of Clone tasks. &#39;BackupNow&#39; notification type is generated upon completion of Backup tasks. &#39;FieldMessage&#39; notification type is generated when field message from Cohesity support is created. &#39;bulkInstallApp&#39; notification type is generated from bulk install app &#39;tiering&#39; notification type is generated upon completion of tiering tasks. &#39;analysis&#39; notification type is generated upon completion of analysis tasks. &#39;agentUpgradeTask&#39; notification type is generated upon completion of upgrade task.
        /// </summary>
        /// <value>Task type denotes which type of task this notification is for. This param is used to reflect the taskType. &#39;Restore&#39; notification type is generated upon completion of Restore tasks. &#39;Clone&#39; notification type is generated upon completion of Clone tasks. &#39;BackupNow&#39; notification type is generated upon completion of Backup tasks. &#39;FieldMessage&#39; notification type is generated when field message from Cohesity support is created. &#39;bulkInstallApp&#39; notification type is generated from bulk install app &#39;tiering&#39; notification type is generated upon completion of tiering tasks. &#39;analysis&#39; notification type is generated upon completion of analysis tasks. &#39;agentUpgradeTask&#39; notification type is generated upon completion of upgrade task.</value>
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
            FieldMessage = 4,

            /// <summary>
            /// Enum BulkInstallApp for value: bulkInstallApp
            /// </summary>
            [EnumMember(Value = "bulkInstallApp")]
            BulkInstallApp = 5,

            /// <summary>
            /// Enum Tiering for value: tiering
            /// </summary>
            [EnumMember(Value = "tiering")]
            Tiering = 6,

            /// <summary>
            /// Enum Analysis for value: analysis
            /// </summary>
            [EnumMember(Value = "analysis")]
            Analysis = 7,

            /// <summary>
            /// Enum AgentUpgradeTask for value: agentUpgradeTask
            /// </summary>
            [EnumMember(Value = "agentUpgradeTask")]
            AgentUpgradeTask = 8

        }

        /// <summary>
        /// Task type denotes which type of task this notification is for. This param is used to reflect the taskType. &#39;Restore&#39; notification type is generated upon completion of Restore tasks. &#39;Clone&#39; notification type is generated upon completion of Clone tasks. &#39;BackupNow&#39; notification type is generated upon completion of Backup tasks. &#39;FieldMessage&#39; notification type is generated when field message from Cohesity support is created. &#39;bulkInstallApp&#39; notification type is generated from bulk install app &#39;tiering&#39; notification type is generated upon completion of tiering tasks. &#39;analysis&#39; notification type is generated upon completion of analysis tasks. &#39;agentUpgradeTask&#39; notification type is generated upon completion of upgrade task.
        /// </summary>
        /// <value>Task type denotes which type of task this notification is for. This param is used to reflect the taskType. &#39;Restore&#39; notification type is generated upon completion of Restore tasks. &#39;Clone&#39; notification type is generated upon completion of Clone tasks. &#39;BackupNow&#39; notification type is generated upon completion of Backup tasks. &#39;FieldMessage&#39; notification type is generated when field message from Cohesity support is created. &#39;bulkInstallApp&#39; notification type is generated from bulk install app &#39;tiering&#39; notification type is generated upon completion of tiering tasks. &#39;analysis&#39; notification type is generated upon completion of analysis tasks. &#39;agentUpgradeTask&#39; notification type is generated upon completion of upgrade task.</value>
        [DataMember(Name="taskType", EmitDefaultValue=true)]
        public TaskTypeEnum? TaskType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskNotification" /> class.
        /// </summary>
        /// <param name="agentUpgradeTask">agentUpgradeTask.</param>
        /// <param name="analysisTask">analysisTask.</param>
        /// <param name="backupTask">backupTask.</param>
        /// <param name="bulkInstallAppTask">bulkInstallAppTask.</param>
        /// <param name="cloneTask">cloneTask.</param>
        /// <param name="createdTimeSecs">Timestamp at which the notification was created..</param>
        /// <param name="description">Description holds the actual notification text generated for the event..</param>
        /// <param name="dismissed">Dismissed keeps track of whether a notification has been seen or not. User may choose to dismiss individual event or all notifications at once. Nil or 0 value represents false..</param>
        /// <param name="dismissedTimeSecs">Timestamp at which user dismissed this notification event..</param>
        /// <param name="fieldMessageTask">fieldMessageTask.</param>
        /// <param name="id">id identifies a user notification event uniquely. This can also be used to dismiss individual notifications..</param>
        /// <param name="recoveryTask">recoveryTask.</param>
        /// <param name="status">Status of the task. Status of the task. &#39;kSuccess&#39; indicates that task completed successfully. &#39;kError&#39; indicates that task encountered errors..</param>
        /// <param name="taskType">Task type denotes which type of task this notification is for. This param is used to reflect the taskType. &#39;Restore&#39; notification type is generated upon completion of Restore tasks. &#39;Clone&#39; notification type is generated upon completion of Clone tasks. &#39;BackupNow&#39; notification type is generated upon completion of Backup tasks. &#39;FieldMessage&#39; notification type is generated when field message from Cohesity support is created. &#39;bulkInstallApp&#39; notification type is generated from bulk install app &#39;tiering&#39; notification type is generated upon completion of tiering tasks. &#39;analysis&#39; notification type is generated upon completion of analysis tasks. &#39;agentUpgradeTask&#39; notification type is generated upon completion of upgrade task..</param>
        /// <param name="tieringTask">tieringTask.</param>
        /// <param name="visited">Visited keeps track of whether a notification has been seen or not..</param>
        /// <param name="visitedTimeSecs">Timestamp at which user visited this notification event..</param>
        public TaskNotification(AgentUpgradeTaskInfo agentUpgradeTask = default(AgentUpgradeTaskInfo), AnalysisTaskInfo analysisTask = default(AnalysisTaskInfo), BackupTaskInfo backupTask = default(BackupTaskInfo), BulkInstallAppTaskInfo bulkInstallAppTask = default(BulkInstallAppTaskInfo), CloneTaskInfo cloneTask = default(CloneTaskInfo), long? createdTimeSecs = default(long?), string description = default(string), bool? dismissed = default(bool?), long? dismissedTimeSecs = default(long?), BasicTaskInfo fieldMessageTask = default(BasicTaskInfo), string id = default(string), RecoveryTaskInfo recoveryTask = default(RecoveryTaskInfo), StatusEnum? status = default(StatusEnum?), TaskTypeEnum? taskType = default(TaskTypeEnum?), TieringTaskInfo tieringTask = default(TieringTaskInfo), bool? visited = default(bool?), long? visitedTimeSecs = default(long?))
        {
            this.AgentUpgradeTask = agentUpgradeTask;
            this.AnalysisTask = analysisTask;
            this.BackupTask = backupTask;
            this.BulkInstallAppTask = bulkInstallAppTask;
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
            this.TieringTask = tieringTask;
            this.Visited = visited;
            this.VisitedTimeSecs = visitedTimeSecs;
        }
        
        /// <summary>
        /// Gets or Sets AgentUpgradeTask
        /// </summary>
        [DataMember(Name="agentUpgradeTask", EmitDefaultValue=false)]
        public AgentUpgradeTaskInfo AgentUpgradeTask { get; set; }

        /// <summary>
        /// Gets or Sets AnalysisTask
        /// </summary>
        [DataMember(Name="analysisTask", EmitDefaultValue=false)]
        public AnalysisTaskInfo AnalysisTask { get; set; }

        /// <summary>
        /// Gets or Sets BackupTask
        /// </summary>
        [DataMember(Name="backupTask", EmitDefaultValue=false)]
        public BackupTaskInfo BackupTask { get; set; }

        /// <summary>
        /// Gets or Sets BulkInstallAppTask
        /// </summary>
        [DataMember(Name="bulkInstallAppTask", EmitDefaultValue=false)]
        public BulkInstallAppTaskInfo BulkInstallAppTask { get; set; }

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
        /// Gets or Sets TieringTask
        /// </summary>
        [DataMember(Name="tieringTask", EmitDefaultValue=false)]
        public TieringTaskInfo TieringTask { get; set; }

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
                    this.AgentUpgradeTask == input.AgentUpgradeTask ||
                    (this.AgentUpgradeTask != null &&
                    this.AgentUpgradeTask.Equals(input.AgentUpgradeTask))
                ) && 
                (
                    this.AnalysisTask == input.AnalysisTask ||
                    (this.AnalysisTask != null &&
                    this.AnalysisTask.Equals(input.AnalysisTask))
                ) && 
                (
                    this.BackupTask == input.BackupTask ||
                    (this.BackupTask != null &&
                    this.BackupTask.Equals(input.BackupTask))
                ) && 
                (
                    this.BulkInstallAppTask == input.BulkInstallAppTask ||
                    (this.BulkInstallAppTask != null &&
                    this.BulkInstallAppTask.Equals(input.BulkInstallAppTask))
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
                    this.TieringTask == input.TieringTask ||
                    (this.TieringTask != null &&
                    this.TieringTask.Equals(input.TieringTask))
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
                if (this.AgentUpgradeTask != null)
                    hashCode = hashCode * 59 + this.AgentUpgradeTask.GetHashCode();
                if (this.AnalysisTask != null)
                    hashCode = hashCode * 59 + this.AnalysisTask.GetHashCode();
                if (this.BackupTask != null)
                    hashCode = hashCode * 59 + this.BackupTask.GetHashCode();
                if (this.BulkInstallAppTask != null)
                    hashCode = hashCode * 59 + this.BulkInstallAppTask.GetHashCode();
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
                if (this.Status != null)
					hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TaskType != null)
					hashCode = hashCode * 59 + this.TaskType.GetHashCode();
                if (this.TieringTask != null)
                    hashCode = hashCode * 59 + this.TieringTask.GetHashCode();
                if (this.Visited != null)
                    hashCode = hashCode * 59 + this.Visited.GetHashCode();
                if (this.VisitedTimeSecs != null)
                    hashCode = hashCode * 59 + this.VisitedTimeSecs.GetHashCode();
                return hashCode;
            }
        }

    }

}


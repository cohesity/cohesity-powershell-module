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
    /// Specifies one task.
    /// </summary>
    [DataContract]
    public partial class Task :  IEquatable<Task>
    {
        /// <summary>
        /// Specifies the status of the task being queried. &#39;kActive&#39; indicates that the task is still active. &#39;kFinished&#39; indicates that the task has finished without any errors. &#39;kFinishedWithError&#39; indicates that the task has finished, but that there was an errror of some kind. &#39;kCancelled&#39; indicates that the task was cancelled. &#39;kFinishedGarbageCollected&#39; indicates that the task was garbage collected due to its subtasks not finishing within the allotted time.
        /// </summary>
        /// <value>Specifies the status of the task being queried. &#39;kActive&#39; indicates that the task is still active. &#39;kFinished&#39; indicates that the task has finished without any errors. &#39;kFinishedWithError&#39; indicates that the task has finished, but that there was an errror of some kind. &#39;kCancelled&#39; indicates that the task was cancelled. &#39;kFinishedGarbageCollected&#39; indicates that the task was garbage collected due to its subtasks not finishing within the allotted time.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum KActive for value: kActive
            /// </summary>
            [EnumMember(Value = "kActive")]
            KActive = 1,

            /// <summary>
            /// Enum KFinished for value: kFinished
            /// </summary>
            [EnumMember(Value = "kFinished")]
            KFinished = 2,

            /// <summary>
            /// Enum KFinishedWithError for value: kFinishedWithError
            /// </summary>
            [EnumMember(Value = "kFinishedWithError")]
            KFinishedWithError = 3,

            /// <summary>
            /// Enum KCancelled for value: kCancelled
            /// </summary>
            [EnumMember(Value = "kCancelled")]
            KCancelled = 4,

            /// <summary>
            /// Enum KFinishedGarbageCollected for value: kFinishedGarbageCollected
            /// </summary>
            [EnumMember(Value = "kFinishedGarbageCollected")]
            KFinishedGarbageCollected = 5

        }

        /// <summary>
        /// Specifies the status of the task being queried. &#39;kActive&#39; indicates that the task is still active. &#39;kFinished&#39; indicates that the task has finished without any errors. &#39;kFinishedWithError&#39; indicates that the task has finished, but that there was an errror of some kind. &#39;kCancelled&#39; indicates that the task was cancelled. &#39;kFinishedGarbageCollected&#39; indicates that the task was garbage collected due to its subtasks not finishing within the allotted time.
        /// </summary>
        /// <value>Specifies the status of the task being queried. &#39;kActive&#39; indicates that the task is still active. &#39;kFinished&#39; indicates that the task has finished without any errors. &#39;kFinishedWithError&#39; indicates that the task has finished, but that there was an errror of some kind. &#39;kCancelled&#39; indicates that the task was cancelled. &#39;kFinishedGarbageCollected&#39; indicates that the task was garbage collected due to its subtasks not finishing within the allotted time.</value>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Task" /> class.
        /// </summary>
        /// <param name="attributes">The latest attributes reported for this task..</param>
        /// <param name="endTimeSeconds">Specifies the end time of the task..</param>
        /// <param name="errorMessage">Specifies an optional error message for this task..</param>
        /// <param name="events">Specifies the events reported for this task..</param>
        /// <param name="expectedEndTimeSeconds">Specifies the estimated end time of the task..</param>
        /// <param name="expectedSecondsRemaining">Specifies the expected remaining time for this task in seconds..</param>
        /// <param name="expectedTotalWorkCount">The expected raw count of the total work remaining. This is the highest work count value reported by the client. This field can be set to let pulse compute percentFinished by looking at the currently reported remainingWorkCount and the expectedTotalWorkCount..</param>
        /// <param name="lastUpdateTimeSeconds">Specifies the timestamp when the last progress was reported..</param>
        /// <param name="percentFinished">Specifies the reported progress on the task..</param>
        /// <param name="startTimeSeconds">Specifies the start time of the task..</param>
        /// <param name="status">Specifies the status of the task being queried. &#39;kActive&#39; indicates that the task is still active. &#39;kFinished&#39; indicates that the task has finished without any errors. &#39;kFinishedWithError&#39; indicates that the task has finished, but that there was an errror of some kind. &#39;kCancelled&#39; indicates that the task was cancelled. &#39;kFinishedGarbageCollected&#39; indicates that the task was garbage collected due to its subtasks not finishing within the allotted time..</param>
        /// <param name="subTasks">Specifies a list of subtasks belonging to this task..</param>
        /// <param name="taskPath">Specifes the path of this task..</param>
        public Task(List<TaskAttribute> attributes = default(List<TaskAttribute>), long? endTimeSeconds = default(long?), string errorMessage = default(string), List<TaskEvent> events = default(List<TaskEvent>), long? expectedEndTimeSeconds = default(long?), long? expectedSecondsRemaining = default(long?), long? expectedTotalWorkCount = default(long?), long? lastUpdateTimeSeconds = default(long?), float? percentFinished = default(float?), long? startTimeSeconds = default(long?), StatusEnum? status = default(StatusEnum?), List<Object> subTasks = default(List<Object>), string taskPath = default(string))
        {
            this.Attributes = attributes;
            this.EndTimeSeconds = endTimeSeconds;
            this.ErrorMessage = errorMessage;
            this.Events = events;
            this.ExpectedEndTimeSeconds = expectedEndTimeSeconds;
            this.ExpectedSecondsRemaining = expectedSecondsRemaining;
            this.ExpectedTotalWorkCount = expectedTotalWorkCount;
            this.LastUpdateTimeSeconds = lastUpdateTimeSeconds;
            this.PercentFinished = percentFinished;
            this.StartTimeSeconds = startTimeSeconds;
            this.Status = status;
            this.SubTasks = subTasks;
            this.TaskPath = taskPath;
            this.Attributes = attributes;
            this.EndTimeSeconds = endTimeSeconds;
            this.ErrorMessage = errorMessage;
            this.Events = events;
            this.ExpectedEndTimeSeconds = expectedEndTimeSeconds;
            this.ExpectedSecondsRemaining = expectedSecondsRemaining;
            this.ExpectedTotalWorkCount = expectedTotalWorkCount;
            this.LastUpdateTimeSeconds = lastUpdateTimeSeconds;
            this.PercentFinished = percentFinished;
            this.StartTimeSeconds = startTimeSeconds;
            this.Status = status;
            this.SubTasks = subTasks;
            this.TaskPath = taskPath;
        }
        
        /// <summary>
        /// The latest attributes reported for this task.
        /// </summary>
        /// <value>The latest attributes reported for this task.</value>
        [DataMember(Name="attributes", EmitDefaultValue=true)]
        public List<TaskAttribute> Attributes { get; set; }

        /// <summary>
        /// Specifies the end time of the task.
        /// </summary>
        /// <value>Specifies the end time of the task.</value>
        [DataMember(Name="endTimeSeconds", EmitDefaultValue=true)]
        public long? EndTimeSeconds { get; set; }

        /// <summary>
        /// Specifies an optional error message for this task.
        /// </summary>
        /// <value>Specifies an optional error message for this task.</value>
        [DataMember(Name="errorMessage", EmitDefaultValue=true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Specifies the events reported for this task.
        /// </summary>
        /// <value>Specifies the events reported for this task.</value>
        [DataMember(Name="events", EmitDefaultValue=true)]
        public List<TaskEvent> Events { get; set; }

        /// <summary>
        /// Specifies the estimated end time of the task.
        /// </summary>
        /// <value>Specifies the estimated end time of the task.</value>
        [DataMember(Name="expectedEndTimeSeconds", EmitDefaultValue=true)]
        public long? ExpectedEndTimeSeconds { get; set; }

        /// <summary>
        /// Specifies the expected remaining time for this task in seconds.
        /// </summary>
        /// <value>Specifies the expected remaining time for this task in seconds.</value>
        [DataMember(Name="expectedSecondsRemaining", EmitDefaultValue=true)]
        public long? ExpectedSecondsRemaining { get; set; }

        /// <summary>
        /// The expected raw count of the total work remaining. This is the highest work count value reported by the client. This field can be set to let pulse compute percentFinished by looking at the currently reported remainingWorkCount and the expectedTotalWorkCount.
        /// </summary>
        /// <value>The expected raw count of the total work remaining. This is the highest work count value reported by the client. This field can be set to let pulse compute percentFinished by looking at the currently reported remainingWorkCount and the expectedTotalWorkCount.</value>
        [DataMember(Name="expectedTotalWorkCount", EmitDefaultValue=true)]
        public long? ExpectedTotalWorkCount { get; set; }

        /// <summary>
        /// Specifies the timestamp when the last progress was reported.
        /// </summary>
        /// <value>Specifies the timestamp when the last progress was reported.</value>
        [DataMember(Name="lastUpdateTimeSeconds", EmitDefaultValue=true)]
        public long? LastUpdateTimeSeconds { get; set; }

        /// <summary>
        /// Specifies the reported progress on the task.
        /// </summary>
        /// <value>Specifies the reported progress on the task.</value>
        [DataMember(Name="percentFinished", EmitDefaultValue=true)]
        public float? PercentFinished { get; set; }

        /// <summary>
        /// Specifies the start time of the task.
        /// </summary>
        /// <value>Specifies the start time of the task.</value>
        [DataMember(Name="startTimeSeconds", EmitDefaultValue=true)]
        public long? StartTimeSeconds { get; set; }

        /// <summary>
        /// Specifies a list of subtasks belonging to this task.
        /// </summary>
        /// <value>Specifies a list of subtasks belonging to this task.</value>
        [DataMember(Name="subTasks", EmitDefaultValue=true)]
        public List<Object> SubTasks { get; set; }

        /// <summary>
        /// Specifes the path of this task.
        /// </summary>
        /// <value>Specifes the path of this task.</value>
        [DataMember(Name="taskPath", EmitDefaultValue=true)]
        public string TaskPath { get; set; }

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
            return this.Equals(input as Task);
        }

        /// <summary>
        /// Returns true if Task instances are equal
        /// </summary>
        /// <param name="input">Instance of Task to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Task input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    input.Attributes != null &&
                    this.Attributes.Equals(input.Attributes)
                ) && 
                (
                    this.EndTimeSeconds == input.EndTimeSeconds ||
                    (this.EndTimeSeconds != null &&
                    this.EndTimeSeconds.Equals(input.EndTimeSeconds))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.Events == input.Events ||
                    this.Events != null &&
                    input.Events != null &&
                    this.Events.Equals(input.Events)
                ) && 
                (
                    this.ExpectedEndTimeSeconds == input.ExpectedEndTimeSeconds ||
                    (this.ExpectedEndTimeSeconds != null &&
                    this.ExpectedEndTimeSeconds.Equals(input.ExpectedEndTimeSeconds))
                ) && 
                (
                    this.ExpectedSecondsRemaining == input.ExpectedSecondsRemaining ||
                    (this.ExpectedSecondsRemaining != null &&
                    this.ExpectedSecondsRemaining.Equals(input.ExpectedSecondsRemaining))
                ) && 
                (
                    this.ExpectedTotalWorkCount == input.ExpectedTotalWorkCount ||
                    (this.ExpectedTotalWorkCount != null &&
                    this.ExpectedTotalWorkCount.Equals(input.ExpectedTotalWorkCount))
                ) && 
                (
                    this.LastUpdateTimeSeconds == input.LastUpdateTimeSeconds ||
                    (this.LastUpdateTimeSeconds != null &&
                    this.LastUpdateTimeSeconds.Equals(input.LastUpdateTimeSeconds))
                ) && 
                (
                    this.PercentFinished == input.PercentFinished ||
                    (this.PercentFinished != null &&
                    this.PercentFinished.Equals(input.PercentFinished))
                ) && 
                (
                    this.StartTimeSeconds == input.StartTimeSeconds ||
                    (this.StartTimeSeconds != null &&
                    this.StartTimeSeconds.Equals(input.StartTimeSeconds))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.SubTasks == input.SubTasks ||
                    this.SubTasks != null &&
                    input.SubTasks != null &&
                    this.SubTasks.Equals(input.SubTasks)
                ) && 
                (
                    this.TaskPath == input.TaskPath ||
                    (this.TaskPath != null &&
                    this.TaskPath.Equals(input.TaskPath))
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
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.EndTimeSeconds != null)
                    hashCode = hashCode * 59 + this.EndTimeSeconds.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.Events != null)
                    hashCode = hashCode * 59 + this.Events.GetHashCode();
                if (this.ExpectedEndTimeSeconds != null)
                    hashCode = hashCode * 59 + this.ExpectedEndTimeSeconds.GetHashCode();
                if (this.ExpectedSecondsRemaining != null)
                    hashCode = hashCode * 59 + this.ExpectedSecondsRemaining.GetHashCode();
                if (this.ExpectedTotalWorkCount != null)
                    hashCode = hashCode * 59 + this.ExpectedTotalWorkCount.GetHashCode();
                if (this.LastUpdateTimeSeconds != null)
                    hashCode = hashCode * 59 + this.LastUpdateTimeSeconds.GetHashCode();
                if (this.PercentFinished != null)
                    hashCode = hashCode * 59 + this.PercentFinished.GetHashCode();
                if (this.StartTimeSeconds != null)
                    hashCode = hashCode * 59 + this.StartTimeSeconds.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SubTasks != null)
                    hashCode = hashCode * 59 + this.SubTasks.GetHashCode();
                if (this.TaskPath != null)
                    hashCode = hashCode * 59 + this.TaskPath.GetHashCode();
                return hashCode;
            }
        }

    }

}


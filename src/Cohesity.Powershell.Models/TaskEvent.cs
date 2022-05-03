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
    /// Specifies events that clients can attach to a task.
    /// </summary>
    [DataContract]
    public partial class TaskEvent :  IEquatable<TaskEvent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskEvent" /> class.
        /// </summary>
        /// <param name="eventMessage">Specifies the message associated with an event..</param>
        /// <param name="percentFinished">Specifies the completion percentage of the task attached to this event..</param>
        /// <param name="remainingWorkCount">Specifies the amount of work remaining for the task attached to this event..</param>
        /// <param name="timestampSeconds">Specifies the Unix timestamp that the event occurred..</param>
        public TaskEvent(string eventMessage = default(string), float? percentFinished = default(float?), long? remainingWorkCount = default(long?), long? timestampSeconds = default(long?))
        {
            this.EventMessage = eventMessage;
            this.PercentFinished = percentFinished;
            this.RemainingWorkCount = remainingWorkCount;
            this.TimestampSeconds = timestampSeconds;
        }
        
        /// <summary>
        /// Specifies the message associated with an event.
        /// </summary>
        /// <value>Specifies the message associated with an event.</value>
        [DataMember(Name="eventMessage", EmitDefaultValue=false)]
        public string EventMessage { get; set; }

        /// <summary>
        /// Specifies the completion percentage of the task attached to this event.
        /// </summary>
        /// <value>Specifies the completion percentage of the task attached to this event.</value>
        [DataMember(Name="percentFinished", EmitDefaultValue=false)]
        public float? PercentFinished { get; set; }

        /// <summary>
        /// Specifies the amount of work remaining for the task attached to this event.
        /// </summary>
        /// <value>Specifies the amount of work remaining for the task attached to this event.</value>
        [DataMember(Name="remainingWorkCount", EmitDefaultValue=false)]
        public long? RemainingWorkCount { get; set; }

        /// <summary>
        /// Specifies the Unix timestamp that the event occurred.
        /// </summary>
        /// <value>Specifies the Unix timestamp that the event occurred.</value>
        [DataMember(Name="timestampSeconds", EmitDefaultValue=false)]
        public long? TimestampSeconds { get; set; }

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
            return this.Equals(input as TaskEvent);
        }

        /// <summary>
        /// Returns true if TaskEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EventMessage == input.EventMessage ||
                    (this.EventMessage != null &&
                    this.EventMessage.Equals(input.EventMessage))
                ) && 
                (
                    this.PercentFinished == input.PercentFinished ||
                    (this.PercentFinished != null &&
                    this.PercentFinished.Equals(input.PercentFinished))
                ) && 
                (
                    this.RemainingWorkCount == input.RemainingWorkCount ||
                    (this.RemainingWorkCount != null &&
                    this.RemainingWorkCount.Equals(input.RemainingWorkCount))
                ) && 
                (
                    this.TimestampSeconds == input.TimestampSeconds ||
                    (this.TimestampSeconds != null &&
                    this.TimestampSeconds.Equals(input.TimestampSeconds))
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
                if (this.EventMessage != null)
                    hashCode = hashCode * 59 + this.EventMessage.GetHashCode();
                if (this.PercentFinished != null)
                    hashCode = hashCode * 59 + this.PercentFinished.GetHashCode();
                if (this.RemainingWorkCount != null)
                    hashCode = hashCode * 59 + this.RemainingWorkCount.GetHashCode();
                if (this.TimestampSeconds != null)
                    hashCode = hashCode * 59 + this.TimestampSeconds.GetHashCode();
                return hashCode;
            }
        }

    }

}


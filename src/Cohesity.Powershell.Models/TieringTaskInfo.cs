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
    /// TieringTaskInfo
    /// </summary>
    [DataContract]
    public partial class TieringTaskInfo :  IEquatable<TieringTaskInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TieringTaskInfo" /> class.
        /// </summary>
        /// <param name="instanceId">Id of that particular instance..</param>
        /// <param name="name">Name of the recovery task..</param>
        /// <param name="startTimeUsecs">Denotes the start time of the tieringtask, needed for deeplinking..</param>
        /// <param name="taskId">Id of the recovery task..</param>
        public TieringTaskInfo(string instanceId = default(string), string name = default(string), string startTimeUsecs = default(string), string taskId = default(string))
        {
            this.InstanceId = instanceId;
            this.Name = name;
            this.StartTimeUsecs = startTimeUsecs;
            this.TaskId = taskId;
        }
        
        /// <summary>
        /// Id of that particular instance.
        /// </summary>
        /// <value>Id of that particular instance.</value>
        [DataMember(Name="instanceId", EmitDefaultValue=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Name of the recovery task.
        /// </summary>
        /// <value>Name of the recovery task.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Denotes the start time of the tieringtask, needed for deeplinking.
        /// </summary>
        /// <value>Denotes the start time of the tieringtask, needed for deeplinking.</value>
        [DataMember(Name="startTimeUsecs", EmitDefaultValue=false)]
        public string StartTimeUsecs { get; set; }

        /// <summary>
        /// Id of the recovery task.
        /// </summary>
        /// <value>Id of the recovery task.</value>
        [DataMember(Name="taskId", EmitDefaultValue=false)]
        public string TaskId { get; set; }

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
            return this.Equals(input as TieringTaskInfo);
        }

        /// <summary>
        /// Returns true if TieringTaskInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of TieringTaskInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TieringTaskInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.StartTimeUsecs == input.StartTimeUsecs ||
                    (this.StartTimeUsecs != null &&
                    this.StartTimeUsecs.Equals(input.StartTimeUsecs))
                ) && 
                (
                    this.TaskId == input.TaskId ||
                    (this.TaskId != null &&
                    this.TaskId.Equals(input.TaskId))
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
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.StartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.StartTimeUsecs.GetHashCode();
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                return hashCode;
            }
        }

    }

}


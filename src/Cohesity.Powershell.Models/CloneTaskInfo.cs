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
    /// Parameters for a clone op.
    /// </summary>
    [DataContract]
    public partial class CloneTaskInfo :  IEquatable<CloneTaskInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloneTaskInfo" /> class.
        /// </summary>
        /// <param name="name">Name of the recovery task..</param>
        /// <param name="taskId">Id of the recovery task..</param>
        public CloneTaskInfo(string name = default(string), string taskId = default(string))
        {
            this.Name = name;
            this.TaskId = taskId;
            this.Name = name;
            this.TaskId = taskId;
        }
        
        /// <summary>
        /// Name of the recovery task.
        /// </summary>
        /// <value>Name of the recovery task.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Id of the recovery task.
        /// </summary>
        /// <value>Id of the recovery task.</value>
        [DataMember(Name="taskId", EmitDefaultValue=true)]
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
            return this.Equals(input as CloneTaskInfo);
        }

        /// <summary>
        /// Returns true if CloneTaskInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CloneTaskInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloneTaskInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                return hashCode;
            }
        }

    }

}


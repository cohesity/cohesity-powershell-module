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
    /// Parameters for a recovery op.
    /// </summary>
    [DataContract]
    public partial class RecoveryTaskInfo :  IEquatable<RecoveryTaskInfo>
    {
        /// <summary>
        /// Denotes if the recovery task has an archival target. This param is used to reflect if the recovery op has an archival target to work with. &#39;local&#39; indicates no archival target. &#39;archive&#39; indicates that objects restored using an archival target.
        /// </summary>
        /// <value>Denotes if the recovery task has an archival target. This param is used to reflect if the recovery op has an archival target to work with. &#39;local&#39; indicates no archival target. &#39;archive&#39; indicates that objects restored using an archival target.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Local for value: local
            /// </summary>
            [EnumMember(Value = "local")]
            Local = 1,

            /// <summary>
            /// Enum Archive for value: archive
            /// </summary>
            [EnumMember(Value = "archive")]
            Archive = 2

        }

        /// <summary>
        /// Denotes if the recovery task has an archival target. This param is used to reflect if the recovery op has an archival target to work with. &#39;local&#39; indicates no archival target. &#39;archive&#39; indicates that objects restored using an archival target.
        /// </summary>
        /// <value>Denotes if the recovery task has an archival target. This param is used to reflect if the recovery op has an archival target to work with. &#39;local&#39; indicates no archival target. &#39;archive&#39; indicates that objects restored using an archival target.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecoveryTaskInfo" /> class.
        /// </summary>
        /// <param name="name">Name of the recovery task..</param>
        /// <param name="taskId">Id of the recovery task..</param>
        /// <param name="type">Denotes if the recovery task has an archival target. This param is used to reflect if the recovery op has an archival target to work with. &#39;local&#39; indicates no archival target. &#39;archive&#39; indicates that objects restored using an archival target..</param>
        public RecoveryTaskInfo(string name = default(string), string taskId = default(string), TypeEnum? type = default(TypeEnum?))
        {
            this.Name = name;
            this.TaskId = taskId;
            this.Type = type;
            this.Name = name;
            this.TaskId = taskId;
            this.Type = type;
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
            return this.Equals(input as RecoveryTaskInfo);
        }

        /// <summary>
        /// Returns true if RecoveryTaskInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of RecoveryTaskInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecoveryTaskInfo input)
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
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}


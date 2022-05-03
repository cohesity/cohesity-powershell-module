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
    /// RecoverVolumesTaskStateProto
    /// </summary>
    [DataContract]
    public partial class RecoverVolumesTaskStateProto :  IEquatable<RecoverVolumesTaskStateProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecoverVolumesTaskStateProto" /> class.
        /// </summary>
        /// <param name="_params">_params.</param>
        /// <param name="taskResultVec">Contains high-level per-volume information. This data is here because Iris cannot see into protobuf extensions yet needs to display per-subtask progress..</param>
        public RecoverVolumesTaskStateProto(RecoverVolumesParams _params = default(RecoverVolumesParams), List<RecoverVolumesTaskStateProtoTaskResult> taskResultVec = default(List<RecoverVolumesTaskStateProtoTaskResult>))
        {
            this.Params = _params;
            this.TaskResultVec = taskResultVec;
        }
        
        /// <summary>
        /// Gets or Sets Params
        /// </summary>
        [DataMember(Name="params", EmitDefaultValue=false)]
        public RecoverVolumesParams Params { get; set; }

        /// <summary>
        /// Contains high-level per-volume information. This data is here because Iris cannot see into protobuf extensions yet needs to display per-subtask progress.
        /// </summary>
        /// <value>Contains high-level per-volume information. This data is here because Iris cannot see into protobuf extensions yet needs to display per-subtask progress.</value>
        [DataMember(Name="taskResultVec", EmitDefaultValue=false)]
        public List<RecoverVolumesTaskStateProtoTaskResult> TaskResultVec { get; set; }

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
            return this.Equals(input as RecoverVolumesTaskStateProto);
        }

        /// <summary>
        /// Returns true if RecoverVolumesTaskStateProto instances are equal
        /// </summary>
        /// <param name="input">Instance of RecoverVolumesTaskStateProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecoverVolumesTaskStateProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Params == input.Params ||
                    (this.Params != null &&
                    this.Params.Equals(input.Params))
                ) && 
                (
                    this.TaskResultVec == input.TaskResultVec ||
                    this.TaskResultVec != null &&
                    this.TaskResultVec.Equals(input.TaskResultVec)
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
                if (this.Params != null)
                    hashCode = hashCode * 59 + this.Params.GetHashCode();
                if (this.TaskResultVec != null)
                    hashCode = hashCode * 59 + this.TaskResultVec.GetHashCode();
                return hashCode;
            }
        }

    }

}


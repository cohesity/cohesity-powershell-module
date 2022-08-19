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
    /// Information of the object being restored along with the info of the task tracking the restore of that object.
    /// </summary>
    [DataContract]
    public partial class PerformRestoreJobStateProtoRestoreTask :  IEquatable<PerformRestoreJobStateProtoRestoreTask>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PerformRestoreJobStateProtoRestoreTask" /> class.
        /// </summary>
        /// <param name="_object">_object.</param>
        /// <param name="objectProgressMonitorTaskPath">The relative task path of the progress monitor for the restore of the above &#39;object&#39;. Please note that this field will be set only after progress monitor is created for this restore job..</param>
        /// <param name="preprocessingError">preprocessingError.</param>
        /// <param name="taskId">Id of the task tracking the restore of the above &#39;object&#39;..</param>
        public PerformRestoreJobStateProtoRestoreTask(RestoreObject _object = default(RestoreObject), string objectProgressMonitorTaskPath = default(string), ErrorProto preprocessingError = default(ErrorProto), long? taskId = default(long?))
        {
            this.Object = _object;
            this.ObjectProgressMonitorTaskPath = objectProgressMonitorTaskPath;
            this.PreprocessingError = preprocessingError;
            this.TaskId = taskId;
        }
        
        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public RestoreObject Object { get; set; }

        /// <summary>
        /// The relative task path of the progress monitor for the restore of the above &#39;object&#39;. Please note that this field will be set only after progress monitor is created for this restore job.
        /// </summary>
        /// <value>The relative task path of the progress monitor for the restore of the above &#39;object&#39;. Please note that this field will be set only after progress monitor is created for this restore job.</value>
        [DataMember(Name="objectProgressMonitorTaskPath", EmitDefaultValue=true)]
        public string ObjectProgressMonitorTaskPath { get; set; }

        /// <summary>
        /// Gets or Sets PreprocessingError
        /// </summary>
        [DataMember(Name="preprocessingError", EmitDefaultValue=false)]
        public ErrorProto PreprocessingError { get; set; }

        /// <summary>
        /// Id of the task tracking the restore of the above &#39;object&#39;.
        /// </summary>
        /// <value>Id of the task tracking the restore of the above &#39;object&#39;.</value>
        [DataMember(Name="taskId", EmitDefaultValue=true)]
        public long? TaskId { get; set; }

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
            return this.Equals(input as PerformRestoreJobStateProtoRestoreTask);
        }

        /// <summary>
        /// Returns true if PerformRestoreJobStateProtoRestoreTask instances are equal
        /// </summary>
        /// <param name="input">Instance of PerformRestoreJobStateProtoRestoreTask to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PerformRestoreJobStateProtoRestoreTask input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
                ) && 
                (
                    this.ObjectProgressMonitorTaskPath == input.ObjectProgressMonitorTaskPath ||
                    (this.ObjectProgressMonitorTaskPath != null &&
                    this.ObjectProgressMonitorTaskPath.Equals(input.ObjectProgressMonitorTaskPath))
                ) && 
                (
                    this.PreprocessingError == input.PreprocessingError ||
                    (this.PreprocessingError != null &&
                    this.PreprocessingError.Equals(input.PreprocessingError))
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
                if (this.Object != null)
                    hashCode = hashCode * 59 + this.Object.GetHashCode();
                if (this.ObjectProgressMonitorTaskPath != null)
                    hashCode = hashCode * 59 + this.ObjectProgressMonitorTaskPath.GetHashCode();
                if (this.PreprocessingError != null)
                    hashCode = hashCode * 59 + this.PreprocessingError.GetHashCode();
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                return hashCode;
            }
        }

    }

}


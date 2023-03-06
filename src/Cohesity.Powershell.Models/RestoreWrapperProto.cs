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
    /// If this message is a checkpoint record in WAL-logging or if this message is used to send restore task info back to the user, it will contain the info of the restore job/task and the list of all destroy tasks (only when the record is for a restore task of type clone) associated with it. If this message is delta record, it will contain the state mutation for one of individual restore job, restore task and individual destroy task.
    /// </summary>
    [DataContract]
    public partial class RestoreWrapperProto :  IEquatable<RestoreWrapperProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreWrapperProto" /> class.
        /// </summary>
        /// <param name="destroyClonedTaskStateVec">For a restore task of type &#39;Clone&#39;, this field contains the info of the destroy task(s)..</param>
        /// <param name="ownerRestoreWrapperProto">ownerRestoreWrapperProto.</param>
        /// <param name="performRefreshTaskStateVec">Contains information of the refresh tasks for a clone.</param>
        /// <param name="performRestoreJobState">performRestoreJobState.</param>
        /// <param name="performRestoreTaskState">performRestoreTaskState.</param>
        /// <param name="restoreSubTaskWrapperProtoVec">If this restore has sub tasks, the following field will get populated with the wrapper proto of all of its sub-tasks.  Note that this field is only populated for Iris in response to &#39;GetRestoreTasksArg&#39; RPC. It is not persisted in Magneto&#39;s WAL.  List of environments that use this field: kSQL : Used for multi-stage SQL restore that supports a hot-standy..</param>
        public RestoreWrapperProto(List<DestroyClonedTaskStateProto> destroyClonedTaskStateVec = default(List<DestroyClonedTaskStateProto>), RestoreWrapperProto ownerRestoreWrapperProto = default(RestoreWrapperProto), List<PerformRestoreTaskStateProto> performRefreshTaskStateVec = default(List<PerformRestoreTaskStateProto>), PerformRestoreJobStateProto performRestoreJobState = default(PerformRestoreJobStateProto), PerformRestoreTaskStateProto performRestoreTaskState = default(PerformRestoreTaskStateProto), List<Object> restoreSubTaskWrapperProtoVec = default(List<Object>))
        {
            this.DestroyClonedTaskStateVec = destroyClonedTaskStateVec;
            this.PerformRefreshTaskStateVec = performRefreshTaskStateVec;
            this.RestoreSubTaskWrapperProtoVec = restoreSubTaskWrapperProtoVec;
            this.DestroyClonedTaskStateVec = destroyClonedTaskStateVec;
            this.OwnerRestoreWrapperProto = ownerRestoreWrapperProto;
            this.PerformRefreshTaskStateVec = performRefreshTaskStateVec;
            this.PerformRestoreJobState = performRestoreJobState;
            this.PerformRestoreTaskState = performRestoreTaskState;
            this.RestoreSubTaskWrapperProtoVec = restoreSubTaskWrapperProtoVec;
        }
        
        /// <summary>
        /// For a restore task of type &#39;Clone&#39;, this field contains the info of the destroy task(s).
        /// </summary>
        /// <value>For a restore task of type &#39;Clone&#39;, this field contains the info of the destroy task(s).</value>
        [DataMember(Name="destroyClonedTaskStateVec", EmitDefaultValue=true)]
        public List<DestroyClonedTaskStateProto> DestroyClonedTaskStateVec { get; set; }

        /// <summary>
        /// Gets or Sets OwnerRestoreWrapperProto
        /// </summary>
        [DataMember(Name="ownerRestoreWrapperProto", EmitDefaultValue=false)]
        public RestoreWrapperProto OwnerRestoreWrapperProto { get; set; }

        /// <summary>
        /// Contains information of the refresh tasks for a clone
        /// </summary>
        /// <value>Contains information of the refresh tasks for a clone</value>
        [DataMember(Name="performRefreshTaskStateVec", EmitDefaultValue=true)]
        public List<PerformRestoreTaskStateProto> PerformRefreshTaskStateVec { get; set; }

        /// <summary>
        /// Gets or Sets PerformRestoreJobState
        /// </summary>
        [DataMember(Name="performRestoreJobState", EmitDefaultValue=false)]
        public PerformRestoreJobStateProto PerformRestoreJobState { get; set; }

        /// <summary>
        /// Gets or Sets PerformRestoreTaskState
        /// </summary>
        [DataMember(Name="performRestoreTaskState", EmitDefaultValue=false)]
        public PerformRestoreTaskStateProto PerformRestoreTaskState { get; set; }

        /// <summary>
        /// If this restore has sub tasks, the following field will get populated with the wrapper proto of all of its sub-tasks.  Note that this field is only populated for Iris in response to &#39;GetRestoreTasksArg&#39; RPC. It is not persisted in Magneto&#39;s WAL.  List of environments that use this field: kSQL : Used for multi-stage SQL restore that supports a hot-standy.
        /// </summary>
        /// <value>If this restore has sub tasks, the following field will get populated with the wrapper proto of all of its sub-tasks.  Note that this field is only populated for Iris in response to &#39;GetRestoreTasksArg&#39; RPC. It is not persisted in Magneto&#39;s WAL.  List of environments that use this field: kSQL : Used for multi-stage SQL restore that supports a hot-standy.</value>
        [DataMember(Name="restoreSubTaskWrapperProtoVec", EmitDefaultValue=true)]
        public List<Object> RestoreSubTaskWrapperProtoVec { get; set; }

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
            return this.Equals(input as RestoreWrapperProto);
        }

        /// <summary>
        /// Returns true if RestoreWrapperProto instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreWrapperProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreWrapperProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DestroyClonedTaskStateVec == input.DestroyClonedTaskStateVec ||
                    this.DestroyClonedTaskStateVec != null &&
                    input.DestroyClonedTaskStateVec != null &&
                    this.DestroyClonedTaskStateVec.SequenceEqual(input.DestroyClonedTaskStateVec)
                ) && 
                (
                    this.OwnerRestoreWrapperProto == input.OwnerRestoreWrapperProto ||
                    (this.OwnerRestoreWrapperProto != null &&
                    this.OwnerRestoreWrapperProto.Equals(input.OwnerRestoreWrapperProto))
                ) && 
                (
                    this.PerformRefreshTaskStateVec == input.PerformRefreshTaskStateVec ||
                    this.PerformRefreshTaskStateVec != null &&
                    input.PerformRefreshTaskStateVec != null &&
                    this.PerformRefreshTaskStateVec.SequenceEqual(input.PerformRefreshTaskStateVec)
                ) && 
                (
                    this.PerformRestoreJobState == input.PerformRestoreJobState ||
                    (this.PerformRestoreJobState != null &&
                    this.PerformRestoreJobState.Equals(input.PerformRestoreJobState))
                ) && 
                (
                    this.PerformRestoreTaskState == input.PerformRestoreTaskState ||
                    (this.PerformRestoreTaskState != null &&
                    this.PerformRestoreTaskState.Equals(input.PerformRestoreTaskState))
                ) && 
                (
                    this.RestoreSubTaskWrapperProtoVec == input.RestoreSubTaskWrapperProtoVec ||
                    this.RestoreSubTaskWrapperProtoVec != null &&
                    input.RestoreSubTaskWrapperProtoVec != null &&
                    this.RestoreSubTaskWrapperProtoVec.SequenceEqual(input.RestoreSubTaskWrapperProtoVec)
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
                if (this.DestroyClonedTaskStateVec != null)
                    hashCode = hashCode * 59 + this.DestroyClonedTaskStateVec.GetHashCode();
                if (this.OwnerRestoreWrapperProto != null)
                    hashCode = hashCode * 59 + this.OwnerRestoreWrapperProto.GetHashCode();
                if (this.PerformRefreshTaskStateVec != null)
                    hashCode = hashCode * 59 + this.PerformRefreshTaskStateVec.GetHashCode();
                if (this.PerformRestoreJobState != null)
                    hashCode = hashCode * 59 + this.PerformRestoreJobState.GetHashCode();
                if (this.PerformRestoreTaskState != null)
                    hashCode = hashCode * 59 + this.PerformRestoreTaskState.GetHashCode();
                if (this.RestoreSubTaskWrapperProtoVec != null)
                    hashCode = hashCode * 59 + this.RestoreSubTaskWrapperProtoVec.GetHashCode();
                return hashCode;
            }
        }

    }

}


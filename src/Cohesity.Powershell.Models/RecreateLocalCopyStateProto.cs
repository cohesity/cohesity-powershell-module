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
    /// A local copy is recreated by fetching it from secondary copies like archives in case a local copy is needed after its normal expiry.
    /// </summary>
    [DataContract]
    public partial class RecreateLocalCopyStateProto :  IEquatable<RecreateLocalCopyStateProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecreateLocalCopyStateProto" /> class.
        /// </summary>
        /// <param name="desiredExpiryTimestampUsecs">Expiry time of this recreated view..</param>
        /// <param name="endTimeUsecs">The end time of the recreate task. This is the time when the copy was created in kStubViewCreated state..</param>
        /// <param name="entityDirRelativePath">The relative path of the directory where the snapshot exists is the view..</param>
        /// <param name="entityId">Entity whose copy was recreated..</param>
        /// <param name="iceboxStubViewId">Denotes the int64 id of the above icebox stub view..</param>
        /// <param name="iceboxStubViewName">Denotes the icebox stub view from which this recreated local copy was cloned. If the local copy is not in kFullyHydrated status, then it is necessary to ensure that the icebox stub view is still alive..</param>
        /// <param name="jobUid">jobUid.</param>
        /// <param name="retrieveArchiveTaskUid">retrieveArchiveTaskUid.</param>
        /// <param name="runStartTimeUsecs">The backup run_start_time for which the recreation was performed..</param>
        /// <param name="status">State of the recreated copy..</param>
        /// <param name="taskId">The unique identifier for this recreate task..</param>
        /// <param name="viewBoxId">The view box where the recreated view resides..</param>
        /// <param name="viewName">Name of the view where the snapshot exists..</param>
        public RecreateLocalCopyStateProto(long? desiredExpiryTimestampUsecs = default(long?), long? endTimeUsecs = default(long?), string entityDirRelativePath = default(string), long? entityId = default(long?), long? iceboxStubViewId = default(long?), string iceboxStubViewName = default(string), UniversalIdProto jobUid = default(UniversalIdProto), UniversalIdProto retrieveArchiveTaskUid = default(UniversalIdProto), long? runStartTimeUsecs = default(long?), int? status = default(int?), long? taskId = default(long?), long? viewBoxId = default(long?), string viewName = default(string))
        {
            this.DesiredExpiryTimestampUsecs = desiredExpiryTimestampUsecs;
            this.EndTimeUsecs = endTimeUsecs;
            this.EntityDirRelativePath = entityDirRelativePath;
            this.EntityId = entityId;
            this.IceboxStubViewId = iceboxStubViewId;
            this.IceboxStubViewName = iceboxStubViewName;
            this.RunStartTimeUsecs = runStartTimeUsecs;
            this.Status = status;
            this.TaskId = taskId;
            this.ViewBoxId = viewBoxId;
            this.ViewName = viewName;
            this.DesiredExpiryTimestampUsecs = desiredExpiryTimestampUsecs;
            this.EndTimeUsecs = endTimeUsecs;
            this.EntityDirRelativePath = entityDirRelativePath;
            this.EntityId = entityId;
            this.IceboxStubViewId = iceboxStubViewId;
            this.IceboxStubViewName = iceboxStubViewName;
            this.JobUid = jobUid;
            this.RetrieveArchiveTaskUid = retrieveArchiveTaskUid;
            this.RunStartTimeUsecs = runStartTimeUsecs;
            this.Status = status;
            this.TaskId = taskId;
            this.ViewBoxId = viewBoxId;
            this.ViewName = viewName;
        }
        
        /// <summary>
        /// Expiry time of this recreated view.
        /// </summary>
        /// <value>Expiry time of this recreated view.</value>
        [DataMember(Name="desiredExpiryTimestampUsecs", EmitDefaultValue=true)]
        public long? DesiredExpiryTimestampUsecs { get; set; }

        /// <summary>
        /// The end time of the recreate task. This is the time when the copy was created in kStubViewCreated state.
        /// </summary>
        /// <value>The end time of the recreate task. This is the time when the copy was created in kStubViewCreated state.</value>
        [DataMember(Name="endTimeUsecs", EmitDefaultValue=true)]
        public long? EndTimeUsecs { get; set; }

        /// <summary>
        /// The relative path of the directory where the snapshot exists is the view.
        /// </summary>
        /// <value>The relative path of the directory where the snapshot exists is the view.</value>
        [DataMember(Name="entityDirRelativePath", EmitDefaultValue=true)]
        public string EntityDirRelativePath { get; set; }

        /// <summary>
        /// Entity whose copy was recreated.
        /// </summary>
        /// <value>Entity whose copy was recreated.</value>
        [DataMember(Name="entityId", EmitDefaultValue=true)]
        public long? EntityId { get; set; }

        /// <summary>
        /// Denotes the int64 id of the above icebox stub view.
        /// </summary>
        /// <value>Denotes the int64 id of the above icebox stub view.</value>
        [DataMember(Name="iceboxStubViewId", EmitDefaultValue=true)]
        public long? IceboxStubViewId { get; set; }

        /// <summary>
        /// Denotes the icebox stub view from which this recreated local copy was cloned. If the local copy is not in kFullyHydrated status, then it is necessary to ensure that the icebox stub view is still alive.
        /// </summary>
        /// <value>Denotes the icebox stub view from which this recreated local copy was cloned. If the local copy is not in kFullyHydrated status, then it is necessary to ensure that the icebox stub view is still alive.</value>
        [DataMember(Name="iceboxStubViewName", EmitDefaultValue=true)]
        public string IceboxStubViewName { get; set; }

        /// <summary>
        /// Gets or Sets JobUid
        /// </summary>
        [DataMember(Name="jobUid", EmitDefaultValue=false)]
        public UniversalIdProto JobUid { get; set; }

        /// <summary>
        /// Gets or Sets RetrieveArchiveTaskUid
        /// </summary>
        [DataMember(Name="retrieveArchiveTaskUid", EmitDefaultValue=false)]
        public UniversalIdProto RetrieveArchiveTaskUid { get; set; }

        /// <summary>
        /// The backup run_start_time for which the recreation was performed.
        /// </summary>
        /// <value>The backup run_start_time for which the recreation was performed.</value>
        [DataMember(Name="runStartTimeUsecs", EmitDefaultValue=true)]
        public long? RunStartTimeUsecs { get; set; }

        /// <summary>
        /// State of the recreated copy.
        /// </summary>
        /// <value>State of the recreated copy.</value>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public int? Status { get; set; }

        /// <summary>
        /// The unique identifier for this recreate task.
        /// </summary>
        /// <value>The unique identifier for this recreate task.</value>
        [DataMember(Name="taskId", EmitDefaultValue=true)]
        public long? TaskId { get; set; }

        /// <summary>
        /// The view box where the recreated view resides.
        /// </summary>
        /// <value>The view box where the recreated view resides.</value>
        [DataMember(Name="viewBoxId", EmitDefaultValue=true)]
        public long? ViewBoxId { get; set; }

        /// <summary>
        /// Name of the view where the snapshot exists.
        /// </summary>
        /// <value>Name of the view where the snapshot exists.</value>
        [DataMember(Name="viewName", EmitDefaultValue=true)]
        public string ViewName { get; set; }

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
            return this.Equals(input as RecreateLocalCopyStateProto);
        }

        /// <summary>
        /// Returns true if RecreateLocalCopyStateProto instances are equal
        /// </summary>
        /// <param name="input">Instance of RecreateLocalCopyStateProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecreateLocalCopyStateProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DesiredExpiryTimestampUsecs == input.DesiredExpiryTimestampUsecs ||
                    (this.DesiredExpiryTimestampUsecs != null &&
                    this.DesiredExpiryTimestampUsecs.Equals(input.DesiredExpiryTimestampUsecs))
                ) && 
                (
                    this.EndTimeUsecs == input.EndTimeUsecs ||
                    (this.EndTimeUsecs != null &&
                    this.EndTimeUsecs.Equals(input.EndTimeUsecs))
                ) && 
                (
                    this.EntityDirRelativePath == input.EntityDirRelativePath ||
                    (this.EntityDirRelativePath != null &&
                    this.EntityDirRelativePath.Equals(input.EntityDirRelativePath))
                ) && 
                (
                    this.EntityId == input.EntityId ||
                    (this.EntityId != null &&
                    this.EntityId.Equals(input.EntityId))
                ) && 
                (
                    this.IceboxStubViewId == input.IceboxStubViewId ||
                    (this.IceboxStubViewId != null &&
                    this.IceboxStubViewId.Equals(input.IceboxStubViewId))
                ) && 
                (
                    this.IceboxStubViewName == input.IceboxStubViewName ||
                    (this.IceboxStubViewName != null &&
                    this.IceboxStubViewName.Equals(input.IceboxStubViewName))
                ) && 
                (
                    this.JobUid == input.JobUid ||
                    (this.JobUid != null &&
                    this.JobUid.Equals(input.JobUid))
                ) && 
                (
                    this.RetrieveArchiveTaskUid == input.RetrieveArchiveTaskUid ||
                    (this.RetrieveArchiveTaskUid != null &&
                    this.RetrieveArchiveTaskUid.Equals(input.RetrieveArchiveTaskUid))
                ) && 
                (
                    this.RunStartTimeUsecs == input.RunStartTimeUsecs ||
                    (this.RunStartTimeUsecs != null &&
                    this.RunStartTimeUsecs.Equals(input.RunStartTimeUsecs))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.TaskId == input.TaskId ||
                    (this.TaskId != null &&
                    this.TaskId.Equals(input.TaskId))
                ) && 
                (
                    this.ViewBoxId == input.ViewBoxId ||
                    (this.ViewBoxId != null &&
                    this.ViewBoxId.Equals(input.ViewBoxId))
                ) && 
                (
                    this.ViewName == input.ViewName ||
                    (this.ViewName != null &&
                    this.ViewName.Equals(input.ViewName))
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
                if (this.DesiredExpiryTimestampUsecs != null)
                    hashCode = hashCode * 59 + this.DesiredExpiryTimestampUsecs.GetHashCode();
                if (this.EndTimeUsecs != null)
                    hashCode = hashCode * 59 + this.EndTimeUsecs.GetHashCode();
                if (this.EntityDirRelativePath != null)
                    hashCode = hashCode * 59 + this.EntityDirRelativePath.GetHashCode();
                if (this.EntityId != null)
                    hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                if (this.IceboxStubViewId != null)
                    hashCode = hashCode * 59 + this.IceboxStubViewId.GetHashCode();
                if (this.IceboxStubViewName != null)
                    hashCode = hashCode * 59 + this.IceboxStubViewName.GetHashCode();
                if (this.JobUid != null)
                    hashCode = hashCode * 59 + this.JobUid.GetHashCode();
                if (this.RetrieveArchiveTaskUid != null)
                    hashCode = hashCode * 59 + this.RetrieveArchiveTaskUid.GetHashCode();
                if (this.RunStartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.RunStartTimeUsecs.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.ViewBoxId != null)
                    hashCode = hashCode * 59 + this.ViewBoxId.GetHashCode();
                if (this.ViewName != null)
                    hashCode = hashCode * 59 + this.ViewName.GetHashCode();
                return hashCode;
            }
        }

    }

}


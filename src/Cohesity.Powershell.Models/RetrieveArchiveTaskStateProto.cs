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
    /// Persistent state of a retrieve of an archive task. Only one of either entity_vec or download_files_info needs to be specified in this proto, where entity_vec is for retrieving the whole objects from the archive, and download_files_info is for only downloading the specified files from the archive.
    /// </summary>
    [DataContract]
    public partial class RetrieveArchiveTaskStateProto :  IEquatable<RetrieveArchiveTaskStateProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveArchiveTaskStateProto" /> class.
        /// </summary>
        /// <param name="archivalTarget">archivalTarget.</param>
        /// <param name="archiveTaskUid">archiveTaskUid.</param>
        /// <param name="backupRunStartTimeUsecs">The start time of the backup run whose corresponding archive is being retrieved. This field is just used for logging purposes..</param>
        /// <param name="cancellationRequested">Whether this retrieval task has a pending cancellation request..</param>
        /// <param name="downloadFilesInfo">downloadFilesInfo.</param>
        /// <param name="endTimeUsecs">If the retrieval task has finished, this field contains the end time for the task..</param>
        /// <param name="entityVec">Information on the exact set of objects to retrieve from archive. Even if the user wanted to retrieve all objects from the archive, this field will contain all individual leaf-level objects..</param>
        /// <param name="error">error.</param>
        /// <param name="fullViewNameDEPRECATED">The full view name (external). This is composed of a Cohesity specific prefix and the user provided view name..</param>
        /// <param name="jobUid">jobUid.</param>
        /// <param name="name">The name of the retrieval task..</param>
        /// <param name="progressMonitorTaskPath">The path of the progress monitor for this task..</param>
        /// <param name="restoreArchiveFilesInfo">restoreArchiveFilesInfo.</param>
        /// <param name="restoreTaskId">For retrieve tasks created after the 2.8 release, this will contain the id of the restore task that created this retrieve task..</param>
        /// <param name="retrievalInfo">retrievalInfo.</param>
        /// <param name="startTimeUsecs">The start time for this retrieval task..</param>
        /// <param name="status">The status of this task..</param>
        /// <param name="taskUid">taskUid.</param>
        /// <param name="user">The user who requested this retrieval task..</param>
        /// <param name="vaultRestoreParams">vaultRestoreParams.</param>
        /// <param name="viewBoxId">The view box id to which &#39;view_name&#39; belongs to..</param>
        /// <param name="viewNameDEPRECATED">The view name as provided by the user for this retrieval task. Retrieved snapshots of the entities will be placed in this view..</param>
        public RetrieveArchiveTaskStateProto(ArchivalTarget archivalTarget = default(ArchivalTarget), UniversalIdProto archiveTaskUid = default(UniversalIdProto), long? backupRunStartTimeUsecs = default(long?), bool? cancellationRequested = default(bool?), RetrieveArchiveTaskStateProtoDownloadFilesInfo downloadFilesInfo = default(RetrieveArchiveTaskStateProtoDownloadFilesInfo), long? endTimeUsecs = default(long?), List<EntityProto> entityVec = default(List<EntityProto>), ErrorProto error = default(ErrorProto), string fullViewNameDEPRECATED = default(string), UniversalIdProto jobUid = default(UniversalIdProto), string name = default(string), string progressMonitorTaskPath = default(string), RetrieveArchiveTaskStateProtoDownloadFilesInfo restoreArchiveFilesInfo = default(RetrieveArchiveTaskStateProtoDownloadFilesInfo), long? restoreTaskId = default(long?), RetrieveArchiveInfo retrievalInfo = default(RetrieveArchiveInfo), long? startTimeUsecs = default(long?), int? status = default(int?), UniversalIdProto taskUid = default(UniversalIdProto), string user = default(string), VaultParamsRestoreParams vaultRestoreParams = default(VaultParamsRestoreParams), long? viewBoxId = default(long?), string viewNameDEPRECATED = default(string))
        {
            this.BackupRunStartTimeUsecs = backupRunStartTimeUsecs;
            this.CancellationRequested = cancellationRequested;
            this.EndTimeUsecs = endTimeUsecs;
            this.EntityVec = entityVec;
            this.FullViewNameDEPRECATED = fullViewNameDEPRECATED;
            this.Name = name;
            this.ProgressMonitorTaskPath = progressMonitorTaskPath;
            this.RestoreTaskId = restoreTaskId;
            this.StartTimeUsecs = startTimeUsecs;
            this.Status = status;
            this.User = user;
            this.ViewBoxId = viewBoxId;
            this.ViewNameDEPRECATED = viewNameDEPRECATED;
            this.ArchivalTarget = archivalTarget;
            this.ArchiveTaskUid = archiveTaskUid;
            this.BackupRunStartTimeUsecs = backupRunStartTimeUsecs;
            this.CancellationRequested = cancellationRequested;
            this.DownloadFilesInfo = downloadFilesInfo;
            this.EndTimeUsecs = endTimeUsecs;
            this.EntityVec = entityVec;
            this.Error = error;
            this.FullViewNameDEPRECATED = fullViewNameDEPRECATED;
            this.JobUid = jobUid;
            this.Name = name;
            this.ProgressMonitorTaskPath = progressMonitorTaskPath;
            this.RestoreArchiveFilesInfo = restoreArchiveFilesInfo;
            this.RestoreTaskId = restoreTaskId;
            this.RetrievalInfo = retrievalInfo;
            this.StartTimeUsecs = startTimeUsecs;
            this.Status = status;
            this.TaskUid = taskUid;
            this.User = user;
            this.VaultRestoreParams = vaultRestoreParams;
            this.ViewBoxId = viewBoxId;
            this.ViewNameDEPRECATED = viewNameDEPRECATED;
        }
        
        /// <summary>
        /// Gets or Sets ArchivalTarget
        /// </summary>
        [DataMember(Name="archivalTarget", EmitDefaultValue=false)]
        public ArchivalTarget ArchivalTarget { get; set; }

        /// <summary>
        /// Gets or Sets ArchiveTaskUid
        /// </summary>
        [DataMember(Name="archiveTaskUid", EmitDefaultValue=false)]
        public UniversalIdProto ArchiveTaskUid { get; set; }

        /// <summary>
        /// The start time of the backup run whose corresponding archive is being retrieved. This field is just used for logging purposes.
        /// </summary>
        /// <value>The start time of the backup run whose corresponding archive is being retrieved. This field is just used for logging purposes.</value>
        [DataMember(Name="backupRunStartTimeUsecs", EmitDefaultValue=true)]
        public long? BackupRunStartTimeUsecs { get; set; }

        /// <summary>
        /// Whether this retrieval task has a pending cancellation request.
        /// </summary>
        /// <value>Whether this retrieval task has a pending cancellation request.</value>
        [DataMember(Name="cancellationRequested", EmitDefaultValue=true)]
        public bool? CancellationRequested { get; set; }

        /// <summary>
        /// Gets or Sets DownloadFilesInfo
        /// </summary>
        [DataMember(Name="downloadFilesInfo", EmitDefaultValue=false)]
        public RetrieveArchiveTaskStateProtoDownloadFilesInfo DownloadFilesInfo { get; set; }

        /// <summary>
        /// If the retrieval task has finished, this field contains the end time for the task.
        /// </summary>
        /// <value>If the retrieval task has finished, this field contains the end time for the task.</value>
        [DataMember(Name="endTimeUsecs", EmitDefaultValue=true)]
        public long? EndTimeUsecs { get; set; }

        /// <summary>
        /// Information on the exact set of objects to retrieve from archive. Even if the user wanted to retrieve all objects from the archive, this field will contain all individual leaf-level objects.
        /// </summary>
        /// <value>Information on the exact set of objects to retrieve from archive. Even if the user wanted to retrieve all objects from the archive, this field will contain all individual leaf-level objects.</value>
        [DataMember(Name="entityVec", EmitDefaultValue=true)]
        public List<EntityProto> EntityVec { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public ErrorProto Error { get; set; }

        /// <summary>
        /// The full view name (external). This is composed of a Cohesity specific prefix and the user provided view name.
        /// </summary>
        /// <value>The full view name (external). This is composed of a Cohesity specific prefix and the user provided view name.</value>
        [DataMember(Name="fullViewName_DEPRECATED", EmitDefaultValue=true)]
        public string FullViewNameDEPRECATED { get; set; }

        /// <summary>
        /// Gets or Sets JobUid
        /// </summary>
        [DataMember(Name="jobUid", EmitDefaultValue=false)]
        public UniversalIdProto JobUid { get; set; }

        /// <summary>
        /// The name of the retrieval task.
        /// </summary>
        /// <value>The name of the retrieval task.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// The path of the progress monitor for this task.
        /// </summary>
        /// <value>The path of the progress monitor for this task.</value>
        [DataMember(Name="progressMonitorTaskPath", EmitDefaultValue=true)]
        public string ProgressMonitorTaskPath { get; set; }

        /// <summary>
        /// Gets or Sets RestoreArchiveFilesInfo
        /// </summary>
        [DataMember(Name="restoreArchiveFilesInfo", EmitDefaultValue=false)]
        public RetrieveArchiveTaskStateProtoDownloadFilesInfo RestoreArchiveFilesInfo { get; set; }

        /// <summary>
        /// For retrieve tasks created after the 2.8 release, this will contain the id of the restore task that created this retrieve task.
        /// </summary>
        /// <value>For retrieve tasks created after the 2.8 release, this will contain the id of the restore task that created this retrieve task.</value>
        [DataMember(Name="restoreTaskId", EmitDefaultValue=true)]
        public long? RestoreTaskId { get; set; }

        /// <summary>
        /// Gets or Sets RetrievalInfo
        /// </summary>
        [DataMember(Name="retrievalInfo", EmitDefaultValue=false)]
        public RetrieveArchiveInfo RetrievalInfo { get; set; }

        /// <summary>
        /// The start time for this retrieval task.
        /// </summary>
        /// <value>The start time for this retrieval task.</value>
        [DataMember(Name="startTimeUsecs", EmitDefaultValue=true)]
        public long? StartTimeUsecs { get; set; }

        /// <summary>
        /// The status of this task.
        /// </summary>
        /// <value>The status of this task.</value>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public int? Status { get; set; }

        /// <summary>
        /// Gets or Sets TaskUid
        /// </summary>
        [DataMember(Name="taskUid", EmitDefaultValue=false)]
        public UniversalIdProto TaskUid { get; set; }

        /// <summary>
        /// The user who requested this retrieval task.
        /// </summary>
        /// <value>The user who requested this retrieval task.</value>
        [DataMember(Name="user", EmitDefaultValue=true)]
        public string User { get; set; }

        /// <summary>
        /// Gets or Sets VaultRestoreParams
        /// </summary>
        [DataMember(Name="vaultRestoreParams", EmitDefaultValue=false)]
        public VaultParamsRestoreParams VaultRestoreParams { get; set; }

        /// <summary>
        /// The view box id to which &#39;view_name&#39; belongs to.
        /// </summary>
        /// <value>The view box id to which &#39;view_name&#39; belongs to.</value>
        [DataMember(Name="viewBoxId", EmitDefaultValue=true)]
        public long? ViewBoxId { get; set; }

        /// <summary>
        /// The view name as provided by the user for this retrieval task. Retrieved snapshots of the entities will be placed in this view.
        /// </summary>
        /// <value>The view name as provided by the user for this retrieval task. Retrieved snapshots of the entities will be placed in this view.</value>
        [DataMember(Name="viewName_DEPRECATED", EmitDefaultValue=true)]
        public string ViewNameDEPRECATED { get; set; }

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
            return this.Equals(input as RetrieveArchiveTaskStateProto);
        }

        /// <summary>
        /// Returns true if RetrieveArchiveTaskStateProto instances are equal
        /// </summary>
        /// <param name="input">Instance of RetrieveArchiveTaskStateProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RetrieveArchiveTaskStateProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ArchivalTarget == input.ArchivalTarget ||
                    (this.ArchivalTarget != null &&
                    this.ArchivalTarget.Equals(input.ArchivalTarget))
                ) && 
                (
                    this.ArchiveTaskUid == input.ArchiveTaskUid ||
                    (this.ArchiveTaskUid != null &&
                    this.ArchiveTaskUid.Equals(input.ArchiveTaskUid))
                ) && 
                (
                    this.BackupRunStartTimeUsecs == input.BackupRunStartTimeUsecs ||
                    (this.BackupRunStartTimeUsecs != null &&
                    this.BackupRunStartTimeUsecs.Equals(input.BackupRunStartTimeUsecs))
                ) && 
                (
                    this.CancellationRequested == input.CancellationRequested ||
                    (this.CancellationRequested != null &&
                    this.CancellationRequested.Equals(input.CancellationRequested))
                ) && 
                (
                    this.DownloadFilesInfo == input.DownloadFilesInfo ||
                    (this.DownloadFilesInfo != null &&
                    this.DownloadFilesInfo.Equals(input.DownloadFilesInfo))
                ) && 
                (
                    this.EndTimeUsecs == input.EndTimeUsecs ||
                    (this.EndTimeUsecs != null &&
                    this.EndTimeUsecs.Equals(input.EndTimeUsecs))
                ) && 
                (
                    this.EntityVec == input.EntityVec ||
                    this.EntityVec != null &&
                    input.EntityVec != null &&
                    this.EntityVec.SequenceEqual(input.EntityVec)
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.FullViewNameDEPRECATED == input.FullViewNameDEPRECATED ||
                    (this.FullViewNameDEPRECATED != null &&
                    this.FullViewNameDEPRECATED.Equals(input.FullViewNameDEPRECATED))
                ) && 
                (
                    this.JobUid == input.JobUid ||
                    (this.JobUid != null &&
                    this.JobUid.Equals(input.JobUid))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ProgressMonitorTaskPath == input.ProgressMonitorTaskPath ||
                    (this.ProgressMonitorTaskPath != null &&
                    this.ProgressMonitorTaskPath.Equals(input.ProgressMonitorTaskPath))
                ) && 
                (
                    this.RestoreArchiveFilesInfo == input.RestoreArchiveFilesInfo ||
                    (this.RestoreArchiveFilesInfo != null &&
                    this.RestoreArchiveFilesInfo.Equals(input.RestoreArchiveFilesInfo))
                ) && 
                (
                    this.RestoreTaskId == input.RestoreTaskId ||
                    (this.RestoreTaskId != null &&
                    this.RestoreTaskId.Equals(input.RestoreTaskId))
                ) && 
                (
                    this.RetrievalInfo == input.RetrievalInfo ||
                    (this.RetrievalInfo != null &&
                    this.RetrievalInfo.Equals(input.RetrievalInfo))
                ) && 
                (
                    this.StartTimeUsecs == input.StartTimeUsecs ||
                    (this.StartTimeUsecs != null &&
                    this.StartTimeUsecs.Equals(input.StartTimeUsecs))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.TaskUid == input.TaskUid ||
                    (this.TaskUid != null &&
                    this.TaskUid.Equals(input.TaskUid))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.VaultRestoreParams == input.VaultRestoreParams ||
                    (this.VaultRestoreParams != null &&
                    this.VaultRestoreParams.Equals(input.VaultRestoreParams))
                ) && 
                (
                    this.ViewBoxId == input.ViewBoxId ||
                    (this.ViewBoxId != null &&
                    this.ViewBoxId.Equals(input.ViewBoxId))
                ) && 
                (
                    this.ViewNameDEPRECATED == input.ViewNameDEPRECATED ||
                    (this.ViewNameDEPRECATED != null &&
                    this.ViewNameDEPRECATED.Equals(input.ViewNameDEPRECATED))
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
                if (this.ArchivalTarget != null)
                    hashCode = hashCode * 59 + this.ArchivalTarget.GetHashCode();
                if (this.ArchiveTaskUid != null)
                    hashCode = hashCode * 59 + this.ArchiveTaskUid.GetHashCode();
                if (this.BackupRunStartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.BackupRunStartTimeUsecs.GetHashCode();
                if (this.CancellationRequested != null)
                    hashCode = hashCode * 59 + this.CancellationRequested.GetHashCode();
                if (this.DownloadFilesInfo != null)
                    hashCode = hashCode * 59 + this.DownloadFilesInfo.GetHashCode();
                if (this.EndTimeUsecs != null)
                    hashCode = hashCode * 59 + this.EndTimeUsecs.GetHashCode();
                if (this.EntityVec != null)
                    hashCode = hashCode * 59 + this.EntityVec.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.FullViewNameDEPRECATED != null)
                    hashCode = hashCode * 59 + this.FullViewNameDEPRECATED.GetHashCode();
                if (this.JobUid != null)
                    hashCode = hashCode * 59 + this.JobUid.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProgressMonitorTaskPath != null)
                    hashCode = hashCode * 59 + this.ProgressMonitorTaskPath.GetHashCode();
                if (this.RestoreArchiveFilesInfo != null)
                    hashCode = hashCode * 59 + this.RestoreArchiveFilesInfo.GetHashCode();
                if (this.RestoreTaskId != null)
                    hashCode = hashCode * 59 + this.RestoreTaskId.GetHashCode();
                if (this.RetrievalInfo != null)
                    hashCode = hashCode * 59 + this.RetrievalInfo.GetHashCode();
                if (this.StartTimeUsecs != null)
                    hashCode = hashCode * 59 + this.StartTimeUsecs.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TaskUid != null)
                    hashCode = hashCode * 59 + this.TaskUid.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.VaultRestoreParams != null)
                    hashCode = hashCode * 59 + this.VaultRestoreParams.GetHashCode();
                if (this.ViewBoxId != null)
                    hashCode = hashCode * 59 + this.ViewBoxId.GetHashCode();
                if (this.ViewNameDEPRECATED != null)
                    hashCode = hashCode * 59 + this.ViewNameDEPRECATED.GetHashCode();
                return hashCode;
            }
        }

    }

}


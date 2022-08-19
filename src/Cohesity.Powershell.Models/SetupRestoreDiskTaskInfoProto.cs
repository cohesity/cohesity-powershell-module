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
    /// Each available extension is listed below along with the location of the proto file (relative to magneto/connectors) where it is defined.  SetupRestoreDiskTaskInfoProto extension, extension_number Location &#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D; vmware::SetupRestoreDiskTaskInfo vmware_setup_restore_disk_task_info, 100 connectors/vmware/vmware_setup_restore_disks.proto.proto  AgentSetupRestoreDiskTaskInfo agent_setup_restore_disk_task_info, 101 base/agent.proto  app_file::SetupRestoreTaskInfo app_file_setup_restore_task_info, 102 connectors/app_file/app_file_setup_restore.proto  hyperv::SetupRestoreDiskTaskInfo hyperv_setup_restore_disk_task_info, 103 connectors/hyperv/hyperv_setup_restore_disks.proto &#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;
    /// </summary>
    [DataContract]
    public partial class SetupRestoreDiskTaskInfoProto :  IEquatable<SetupRestoreDiskTaskInfoProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetupRestoreDiskTaskInfoProto" /> class.
        /// </summary>
        /// <param name="entity">entity.</param>
        /// <param name="progressMonitorRootTaskPath">The path to the progress monitor root task if any..</param>
        /// <param name="rootEntity">rootEntity.</param>
        /// <param name="sourceViewName">The source view which contains the backups for the &#39;entity&#39;..</param>
        /// <param name="taskId">The id of the associated task..</param>
        /// <param name="viewBoxId">The view box id containing the backups for the &#39;entity&#39;..</param>
        /// <param name="viewName">Destination view into which the files will be cloned..</param>
        public SetupRestoreDiskTaskInfoProto(EntityProto entity = default(EntityProto), string progressMonitorRootTaskPath = default(string), EntityProto rootEntity = default(EntityProto), string sourceViewName = default(string), long? taskId = default(long?), long? viewBoxId = default(long?), string viewName = default(string))
        {
            this.Entity = entity;
            this.ProgressMonitorRootTaskPath = progressMonitorRootTaskPath;
            this.RootEntity = rootEntity;
            this.SourceViewName = sourceViewName;
            this.TaskId = taskId;
            this.ViewBoxId = viewBoxId;
            this.ViewName = viewName;
        }
        
        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public EntityProto Entity { get; set; }

        /// <summary>
        /// The path to the progress monitor root task if any.
        /// </summary>
        /// <value>The path to the progress monitor root task if any.</value>
        [DataMember(Name="progressMonitorRootTaskPath", EmitDefaultValue=true)]
        public string ProgressMonitorRootTaskPath { get; set; }

        /// <summary>
        /// Gets or Sets RootEntity
        /// </summary>
        [DataMember(Name="rootEntity", EmitDefaultValue=false)]
        public EntityProto RootEntity { get; set; }

        /// <summary>
        /// The source view which contains the backups for the &#39;entity&#39;.
        /// </summary>
        /// <value>The source view which contains the backups for the &#39;entity&#39;.</value>
        [DataMember(Name="sourceViewName", EmitDefaultValue=true)]
        public string SourceViewName { get; set; }

        /// <summary>
        /// The id of the associated task.
        /// </summary>
        /// <value>The id of the associated task.</value>
        [DataMember(Name="taskId", EmitDefaultValue=true)]
        public long? TaskId { get; set; }

        /// <summary>
        /// The view box id containing the backups for the &#39;entity&#39;.
        /// </summary>
        /// <value>The view box id containing the backups for the &#39;entity&#39;.</value>
        [DataMember(Name="viewBoxId", EmitDefaultValue=true)]
        public long? ViewBoxId { get; set; }

        /// <summary>
        /// Destination view into which the files will be cloned.
        /// </summary>
        /// <value>Destination view into which the files will be cloned.</value>
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
            return this.Equals(input as SetupRestoreDiskTaskInfoProto);
        }

        /// <summary>
        /// Returns true if SetupRestoreDiskTaskInfoProto instances are equal
        /// </summary>
        /// <param name="input">Instance of SetupRestoreDiskTaskInfoProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetupRestoreDiskTaskInfoProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Entity == input.Entity ||
                    (this.Entity != null &&
                    this.Entity.Equals(input.Entity))
                ) && 
                (
                    this.ProgressMonitorRootTaskPath == input.ProgressMonitorRootTaskPath ||
                    (this.ProgressMonitorRootTaskPath != null &&
                    this.ProgressMonitorRootTaskPath.Equals(input.ProgressMonitorRootTaskPath))
                ) && 
                (
                    this.RootEntity == input.RootEntity ||
                    (this.RootEntity != null &&
                    this.RootEntity.Equals(input.RootEntity))
                ) && 
                (
                    this.SourceViewName == input.SourceViewName ||
                    (this.SourceViewName != null &&
                    this.SourceViewName.Equals(input.SourceViewName))
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
                if (this.Entity != null)
                    hashCode = hashCode * 59 + this.Entity.GetHashCode();
                if (this.ProgressMonitorRootTaskPath != null)
                    hashCode = hashCode * 59 + this.ProgressMonitorRootTaskPath.GetHashCode();
                if (this.RootEntity != null)
                    hashCode = hashCode * 59 + this.RootEntity.GetHashCode();
                if (this.SourceViewName != null)
                    hashCode = hashCode * 59 + this.SourceViewName.GetHashCode();
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


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
    /// CloudDeployInfoProtoCloudDeployEntity
    /// </summary>
    [DataContract]
    public partial class CloudDeployInfoProtoCloudDeployEntity :  IEquatable<CloudDeployInfoProtoCloudDeployEntity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudDeployInfoProtoCloudDeployEntity" /> class.
        /// </summary>
        /// <param name="deployedVmName">Optional name that should be used for deployed VM..</param>
        /// <param name="entity">entity.</param>
        /// <param name="error">error.</param>
        /// <param name="previousRelativeCloneDirPath">Directory where files of the entity&#39;s previous snapshot were cloned to. Path is relative to the destination view..</param>
        /// <param name="previousRelativeClonePaths">All the paths that the entity&#39;s previous snapshot files were cloned to. Each path is relative to the destination view..</param>
        /// <param name="progressMonitorTaskPath">Progress monitor task path for this entity which is relative to the root path of the cloud deploy task progress monitor..</param>
        /// <param name="publicStatus">Iris-facing task state. This field is stamped during the export..</param>
        /// <param name="relativeClonePaths">All the paths that the entity&#39;s files were cloned to. Each path is relative to the destination view..</param>
        /// <param name="status">The status of the entity..</param>
        public CloudDeployInfoProtoCloudDeployEntity(string deployedVmName = default(string), EntityProto entity = default(EntityProto), ErrorProto error = default(ErrorProto), string previousRelativeCloneDirPath = default(string), List<string> previousRelativeClonePaths = default(List<string>), string progressMonitorTaskPath = default(string), int? publicStatus = default(int?), List<string> relativeClonePaths = default(List<string>), int? status = default(int?))
        {
            this.DeployedVmName = deployedVmName;
            this.Entity = entity;
            this.Error = error;
            this.PreviousRelativeCloneDirPath = previousRelativeCloneDirPath;
            this.PreviousRelativeClonePaths = previousRelativeClonePaths;
            this.ProgressMonitorTaskPath = progressMonitorTaskPath;
            this.PublicStatus = publicStatus;
            this.RelativeClonePaths = relativeClonePaths;
            this.Status = status;
        }
        
        /// <summary>
        /// Optional name that should be used for deployed VM.
        /// </summary>
        /// <value>Optional name that should be used for deployed VM.</value>
        [DataMember(Name="deployedVmName", EmitDefaultValue=false)]
        public string DeployedVmName { get; set; }

        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public EntityProto Entity { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public ErrorProto Error { get; set; }

        /// <summary>
        /// Directory where files of the entity&#39;s previous snapshot were cloned to. Path is relative to the destination view.
        /// </summary>
        /// <value>Directory where files of the entity&#39;s previous snapshot were cloned to. Path is relative to the destination view.</value>
        [DataMember(Name="previousRelativeCloneDirPath", EmitDefaultValue=false)]
        public string PreviousRelativeCloneDirPath { get; set; }

        /// <summary>
        /// All the paths that the entity&#39;s previous snapshot files were cloned to. Each path is relative to the destination view.
        /// </summary>
        /// <value>All the paths that the entity&#39;s previous snapshot files were cloned to. Each path is relative to the destination view.</value>
        [DataMember(Name="previousRelativeClonePaths", EmitDefaultValue=false)]
        public List<string> PreviousRelativeClonePaths { get; set; }

        /// <summary>
        /// Progress monitor task path for this entity which is relative to the root path of the cloud deploy task progress monitor.
        /// </summary>
        /// <value>Progress monitor task path for this entity which is relative to the root path of the cloud deploy task progress monitor.</value>
        [DataMember(Name="progressMonitorTaskPath", EmitDefaultValue=false)]
        public string ProgressMonitorTaskPath { get; set; }

        /// <summary>
        /// Iris-facing task state. This field is stamped during the export.
        /// </summary>
        /// <value>Iris-facing task state. This field is stamped during the export.</value>
        [DataMember(Name="publicStatus", EmitDefaultValue=false)]
        public int? PublicStatus { get; set; }

        /// <summary>
        /// All the paths that the entity&#39;s files were cloned to. Each path is relative to the destination view.
        /// </summary>
        /// <value>All the paths that the entity&#39;s files were cloned to. Each path is relative to the destination view.</value>
        [DataMember(Name="relativeClonePaths", EmitDefaultValue=false)]
        public List<string> RelativeClonePaths { get; set; }

        /// <summary>
        /// The status of the entity.
        /// </summary>
        /// <value>The status of the entity.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }

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
            return this.Equals(input as CloudDeployInfoProtoCloudDeployEntity);
        }

        /// <summary>
        /// Returns true if CloudDeployInfoProtoCloudDeployEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of CloudDeployInfoProtoCloudDeployEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloudDeployInfoProtoCloudDeployEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeployedVmName == input.DeployedVmName ||
                    (this.DeployedVmName != null &&
                    this.DeployedVmName.Equals(input.DeployedVmName))
                ) && 
                (
                    this.Entity == input.Entity ||
                    (this.Entity != null &&
                    this.Entity.Equals(input.Entity))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.PreviousRelativeCloneDirPath == input.PreviousRelativeCloneDirPath ||
                    (this.PreviousRelativeCloneDirPath != null &&
                    this.PreviousRelativeCloneDirPath.Equals(input.PreviousRelativeCloneDirPath))
                ) && 
                (
                    this.PreviousRelativeClonePaths == input.PreviousRelativeClonePaths ||
                    this.PreviousRelativeClonePaths != null &&
                    this.PreviousRelativeClonePaths.Equals(input.PreviousRelativeClonePaths)
                ) && 
                (
                    this.ProgressMonitorTaskPath == input.ProgressMonitorTaskPath ||
                    (this.ProgressMonitorTaskPath != null &&
                    this.ProgressMonitorTaskPath.Equals(input.ProgressMonitorTaskPath))
                ) && 
                (
                    this.PublicStatus == input.PublicStatus ||
                    (this.PublicStatus != null &&
                    this.PublicStatus.Equals(input.PublicStatus))
                ) && 
                (
                    this.RelativeClonePaths == input.RelativeClonePaths ||
                    this.RelativeClonePaths != null &&
                    this.RelativeClonePaths.Equals(input.RelativeClonePaths)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.DeployedVmName != null)
                    hashCode = hashCode * 59 + this.DeployedVmName.GetHashCode();
                if (this.Entity != null)
                    hashCode = hashCode * 59 + this.Entity.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.PreviousRelativeCloneDirPath != null)
                    hashCode = hashCode * 59 + this.PreviousRelativeCloneDirPath.GetHashCode();
                if (this.PreviousRelativeClonePaths != null)
                    hashCode = hashCode * 59 + this.PreviousRelativeClonePaths.GetHashCode();
                if (this.ProgressMonitorTaskPath != null)
                    hashCode = hashCode * 59 + this.ProgressMonitorTaskPath.GetHashCode();
                if (this.PublicStatus != null)
                    hashCode = hashCode * 59 + this.PublicStatus.GetHashCode();
                if (this.RelativeClonePaths != null)
                    hashCode = hashCode * 59 + this.RelativeClonePaths.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }

    }

}


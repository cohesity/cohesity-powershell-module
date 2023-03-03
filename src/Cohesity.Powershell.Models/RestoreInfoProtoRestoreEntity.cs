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
    /// RestoreInfoProtoRestoreEntity
    /// </summary>
    [DataContract]
    public partial class RestoreInfoProtoRestoreEntity :  IEquatable<RestoreInfoProtoRestoreEntity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreInfoProtoRestoreEntity" /> class.
        /// </summary>
        /// <param name="entity">entity.</param>
        /// <param name="error">error.</param>
        /// <param name="progressMonitorTaskPath">The path relative to the root path of the restore task progress monitor of the progress monitor for this entity..</param>
        /// <param name="publicStatus">Iris-facing task state. This field is stamped during the export..</param>
        /// <param name="relativeRestorePaths">All the paths that the entity&#39;s files were restored to. Each path is relative to the destination view..</param>
        /// <param name="resourcePoolEntity">resourcePoolEntity.</param>
        /// <param name="restoredEntity">restoredEntity.</param>
        /// <param name="restoredViewName">Cloned or converted view name which is used to restore the entity. In case of on-prem deploy task this view name will be used in next run..</param>
        /// <param name="status">The restore status of the entity..</param>
        /// <param name="totalBytesRestored">Contains the information regarding total bytes restored for this entity. Currently updated only in case of outlook restore..</param>
        /// <param name="warnings">Optional warnings if any..</param>
        public RestoreInfoProtoRestoreEntity(EntityProto entity = default(EntityProto), ErrorProto error = default(ErrorProto), string progressMonitorTaskPath = default(string), int? publicStatus = default(int?), List<string> relativeRestorePaths = default(List<string>), EntityProto resourcePoolEntity = default(EntityProto), EntityProto restoredEntity = default(EntityProto), string restoredViewName = default(string), int? status = default(int?), long? totalBytesRestored = default(long?), List<ErrorProto> warnings = default(List<ErrorProto>))
        {
            this.ProgressMonitorTaskPath = progressMonitorTaskPath;
            this.PublicStatus = publicStatus;
            this.RelativeRestorePaths = relativeRestorePaths;
            this.RestoredViewName = restoredViewName;
            this.Status = status;
            this.TotalBytesRestored = totalBytesRestored;
            this.Warnings = warnings;
            this.Entity = entity;
            this.Error = error;
            this.ProgressMonitorTaskPath = progressMonitorTaskPath;
            this.PublicStatus = publicStatus;
            this.RelativeRestorePaths = relativeRestorePaths;
            this.ResourcePoolEntity = resourcePoolEntity;
            this.RestoredEntity = restoredEntity;
            this.RestoredViewName = restoredViewName;
            this.Status = status;
            this.TotalBytesRestored = totalBytesRestored;
            this.Warnings = warnings;
        }
        
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
        /// The path relative to the root path of the restore task progress monitor of the progress monitor for this entity.
        /// </summary>
        /// <value>The path relative to the root path of the restore task progress monitor of the progress monitor for this entity.</value>
        [DataMember(Name="progressMonitorTaskPath", EmitDefaultValue=true)]
        public string ProgressMonitorTaskPath { get; set; }

        /// <summary>
        /// Iris-facing task state. This field is stamped during the export.
        /// </summary>
        /// <value>Iris-facing task state. This field is stamped during the export.</value>
        [DataMember(Name="publicStatus", EmitDefaultValue=true)]
        public int? PublicStatus { get; set; }

        /// <summary>
        /// All the paths that the entity&#39;s files were restored to. Each path is relative to the destination view.
        /// </summary>
        /// <value>All the paths that the entity&#39;s files were restored to. Each path is relative to the destination view.</value>
        [DataMember(Name="relativeRestorePaths", EmitDefaultValue=true)]
        public List<string> RelativeRestorePaths { get; set; }

        /// <summary>
        /// Gets or Sets ResourcePoolEntity
        /// </summary>
        [DataMember(Name="resourcePoolEntity", EmitDefaultValue=false)]
        public EntityProto ResourcePoolEntity { get; set; }

        /// <summary>
        /// Gets or Sets RestoredEntity
        /// </summary>
        [DataMember(Name="restoredEntity", EmitDefaultValue=false)]
        public EntityProto RestoredEntity { get; set; }

        /// <summary>
        /// Cloned or converted view name which is used to restore the entity. In case of on-prem deploy task this view name will be used in next run.
        /// </summary>
        /// <value>Cloned or converted view name which is used to restore the entity. In case of on-prem deploy task this view name will be used in next run.</value>
        [DataMember(Name="restoredViewName", EmitDefaultValue=true)]
        public string RestoredViewName { get; set; }

        /// <summary>
        /// The restore status of the entity.
        /// </summary>
        /// <value>The restore status of the entity.</value>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public int? Status { get; set; }

        /// <summary>
        /// Contains the information regarding total bytes restored for this entity. Currently updated only in case of outlook restore.
        /// </summary>
        /// <value>Contains the information regarding total bytes restored for this entity. Currently updated only in case of outlook restore.</value>
        [DataMember(Name="totalBytesRestored", EmitDefaultValue=true)]
        public long? TotalBytesRestored { get; set; }

        /// <summary>
        /// Optional warnings if any.
        /// </summary>
        /// <value>Optional warnings if any.</value>
        [DataMember(Name="warnings", EmitDefaultValue=true)]
        public List<ErrorProto> Warnings { get; set; }

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
            return this.Equals(input as RestoreInfoProtoRestoreEntity);
        }

        /// <summary>
        /// Returns true if RestoreInfoProtoRestoreEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreInfoProtoRestoreEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreInfoProtoRestoreEntity input)
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
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
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
                    this.RelativeRestorePaths == input.RelativeRestorePaths ||
                    this.RelativeRestorePaths != null &&
                    input.RelativeRestorePaths != null &&
                    this.RelativeRestorePaths.SequenceEqual(input.RelativeRestorePaths)
                ) && 
                (
                    this.ResourcePoolEntity == input.ResourcePoolEntity ||
                    (this.ResourcePoolEntity != null &&
                    this.ResourcePoolEntity.Equals(input.ResourcePoolEntity))
                ) && 
                (
                    this.RestoredEntity == input.RestoredEntity ||
                    (this.RestoredEntity != null &&
                    this.RestoredEntity.Equals(input.RestoredEntity))
                ) && 
                (
                    this.RestoredViewName == input.RestoredViewName ||
                    (this.RestoredViewName != null &&
                    this.RestoredViewName.Equals(input.RestoredViewName))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.TotalBytesRestored == input.TotalBytesRestored ||
                    (this.TotalBytesRestored != null &&
                    this.TotalBytesRestored.Equals(input.TotalBytesRestored))
                ) && 
                (
                    this.Warnings == input.Warnings ||
                    this.Warnings != null &&
                    input.Warnings != null &&
                    this.Warnings.SequenceEqual(input.Warnings)
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
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.ProgressMonitorTaskPath != null)
                    hashCode = hashCode * 59 + this.ProgressMonitorTaskPath.GetHashCode();
                if (this.PublicStatus != null)
                    hashCode = hashCode * 59 + this.PublicStatus.GetHashCode();
                if (this.RelativeRestorePaths != null)
                    hashCode = hashCode * 59 + this.RelativeRestorePaths.GetHashCode();
                if (this.ResourcePoolEntity != null)
                    hashCode = hashCode * 59 + this.ResourcePoolEntity.GetHashCode();
                if (this.RestoredEntity != null)
                    hashCode = hashCode * 59 + this.RestoredEntity.GetHashCode();
                if (this.RestoredViewName != null)
                    hashCode = hashCode * 59 + this.RestoredViewName.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TotalBytesRestored != null)
                    hashCode = hashCode * 59 + this.TotalBytesRestored.GetHashCode();
                if (this.Warnings != null)
                    hashCode = hashCode * 59 + this.Warnings.GetHashCode();
                return hashCode;
            }
        }

    }

}


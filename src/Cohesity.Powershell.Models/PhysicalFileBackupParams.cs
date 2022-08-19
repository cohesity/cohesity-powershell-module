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
    /// Message to capture params when backing up files on a Physical source.
    /// </summary>
    [DataContract]
    public partial class PhysicalFileBackupParams :  IEquatable<PhysicalFileBackupParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalFileBackupParams" /> class.
        /// </summary>
        /// <param name="backupPathInfoVec">Specifies the paths to backup on the Physical source..</param>
        /// <param name="metadataFilePath">Specifies metadata path on source. This file contains absolute paths of files that needs to be backed up on the same source. If this field is set, backup_path_info_vec will be ignored..</param>
        /// <param name="skipNestedVolumesVec">Mount types of nested volumes to be skipped..</param>
        /// <param name="symlinkFollowNasTarget">Specifies whether to follow nas target pointed by symlink. Set to true only for windows physical file based job..</param>
        /// <param name="usesSkipNestedVolumesVec">Specifies whether to use skip_nested_volumes_vec to skip nested mounts. Before 6.4, BackupPathInfo.skip_nested_volumes boolean was used to skip nested volumes. So we use this boolean to support older jobs..</param>
        public PhysicalFileBackupParams(List<PhysicalFileBackupParamsBackupPathInfo> backupPathInfoVec = default(List<PhysicalFileBackupParamsBackupPathInfo>), string metadataFilePath = default(string), List<string> skipNestedVolumesVec = default(List<string>), bool? symlinkFollowNasTarget = default(bool?), bool? usesSkipNestedVolumesVec = default(bool?))
        {
            this.BackupPathInfoVec = backupPathInfoVec;
            this.MetadataFilePath = metadataFilePath;
            this.SkipNestedVolumesVec = skipNestedVolumesVec;
            this.SymlinkFollowNasTarget = symlinkFollowNasTarget;
            this.UsesSkipNestedVolumesVec = usesSkipNestedVolumesVec;
        }
        
        /// <summary>
        /// Specifies the paths to backup on the Physical source.
        /// </summary>
        /// <value>Specifies the paths to backup on the Physical source.</value>
        [DataMember(Name="backupPathInfoVec", EmitDefaultValue=true)]
        public List<PhysicalFileBackupParamsBackupPathInfo> BackupPathInfoVec { get; set; }

        /// <summary>
        /// Specifies metadata path on source. This file contains absolute paths of files that needs to be backed up on the same source. If this field is set, backup_path_info_vec will be ignored.
        /// </summary>
        /// <value>Specifies metadata path on source. This file contains absolute paths of files that needs to be backed up on the same source. If this field is set, backup_path_info_vec will be ignored.</value>
        [DataMember(Name="metadataFilePath", EmitDefaultValue=true)]
        public string MetadataFilePath { get; set; }

        /// <summary>
        /// Mount types of nested volumes to be skipped.
        /// </summary>
        /// <value>Mount types of nested volumes to be skipped.</value>
        [DataMember(Name="skipNestedVolumesVec", EmitDefaultValue=true)]
        public List<string> SkipNestedVolumesVec { get; set; }

        /// <summary>
        /// Specifies whether to follow nas target pointed by symlink. Set to true only for windows physical file based job.
        /// </summary>
        /// <value>Specifies whether to follow nas target pointed by symlink. Set to true only for windows physical file based job.</value>
        [DataMember(Name="symlinkFollowNasTarget", EmitDefaultValue=true)]
        public bool? SymlinkFollowNasTarget { get; set; }

        /// <summary>
        /// Specifies whether to use skip_nested_volumes_vec to skip nested mounts. Before 6.4, BackupPathInfo.skip_nested_volumes boolean was used to skip nested volumes. So we use this boolean to support older jobs.
        /// </summary>
        /// <value>Specifies whether to use skip_nested_volumes_vec to skip nested mounts. Before 6.4, BackupPathInfo.skip_nested_volumes boolean was used to skip nested volumes. So we use this boolean to support older jobs.</value>
        [DataMember(Name="usesSkipNestedVolumesVec", EmitDefaultValue=true)]
        public bool? UsesSkipNestedVolumesVec { get; set; }

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
            return this.Equals(input as PhysicalFileBackupParams);
        }

        /// <summary>
        /// Returns true if PhysicalFileBackupParams instances are equal
        /// </summary>
        /// <param name="input">Instance of PhysicalFileBackupParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhysicalFileBackupParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackupPathInfoVec == input.BackupPathInfoVec ||
                    this.BackupPathInfoVec != null &&
                    input.BackupPathInfoVec != null &&
                    this.BackupPathInfoVec.Equals(input.BackupPathInfoVec)
                ) && 
                (
                    this.MetadataFilePath == input.MetadataFilePath ||
                    (this.MetadataFilePath != null &&
                    this.MetadataFilePath.Equals(input.MetadataFilePath))
                ) && 
                (
                    this.SkipNestedVolumesVec == input.SkipNestedVolumesVec ||
                    this.SkipNestedVolumesVec != null &&
                    input.SkipNestedVolumesVec != null &&
                    this.SkipNestedVolumesVec.Equals(input.SkipNestedVolumesVec)
                ) && 
                (
                    this.SymlinkFollowNasTarget == input.SymlinkFollowNasTarget ||
                    (this.SymlinkFollowNasTarget != null &&
                    this.SymlinkFollowNasTarget.Equals(input.SymlinkFollowNasTarget))
                ) && 
                (
                    this.UsesSkipNestedVolumesVec == input.UsesSkipNestedVolumesVec ||
                    (this.UsesSkipNestedVolumesVec != null &&
                    this.UsesSkipNestedVolumesVec.Equals(input.UsesSkipNestedVolumesVec))
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
                if (this.BackupPathInfoVec != null)
                    hashCode = hashCode * 59 + this.BackupPathInfoVec.GetHashCode();
                if (this.MetadataFilePath != null)
                    hashCode = hashCode * 59 + this.MetadataFilePath.GetHashCode();
                if (this.SkipNestedVolumesVec != null)
                    hashCode = hashCode * 59 + this.SkipNestedVolumesVec.GetHashCode();
                if (this.SymlinkFollowNasTarget != null)
                    hashCode = hashCode * 59 + this.SymlinkFollowNasTarget.GetHashCode();
                if (this.UsesSkipNestedVolumesVec != null)
                    hashCode = hashCode * 59 + this.UsesSkipNestedVolumesVec.GetHashCode();
                return hashCode;
            }
        }

    }

}


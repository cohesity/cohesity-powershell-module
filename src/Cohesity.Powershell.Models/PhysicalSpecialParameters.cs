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
    /// Specifies additional special settings applicable for a Protection Source of &#39;kPhysical&#39; type in a Protection Job.
    /// </summary>
    [DataContract]
    public partial class PhysicalSpecialParameters :  IEquatable<PhysicalSpecialParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalSpecialParameters" /> class.
        /// </summary>
        /// <param name="applicationParameters">applicationParameters.</param>
        /// <param name="enableSystemBackup">Specifies whether to allow system backup using 3rd party tools installed on the Protection Host. System backups are used for doing bare metal recovery later. This field is applicable only for System backups..</param>
        /// <param name="filePaths">Array of File Paths to Back Up.  Specifies a list of directories or files to protect in a Physical Server..</param>
        /// <param name="metadataFilePath">Specifies metadata path on source. This file contains absolute paths of files that needs to be backed up on the same source..</param>
        /// <param name="skipNestedVolumesVec">Specifies mounttypes of nested volumes to be skipped..</param>
        /// <param name="usesSkipNestedVolumesVec">Specifies whether to use SkipNestedVolumes vec to skip nested mounts..</param>
        /// <param name="volumeGuid">Array of Mounted Volumes to Back Up.  Specifies the subset of mounted volumes to protect in a Physical Server. If not specified, all mounted volumes on a Physical Server are protected..</param>
        /// <param name="windowsParameters">windowsParameters.</param>
        public PhysicalSpecialParameters(ApplicationParameters applicationParameters = default(ApplicationParameters), bool? enableSystemBackup = default(bool?), List<FilePathParameters> filePaths = default(List<FilePathParameters>), string metadataFilePath = default(string), List<string> skipNestedVolumesVec = default(List<string>), bool? usesSkipNestedVolumesVec = default(bool?), List<string> volumeGuid = default(List<string>), WindowsHostSnapshotParameters windowsParameters = default(WindowsHostSnapshotParameters))
        {
            this.ApplicationParameters = applicationParameters;
            this.EnableSystemBackup = enableSystemBackup;
            this.FilePaths = filePaths;
            this.MetadataFilePath = metadataFilePath;
            this.SkipNestedVolumesVec = skipNestedVolumesVec;
            this.UsesSkipNestedVolumesVec = usesSkipNestedVolumesVec;
            this.VolumeGuid = volumeGuid;
            this.WindowsParameters = windowsParameters;
        }
        
        /// <summary>
        /// Gets or Sets ApplicationParameters
        /// </summary>
        [DataMember(Name="applicationParameters", EmitDefaultValue=false)]
        public ApplicationParameters ApplicationParameters { get; set; }

        /// <summary>
        /// Specifies whether to allow system backup using 3rd party tools installed on the Protection Host. System backups are used for doing bare metal recovery later. This field is applicable only for System backups.
        /// </summary>
        /// <value>Specifies whether to allow system backup using 3rd party tools installed on the Protection Host. System backups are used for doing bare metal recovery later. This field is applicable only for System backups.</value>
        [DataMember(Name="enableSystemBackup", EmitDefaultValue=true)]
        public bool? EnableSystemBackup { get; set; }

        /// <summary>
        /// Array of File Paths to Back Up.  Specifies a list of directories or files to protect in a Physical Server.
        /// </summary>
        /// <value>Array of File Paths to Back Up.  Specifies a list of directories or files to protect in a Physical Server.</value>
        [DataMember(Name="filePaths", EmitDefaultValue=true)]
        public List<FilePathParameters> FilePaths { get; set; }

        /// <summary>
        /// Specifies metadata path on source. This file contains absolute paths of files that needs to be backed up on the same source.
        /// </summary>
        /// <value>Specifies metadata path on source. This file contains absolute paths of files that needs to be backed up on the same source.</value>
        [DataMember(Name="metadataFilePath", EmitDefaultValue=true)]
        public string MetadataFilePath { get; set; }

        /// <summary>
        /// Specifies mounttypes of nested volumes to be skipped.
        /// </summary>
        /// <value>Specifies mounttypes of nested volumes to be skipped.</value>
        [DataMember(Name="skipNestedVolumesVec", EmitDefaultValue=true)]
        public List<string> SkipNestedVolumesVec { get; set; }

        /// <summary>
        /// Specifies whether to use SkipNestedVolumes vec to skip nested mounts.
        /// </summary>
        /// <value>Specifies whether to use SkipNestedVolumes vec to skip nested mounts.</value>
        [DataMember(Name="usesSkipNestedVolumesVec", EmitDefaultValue=true)]
        public bool? UsesSkipNestedVolumesVec { get; set; }

        /// <summary>
        /// Array of Mounted Volumes to Back Up.  Specifies the subset of mounted volumes to protect in a Physical Server. If not specified, all mounted volumes on a Physical Server are protected.
        /// </summary>
        /// <value>Array of Mounted Volumes to Back Up.  Specifies the subset of mounted volumes to protect in a Physical Server. If not specified, all mounted volumes on a Physical Server are protected.</value>
        [DataMember(Name="volumeGuid", EmitDefaultValue=true)]
        public List<string> VolumeGuid { get; set; }

        /// <summary>
        /// Gets or Sets WindowsParameters
        /// </summary>
        [DataMember(Name="windowsParameters", EmitDefaultValue=false)]
        public WindowsHostSnapshotParameters WindowsParameters { get; set; }

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
            return this.Equals(input as PhysicalSpecialParameters);
        }

        /// <summary>
        /// Returns true if PhysicalSpecialParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PhysicalSpecialParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhysicalSpecialParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicationParameters == input.ApplicationParameters ||
                    (this.ApplicationParameters != null &&
                    this.ApplicationParameters.Equals(input.ApplicationParameters))
                ) && 
                (
                    this.EnableSystemBackup == input.EnableSystemBackup ||
                    (this.EnableSystemBackup != null &&
                    this.EnableSystemBackup.Equals(input.EnableSystemBackup))
                ) && 
                (
                    this.FilePaths == input.FilePaths ||
                    this.FilePaths != null &&
                    input.FilePaths != null &&
                    this.FilePaths.Equals(input.FilePaths)
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
                    this.UsesSkipNestedVolumesVec == input.UsesSkipNestedVolumesVec ||
                    (this.UsesSkipNestedVolumesVec != null &&
                    this.UsesSkipNestedVolumesVec.Equals(input.UsesSkipNestedVolumesVec))
                ) && 
                (
                    this.VolumeGuid == input.VolumeGuid ||
                    this.VolumeGuid != null &&
                    input.VolumeGuid != null &&
                    this.VolumeGuid.Equals(input.VolumeGuid)
                ) && 
                (
                    this.WindowsParameters == input.WindowsParameters ||
                    (this.WindowsParameters != null &&
                    this.WindowsParameters.Equals(input.WindowsParameters))
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
                if (this.ApplicationParameters != null)
                    hashCode = hashCode * 59 + this.ApplicationParameters.GetHashCode();
                if (this.EnableSystemBackup != null)
                    hashCode = hashCode * 59 + this.EnableSystemBackup.GetHashCode();
                if (this.FilePaths != null)
                    hashCode = hashCode * 59 + this.FilePaths.GetHashCode();
                if (this.MetadataFilePath != null)
                    hashCode = hashCode * 59 + this.MetadataFilePath.GetHashCode();
                if (this.SkipNestedVolumesVec != null)
                    hashCode = hashCode * 59 + this.SkipNestedVolumesVec.GetHashCode();
                if (this.UsesSkipNestedVolumesVec != null)
                    hashCode = hashCode * 59 + this.UsesSkipNestedVolumesVec.GetHashCode();
                if (this.VolumeGuid != null)
                    hashCode = hashCode * 59 + this.VolumeGuid.GetHashCode();
                if (this.WindowsParameters != null)
                    hashCode = hashCode * 59 + this.WindowsParameters.GetHashCode();
                return hashCode;
            }
        }

    }

}


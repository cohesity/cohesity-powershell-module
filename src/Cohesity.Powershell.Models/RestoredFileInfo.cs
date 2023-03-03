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
    /// RestoredFileInfo
    /// </summary>
    [DataContract]
    public partial class RestoredFileInfo :  IEquatable<RestoredFileInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoredFileInfo" /> class.
        /// </summary>
        /// <param name="absolutePath">Full path of the file being restored: the actual file path without the disk. E.g.: \\Program Files\\App\\file.txt.</param>
        /// <param name="attachedDiskId">Disk information of where the source file is currently located..</param>
        /// <param name="diskPartitionId">Disk partition to which the file belongs to..</param>
        /// <param name="fsUuid">File system UUID on which file resides..</param>
        /// <param name="inodeNumber">Inode number of the file. This is needed for snapmirror restore workflow..</param>
        /// <param name="isDirectory">Whether the path points to a directory..</param>
        /// <param name="isNonSimpleLdmVol">This will be set to true for recovery workflows for non-simple volumes on Windows Dynamic Disks. In that case, we will use VolumeInfo instead of some of the details captured here (e.g. virtual_disk_file) for determining disk and volume related details..</param>
        /// <param name="restoreBaseDirectory">This must be set to a directory path if restore_to_original_paths is false and restore task has multiple files which are not desired to be restore to one common location. If this filed is populated, &#39;absolute_path&#39; will be restored under this location. If this field is not populated all files in restore task will be restored to location specified in RestoreFilesPreferences..</param>
        /// <param name="restoreMountPoint">Mount point of the volume on which the file to be restored is located. E.g.: c:\\temp\\vhd_mount_1234.</param>
        /// <param name="sizeBytes">Size of the file in bytes. Required in FLR in GCP using Cloud Functions..</param>
        /// <param name="virtualDiskFile">Virtual disk file to which this file belongs to..</param>
        /// <param name="volumeId">Id of the volume..</param>
        /// <param name="volumePath">Original volume name (or drive letter). This is used while performing the copy to the original paths. E.g.: c:.</param>
        public RestoredFileInfo(string absolutePath = default(string), int? attachedDiskId = default(int?), int? diskPartitionId = default(int?), string fsUuid = default(string), long? inodeNumber = default(long?), bool? isDirectory = default(bool?), bool? isNonSimpleLdmVol = default(bool?), string restoreBaseDirectory = default(string), string restoreMountPoint = default(string), long? sizeBytes = default(long?), string virtualDiskFile = default(string), string volumeId = default(string), string volumePath = default(string))
        {
            this.AbsolutePath = absolutePath;
            this.AttachedDiskId = attachedDiskId;
            this.DiskPartitionId = diskPartitionId;
            this.FsUuid = fsUuid;
            this.InodeNumber = inodeNumber;
            this.IsDirectory = isDirectory;
            this.IsNonSimpleLdmVol = isNonSimpleLdmVol;
            this.RestoreBaseDirectory = restoreBaseDirectory;
            this.RestoreMountPoint = restoreMountPoint;
            this.SizeBytes = sizeBytes;
            this.VirtualDiskFile = virtualDiskFile;
            this.VolumeId = volumeId;
            this.VolumePath = volumePath;
            this.AbsolutePath = absolutePath;
            this.AttachedDiskId = attachedDiskId;
            this.DiskPartitionId = diskPartitionId;
            this.FsUuid = fsUuid;
            this.InodeNumber = inodeNumber;
            this.IsDirectory = isDirectory;
            this.IsNonSimpleLdmVol = isNonSimpleLdmVol;
            this.RestoreBaseDirectory = restoreBaseDirectory;
            this.RestoreMountPoint = restoreMountPoint;
            this.SizeBytes = sizeBytes;
            this.VirtualDiskFile = virtualDiskFile;
            this.VolumeId = volumeId;
            this.VolumePath = volumePath;
        }
        
        /// <summary>
        /// Full path of the file being restored: the actual file path without the disk. E.g.: \\Program Files\\App\\file.txt
        /// </summary>
        /// <value>Full path of the file being restored: the actual file path without the disk. E.g.: \\Program Files\\App\\file.txt</value>
        [DataMember(Name="absolutePath", EmitDefaultValue=true)]
        public string AbsolutePath { get; set; }

        /// <summary>
        /// Disk information of where the source file is currently located.
        /// </summary>
        /// <value>Disk information of where the source file is currently located.</value>
        [DataMember(Name="attachedDiskId", EmitDefaultValue=true)]
        public int? AttachedDiskId { get; set; }

        /// <summary>
        /// Disk partition to which the file belongs to.
        /// </summary>
        /// <value>Disk partition to which the file belongs to.</value>
        [DataMember(Name="diskPartitionId", EmitDefaultValue=true)]
        public int? DiskPartitionId { get; set; }

        /// <summary>
        /// File system UUID on which file resides.
        /// </summary>
        /// <value>File system UUID on which file resides.</value>
        [DataMember(Name="fsUuid", EmitDefaultValue=true)]
        public string FsUuid { get; set; }

        /// <summary>
        /// Inode number of the file. This is needed for snapmirror restore workflow.
        /// </summary>
        /// <value>Inode number of the file. This is needed for snapmirror restore workflow.</value>
        [DataMember(Name="inodeNumber", EmitDefaultValue=true)]
        public long? InodeNumber { get; set; }

        /// <summary>
        /// Whether the path points to a directory.
        /// </summary>
        /// <value>Whether the path points to a directory.</value>
        [DataMember(Name="isDirectory", EmitDefaultValue=true)]
        public bool? IsDirectory { get; set; }

        /// <summary>
        /// This will be set to true for recovery workflows for non-simple volumes on Windows Dynamic Disks. In that case, we will use VolumeInfo instead of some of the details captured here (e.g. virtual_disk_file) for determining disk and volume related details.
        /// </summary>
        /// <value>This will be set to true for recovery workflows for non-simple volumes on Windows Dynamic Disks. In that case, we will use VolumeInfo instead of some of the details captured here (e.g. virtual_disk_file) for determining disk and volume related details.</value>
        [DataMember(Name="isNonSimpleLdmVol", EmitDefaultValue=true)]
        public bool? IsNonSimpleLdmVol { get; set; }

        /// <summary>
        /// This must be set to a directory path if restore_to_original_paths is false and restore task has multiple files which are not desired to be restore to one common location. If this filed is populated, &#39;absolute_path&#39; will be restored under this location. If this field is not populated all files in restore task will be restored to location specified in RestoreFilesPreferences.
        /// </summary>
        /// <value>This must be set to a directory path if restore_to_original_paths is false and restore task has multiple files which are not desired to be restore to one common location. If this filed is populated, &#39;absolute_path&#39; will be restored under this location. If this field is not populated all files in restore task will be restored to location specified in RestoreFilesPreferences.</value>
        [DataMember(Name="restoreBaseDirectory", EmitDefaultValue=true)]
        public string RestoreBaseDirectory { get; set; }

        /// <summary>
        /// Mount point of the volume on which the file to be restored is located. E.g.: c:\\temp\\vhd_mount_1234
        /// </summary>
        /// <value>Mount point of the volume on which the file to be restored is located. E.g.: c:\\temp\\vhd_mount_1234</value>
        [DataMember(Name="restoreMountPoint", EmitDefaultValue=true)]
        public string RestoreMountPoint { get; set; }

        /// <summary>
        /// Size of the file in bytes. Required in FLR in GCP using Cloud Functions.
        /// </summary>
        /// <value>Size of the file in bytes. Required in FLR in GCP using Cloud Functions.</value>
        [DataMember(Name="sizeBytes", EmitDefaultValue=true)]
        public long? SizeBytes { get; set; }

        /// <summary>
        /// Virtual disk file to which this file belongs to.
        /// </summary>
        /// <value>Virtual disk file to which this file belongs to.</value>
        [DataMember(Name="virtualDiskFile", EmitDefaultValue=true)]
        public string VirtualDiskFile { get; set; }

        /// <summary>
        /// Id of the volume.
        /// </summary>
        /// <value>Id of the volume.</value>
        [DataMember(Name="volumeId", EmitDefaultValue=true)]
        public string VolumeId { get; set; }

        /// <summary>
        /// Original volume name (or drive letter). This is used while performing the copy to the original paths. E.g.: c:
        /// </summary>
        /// <value>Original volume name (or drive letter). This is used while performing the copy to the original paths. E.g.: c:</value>
        [DataMember(Name="volumePath", EmitDefaultValue=true)]
        public string VolumePath { get; set; }

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
            return this.Equals(input as RestoredFileInfo);
        }

        /// <summary>
        /// Returns true if RestoredFileInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoredFileInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoredFileInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AbsolutePath == input.AbsolutePath ||
                    (this.AbsolutePath != null &&
                    this.AbsolutePath.Equals(input.AbsolutePath))
                ) && 
                (
                    this.AttachedDiskId == input.AttachedDiskId ||
                    (this.AttachedDiskId != null &&
                    this.AttachedDiskId.Equals(input.AttachedDiskId))
                ) && 
                (
                    this.DiskPartitionId == input.DiskPartitionId ||
                    (this.DiskPartitionId != null &&
                    this.DiskPartitionId.Equals(input.DiskPartitionId))
                ) && 
                (
                    this.FsUuid == input.FsUuid ||
                    (this.FsUuid != null &&
                    this.FsUuid.Equals(input.FsUuid))
                ) && 
                (
                    this.InodeNumber == input.InodeNumber ||
                    (this.InodeNumber != null &&
                    this.InodeNumber.Equals(input.InodeNumber))
                ) && 
                (
                    this.IsDirectory == input.IsDirectory ||
                    (this.IsDirectory != null &&
                    this.IsDirectory.Equals(input.IsDirectory))
                ) && 
                (
                    this.IsNonSimpleLdmVol == input.IsNonSimpleLdmVol ||
                    (this.IsNonSimpleLdmVol != null &&
                    this.IsNonSimpleLdmVol.Equals(input.IsNonSimpleLdmVol))
                ) && 
                (
                    this.RestoreBaseDirectory == input.RestoreBaseDirectory ||
                    (this.RestoreBaseDirectory != null &&
                    this.RestoreBaseDirectory.Equals(input.RestoreBaseDirectory))
                ) && 
                (
                    this.RestoreMountPoint == input.RestoreMountPoint ||
                    (this.RestoreMountPoint != null &&
                    this.RestoreMountPoint.Equals(input.RestoreMountPoint))
                ) && 
                (
                    this.SizeBytes == input.SizeBytes ||
                    (this.SizeBytes != null &&
                    this.SizeBytes.Equals(input.SizeBytes))
                ) && 
                (
                    this.VirtualDiskFile == input.VirtualDiskFile ||
                    (this.VirtualDiskFile != null &&
                    this.VirtualDiskFile.Equals(input.VirtualDiskFile))
                ) && 
                (
                    this.VolumeId == input.VolumeId ||
                    (this.VolumeId != null &&
                    this.VolumeId.Equals(input.VolumeId))
                ) && 
                (
                    this.VolumePath == input.VolumePath ||
                    (this.VolumePath != null &&
                    this.VolumePath.Equals(input.VolumePath))
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
                if (this.AbsolutePath != null)
                    hashCode = hashCode * 59 + this.AbsolutePath.GetHashCode();
                if (this.AttachedDiskId != null)
                    hashCode = hashCode * 59 + this.AttachedDiskId.GetHashCode();
                if (this.DiskPartitionId != null)
                    hashCode = hashCode * 59 + this.DiskPartitionId.GetHashCode();
                if (this.FsUuid != null)
                    hashCode = hashCode * 59 + this.FsUuid.GetHashCode();
                if (this.InodeNumber != null)
                    hashCode = hashCode * 59 + this.InodeNumber.GetHashCode();
                if (this.IsDirectory != null)
                    hashCode = hashCode * 59 + this.IsDirectory.GetHashCode();
                if (this.IsNonSimpleLdmVol != null)
                    hashCode = hashCode * 59 + this.IsNonSimpleLdmVol.GetHashCode();
                if (this.RestoreBaseDirectory != null)
                    hashCode = hashCode * 59 + this.RestoreBaseDirectory.GetHashCode();
                if (this.RestoreMountPoint != null)
                    hashCode = hashCode * 59 + this.RestoreMountPoint.GetHashCode();
                if (this.SizeBytes != null)
                    hashCode = hashCode * 59 + this.SizeBytes.GetHashCode();
                if (this.VirtualDiskFile != null)
                    hashCode = hashCode * 59 + this.VirtualDiskFile.GetHashCode();
                if (this.VolumeId != null)
                    hashCode = hashCode * 59 + this.VolumeId.GetHashCode();
                if (this.VolumePath != null)
                    hashCode = hashCode * 59 + this.VolumePath.GetHashCode();
                return hashCode;
            }
        }

    }

}


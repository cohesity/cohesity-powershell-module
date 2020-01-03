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
    /// VolumeInfo
    /// </summary>
    [DataContract]
    public partial class VolumeInfo :  IEquatable<VolumeInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeInfo" /> class.
        /// </summary>
        /// <param name="diskVec">Information about all the disks and partitions needed to mount this logical volume..</param>
        /// <param name="displayName">Display name..</param>
        /// <param name="filesystemType">Filesystem on this volume..</param>
        /// <param name="fsLabel">Filesystem label..</param>
        /// <param name="fsUuid">Filesystem uuid..</param>
        /// <param name="isBootable">Is this volume bootable?.</param>
        /// <param name="isDedup">Is this a dedup volume? Currently, set to true only for ntfs dedup volume..</param>
        /// <param name="isSupported">Is this a supported Volume (filesystem)?.</param>
        /// <param name="lvInfo">lvInfo.</param>
        /// <param name="volumeGuid">The guid of the volume represented by this virtual disk. This information will be originally populated by magneto for physical environments..</param>
        /// <param name="volumeType">Whether this volume is simple, lvm or ldm..</param>
        public VolumeInfo(List<VolumeInfoDiskInfo> diskVec = default(List<VolumeInfoDiskInfo>), string displayName = default(string), string filesystemType = default(string), string fsLabel = default(string), string fsUuid = default(string), bool? isBootable = default(bool?), bool? isDedup = default(bool?), bool? isSupported = default(bool?), VolumeInfoLogicalVolumeInfo lvInfo = default(VolumeInfoLogicalVolumeInfo), string volumeGuid = default(string), int? volumeType = default(int?))
        {
            this.DiskVec = diskVec;
            this.DisplayName = displayName;
            this.FilesystemType = filesystemType;
            this.FsLabel = fsLabel;
            this.FsUuid = fsUuid;
            this.IsBootable = isBootable;
            this.IsDedup = isDedup;
            this.IsSupported = isSupported;
            this.VolumeGuid = volumeGuid;
            this.VolumeType = volumeType;
            this.DiskVec = diskVec;
            this.DisplayName = displayName;
            this.FilesystemType = filesystemType;
            this.FsLabel = fsLabel;
            this.FsUuid = fsUuid;
            this.IsBootable = isBootable;
            this.IsDedup = isDedup;
            this.IsSupported = isSupported;
            this.LvInfo = lvInfo;
            this.VolumeGuid = volumeGuid;
            this.VolumeType = volumeType;
        }
        
        /// <summary>
        /// Information about all the disks and partitions needed to mount this logical volume.
        /// </summary>
        /// <value>Information about all the disks and partitions needed to mount this logical volume.</value>
        [DataMember(Name="diskVec", EmitDefaultValue=true)]
        public List<VolumeInfoDiskInfo> DiskVec { get; set; }

        /// <summary>
        /// Display name.
        /// </summary>
        /// <value>Display name.</value>
        [DataMember(Name="displayName", EmitDefaultValue=true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Filesystem on this volume.
        /// </summary>
        /// <value>Filesystem on this volume.</value>
        [DataMember(Name="filesystemType", EmitDefaultValue=true)]
        public string FilesystemType { get; set; }

        /// <summary>
        /// Filesystem label.
        /// </summary>
        /// <value>Filesystem label.</value>
        [DataMember(Name="fsLabel", EmitDefaultValue=true)]
        public string FsLabel { get; set; }

        /// <summary>
        /// Filesystem uuid.
        /// </summary>
        /// <value>Filesystem uuid.</value>
        [DataMember(Name="fsUuid", EmitDefaultValue=true)]
        public string FsUuid { get; set; }

        /// <summary>
        /// Is this volume bootable?
        /// </summary>
        /// <value>Is this volume bootable?</value>
        [DataMember(Name="isBootable", EmitDefaultValue=true)]
        public bool? IsBootable { get; set; }

        /// <summary>
        /// Is this a dedup volume? Currently, set to true only for ntfs dedup volume.
        /// </summary>
        /// <value>Is this a dedup volume? Currently, set to true only for ntfs dedup volume.</value>
        [DataMember(Name="isDedup", EmitDefaultValue=true)]
        public bool? IsDedup { get; set; }

        /// <summary>
        /// Is this a supported Volume (filesystem)?
        /// </summary>
        /// <value>Is this a supported Volume (filesystem)?</value>
        [DataMember(Name="isSupported", EmitDefaultValue=true)]
        public bool? IsSupported { get; set; }

        /// <summary>
        /// Gets or Sets LvInfo
        /// </summary>
        [DataMember(Name="lvInfo", EmitDefaultValue=false)]
        public VolumeInfoLogicalVolumeInfo LvInfo { get; set; }

        /// <summary>
        /// The guid of the volume represented by this virtual disk. This information will be originally populated by magneto for physical environments.
        /// </summary>
        /// <value>The guid of the volume represented by this virtual disk. This information will be originally populated by magneto for physical environments.</value>
        [DataMember(Name="volumeGuid", EmitDefaultValue=true)]
        public string VolumeGuid { get; set; }

        /// <summary>
        /// Whether this volume is simple, lvm or ldm.
        /// </summary>
        /// <value>Whether this volume is simple, lvm or ldm.</value>
        [DataMember(Name="volumeType", EmitDefaultValue=true)]
        public int? VolumeType { get; set; }

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
            return this.Equals(input as VolumeInfo);
        }

        /// <summary>
        /// Returns true if VolumeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VolumeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VolumeInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DiskVec == input.DiskVec ||
                    this.DiskVec != null &&
                    input.DiskVec != null &&
                    this.DiskVec.SequenceEqual(input.DiskVec)
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.FilesystemType == input.FilesystemType ||
                    (this.FilesystemType != null &&
                    this.FilesystemType.Equals(input.FilesystemType))
                ) && 
                (
                    this.FsLabel == input.FsLabel ||
                    (this.FsLabel != null &&
                    this.FsLabel.Equals(input.FsLabel))
                ) && 
                (
                    this.FsUuid == input.FsUuid ||
                    (this.FsUuid != null &&
                    this.FsUuid.Equals(input.FsUuid))
                ) && 
                (
                    this.IsBootable == input.IsBootable ||
                    (this.IsBootable != null &&
                    this.IsBootable.Equals(input.IsBootable))
                ) && 
                (
                    this.IsDedup == input.IsDedup ||
                    (this.IsDedup != null &&
                    this.IsDedup.Equals(input.IsDedup))
                ) && 
                (
                    this.IsSupported == input.IsSupported ||
                    (this.IsSupported != null &&
                    this.IsSupported.Equals(input.IsSupported))
                ) && 
                (
                    this.LvInfo == input.LvInfo ||
                    (this.LvInfo != null &&
                    this.LvInfo.Equals(input.LvInfo))
                ) && 
                (
                    this.VolumeGuid == input.VolumeGuid ||
                    (this.VolumeGuid != null &&
                    this.VolumeGuid.Equals(input.VolumeGuid))
                ) && 
                (
                    this.VolumeType == input.VolumeType ||
                    (this.VolumeType != null &&
                    this.VolumeType.Equals(input.VolumeType))
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
                if (this.DiskVec != null)
                    hashCode = hashCode * 59 + this.DiskVec.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.FilesystemType != null)
                    hashCode = hashCode * 59 + this.FilesystemType.GetHashCode();
                if (this.FsLabel != null)
                    hashCode = hashCode * 59 + this.FsLabel.GetHashCode();
                if (this.FsUuid != null)
                    hashCode = hashCode * 59 + this.FsUuid.GetHashCode();
                if (this.IsBootable != null)
                    hashCode = hashCode * 59 + this.IsBootable.GetHashCode();
                if (this.IsDedup != null)
                    hashCode = hashCode * 59 + this.IsDedup.GetHashCode();
                if (this.IsSupported != null)
                    hashCode = hashCode * 59 + this.IsSupported.GetHashCode();
                if (this.LvInfo != null)
                    hashCode = hashCode * 59 + this.LvInfo.GetHashCode();
                if (this.VolumeGuid != null)
                    hashCode = hashCode * 59 + this.VolumeGuid.GetHashCode();
                if (this.VolumeType != null)
                    hashCode = hashCode * 59 + this.VolumeType.GetHashCode();
                return hashCode;
            }
        }

    }

}


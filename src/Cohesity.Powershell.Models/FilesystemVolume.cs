// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// Specifies information about a filesystem volume.
    /// </summary>
    [DataContract]
    public partial class FilesystemVolume :  IEquatable<FilesystemVolume>
    {
        /// <summary>
        /// Specifies the type of logical volume such as kSimpleVolume, kLVM or kLDM. &#39;kSimpleVolume&#39; indicates a simple volume. Data can be used by just mounting the only one partition present on the disk. &#39;kLVM&#39; indicates a logical volume on Linux managed by a Logical Volume Manager. In order to access the data, deviceTree must be created based on the specification in logicalVolume.deviceTree. &#39;kLDM&#39; indicates a logical volume on Windows managed by Logical Disk Manager.
        /// </summary>
        /// <value>Specifies the type of logical volume such as kSimpleVolume, kLVM or kLDM. &#39;kSimpleVolume&#39; indicates a simple volume. Data can be used by just mounting the only one partition present on the disk. &#39;kLVM&#39; indicates a logical volume on Linux managed by a Logical Volume Manager. In order to access the data, deviceTree must be created based on the specification in logicalVolume.deviceTree. &#39;kLDM&#39; indicates a logical volume on Windows managed by Logical Disk Manager.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LogicalVolumeTypeEnum
        {
            
            /// <summary>
            /// Enum KSimpleVolume for value: kSimpleVolume
            /// </summary>
            [EnumMember(Value = "kSimpleVolume")]
            KSimpleVolume = 1,
            
            /// <summary>
            /// Enum KLVM for value: kLVM
            /// </summary>
            [EnumMember(Value = "kLVM")]
            KLVM = 2,
            
            /// <summary>
            /// Enum KLDM for value: kLDM
            /// </summary>
            [EnumMember(Value = "kLDM")]
            KLDM = 3
        }

        /// <summary>
        /// Specifies the type of logical volume such as kSimpleVolume, kLVM or kLDM. &#39;kSimpleVolume&#39; indicates a simple volume. Data can be used by just mounting the only one partition present on the disk. &#39;kLVM&#39; indicates a logical volume on Linux managed by a Logical Volume Manager. In order to access the data, deviceTree must be created based on the specification in logicalVolume.deviceTree. &#39;kLDM&#39; indicates a logical volume on Windows managed by Logical Disk Manager.
        /// </summary>
        /// <value>Specifies the type of logical volume such as kSimpleVolume, kLVM or kLDM. &#39;kSimpleVolume&#39; indicates a simple volume. Data can be used by just mounting the only one partition present on the disk. &#39;kLVM&#39; indicates a logical volume on Linux managed by a Logical Volume Manager. In order to access the data, deviceTree must be created based on the specification in logicalVolume.deviceTree. &#39;kLDM&#39; indicates a logical volume on Windows managed by Logical Disk Manager.</value>
        [DataMember(Name="logicalVolumeType", EmitDefaultValue=false)]
        public LogicalVolumeTypeEnum? LogicalVolumeType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FilesystemVolume" /> class.
        /// </summary>
        /// <param name="disks">Specifies information about all the disks and partitions needed to mount this logical volume..</param>
        /// <param name="displayName">Specifies a description about the filesystem..</param>
        /// <param name="filesystemType">Specifies type of the filesystem on this volume..</param>
        /// <param name="filesystemUuid">Specifies the uuid of the filesystem..</param>
        /// <param name="isSupported">If true, this is a supported filesystem volume type..</param>
        /// <param name="logicalVolume">logicalVolume.</param>
        /// <param name="logicalVolumeType">Specifies the type of logical volume such as kSimpleVolume, kLVM or kLDM. &#39;kSimpleVolume&#39; indicates a simple volume. Data can be used by just mounting the only one partition present on the disk. &#39;kLVM&#39; indicates a logical volume on Linux managed by a Logical Volume Manager. In order to access the data, deviceTree must be created based on the specification in logicalVolume.deviceTree. &#39;kLDM&#39; indicates a logical volume on Windows managed by Logical Disk Manager..</param>
        /// <param name="name">Specifies the name of the volume such as /C..</param>
        /// <param name="volumeGuid">VolumeGuid is the Volume guid. This is populated for kPhysical environments..</param>
        public FilesystemVolume(List<Disk> disks = default(List<Disk>), string displayName = default(string), string filesystemType = default(string), string filesystemUuid = default(string), bool? isSupported = default(bool?), LogicalVolume_ logicalVolume = default(LogicalVolume_), LogicalVolumeTypeEnum? logicalVolumeType = default(LogicalVolumeTypeEnum?), string name = default(string), string volumeGuid = default(string))
        {
            this.Disks = disks;
            this.DisplayName = displayName;
            this.FilesystemType = filesystemType;
            this.FilesystemUuid = filesystemUuid;
            this.IsSupported = isSupported;
            this.LogicalVolume = logicalVolume;
            this.LogicalVolumeType = logicalVolumeType;
            this.Name = name;
            this.VolumeGuid = volumeGuid;
        }
        
        /// <summary>
        /// Specifies information about all the disks and partitions needed to mount this logical volume.
        /// </summary>
        /// <value>Specifies information about all the disks and partitions needed to mount this logical volume.</value>
        [DataMember(Name="disks", EmitDefaultValue=false)]
        public List<Disk> Disks { get; set; }

        /// <summary>
        /// Specifies a description about the filesystem.
        /// </summary>
        /// <value>Specifies a description about the filesystem.</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Specifies type of the filesystem on this volume.
        /// </summary>
        /// <value>Specifies type of the filesystem on this volume.</value>
        [DataMember(Name="filesystemType", EmitDefaultValue=false)]
        public string FilesystemType { get; set; }

        /// <summary>
        /// Specifies the uuid of the filesystem.
        /// </summary>
        /// <value>Specifies the uuid of the filesystem.</value>
        [DataMember(Name="filesystemUuid", EmitDefaultValue=false)]
        public string FilesystemUuid { get; set; }

        /// <summary>
        /// If true, this is a supported filesystem volume type.
        /// </summary>
        /// <value>If true, this is a supported filesystem volume type.</value>
        [DataMember(Name="isSupported", EmitDefaultValue=false)]
        public bool? IsSupported { get; set; }

        /// <summary>
        /// Gets or Sets LogicalVolume
        /// </summary>
        [DataMember(Name="logicalVolume", EmitDefaultValue=false)]
        public LogicalVolume_ LogicalVolume { get; set; }


        /// <summary>
        /// Specifies the name of the volume such as /C.
        /// </summary>
        /// <value>Specifies the name of the volume such as /C.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// VolumeGuid is the Volume guid. This is populated for kPhysical environments.
        /// </summary>
        /// <value>VolumeGuid is the Volume guid. This is populated for kPhysical environments.</value>
        [DataMember(Name="volumeGuid", EmitDefaultValue=false)]
        public string VolumeGuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }
  
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
            return this.Equals(input as FilesystemVolume);
        }

        /// <summary>
        /// Returns true if FilesystemVolume instances are equal
        /// </summary>
        /// <param name="input">Instance of FilesystemVolume to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FilesystemVolume input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Disks == input.Disks ||
                    this.Disks != null &&
                    this.Disks.SequenceEqual(input.Disks)
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
                    this.FilesystemUuid == input.FilesystemUuid ||
                    (this.FilesystemUuid != null &&
                    this.FilesystemUuid.Equals(input.FilesystemUuid))
                ) && 
                (
                    this.IsSupported == input.IsSupported ||
                    (this.IsSupported != null &&
                    this.IsSupported.Equals(input.IsSupported))
                ) && 
                (
                    this.LogicalVolume == input.LogicalVolume ||
                    (this.LogicalVolume != null &&
                    this.LogicalVolume.Equals(input.LogicalVolume))
                ) && 
                (
                    this.LogicalVolumeType == input.LogicalVolumeType ||
                    (this.LogicalVolumeType != null &&
                    this.LogicalVolumeType.Equals(input.LogicalVolumeType))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.VolumeGuid == input.VolumeGuid ||
                    (this.VolumeGuid != null &&
                    this.VolumeGuid.Equals(input.VolumeGuid))
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
                if (this.Disks != null)
                    hashCode = hashCode * 59 + this.Disks.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.FilesystemType != null)
                    hashCode = hashCode * 59 + this.FilesystemType.GetHashCode();
                if (this.FilesystemUuid != null)
                    hashCode = hashCode * 59 + this.FilesystemUuid.GetHashCode();
                if (this.IsSupported != null)
                    hashCode = hashCode * 59 + this.IsSupported.GetHashCode();
                if (this.LogicalVolume != null)
                    hashCode = hashCode * 59 + this.LogicalVolume.GetHashCode();
                if (this.LogicalVolumeType != null)
                    hashCode = hashCode * 59 + this.LogicalVolumeType.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.VolumeGuid != null)
                    hashCode = hashCode * 59 + this.VolumeGuid.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


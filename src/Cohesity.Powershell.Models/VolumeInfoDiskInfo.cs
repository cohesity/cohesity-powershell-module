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
    /// VolumeInfoDiskInfo
    /// </summary>
    [DataContract]
    public partial class VolumeInfoDiskInfo :  IEquatable<VolumeInfoDiskInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeInfoDiskInfo" /> class.
        /// </summary>
        /// <param name="diskFileName">Disk name. This is the vmdk names, and not the flat file name..</param>
        /// <param name="diskFormat">Disk format type of this file. See util/disklib/base/enums.proto for available types..</param>
        /// <param name="diskUuid">Disk uuid..</param>
        /// <param name="partitionType">Disk partition type..</param>
        /// <param name="partitionVec">Information about all the partitions in this disk..</param>
        /// <param name="physicalRangeVec">This disk is formed by following physical ranges. Ranges are arranged sequentially to form a disk..</param>
        /// <param name="sectorSize">Sector size of disk. This is sector size of disk which is formed by mapping the physical ranges of the disk into a linear device..</param>
        /// <param name="vmdkSize">Disk size in bytes..</param>
        public VolumeInfoDiskInfo(string diskFileName = default(string), int? diskFormat = default(int?), string diskUuid = default(string), int? partitionType = default(int?), List<VolumeInfoDiskInfoPartitionInfo> partitionVec = default(List<VolumeInfoDiskInfoPartitionInfo>), List<VolumeInfoDiskInfoPhysicalRange> physicalRangeVec = default(List<VolumeInfoDiskInfoPhysicalRange>), long? sectorSize = default(long?), long? vmdkSize = default(long?))
        {
            this.DiskFileName = diskFileName;
            this.DiskFormat = diskFormat;
            this.DiskUuid = diskUuid;
            this.PartitionType = partitionType;
            this.PartitionVec = partitionVec;
            this.PhysicalRangeVec = physicalRangeVec;
            this.SectorSize = sectorSize;
            this.VmdkSize = vmdkSize;
            this.DiskFileName = diskFileName;
            this.DiskFormat = diskFormat;
            this.DiskUuid = diskUuid;
            this.PartitionType = partitionType;
            this.PartitionVec = partitionVec;
            this.PhysicalRangeVec = physicalRangeVec;
            this.SectorSize = sectorSize;
            this.VmdkSize = vmdkSize;
        }
        
        /// <summary>
        /// Disk name. This is the vmdk names, and not the flat file name.
        /// </summary>
        /// <value>Disk name. This is the vmdk names, and not the flat file name.</value>
        [DataMember(Name="diskFileName", EmitDefaultValue=true)]
        public string DiskFileName { get; set; }

        /// <summary>
        /// Disk format type of this file. See util/disklib/base/enums.proto for available types.
        /// </summary>
        /// <value>Disk format type of this file. See util/disklib/base/enums.proto for available types.</value>
        [DataMember(Name="diskFormat", EmitDefaultValue=true)]
        public int? DiskFormat { get; set; }

        /// <summary>
        /// Disk uuid.
        /// </summary>
        /// <value>Disk uuid.</value>
        [DataMember(Name="diskUuid", EmitDefaultValue=true)]
        public string DiskUuid { get; set; }

        /// <summary>
        /// Disk partition type.
        /// </summary>
        /// <value>Disk partition type.</value>
        [DataMember(Name="partitionType", EmitDefaultValue=true)]
        public int? PartitionType { get; set; }

        /// <summary>
        /// Information about all the partitions in this disk.
        /// </summary>
        /// <value>Information about all the partitions in this disk.</value>
        [DataMember(Name="partitionVec", EmitDefaultValue=true)]
        public List<VolumeInfoDiskInfoPartitionInfo> PartitionVec { get; set; }

        /// <summary>
        /// This disk is formed by following physical ranges. Ranges are arranged sequentially to form a disk.
        /// </summary>
        /// <value>This disk is formed by following physical ranges. Ranges are arranged sequentially to form a disk.</value>
        [DataMember(Name="physicalRangeVec", EmitDefaultValue=true)]
        public List<VolumeInfoDiskInfoPhysicalRange> PhysicalRangeVec { get; set; }

        /// <summary>
        /// Sector size of disk. This is sector size of disk which is formed by mapping the physical ranges of the disk into a linear device.
        /// </summary>
        /// <value>Sector size of disk. This is sector size of disk which is formed by mapping the physical ranges of the disk into a linear device.</value>
        [DataMember(Name="sectorSize", EmitDefaultValue=true)]
        public long? SectorSize { get; set; }

        /// <summary>
        /// Disk size in bytes.
        /// </summary>
        /// <value>Disk size in bytes.</value>
        [DataMember(Name="vmdkSize", EmitDefaultValue=true)]
        public long? VmdkSize { get; set; }

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
            return this.Equals(input as VolumeInfoDiskInfo);
        }

        /// <summary>
        /// Returns true if VolumeInfoDiskInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VolumeInfoDiskInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VolumeInfoDiskInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DiskFileName == input.DiskFileName ||
                    (this.DiskFileName != null &&
                    this.DiskFileName.Equals(input.DiskFileName))
                ) && 
                (
                    this.DiskFormat == input.DiskFormat ||
                    (this.DiskFormat != null &&
                    this.DiskFormat.Equals(input.DiskFormat))
                ) && 
                (
                    this.DiskUuid == input.DiskUuid ||
                    (this.DiskUuid != null &&
                    this.DiskUuid.Equals(input.DiskUuid))
                ) && 
                (
                    this.PartitionType == input.PartitionType ||
                    (this.PartitionType != null &&
                    this.PartitionType.Equals(input.PartitionType))
                ) && 
                (
                    this.PartitionVec == input.PartitionVec ||
                    this.PartitionVec != null &&
                    input.PartitionVec != null &&
                    this.PartitionVec.SequenceEqual(input.PartitionVec)
                ) && 
                (
                    this.PhysicalRangeVec == input.PhysicalRangeVec ||
                    this.PhysicalRangeVec != null &&
                    input.PhysicalRangeVec != null &&
                    this.PhysicalRangeVec.SequenceEqual(input.PhysicalRangeVec)
                ) && 
                (
                    this.SectorSize == input.SectorSize ||
                    (this.SectorSize != null &&
                    this.SectorSize.Equals(input.SectorSize))
                ) && 
                (
                    this.VmdkSize == input.VmdkSize ||
                    (this.VmdkSize != null &&
                    this.VmdkSize.Equals(input.VmdkSize))
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
                if (this.DiskFileName != null)
                    hashCode = hashCode * 59 + this.DiskFileName.GetHashCode();
                if (this.DiskFormat != null)
                    hashCode = hashCode * 59 + this.DiskFormat.GetHashCode();
                if (this.DiskUuid != null)
                    hashCode = hashCode * 59 + this.DiskUuid.GetHashCode();
                if (this.PartitionType != null)
                    hashCode = hashCode * 59 + this.PartitionType.GetHashCode();
                if (this.PartitionVec != null)
                    hashCode = hashCode * 59 + this.PartitionVec.GetHashCode();
                if (this.PhysicalRangeVec != null)
                    hashCode = hashCode * 59 + this.PhysicalRangeVec.GetHashCode();
                if (this.SectorSize != null)
                    hashCode = hashCode * 59 + this.SectorSize.GetHashCode();
                if (this.VmdkSize != null)
                    hashCode = hashCode * 59 + this.VmdkSize.GetHashCode();
                return hashCode;
            }
        }

    }

}


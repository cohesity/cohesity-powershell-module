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
    /// Specifies information about a disk and partitions in a volume.
    /// </summary>
    [DataContract]
    public partial class Disk :  IEquatable<Disk>
    {
        /// <summary>
        /// Specifies the format of the virtual disk. &#39;kVMDK&#39; indicates VMware&#39;s Virtual Disk format. &#39;kVHD&#39; indicates Microsoft&#39;s Virtual Hard Drive format. &#39;kVHDx&#39; indicates Microsoft&#39;s Hyper-V Virtual Hard Drive format.
        /// </summary>
        /// <value>Specifies the format of the virtual disk. &#39;kVMDK&#39; indicates VMware&#39;s Virtual Disk format. &#39;kVHD&#39; indicates Microsoft&#39;s Virtual Hard Drive format. &#39;kVHDx&#39; indicates Microsoft&#39;s Hyper-V Virtual Hard Drive format.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DiskFormatEnum
        {
            
            /// <summary>
            /// Enum KVMDK for value: kVMDK
            /// </summary>
            [EnumMember(Value = "kVMDK")]
            KVMDK = 1,
            
            /// <summary>
            /// Enum KVHD for value: kVHD
            /// </summary>
            [EnumMember(Value = "kVHD")]
            KVHD = 2,
            
            /// <summary>
            /// Enum KVHDx for value: kVHDx
            /// </summary>
            [EnumMember(Value = "kVHDx")]
            KVHDx = 3
        }

        /// <summary>
        /// Specifies the format of the virtual disk. &#39;kVMDK&#39; indicates VMware&#39;s Virtual Disk format. &#39;kVHD&#39; indicates Microsoft&#39;s Virtual Hard Drive format. &#39;kVHDx&#39; indicates Microsoft&#39;s Hyper-V Virtual Hard Drive format.
        /// </summary>
        /// <value>Specifies the format of the virtual disk. &#39;kVMDK&#39; indicates VMware&#39;s Virtual Disk format. &#39;kVHD&#39; indicates Microsoft&#39;s Virtual Hard Drive format. &#39;kVHDx&#39; indicates Microsoft&#39;s Hyper-V Virtual Hard Drive format.</value>
        [DataMember(Name="diskFormat", EmitDefaultValue=false)]
        public DiskFormatEnum? DiskFormat { get; set; }
        /// <summary>
        /// Specifies partition table format on a disk. &#39;kNoPartition&#39; indicates missing partition table. &#39;kMBRPartition&#39; indicates partition table is in Master Boot Record format. &#39;kGPTPartition&#39; indicates partition table is in Guid Partition Table format. &#39;kSGIPartition&#39; indicates partition table uses SGI scheme. &#39;kSUNPartition&#39; indicates partition table uses SUN scheme.
        /// </summary>
        /// <value>Specifies partition table format on a disk. &#39;kNoPartition&#39; indicates missing partition table. &#39;kMBRPartition&#39; indicates partition table is in Master Boot Record format. &#39;kGPTPartition&#39; indicates partition table is in Guid Partition Table format. &#39;kSGIPartition&#39; indicates partition table uses SGI scheme. &#39;kSUNPartition&#39; indicates partition table uses SUN scheme.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PartitionTableFormatEnum
        {
            
            /// <summary>
            /// Enum KNoPartition for value: kNoPartition
            /// </summary>
            [EnumMember(Value = "kNoPartition")]
            KNoPartition = 1,
            
            /// <summary>
            /// Enum KMBRPartition for value: kMBRPartition
            /// </summary>
            [EnumMember(Value = "kMBRPartition")]
            KMBRPartition = 2,
            
            /// <summary>
            /// Enum KGPTPartition for value: kGPTPartition
            /// </summary>
            [EnumMember(Value = "kGPTPartition")]
            KGPTPartition = 3,
            
            /// <summary>
            /// Enum KSGIPartition for value: kSGIPartition
            /// </summary>
            [EnumMember(Value = "kSGIPartition")]
            KSGIPartition = 4,
            
            /// <summary>
            /// Enum KSUNPartition for value: kSUNPartition
            /// </summary>
            [EnumMember(Value = "kSUNPartition")]
            KSUNPartition = 5
        }

        /// <summary>
        /// Specifies partition table format on a disk. &#39;kNoPartition&#39; indicates missing partition table. &#39;kMBRPartition&#39; indicates partition table is in Master Boot Record format. &#39;kGPTPartition&#39; indicates partition table is in Guid Partition Table format. &#39;kSGIPartition&#39; indicates partition table uses SGI scheme. &#39;kSUNPartition&#39; indicates partition table uses SUN scheme.
        /// </summary>
        /// <value>Specifies partition table format on a disk. &#39;kNoPartition&#39; indicates missing partition table. &#39;kMBRPartition&#39; indicates partition table is in Master Boot Record format. &#39;kGPTPartition&#39; indicates partition table is in Guid Partition Table format. &#39;kSGIPartition&#39; indicates partition table uses SGI scheme. &#39;kSUNPartition&#39; indicates partition table uses SUN scheme.</value>
        [DataMember(Name="partitionTableFormat", EmitDefaultValue=false)]
        public PartitionTableFormatEnum? PartitionTableFormat { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Disk" /> class.
        /// </summary>
        /// <param name="diskBlocks">Specifies a set of disk blocks by defining the location and offset of disk blocks in a disk..</param>
        /// <param name="diskFormat">Specifies the format of the virtual disk. &#39;kVMDK&#39; indicates VMware&#39;s Virtual Disk format. &#39;kVHD&#39; indicates Microsoft&#39;s Virtual Hard Drive format. &#39;kVHDx&#39; indicates Microsoft&#39;s Hyper-V Virtual Hard Drive format..</param>
        /// <param name="diskPartitions">Specifies information about all the partitions in this disk..</param>
        /// <param name="partitionTableFormat">Specifies partition table format on a disk. &#39;kNoPartition&#39; indicates missing partition table. &#39;kMBRPartition&#39; indicates partition table is in Master Boot Record format. &#39;kGPTPartition&#39; indicates partition table is in Guid Partition Table format. &#39;kSGIPartition&#39; indicates partition table uses SGI scheme. &#39;kSUNPartition&#39; indicates partition table uses SUN scheme..</param>
        /// <param name="sectorSizeBytes">Specifies the sector size of hard disk. It is used for mapping the disk blocks of the disk file into a linear list of sectors..</param>
        /// <param name="uuid">Specifies the disk uuid..</param>
        /// <param name="vmdkFileName">Specifies the disk file name. This is the VMDK name and not the flat file name..</param>
        /// <param name="vmdkSizeBytes">Specifies the disk size in bytes..</param>
        public Disk(List<DiskBlock> diskBlocks = default(List<DiskBlock>), DiskFormatEnum? diskFormat = default(DiskFormatEnum?), List<DiskPartition> diskPartitions = default(List<DiskPartition>), PartitionTableFormatEnum? partitionTableFormat = default(PartitionTableFormatEnum?), long? sectorSizeBytes = default(long?), string uuid = default(string), string vmdkFileName = default(string), long? vmdkSizeBytes = default(long?))
        {
            this.DiskBlocks = diskBlocks;
            this.DiskFormat = diskFormat;
            this.DiskPartitions = diskPartitions;
            this.PartitionTableFormat = partitionTableFormat;
            this.SectorSizeBytes = sectorSizeBytes;
            this.Uuid = uuid;
            this.VmdkFileName = vmdkFileName;
            this.VmdkSizeBytes = vmdkSizeBytes;
        }
        
        /// <summary>
        /// Specifies a set of disk blocks by defining the location and offset of disk blocks in a disk.
        /// </summary>
        /// <value>Specifies a set of disk blocks by defining the location and offset of disk blocks in a disk.</value>
        [DataMember(Name="diskBlocks", EmitDefaultValue=false)]
        public List<DiskBlock> DiskBlocks { get; set; }


        /// <summary>
        /// Specifies information about all the partitions in this disk.
        /// </summary>
        /// <value>Specifies information about all the partitions in this disk.</value>
        [DataMember(Name="diskPartitions", EmitDefaultValue=false)]
        public List<DiskPartition> DiskPartitions { get; set; }


        /// <summary>
        /// Specifies the sector size of hard disk. It is used for mapping the disk blocks of the disk file into a linear list of sectors.
        /// </summary>
        /// <value>Specifies the sector size of hard disk. It is used for mapping the disk blocks of the disk file into a linear list of sectors.</value>
        [DataMember(Name="sectorSizeBytes", EmitDefaultValue=false)]
        public long? SectorSizeBytes { get; set; }

        /// <summary>
        /// Specifies the disk uuid.
        /// </summary>
        /// <value>Specifies the disk uuid.</value>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// Specifies the disk file name. This is the VMDK name and not the flat file name.
        /// </summary>
        /// <value>Specifies the disk file name. This is the VMDK name and not the flat file name.</value>
        [DataMember(Name="vmdkFileName", EmitDefaultValue=false)]
        public string VmdkFileName { get; set; }

        /// <summary>
        /// Specifies the disk size in bytes.
        /// </summary>
        /// <value>Specifies the disk size in bytes.</value>
        [DataMember(Name="vmdkSizeBytes", EmitDefaultValue=false)]
        public long? VmdkSizeBytes { get; set; }

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
            return this.Equals(input as Disk);
        }

        /// <summary>
        /// Returns true if Disk instances are equal
        /// </summary>
        /// <param name="input">Instance of Disk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Disk input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DiskBlocks == input.DiskBlocks ||
                    this.DiskBlocks != null &&
                    this.DiskBlocks.SequenceEqual(input.DiskBlocks)
                ) && 
                (
                    this.DiskFormat == input.DiskFormat ||
                    (this.DiskFormat != null &&
                    this.DiskFormat.Equals(input.DiskFormat))
                ) && 
                (
                    this.DiskPartitions == input.DiskPartitions ||
                    this.DiskPartitions != null &&
                    this.DiskPartitions.SequenceEqual(input.DiskPartitions)
                ) && 
                (
                    this.PartitionTableFormat == input.PartitionTableFormat ||
                    (this.PartitionTableFormat != null &&
                    this.PartitionTableFormat.Equals(input.PartitionTableFormat))
                ) && 
                (
                    this.SectorSizeBytes == input.SectorSizeBytes ||
                    (this.SectorSizeBytes != null &&
                    this.SectorSizeBytes.Equals(input.SectorSizeBytes))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.VmdkFileName == input.VmdkFileName ||
                    (this.VmdkFileName != null &&
                    this.VmdkFileName.Equals(input.VmdkFileName))
                ) && 
                (
                    this.VmdkSizeBytes == input.VmdkSizeBytes ||
                    (this.VmdkSizeBytes != null &&
                    this.VmdkSizeBytes.Equals(input.VmdkSizeBytes))
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
                if (this.DiskBlocks != null)
                    hashCode = hashCode * 59 + this.DiskBlocks.GetHashCode();
                if (this.DiskFormat != null)
                    hashCode = hashCode * 59 + this.DiskFormat.GetHashCode();
                if (this.DiskPartitions != null)
                    hashCode = hashCode * 59 + this.DiskPartitions.GetHashCode();
                if (this.PartitionTableFormat != null)
                    hashCode = hashCode * 59 + this.PartitionTableFormat.GetHashCode();
                if (this.SectorSizeBytes != null)
                    hashCode = hashCode * 59 + this.SectorSizeBytes.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.VmdkFileName != null)
                    hashCode = hashCode * 59 + this.VmdkFileName.GetHashCode();
                if (this.VmdkSizeBytes != null)
                    hashCode = hashCode * 59 + this.VmdkSizeBytes.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


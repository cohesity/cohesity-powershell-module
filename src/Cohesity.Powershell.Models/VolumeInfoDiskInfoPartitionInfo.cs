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
    /// Offset/Length here is relative to the logical range starting at 0, formed by mapping the physical ranges of the disk into a linear device.
    /// </summary>
    [DataContract]
    public partial class VolumeInfoDiskInfoPartitionInfo :  IEquatable<VolumeInfoDiskInfoPartitionInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeInfoDiskInfoPartitionInfo" /> class.
        /// </summary>
        /// <param name="length">Length of partition in bytes..</param>
        /// <param name="partitionNumber">Partition number..</param>
        /// <param name="partitionTypeUuid">Partition type uuid. If disk is unpartitioned, this field will not be set. If disk is MBR partitioned, this field will be set to partition type. Example: 83 (from below fdisk output) [This value is in hex] bash$ fdisk -l foobar.vmdk Device        Boot Start   End    Sectors  Size Id Type foobar.vmdk1       2048  1050623  1048576  512M 83 Linux If disk is GPT partitioned, this field will be set to partition type GUID. Example: fc63daf-8483-4772-8e793d69d8477de4 (Linux filesystem data).</param>
        /// <param name="partitionUuid">Partition uuid. If disk is unpartitioned, this field will not be set. If disk is MBR partitioned, this field will not be set. If disk is GPT partitioned, this field will be set to partition GUID..</param>
        /// <param name="startOffset">Start offset of partition in bytes..</param>
        public VolumeInfoDiskInfoPartitionInfo(long? length = default(long?), long? partitionNumber = default(long?), string partitionTypeUuid = default(string), string partitionUuid = default(string), long? startOffset = default(long?))
        {
            this.Length = length;
            this.PartitionNumber = partitionNumber;
            this.PartitionTypeUuid = partitionTypeUuid;
            this.PartitionUuid = partitionUuid;
            this.StartOffset = startOffset;
        }
        
        /// <summary>
        /// Length of partition in bytes.
        /// </summary>
        /// <value>Length of partition in bytes.</value>
        [DataMember(Name="length", EmitDefaultValue=false)]
        public long? Length { get; set; }

        /// <summary>
        /// Partition number.
        /// </summary>
        /// <value>Partition number.</value>
        [DataMember(Name="partitionNumber", EmitDefaultValue=false)]
        public long? PartitionNumber { get; set; }

        /// <summary>
        /// Partition type uuid. If disk is unpartitioned, this field will not be set. If disk is MBR partitioned, this field will be set to partition type. Example: 83 (from below fdisk output) [This value is in hex] bash$ fdisk -l foobar.vmdk Device        Boot Start   End    Sectors  Size Id Type foobar.vmdk1       2048  1050623  1048576  512M 83 Linux If disk is GPT partitioned, this field will be set to partition type GUID. Example: fc63daf-8483-4772-8e793d69d8477de4 (Linux filesystem data)
        /// </summary>
        /// <value>Partition type uuid. If disk is unpartitioned, this field will not be set. If disk is MBR partitioned, this field will be set to partition type. Example: 83 (from below fdisk output) [This value is in hex] bash$ fdisk -l foobar.vmdk Device        Boot Start   End    Sectors  Size Id Type foobar.vmdk1       2048  1050623  1048576  512M 83 Linux If disk is GPT partitioned, this field will be set to partition type GUID. Example: fc63daf-8483-4772-8e793d69d8477de4 (Linux filesystem data)</value>
        [DataMember(Name="partitionTypeUuid", EmitDefaultValue=false)]
        public string PartitionTypeUuid { get; set; }

        /// <summary>
        /// Partition uuid. If disk is unpartitioned, this field will not be set. If disk is MBR partitioned, this field will not be set. If disk is GPT partitioned, this field will be set to partition GUID.
        /// </summary>
        /// <value>Partition uuid. If disk is unpartitioned, this field will not be set. If disk is MBR partitioned, this field will not be set. If disk is GPT partitioned, this field will be set to partition GUID.</value>
        [DataMember(Name="partitionUuid", EmitDefaultValue=false)]
        public string PartitionUuid { get; set; }

        /// <summary>
        /// Start offset of partition in bytes.
        /// </summary>
        /// <value>Start offset of partition in bytes.</value>
        [DataMember(Name="startOffset", EmitDefaultValue=false)]
        public long? StartOffset { get; set; }

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
            return this.Equals(input as VolumeInfoDiskInfoPartitionInfo);
        }

        /// <summary>
        /// Returns true if VolumeInfoDiskInfoPartitionInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VolumeInfoDiskInfoPartitionInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VolumeInfoDiskInfoPartitionInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Length == input.Length ||
                    (this.Length != null &&
                    this.Length.Equals(input.Length))
                ) && 
                (
                    this.PartitionNumber == input.PartitionNumber ||
                    (this.PartitionNumber != null &&
                    this.PartitionNumber.Equals(input.PartitionNumber))
                ) && 
                (
                    this.PartitionTypeUuid == input.PartitionTypeUuid ||
                    (this.PartitionTypeUuid != null &&
                    this.PartitionTypeUuid.Equals(input.PartitionTypeUuid))
                ) && 
                (
                    this.PartitionUuid == input.PartitionUuid ||
                    (this.PartitionUuid != null &&
                    this.PartitionUuid.Equals(input.PartitionUuid))
                ) && 
                (
                    this.StartOffset == input.StartOffset ||
                    (this.StartOffset != null &&
                    this.StartOffset.Equals(input.StartOffset))
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
                if (this.Length != null)
                    hashCode = hashCode * 59 + this.Length.GetHashCode();
                if (this.PartitionNumber != null)
                    hashCode = hashCode * 59 + this.PartitionNumber.GetHashCode();
                if (this.PartitionTypeUuid != null)
                    hashCode = hashCode * 59 + this.PartitionTypeUuid.GetHashCode();
                if (this.PartitionUuid != null)
                    hashCode = hashCode * 59 + this.PartitionUuid.GetHashCode();
                if (this.StartOffset != null)
                    hashCode = hashCode * 59 + this.StartOffset.GetHashCode();
                return hashCode;
            }
        }

    }

}


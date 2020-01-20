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
    /// DeviceTreePartitionSlice
    /// </summary>
    [DataContract]
    public partial class DeviceTreePartitionSlice :  IEquatable<DeviceTreePartitionSlice>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceTreePartitionSlice" /> class.
        /// </summary>
        /// <param name="diskFileName">The disk to use..</param>
        /// <param name="length">The length of data for the LVM volume (for which this device tree is being built) in bytes. It does not include size of the LVM meta data..</param>
        /// <param name="lvmDataOffset">Each LVM partition starts with LVM meta data. After the meta data there can be data for one or more LVM volumes.  This field indicates the offset in bytes (relative to partition) where data for various LVM volumes starts on the partition. NOTE: If this device tree represents first LVM volume on the  partition, &#39;lvm_data_offset&#39; is equal to &#39;offset&#39;..</param>
        /// <param name="offset">This is the offset (in bytes) where data for the LVM volume (for which this device tree is being build) starts relative to the start of the partition above..</param>
        /// <param name="partitionNumber">The partition to use in the disk above..</param>
        public DeviceTreePartitionSlice(string diskFileName = default(string), long? length = default(long?), long? lvmDataOffset = default(long?), long? offset = default(long?), int? partitionNumber = default(int?))
        {
            this.DiskFileName = diskFileName;
            this.Length = length;
            this.LvmDataOffset = lvmDataOffset;
            this.Offset = offset;
            this.PartitionNumber = partitionNumber;
            this.DiskFileName = diskFileName;
            this.Length = length;
            this.LvmDataOffset = lvmDataOffset;
            this.Offset = offset;
            this.PartitionNumber = partitionNumber;
        }
        
        /// <summary>
        /// The disk to use.
        /// </summary>
        /// <value>The disk to use.</value>
        [DataMember(Name="diskFileName", EmitDefaultValue=true)]
        public string DiskFileName { get; set; }

        /// <summary>
        /// The length of data for the LVM volume (for which this device tree is being built) in bytes. It does not include size of the LVM meta data.
        /// </summary>
        /// <value>The length of data for the LVM volume (for which this device tree is being built) in bytes. It does not include size of the LVM meta data.</value>
        [DataMember(Name="length", EmitDefaultValue=true)]
        public long? Length { get; set; }

        /// <summary>
        /// Each LVM partition starts with LVM meta data. After the meta data there can be data for one or more LVM volumes.  This field indicates the offset in bytes (relative to partition) where data for various LVM volumes starts on the partition. NOTE: If this device tree represents first LVM volume on the  partition, &#39;lvm_data_offset&#39; is equal to &#39;offset&#39;.
        /// </summary>
        /// <value>Each LVM partition starts with LVM meta data. After the meta data there can be data for one or more LVM volumes.  This field indicates the offset in bytes (relative to partition) where data for various LVM volumes starts on the partition. NOTE: If this device tree represents first LVM volume on the  partition, &#39;lvm_data_offset&#39; is equal to &#39;offset&#39;.</value>
        [DataMember(Name="lvmDataOffset", EmitDefaultValue=true)]
        public long? LvmDataOffset { get; set; }

        /// <summary>
        /// This is the offset (in bytes) where data for the LVM volume (for which this device tree is being build) starts relative to the start of the partition above.
        /// </summary>
        /// <value>This is the offset (in bytes) where data for the LVM volume (for which this device tree is being build) starts relative to the start of the partition above.</value>
        [DataMember(Name="offset", EmitDefaultValue=true)]
        public long? Offset { get; set; }

        /// <summary>
        /// The partition to use in the disk above.
        /// </summary>
        /// <value>The partition to use in the disk above.</value>
        [DataMember(Name="partitionNumber", EmitDefaultValue=true)]
        public int? PartitionNumber { get; set; }

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
            return this.Equals(input as DeviceTreePartitionSlice);
        }

        /// <summary>
        /// Returns true if DeviceTreePartitionSlice instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceTreePartitionSlice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceTreePartitionSlice input)
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
                    this.Length == input.Length ||
                    (this.Length != null &&
                    this.Length.Equals(input.Length))
                ) && 
                (
                    this.LvmDataOffset == input.LvmDataOffset ||
                    (this.LvmDataOffset != null &&
                    this.LvmDataOffset.Equals(input.LvmDataOffset))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.PartitionNumber == input.PartitionNumber ||
                    (this.PartitionNumber != null &&
                    this.PartitionNumber.Equals(input.PartitionNumber))
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
                if (this.Length != null)
                    hashCode = hashCode * 59 + this.Length.GetHashCode();
                if (this.LvmDataOffset != null)
                    hashCode = hashCode * 59 + this.LvmDataOffset.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.PartitionNumber != null)
                    hashCode = hashCode * 59 + this.PartitionNumber.GetHashCode();
                return hashCode;
            }
        }

    }

}


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
    /// Specifies information about each partition in a physical disk.
    /// </summary>
    [DataContract]
    public partial class DiskPartition :  IEquatable<DiskPartition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiskPartition" /> class.
        /// </summary>
        /// <param name="lengthBytes">Specifies the length of the block in bytes..</param>
        /// <param name="number">Specifies a unique number of the partition within the linear disk file..</param>
        /// <param name="offsetBytes">Specifies the offset of the block (in bytes) from the beginning of the containing object such as a physical disk or a virtual disk file..</param>
        /// <param name="typeUuid">Specifies the partition type uuid. If disk is unpartitioned, this field is not set. If disk is MBR partitioned, this field is set to a partition type. If disk is GPT partitioned, this field is set to a partition type GUID..</param>
        /// <param name="uuid">Specifies the partition uuid. If disk is unpartitioned, this field is not set. If disk is MBR partitioned, this field is not set. If disk is GPT partitioned, this field is set to a partition GUID..</param>
        public DiskPartition(long? lengthBytes = default(long?), long? number = default(long?), long? offsetBytes = default(long?), string typeUuid = default(string), string uuid = default(string))
        {
            this.LengthBytes = lengthBytes;
            this.Number = number;
            this.OffsetBytes = offsetBytes;
            this.TypeUuid = typeUuid;
            this.Uuid = uuid;
        }
        
        /// <summary>
        /// Specifies the length of the block in bytes.
        /// </summary>
        /// <value>Specifies the length of the block in bytes.</value>
        [DataMember(Name="lengthBytes", EmitDefaultValue=false)]
        public long? LengthBytes { get; set; }

        /// <summary>
        /// Specifies a unique number of the partition within the linear disk file.
        /// </summary>
        /// <value>Specifies a unique number of the partition within the linear disk file.</value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public long? Number { get; set; }

        /// <summary>
        /// Specifies the offset of the block (in bytes) from the beginning of the containing object such as a physical disk or a virtual disk file.
        /// </summary>
        /// <value>Specifies the offset of the block (in bytes) from the beginning of the containing object such as a physical disk or a virtual disk file.</value>
        [DataMember(Name="offsetBytes", EmitDefaultValue=false)]
        public long? OffsetBytes { get; set; }

        /// <summary>
        /// Specifies the partition type uuid. If disk is unpartitioned, this field is not set. If disk is MBR partitioned, this field is set to a partition type. If disk is GPT partitioned, this field is set to a partition type GUID.
        /// </summary>
        /// <value>Specifies the partition type uuid. If disk is unpartitioned, this field is not set. If disk is MBR partitioned, this field is set to a partition type. If disk is GPT partitioned, this field is set to a partition type GUID.</value>
        [DataMember(Name="typeUuid", EmitDefaultValue=false)]
        public string TypeUuid { get; set; }

        /// <summary>
        /// Specifies the partition uuid. If disk is unpartitioned, this field is not set. If disk is MBR partitioned, this field is not set. If disk is GPT partitioned, this field is set to a partition GUID.
        /// </summary>
        /// <value>Specifies the partition uuid. If disk is unpartitioned, this field is not set. If disk is MBR partitioned, this field is not set. If disk is GPT partitioned, this field is set to a partition GUID.</value>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public string Uuid { get; set; }

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
            return this.Equals(input as DiskPartition);
        }

        /// <summary>
        /// Returns true if DiskPartition instances are equal
        /// </summary>
        /// <param name="input">Instance of DiskPartition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiskPartition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LengthBytes == input.LengthBytes ||
                    (this.LengthBytes != null &&
                    this.LengthBytes.Equals(input.LengthBytes))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.OffsetBytes == input.OffsetBytes ||
                    (this.OffsetBytes != null &&
                    this.OffsetBytes.Equals(input.OffsetBytes))
                ) && 
                (
                    this.TypeUuid == input.TypeUuid ||
                    (this.TypeUuid != null &&
                    this.TypeUuid.Equals(input.TypeUuid))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
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
                if (this.LengthBytes != null)
                    hashCode = hashCode * 59 + this.LengthBytes.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.OffsetBytes != null)
                    hashCode = hashCode * 59 + this.OffsetBytes.GetHashCode();
                if (this.TypeUuid != null)
                    hashCode = hashCode * 59 + this.TypeUuid.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


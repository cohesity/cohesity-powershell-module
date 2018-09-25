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
    /// Defines a leaf node of a device tree. This refers to a logical partition in a virtual disk file.
    /// </summary>
    [DataContract]
    public partial class FilePartitionBlock :  IEquatable<FilePartitionBlock>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilePartitionBlock" /> class.
        /// </summary>
        /// <param name="diskFileName">Specifies the disk file name where the logical partition is..</param>
        /// <param name="lengthBytes">Specifies the length of the block in bytes..</param>
        /// <param name="number">Specifies a unique number of the partition within the linear disk file..</param>
        /// <param name="offsetBytes">Specifies the offset of the block (in bytes) from the beginning of the containing object such as a physical disk or a virtual disk file..</param>
        public FilePartitionBlock(string diskFileName = default(string), long? lengthBytes = default(long?), long? number = default(long?), long? offsetBytes = default(long?))
        {
            this.DiskFileName = diskFileName;
            this.LengthBytes = lengthBytes;
            this.Number = number;
            this.OffsetBytes = offsetBytes;
        }
        
        /// <summary>
        /// Specifies the disk file name where the logical partition is.
        /// </summary>
        /// <value>Specifies the disk file name where the logical partition is.</value>
        [DataMember(Name="diskFileName", EmitDefaultValue=false)]
        public string DiskFileName { get; set; }

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
            return this.Equals(input as FilePartitionBlock);
        }

        /// <summary>
        /// Returns true if FilePartitionBlock instances are equal
        /// </summary>
        /// <param name="input">Instance of FilePartitionBlock to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FilePartitionBlock input)
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
                if (this.LengthBytes != null)
                    hashCode = hashCode * 59 + this.LengthBytes.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.OffsetBytes != null)
                    hashCode = hashCode * 59 + this.OffsetBytes.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


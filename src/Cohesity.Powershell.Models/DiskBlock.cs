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
    /// Specifies a contiguous block by defining an offset and length of the block.
    /// </summary>
    [DataContract]
    public partial class DiskBlock :  IEquatable<DiskBlock>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiskBlock" /> class.
        /// </summary>
        /// <param name="lengthBytes">Specifies the length of the block in bytes..</param>
        /// <param name="offsetBytes">Specifies the offset of the block (in bytes) from the beginning of the containing object such as a physical disk or a virtual disk file..</param>
        public DiskBlock(long? lengthBytes = default(long?), long? offsetBytes = default(long?))
        {
            this.LengthBytes = lengthBytes;
            this.OffsetBytes = offsetBytes;
        }
        
        /// <summary>
        /// Specifies the length of the block in bytes.
        /// </summary>
        /// <value>Specifies the length of the block in bytes.</value>
        [DataMember(Name="lengthBytes", EmitDefaultValue=false)]
        public long? LengthBytes { get; set; }

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
            return this.Equals(input as DiskBlock);
        }

        /// <summary>
        /// Returns true if DiskBlock instances are equal
        /// </summary>
        /// <param name="input">Instance of DiskBlock to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiskBlock input)
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
                if (this.LengthBytes != null)
                    hashCode = hashCode * 59 + this.LengthBytes.GetHashCode();
                if (this.OffsetBytes != null)
                    hashCode = hashCode * 59 + this.OffsetBytes.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


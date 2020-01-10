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
    /// VolumeInfoDiskInfoPhysicalRange
    /// </summary>
    [DataContract]
    public partial class VolumeInfoDiskInfoPhysicalRange :  IEquatable<VolumeInfoDiskInfoPhysicalRange>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeInfoDiskInfoPhysicalRange" /> class.
        /// </summary>
        /// <param name="length">Length of this range in bytes..</param>
        /// <param name="offset">Offset of this range in disk file from beginning of file..</param>
        public VolumeInfoDiskInfoPhysicalRange(long? length = default(long?), long? offset = default(long?))
        {
            this.Length = length;
            this.Offset = offset;
            this.Length = length;
            this.Offset = offset;
        }
        
        /// <summary>
        /// Length of this range in bytes.
        /// </summary>
        /// <value>Length of this range in bytes.</value>
        [DataMember(Name="length", EmitDefaultValue=true)]
        public long? Length { get; set; }

        /// <summary>
        /// Offset of this range in disk file from beginning of file.
        /// </summary>
        /// <value>Offset of this range in disk file from beginning of file.</value>
        [DataMember(Name="offset", EmitDefaultValue=true)]
        public long? Offset { get; set; }

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
            return this.Equals(input as VolumeInfoDiskInfoPhysicalRange);
        }

        /// <summary>
        /// Returns true if VolumeInfoDiskInfoPhysicalRange instances are equal
        /// </summary>
        /// <param name="input">Instance of VolumeInfoDiskInfoPhysicalRange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VolumeInfoDiskInfoPhysicalRange input)
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
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
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
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                return hashCode;
            }
        }

    }

}


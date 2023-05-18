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
    /// Specifies a SAN Volume in a SAN Storage Array.
    /// </summary>
    [DataContract]
    public partial class SanVolume :  IEquatable<SanVolume>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SanVolume" /> class.
        /// </summary>
        /// <param name="createdTime">Specifies the created time (e.g., \&quot;2015-07-21T17:59:41Z\&quot;) of the volume..</param>
        /// <param name="parentVolume">Specifies the name of the source volume, if this volume was copied or cloned from it..</param>
        /// <param name="serialNumber">Specifies the serial number of the volume..</param>
        /// <param name="sizeBytes">Specifies the provisioned size in bytes of the volume..</param>
        /// <param name="usedBytes">Specifies the total space actually used by the volume..</param>
        public SanVolume(string createdTime = default(string), string parentVolume = default(string), string serialNumber = default(string), long? sizeBytes = default(long?), long? usedBytes = default(long?))
        {
            this.CreatedTime = createdTime;
            this.ParentVolume = parentVolume;
            this.SerialNumber = serialNumber;
            this.SizeBytes = sizeBytes;
            this.UsedBytes = usedBytes;
            this.CreatedTime = createdTime;
            this.ParentVolume = parentVolume;
            this.SerialNumber = serialNumber;
            this.SizeBytes = sizeBytes;
            this.UsedBytes = usedBytes;
        }
        
        /// <summary>
        /// Specifies the created time (e.g., \&quot;2015-07-21T17:59:41Z\&quot;) of the volume.
        /// </summary>
        /// <value>Specifies the created time (e.g., \&quot;2015-07-21T17:59:41Z\&quot;) of the volume.</value>
        [DataMember(Name="createdTime", EmitDefaultValue=true)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// Specifies the name of the source volume, if this volume was copied or cloned from it.
        /// </summary>
        /// <value>Specifies the name of the source volume, if this volume was copied or cloned from it.</value>
        [DataMember(Name="parentVolume", EmitDefaultValue=true)]
        public string ParentVolume { get; set; }

        /// <summary>
        /// Specifies the serial number of the volume.
        /// </summary>
        /// <value>Specifies the serial number of the volume.</value>
        [DataMember(Name="serialNumber", EmitDefaultValue=true)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Specifies the provisioned size in bytes of the volume.
        /// </summary>
        /// <value>Specifies the provisioned size in bytes of the volume.</value>
        [DataMember(Name="sizeBytes", EmitDefaultValue=true)]
        public long? SizeBytes { get; set; }

        /// <summary>
        /// Specifies the total space actually used by the volume.
        /// </summary>
        /// <value>Specifies the total space actually used by the volume.</value>
        [DataMember(Name="usedBytes", EmitDefaultValue=true)]
        public long? UsedBytes { get; set; }

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
            return this.Equals(input as SanVolume);
        }

        /// <summary>
        /// Returns true if SanVolume instances are equal
        /// </summary>
        /// <param name="input">Instance of SanVolume to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SanVolume input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedTime == input.CreatedTime ||
                    (this.CreatedTime != null &&
                    this.CreatedTime.Equals(input.CreatedTime))
                ) && 
                (
                    this.ParentVolume == input.ParentVolume ||
                    (this.ParentVolume != null &&
                    this.ParentVolume.Equals(input.ParentVolume))
                ) && 
                (
                    this.SerialNumber == input.SerialNumber ||
                    (this.SerialNumber != null &&
                    this.SerialNumber.Equals(input.SerialNumber))
                ) && 
                (
                    this.SizeBytes == input.SizeBytes ||
                    (this.SizeBytes != null &&
                    this.SizeBytes.Equals(input.SizeBytes))
                ) && 
                (
                    this.UsedBytes == input.UsedBytes ||
                    (this.UsedBytes != null &&
                    this.UsedBytes.Equals(input.UsedBytes))
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
                if (this.CreatedTime != null)
                    hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                if (this.ParentVolume != null)
                    hashCode = hashCode * 59 + this.ParentVolume.GetHashCode();
                if (this.SerialNumber != null)
                    hashCode = hashCode * 59 + this.SerialNumber.GetHashCode();
                if (this.SizeBytes != null)
                    hashCode = hashCode * 59 + this.SizeBytes.GetHashCode();
                if (this.UsedBytes != null)
                    hashCode = hashCode * 59 + this.UsedBytes.GetHashCode();
                return hashCode;
            }
        }

    }

}


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
    /// Specifies information about virtual disks where a user can specify mappings of source disk and destination disk to overwrite.
    /// </summary>
    [DataContract]
    public partial class VirtualDiskMappingResponse :  IEquatable<VirtualDiskMappingResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualDiskMappingResponse" /> class.
        /// </summary>
        /// <param name="diskToOverwrite">diskToOverwrite.</param>
        /// <param name="sourceDisk">sourceDisk.</param>
        /// <param name="targetLocation">targetLocation.</param>
        public VirtualDiskMappingResponse(VirtualDiskIdInformation diskToOverwrite = default(VirtualDiskIdInformation), VirtualDiskIdInformation sourceDisk = default(VirtualDiskIdInformation), ProtectionSource targetLocation = default(ProtectionSource))
        {
            this.DiskToOverwrite = diskToOverwrite;
            this.SourceDisk = sourceDisk;
            this.TargetLocation = targetLocation;
        }
        
        /// <summary>
        /// Gets or Sets DiskToOverwrite
        /// </summary>
        [DataMember(Name="diskToOverwrite", EmitDefaultValue=false)]
        public VirtualDiskIdInformation DiskToOverwrite { get; set; }

        /// <summary>
        /// Gets or Sets SourceDisk
        /// </summary>
        [DataMember(Name="sourceDisk", EmitDefaultValue=false)]
        public VirtualDiskIdInformation SourceDisk { get; set; }

        /// <summary>
        /// Gets or Sets TargetLocation
        /// </summary>
        [DataMember(Name="targetLocation", EmitDefaultValue=false)]
        public ProtectionSource TargetLocation { get; set; }

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
            return this.Equals(input as VirtualDiskMappingResponse);
        }

        /// <summary>
        /// Returns true if VirtualDiskMappingResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of VirtualDiskMappingResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VirtualDiskMappingResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DiskToOverwrite == input.DiskToOverwrite ||
                    (this.DiskToOverwrite != null &&
                    this.DiskToOverwrite.Equals(input.DiskToOverwrite))
                ) && 
                (
                    this.SourceDisk == input.SourceDisk ||
                    (this.SourceDisk != null &&
                    this.SourceDisk.Equals(input.SourceDisk))
                ) && 
                (
                    this.TargetLocation == input.TargetLocation ||
                    (this.TargetLocation != null &&
                    this.TargetLocation.Equals(input.TargetLocation))
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
                if (this.DiskToOverwrite != null)
                    hashCode = hashCode * 59 + this.DiskToOverwrite.GetHashCode();
                if (this.SourceDisk != null)
                    hashCode = hashCode * 59 + this.SourceDisk.GetHashCode();
                if (this.TargetLocation != null)
                    hashCode = hashCode * 59 + this.TargetLocation.GetHashCode();
                return hashCode;
            }
        }

    }

}


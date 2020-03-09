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
    /// Specifies the request data struct for virtual disk mapping with only the disk ids.
    /// </summary>
    [DataContract]
    public partial class VirtualDiskMapping :  IEquatable<VirtualDiskMapping>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualDiskMapping" /> class.
        /// </summary>
        /// <param name="diskToOverwrite">diskToOverwrite.</param>
        /// <param name="sourceDisk">sourceDisk.</param>
        /// <param name="targetLocationId">Specifies the target location information, for e.g. a datastore in VMware environment. If diskToOverwrite is specified, then the target location is automatically deduced..</param>
        public VirtualDiskMapping(VirtualDiskIdInformation diskToOverwrite = default(VirtualDiskIdInformation), VirtualDiskIdInformation sourceDisk = default(VirtualDiskIdInformation), long? targetLocationId = default(long?))
        {
            this.TargetLocationId = targetLocationId;
            this.DiskToOverwrite = diskToOverwrite;
            this.SourceDisk = sourceDisk;
            this.TargetLocationId = targetLocationId;
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
        /// Specifies the target location information, for e.g. a datastore in VMware environment. If diskToOverwrite is specified, then the target location is automatically deduced.
        /// </summary>
        /// <value>Specifies the target location information, for e.g. a datastore in VMware environment. If diskToOverwrite is specified, then the target location is automatically deduced.</value>
        [DataMember(Name="targetLocationId", EmitDefaultValue=true)]
        public long? TargetLocationId { get; set; }

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
            return this.Equals(input as VirtualDiskMapping);
        }

        /// <summary>
        /// Returns true if VirtualDiskMapping instances are equal
        /// </summary>
        /// <param name="input">Instance of VirtualDiskMapping to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VirtualDiskMapping input)
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
                    this.TargetLocationId == input.TargetLocationId ||
                    (this.TargetLocationId != null &&
                    this.TargetLocationId.Equals(input.TargetLocationId))
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
                if (this.TargetLocationId != null)
                    hashCode = hashCode * 59 + this.TargetLocationId.GetHashCode();
                return hashCode;
            }
        }

    }

}


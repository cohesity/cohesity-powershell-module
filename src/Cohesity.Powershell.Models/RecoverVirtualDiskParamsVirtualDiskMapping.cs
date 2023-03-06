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
    /// RecoverVirtualDiskParamsVirtualDiskMapping
    /// </summary>
    [DataContract]
    public partial class RecoverVirtualDiskParamsVirtualDiskMapping :  IEquatable<RecoverVirtualDiskParamsVirtualDiskMapping>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecoverVirtualDiskParamsVirtualDiskMapping" /> class.
        /// </summary>
        /// <param name="diskToOverwrite">diskToOverwrite.</param>
        /// <param name="srcDisk">srcDisk.</param>
        /// <param name="targetLocation">targetLocation.</param>
        public RecoverVirtualDiskParamsVirtualDiskMapping(VirtualDiskId diskToOverwrite = default(VirtualDiskId), VirtualDiskId srcDisk = default(VirtualDiskId), EntityProto targetLocation = default(EntityProto))
        {
            this.DiskToOverwrite = diskToOverwrite;
            this.SrcDisk = srcDisk;
            this.TargetLocation = targetLocation;
        }
        
        /// <summary>
        /// Gets or Sets DiskToOverwrite
        /// </summary>
        [DataMember(Name="diskToOverwrite", EmitDefaultValue=false)]
        public VirtualDiskId DiskToOverwrite { get; set; }

        /// <summary>
        /// Gets or Sets SrcDisk
        /// </summary>
        [DataMember(Name="srcDisk", EmitDefaultValue=false)]
        public VirtualDiskId SrcDisk { get; set; }

        /// <summary>
        /// Gets or Sets TargetLocation
        /// </summary>
        [DataMember(Name="targetLocation", EmitDefaultValue=false)]
        public EntityProto TargetLocation { get; set; }

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
            return this.Equals(input as RecoverVirtualDiskParamsVirtualDiskMapping);
        }

        /// <summary>
        /// Returns true if RecoverVirtualDiskParamsVirtualDiskMapping instances are equal
        /// </summary>
        /// <param name="input">Instance of RecoverVirtualDiskParamsVirtualDiskMapping to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecoverVirtualDiskParamsVirtualDiskMapping input)
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
                    this.SrcDisk == input.SrcDisk ||
                    (this.SrcDisk != null &&
                    this.SrcDisk.Equals(input.SrcDisk))
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
                if (this.SrcDisk != null)
                    hashCode = hashCode * 59 + this.SrcDisk.GetHashCode();
                if (this.TargetLocation != null)
                    hashCode = hashCode * 59 + this.TargetLocation.GetHashCode();
                return hashCode;
            }
        }

    }

}


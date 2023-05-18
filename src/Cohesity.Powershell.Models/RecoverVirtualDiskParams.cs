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
    /// RecoverVirtualDiskParams
    /// </summary>
    [DataContract]
    public partial class RecoverVirtualDiskParams :  IEquatable<RecoverVirtualDiskParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecoverVirtualDiskParams" /> class.
        /// </summary>
        /// <param name="powerOffVmBeforeRecovery">Whether to power-off the VM before recovering virtual disks..</param>
        /// <param name="powerOnVmAfterRecovery">Whether to power-on the VM after recovering virtual disks..</param>
        /// <param name="targetEntity">targetEntity.</param>
        /// <param name="virtualDiskMappings">virtualDiskMappings.</param>
        public RecoverVirtualDiskParams(bool? powerOffVmBeforeRecovery = default(bool?), bool? powerOnVmAfterRecovery = default(bool?), EntityProto targetEntity = default(EntityProto), List<RecoverVirtualDiskParamsVirtualDiskMapping> virtualDiskMappings = default(List<RecoverVirtualDiskParamsVirtualDiskMapping>))
        {
            this.PowerOffVmBeforeRecovery = powerOffVmBeforeRecovery;
            this.PowerOnVmAfterRecovery = powerOnVmAfterRecovery;
            this.VirtualDiskMappings = virtualDiskMappings;
            this.PowerOffVmBeforeRecovery = powerOffVmBeforeRecovery;
            this.PowerOnVmAfterRecovery = powerOnVmAfterRecovery;
            this.TargetEntity = targetEntity;
            this.VirtualDiskMappings = virtualDiskMappings;
        }
        
        /// <summary>
        /// Whether to power-off the VM before recovering virtual disks.
        /// </summary>
        /// <value>Whether to power-off the VM before recovering virtual disks.</value>
        [DataMember(Name="powerOffVmBeforeRecovery", EmitDefaultValue=true)]
        public bool? PowerOffVmBeforeRecovery { get; set; }

        /// <summary>
        /// Whether to power-on the VM after recovering virtual disks.
        /// </summary>
        /// <value>Whether to power-on the VM after recovering virtual disks.</value>
        [DataMember(Name="powerOnVmAfterRecovery", EmitDefaultValue=true)]
        public bool? PowerOnVmAfterRecovery { get; set; }

        /// <summary>
        /// Gets or Sets TargetEntity
        /// </summary>
        [DataMember(Name="targetEntity", EmitDefaultValue=false)]
        public EntityProto TargetEntity { get; set; }

        /// <summary>
        /// Gets or Sets VirtualDiskMappings
        /// </summary>
        [DataMember(Name="virtualDiskMappings", EmitDefaultValue=true)]
        public List<RecoverVirtualDiskParamsVirtualDiskMapping> VirtualDiskMappings { get; set; }

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
            return this.Equals(input as RecoverVirtualDiskParams);
        }

        /// <summary>
        /// Returns true if RecoverVirtualDiskParams instances are equal
        /// </summary>
        /// <param name="input">Instance of RecoverVirtualDiskParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecoverVirtualDiskParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PowerOffVmBeforeRecovery == input.PowerOffVmBeforeRecovery ||
                    (this.PowerOffVmBeforeRecovery != null &&
                    this.PowerOffVmBeforeRecovery.Equals(input.PowerOffVmBeforeRecovery))
                ) && 
                (
                    this.PowerOnVmAfterRecovery == input.PowerOnVmAfterRecovery ||
                    (this.PowerOnVmAfterRecovery != null &&
                    this.PowerOnVmAfterRecovery.Equals(input.PowerOnVmAfterRecovery))
                ) && 
                (
                    this.TargetEntity == input.TargetEntity ||
                    (this.TargetEntity != null &&
                    this.TargetEntity.Equals(input.TargetEntity))
                ) && 
                (
                    this.VirtualDiskMappings == input.VirtualDiskMappings ||
                    this.VirtualDiskMappings != null &&
                    input.VirtualDiskMappings != null &&
                    this.VirtualDiskMappings.SequenceEqual(input.VirtualDiskMappings)
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
                if (this.PowerOffVmBeforeRecovery != null)
                    hashCode = hashCode * 59 + this.PowerOffVmBeforeRecovery.GetHashCode();
                if (this.PowerOnVmAfterRecovery != null)
                    hashCode = hashCode * 59 + this.PowerOnVmAfterRecovery.GetHashCode();
                if (this.TargetEntity != null)
                    hashCode = hashCode * 59 + this.TargetEntity.GetHashCode();
                if (this.VirtualDiskMappings != null)
                    hashCode = hashCode * 59 + this.VirtualDiskMappings.GetHashCode();
                return hashCode;
            }
        }

    }

}


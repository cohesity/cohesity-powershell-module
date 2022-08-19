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
    /// Specifies the parameters to recover virtual disks of a vm with full Protection Source.
    /// </summary>
    [DataContract]
    public partial class VirtualDiskRestoreResponse :  IEquatable<VirtualDiskRestoreResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualDiskRestoreResponse" /> class.
        /// </summary>
        /// <param name="powerOffVmBeforeRecovery">Specifies whether to power off the VM before recovering virtual disks..</param>
        /// <param name="powerOnVmAfterRecovery">Specifies whether to power on the VM after recovering virtual disks..</param>
        /// <param name="targetSource">targetSource.</param>
        /// <param name="virtualDiskMappings">Specifies the list of virtual disks mappings..</param>
        public VirtualDiskRestoreResponse(bool? powerOffVmBeforeRecovery = default(bool?), bool? powerOnVmAfterRecovery = default(bool?), ProtectionSource targetSource = default(ProtectionSource), List<VirtualDiskMappingResponse> virtualDiskMappings = default(List<VirtualDiskMappingResponse>))
        {
            this.PowerOffVmBeforeRecovery = powerOffVmBeforeRecovery;
            this.PowerOnVmAfterRecovery = powerOnVmAfterRecovery;
            this.VirtualDiskMappings = virtualDiskMappings;
            this.PowerOffVmBeforeRecovery = powerOffVmBeforeRecovery;
            this.PowerOnVmAfterRecovery = powerOnVmAfterRecovery;
            this.TargetSource = targetSource;
            this.VirtualDiskMappings = virtualDiskMappings;
        }
        
        /// <summary>
        /// Specifies whether to power off the VM before recovering virtual disks.
        /// </summary>
        /// <value>Specifies whether to power off the VM before recovering virtual disks.</value>
        [DataMember(Name="powerOffVmBeforeRecovery", EmitDefaultValue=true)]
        public bool? PowerOffVmBeforeRecovery { get; set; }

        /// <summary>
        /// Specifies whether to power on the VM after recovering virtual disks.
        /// </summary>
        /// <value>Specifies whether to power on the VM after recovering virtual disks.</value>
        [DataMember(Name="powerOnVmAfterRecovery", EmitDefaultValue=true)]
        public bool? PowerOnVmAfterRecovery { get; set; }

        /// <summary>
        /// Gets or Sets TargetSource
        /// </summary>
        [DataMember(Name="targetSource", EmitDefaultValue=false)]
        public ProtectionSource TargetSource { get; set; }

        /// <summary>
        /// Specifies the list of virtual disks mappings.
        /// </summary>
        /// <value>Specifies the list of virtual disks mappings.</value>
        [DataMember(Name="virtualDiskMappings", EmitDefaultValue=true)]
        public List<VirtualDiskMappingResponse> VirtualDiskMappings { get; set; }

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
            return this.Equals(input as VirtualDiskRestoreResponse);
        }

        /// <summary>
        /// Returns true if VirtualDiskRestoreResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of VirtualDiskRestoreResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VirtualDiskRestoreResponse input)
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
                    this.TargetSource == input.TargetSource ||
                    (this.TargetSource != null &&
                    this.TargetSource.Equals(input.TargetSource))
                ) && 
                (
                    this.VirtualDiskMappings == input.VirtualDiskMappings ||
                    this.VirtualDiskMappings != null &&
                    input.VirtualDiskMappings != null &&
                    this.VirtualDiskMappings.Equals(input.VirtualDiskMappings)
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
                if (this.TargetSource != null)
                    hashCode = hashCode * 59 + this.TargetSource.GetHashCode();
                if (this.VirtualDiskMappings != null)
                    hashCode = hashCode * 59 + this.VirtualDiskMappings.GetHashCode();
                return hashCode;
            }
        }

    }

}


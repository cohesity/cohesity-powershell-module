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
    /// Specifies job parameters applicable for all &#39;kVMware&#39; Environment type Protection Sources in a Protection Job.
    /// </summary>
    [DataContract]
    public partial class VmwareEnvJobParameters :  IEquatable<VmwareEnvJobParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VmwareEnvJobParameters" /> class.
        /// </summary>
        /// <param name="excludedDisks">Specifies the list of Disks to be excluded from backing up. These disks are excluded from all Protection Sources in the Protection Job..</param>
        /// <param name="fallbackToCrashConsistent">If true, takes a crash-consistent snapshot when app-consistent snapshot fails. Otherwise, the snapshot attempt is marked failed..</param>
        /// <param name="skipPhysicalRdmDisks">If true, skip physical RDM disks when backing up VMs. Otherwise, backup of VMs having physical RDM will fail..</param>
        public VmwareEnvJobParameters(List<DiskUnit> excludedDisks = default(List<DiskUnit>), bool? fallbackToCrashConsistent = default(bool?), bool? skipPhysicalRdmDisks = default(bool?))
        {
            this.ExcludedDisks = excludedDisks;
            this.FallbackToCrashConsistent = fallbackToCrashConsistent;
            this.SkipPhysicalRdmDisks = skipPhysicalRdmDisks;
        }
        
        /// <summary>
        /// Specifies the list of Disks to be excluded from backing up. These disks are excluded from all Protection Sources in the Protection Job.
        /// </summary>
        /// <value>Specifies the list of Disks to be excluded from backing up. These disks are excluded from all Protection Sources in the Protection Job.</value>
        [DataMember(Name="excludedDisks", EmitDefaultValue=false)]
        public List<DiskUnit> ExcludedDisks { get; set; }

        /// <summary>
        /// If true, takes a crash-consistent snapshot when app-consistent snapshot fails. Otherwise, the snapshot attempt is marked failed.
        /// </summary>
        /// <value>If true, takes a crash-consistent snapshot when app-consistent snapshot fails. Otherwise, the snapshot attempt is marked failed.</value>
        [DataMember(Name="fallbackToCrashConsistent", EmitDefaultValue=false)]
        public bool? FallbackToCrashConsistent { get; set; }

        /// <summary>
        /// If true, skip physical RDM disks when backing up VMs. Otherwise, backup of VMs having physical RDM will fail.
        /// </summary>
        /// <value>If true, skip physical RDM disks when backing up VMs. Otherwise, backup of VMs having physical RDM will fail.</value>
        [DataMember(Name="skipPhysicalRdmDisks", EmitDefaultValue=false)]
        public bool? SkipPhysicalRdmDisks { get; set; }

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
            return this.Equals(input as VmwareEnvJobParameters);
        }

        /// <summary>
        /// Returns true if VmwareEnvJobParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of VmwareEnvJobParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VmwareEnvJobParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExcludedDisks == input.ExcludedDisks ||
                    this.ExcludedDisks != null &&
                    this.ExcludedDisks.SequenceEqual(input.ExcludedDisks)
                ) && 
                (
                    this.FallbackToCrashConsistent == input.FallbackToCrashConsistent ||
                    (this.FallbackToCrashConsistent != null &&
                    this.FallbackToCrashConsistent.Equals(input.FallbackToCrashConsistent))
                ) && 
                (
                    this.SkipPhysicalRdmDisks == input.SkipPhysicalRdmDisks ||
                    (this.SkipPhysicalRdmDisks != null &&
                    this.SkipPhysicalRdmDisks.Equals(input.SkipPhysicalRdmDisks))
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
                if (this.ExcludedDisks != null)
                    hashCode = hashCode * 59 + this.ExcludedDisks.GetHashCode();
                if (this.FallbackToCrashConsistent != null)
                    hashCode = hashCode * 59 + this.FallbackToCrashConsistent.GetHashCode();
                if (this.SkipPhysicalRdmDisks != null)
                    hashCode = hashCode * 59 + this.SkipPhysicalRdmDisks.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


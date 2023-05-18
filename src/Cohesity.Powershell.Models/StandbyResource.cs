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
    /// Message to encapsulate resources to be used to create a standby entity on the primary environment. Each environment should define the parameters it needs to create an entity on the primary environment.
    /// </summary>
    [DataContract]
    public partial class StandbyResource :  IEquatable<StandbyResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StandbyResource" /> class.
        /// </summary>
        /// <param name="recoveryPointObjectiveSecs">User defined recovery point objective for the standby VM. Using this RPO, Magneto will hydrate the VMs..</param>
        /// <param name="vmwareStandbyResource">vmwareStandbyResource.</param>
        public StandbyResource(long? recoveryPointObjectiveSecs = default(long?), VMwareStandbyResource vmwareStandbyResource = default(VMwareStandbyResource))
        {
            this.RecoveryPointObjectiveSecs = recoveryPointObjectiveSecs;
            this.RecoveryPointObjectiveSecs = recoveryPointObjectiveSecs;
            this.VmwareStandbyResource = vmwareStandbyResource;
        }
        
        /// <summary>
        /// User defined recovery point objective for the standby VM. Using this RPO, Magneto will hydrate the VMs.
        /// </summary>
        /// <value>User defined recovery point objective for the standby VM. Using this RPO, Magneto will hydrate the VMs.</value>
        [DataMember(Name="recoveryPointObjectiveSecs", EmitDefaultValue=true)]
        public long? RecoveryPointObjectiveSecs { get; set; }

        /// <summary>
        /// Gets or Sets VmwareStandbyResource
        /// </summary>
        [DataMember(Name="vmwareStandbyResource", EmitDefaultValue=false)]
        public VMwareStandbyResource VmwareStandbyResource { get; set; }

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
            return this.Equals(input as StandbyResource);
        }

        /// <summary>
        /// Returns true if StandbyResource instances are equal
        /// </summary>
        /// <param name="input">Instance of StandbyResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StandbyResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RecoveryPointObjectiveSecs == input.RecoveryPointObjectiveSecs ||
                    (this.RecoveryPointObjectiveSecs != null &&
                    this.RecoveryPointObjectiveSecs.Equals(input.RecoveryPointObjectiveSecs))
                ) && 
                (
                    this.VmwareStandbyResource == input.VmwareStandbyResource ||
                    (this.VmwareStandbyResource != null &&
                    this.VmwareStandbyResource.Equals(input.VmwareStandbyResource))
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
                if (this.RecoveryPointObjectiveSecs != null)
                    hashCode = hashCode * 59 + this.RecoveryPointObjectiveSecs.GetHashCode();
                if (this.VmwareStandbyResource != null)
                    hashCode = hashCode * 59 + this.VmwareStandbyResource.GetHashCode();
                return hashCode;
            }
        }

    }

}


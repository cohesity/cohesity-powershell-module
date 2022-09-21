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
    /// MountVolumesVMwareParams
    /// </summary>
    [DataContract]
    public partial class MountVolumesVMwareParams :  IEquatable<MountVolumesVMwareParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MountVolumesVMwareParams" /> class.
        /// </summary>
        /// <param name="bringDisksOnline">Optional setting which will determine if the volumes need to be onlined within the target environment after attaching the disks. NOTE: If this is set to true, then target_entity_credentials must be specified and VMware tools must be installed on the VM..</param>
        /// <param name="targetEntityCredentials">targetEntityCredentials.</param>
        public MountVolumesVMwareParams(bool? bringDisksOnline = default(bool?), Credentials targetEntityCredentials = default(Credentials))
        {
            this.BringDisksOnline = bringDisksOnline;
            this.BringDisksOnline = bringDisksOnline;
            this.TargetEntityCredentials = targetEntityCredentials;
        }
        
        /// <summary>
        /// Optional setting which will determine if the volumes need to be onlined within the target environment after attaching the disks. NOTE: If this is set to true, then target_entity_credentials must be specified and VMware tools must be installed on the VM.
        /// </summary>
        /// <value>Optional setting which will determine if the volumes need to be onlined within the target environment after attaching the disks. NOTE: If this is set to true, then target_entity_credentials must be specified and VMware tools must be installed on the VM.</value>
        [DataMember(Name="bringDisksOnline", EmitDefaultValue=true)]
        public bool? BringDisksOnline { get; set; }

        /// <summary>
        /// Gets or Sets TargetEntityCredentials
        /// </summary>
        [DataMember(Name="targetEntityCredentials", EmitDefaultValue=false)]
        public Credentials TargetEntityCredentials { get; set; }

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
            return this.Equals(input as MountVolumesVMwareParams);
        }

        /// <summary>
        /// Returns true if MountVolumesVMwareParams instances are equal
        /// </summary>
        /// <param name="input">Instance of MountVolumesVMwareParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MountVolumesVMwareParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BringDisksOnline == input.BringDisksOnline ||
                    (this.BringDisksOnline != null &&
                    this.BringDisksOnline.Equals(input.BringDisksOnline))
                ) && 
                (
                    this.TargetEntityCredentials == input.TargetEntityCredentials ||
                    (this.TargetEntityCredentials != null &&
                    this.TargetEntityCredentials.Equals(input.TargetEntityCredentials))
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
                if (this.BringDisksOnline != null)
                    hashCode = hashCode * 59 + this.BringDisksOnline.GetHashCode();
                if (this.TargetEntityCredentials != null)
                    hashCode = hashCode * 59 + this.TargetEntityCredentials.GetHashCode();
                return hashCode;
            }
        }

    }

}


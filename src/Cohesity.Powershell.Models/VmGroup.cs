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
    /// VmGroup specifies information of a VM Group.
    /// </summary>
    [DataContract]
    public partial class VmGroup :  IEquatable<VmGroup>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VmGroup" /> class.
        /// </summary>
        /// <param name="name">Specifies name of the VM group..</param>
        /// <param name="vms">Specifies VMs in the group..</param>
        public VmGroup(string name = default(string), List<VmInfo> vms = default(List<VmInfo>))
        {
            this.Name = name;
            this.Vms = vms;
            this.Name = name;
            this.Vms = vms;
        }
        
        /// <summary>
        /// Specifies name of the VM group.
        /// </summary>
        /// <value>Specifies name of the VM group.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies VMs in the group.
        /// </summary>
        /// <value>Specifies VMs in the group.</value>
        [DataMember(Name="vms", EmitDefaultValue=true)]
        public List<VmInfo> Vms { get; set; }

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
            return this.Equals(input as VmGroup);
        }

        /// <summary>
        /// Returns true if VmGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of VmGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VmGroup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Vms == input.Vms ||
                    this.Vms != null &&
                    input.Vms != null &&
                    this.Vms.SequenceEqual(input.Vms)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Vms != null)
                    hashCode = hashCode * 59 + this.Vms.GetHashCode();
                return hashCode;
            }
        }

    }

}


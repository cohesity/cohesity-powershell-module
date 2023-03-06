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
    /// VmwareParams
    /// </summary>
    [DataContract]
    public partial class VmwareParams :  IEquatable<VmwareParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VmwareParams" /> class.
        /// </summary>
        /// <param name="useVmBiosUuid">Specifies to use VM BIOS UUID to track virtual machines in the host..</param>
        public VmwareParams(bool? useVmBiosUuid = default(bool?))
        {
            this.UseVmBiosUuid = useVmBiosUuid;
            this.UseVmBiosUuid = useVmBiosUuid;
        }
        
        /// <summary>
        /// Specifies to use VM BIOS UUID to track virtual machines in the host.
        /// </summary>
        /// <value>Specifies to use VM BIOS UUID to track virtual machines in the host.</value>
        [DataMember(Name="useVmBiosUuid", EmitDefaultValue=true)]
        public bool? UseVmBiosUuid { get; set; }

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
            return this.Equals(input as VmwareParams);
        }

        /// <summary>
        /// Returns true if VmwareParams instances are equal
        /// </summary>
        /// <param name="input">Instance of VmwareParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VmwareParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UseVmBiosUuid == input.UseVmBiosUuid ||
                    (this.UseVmBiosUuid != null &&
                    this.UseVmBiosUuid.Equals(input.UseVmBiosUuid))
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
                if (this.UseVmBiosUuid != null)
                    hashCode = hashCode * 59 + this.UseVmBiosUuid.GetHashCode();
                return hashCode;
            }
        }

    }

}


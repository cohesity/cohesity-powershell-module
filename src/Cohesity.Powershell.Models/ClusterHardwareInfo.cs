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
    /// Specifies a hardware type for motherboard of the Nodes that make up this Cohesity Cluster such as S2600WB for Ivy Bridge or S2600TP for Haswell.
    /// </summary>
    [DataContract]
    public partial class ClusterHardwareInfo :  IEquatable<ClusterHardwareInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterHardwareInfo" /> class.
        /// </summary>
        /// <param name="hardwareModels">hardwareModels.</param>
        /// <param name="hardwareVendors">hardwareVendors.</param>
        public ClusterHardwareInfo(List<string> hardwareModels = default(List<string>), List<string> hardwareVendors = default(List<string>))
        {
            this.HardwareModels = hardwareModels;
            this.HardwareVendors = hardwareVendors;
            this.HardwareModels = hardwareModels;
            this.HardwareVendors = hardwareVendors;
        }
        
        /// <summary>
        /// Gets or Sets HardwareModels
        /// </summary>
        [DataMember(Name="hardwareModels", EmitDefaultValue=true)]
        public List<string> HardwareModels { get; set; }

        /// <summary>
        /// Gets or Sets HardwareVendors
        /// </summary>
        [DataMember(Name="hardwareVendors", EmitDefaultValue=true)]
        public List<string> HardwareVendors { get; set; }

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
            return this.Equals(input as ClusterHardwareInfo);
        }

        /// <summary>
        /// Returns true if ClusterHardwareInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ClusterHardwareInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClusterHardwareInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HardwareModels == input.HardwareModels ||
                    this.HardwareModels != null &&
                    input.HardwareModels != null &&
                    this.HardwareModels.SequenceEqual(input.HardwareModels)
                ) && 
                (
                    this.HardwareVendors == input.HardwareVendors ||
                    this.HardwareVendors != null &&
                    input.HardwareVendors != null &&
                    this.HardwareVendors.SequenceEqual(input.HardwareVendors)
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
                if (this.HardwareModels != null)
                    hashCode = hashCode * 59 + this.HardwareModels.GetHashCode();
                if (this.HardwareVendors != null)
                    hashCode = hashCode * 59 + this.HardwareVendors.GetHashCode();
                return hashCode;
            }
        }

    }

}


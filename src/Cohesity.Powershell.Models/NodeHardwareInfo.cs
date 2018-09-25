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
    /// NodeHardwareInfo
    /// </summary>
    [DataContract]
    public partial class NodeHardwareInfo :  IEquatable<NodeHardwareInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeHardwareInfo" /> class.
        /// </summary>
        /// <param name="cpu">Cpu provides the information regarding the CPU..</param>
        /// <param name="memorySizeBytes">MemorySizeBytes provides the memory size in bytes..</param>
        /// <param name="network">Network provides the information regarding the network cards..</param>
        public NodeHardwareInfo(string cpu = default(string), long? memorySizeBytes = default(long?), string network = default(string))
        {
            this.Cpu = cpu;
            this.MemorySizeBytes = memorySizeBytes;
            this.Network = network;
        }
        
        /// <summary>
        /// Cpu provides the information regarding the CPU.
        /// </summary>
        /// <value>Cpu provides the information regarding the CPU.</value>
        [DataMember(Name="cpu", EmitDefaultValue=false)]
        public string Cpu { get; set; }

        /// <summary>
        /// MemorySizeBytes provides the memory size in bytes.
        /// </summary>
        /// <value>MemorySizeBytes provides the memory size in bytes.</value>
        [DataMember(Name="memorySizeBytes", EmitDefaultValue=false)]
        public long? MemorySizeBytes { get; set; }

        /// <summary>
        /// Network provides the information regarding the network cards.
        /// </summary>
        /// <value>Network provides the information regarding the network cards.</value>
        [DataMember(Name="network", EmitDefaultValue=false)]
        public string Network { get; set; }

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
            return this.Equals(input as NodeHardwareInfo);
        }

        /// <summary>
        /// Returns true if NodeHardwareInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of NodeHardwareInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NodeHardwareInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cpu == input.Cpu ||
                    (this.Cpu != null &&
                    this.Cpu.Equals(input.Cpu))
                ) && 
                (
                    this.MemorySizeBytes == input.MemorySizeBytes ||
                    (this.MemorySizeBytes != null &&
                    this.MemorySizeBytes.Equals(input.MemorySizeBytes))
                ) && 
                (
                    this.Network == input.Network ||
                    (this.Network != null &&
                    this.Network.Equals(input.Network))
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
                if (this.Cpu != null)
                    hashCode = hashCode * 59 + this.Cpu.GetHashCode();
                if (this.MemorySizeBytes != null)
                    hashCode = hashCode * 59 + this.MemorySizeBytes.GetHashCode();
                if (this.Network != null)
                    hashCode = hashCode * 59 + this.Network.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


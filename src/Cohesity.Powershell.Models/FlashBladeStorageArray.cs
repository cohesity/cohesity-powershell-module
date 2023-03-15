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
    /// Specifies information about a Pure Storage FlashBlade Array.
    /// </summary>
    [DataContract]
    public partial class FlashBladeStorageArray :  IEquatable<FlashBladeStorageArray>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlashBladeStorageArray" /> class.
        /// </summary>
        /// <param name="capacityBytes">Specifies the total capacity in bytes of the Pure Storage FlashBlade Array..</param>
        /// <param name="id">Specifies a unique id of a Pure Storage FlashBlade Array. The id is unique across Cohesity Clusters..</param>
        /// <param name="networks">Specifies the network interfaces of the Pure Storage FlashBlade Array..</param>
        /// <param name="physicalUsedBytes">Specifies the space used for physical data in bytes..</param>
        /// <param name="revision">Specifies the revision of the Pure Storage FlashBlade software..</param>
        /// <param name="version">Specifies the software version running on the Pure Storage FlashBlade Array..</param>
        public FlashBladeStorageArray(long? capacityBytes = default(long?), string id = default(string), List<FlashBladeNetworkInterface> networks = default(List<FlashBladeNetworkInterface>), long? physicalUsedBytes = default(long?), string revision = default(string), string version = default(string))
        {
            this.CapacityBytes = capacityBytes;
            this.Id = id;
            this.Networks = networks;
            this.PhysicalUsedBytes = physicalUsedBytes;
            this.Revision = revision;
            this.Version = version;
            this.CapacityBytes = capacityBytes;
            this.Id = id;
            this.Networks = networks;
            this.PhysicalUsedBytes = physicalUsedBytes;
            this.Revision = revision;
            this.Version = version;
        }
        
        /// <summary>
        /// Specifies the total capacity in bytes of the Pure Storage FlashBlade Array.
        /// </summary>
        /// <value>Specifies the total capacity in bytes of the Pure Storage FlashBlade Array.</value>
        [DataMember(Name="capacityBytes", EmitDefaultValue=true)]
        public long? CapacityBytes { get; set; }

        /// <summary>
        /// Specifies a unique id of a Pure Storage FlashBlade Array. The id is unique across Cohesity Clusters.
        /// </summary>
        /// <value>Specifies a unique id of a Pure Storage FlashBlade Array. The id is unique across Cohesity Clusters.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Specifies the network interfaces of the Pure Storage FlashBlade Array.
        /// </summary>
        /// <value>Specifies the network interfaces of the Pure Storage FlashBlade Array.</value>
        [DataMember(Name="networks", EmitDefaultValue=true)]
        public List<FlashBladeNetworkInterface> Networks { get; set; }

        /// <summary>
        /// Specifies the space used for physical data in bytes.
        /// </summary>
        /// <value>Specifies the space used for physical data in bytes.</value>
        [DataMember(Name="physicalUsedBytes", EmitDefaultValue=true)]
        public long? PhysicalUsedBytes { get; set; }

        /// <summary>
        /// Specifies the revision of the Pure Storage FlashBlade software.
        /// </summary>
        /// <value>Specifies the revision of the Pure Storage FlashBlade software.</value>
        [DataMember(Name="revision", EmitDefaultValue=true)]
        public string Revision { get; set; }

        /// <summary>
        /// Specifies the software version running on the Pure Storage FlashBlade Array.
        /// </summary>
        /// <value>Specifies the software version running on the Pure Storage FlashBlade Array.</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public string Version { get; set; }

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
            return this.Equals(input as FlashBladeStorageArray);
        }

        /// <summary>
        /// Returns true if FlashBladeStorageArray instances are equal
        /// </summary>
        /// <param name="input">Instance of FlashBladeStorageArray to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlashBladeStorageArray input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CapacityBytes == input.CapacityBytes ||
                    (this.CapacityBytes != null &&
                    this.CapacityBytes.Equals(input.CapacityBytes))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Networks == input.Networks ||
                    this.Networks != null &&
                    input.Networks != null &&
                    this.Networks.SequenceEqual(input.Networks)
                ) && 
                (
                    this.PhysicalUsedBytes == input.PhysicalUsedBytes ||
                    (this.PhysicalUsedBytes != null &&
                    this.PhysicalUsedBytes.Equals(input.PhysicalUsedBytes))
                ) && 
                (
                    this.Revision == input.Revision ||
                    (this.Revision != null &&
                    this.Revision.Equals(input.Revision))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.CapacityBytes != null)
                    hashCode = hashCode * 59 + this.CapacityBytes.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Networks != null)
                    hashCode = hashCode * 59 + this.Networks.GetHashCode();
                if (this.PhysicalUsedBytes != null)
                    hashCode = hashCode * 59 + this.PhysicalUsedBytes.GetHashCode();
                if (this.Revision != null)
                    hashCode = hashCode * 59 + this.Revision.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}


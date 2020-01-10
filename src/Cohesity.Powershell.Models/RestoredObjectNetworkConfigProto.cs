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
    /// RestoredObjectNetworkConfigProto
    /// </summary>
    [DataContract]
    public partial class RestoredObjectNetworkConfigProto :  IEquatable<RestoredObjectNetworkConfigProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoredObjectNetworkConfigProto" /> class.
        /// </summary>
        /// <param name="detachNetwork">If this is set to true, then the network will be detached from the recovered or cloned VMs. NOTE: If this is set to true, then all the following fields will be ignored..</param>
        /// <param name="disableNetwork">This can be set to true to indicate that the attached network should be left in disabled state..</param>
        /// <param name="mappings">The network mappings to be applied to the target object..</param>
        /// <param name="networkEntity">networkEntity.</param>
        /// <param name="preserveMacAddressOnNewNetwork">If this is true and we are attaching to a new network entity, then the VM&#39;s MAC address will be preserved on the new network..</param>
        /// <param name="vnicEntity">vnicEntity.</param>
        public RestoredObjectNetworkConfigProto(bool? detachNetwork = default(bool?), bool? disableNetwork = default(bool?), List<NetworkMappingProto> mappings = default(List<NetworkMappingProto>), EntityProto networkEntity = default(EntityProto), bool? preserveMacAddressOnNewNetwork = default(bool?), EntityProto vnicEntity = default(EntityProto))
        {
            this.DetachNetwork = detachNetwork;
            this.DisableNetwork = disableNetwork;
            this.Mappings = mappings;
            this.PreserveMacAddressOnNewNetwork = preserveMacAddressOnNewNetwork;
            this.DetachNetwork = detachNetwork;
            this.DisableNetwork = disableNetwork;
            this.Mappings = mappings;
            this.NetworkEntity = networkEntity;
            this.PreserveMacAddressOnNewNetwork = preserveMacAddressOnNewNetwork;
            this.VnicEntity = vnicEntity;
        }
        
        /// <summary>
        /// If this is set to true, then the network will be detached from the recovered or cloned VMs. NOTE: If this is set to true, then all the following fields will be ignored.
        /// </summary>
        /// <value>If this is set to true, then the network will be detached from the recovered or cloned VMs. NOTE: If this is set to true, then all the following fields will be ignored.</value>
        [DataMember(Name="detachNetwork", EmitDefaultValue=true)]
        public bool? DetachNetwork { get; set; }

        /// <summary>
        /// This can be set to true to indicate that the attached network should be left in disabled state.
        /// </summary>
        /// <value>This can be set to true to indicate that the attached network should be left in disabled state.</value>
        [DataMember(Name="disableNetwork", EmitDefaultValue=true)]
        public bool? DisableNetwork { get; set; }

        /// <summary>
        /// The network mappings to be applied to the target object.
        /// </summary>
        /// <value>The network mappings to be applied to the target object.</value>
        [DataMember(Name="mappings", EmitDefaultValue=true)]
        public List<NetworkMappingProto> Mappings { get; set; }

        /// <summary>
        /// Gets or Sets NetworkEntity
        /// </summary>
        [DataMember(Name="networkEntity", EmitDefaultValue=false)]
        public EntityProto NetworkEntity { get; set; }

        /// <summary>
        /// If this is true and we are attaching to a new network entity, then the VM&#39;s MAC address will be preserved on the new network.
        /// </summary>
        /// <value>If this is true and we are attaching to a new network entity, then the VM&#39;s MAC address will be preserved on the new network.</value>
        [DataMember(Name="preserveMacAddressOnNewNetwork", EmitDefaultValue=true)]
        public bool? PreserveMacAddressOnNewNetwork { get; set; }

        /// <summary>
        /// Gets or Sets VnicEntity
        /// </summary>
        [DataMember(Name="vnicEntity", EmitDefaultValue=false)]
        public EntityProto VnicEntity { get; set; }

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
            return this.Equals(input as RestoredObjectNetworkConfigProto);
        }

        /// <summary>
        /// Returns true if RestoredObjectNetworkConfigProto instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoredObjectNetworkConfigProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoredObjectNetworkConfigProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DetachNetwork == input.DetachNetwork ||
                    (this.DetachNetwork != null &&
                    this.DetachNetwork.Equals(input.DetachNetwork))
                ) && 
                (
                    this.DisableNetwork == input.DisableNetwork ||
                    (this.DisableNetwork != null &&
                    this.DisableNetwork.Equals(input.DisableNetwork))
                ) && 
                (
                    this.Mappings == input.Mappings ||
                    this.Mappings != null &&
                    input.Mappings != null &&
                    this.Mappings.SequenceEqual(input.Mappings)
                ) && 
                (
                    this.NetworkEntity == input.NetworkEntity ||
                    (this.NetworkEntity != null &&
                    this.NetworkEntity.Equals(input.NetworkEntity))
                ) && 
                (
                    this.PreserveMacAddressOnNewNetwork == input.PreserveMacAddressOnNewNetwork ||
                    (this.PreserveMacAddressOnNewNetwork != null &&
                    this.PreserveMacAddressOnNewNetwork.Equals(input.PreserveMacAddressOnNewNetwork))
                ) && 
                (
                    this.VnicEntity == input.VnicEntity ||
                    (this.VnicEntity != null &&
                    this.VnicEntity.Equals(input.VnicEntity))
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
                if (this.DetachNetwork != null)
                    hashCode = hashCode * 59 + this.DetachNetwork.GetHashCode();
                if (this.DisableNetwork != null)
                    hashCode = hashCode * 59 + this.DisableNetwork.GetHashCode();
                if (this.Mappings != null)
                    hashCode = hashCode * 59 + this.Mappings.GetHashCode();
                if (this.NetworkEntity != null)
                    hashCode = hashCode * 59 + this.NetworkEntity.GetHashCode();
                if (this.PreserveMacAddressOnNewNetwork != null)
                    hashCode = hashCode * 59 + this.PreserveMacAddressOnNewNetwork.GetHashCode();
                if (this.VnicEntity != null)
                    hashCode = hashCode * 59 + this.VnicEntity.GetHashCode();
                return hashCode;
            }
        }

    }

}


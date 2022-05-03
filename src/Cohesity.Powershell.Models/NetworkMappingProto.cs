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
    /// NetworkMappingProto
    /// </summary>
    [DataContract]
    public partial class NetworkMappingProto :  IEquatable<NetworkMappingProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkMappingProto" /> class.
        /// </summary>
        /// <param name="disableNetwork">This can be set to true to indicate that the attached network should be left in disabled state. This value takes priority over the value in RestoredObjectNetworkConfigProto..</param>
        /// <param name="preserveMacAddressOnNewNetwork">VM&#39;s MAC address will be preserved on the new network. This value takes priority over the value in RestoredObjectNetworkConfigProto..</param>
        /// <param name="sourceNetworkEntity">sourceNetworkEntity.</param>
        /// <param name="targetNetworkEntity">targetNetworkEntity.</param>
        public NetworkMappingProto(bool? disableNetwork = default(bool?), bool? preserveMacAddressOnNewNetwork = default(bool?), EntityProto sourceNetworkEntity = default(EntityProto), EntityProto targetNetworkEntity = default(EntityProto))
        {
            this.DisableNetwork = disableNetwork;
            this.PreserveMacAddressOnNewNetwork = preserveMacAddressOnNewNetwork;
            this.SourceNetworkEntity = sourceNetworkEntity;
            this.TargetNetworkEntity = targetNetworkEntity;
        }
        
        /// <summary>
        /// This can be set to true to indicate that the attached network should be left in disabled state. This value takes priority over the value in RestoredObjectNetworkConfigProto.
        /// </summary>
        /// <value>This can be set to true to indicate that the attached network should be left in disabled state. This value takes priority over the value in RestoredObjectNetworkConfigProto.</value>
        [DataMember(Name="disableNetwork", EmitDefaultValue=false)]
        public bool? DisableNetwork { get; set; }

        /// <summary>
        /// VM&#39;s MAC address will be preserved on the new network. This value takes priority over the value in RestoredObjectNetworkConfigProto.
        /// </summary>
        /// <value>VM&#39;s MAC address will be preserved on the new network. This value takes priority over the value in RestoredObjectNetworkConfigProto.</value>
        [DataMember(Name="preserveMacAddressOnNewNetwork", EmitDefaultValue=false)]
        public bool? PreserveMacAddressOnNewNetwork { get; set; }

        /// <summary>
        /// Gets or Sets SourceNetworkEntity
        /// </summary>
        [DataMember(Name="sourceNetworkEntity", EmitDefaultValue=false)]
        public EntityProto SourceNetworkEntity { get; set; }

        /// <summary>
        /// Gets or Sets TargetNetworkEntity
        /// </summary>
        [DataMember(Name="targetNetworkEntity", EmitDefaultValue=false)]
        public EntityProto TargetNetworkEntity { get; set; }

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
            return this.Equals(input as NetworkMappingProto);
        }

        /// <summary>
        /// Returns true if NetworkMappingProto instances are equal
        /// </summary>
        /// <param name="input">Instance of NetworkMappingProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetworkMappingProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisableNetwork == input.DisableNetwork ||
                    (this.DisableNetwork != null &&
                    this.DisableNetwork.Equals(input.DisableNetwork))
                ) && 
                (
                    this.PreserveMacAddressOnNewNetwork == input.PreserveMacAddressOnNewNetwork ||
                    (this.PreserveMacAddressOnNewNetwork != null &&
                    this.PreserveMacAddressOnNewNetwork.Equals(input.PreserveMacAddressOnNewNetwork))
                ) && 
                (
                    this.SourceNetworkEntity == input.SourceNetworkEntity ||
                    (this.SourceNetworkEntity != null &&
                    this.SourceNetworkEntity.Equals(input.SourceNetworkEntity))
                ) && 
                (
                    this.TargetNetworkEntity == input.TargetNetworkEntity ||
                    (this.TargetNetworkEntity != null &&
                    this.TargetNetworkEntity.Equals(input.TargetNetworkEntity))
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
                if (this.DisableNetwork != null)
                    hashCode = hashCode * 59 + this.DisableNetwork.GetHashCode();
                if (this.PreserveMacAddressOnNewNetwork != null)
                    hashCode = hashCode * 59 + this.PreserveMacAddressOnNewNetwork.GetHashCode();
                if (this.SourceNetworkEntity != null)
                    hashCode = hashCode * 59 + this.SourceNetworkEntity.GetHashCode();
                if (this.TargetNetworkEntity != null)
                    hashCode = hashCode * 59 + this.TargetNetworkEntity.GetHashCode();
                return hashCode;
            }
        }

    }

}


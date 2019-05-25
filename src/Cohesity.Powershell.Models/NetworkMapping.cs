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
    /// Specifies the information needed when mapping the source networks to target networks during restore and clone actions.
    /// </summary>
    [DataContract]
    public partial class NetworkMapping :  IEquatable<NetworkMapping>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkMapping" /> class.
        /// </summary>
        /// <param name="disableNetwork">Specifies if the network should be disabled. On restore or clone of the VM, if the network should be kept in disabled state, set this flag to true. The mapped network is enabled by default..</param>
        /// <param name="preserveMacAddress">Specifies if the source mac address should be preserved after restore or clone. In case of collision of mac address on target network the job won&#39;t fail. Address collision should be resolved manually..</param>
        /// <param name="sourceNetworkId">Specifies the id of the source network..</param>
        /// <param name="targetNetworkId">Specifies the id of target network..</param>
        public NetworkMapping(bool? disableNetwork = default(bool?), bool? preserveMacAddress = default(bool?), long? sourceNetworkId = default(long?), long? targetNetworkId = default(long?))
        {
            this.DisableNetwork = disableNetwork;
            this.PreserveMacAddress = preserveMacAddress;
            this.SourceNetworkId = sourceNetworkId;
            this.TargetNetworkId = targetNetworkId;
            this.DisableNetwork = disableNetwork;
            this.PreserveMacAddress = preserveMacAddress;
            this.SourceNetworkId = sourceNetworkId;
            this.TargetNetworkId = targetNetworkId;
        }
        
        /// <summary>
        /// Specifies if the network should be disabled. On restore or clone of the VM, if the network should be kept in disabled state, set this flag to true. The mapped network is enabled by default.
        /// </summary>
        /// <value>Specifies if the network should be disabled. On restore or clone of the VM, if the network should be kept in disabled state, set this flag to true. The mapped network is enabled by default.</value>
        [DataMember(Name="disableNetwork", EmitDefaultValue=true)]
        public bool? DisableNetwork { get; set; }

        /// <summary>
        /// Specifies if the source mac address should be preserved after restore or clone. In case of collision of mac address on target network the job won&#39;t fail. Address collision should be resolved manually.
        /// </summary>
        /// <value>Specifies if the source mac address should be preserved after restore or clone. In case of collision of mac address on target network the job won&#39;t fail. Address collision should be resolved manually.</value>
        [DataMember(Name="preserveMacAddress", EmitDefaultValue=true)]
        public bool? PreserveMacAddress { get; set; }

        /// <summary>
        /// Specifies the id of the source network.
        /// </summary>
        /// <value>Specifies the id of the source network.</value>
        [DataMember(Name="sourceNetworkId", EmitDefaultValue=true)]
        public long? SourceNetworkId { get; set; }

        /// <summary>
        /// Specifies the id of target network.
        /// </summary>
        /// <value>Specifies the id of target network.</value>
        [DataMember(Name="targetNetworkId", EmitDefaultValue=true)]
        public long? TargetNetworkId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NetworkMapping {\n");
            sb.Append("  DisableNetwork: ").Append(DisableNetwork).Append("\n");
            sb.Append("  PreserveMacAddress: ").Append(PreserveMacAddress).Append("\n");
            sb.Append("  SourceNetworkId: ").Append(SourceNetworkId).Append("\n");
            sb.Append("  TargetNetworkId: ").Append(TargetNetworkId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
            return this.Equals(input as NetworkMapping);
        }

        /// <summary>
        /// Returns true if NetworkMapping instances are equal
        /// </summary>
        /// <param name="input">Instance of NetworkMapping to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetworkMapping input)
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
                    this.PreserveMacAddress == input.PreserveMacAddress ||
                    (this.PreserveMacAddress != null &&
                    this.PreserveMacAddress.Equals(input.PreserveMacAddress))
                ) && 
                (
                    this.SourceNetworkId == input.SourceNetworkId ||
                    (this.SourceNetworkId != null &&
                    this.SourceNetworkId.Equals(input.SourceNetworkId))
                ) && 
                (
                    this.TargetNetworkId == input.TargetNetworkId ||
                    (this.TargetNetworkId != null &&
                    this.TargetNetworkId.Equals(input.TargetNetworkId))
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
                if (this.PreserveMacAddress != null)
                    hashCode = hashCode * 59 + this.PreserveMacAddress.GetHashCode();
                if (this.SourceNetworkId != null)
                    hashCode = hashCode * 59 + this.SourceNetworkId.GetHashCode();
                if (this.TargetNetworkId != null)
                    hashCode = hashCode * 59 + this.TargetNetworkId.GetHashCode();
                return hashCode;
            }
        }

    }

}

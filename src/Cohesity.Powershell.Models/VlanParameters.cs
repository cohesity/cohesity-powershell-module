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
    /// VlanParameters
    /// </summary>
    [DataContract]
    public partial class VlanParameters :  IEquatable<VlanParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VlanParameters" /> class.
        /// </summary>
        /// <param name="disableVlan">Specifies whether to use the VIPs even when VLANs are configured on the Cluster. If configured, VLAN IP addresses are used by default. If VLANs are not configured, this flag is ignored. Set this flag to true to force using the partition VIPs when VLANs are configured on the Cluster..</param>
        /// <param name="vlan">Specifies the VLAN to use for mounting Cohesity&#39;s view on the remote host. If specified, Cohesity hostname or the IP address on this VLAN is used..</param>
        public VlanParameters(bool? disableVlan = default(bool?), int? vlan = default(int?))
        {
            this.DisableVlan = disableVlan;
            this.Vlan = vlan;
        }
        
        /// <summary>
        /// Specifies whether to use the VIPs even when VLANs are configured on the Cluster. If configured, VLAN IP addresses are used by default. If VLANs are not configured, this flag is ignored. Set this flag to true to force using the partition VIPs when VLANs are configured on the Cluster.
        /// </summary>
        /// <value>Specifies whether to use the VIPs even when VLANs are configured on the Cluster. If configured, VLAN IP addresses are used by default. If VLANs are not configured, this flag is ignored. Set this flag to true to force using the partition VIPs when VLANs are configured on the Cluster.</value>
        [DataMember(Name="disableVlan", EmitDefaultValue=false)]
        public bool? DisableVlan { get; set; }

        /// <summary>
        /// Specifies the VLAN to use for mounting Cohesity&#39;s view on the remote host. If specified, Cohesity hostname or the IP address on this VLAN is used.
        /// </summary>
        /// <value>Specifies the VLAN to use for mounting Cohesity&#39;s view on the remote host. If specified, Cohesity hostname or the IP address on this VLAN is used.</value>
        [DataMember(Name="vlan", EmitDefaultValue=false)]
        public int? Vlan { get; set; }

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
            return this.Equals(input as VlanParameters);
        }

        /// <summary>
        /// Returns true if VlanParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of VlanParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VlanParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisableVlan == input.DisableVlan ||
                    (this.DisableVlan != null &&
                    this.DisableVlan.Equals(input.DisableVlan))
                ) && 
                (
                    this.Vlan == input.Vlan ||
                    (this.Vlan != null &&
                    this.Vlan.Equals(input.Vlan))
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
                if (this.DisableVlan != null)
                    hashCode = hashCode * 59 + this.DisableVlan.GetHashCode();
                if (this.Vlan != null)
                    hashCode = hashCode * 59 + this.Vlan.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


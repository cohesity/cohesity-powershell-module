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
    /// VlanParams
    /// </summary>
    [DataContract]
    public partial class VlanParams :  IEquatable<VlanParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VlanParams" /> class.
        /// </summary>
        /// <param name="disableVlan">If this is set to true, then even if VLANs are configured on the system, the partition VIPs will be used for the restore..</param>
        /// <param name="interfaceName">Interface group to use for restore. If this is not specified, primary interface group for the cluster will be used..</param>
        /// <param name="vlanId">If this is set, then the Cohesity host name or the IP address associated with this vlan is used for mounting Cohesity&#39;s view on the remote host..</param>
        public VlanParams(bool? disableVlan = default(bool?), string interfaceName = default(string), int? vlanId = default(int?))
        {
            this.DisableVlan = disableVlan;
            this.InterfaceName = interfaceName;
            this.VlanId = vlanId;
            this.DisableVlan = disableVlan;
            this.InterfaceName = interfaceName;
            this.VlanId = vlanId;
        }
        
        /// <summary>
        /// If this is set to true, then even if VLANs are configured on the system, the partition VIPs will be used for the restore.
        /// </summary>
        /// <value>If this is set to true, then even if VLANs are configured on the system, the partition VIPs will be used for the restore.</value>
        [DataMember(Name="disableVlan", EmitDefaultValue=true)]
        public bool? DisableVlan { get; set; }

        /// <summary>
        /// Interface group to use for restore. If this is not specified, primary interface group for the cluster will be used.
        /// </summary>
        /// <value>Interface group to use for restore. If this is not specified, primary interface group for the cluster will be used.</value>
        [DataMember(Name="interfaceName", EmitDefaultValue=true)]
        public string InterfaceName { get; set; }

        /// <summary>
        /// If this is set, then the Cohesity host name or the IP address associated with this vlan is used for mounting Cohesity&#39;s view on the remote host.
        /// </summary>
        /// <value>If this is set, then the Cohesity host name or the IP address associated with this vlan is used for mounting Cohesity&#39;s view on the remote host.</value>
        [DataMember(Name="vlanId", EmitDefaultValue=true)]
        public int? VlanId { get; set; }

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
            return this.Equals(input as VlanParams);
        }

        /// <summary>
        /// Returns true if VlanParams instances are equal
        /// </summary>
        /// <param name="input">Instance of VlanParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VlanParams input)
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
                    this.InterfaceName == input.InterfaceName ||
                    (this.InterfaceName != null &&
                    this.InterfaceName.Equals(input.InterfaceName))
                ) && 
                (
                    this.VlanId == input.VlanId ||
                    (this.VlanId != null &&
                    this.VlanId.Equals(input.VlanId))
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
                if (this.InterfaceName != null)
                    hashCode = hashCode * 59 + this.InterfaceName.GetHashCode();
                if (this.VlanId != null)
                    hashCode = hashCode * 59 + this.VlanId.GetHashCode();
                return hashCode;
            }
        }

    }

}


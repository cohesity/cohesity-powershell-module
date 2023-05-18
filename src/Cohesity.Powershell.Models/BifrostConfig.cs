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
    /// Specifies the settings of a BifrostConfig. Its used by both Request and Response structures.
    /// </summary>
    [DataContract]
    public partial class BifrostConfig :  IEquatable<BifrostConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BifrostConfig" /> class.
        /// </summary>
        /// <param name="imageVersion">Specifies the bifrost image version..</param>
        /// <param name="cpu">Specifies the cpu for the bifrost config..</param>
        /// <param name="description">Specifies a description of the VLAN..</param>
        /// <param name="id">Specifies the id of the VLAN tag..</param>
        /// <param name="ifaceGroupName">Specifies the interface group name of the VLAN. It is in the format of &lt;base_interface_group_name&gt;.&lt;vlan_id&gt;..</param>
        /// <param name="memory">Specifies the memory for the bifrost config..</param>
        /// <param name="mtu">Specifies the mtu for the bifrost vlan..</param>
        /// <param name="state">4 types of States UNKNOWN ACTIVE DISABLED DELETING.</param>
        /// <param name="subnet">Specifies the subnet of the VLAN. The netmask can be specified by setting netmaskBits or netmaskIp4. The netmask can only be set using netmaskIp4 if the IP address is an IPv4 address. It can carry V4 or V6 in case of requests, and carries V4 in case of response..</param>
        /// <param name="tenantId">Specifies the tenant id that this vlan belongs to..</param>
        /// <param name="type">Two types of bifrost vlans. INTERNAL EXTERNAL.</param>
        /// <param name="vlanName">Specifies the VLAN name of the vlanId..</param>
        public BifrostConfig(string imageVersion = default(string), int? cpu = default(int?), string description = default(string), int? id = default(int?), string ifaceGroupName = default(string), int? memory = default(int?), int? mtu = default(int?), string state = default(string), BifrostSubnet subnet = default(BifrostSubnet), string tenantId = default(string), string type = default(string), string vlanName = default(string))
        {
            this.ImageVersion = imageVersion;
            this.Cpu = cpu;
            this.Description = description;
            this.Id = id;
            this.IfaceGroupName = ifaceGroupName;
            this.Memory = memory;
            this.Mtu = mtu;
            this.State = state;
            this.Subnet = subnet;
            this.TenantId = tenantId;
            this.Type = type;
            this.VlanName = vlanName;
            this.ImageVersion = imageVersion;
            this.Cpu = cpu;
            this.Description = description;
            this.Id = id;
            this.IfaceGroupName = ifaceGroupName;
            this.Memory = memory;
            this.Mtu = mtu;
            this.State = state;
            this.Subnet = subnet;
            this.TenantId = tenantId;
            this.Type = type;
            this.VlanName = vlanName;
        }
        
        /// <summary>
        /// Specifies the bifrost image version.
        /// </summary>
        /// <value>Specifies the bifrost image version.</value>
        [DataMember(Name="ImageVersion", EmitDefaultValue=true)]
        public string ImageVersion { get; set; }

        /// <summary>
        /// Specifies the cpu for the bifrost config.
        /// </summary>
        /// <value>Specifies the cpu for the bifrost config.</value>
        [DataMember(Name="cpu", EmitDefaultValue=true)]
        public int? Cpu { get; set; }

        /// <summary>
        /// Specifies a description of the VLAN.
        /// </summary>
        /// <value>Specifies a description of the VLAN.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies the id of the VLAN tag.
        /// </summary>
        /// <value>Specifies the id of the VLAN tag.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public int? Id { get; set; }

        /// <summary>
        /// Specifies the interface group name of the VLAN. It is in the format of &lt;base_interface_group_name&gt;.&lt;vlan_id&gt;.
        /// </summary>
        /// <value>Specifies the interface group name of the VLAN. It is in the format of &lt;base_interface_group_name&gt;.&lt;vlan_id&gt;.</value>
        [DataMember(Name="ifaceGroupName", EmitDefaultValue=true)]
        public string IfaceGroupName { get; set; }

        /// <summary>
        /// Specifies the memory for the bifrost config.
        /// </summary>
        /// <value>Specifies the memory for the bifrost config.</value>
        [DataMember(Name="memory", EmitDefaultValue=true)]
        public int? Memory { get; set; }

        /// <summary>
        /// Specifies the mtu for the bifrost vlan.
        /// </summary>
        /// <value>Specifies the mtu for the bifrost vlan.</value>
        [DataMember(Name="mtu", EmitDefaultValue=true)]
        public int? Mtu { get; set; }

        /// <summary>
        /// 4 types of States UNKNOWN ACTIVE DISABLED DELETING
        /// </summary>
        /// <value>4 types of States UNKNOWN ACTIVE DISABLED DELETING</value>
        [DataMember(Name="state", EmitDefaultValue=true)]
        public string State { get; set; }

        /// <summary>
        /// Specifies the subnet of the VLAN. The netmask can be specified by setting netmaskBits or netmaskIp4. The netmask can only be set using netmaskIp4 if the IP address is an IPv4 address. It can carry V4 or V6 in case of requests, and carries V4 in case of response.
        /// </summary>
        /// <value>Specifies the subnet of the VLAN. The netmask can be specified by setting netmaskBits or netmaskIp4. The netmask can only be set using netmaskIp4 if the IP address is an IPv4 address. It can carry V4 or V6 in case of requests, and carries V4 in case of response.</value>
        [DataMember(Name="subnet", EmitDefaultValue=true)]
        public BifrostSubnet Subnet { get; set; }

        /// <summary>
        /// Specifies the tenant id that this vlan belongs to.
        /// </summary>
        /// <value>Specifies the tenant id that this vlan belongs to.</value>
        [DataMember(Name="tenantId", EmitDefaultValue=true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Two types of bifrost vlans. INTERNAL EXTERNAL
        /// </summary>
        /// <value>Two types of bifrost vlans. INTERNAL EXTERNAL</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public string Type { get; set; }

        /// <summary>
        /// Specifies the VLAN name of the vlanId.
        /// </summary>
        /// <value>Specifies the VLAN name of the vlanId.</value>
        [DataMember(Name="vlanName", EmitDefaultValue=true)]
        public string VlanName { get; set; }

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
            return this.Equals(input as BifrostConfig);
        }

        /// <summary>
        /// Returns true if BifrostConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of BifrostConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BifrostConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ImageVersion == input.ImageVersion ||
                    (this.ImageVersion != null &&
                    this.ImageVersion.Equals(input.ImageVersion))
                ) && 
                (
                    this.Cpu == input.Cpu ||
                    (this.Cpu != null &&
                    this.Cpu.Equals(input.Cpu))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IfaceGroupName == input.IfaceGroupName ||
                    (this.IfaceGroupName != null &&
                    this.IfaceGroupName.Equals(input.IfaceGroupName))
                ) && 
                (
                    this.Memory == input.Memory ||
                    (this.Memory != null &&
                    this.Memory.Equals(input.Memory))
                ) && 
                (
                    this.Mtu == input.Mtu ||
                    (this.Mtu != null &&
                    this.Mtu.Equals(input.Mtu))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Subnet == input.Subnet ||
                    (this.Subnet != null &&
                    this.Subnet.Equals(input.Subnet))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.VlanName == input.VlanName ||
                    (this.VlanName != null &&
                    this.VlanName.Equals(input.VlanName))
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
                if (this.ImageVersion != null)
                    hashCode = hashCode * 59 + this.ImageVersion.GetHashCode();
                if (this.Cpu != null)
                    hashCode = hashCode * 59 + this.Cpu.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IfaceGroupName != null)
                    hashCode = hashCode * 59 + this.IfaceGroupName.GetHashCode();
                if (this.Memory != null)
                    hashCode = hashCode * 59 + this.Memory.GetHashCode();
                if (this.Mtu != null)
                    hashCode = hashCode * 59 + this.Mtu.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Subnet != null)
                    hashCode = hashCode * 59 + this.Subnet.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.VlanName != null)
                    hashCode = hashCode * 59 + this.VlanName.GetHashCode();
                return hashCode;
            }
        }

    }

}


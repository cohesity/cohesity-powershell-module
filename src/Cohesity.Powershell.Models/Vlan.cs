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
    /// Specifies the settings of a VLAN.
    /// </summary>
    [DataContract]
    public partial class Vlan :  IEquatable<Vlan>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Vlan" /> class.
        /// </summary>
        /// <param name="addToClusterPartition">Specifies whether to add the VLAN IPs to the cluster partition that already has one or more IPs from this VLAN..</param>
        /// <param name="description">Specifies a description of the VLAN..</param>
        /// <param name="gateway">Specifies the Gateway of the VLAN..</param>
        /// <param name="hostname">Specifies the hostname of the VLAN..</param>
        /// <param name="id">Specifies the id of the VLAN..</param>
        /// <param name="ifaceGroupName">Specifies the interface group name of the VLAN. It is in the format of &lt;base_interface_group_name&gt;.&lt;vlan_id&gt;..</param>
        /// <param name="interfaceName">Specifies the interface name of the VLAN..</param>
        /// <param name="ips">Array of IPs.  Specifies a list of IPs in the VLAN..</param>
        /// <param name="subnet">Specifies the subnet of the VLAN. The netmask can be specified by setting netmaskBits or netmaskIp4. The netmask can only be set using netmaskIp4 if the IP address is an IPv4 address..</param>
        /// <param name="tenantId">Optional tenant id that this vlan belongs to..</param>
        /// <param name="vlanName">Specifies the VLAN name of the vlanId..</param>
        public Vlan(bool? addToClusterPartition = default(bool?), string description = default(string), string gateway = default(string), string hostname = default(string), int? id = default(int?), string ifaceGroupName = default(string), string interfaceName = default(string), List<string> ips = default(List<string>), Subnet subnet = default(Subnet), string tenantId = default(string), string vlanName = default(string))
        {
            this.AddToClusterPartition = addToClusterPartition;
            this.Description = description;
            this.Gateway = gateway;
            this.Hostname = hostname;
            this.Id = id;
            this.IfaceGroupName = ifaceGroupName;
            this.InterfaceName = interfaceName;
            this.Ips = ips;
            this.Subnet = subnet;
            this.TenantId = tenantId;
            this.VlanName = vlanName;
            this.AddToClusterPartition = addToClusterPartition;
            this.Description = description;
            this.Gateway = gateway;
            this.Hostname = hostname;
            this.Id = id;
            this.IfaceGroupName = ifaceGroupName;
            this.InterfaceName = interfaceName;
            this.Ips = ips;
            this.Subnet = subnet;
            this.TenantId = tenantId;
            this.VlanName = vlanName;
        }
        
        /// <summary>
        /// Specifies whether to add the VLAN IPs to the cluster partition that already has one or more IPs from this VLAN.
        /// </summary>
        /// <value>Specifies whether to add the VLAN IPs to the cluster partition that already has one or more IPs from this VLAN.</value>
        [DataMember(Name="addToClusterPartition", EmitDefaultValue=true)]
        public bool? AddToClusterPartition { get; set; }

        /// <summary>
        /// Specifies a description of the VLAN.
        /// </summary>
        /// <value>Specifies a description of the VLAN.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies the Gateway of the VLAN.
        /// </summary>
        /// <value>Specifies the Gateway of the VLAN.</value>
        [DataMember(Name="gateway", EmitDefaultValue=true)]
        public string Gateway { get; set; }

        /// <summary>
        /// Specifies the hostname of the VLAN.
        /// </summary>
        /// <value>Specifies the hostname of the VLAN.</value>
        [DataMember(Name="hostname", EmitDefaultValue=true)]
        public string Hostname { get; set; }

        /// <summary>
        /// Specifies the id of the VLAN.
        /// </summary>
        /// <value>Specifies the id of the VLAN.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public int? Id { get; set; }

        /// <summary>
        /// Specifies the interface group name of the VLAN. It is in the format of &lt;base_interface_group_name&gt;.&lt;vlan_id&gt;.
        /// </summary>
        /// <value>Specifies the interface group name of the VLAN. It is in the format of &lt;base_interface_group_name&gt;.&lt;vlan_id&gt;.</value>
        [DataMember(Name="ifaceGroupName", EmitDefaultValue=true)]
        public string IfaceGroupName { get; set; }

        /// <summary>
        /// Specifies the interface name of the VLAN.
        /// </summary>
        /// <value>Specifies the interface name of the VLAN.</value>
        [DataMember(Name="interfaceName", EmitDefaultValue=true)]
        public string InterfaceName { get; set; }

        /// <summary>
        /// Array of IPs.  Specifies a list of IPs in the VLAN.
        /// </summary>
        /// <value>Array of IPs.  Specifies a list of IPs in the VLAN.</value>
        [DataMember(Name="ips", EmitDefaultValue=true)]
        public List<string> Ips { get; set; }

        /// <summary>
        /// Specifies the subnet of the VLAN. The netmask can be specified by setting netmaskBits or netmaskIp4. The netmask can only be set using netmaskIp4 if the IP address is an IPv4 address.
        /// </summary>
        /// <value>Specifies the subnet of the VLAN. The netmask can be specified by setting netmaskBits or netmaskIp4. The netmask can only be set using netmaskIp4 if the IP address is an IPv4 address.</value>
        [DataMember(Name="subnet", EmitDefaultValue=true)]
        public Subnet Subnet { get; set; }

        /// <summary>
        /// Optional tenant id that this vlan belongs to.
        /// </summary>
        /// <value>Optional tenant id that this vlan belongs to.</value>
        [DataMember(Name="tenantId", EmitDefaultValue=true)]
        public string TenantId { get; set; }

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
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Vlan {\n");
            sb.Append("  AddToClusterPartition: ").Append(AddToClusterPartition).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Gateway: ").Append(Gateway).Append("\n");
            sb.Append("  Hostname: ").Append(Hostname).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IfaceGroupName: ").Append(IfaceGroupName).Append("\n");
            sb.Append("  InterfaceName: ").Append(InterfaceName).Append("\n");
            sb.Append("  Ips: ").Append(Ips).Append("\n");
            sb.Append("  Subnet: ").Append(Subnet).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  VlanName: ").Append(VlanName).Append("\n");
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
            return this.Equals(input as Vlan);
        }

        /// <summary>
        /// Returns true if Vlan instances are equal
        /// </summary>
        /// <param name="input">Instance of Vlan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Vlan input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddToClusterPartition == input.AddToClusterPartition ||
                    (this.AddToClusterPartition != null &&
                    this.AddToClusterPartition.Equals(input.AddToClusterPartition))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Gateway == input.Gateway ||
                    (this.Gateway != null &&
                    this.Gateway.Equals(input.Gateway))
                ) && 
                (
                    this.Hostname == input.Hostname ||
                    (this.Hostname != null &&
                    this.Hostname.Equals(input.Hostname))
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
                    this.InterfaceName == input.InterfaceName ||
                    (this.InterfaceName != null &&
                    this.InterfaceName.Equals(input.InterfaceName))
                ) && 
                (
                    this.Ips == input.Ips ||
                    this.Ips != null &&
                    input.Ips != null &&
                    this.Ips.SequenceEqual(input.Ips)
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
                if (this.AddToClusterPartition != null)
                    hashCode = hashCode * 59 + this.AddToClusterPartition.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Gateway != null)
                    hashCode = hashCode * 59 + this.Gateway.GetHashCode();
                if (this.Hostname != null)
                    hashCode = hashCode * 59 + this.Hostname.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IfaceGroupName != null)
                    hashCode = hashCode * 59 + this.IfaceGroupName.GetHashCode();
                if (this.InterfaceName != null)
                    hashCode = hashCode * 59 + this.InterfaceName.GetHashCode();
                if (this.Ips != null)
                    hashCode = hashCode * 59 + this.Ips.GetHashCode();
                if (this.Subnet != null)
                    hashCode = hashCode * 59 + this.Subnet.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.VlanName != null)
                    hashCode = hashCode * 59 + this.VlanName.GetHashCode();
                return hashCode;
            }
        }

    }

}

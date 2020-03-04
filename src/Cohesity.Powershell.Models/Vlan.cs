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
    /// Specifies the settings of a VLAN. Its used by both Request and Response structures.
    /// </summary>
    [DataContract]
    public partial class Vlan :  IEquatable<Vlan>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Vlan" /> class.
        /// </summary>
        /// <param name="addToClusterPartition">Specifies whether to add the VLAN IPs to the cluster partition that already has one or more IPs from this VLAN..</param>
        /// <param name="allTenantAccess">Specifies if this VLAN can be used by all tenants without explicit assignment to them. This option can only be set true for VLANs that are not assigned to any tenant..</param>
        /// <param name="appsips">Array of Athena Apps IPs.  Specifies a list of Athena IPs in the VLAN..</param>
        /// <param name="description">Specifies a description of the VLAN..</param>
        /// <param name="gateway">Specifies the Gateway of the VLAN. It can carry V4 or V6 in case of requests, and carrises V4 in case of response..</param>
        /// <param name="gatewayV6">Specifies the Gateway of the VLAN..</param>
        /// <param name="hostname">Specifies the hostname of the VLAN..</param>
        /// <param name="id">Specifies the id of the VLAN..</param>
        /// <param name="ifaceGroupName">Specifies the interface group name of the VLAN. It is in the format of &lt;base_interface_group_name&gt;.&lt;vlan_id&gt;..</param>
        /// <param name="interfaceName">Specifies the interface name of the VLAN..</param>
        /// <param name="ipFamily">Specifies IP family. Based on this, subnet/gateway field contains V4 or V6 values. Used in Request..</param>
        /// <param name="ipRange">ipRange.</param>
        /// <param name="ips">Array of IPs.  Specifies a list of IPs in the VLAN..</param>
        /// <param name="mtu">mtu.</param>
        /// <param name="subnet">Specifies the subnet of the VLAN. The netmask can be specified by setting netmaskBits or netmaskIp4. The netmask can only be set using netmaskIp4 if the IP address is an IPv4 address. It can carry V4 or V6 in case of requests, and carries V4 in case of response..</param>
        /// <param name="subnetV6">Specifies the subnet of the VLAN. The netmask can be specified by setting netmaskBits or netmaskIp4. The netmask can only be set using netmaskIp4 if the IP address is an IPv4 address..</param>
        /// <param name="tenantId">Optional tenant id that this vlan belongs to..</param>
        /// <param name="vlanName">Specifies the VLAN name of the vlanId..</param>
        public Vlan(bool? addToClusterPartition = default(bool?), bool? allTenantAccess = default(bool?), List<string> appsips = default(List<string>), string description = default(string), string gateway = default(string), string gatewayV6 = default(string), string hostname = default(string), int? id = default(int?), string ifaceGroupName = default(string), string interfaceName = default(string), int? ipFamily = default(int?), IpRange ipRange = default(IpRange), List<string> ips = default(List<string>), int? mtu = default(int?), Subnet subnet = default(Subnet), Subnet subnetV6 = default(Subnet), string tenantId = default(string), string vlanName = default(string))
        {
            this.AddToClusterPartition = addToClusterPartition;
            this.AllTenantAccess = allTenantAccess;
            this.Appsips = appsips;
            this.Description = description;
            this.Gateway = gateway;
            this.GatewayV6 = gatewayV6;
            this.Hostname = hostname;
            this.Id = id;
            this.IfaceGroupName = ifaceGroupName;
            this.InterfaceName = interfaceName;
            this.IpFamily = ipFamily;
            this.Ips = ips;
            this.Mtu = mtu;
            this.Subnet = subnet;
            this.SubnetV6 = subnetV6;
            this.TenantId = tenantId;
            this.VlanName = vlanName;
            this.AddToClusterPartition = addToClusterPartition;
            this.AllTenantAccess = allTenantAccess;
            this.Appsips = appsips;
            this.Description = description;
            this.Gateway = gateway;
            this.GatewayV6 = gatewayV6;
            this.Hostname = hostname;
            this.Id = id;
            this.IfaceGroupName = ifaceGroupName;
            this.InterfaceName = interfaceName;
            this.IpFamily = ipFamily;
            this.IpRange = ipRange;
            this.Ips = ips;
            this.Mtu = mtu;
            this.Subnet = subnet;
            this.SubnetV6 = subnetV6;
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
        /// Specifies if this VLAN can be used by all tenants without explicit assignment to them. This option can only be set true for VLANs that are not assigned to any tenant.
        /// </summary>
        /// <value>Specifies if this VLAN can be used by all tenants without explicit assignment to them. This option can only be set true for VLANs that are not assigned to any tenant.</value>
        [DataMember(Name="allTenantAccess", EmitDefaultValue=true)]
        public bool? AllTenantAccess { get; set; }

        /// <summary>
        /// Array of Athena Apps IPs.  Specifies a list of Athena IPs in the VLAN.
        /// </summary>
        /// <value>Array of Athena Apps IPs.  Specifies a list of Athena IPs in the VLAN.</value>
        [DataMember(Name="appsips", EmitDefaultValue=true)]
        public List<string> Appsips { get; set; }

        /// <summary>
        /// Specifies a description of the VLAN.
        /// </summary>
        /// <value>Specifies a description of the VLAN.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies the Gateway of the VLAN. It can carry V4 or V6 in case of requests, and carrises V4 in case of response.
        /// </summary>
        /// <value>Specifies the Gateway of the VLAN. It can carry V4 or V6 in case of requests, and carrises V4 in case of response.</value>
        [DataMember(Name="gateway", EmitDefaultValue=true)]
        public string Gateway { get; set; }

        /// <summary>
        /// Specifies the Gateway of the VLAN.
        /// </summary>
        /// <value>Specifies the Gateway of the VLAN.</value>
        [DataMember(Name="gatewayV6", EmitDefaultValue=true)]
        public string GatewayV6 { get; set; }

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
        /// Specifies IP family. Based on this, subnet/gateway field contains V4 or V6 values. Used in Request.
        /// </summary>
        /// <value>Specifies IP family. Based on this, subnet/gateway field contains V4 or V6 values. Used in Request.</value>
        [DataMember(Name="ipFamily", EmitDefaultValue=true)]
        public int? IpFamily { get; set; }

        /// <summary>
        /// Gets or Sets IpRange
        /// </summary>
        [DataMember(Name="ipRange", EmitDefaultValue=false)]
        public IpRange IpRange { get; set; }

        /// <summary>
        /// Array of IPs.  Specifies a list of IPs in the VLAN.
        /// </summary>
        /// <value>Array of IPs.  Specifies a list of IPs in the VLAN.</value>
        [DataMember(Name="ips", EmitDefaultValue=true)]
        public List<string> Ips { get; set; }

        /// <summary>
        /// Gets or Sets Mtu
        /// </summary>
        [DataMember(Name="mtu", EmitDefaultValue=true)]
        public int? Mtu { get; set; }

        /// <summary>
        /// Specifies the subnet of the VLAN. The netmask can be specified by setting netmaskBits or netmaskIp4. The netmask can only be set using netmaskIp4 if the IP address is an IPv4 address. It can carry V4 or V6 in case of requests, and carries V4 in case of response.
        /// </summary>
        /// <value>Specifies the subnet of the VLAN. The netmask can be specified by setting netmaskBits or netmaskIp4. The netmask can only be set using netmaskIp4 if the IP address is an IPv4 address. It can carry V4 or V6 in case of requests, and carries V4 in case of response.</value>
        [DataMember(Name="subnet", EmitDefaultValue=true)]
        public Subnet Subnet { get; set; }

        /// <summary>
        /// Specifies the subnet of the VLAN. The netmask can be specified by setting netmaskBits or netmaskIp4. The netmask can only be set using netmaskIp4 if the IP address is an IPv4 address.
        /// </summary>
        /// <value>Specifies the subnet of the VLAN. The netmask can be specified by setting netmaskBits or netmaskIp4. The netmask can only be set using netmaskIp4 if the IP address is an IPv4 address.</value>
        [DataMember(Name="subnetV6", EmitDefaultValue=true)]
        public Subnet SubnetV6 { get; set; }

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
                    this.AllTenantAccess == input.AllTenantAccess ||
                    (this.AllTenantAccess != null &&
                    this.AllTenantAccess.Equals(input.AllTenantAccess))
                ) && 
                (
                    this.Appsips == input.Appsips ||
                    this.Appsips != null &&
                    input.Appsips != null &&
                    this.Appsips.SequenceEqual(input.Appsips)
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
                    this.GatewayV6 == input.GatewayV6 ||
                    (this.GatewayV6 != null &&
                    this.GatewayV6.Equals(input.GatewayV6))
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
                    this.IpFamily == input.IpFamily ||
                    (this.IpFamily != null &&
                    this.IpFamily.Equals(input.IpFamily))
                ) && 
                (
                    this.IpRange == input.IpRange ||
                    (this.IpRange != null &&
                    this.IpRange.Equals(input.IpRange))
                ) && 
                (
                    this.Ips == input.Ips ||
                    this.Ips != null &&
                    input.Ips != null &&
                    this.Ips.SequenceEqual(input.Ips)
                ) && 
                (
                    this.Mtu == input.Mtu ||
                    (this.Mtu != null &&
                    this.Mtu.Equals(input.Mtu))
                ) && 
                (
                    this.Subnet == input.Subnet ||
                    (this.Subnet != null &&
                    this.Subnet.Equals(input.Subnet))
                ) && 
                (
                    this.SubnetV6 == input.SubnetV6 ||
                    (this.SubnetV6 != null &&
                    this.SubnetV6.Equals(input.SubnetV6))
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
                if (this.AllTenantAccess != null)
                    hashCode = hashCode * 59 + this.AllTenantAccess.GetHashCode();
                if (this.Appsips != null)
                    hashCode = hashCode * 59 + this.Appsips.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Gateway != null)
                    hashCode = hashCode * 59 + this.Gateway.GetHashCode();
                if (this.GatewayV6 != null)
                    hashCode = hashCode * 59 + this.GatewayV6.GetHashCode();
                if (this.Hostname != null)
                    hashCode = hashCode * 59 + this.Hostname.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IfaceGroupName != null)
                    hashCode = hashCode * 59 + this.IfaceGroupName.GetHashCode();
                if (this.InterfaceName != null)
                    hashCode = hashCode * 59 + this.InterfaceName.GetHashCode();
                if (this.IpFamily != null)
                    hashCode = hashCode * 59 + this.IpFamily.GetHashCode();
                if (this.IpRange != null)
                    hashCode = hashCode * 59 + this.IpRange.GetHashCode();
                if (this.Ips != null)
                    hashCode = hashCode * 59 + this.Ips.GetHashCode();
                if (this.Mtu != null)
                    hashCode = hashCode * 59 + this.Mtu.GetHashCode();
                if (this.Subnet != null)
                    hashCode = hashCode * 59 + this.Subnet.GetHashCode();
                if (this.SubnetV6 != null)
                    hashCode = hashCode * 59 + this.SubnetV6.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.VlanName != null)
                    hashCode = hashCode * 59 + this.VlanName.GetHashCode();
                return hashCode;
            }
        }

    }

}


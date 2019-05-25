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
    /// Specifies the properties of a network interface.
    /// </summary>
    [DataContract]
    public partial class NetworkInterface :  IEquatable<NetworkInterface>
    {
        /// <summary>
        /// Specifies the bonding mode if this interface is a bond. &#39;kActiveBackup&#39; indicates active backup bonding mode. &#39;k802_3ad&#39; indicates 802.3ad bonding mode.
        /// </summary>
        /// <value>Specifies the bonding mode if this interface is a bond. &#39;kActiveBackup&#39; indicates active backup bonding mode. &#39;k802_3ad&#39; indicates 802.3ad bonding mode.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BondingModeEnum
        {
            /// <summary>
            /// Enum KActiveBackup for value: kActiveBackup
            /// </summary>
            [EnumMember(Value = "kActiveBackup")]
            KActiveBackup = 1,

            /// <summary>
            /// Enum K8023ad for value: k802_3ad
            /// </summary>
            [EnumMember(Value = "k802_3ad")]
            K8023ad = 2

        }

        /// <summary>
        /// Specifies the bonding mode if this interface is a bond. &#39;kActiveBackup&#39; indicates active backup bonding mode. &#39;k802_3ad&#39; indicates 802.3ad bonding mode.
        /// </summary>
        /// <value>Specifies the bonding mode if this interface is a bond. &#39;kActiveBackup&#39; indicates active backup bonding mode. &#39;k802_3ad&#39; indicates 802.3ad bonding mode.</value>
        [DataMember(Name="bondingMode", EmitDefaultValue=true)]
        public BondingModeEnum? BondingMode { get; set; }
        /// <summary>
        /// Specifies the role of this interface. &#39;kPrimary&#39; indicates a primary role. &#39;kSecondary&#39; indicates a secondary role.
        /// </summary>
        /// <value>Specifies the role of this interface. &#39;kPrimary&#39; indicates a primary role. &#39;kSecondary&#39; indicates a secondary role.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RoleEnum
        {
            /// <summary>
            /// Enum KPrimary for value: kPrimary
            /// </summary>
            [EnumMember(Value = "kPrimary")]
            KPrimary = 1,

            /// <summary>
            /// Enum KSecondary for value: kSecondary
            /// </summary>
            [EnumMember(Value = "kSecondary")]
            KSecondary = 2

        }

        /// <summary>
        /// Specifies the role of this interface. &#39;kPrimary&#39; indicates a primary role. &#39;kSecondary&#39; indicates a secondary role.
        /// </summary>
        /// <value>Specifies the role of this interface. &#39;kPrimary&#39; indicates a primary role. &#39;kSecondary&#39; indicates a secondary role.</value>
        [DataMember(Name="role", EmitDefaultValue=true)]
        public RoleEnum? Role { get; set; }
        /// <summary>
        /// Defines Services
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ServicesEnum
        {
            /// <summary>
            /// Enum KReplicationService for value: kReplicationService
            /// </summary>
            [EnumMember(Value = "kReplicationService")]
            KReplicationService = 1,

            /// <summary>
            /// Enum KRemoteTunnelService for value: kRemoteTunnelService
            /// </summary>
            [EnumMember(Value = "kRemoteTunnelService")]
            KRemoteTunnelService = 2,

            /// <summary>
            /// Enum KClusterDataService for value: kClusterDataService
            /// </summary>
            [EnumMember(Value = "kClusterDataService")]
            KClusterDataService = 3,

            /// <summary>
            /// Enum KAvahiDiscoverService for value: kAvahiDiscoverService
            /// </summary>
            [EnumMember(Value = "kAvahiDiscoverService")]
            KAvahiDiscoverService = 4

        }


        /// <summary>
        /// Specifies the types of services this interface is used for. &#39;kReplicationService&#39; indicates a service which is used for data replication. &#39;kRemoteTunnelService&#39; indicates a service which is used for remote tunneling. &#39;kClusterDataService&#39; indicates a service which is used for managing Cluster data. &#39;kAvahiDiscoverService&#39; indicates a service which is used for Avahi discovery.
        /// </summary>
        /// <value>Specifies the types of services this interface is used for. &#39;kReplicationService&#39; indicates a service which is used for data replication. &#39;kRemoteTunnelService&#39; indicates a service which is used for remote tunneling. &#39;kClusterDataService&#39; indicates a service which is used for managing Cluster data. &#39;kAvahiDiscoverService&#39; indicates a service which is used for Avahi discovery.</value>
        [DataMember(Name="services", EmitDefaultValue=true)]
        public List<ServicesEnum> Services { get; set; }
        /// <summary>
        /// Specifies the type of interface. &#39;kPhysicalInterface&#39; indicates a physical interface type. &#39;kBondMasterInterface&#39; indicates that the interface is the master of a bond. &#39;kBondSlaveInterface&#39; indicates the the interface is a slave of a bond. &#39;kTaggedVlanInterface&#39; indicates a tagged vlan interface type.
        /// </summary>
        /// <value>Specifies the type of interface. &#39;kPhysicalInterface&#39; indicates a physical interface type. &#39;kBondMasterInterface&#39; indicates that the interface is the master of a bond. &#39;kBondSlaveInterface&#39; indicates the the interface is a slave of a bond. &#39;kTaggedVlanInterface&#39; indicates a tagged vlan interface type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KPhysicalInterface for value: kPhysicalInterface
            /// </summary>
            [EnumMember(Value = "kPhysicalInterface")]
            KPhysicalInterface = 1,

            /// <summary>
            /// Enum KBondMasterInterface for value: kBondMasterInterface
            /// </summary>
            [EnumMember(Value = "kBondMasterInterface")]
            KBondMasterInterface = 2,

            /// <summary>
            /// Enum KBondSlaveInterface for value: kBondSlaveInterface
            /// </summary>
            [EnumMember(Value = "kBondSlaveInterface")]
            KBondSlaveInterface = 3,

            /// <summary>
            /// Enum KTaggedVlanInterface for value: kTaggedVlanInterface
            /// </summary>
            [EnumMember(Value = "kTaggedVlanInterface")]
            KTaggedVlanInterface = 4

        }

        /// <summary>
        /// Specifies the type of interface. &#39;kPhysicalInterface&#39; indicates a physical interface type. &#39;kBondMasterInterface&#39; indicates that the interface is the master of a bond. &#39;kBondSlaveInterface&#39; indicates the the interface is a slave of a bond. &#39;kTaggedVlanInterface&#39; indicates a tagged vlan interface type.
        /// </summary>
        /// <value>Specifies the type of interface. &#39;kPhysicalInterface&#39; indicates a physical interface type. &#39;kBondMasterInterface&#39; indicates that the interface is the master of a bond. &#39;kBondSlaveInterface&#39; indicates the the interface is a slave of a bond. &#39;kTaggedVlanInterface&#39; indicates a tagged vlan interface type.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkInterface" /> class.
        /// </summary>
        /// <param name="bondSlaveSlotTypes">Specifies the types of the slots of any slaves if this interface is a bond..</param>
        /// <param name="bondSlaves">Specifies the names of any slaves if this interface is a bond..</param>
        /// <param name="bondingMode">Specifies the bonding mode if this interface is a bond. &#39;kActiveBackup&#39; indicates active backup bonding mode. &#39;k802_3ad&#39; indicates 802.3ad bonding mode..</param>
        /// <param name="gateway">Specifies the gateway of the interface..</param>
        /// <param name="group">Specifies the group that this interface belongs to..</param>
        /// <param name="id">Specifies the ID of this network interface..</param>
        /// <param name="isConnected">Specifies whether or not the Interface is connected..</param>
        /// <param name="isDefaultRoute">Specifies whether or not to use this interface as the default route..</param>
        /// <param name="isUp">Specifies whether or not the interface is currently  up..</param>
        /// <param name="macAddress">Specifies the Mac address of the Interface..</param>
        /// <param name="mtu">Specifies the MTU of the interface..</param>
        /// <param name="name">Specifies the name of the interface port..</param>
        /// <param name="role">Specifies the role of this interface. &#39;kPrimary&#39; indicates a primary role. &#39;kSecondary&#39; indicates a secondary role..</param>
        /// <param name="services">Specifies the types of services this interface is used for. &#39;kReplicationService&#39; indicates a service which is used for data replication. &#39;kRemoteTunnelService&#39; indicates a service which is used for remote tunneling. &#39;kClusterDataService&#39; indicates a service which is used for managing Cluster data. &#39;kAvahiDiscoverService&#39; indicates a service which is used for Avahi discovery..</param>
        /// <param name="speed">Specifies the speed of the Interface..</param>
        /// <param name="staticIp">Specifies the static IP of the interface..</param>
        /// <param name="subnet">Specifies the subnet mask of the interface..</param>
        /// <param name="type">Specifies the type of interface. &#39;kPhysicalInterface&#39; indicates a physical interface type. &#39;kBondMasterInterface&#39; indicates that the interface is the master of a bond. &#39;kBondSlaveInterface&#39; indicates the the interface is a slave of a bond. &#39;kTaggedVlanInterface&#39; indicates a tagged vlan interface type..</param>
        /// <param name="virtualIp">Specifies the virtual IP of the interface..</param>
        public NetworkInterface(List<string> bondSlaveSlotTypes = default(List<string>), List<string> bondSlaves = default(List<string>), BondingModeEnum? bondingMode = default(BondingModeEnum?), string gateway = default(string), string group = default(string), long? id = default(long?), bool? isConnected = default(bool?), bool? isDefaultRoute = default(bool?), bool? isUp = default(bool?), string macAddress = default(string), int? mtu = default(int?), string name = default(string), RoleEnum? role = default(RoleEnum?), List<ServicesEnum> services = default(List<ServicesEnum>), string speed = default(string), string staticIp = default(string), string subnet = default(string), TypeEnum? type = default(TypeEnum?), string virtualIp = default(string))
        {
            this.BondSlaveSlotTypes = bondSlaveSlotTypes;
            this.BondSlaves = bondSlaves;
            this.BondingMode = bondingMode;
            this.Gateway = gateway;
            this.Group = group;
            this.Id = id;
            this.IsConnected = isConnected;
            this.IsDefaultRoute = isDefaultRoute;
            this.IsUp = isUp;
            this.MacAddress = macAddress;
            this.Mtu = mtu;
            this.Name = name;
            this.Role = role;
            this.Services = services;
            this.Speed = speed;
            this.StaticIp = staticIp;
            this.Subnet = subnet;
            this.Type = type;
            this.VirtualIp = virtualIp;
            this.BondSlaveSlotTypes = bondSlaveSlotTypes;
            this.BondSlaves = bondSlaves;
            this.BondingMode = bondingMode;
            this.Gateway = gateway;
            this.Group = group;
            this.Id = id;
            this.IsConnected = isConnected;
            this.IsDefaultRoute = isDefaultRoute;
            this.IsUp = isUp;
            this.MacAddress = macAddress;
            this.Mtu = mtu;
            this.Name = name;
            this.Role = role;
            this.Services = services;
            this.Speed = speed;
            this.StaticIp = staticIp;
            this.Subnet = subnet;
            this.Type = type;
            this.VirtualIp = virtualIp;
        }
        
        /// <summary>
        /// Specifies the types of the slots of any slaves if this interface is a bond.
        /// </summary>
        /// <value>Specifies the types of the slots of any slaves if this interface is a bond.</value>
        [DataMember(Name="bondSlaveSlotTypes", EmitDefaultValue=true)]
        public List<string> BondSlaveSlotTypes { get; set; }

        /// <summary>
        /// Specifies the names of any slaves if this interface is a bond.
        /// </summary>
        /// <value>Specifies the names of any slaves if this interface is a bond.</value>
        [DataMember(Name="bondSlaves", EmitDefaultValue=true)]
        public List<string> BondSlaves { get; set; }

        /// <summary>
        /// Specifies the gateway of the interface.
        /// </summary>
        /// <value>Specifies the gateway of the interface.</value>
        [DataMember(Name="gateway", EmitDefaultValue=true)]
        public string Gateway { get; set; }

        /// <summary>
        /// Specifies the group that this interface belongs to.
        /// </summary>
        /// <value>Specifies the group that this interface belongs to.</value>
        [DataMember(Name="group", EmitDefaultValue=true)]
        public string Group { get; set; }

        /// <summary>
        /// Specifies the ID of this network interface.
        /// </summary>
        /// <value>Specifies the ID of this network interface.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Specifies whether or not the Interface is connected.
        /// </summary>
        /// <value>Specifies whether or not the Interface is connected.</value>
        [DataMember(Name="isConnected", EmitDefaultValue=true)]
        public bool? IsConnected { get; set; }

        /// <summary>
        /// Specifies whether or not to use this interface as the default route.
        /// </summary>
        /// <value>Specifies whether or not to use this interface as the default route.</value>
        [DataMember(Name="isDefaultRoute", EmitDefaultValue=true)]
        public bool? IsDefaultRoute { get; set; }

        /// <summary>
        /// Specifies whether or not the interface is currently  up.
        /// </summary>
        /// <value>Specifies whether or not the interface is currently  up.</value>
        [DataMember(Name="isUp", EmitDefaultValue=true)]
        public bool? IsUp { get; set; }

        /// <summary>
        /// Specifies the Mac address of the Interface.
        /// </summary>
        /// <value>Specifies the Mac address of the Interface.</value>
        [DataMember(Name="macAddress", EmitDefaultValue=true)]
        public string MacAddress { get; set; }

        /// <summary>
        /// Specifies the MTU of the interface.
        /// </summary>
        /// <value>Specifies the MTU of the interface.</value>
        [DataMember(Name="mtu", EmitDefaultValue=true)]
        public int? Mtu { get; set; }

        /// <summary>
        /// Specifies the name of the interface port.
        /// </summary>
        /// <value>Specifies the name of the interface port.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the speed of the Interface.
        /// </summary>
        /// <value>Specifies the speed of the Interface.</value>
        [DataMember(Name="speed", EmitDefaultValue=true)]
        public string Speed { get; set; }

        /// <summary>
        /// Specifies the static IP of the interface.
        /// </summary>
        /// <value>Specifies the static IP of the interface.</value>
        [DataMember(Name="staticIp", EmitDefaultValue=true)]
        public string StaticIp { get; set; }

        /// <summary>
        /// Specifies the subnet mask of the interface.
        /// </summary>
        /// <value>Specifies the subnet mask of the interface.</value>
        [DataMember(Name="subnet", EmitDefaultValue=true)]
        public string Subnet { get; set; }

        /// <summary>
        /// Specifies the virtual IP of the interface.
        /// </summary>
        /// <value>Specifies the virtual IP of the interface.</value>
        [DataMember(Name="virtualIp", EmitDefaultValue=true)]
        public string VirtualIp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NetworkInterface {\n");
            sb.Append("  BondSlaveSlotTypes: ").Append(BondSlaveSlotTypes).Append("\n");
            sb.Append("  BondSlaves: ").Append(BondSlaves).Append("\n");
            sb.Append("  BondingMode: ").Append(BondingMode).Append("\n");
            sb.Append("  Gateway: ").Append(Gateway).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsConnected: ").Append(IsConnected).Append("\n");
            sb.Append("  IsDefaultRoute: ").Append(IsDefaultRoute).Append("\n");
            sb.Append("  IsUp: ").Append(IsUp).Append("\n");
            sb.Append("  MacAddress: ").Append(MacAddress).Append("\n");
            sb.Append("  Mtu: ").Append(Mtu).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Services: ").Append(Services).Append("\n");
            sb.Append("  Speed: ").Append(Speed).Append("\n");
            sb.Append("  StaticIp: ").Append(StaticIp).Append("\n");
            sb.Append("  Subnet: ").Append(Subnet).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  VirtualIp: ").Append(VirtualIp).Append("\n");
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
            return this.Equals(input as NetworkInterface);
        }

        /// <summary>
        /// Returns true if NetworkInterface instances are equal
        /// </summary>
        /// <param name="input">Instance of NetworkInterface to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetworkInterface input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BondSlaveSlotTypes == input.BondSlaveSlotTypes ||
                    this.BondSlaveSlotTypes != null &&
                    input.BondSlaveSlotTypes != null &&
                    this.BondSlaveSlotTypes.SequenceEqual(input.BondSlaveSlotTypes)
                ) && 
                (
                    this.BondSlaves == input.BondSlaves ||
                    this.BondSlaves != null &&
                    input.BondSlaves != null &&
                    this.BondSlaves.SequenceEqual(input.BondSlaves)
                ) && 
                (
                    this.BondingMode == input.BondingMode ||
                    this.BondingMode.Equals(input.BondingMode)
                ) && 
                (
                    this.Gateway == input.Gateway ||
                    (this.Gateway != null &&
                    this.Gateway.Equals(input.Gateway))
                ) && 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsConnected == input.IsConnected ||
                    (this.IsConnected != null &&
                    this.IsConnected.Equals(input.IsConnected))
                ) && 
                (
                    this.IsDefaultRoute == input.IsDefaultRoute ||
                    (this.IsDefaultRoute != null &&
                    this.IsDefaultRoute.Equals(input.IsDefaultRoute))
                ) && 
                (
                    this.IsUp == input.IsUp ||
                    (this.IsUp != null &&
                    this.IsUp.Equals(input.IsUp))
                ) && 
                (
                    this.MacAddress == input.MacAddress ||
                    (this.MacAddress != null &&
                    this.MacAddress.Equals(input.MacAddress))
                ) && 
                (
                    this.Mtu == input.Mtu ||
                    (this.Mtu != null &&
                    this.Mtu.Equals(input.Mtu))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Role == input.Role ||
                    this.Role.Equals(input.Role)
                ) && 
                (
                    this.Services == input.Services ||
                    this.Services != null &&
                    input.Services != null &&
                    this.Services.SequenceEqual(input.Services)
                ) && 
                (
                    this.Speed == input.Speed ||
                    (this.Speed != null &&
                    this.Speed.Equals(input.Speed))
                ) && 
                (
                    this.StaticIp == input.StaticIp ||
                    (this.StaticIp != null &&
                    this.StaticIp.Equals(input.StaticIp))
                ) && 
                (
                    this.Subnet == input.Subnet ||
                    (this.Subnet != null &&
                    this.Subnet.Equals(input.Subnet))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.VirtualIp == input.VirtualIp ||
                    (this.VirtualIp != null &&
                    this.VirtualIp.Equals(input.VirtualIp))
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
                if (this.BondSlaveSlotTypes != null)
                    hashCode = hashCode * 59 + this.BondSlaveSlotTypes.GetHashCode();
                if (this.BondSlaves != null)
                    hashCode = hashCode * 59 + this.BondSlaves.GetHashCode();
                hashCode = hashCode * 59 + this.BondingMode.GetHashCode();
                if (this.Gateway != null)
                    hashCode = hashCode * 59 + this.Gateway.GetHashCode();
                if (this.Group != null)
                    hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IsConnected != null)
                    hashCode = hashCode * 59 + this.IsConnected.GetHashCode();
                if (this.IsDefaultRoute != null)
                    hashCode = hashCode * 59 + this.IsDefaultRoute.GetHashCode();
                if (this.IsUp != null)
                    hashCode = hashCode * 59 + this.IsUp.GetHashCode();
                if (this.MacAddress != null)
                    hashCode = hashCode * 59 + this.MacAddress.GetHashCode();
                if (this.Mtu != null)
                    hashCode = hashCode * 59 + this.Mtu.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Role.GetHashCode();
                hashCode = hashCode * 59 + this.Services.GetHashCode();
                if (this.Speed != null)
                    hashCode = hashCode * 59 + this.Speed.GetHashCode();
                if (this.StaticIp != null)
                    hashCode = hashCode * 59 + this.StaticIp.GetHashCode();
                if (this.Subnet != null)
                    hashCode = hashCode * 59 + this.Subnet.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.VirtualIp != null)
                    hashCode = hashCode * 59 + this.VirtualIp.GetHashCode();
                return hashCode;
            }
        }

    }

}

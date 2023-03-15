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
        /// Initializes a new instance of the <see cref="NetworkInterface" /> class.
        /// </summary>
        /// <param name="activeBondSlave">Current active secondary. This is only valid in active-backup mode..</param>
        /// <param name="bondSlaveSlotTypes">Specifies the types of the slots of any secondaries if this interface is a bond..</param>
        /// <param name="bondSlaves">Specifies the names of any secondaries if this interface is a bond..</param>
        /// <param name="bondSlavesDetails">Specifies the details of the bond secondaries..</param>
        /// <param name="bondingMode">Specifies the bonding mode if this interface is a bond..</param>
        /// <param name="gateway">Specifies the gateway of the interface..</param>
        /// <param name="gateway6">Specifies the gateway6 of the interface..</param>
        /// <param name="group">Specifies the group that this interface belongs to..</param>
        /// <param name="id">Specifies the ID of this network interface..</param>
        /// <param name="isConnected">Specifies whether or not the Interface is connected..</param>
        /// <param name="isDefaultRoute">Specifies whether or not to use this interface as the default route..</param>
        /// <param name="isUp">Specifies whether or not the interface is currently  up..</param>
        /// <param name="macAddress">Specifies the Mac address of the Interface..</param>
        /// <param name="mtu">Specifies the MTU of the interface..</param>
        /// <param name="name">Specifies the name of the interface port..</param>
        /// <param name="role">Specifies the role of this interface..</param>
        /// <param name="services">Specifies the types of services this interface is used for..</param>
        /// <param name="speed">Specifies the speed of the Interface..</param>
        /// <param name="staticIp">Specifies the static IP of the interface..</param>
        /// <param name="staticIp6">Specifies the static IPv6 of the interface..</param>
        /// <param name="stats">stats.</param>
        /// <param name="subnet">Specifies the subnet mask of the interface..</param>
        /// <param name="subnet6">Specifies the subnet6 mask of the interface..</param>
        /// <param name="type">Specifies the type of interface..</param>
        /// <param name="virtualIp">Specifies the virtual IP of the interface..</param>
        public NetworkInterface(string activeBondSlave = default(string), List<string> bondSlaveSlotTypes = default(List<string>), List<string> bondSlaves = default(List<string>), List<BondSlaveInfo> bondSlavesDetails = default(List<BondSlaveInfo>), int? bondingMode = default(int?), string gateway = default(string), string gateway6 = default(string), string group = default(string), long? id = default(long?), bool? isConnected = default(bool?), bool? isDefaultRoute = default(bool?), bool? isUp = default(bool?), string macAddress = default(string), int? mtu = default(int?), string name = default(string), string role = default(string), List<string> services = default(List<string>), string speed = default(string), string staticIp = default(string), string staticIp6 = default(string), InterfaceStats stats = default(InterfaceStats), string subnet = default(string), string subnet6 = default(string), int? type = default(int?), string virtualIp = default(string))
        {
            this.ActiveBondSlave = activeBondSlave;
            this.BondSlaveSlotTypes = bondSlaveSlotTypes;
            this.BondSlaves = bondSlaves;
            this.BondSlavesDetails = bondSlavesDetails;
            this.BondingMode = bondingMode;
            this.Gateway = gateway;
            this.Gateway6 = gateway6;
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
            this.StaticIp6 = staticIp6;
            this.Subnet = subnet;
            this.Subnet6 = subnet6;
            this.Type = type;
            this.VirtualIp = virtualIp;
            this.ActiveBondSlave = activeBondSlave;
            this.BondSlaveSlotTypes = bondSlaveSlotTypes;
            this.BondSlaves = bondSlaves;
            this.BondSlavesDetails = bondSlavesDetails;
            this.BondingMode = bondingMode;
            this.Gateway = gateway;
            this.Gateway6 = gateway6;
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
            this.StaticIp6 = staticIp6;
            this.Stats = stats;
            this.Subnet = subnet;
            this.Subnet6 = subnet6;
            this.Type = type;
            this.VirtualIp = virtualIp;
        }
        
        /// <summary>
        /// Current active secondary. This is only valid in active-backup mode.
        /// </summary>
        /// <value>Current active secondary. This is only valid in active-backup mode.</value>
        [DataMember(Name="activeBondSlave", EmitDefaultValue=true)]
        public string ActiveBondSlave { get; set; }

        /// <summary>
        /// Specifies the types of the slots of any secondaries if this interface is a bond.
        /// </summary>
        /// <value>Specifies the types of the slots of any secondaries if this interface is a bond.</value>
        [DataMember(Name="bondSlaveSlotTypes", EmitDefaultValue=true)]
        public List<string> BondSlaveSlotTypes { get; set; }

        /// <summary>
        /// Specifies the names of any secondaries if this interface is a bond.
        /// </summary>
        /// <value>Specifies the names of any secondaries if this interface is a bond.</value>
        [DataMember(Name="bondSlaves", EmitDefaultValue=true)]
        public List<string> BondSlaves { get; set; }

        /// <summary>
        /// Specifies the details of the bond secondaries.
        /// </summary>
        /// <value>Specifies the details of the bond secondaries.</value>
        [DataMember(Name="bondSlavesDetails", EmitDefaultValue=true)]
        public List<BondSlaveInfo> BondSlavesDetails { get; set; }

        /// <summary>
        /// Specifies the bonding mode if this interface is a bond.
        /// </summary>
        /// <value>Specifies the bonding mode if this interface is a bond.</value>
        [DataMember(Name="bondingMode", EmitDefaultValue=true)]
        public int? BondingMode { get; set; }

        /// <summary>
        /// Specifies the gateway of the interface.
        /// </summary>
        /// <value>Specifies the gateway of the interface.</value>
        [DataMember(Name="gateway", EmitDefaultValue=true)]
        public string Gateway { get; set; }

        /// <summary>
        /// Specifies the gateway6 of the interface.
        /// </summary>
        /// <value>Specifies the gateway6 of the interface.</value>
        [DataMember(Name="gateway6", EmitDefaultValue=true)]
        public string Gateway6 { get; set; }

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
        /// Specifies the role of this interface.
        /// </summary>
        /// <value>Specifies the role of this interface.</value>
        [DataMember(Name="role", EmitDefaultValue=true)]
        public string Role { get; set; }

        /// <summary>
        /// Specifies the types of services this interface is used for.
        /// </summary>
        /// <value>Specifies the types of services this interface is used for.</value>
        [DataMember(Name="services", EmitDefaultValue=true)]
        public List<string> Services { get; set; }

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
        /// Specifies the static IPv6 of the interface.
        /// </summary>
        /// <value>Specifies the static IPv6 of the interface.</value>
        [DataMember(Name="staticIp6", EmitDefaultValue=true)]
        public string StaticIp6 { get; set; }

        /// <summary>
        /// Gets or Sets Stats
        /// </summary>
        [DataMember(Name="stats", EmitDefaultValue=false)]
        public InterfaceStats Stats { get; set; }

        /// <summary>
        /// Specifies the subnet mask of the interface.
        /// </summary>
        /// <value>Specifies the subnet mask of the interface.</value>
        [DataMember(Name="subnet", EmitDefaultValue=true)]
        public string Subnet { get; set; }

        /// <summary>
        /// Specifies the subnet6 mask of the interface.
        /// </summary>
        /// <value>Specifies the subnet6 mask of the interface.</value>
        [DataMember(Name="subnet6", EmitDefaultValue=true)]
        public string Subnet6 { get; set; }

        /// <summary>
        /// Specifies the type of interface.
        /// </summary>
        /// <value>Specifies the type of interface.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public int? Type { get; set; }

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
                    this.ActiveBondSlave == input.ActiveBondSlave ||
                    (this.ActiveBondSlave != null &&
                    this.ActiveBondSlave.Equals(input.ActiveBondSlave))
                ) && 
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
                    this.BondSlavesDetails == input.BondSlavesDetails ||
                    this.BondSlavesDetails != null &&
                    input.BondSlavesDetails != null &&
                    this.BondSlavesDetails.SequenceEqual(input.BondSlavesDetails)
                ) && 
                (
                    this.BondingMode == input.BondingMode ||
                    (this.BondingMode != null &&
                    this.BondingMode.Equals(input.BondingMode))
                ) && 
                (
                    this.Gateway == input.Gateway ||
                    (this.Gateway != null &&
                    this.Gateway.Equals(input.Gateway))
                ) && 
                (
                    this.Gateway6 == input.Gateway6 ||
                    (this.Gateway6 != null &&
                    this.Gateway6.Equals(input.Gateway6))
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
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
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
                    this.StaticIp6 == input.StaticIp6 ||
                    (this.StaticIp6 != null &&
                    this.StaticIp6.Equals(input.StaticIp6))
                ) && 
                (
                    this.Stats == input.Stats ||
                    (this.Stats != null &&
                    this.Stats.Equals(input.Stats))
                ) && 
                (
                    this.Subnet == input.Subnet ||
                    (this.Subnet != null &&
                    this.Subnet.Equals(input.Subnet))
                ) && 
                (
                    this.Subnet6 == input.Subnet6 ||
                    (this.Subnet6 != null &&
                    this.Subnet6.Equals(input.Subnet6))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.ActiveBondSlave != null)
                    hashCode = hashCode * 59 + this.ActiveBondSlave.GetHashCode();
                if (this.BondSlaveSlotTypes != null)
                    hashCode = hashCode * 59 + this.BondSlaveSlotTypes.GetHashCode();
                if (this.BondSlaves != null)
                    hashCode = hashCode * 59 + this.BondSlaves.GetHashCode();
                if (this.BondSlavesDetails != null)
                    hashCode = hashCode * 59 + this.BondSlavesDetails.GetHashCode();
                if (this.BondingMode != null)
                    hashCode = hashCode * 59 + this.BondingMode.GetHashCode();
                if (this.Gateway != null)
                    hashCode = hashCode * 59 + this.Gateway.GetHashCode();
                if (this.Gateway6 != null)
                    hashCode = hashCode * 59 + this.Gateway6.GetHashCode();
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
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.Services != null)
                    hashCode = hashCode * 59 + this.Services.GetHashCode();
                if (this.Speed != null)
                    hashCode = hashCode * 59 + this.Speed.GetHashCode();
                if (this.StaticIp != null)
                    hashCode = hashCode * 59 + this.StaticIp.GetHashCode();
                if (this.StaticIp6 != null)
                    hashCode = hashCode * 59 + this.StaticIp6.GetHashCode();
                if (this.Stats != null)
                    hashCode = hashCode * 59 + this.Stats.GetHashCode();
                if (this.Subnet != null)
                    hashCode = hashCode * 59 + this.Subnet.GetHashCode();
                if (this.Subnet6 != null)
                    hashCode = hashCode * 59 + this.Subnet6.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.VirtualIp != null)
                    hashCode = hashCode * 59 + this.VirtualIp.GetHashCode();
                return hashCode;
            }
        }

    }

}


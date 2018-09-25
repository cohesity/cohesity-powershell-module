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
    /// Specifies the settings of a Static Route.
    /// </summary>
    [DataContract]
    public partial class StaticRoute :  IEquatable<StaticRoute>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StaticRoute" /> class.
        /// </summary>
        /// <param name="description">Specifies a description of the Static Route..</param>
        /// <param name="isUpdate">Specifies if the route is currently being updated on the Cohesity Cluster..</param>
        /// <param name="networkInterfaceGroup">Specifies the group name of the network interfaces to use for communicating with the destination subnet..</param>
        /// <param name="networkInterfaceIds">Specifies the ids of the network interfaces to use for communicating with the destination subnet..</param>
        /// <param name="subnet">subnet.</param>
        /// <param name="vlanId">Specifies the ID of the VLAN to use for communication with the destination subnet..</param>
        public StaticRoute(string description = default(string), bool? isUpdate = default(bool?), string networkInterfaceGroup = default(string), List<long?> networkInterfaceIds = default(List<long?>), DestinationSubnet_ subnet = default(DestinationSubnet_), int? vlanId = default(int?))
        {
            this.Description = description;
            this.IsUpdate = isUpdate;
            this.NetworkInterfaceGroup = networkInterfaceGroup;
            this.NetworkInterfaceIds = networkInterfaceIds;
            this.Subnet = subnet;
            this.VlanId = vlanId;
        }
        
        /// <summary>
        /// Specifies a description of the Static Route.
        /// </summary>
        /// <value>Specifies a description of the Static Route.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies if the route is currently being updated on the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies if the route is currently being updated on the Cohesity Cluster.</value>
        [DataMember(Name="isUpdate", EmitDefaultValue=false)]
        public bool? IsUpdate { get; set; }

        /// <summary>
        /// Specifies the group name of the network interfaces to use for communicating with the destination subnet.
        /// </summary>
        /// <value>Specifies the group name of the network interfaces to use for communicating with the destination subnet.</value>
        [DataMember(Name="networkInterfaceGroup", EmitDefaultValue=false)]
        public string NetworkInterfaceGroup { get; set; }

        /// <summary>
        /// Specifies the ids of the network interfaces to use for communicating with the destination subnet.
        /// </summary>
        /// <value>Specifies the ids of the network interfaces to use for communicating with the destination subnet.</value>
        [DataMember(Name="networkInterfaceIds", EmitDefaultValue=false)]
        public List<long?> NetworkInterfaceIds { get; set; }

        /// <summary>
        /// Gets or Sets Subnet
        /// </summary>
        [DataMember(Name="subnet", EmitDefaultValue=false)]
        public DestinationSubnet_ Subnet { get; set; }

        /// <summary>
        /// Specifies the ID of the VLAN to use for communication with the destination subnet.
        /// </summary>
        /// <value>Specifies the ID of the VLAN to use for communication with the destination subnet.</value>
        [DataMember(Name="vlanId", EmitDefaultValue=false)]
        public int? VlanId { get; set; }

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
            return this.Equals(input as StaticRoute);
        }

        /// <summary>
        /// Returns true if StaticRoute instances are equal
        /// </summary>
        /// <param name="input">Instance of StaticRoute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StaticRoute input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.IsUpdate == input.IsUpdate ||
                    (this.IsUpdate != null &&
                    this.IsUpdate.Equals(input.IsUpdate))
                ) && 
                (
                    this.NetworkInterfaceGroup == input.NetworkInterfaceGroup ||
                    (this.NetworkInterfaceGroup != null &&
                    this.NetworkInterfaceGroup.Equals(input.NetworkInterfaceGroup))
                ) && 
                (
                    this.NetworkInterfaceIds == input.NetworkInterfaceIds ||
                    this.NetworkInterfaceIds != null &&
                    this.NetworkInterfaceIds.SequenceEqual(input.NetworkInterfaceIds)
                ) && 
                (
                    this.Subnet == input.Subnet ||
                    (this.Subnet != null &&
                    this.Subnet.Equals(input.Subnet))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IsUpdate != null)
                    hashCode = hashCode * 59 + this.IsUpdate.GetHashCode();
                if (this.NetworkInterfaceGroup != null)
                    hashCode = hashCode * 59 + this.NetworkInterfaceGroup.GetHashCode();
                if (this.NetworkInterfaceIds != null)
                    hashCode = hashCode * 59 + this.NetworkInterfaceIds.GetHashCode();
                if (this.Subnet != null)
                    hashCode = hashCode * 59 + this.Subnet.GetHashCode();
                if (this.VlanId != null)
                    hashCode = hashCode * 59 + this.VlanId.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


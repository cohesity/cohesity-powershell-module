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
    /// Specifies the settings of a Static Route.
    /// </summary>
    [DataContract]
    public partial class Route :  IEquatable<Route>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Route" /> class.
        /// </summary>
        /// <param name="advmss">Specifies AdvMss setting per route..</param>
        /// <param name="description">Specifies a description of the Static Route..</param>
        /// <param name="destNetwork">Destination network.  Specifies the destination network of the Static Route. overrideDescription: true.</param>
        /// <param name="ifName">Specifies the network interfaces name to use for communicating with the destination network..</param>
        /// <param name="ifaceGroupName">Specifies the network interfaces group or interface group with vlan id to use for communicating with the destination network..</param>
        /// <param name="mtu">Specifies MTU setting per route..</param>
        /// <param name="nextHop">Specifies the next hop to the destination network..</param>
        /// <param name="nodeGroupName">Specifies the network node group to represent a group of nodes..</param>
        public Route(int? advmss = default(int?), string description = default(string), string destNetwork = default(string), string ifName = default(string), string ifaceGroupName = default(string), int? mtu = default(int?), string nextHop = default(string), string nodeGroupName = default(string))
        {
            this.Advmss = advmss;
            this.Description = description;
            this.DestNetwork = destNetwork;
            this.IfName = ifName;
            this.IfaceGroupName = ifaceGroupName;
            this.Mtu = mtu;
            this.NextHop = nextHop;
            this.NodeGroupName = nodeGroupName;
        }
        
        /// <summary>
        /// Specifies AdvMss setting per route.
        /// </summary>
        /// <value>Specifies AdvMss setting per route.</value>
        [DataMember(Name="advmss", EmitDefaultValue=true)]
        public int? Advmss { get; set; }

        /// <summary>
        /// Specifies a description of the Static Route.
        /// </summary>
        /// <value>Specifies a description of the Static Route.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Destination network.  Specifies the destination network of the Static Route. overrideDescription: true
        /// </summary>
        /// <value>Destination network.  Specifies the destination network of the Static Route. overrideDescription: true</value>
        [DataMember(Name="destNetwork", EmitDefaultValue=true)]
        public string DestNetwork { get; set; }

        /// <summary>
        /// Specifies the network interfaces name to use for communicating with the destination network.
        /// </summary>
        /// <value>Specifies the network interfaces name to use for communicating with the destination network.</value>
        [DataMember(Name="ifName", EmitDefaultValue=true)]
        public string IfName { get; set; }

        /// <summary>
        /// Specifies the network interfaces group or interface group with vlan id to use for communicating with the destination network.
        /// </summary>
        /// <value>Specifies the network interfaces group or interface group with vlan id to use for communicating with the destination network.</value>
        [DataMember(Name="ifaceGroupName", EmitDefaultValue=true)]
        public string IfaceGroupName { get; set; }

        /// <summary>
        /// Specifies MTU setting per route.
        /// </summary>
        /// <value>Specifies MTU setting per route.</value>
        [DataMember(Name="mtu", EmitDefaultValue=true)]
        public int? Mtu { get; set; }

        /// <summary>
        /// Specifies the next hop to the destination network.
        /// </summary>
        /// <value>Specifies the next hop to the destination network.</value>
        [DataMember(Name="nextHop", EmitDefaultValue=true)]
        public string NextHop { get; set; }

        /// <summary>
        /// Specifies the network node group to represent a group of nodes.
        /// </summary>
        /// <value>Specifies the network node group to represent a group of nodes.</value>
        [DataMember(Name="nodeGroupName", EmitDefaultValue=true)]
        public string NodeGroupName { get; set; }

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
            return this.Equals(input as Route);
        }

        /// <summary>
        /// Returns true if Route instances are equal
        /// </summary>
        /// <param name="input">Instance of Route to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Route input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Advmss == input.Advmss ||
                    (this.Advmss != null &&
                    this.Advmss.Equals(input.Advmss))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DestNetwork == input.DestNetwork ||
                    (this.DestNetwork != null &&
                    this.DestNetwork.Equals(input.DestNetwork))
                ) && 
                (
                    this.IfName == input.IfName ||
                    (this.IfName != null &&
                    this.IfName.Equals(input.IfName))
                ) && 
                (
                    this.IfaceGroupName == input.IfaceGroupName ||
                    (this.IfaceGroupName != null &&
                    this.IfaceGroupName.Equals(input.IfaceGroupName))
                ) && 
                (
                    this.Mtu == input.Mtu ||
                    (this.Mtu != null &&
                    this.Mtu.Equals(input.Mtu))
                ) && 
                (
                    this.NextHop == input.NextHop ||
                    (this.NextHop != null &&
                    this.NextHop.Equals(input.NextHop))
                ) && 
                (
                    this.NodeGroupName == input.NodeGroupName ||
                    (this.NodeGroupName != null &&
                    this.NodeGroupName.Equals(input.NodeGroupName))
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
                if (this.Advmss != null)
                    hashCode = hashCode * 59 + this.Advmss.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DestNetwork != null)
                    hashCode = hashCode * 59 + this.DestNetwork.GetHashCode();
                if (this.IfName != null)
                    hashCode = hashCode * 59 + this.IfName.GetHashCode();
                if (this.IfaceGroupName != null)
                    hashCode = hashCode * 59 + this.IfaceGroupName.GetHashCode();
                if (this.Mtu != null)
                    hashCode = hashCode * 59 + this.Mtu.GetHashCode();
                if (this.NextHop != null)
                    hashCode = hashCode * 59 + this.NextHop.GetHashCode();
                if (this.NodeGroupName != null)
                    hashCode = hashCode * 59 + this.NodeGroupName.GetHashCode();
                return hashCode;
            }
        }

    }

}


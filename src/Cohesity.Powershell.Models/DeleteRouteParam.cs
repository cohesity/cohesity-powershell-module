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
    /// Specifies the delete param of a Static Route.
    /// </summary>
    [DataContract]
    public partial class DeleteRouteParam :  IEquatable<DeleteRouteParam>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRouteParam" /> class.
        /// </summary>
        /// <param name="destNetwork">Destination network.  Specifies the destination network of the Static Route. overrideDescription: true.</param>
        /// <param name="ifName">Specifies the network interfaces name to use for communicating with the destination network..</param>
        /// <param name="ifaceGroupName">Specifies the network interfaces group or vlan interface group to use for communicating with the destination network..</param>
        /// <param name="nodeGroupName">Specifies the network node group to represent a group of nodes..</param>
        public DeleteRouteParam(string destNetwork = default(string), string ifName = default(string), string ifaceGroupName = default(string), string nodeGroupName = default(string))
        {
            this.DestNetwork = destNetwork;
            this.IfName = ifName;
            this.IfaceGroupName = ifaceGroupName;
            this.NodeGroupName = nodeGroupName;
            this.DestNetwork = destNetwork;
            this.IfName = ifName;
            this.IfaceGroupName = ifaceGroupName;
            this.NodeGroupName = nodeGroupName;
        }
        
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
        /// Specifies the network interfaces group or vlan interface group to use for communicating with the destination network.
        /// </summary>
        /// <value>Specifies the network interfaces group or vlan interface group to use for communicating with the destination network.</value>
        [DataMember(Name="ifaceGroupName", EmitDefaultValue=true)]
        public string IfaceGroupName { get; set; }

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
            return this.Equals(input as DeleteRouteParam);
        }

        /// <summary>
        /// Returns true if DeleteRouteParam instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteRouteParam to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteRouteParam input)
        {
            if (input == null)
                return false;

            return 
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
                if (this.DestNetwork != null)
                    hashCode = hashCode * 59 + this.DestNetwork.GetHashCode();
                if (this.IfName != null)
                    hashCode = hashCode * 59 + this.IfName.GetHashCode();
                if (this.IfaceGroupName != null)
                    hashCode = hashCode * 59 + this.IfaceGroupName.GetHashCode();
                if (this.NodeGroupName != null)
                    hashCode = hashCode * 59 + this.NodeGroupName.GetHashCode();
                return hashCode;
            }
        }

    }

}


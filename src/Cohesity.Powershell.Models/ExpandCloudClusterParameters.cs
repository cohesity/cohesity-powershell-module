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
    /// Specifies the parameters needed to expand a Cohesity Cloud Edition Cluster.
    /// </summary>
    [DataContract]
    public partial class ExpandCloudClusterParameters :  IEquatable<ExpandCloudClusterParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpandCloudClusterParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExpandCloudClusterParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpandCloudClusterParameters" /> class.
        /// </summary>
        /// <param name="diskAllNodesReachable">All nodes reachable property of the disks to designate..</param>
        /// <param name="diskComponentExclusive">Component exclusive property of the disks to designate..</param>
        /// <param name="diskSelfFaultTolerant">Self fault tolerant property of the disks to designate..</param>
        /// <param name="diskSerials">Serial number of the disks to designate properties..</param>
        /// <param name="diskTiers">Tiers of the disks to designate..</param>
        /// <param name="nodeIps">Specifies the list of IPs of the new Nodes. (required).</param>
        /// <param name="useAsComputeNode">UseAsComputeNode indicates whether the node should be used as a compute node or not..</param>
        public ExpandCloudClusterParameters(List<bool> diskAllNodesReachable = default(List<bool>), List<string> diskComponentExclusive = default(List<string>), List<bool> diskSelfFaultTolerant = default(List<bool>), List<string> diskSerials = default(List<string>), List<string> diskTiers = default(List<string>), List<string> nodeIps = default(List<string>), List<bool> useAsComputeNode = default(List<bool>))
        {
            this.DiskAllNodesReachable = diskAllNodesReachable;
            this.DiskComponentExclusive = diskComponentExclusive;
            this.DiskSelfFaultTolerant = diskSelfFaultTolerant;
            this.DiskSerials = diskSerials;
            this.DiskTiers = diskTiers;
            this.NodeIps = nodeIps;
            this.UseAsComputeNode = useAsComputeNode;
            this.DiskAllNodesReachable = diskAllNodesReachable;
            this.DiskComponentExclusive = diskComponentExclusive;
            this.DiskSelfFaultTolerant = diskSelfFaultTolerant;
            this.DiskSerials = diskSerials;
            this.DiskTiers = diskTiers;
            this.UseAsComputeNode = useAsComputeNode;
        }
        
        /// <summary>
        /// All nodes reachable property of the disks to designate.
        /// </summary>
        /// <value>All nodes reachable property of the disks to designate.</value>
        [DataMember(Name="diskAllNodesReachable", EmitDefaultValue=true)]
        public List<bool> DiskAllNodesReachable { get; set; }

        /// <summary>
        /// Component exclusive property of the disks to designate.
        /// </summary>
        /// <value>Component exclusive property of the disks to designate.</value>
        [DataMember(Name="diskComponentExclusive", EmitDefaultValue=true)]
        public List<string> DiskComponentExclusive { get; set; }

        /// <summary>
        /// Self fault tolerant property of the disks to designate.
        /// </summary>
        /// <value>Self fault tolerant property of the disks to designate.</value>
        [DataMember(Name="diskSelfFaultTolerant", EmitDefaultValue=true)]
        public List<bool> DiskSelfFaultTolerant { get; set; }

        /// <summary>
        /// Serial number of the disks to designate properties.
        /// </summary>
        /// <value>Serial number of the disks to designate properties.</value>
        [DataMember(Name="diskSerials", EmitDefaultValue=true)]
        public List<string> DiskSerials { get; set; }

        /// <summary>
        /// Tiers of the disks to designate.
        /// </summary>
        /// <value>Tiers of the disks to designate.</value>
        [DataMember(Name="diskTiers", EmitDefaultValue=true)]
        public List<string> DiskTiers { get; set; }

        /// <summary>
        /// Specifies the list of IPs of the new Nodes.
        /// </summary>
        /// <value>Specifies the list of IPs of the new Nodes.</value>
        [DataMember(Name="nodeIps", EmitDefaultValue=true)]
        public List<string> NodeIps { get; set; }

        /// <summary>
        /// UseAsComputeNode indicates whether the node should be used as a compute node or not.
        /// </summary>
        /// <value>UseAsComputeNode indicates whether the node should be used as a compute node or not.</value>
        [DataMember(Name="useAsComputeNode", EmitDefaultValue=true)]
        public List<bool> UseAsComputeNode { get; set; }

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
            return this.Equals(input as ExpandCloudClusterParameters);
        }

        /// <summary>
        /// Returns true if ExpandCloudClusterParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ExpandCloudClusterParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExpandCloudClusterParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DiskAllNodesReachable == input.DiskAllNodesReachable ||
                    this.DiskAllNodesReachable != null &&
                    input.DiskAllNodesReachable != null &&
                    this.DiskAllNodesReachable.SequenceEqual(input.DiskAllNodesReachable)
                ) && 
                (
                    this.DiskComponentExclusive == input.DiskComponentExclusive ||
                    this.DiskComponentExclusive != null &&
                    input.DiskComponentExclusive != null &&
                    this.DiskComponentExclusive.SequenceEqual(input.DiskComponentExclusive)
                ) && 
                (
                    this.DiskSelfFaultTolerant == input.DiskSelfFaultTolerant ||
                    this.DiskSelfFaultTolerant != null &&
                    input.DiskSelfFaultTolerant != null &&
                    this.DiskSelfFaultTolerant.SequenceEqual(input.DiskSelfFaultTolerant)
                ) && 
                (
                    this.DiskSerials == input.DiskSerials ||
                    this.DiskSerials != null &&
                    input.DiskSerials != null &&
                    this.DiskSerials.SequenceEqual(input.DiskSerials)
                ) && 
                (
                    this.DiskTiers == input.DiskTiers ||
                    this.DiskTiers != null &&
                    input.DiskTiers != null &&
                    this.DiskTiers.SequenceEqual(input.DiskTiers)
                ) && 
                (
                    this.NodeIps == input.NodeIps ||
                    this.NodeIps != null &&
                    input.NodeIps != null &&
                    this.NodeIps.SequenceEqual(input.NodeIps)
                ) && 
                (
                    this.UseAsComputeNode == input.UseAsComputeNode ||
                    this.UseAsComputeNode != null &&
                    input.UseAsComputeNode != null &&
                    this.UseAsComputeNode.SequenceEqual(input.UseAsComputeNode)
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
                if (this.DiskAllNodesReachable != null)
                    hashCode = hashCode * 59 + this.DiskAllNodesReachable.GetHashCode();
                if (this.DiskComponentExclusive != null)
                    hashCode = hashCode * 59 + this.DiskComponentExclusive.GetHashCode();
                if (this.DiskSelfFaultTolerant != null)
                    hashCode = hashCode * 59 + this.DiskSelfFaultTolerant.GetHashCode();
                if (this.DiskSerials != null)
                    hashCode = hashCode * 59 + this.DiskSerials.GetHashCode();
                if (this.DiskTiers != null)
                    hashCode = hashCode * 59 + this.DiskTiers.GetHashCode();
                if (this.NodeIps != null)
                    hashCode = hashCode * 59 + this.NodeIps.GetHashCode();
                if (this.UseAsComputeNode != null)
                    hashCode = hashCode * 59 + this.UseAsComputeNode.GetHashCode();
                return hashCode;
            }
        }

    }

}


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
    /// Specifies the configuration for a node in the Cluster.
    /// </summary>
    [DataContract]
    public partial class PhysicalNodeConfiguration :  IEquatable<PhysicalNodeConfiguration>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalNodeConfiguration" /> class.
        /// </summary>
        /// <param name="nodeId">Specifies the Node ID for this node..</param>
        /// <param name="nodeIp">Specifies the Node IP address for this node..</param>
        /// <param name="nodeIpmiIp">Specifies IPMI IP for this node..</param>
        /// <param name="useAsComputeNode">Specifies whether to use the Node for compute only..</param>
        public PhysicalNodeConfiguration(long? nodeId = default(long?), string nodeIp = default(string), string nodeIpmiIp = default(string), bool? useAsComputeNode = default(bool?))
        {
            this.NodeId = nodeId;
            this.NodeIp = nodeIp;
            this.NodeIpmiIp = nodeIpmiIp;
            this.UseAsComputeNode = useAsComputeNode;
            this.NodeId = nodeId;
            this.NodeIp = nodeIp;
            this.NodeIpmiIp = nodeIpmiIp;
            this.UseAsComputeNode = useAsComputeNode;
        }
        
        /// <summary>
        /// Specifies the Node ID for this node.
        /// </summary>
        /// <value>Specifies the Node ID for this node.</value>
        [DataMember(Name="nodeId", EmitDefaultValue=true)]
        public long? NodeId { get; set; }

        /// <summary>
        /// Specifies the Node IP address for this node.
        /// </summary>
        /// <value>Specifies the Node IP address for this node.</value>
        [DataMember(Name="nodeIp", EmitDefaultValue=true)]
        public string NodeIp { get; set; }

        /// <summary>
        /// Specifies IPMI IP for this node.
        /// </summary>
        /// <value>Specifies IPMI IP for this node.</value>
        [DataMember(Name="nodeIpmiIp", EmitDefaultValue=true)]
        public string NodeIpmiIp { get; set; }

        /// <summary>
        /// Specifies whether to use the Node for compute only.
        /// </summary>
        /// <value>Specifies whether to use the Node for compute only.</value>
        [DataMember(Name="useAsComputeNode", EmitDefaultValue=true)]
        public bool? UseAsComputeNode { get; set; }

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
            return this.Equals(input as PhysicalNodeConfiguration);
        }

        /// <summary>
        /// Returns true if PhysicalNodeConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of PhysicalNodeConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhysicalNodeConfiguration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NodeId == input.NodeId ||
                    (this.NodeId != null &&
                    this.NodeId.Equals(input.NodeId))
                ) && 
                (
                    this.NodeIp == input.NodeIp ||
                    (this.NodeIp != null &&
                    this.NodeIp.Equals(input.NodeIp))
                ) && 
                (
                    this.NodeIpmiIp == input.NodeIpmiIp ||
                    (this.NodeIpmiIp != null &&
                    this.NodeIpmiIp.Equals(input.NodeIpmiIp))
                ) && 
                (
                    this.UseAsComputeNode == input.UseAsComputeNode ||
                    (this.UseAsComputeNode != null &&
                    this.UseAsComputeNode.Equals(input.UseAsComputeNode))
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
                if (this.NodeId != null)
                    hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.NodeIp != null)
                    hashCode = hashCode * 59 + this.NodeIp.GetHashCode();
                if (this.NodeIpmiIp != null)
                    hashCode = hashCode * 59 + this.NodeIpmiIp.GetHashCode();
                if (this.UseAsComputeNode != null)
                    hashCode = hashCode * 59 + this.UseAsComputeNode.GetHashCode();
                return hashCode;
            }
        }

    }

}


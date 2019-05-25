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
    public partial class VirtualNodeConfiguration :  IEquatable<VirtualNodeConfiguration>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualNodeConfiguration" /> class.
        /// </summary>
        /// <param name="nodeId">Specifies the Node ID for this node..</param>
        /// <param name="nodeIp">Specifies the Node IP address for this node..</param>
        public VirtualNodeConfiguration(long? nodeId = default(long?), string nodeIp = default(string))
        {
            this.NodeId = nodeId;
            this.NodeIp = nodeIp;
            this.NodeId = nodeId;
            this.NodeIp = nodeIp;
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VirtualNodeConfiguration {\n");
            sb.Append("  NodeId: ").Append(NodeId).Append("\n");
            sb.Append("  NodeIp: ").Append(NodeIp).Append("\n");
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
            return this.Equals(input as VirtualNodeConfiguration);
        }

        /// <summary>
        /// Returns true if VirtualNodeConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of VirtualNodeConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VirtualNodeConfiguration input)
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
                return hashCode;
            }
        }

    }

}

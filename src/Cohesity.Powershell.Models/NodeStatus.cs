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
    /// Specifies the status of each node in the cluster being created.
    /// </summary>
    [DataContract]
    public partial class NodeStatus :  IEquatable<NodeStatus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeStatus" /> class.
        /// </summary>
        /// <param name="errorMessage">Specifies an optional message relating to the node status..</param>
        /// <param name="ipmiIp">Specifies the IPMI IP of the node (if physical cluster)..</param>
        /// <param name="nodeId">Specifies the ID of the node..</param>
        /// <param name="nodeIp">For physical nodes this will specify the IP address of the node..</param>
        public NodeStatus(string errorMessage = default(string), string ipmiIp = default(string), long? nodeId = default(long?), string nodeIp = default(string))
        {
            this.ErrorMessage = errorMessage;
            this.IpmiIp = ipmiIp;
            this.NodeId = nodeId;
            this.NodeIp = nodeIp;
            this.ErrorMessage = errorMessage;
            this.IpmiIp = ipmiIp;
            this.NodeId = nodeId;
            this.NodeIp = nodeIp;
        }
        
        /// <summary>
        /// Specifies an optional message relating to the node status.
        /// </summary>
        /// <value>Specifies an optional message relating to the node status.</value>
        [DataMember(Name="errorMessage", EmitDefaultValue=true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Specifies the IPMI IP of the node (if physical cluster).
        /// </summary>
        /// <value>Specifies the IPMI IP of the node (if physical cluster).</value>
        [DataMember(Name="ipmiIp", EmitDefaultValue=true)]
        public string IpmiIp { get; set; }

        /// <summary>
        /// Specifies the ID of the node.
        /// </summary>
        /// <value>Specifies the ID of the node.</value>
        [DataMember(Name="nodeId", EmitDefaultValue=true)]
        public long? NodeId { get; set; }

        /// <summary>
        /// For physical nodes this will specify the IP address of the node.
        /// </summary>
        /// <value>For physical nodes this will specify the IP address of the node.</value>
        [DataMember(Name="nodeIp", EmitDefaultValue=true)]
        public string NodeIp { get; set; }

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
            return this.Equals(input as NodeStatus);
        }

        /// <summary>
        /// Returns true if NodeStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of NodeStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NodeStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.IpmiIp == input.IpmiIp ||
                    (this.IpmiIp != null &&
                    this.IpmiIp.Equals(input.IpmiIp))
                ) && 
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
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.IpmiIp != null)
                    hashCode = hashCode * 59 + this.IpmiIp.GetHashCode();
                if (this.NodeId != null)
                    hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.NodeIp != null)
                    hashCode = hashCode * 59 + this.NodeIp.GetHashCode();
                return hashCode;
            }
        }

    }

}


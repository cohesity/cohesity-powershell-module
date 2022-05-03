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
    /// Specifies a node ID and interface tuple.
    /// </summary>
    [DataContract]
    public partial class NodeInterfacePair :  IEquatable<NodeInterfacePair>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeInterfacePair" /> class.
        /// </summary>
        /// <param name="ifaceName">Specifies the name of the interface..</param>
        /// <param name="nodeId">Specifies list of node IDs..</param>
        public NodeInterfacePair(string ifaceName = default(string), long? nodeId = default(long?))
        {
            this.IfaceName = ifaceName;
            this.NodeId = nodeId;
        }
        
        /// <summary>
        /// Specifies the name of the interface.
        /// </summary>
        /// <value>Specifies the name of the interface.</value>
        [DataMember(Name="ifaceName", EmitDefaultValue=false)]
        public string IfaceName { get; set; }

        /// <summary>
        /// Specifies list of node IDs.
        /// </summary>
        /// <value>Specifies list of node IDs.</value>
        [DataMember(Name="nodeId", EmitDefaultValue=false)]
        public long? NodeId { get; set; }

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
            return this.Equals(input as NodeInterfacePair);
        }

        /// <summary>
        /// Returns true if NodeInterfacePair instances are equal
        /// </summary>
        /// <param name="input">Instance of NodeInterfacePair to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NodeInterfacePair input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IfaceName == input.IfaceName ||
                    (this.IfaceName != null &&
                    this.IfaceName.Equals(input.IfaceName))
                ) && 
                (
                    this.NodeId == input.NodeId ||
                    (this.NodeId != null &&
                    this.NodeId.Equals(input.NodeId))
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
                if (this.IfaceName != null)
                    hashCode = hashCode * 59 + this.IfaceName.GetHashCode();
                if (this.NodeId != null)
                    hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                return hashCode;
            }
        }

    }

}


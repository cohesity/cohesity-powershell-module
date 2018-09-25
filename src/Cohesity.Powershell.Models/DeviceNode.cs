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
    /// Specifies the list of devices that need to be combined to form the storage space. Only one of the fields is populated with a device node. If the device node is a leaf node, leafNode is populated with details about the partition blocks in the file. If the device node is an intermediate node, intermediateNode is populated with a device sub-tree.
    /// </summary>
    [DataContract]
    public partial class DeviceNode :  IEquatable<DeviceNode>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceNode" /> class.
        /// </summary>
        /// <param name="intermediateNode">Specifies an intermediate node of the logical device tree..</param>
        /// <param name="leafNode">Specifies the leaf node of the device tree..</param>
        public DeviceNode(DeviceTree intermediateNode = default(DeviceTree), FilePartitionBlock leafNode = default(FilePartitionBlock))
        {
            this.IntermediateNode = intermediateNode;
            this.LeafNode = leafNode;
        }
        
        /// <summary>
        /// Specifies an intermediate node of the logical device tree.
        /// </summary>
        /// <value>Specifies an intermediate node of the logical device tree.</value>
        [DataMember(Name="intermediateNode", EmitDefaultValue=false)]
        public DeviceTree IntermediateNode { get; set; }

        /// <summary>
        /// Specifies the leaf node of the device tree.
        /// </summary>
        /// <value>Specifies the leaf node of the device tree.</value>
        [DataMember(Name="leafNode", EmitDefaultValue=false)]
        public FilePartitionBlock LeafNode { get; set; }

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
            return this.Equals(input as DeviceNode);
        }

        /// <summary>
        /// Returns true if DeviceNode instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceNode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceNode input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IntermediateNode == input.IntermediateNode ||
                    (this.IntermediateNode != null &&
                    this.IntermediateNode.Equals(input.IntermediateNode))
                ) && 
                (
                    this.LeafNode == input.LeafNode ||
                    (this.LeafNode != null &&
                    this.LeafNode.Equals(input.LeafNode))
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
                if (this.IntermediateNode != null)
                    hashCode = hashCode * 59 + this.IntermediateNode.GetHashCode();
                if (this.LeafNode != null)
                    hashCode = hashCode * 59 + this.LeafNode.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


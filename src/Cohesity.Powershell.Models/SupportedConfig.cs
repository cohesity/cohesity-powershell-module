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
    /// Lists the supported Erasure Coding options for the number of Nodes in the Cohesity Cluster. In addition, the minimum number of Nodes supported for this Cluster type is defined.
    /// </summary>
    [DataContract]
    public partial class SupportedConfig :  IEquatable<SupportedConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportedConfig" /> class.
        /// </summary>
        /// <param name="minNodesAllowed">Specifies the minimum number of Nodes supported for this Cluster type. For example, a Cohesity Cluster hosted directly on hardware must have at least 3 Nodes..</param>
        /// <param name="supportedErasureCoding">List the supported Erasure Coding options for the current number of Nodes (nodeCount) in this Cluster. Each string in the array is in the following format: \&quot;NumDataStripes:NumCodedStripes\&quot; For example if there are 3 nodes in the Cluster, the following Erasure Coding mode is returned: 2:1. See the Cohesity Dashboard help documentation for details..</param>
        public SupportedConfig(int? minNodesAllowed = default(int?), List<string> supportedErasureCoding = default(List<string>))
        {
            this.MinNodesAllowed = minNodesAllowed;
            this.SupportedErasureCoding = supportedErasureCoding;
        }
        
        /// <summary>
        /// Specifies the minimum number of Nodes supported for this Cluster type. For example, a Cohesity Cluster hosted directly on hardware must have at least 3 Nodes.
        /// </summary>
        /// <value>Specifies the minimum number of Nodes supported for this Cluster type. For example, a Cohesity Cluster hosted directly on hardware must have at least 3 Nodes.</value>
        [DataMember(Name="minNodesAllowed", EmitDefaultValue=false)]
        public int? MinNodesAllowed { get; set; }

        /// <summary>
        /// List the supported Erasure Coding options for the current number of Nodes (nodeCount) in this Cluster. Each string in the array is in the following format: \&quot;NumDataStripes:NumCodedStripes\&quot; For example if there are 3 nodes in the Cluster, the following Erasure Coding mode is returned: 2:1. See the Cohesity Dashboard help documentation for details.
        /// </summary>
        /// <value>List the supported Erasure Coding options for the current number of Nodes (nodeCount) in this Cluster. Each string in the array is in the following format: \&quot;NumDataStripes:NumCodedStripes\&quot; For example if there are 3 nodes in the Cluster, the following Erasure Coding mode is returned: 2:1. See the Cohesity Dashboard help documentation for details.</value>
        [DataMember(Name="supportedErasureCoding", EmitDefaultValue=false)]
        public List<string> SupportedErasureCoding { get; set; }

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
            return this.Equals(input as SupportedConfig);
        }

        /// <summary>
        /// Returns true if SupportedConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of SupportedConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SupportedConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MinNodesAllowed == input.MinNodesAllowed ||
                    (this.MinNodesAllowed != null &&
                    this.MinNodesAllowed.Equals(input.MinNodesAllowed))
                ) && 
                (
                    this.SupportedErasureCoding == input.SupportedErasureCoding ||
                    this.SupportedErasureCoding != null &&
                    this.SupportedErasureCoding.SequenceEqual(input.SupportedErasureCoding)
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
                if (this.MinNodesAllowed != null)
                    hashCode = hashCode * 59 + this.MinNodesAllowed.GetHashCode();
                if (this.SupportedErasureCoding != null)
                    hashCode = hashCode * 59 + this.SupportedErasureCoding.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


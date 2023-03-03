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
        /// <param name="nodeIps">Specifies the list of IPs of the new Nodes. (required).</param>
        public ExpandCloudClusterParameters(List<string> nodeIps = default(List<string>))
        {
            this.NodeIps = nodeIps;
        }
        
        /// <summary>
        /// Specifies the list of IPs of the new Nodes.
        /// </summary>
        /// <value>Specifies the list of IPs of the new Nodes.</value>
        [DataMember(Name="nodeIps", EmitDefaultValue=true)]
        public List<string> NodeIps { get; set; }

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
                    this.NodeIps == input.NodeIps ||
                    this.NodeIps != null &&
                    input.NodeIps != null &&
                    this.NodeIps.SequenceEqual(input.NodeIps)
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
                if (this.NodeIps != null)
                    hashCode = hashCode * 59 + this.NodeIps.GetHashCode();
                return hashCode;
            }
        }

    }

}


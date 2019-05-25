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
    /// Specifies a resource with IP address.
    /// </summary>
    [DataContract]
    public partial class ClusterNetworkingResourceInformation :  IEquatable<ClusterNetworkingResourceInformation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterNetworkingResourceInformation" /> class.
        /// </summary>
        /// <param name="endpoints">The endpoints by which the resource is accessible..</param>
        /// <param name="type">The type of the resource..</param>
        public ClusterNetworkingResourceInformation(List<ClusterNetworkingEndpoint> endpoints = default(List<ClusterNetworkingEndpoint>), string type = default(string))
        {
            this.Endpoints = endpoints;
            this.Type = type;
            this.Endpoints = endpoints;
            this.Type = type;
        }
        
        /// <summary>
        /// The endpoints by which the resource is accessible.
        /// </summary>
        /// <value>The endpoints by which the resource is accessible.</value>
        [DataMember(Name="endpoints", EmitDefaultValue=true)]
        public List<ClusterNetworkingEndpoint> Endpoints { get; set; }

        /// <summary>
        /// The type of the resource.
        /// </summary>
        /// <value>The type of the resource.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusterNetworkingResourceInformation {\n");
            sb.Append("  Endpoints: ").Append(Endpoints).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as ClusterNetworkingResourceInformation);
        }

        /// <summary>
        /// Returns true if ClusterNetworkingResourceInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of ClusterNetworkingResourceInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClusterNetworkingResourceInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Endpoints == input.Endpoints ||
                    this.Endpoints != null &&
                    input.Endpoints != null &&
                    this.Endpoints.SequenceEqual(input.Endpoints)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Endpoints != null)
                    hashCode = hashCode * 59 + this.Endpoints.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}

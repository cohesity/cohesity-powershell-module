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
    /// Specifies information about an Isilon Cluster.
    /// </summary>
    [DataContract]
    public partial class IsilonCluster :  IEquatable<IsilonCluster>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IsilonCluster" /> class.
        /// </summary>
        /// <param name="description">Specifies the description of an Isilon Cluster..</param>
        /// <param name="guid">Specifies a globally unique id of an Isilon Cluster..</param>
        public IsilonCluster(string description = default(string), string guid = default(string))
        {
            this.Description = description;
            this.Guid = guid;
            this.Description = description;
            this.Guid = guid;
        }
        
        /// <summary>
        /// Specifies the description of an Isilon Cluster.
        /// </summary>
        /// <value>Specifies the description of an Isilon Cluster.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies a globally unique id of an Isilon Cluster.
        /// </summary>
        /// <value>Specifies a globally unique id of an Isilon Cluster.</value>
        [DataMember(Name="guid", EmitDefaultValue=true)]
        public string Guid { get; set; }

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
            return this.Equals(input as IsilonCluster);
        }

        /// <summary>
        /// Returns true if IsilonCluster instances are equal
        /// </summary>
        /// <param name="input">Instance of IsilonCluster to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IsilonCluster input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Guid == input.Guid ||
                    (this.Guid != null &&
                    this.Guid.Equals(input.Guid))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Guid != null)
                    hashCode = hashCode * 59 + this.Guid.GetHashCode();
                return hashCode;
            }
        }

    }

}


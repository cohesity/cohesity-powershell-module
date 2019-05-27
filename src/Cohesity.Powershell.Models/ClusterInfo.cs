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
    /// ClusterInfo
    /// </summary>
    [DataContract]
    public partial class ClusterInfo :  IEquatable<ClusterInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterInfo" /> class.
        /// </summary>
        /// <param name="clusterId">Specifies the id of the cluster..</param>
        /// <param name="incarnationId">Specifies the incarnation id of the cluster..</param>
        public ClusterInfo(long? clusterId = default(long?), long? incarnationId = default(long?))
        {
            this.ClusterId = clusterId;
            this.IncarnationId = incarnationId;
            this.ClusterId = clusterId;
            this.IncarnationId = incarnationId;
        }
        
        /// <summary>
        /// Specifies the id of the cluster.
        /// </summary>
        /// <value>Specifies the id of the cluster.</value>
        [DataMember(Name="clusterId", EmitDefaultValue=true)]
        public long? ClusterId { get; set; }

        /// <summary>
        /// Specifies the incarnation id of the cluster.
        /// </summary>
        /// <value>Specifies the incarnation id of the cluster.</value>
        [DataMember(Name="incarnationId", EmitDefaultValue=true)]
        public long? IncarnationId { get; set; }

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
            return this.Equals(input as ClusterInfo);
        }

        /// <summary>
        /// Returns true if ClusterInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ClusterInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClusterInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterId == input.ClusterId ||
                    (this.ClusterId != null &&
                    this.ClusterId.Equals(input.ClusterId))
                ) && 
                (
                    this.IncarnationId == input.IncarnationId ||
                    (this.IncarnationId != null &&
                    this.IncarnationId.Equals(input.IncarnationId))
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
                if (this.ClusterId != null)
                    hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.IncarnationId != null)
                    hashCode = hashCode * 59 + this.IncarnationId.GetHashCode();
                return hashCode;
            }
        }

    }

}


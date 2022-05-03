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
    /// ClusterIdentifier
    /// </summary>
    [DataContract]
    public partial class ClusterIdentifier :  IEquatable<ClusterIdentifier>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterIdentifier" /> class.
        /// </summary>
        /// <param name="clusterId">Specifies the cluster id of the cluster..</param>
        /// <param name="clusterIncarnationId">Specifies the cluster incarnation id..</param>
        public ClusterIdentifier(long? clusterId = default(long?), long? clusterIncarnationId = default(long?))
        {
            this.ClusterId = clusterId;
            this.ClusterIncarnationId = clusterIncarnationId;
        }
        
        /// <summary>
        /// Specifies the cluster id of the cluster.
        /// </summary>
        /// <value>Specifies the cluster id of the cluster.</value>
        [DataMember(Name="clusterId", EmitDefaultValue=false)]
        public long? ClusterId { get; set; }

        /// <summary>
        /// Specifies the cluster incarnation id.
        /// </summary>
        /// <value>Specifies the cluster incarnation id.</value>
        [DataMember(Name="clusterIncarnationId", EmitDefaultValue=false)]
        public long? ClusterIncarnationId { get; set; }

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
            return this.Equals(input as ClusterIdentifier);
        }

        /// <summary>
        /// Returns true if ClusterIdentifier instances are equal
        /// </summary>
        /// <param name="input">Instance of ClusterIdentifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClusterIdentifier input)
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
                    this.ClusterIncarnationId == input.ClusterIncarnationId ||
                    (this.ClusterIncarnationId != null &&
                    this.ClusterIncarnationId.Equals(input.ClusterIncarnationId))
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
                if (this.ClusterIncarnationId != null)
                    hashCode = hashCode * 59 + this.ClusterIncarnationId.GetHashCode();
                return hashCode;
            }
        }

    }

}


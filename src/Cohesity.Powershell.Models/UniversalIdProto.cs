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
    /// UniversalIdProto
    /// </summary>
    [DataContract]
    public partial class UniversalIdProto :  IEquatable<UniversalIdProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UniversalIdProto" /> class.
        /// </summary>
        /// <param name="clusterId">The id of the cluster at which the object was created..</param>
        /// <param name="clusterIncarnationId">The incarnation id of the above cluster..</param>
        /// <param name="objectId">The object id - this is unique within the above cluster..</param>
        public UniversalIdProto(long? clusterId = default(long?), long? clusterIncarnationId = default(long?), long? objectId = default(long?))
        {
            this.ClusterId = clusterId;
            this.ClusterIncarnationId = clusterIncarnationId;
            this.ObjectId = objectId;
            this.ClusterId = clusterId;
            this.ClusterIncarnationId = clusterIncarnationId;
            this.ObjectId = objectId;
        }
        
        /// <summary>
        /// The id of the cluster at which the object was created.
        /// </summary>
        /// <value>The id of the cluster at which the object was created.</value>
        [DataMember(Name="clusterId", EmitDefaultValue=true)]
        public long? ClusterId { get; set; }

        /// <summary>
        /// The incarnation id of the above cluster.
        /// </summary>
        /// <value>The incarnation id of the above cluster.</value>
        [DataMember(Name="clusterIncarnationId", EmitDefaultValue=true)]
        public long? ClusterIncarnationId { get; set; }

        /// <summary>
        /// The object id - this is unique within the above cluster.
        /// </summary>
        /// <value>The object id - this is unique within the above cluster.</value>
        [DataMember(Name="objectId", EmitDefaultValue=true)]
        public long? ObjectId { get; set; }

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
            return this.Equals(input as UniversalIdProto);
        }

        /// <summary>
        /// Returns true if UniversalIdProto instances are equal
        /// </summary>
        /// <param name="input">Instance of UniversalIdProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UniversalIdProto input)
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
                ) && 
                (
                    this.ObjectId == input.ObjectId ||
                    (this.ObjectId != null &&
                    this.ObjectId.Equals(input.ObjectId))
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
                if (this.ObjectId != null)
                    hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                return hashCode;
            }
        }

    }

}


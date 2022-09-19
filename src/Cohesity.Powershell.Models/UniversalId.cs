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
    /// Specifies an id for an object that is unique across Cohesity Clusters. The id is composite of all the ids listed below.
    /// </summary>
    [DataContract]
    public partial class UniversalId :  IEquatable<UniversalId>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UniversalId" /> class.
        /// </summary>
        /// <param name="clusterId">Specifies the Cohesity Cluster id where the object was created..</param>
        /// <param name="clusterIncarnationId">Specifies an id for the Cohesity Cluster that is generated when a Cohesity Cluster is initially created..</param>
        /// <param name="id">Specifies a unique id assigned to an object (such as a Job) by the Cohesity Cluster..</param>
        public UniversalId(long? clusterId = default(long?), long? clusterIncarnationId = default(long?), long? id = default(long?))
        {
            this.ClusterId = clusterId;
            this.ClusterIncarnationId = clusterIncarnationId;
            this.Id = id;
            this.ClusterId = clusterId;
            this.ClusterIncarnationId = clusterIncarnationId;
            this.Id = id;
        }
        
        /// <summary>
        /// Specifies the Cohesity Cluster id where the object was created.
        /// </summary>
        /// <value>Specifies the Cohesity Cluster id where the object was created.</value>
        [DataMember(Name="clusterId", EmitDefaultValue=true)]
        public long? ClusterId { get; set; }

        /// <summary>
        /// Specifies an id for the Cohesity Cluster that is generated when a Cohesity Cluster is initially created.
        /// </summary>
        /// <value>Specifies an id for the Cohesity Cluster that is generated when a Cohesity Cluster is initially created.</value>
        [DataMember(Name="clusterIncarnationId", EmitDefaultValue=true)]
        public long? ClusterIncarnationId { get; set; }

        /// <summary>
        /// Specifies a unique id assigned to an object (such as a Job) by the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies a unique id assigned to an object (such as a Job) by the Cohesity Cluster.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

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
            return this.Equals(input as UniversalId);
        }

        /// <summary>
        /// Returns true if UniversalId instances are equal
        /// </summary>
        /// <param name="input">Instance of UniversalId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UniversalId input)
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                return hashCode;
            }
        }

    }

}


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
    /// Specifies an Object containing information about a mongodb cluster.
    /// </summary>
    [DataContract]
    public partial class MongoDBPhysicalCluster :  IEquatable<MongoDBPhysicalCluster>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MongoDBPhysicalCluster" /> class.
        /// </summary>
        /// <param name="clusterId">Specifies the Cluster ID for the MongoDB Cluster..</param>
        /// <param name="hasReplicaSet">Specifies if the MongoDB cluster has replica set..</param>
        /// <param name="hostEndpoints">Specifies the list of endpoints for the MongoDB vluster..</param>
        /// <param name="mongodbServerProcesses">Specifies the Server process count for the MongoDB entity..</param>
        /// <param name="mongodbVersion">Specifies the MongoDb version for the MongoDB Cluster..</param>
        /// <param name="shardsCount">Specifies the sharded count for  MongoDB Cluster..</param>
        public MongoDBPhysicalCluster(string clusterId = default(string), bool? hasReplicaSet = default(bool?), List<string> hostEndpoints = default(List<string>), int? mongodbServerProcesses = default(int?), string mongodbVersion = default(string), long? shardsCount = default(long?))
        {
            this.ClusterId = clusterId;
            this.HasReplicaSet = hasReplicaSet;
            this.HostEndpoints = hostEndpoints;
            this.MongodbServerProcesses = mongodbServerProcesses;
            this.MongodbVersion = mongodbVersion;
            this.ShardsCount = shardsCount;
            this.ClusterId = clusterId;
            this.HasReplicaSet = hasReplicaSet;
            this.HostEndpoints = hostEndpoints;
            this.MongodbServerProcesses = mongodbServerProcesses;
            this.MongodbVersion = mongodbVersion;
            this.ShardsCount = shardsCount;
        }
        
        /// <summary>
        /// Specifies the Cluster ID for the MongoDB Cluster.
        /// </summary>
        /// <value>Specifies the Cluster ID for the MongoDB Cluster.</value>
        [DataMember(Name="clusterId", EmitDefaultValue=true)]
        public string ClusterId { get; set; }

        /// <summary>
        /// Specifies if the MongoDB cluster has replica set.
        /// </summary>
        /// <value>Specifies if the MongoDB cluster has replica set.</value>
        [DataMember(Name="hasReplicaSet", EmitDefaultValue=true)]
        public bool? HasReplicaSet { get; set; }

        /// <summary>
        /// Specifies the list of endpoints for the MongoDB vluster.
        /// </summary>
        /// <value>Specifies the list of endpoints for the MongoDB vluster.</value>
        [DataMember(Name="hostEndpoints", EmitDefaultValue=true)]
        public List<string> HostEndpoints { get; set; }

        /// <summary>
        /// Specifies the Server process count for the MongoDB entity.
        /// </summary>
        /// <value>Specifies the Server process count for the MongoDB entity.</value>
        [DataMember(Name="mongodbServerProcesses", EmitDefaultValue=true)]
        public int? MongodbServerProcesses { get; set; }

        /// <summary>
        /// Specifies the MongoDb version for the MongoDB Cluster.
        /// </summary>
        /// <value>Specifies the MongoDb version for the MongoDB Cluster.</value>
        [DataMember(Name="mongodbVersion", EmitDefaultValue=true)]
        public string MongodbVersion { get; set; }

        /// <summary>
        /// Specifies the sharded count for  MongoDB Cluster.
        /// </summary>
        /// <value>Specifies the sharded count for  MongoDB Cluster.</value>
        [DataMember(Name="shardsCount", EmitDefaultValue=true)]
        public long? ShardsCount { get; set; }

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
            return this.Equals(input as MongoDBPhysicalCluster);
        }

        /// <summary>
        /// Returns true if MongoDBPhysicalCluster instances are equal
        /// </summary>
        /// <param name="input">Instance of MongoDBPhysicalCluster to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MongoDBPhysicalCluster input)
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
                    this.HasReplicaSet == input.HasReplicaSet ||
                    (this.HasReplicaSet != null &&
                    this.HasReplicaSet.Equals(input.HasReplicaSet))
                ) && 
                (
                    this.HostEndpoints == input.HostEndpoints ||
                    this.HostEndpoints != null &&
                    input.HostEndpoints != null &&
                    this.HostEndpoints.SequenceEqual(input.HostEndpoints)
                ) && 
                (
                    this.MongodbServerProcesses == input.MongodbServerProcesses ||
                    (this.MongodbServerProcesses != null &&
                    this.MongodbServerProcesses.Equals(input.MongodbServerProcesses))
                ) && 
                (
                    this.MongodbVersion == input.MongodbVersion ||
                    (this.MongodbVersion != null &&
                    this.MongodbVersion.Equals(input.MongodbVersion))
                ) && 
                (
                    this.ShardsCount == input.ShardsCount ||
                    (this.ShardsCount != null &&
                    this.ShardsCount.Equals(input.ShardsCount))
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
                if (this.HasReplicaSet != null)
                    hashCode = hashCode * 59 + this.HasReplicaSet.GetHashCode();
                if (this.HostEndpoints != null)
                    hashCode = hashCode * 59 + this.HostEndpoints.GetHashCode();
                if (this.MongodbServerProcesses != null)
                    hashCode = hashCode * 59 + this.MongodbServerProcesses.GetHashCode();
                if (this.MongodbVersion != null)
                    hashCode = hashCode * 59 + this.MongodbVersion.GetHashCode();
                if (this.ShardsCount != null)
                    hashCode = hashCode * 59 + this.ShardsCount.GetHashCode();
                return hashCode;
            }
        }

    }

}


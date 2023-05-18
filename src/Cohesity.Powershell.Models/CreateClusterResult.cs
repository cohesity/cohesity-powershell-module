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
    /// Specifies the immediate result of a Cluster creation request. Contains validation results for each node. If the request is valid, it also indicates that the individual node bringup operation is started in the background.
    /// </summary>
    [DataContract]
    public partial class CreateClusterResult :  IEquatable<CreateClusterResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClusterResult" /> class.
        /// </summary>
        /// <param name="clusterId">Specifies the ID of the new Cluster..</param>
        /// <param name="clusterName">Specifies the name of the new Cluster..</param>
        /// <param name="clusterSwVersion">Specifies the software version of the new Cluster..</param>
        /// <param name="healthyNodes">Specifies the status of the Nodes in the Cluster. All Nodes that are accepted to the Cluster are appended to this list..</param>
        /// <param name="incarnationId">Specifies the Incarnation ID of the new Cluster..</param>
        /// <param name="message">Specifies an optional message field..</param>
        /// <param name="unhealthyNodes">Specifies the status of the Nodes in the Cluster. All Nodes that are not accepted to the Cluster are appended to this list..</param>
        public CreateClusterResult(long? clusterId = default(long?), string clusterName = default(string), string clusterSwVersion = default(string), List<NodeStatus> healthyNodes = default(List<NodeStatus>), long? incarnationId = default(long?), string message = default(string), List<NodeStatus> unhealthyNodes = default(List<NodeStatus>))
        {
            this.ClusterId = clusterId;
            this.ClusterName = clusterName;
            this.ClusterSwVersion = clusterSwVersion;
            this.HealthyNodes = healthyNodes;
            this.IncarnationId = incarnationId;
            this.Message = message;
            this.UnhealthyNodes = unhealthyNodes;
            this.ClusterId = clusterId;
            this.ClusterName = clusterName;
            this.ClusterSwVersion = clusterSwVersion;
            this.HealthyNodes = healthyNodes;
            this.IncarnationId = incarnationId;
            this.Message = message;
            this.UnhealthyNodes = unhealthyNodes;
        }
        
        /// <summary>
        /// Specifies the ID of the new Cluster.
        /// </summary>
        /// <value>Specifies the ID of the new Cluster.</value>
        [DataMember(Name="clusterId", EmitDefaultValue=true)]
        public long? ClusterId { get; set; }

        /// <summary>
        /// Specifies the name of the new Cluster.
        /// </summary>
        /// <value>Specifies the name of the new Cluster.</value>
        [DataMember(Name="clusterName", EmitDefaultValue=true)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Specifies the software version of the new Cluster.
        /// </summary>
        /// <value>Specifies the software version of the new Cluster.</value>
        [DataMember(Name="clusterSwVersion", EmitDefaultValue=true)]
        public string ClusterSwVersion { get; set; }

        /// <summary>
        /// Specifies the status of the Nodes in the Cluster. All Nodes that are accepted to the Cluster are appended to this list.
        /// </summary>
        /// <value>Specifies the status of the Nodes in the Cluster. All Nodes that are accepted to the Cluster are appended to this list.</value>
        [DataMember(Name="healthyNodes", EmitDefaultValue=true)]
        public List<NodeStatus> HealthyNodes { get; set; }

        /// <summary>
        /// Specifies the Incarnation ID of the new Cluster.
        /// </summary>
        /// <value>Specifies the Incarnation ID of the new Cluster.</value>
        [DataMember(Name="incarnationId", EmitDefaultValue=true)]
        public long? IncarnationId { get; set; }

        /// <summary>
        /// Specifies an optional message field.
        /// </summary>
        /// <value>Specifies an optional message field.</value>
        [DataMember(Name="message", EmitDefaultValue=true)]
        public string Message { get; set; }

        /// <summary>
        /// Specifies the status of the Nodes in the Cluster. All Nodes that are not accepted to the Cluster are appended to this list.
        /// </summary>
        /// <value>Specifies the status of the Nodes in the Cluster. All Nodes that are not accepted to the Cluster are appended to this list.</value>
        [DataMember(Name="unhealthyNodes", EmitDefaultValue=true)]
        public List<NodeStatus> UnhealthyNodes { get; set; }

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
            return this.Equals(input as CreateClusterResult);
        }

        /// <summary>
        /// Returns true if CreateClusterResult instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateClusterResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateClusterResult input)
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
                    this.ClusterName == input.ClusterName ||
                    (this.ClusterName != null &&
                    this.ClusterName.Equals(input.ClusterName))
                ) && 
                (
                    this.ClusterSwVersion == input.ClusterSwVersion ||
                    (this.ClusterSwVersion != null &&
                    this.ClusterSwVersion.Equals(input.ClusterSwVersion))
                ) && 
                (
                    this.HealthyNodes == input.HealthyNodes ||
                    this.HealthyNodes != null &&
                    input.HealthyNodes != null &&
                    this.HealthyNodes.SequenceEqual(input.HealthyNodes)
                ) && 
                (
                    this.IncarnationId == input.IncarnationId ||
                    (this.IncarnationId != null &&
                    this.IncarnationId.Equals(input.IncarnationId))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.UnhealthyNodes == input.UnhealthyNodes ||
                    this.UnhealthyNodes != null &&
                    input.UnhealthyNodes != null &&
                    this.UnhealthyNodes.SequenceEqual(input.UnhealthyNodes)
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
                if (this.ClusterName != null)
                    hashCode = hashCode * 59 + this.ClusterName.GetHashCode();
                if (this.ClusterSwVersion != null)
                    hashCode = hashCode * 59 + this.ClusterSwVersion.GetHashCode();
                if (this.HealthyNodes != null)
                    hashCode = hashCode * 59 + this.HealthyNodes.GetHashCode();
                if (this.IncarnationId != null)
                    hashCode = hashCode * 59 + this.IncarnationId.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.UnhealthyNodes != null)
                    hashCode = hashCode * 59 + this.UnhealthyNodes.GetHashCode();
                return hashCode;
            }
        }

    }

}


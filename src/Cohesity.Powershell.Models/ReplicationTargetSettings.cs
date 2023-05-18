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
    /// Specifies settings about the Remote Cohesity Cluster where Snapshots are copied to.
    /// </summary>
    [DataContract]
    public partial class ReplicationTargetSettings :  IEquatable<ReplicationTargetSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationTargetSettings" /> class.
        /// </summary>
        /// <param name="clusterId">Specifies the id of the Remote Cluster..</param>
        /// <param name="clusterName">Specifies the name of the Remote Cluster..</param>
        public ReplicationTargetSettings(long? clusterId = default(long?), string clusterName = default(string))
        {
            this.ClusterId = clusterId;
            this.ClusterName = clusterName;
            this.ClusterId = clusterId;
            this.ClusterName = clusterName;
        }
        
        /// <summary>
        /// Specifies the id of the Remote Cluster.
        /// </summary>
        /// <value>Specifies the id of the Remote Cluster.</value>
        [DataMember(Name="clusterId", EmitDefaultValue=true)]
        public long? ClusterId { get; set; }

        /// <summary>
        /// Specifies the name of the Remote Cluster.
        /// </summary>
        /// <value>Specifies the name of the Remote Cluster.</value>
        [DataMember(Name="clusterName", EmitDefaultValue=true)]
        public string ClusterName { get; set; }

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
            return this.Equals(input as ReplicationTargetSettings);
        }

        /// <summary>
        /// Returns true if ReplicationTargetSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of ReplicationTargetSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReplicationTargetSettings input)
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
                return hashCode;
            }
        }

    }

}


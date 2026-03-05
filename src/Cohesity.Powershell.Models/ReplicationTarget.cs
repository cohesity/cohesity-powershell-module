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
    /// Message that specifies the details about a remote cluster where backup snapshots may be replicated to.
    /// </summary>
    [DataContract]
    public partial class ReplicationTarget :  IEquatable<ReplicationTarget>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationTarget" /> class.
        /// </summary>
        /// <param name="clusterId">The id of the remote cluster..</param>
        /// <param name="clusterName">The name of the remote cluster..</param>
        /// <param name="ownershipContext">OwnershipContext of a replication target. By default all regular replication targets have the value of kOwnershipContextLocal. Replication targets configured for Onprem FortKnox will have the value of kOwnershipContextOnpremVault. Onprem FortKnox use same replication mechanism behind the scene, except a few differences as follows: 1. The Onprem FortKnox vaults are configured on Rx and auto synced to Tx. On Tx the vault configurations are read only. 2. During replication the connection is initiated from Rx, then Tx uses the connection to perform replication. Tx does not know the IP address of the Rx. 3. The Onprem FortKnox vaults use vault windows to control when replication can happen. Replication outside of vault windows will wait for the next window. Note: This proto message is encapsulated in various other protos and this field may not always be valid/correctly set. It is set correctly in the context of a policy..</param>
        public ReplicationTarget(long? clusterId = default(long?), string clusterName = default(string), int? ownershipContext = default(int?))
        {
            this.ClusterId = clusterId;
            this.ClusterName = clusterName;
            this.OwnershipContext = ownershipContext;
            this.ClusterId = clusterId;
            this.ClusterName = clusterName;
            this.OwnershipContext = ownershipContext;
        }
        
        /// <summary>
        /// The id of the remote cluster.
        /// </summary>
        /// <value>The id of the remote cluster.</value>
        [DataMember(Name="clusterId", EmitDefaultValue=true)]
        public long? ClusterId { get; set; }

        /// <summary>
        /// The name of the remote cluster.
        /// </summary>
        /// <value>The name of the remote cluster.</value>
        [DataMember(Name="clusterName", EmitDefaultValue=true)]
        public string ClusterName { get; set; }

        /// <summary>
        /// OwnershipContext of a replication target. By default all regular replication targets have the value of kOwnershipContextLocal. Replication targets configured for Onprem FortKnox will have the value of kOwnershipContextOnpremVault. Onprem FortKnox use same replication mechanism behind the scene, except a few differences as follows: 1. The Onprem FortKnox vaults are configured on Rx and auto synced to Tx. On Tx the vault configurations are read only. 2. During replication the connection is initiated from Rx, then Tx uses the connection to perform replication. Tx does not know the IP address of the Rx. 3. The Onprem FortKnox vaults use vault windows to control when replication can happen. Replication outside of vault windows will wait for the next window. Note: This proto message is encapsulated in various other protos and this field may not always be valid/correctly set. It is set correctly in the context of a policy.
        /// </summary>
        /// <value>OwnershipContext of a replication target. By default all regular replication targets have the value of kOwnershipContextLocal. Replication targets configured for Onprem FortKnox will have the value of kOwnershipContextOnpremVault. Onprem FortKnox use same replication mechanism behind the scene, except a few differences as follows: 1. The Onprem FortKnox vaults are configured on Rx and auto synced to Tx. On Tx the vault configurations are read only. 2. During replication the connection is initiated from Rx, then Tx uses the connection to perform replication. Tx does not know the IP address of the Rx. 3. The Onprem FortKnox vaults use vault windows to control when replication can happen. Replication outside of vault windows will wait for the next window. Note: This proto message is encapsulated in various other protos and this field may not always be valid/correctly set. It is set correctly in the context of a policy.</value>
        [DataMember(Name="ownershipContext", EmitDefaultValue=true)]
        public int? OwnershipContext { get; set; }

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
            return this.Equals(input as ReplicationTarget);
        }

        /// <summary>
        /// Returns true if ReplicationTarget instances are equal
        /// </summary>
        /// <param name="input">Instance of ReplicationTarget to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReplicationTarget input)
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
                    this.OwnershipContext == input.OwnershipContext ||
                    (this.OwnershipContext != null &&
                    this.OwnershipContext.Equals(input.OwnershipContext))
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
                if (this.OwnershipContext != null)
                    hashCode = hashCode * 59 + this.OwnershipContext.GetHashCode();
                return hashCode;
            }
        }

    }

}


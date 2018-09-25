// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// Specifies settings about a target where a copied Snapshot is stored. A target can be a Remote Cluster or an Archival External Target such as AWS or Tape.
    /// </summary>
    [DataContract]
    public partial class SnapshotTarget :  IEquatable<SnapshotTarget>
    {
        /// <summary>
        /// Specifies the type of a Snapshot target such as &#39;kLocal&#39;, &#39;kRemote&#39; or &#39;kArchival&#39;. &#39;kLocal&#39; means the Snapshot is stored on a local Cohesity Cluster. &#39;kRemote&#39; means the Snapshot is stored on a Remote Cohesity Cluster. (It was copied to the Remote Cohesity Cluster using replication.) &#39;kArchival&#39; means the Snapshot is stored on a Archival External Target (such as Tape or AWS).
        /// </summary>
        /// <value>Specifies the type of a Snapshot target such as &#39;kLocal&#39;, &#39;kRemote&#39; or &#39;kArchival&#39;. &#39;kLocal&#39; means the Snapshot is stored on a local Cohesity Cluster. &#39;kRemote&#39; means the Snapshot is stored on a Remote Cohesity Cluster. (It was copied to the Remote Cohesity Cluster using replication.) &#39;kArchival&#39; means the Snapshot is stored on a Archival External Target (such as Tape or AWS).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum KLocal for value: kLocal
            /// </summary>
            [EnumMember(Value = "kLocal")]
            KLocal = 1,
            
            /// <summary>
            /// Enum KRemote for value: kRemote
            /// </summary>
            [EnumMember(Value = "kRemote")]
            KRemote = 2,
            
            /// <summary>
            /// Enum KArchival for value: kArchival
            /// </summary>
            [EnumMember(Value = "kArchival")]
            KArchival = 3
        }

        /// <summary>
        /// Specifies the type of a Snapshot target such as &#39;kLocal&#39;, &#39;kRemote&#39; or &#39;kArchival&#39;. &#39;kLocal&#39; means the Snapshot is stored on a local Cohesity Cluster. &#39;kRemote&#39; means the Snapshot is stored on a Remote Cohesity Cluster. (It was copied to the Remote Cohesity Cluster using replication.) &#39;kArchival&#39; means the Snapshot is stored on a Archival External Target (such as Tape or AWS).
        /// </summary>
        /// <value>Specifies the type of a Snapshot target such as &#39;kLocal&#39;, &#39;kRemote&#39; or &#39;kArchival&#39;. &#39;kLocal&#39; means the Snapshot is stored on a local Cohesity Cluster. &#39;kRemote&#39; means the Snapshot is stored on a Remote Cohesity Cluster. (It was copied to the Remote Cohesity Cluster using replication.) &#39;kArchival&#39; means the Snapshot is stored on a Archival External Target (such as Tape or AWS).</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SnapshotTarget" /> class.
        /// </summary>
        /// <param name="archivalTarget">Specifies the Archival External Target for storing a copied Snapshot. If the type is not &#39;kLocal&#39;, either a replicationTarget or archivalTarget must be specified..</param>
        /// <param name="replicationTarget">Specifies the replication target (Remote Cluster) for storing a copied Snapshot. If the type is not &#39;kLocal&#39;, either a replicationTarget or archivalTarget must be specified..</param>
        /// <param name="type">Specifies the type of a Snapshot target such as &#39;kLocal&#39;, &#39;kRemote&#39; or &#39;kArchival&#39;. &#39;kLocal&#39; means the Snapshot is stored on a local Cohesity Cluster. &#39;kRemote&#39; means the Snapshot is stored on a Remote Cohesity Cluster. (It was copied to the Remote Cohesity Cluster using replication.) &#39;kArchival&#39; means the Snapshot is stored on a Archival External Target (such as Tape or AWS)..</param>
        public SnapshotTarget(ArchivalTarget archivalTarget = default(ArchivalTarget), ReplicationTarget replicationTarget = default(ReplicationTarget), TypeEnum? type = default(TypeEnum?))
        {
            this.ArchivalTarget = archivalTarget;
            this.ReplicationTarget = replicationTarget;
            this.Type = type;
        }
        
        /// <summary>
        /// Specifies the Archival External Target for storing a copied Snapshot. If the type is not &#39;kLocal&#39;, either a replicationTarget or archivalTarget must be specified.
        /// </summary>
        /// <value>Specifies the Archival External Target for storing a copied Snapshot. If the type is not &#39;kLocal&#39;, either a replicationTarget or archivalTarget must be specified.</value>
        [DataMember(Name="archivalTarget", EmitDefaultValue=false)]
        public ArchivalTarget ArchivalTarget { get; set; }

        /// <summary>
        /// Specifies the replication target (Remote Cluster) for storing a copied Snapshot. If the type is not &#39;kLocal&#39;, either a replicationTarget or archivalTarget must be specified.
        /// </summary>
        /// <value>Specifies the replication target (Remote Cluster) for storing a copied Snapshot. If the type is not &#39;kLocal&#39;, either a replicationTarget or archivalTarget must be specified.</value>
        [DataMember(Name="replicationTarget", EmitDefaultValue=false)]
        public ReplicationTarget ReplicationTarget { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
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
            return this.Equals(input as SnapshotTarget);
        }

        /// <summary>
        /// Returns true if SnapshotTarget instances are equal
        /// </summary>
        /// <param name="input">Instance of SnapshotTarget to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SnapshotTarget input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ArchivalTarget == input.ArchivalTarget ||
                    (this.ArchivalTarget != null &&
                    this.ArchivalTarget.Equals(input.ArchivalTarget))
                ) && 
                (
                    this.ReplicationTarget == input.ReplicationTarget ||
                    (this.ReplicationTarget != null &&
                    this.ReplicationTarget.Equals(input.ReplicationTarget))
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
                if (this.ArchivalTarget != null)
                    hashCode = hashCode * 59 + this.ArchivalTarget.GetHashCode();
                if (this.ReplicationTarget != null)
                    hashCode = hashCode * 59 + this.ReplicationTarget.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


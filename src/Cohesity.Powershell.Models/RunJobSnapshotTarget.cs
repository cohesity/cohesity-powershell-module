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
    /// RunJobSnapshotTarget
    /// </summary>
    [DataContract]
    public partial class RunJobSnapshotTarget :  IEquatable<RunJobSnapshotTarget>
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
        /// Initializes a new instance of the <see cref="RunJobSnapshotTarget" /> class.
        /// </summary>
        /// <param name="archivalTarget">Specifies the Archival External Target for storing a copied Snapshot. If the type is not &#39;kLocal&#39;, either a replicationTarget or archivalTarget must be specified..</param>
        /// <param name="daysToKeep">Specifies the number of days to retain copied Snapshots on the target..</param>
        /// <param name="replicationTarget">Specifies the replication target (Remote Cluster) for storing a copied Snapshot. If the type is not &#39;kLocal&#39;, either a replicationTarget or archivalTarget must be specified..</param>
        /// <param name="type">Specifies the type of a Snapshot target such as &#39;kLocal&#39;, &#39;kRemote&#39; or &#39;kArchival&#39;. &#39;kLocal&#39; means the Snapshot is stored on a local Cohesity Cluster. &#39;kRemote&#39; means the Snapshot is stored on a Remote Cohesity Cluster. (It was copied to the Remote Cohesity Cluster using replication.) &#39;kArchival&#39; means the Snapshot is stored on a Archival External Target (such as Tape or AWS)..</param>
        public RunJobSnapshotTarget(ArchivalTarget archivalTarget = default(ArchivalTarget), long? daysToKeep = default(long?), ReplicationTarget replicationTarget = default(ReplicationTarget), TypeEnum? type = default(TypeEnum?))
        {
            this.ArchivalTarget = archivalTarget;
            this.DaysToKeep = daysToKeep;
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
        /// Specifies the number of days to retain copied Snapshots on the target.
        /// </summary>
        /// <value>Specifies the number of days to retain copied Snapshots on the target.</value>
        [DataMember(Name="daysToKeep", EmitDefaultValue=false)]
        public long? DaysToKeep { get; set; }

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
            return this.Equals(input as RunJobSnapshotTarget);
        }

        /// <summary>
        /// Returns true if RunJobSnapshotTarget instances are equal
        /// </summary>
        /// <param name="input">Instance of RunJobSnapshotTarget to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RunJobSnapshotTarget input)
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
                    this.DaysToKeep == input.DaysToKeep ||
                    (this.DaysToKeep != null &&
                    this.DaysToKeep.Equals(input.DaysToKeep))
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
                if (this.DaysToKeep != null)
                    hashCode = hashCode * 59 + this.DaysToKeep.GetHashCode();
                if (this.ReplicationTarget != null)
                    hashCode = hashCode * 59 + this.ReplicationTarget.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


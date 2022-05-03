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
    /// Specifies settings about a target where a copied Snapshot is stored. A target can be a Remote Cluster or an Archival External Target such as AWS or Tape.
    /// </summary>
    [DataContract]
    public partial class SnapshotTargetSettings :  IEquatable<SnapshotTargetSettings>
    {
        /// <summary>
        /// Specifies the type of a Snapshot target such as &#39;kLocal&#39;, &#39;kRemote&#39; or &#39;kArchival&#39;. &#39;kLocal&#39; means the Snapshot is stored on a local Cohesity Cluster. &#39;kRemote&#39; means the Snapshot is stored on a Remote Cohesity Cluster. (It was copied to the Remote Cohesity Cluster using replication.) &#39;kArchival&#39; means the Snapshot is stored on a Archival External Target (such as Tape or AWS). &#39;kCloudDeploy&#39; means the Snapshot is stored on a Cloud platform.
        /// </summary>
        /// <value>Specifies the type of a Snapshot target such as &#39;kLocal&#39;, &#39;kRemote&#39; or &#39;kArchival&#39;. &#39;kLocal&#39; means the Snapshot is stored on a local Cohesity Cluster. &#39;kRemote&#39; means the Snapshot is stored on a Remote Cohesity Cluster. (It was copied to the Remote Cohesity Cluster using replication.) &#39;kArchival&#39; means the Snapshot is stored on a Archival External Target (such as Tape or AWS). &#39;kCloudDeploy&#39; means the Snapshot is stored on a Cloud platform.</value>
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
            KArchival = 3,

            /// <summary>
            /// Enum KCloudDeploy for value: kCloudDeploy
            /// </summary>
            [EnumMember(Value = "kCloudDeploy")]
            KCloudDeploy = 4,

            /// <summary>
            /// Enum KCloudReplication for value: kCloudReplication
            /// </summary>
            [EnumMember(Value = "kCloudReplication")]
            KCloudReplication = 5

        }

        /// <summary>
        /// Specifies the type of a Snapshot target such as &#39;kLocal&#39;, &#39;kRemote&#39; or &#39;kArchival&#39;. &#39;kLocal&#39; means the Snapshot is stored on a local Cohesity Cluster. &#39;kRemote&#39; means the Snapshot is stored on a Remote Cohesity Cluster. (It was copied to the Remote Cohesity Cluster using replication.) &#39;kArchival&#39; means the Snapshot is stored on a Archival External Target (such as Tape or AWS). &#39;kCloudDeploy&#39; means the Snapshot is stored on a Cloud platform.
        /// </summary>
        /// <value>Specifies the type of a Snapshot target such as &#39;kLocal&#39;, &#39;kRemote&#39; or &#39;kArchival&#39;. &#39;kLocal&#39; means the Snapshot is stored on a local Cohesity Cluster. &#39;kRemote&#39; means the Snapshot is stored on a Remote Cohesity Cluster. (It was copied to the Remote Cohesity Cluster using replication.) &#39;kArchival&#39; means the Snapshot is stored on a Archival External Target (such as Tape or AWS). &#39;kCloudDeploy&#39; means the Snapshot is stored on a Cloud platform.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SnapshotTargetSettings" /> class.
        /// </summary>
        /// <param name="archivalTarget">archivalTarget.</param>
        /// <param name="cloudReplicationTarget">cloudReplicationTarget.</param>
        /// <param name="replicationTarget">replicationTarget.</param>
        /// <param name="type">Specifies the type of a Snapshot target such as &#39;kLocal&#39;, &#39;kRemote&#39; or &#39;kArchival&#39;. &#39;kLocal&#39; means the Snapshot is stored on a local Cohesity Cluster. &#39;kRemote&#39; means the Snapshot is stored on a Remote Cohesity Cluster. (It was copied to the Remote Cohesity Cluster using replication.) &#39;kArchival&#39; means the Snapshot is stored on a Archival External Target (such as Tape or AWS). &#39;kCloudDeploy&#39; means the Snapshot is stored on a Cloud platform..</param>
        public SnapshotTargetSettings(ArchivalExternalTarget archivalTarget = default(ArchivalExternalTarget), CloudDeployTargetDetails cloudReplicationTarget = default(CloudDeployTargetDetails), ReplicationTargetSettings replicationTarget = default(ReplicationTargetSettings), TypeEnum? type = default(TypeEnum?))
        {
            this.ArchivalTarget = archivalTarget;
            this.CloudReplicationTarget = cloudReplicationTarget;
            this.ReplicationTarget = replicationTarget;
            this.Type = type;
        }
        
        /// <summary>
        /// Gets or Sets ArchivalTarget
        /// </summary>
        [DataMember(Name="archivalTarget", EmitDefaultValue=false)]
        public ArchivalExternalTarget ArchivalTarget { get; set; }

        /// <summary>
        /// Gets or Sets CloudReplicationTarget
        /// </summary>
        [DataMember(Name="cloudReplicationTarget", EmitDefaultValue=false)]
        public CloudDeployTargetDetails CloudReplicationTarget { get; set; }

        /// <summary>
        /// Gets or Sets ReplicationTarget
        /// </summary>
        [DataMember(Name="replicationTarget", EmitDefaultValue=false)]
        public ReplicationTargetSettings ReplicationTarget { get; set; }


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
            return this.Equals(input as SnapshotTargetSettings);
        }

        /// <summary>
        /// Returns true if SnapshotTargetSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of SnapshotTargetSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SnapshotTargetSettings input)
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
                    this.CloudReplicationTarget == input.CloudReplicationTarget ||
                    (this.CloudReplicationTarget != null &&
                    this.CloudReplicationTarget.Equals(input.CloudReplicationTarget))
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
                if (this.CloudReplicationTarget != null)
                    hashCode = hashCode * 59 + this.CloudReplicationTarget.GetHashCode();
                if (this.ReplicationTarget != null)
                    hashCode = hashCode * 59 + this.ReplicationTarget.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}


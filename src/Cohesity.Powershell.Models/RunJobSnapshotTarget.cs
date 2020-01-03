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
    /// Specifies settings for a Copy Task when a Protection is run. It gives the target location for the Snapshot and its retention.
    /// </summary>
    [DataContract]
    public partial class RunJobSnapshotTarget :  IEquatable<RunJobSnapshotTarget>
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
            KCloudDeploy = 4

        }

        /// <summary>
        /// Specifies the type of a Snapshot target such as &#39;kLocal&#39;, &#39;kRemote&#39; or &#39;kArchival&#39;. &#39;kLocal&#39; means the Snapshot is stored on a local Cohesity Cluster. &#39;kRemote&#39; means the Snapshot is stored on a Remote Cohesity Cluster. (It was copied to the Remote Cohesity Cluster using replication.) &#39;kArchival&#39; means the Snapshot is stored on a Archival External Target (such as Tape or AWS). &#39;kCloudDeploy&#39; means the Snapshot is stored on a Cloud platform.
        /// </summary>
        /// <value>Specifies the type of a Snapshot target such as &#39;kLocal&#39;, &#39;kRemote&#39; or &#39;kArchival&#39;. &#39;kLocal&#39; means the Snapshot is stored on a local Cohesity Cluster. &#39;kRemote&#39; means the Snapshot is stored on a Remote Cohesity Cluster. (It was copied to the Remote Cohesity Cluster using replication.) &#39;kArchival&#39; means the Snapshot is stored on a Archival External Target (such as Tape or AWS). &#39;kCloudDeploy&#39; means the Snapshot is stored on a Cloud platform.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RunJobSnapshotTarget" /> class.
        /// </summary>
        /// <param name="archivalTarget">archivalTarget.</param>
        /// <param name="cloudReplicationTarget">cloudReplicationTarget.</param>
        /// <param name="daysToKeep">Specifies the number of days to retain copied Snapshots on the target..</param>
        /// <param name="holdForLegalPurpose">Specifies optionally whether to retain the snapshot for legal purpose. If set to true, the run cannot be deleted until the retention period. Note that using this option may cause the Cluster to run out of space. If set to false explicitly, the hold is removed, and the run will expire as specified in the policy of the Protection Job. If this field is not specified, there is no change to the hold of the run. This field can be set only by a User having Data Security Role..</param>
        /// <param name="replicationTarget">replicationTarget.</param>
        /// <param name="type">Specifies the type of a Snapshot target such as &#39;kLocal&#39;, &#39;kRemote&#39; or &#39;kArchival&#39;. &#39;kLocal&#39; means the Snapshot is stored on a local Cohesity Cluster. &#39;kRemote&#39; means the Snapshot is stored on a Remote Cohesity Cluster. (It was copied to the Remote Cohesity Cluster using replication.) &#39;kArchival&#39; means the Snapshot is stored on a Archival External Target (such as Tape or AWS). &#39;kCloudDeploy&#39; means the Snapshot is stored on a Cloud platform..</param>
        public RunJobSnapshotTarget(ArchivalExternalTarget archivalTarget = default(ArchivalExternalTarget), CloudDeployTargetDetails cloudReplicationTarget = default(CloudDeployTargetDetails), long? daysToKeep = default(long?), bool? holdForLegalPurpose = default(bool?), ReplicationTargetSettings replicationTarget = default(ReplicationTargetSettings), TypeEnum? type = default(TypeEnum?))
        {
            this.DaysToKeep = daysToKeep;
            this.HoldForLegalPurpose = holdForLegalPurpose;
            this.Type = type;
            this.ArchivalTarget = archivalTarget;
            this.CloudReplicationTarget = cloudReplicationTarget;
            this.DaysToKeep = daysToKeep;
            this.HoldForLegalPurpose = holdForLegalPurpose;
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
        /// Specifies the number of days to retain copied Snapshots on the target.
        /// </summary>
        /// <value>Specifies the number of days to retain copied Snapshots on the target.</value>
        [DataMember(Name="daysToKeep", EmitDefaultValue=true)]
        public long? DaysToKeep { get; set; }

        /// <summary>
        /// Specifies optionally whether to retain the snapshot for legal purpose. If set to true, the run cannot be deleted until the retention period. Note that using this option may cause the Cluster to run out of space. If set to false explicitly, the hold is removed, and the run will expire as specified in the policy of the Protection Job. If this field is not specified, there is no change to the hold of the run. This field can be set only by a User having Data Security Role.
        /// </summary>
        /// <value>Specifies optionally whether to retain the snapshot for legal purpose. If set to true, the run cannot be deleted until the retention period. Note that using this option may cause the Cluster to run out of space. If set to false explicitly, the hold is removed, and the run will expire as specified in the policy of the Protection Job. If this field is not specified, there is no change to the hold of the run. This field can be set only by a User having Data Security Role.</value>
        [DataMember(Name="holdForLegalPurpose", EmitDefaultValue=true)]
        public bool? HoldForLegalPurpose { get; set; }

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
                    this.CloudReplicationTarget == input.CloudReplicationTarget ||
                    (this.CloudReplicationTarget != null &&
                    this.CloudReplicationTarget.Equals(input.CloudReplicationTarget))
                ) && 
                (
                    this.DaysToKeep == input.DaysToKeep ||
                    (this.DaysToKeep != null &&
                    this.DaysToKeep.Equals(input.DaysToKeep))
                ) && 
                (
                    this.HoldForLegalPurpose == input.HoldForLegalPurpose ||
                    (this.HoldForLegalPurpose != null &&
                    this.HoldForLegalPurpose.Equals(input.HoldForLegalPurpose))
                ) && 
                (
                    this.ReplicationTarget == input.ReplicationTarget ||
                    (this.ReplicationTarget != null &&
                    this.ReplicationTarget.Equals(input.ReplicationTarget))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.DaysToKeep != null)
                    hashCode = hashCode * 59 + this.DaysToKeep.GetHashCode();
                if (this.HoldForLegalPurpose != null)
                    hashCode = hashCode * 59 + this.HoldForLegalPurpose.GetHashCode();
                if (this.ReplicationTarget != null)
                    hashCode = hashCode * 59 + this.ReplicationTarget.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}


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
    /// Message that specifies details about a target (such as a replication or archival target) where a backup snapshot may be copied to.
    /// </summary>
    [DataContract]
    public partial class SnapshotTarget :  IEquatable<SnapshotTarget>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SnapshotTarget" /> class.
        /// </summary>
        /// <param name="archivalTarget">archivalTarget.</param>
        /// <param name="cloudDeployTarget">cloudDeployTarget.</param>
        /// <param name="onpremDeployTarget">onpremDeployTarget.</param>
        /// <param name="replicationTarget">replicationTarget.</param>
        /// <param name="type">The type of snapshot target this proto represents..</param>
        public SnapshotTarget(ArchivalTarget archivalTarget = default(ArchivalTarget), CloudDeployTarget cloudDeployTarget = default(CloudDeployTarget), OnPremDeployTarget onpremDeployTarget = default(OnPremDeployTarget), ReplicationTarget replicationTarget = default(ReplicationTarget), int? type = default(int?))
        {
            this.Type = type;
            this.ArchivalTarget = archivalTarget;
            this.CloudDeployTarget = cloudDeployTarget;
            this.OnpremDeployTarget = onpremDeployTarget;
            this.ReplicationTarget = replicationTarget;
            this.Type = type;
        }
        
        /// <summary>
        /// Gets or Sets ArchivalTarget
        /// </summary>
        [DataMember(Name="archivalTarget", EmitDefaultValue=false)]
        public ArchivalTarget ArchivalTarget { get; set; }

        /// <summary>
        /// Gets or Sets CloudDeployTarget
        /// </summary>
        [DataMember(Name="cloudDeployTarget", EmitDefaultValue=false)]
        public CloudDeployTarget CloudDeployTarget { get; set; }

        /// <summary>
        /// Gets or Sets OnpremDeployTarget
        /// </summary>
        [DataMember(Name="onpremDeployTarget", EmitDefaultValue=false)]
        public OnPremDeployTarget OnpremDeployTarget { get; set; }

        /// <summary>
        /// Gets or Sets ReplicationTarget
        /// </summary>
        [DataMember(Name="replicationTarget", EmitDefaultValue=false)]
        public ReplicationTarget ReplicationTarget { get; set; }

        /// <summary>
        /// The type of snapshot target this proto represents.
        /// </summary>
        /// <value>The type of snapshot target this proto represents.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public int? Type { get; set; }

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
                    this.CloudDeployTarget == input.CloudDeployTarget ||
                    (this.CloudDeployTarget != null &&
                    this.CloudDeployTarget.Equals(input.CloudDeployTarget))
                ) && 
                (
                    this.OnpremDeployTarget == input.OnpremDeployTarget ||
                    (this.OnpremDeployTarget != null &&
                    this.OnpremDeployTarget.Equals(input.OnpremDeployTarget))
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
                if (this.CloudDeployTarget != null)
                    hashCode = hashCode * 59 + this.CloudDeployTarget.GetHashCode();
                if (this.OnpremDeployTarget != null)
                    hashCode = hashCode * 59 + this.OnpremDeployTarget.GetHashCode();
                if (this.ReplicationTarget != null)
                    hashCode = hashCode * 59 + this.ReplicationTarget.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}


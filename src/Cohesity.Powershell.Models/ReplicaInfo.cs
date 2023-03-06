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
    /// Specifies the Replication information about a snapshot.
    /// </summary>
    [DataContract]
    public partial class ReplicaInfo :  IEquatable<ReplicaInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicaInfo" /> class.
        /// </summary>
        /// <param name="expiryTimeUsecs">Specifies the expiration time of the snapshot within the target location..</param>
        /// <param name="snapshotTargetSettings">snapshotTargetSettings.</param>
        /// <param name="uid">uid.</param>
        public ReplicaInfo(long? expiryTimeUsecs = default(long?), SnapshotTargetSettings snapshotTargetSettings = default(SnapshotTargetSettings), UniversalId uid = default(UniversalId))
        {
            this.ExpiryTimeUsecs = expiryTimeUsecs;
            this.ExpiryTimeUsecs = expiryTimeUsecs;
            this.SnapshotTargetSettings = snapshotTargetSettings;
            this.Uid = uid;
        }
        
        /// <summary>
        /// Specifies the expiration time of the snapshot within the target location.
        /// </summary>
        /// <value>Specifies the expiration time of the snapshot within the target location.</value>
        [DataMember(Name="expiryTimeUsecs", EmitDefaultValue=true)]
        public long? ExpiryTimeUsecs { get; set; }

        /// <summary>
        /// Gets or Sets SnapshotTargetSettings
        /// </summary>
        [DataMember(Name="snapshotTargetSettings", EmitDefaultValue=false)]
        public SnapshotTargetSettings SnapshotTargetSettings { get; set; }

        /// <summary>
        /// Gets or Sets Uid
        /// </summary>
        [DataMember(Name="uid", EmitDefaultValue=false)]
        public UniversalId Uid { get; set; }

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
            return this.Equals(input as ReplicaInfo);
        }

        /// <summary>
        /// Returns true if ReplicaInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ReplicaInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReplicaInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExpiryTimeUsecs == input.ExpiryTimeUsecs ||
                    (this.ExpiryTimeUsecs != null &&
                    this.ExpiryTimeUsecs.Equals(input.ExpiryTimeUsecs))
                ) && 
                (
                    this.SnapshotTargetSettings == input.SnapshotTargetSettings ||
                    (this.SnapshotTargetSettings != null &&
                    this.SnapshotTargetSettings.Equals(input.SnapshotTargetSettings))
                ) && 
                (
                    this.Uid == input.Uid ||
                    (this.Uid != null &&
                    this.Uid.Equals(input.Uid))
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
                if (this.ExpiryTimeUsecs != null)
                    hashCode = hashCode * 59 + this.ExpiryTimeUsecs.GetHashCode();
                if (this.SnapshotTargetSettings != null)
                    hashCode = hashCode * 59 + this.SnapshotTargetSettings.GetHashCode();
                if (this.Uid != null)
                    hashCode = hashCode * 59 + this.Uid.GetHashCode();
                return hashCode;
            }
        }

    }

}


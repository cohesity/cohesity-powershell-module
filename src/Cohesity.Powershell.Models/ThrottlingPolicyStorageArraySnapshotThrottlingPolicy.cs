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
    /// ThrottlingPolicyStorageArraySnapshotThrottlingPolicy
    /// </summary>
    [DataContract]
    public partial class ThrottlingPolicyStorageArraySnapshotThrottlingPolicy :  IEquatable<ThrottlingPolicyStorageArraySnapshotThrottlingPolicy>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThrottlingPolicyStorageArraySnapshotThrottlingPolicy" /> class.
        /// </summary>
        /// <param name="isMaxSnapshotsConfigEnabled">If set to true, the max snapshots for this volume will be according to max_snapshot_config. If set to false, the max snapshots for this volume will be uncapped. If not set, there is not max snapshot override for this volume..</param>
        /// <param name="isMaxSpaceConfigEnabled">If set to true, the max space for this volume will be according to max_space_config. If set to false, the max space for this volume will be uncapped. If not set, there is not max snapshot override for this volume..</param>
        /// <param name="maxSnapshotConfig">maxSnapshotConfig.</param>
        /// <param name="maxSpaceConfig">maxSpaceConfig.</param>
        /// <param name="storageEntity">storageEntity.</param>
        public ThrottlingPolicyStorageArraySnapshotThrottlingPolicy(bool? isMaxSnapshotsConfigEnabled = default(bool?), bool? isMaxSpaceConfigEnabled = default(bool?), ThrottlingPolicyStorageArraySnapshotMaxSnapshotConfig maxSnapshotConfig = default(ThrottlingPolicyStorageArraySnapshotMaxSnapshotConfig), ThrottlingPolicyStorageArraySnapshotMaxSpaceConfig maxSpaceConfig = default(ThrottlingPolicyStorageArraySnapshotMaxSpaceConfig), EntityProto storageEntity = default(EntityProto))
        {
            this.IsMaxSnapshotsConfigEnabled = isMaxSnapshotsConfigEnabled;
            this.IsMaxSpaceConfigEnabled = isMaxSpaceConfigEnabled;
            this.IsMaxSnapshotsConfigEnabled = isMaxSnapshotsConfigEnabled;
            this.IsMaxSpaceConfigEnabled = isMaxSpaceConfigEnabled;
            this.MaxSnapshotConfig = maxSnapshotConfig;
            this.MaxSpaceConfig = maxSpaceConfig;
            this.StorageEntity = storageEntity;
        }
        
        /// <summary>
        /// If set to true, the max snapshots for this volume will be according to max_snapshot_config. If set to false, the max snapshots for this volume will be uncapped. If not set, there is not max snapshot override for this volume.
        /// </summary>
        /// <value>If set to true, the max snapshots for this volume will be according to max_snapshot_config. If set to false, the max snapshots for this volume will be uncapped. If not set, there is not max snapshot override for this volume.</value>
        [DataMember(Name="isMaxSnapshotsConfigEnabled", EmitDefaultValue=true)]
        public bool? IsMaxSnapshotsConfigEnabled { get; set; }

        /// <summary>
        /// If set to true, the max space for this volume will be according to max_space_config. If set to false, the max space for this volume will be uncapped. If not set, there is not max snapshot override for this volume.
        /// </summary>
        /// <value>If set to true, the max space for this volume will be according to max_space_config. If set to false, the max space for this volume will be uncapped. If not set, there is not max snapshot override for this volume.</value>
        [DataMember(Name="isMaxSpaceConfigEnabled", EmitDefaultValue=true)]
        public bool? IsMaxSpaceConfigEnabled { get; set; }

        /// <summary>
        /// Gets or Sets MaxSnapshotConfig
        /// </summary>
        [DataMember(Name="maxSnapshotConfig", EmitDefaultValue=false)]
        public ThrottlingPolicyStorageArraySnapshotMaxSnapshotConfig MaxSnapshotConfig { get; set; }

        /// <summary>
        /// Gets or Sets MaxSpaceConfig
        /// </summary>
        [DataMember(Name="maxSpaceConfig", EmitDefaultValue=false)]
        public ThrottlingPolicyStorageArraySnapshotMaxSpaceConfig MaxSpaceConfig { get; set; }

        /// <summary>
        /// Gets or Sets StorageEntity
        /// </summary>
        [DataMember(Name="storageEntity", EmitDefaultValue=false)]
        public EntityProto StorageEntity { get; set; }

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
            return this.Equals(input as ThrottlingPolicyStorageArraySnapshotThrottlingPolicy);
        }

        /// <summary>
        /// Returns true if ThrottlingPolicyStorageArraySnapshotThrottlingPolicy instances are equal
        /// </summary>
        /// <param name="input">Instance of ThrottlingPolicyStorageArraySnapshotThrottlingPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThrottlingPolicyStorageArraySnapshotThrottlingPolicy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsMaxSnapshotsConfigEnabled == input.IsMaxSnapshotsConfigEnabled ||
                    (this.IsMaxSnapshotsConfigEnabled != null &&
                    this.IsMaxSnapshotsConfigEnabled.Equals(input.IsMaxSnapshotsConfigEnabled))
                ) && 
                (
                    this.IsMaxSpaceConfigEnabled == input.IsMaxSpaceConfigEnabled ||
                    (this.IsMaxSpaceConfigEnabled != null &&
                    this.IsMaxSpaceConfigEnabled.Equals(input.IsMaxSpaceConfigEnabled))
                ) && 
                (
                    this.MaxSnapshotConfig == input.MaxSnapshotConfig ||
                    (this.MaxSnapshotConfig != null &&
                    this.MaxSnapshotConfig.Equals(input.MaxSnapshotConfig))
                ) && 
                (
                    this.MaxSpaceConfig == input.MaxSpaceConfig ||
                    (this.MaxSpaceConfig != null &&
                    this.MaxSpaceConfig.Equals(input.MaxSpaceConfig))
                ) && 
                (
                    this.StorageEntity == input.StorageEntity ||
                    (this.StorageEntity != null &&
                    this.StorageEntity.Equals(input.StorageEntity))
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
                if (this.IsMaxSnapshotsConfigEnabled != null)
                    hashCode = hashCode * 59 + this.IsMaxSnapshotsConfigEnabled.GetHashCode();
                if (this.IsMaxSpaceConfigEnabled != null)
                    hashCode = hashCode * 59 + this.IsMaxSpaceConfigEnabled.GetHashCode();
                if (this.MaxSnapshotConfig != null)
                    hashCode = hashCode * 59 + this.MaxSnapshotConfig.GetHashCode();
                if (this.MaxSpaceConfig != null)
                    hashCode = hashCode * 59 + this.MaxSpaceConfig.GetHashCode();
                if (this.StorageEntity != null)
                    hashCode = hashCode * 59 + this.StorageEntity.GetHashCode();
                return hashCode;
            }
        }

    }

}


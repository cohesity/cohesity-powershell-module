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
    /// StorageArraySnapshotThrottlingPolicy
    /// </summary>
    [DataContract]
    public partial class StorageArraySnapshotThrottlingPolicy :  IEquatable<StorageArraySnapshotThrottlingPolicy>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageArraySnapshotThrottlingPolicy" /> class.
        /// </summary>
        /// <param name="id">Specifies the volume id of the storage array snapshot config..</param>
        /// <param name="isMaxSnapshotsConfigEnabled">Specifies if the storage array snapshot max snapshots config is enabled or not..</param>
        /// <param name="isMaxSpaceConfigEnabled">Specifies if the storage array snapshot max space config is enabled or not..</param>
        /// <param name="maxSnapshotConfig">maxSnapshotConfig.</param>
        /// <param name="maxSpaceConfig">maxSpaceConfig.</param>
        public StorageArraySnapshotThrottlingPolicy(long? id = default(long?), bool? isMaxSnapshotsConfigEnabled = default(bool?), bool? isMaxSpaceConfigEnabled = default(bool?), StorageArraySnapshotMaxSnapshotConfigParams maxSnapshotConfig = default(StorageArraySnapshotMaxSnapshotConfigParams), StorageArraySnapshotMaxSpaceConfigParams maxSpaceConfig = default(StorageArraySnapshotMaxSpaceConfigParams))
        {
            this.Id = id;
            this.IsMaxSnapshotsConfigEnabled = isMaxSnapshotsConfigEnabled;
            this.IsMaxSpaceConfigEnabled = isMaxSpaceConfigEnabled;
            this.Id = id;
            this.IsMaxSnapshotsConfigEnabled = isMaxSnapshotsConfigEnabled;
            this.IsMaxSpaceConfigEnabled = isMaxSpaceConfigEnabled;
            this.MaxSnapshotConfig = maxSnapshotConfig;
            this.MaxSpaceConfig = maxSpaceConfig;
        }
        
        /// <summary>
        /// Specifies the volume id of the storage array snapshot config.
        /// </summary>
        /// <value>Specifies the volume id of the storage array snapshot config.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Specifies if the storage array snapshot max snapshots config is enabled or not.
        /// </summary>
        /// <value>Specifies if the storage array snapshot max snapshots config is enabled or not.</value>
        [DataMember(Name="isMaxSnapshotsConfigEnabled", EmitDefaultValue=true)]
        public bool? IsMaxSnapshotsConfigEnabled { get; set; }

        /// <summary>
        /// Specifies if the storage array snapshot max space config is enabled or not.
        /// </summary>
        /// <value>Specifies if the storage array snapshot max space config is enabled or not.</value>
        [DataMember(Name="isMaxSpaceConfigEnabled", EmitDefaultValue=true)]
        public bool? IsMaxSpaceConfigEnabled { get; set; }

        /// <summary>
        /// Gets or Sets MaxSnapshotConfig
        /// </summary>
        [DataMember(Name="maxSnapshotConfig", EmitDefaultValue=false)]
        public StorageArraySnapshotMaxSnapshotConfigParams MaxSnapshotConfig { get; set; }

        /// <summary>
        /// Gets or Sets MaxSpaceConfig
        /// </summary>
        [DataMember(Name="maxSpaceConfig", EmitDefaultValue=false)]
        public StorageArraySnapshotMaxSpaceConfigParams MaxSpaceConfig { get; set; }

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
            return this.Equals(input as StorageArraySnapshotThrottlingPolicy);
        }

        /// <summary>
        /// Returns true if StorageArraySnapshotThrottlingPolicy instances are equal
        /// </summary>
        /// <param name="input">Instance of StorageArraySnapshotThrottlingPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StorageArraySnapshotThrottlingPolicy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IsMaxSnapshotsConfigEnabled != null)
                    hashCode = hashCode * 59 + this.IsMaxSnapshotsConfigEnabled.GetHashCode();
                if (this.IsMaxSpaceConfigEnabled != null)
                    hashCode = hashCode * 59 + this.IsMaxSpaceConfigEnabled.GetHashCode();
                if (this.MaxSnapshotConfig != null)
                    hashCode = hashCode * 59 + this.MaxSnapshotConfig.GetHashCode();
                if (this.MaxSpaceConfig != null)
                    hashCode = hashCode * 59 + this.MaxSpaceConfig.GetHashCode();
                return hashCode;
            }
        }

    }

}


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
    /// StorageArraySnapshotConfigParams
    /// </summary>
    [DataContract]
    public partial class StorageArraySnapshotConfigParams :  IEquatable<StorageArraySnapshotConfigParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageArraySnapshotConfigParams" /> class.
        /// </summary>
        /// <param name="isMaxSnapshotsConfigEnabled">Specifies if the storage array snapshot max snapshots config is enabled or not..</param>
        /// <param name="isMaxSpaceConfigEnabled">Specifies if the storage array snapshot max space config is enabled or not..</param>
        /// <param name="storageArraySnapshotMaxSpaceConfig">storageArraySnapshotMaxSpaceConfig.</param>
        /// <param name="storageArraySnapshotThrottlingPolicies">Specifies throttling policies configured for individual volume/lun..</param>
        public StorageArraySnapshotConfigParams(bool? isMaxSnapshotsConfigEnabled = default(bool?), bool? isMaxSpaceConfigEnabled = default(bool?), StorageArraySnapshotMaxSpaceConfigParams storageArraySnapshotMaxSpaceConfig = default(StorageArraySnapshotMaxSpaceConfigParams), List<StorageArraySnapshotThrottlingPolicy> storageArraySnapshotThrottlingPolicies = default(List<StorageArraySnapshotThrottlingPolicy>))
        {
            this.IsMaxSnapshotsConfigEnabled = isMaxSnapshotsConfigEnabled;
            this.IsMaxSpaceConfigEnabled = isMaxSpaceConfigEnabled;
            this.StorageArraySnapshotThrottlingPolicies = storageArraySnapshotThrottlingPolicies;
            this.IsMaxSnapshotsConfigEnabled = isMaxSnapshotsConfigEnabled;
            this.IsMaxSpaceConfigEnabled = isMaxSpaceConfigEnabled;
            this.StorageArraySnapshotMaxSpaceConfig = storageArraySnapshotMaxSpaceConfig;
            this.StorageArraySnapshotThrottlingPolicies = storageArraySnapshotThrottlingPolicies;
        }
        
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
        /// Gets or Sets StorageArraySnapshotMaxSpaceConfig
        /// </summary>
        [DataMember(Name="storageArraySnapshotMaxSpaceConfig", EmitDefaultValue=false)]
        public StorageArraySnapshotMaxSpaceConfigParams StorageArraySnapshotMaxSpaceConfig { get; set; }

        /// <summary>
        /// Specifies throttling policies configured for individual volume/lun.
        /// </summary>
        /// <value>Specifies throttling policies configured for individual volume/lun.</value>
        [DataMember(Name="storageArraySnapshotThrottlingPolicies", EmitDefaultValue=true)]
        public List<StorageArraySnapshotThrottlingPolicy> StorageArraySnapshotThrottlingPolicies { get; set; }

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
            return this.Equals(input as StorageArraySnapshotConfigParams);
        }

        /// <summary>
        /// Returns true if StorageArraySnapshotConfigParams instances are equal
        /// </summary>
        /// <param name="input">Instance of StorageArraySnapshotConfigParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StorageArraySnapshotConfigParams input)
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
                    this.StorageArraySnapshotMaxSpaceConfig == input.StorageArraySnapshotMaxSpaceConfig ||
                    (this.StorageArraySnapshotMaxSpaceConfig != null &&
                    this.StorageArraySnapshotMaxSpaceConfig.Equals(input.StorageArraySnapshotMaxSpaceConfig))
                ) && 
                (
                    this.StorageArraySnapshotThrottlingPolicies == input.StorageArraySnapshotThrottlingPolicies ||
                    this.StorageArraySnapshotThrottlingPolicies != null &&
                    input.StorageArraySnapshotThrottlingPolicies != null &&
                    this.StorageArraySnapshotThrottlingPolicies.Equals(input.StorageArraySnapshotThrottlingPolicies)
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
                if (this.StorageArraySnapshotMaxSpaceConfig != null)
                    hashCode = hashCode * 59 + this.StorageArraySnapshotMaxSpaceConfig.GetHashCode();
                if (this.StorageArraySnapshotThrottlingPolicies != null)
                    hashCode = hashCode * 59 + this.StorageArraySnapshotThrottlingPolicies.GetHashCode();
                return hashCode;
            }
        }

    }

}


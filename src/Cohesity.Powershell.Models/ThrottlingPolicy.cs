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
    /// Message that specifies the throttling policy for a particular registered entity.
    /// </summary>
    [DataContract]
    public partial class ThrottlingPolicy :  IEquatable<ThrottlingPolicy>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThrottlingPolicy" /> class.
        /// </summary>
        /// <param name="datastoreStreamsConfig">datastoreStreamsConfig.</param>
        /// <param name="datastoreThrottlingPolicies">This field can be used to override the throttling policy for individual datastores..</param>
        /// <param name="entity">entity.</param>
        /// <param name="isDatastoreStreamsConfigEnabled">Whether datastore streams can be configured on all datastores that are part of the registered entity. If set to true, then the config within &#39;DatastoreStreamsConfig&#39; would be applicable to all those datastores..</param>
        /// <param name="isMaxSnapshotsConfigEnabled">Whether we will use storage snapshot managmement max snap config to all volumes/luns that are part of the registered entity..</param>
        /// <param name="isMaxSpaceConfigEnabled">Whether we will use storage snapshot managmement max space config to all volumes/luns that are part of the registered entity..</param>
        /// <param name="isRegisteredSourceThrottlingConfigEnabled">Whether no. of backups can be configured on the registered entity. If set to true, then the config within &#39;RegisteredSourceThrottlingConfig&#39; would be applicable to the registered entity..</param>
        /// <param name="isThrottlingEnabled">Whether we will adaptively throttle read operations from the datastores that are part of the registered entity. Note: This is only applicable to latency throttling..</param>
        /// <param name="latencyThresholds">latencyThresholds.</param>
        /// <param name="registeredSourceThrottlingConfig">registeredSourceThrottlingConfig.</param>
        /// <param name="storageArraySnapshotMaxSnapshotConfig">storageArraySnapshotMaxSnapshotConfig.</param>
        /// <param name="storageArraySnapshotMaxSpaceConfig">storageArraySnapshotMaxSpaceConfig.</param>
        /// <param name="storageArraySnapshotThrottlingPolicies">This field is used for throttling policy for individual volume/lun..</param>
        public ThrottlingPolicy(ThrottlingPolicyDatastoreStreamsConfig datastoreStreamsConfig = default(ThrottlingPolicyDatastoreStreamsConfig), List<ThrottlingPolicyDatastoreThrottlingPolicy> datastoreThrottlingPolicies = default(List<ThrottlingPolicyDatastoreThrottlingPolicy>), EntityProto entity = default(EntityProto), bool? isDatastoreStreamsConfigEnabled = default(bool?), bool? isMaxSnapshotsConfigEnabled = default(bool?), bool? isMaxSpaceConfigEnabled = default(bool?), bool? isRegisteredSourceThrottlingConfigEnabled = default(bool?), bool? isThrottlingEnabled = default(bool?), ThrottlingPolicyLatencyThresholds latencyThresholds = default(ThrottlingPolicyLatencyThresholds), ThrottlingPolicyRegisteredSourceThrottlingConfig registeredSourceThrottlingConfig = default(ThrottlingPolicyRegisteredSourceThrottlingConfig), ThrottlingPolicyStorageArraySnapshotMaxSnapshotConfig storageArraySnapshotMaxSnapshotConfig = default(ThrottlingPolicyStorageArraySnapshotMaxSnapshotConfig), ThrottlingPolicyStorageArraySnapshotMaxSpaceConfig storageArraySnapshotMaxSpaceConfig = default(ThrottlingPolicyStorageArraySnapshotMaxSpaceConfig), List<ThrottlingPolicyStorageArraySnapshotThrottlingPolicy> storageArraySnapshotThrottlingPolicies = default(List<ThrottlingPolicyStorageArraySnapshotThrottlingPolicy>))
        {
            this.DatastoreThrottlingPolicies = datastoreThrottlingPolicies;
            this.IsDatastoreStreamsConfigEnabled = isDatastoreStreamsConfigEnabled;
            this.IsMaxSnapshotsConfigEnabled = isMaxSnapshotsConfigEnabled;
            this.IsMaxSpaceConfigEnabled = isMaxSpaceConfigEnabled;
            this.IsRegisteredSourceThrottlingConfigEnabled = isRegisteredSourceThrottlingConfigEnabled;
            this.IsThrottlingEnabled = isThrottlingEnabled;
            this.StorageArraySnapshotThrottlingPolicies = storageArraySnapshotThrottlingPolicies;
            this.DatastoreStreamsConfig = datastoreStreamsConfig;
            this.DatastoreThrottlingPolicies = datastoreThrottlingPolicies;
            this.Entity = entity;
            this.IsDatastoreStreamsConfigEnabled = isDatastoreStreamsConfigEnabled;
            this.IsMaxSnapshotsConfigEnabled = isMaxSnapshotsConfigEnabled;
            this.IsMaxSpaceConfigEnabled = isMaxSpaceConfigEnabled;
            this.IsRegisteredSourceThrottlingConfigEnabled = isRegisteredSourceThrottlingConfigEnabled;
            this.IsThrottlingEnabled = isThrottlingEnabled;
            this.LatencyThresholds = latencyThresholds;
            this.RegisteredSourceThrottlingConfig = registeredSourceThrottlingConfig;
            this.StorageArraySnapshotMaxSnapshotConfig = storageArraySnapshotMaxSnapshotConfig;
            this.StorageArraySnapshotMaxSpaceConfig = storageArraySnapshotMaxSpaceConfig;
            this.StorageArraySnapshotThrottlingPolicies = storageArraySnapshotThrottlingPolicies;
        }
        
        /// <summary>
        /// Gets or Sets DatastoreStreamsConfig
        /// </summary>
        [DataMember(Name="datastoreStreamsConfig", EmitDefaultValue=false)]
        public ThrottlingPolicyDatastoreStreamsConfig DatastoreStreamsConfig { get; set; }

        /// <summary>
        /// This field can be used to override the throttling policy for individual datastores.
        /// </summary>
        /// <value>This field can be used to override the throttling policy for individual datastores.</value>
        [DataMember(Name="datastoreThrottlingPolicies", EmitDefaultValue=true)]
        public List<ThrottlingPolicyDatastoreThrottlingPolicy> DatastoreThrottlingPolicies { get; set; }

        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public EntityProto Entity { get; set; }

        /// <summary>
        /// Whether datastore streams can be configured on all datastores that are part of the registered entity. If set to true, then the config within &#39;DatastoreStreamsConfig&#39; would be applicable to all those datastores.
        /// </summary>
        /// <value>Whether datastore streams can be configured on all datastores that are part of the registered entity. If set to true, then the config within &#39;DatastoreStreamsConfig&#39; would be applicable to all those datastores.</value>
        [DataMember(Name="isDatastoreStreamsConfigEnabled", EmitDefaultValue=true)]
        public bool? IsDatastoreStreamsConfigEnabled { get; set; }

        /// <summary>
        /// Whether we will use storage snapshot managmement max snap config to all volumes/luns that are part of the registered entity.
        /// </summary>
        /// <value>Whether we will use storage snapshot managmement max snap config to all volumes/luns that are part of the registered entity.</value>
        [DataMember(Name="isMaxSnapshotsConfigEnabled", EmitDefaultValue=true)]
        public bool? IsMaxSnapshotsConfigEnabled { get; set; }

        /// <summary>
        /// Whether we will use storage snapshot managmement max space config to all volumes/luns that are part of the registered entity.
        /// </summary>
        /// <value>Whether we will use storage snapshot managmement max space config to all volumes/luns that are part of the registered entity.</value>
        [DataMember(Name="isMaxSpaceConfigEnabled", EmitDefaultValue=true)]
        public bool? IsMaxSpaceConfigEnabled { get; set; }

        /// <summary>
        /// Whether no. of backups can be configured on the registered entity. If set to true, then the config within &#39;RegisteredSourceThrottlingConfig&#39; would be applicable to the registered entity.
        /// </summary>
        /// <value>Whether no. of backups can be configured on the registered entity. If set to true, then the config within &#39;RegisteredSourceThrottlingConfig&#39; would be applicable to the registered entity.</value>
        [DataMember(Name="isRegisteredSourceThrottlingConfigEnabled", EmitDefaultValue=true)]
        public bool? IsRegisteredSourceThrottlingConfigEnabled { get; set; }

        /// <summary>
        /// Whether we will adaptively throttle read operations from the datastores that are part of the registered entity. Note: This is only applicable to latency throttling.
        /// </summary>
        /// <value>Whether we will adaptively throttle read operations from the datastores that are part of the registered entity. Note: This is only applicable to latency throttling.</value>
        [DataMember(Name="isThrottlingEnabled", EmitDefaultValue=true)]
        public bool? IsThrottlingEnabled { get; set; }

        /// <summary>
        /// Gets or Sets LatencyThresholds
        /// </summary>
        [DataMember(Name="latencyThresholds", EmitDefaultValue=false)]
        public ThrottlingPolicyLatencyThresholds LatencyThresholds { get; set; }

        /// <summary>
        /// Gets or Sets RegisteredSourceThrottlingConfig
        /// </summary>
        [DataMember(Name="registeredSourceThrottlingConfig", EmitDefaultValue=false)]
        public ThrottlingPolicyRegisteredSourceThrottlingConfig RegisteredSourceThrottlingConfig { get; set; }

        /// <summary>
        /// Gets or Sets StorageArraySnapshotMaxSnapshotConfig
        /// </summary>
        [DataMember(Name="storageArraySnapshotMaxSnapshotConfig", EmitDefaultValue=false)]
        public ThrottlingPolicyStorageArraySnapshotMaxSnapshotConfig StorageArraySnapshotMaxSnapshotConfig { get; set; }

        /// <summary>
        /// Gets or Sets StorageArraySnapshotMaxSpaceConfig
        /// </summary>
        [DataMember(Name="storageArraySnapshotMaxSpaceConfig", EmitDefaultValue=false)]
        public ThrottlingPolicyStorageArraySnapshotMaxSpaceConfig StorageArraySnapshotMaxSpaceConfig { get; set; }

        /// <summary>
        /// This field is used for throttling policy for individual volume/lun.
        /// </summary>
        /// <value>This field is used for throttling policy for individual volume/lun.</value>
        [DataMember(Name="storageArraySnapshotThrottlingPolicies", EmitDefaultValue=true)]
        public List<ThrottlingPolicyStorageArraySnapshotThrottlingPolicy> StorageArraySnapshotThrottlingPolicies { get; set; }

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
            return this.Equals(input as ThrottlingPolicy);
        }

        /// <summary>
        /// Returns true if ThrottlingPolicy instances are equal
        /// </summary>
        /// <param name="input">Instance of ThrottlingPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThrottlingPolicy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DatastoreStreamsConfig == input.DatastoreStreamsConfig ||
                    (this.DatastoreStreamsConfig != null &&
                    this.DatastoreStreamsConfig.Equals(input.DatastoreStreamsConfig))
                ) && 
                (
                    this.DatastoreThrottlingPolicies == input.DatastoreThrottlingPolicies ||
                    this.DatastoreThrottlingPolicies != null &&
                    input.DatastoreThrottlingPolicies != null &&
                    this.DatastoreThrottlingPolicies.SequenceEqual(input.DatastoreThrottlingPolicies)
                ) && 
                (
                    this.Entity == input.Entity ||
                    (this.Entity != null &&
                    this.Entity.Equals(input.Entity))
                ) && 
                (
                    this.IsDatastoreStreamsConfigEnabled == input.IsDatastoreStreamsConfigEnabled ||
                    (this.IsDatastoreStreamsConfigEnabled != null &&
                    this.IsDatastoreStreamsConfigEnabled.Equals(input.IsDatastoreStreamsConfigEnabled))
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
                    this.IsRegisteredSourceThrottlingConfigEnabled == input.IsRegisteredSourceThrottlingConfigEnabled ||
                    (this.IsRegisteredSourceThrottlingConfigEnabled != null &&
                    this.IsRegisteredSourceThrottlingConfigEnabled.Equals(input.IsRegisteredSourceThrottlingConfigEnabled))
                ) && 
                (
                    this.IsThrottlingEnabled == input.IsThrottlingEnabled ||
                    (this.IsThrottlingEnabled != null &&
                    this.IsThrottlingEnabled.Equals(input.IsThrottlingEnabled))
                ) && 
                (
                    this.LatencyThresholds == input.LatencyThresholds ||
                    (this.LatencyThresholds != null &&
                    this.LatencyThresholds.Equals(input.LatencyThresholds))
                ) && 
                (
                    this.RegisteredSourceThrottlingConfig == input.RegisteredSourceThrottlingConfig ||
                    (this.RegisteredSourceThrottlingConfig != null &&
                    this.RegisteredSourceThrottlingConfig.Equals(input.RegisteredSourceThrottlingConfig))
                ) && 
                (
                    this.StorageArraySnapshotMaxSnapshotConfig == input.StorageArraySnapshotMaxSnapshotConfig ||
                    (this.StorageArraySnapshotMaxSnapshotConfig != null &&
                    this.StorageArraySnapshotMaxSnapshotConfig.Equals(input.StorageArraySnapshotMaxSnapshotConfig))
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
                    this.StorageArraySnapshotThrottlingPolicies.SequenceEqual(input.StorageArraySnapshotThrottlingPolicies)
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
                if (this.DatastoreStreamsConfig != null)
                    hashCode = hashCode * 59 + this.DatastoreStreamsConfig.GetHashCode();
                if (this.DatastoreThrottlingPolicies != null)
                    hashCode = hashCode * 59 + this.DatastoreThrottlingPolicies.GetHashCode();
                if (this.Entity != null)
                    hashCode = hashCode * 59 + this.Entity.GetHashCode();
                if (this.IsDatastoreStreamsConfigEnabled != null)
                    hashCode = hashCode * 59 + this.IsDatastoreStreamsConfigEnabled.GetHashCode();
                if (this.IsMaxSnapshotsConfigEnabled != null)
                    hashCode = hashCode * 59 + this.IsMaxSnapshotsConfigEnabled.GetHashCode();
                if (this.IsMaxSpaceConfigEnabled != null)
                    hashCode = hashCode * 59 + this.IsMaxSpaceConfigEnabled.GetHashCode();
                if (this.IsRegisteredSourceThrottlingConfigEnabled != null)
                    hashCode = hashCode * 59 + this.IsRegisteredSourceThrottlingConfigEnabled.GetHashCode();
                if (this.IsThrottlingEnabled != null)
                    hashCode = hashCode * 59 + this.IsThrottlingEnabled.GetHashCode();
                if (this.LatencyThresholds != null)
                    hashCode = hashCode * 59 + this.LatencyThresholds.GetHashCode();
                if (this.RegisteredSourceThrottlingConfig != null)
                    hashCode = hashCode * 59 + this.RegisteredSourceThrottlingConfig.GetHashCode();
                if (this.StorageArraySnapshotMaxSnapshotConfig != null)
                    hashCode = hashCode * 59 + this.StorageArraySnapshotMaxSnapshotConfig.GetHashCode();
                if (this.StorageArraySnapshotMaxSpaceConfig != null)
                    hashCode = hashCode * 59 + this.StorageArraySnapshotMaxSpaceConfig.GetHashCode();
                if (this.StorageArraySnapshotThrottlingPolicies != null)
                    hashCode = hashCode * 59 + this.StorageArraySnapshotThrottlingPolicies.GetHashCode();
                return hashCode;
            }
        }

    }

}


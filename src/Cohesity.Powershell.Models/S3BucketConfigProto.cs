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
    /// S3BucketConfigProto
    /// </summary>
    [DataContract]
    public partial class S3BucketConfigProto :  IEquatable<S3BucketConfigProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="S3BucketConfigProto" /> class.
        /// </summary>
        /// <param name="abacEnabled">bool representing if the view is ABAC enabled or not.</param>
        /// <param name="acl">acl.</param>
        /// <param name="bucketPolicy">bucketPolicy.</param>
        /// <param name="efficientMpuEnabled">bool representing whether MPUs are organized using S3 MPU 2.0 design. Should only be set while view creation and immutable there after..</param>
        /// <param name="enableObjStoreAccess">If set to false, we disable access to view using S3/Swift protocol. This overrides any &#39;protocol_access_info&#39; set on view for S3/Swift. This flag is added as the transition for S3 native to non-S3 native is disabled and therefore the access using S3/Swift protocol cannot be disabled by madrox..</param>
        /// <param name="initClusterId">The cluster id for the cluster where the view was initially created without replication. For view on Rx, the init_cluster_id will remain same as that of the initial cluster..</param>
        /// <param name="initClusterIncarnationId">The cluster incarnation id for the cluster where the view was initially created without replication. For view on Rx, the init_incarnation_cluster_id will remain same as that of the initial cluster..</param>
        /// <param name="lifecycleConfig">lifecycleConfig.</param>
        /// <param name="maxSubfilesPerMpu">This tunable field defines the number of maximum subfiles a MPU directory can have..</param>
        /// <param name="objectTagsAdded">Whether this view has ever had any object with tags. This should be enabled only when first object tag is ever put in this view..</param>
        /// <param name="ownerInfo">ownerInfo.</param>
        /// <param name="ownershipControls">ownershipControls.</param>
        /// <param name="prefixDelimiter">Delimiter used in prefix based request routing. An application needs to explicitly set the prefix_delimiter during bucket creation. If the prefix_delimiter is not explicitly set, &#39;/&#39; will be used as the default prefix delimiter for buckets that has prefix-based-routing enabled. SnapDiff backups uses &#39;/&#39; in the object names hence it was chosen as the default prefix to avoid further UI changes in this project. If there are other use cases that require a different prefix_delimiter, it has to be set during bucket creation. Once prefix_delimiter is chosen, it cannot be changed..</param>
        /// <param name="prefixToChildBucketMap">Stores the prefix to child bucket mapping to enable prefix based routing of object requests to child buckets..</param>
        /// <param name="protocolType">Protocol type of this bucket..</param>
        /// <param name="swiftContainerTag">swiftContainerTag.</param>
        /// <param name="tagMap">Tags (or labels) assigned to the bucket. Tags are set of &lt;key, value&gt; pairs..</param>
        /// <param name="versioningState">versioningState.</param>
        public S3BucketConfigProto(bool? abacEnabled = default(bool?), ACLProto acl = default(ACLProto), BucketPolicy bucketPolicy = default(BucketPolicy), bool? efficientMpuEnabled = default(bool?), bool? enableObjStoreAccess = default(bool?), long? initClusterId = default(long?), long? initClusterIncarnationId = default(long?), LifecycleConfigProto lifecycleConfig = default(LifecycleConfigProto), int? maxSubfilesPerMpu = default(int?), bool? objectTagsAdded = default(bool?), OwnerInfo ownerInfo = default(OwnerInfo), BucketOwnershipControls ownershipControls = default(BucketOwnershipControls), string prefixDelimiter = default(string), List<S3BucketConfigProtoPrefixToChildBucketMapEntry> prefixToChildBucketMap = default(List<S3BucketConfigProtoPrefixToChildBucketMapEntry>), int? protocolType = default(int?), SwiftContainerTaggingProto swiftContainerTag = default(SwiftContainerTaggingProto), List<S3BucketConfigProtoTagMapEntry> tagMap = default(List<S3BucketConfigProtoTagMapEntry>), int? versioningState = default(int?))
        {
            this.AbacEnabled = abacEnabled;
            this.EfficientMpuEnabled = efficientMpuEnabled;
            this.EnableObjStoreAccess = enableObjStoreAccess;
            this.InitClusterId = initClusterId;
            this.InitClusterIncarnationId = initClusterIncarnationId;
            this.MaxSubfilesPerMpu = maxSubfilesPerMpu;
            this.ObjectTagsAdded = objectTagsAdded;
            this.PrefixDelimiter = prefixDelimiter;
            this.PrefixToChildBucketMap = prefixToChildBucketMap;
            this.ProtocolType = protocolType;
            this.TagMap = tagMap;
            this.VersioningState = versioningState;
            this.AbacEnabled = abacEnabled;
            this.Acl = acl;
            this.BucketPolicy = bucketPolicy;
            this.EfficientMpuEnabled = efficientMpuEnabled;
            this.EnableObjStoreAccess = enableObjStoreAccess;
            this.InitClusterId = initClusterId;
            this.InitClusterIncarnationId = initClusterIncarnationId;
            this.LifecycleConfig = lifecycleConfig;
            this.MaxSubfilesPerMpu = maxSubfilesPerMpu;
            this.ObjectTagsAdded = objectTagsAdded;
            this.OwnerInfo = ownerInfo;
            this.OwnershipControls = ownershipControls;
            this.PrefixDelimiter = prefixDelimiter;
            this.PrefixToChildBucketMap = prefixToChildBucketMap;
            this.ProtocolType = protocolType;
            this.SwiftContainerTag = swiftContainerTag;
            this.TagMap = tagMap;
            this.VersioningState = versioningState;
        }
        
        /// <summary>
        /// bool representing if the view is ABAC enabled or not
        /// </summary>
        /// <value>bool representing if the view is ABAC enabled or not</value>
        [DataMember(Name="abacEnabled", EmitDefaultValue=true)]
        public bool? AbacEnabled { get; set; }

        /// <summary>
        /// Gets or Sets Acl
        /// </summary>
        [DataMember(Name="acl", EmitDefaultValue=false)]
        public ACLProto Acl { get; set; }

        /// <summary>
        /// Gets or Sets BucketPolicy
        /// </summary>
        [DataMember(Name="bucketPolicy", EmitDefaultValue=false)]
        public BucketPolicy BucketPolicy { get; set; }

        /// <summary>
        /// bool representing whether MPUs are organized using S3 MPU 2.0 design. Should only be set while view creation and immutable there after.
        /// </summary>
        /// <value>bool representing whether MPUs are organized using S3 MPU 2.0 design. Should only be set while view creation and immutable there after.</value>
        [DataMember(Name="efficientMpuEnabled", EmitDefaultValue=true)]
        public bool? EfficientMpuEnabled { get; set; }

        /// <summary>
        /// If set to false, we disable access to view using S3/Swift protocol. This overrides any &#39;protocol_access_info&#39; set on view for S3/Swift. This flag is added as the transition for S3 native to non-S3 native is disabled and therefore the access using S3/Swift protocol cannot be disabled by madrox.
        /// </summary>
        /// <value>If set to false, we disable access to view using S3/Swift protocol. This overrides any &#39;protocol_access_info&#39; set on view for S3/Swift. This flag is added as the transition for S3 native to non-S3 native is disabled and therefore the access using S3/Swift protocol cannot be disabled by madrox.</value>
        [DataMember(Name="enableObjStoreAccess", EmitDefaultValue=true)]
        public bool? EnableObjStoreAccess { get; set; }

        /// <summary>
        /// The cluster id for the cluster where the view was initially created without replication. For view on Rx, the init_cluster_id will remain same as that of the initial cluster.
        /// </summary>
        /// <value>The cluster id for the cluster where the view was initially created without replication. For view on Rx, the init_cluster_id will remain same as that of the initial cluster.</value>
        [DataMember(Name="initClusterId", EmitDefaultValue=true)]
        public long? InitClusterId { get; set; }

        /// <summary>
        /// The cluster incarnation id for the cluster where the view was initially created without replication. For view on Rx, the init_incarnation_cluster_id will remain same as that of the initial cluster.
        /// </summary>
        /// <value>The cluster incarnation id for the cluster where the view was initially created without replication. For view on Rx, the init_incarnation_cluster_id will remain same as that of the initial cluster.</value>
        [DataMember(Name="initClusterIncarnationId", EmitDefaultValue=true)]
        public long? InitClusterIncarnationId { get; set; }

        /// <summary>
        /// Gets or Sets LifecycleConfig
        /// </summary>
        [DataMember(Name="lifecycleConfig", EmitDefaultValue=false)]
        public LifecycleConfigProto LifecycleConfig { get; set; }

        /// <summary>
        /// This tunable field defines the number of maximum subfiles a MPU directory can have.
        /// </summary>
        /// <value>This tunable field defines the number of maximum subfiles a MPU directory can have.</value>
        [DataMember(Name="maxSubfilesPerMpu", EmitDefaultValue=true)]
        public int? MaxSubfilesPerMpu { get; set; }

        /// <summary>
        /// Whether this view has ever had any object with tags. This should be enabled only when first object tag is ever put in this view.
        /// </summary>
        /// <value>Whether this view has ever had any object with tags. This should be enabled only when first object tag is ever put in this view.</value>
        [DataMember(Name="objectTagsAdded", EmitDefaultValue=true)]
        public bool? ObjectTagsAdded { get; set; }

        /// <summary>
        /// Gets or Sets OwnerInfo
        /// </summary>
        [DataMember(Name="ownerInfo", EmitDefaultValue=false)]
        public OwnerInfo OwnerInfo { get; set; }

        /// <summary>
        /// Gets or Sets OwnershipControls
        /// </summary>
        [DataMember(Name="ownershipControls", EmitDefaultValue=false)]
        public BucketOwnershipControls OwnershipControls { get; set; }

        /// <summary>
        /// Delimiter used in prefix based request routing. An application needs to explicitly set the prefix_delimiter during bucket creation. If the prefix_delimiter is not explicitly set, &#39;/&#39; will be used as the default prefix delimiter for buckets that has prefix-based-routing enabled. SnapDiff backups uses &#39;/&#39; in the object names hence it was chosen as the default prefix to avoid further UI changes in this project. If there are other use cases that require a different prefix_delimiter, it has to be set during bucket creation. Once prefix_delimiter is chosen, it cannot be changed.
        /// </summary>
        /// <value>Delimiter used in prefix based request routing. An application needs to explicitly set the prefix_delimiter during bucket creation. If the prefix_delimiter is not explicitly set, &#39;/&#39; will be used as the default prefix delimiter for buckets that has prefix-based-routing enabled. SnapDiff backups uses &#39;/&#39; in the object names hence it was chosen as the default prefix to avoid further UI changes in this project. If there are other use cases that require a different prefix_delimiter, it has to be set during bucket creation. Once prefix_delimiter is chosen, it cannot be changed.</value>
        [DataMember(Name="prefixDelimiter", EmitDefaultValue=true)]
        public string PrefixDelimiter { get; set; }

        /// <summary>
        /// Stores the prefix to child bucket mapping to enable prefix based routing of object requests to child buckets.
        /// </summary>
        /// <value>Stores the prefix to child bucket mapping to enable prefix based routing of object requests to child buckets.</value>
        [DataMember(Name="prefixToChildBucketMap", EmitDefaultValue=true)]
        public List<S3BucketConfigProtoPrefixToChildBucketMapEntry> PrefixToChildBucketMap { get; set; }

        /// <summary>
        /// Protocol type of this bucket.
        /// </summary>
        /// <value>Protocol type of this bucket.</value>
        [DataMember(Name="protocolType", EmitDefaultValue=true)]
        public int? ProtocolType { get; set; }

        /// <summary>
        /// Gets or Sets SwiftContainerTag
        /// </summary>
        [DataMember(Name="swiftContainerTag", EmitDefaultValue=false)]
        public SwiftContainerTaggingProto SwiftContainerTag { get; set; }

        /// <summary>
        /// Tags (or labels) assigned to the bucket. Tags are set of &lt;key, value&gt; pairs.
        /// </summary>
        /// <value>Tags (or labels) assigned to the bucket. Tags are set of &lt;key, value&gt; pairs.</value>
        [DataMember(Name="tagMap", EmitDefaultValue=true)]
        public List<S3BucketConfigProtoTagMapEntry> TagMap { get; set; }

        /// <summary>
        /// Gets or Sets VersioningState
        /// </summary>
        [DataMember(Name="versioningState", EmitDefaultValue=true)]
        public int? VersioningState { get; set; }

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
            return this.Equals(input as S3BucketConfigProto);
        }

        /// <summary>
        /// Returns true if S3BucketConfigProto instances are equal
        /// </summary>
        /// <param name="input">Instance of S3BucketConfigProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(S3BucketConfigProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AbacEnabled == input.AbacEnabled ||
                    (this.AbacEnabled != null &&
                    this.AbacEnabled.Equals(input.AbacEnabled))
                ) && 
                (
                    this.Acl == input.Acl ||
                    (this.Acl != null &&
                    this.Acl.Equals(input.Acl))
                ) && 
                (
                    this.BucketPolicy == input.BucketPolicy ||
                    (this.BucketPolicy != null &&
                    this.BucketPolicy.Equals(input.BucketPolicy))
                ) && 
                (
                    this.EfficientMpuEnabled == input.EfficientMpuEnabled ||
                    (this.EfficientMpuEnabled != null &&
                    this.EfficientMpuEnabled.Equals(input.EfficientMpuEnabled))
                ) && 
                (
                    this.EnableObjStoreAccess == input.EnableObjStoreAccess ||
                    (this.EnableObjStoreAccess != null &&
                    this.EnableObjStoreAccess.Equals(input.EnableObjStoreAccess))
                ) && 
                (
                    this.InitClusterId == input.InitClusterId ||
                    (this.InitClusterId != null &&
                    this.InitClusterId.Equals(input.InitClusterId))
                ) && 
                (
                    this.InitClusterIncarnationId == input.InitClusterIncarnationId ||
                    (this.InitClusterIncarnationId != null &&
                    this.InitClusterIncarnationId.Equals(input.InitClusterIncarnationId))
                ) && 
                (
                    this.LifecycleConfig == input.LifecycleConfig ||
                    (this.LifecycleConfig != null &&
                    this.LifecycleConfig.Equals(input.LifecycleConfig))
                ) && 
                (
                    this.MaxSubfilesPerMpu == input.MaxSubfilesPerMpu ||
                    (this.MaxSubfilesPerMpu != null &&
                    this.MaxSubfilesPerMpu.Equals(input.MaxSubfilesPerMpu))
                ) && 
                (
                    this.ObjectTagsAdded == input.ObjectTagsAdded ||
                    (this.ObjectTagsAdded != null &&
                    this.ObjectTagsAdded.Equals(input.ObjectTagsAdded))
                ) && 
                (
                    this.OwnerInfo == input.OwnerInfo ||
                    (this.OwnerInfo != null &&
                    this.OwnerInfo.Equals(input.OwnerInfo))
                ) && 
                (
                    this.OwnershipControls == input.OwnershipControls ||
                    (this.OwnershipControls != null &&
                    this.OwnershipControls.Equals(input.OwnershipControls))
                ) && 
                (
                    this.PrefixDelimiter == input.PrefixDelimiter ||
                    (this.PrefixDelimiter != null &&
                    this.PrefixDelimiter.Equals(input.PrefixDelimiter))
                ) && 
                (
                    this.PrefixToChildBucketMap == input.PrefixToChildBucketMap ||
                    this.PrefixToChildBucketMap != null &&
                    input.PrefixToChildBucketMap != null &&
                    this.PrefixToChildBucketMap.SequenceEqual(input.PrefixToChildBucketMap)
                ) && 
                (
                    this.ProtocolType == input.ProtocolType ||
                    (this.ProtocolType != null &&
                    this.ProtocolType.Equals(input.ProtocolType))
                ) && 
                (
                    this.SwiftContainerTag == input.SwiftContainerTag ||
                    (this.SwiftContainerTag != null &&
                    this.SwiftContainerTag.Equals(input.SwiftContainerTag))
                ) && 
                (
                    this.TagMap == input.TagMap ||
                    this.TagMap != null &&
                    input.TagMap != null &&
                    this.TagMap.SequenceEqual(input.TagMap)
                ) && 
                (
                    this.VersioningState == input.VersioningState ||
                    (this.VersioningState != null &&
                    this.VersioningState.Equals(input.VersioningState))
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
                if (this.AbacEnabled != null)
                    hashCode = hashCode * 59 + this.AbacEnabled.GetHashCode();
                if (this.Acl != null)
                    hashCode = hashCode * 59 + this.Acl.GetHashCode();
                if (this.BucketPolicy != null)
                    hashCode = hashCode * 59 + this.BucketPolicy.GetHashCode();
                if (this.EfficientMpuEnabled != null)
                    hashCode = hashCode * 59 + this.EfficientMpuEnabled.GetHashCode();
                if (this.EnableObjStoreAccess != null)
                    hashCode = hashCode * 59 + this.EnableObjStoreAccess.GetHashCode();
                if (this.InitClusterId != null)
                    hashCode = hashCode * 59 + this.InitClusterId.GetHashCode();
                if (this.InitClusterIncarnationId != null)
                    hashCode = hashCode * 59 + this.InitClusterIncarnationId.GetHashCode();
                if (this.LifecycleConfig != null)
                    hashCode = hashCode * 59 + this.LifecycleConfig.GetHashCode();
                if (this.MaxSubfilesPerMpu != null)
                    hashCode = hashCode * 59 + this.MaxSubfilesPerMpu.GetHashCode();
                if (this.ObjectTagsAdded != null)
                    hashCode = hashCode * 59 + this.ObjectTagsAdded.GetHashCode();
                if (this.OwnerInfo != null)
                    hashCode = hashCode * 59 + this.OwnerInfo.GetHashCode();
                if (this.OwnershipControls != null)
                    hashCode = hashCode * 59 + this.OwnershipControls.GetHashCode();
                if (this.PrefixDelimiter != null)
                    hashCode = hashCode * 59 + this.PrefixDelimiter.GetHashCode();
                if (this.PrefixToChildBucketMap != null)
                    hashCode = hashCode * 59 + this.PrefixToChildBucketMap.GetHashCode();
                if (this.ProtocolType != null)
                    hashCode = hashCode * 59 + this.ProtocolType.GetHashCode();
                if (this.SwiftContainerTag != null)
                    hashCode = hashCode * 59 + this.SwiftContainerTag.GetHashCode();
                if (this.TagMap != null)
                    hashCode = hashCode * 59 + this.TagMap.GetHashCode();
                if (this.VersioningState != null)
                    hashCode = hashCode * 59 + this.VersioningState.GetHashCode();
                return hashCode;
            }
        }

    }

}


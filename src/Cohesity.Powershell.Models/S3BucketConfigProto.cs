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
        /// <param name="acl">acl.</param>
        /// <param name="bucketPolicy">bucketPolicy.</param>
        /// <param name="enableObjStoreAccess">If set to false, we disable access to view using S3/Swift protocol. This overrides any &#39;protocol_access_info&#39; set on view for S3/Swift. This flag is added as the transition for S3 native to non-S3 native is disabled and therefore the access using S3/Swift protocol cannot be disabled by madrox..</param>
        /// <param name="initClusterId">The cluster id for the cluster where the view was initially created without replication. For view on Rx, the init_cluster_id will remain same as that of the initial cluster..</param>
        /// <param name="initClusterIncarnationId">The cluster incarnation id for the cluster where the view was initially created without replication. For view on Rx, the init_incarnation_cluster_id will remain same as that of the initial cluster..</param>
        /// <param name="lifecycleConfig">lifecycleConfig.</param>
        /// <param name="ownerInfo">ownerInfo.</param>
        /// <param name="ownershipControls">ownershipControls.</param>
        /// <param name="protocolType">Protocol type of this bucket..</param>
        /// <param name="swiftContainerTag">swiftContainerTag.</param>
        /// <param name="tagMap">Tags (or labels) assigned to the bucket. Tags are set of &lt;key, value&gt; pairs..</param>
        /// <param name="versioningState">versioningState.</param>
        public S3BucketConfigProto(ACLProto acl = default(ACLProto), BucketPolicy bucketPolicy = default(BucketPolicy), bool? enableObjStoreAccess = default(bool?), long? initClusterId = default(long?), long? initClusterIncarnationId = default(long?), LifecycleConfigProto lifecycleConfig = default(LifecycleConfigProto), OwnerInfo ownerInfo = default(OwnerInfo), BucketOwnershipControls ownershipControls = default(BucketOwnershipControls), int? protocolType = default(int?), SwiftContainerTaggingProto swiftContainerTag = default(SwiftContainerTaggingProto), List<S3BucketConfigProtoTagMapEntry> tagMap = default(List<S3BucketConfigProtoTagMapEntry>), int? versioningState = default(int?))
        {
            this.EnableObjStoreAccess = enableObjStoreAccess;
            this.InitClusterId = initClusterId;
            this.InitClusterIncarnationId = initClusterIncarnationId;
            this.ProtocolType = protocolType;
            this.TagMap = tagMap;
            this.VersioningState = versioningState;
            this.Acl = acl;
            this.BucketPolicy = bucketPolicy;
            this.EnableObjStoreAccess = enableObjStoreAccess;
            this.InitClusterId = initClusterId;
            this.InitClusterIncarnationId = initClusterIncarnationId;
            this.LifecycleConfig = lifecycleConfig;
            this.OwnerInfo = ownerInfo;
            this.OwnershipControls = ownershipControls;
            this.ProtocolType = protocolType;
            this.SwiftContainerTag = swiftContainerTag;
            this.TagMap = tagMap;
            this.VersioningState = versioningState;
        }
        
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
                if (this.Acl != null)
                    hashCode = hashCode * 59 + this.Acl.GetHashCode();
                if (this.BucketPolicy != null)
                    hashCode = hashCode * 59 + this.BucketPolicy.GetHashCode();
                if (this.EnableObjStoreAccess != null)
                    hashCode = hashCode * 59 + this.EnableObjStoreAccess.GetHashCode();
                if (this.InitClusterId != null)
                    hashCode = hashCode * 59 + this.InitClusterId.GetHashCode();
                if (this.InitClusterIncarnationId != null)
                    hashCode = hashCode * 59 + this.InitClusterIncarnationId.GetHashCode();
                if (this.LifecycleConfig != null)
                    hashCode = hashCode * 59 + this.LifecycleConfig.GetHashCode();
                if (this.OwnerInfo != null)
                    hashCode = hashCode * 59 + this.OwnerInfo.GetHashCode();
                if (this.OwnershipControls != null)
                    hashCode = hashCode * 59 + this.OwnershipControls.GetHashCode();
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


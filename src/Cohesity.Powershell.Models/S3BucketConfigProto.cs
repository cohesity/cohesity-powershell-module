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
        /// <param name="lifecycleConfig">lifecycleConfig.</param>
        /// <param name="ownerInfo">ownerInfo.</param>
        /// <param name="protocolType">Protocol type of this bucket..</param>
        /// <param name="swiftContainerTag">swiftContainerTag.</param>
        /// <param name="tagMap">Tags (or labels) assigned to the bucket. Tags are set of &lt;key, value&gt; pairs..</param>
        /// <param name="versioningState">versioningState.</param>
        public S3BucketConfigProto(ACLProto acl = default(ACLProto), LifecycleConfigProto lifecycleConfig = default(LifecycleConfigProto), OwnerInfo ownerInfo = default(OwnerInfo), int? protocolType = default(int?), SwiftContainerTaggingProto swiftContainerTag = default(SwiftContainerTaggingProto), List<S3BucketConfigProtoTagMapEntry> tagMap = default(List<S3BucketConfigProtoTagMapEntry>), int? versioningState = default(int?))
        {
            this.Acl = acl;
            this.LifecycleConfig = lifecycleConfig;
            this.OwnerInfo = ownerInfo;
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
        /// Protocol type of this bucket.
        /// </summary>
        /// <value>Protocol type of this bucket.</value>
        [DataMember(Name="protocolType", EmitDefaultValue=false)]
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
        [DataMember(Name="tagMap", EmitDefaultValue=false)]
        public List<S3BucketConfigProtoTagMapEntry> TagMap { get; set; }

        /// <summary>
        /// Gets or Sets VersioningState
        /// </summary>
        [DataMember(Name="versioningState", EmitDefaultValue=false)]
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
                    this.TagMap.Equals(input.TagMap)
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
                if (this.LifecycleConfig != null)
                    hashCode = hashCode * 59 + this.LifecycleConfig.GetHashCode();
                if (this.OwnerInfo != null)
                    hashCode = hashCode * 59 + this.OwnerInfo.GetHashCode();
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


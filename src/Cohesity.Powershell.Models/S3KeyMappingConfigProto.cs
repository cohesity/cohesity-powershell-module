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
    /// When key mapping is configured, S3 protocol layer will convert S3 object keys into multi-component snap_fs paths by segmenting the key into components. Each component will be of size segment_length. If max_segments is specified, the number of segments will be limited to that value. If the length of the object key is &gt;&#x3D; segment_length * max_segments, only the first segment_length * max_segments will be segmented and rest of the key will be left untouched. E.g.: If segment_length is set to 2 and max_segments is set to 2, following will be the mapping. 1. abcdefg -&gt; ab/cd/efg 2. abc -&gt; ab/c
    /// </summary>
    [DataContract]
    public partial class S3KeyMappingConfigProto :  IEquatable<S3KeyMappingConfigProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="S3KeyMappingConfigProto" /> class.
        /// </summary>
        /// <param name="maxSegments">Maximum number of components in the segmented object name..</param>
        /// <param name="objectSnapTreeEnabled">This is true if S3 view is created using s3_object_snap_tree..</param>
        /// <param name="segmentLength">Length of the each path component when the object name is segmented..</param>
        public S3KeyMappingConfigProto(int? maxSegments = default(int?), bool? objectSnapTreeEnabled = default(bool?), int? segmentLength = default(int?))
        {
            this.MaxSegments = maxSegments;
            this.ObjectSnapTreeEnabled = objectSnapTreeEnabled;
            this.SegmentLength = segmentLength;
            this.MaxSegments = maxSegments;
            this.ObjectSnapTreeEnabled = objectSnapTreeEnabled;
            this.SegmentLength = segmentLength;
        }
        
        /// <summary>
        /// Maximum number of components in the segmented object name.
        /// </summary>
        /// <value>Maximum number of components in the segmented object name.</value>
        [DataMember(Name="maxSegments", EmitDefaultValue=true)]
        public int? MaxSegments { get; set; }

        /// <summary>
        /// This is true if S3 view is created using s3_object_snap_tree.
        /// </summary>
        /// <value>This is true if S3 view is created using s3_object_snap_tree.</value>
        [DataMember(Name="objectSnapTreeEnabled", EmitDefaultValue=true)]
        public bool? ObjectSnapTreeEnabled { get; set; }

        /// <summary>
        /// Length of the each path component when the object name is segmented.
        /// </summary>
        /// <value>Length of the each path component when the object name is segmented.</value>
        [DataMember(Name="segmentLength", EmitDefaultValue=true)]
        public int? SegmentLength { get; set; }

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
            return this.Equals(input as S3KeyMappingConfigProto);
        }

        /// <summary>
        /// Returns true if S3KeyMappingConfigProto instances are equal
        /// </summary>
        /// <param name="input">Instance of S3KeyMappingConfigProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(S3KeyMappingConfigProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaxSegments == input.MaxSegments ||
                    (this.MaxSegments != null &&
                    this.MaxSegments.Equals(input.MaxSegments))
                ) && 
                (
                    this.ObjectSnapTreeEnabled == input.ObjectSnapTreeEnabled ||
                    (this.ObjectSnapTreeEnabled != null &&
                    this.ObjectSnapTreeEnabled.Equals(input.ObjectSnapTreeEnabled))
                ) && 
                (
                    this.SegmentLength == input.SegmentLength ||
                    (this.SegmentLength != null &&
                    this.SegmentLength.Equals(input.SegmentLength))
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
                if (this.MaxSegments != null)
                    hashCode = hashCode * 59 + this.MaxSegments.GetHashCode();
                if (this.ObjectSnapTreeEnabled != null)
                    hashCode = hashCode * 59 + this.ObjectSnapTreeEnabled.GetHashCode();
                if (this.SegmentLength != null)
                    hashCode = hashCode * 59 + this.SegmentLength.GetHashCode();
                return hashCode;
            }
        }

    }

}


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
    /// Specifies universal id of the Protection source specific to a cluster.
    /// </summary>
    [DataContract]
    public partial class ProtectionSourceUid :  IEquatable<ProtectionSourceUid>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionSourceUid" /> class.
        /// </summary>
        /// <param name="clusterId">Specifies the id of the cluster on which object is present..</param>
        /// <param name="clusterIncarnationId">Specifies the incarnation id of the cluster on which object is present..</param>
        /// <param name="parentSourceId">Specifies parent source id of an object..</param>
        /// <param name="sourceId">Specifies source id of an object..</param>
        public ProtectionSourceUid(long? clusterId = default(long?), long? clusterIncarnationId = default(long?), long? parentSourceId = default(long?), long? sourceId = default(long?))
        {
            this.ClusterId = clusterId;
            this.ClusterIncarnationId = clusterIncarnationId;
            this.ParentSourceId = parentSourceId;
            this.SourceId = sourceId;
        }
        
        /// <summary>
        /// Specifies the id of the cluster on which object is present.
        /// </summary>
        /// <value>Specifies the id of the cluster on which object is present.</value>
        [DataMember(Name="clusterId", EmitDefaultValue=false)]
        public long? ClusterId { get; set; }

        /// <summary>
        /// Specifies the incarnation id of the cluster on which object is present.
        /// </summary>
        /// <value>Specifies the incarnation id of the cluster on which object is present.</value>
        [DataMember(Name="clusterIncarnationId", EmitDefaultValue=false)]
        public long? ClusterIncarnationId { get; set; }

        /// <summary>
        /// Specifies parent source id of an object.
        /// </summary>
        /// <value>Specifies parent source id of an object.</value>
        [DataMember(Name="parentSourceId", EmitDefaultValue=false)]
        public long? ParentSourceId { get; set; }

        /// <summary>
        /// Specifies source id of an object.
        /// </summary>
        /// <value>Specifies source id of an object.</value>
        [DataMember(Name="sourceId", EmitDefaultValue=false)]
        public long? SourceId { get; set; }

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
            return this.Equals(input as ProtectionSourceUid);
        }

        /// <summary>
        /// Returns true if ProtectionSourceUid instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectionSourceUid to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectionSourceUid input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterId == input.ClusterId ||
                    (this.ClusterId != null &&
                    this.ClusterId.Equals(input.ClusterId))
                ) && 
                (
                    this.ClusterIncarnationId == input.ClusterIncarnationId ||
                    (this.ClusterIncarnationId != null &&
                    this.ClusterIncarnationId.Equals(input.ClusterIncarnationId))
                ) && 
                (
                    this.ParentSourceId == input.ParentSourceId ||
                    (this.ParentSourceId != null &&
                    this.ParentSourceId.Equals(input.ParentSourceId))
                ) && 
                (
                    this.SourceId == input.SourceId ||
                    (this.SourceId != null &&
                    this.SourceId.Equals(input.SourceId))
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
                if (this.ClusterId != null)
                    hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.ClusterIncarnationId != null)
                    hashCode = hashCode * 59 + this.ClusterIncarnationId.GetHashCode();
                if (this.ParentSourceId != null)
                    hashCode = hashCode * 59 + this.ParentSourceId.GetHashCode();
                if (this.SourceId != null)
                    hashCode = hashCode * 59 + this.SourceId.GetHashCode();
                return hashCode;
            }
        }

    }

}


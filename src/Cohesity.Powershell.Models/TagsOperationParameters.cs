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
    /// TagsOperationParameters
    /// </summary>
    [DataContract]
    public partial class TagsOperationParameters :  IEquatable<TagsOperationParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TagsOperationParameters" /> class.
        /// </summary>
        /// <param name="clusterId">ClusterId is the Id of the cluster used for constructing JobUid..</param>
        /// <param name="clusterIncarnationId">ClusterIncarnationId is the incarnation Id of the cluster used for constructing JobUid..</param>
        /// <param name="documentIds">DocumentIds are list of documents to be tagged..</param>
        /// <param name="entityId">EntityId is the Id of the entity where the file resides..</param>
        /// <param name="jobId">JobId is the Id of the job that took the snapshot..</param>
        /// <param name="jobInstanceIds">JobInstanceIds to tag corresponding snapshots..</param>
        /// <param name="tagIds">Tags are list of tags uuids that will be operated on to corresponding objects..</param>
        /// <param name="tags">Tags are list of tags that will be operated on to corresponding objects. This is deprecated. Use tagIds instead. deprecated: true.</param>
        public TagsOperationParameters(long? clusterId = default(long?), long? clusterIncarnationId = default(long?), List<string> documentIds = default(List<string>), long? entityId = default(long?), long? jobId = default(long?), List<long> jobInstanceIds = default(List<long>), List<string> tagIds = default(List<string>), List<string> tags = default(List<string>))
        {
            this.ClusterId = clusterId;
            this.ClusterIncarnationId = clusterIncarnationId;
            this.DocumentIds = documentIds;
            this.EntityId = entityId;
            this.JobId = jobId;
            this.JobInstanceIds = jobInstanceIds;
            this.TagIds = tagIds;
            this.Tags = tags;
        }
        
        /// <summary>
        /// ClusterId is the Id of the cluster used for constructing JobUid.
        /// </summary>
        /// <value>ClusterId is the Id of the cluster used for constructing JobUid.</value>
        [DataMember(Name="clusterId", EmitDefaultValue=true)]
        public long? ClusterId { get; set; }

        /// <summary>
        /// ClusterIncarnationId is the incarnation Id of the cluster used for constructing JobUid.
        /// </summary>
        /// <value>ClusterIncarnationId is the incarnation Id of the cluster used for constructing JobUid.</value>
        [DataMember(Name="clusterIncarnationId", EmitDefaultValue=true)]
        public long? ClusterIncarnationId { get; set; }

        /// <summary>
        /// DocumentIds are list of documents to be tagged.
        /// </summary>
        /// <value>DocumentIds are list of documents to be tagged.</value>
        [DataMember(Name="documentIds", EmitDefaultValue=true)]
        public List<string> DocumentIds { get; set; }

        /// <summary>
        /// EntityId is the Id of the entity where the file resides.
        /// </summary>
        /// <value>EntityId is the Id of the entity where the file resides.</value>
        [DataMember(Name="entityId", EmitDefaultValue=true)]
        public long? EntityId { get; set; }

        /// <summary>
        /// JobId is the Id of the job that took the snapshot.
        /// </summary>
        /// <value>JobId is the Id of the job that took the snapshot.</value>
        [DataMember(Name="jobId", EmitDefaultValue=true)]
        public long? JobId { get; set; }

        /// <summary>
        /// JobInstanceIds to tag corresponding snapshots.
        /// </summary>
        /// <value>JobInstanceIds to tag corresponding snapshots.</value>
        [DataMember(Name="jobInstanceIds", EmitDefaultValue=true)]
        public List<long> JobInstanceIds { get; set; }

        /// <summary>
        /// Tags are list of tags uuids that will be operated on to corresponding objects.
        /// </summary>
        /// <value>Tags are list of tags uuids that will be operated on to corresponding objects.</value>
        [DataMember(Name="tagIds", EmitDefaultValue=true)]
        public List<string> TagIds { get; set; }

        /// <summary>
        /// Tags are list of tags that will be operated on to corresponding objects. This is deprecated. Use tagIds instead. deprecated: true
        /// </summary>
        /// <value>Tags are list of tags that will be operated on to corresponding objects. This is deprecated. Use tagIds instead. deprecated: true</value>
        [DataMember(Name="tags", EmitDefaultValue=true)]
        public List<string> Tags { get; set; }

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
            return this.Equals(input as TagsOperationParameters);
        }

        /// <summary>
        /// Returns true if TagsOperationParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of TagsOperationParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TagsOperationParameters input)
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
                    this.DocumentIds == input.DocumentIds ||
                    this.DocumentIds != null &&
                    input.DocumentIds != null &&
                    this.DocumentIds.Equals(input.DocumentIds)
                ) && 
                (
                    this.EntityId == input.EntityId ||
                    (this.EntityId != null &&
                    this.EntityId.Equals(input.EntityId))
                ) && 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.JobInstanceIds == input.JobInstanceIds ||
                    this.JobInstanceIds != null &&
                    input.JobInstanceIds != null &&
                    this.JobInstanceIds.Equals(input.JobInstanceIds)
                ) && 
                (
                    this.TagIds == input.TagIds ||
                    this.TagIds != null &&
                    input.TagIds != null &&
                    this.TagIds.Equals(input.TagIds)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.Equals(input.Tags)
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
                if (this.DocumentIds != null)
                    hashCode = hashCode * 59 + this.DocumentIds.GetHashCode();
                if (this.EntityId != null)
                    hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.JobInstanceIds != null)
                    hashCode = hashCode * 59 + this.JobInstanceIds.GetHashCode();
                if (this.TagIds != null)
                    hashCode = hashCode * 59 + this.TagIds.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }

    }

}


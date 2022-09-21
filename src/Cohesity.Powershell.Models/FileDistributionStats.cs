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
    /// Specifies the File distribution stats.
    /// </summary>
    [DataContract]
    public partial class FileDistributionStats :  IEquatable<FileDistributionStats>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileDistributionStats" /> class.
        /// </summary>
        /// <param name="clusterId">Specifies the cluster Id..</param>
        /// <param name="clusterIncarnationId">Specifies the cluster Incarnation Id..</param>
        /// <param name="entityId">Specifies the id of the entity for which file distribution stats are computed..</param>
        /// <param name="entityName">Specifies the name of the entity for which file distribution stats are computed..</param>
        /// <param name="metricsList">Specifies the list of file stats for different file extensions..</param>
        public FileDistributionStats(long? clusterId = default(long?), long? clusterIncarnationId = default(long?), long? entityId = default(long?), string entityName = default(string), List<FileDistributionMetrics> metricsList = default(List<FileDistributionMetrics>))
        {
            this.ClusterId = clusterId;
            this.ClusterIncarnationId = clusterIncarnationId;
            this.EntityId = entityId;
            this.EntityName = entityName;
            this.MetricsList = metricsList;
            this.ClusterId = clusterId;
            this.ClusterIncarnationId = clusterIncarnationId;
            this.EntityId = entityId;
            this.EntityName = entityName;
            this.MetricsList = metricsList;
        }
        
        /// <summary>
        /// Specifies the cluster Id.
        /// </summary>
        /// <value>Specifies the cluster Id.</value>
        [DataMember(Name="clusterId", EmitDefaultValue=true)]
        public long? ClusterId { get; set; }

        /// <summary>
        /// Specifies the cluster Incarnation Id.
        /// </summary>
        /// <value>Specifies the cluster Incarnation Id.</value>
        [DataMember(Name="clusterIncarnationId", EmitDefaultValue=true)]
        public long? ClusterIncarnationId { get; set; }

        /// <summary>
        /// Specifies the id of the entity for which file distribution stats are computed.
        /// </summary>
        /// <value>Specifies the id of the entity for which file distribution stats are computed.</value>
        [DataMember(Name="entityId", EmitDefaultValue=true)]
        public long? EntityId { get; set; }

        /// <summary>
        /// Specifies the name of the entity for which file distribution stats are computed.
        /// </summary>
        /// <value>Specifies the name of the entity for which file distribution stats are computed.</value>
        [DataMember(Name="entityName", EmitDefaultValue=true)]
        public string EntityName { get; set; }

        /// <summary>
        /// Specifies the list of file stats for different file extensions.
        /// </summary>
        /// <value>Specifies the list of file stats for different file extensions.</value>
        [DataMember(Name="metricsList", EmitDefaultValue=true)]
        public List<FileDistributionMetrics> MetricsList { get; set; }

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
            return this.Equals(input as FileDistributionStats);
        }

        /// <summary>
        /// Returns true if FileDistributionStats instances are equal
        /// </summary>
        /// <param name="input">Instance of FileDistributionStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileDistributionStats input)
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
                    this.EntityId == input.EntityId ||
                    (this.EntityId != null &&
                    this.EntityId.Equals(input.EntityId))
                ) && 
                (
                    this.EntityName == input.EntityName ||
                    (this.EntityName != null &&
                    this.EntityName.Equals(input.EntityName))
                ) && 
                (
                    this.MetricsList == input.MetricsList ||
                    this.MetricsList != null &&
                    input.MetricsList != null &&
                    this.MetricsList.Equals(input.MetricsList)
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
                if (this.EntityId != null)
                    hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                if (this.EntityName != null)
                    hashCode = hashCode * 59 + this.EntityName.GetHashCode();
                if (this.MetricsList != null)
                    hashCode = hashCode * 59 + this.MetricsList.GetHashCode();
                return hashCode;
            }
        }

    }

}


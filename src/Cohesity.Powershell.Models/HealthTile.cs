// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// HealthTile
    /// </summary>
    [DataContract]
    public partial class HealthTile :  IEquatable<HealthTile>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HealthTile" /> class.
        /// </summary>
        /// <param name="capacityBytes">Raw Cluster Capacity in Bytes. This is not usable capacity and does not take replication factor into account..</param>
        /// <param name="clusterCloudUsageBytes">Usage in Bytes on the cloud..</param>
        /// <param name="lastDayAlerts">lastDayAlerts.</param>
        /// <param name="lastDayNumCriticals">Number of Critical Alerts..</param>
        /// <param name="lastDayNumWarnings">Number of Warning Alerts..</param>
        /// <param name="numNodes">Number of nodes in the cluster..</param>
        /// <param name="numNodesWithIssues">Number of nodes in the cluster that are unhealthy..</param>
        /// <param name="percentFull">Percent the cluster is full..</param>
        /// <param name="rawUsedBytes">Raw Bytes used in the cluster..</param>
        public HealthTile(long? capacityBytes = default(long?), long? clusterCloudUsageBytes = default(long?), List<Alert> lastDayAlerts = default(List<Alert>), long? lastDayNumCriticals = default(long?), long? lastDayNumWarnings = default(long?), int? numNodes = default(int?), int? numNodesWithIssues = default(int?), float? percentFull = default(float?), long? rawUsedBytes = default(long?))
        {
            this.CapacityBytes = capacityBytes;
            this.ClusterCloudUsageBytes = clusterCloudUsageBytes;
            this.LastDayAlerts = lastDayAlerts;
            this.LastDayNumCriticals = lastDayNumCriticals;
            this.LastDayNumWarnings = lastDayNumWarnings;
            this.NumNodes = numNodes;
            this.NumNodesWithIssues = numNodesWithIssues;
            this.PercentFull = percentFull;
            this.RawUsedBytes = rawUsedBytes;
        }
        
        /// <summary>
        /// Raw Cluster Capacity in Bytes. This is not usable capacity and does not take replication factor into account.
        /// </summary>
        /// <value>Raw Cluster Capacity in Bytes. This is not usable capacity and does not take replication factor into account.</value>
        [DataMember(Name="capacityBytes", EmitDefaultValue=false)]
        public long? CapacityBytes { get; set; }

        /// <summary>
        /// Usage in Bytes on the cloud.
        /// </summary>
        /// <value>Usage in Bytes on the cloud.</value>
        [DataMember(Name="clusterCloudUsageBytes", EmitDefaultValue=false)]
        public long? ClusterCloudUsageBytes { get; set; }

        /// <summary>
        /// Gets or Sets LastDayAlerts
        /// </summary>
        [DataMember(Name="lastDayAlerts", EmitDefaultValue=false)]
        public List<Alert> LastDayAlerts { get; set; }

        /// <summary>
        /// Number of Critical Alerts.
        /// </summary>
        /// <value>Number of Critical Alerts.</value>
        [DataMember(Name="lastDayNumCriticals", EmitDefaultValue=false)]
        public long? LastDayNumCriticals { get; set; }

        /// <summary>
        /// Number of Warning Alerts.
        /// </summary>
        /// <value>Number of Warning Alerts.</value>
        [DataMember(Name="lastDayNumWarnings", EmitDefaultValue=false)]
        public long? LastDayNumWarnings { get; set; }

        /// <summary>
        /// Number of nodes in the cluster.
        /// </summary>
        /// <value>Number of nodes in the cluster.</value>
        [DataMember(Name="numNodes", EmitDefaultValue=false)]
        public int? NumNodes { get; set; }

        /// <summary>
        /// Number of nodes in the cluster that are unhealthy.
        /// </summary>
        /// <value>Number of nodes in the cluster that are unhealthy.</value>
        [DataMember(Name="numNodesWithIssues", EmitDefaultValue=false)]
        public int? NumNodesWithIssues { get; set; }

        /// <summary>
        /// Percent the cluster is full.
        /// </summary>
        /// <value>Percent the cluster is full.</value>
        [DataMember(Name="percentFull", EmitDefaultValue=false)]
        public float? PercentFull { get; set; }

        /// <summary>
        /// Raw Bytes used in the cluster.
        /// </summary>
        /// <value>Raw Bytes used in the cluster.</value>
        [DataMember(Name="rawUsedBytes", EmitDefaultValue=false)]
        public long? RawUsedBytes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }
  
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
            return this.Equals(input as HealthTile);
        }

        /// <summary>
        /// Returns true if HealthTile instances are equal
        /// </summary>
        /// <param name="input">Instance of HealthTile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HealthTile input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CapacityBytes == input.CapacityBytes ||
                    (this.CapacityBytes != null &&
                    this.CapacityBytes.Equals(input.CapacityBytes))
                ) && 
                (
                    this.ClusterCloudUsageBytes == input.ClusterCloudUsageBytes ||
                    (this.ClusterCloudUsageBytes != null &&
                    this.ClusterCloudUsageBytes.Equals(input.ClusterCloudUsageBytes))
                ) && 
                (
                    this.LastDayAlerts == input.LastDayAlerts ||
                    this.LastDayAlerts != null &&
                    this.LastDayAlerts.SequenceEqual(input.LastDayAlerts)
                ) && 
                (
                    this.LastDayNumCriticals == input.LastDayNumCriticals ||
                    (this.LastDayNumCriticals != null &&
                    this.LastDayNumCriticals.Equals(input.LastDayNumCriticals))
                ) && 
                (
                    this.LastDayNumWarnings == input.LastDayNumWarnings ||
                    (this.LastDayNumWarnings != null &&
                    this.LastDayNumWarnings.Equals(input.LastDayNumWarnings))
                ) && 
                (
                    this.NumNodes == input.NumNodes ||
                    (this.NumNodes != null &&
                    this.NumNodes.Equals(input.NumNodes))
                ) && 
                (
                    this.NumNodesWithIssues == input.NumNodesWithIssues ||
                    (this.NumNodesWithIssues != null &&
                    this.NumNodesWithIssues.Equals(input.NumNodesWithIssues))
                ) && 
                (
                    this.PercentFull == input.PercentFull ||
                    (this.PercentFull != null &&
                    this.PercentFull.Equals(input.PercentFull))
                ) && 
                (
                    this.RawUsedBytes == input.RawUsedBytes ||
                    (this.RawUsedBytes != null &&
                    this.RawUsedBytes.Equals(input.RawUsedBytes))
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
                if (this.CapacityBytes != null)
                    hashCode = hashCode * 59 + this.CapacityBytes.GetHashCode();
                if (this.ClusterCloudUsageBytes != null)
                    hashCode = hashCode * 59 + this.ClusterCloudUsageBytes.GetHashCode();
                if (this.LastDayAlerts != null)
                    hashCode = hashCode * 59 + this.LastDayAlerts.GetHashCode();
                if (this.LastDayNumCriticals != null)
                    hashCode = hashCode * 59 + this.LastDayNumCriticals.GetHashCode();
                if (this.LastDayNumWarnings != null)
                    hashCode = hashCode * 59 + this.LastDayNumWarnings.GetHashCode();
                if (this.NumNodes != null)
                    hashCode = hashCode * 59 + this.NumNodes.GetHashCode();
                if (this.NumNodesWithIssues != null)
                    hashCode = hashCode * 59 + this.NumNodesWithIssues.GetHashCode();
                if (this.PercentFull != null)
                    hashCode = hashCode * 59 + this.PercentFull.GetHashCode();
                if (this.RawUsedBytes != null)
                    hashCode = hashCode * 59 + this.RawUsedBytes.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


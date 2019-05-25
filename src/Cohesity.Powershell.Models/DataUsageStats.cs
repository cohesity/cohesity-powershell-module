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
    /// Specifies the data usage metric of the data stored on the Cohesity Cluster or Storage Domains (View Boxes).
    /// </summary>
    [DataContract]
    public partial class DataUsageStats :  IEquatable<DataUsageStats>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataUsageStats" /> class.
        /// </summary>
        /// <param name="dataInBytes">Specifies the data brought into the cluster. This is the usage before data reduction..</param>
        /// <param name="dataInBytesAfterDedup">Specifies the the the size of the data has been reduced by change-block tracking and deduplication but before compression or data is replicated to other nodes as per RF or Erasure Coding policy..</param>
        /// <param name="dataWrittenBytes">Specifies the total data written on local and cloud tiers, as computed by the Cohesity Cluster, after the size of the data has been reduced by change-block tracking, deduplication and compression. This does not include resiliency impact..</param>
        /// <param name="localDataWrittenBytes">Specifies the total data written on local tiers, as computed by the Cohesity Cluster, after the size of the data has been reduced by change-block tracking, deduplication and compression. This does not include resiliency impact..</param>
        /// <param name="localTierResiliencyImpactBytes">Specifies the size of the data has been replicated to other nodes as per RF or Erasure Coding policy..</param>
        /// <param name="storageConsumedBytes">Specifies the total capacity, as computed by the Cohesity Cluster, after the size of the data has been reduced by change-block tracking, compression and deduplication. This includes resiliency impact..</param>
        public DataUsageStats(long? dataInBytes = default(long?), long? dataInBytesAfterDedup = default(long?), long? dataWrittenBytes = default(long?), long? localDataWrittenBytes = default(long?), long? localTierResiliencyImpactBytes = default(long?), long? storageConsumedBytes = default(long?))
        {
            this.DataInBytes = dataInBytes;
            this.DataInBytesAfterDedup = dataInBytesAfterDedup;
            this.DataWrittenBytes = dataWrittenBytes;
            this.LocalDataWrittenBytes = localDataWrittenBytes;
            this.LocalTierResiliencyImpactBytes = localTierResiliencyImpactBytes;
            this.StorageConsumedBytes = storageConsumedBytes;
            this.DataInBytes = dataInBytes;
            this.DataInBytesAfterDedup = dataInBytesAfterDedup;
            this.DataWrittenBytes = dataWrittenBytes;
            this.LocalDataWrittenBytes = localDataWrittenBytes;
            this.LocalTierResiliencyImpactBytes = localTierResiliencyImpactBytes;
            this.StorageConsumedBytes = storageConsumedBytes;
        }
        
        /// <summary>
        /// Specifies the data brought into the cluster. This is the usage before data reduction.
        /// </summary>
        /// <value>Specifies the data brought into the cluster. This is the usage before data reduction.</value>
        [DataMember(Name="dataInBytes", EmitDefaultValue=true)]
        public long? DataInBytes { get; set; }

        /// <summary>
        /// Specifies the the the size of the data has been reduced by change-block tracking and deduplication but before compression or data is replicated to other nodes as per RF or Erasure Coding policy.
        /// </summary>
        /// <value>Specifies the the the size of the data has been reduced by change-block tracking and deduplication but before compression or data is replicated to other nodes as per RF or Erasure Coding policy.</value>
        [DataMember(Name="dataInBytesAfterDedup", EmitDefaultValue=true)]
        public long? DataInBytesAfterDedup { get; set; }

        /// <summary>
        /// Specifies the total data written on local and cloud tiers, as computed by the Cohesity Cluster, after the size of the data has been reduced by change-block tracking, deduplication and compression. This does not include resiliency impact.
        /// </summary>
        /// <value>Specifies the total data written on local and cloud tiers, as computed by the Cohesity Cluster, after the size of the data has been reduced by change-block tracking, deduplication and compression. This does not include resiliency impact.</value>
        [DataMember(Name="dataWrittenBytes", EmitDefaultValue=true)]
        public long? DataWrittenBytes { get; set; }

        /// <summary>
        /// Specifies the total data written on local tiers, as computed by the Cohesity Cluster, after the size of the data has been reduced by change-block tracking, deduplication and compression. This does not include resiliency impact.
        /// </summary>
        /// <value>Specifies the total data written on local tiers, as computed by the Cohesity Cluster, after the size of the data has been reduced by change-block tracking, deduplication and compression. This does not include resiliency impact.</value>
        [DataMember(Name="localDataWrittenBytes", EmitDefaultValue=true)]
        public long? LocalDataWrittenBytes { get; set; }

        /// <summary>
        /// Specifies the size of the data has been replicated to other nodes as per RF or Erasure Coding policy.
        /// </summary>
        /// <value>Specifies the size of the data has been replicated to other nodes as per RF or Erasure Coding policy.</value>
        [DataMember(Name="localTierResiliencyImpactBytes", EmitDefaultValue=true)]
        public long? LocalTierResiliencyImpactBytes { get; set; }

        /// <summary>
        /// Specifies the total capacity, as computed by the Cohesity Cluster, after the size of the data has been reduced by change-block tracking, compression and deduplication. This includes resiliency impact.
        /// </summary>
        /// <value>Specifies the total capacity, as computed by the Cohesity Cluster, after the size of the data has been reduced by change-block tracking, compression and deduplication. This includes resiliency impact.</value>
        [DataMember(Name="storageConsumedBytes", EmitDefaultValue=true)]
        public long? StorageConsumedBytes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataUsageStats {\n");
            sb.Append("  DataInBytes: ").Append(DataInBytes).Append("\n");
            sb.Append("  DataInBytesAfterDedup: ").Append(DataInBytesAfterDedup).Append("\n");
            sb.Append("  DataWrittenBytes: ").Append(DataWrittenBytes).Append("\n");
            sb.Append("  LocalDataWrittenBytes: ").Append(LocalDataWrittenBytes).Append("\n");
            sb.Append("  LocalTierResiliencyImpactBytes: ").Append(LocalTierResiliencyImpactBytes).Append("\n");
            sb.Append("  StorageConsumedBytes: ").Append(StorageConsumedBytes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
            return this.Equals(input as DataUsageStats);
        }

        /// <summary>
        /// Returns true if DataUsageStats instances are equal
        /// </summary>
        /// <param name="input">Instance of DataUsageStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataUsageStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DataInBytes == input.DataInBytes ||
                    (this.DataInBytes != null &&
                    this.DataInBytes.Equals(input.DataInBytes))
                ) && 
                (
                    this.DataInBytesAfterDedup == input.DataInBytesAfterDedup ||
                    (this.DataInBytesAfterDedup != null &&
                    this.DataInBytesAfterDedup.Equals(input.DataInBytesAfterDedup))
                ) && 
                (
                    this.DataWrittenBytes == input.DataWrittenBytes ||
                    (this.DataWrittenBytes != null &&
                    this.DataWrittenBytes.Equals(input.DataWrittenBytes))
                ) && 
                (
                    this.LocalDataWrittenBytes == input.LocalDataWrittenBytes ||
                    (this.LocalDataWrittenBytes != null &&
                    this.LocalDataWrittenBytes.Equals(input.LocalDataWrittenBytes))
                ) && 
                (
                    this.LocalTierResiliencyImpactBytes == input.LocalTierResiliencyImpactBytes ||
                    (this.LocalTierResiliencyImpactBytes != null &&
                    this.LocalTierResiliencyImpactBytes.Equals(input.LocalTierResiliencyImpactBytes))
                ) && 
                (
                    this.StorageConsumedBytes == input.StorageConsumedBytes ||
                    (this.StorageConsumedBytes != null &&
                    this.StorageConsumedBytes.Equals(input.StorageConsumedBytes))
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
                if (this.DataInBytes != null)
                    hashCode = hashCode * 59 + this.DataInBytes.GetHashCode();
                if (this.DataInBytesAfterDedup != null)
                    hashCode = hashCode * 59 + this.DataInBytesAfterDedup.GetHashCode();
                if (this.DataWrittenBytes != null)
                    hashCode = hashCode * 59 + this.DataWrittenBytes.GetHashCode();
                if (this.LocalDataWrittenBytes != null)
                    hashCode = hashCode * 59 + this.LocalDataWrittenBytes.GetHashCode();
                if (this.LocalTierResiliencyImpactBytes != null)
                    hashCode = hashCode * 59 + this.LocalTierResiliencyImpactBytes.GetHashCode();
                if (this.StorageConsumedBytes != null)
                    hashCode = hashCode * 59 + this.StorageConsumedBytes.GetHashCode();
                return hashCode;
            }
        }

    }

}

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
        /// <param name="cloudDataWrittenBytes">Specifies the total data written on cloud tiers, as computed by the Cohesity Cluster..</param>
        /// <param name="cloudDataWrittenBytesTimestampUsec">Specifies Timestamp of CloudDataWrittenBytes..</param>
        /// <param name="cloudTotalPhysicalUsageBytes">Specifies the total cloud capacity, as computed by the Cohesity Cluster, after the size of the data has been reduced by change-block tracking, compression and deduplication..</param>
        /// <param name="cloudTotalPhysicalUsageBytesTimestampUsec">Specifies Timestamp of CloudTotalPhysicalUsageBytes..</param>
        /// <param name="dataInBytes">Specifies the data brought into the cluster. This is the usage before data reduction..</param>
        /// <param name="dataInBytesAfterDedup">Specifies the the the size of the data has been reduced by change-block tracking and deduplication but before compression or data is replicated to other nodes as per RF or Erasure Coding policy..</param>
        /// <param name="dataInBytesAfterDedupTimestampUsec">Specifies Timestamp of DataInBytesAfterDedup..</param>
        /// <param name="dataInBytesTimestampUsec">Specifies Timestamp of DataInBytes..</param>
        /// <param name="dataProtectLogicalUsageBytes">Specifies the logical data used by Data Protect on Cohesity cluster..</param>
        /// <param name="dataProtectLogicalUsageBytesTimestampUsec">Specifies Timestamp of DataProtectLogicalUsageBytes..</param>
        /// <param name="dataProtectPhysicalUsageBytes">Specifies the physical data used by Data Protect on Cohesity cluster..</param>
        /// <param name="dataProtectPhysicalUsageBytesTimestampUsec">Specifies Timestamp of DataProtectPhysicalUsageBytes..</param>
        /// <param name="dataWrittenBytes">Specifies the total data written on local and cloud tiers, as computed by the Cohesity Cluster, after the size of the data has been reduced by change-block tracking, deduplication and compression. This does not include resiliency impact..</param>
        /// <param name="dataWrittenBytesTimestampUsec">Specifies Timestamp of DataWrittenBytes..</param>
        /// <param name="fileServicesLogicalUsageBytes">Specifies the logical data used by File services on Cohesity cluster..</param>
        /// <param name="fileServicesLogicalUsageBytesTimestampUsec">Specifies Timestamp of FileServicesLogicalUsageBytes..</param>
        /// <param name="fileServicesPhysicalUsageBytes">Specifies the physical data used by File services on Cohesity cluster..</param>
        /// <param name="fileServicesPhysicalUsageBytesTimestampUsec">Specifies Timestamp of FileServicesPhysicalUsageBytes..</param>
        /// <param name="localDataWrittenBytes">Specifies the total data written on local tiers, as computed by the Cohesity Cluster, after the size of the data has been reduced by change-block tracking, deduplication and compression. This does not include resiliency impact..</param>
        /// <param name="localDataWrittenBytesTimestampUsec">Specifies Timestamp of LocalDataWrittenBytes..</param>
        /// <param name="localTierResiliencyImpactBytes">Specifies the size of the data has been replicated to other nodes as per RF or Erasure Coding policy..</param>
        /// <param name="localTierResiliencyImpactBytesTimestampUsec">Specifies Timestamp of LocalTierResiliencyImpactBytes..</param>
        /// <param name="localTotalPhysicalUsageBytes">Specifies the total local capacity, as computed by the Cohesity Cluster, after the size of the data has been reduced by change-block tracking, compression and deduplication..</param>
        /// <param name="localTotalPhysicalUsageBytesTimestampUsec">Specifies Timestamp of LocalTotalPhysicalUsageBytes..</param>
        /// <param name="outdatedLogicalUsageBytesTimestampUsec">Specifies Timestamp of OutdatedLogicalUsageBytes..</param>
        /// <param name="storageConsumedBytes">Specifies the total capacity, as computed by the Cohesity Cluster, after the size of the data has been reduced by change-block tracking, compression and deduplication. This includes resiliency impact..</param>
        /// <param name="storageConsumedBytesTimestampUsec">Specifies Timestamp of StorageConsumedBytes..</param>
        /// <param name="totalLogicalUsageBytes">Specifies the logical usage as computed by the Cohesity Cluster. The size of the data without reduction by change-block tracking, compression and deduplication..</param>
        /// <param name="totalLogicalUsageBytesTimestampUsec">Specifies Timestamp of TotalLogicalUsageBytes..</param>
        public DataUsageStats(long? cloudDataWrittenBytes = default(long?), long? cloudDataWrittenBytesTimestampUsec = default(long?), long? cloudTotalPhysicalUsageBytes = default(long?), long? cloudTotalPhysicalUsageBytesTimestampUsec = default(long?), long? dataInBytes = default(long?), long? dataInBytesAfterDedup = default(long?), long? dataInBytesAfterDedupTimestampUsec = default(long?), long? dataInBytesTimestampUsec = default(long?), long? dataProtectLogicalUsageBytes = default(long?), long? dataProtectLogicalUsageBytesTimestampUsec = default(long?), long? dataProtectPhysicalUsageBytes = default(long?), long? dataProtectPhysicalUsageBytesTimestampUsec = default(long?), long? dataWrittenBytes = default(long?), long? dataWrittenBytesTimestampUsec = default(long?), long? fileServicesLogicalUsageBytes = default(long?), long? fileServicesLogicalUsageBytesTimestampUsec = default(long?), long? fileServicesPhysicalUsageBytes = default(long?), long? fileServicesPhysicalUsageBytesTimestampUsec = default(long?), long? localDataWrittenBytes = default(long?), long? localDataWrittenBytesTimestampUsec = default(long?), long? localTierResiliencyImpactBytes = default(long?), long? localTierResiliencyImpactBytesTimestampUsec = default(long?), long? localTotalPhysicalUsageBytes = default(long?), long? localTotalPhysicalUsageBytesTimestampUsec = default(long?), long? outdatedLogicalUsageBytesTimestampUsec = default(long?), long? storageConsumedBytes = default(long?), long? storageConsumedBytesTimestampUsec = default(long?), long? totalLogicalUsageBytes = default(long?), long? totalLogicalUsageBytesTimestampUsec = default(long?))
        {
            this.CloudDataWrittenBytes = cloudDataWrittenBytes;
            this.CloudDataWrittenBytesTimestampUsec = cloudDataWrittenBytesTimestampUsec;
            this.CloudTotalPhysicalUsageBytes = cloudTotalPhysicalUsageBytes;
            this.CloudTotalPhysicalUsageBytesTimestampUsec = cloudTotalPhysicalUsageBytesTimestampUsec;
            this.DataInBytes = dataInBytes;
            this.DataInBytesAfterDedup = dataInBytesAfterDedup;
            this.DataInBytesAfterDedupTimestampUsec = dataInBytesAfterDedupTimestampUsec;
            this.DataInBytesTimestampUsec = dataInBytesTimestampUsec;
            this.DataProtectLogicalUsageBytes = dataProtectLogicalUsageBytes;
            this.DataProtectLogicalUsageBytesTimestampUsec = dataProtectLogicalUsageBytesTimestampUsec;
            this.DataProtectPhysicalUsageBytes = dataProtectPhysicalUsageBytes;
            this.DataProtectPhysicalUsageBytesTimestampUsec = dataProtectPhysicalUsageBytesTimestampUsec;
            this.DataWrittenBytes = dataWrittenBytes;
            this.DataWrittenBytesTimestampUsec = dataWrittenBytesTimestampUsec;
            this.FileServicesLogicalUsageBytes = fileServicesLogicalUsageBytes;
            this.FileServicesLogicalUsageBytesTimestampUsec = fileServicesLogicalUsageBytesTimestampUsec;
            this.FileServicesPhysicalUsageBytes = fileServicesPhysicalUsageBytes;
            this.FileServicesPhysicalUsageBytesTimestampUsec = fileServicesPhysicalUsageBytesTimestampUsec;
            this.LocalDataWrittenBytes = localDataWrittenBytes;
            this.LocalDataWrittenBytesTimestampUsec = localDataWrittenBytesTimestampUsec;
            this.LocalTierResiliencyImpactBytes = localTierResiliencyImpactBytes;
            this.LocalTierResiliencyImpactBytesTimestampUsec = localTierResiliencyImpactBytesTimestampUsec;
            this.LocalTotalPhysicalUsageBytes = localTotalPhysicalUsageBytes;
            this.LocalTotalPhysicalUsageBytesTimestampUsec = localTotalPhysicalUsageBytesTimestampUsec;
            this.OutdatedLogicalUsageBytesTimestampUsec = outdatedLogicalUsageBytesTimestampUsec;
            this.StorageConsumedBytes = storageConsumedBytes;
            this.StorageConsumedBytesTimestampUsec = storageConsumedBytesTimestampUsec;
            this.TotalLogicalUsageBytes = totalLogicalUsageBytes;
            this.TotalLogicalUsageBytesTimestampUsec = totalLogicalUsageBytesTimestampUsec;
            this.CloudDataWrittenBytes = cloudDataWrittenBytes;
            this.CloudDataWrittenBytesTimestampUsec = cloudDataWrittenBytesTimestampUsec;
            this.CloudTotalPhysicalUsageBytes = cloudTotalPhysicalUsageBytes;
            this.CloudTotalPhysicalUsageBytesTimestampUsec = cloudTotalPhysicalUsageBytesTimestampUsec;
            this.DataInBytes = dataInBytes;
            this.DataInBytesAfterDedup = dataInBytesAfterDedup;
            this.DataInBytesAfterDedupTimestampUsec = dataInBytesAfterDedupTimestampUsec;
            this.DataInBytesTimestampUsec = dataInBytesTimestampUsec;
            this.DataProtectLogicalUsageBytes = dataProtectLogicalUsageBytes;
            this.DataProtectLogicalUsageBytesTimestampUsec = dataProtectLogicalUsageBytesTimestampUsec;
            this.DataProtectPhysicalUsageBytes = dataProtectPhysicalUsageBytes;
            this.DataProtectPhysicalUsageBytesTimestampUsec = dataProtectPhysicalUsageBytesTimestampUsec;
            this.DataWrittenBytes = dataWrittenBytes;
            this.DataWrittenBytesTimestampUsec = dataWrittenBytesTimestampUsec;
            this.FileServicesLogicalUsageBytes = fileServicesLogicalUsageBytes;
            this.FileServicesLogicalUsageBytesTimestampUsec = fileServicesLogicalUsageBytesTimestampUsec;
            this.FileServicesPhysicalUsageBytes = fileServicesPhysicalUsageBytes;
            this.FileServicesPhysicalUsageBytesTimestampUsec = fileServicesPhysicalUsageBytesTimestampUsec;
            this.LocalDataWrittenBytes = localDataWrittenBytes;
            this.LocalDataWrittenBytesTimestampUsec = localDataWrittenBytesTimestampUsec;
            this.LocalTierResiliencyImpactBytes = localTierResiliencyImpactBytes;
            this.LocalTierResiliencyImpactBytesTimestampUsec = localTierResiliencyImpactBytesTimestampUsec;
            this.LocalTotalPhysicalUsageBytes = localTotalPhysicalUsageBytes;
            this.LocalTotalPhysicalUsageBytesTimestampUsec = localTotalPhysicalUsageBytesTimestampUsec;
            this.OutdatedLogicalUsageBytesTimestampUsec = outdatedLogicalUsageBytesTimestampUsec;
            this.StorageConsumedBytes = storageConsumedBytes;
            this.StorageConsumedBytesTimestampUsec = storageConsumedBytesTimestampUsec;
            this.TotalLogicalUsageBytes = totalLogicalUsageBytes;
            this.TotalLogicalUsageBytesTimestampUsec = totalLogicalUsageBytesTimestampUsec;
        }
        
        /// <summary>
        /// Specifies the total data written on cloud tiers, as computed by the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the total data written on cloud tiers, as computed by the Cohesity Cluster.</value>
        [DataMember(Name="cloudDataWrittenBytes", EmitDefaultValue=true)]
        public long? CloudDataWrittenBytes { get; set; }

        /// <summary>
        /// Specifies Timestamp of CloudDataWrittenBytes.
        /// </summary>
        /// <value>Specifies Timestamp of CloudDataWrittenBytes.</value>
        [DataMember(Name="cloudDataWrittenBytesTimestampUsec", EmitDefaultValue=true)]
        public long? CloudDataWrittenBytesTimestampUsec { get; set; }

        /// <summary>
        /// Specifies the total cloud capacity, as computed by the Cohesity Cluster, after the size of the data has been reduced by change-block tracking, compression and deduplication.
        /// </summary>
        /// <value>Specifies the total cloud capacity, as computed by the Cohesity Cluster, after the size of the data has been reduced by change-block tracking, compression and deduplication.</value>
        [DataMember(Name="cloudTotalPhysicalUsageBytes", EmitDefaultValue=true)]
        public long? CloudTotalPhysicalUsageBytes { get; set; }

        /// <summary>
        /// Specifies Timestamp of CloudTotalPhysicalUsageBytes.
        /// </summary>
        /// <value>Specifies Timestamp of CloudTotalPhysicalUsageBytes.</value>
        [DataMember(Name="cloudTotalPhysicalUsageBytesTimestampUsec", EmitDefaultValue=true)]
        public long? CloudTotalPhysicalUsageBytesTimestampUsec { get; set; }

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
        /// Specifies Timestamp of DataInBytesAfterDedup.
        /// </summary>
        /// <value>Specifies Timestamp of DataInBytesAfterDedup.</value>
        [DataMember(Name="dataInBytesAfterDedupTimestampUsec", EmitDefaultValue=true)]
        public long? DataInBytesAfterDedupTimestampUsec { get; set; }

        /// <summary>
        /// Specifies Timestamp of DataInBytes.
        /// </summary>
        /// <value>Specifies Timestamp of DataInBytes.</value>
        [DataMember(Name="dataInBytesTimestampUsec", EmitDefaultValue=true)]
        public long? DataInBytesTimestampUsec { get; set; }

        /// <summary>
        /// Specifies the logical data used by Data Protect on Cohesity cluster.
        /// </summary>
        /// <value>Specifies the logical data used by Data Protect on Cohesity cluster.</value>
        [DataMember(Name="dataProtectLogicalUsageBytes", EmitDefaultValue=true)]
        public long? DataProtectLogicalUsageBytes { get; set; }

        /// <summary>
        /// Specifies Timestamp of DataProtectLogicalUsageBytes.
        /// </summary>
        /// <value>Specifies Timestamp of DataProtectLogicalUsageBytes.</value>
        [DataMember(Name="dataProtectLogicalUsageBytesTimestampUsec", EmitDefaultValue=true)]
        public long? DataProtectLogicalUsageBytesTimestampUsec { get; set; }

        /// <summary>
        /// Specifies the physical data used by Data Protect on Cohesity cluster.
        /// </summary>
        /// <value>Specifies the physical data used by Data Protect on Cohesity cluster.</value>
        [DataMember(Name="dataProtectPhysicalUsageBytes", EmitDefaultValue=true)]
        public long? DataProtectPhysicalUsageBytes { get; set; }

        /// <summary>
        /// Specifies Timestamp of DataProtectPhysicalUsageBytes.
        /// </summary>
        /// <value>Specifies Timestamp of DataProtectPhysicalUsageBytes.</value>
        [DataMember(Name="dataProtectPhysicalUsageBytesTimestampUsec", EmitDefaultValue=true)]
        public long? DataProtectPhysicalUsageBytesTimestampUsec { get; set; }

        /// <summary>
        /// Specifies the total data written on local and cloud tiers, as computed by the Cohesity Cluster, after the size of the data has been reduced by change-block tracking, deduplication and compression. This does not include resiliency impact.
        /// </summary>
        /// <value>Specifies the total data written on local and cloud tiers, as computed by the Cohesity Cluster, after the size of the data has been reduced by change-block tracking, deduplication and compression. This does not include resiliency impact.</value>
        [DataMember(Name="dataWrittenBytes", EmitDefaultValue=true)]
        public long? DataWrittenBytes { get; set; }

        /// <summary>
        /// Specifies Timestamp of DataWrittenBytes.
        /// </summary>
        /// <value>Specifies Timestamp of DataWrittenBytes.</value>
        [DataMember(Name="dataWrittenBytesTimestampUsec", EmitDefaultValue=true)]
        public long? DataWrittenBytesTimestampUsec { get; set; }

        /// <summary>
        /// Specifies the logical data used by File services on Cohesity cluster.
        /// </summary>
        /// <value>Specifies the logical data used by File services on Cohesity cluster.</value>
        [DataMember(Name="fileServicesLogicalUsageBytes", EmitDefaultValue=true)]
        public long? FileServicesLogicalUsageBytes { get; set; }

        /// <summary>
        /// Specifies Timestamp of FileServicesLogicalUsageBytes.
        /// </summary>
        /// <value>Specifies Timestamp of FileServicesLogicalUsageBytes.</value>
        [DataMember(Name="fileServicesLogicalUsageBytesTimestampUsec", EmitDefaultValue=true)]
        public long? FileServicesLogicalUsageBytesTimestampUsec { get; set; }

        /// <summary>
        /// Specifies the physical data used by File services on Cohesity cluster.
        /// </summary>
        /// <value>Specifies the physical data used by File services on Cohesity cluster.</value>
        [DataMember(Name="fileServicesPhysicalUsageBytes", EmitDefaultValue=true)]
        public long? FileServicesPhysicalUsageBytes { get; set; }

        /// <summary>
        /// Specifies Timestamp of FileServicesPhysicalUsageBytes.
        /// </summary>
        /// <value>Specifies Timestamp of FileServicesPhysicalUsageBytes.</value>
        [DataMember(Name="fileServicesPhysicalUsageBytesTimestampUsec", EmitDefaultValue=true)]
        public long? FileServicesPhysicalUsageBytesTimestampUsec { get; set; }

        /// <summary>
        /// Specifies the total data written on local tiers, as computed by the Cohesity Cluster, after the size of the data has been reduced by change-block tracking, deduplication and compression. This does not include resiliency impact.
        /// </summary>
        /// <value>Specifies the total data written on local tiers, as computed by the Cohesity Cluster, after the size of the data has been reduced by change-block tracking, deduplication and compression. This does not include resiliency impact.</value>
        [DataMember(Name="localDataWrittenBytes", EmitDefaultValue=true)]
        public long? LocalDataWrittenBytes { get; set; }

        /// <summary>
        /// Specifies Timestamp of LocalDataWrittenBytes.
        /// </summary>
        /// <value>Specifies Timestamp of LocalDataWrittenBytes.</value>
        [DataMember(Name="localDataWrittenBytesTimestampUsec", EmitDefaultValue=true)]
        public long? LocalDataWrittenBytesTimestampUsec { get; set; }

        /// <summary>
        /// Specifies the size of the data has been replicated to other nodes as per RF or Erasure Coding policy.
        /// </summary>
        /// <value>Specifies the size of the data has been replicated to other nodes as per RF or Erasure Coding policy.</value>
        [DataMember(Name="localTierResiliencyImpactBytes", EmitDefaultValue=true)]
        public long? LocalTierResiliencyImpactBytes { get; set; }

        /// <summary>
        /// Specifies Timestamp of LocalTierResiliencyImpactBytes.
        /// </summary>
        /// <value>Specifies Timestamp of LocalTierResiliencyImpactBytes.</value>
        [DataMember(Name="localTierResiliencyImpactBytesTimestampUsec", EmitDefaultValue=true)]
        public long? LocalTierResiliencyImpactBytesTimestampUsec { get; set; }

        /// <summary>
        /// Specifies the total local capacity, as computed by the Cohesity Cluster, after the size of the data has been reduced by change-block tracking, compression and deduplication.
        /// </summary>
        /// <value>Specifies the total local capacity, as computed by the Cohesity Cluster, after the size of the data has been reduced by change-block tracking, compression and deduplication.</value>
        [DataMember(Name="localTotalPhysicalUsageBytes", EmitDefaultValue=true)]
        public long? LocalTotalPhysicalUsageBytes { get; set; }

        /// <summary>
        /// Specifies Timestamp of LocalTotalPhysicalUsageBytes.
        /// </summary>
        /// <value>Specifies Timestamp of LocalTotalPhysicalUsageBytes.</value>
        [DataMember(Name="localTotalPhysicalUsageBytesTimestampUsec", EmitDefaultValue=true)]
        public long? LocalTotalPhysicalUsageBytesTimestampUsec { get; set; }

        /// <summary>
        /// Specifies Timestamp of OutdatedLogicalUsageBytes.
        /// </summary>
        /// <value>Specifies Timestamp of OutdatedLogicalUsageBytes.</value>
        [DataMember(Name="outdatedLogicalUsageBytesTimestampUsec", EmitDefaultValue=true)]
        public long? OutdatedLogicalUsageBytesTimestampUsec { get; set; }

        /// <summary>
        /// Specifies the total capacity, as computed by the Cohesity Cluster, after the size of the data has been reduced by change-block tracking, compression and deduplication. This includes resiliency impact.
        /// </summary>
        /// <value>Specifies the total capacity, as computed by the Cohesity Cluster, after the size of the data has been reduced by change-block tracking, compression and deduplication. This includes resiliency impact.</value>
        [DataMember(Name="storageConsumedBytes", EmitDefaultValue=true)]
        public long? StorageConsumedBytes { get; set; }

        /// <summary>
        /// Specifies Timestamp of StorageConsumedBytes.
        /// </summary>
        /// <value>Specifies Timestamp of StorageConsumedBytes.</value>
        [DataMember(Name="storageConsumedBytesTimestampUsec", EmitDefaultValue=true)]
        public long? StorageConsumedBytesTimestampUsec { get; set; }

        /// <summary>
        /// Specifies the logical usage as computed by the Cohesity Cluster. The size of the data without reduction by change-block tracking, compression and deduplication.
        /// </summary>
        /// <value>Specifies the logical usage as computed by the Cohesity Cluster. The size of the data without reduction by change-block tracking, compression and deduplication.</value>
        [DataMember(Name="totalLogicalUsageBytes", EmitDefaultValue=true)]
        public long? TotalLogicalUsageBytes { get; set; }

        /// <summary>
        /// Specifies Timestamp of TotalLogicalUsageBytes.
        /// </summary>
        /// <value>Specifies Timestamp of TotalLogicalUsageBytes.</value>
        [DataMember(Name="totalLogicalUsageBytesTimestampUsec", EmitDefaultValue=true)]
        public long? TotalLogicalUsageBytesTimestampUsec { get; set; }

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
                    this.CloudDataWrittenBytes == input.CloudDataWrittenBytes ||
                    (this.CloudDataWrittenBytes != null &&
                    this.CloudDataWrittenBytes.Equals(input.CloudDataWrittenBytes))
                ) && 
                (
                    this.CloudDataWrittenBytesTimestampUsec == input.CloudDataWrittenBytesTimestampUsec ||
                    (this.CloudDataWrittenBytesTimestampUsec != null &&
                    this.CloudDataWrittenBytesTimestampUsec.Equals(input.CloudDataWrittenBytesTimestampUsec))
                ) && 
                (
                    this.CloudTotalPhysicalUsageBytes == input.CloudTotalPhysicalUsageBytes ||
                    (this.CloudTotalPhysicalUsageBytes != null &&
                    this.CloudTotalPhysicalUsageBytes.Equals(input.CloudTotalPhysicalUsageBytes))
                ) && 
                (
                    this.CloudTotalPhysicalUsageBytesTimestampUsec == input.CloudTotalPhysicalUsageBytesTimestampUsec ||
                    (this.CloudTotalPhysicalUsageBytesTimestampUsec != null &&
                    this.CloudTotalPhysicalUsageBytesTimestampUsec.Equals(input.CloudTotalPhysicalUsageBytesTimestampUsec))
                ) && 
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
                    this.DataInBytesAfterDedupTimestampUsec == input.DataInBytesAfterDedupTimestampUsec ||
                    (this.DataInBytesAfterDedupTimestampUsec != null &&
                    this.DataInBytesAfterDedupTimestampUsec.Equals(input.DataInBytesAfterDedupTimestampUsec))
                ) && 
                (
                    this.DataInBytesTimestampUsec == input.DataInBytesTimestampUsec ||
                    (this.DataInBytesTimestampUsec != null &&
                    this.DataInBytesTimestampUsec.Equals(input.DataInBytesTimestampUsec))
                ) && 
                (
                    this.DataProtectLogicalUsageBytes == input.DataProtectLogicalUsageBytes ||
                    (this.DataProtectLogicalUsageBytes != null &&
                    this.DataProtectLogicalUsageBytes.Equals(input.DataProtectLogicalUsageBytes))
                ) && 
                (
                    this.DataProtectLogicalUsageBytesTimestampUsec == input.DataProtectLogicalUsageBytesTimestampUsec ||
                    (this.DataProtectLogicalUsageBytesTimestampUsec != null &&
                    this.DataProtectLogicalUsageBytesTimestampUsec.Equals(input.DataProtectLogicalUsageBytesTimestampUsec))
                ) && 
                (
                    this.DataProtectPhysicalUsageBytes == input.DataProtectPhysicalUsageBytes ||
                    (this.DataProtectPhysicalUsageBytes != null &&
                    this.DataProtectPhysicalUsageBytes.Equals(input.DataProtectPhysicalUsageBytes))
                ) && 
                (
                    this.DataProtectPhysicalUsageBytesTimestampUsec == input.DataProtectPhysicalUsageBytesTimestampUsec ||
                    (this.DataProtectPhysicalUsageBytesTimestampUsec != null &&
                    this.DataProtectPhysicalUsageBytesTimestampUsec.Equals(input.DataProtectPhysicalUsageBytesTimestampUsec))
                ) && 
                (
                    this.DataWrittenBytes == input.DataWrittenBytes ||
                    (this.DataWrittenBytes != null &&
                    this.DataWrittenBytes.Equals(input.DataWrittenBytes))
                ) && 
                (
                    this.DataWrittenBytesTimestampUsec == input.DataWrittenBytesTimestampUsec ||
                    (this.DataWrittenBytesTimestampUsec != null &&
                    this.DataWrittenBytesTimestampUsec.Equals(input.DataWrittenBytesTimestampUsec))
                ) && 
                (
                    this.FileServicesLogicalUsageBytes == input.FileServicesLogicalUsageBytes ||
                    (this.FileServicesLogicalUsageBytes != null &&
                    this.FileServicesLogicalUsageBytes.Equals(input.FileServicesLogicalUsageBytes))
                ) && 
                (
                    this.FileServicesLogicalUsageBytesTimestampUsec == input.FileServicesLogicalUsageBytesTimestampUsec ||
                    (this.FileServicesLogicalUsageBytesTimestampUsec != null &&
                    this.FileServicesLogicalUsageBytesTimestampUsec.Equals(input.FileServicesLogicalUsageBytesTimestampUsec))
                ) && 
                (
                    this.FileServicesPhysicalUsageBytes == input.FileServicesPhysicalUsageBytes ||
                    (this.FileServicesPhysicalUsageBytes != null &&
                    this.FileServicesPhysicalUsageBytes.Equals(input.FileServicesPhysicalUsageBytes))
                ) && 
                (
                    this.FileServicesPhysicalUsageBytesTimestampUsec == input.FileServicesPhysicalUsageBytesTimestampUsec ||
                    (this.FileServicesPhysicalUsageBytesTimestampUsec != null &&
                    this.FileServicesPhysicalUsageBytesTimestampUsec.Equals(input.FileServicesPhysicalUsageBytesTimestampUsec))
                ) && 
                (
                    this.LocalDataWrittenBytes == input.LocalDataWrittenBytes ||
                    (this.LocalDataWrittenBytes != null &&
                    this.LocalDataWrittenBytes.Equals(input.LocalDataWrittenBytes))
                ) && 
                (
                    this.LocalDataWrittenBytesTimestampUsec == input.LocalDataWrittenBytesTimestampUsec ||
                    (this.LocalDataWrittenBytesTimestampUsec != null &&
                    this.LocalDataWrittenBytesTimestampUsec.Equals(input.LocalDataWrittenBytesTimestampUsec))
                ) && 
                (
                    this.LocalTierResiliencyImpactBytes == input.LocalTierResiliencyImpactBytes ||
                    (this.LocalTierResiliencyImpactBytes != null &&
                    this.LocalTierResiliencyImpactBytes.Equals(input.LocalTierResiliencyImpactBytes))
                ) && 
                (
                    this.LocalTierResiliencyImpactBytesTimestampUsec == input.LocalTierResiliencyImpactBytesTimestampUsec ||
                    (this.LocalTierResiliencyImpactBytesTimestampUsec != null &&
                    this.LocalTierResiliencyImpactBytesTimestampUsec.Equals(input.LocalTierResiliencyImpactBytesTimestampUsec))
                ) && 
                (
                    this.LocalTotalPhysicalUsageBytes == input.LocalTotalPhysicalUsageBytes ||
                    (this.LocalTotalPhysicalUsageBytes != null &&
                    this.LocalTotalPhysicalUsageBytes.Equals(input.LocalTotalPhysicalUsageBytes))
                ) && 
                (
                    this.LocalTotalPhysicalUsageBytesTimestampUsec == input.LocalTotalPhysicalUsageBytesTimestampUsec ||
                    (this.LocalTotalPhysicalUsageBytesTimestampUsec != null &&
                    this.LocalTotalPhysicalUsageBytesTimestampUsec.Equals(input.LocalTotalPhysicalUsageBytesTimestampUsec))
                ) && 
                (
                    this.OutdatedLogicalUsageBytesTimestampUsec == input.OutdatedLogicalUsageBytesTimestampUsec ||
                    (this.OutdatedLogicalUsageBytesTimestampUsec != null &&
                    this.OutdatedLogicalUsageBytesTimestampUsec.Equals(input.OutdatedLogicalUsageBytesTimestampUsec))
                ) && 
                (
                    this.StorageConsumedBytes == input.StorageConsumedBytes ||
                    (this.StorageConsumedBytes != null &&
                    this.StorageConsumedBytes.Equals(input.StorageConsumedBytes))
                ) && 
                (
                    this.StorageConsumedBytesTimestampUsec == input.StorageConsumedBytesTimestampUsec ||
                    (this.StorageConsumedBytesTimestampUsec != null &&
                    this.StorageConsumedBytesTimestampUsec.Equals(input.StorageConsumedBytesTimestampUsec))
                ) && 
                (
                    this.TotalLogicalUsageBytes == input.TotalLogicalUsageBytes ||
                    (this.TotalLogicalUsageBytes != null &&
                    this.TotalLogicalUsageBytes.Equals(input.TotalLogicalUsageBytes))
                ) && 
                (
                    this.TotalLogicalUsageBytesTimestampUsec == input.TotalLogicalUsageBytesTimestampUsec ||
                    (this.TotalLogicalUsageBytesTimestampUsec != null &&
                    this.TotalLogicalUsageBytesTimestampUsec.Equals(input.TotalLogicalUsageBytesTimestampUsec))
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
                if (this.CloudDataWrittenBytes != null)
                    hashCode = hashCode * 59 + this.CloudDataWrittenBytes.GetHashCode();
                if (this.CloudDataWrittenBytesTimestampUsec != null)
                    hashCode = hashCode * 59 + this.CloudDataWrittenBytesTimestampUsec.GetHashCode();
                if (this.CloudTotalPhysicalUsageBytes != null)
                    hashCode = hashCode * 59 + this.CloudTotalPhysicalUsageBytes.GetHashCode();
                if (this.CloudTotalPhysicalUsageBytesTimestampUsec != null)
                    hashCode = hashCode * 59 + this.CloudTotalPhysicalUsageBytesTimestampUsec.GetHashCode();
                if (this.DataInBytes != null)
                    hashCode = hashCode * 59 + this.DataInBytes.GetHashCode();
                if (this.DataInBytesAfterDedup != null)
                    hashCode = hashCode * 59 + this.DataInBytesAfterDedup.GetHashCode();
                if (this.DataInBytesAfterDedupTimestampUsec != null)
                    hashCode = hashCode * 59 + this.DataInBytesAfterDedupTimestampUsec.GetHashCode();
                if (this.DataInBytesTimestampUsec != null)
                    hashCode = hashCode * 59 + this.DataInBytesTimestampUsec.GetHashCode();
                if (this.DataProtectLogicalUsageBytes != null)
                    hashCode = hashCode * 59 + this.DataProtectLogicalUsageBytes.GetHashCode();
                if (this.DataProtectLogicalUsageBytesTimestampUsec != null)
                    hashCode = hashCode * 59 + this.DataProtectLogicalUsageBytesTimestampUsec.GetHashCode();
                if (this.DataProtectPhysicalUsageBytes != null)
                    hashCode = hashCode * 59 + this.DataProtectPhysicalUsageBytes.GetHashCode();
                if (this.DataProtectPhysicalUsageBytesTimestampUsec != null)
                    hashCode = hashCode * 59 + this.DataProtectPhysicalUsageBytesTimestampUsec.GetHashCode();
                if (this.DataWrittenBytes != null)
                    hashCode = hashCode * 59 + this.DataWrittenBytes.GetHashCode();
                if (this.DataWrittenBytesTimestampUsec != null)
                    hashCode = hashCode * 59 + this.DataWrittenBytesTimestampUsec.GetHashCode();
                if (this.FileServicesLogicalUsageBytes != null)
                    hashCode = hashCode * 59 + this.FileServicesLogicalUsageBytes.GetHashCode();
                if (this.FileServicesLogicalUsageBytesTimestampUsec != null)
                    hashCode = hashCode * 59 + this.FileServicesLogicalUsageBytesTimestampUsec.GetHashCode();
                if (this.FileServicesPhysicalUsageBytes != null)
                    hashCode = hashCode * 59 + this.FileServicesPhysicalUsageBytes.GetHashCode();
                if (this.FileServicesPhysicalUsageBytesTimestampUsec != null)
                    hashCode = hashCode * 59 + this.FileServicesPhysicalUsageBytesTimestampUsec.GetHashCode();
                if (this.LocalDataWrittenBytes != null)
                    hashCode = hashCode * 59 + this.LocalDataWrittenBytes.GetHashCode();
                if (this.LocalDataWrittenBytesTimestampUsec != null)
                    hashCode = hashCode * 59 + this.LocalDataWrittenBytesTimestampUsec.GetHashCode();
                if (this.LocalTierResiliencyImpactBytes != null)
                    hashCode = hashCode * 59 + this.LocalTierResiliencyImpactBytes.GetHashCode();
                if (this.LocalTierResiliencyImpactBytesTimestampUsec != null)
                    hashCode = hashCode * 59 + this.LocalTierResiliencyImpactBytesTimestampUsec.GetHashCode();
                if (this.LocalTotalPhysicalUsageBytes != null)
                    hashCode = hashCode * 59 + this.LocalTotalPhysicalUsageBytes.GetHashCode();
                if (this.LocalTotalPhysicalUsageBytesTimestampUsec != null)
                    hashCode = hashCode * 59 + this.LocalTotalPhysicalUsageBytesTimestampUsec.GetHashCode();
                if (this.OutdatedLogicalUsageBytesTimestampUsec != null)
                    hashCode = hashCode * 59 + this.OutdatedLogicalUsageBytesTimestampUsec.GetHashCode();
                if (this.StorageConsumedBytes != null)
                    hashCode = hashCode * 59 + this.StorageConsumedBytes.GetHashCode();
                if (this.StorageConsumedBytesTimestampUsec != null)
                    hashCode = hashCode * 59 + this.StorageConsumedBytesTimestampUsec.GetHashCode();
                if (this.TotalLogicalUsageBytes != null)
                    hashCode = hashCode * 59 + this.TotalLogicalUsageBytes.GetHashCode();
                if (this.TotalLogicalUsageBytesTimestampUsec != null)
                    hashCode = hashCode * 59 + this.TotalLogicalUsageBytesTimestampUsec.GetHashCode();
                return hashCode;
            }
        }

    }

}


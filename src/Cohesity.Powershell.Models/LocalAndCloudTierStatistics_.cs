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
    /// Provides usage and performance statistics about the local data stored directly on the Cohesity Cluster and the remote data stored on a Cloud Tier for the Cohesity Cluster.
    /// </summary>
    [DataContract]
    public partial class LocalAndCloudTierStatistics_ :  IEquatable<LocalAndCloudTierStatistics_>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalAndCloudTierStatistics_" /> class.
        /// </summary>
        /// <param name="dataInBytes">Data brought into the cluster. This is the usage before data reduction if we ignore the zeroes and effects of cloning..</param>
        /// <param name="dataInBytesAfterReduction">Morphed Usage before data is replicated to other nodes as per RF or Erasure Coding policy..</param>
        /// <param name="minUsablePhysicalCapacityBytes">Specifies the minimum usable capacity available after erasure coding or RF. This will only be populated for cluster. If a cluster has multiple Domains (View Boxes) with different RF or erasure coding, this metric will be computed using the scheme that will provide least saving..</param>
        /// <param name="numBytesRead">Provides the total number of bytes read in the last 30 seconds..</param>
        /// <param name="numBytesWritten">Provides the total number of bytes written in the last 30 second..</param>
        /// <param name="physicalCapacityBytes">Provides the total physical capacity in bytes as computed by the Cohesity Cluster..</param>
        /// <param name="readIos">Provides the number of Read IOs that occurred in the last 30 seconds..</param>
        /// <param name="readLatencyMsecs">Provides the Read latency in milliseconds for the Read IOs that occurred during the last 30 seconds..</param>
        /// <param name="systemCapacityBytes">Provides the total available capacity as computed by the Linux &#39;statfs&#39; command..</param>
        /// <param name="systemUsageBytes">Provides the usage of bytes, as computed by the Linux &#39;statfs&#39; command, after the size of the data is reduced by change-block tracking, compression and deduplication..</param>
        /// <param name="totalPhysicalRawUsageBytes">Provides the usage of bytes, as computed by the Cohesity Cluster, before the size of the data is reduced by change-block tracking, compression and deduplication..</param>
        /// <param name="totalPhysicalUsageBytes">Provides the total capacity, as computed by the Cohesity Cluster, after the size of the data has been reduced by change-block tracking, compression and deduplication..</param>
        /// <param name="writeIos">Provides the number of Write IOs that occurred in the last 30 seconds..</param>
        /// <param name="writeLatencyMsecs">Provides the Write latency in milliseconds for the Write IOs that occurred during the last 30 seconds..</param>
        public LocalAndCloudTierStatistics_(long? dataInBytes = default(long?), long? dataInBytesAfterReduction = default(long?), long? minUsablePhysicalCapacityBytes = default(long?), long? numBytesRead = default(long?), long? numBytesWritten = default(long?), long? physicalCapacityBytes = default(long?), long? readIos = default(long?), double? readLatencyMsecs = default(double?), long? systemCapacityBytes = default(long?), long? systemUsageBytes = default(long?), long? totalPhysicalRawUsageBytes = default(long?), long? totalPhysicalUsageBytes = default(long?), long? writeIos = default(long?), double? writeLatencyMsecs = default(double?))
        {
            this.DataInBytes = dataInBytes;
            this.DataInBytesAfterReduction = dataInBytesAfterReduction;
            this.MinUsablePhysicalCapacityBytes = minUsablePhysicalCapacityBytes;
            this.NumBytesRead = numBytesRead;
            this.NumBytesWritten = numBytesWritten;
            this.PhysicalCapacityBytes = physicalCapacityBytes;
            this.ReadIos = readIos;
            this.ReadLatencyMsecs = readLatencyMsecs;
            this.SystemCapacityBytes = systemCapacityBytes;
            this.SystemUsageBytes = systemUsageBytes;
            this.TotalPhysicalRawUsageBytes = totalPhysicalRawUsageBytes;
            this.TotalPhysicalUsageBytes = totalPhysicalUsageBytes;
            this.WriteIos = writeIos;
            this.WriteLatencyMsecs = writeLatencyMsecs;
        }
        
        /// <summary>
        /// Data brought into the cluster. This is the usage before data reduction if we ignore the zeroes and effects of cloning.
        /// </summary>
        /// <value>Data brought into the cluster. This is the usage before data reduction if we ignore the zeroes and effects of cloning.</value>
        [DataMember(Name="dataInBytes", EmitDefaultValue=false)]
        public long? DataInBytes { get; set; }

        /// <summary>
        /// Morphed Usage before data is replicated to other nodes as per RF or Erasure Coding policy.
        /// </summary>
        /// <value>Morphed Usage before data is replicated to other nodes as per RF or Erasure Coding policy.</value>
        [DataMember(Name="dataInBytesAfterReduction", EmitDefaultValue=false)]
        public long? DataInBytesAfterReduction { get; set; }

        /// <summary>
        /// Specifies the minimum usable capacity available after erasure coding or RF. This will only be populated for cluster. If a cluster has multiple Domains (View Boxes) with different RF or erasure coding, this metric will be computed using the scheme that will provide least saving.
        /// </summary>
        /// <value>Specifies the minimum usable capacity available after erasure coding or RF. This will only be populated for cluster. If a cluster has multiple Domains (View Boxes) with different RF or erasure coding, this metric will be computed using the scheme that will provide least saving.</value>
        [DataMember(Name="minUsablePhysicalCapacityBytes", EmitDefaultValue=false)]
        public long? MinUsablePhysicalCapacityBytes { get; set; }

        /// <summary>
        /// Provides the total number of bytes read in the last 30 seconds.
        /// </summary>
        /// <value>Provides the total number of bytes read in the last 30 seconds.</value>
        [DataMember(Name="numBytesRead", EmitDefaultValue=false)]
        public long? NumBytesRead { get; set; }

        /// <summary>
        /// Provides the total number of bytes written in the last 30 second.
        /// </summary>
        /// <value>Provides the total number of bytes written in the last 30 second.</value>
        [DataMember(Name="numBytesWritten", EmitDefaultValue=false)]
        public long? NumBytesWritten { get; set; }

        /// <summary>
        /// Provides the total physical capacity in bytes as computed by the Cohesity Cluster.
        /// </summary>
        /// <value>Provides the total physical capacity in bytes as computed by the Cohesity Cluster.</value>
        [DataMember(Name="physicalCapacityBytes", EmitDefaultValue=false)]
        public long? PhysicalCapacityBytes { get; set; }

        /// <summary>
        /// Provides the number of Read IOs that occurred in the last 30 seconds.
        /// </summary>
        /// <value>Provides the number of Read IOs that occurred in the last 30 seconds.</value>
        [DataMember(Name="readIos", EmitDefaultValue=false)]
        public long? ReadIos { get; set; }

        /// <summary>
        /// Provides the Read latency in milliseconds for the Read IOs that occurred during the last 30 seconds.
        /// </summary>
        /// <value>Provides the Read latency in milliseconds for the Read IOs that occurred during the last 30 seconds.</value>
        [DataMember(Name="readLatencyMsecs", EmitDefaultValue=false)]
        public double? ReadLatencyMsecs { get; set; }

        /// <summary>
        /// Provides the total available capacity as computed by the Linux &#39;statfs&#39; command.
        /// </summary>
        /// <value>Provides the total available capacity as computed by the Linux &#39;statfs&#39; command.</value>
        [DataMember(Name="systemCapacityBytes", EmitDefaultValue=false)]
        public long? SystemCapacityBytes { get; set; }

        /// <summary>
        /// Provides the usage of bytes, as computed by the Linux &#39;statfs&#39; command, after the size of the data is reduced by change-block tracking, compression and deduplication.
        /// </summary>
        /// <value>Provides the usage of bytes, as computed by the Linux &#39;statfs&#39; command, after the size of the data is reduced by change-block tracking, compression and deduplication.</value>
        [DataMember(Name="systemUsageBytes", EmitDefaultValue=false)]
        public long? SystemUsageBytes { get; set; }

        /// <summary>
        /// Provides the usage of bytes, as computed by the Cohesity Cluster, before the size of the data is reduced by change-block tracking, compression and deduplication.
        /// </summary>
        /// <value>Provides the usage of bytes, as computed by the Cohesity Cluster, before the size of the data is reduced by change-block tracking, compression and deduplication.</value>
        [DataMember(Name="totalPhysicalRawUsageBytes", EmitDefaultValue=false)]
        public long? TotalPhysicalRawUsageBytes { get; set; }

        /// <summary>
        /// Provides the total capacity, as computed by the Cohesity Cluster, after the size of the data has been reduced by change-block tracking, compression and deduplication.
        /// </summary>
        /// <value>Provides the total capacity, as computed by the Cohesity Cluster, after the size of the data has been reduced by change-block tracking, compression and deduplication.</value>
        [DataMember(Name="totalPhysicalUsageBytes", EmitDefaultValue=false)]
        public long? TotalPhysicalUsageBytes { get; set; }

        /// <summary>
        /// Provides the number of Write IOs that occurred in the last 30 seconds.
        /// </summary>
        /// <value>Provides the number of Write IOs that occurred in the last 30 seconds.</value>
        [DataMember(Name="writeIos", EmitDefaultValue=false)]
        public long? WriteIos { get; set; }

        /// <summary>
        /// Provides the Write latency in milliseconds for the Write IOs that occurred during the last 30 seconds.
        /// </summary>
        /// <value>Provides the Write latency in milliseconds for the Write IOs that occurred during the last 30 seconds.</value>
        [DataMember(Name="writeLatencyMsecs", EmitDefaultValue=false)]
        public double? WriteLatencyMsecs { get; set; }

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
            return this.Equals(input as LocalAndCloudTierStatistics_);
        }

        /// <summary>
        /// Returns true if LocalAndCloudTierStatistics_ instances are equal
        /// </summary>
        /// <param name="input">Instance of LocalAndCloudTierStatistics_ to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocalAndCloudTierStatistics_ input)
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
                    this.DataInBytesAfterReduction == input.DataInBytesAfterReduction ||
                    (this.DataInBytesAfterReduction != null &&
                    this.DataInBytesAfterReduction.Equals(input.DataInBytesAfterReduction))
                ) && 
                (
                    this.MinUsablePhysicalCapacityBytes == input.MinUsablePhysicalCapacityBytes ||
                    (this.MinUsablePhysicalCapacityBytes != null &&
                    this.MinUsablePhysicalCapacityBytes.Equals(input.MinUsablePhysicalCapacityBytes))
                ) && 
                (
                    this.NumBytesRead == input.NumBytesRead ||
                    (this.NumBytesRead != null &&
                    this.NumBytesRead.Equals(input.NumBytesRead))
                ) && 
                (
                    this.NumBytesWritten == input.NumBytesWritten ||
                    (this.NumBytesWritten != null &&
                    this.NumBytesWritten.Equals(input.NumBytesWritten))
                ) && 
                (
                    this.PhysicalCapacityBytes == input.PhysicalCapacityBytes ||
                    (this.PhysicalCapacityBytes != null &&
                    this.PhysicalCapacityBytes.Equals(input.PhysicalCapacityBytes))
                ) && 
                (
                    this.ReadIos == input.ReadIos ||
                    (this.ReadIos != null &&
                    this.ReadIos.Equals(input.ReadIos))
                ) && 
                (
                    this.ReadLatencyMsecs == input.ReadLatencyMsecs ||
                    (this.ReadLatencyMsecs != null &&
                    this.ReadLatencyMsecs.Equals(input.ReadLatencyMsecs))
                ) && 
                (
                    this.SystemCapacityBytes == input.SystemCapacityBytes ||
                    (this.SystemCapacityBytes != null &&
                    this.SystemCapacityBytes.Equals(input.SystemCapacityBytes))
                ) && 
                (
                    this.SystemUsageBytes == input.SystemUsageBytes ||
                    (this.SystemUsageBytes != null &&
                    this.SystemUsageBytes.Equals(input.SystemUsageBytes))
                ) && 
                (
                    this.TotalPhysicalRawUsageBytes == input.TotalPhysicalRawUsageBytes ||
                    (this.TotalPhysicalRawUsageBytes != null &&
                    this.TotalPhysicalRawUsageBytes.Equals(input.TotalPhysicalRawUsageBytes))
                ) && 
                (
                    this.TotalPhysicalUsageBytes == input.TotalPhysicalUsageBytes ||
                    (this.TotalPhysicalUsageBytes != null &&
                    this.TotalPhysicalUsageBytes.Equals(input.TotalPhysicalUsageBytes))
                ) && 
                (
                    this.WriteIos == input.WriteIos ||
                    (this.WriteIos != null &&
                    this.WriteIos.Equals(input.WriteIos))
                ) && 
                (
                    this.WriteLatencyMsecs == input.WriteLatencyMsecs ||
                    (this.WriteLatencyMsecs != null &&
                    this.WriteLatencyMsecs.Equals(input.WriteLatencyMsecs))
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
                if (this.DataInBytesAfterReduction != null)
                    hashCode = hashCode * 59 + this.DataInBytesAfterReduction.GetHashCode();
                if (this.MinUsablePhysicalCapacityBytes != null)
                    hashCode = hashCode * 59 + this.MinUsablePhysicalCapacityBytes.GetHashCode();
                if (this.NumBytesRead != null)
                    hashCode = hashCode * 59 + this.NumBytesRead.GetHashCode();
                if (this.NumBytesWritten != null)
                    hashCode = hashCode * 59 + this.NumBytesWritten.GetHashCode();
                if (this.PhysicalCapacityBytes != null)
                    hashCode = hashCode * 59 + this.PhysicalCapacityBytes.GetHashCode();
                if (this.ReadIos != null)
                    hashCode = hashCode * 59 + this.ReadIos.GetHashCode();
                if (this.ReadLatencyMsecs != null)
                    hashCode = hashCode * 59 + this.ReadLatencyMsecs.GetHashCode();
                if (this.SystemCapacityBytes != null)
                    hashCode = hashCode * 59 + this.SystemCapacityBytes.GetHashCode();
                if (this.SystemUsageBytes != null)
                    hashCode = hashCode * 59 + this.SystemUsageBytes.GetHashCode();
                if (this.TotalPhysicalRawUsageBytes != null)
                    hashCode = hashCode * 59 + this.TotalPhysicalRawUsageBytes.GetHashCode();
                if (this.TotalPhysicalUsageBytes != null)
                    hashCode = hashCode * 59 + this.TotalPhysicalUsageBytes.GetHashCode();
                if (this.WriteIos != null)
                    hashCode = hashCode * 59 + this.WriteIos.GetHashCode();
                if (this.WriteLatencyMsecs != null)
                    hashCode = hashCode * 59 + this.WriteLatencyMsecs.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


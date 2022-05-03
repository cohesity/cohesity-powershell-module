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
    /// StorageEfficiencyTile gives tile information for the storage saved because of compression and dedupe done on the cluster.
    /// </summary>
    [DataContract]
    public partial class StorageEfficiencyTile :  IEquatable<StorageEfficiencyTile>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageEfficiencyTile" /> class.
        /// </summary>
        /// <param name="dataInBytes">Specifies the size of data brought into the cluster. This is the usage before data reduction if we ignore the zeroes and effects of cloning..</param>
        /// <param name="dataInBytesSamples">Specifies the samples taken for Data brought into the cluster in bytes in ascending order of time..</param>
        /// <param name="dataInDedupedBytes">Specifies the size of data after compression and or dedupe operations just before the data is replicated to other nodes as per RF or Erasure Coding policy..</param>
        /// <param name="dataInDedupedBytesSamples">Specifies the samples taken for morphed data in bytes in ascending order of time..</param>
        /// <param name="dedupeRatio">Specifies the current dedupe ratio on the cluster. It is the ratio of DataInBytes to DataInDedupedBytes..</param>
        /// <param name="dedupeRatioSamples">Specifies the samples for data reduction ratio in ascending order of time..</param>
        /// <param name="durationDays">Specifies the duration in days in which the samples were taken. For this tile, it is 7 days..</param>
        /// <param name="intervalSeconds">Specifies the interval between the samples in seconds. For this tile, it is 1 day which is 86400 seconds..</param>
        /// <param name="logicalUsedBytes">Specifies the size of logical data currently represented on the cluster..</param>
        /// <param name="logicalUsedBytesSamples">Specifies the samples taken for logical data represented in bytes in ascending order of time..</param>
        /// <param name="physicalUsedBytes">Specifies the size of physical data currently consumed on the cluster..</param>
        /// <param name="physicalUsedBytesSamples">Specifies the samples taken for physical data consumed in bytes in ascending order of time..</param>
        /// <param name="storageReductionRatio">Specifies the current storage reduction ratio on the cluster. It is the ratio of LogicalUsedBytes to PhysicalUsedBytes..</param>
        /// <param name="storageReductionSamples">Specifies the samples for storage reduction ratio in ascending order of time..</param>
        public StorageEfficiencyTile(long? dataInBytes = default(long?), List<Sample> dataInBytesSamples = default(List<Sample>), long? dataInDedupedBytes = default(long?), List<Sample> dataInDedupedBytesSamples = default(List<Sample>), double? dedupeRatio = default(double?), List<Sample> dedupeRatioSamples = default(List<Sample>), int? durationDays = default(int?), int? intervalSeconds = default(int?), long? logicalUsedBytes = default(long?), List<Sample> logicalUsedBytesSamples = default(List<Sample>), long? physicalUsedBytes = default(long?), List<Sample> physicalUsedBytesSamples = default(List<Sample>), double? storageReductionRatio = default(double?), List<Sample> storageReductionSamples = default(List<Sample>))
        {
            this.DataInBytes = dataInBytes;
            this.DataInBytesSamples = dataInBytesSamples;
            this.DataInDedupedBytes = dataInDedupedBytes;
            this.DataInDedupedBytesSamples = dataInDedupedBytesSamples;
            this.DedupeRatio = dedupeRatio;
            this.DedupeRatioSamples = dedupeRatioSamples;
            this.DurationDays = durationDays;
            this.IntervalSeconds = intervalSeconds;
            this.LogicalUsedBytes = logicalUsedBytes;
            this.LogicalUsedBytesSamples = logicalUsedBytesSamples;
            this.PhysicalUsedBytes = physicalUsedBytes;
            this.PhysicalUsedBytesSamples = physicalUsedBytesSamples;
            this.StorageReductionRatio = storageReductionRatio;
            this.StorageReductionSamples = storageReductionSamples;
        }
        
        /// <summary>
        /// Specifies the size of data brought into the cluster. This is the usage before data reduction if we ignore the zeroes and effects of cloning.
        /// </summary>
        /// <value>Specifies the size of data brought into the cluster. This is the usage before data reduction if we ignore the zeroes and effects of cloning.</value>
        [DataMember(Name="dataInBytes", EmitDefaultValue=false)]
        public long? DataInBytes { get; set; }

        /// <summary>
        /// Specifies the samples taken for Data brought into the cluster in bytes in ascending order of time.
        /// </summary>
        /// <value>Specifies the samples taken for Data brought into the cluster in bytes in ascending order of time.</value>
        [DataMember(Name="dataInBytesSamples", EmitDefaultValue=false)]
        public List<Sample> DataInBytesSamples { get; set; }

        /// <summary>
        /// Specifies the size of data after compression and or dedupe operations just before the data is replicated to other nodes as per RF or Erasure Coding policy.
        /// </summary>
        /// <value>Specifies the size of data after compression and or dedupe operations just before the data is replicated to other nodes as per RF or Erasure Coding policy.</value>
        [DataMember(Name="dataInDedupedBytes", EmitDefaultValue=false)]
        public long? DataInDedupedBytes { get; set; }

        /// <summary>
        /// Specifies the samples taken for morphed data in bytes in ascending order of time.
        /// </summary>
        /// <value>Specifies the samples taken for morphed data in bytes in ascending order of time.</value>
        [DataMember(Name="dataInDedupedBytesSamples", EmitDefaultValue=false)]
        public List<Sample> DataInDedupedBytesSamples { get; set; }

        /// <summary>
        /// Specifies the current dedupe ratio on the cluster. It is the ratio of DataInBytes to DataInDedupedBytes.
        /// </summary>
        /// <value>Specifies the current dedupe ratio on the cluster. It is the ratio of DataInBytes to DataInDedupedBytes.</value>
        [DataMember(Name="dedupeRatio", EmitDefaultValue=false)]
        public double? DedupeRatio { get; set; }

        /// <summary>
        /// Specifies the samples for data reduction ratio in ascending order of time.
        /// </summary>
        /// <value>Specifies the samples for data reduction ratio in ascending order of time.</value>
        [DataMember(Name="dedupeRatioSamples", EmitDefaultValue=false)]
        public List<Sample> DedupeRatioSamples { get; set; }

        /// <summary>
        /// Specifies the duration in days in which the samples were taken. For this tile, it is 7 days.
        /// </summary>
        /// <value>Specifies the duration in days in which the samples were taken. For this tile, it is 7 days.</value>
        [DataMember(Name="durationDays", EmitDefaultValue=false)]
        public int? DurationDays { get; set; }

        /// <summary>
        /// Specifies the interval between the samples in seconds. For this tile, it is 1 day which is 86400 seconds.
        /// </summary>
        /// <value>Specifies the interval between the samples in seconds. For this tile, it is 1 day which is 86400 seconds.</value>
        [DataMember(Name="intervalSeconds", EmitDefaultValue=false)]
        public int? IntervalSeconds { get; set; }

        /// <summary>
        /// Specifies the size of logical data currently represented on the cluster.
        /// </summary>
        /// <value>Specifies the size of logical data currently represented on the cluster.</value>
        [DataMember(Name="logicalUsedBytes", EmitDefaultValue=false)]
        public long? LogicalUsedBytes { get; set; }

        /// <summary>
        /// Specifies the samples taken for logical data represented in bytes in ascending order of time.
        /// </summary>
        /// <value>Specifies the samples taken for logical data represented in bytes in ascending order of time.</value>
        [DataMember(Name="logicalUsedBytesSamples", EmitDefaultValue=false)]
        public List<Sample> LogicalUsedBytesSamples { get; set; }

        /// <summary>
        /// Specifies the size of physical data currently consumed on the cluster.
        /// </summary>
        /// <value>Specifies the size of physical data currently consumed on the cluster.</value>
        [DataMember(Name="physicalUsedBytes", EmitDefaultValue=false)]
        public long? PhysicalUsedBytes { get; set; }

        /// <summary>
        /// Specifies the samples taken for physical data consumed in bytes in ascending order of time.
        /// </summary>
        /// <value>Specifies the samples taken for physical data consumed in bytes in ascending order of time.</value>
        [DataMember(Name="physicalUsedBytesSamples", EmitDefaultValue=false)]
        public List<Sample> PhysicalUsedBytesSamples { get; set; }

        /// <summary>
        /// Specifies the current storage reduction ratio on the cluster. It is the ratio of LogicalUsedBytes to PhysicalUsedBytes.
        /// </summary>
        /// <value>Specifies the current storage reduction ratio on the cluster. It is the ratio of LogicalUsedBytes to PhysicalUsedBytes.</value>
        [DataMember(Name="storageReductionRatio", EmitDefaultValue=false)]
        public double? StorageReductionRatio { get; set; }

        /// <summary>
        /// Specifies the samples for storage reduction ratio in ascending order of time.
        /// </summary>
        /// <value>Specifies the samples for storage reduction ratio in ascending order of time.</value>
        [DataMember(Name="storageReductionSamples", EmitDefaultValue=false)]
        public List<Sample> StorageReductionSamples { get; set; }

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
            return this.Equals(input as StorageEfficiencyTile);
        }

        /// <summary>
        /// Returns true if StorageEfficiencyTile instances are equal
        /// </summary>
        /// <param name="input">Instance of StorageEfficiencyTile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StorageEfficiencyTile input)
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
                    this.DataInBytesSamples == input.DataInBytesSamples ||
                    this.DataInBytesSamples != null &&
                    this.DataInBytesSamples.Equals(input.DataInBytesSamples)
                ) && 
                (
                    this.DataInDedupedBytes == input.DataInDedupedBytes ||
                    (this.DataInDedupedBytes != null &&
                    this.DataInDedupedBytes.Equals(input.DataInDedupedBytes))
                ) && 
                (
                    this.DataInDedupedBytesSamples == input.DataInDedupedBytesSamples ||
                    this.DataInDedupedBytesSamples != null &&
                    this.DataInDedupedBytesSamples.Equals(input.DataInDedupedBytesSamples)
                ) && 
                (
                    this.DedupeRatio == input.DedupeRatio ||
                    (this.DedupeRatio != null &&
                    this.DedupeRatio.Equals(input.DedupeRatio))
                ) && 
                (
                    this.DedupeRatioSamples == input.DedupeRatioSamples ||
                    this.DedupeRatioSamples != null &&
                    this.DedupeRatioSamples.Equals(input.DedupeRatioSamples)
                ) && 
                (
                    this.DurationDays == input.DurationDays ||
                    (this.DurationDays != null &&
                    this.DurationDays.Equals(input.DurationDays))
                ) && 
                (
                    this.IntervalSeconds == input.IntervalSeconds ||
                    (this.IntervalSeconds != null &&
                    this.IntervalSeconds.Equals(input.IntervalSeconds))
                ) && 
                (
                    this.LogicalUsedBytes == input.LogicalUsedBytes ||
                    (this.LogicalUsedBytes != null &&
                    this.LogicalUsedBytes.Equals(input.LogicalUsedBytes))
                ) && 
                (
                    this.LogicalUsedBytesSamples == input.LogicalUsedBytesSamples ||
                    this.LogicalUsedBytesSamples != null &&
                    this.LogicalUsedBytesSamples.Equals(input.LogicalUsedBytesSamples)
                ) && 
                (
                    this.PhysicalUsedBytes == input.PhysicalUsedBytes ||
                    (this.PhysicalUsedBytes != null &&
                    this.PhysicalUsedBytes.Equals(input.PhysicalUsedBytes))
                ) && 
                (
                    this.PhysicalUsedBytesSamples == input.PhysicalUsedBytesSamples ||
                    this.PhysicalUsedBytesSamples != null &&
                    this.PhysicalUsedBytesSamples.Equals(input.PhysicalUsedBytesSamples)
                ) && 
                (
                    this.StorageReductionRatio == input.StorageReductionRatio ||
                    (this.StorageReductionRatio != null &&
                    this.StorageReductionRatio.Equals(input.StorageReductionRatio))
                ) && 
                (
                    this.StorageReductionSamples == input.StorageReductionSamples ||
                    this.StorageReductionSamples != null &&
                    this.StorageReductionSamples.Equals(input.StorageReductionSamples)
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
                if (this.DataInBytesSamples != null)
                    hashCode = hashCode * 59 + this.DataInBytesSamples.GetHashCode();
                if (this.DataInDedupedBytes != null)
                    hashCode = hashCode * 59 + this.DataInDedupedBytes.GetHashCode();
                if (this.DataInDedupedBytesSamples != null)
                    hashCode = hashCode * 59 + this.DataInDedupedBytesSamples.GetHashCode();
                if (this.DedupeRatio != null)
                    hashCode = hashCode * 59 + this.DedupeRatio.GetHashCode();
                if (this.DedupeRatioSamples != null)
                    hashCode = hashCode * 59 + this.DedupeRatioSamples.GetHashCode();
                if (this.DurationDays != null)
                    hashCode = hashCode * 59 + this.DurationDays.GetHashCode();
                if (this.IntervalSeconds != null)
                    hashCode = hashCode * 59 + this.IntervalSeconds.GetHashCode();
                if (this.LogicalUsedBytes != null)
                    hashCode = hashCode * 59 + this.LogicalUsedBytes.GetHashCode();
                if (this.LogicalUsedBytesSamples != null)
                    hashCode = hashCode * 59 + this.LogicalUsedBytesSamples.GetHashCode();
                if (this.PhysicalUsedBytes != null)
                    hashCode = hashCode * 59 + this.PhysicalUsedBytes.GetHashCode();
                if (this.PhysicalUsedBytesSamples != null)
                    hashCode = hashCode * 59 + this.PhysicalUsedBytesSamples.GetHashCode();
                if (this.StorageReductionRatio != null)
                    hashCode = hashCode * 59 + this.StorageReductionRatio.GetHashCode();
                if (this.StorageReductionSamples != null)
                    hashCode = hashCode * 59 + this.StorageReductionSamples.GetHashCode();
                return hashCode;
            }
        }

    }

}


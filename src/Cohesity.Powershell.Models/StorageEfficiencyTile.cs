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
    /// StorageEfficiencyTile
    /// </summary>
    [DataContract]
    public partial class StorageEfficiencyTile :  IEquatable<StorageEfficiencyTile>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageEfficiencyTile" /> class.
        /// </summary>
        /// <param name="dataInBytes">Data brought into the cluster. This is the usage before data reduction if we ignore the zeroes and effects of cloning..</param>
        /// <param name="dataInDedupedBytes">Morphed Usage before data is replicated to other nodes as per RF or Erasure Coding policy..</param>
        /// <param name="dataReduction">Data Reduction is the ratio of DataInBytes to DataInDedupBytes..</param>
        /// <param name="lastWeekDataInBytes">lastWeekDataInBytes.</param>
        /// <param name="lastWeekDataInDedupedBytes">Morphed usage before data is replicated in last 7 days in descening order of time..</param>
        /// <param name="lastWeekDataReduction">lastWeekDataReduction.</param>
        /// <param name="lastWeekLogicalUsedBytes">lastWeekLogicalUsedBytes.</param>
        /// <param name="lastWeekPhysicalUsedBytes">lastWeekPhysicalUsedBytes.</param>
        /// <param name="lastWeekStorageEfficiency">lastWeekStorageEfficiency.</param>
        /// <param name="logicalUsedBytes">Logical Data used on the cluster..</param>
        /// <param name="storageEfficiency">Storage Efficiency is the ratio of LogicalUsedBytes / RawUsedBytes..</param>
        public StorageEfficiencyTile(long? dataInBytes = default(long?), long? dataInDedupedBytes = default(long?), long? dataReduction = default(long?), List<long?> lastWeekDataInBytes = default(List<long?>), List<long?> lastWeekDataInDedupedBytes = default(List<long?>), List<long?> lastWeekDataReduction = default(List<long?>), List<long?> lastWeekLogicalUsedBytes = default(List<long?>), List<long?> lastWeekPhysicalUsedBytes = default(List<long?>), List<long?> lastWeekStorageEfficiency = default(List<long?>), long? logicalUsedBytes = default(long?), long? storageEfficiency = default(long?))
        {
            this.DataInBytes = dataInBytes;
            this.DataInDedupedBytes = dataInDedupedBytes;
            this.DataReduction = dataReduction;
            this.LastWeekDataInBytes = lastWeekDataInBytes;
            this.LastWeekDataInDedupedBytes = lastWeekDataInDedupedBytes;
            this.LastWeekDataReduction = lastWeekDataReduction;
            this.LastWeekLogicalUsedBytes = lastWeekLogicalUsedBytes;
            this.LastWeekPhysicalUsedBytes = lastWeekPhysicalUsedBytes;
            this.LastWeekStorageEfficiency = lastWeekStorageEfficiency;
            this.LogicalUsedBytes = logicalUsedBytes;
            this.StorageEfficiency = storageEfficiency;
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
        [DataMember(Name="dataInDedupedBytes", EmitDefaultValue=false)]
        public long? DataInDedupedBytes { get; set; }

        /// <summary>
        /// Data Reduction is the ratio of DataInBytes to DataInDedupBytes.
        /// </summary>
        /// <value>Data Reduction is the ratio of DataInBytes to DataInDedupBytes.</value>
        [DataMember(Name="dataReduction", EmitDefaultValue=false)]
        public long? DataReduction { get; set; }

        /// <summary>
        /// Gets or Sets LastWeekDataInBytes
        /// </summary>
        [DataMember(Name="lastWeekDataInBytes", EmitDefaultValue=false)]
        public List<long?> LastWeekDataInBytes { get; set; }

        /// <summary>
        /// Morphed usage before data is replicated in last 7 days in descening order of time.
        /// </summary>
        /// <value>Morphed usage before data is replicated in last 7 days in descening order of time.</value>
        [DataMember(Name="lastWeekDataInDedupedBytes", EmitDefaultValue=false)]
        public List<long?> LastWeekDataInDedupedBytes { get; set; }

        /// <summary>
        /// Gets or Sets LastWeekDataReduction
        /// </summary>
        [DataMember(Name="lastWeekDataReduction", EmitDefaultValue=false)]
        public List<long?> LastWeekDataReduction { get; set; }

        /// <summary>
        /// Gets or Sets LastWeekLogicalUsedBytes
        /// </summary>
        [DataMember(Name="lastWeekLogicalUsedBytes", EmitDefaultValue=false)]
        public List<long?> LastWeekLogicalUsedBytes { get; set; }

        /// <summary>
        /// Gets or Sets LastWeekPhysicalUsedBytes
        /// </summary>
        [DataMember(Name="lastWeekPhysicalUsedBytes", EmitDefaultValue=false)]
        public List<long?> LastWeekPhysicalUsedBytes { get; set; }

        /// <summary>
        /// Gets or Sets LastWeekStorageEfficiency
        /// </summary>
        [DataMember(Name="lastWeekStorageEfficiency", EmitDefaultValue=false)]
        public List<long?> LastWeekStorageEfficiency { get; set; }

        /// <summary>
        /// Logical Data used on the cluster.
        /// </summary>
        /// <value>Logical Data used on the cluster.</value>
        [DataMember(Name="logicalUsedBytes", EmitDefaultValue=false)]
        public long? LogicalUsedBytes { get; set; }

        /// <summary>
        /// Storage Efficiency is the ratio of LogicalUsedBytes / RawUsedBytes.
        /// </summary>
        /// <value>Storage Efficiency is the ratio of LogicalUsedBytes / RawUsedBytes.</value>
        [DataMember(Name="storageEfficiency", EmitDefaultValue=false)]
        public long? StorageEfficiency { get; set; }

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
                    this.DataInDedupedBytes == input.DataInDedupedBytes ||
                    (this.DataInDedupedBytes != null &&
                    this.DataInDedupedBytes.Equals(input.DataInDedupedBytes))
                ) && 
                (
                    this.DataReduction == input.DataReduction ||
                    (this.DataReduction != null &&
                    this.DataReduction.Equals(input.DataReduction))
                ) && 
                (
                    this.LastWeekDataInBytes == input.LastWeekDataInBytes ||
                    this.LastWeekDataInBytes != null &&
                    this.LastWeekDataInBytes.SequenceEqual(input.LastWeekDataInBytes)
                ) && 
                (
                    this.LastWeekDataInDedupedBytes == input.LastWeekDataInDedupedBytes ||
                    this.LastWeekDataInDedupedBytes != null &&
                    this.LastWeekDataInDedupedBytes.SequenceEqual(input.LastWeekDataInDedupedBytes)
                ) && 
                (
                    this.LastWeekDataReduction == input.LastWeekDataReduction ||
                    this.LastWeekDataReduction != null &&
                    this.LastWeekDataReduction.SequenceEqual(input.LastWeekDataReduction)
                ) && 
                (
                    this.LastWeekLogicalUsedBytes == input.LastWeekLogicalUsedBytes ||
                    this.LastWeekLogicalUsedBytes != null &&
                    this.LastWeekLogicalUsedBytes.SequenceEqual(input.LastWeekLogicalUsedBytes)
                ) && 
                (
                    this.LastWeekPhysicalUsedBytes == input.LastWeekPhysicalUsedBytes ||
                    this.LastWeekPhysicalUsedBytes != null &&
                    this.LastWeekPhysicalUsedBytes.SequenceEqual(input.LastWeekPhysicalUsedBytes)
                ) && 
                (
                    this.LastWeekStorageEfficiency == input.LastWeekStorageEfficiency ||
                    this.LastWeekStorageEfficiency != null &&
                    this.LastWeekStorageEfficiency.SequenceEqual(input.LastWeekStorageEfficiency)
                ) && 
                (
                    this.LogicalUsedBytes == input.LogicalUsedBytes ||
                    (this.LogicalUsedBytes != null &&
                    this.LogicalUsedBytes.Equals(input.LogicalUsedBytes))
                ) && 
                (
                    this.StorageEfficiency == input.StorageEfficiency ||
                    (this.StorageEfficiency != null &&
                    this.StorageEfficiency.Equals(input.StorageEfficiency))
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
                if (this.DataInDedupedBytes != null)
                    hashCode = hashCode * 59 + this.DataInDedupedBytes.GetHashCode();
                if (this.DataReduction != null)
                    hashCode = hashCode * 59 + this.DataReduction.GetHashCode();
                if (this.LastWeekDataInBytes != null)
                    hashCode = hashCode * 59 + this.LastWeekDataInBytes.GetHashCode();
                if (this.LastWeekDataInDedupedBytes != null)
                    hashCode = hashCode * 59 + this.LastWeekDataInDedupedBytes.GetHashCode();
                if (this.LastWeekDataReduction != null)
                    hashCode = hashCode * 59 + this.LastWeekDataReduction.GetHashCode();
                if (this.LastWeekLogicalUsedBytes != null)
                    hashCode = hashCode * 59 + this.LastWeekLogicalUsedBytes.GetHashCode();
                if (this.LastWeekPhysicalUsedBytes != null)
                    hashCode = hashCode * 59 + this.LastWeekPhysicalUsedBytes.GetHashCode();
                if (this.LastWeekStorageEfficiency != null)
                    hashCode = hashCode * 59 + this.LastWeekStorageEfficiency.GetHashCode();
                if (this.LogicalUsedBytes != null)
                    hashCode = hashCode * 59 + this.LogicalUsedBytes.GetHashCode();
                if (this.StorageEfficiency != null)
                    hashCode = hashCode * 59 + this.StorageEfficiency.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


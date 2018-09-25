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
    /// Specifies summary statistics about the transfer of data from a Vault to this Cohesity Cluster.
    /// </summary>
    [DataContract]
    public partial class DataTransferFromVaultSummary :  IEquatable<DataTransferFromVaultSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataTransferFromVaultSummary" /> class.
        /// </summary>
        /// <param name="dataTransferPerTask">Specifies the transfer of data from this Vault to this Cohesity Cluster for each clone or recover task..</param>
        /// <param name="numLogicalBytesTransferred">Specifies the total number of logical bytes that have been transferred from this Vault (External Target) to this Cohesity Cluster. The logical size is when the data is fully hydrated or expanded..</param>
        /// <param name="numPhysicalBytesTransferred">Specifies the total number of physical bytes that have been transferred from this Vault (External Target) to the Cohesity Cluster..</param>
        /// <param name="numTasks">Specifies the number of recover or clone tasks that have transferred data from this Vault (External Target) to this Cohesity Cluster..</param>
        /// <param name="physicalDataTransferredBytesDuringTimeRange">Specifies the physical data transferred from this Vault to the Cohesity Cluster during the time period specified using the startTimeMsecs and endTimeMsecs parameters. For each day in the time period, an array element is returned, for example if 7 days are specified, 7 array elements are returned..</param>
        /// <param name="vaultName">Specifies the name of the Vault (External Target)..</param>
        public DataTransferFromVaultSummary(List<DataTransferFromVaultPerTask> dataTransferPerTask = default(List<DataTransferFromVaultPerTask>), long? numLogicalBytesTransferred = default(long?), long? numPhysicalBytesTransferred = default(long?), long? numTasks = default(long?), List<long?> physicalDataTransferredBytesDuringTimeRange = default(List<long?>), string vaultName = default(string))
        {
            this.DataTransferPerTask = dataTransferPerTask;
            this.NumLogicalBytesTransferred = numLogicalBytesTransferred;
            this.NumPhysicalBytesTransferred = numPhysicalBytesTransferred;
            this.NumTasks = numTasks;
            this.PhysicalDataTransferredBytesDuringTimeRange = physicalDataTransferredBytesDuringTimeRange;
            this.VaultName = vaultName;
        }
        
        /// <summary>
        /// Specifies the transfer of data from this Vault to this Cohesity Cluster for each clone or recover task.
        /// </summary>
        /// <value>Specifies the transfer of data from this Vault to this Cohesity Cluster for each clone or recover task.</value>
        [DataMember(Name="dataTransferPerTask", EmitDefaultValue=false)]
        public List<DataTransferFromVaultPerTask> DataTransferPerTask { get; set; }

        /// <summary>
        /// Specifies the total number of logical bytes that have been transferred from this Vault (External Target) to this Cohesity Cluster. The logical size is when the data is fully hydrated or expanded.
        /// </summary>
        /// <value>Specifies the total number of logical bytes that have been transferred from this Vault (External Target) to this Cohesity Cluster. The logical size is when the data is fully hydrated or expanded.</value>
        [DataMember(Name="numLogicalBytesTransferred", EmitDefaultValue=false)]
        public long? NumLogicalBytesTransferred { get; set; }

        /// <summary>
        /// Specifies the total number of physical bytes that have been transferred from this Vault (External Target) to the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the total number of physical bytes that have been transferred from this Vault (External Target) to the Cohesity Cluster.</value>
        [DataMember(Name="numPhysicalBytesTransferred", EmitDefaultValue=false)]
        public long? NumPhysicalBytesTransferred { get; set; }

        /// <summary>
        /// Specifies the number of recover or clone tasks that have transferred data from this Vault (External Target) to this Cohesity Cluster.
        /// </summary>
        /// <value>Specifies the number of recover or clone tasks that have transferred data from this Vault (External Target) to this Cohesity Cluster.</value>
        [DataMember(Name="numTasks", EmitDefaultValue=false)]
        public long? NumTasks { get; set; }

        /// <summary>
        /// Specifies the physical data transferred from this Vault to the Cohesity Cluster during the time period specified using the startTimeMsecs and endTimeMsecs parameters. For each day in the time period, an array element is returned, for example if 7 days are specified, 7 array elements are returned.
        /// </summary>
        /// <value>Specifies the physical data transferred from this Vault to the Cohesity Cluster during the time period specified using the startTimeMsecs and endTimeMsecs parameters. For each day in the time period, an array element is returned, for example if 7 days are specified, 7 array elements are returned.</value>
        [DataMember(Name="physicalDataTransferredBytesDuringTimeRange", EmitDefaultValue=false)]
        public List<long?> PhysicalDataTransferredBytesDuringTimeRange { get; set; }

        /// <summary>
        /// Specifies the name of the Vault (External Target).
        /// </summary>
        /// <value>Specifies the name of the Vault (External Target).</value>
        [DataMember(Name="vaultName", EmitDefaultValue=false)]
        public string VaultName { get; set; }

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
            return this.Equals(input as DataTransferFromVaultSummary);
        }

        /// <summary>
        /// Returns true if DataTransferFromVaultSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of DataTransferFromVaultSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataTransferFromVaultSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DataTransferPerTask == input.DataTransferPerTask ||
                    this.DataTransferPerTask != null &&
                    this.DataTransferPerTask.SequenceEqual(input.DataTransferPerTask)
                ) && 
                (
                    this.NumLogicalBytesTransferred == input.NumLogicalBytesTransferred ||
                    (this.NumLogicalBytesTransferred != null &&
                    this.NumLogicalBytesTransferred.Equals(input.NumLogicalBytesTransferred))
                ) && 
                (
                    this.NumPhysicalBytesTransferred == input.NumPhysicalBytesTransferred ||
                    (this.NumPhysicalBytesTransferred != null &&
                    this.NumPhysicalBytesTransferred.Equals(input.NumPhysicalBytesTransferred))
                ) && 
                (
                    this.NumTasks == input.NumTasks ||
                    (this.NumTasks != null &&
                    this.NumTasks.Equals(input.NumTasks))
                ) && 
                (
                    this.PhysicalDataTransferredBytesDuringTimeRange == input.PhysicalDataTransferredBytesDuringTimeRange ||
                    this.PhysicalDataTransferredBytesDuringTimeRange != null &&
                    this.PhysicalDataTransferredBytesDuringTimeRange.SequenceEqual(input.PhysicalDataTransferredBytesDuringTimeRange)
                ) && 
                (
                    this.VaultName == input.VaultName ||
                    (this.VaultName != null &&
                    this.VaultName.Equals(input.VaultName))
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
                if (this.DataTransferPerTask != null)
                    hashCode = hashCode * 59 + this.DataTransferPerTask.GetHashCode();
                if (this.NumLogicalBytesTransferred != null)
                    hashCode = hashCode * 59 + this.NumLogicalBytesTransferred.GetHashCode();
                if (this.NumPhysicalBytesTransferred != null)
                    hashCode = hashCode * 59 + this.NumPhysicalBytesTransferred.GetHashCode();
                if (this.NumTasks != null)
                    hashCode = hashCode * 59 + this.NumTasks.GetHashCode();
                if (this.PhysicalDataTransferredBytesDuringTimeRange != null)
                    hashCode = hashCode * 59 + this.PhysicalDataTransferredBytesDuringTimeRange.GetHashCode();
                if (this.VaultName != null)
                    hashCode = hashCode * 59 + this.VaultName.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


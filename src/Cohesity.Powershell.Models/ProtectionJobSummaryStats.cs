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
    /// Specifies statistics about a Protection Job.
    /// </summary>
    [DataContract]
    public partial class ProtectionJobSummaryStats :  IEquatable<ProtectionJobSummaryStats>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionJobSummaryStats" /> class.
        /// </summary>
        /// <param name="averageRunTimeUsecs">Specifies the average run time of all successful Protection Runs. It is specified as a Unix epoch Timestamp (in microseconds)..</param>
        /// <param name="fastestRunTimeUsecs">Specifies the time taken for a fastest successful Protection Run so far. It is specified as a Unix epoch Timestamp (in microseconds)..</param>
        /// <param name="numCanceledRuns">Specifies the number of runs that were cancelled..</param>
        /// <param name="numFailedRuns">Specifies the number of runs that failed to finish..</param>
        /// <param name="numSlaViolations">Specifies the number of runs having SLA violations..</param>
        /// <param name="numSuccessfulRuns">Specifies the number of runs that finished successfully..</param>
        /// <param name="slowestRunTimeUsecs">Specifies the time taken for a slowest successful Protection Run so far. It is specified as a Unix epoch Timestamp (in microseconds)..</param>
        /// <param name="totalBytesReadFromSource">Specifies the total amount of data read from the source (so far)..</param>
        /// <param name="totalLogicalBackupSizeBytes">Specifies the size of the source object (such as a VM) protected by this task on the primary storage after the snapshot is taken. The logical size of the data on the source if the data is fully hydrated or expanded and not reduced by change-block tracking, compression and deduplication..</param>
        /// <param name="totalPhysicalBackupSizeBytes">Specifies the total amount of physical space used on the Cohesity Cluster to store the protected object after being reduced by change-block tracking, compression and deduplication. For example, if the logical backup size is 1GB, but only 1MB was used on the Cohesity Cluster to store it, this field be equal to 1MB..</param>
        public ProtectionJobSummaryStats(long? averageRunTimeUsecs = default(long?), long? fastestRunTimeUsecs = default(long?), long? numCanceledRuns = default(long?), long? numFailedRuns = default(long?), long? numSlaViolations = default(long?), long? numSuccessfulRuns = default(long?), long? slowestRunTimeUsecs = default(long?), long? totalBytesReadFromSource = default(long?), long? totalLogicalBackupSizeBytes = default(long?), long? totalPhysicalBackupSizeBytes = default(long?))
        {
            this.AverageRunTimeUsecs = averageRunTimeUsecs;
            this.FastestRunTimeUsecs = fastestRunTimeUsecs;
            this.NumCanceledRuns = numCanceledRuns;
            this.NumFailedRuns = numFailedRuns;
            this.NumSlaViolations = numSlaViolations;
            this.NumSuccessfulRuns = numSuccessfulRuns;
            this.SlowestRunTimeUsecs = slowestRunTimeUsecs;
            this.TotalBytesReadFromSource = totalBytesReadFromSource;
            this.TotalLogicalBackupSizeBytes = totalLogicalBackupSizeBytes;
            this.TotalPhysicalBackupSizeBytes = totalPhysicalBackupSizeBytes;
            this.AverageRunTimeUsecs = averageRunTimeUsecs;
            this.FastestRunTimeUsecs = fastestRunTimeUsecs;
            this.NumCanceledRuns = numCanceledRuns;
            this.NumFailedRuns = numFailedRuns;
            this.NumSlaViolations = numSlaViolations;
            this.NumSuccessfulRuns = numSuccessfulRuns;
            this.SlowestRunTimeUsecs = slowestRunTimeUsecs;
            this.TotalBytesReadFromSource = totalBytesReadFromSource;
            this.TotalLogicalBackupSizeBytes = totalLogicalBackupSizeBytes;
            this.TotalPhysicalBackupSizeBytes = totalPhysicalBackupSizeBytes;
        }
        
        /// <summary>
        /// Specifies the average run time of all successful Protection Runs. It is specified as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the average run time of all successful Protection Runs. It is specified as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="averageRunTimeUsecs", EmitDefaultValue=true)]
        public long? AverageRunTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the time taken for a fastest successful Protection Run so far. It is specified as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the time taken for a fastest successful Protection Run so far. It is specified as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="fastestRunTimeUsecs", EmitDefaultValue=true)]
        public long? FastestRunTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the number of runs that were cancelled.
        /// </summary>
        /// <value>Specifies the number of runs that were cancelled.</value>
        [DataMember(Name="numCanceledRuns", EmitDefaultValue=true)]
        public long? NumCanceledRuns { get; set; }

        /// <summary>
        /// Specifies the number of runs that failed to finish.
        /// </summary>
        /// <value>Specifies the number of runs that failed to finish.</value>
        [DataMember(Name="numFailedRuns", EmitDefaultValue=true)]
        public long? NumFailedRuns { get; set; }

        /// <summary>
        /// Specifies the number of runs having SLA violations.
        /// </summary>
        /// <value>Specifies the number of runs having SLA violations.</value>
        [DataMember(Name="numSlaViolations", EmitDefaultValue=true)]
        public long? NumSlaViolations { get; set; }

        /// <summary>
        /// Specifies the number of runs that finished successfully.
        /// </summary>
        /// <value>Specifies the number of runs that finished successfully.</value>
        [DataMember(Name="numSuccessfulRuns", EmitDefaultValue=true)]
        public long? NumSuccessfulRuns { get; set; }

        /// <summary>
        /// Specifies the time taken for a slowest successful Protection Run so far. It is specified as a Unix epoch Timestamp (in microseconds).
        /// </summary>
        /// <value>Specifies the time taken for a slowest successful Protection Run so far. It is specified as a Unix epoch Timestamp (in microseconds).</value>
        [DataMember(Name="slowestRunTimeUsecs", EmitDefaultValue=true)]
        public long? SlowestRunTimeUsecs { get; set; }

        /// <summary>
        /// Specifies the total amount of data read from the source (so far).
        /// </summary>
        /// <value>Specifies the total amount of data read from the source (so far).</value>
        [DataMember(Name="totalBytesReadFromSource", EmitDefaultValue=true)]
        public long? TotalBytesReadFromSource { get; set; }

        /// <summary>
        /// Specifies the size of the source object (such as a VM) protected by this task on the primary storage after the snapshot is taken. The logical size of the data on the source if the data is fully hydrated or expanded and not reduced by change-block tracking, compression and deduplication.
        /// </summary>
        /// <value>Specifies the size of the source object (such as a VM) protected by this task on the primary storage after the snapshot is taken. The logical size of the data on the source if the data is fully hydrated or expanded and not reduced by change-block tracking, compression and deduplication.</value>
        [DataMember(Name="totalLogicalBackupSizeBytes", EmitDefaultValue=true)]
        public long? TotalLogicalBackupSizeBytes { get; set; }

        /// <summary>
        /// Specifies the total amount of physical space used on the Cohesity Cluster to store the protected object after being reduced by change-block tracking, compression and deduplication. For example, if the logical backup size is 1GB, but only 1MB was used on the Cohesity Cluster to store it, this field be equal to 1MB.
        /// </summary>
        /// <value>Specifies the total amount of physical space used on the Cohesity Cluster to store the protected object after being reduced by change-block tracking, compression and deduplication. For example, if the logical backup size is 1GB, but only 1MB was used on the Cohesity Cluster to store it, this field be equal to 1MB.</value>
        [DataMember(Name="totalPhysicalBackupSizeBytes", EmitDefaultValue=true)]
        public long? TotalPhysicalBackupSizeBytes { get; set; }

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
            return this.Equals(input as ProtectionJobSummaryStats);
        }

        /// <summary>
        /// Returns true if ProtectionJobSummaryStats instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectionJobSummaryStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectionJobSummaryStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AverageRunTimeUsecs == input.AverageRunTimeUsecs ||
                    (this.AverageRunTimeUsecs != null &&
                    this.AverageRunTimeUsecs.Equals(input.AverageRunTimeUsecs))
                ) && 
                (
                    this.FastestRunTimeUsecs == input.FastestRunTimeUsecs ||
                    (this.FastestRunTimeUsecs != null &&
                    this.FastestRunTimeUsecs.Equals(input.FastestRunTimeUsecs))
                ) && 
                (
                    this.NumCanceledRuns == input.NumCanceledRuns ||
                    (this.NumCanceledRuns != null &&
                    this.NumCanceledRuns.Equals(input.NumCanceledRuns))
                ) && 
                (
                    this.NumFailedRuns == input.NumFailedRuns ||
                    (this.NumFailedRuns != null &&
                    this.NumFailedRuns.Equals(input.NumFailedRuns))
                ) && 
                (
                    this.NumSlaViolations == input.NumSlaViolations ||
                    (this.NumSlaViolations != null &&
                    this.NumSlaViolations.Equals(input.NumSlaViolations))
                ) && 
                (
                    this.NumSuccessfulRuns == input.NumSuccessfulRuns ||
                    (this.NumSuccessfulRuns != null &&
                    this.NumSuccessfulRuns.Equals(input.NumSuccessfulRuns))
                ) && 
                (
                    this.SlowestRunTimeUsecs == input.SlowestRunTimeUsecs ||
                    (this.SlowestRunTimeUsecs != null &&
                    this.SlowestRunTimeUsecs.Equals(input.SlowestRunTimeUsecs))
                ) && 
                (
                    this.TotalBytesReadFromSource == input.TotalBytesReadFromSource ||
                    (this.TotalBytesReadFromSource != null &&
                    this.TotalBytesReadFromSource.Equals(input.TotalBytesReadFromSource))
                ) && 
                (
                    this.TotalLogicalBackupSizeBytes == input.TotalLogicalBackupSizeBytes ||
                    (this.TotalLogicalBackupSizeBytes != null &&
                    this.TotalLogicalBackupSizeBytes.Equals(input.TotalLogicalBackupSizeBytes))
                ) && 
                (
                    this.TotalPhysicalBackupSizeBytes == input.TotalPhysicalBackupSizeBytes ||
                    (this.TotalPhysicalBackupSizeBytes != null &&
                    this.TotalPhysicalBackupSizeBytes.Equals(input.TotalPhysicalBackupSizeBytes))
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
                if (this.AverageRunTimeUsecs != null)
                    hashCode = hashCode * 59 + this.AverageRunTimeUsecs.GetHashCode();
                if (this.FastestRunTimeUsecs != null)
                    hashCode = hashCode * 59 + this.FastestRunTimeUsecs.GetHashCode();
                if (this.NumCanceledRuns != null)
                    hashCode = hashCode * 59 + this.NumCanceledRuns.GetHashCode();
                if (this.NumFailedRuns != null)
                    hashCode = hashCode * 59 + this.NumFailedRuns.GetHashCode();
                if (this.NumSlaViolations != null)
                    hashCode = hashCode * 59 + this.NumSlaViolations.GetHashCode();
                if (this.NumSuccessfulRuns != null)
                    hashCode = hashCode * 59 + this.NumSuccessfulRuns.GetHashCode();
                if (this.SlowestRunTimeUsecs != null)
                    hashCode = hashCode * 59 + this.SlowestRunTimeUsecs.GetHashCode();
                if (this.TotalBytesReadFromSource != null)
                    hashCode = hashCode * 59 + this.TotalBytesReadFromSource.GetHashCode();
                if (this.TotalLogicalBackupSizeBytes != null)
                    hashCode = hashCode * 59 + this.TotalLogicalBackupSizeBytes.GetHashCode();
                if (this.TotalPhysicalBackupSizeBytes != null)
                    hashCode = hashCode * 59 + this.TotalPhysicalBackupSizeBytes.GetHashCode();
                return hashCode;
            }
        }

    }

}


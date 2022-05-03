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
    /// LastProtectionRunsSummary is the summary of the last Protection Run for the Protection Jobs using the Specified Protection Policy.
    /// </summary>
    [DataContract]
    public partial class LastProtectionRunSummary :  IEquatable<LastProtectionRunSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LastProtectionRunSummary" /> class.
        /// </summary>
        /// <param name="numberOfCancelledProtectionRuns">Specifies the number of cancelled Protection Runs the given Protection Policy has in the Last Run..</param>
        /// <param name="numberOfFailedProtectionRuns">Specifies the number of failed Protection Runs the given Protection Policy has in the Last Run..</param>
        /// <param name="numberOfProtectedSources">Specifies the number of Protection Sources protected by the given Protection Policy..</param>
        /// <param name="numberOfRunningProtectionRuns">Specifies the number of running Protection Runs using the current Protection Policy..</param>
        /// <param name="numberOfSlaViolations">Specifies the number of SLA violations the given Protection Policy has in the Last Run...</param>
        /// <param name="numberOfSuccessfulProtectionRuns">Specifies the number of successful Protection Runs the given Protection Policy has in the Last Run..</param>
        /// <param name="totalLogicalBackupSizeInBytes">Specifies the aggregated total logical backup performed in all the Latest Protection Runs made for all the Protection Jobs which have the given Protection Policy Specified..</param>
        public LastProtectionRunSummary(long? numberOfCancelledProtectionRuns = default(long?), long? numberOfFailedProtectionRuns = default(long?), long? numberOfProtectedSources = default(long?), long? numberOfRunningProtectionRuns = default(long?), long? numberOfSlaViolations = default(long?), long? numberOfSuccessfulProtectionRuns = default(long?), long? totalLogicalBackupSizeInBytes = default(long?))
        {
            this.NumberOfCancelledProtectionRuns = numberOfCancelledProtectionRuns;
            this.NumberOfFailedProtectionRuns = numberOfFailedProtectionRuns;
            this.NumberOfProtectedSources = numberOfProtectedSources;
            this.NumberOfRunningProtectionRuns = numberOfRunningProtectionRuns;
            this.NumberOfSlaViolations = numberOfSlaViolations;
            this.NumberOfSuccessfulProtectionRuns = numberOfSuccessfulProtectionRuns;
            this.TotalLogicalBackupSizeInBytes = totalLogicalBackupSizeInBytes;
        }
        
        /// <summary>
        /// Specifies the number of cancelled Protection Runs the given Protection Policy has in the Last Run.
        /// </summary>
        /// <value>Specifies the number of cancelled Protection Runs the given Protection Policy has in the Last Run.</value>
        [DataMember(Name="numberOfCancelledProtectionRuns", EmitDefaultValue=false)]
        public long? NumberOfCancelledProtectionRuns { get; set; }

        /// <summary>
        /// Specifies the number of failed Protection Runs the given Protection Policy has in the Last Run.
        /// </summary>
        /// <value>Specifies the number of failed Protection Runs the given Protection Policy has in the Last Run.</value>
        [DataMember(Name="numberOfFailedProtectionRuns", EmitDefaultValue=false)]
        public long? NumberOfFailedProtectionRuns { get; set; }

        /// <summary>
        /// Specifies the number of Protection Sources protected by the given Protection Policy.
        /// </summary>
        /// <value>Specifies the number of Protection Sources protected by the given Protection Policy.</value>
        [DataMember(Name="numberOfProtectedSources", EmitDefaultValue=false)]
        public long? NumberOfProtectedSources { get; set; }

        /// <summary>
        /// Specifies the number of running Protection Runs using the current Protection Policy.
        /// </summary>
        /// <value>Specifies the number of running Protection Runs using the current Protection Policy.</value>
        [DataMember(Name="numberOfRunningProtectionRuns", EmitDefaultValue=false)]
        public long? NumberOfRunningProtectionRuns { get; set; }

        /// <summary>
        /// Specifies the number of SLA violations the given Protection Policy has in the Last Run..
        /// </summary>
        /// <value>Specifies the number of SLA violations the given Protection Policy has in the Last Run..</value>
        [DataMember(Name="numberOfSlaViolations", EmitDefaultValue=false)]
        public long? NumberOfSlaViolations { get; set; }

        /// <summary>
        /// Specifies the number of successful Protection Runs the given Protection Policy has in the Last Run.
        /// </summary>
        /// <value>Specifies the number of successful Protection Runs the given Protection Policy has in the Last Run.</value>
        [DataMember(Name="numberOfSuccessfulProtectionRuns", EmitDefaultValue=false)]
        public long? NumberOfSuccessfulProtectionRuns { get; set; }

        /// <summary>
        /// Specifies the aggregated total logical backup performed in all the Latest Protection Runs made for all the Protection Jobs which have the given Protection Policy Specified.
        /// </summary>
        /// <value>Specifies the aggregated total logical backup performed in all the Latest Protection Runs made for all the Protection Jobs which have the given Protection Policy Specified.</value>
        [DataMember(Name="totalLogicalBackupSizeInBytes", EmitDefaultValue=false)]
        public long? TotalLogicalBackupSizeInBytes { get; set; }

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
            return this.Equals(input as LastProtectionRunSummary);
        }

        /// <summary>
        /// Returns true if LastProtectionRunSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of LastProtectionRunSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LastProtectionRunSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NumberOfCancelledProtectionRuns == input.NumberOfCancelledProtectionRuns ||
                    (this.NumberOfCancelledProtectionRuns != null &&
                    this.NumberOfCancelledProtectionRuns.Equals(input.NumberOfCancelledProtectionRuns))
                ) && 
                (
                    this.NumberOfFailedProtectionRuns == input.NumberOfFailedProtectionRuns ||
                    (this.NumberOfFailedProtectionRuns != null &&
                    this.NumberOfFailedProtectionRuns.Equals(input.NumberOfFailedProtectionRuns))
                ) && 
                (
                    this.NumberOfProtectedSources == input.NumberOfProtectedSources ||
                    (this.NumberOfProtectedSources != null &&
                    this.NumberOfProtectedSources.Equals(input.NumberOfProtectedSources))
                ) && 
                (
                    this.NumberOfRunningProtectionRuns == input.NumberOfRunningProtectionRuns ||
                    (this.NumberOfRunningProtectionRuns != null &&
                    this.NumberOfRunningProtectionRuns.Equals(input.NumberOfRunningProtectionRuns))
                ) && 
                (
                    this.NumberOfSlaViolations == input.NumberOfSlaViolations ||
                    (this.NumberOfSlaViolations != null &&
                    this.NumberOfSlaViolations.Equals(input.NumberOfSlaViolations))
                ) && 
                (
                    this.NumberOfSuccessfulProtectionRuns == input.NumberOfSuccessfulProtectionRuns ||
                    (this.NumberOfSuccessfulProtectionRuns != null &&
                    this.NumberOfSuccessfulProtectionRuns.Equals(input.NumberOfSuccessfulProtectionRuns))
                ) && 
                (
                    this.TotalLogicalBackupSizeInBytes == input.TotalLogicalBackupSizeInBytes ||
                    (this.TotalLogicalBackupSizeInBytes != null &&
                    this.TotalLogicalBackupSizeInBytes.Equals(input.TotalLogicalBackupSizeInBytes))
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
                if (this.NumberOfCancelledProtectionRuns != null)
                    hashCode = hashCode * 59 + this.NumberOfCancelledProtectionRuns.GetHashCode();
                if (this.NumberOfFailedProtectionRuns != null)
                    hashCode = hashCode * 59 + this.NumberOfFailedProtectionRuns.GetHashCode();
                if (this.NumberOfProtectedSources != null)
                    hashCode = hashCode * 59 + this.NumberOfProtectedSources.GetHashCode();
                if (this.NumberOfRunningProtectionRuns != null)
                    hashCode = hashCode * 59 + this.NumberOfRunningProtectionRuns.GetHashCode();
                if (this.NumberOfSlaViolations != null)
                    hashCode = hashCode * 59 + this.NumberOfSlaViolations.GetHashCode();
                if (this.NumberOfSuccessfulProtectionRuns != null)
                    hashCode = hashCode * 59 + this.NumberOfSuccessfulProtectionRuns.GetHashCode();
                if (this.TotalLogicalBackupSizeInBytes != null)
                    hashCode = hashCode * 59 + this.TotalLogicalBackupSizeInBytes.GetHashCode();
                return hashCode;
            }
        }

    }

}


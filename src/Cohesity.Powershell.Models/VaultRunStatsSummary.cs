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
    /// Specifies the stats by run type for each vault run.
    /// </summary>
    [DataContract]
    public partial class VaultRunStatsSummary :  IEquatable<VaultRunStatsSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VaultRunStatsSummary" /> class.
        /// </summary>
        /// <param name="failureTimeSeries">Specifies the time series for the failed runs that ended in the given time frame..</param>
        /// <param name="numFailedRuns">Specifies the number of runs that ended in failure during the given time frame..</param>
        /// <param name="numInProgressRuns">Specifies the number of runs that were currently in progress at the time that the API call was made..</param>
        /// <param name="numQueuedRuns">Specifies the number of runs that were currently queued at the time that the API call was made..</param>
        /// <param name="numSuccessfulRuns">Specifies the number of runs that ended in success during the given time frame..</param>
        /// <param name="successTimeSeries">Specifies the time series for the successful runs that ended in the given time frame..</param>
        public VaultRunStatsSummary(List<VaultRunInfo> failureTimeSeries = default(List<VaultRunInfo>), long? numFailedRuns = default(long?), long? numInProgressRuns = default(long?), long? numQueuedRuns = default(long?), long? numSuccessfulRuns = default(long?), List<VaultRunInfo> successTimeSeries = default(List<VaultRunInfo>))
        {
            this.NumFailedRuns = numFailedRuns;
            this.NumInProgressRuns = numInProgressRuns;
            this.NumQueuedRuns = numQueuedRuns;
            this.NumSuccessfulRuns = numSuccessfulRuns;
            this.FailureTimeSeries = failureTimeSeries;
            this.NumFailedRuns = numFailedRuns;
            this.NumInProgressRuns = numInProgressRuns;
            this.NumQueuedRuns = numQueuedRuns;
            this.NumSuccessfulRuns = numSuccessfulRuns;
            this.SuccessTimeSeries = successTimeSeries;
        }
        
        /// <summary>
        /// Specifies the time series for the failed runs that ended in the given time frame.
        /// </summary>
        /// <value>Specifies the time series for the failed runs that ended in the given time frame.</value>
        [DataMember(Name="failureTimeSeries", EmitDefaultValue=false)]
        public List<VaultRunInfo> FailureTimeSeries { get; set; }

        /// <summary>
        /// Specifies the number of runs that ended in failure during the given time frame.
        /// </summary>
        /// <value>Specifies the number of runs that ended in failure during the given time frame.</value>
        [DataMember(Name="numFailedRuns", EmitDefaultValue=true)]
        public long? NumFailedRuns { get; set; }

        /// <summary>
        /// Specifies the number of runs that were currently in progress at the time that the API call was made.
        /// </summary>
        /// <value>Specifies the number of runs that were currently in progress at the time that the API call was made.</value>
        [DataMember(Name="numInProgressRuns", EmitDefaultValue=true)]
        public long? NumInProgressRuns { get; set; }

        /// <summary>
        /// Specifies the number of runs that were currently queued at the time that the API call was made.
        /// </summary>
        /// <value>Specifies the number of runs that were currently queued at the time that the API call was made.</value>
        [DataMember(Name="numQueuedRuns", EmitDefaultValue=true)]
        public long? NumQueuedRuns { get; set; }

        /// <summary>
        /// Specifies the number of runs that ended in success during the given time frame.
        /// </summary>
        /// <value>Specifies the number of runs that ended in success during the given time frame.</value>
        [DataMember(Name="numSuccessfulRuns", EmitDefaultValue=true)]
        public long? NumSuccessfulRuns { get; set; }

        /// <summary>
        /// Specifies the time series for the successful runs that ended in the given time frame.
        /// </summary>
        /// <value>Specifies the time series for the successful runs that ended in the given time frame.</value>
        [DataMember(Name="successTimeSeries", EmitDefaultValue=false)]
        public List<VaultRunInfo> SuccessTimeSeries { get; set; }

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
            return this.Equals(input as VaultRunStatsSummary);
        }

        /// <summary>
        /// Returns true if VaultRunStatsSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of VaultRunStatsSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VaultRunStatsSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FailureTimeSeries == input.FailureTimeSeries ||
                    this.FailureTimeSeries != null &&
                    input.FailureTimeSeries != null &&
                    this.FailureTimeSeries.Equals(input.FailureTimeSeries)
                ) && 
                (
                    this.NumFailedRuns == input.NumFailedRuns ||
                    (this.NumFailedRuns != null &&
                    this.NumFailedRuns.Equals(input.NumFailedRuns))
                ) && 
                (
                    this.NumInProgressRuns == input.NumInProgressRuns ||
                    (this.NumInProgressRuns != null &&
                    this.NumInProgressRuns.Equals(input.NumInProgressRuns))
                ) && 
                (
                    this.NumQueuedRuns == input.NumQueuedRuns ||
                    (this.NumQueuedRuns != null &&
                    this.NumQueuedRuns.Equals(input.NumQueuedRuns))
                ) && 
                (
                    this.NumSuccessfulRuns == input.NumSuccessfulRuns ||
                    (this.NumSuccessfulRuns != null &&
                    this.NumSuccessfulRuns.Equals(input.NumSuccessfulRuns))
                ) && 
                (
                    this.SuccessTimeSeries == input.SuccessTimeSeries ||
                    this.SuccessTimeSeries != null &&
                    input.SuccessTimeSeries != null &&
                    this.SuccessTimeSeries.Equals(input.SuccessTimeSeries)
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
                if (this.FailureTimeSeries != null)
                    hashCode = hashCode * 59 + this.FailureTimeSeries.GetHashCode();
                if (this.NumFailedRuns != null)
                    hashCode = hashCode * 59 + this.NumFailedRuns.GetHashCode();
                if (this.NumInProgressRuns != null)
                    hashCode = hashCode * 59 + this.NumInProgressRuns.GetHashCode();
                if (this.NumQueuedRuns != null)
                    hashCode = hashCode * 59 + this.NumQueuedRuns.GetHashCode();
                if (this.NumSuccessfulRuns != null)
                    hashCode = hashCode * 59 + this.NumSuccessfulRuns.GetHashCode();
                if (this.SuccessTimeSeries != null)
                    hashCode = hashCode * 59 + this.SuccessTimeSeries.GetHashCode();
                return hashCode;
            }
        }

    }

}


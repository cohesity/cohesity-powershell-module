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
    /// JobRunsTile
    /// </summary>
    [DataContract]
    public partial class JobRunsTile :  IEquatable<JobRunsTile>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobRunsTile" /> class.
        /// </summary>
        /// <param name="objectsProtectedByPolicy">objectsProtectedByPolicy.</param>
        /// <param name="lastDayNumJobErrors">Number of Error runs in the last 24 hours..</param>
        /// <param name="lastDayNumJobRuns">Number of Job Runs in the last 24 hours..</param>
        /// <param name="lastDayNumJobSlaViolations">Number of SLA Violations in the last 24 hours..</param>
        /// <param name="numJobRunning">Number of Jobs currently running..</param>
        public JobRunsTile(List<ObjectsProtectedByPolicy> objectsProtectedByPolicy = default(List<ObjectsProtectedByPolicy>), int? lastDayNumJobErrors = default(int?), int? lastDayNumJobRuns = default(int?), int? lastDayNumJobSlaViolations = default(int?), int? numJobRunning = default(int?))
        {
            this.ObjectsProtectedByPolicy = objectsProtectedByPolicy;
            this.LastDayNumJobErrors = lastDayNumJobErrors;
            this.LastDayNumJobRuns = lastDayNumJobRuns;
            this.LastDayNumJobSlaViolations = lastDayNumJobSlaViolations;
            this.NumJobRunning = numJobRunning;
        }
        
        /// <summary>
        /// Gets or Sets ObjectsProtectedByPolicy
        /// </summary>
        [DataMember(Name="ObjectsProtectedByPolicy", EmitDefaultValue=false)]
        public List<ObjectsProtectedByPolicy> ObjectsProtectedByPolicy { get; set; }

        /// <summary>
        /// Number of Error runs in the last 24 hours.
        /// </summary>
        /// <value>Number of Error runs in the last 24 hours.</value>
        [DataMember(Name="lastDayNumJobErrors", EmitDefaultValue=false)]
        public int? LastDayNumJobErrors { get; set; }

        /// <summary>
        /// Number of Job Runs in the last 24 hours.
        /// </summary>
        /// <value>Number of Job Runs in the last 24 hours.</value>
        [DataMember(Name="lastDayNumJobRuns", EmitDefaultValue=false)]
        public int? LastDayNumJobRuns { get; set; }

        /// <summary>
        /// Number of SLA Violations in the last 24 hours.
        /// </summary>
        /// <value>Number of SLA Violations in the last 24 hours.</value>
        [DataMember(Name="lastDayNumJobSlaViolations", EmitDefaultValue=false)]
        public int? LastDayNumJobSlaViolations { get; set; }

        /// <summary>
        /// Number of Jobs currently running.
        /// </summary>
        /// <value>Number of Jobs currently running.</value>
        [DataMember(Name="numJobRunning", EmitDefaultValue=false)]
        public int? NumJobRunning { get; set; }

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
            return this.Equals(input as JobRunsTile);
        }

        /// <summary>
        /// Returns true if JobRunsTile instances are equal
        /// </summary>
        /// <param name="input">Instance of JobRunsTile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobRunsTile input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjectsProtectedByPolicy == input.ObjectsProtectedByPolicy ||
                    this.ObjectsProtectedByPolicy != null &&
                    this.ObjectsProtectedByPolicy.SequenceEqual(input.ObjectsProtectedByPolicy)
                ) && 
                (
                    this.LastDayNumJobErrors == input.LastDayNumJobErrors ||
                    (this.LastDayNumJobErrors != null &&
                    this.LastDayNumJobErrors.Equals(input.LastDayNumJobErrors))
                ) && 
                (
                    this.LastDayNumJobRuns == input.LastDayNumJobRuns ||
                    (this.LastDayNumJobRuns != null &&
                    this.LastDayNumJobRuns.Equals(input.LastDayNumJobRuns))
                ) && 
                (
                    this.LastDayNumJobSlaViolations == input.LastDayNumJobSlaViolations ||
                    (this.LastDayNumJobSlaViolations != null &&
                    this.LastDayNumJobSlaViolations.Equals(input.LastDayNumJobSlaViolations))
                ) && 
                (
                    this.NumJobRunning == input.NumJobRunning ||
                    (this.NumJobRunning != null &&
                    this.NumJobRunning.Equals(input.NumJobRunning))
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
                if (this.ObjectsProtectedByPolicy != null)
                    hashCode = hashCode * 59 + this.ObjectsProtectedByPolicy.GetHashCode();
                if (this.LastDayNumJobErrors != null)
                    hashCode = hashCode * 59 + this.LastDayNumJobErrors.GetHashCode();
                if (this.LastDayNumJobRuns != null)
                    hashCode = hashCode * 59 + this.LastDayNumJobRuns.GetHashCode();
                if (this.LastDayNumJobSlaViolations != null)
                    hashCode = hashCode * 59 + this.LastDayNumJobSlaViolations.GetHashCode();
                if (this.NumJobRunning != null)
                    hashCode = hashCode * 59 + this.NumJobRunning.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


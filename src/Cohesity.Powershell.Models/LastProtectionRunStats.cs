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
    /// Specifies the stats of last Protection Run.
    /// </summary>
    [DataContract]
    public partial class LastProtectionRunStats :  IEquatable<LastProtectionRunStats>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LastProtectionRunStats" /> class.
        /// </summary>
        /// <param name="numObjectsCancelled">Specifies the number of objects that were cancelled in the last Run across all Protection Jobs..</param>
        /// <param name="numObjectsFailed">Specifies the number of objects that were failed in the last Run across all Protection Jobs..</param>
        /// <param name="numObjectsInProgress">Specifies the number of objects that are still in progress in the last Run across all Protection Jobs..</param>
        /// <param name="numObjectsSuccessful">Specifies the number of objects that were successful in the last Run across all Protection Jobs..</param>
        /// <param name="numRunsFailed">Specifies the number of Protection Jobs for which specified Protection Run failed..</param>
        /// <param name="numRunsFailedSla">Specifies the number of Protection Jobs for which specified Protection Run failed SLA..</param>
        /// <param name="numRunsMetSla">Specifies the number of Protection Jobs for which specified Protection Run met SLA..</param>
        /// <param name="statsByEnv">Specifies the last Protection Run stats by environment..</param>
        public LastProtectionRunStats(long? numObjectsCancelled = default(long?), long? numObjectsFailed = default(long?), long? numObjectsInProgress = default(long?), long? numObjectsSuccessful = default(long?), long? numRunsFailed = default(long?), long? numRunsFailedSla = default(long?), long? numRunsMetSla = default(long?), List<LastProtectionRunStatsByEnv> statsByEnv = default(List<LastProtectionRunStatsByEnv>))
        {
            this.NumObjectsCancelled = numObjectsCancelled;
            this.NumObjectsFailed = numObjectsFailed;
            this.NumObjectsInProgress = numObjectsInProgress;
            this.NumObjectsSuccessful = numObjectsSuccessful;
            this.NumRunsFailed = numRunsFailed;
            this.NumRunsFailedSla = numRunsFailedSla;
            this.NumRunsMetSla = numRunsMetSla;
            this.StatsByEnv = statsByEnv;
        }
        
        /// <summary>
        /// Specifies the number of objects that were cancelled in the last Run across all Protection Jobs.
        /// </summary>
        /// <value>Specifies the number of objects that were cancelled in the last Run across all Protection Jobs.</value>
        [DataMember(Name="numObjectsCancelled", EmitDefaultValue=false)]
        public long? NumObjectsCancelled { get; set; }

        /// <summary>
        /// Specifies the number of objects that were failed in the last Run across all Protection Jobs.
        /// </summary>
        /// <value>Specifies the number of objects that were failed in the last Run across all Protection Jobs.</value>
        [DataMember(Name="numObjectsFailed", EmitDefaultValue=false)]
        public long? NumObjectsFailed { get; set; }

        /// <summary>
        /// Specifies the number of objects that are still in progress in the last Run across all Protection Jobs.
        /// </summary>
        /// <value>Specifies the number of objects that are still in progress in the last Run across all Protection Jobs.</value>
        [DataMember(Name="numObjectsInProgress", EmitDefaultValue=false)]
        public long? NumObjectsInProgress { get; set; }

        /// <summary>
        /// Specifies the number of objects that were successful in the last Run across all Protection Jobs.
        /// </summary>
        /// <value>Specifies the number of objects that were successful in the last Run across all Protection Jobs.</value>
        [DataMember(Name="numObjectsSuccessful", EmitDefaultValue=false)]
        public long? NumObjectsSuccessful { get; set; }

        /// <summary>
        /// Specifies the number of Protection Jobs for which specified Protection Run failed.
        /// </summary>
        /// <value>Specifies the number of Protection Jobs for which specified Protection Run failed.</value>
        [DataMember(Name="numRunsFailed", EmitDefaultValue=false)]
        public long? NumRunsFailed { get; set; }

        /// <summary>
        /// Specifies the number of Protection Jobs for which specified Protection Run failed SLA.
        /// </summary>
        /// <value>Specifies the number of Protection Jobs for which specified Protection Run failed SLA.</value>
        [DataMember(Name="numRunsFailedSla", EmitDefaultValue=false)]
        public long? NumRunsFailedSla { get; set; }

        /// <summary>
        /// Specifies the number of Protection Jobs for which specified Protection Run met SLA.
        /// </summary>
        /// <value>Specifies the number of Protection Jobs for which specified Protection Run met SLA.</value>
        [DataMember(Name="numRunsMetSla", EmitDefaultValue=false)]
        public long? NumRunsMetSla { get; set; }

        /// <summary>
        /// Specifies the last Protection Run stats by environment.
        /// </summary>
        /// <value>Specifies the last Protection Run stats by environment.</value>
        [DataMember(Name="statsByEnv", EmitDefaultValue=false)]
        public List<LastProtectionRunStatsByEnv> StatsByEnv { get; set; }

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
            return this.Equals(input as LastProtectionRunStats);
        }

        /// <summary>
        /// Returns true if LastProtectionRunStats instances are equal
        /// </summary>
        /// <param name="input">Instance of LastProtectionRunStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LastProtectionRunStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NumObjectsCancelled == input.NumObjectsCancelled ||
                    (this.NumObjectsCancelled != null &&
                    this.NumObjectsCancelled.Equals(input.NumObjectsCancelled))
                ) && 
                (
                    this.NumObjectsFailed == input.NumObjectsFailed ||
                    (this.NumObjectsFailed != null &&
                    this.NumObjectsFailed.Equals(input.NumObjectsFailed))
                ) && 
                (
                    this.NumObjectsInProgress == input.NumObjectsInProgress ||
                    (this.NumObjectsInProgress != null &&
                    this.NumObjectsInProgress.Equals(input.NumObjectsInProgress))
                ) && 
                (
                    this.NumObjectsSuccessful == input.NumObjectsSuccessful ||
                    (this.NumObjectsSuccessful != null &&
                    this.NumObjectsSuccessful.Equals(input.NumObjectsSuccessful))
                ) && 
                (
                    this.NumRunsFailed == input.NumRunsFailed ||
                    (this.NumRunsFailed != null &&
                    this.NumRunsFailed.Equals(input.NumRunsFailed))
                ) && 
                (
                    this.NumRunsFailedSla == input.NumRunsFailedSla ||
                    (this.NumRunsFailedSla != null &&
                    this.NumRunsFailedSla.Equals(input.NumRunsFailedSla))
                ) && 
                (
                    this.NumRunsMetSla == input.NumRunsMetSla ||
                    (this.NumRunsMetSla != null &&
                    this.NumRunsMetSla.Equals(input.NumRunsMetSla))
                ) && 
                (
                    this.StatsByEnv == input.StatsByEnv ||
                    this.StatsByEnv != null &&
                    this.StatsByEnv.Equals(input.StatsByEnv)
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
                if (this.NumObjectsCancelled != null)
                    hashCode = hashCode * 59 + this.NumObjectsCancelled.GetHashCode();
                if (this.NumObjectsFailed != null)
                    hashCode = hashCode * 59 + this.NumObjectsFailed.GetHashCode();
                if (this.NumObjectsInProgress != null)
                    hashCode = hashCode * 59 + this.NumObjectsInProgress.GetHashCode();
                if (this.NumObjectsSuccessful != null)
                    hashCode = hashCode * 59 + this.NumObjectsSuccessful.GetHashCode();
                if (this.NumRunsFailed != null)
                    hashCode = hashCode * 59 + this.NumRunsFailed.GetHashCode();
                if (this.NumRunsFailedSla != null)
                    hashCode = hashCode * 59 + this.NumRunsFailedSla.GetHashCode();
                if (this.NumRunsMetSla != null)
                    hashCode = hashCode * 59 + this.NumRunsMetSla.GetHashCode();
                if (this.StatsByEnv != null)
                    hashCode = hashCode * 59 + this.StatsByEnv.GetHashCode();
                return hashCode;
            }
        }

    }

}


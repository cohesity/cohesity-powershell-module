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
    /// ProtectionRunsSummary is the summary of the all the Protection Runs for the Protection Jobs using the Specified Protection Policy.
    /// </summary>
    [DataContract]
    public partial class ProtectionRunsSummary :  IEquatable<ProtectionRunsSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionRunsSummary" /> class.
        /// </summary>
        /// <param name="numberOfArchivalRuns">Specifies the total number of Archival Runs using the current Protection Policy..</param>
        /// <param name="numberOfProtectionRuns">Specifies the total number of Protection Runs by the given Protection Policy..</param>
        /// <param name="numberOfReplicationRuns">Specifies the total number of Replication Runs using the current Protection Policy..</param>
        /// <param name="numberOfSuccessfulArchivalRuns">Specifies the number of total successful Archival Runs using the current Protection Policy..</param>
        /// <param name="numberOfSuccessfulProtectionRuns">Specifies the number of successful Protection Runs using the current Protection Policy..</param>
        /// <param name="numberOfSuccessfulReplicationRuns">Specifies the number of total successful Replication Runs using the current Protection Policy..</param>
        public ProtectionRunsSummary(long? numberOfArchivalRuns = default(long?), long? numberOfProtectionRuns = default(long?), long? numberOfReplicationRuns = default(long?), long? numberOfSuccessfulArchivalRuns = default(long?), long? numberOfSuccessfulProtectionRuns = default(long?), long? numberOfSuccessfulReplicationRuns = default(long?))
        {
            this.NumberOfArchivalRuns = numberOfArchivalRuns;
            this.NumberOfProtectionRuns = numberOfProtectionRuns;
            this.NumberOfReplicationRuns = numberOfReplicationRuns;
            this.NumberOfSuccessfulArchivalRuns = numberOfSuccessfulArchivalRuns;
            this.NumberOfSuccessfulProtectionRuns = numberOfSuccessfulProtectionRuns;
            this.NumberOfSuccessfulReplicationRuns = numberOfSuccessfulReplicationRuns;
            this.NumberOfArchivalRuns = numberOfArchivalRuns;
            this.NumberOfProtectionRuns = numberOfProtectionRuns;
            this.NumberOfReplicationRuns = numberOfReplicationRuns;
            this.NumberOfSuccessfulArchivalRuns = numberOfSuccessfulArchivalRuns;
            this.NumberOfSuccessfulProtectionRuns = numberOfSuccessfulProtectionRuns;
            this.NumberOfSuccessfulReplicationRuns = numberOfSuccessfulReplicationRuns;
        }
        
        /// <summary>
        /// Specifies the total number of Archival Runs using the current Protection Policy.
        /// </summary>
        /// <value>Specifies the total number of Archival Runs using the current Protection Policy.</value>
        [DataMember(Name="numberOfArchivalRuns", EmitDefaultValue=true)]
        public long? NumberOfArchivalRuns { get; set; }

        /// <summary>
        /// Specifies the total number of Protection Runs by the given Protection Policy.
        /// </summary>
        /// <value>Specifies the total number of Protection Runs by the given Protection Policy.</value>
        [DataMember(Name="numberOfProtectionRuns", EmitDefaultValue=true)]
        public long? NumberOfProtectionRuns { get; set; }

        /// <summary>
        /// Specifies the total number of Replication Runs using the current Protection Policy.
        /// </summary>
        /// <value>Specifies the total number of Replication Runs using the current Protection Policy.</value>
        [DataMember(Name="numberOfReplicationRuns", EmitDefaultValue=true)]
        public long? NumberOfReplicationRuns { get; set; }

        /// <summary>
        /// Specifies the number of total successful Archival Runs using the current Protection Policy.
        /// </summary>
        /// <value>Specifies the number of total successful Archival Runs using the current Protection Policy.</value>
        [DataMember(Name="numberOfSuccessfulArchivalRuns", EmitDefaultValue=true)]
        public long? NumberOfSuccessfulArchivalRuns { get; set; }

        /// <summary>
        /// Specifies the number of successful Protection Runs using the current Protection Policy.
        /// </summary>
        /// <value>Specifies the number of successful Protection Runs using the current Protection Policy.</value>
        [DataMember(Name="numberOfSuccessfulProtectionRuns", EmitDefaultValue=true)]
        public long? NumberOfSuccessfulProtectionRuns { get; set; }

        /// <summary>
        /// Specifies the number of total successful Replication Runs using the current Protection Policy.
        /// </summary>
        /// <value>Specifies the number of total successful Replication Runs using the current Protection Policy.</value>
        [DataMember(Name="numberOfSuccessfulReplicationRuns", EmitDefaultValue=true)]
        public long? NumberOfSuccessfulReplicationRuns { get; set; }

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
            return this.Equals(input as ProtectionRunsSummary);
        }

        /// <summary>
        /// Returns true if ProtectionRunsSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectionRunsSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectionRunsSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NumberOfArchivalRuns == input.NumberOfArchivalRuns ||
                    (this.NumberOfArchivalRuns != null &&
                    this.NumberOfArchivalRuns.Equals(input.NumberOfArchivalRuns))
                ) && 
                (
                    this.NumberOfProtectionRuns == input.NumberOfProtectionRuns ||
                    (this.NumberOfProtectionRuns != null &&
                    this.NumberOfProtectionRuns.Equals(input.NumberOfProtectionRuns))
                ) && 
                (
                    this.NumberOfReplicationRuns == input.NumberOfReplicationRuns ||
                    (this.NumberOfReplicationRuns != null &&
                    this.NumberOfReplicationRuns.Equals(input.NumberOfReplicationRuns))
                ) && 
                (
                    this.NumberOfSuccessfulArchivalRuns == input.NumberOfSuccessfulArchivalRuns ||
                    (this.NumberOfSuccessfulArchivalRuns != null &&
                    this.NumberOfSuccessfulArchivalRuns.Equals(input.NumberOfSuccessfulArchivalRuns))
                ) && 
                (
                    this.NumberOfSuccessfulProtectionRuns == input.NumberOfSuccessfulProtectionRuns ||
                    (this.NumberOfSuccessfulProtectionRuns != null &&
                    this.NumberOfSuccessfulProtectionRuns.Equals(input.NumberOfSuccessfulProtectionRuns))
                ) && 
                (
                    this.NumberOfSuccessfulReplicationRuns == input.NumberOfSuccessfulReplicationRuns ||
                    (this.NumberOfSuccessfulReplicationRuns != null &&
                    this.NumberOfSuccessfulReplicationRuns.Equals(input.NumberOfSuccessfulReplicationRuns))
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
                if (this.NumberOfArchivalRuns != null)
                    hashCode = hashCode * 59 + this.NumberOfArchivalRuns.GetHashCode();
                if (this.NumberOfProtectionRuns != null)
                    hashCode = hashCode * 59 + this.NumberOfProtectionRuns.GetHashCode();
                if (this.NumberOfReplicationRuns != null)
                    hashCode = hashCode * 59 + this.NumberOfReplicationRuns.GetHashCode();
                if (this.NumberOfSuccessfulArchivalRuns != null)
                    hashCode = hashCode * 59 + this.NumberOfSuccessfulArchivalRuns.GetHashCode();
                if (this.NumberOfSuccessfulProtectionRuns != null)
                    hashCode = hashCode * 59 + this.NumberOfSuccessfulProtectionRuns.GetHashCode();
                if (this.NumberOfSuccessfulReplicationRuns != null)
                    hashCode = hashCode * 59 + this.NumberOfSuccessfulReplicationRuns.GetHashCode();
                return hashCode;
            }
        }

    }

}


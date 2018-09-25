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
    /// ProtectedVmInfo
    /// </summary>
    [DataContract]
    public partial class ProtectedVmInfo :  IEquatable<ProtectedVmInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectedVmInfo" /> class.
        /// </summary>
        /// <param name="protectionJobs">protectionJobs.</param>
        /// <param name="protectionPolicies">protectionPolicies.</param>
        /// <param name="protectionSource">Specifies a VM that is being protected on the Cohesity Cluster..</param>
        /// <param name="stats">stats.</param>
        public ProtectedVmInfo(List<ProtectionJob> protectionJobs = default(List<ProtectionJob>), List<ProtectionPolicy> protectionPolicies = default(List<ProtectionPolicy>), ProtectionSource protectionSource = default(ProtectionSource), ProtectionSummaryInformationOfARegisteredProtectionSourceTreeOrtheCohesityCluster1 stats = default(ProtectionSummaryInformationOfARegisteredProtectionSourceTreeOrtheCohesityCluster1))
        {
            this.ProtectionJobs = protectionJobs;
            this.ProtectionPolicies = protectionPolicies;
            this.ProtectionSource = protectionSource;
            this.Stats = stats;
        }
        
        /// <summary>
        /// Gets or Sets ProtectionJobs
        /// </summary>
        [DataMember(Name="protectionJobs", EmitDefaultValue=false)]
        public List<ProtectionJob> ProtectionJobs { get; set; }

        /// <summary>
        /// Gets or Sets ProtectionPolicies
        /// </summary>
        [DataMember(Name="protectionPolicies", EmitDefaultValue=false)]
        public List<ProtectionPolicy> ProtectionPolicies { get; set; }

        /// <summary>
        /// Specifies a VM that is being protected on the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies a VM that is being protected on the Cohesity Cluster.</value>
        [DataMember(Name="protectionSource", EmitDefaultValue=false)]
        public ProtectionSource ProtectionSource { get; set; }

        /// <summary>
        /// Gets or Sets Stats
        /// </summary>
        [DataMember(Name="stats", EmitDefaultValue=false)]
        public ProtectionSummaryInformationOfARegisteredProtectionSourceTreeOrtheCohesityCluster1 Stats { get; set; }

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
            return this.Equals(input as ProtectedVmInfo);
        }

        /// <summary>
        /// Returns true if ProtectedVmInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectedVmInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectedVmInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProtectionJobs == input.ProtectionJobs ||
                    this.ProtectionJobs != null &&
                    this.ProtectionJobs.SequenceEqual(input.ProtectionJobs)
                ) && 
                (
                    this.ProtectionPolicies == input.ProtectionPolicies ||
                    this.ProtectionPolicies != null &&
                    this.ProtectionPolicies.SequenceEqual(input.ProtectionPolicies)
                ) && 
                (
                    this.ProtectionSource == input.ProtectionSource ||
                    (this.ProtectionSource != null &&
                    this.ProtectionSource.Equals(input.ProtectionSource))
                ) && 
                (
                    this.Stats == input.Stats ||
                    (this.Stats != null &&
                    this.Stats.Equals(input.Stats))
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
                if (this.ProtectionJobs != null)
                    hashCode = hashCode * 59 + this.ProtectionJobs.GetHashCode();
                if (this.ProtectionPolicies != null)
                    hashCode = hashCode * 59 + this.ProtectionPolicies.GetHashCode();
                if (this.ProtectionSource != null)
                    hashCode = hashCode * 59 + this.ProtectionSource.GetHashCode();
                if (this.Stats != null)
                    hashCode = hashCode * 59 + this.Stats.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


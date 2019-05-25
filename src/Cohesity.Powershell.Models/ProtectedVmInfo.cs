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
    /// Specifies the Protection Jobs information of a VM.
    /// </summary>
    [DataContract]
    public partial class ProtectedVmInfo :  IEquatable<ProtectedVmInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectedVmInfo" /> class.
        /// </summary>
        /// <param name="protectionJobs">Specifies the list of Protection Jobs that protect the VM..</param>
        /// <param name="protectionPolicies">Specifies the list of Policies that are used by the Protection Jobs..</param>
        /// <param name="protectionSource">protectionSource.</param>
        /// <param name="stats">Specifies the protection stats of VM..</param>
        public ProtectedVmInfo(List<ProtectionJob> protectionJobs = default(List<ProtectionJob>), List<ProtectionPolicy> protectionPolicies = default(List<ProtectionPolicy>), ProtectionSource protectionSource = default(ProtectionSource), ProtectionSummary stats = default(ProtectionSummary))
        {
            this.ProtectionJobs = protectionJobs;
            this.ProtectionPolicies = protectionPolicies;
            this.Stats = stats;
            this.ProtectionJobs = protectionJobs;
            this.ProtectionPolicies = protectionPolicies;
            this.ProtectionSource = protectionSource;
            this.Stats = stats;
        }
        
        /// <summary>
        /// Specifies the list of Protection Jobs that protect the VM.
        /// </summary>
        /// <value>Specifies the list of Protection Jobs that protect the VM.</value>
        [DataMember(Name="protectionJobs", EmitDefaultValue=true)]
        public List<ProtectionJob> ProtectionJobs { get; set; }

        /// <summary>
        /// Specifies the list of Policies that are used by the Protection Jobs.
        /// </summary>
        /// <value>Specifies the list of Policies that are used by the Protection Jobs.</value>
        [DataMember(Name="protectionPolicies", EmitDefaultValue=true)]
        public List<ProtectionPolicy> ProtectionPolicies { get; set; }

        /// <summary>
        /// Gets or Sets ProtectionSource
        /// </summary>
        [DataMember(Name="protectionSource", EmitDefaultValue=false)]
        public ProtectionSource ProtectionSource { get; set; }

        /// <summary>
        /// Specifies the protection stats of VM.
        /// </summary>
        /// <value>Specifies the protection stats of VM.</value>
        [DataMember(Name="stats", EmitDefaultValue=true)]
        public ProtectionSummary Stats { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProtectedVmInfo {\n");
            sb.Append("  ProtectionJobs: ").Append(ProtectionJobs).Append("\n");
            sb.Append("  ProtectionPolicies: ").Append(ProtectionPolicies).Append("\n");
            sb.Append("  ProtectionSource: ").Append(ProtectionSource).Append("\n");
            sb.Append("  Stats: ").Append(Stats).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
                    input.ProtectionJobs != null &&
                    this.ProtectionJobs.SequenceEqual(input.ProtectionJobs)
                ) && 
                (
                    this.ProtectionPolicies == input.ProtectionPolicies ||
                    this.ProtectionPolicies != null &&
                    input.ProtectionPolicies != null &&
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

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
    /// ProtectionPolicySummary specifies protection summary of a given Protection Policy.
    /// </summary>
    [DataContract]
    public partial class ProtectionPolicySummary :  IEquatable<ProtectionPolicySummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionPolicySummary" /> class.
        /// </summary>
        /// <param name="lastProtectionRunSummary">lastProtectionRunSummary.</param>
        /// <param name="paginationCookie">If there are more results to display, use this value to get the next set of results, by using this value in paginationCookie param for the next request to GetProtectionPolicySummary..</param>
        /// <param name="protectedSourcesSummary">Specifies the list of Protection Sources which are protected under the given policy. This is only populated if the policy is of type kRPO..</param>
        /// <param name="protectionJobsSummary">Specifies the list of Protection Jobs associated with the given Protection Policy. This is only populated if the type of the Protection Policy is kRegular..</param>
        /// <param name="protectionPolicy">protectionPolicy.</param>
        /// <param name="protectionRunsSummary">protectionRunsSummary.</param>
        public ProtectionPolicySummary(LastProtectionRunSummary lastProtectionRunSummary = default(LastProtectionRunSummary), string paginationCookie = default(string), List<ProtectedSourceSummary> protectedSourcesSummary = default(List<ProtectedSourceSummary>), List<ProtectionJobSummaryForPolicies> protectionJobsSummary = default(List<ProtectionJobSummaryForPolicies>), ProtectionPolicy protectionPolicy = default(ProtectionPolicy), ProtectionRunsSummary protectionRunsSummary = default(ProtectionRunsSummary))
        {
            this.LastProtectionRunSummary = lastProtectionRunSummary;
            this.PaginationCookie = paginationCookie;
            this.ProtectedSourcesSummary = protectedSourcesSummary;
            this.ProtectionJobsSummary = protectionJobsSummary;
            this.ProtectionPolicy = protectionPolicy;
            this.ProtectionRunsSummary = protectionRunsSummary;
        }
        
        /// <summary>
        /// Gets or Sets LastProtectionRunSummary
        /// </summary>
        [DataMember(Name="lastProtectionRunSummary", EmitDefaultValue=false)]
        public LastProtectionRunSummary LastProtectionRunSummary { get; set; }

        /// <summary>
        /// If there are more results to display, use this value to get the next set of results, by using this value in paginationCookie param for the next request to GetProtectionPolicySummary.
        /// </summary>
        /// <value>If there are more results to display, use this value to get the next set of results, by using this value in paginationCookie param for the next request to GetProtectionPolicySummary.</value>
        [DataMember(Name="paginationCookie", EmitDefaultValue=false)]
        public string PaginationCookie { get; set; }

        /// <summary>
        /// Specifies the list of Protection Sources which are protected under the given policy. This is only populated if the policy is of type kRPO.
        /// </summary>
        /// <value>Specifies the list of Protection Sources which are protected under the given policy. This is only populated if the policy is of type kRPO.</value>
        [DataMember(Name="protectedSourcesSummary", EmitDefaultValue=false)]
        public List<ProtectedSourceSummary> ProtectedSourcesSummary { get; set; }

        /// <summary>
        /// Specifies the list of Protection Jobs associated with the given Protection Policy. This is only populated if the type of the Protection Policy is kRegular.
        /// </summary>
        /// <value>Specifies the list of Protection Jobs associated with the given Protection Policy. This is only populated if the type of the Protection Policy is kRegular.</value>
        [DataMember(Name="protectionJobsSummary", EmitDefaultValue=false)]
        public List<ProtectionJobSummaryForPolicies> ProtectionJobsSummary { get; set; }

        /// <summary>
        /// Gets or Sets ProtectionPolicy
        /// </summary>
        [DataMember(Name="protectionPolicy", EmitDefaultValue=false)]
        public ProtectionPolicy ProtectionPolicy { get; set; }

        /// <summary>
        /// Gets or Sets ProtectionRunsSummary
        /// </summary>
        [DataMember(Name="protectionRunsSummary", EmitDefaultValue=false)]
        public ProtectionRunsSummary ProtectionRunsSummary { get; set; }

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
            return this.Equals(input as ProtectionPolicySummary);
        }

        /// <summary>
        /// Returns true if ProtectionPolicySummary instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectionPolicySummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectionPolicySummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LastProtectionRunSummary == input.LastProtectionRunSummary ||
                    (this.LastProtectionRunSummary != null &&
                    this.LastProtectionRunSummary.Equals(input.LastProtectionRunSummary))
                ) && 
                (
                    this.PaginationCookie == input.PaginationCookie ||
                    (this.PaginationCookie != null &&
                    this.PaginationCookie.Equals(input.PaginationCookie))
                ) && 
                (
                    this.ProtectedSourcesSummary == input.ProtectedSourcesSummary ||
                    this.ProtectedSourcesSummary != null &&
                    this.ProtectedSourcesSummary.Equals(input.ProtectedSourcesSummary)
                ) && 
                (
                    this.ProtectionJobsSummary == input.ProtectionJobsSummary ||
                    this.ProtectionJobsSummary != null &&
                    this.ProtectionJobsSummary.Equals(input.ProtectionJobsSummary)
                ) && 
                (
                    this.ProtectionPolicy == input.ProtectionPolicy ||
                    (this.ProtectionPolicy != null &&
                    this.ProtectionPolicy.Equals(input.ProtectionPolicy))
                ) && 
                (
                    this.ProtectionRunsSummary == input.ProtectionRunsSummary ||
                    (this.ProtectionRunsSummary != null &&
                    this.ProtectionRunsSummary.Equals(input.ProtectionRunsSummary))
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
                if (this.LastProtectionRunSummary != null)
                    hashCode = hashCode * 59 + this.LastProtectionRunSummary.GetHashCode();
                if (this.PaginationCookie != null)
                    hashCode = hashCode * 59 + this.PaginationCookie.GetHashCode();
                if (this.ProtectedSourcesSummary != null)
                    hashCode = hashCode * 59 + this.ProtectedSourcesSummary.GetHashCode();
                if (this.ProtectionJobsSummary != null)
                    hashCode = hashCode * 59 + this.ProtectionJobsSummary.GetHashCode();
                if (this.ProtectionPolicy != null)
                    hashCode = hashCode * 59 + this.ProtectionPolicy.GetHashCode();
                if (this.ProtectionRunsSummary != null)
                    hashCode = hashCode * 59 + this.ProtectionRunsSummary.GetHashCode();
                return hashCode;
            }
        }

    }

}


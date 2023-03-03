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
    /// ProtectionSourcesJobsSummaryReportResponseWrapper
    /// </summary>
    [DataContract]
    public partial class ProtectionSourcesJobsSummaryReportResponseWrapper :  IEquatable<ProtectionSourcesJobsSummaryReportResponseWrapper>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionSourcesJobsSummaryReportResponseWrapper" /> class.
        /// </summary>
        /// <param name="protectionSourcesJobsSummary">Specifies the list of Snapshot summary statistics that match the filter criteria..</param>
        public ProtectionSourcesJobsSummaryReportResponseWrapper(List<ProtectionSourcesSummaryStats> protectionSourcesJobsSummary = default(List<ProtectionSourcesSummaryStats>))
        {
            this.ProtectionSourcesJobsSummary = protectionSourcesJobsSummary;
            this.ProtectionSourcesJobsSummary = protectionSourcesJobsSummary;
        }
        
        /// <summary>
        /// Specifies the list of Snapshot summary statistics that match the filter criteria.
        /// </summary>
        /// <value>Specifies the list of Snapshot summary statistics that match the filter criteria.</value>
        [DataMember(Name="protectionSourcesJobsSummary", EmitDefaultValue=true)]
        public List<ProtectionSourcesSummaryStats> ProtectionSourcesJobsSummary { get; set; }

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
            return this.Equals(input as ProtectionSourcesJobsSummaryReportResponseWrapper);
        }

        /// <summary>
        /// Returns true if ProtectionSourcesJobsSummaryReportResponseWrapper instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectionSourcesJobsSummaryReportResponseWrapper to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectionSourcesJobsSummaryReportResponseWrapper input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProtectionSourcesJobsSummary == input.ProtectionSourcesJobsSummary ||
                    this.ProtectionSourcesJobsSummary != null &&
                    input.ProtectionSourcesJobsSummary != null &&
                    this.ProtectionSourcesJobsSummary.SequenceEqual(input.ProtectionSourcesJobsSummary)
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
                if (this.ProtectionSourcesJobsSummary != null)
                    hashCode = hashCode * 59 + this.ProtectionSourcesJobsSummary.GetHashCode();
                return hashCode;
            }
        }

    }

}


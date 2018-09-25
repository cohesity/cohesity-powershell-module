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
    /// Short description and detailed notes about the Resolution.
    /// </summary>
    [DataContract]
    public partial class AlertResolutionInfo :  IEquatable<AlertResolutionInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlertResolutionInfo" /> class.
        /// </summary>
        /// <param name="resolutionDetails">Detailed notes about the Resolution..</param>
        /// <param name="resolutionSummary">Short description about the Resolution..</param>
        public AlertResolutionInfo(string resolutionDetails = default(string), string resolutionSummary = default(string))
        {
            this.ResolutionDetails = resolutionDetails;
            this.ResolutionSummary = resolutionSummary;
        }
        
        /// <summary>
        /// Detailed notes about the Resolution.
        /// </summary>
        /// <value>Detailed notes about the Resolution.</value>
        [DataMember(Name="resolutionDetails", EmitDefaultValue=false)]
        public string ResolutionDetails { get; set; }

        /// <summary>
        /// Short description about the Resolution.
        /// </summary>
        /// <value>Short description about the Resolution.</value>
        [DataMember(Name="resolutionSummary", EmitDefaultValue=false)]
        public string ResolutionSummary { get; set; }

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
            return this.Equals(input as AlertResolutionInfo);
        }

        /// <summary>
        /// Returns true if AlertResolutionInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of AlertResolutionInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlertResolutionInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResolutionDetails == input.ResolutionDetails ||
                    (this.ResolutionDetails != null &&
                    this.ResolutionDetails.Equals(input.ResolutionDetails))
                ) && 
                (
                    this.ResolutionSummary == input.ResolutionSummary ||
                    (this.ResolutionSummary != null &&
                    this.ResolutionSummary.Equals(input.ResolutionSummary))
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
                if (this.ResolutionDetails != null)
                    hashCode = hashCode * 59 + this.ResolutionDetails.GetHashCode();
                if (this.ResolutionSummary != null)
                    hashCode = hashCode * 59 + this.ResolutionSummary.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


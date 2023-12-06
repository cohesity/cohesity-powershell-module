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
    /// ThreatProtectionInfo holds information about the Datahawk ThreatProtection subscription such as if it is active or not.
    /// </summary>
    [DataContract]
    public partial class ThreatProtectionInfo :  IEquatable<ThreatProtectionInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThreatProtectionInfo" /> class.
        /// </summary>
        /// <param name="endDate">Specifies the end date of the subscription..</param>
        /// <param name="isActive">Specifies whether the Datahawk ThreatProtection subscription is active..</param>
        /// <param name="isFreeTrial">Specifies whether the subscription is free trial..</param>
        /// <param name="startDate">Specifies the start date of the subscription..</param>
        public ThreatProtectionInfo(string endDate = default(string), bool? isActive = default(bool?), bool? isFreeTrial = default(bool?), string startDate = default(string))
        {
            this.EndDate = endDate;
            this.IsActive = isActive;
            this.IsFreeTrial = isFreeTrial;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.IsActive = isActive;
            this.IsFreeTrial = isFreeTrial;
            this.StartDate = startDate;
        }
        
        /// <summary>
        /// Specifies the end date of the subscription.
        /// </summary>
        /// <value>Specifies the end date of the subscription.</value>
        [DataMember(Name="endDate", EmitDefaultValue=true)]
        public string EndDate { get; set; }

        /// <summary>
        /// Specifies whether the Datahawk ThreatProtection subscription is active.
        /// </summary>
        /// <value>Specifies whether the Datahawk ThreatProtection subscription is active.</value>
        [DataMember(Name="isActive", EmitDefaultValue=true)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Specifies whether the subscription is free trial.
        /// </summary>
        /// <value>Specifies whether the subscription is free trial.</value>
        [DataMember(Name="isFreeTrial", EmitDefaultValue=true)]
        public bool? IsFreeTrial { get; set; }

        /// <summary>
        /// Specifies the start date of the subscription.
        /// </summary>
        /// <value>Specifies the start date of the subscription.</value>
        [DataMember(Name="startDate", EmitDefaultValue=true)]
        public string StartDate { get; set; }

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
            return this.Equals(input as ThreatProtectionInfo);
        }

        /// <summary>
        /// Returns true if ThreatProtectionInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ThreatProtectionInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThreatProtectionInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    (this.IsActive != null &&
                    this.IsActive.Equals(input.IsActive))
                ) && 
                (
                    this.IsFreeTrial == input.IsFreeTrial ||
                    (this.IsFreeTrial != null &&
                    this.IsFreeTrial.Equals(input.IsFreeTrial))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
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
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.IsActive != null)
                    hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.IsFreeTrial != null)
                    hashCode = hashCode * 59 + this.IsFreeTrial.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                return hashCode;
            }
        }

    }

}


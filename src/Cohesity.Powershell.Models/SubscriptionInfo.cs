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
    /// Extends this to have Helios, DRaaS and DSaaS.
    /// </summary>
    [DataContract]
    public partial class SubscriptionInfo :  IEquatable<SubscriptionInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionInfo" /> class.
        /// </summary>
        /// <param name="dataGovernance">dataGovernance.</param>
        /// <param name="dataProtect">dataProtect.</param>
        /// <param name="ransomware">ransomware.</param>
        /// <param name="siteContinuity">siteContinuity.</param>
        public SubscriptionInfo(DataGovernanceInfo dataGovernance = default(DataGovernanceInfo), DataProtectInfo dataProtect = default(DataProtectInfo), RansomwareInfo ransomware = default(RansomwareInfo), SiteContinuityInfo siteContinuity = default(SiteContinuityInfo))
        {
            this.DataGovernance = dataGovernance;
            this.DataProtect = dataProtect;
            this.Ransomware = ransomware;
            this.SiteContinuity = siteContinuity;
        }
        
        /// <summary>
        /// Gets or Sets DataGovernance
        /// </summary>
        [DataMember(Name="dataGovernance", EmitDefaultValue=false)]
        public DataGovernanceInfo DataGovernance { get; set; }

        /// <summary>
        /// Gets or Sets DataProtect
        /// </summary>
        [DataMember(Name="dataProtect", EmitDefaultValue=false)]
        public DataProtectInfo DataProtect { get; set; }

        /// <summary>
        /// Gets or Sets Ransomware
        /// </summary>
        [DataMember(Name="ransomware", EmitDefaultValue=false)]
        public RansomwareInfo Ransomware { get; set; }

        /// <summary>
        /// Gets or Sets SiteContinuity
        /// </summary>
        [DataMember(Name="siteContinuity", EmitDefaultValue=false)]
        public SiteContinuityInfo SiteContinuity { get; set; }

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
            return this.Equals(input as SubscriptionInfo);
        }

        /// <summary>
        /// Returns true if SubscriptionInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DataGovernance == input.DataGovernance ||
                    (this.DataGovernance != null &&
                    this.DataGovernance.Equals(input.DataGovernance))
                ) && 
                (
                    this.DataProtect == input.DataProtect ||
                    (this.DataProtect != null &&
                    this.DataProtect.Equals(input.DataProtect))
                ) && 
                (
                    this.Ransomware == input.Ransomware ||
                    (this.Ransomware != null &&
                    this.Ransomware.Equals(input.Ransomware))
                ) && 
                (
                    this.SiteContinuity == input.SiteContinuity ||
                    (this.SiteContinuity != null &&
                    this.SiteContinuity.Equals(input.SiteContinuity))
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
                if (this.DataGovernance != null)
                    hashCode = hashCode * 59 + this.DataGovernance.GetHashCode();
                if (this.DataProtect != null)
                    hashCode = hashCode * 59 + this.DataProtect.GetHashCode();
                if (this.Ransomware != null)
                    hashCode = hashCode * 59 + this.Ransomware.GetHashCode();
                if (this.SiteContinuity != null)
                    hashCode = hashCode * 59 + this.SiteContinuity.GetHashCode();
                return hashCode;
            }
        }

    }

}


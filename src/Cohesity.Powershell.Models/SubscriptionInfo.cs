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
        /// <param name="classification">classification.</param>
        /// <param name="dataProtect">dataProtect.</param>
        /// <param name="dataProtectAzure">dataProtectAzure.</param>
        /// <param name="fortKnoxAzureCool">fortKnoxAzureCool.</param>
        /// <param name="fortKnoxAzureHot">fortKnoxAzureHot.</param>
        /// <param name="fortKnoxCold">fortKnoxCold.</param>
        /// <param name="ransomware">ransomware.</param>
        /// <param name="siteContinuity">siteContinuity.</param>
        /// <param name="threatProtection">threatProtection.</param>
        public SubscriptionInfo(ClassificationInfo classification = default(ClassificationInfo), DataProtectInfo dataProtect = default(DataProtectInfo), DataProtectAzureInfo dataProtectAzure = default(DataProtectAzureInfo), FortKnoxAzureInfo fortKnoxAzureCool = default(FortKnoxAzureInfo), FortKnoxAzureInfo fortKnoxAzureHot = default(FortKnoxAzureInfo), FortKnoxColdInfo fortKnoxCold = default(FortKnoxColdInfo), RansomwareInfo ransomware = default(RansomwareInfo), SiteContinuityInfo siteContinuity = default(SiteContinuityInfo), ThreatProtectionInfo threatProtection = default(ThreatProtectionInfo))
        {
            this.Classification = classification;
            this.DataProtect = dataProtect;
            this.DataProtectAzure = dataProtectAzure;
            this.FortKnoxAzureCool = fortKnoxAzureCool;
            this.FortKnoxAzureHot = fortKnoxAzureHot;
            this.FortKnoxCold = fortKnoxCold;
            this.Ransomware = ransomware;
            this.SiteContinuity = siteContinuity;
            this.ThreatProtection = threatProtection;
        }
        
        /// <summary>
        /// Gets or Sets Classification
        /// </summary>
        [DataMember(Name="classification", EmitDefaultValue=false)]
        public ClassificationInfo Classification { get; set; }

        /// <summary>
        /// Gets or Sets DataProtect
        /// </summary>
        [DataMember(Name="dataProtect", EmitDefaultValue=false)]
        public DataProtectInfo DataProtect { get; set; }

        /// <summary>
        /// Gets or Sets DataProtectAzure
        /// </summary>
        [DataMember(Name="dataProtectAzure", EmitDefaultValue=false)]
        public DataProtectAzureInfo DataProtectAzure { get; set; }

        /// <summary>
        /// Gets or Sets FortKnoxAzureCool
        /// </summary>
        [DataMember(Name="fortKnoxAzureCool", EmitDefaultValue=false)]
        public FortKnoxAzureInfo FortKnoxAzureCool { get; set; }

        /// <summary>
        /// Gets or Sets FortKnoxAzureHot
        /// </summary>
        [DataMember(Name="fortKnoxAzureHot", EmitDefaultValue=false)]
        public FortKnoxAzureInfo FortKnoxAzureHot { get; set; }

        /// <summary>
        /// Gets or Sets FortKnoxCold
        /// </summary>
        [DataMember(Name="fortKnoxCold", EmitDefaultValue=false)]
        public FortKnoxColdInfo FortKnoxCold { get; set; }

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
        /// Gets or Sets ThreatProtection
        /// </summary>
        [DataMember(Name="threatProtection", EmitDefaultValue=false)]
        public ThreatProtectionInfo ThreatProtection { get; set; }

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
                    this.Classification == input.Classification ||
                    (this.Classification != null &&
                    this.Classification.Equals(input.Classification))
                ) && 
                (
                    this.DataProtect == input.DataProtect ||
                    (this.DataProtect != null &&
                    this.DataProtect.Equals(input.DataProtect))
                ) && 
                (
                    this.DataProtectAzure == input.DataProtectAzure ||
                    (this.DataProtectAzure != null &&
                    this.DataProtectAzure.Equals(input.DataProtectAzure))
                ) && 
                (
                    this.FortKnoxAzureCool == input.FortKnoxAzureCool ||
                    (this.FortKnoxAzureCool != null &&
                    this.FortKnoxAzureCool.Equals(input.FortKnoxAzureCool))
                ) && 
                (
                    this.FortKnoxAzureHot == input.FortKnoxAzureHot ||
                    (this.FortKnoxAzureHot != null &&
                    this.FortKnoxAzureHot.Equals(input.FortKnoxAzureHot))
                ) && 
                (
                    this.FortKnoxCold == input.FortKnoxCold ||
                    (this.FortKnoxCold != null &&
                    this.FortKnoxCold.Equals(input.FortKnoxCold))
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
                ) && 
                (
                    this.ThreatProtection == input.ThreatProtection ||
                    (this.ThreatProtection != null &&
                    this.ThreatProtection.Equals(input.ThreatProtection))
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
                if (this.Classification != null)
                    hashCode = hashCode * 59 + this.Classification.GetHashCode();
                if (this.DataProtect != null)
                    hashCode = hashCode * 59 + this.DataProtect.GetHashCode();
                if (this.DataProtectAzure != null)
                    hashCode = hashCode * 59 + this.DataProtectAzure.GetHashCode();
                if (this.FortKnoxAzureCool != null)
                    hashCode = hashCode * 59 + this.FortKnoxAzureCool.GetHashCode();
                if (this.FortKnoxAzureHot != null)
                    hashCode = hashCode * 59 + this.FortKnoxAzureHot.GetHashCode();
                if (this.FortKnoxCold != null)
                    hashCode = hashCode * 59 + this.FortKnoxCold.GetHashCode();
                if (this.Ransomware != null)
                    hashCode = hashCode * 59 + this.Ransomware.GetHashCode();
                if (this.SiteContinuity != null)
                    hashCode = hashCode * 59 + this.SiteContinuity.GetHashCode();
                if (this.ThreatProtection != null)
                    hashCode = hashCode * 59 + this.ThreatProtection.GetHashCode();
                return hashCode;
            }
        }

    }

}


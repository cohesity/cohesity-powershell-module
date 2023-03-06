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
    /// Structure to hold account usage response
    /// </summary>
    [DataContract]
    public partial class LicenseAccountUsageRsp :  IEquatable<LicenseAccountUsageRsp>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseAccountUsageRsp" /> class.
        /// </summary>
        /// <param name="featureOverusage">Holds information about consumption usage of overused features.</param>
        /// <param name="freeSetupMode">Free Setup Mode.</param>
        /// <param name="isTrial">Check if trial license..</param>
        /// <param name="last12MonthsAvgEntitlement">Holds monthly avg usage values of feature.</param>
        /// <param name="last12MonthsAvgUsage">Holds monthly avg usage values of feature.</param>
        /// <param name="last30DaysEntitlement">Holds daily entitled capacity values of feature.</param>
        /// <param name="last30DaysUsage">Holds daily usage values of feature.</param>
        /// <param name="lastUpdateTime">Last time, this report was updated..</param>
        /// <param name="licensedUsage">LicenseFeatureUsages holds information about each feature from license orders..</param>
        /// <param name="trialExpiration">Trial expiration period..</param>
        /// <param name="usage">Creating a map of cluster id and feature usage to make it consistent display usage UI for the helios server license page UI..</param>
        public LicenseAccountUsageRsp(List<Overusage> featureOverusage = default(List<Overusage>), bool? freeSetupMode = default(bool?), bool? isTrial = default(bool?), Dictionary<string, List<MonthlyEntitlement>> last12MonthsAvgEntitlement = default(Dictionary<string, List<MonthlyEntitlement>>), Dictionary<string, List<MonthlyUsage>> last12MonthsAvgUsage = default(Dictionary<string, List<MonthlyUsage>>), Dictionary<string, List<DailyEntitlement>> last30DaysEntitlement = default(Dictionary<string, List<DailyEntitlement>>), Dictionary<string, List<DailyUsage>> last30DaysUsage = default(Dictionary<string, List<DailyUsage>>), long? lastUpdateTime = default(long?), List<LicensedUsage> licensedUsage = default(List<LicensedUsage>), long? trialExpiration = default(long?), Dictionary<string, List<FeatureUsage>> usage = default(Dictionary<string, List<FeatureUsage>>))
        {
            this.FeatureOverusage = featureOverusage;
            this.FreeSetupMode = freeSetupMode;
            this.IsTrial = isTrial;
            this.Last12MonthsAvgEntitlement = last12MonthsAvgEntitlement;
            this.Last12MonthsAvgUsage = last12MonthsAvgUsage;
            this.Last30DaysEntitlement = last30DaysEntitlement;
            this.Last30DaysUsage = last30DaysUsage;
            this.LastUpdateTime = lastUpdateTime;
            this.LicensedUsage = licensedUsage;
            this.TrialExpiration = trialExpiration;
            this.Usage = usage;
            this.FeatureOverusage = featureOverusage;
            this.FreeSetupMode = freeSetupMode;
            this.IsTrial = isTrial;
            this.Last12MonthsAvgEntitlement = last12MonthsAvgEntitlement;
            this.Last12MonthsAvgUsage = last12MonthsAvgUsage;
            this.Last30DaysEntitlement = last30DaysEntitlement;
            this.Last30DaysUsage = last30DaysUsage;
            this.LastUpdateTime = lastUpdateTime;
            this.LicensedUsage = licensedUsage;
            this.TrialExpiration = trialExpiration;
            this.Usage = usage;
        }
        
        /// <summary>
        /// Holds information about consumption usage of overused features
        /// </summary>
        /// <value>Holds information about consumption usage of overused features</value>
        [DataMember(Name="featureOverusage", EmitDefaultValue=true)]
        public List<Overusage> FeatureOverusage { get; set; }

        /// <summary>
        /// Free Setup Mode
        /// </summary>
        /// <value>Free Setup Mode</value>
        [DataMember(Name="freeSetupMode", EmitDefaultValue=true)]
        public bool? FreeSetupMode { get; set; }

        /// <summary>
        /// Check if trial license.
        /// </summary>
        /// <value>Check if trial license.</value>
        [DataMember(Name="isTrial", EmitDefaultValue=true)]
        public bool? IsTrial { get; set; }

        /// <summary>
        /// Holds monthly avg usage values of feature
        /// </summary>
        /// <value>Holds monthly avg usage values of feature</value>
        [DataMember(Name="last12MonthsAvgEntitlement", EmitDefaultValue=true)]
        public Dictionary<string, List<MonthlyEntitlement>> Last12MonthsAvgEntitlement { get; set; }

        /// <summary>
        /// Holds monthly avg usage values of feature
        /// </summary>
        /// <value>Holds monthly avg usage values of feature</value>
        [DataMember(Name="last12MonthsAvgUsage", EmitDefaultValue=true)]
        public Dictionary<string, List<MonthlyUsage>> Last12MonthsAvgUsage { get; set; }

        /// <summary>
        /// Holds daily entitled capacity values of feature
        /// </summary>
        /// <value>Holds daily entitled capacity values of feature</value>
        [DataMember(Name="last30DaysEntitlement", EmitDefaultValue=true)]
        public Dictionary<string, List<DailyEntitlement>> Last30DaysEntitlement { get; set; }

        /// <summary>
        /// Holds daily usage values of feature
        /// </summary>
        /// <value>Holds daily usage values of feature</value>
        [DataMember(Name="last30DaysUsage", EmitDefaultValue=true)]
        public Dictionary<string, List<DailyUsage>> Last30DaysUsage { get; set; }

        /// <summary>
        /// Last time, this report was updated.
        /// </summary>
        /// <value>Last time, this report was updated.</value>
        [DataMember(Name="lastUpdateTime", EmitDefaultValue=true)]
        public long? LastUpdateTime { get; set; }

        /// <summary>
        /// LicenseFeatureUsages holds information about each feature from license orders.
        /// </summary>
        /// <value>LicenseFeatureUsages holds information about each feature from license orders.</value>
        [DataMember(Name="licensedUsage", EmitDefaultValue=true)]
        public List<LicensedUsage> LicensedUsage { get; set; }

        /// <summary>
        /// Trial expiration period.
        /// </summary>
        /// <value>Trial expiration period.</value>
        [DataMember(Name="trialExpiration", EmitDefaultValue=true)]
        public long? TrialExpiration { get; set; }

        /// <summary>
        /// Creating a map of cluster id and feature usage to make it consistent display usage UI for the helios server license page UI.
        /// </summary>
        /// <value>Creating a map of cluster id and feature usage to make it consistent display usage UI for the helios server license page UI.</value>
        [DataMember(Name="usage", EmitDefaultValue=true)]
        public Dictionary<string, List<FeatureUsage>> Usage { get; set; }

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
            return this.Equals(input as LicenseAccountUsageRsp);
        }

        /// <summary>
        /// Returns true if LicenseAccountUsageRsp instances are equal
        /// </summary>
        /// <param name="input">Instance of LicenseAccountUsageRsp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LicenseAccountUsageRsp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FeatureOverusage == input.FeatureOverusage ||
                    this.FeatureOverusage != null &&
                    input.FeatureOverusage != null &&
                    this.FeatureOverusage.SequenceEqual(input.FeatureOverusage)
                ) && 
                (
                    this.FreeSetupMode == input.FreeSetupMode ||
                    (this.FreeSetupMode != null &&
                    this.FreeSetupMode.Equals(input.FreeSetupMode))
                ) && 
                (
                    this.IsTrial == input.IsTrial ||
                    (this.IsTrial != null &&
                    this.IsTrial.Equals(input.IsTrial))
                ) && 
                (
                    this.Last12MonthsAvgEntitlement == input.Last12MonthsAvgEntitlement ||
                    this.Last12MonthsAvgEntitlement != null &&
                    input.Last12MonthsAvgEntitlement != null &&
                    this.Last12MonthsAvgEntitlement.SequenceEqual(input.Last12MonthsAvgEntitlement)
                ) && 
                (
                    this.Last12MonthsAvgUsage == input.Last12MonthsAvgUsage ||
                    this.Last12MonthsAvgUsage != null &&
                    input.Last12MonthsAvgUsage != null &&
                    this.Last12MonthsAvgUsage.SequenceEqual(input.Last12MonthsAvgUsage)
                ) && 
                (
                    this.Last30DaysEntitlement == input.Last30DaysEntitlement ||
                    this.Last30DaysEntitlement != null &&
                    input.Last30DaysEntitlement != null &&
                    this.Last30DaysEntitlement.SequenceEqual(input.Last30DaysEntitlement)
                ) && 
                (
                    this.Last30DaysUsage == input.Last30DaysUsage ||
                    this.Last30DaysUsage != null &&
                    input.Last30DaysUsage != null &&
                    this.Last30DaysUsage.SequenceEqual(input.Last30DaysUsage)
                ) && 
                (
                    this.LastUpdateTime == input.LastUpdateTime ||
                    (this.LastUpdateTime != null &&
                    this.LastUpdateTime.Equals(input.LastUpdateTime))
                ) && 
                (
                    this.LicensedUsage == input.LicensedUsage ||
                    this.LicensedUsage != null &&
                    input.LicensedUsage != null &&
                    this.LicensedUsage.SequenceEqual(input.LicensedUsage)
                ) && 
                (
                    this.TrialExpiration == input.TrialExpiration ||
                    (this.TrialExpiration != null &&
                    this.TrialExpiration.Equals(input.TrialExpiration))
                ) && 
                (
                    this.Usage == input.Usage ||
                    this.Usage != null &&
                    input.Usage != null &&
                    this.Usage.SequenceEqual(input.Usage)
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
                if (this.FeatureOverusage != null)
                    hashCode = hashCode * 59 + this.FeatureOverusage.GetHashCode();
                if (this.FreeSetupMode != null)
                    hashCode = hashCode * 59 + this.FreeSetupMode.GetHashCode();
                if (this.IsTrial != null)
                    hashCode = hashCode * 59 + this.IsTrial.GetHashCode();
                if (this.Last12MonthsAvgEntitlement != null)
                    hashCode = hashCode * 59 + this.Last12MonthsAvgEntitlement.GetHashCode();
                if (this.Last12MonthsAvgUsage != null)
                    hashCode = hashCode * 59 + this.Last12MonthsAvgUsage.GetHashCode();
                if (this.Last30DaysEntitlement != null)
                    hashCode = hashCode * 59 + this.Last30DaysEntitlement.GetHashCode();
                if (this.Last30DaysUsage != null)
                    hashCode = hashCode * 59 + this.Last30DaysUsage.GetHashCode();
                if (this.LastUpdateTime != null)
                    hashCode = hashCode * 59 + this.LastUpdateTime.GetHashCode();
                if (this.LicensedUsage != null)
                    hashCode = hashCode * 59 + this.LicensedUsage.GetHashCode();
                if (this.TrialExpiration != null)
                    hashCode = hashCode * 59 + this.TrialExpiration.GetHashCode();
                if (this.Usage != null)
                    hashCode = hashCode * 59 + this.Usage.GetHashCode();
                return hashCode;
            }
        }

    }

}


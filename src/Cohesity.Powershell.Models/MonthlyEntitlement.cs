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
    /// MonthlyEntitlement
    /// </summary>
    [DataContract]
    public partial class MonthlyEntitlement :  IEquatable<MonthlyEntitlement>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MonthlyEntitlement" /> class.
        /// </summary>
        /// <param name="featureName">featureName.</param>
        /// <param name="monthlyAvgEntitlement">monthlyAvgEntitlement.</param>
        public MonthlyEntitlement(string featureName = default(string), List<long?> monthlyAvgEntitlement = default(List<long?>))
        {
            this.FeatureName = featureName;
            this.MonthlyAvgEntitlement = monthlyAvgEntitlement;
        }
        
        /// <summary>
        /// Gets or Sets FeatureName
        /// </summary>
        [DataMember(Name="featureName", EmitDefaultValue=false)]
        public string FeatureName { get; set; }

        /// <summary>
        /// Gets or Sets MonthlyAvgEntitlement
        /// </summary>
        [DataMember(Name="monthlyAvgEntitlement", EmitDefaultValue=false)]
        public List<long?> MonthlyAvgEntitlement { get; set; }

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
            return this.Equals(input as MonthlyEntitlement);
        }

        /// <summary>
        /// Returns true if MonthlyEntitlement instances are equal
        /// </summary>
        /// <param name="input">Instance of MonthlyEntitlement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MonthlyEntitlement input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FeatureName == input.FeatureName ||
                    (this.FeatureName != null &&
                    this.FeatureName.Equals(input.FeatureName))
                ) && 
                (
                    this.MonthlyAvgEntitlement == input.MonthlyAvgEntitlement ||
                    this.MonthlyAvgEntitlement != null &&
                    this.MonthlyAvgEntitlement.Equals(input.MonthlyAvgEntitlement)
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
                if (this.FeatureName != null)
                    hashCode = hashCode * 59 + this.FeatureName.GetHashCode();
                if (this.MonthlyAvgEntitlement != null)
                    hashCode = hashCode * 59 + this.MonthlyAvgEntitlement.GetHashCode();
                return hashCode;
            }
        }

    }

}


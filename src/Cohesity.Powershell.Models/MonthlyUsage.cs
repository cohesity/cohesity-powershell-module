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
    /// MonthlyUsage
    /// </summary>
    [DataContract]
    public partial class MonthlyUsage :  IEquatable<MonthlyUsage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MonthlyUsage" /> class.
        /// </summary>
        /// <param name="featureName">featureName.</param>
        /// <param name="monthlyAvgUsage">monthlyAvgUsage.</param>
        public MonthlyUsage(string featureName = default(string), List<long> monthlyAvgUsage = default(List<long>))
        {
            this.FeatureName = featureName;
            this.MonthlyAvgUsage = monthlyAvgUsage;
            this.FeatureName = featureName;
            this.MonthlyAvgUsage = monthlyAvgUsage;
        }
        
        /// <summary>
        /// Gets or Sets FeatureName
        /// </summary>
        [DataMember(Name="featureName", EmitDefaultValue=true)]
        public string FeatureName { get; set; }

        /// <summary>
        /// Gets or Sets MonthlyAvgUsage
        /// </summary>
        [DataMember(Name="monthlyAvgUsage", EmitDefaultValue=true)]
        public List<long> MonthlyAvgUsage { get; set; }

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
            return this.Equals(input as MonthlyUsage);
        }

        /// <summary>
        /// Returns true if MonthlyUsage instances are equal
        /// </summary>
        /// <param name="input">Instance of MonthlyUsage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MonthlyUsage input)
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
                    this.MonthlyAvgUsage == input.MonthlyAvgUsage ||
                    this.MonthlyAvgUsage != null &&
                    input.MonthlyAvgUsage != null &&
                    this.MonthlyAvgUsage.Equals(input.MonthlyAvgUsage)
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
                if (this.MonthlyAvgUsage != null)
                    hashCode = hashCode * 59 + this.MonthlyAvgUsage.GetHashCode();
                return hashCode;
            }
        }

    }

}


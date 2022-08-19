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
    /// DailyUsage
    /// </summary>
    [DataContract]
    public partial class DailyUsage :  IEquatable<DailyUsage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DailyUsage" /> class.
        /// </summary>
        /// <param name="dailyUsage">dailyUsage.</param>
        /// <param name="featureName">featureName.</param>
        public DailyUsage(List<long> dailyUsage = default(List<long>), string featureName = default(string))
        {
            this._DailyUsage = dailyUsage;
            this.FeatureName = featureName;
            this._DailyUsage = dailyUsage;
            this.FeatureName = featureName;
        }
        
        /// <summary>
        /// Gets or Sets _DailyUsage
        /// </summary>
        [DataMember(Name="dailyUsage", EmitDefaultValue=true)]
        public List<long> _DailyUsage { get; set; }

        /// <summary>
        /// Gets or Sets FeatureName
        /// </summary>
        [DataMember(Name="featureName", EmitDefaultValue=true)]
        public string FeatureName { get; set; }

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
            return this.Equals(input as DailyUsage);
        }

        /// <summary>
        /// Returns true if DailyUsage instances are equal
        /// </summary>
        /// <param name="input">Instance of DailyUsage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DailyUsage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._DailyUsage == input._DailyUsage ||
                    this._DailyUsage != null &&
                    input._DailyUsage != null &&
                    this._DailyUsage.Equals(input._DailyUsage)
                ) && 
                (
                    this.FeatureName == input.FeatureName ||
                    (this.FeatureName != null &&
                    this.FeatureName.Equals(input.FeatureName))
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
                if (this._DailyUsage != null)
                    hashCode = hashCode * 59 + this._DailyUsage.GetHashCode();
                if (this.FeatureName != null)
                    hashCode = hashCode * 59 + this.FeatureName.GetHashCode();
                return hashCode;
            }
        }

    }

}


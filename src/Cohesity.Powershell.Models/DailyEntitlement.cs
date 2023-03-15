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
    /// DailyEntitlement
    /// </summary>
    [DataContract]
    public partial class DailyEntitlement :  IEquatable<DailyEntitlement>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DailyEntitlement" /> class.
        /// </summary>
        /// <param name="dailyEntitlement">dailyEntitlement.</param>
        /// <param name="featureName">featureName.</param>
        public DailyEntitlement(List<long> dailyEntitlement = default(List<long>), string featureName = default(string))
        {
            this._DailyEntitlement = dailyEntitlement;
            this.FeatureName = featureName;
            this._DailyEntitlement = dailyEntitlement;
            this.FeatureName = featureName;
        }
        
        /// <summary>
        /// Gets or Sets _DailyEntitlement
        /// </summary>
        [DataMember(Name="dailyEntitlement", EmitDefaultValue=true)]
        public List<long> _DailyEntitlement { get; set; }

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
            return this.Equals(input as DailyEntitlement);
        }

        /// <summary>
        /// Returns true if DailyEntitlement instances are equal
        /// </summary>
        /// <param name="input">Instance of DailyEntitlement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DailyEntitlement input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._DailyEntitlement == input._DailyEntitlement ||
                    this._DailyEntitlement != null &&
                    input._DailyEntitlement != null &&
                    this._DailyEntitlement.SequenceEqual(input._DailyEntitlement)
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
                if (this._DailyEntitlement != null)
                    hashCode = hashCode * 59 + this._DailyEntitlement.GetHashCode();
                if (this.FeatureName != null)
                    hashCode = hashCode * 59 + this.FeatureName.GetHashCode();
                return hashCode;
            }
        }

    }

}


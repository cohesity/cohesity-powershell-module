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
    /// SchedulingPolicyProtoYearlySchedule
    /// </summary>
    [DataContract]
    public partial class SchedulingPolicyProtoYearlySchedule :  IEquatable<SchedulingPolicyProtoYearlySchedule>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulingPolicyProtoYearlySchedule" /> class.
        /// </summary>
        /// <param name="dayOfTheYear">Count of the day on which to perform the backup (look above for a more detailed description)..</param>
        public SchedulingPolicyProtoYearlySchedule(int? dayOfTheYear = default(int?))
        {
            this.DayOfTheYear = dayOfTheYear;
            this.DayOfTheYear = dayOfTheYear;
        }
        
        /// <summary>
        /// Count of the day on which to perform the backup (look above for a more detailed description).
        /// </summary>
        /// <value>Count of the day on which to perform the backup (look above for a more detailed description).</value>
        [DataMember(Name="dayOfTheYear", EmitDefaultValue=true)]
        public int? DayOfTheYear { get; set; }

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
            return this.Equals(input as SchedulingPolicyProtoYearlySchedule);
        }

        /// <summary>
        /// Returns true if SchedulingPolicyProtoYearlySchedule instances are equal
        /// </summary>
        /// <param name="input">Instance of SchedulingPolicyProtoYearlySchedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchedulingPolicyProtoYearlySchedule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DayOfTheYear == input.DayOfTheYear ||
                    (this.DayOfTheYear != null &&
                    this.DayOfTheYear.Equals(input.DayOfTheYear))
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
                if (this.DayOfTheYear != null)
                    hashCode = hashCode * 59 + this.DayOfTheYear.GetHashCode();
                return hashCode;
            }
        }

    }

}


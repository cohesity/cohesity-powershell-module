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
    /// Specifies settings that define a schedule for a Protection Group to run on specific year and specific day of that year.
    /// </summary>
    [DataContract]
    public partial class YearlySchedule :  IEquatable<YearlySchedule>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="YearlySchedule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected YearlySchedule() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="YearlySchedule" /> class.
        /// </summary>
        /// <param name="dayOfTheYear">Specifies the day of the Year (such as &#39;kFirst&#39;) in a Yearly Schedule to start the Job Run. Enum: [kFirst kLast] (required).</param>
        public YearlySchedule(int? dayOfTheYear = default(int?))
        {
            this.DayOfTheYear = dayOfTheYear;
        }
        
        /// <summary>
        /// Specifies the day of the Year (such as &#39;kFirst&#39;) in a Yearly Schedule to start the Job Run. Enum: [kFirst kLast]
        /// </summary>
        /// <value>Specifies the day of the Year (such as &#39;kFirst&#39;) in a Yearly Schedule to start the Job Run. Enum: [kFirst kLast]</value>
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
            return this.Equals(input as YearlySchedule);
        }

        /// <summary>
        /// Returns true if YearlySchedule instances are equal
        /// </summary>
        /// <param name="input">Instance of YearlySchedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(YearlySchedule input)
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


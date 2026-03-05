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
    /// MonthDay
    /// </summary>
    [DataContract]
    public partial class MonthDay :  IEquatable<MonthDay>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MonthDay" /> class.
        /// </summary>
        /// <param name="dayOfTheMonth">Indicates day of the month..</param>
        /// <param name="month">Indicates month for specific date..</param>
        public MonthDay(int? dayOfTheMonth = default(int?), int? month = default(int?))
        {
            this.DayOfTheMonth = dayOfTheMonth;
            this.Month = month;
            this.DayOfTheMonth = dayOfTheMonth;
            this.Month = month;
        }
        
        /// <summary>
        /// Indicates day of the month.
        /// </summary>
        /// <value>Indicates day of the month.</value>
        [DataMember(Name="dayOfTheMonth", EmitDefaultValue=true)]
        public int? DayOfTheMonth { get; set; }

        /// <summary>
        /// Indicates month for specific date.
        /// </summary>
        /// <value>Indicates month for specific date.</value>
        [DataMember(Name="month", EmitDefaultValue=true)]
        public int? Month { get; set; }

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
            return this.Equals(input as MonthDay);
        }

        /// <summary>
        /// Returns true if MonthDay instances are equal
        /// </summary>
        /// <param name="input">Instance of MonthDay to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MonthDay input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DayOfTheMonth == input.DayOfTheMonth ||
                    (this.DayOfTheMonth != null &&
                    this.DayOfTheMonth.Equals(input.DayOfTheMonth))
                ) && 
                (
                    this.Month == input.Month ||
                    (this.Month != null &&
                    this.Month.Equals(input.Month))
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
                if (this.DayOfTheMonth != null)
                    hashCode = hashCode * 59 + this.DayOfTheMonth.GetHashCode();
                if (this.Month != null)
                    hashCode = hashCode * 59 + this.Month.GetHashCode();
                return hashCode;
            }
        }

    }

}


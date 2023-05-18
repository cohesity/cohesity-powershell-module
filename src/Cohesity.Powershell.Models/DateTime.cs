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
    /// DateTime
    /// </summary>
    [DataContract]
    public partial class DateTime :  IEquatable<DateTime>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DateTime" /> class.
        /// </summary>
        /// <param name="dayOfTheMonth">Indicates day of the month..</param>
        /// <param name="month">Indicates month for specific date..</param>
        /// <param name="time">time.</param>
        /// <param name="year">Indicates year for specific date..</param>
        public DateTime(int? dayOfTheMonth = default(int?), int? month = default(int?), Time time = default(Time), int? year = default(int?))
        {
            this.DayOfTheMonth = dayOfTheMonth;
            this.Month = month;
            this.Year = year;
            this.DayOfTheMonth = dayOfTheMonth;
            this.Month = month;
            this.Time = time;
            this.Year = year;
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
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public Time Time { get; set; }

        /// <summary>
        /// Indicates year for specific date.
        /// </summary>
        /// <value>Indicates year for specific date.</value>
        [DataMember(Name="year", EmitDefaultValue=true)]
        public int? Year { get; set; }

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
            return this.Equals(input as DateTime);
        }

        /// <summary>
        /// Returns true if DateTime instances are equal
        /// </summary>
        /// <param name="input">Instance of DateTime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DateTime input)
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
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.Year == input.Year ||
                    (this.Year != null &&
                    this.Year.Equals(input.Year))
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
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Year != null)
                    hashCode = hashCode * 59 + this.Year.GetHashCode();
                return hashCode;
            }
        }

    }

}


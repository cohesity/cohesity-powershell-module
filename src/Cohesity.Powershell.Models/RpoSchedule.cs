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
    /// Specifies an RPO Schedule.
    /// </summary>
    [DataContract]
    public partial class RpoSchedule :  IEquatable<RpoSchedule>
    {
        /// <summary>
        /// Specifies an RPO policy interval unit which will be used along with the multiplier to calculate the interval for the RPO policy execution. this can be kHours, kDays, KWeeks, kMonths RPOIntervalUnit.  Specifies an RPO Schedule interval unit. kMinutes specifies that the rpo interval unit is hours. kHours specifies that the rpo interval unit is hours. kDays specifies that the rpo interval unit is days. kWeeks specifies that the rpo interval unit is weeks. kMonths specifies that the rpo interval unit is months.
        /// </summary>
        /// <value>Specifies an RPO policy interval unit which will be used along with the multiplier to calculate the interval for the RPO policy execution. this can be kHours, kDays, KWeeks, kMonths RPOIntervalUnit.  Specifies an RPO Schedule interval unit. kMinutes specifies that the rpo interval unit is hours. kHours specifies that the rpo interval unit is hours. kDays specifies that the rpo interval unit is days. kWeeks specifies that the rpo interval unit is weeks. kMonths specifies that the rpo interval unit is months.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IntervalUnitEnum
        {
            /// <summary>
            /// Enum KMinutes for value: kMinutes
            /// </summary>
            [EnumMember(Value = "kMinutes")]
            KMinutes = 1,

            /// <summary>
            /// Enum KHours for value: kHours
            /// </summary>
            [EnumMember(Value = "kHours")]
            KHours = 2,

            /// <summary>
            /// Enum KDays for value: kDays
            /// </summary>
            [EnumMember(Value = "kDays")]
            KDays = 3,

            /// <summary>
            /// Enum KWeeks for value: kWeeks
            /// </summary>
            [EnumMember(Value = "kWeeks")]
            KWeeks = 4,

            /// <summary>
            /// Enum KMonths for value: kMonths
            /// </summary>
            [EnumMember(Value = "kMonths")]
            KMonths = 5

        }

        /// <summary>
        /// Specifies an RPO policy interval unit which will be used along with the multiplier to calculate the interval for the RPO policy execution. this can be kHours, kDays, KWeeks, kMonths RPOIntervalUnit.  Specifies an RPO Schedule interval unit. kMinutes specifies that the rpo interval unit is hours. kHours specifies that the rpo interval unit is hours. kDays specifies that the rpo interval unit is days. kWeeks specifies that the rpo interval unit is weeks. kMonths specifies that the rpo interval unit is months.
        /// </summary>
        /// <value>Specifies an RPO policy interval unit which will be used along with the multiplier to calculate the interval for the RPO policy execution. this can be kHours, kDays, KWeeks, kMonths RPOIntervalUnit.  Specifies an RPO Schedule interval unit. kMinutes specifies that the rpo interval unit is hours. kHours specifies that the rpo interval unit is hours. kDays specifies that the rpo interval unit is days. kWeeks specifies that the rpo interval unit is weeks. kMonths specifies that the rpo interval unit is months.</value>
        [DataMember(Name="intervalUnit", EmitDefaultValue=true)]
        public IntervalUnitEnum? IntervalUnit { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RpoSchedule" /> class.
        /// </summary>
        /// <param name="intervalUnit">Specifies an RPO policy interval unit which will be used along with the multiplier to calculate the interval for the RPO policy execution. this can be kHours, kDays, KWeeks, kMonths RPOIntervalUnit.  Specifies an RPO Schedule interval unit. kMinutes specifies that the rpo interval unit is hours. kHours specifies that the rpo interval unit is hours. kDays specifies that the rpo interval unit is days. kWeeks specifies that the rpo interval unit is weeks. kMonths specifies that the rpo interval unit is months..</param>
        /// <param name="multiplier">Specifies the multiplier value to be used with the  RPO interval unit value..</param>
        public RpoSchedule(IntervalUnitEnum? intervalUnit = default(IntervalUnitEnum?), long? multiplier = default(long?))
        {
            this.IntervalUnit = intervalUnit;
            this.Multiplier = multiplier;
            this.IntervalUnit = intervalUnit;
            this.Multiplier = multiplier;
        }
        
        /// <summary>
        /// Specifies the multiplier value to be used with the  RPO interval unit value.
        /// </summary>
        /// <value>Specifies the multiplier value to be used with the  RPO interval unit value.</value>
        [DataMember(Name="multiplier", EmitDefaultValue=true)]
        public long? Multiplier { get; set; }

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
            return this.Equals(input as RpoSchedule);
        }

        /// <summary>
        /// Returns true if RpoSchedule instances are equal
        /// </summary>
        /// <param name="input">Instance of RpoSchedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RpoSchedule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IntervalUnit == input.IntervalUnit ||
                    this.IntervalUnit.Equals(input.IntervalUnit)
                ) && 
                (
                    this.Multiplier == input.Multiplier ||
                    (this.Multiplier != null &&
                    this.Multiplier.Equals(input.Multiplier))
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
                hashCode = hashCode * 59 + this.IntervalUnit.GetHashCode();
                if (this.Multiplier != null)
                    hashCode = hashCode * 59 + this.Multiplier.GetHashCode();
                return hashCode;
            }
        }

    }

}


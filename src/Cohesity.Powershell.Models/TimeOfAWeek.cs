// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// Specifies a time period by specifying a single daily time period and one or more days of the week, for example 9 AM - 5 PM on Monday, Wednesday or Friday. If different time periods are required on different days, then multiple instances of this Weekly Time Period must be specified.
    /// </summary>
    [DataContract]
    public partial class TimeOfAWeek :  IEquatable<TimeOfAWeek>
    {
        /// <summary>
        /// Defines Days
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DaysEnum
        {
            
            /// <summary>
            /// Enum KSunday for value: kSunday
            /// </summary>
            [EnumMember(Value = "kSunday")]
            KSunday = 1,
            
            /// <summary>
            /// Enum KMonday for value: kMonday
            /// </summary>
            [EnumMember(Value = "kMonday")]
            KMonday = 2,
            
            /// <summary>
            /// Enum KTuesday for value: kTuesday
            /// </summary>
            [EnumMember(Value = "kTuesday")]
            KTuesday = 3,
            
            /// <summary>
            /// Enum KWednesday for value: kWednesday
            /// </summary>
            [EnumMember(Value = "kWednesday")]
            KWednesday = 4,
            
            /// <summary>
            /// Enum KThursday for value: kThursday
            /// </summary>
            [EnumMember(Value = "kThursday")]
            KThursday = 5,
            
            /// <summary>
            /// Enum KFriday for value: kFriday
            /// </summary>
            [EnumMember(Value = "kFriday")]
            KFriday = 6,
            
            /// <summary>
            /// Enum KSaturday for value: kSaturday
            /// </summary>
            [EnumMember(Value = "kSaturday")]
            KSaturday = 7
        }


        /// <summary>
        /// Specifies a list of days of a week (such as &#39;kSunday&#39;) when the time period should be applied. If not set, the time range applies to all days of the week. Specifies a day in a week such as &#39;kSunday&#39;, &#39;kMonday&#39;, etc.
        /// </summary>
        /// <value>Specifies a list of days of a week (such as &#39;kSunday&#39;) when the time period should be applied. If not set, the time range applies to all days of the week. Specifies a day in a week such as &#39;kSunday&#39;, &#39;kMonday&#39;, etc.</value>
        [DataMember(Name="days", EmitDefaultValue=false)]
        public List<DaysEnum> Days { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeOfAWeek" /> class.
        /// </summary>
        /// <param name="days">Specifies a list of days of a week (such as &#39;kSunday&#39;) when the time period should be applied. If not set, the time range applies to all days of the week. Specifies a day in a week such as &#39;kSunday&#39;, &#39;kMonday&#39;, etc..</param>
        /// <param name="endTime">endTime.</param>
        /// <param name="startTime">startTime.</param>
        public TimeOfAWeek(List<DaysEnum> days = default(List<DaysEnum>), EndTime_ endTime = default(EndTime_), StartTime_ startTime = default(StartTime_))
        {
            this.Days = days;
            this.EndTime = endTime;
            this.StartTime = startTime;
        }
        

        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public EndTime_ EndTime { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public StartTime_ StartTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }
  
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
            return this.Equals(input as TimeOfAWeek);
        }

        /// <summary>
        /// Returns true if TimeOfAWeek instances are equal
        /// </summary>
        /// <param name="input">Instance of TimeOfAWeek to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeOfAWeek input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Days == input.Days ||
                    this.Days != null &&
                    this.Days.SequenceEqual(input.Days)
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
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
                if (this.Days != null)
                    hashCode = hashCode * 59 + this.Days.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


// Copyright 2018 Cohesity Inc.

using System;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cohesity.Models
{
    /// <summary>
    /// Specifies a time range in a single day when new Job Runs of Protection Jobs cannot be started. For example, a Protection Job with a daily schedule could define a blackout period for Sunday.
    /// </summary>
    [DataContract]
    public partial class BlackoutPeriod :  IEquatable<BlackoutPeriod>
    {
        /// <summary>
        /// Blackout Day.  Specifies a day in the week when no new Job Runs should be started such as &#39;kSunday&#39;. If not set, the time range applies to all days. Specifies a day in a week such as &#39;kSunday&#39;, &#39;kMonday&#39;, etc.
        /// </summary>
        /// <value>Blackout Day.  Specifies a day in the week when no new Job Runs should be started such as &#39;kSunday&#39;. If not set, the time range applies to all days. Specifies a day in a week such as &#39;kSunday&#39;, &#39;kMonday&#39;, etc.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DayEnum
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
        /// Blackout Day.  Specifies a day in the week when no new Job Runs should be started such as &#39;kSunday&#39;. If not set, the time range applies to all days. Specifies a day in a week such as &#39;kSunday&#39;, &#39;kMonday&#39;, etc.
        /// </summary>
        /// <value>Blackout Day.  Specifies a day in the week when no new Job Runs should be started such as &#39;kSunday&#39;. If not set, the time range applies to all days. Specifies a day in a week such as &#39;kSunday&#39;, &#39;kMonday&#39;, etc.</value>
        [DataMember(Name="day", EmitDefaultValue=false)]
        public DayEnum? Day { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BlackoutPeriod" /> class.
        /// </summary>
        /// <param name="day">Blackout Day.  Specifies a day in the week when no new Job Runs should be started such as &#39;kSunday&#39;. If not set, the time range applies to all days. Specifies a day in a week such as &#39;kSunday&#39;, &#39;kMonday&#39;, etc..</param>
        /// <param name="endTime">endTime.</param>
        /// <param name="startTime">startTime.</param>
        public BlackoutPeriod(DayEnum? day = default(DayEnum?), BlackoutEndTime_ endTime = default(BlackoutEndTime_), BlackoutStartTime_ startTime = default(BlackoutStartTime_))
        {
            this.Day = day;
            this.EndTime = endTime;
            this.StartTime = startTime;
        }
        

        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public BlackoutEndTime_ EndTime { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public BlackoutStartTime_ StartTime { get; set; }

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
            return this.Equals(input as BlackoutPeriod);
        }

        /// <summary>
        /// Returns true if BlackoutPeriod instances are equal
        /// </summary>
        /// <param name="input">Instance of BlackoutPeriod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BlackoutPeriod input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Day == input.Day ||
                    (this.Day != null &&
                    this.Day.Equals(input.Day))
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
                if (this.Day != null)
                    hashCode = hashCode * 59 + this.Day.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


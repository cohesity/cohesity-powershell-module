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
    /// Specifies a time range in a single day when new Job Runs of Protection Jobs cannot be started. For example, a Protection Job with a daily schedule could define a QuietTime period for Sunday.
    /// </summary>
    [DataContract]
    public partial class BlackoutPeriod :  IEquatable<BlackoutPeriod>
    {
        /// <summary>
        /// QuietTime Day.  Specifies a day in the week when no new Job Runs should be started such as &#39;kSunday&#39;. If not set, the time range applies to all days. Specifies a day in a week such as &#39;kSunday&#39;, &#39;kMonday&#39;, etc.
        /// </summary>
        /// <value>QuietTime Day.  Specifies a day in the week when no new Job Runs should be started such as &#39;kSunday&#39;. If not set, the time range applies to all days. Specifies a day in a week such as &#39;kSunday&#39;, &#39;kMonday&#39;, etc.</value>
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
        /// QuietTime Day.  Specifies a day in the week when no new Job Runs should be started such as &#39;kSunday&#39;. If not set, the time range applies to all days. Specifies a day in a week such as &#39;kSunday&#39;, &#39;kMonday&#39;, etc.
        /// </summary>
        /// <value>QuietTime Day.  Specifies a day in the week when no new Job Runs should be started such as &#39;kSunday&#39;. If not set, the time range applies to all days. Specifies a day in a week such as &#39;kSunday&#39;, &#39;kMonday&#39;, etc.</value>
        [DataMember(Name="day", EmitDefaultValue=true)]
        public DayEnum? Day { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BlackoutPeriod" /> class.
        /// </summary>
        /// <param name="id">Specified the Id for a snapshot copy policy. This is generated when the policy is created..</param>
        /// <param name="day">QuietTime Day.  Specifies a day in the week when no new Job Runs should be started such as &#39;kSunday&#39;. If not set, the time range applies to all days. Specifies a day in a week such as &#39;kSunday&#39;, &#39;kMonday&#39;, etc..</param>
        /// <param name="endTime">Specifies the end time of the QuietTime time range..</param>
        /// <param name="startTime">Specifies the start time of the QuietTime time range..</param>
        public BlackoutPeriod(string id = default(string), DayEnum? day = default(DayEnum?), TimeOfDay endTime = default(TimeOfDay), TimeOfDay startTime = default(TimeOfDay))
        {
            this.Id = id;
            this.Day = day;
            this.EndTime = endTime;
            this.StartTime = startTime;
            this.Id = id;
            this.Day = day;
            this.EndTime = endTime;
            this.StartTime = startTime;
        }
        
        /// <summary>
        /// Specified the Id for a snapshot copy policy. This is generated when the policy is created.
        /// </summary>
        /// <value>Specified the Id for a snapshot copy policy. This is generated when the policy is created.</value>
        [DataMember(Name="Id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Specifies the end time of the QuietTime time range.
        /// </summary>
        /// <value>Specifies the end time of the QuietTime time range.</value>
        [DataMember(Name="endTime", EmitDefaultValue=true)]
        public TimeOfDay EndTime { get; set; }

        /// <summary>
        /// Specifies the start time of the QuietTime time range.
        /// </summary>
        /// <value>Specifies the start time of the QuietTime time range.</value>
        [DataMember(Name="startTime", EmitDefaultValue=true)]
        public TimeOfDay StartTime { get; set; }

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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Day == input.Day ||
                    this.Day.Equals(input.Day)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
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


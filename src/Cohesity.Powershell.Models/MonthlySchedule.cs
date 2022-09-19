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
    /// Specifies a monthly backup schedule by specifying a day in the week and a week in the month. For example, if day is set to &#39;kMonday&#39; and dayCount is set to &#39;kThird&#39;, a Job Run is started on the third Monday of every month.
    /// </summary>
    [DataContract]
    public partial class MonthlySchedule :  IEquatable<MonthlySchedule>
    {
        /// <summary>
        /// Specifies the day of the week (such as &#39;kMonday&#39;) to start the Job Run. Used with day count to define the day in the month to start the Job Run. Specifies a day in a week such as &#39;kSunday&#39;, &#39;kMonday&#39;, etc.
        /// </summary>
        /// <value>Specifies the day of the week (such as &#39;kMonday&#39;) to start the Job Run. Used with day count to define the day in the month to start the Job Run. Specifies a day in a week such as &#39;kSunday&#39;, &#39;kMonday&#39;, etc.</value>
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
        /// Specifies the day of the week (such as &#39;kMonday&#39;) to start the Job Run. Used with day count to define the day in the month to start the Job Run. Specifies a day in a week such as &#39;kSunday&#39;, &#39;kMonday&#39;, etc.
        /// </summary>
        /// <value>Specifies the day of the week (such as &#39;kMonday&#39;) to start the Job Run. Used with day count to define the day in the month to start the Job Run. Specifies a day in a week such as &#39;kSunday&#39;, &#39;kMonday&#39;, etc.</value>
        [DataMember(Name="day", EmitDefaultValue=true)]
        public DayEnum? Day { get; set; }
        /// <summary>
        /// Specifies the day count in the month (such as &#39;kThird&#39;) to start the Job Run. Used in combination with day to define the day in the month to start the Job Run. Specifies the day count in the month to start the backup. For example if day count is set to &#39;kThird&#39; and day is set to &#39;kMonday&#39;, a backup is performed on the third Monday of every month. &#39;kFirst&#39; indicates that the first week should be chosen for specified day of every month. &#39;kSecond&#39; indicates that the second week should be chosen for specified day of every month. &#39;kThird&#39; indicates that the third week should be chosen for specified day of every month. &#39;kFourth&#39; indicates that the fourth week should be chosen for specified day of every month. &#39;kLast&#39; indicates that the last week should be chosen for specified day of every month.
        /// </summary>
        /// <value>Specifies the day count in the month (such as &#39;kThird&#39;) to start the Job Run. Used in combination with day to define the day in the month to start the Job Run. Specifies the day count in the month to start the backup. For example if day count is set to &#39;kThird&#39; and day is set to &#39;kMonday&#39;, a backup is performed on the third Monday of every month. &#39;kFirst&#39; indicates that the first week should be chosen for specified day of every month. &#39;kSecond&#39; indicates that the second week should be chosen for specified day of every month. &#39;kThird&#39; indicates that the third week should be chosen for specified day of every month. &#39;kFourth&#39; indicates that the fourth week should be chosen for specified day of every month. &#39;kLast&#39; indicates that the last week should be chosen for specified day of every month.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DayCountEnum
        {
            /// <summary>
            /// Enum KFirst for value: kFirst
            /// </summary>
            [EnumMember(Value = "kFirst")]
            KFirst = 1,

            /// <summary>
            /// Enum KSecond for value: kSecond
            /// </summary>
            [EnumMember(Value = "kSecond")]
            KSecond = 2,

            /// <summary>
            /// Enum KThird for value: kThird
            /// </summary>
            [EnumMember(Value = "kThird")]
            KThird = 3,

            /// <summary>
            /// Enum KFourth for value: kFourth
            /// </summary>
            [EnumMember(Value = "kFourth")]
            KFourth = 4,

            /// <summary>
            /// Enum KLast for value: kLast
            /// </summary>
            [EnumMember(Value = "kLast")]
            KLast = 5

        }

        /// <summary>
        /// Specifies the day count in the month (such as &#39;kThird&#39;) to start the Job Run. Used in combination with day to define the day in the month to start the Job Run. Specifies the day count in the month to start the backup. For example if day count is set to &#39;kThird&#39; and day is set to &#39;kMonday&#39;, a backup is performed on the third Monday of every month. &#39;kFirst&#39; indicates that the first week should be chosen for specified day of every month. &#39;kSecond&#39; indicates that the second week should be chosen for specified day of every month. &#39;kThird&#39; indicates that the third week should be chosen for specified day of every month. &#39;kFourth&#39; indicates that the fourth week should be chosen for specified day of every month. &#39;kLast&#39; indicates that the last week should be chosen for specified day of every month.
        /// </summary>
        /// <value>Specifies the day count in the month (such as &#39;kThird&#39;) to start the Job Run. Used in combination with day to define the day in the month to start the Job Run. Specifies the day count in the month to start the backup. For example if day count is set to &#39;kThird&#39; and day is set to &#39;kMonday&#39;, a backup is performed on the third Monday of every month. &#39;kFirst&#39; indicates that the first week should be chosen for specified day of every month. &#39;kSecond&#39; indicates that the second week should be chosen for specified day of every month. &#39;kThird&#39; indicates that the third week should be chosen for specified day of every month. &#39;kFourth&#39; indicates that the fourth week should be chosen for specified day of every month. &#39;kLast&#39; indicates that the last week should be chosen for specified day of every month.</value>
        [DataMember(Name="dayCount", EmitDefaultValue=true)]
        public DayCountEnum? DayCount { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MonthlySchedule" /> class.
        /// </summary>
        /// <param name="day">Specifies the day of the week (such as &#39;kMonday&#39;) to start the Job Run. Used with day count to define the day in the month to start the Job Run. Specifies a day in a week such as &#39;kSunday&#39;, &#39;kMonday&#39;, etc..</param>
        /// <param name="dayCount">Specifies the day count in the month (such as &#39;kThird&#39;) to start the Job Run. Used in combination with day to define the day in the month to start the Job Run. Specifies the day count in the month to start the backup. For example if day count is set to &#39;kThird&#39; and day is set to &#39;kMonday&#39;, a backup is performed on the third Monday of every month. &#39;kFirst&#39; indicates that the first week should be chosen for specified day of every month. &#39;kSecond&#39; indicates that the second week should be chosen for specified day of every month. &#39;kThird&#39; indicates that the third week should be chosen for specified day of every month. &#39;kFourth&#39; indicates that the fourth week should be chosen for specified day of every month. &#39;kLast&#39; indicates that the last week should be chosen for specified day of every month..</param>
        public MonthlySchedule(DayEnum? day = default(DayEnum?), DayCountEnum? dayCount = default(DayCountEnum?))
        {
            this.Day = day;
            this.DayCount = dayCount;
            this.Day = day;
            this.DayCount = dayCount;
        }
        
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
            return this.Equals(input as MonthlySchedule);
        }

        /// <summary>
        /// Returns true if MonthlySchedule instances are equal
        /// </summary>
        /// <param name="input">Instance of MonthlySchedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MonthlySchedule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Day == input.Day ||
                    this.Day.Equals(input.Day)
                ) && 
                (
                    this.DayCount == input.DayCount ||
                    this.DayCount.Equals(input.DayCount)
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
                hashCode = hashCode * 59 + this.Day.GetHashCode();
                hashCode = hashCode * 59 + this.DayCount.GetHashCode();
                return hashCode;
            }
        }

    }

}


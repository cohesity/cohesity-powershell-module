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
    /// Specifies a daily or weekly backup schedule. Set if periodicity is kDaily.
    /// </summary>
    [DataContract]
    public partial class DailyWeeklySchedule_ :  IEquatable<DailyWeeklySchedule_>
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
        /// Specifies a list of days of the week when to start Job Runs. If no days are specified, the Jobs Runs will run every day of the week. Specifies a day in a week such as &#39;kSunday&#39;, &#39;kMonday&#39;, etc.
        /// </summary>
        /// <value>Specifies a list of days of the week when to start Job Runs. If no days are specified, the Jobs Runs will run every day of the week. Specifies a day in a week such as &#39;kSunday&#39;, &#39;kMonday&#39;, etc.</value>
        [DataMember(Name="days", EmitDefaultValue=false)]
        public List<DaysEnum> Days { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DailyWeeklySchedule_" /> class.
        /// </summary>
        /// <param name="days">Specifies a list of days of the week when to start Job Runs. If no days are specified, the Jobs Runs will run every day of the week. Specifies a day in a week such as &#39;kSunday&#39;, &#39;kMonday&#39;, etc..</param>
        public DailyWeeklySchedule_(List<DaysEnum> days = default(List<DaysEnum>))
        {
            this.Days = days;
        }
        

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
            return this.Equals(input as DailyWeeklySchedule_);
        }

        /// <summary>
        /// Returns true if DailyWeeklySchedule_ instances are equal
        /// </summary>
        /// <param name="input">Instance of DailyWeeklySchedule_ to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DailyWeeklySchedule_ input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Days == input.Days ||
                    this.Days != null &&
                    this.Days.SequenceEqual(input.Days)
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
                return hashCode;
            }
        }

        
    }

}


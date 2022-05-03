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
    /// Sample protos: Every n days (n &gt;&#x3D; 1) Ex: For every 2 days, { frequency : 2 } Weekly schedule (Few selected weekdays) Ex: For every Monday, Tuesday { days : {kMonday, kTuesday} } NOTE: Only one of the &#39;days&#39; and &#39;frequency&#39; should be populated.
    /// </summary>
    [DataContract]
    public partial class SchedulingPolicyProtoDailySchedule :  IEquatable<SchedulingPolicyProtoDailySchedule>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulingPolicyProtoDailySchedule" /> class.
        /// </summary>
        /// <param name="days">The list of weekdays for scheduling a backup. This is populated only for selected weekday schedules..</param>
        /// <param name="frequency">This is set only for every-n-day schedules..</param>
        public SchedulingPolicyProtoDailySchedule(List<int?> days = default(List<int?>), long? frequency = default(long?))
        {
            this.Days = days;
            this.Frequency = frequency;
        }
        
        /// <summary>
        /// The list of weekdays for scheduling a backup. This is populated only for selected weekday schedules.
        /// </summary>
        /// <value>The list of weekdays for scheduling a backup. This is populated only for selected weekday schedules.</value>
        [DataMember(Name="days", EmitDefaultValue=false)]
        public List<int?> Days { get; set; }

        /// <summary>
        /// This is set only for every-n-day schedules.
        /// </summary>
        /// <value>This is set only for every-n-day schedules.</value>
        [DataMember(Name="frequency", EmitDefaultValue=false)]
        public long? Frequency { get; set; }

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
            return this.Equals(input as SchedulingPolicyProtoDailySchedule);
        }

        /// <summary>
        /// Returns true if SchedulingPolicyProtoDailySchedule instances are equal
        /// </summary>
        /// <param name="input">Instance of SchedulingPolicyProtoDailySchedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchedulingPolicyProtoDailySchedule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Days == input.Days ||
                    this.Days != null &&
                    this.Days.Equals(input.Days)
                ) && 
                (
                    this.Frequency == input.Frequency ||
                    (this.Frequency != null &&
                    this.Frequency.Equals(input.Frequency))
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
                if (this.Frequency != null)
                    hashCode = hashCode * 59 + this.Frequency.GetHashCode();
                return hashCode;
            }
        }

    }

}


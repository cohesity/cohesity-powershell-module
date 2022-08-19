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
    /// SchedulingPolicyProtoMonthlySchedule
    /// </summary>
    [DataContract]
    public partial class SchedulingPolicyProtoMonthlySchedule :  IEquatable<SchedulingPolicyProtoMonthlySchedule>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulingPolicyProtoMonthlySchedule" /> class.
        /// </summary>
        /// <param name="count">Count of the day on which to perform the backup (look above for a more detailed description)..</param>
        /// <param name="day">The day of the month the backup is to be performed..</param>
        /// <param name="dayOfMonth">Specific date of the month on which to perform the backup..</param>
        public SchedulingPolicyProtoMonthlySchedule(int? count = default(int?), int? day = default(int?), int? dayOfMonth = default(int?))
        {
            this.Count = count;
            this.Day = day;
            this.DayOfMonth = dayOfMonth;
        }
        
        /// <summary>
        /// Count of the day on which to perform the backup (look above for a more detailed description).
        /// </summary>
        /// <value>Count of the day on which to perform the backup (look above for a more detailed description).</value>
        [DataMember(Name="count", EmitDefaultValue=true)]
        public int? Count { get; set; }

        /// <summary>
        /// The day of the month the backup is to be performed.
        /// </summary>
        /// <value>The day of the month the backup is to be performed.</value>
        [DataMember(Name="day", EmitDefaultValue=true)]
        public int? Day { get; set; }

        /// <summary>
        /// Specific date of the month on which to perform the backup.
        /// </summary>
        /// <value>Specific date of the month on which to perform the backup.</value>
        [DataMember(Name="dayOfMonth", EmitDefaultValue=true)]
        public int? DayOfMonth { get; set; }

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
            return this.Equals(input as SchedulingPolicyProtoMonthlySchedule);
        }

        /// <summary>
        /// Returns true if SchedulingPolicyProtoMonthlySchedule instances are equal
        /// </summary>
        /// <param name="input">Instance of SchedulingPolicyProtoMonthlySchedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchedulingPolicyProtoMonthlySchedule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.Day == input.Day ||
                    (this.Day != null &&
                    this.Day.Equals(input.Day))
                ) && 
                (
                    this.DayOfMonth == input.DayOfMonth ||
                    (this.DayOfMonth != null &&
                    this.DayOfMonth.Equals(input.DayOfMonth))
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
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Day != null)
                    hashCode = hashCode * 59 + this.Day.GetHashCode();
                if (this.DayOfMonth != null)
                    hashCode = hashCode * 59 + this.DayOfMonth.GetHashCode();
                return hashCode;
            }
        }

    }

}


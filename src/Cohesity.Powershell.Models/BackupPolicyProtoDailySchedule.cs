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
    /// The daily schedule encompasses weekly schedules as well. This has been done so there is only one way of specifying a schedule (backing up daily is the same as backing up weekly, but on all days of the week).
    /// </summary>
    [DataContract]
    public partial class BackupPolicyProtoDailySchedule :  IEquatable<BackupPolicyProtoDailySchedule>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BackupPolicyProtoDailySchedule" /> class.
        /// </summary>
        /// <param name="days">The days of the week backup must be performed. If no days are specified, then the backup will be performed on all days..</param>
        /// <param name="time">time.</param>
        public BackupPolicyProtoDailySchedule(List<int?> days = default(List<int?>), Time time = default(Time))
        {
            this.Days = days;
            this.Time = time;
        }
        
        /// <summary>
        /// The days of the week backup must be performed. If no days are specified, then the backup will be performed on all days.
        /// </summary>
        /// <value>The days of the week backup must be performed. If no days are specified, then the backup will be performed on all days.</value>
        [DataMember(Name="days", EmitDefaultValue=false)]
        public List<int?> Days { get; set; }

        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public Time Time { get; set; }

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
            return this.Equals(input as BackupPolicyProtoDailySchedule);
        }

        /// <summary>
        /// Returns true if BackupPolicyProtoDailySchedule instances are equal
        /// </summary>
        /// <param name="input">Instance of BackupPolicyProtoDailySchedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BackupPolicyProtoDailySchedule input)
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
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
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
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                return hashCode;
            }
        }

    }

}


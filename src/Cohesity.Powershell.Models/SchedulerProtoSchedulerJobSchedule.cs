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
    /// SchedulerProtoSchedulerJobSchedule
    /// </summary>
    [DataContract]
    public partial class SchedulerProtoSchedulerJobSchedule :  IEquatable<SchedulerProtoSchedulerJobSchedule>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulerProtoSchedulerJobSchedule" /> class.
        /// </summary>
        /// <param name="day">The day of the week when schedule should be executed (0-6)..</param>
        /// <param name="hour">The hour of the day when schedule should be executed (0-23)..</param>
        public SchedulerProtoSchedulerJobSchedule(int? day = default(int?), int? hour = default(int?))
        {
            this.Day = day;
            this.Hour = hour;
        }
        
        /// <summary>
        /// The day of the week when schedule should be executed (0-6).
        /// </summary>
        /// <value>The day of the week when schedule should be executed (0-6).</value>
        [DataMember(Name="day", EmitDefaultValue=false)]
        public int? Day { get; set; }

        /// <summary>
        /// The hour of the day when schedule should be executed (0-23).
        /// </summary>
        /// <value>The hour of the day when schedule should be executed (0-23).</value>
        [DataMember(Name="hour", EmitDefaultValue=false)]
        public int? Hour { get; set; }

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
            return this.Equals(input as SchedulerProtoSchedulerJobSchedule);
        }

        /// <summary>
        /// Returns true if SchedulerProtoSchedulerJobSchedule instances are equal
        /// </summary>
        /// <param name="input">Instance of SchedulerProtoSchedulerJobSchedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchedulerProtoSchedulerJobSchedule input)
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
                    this.Hour == input.Hour ||
                    (this.Hour != null &&
                    this.Hour.Equals(input.Hour))
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
                if (this.Hour != null)
                    hashCode = hashCode * 59 + this.Hour.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


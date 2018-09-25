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




namespace Cohesity.Models
{
    /// <summary>
    /// Specifies the time of day to start the CBT-based Protection Schedule. This is optional and only applicable if the Protection Policy defines a monthly or a daily CBT-based Protection Schedule. Default value is 02:00 AM. deprecated: true
    /// </summary>
    [DataContract]
    public partial class CBTbasedProtectionScheduleStartTime_ :  IEquatable<CBTbasedProtectionScheduleStartTime_>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CBTbasedProtectionScheduleStartTime_" /> class.
        /// </summary>
        /// <param name="hour">Specifies an (0-23) hour in a day..</param>
        /// <param name="minute">Specifies a (0-59) minute in an hour..</param>
        public CBTbasedProtectionScheduleStartTime_(int? hour = default(int?), int? minute = default(int?))
        {
            this.Hour = hour;
            this.Minute = minute;
        }
        
        /// <summary>
        /// Specifies an (0-23) hour in a day.
        /// </summary>
        /// <value>Specifies an (0-23) hour in a day.</value>
        [DataMember(Name="hour", EmitDefaultValue=false)]
        public int? Hour { get; set; }

        /// <summary>
        /// Specifies a (0-59) minute in an hour.
        /// </summary>
        /// <value>Specifies a (0-59) minute in an hour.</value>
        [DataMember(Name="minute", EmitDefaultValue=false)]
        public int? Minute { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        //public override string ToString()
        //{
        //    var sb = new StringBuilder();
        //    sb.Append("class CBTbasedProtectionScheduleStartTime_ {\n");
        //    sb.Append("  Hour: ").Append(Hour).Append("\n");
        //    sb.Append("  Minute: ").Append(Minute).Append("\n");
        //    sb.Append("}\n");
        //    return sb.ToString();
        //}

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
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
            return this.Equals(input as CBTbasedProtectionScheduleStartTime_);
        }

        /// <summary>
        /// Returns true if CBTbasedProtectionScheduleStartTime_ instances are equal
        /// </summary>
        /// <param name="input">Instance of CBTbasedProtectionScheduleStartTime_ to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CBTbasedProtectionScheduleStartTime_ input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Hour == input.Hour ||
                    (this.Hour != null &&
                    this.Hour.Equals(input.Hour))
                ) && 
                (
                    this.Minute == input.Minute ||
                    (this.Minute != null &&
                    this.Minute.Equals(input.Minute))
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
                if (this.Hour != null)
                    hashCode = hashCode * 59 + this.Hour.GetHashCode();
                if (this.Minute != null)
                    hashCode = hashCode * 59 + this.Minute.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


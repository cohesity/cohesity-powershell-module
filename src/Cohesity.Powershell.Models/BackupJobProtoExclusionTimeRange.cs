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
    /// A proto to specify a time range within a single day when backups are not permitted to run.
    /// </summary>
    [DataContract]
    public partial class BackupJobProtoExclusionTimeRange :  IEquatable<BackupJobProtoExclusionTimeRange>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BackupJobProtoExclusionTimeRange" /> class.
        /// </summary>
        /// <param name="day">If the day is not set, the time range applies to all days..</param>
        /// <param name="endTime">endTime.</param>
        /// <param name="startTime">startTime.</param>
        public BackupJobProtoExclusionTimeRange(int? day = default(int?), Time endTime = default(Time), Time startTime = default(Time))
        {
            this.Day = day;
            this.Day = day;
            this.EndTime = endTime;
            this.StartTime = startTime;
        }
        
        /// <summary>
        /// If the day is not set, the time range applies to all days.
        /// </summary>
        /// <value>If the day is not set, the time range applies to all days.</value>
        [DataMember(Name="day", EmitDefaultValue=true)]
        public int? Day { get; set; }

        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public Time EndTime { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public Time StartTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupJobProtoExclusionTimeRange {\n");
            sb.Append("  Day: ").Append(Day).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
            return this.Equals(input as BackupJobProtoExclusionTimeRange);
        }

        /// <summary>
        /// Returns true if BackupJobProtoExclusionTimeRange instances are equal
        /// </summary>
        /// <param name="input">Instance of BackupJobProtoExclusionTimeRange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BackupJobProtoExclusionTimeRange input)
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

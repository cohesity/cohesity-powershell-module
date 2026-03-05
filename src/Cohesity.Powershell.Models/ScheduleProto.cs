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
    /// ScheduleProto
    /// </summary>
    [DataContract]
    public partial class ScheduleProto :  IEquatable<ScheduleProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleProto" /> class.
        /// </summary>
        /// <param name="periodicTimeWindows">Specifies the time range within the days of the week. This field is non-empty iff type &#x3D;&#x3D; kPeriodicTimeWindows..</param>
        /// <param name="timeRanges">Specifies the time ranges in usecs. This field is non-empty iff type &#x3D;&#x3D; kCustomIntervals..</param>
        /// <param name="timezone">Timezone of the user of this ScheduleProto. The timezones have unique names of the form \&quot;Area/Location\&quot;..</param>
        /// <param name="type">Specifies the type of schedule for this ScheduleProto..</param>
        public ScheduleProto(List<TimeWindow> periodicTimeWindows = default(List<TimeWindow>), List<TimeRangeUsecs> timeRanges = default(List<TimeRangeUsecs>), string timezone = default(string), int? type = default(int?))
        {
            this.PeriodicTimeWindows = periodicTimeWindows;
            this.TimeRanges = timeRanges;
            this.Timezone = timezone;
            this.Type = type;
            this.PeriodicTimeWindows = periodicTimeWindows;
            this.TimeRanges = timeRanges;
            this.Timezone = timezone;
            this.Type = type;
        }
        
        /// <summary>
        /// Specifies the time range within the days of the week. This field is non-empty iff type &#x3D;&#x3D; kPeriodicTimeWindows.
        /// </summary>
        /// <value>Specifies the time range within the days of the week. This field is non-empty iff type &#x3D;&#x3D; kPeriodicTimeWindows.</value>
        [DataMember(Name="periodicTimeWindows", EmitDefaultValue=true)]
        public List<TimeWindow> PeriodicTimeWindows { get; set; }

        /// <summary>
        /// Specifies the time ranges in usecs. This field is non-empty iff type &#x3D;&#x3D; kCustomIntervals.
        /// </summary>
        /// <value>Specifies the time ranges in usecs. This field is non-empty iff type &#x3D;&#x3D; kCustomIntervals.</value>
        [DataMember(Name="timeRanges", EmitDefaultValue=true)]
        public List<TimeRangeUsecs> TimeRanges { get; set; }

        /// <summary>
        /// Timezone of the user of this ScheduleProto. The timezones have unique names of the form \&quot;Area/Location\&quot;.
        /// </summary>
        /// <value>Timezone of the user of this ScheduleProto. The timezones have unique names of the form \&quot;Area/Location\&quot;.</value>
        [DataMember(Name="timezone", EmitDefaultValue=true)]
        public string Timezone { get; set; }

        /// <summary>
        /// Specifies the type of schedule for this ScheduleProto.
        /// </summary>
        /// <value>Specifies the type of schedule for this ScheduleProto.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public int? Type { get; set; }

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
            return this.Equals(input as ScheduleProto);
        }

        /// <summary>
        /// Returns true if ScheduleProto instances are equal
        /// </summary>
        /// <param name="input">Instance of ScheduleProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PeriodicTimeWindows == input.PeriodicTimeWindows ||
                    this.PeriodicTimeWindows != null &&
                    input.PeriodicTimeWindows != null &&
                    this.PeriodicTimeWindows.SequenceEqual(input.PeriodicTimeWindows)
                ) && 
                (
                    this.TimeRanges == input.TimeRanges ||
                    this.TimeRanges != null &&
                    input.TimeRanges != null &&
                    this.TimeRanges.SequenceEqual(input.TimeRanges)
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.PeriodicTimeWindows != null)
                    hashCode = hashCode * 59 + this.PeriodicTimeWindows.GetHashCode();
                if (this.TimeRanges != null)
                    hashCode = hashCode * 59 + this.TimeRanges.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}


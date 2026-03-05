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
    /// Message that specifies the frequency granularity at which to copy the snapshots from a backup job&#39;s runs.
    /// </summary>
    [DataContract]
    public partial class GranularityBucket :  IEquatable<GranularityBucket>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GranularityBucket" /> class.
        /// </summary>
        /// <param name="exactDates">exactDates.</param>
        /// <param name="granularity">The base time period granularity that determines the frequency at which backup run snapshots will be copied.  NOTE: The granularity (in combination with the &#39;multiplier&#39; field below but for the case of kExactDates) that is specified should be such that the frequency of copying snapshots is lower than the frequency of actually creating the snapshots (i.e.,lower than the frequency of the backup job runs)..</param>
        /// <param name="monthlyDayVec">Specifies when the monthly granularity bucket takes effect. This can be used with granularity of type kMonth. It allows specifying the start day as a specific day of month (1-31) or as a pattern like \&quot;first Sunday\&quot;, \&quot;second Saturday\&quot;, or \&quot;last Friday\&quot;..</param>
        /// <param name="multiplier">A factor to multiply the granularity by. For example, if this is 2 and the granularity is kHour, then snapshots from the first eligible run from every 2 hour period will be copied..</param>
        /// <param name="weeklyDayVec">Specifies the days of week when the weekly granularity bucket takes effect. This is used with granularity of type kWeek..</param>
        /// <param name="yearlyDayVec">Specifies when the yearly granularity bucket takes effect. This can be used with granularity of type kYear. It allows specifying the start day as a specific month and day combination, or as \&quot;first day of year\&quot; or \&quot;last day of year\&quot;..</param>
        public GranularityBucket(GranularityBucketExactDatesInfo exactDates = default(GranularityBucketExactDatesInfo), int? granularity = default(int?), List<SchedulingPolicyProtoMonthlySchedule> monthlyDayVec = default(List<SchedulingPolicyProtoMonthlySchedule>), int? multiplier = default(int?), List<int> weeklyDayVec = default(List<int>), List<SchedulingPolicyProtoYearlySchedule> yearlyDayVec = default(List<SchedulingPolicyProtoYearlySchedule>))
        {
            this.Granularity = granularity;
            this.MonthlyDayVec = monthlyDayVec;
            this.Multiplier = multiplier;
            this.WeeklyDayVec = weeklyDayVec;
            this.YearlyDayVec = yearlyDayVec;
            this.ExactDates = exactDates;
            this.Granularity = granularity;
            this.MonthlyDayVec = monthlyDayVec;
            this.Multiplier = multiplier;
            this.WeeklyDayVec = weeklyDayVec;
            this.YearlyDayVec = yearlyDayVec;
        }
        
        /// <summary>
        /// Gets or Sets ExactDates
        /// </summary>
        [DataMember(Name="exactDates", EmitDefaultValue=false)]
        public GranularityBucketExactDatesInfo ExactDates { get; set; }

        /// <summary>
        /// The base time period granularity that determines the frequency at which backup run snapshots will be copied.  NOTE: The granularity (in combination with the &#39;multiplier&#39; field below but for the case of kExactDates) that is specified should be such that the frequency of copying snapshots is lower than the frequency of actually creating the snapshots (i.e.,lower than the frequency of the backup job runs).
        /// </summary>
        /// <value>The base time period granularity that determines the frequency at which backup run snapshots will be copied.  NOTE: The granularity (in combination with the &#39;multiplier&#39; field below but for the case of kExactDates) that is specified should be such that the frequency of copying snapshots is lower than the frequency of actually creating the snapshots (i.e.,lower than the frequency of the backup job runs).</value>
        [DataMember(Name="granularity", EmitDefaultValue=true)]
        public int? Granularity { get; set; }

        /// <summary>
        /// Specifies when the monthly granularity bucket takes effect. This can be used with granularity of type kMonth. It allows specifying the start day as a specific day of month (1-31) or as a pattern like \&quot;first Sunday\&quot;, \&quot;second Saturday\&quot;, or \&quot;last Friday\&quot;.
        /// </summary>
        /// <value>Specifies when the monthly granularity bucket takes effect. This can be used with granularity of type kMonth. It allows specifying the start day as a specific day of month (1-31) or as a pattern like \&quot;first Sunday\&quot;, \&quot;second Saturday\&quot;, or \&quot;last Friday\&quot;.</value>
        [DataMember(Name="monthlyDayVec", EmitDefaultValue=true)]
        public List<SchedulingPolicyProtoMonthlySchedule> MonthlyDayVec { get; set; }

        /// <summary>
        /// A factor to multiply the granularity by. For example, if this is 2 and the granularity is kHour, then snapshots from the first eligible run from every 2 hour period will be copied.
        /// </summary>
        /// <value>A factor to multiply the granularity by. For example, if this is 2 and the granularity is kHour, then snapshots from the first eligible run from every 2 hour period will be copied.</value>
        [DataMember(Name="multiplier", EmitDefaultValue=true)]
        public int? Multiplier { get; set; }

        /// <summary>
        /// Specifies the days of week when the weekly granularity bucket takes effect. This is used with granularity of type kWeek.
        /// </summary>
        /// <value>Specifies the days of week when the weekly granularity bucket takes effect. This is used with granularity of type kWeek.</value>
        [DataMember(Name="weeklyDayVec", EmitDefaultValue=true)]
        public List<int> WeeklyDayVec { get; set; }

        /// <summary>
        /// Specifies when the yearly granularity bucket takes effect. This can be used with granularity of type kYear. It allows specifying the start day as a specific month and day combination, or as \&quot;first day of year\&quot; or \&quot;last day of year\&quot;.
        /// </summary>
        /// <value>Specifies when the yearly granularity bucket takes effect. This can be used with granularity of type kYear. It allows specifying the start day as a specific month and day combination, or as \&quot;first day of year\&quot; or \&quot;last day of year\&quot;.</value>
        [DataMember(Name="yearlyDayVec", EmitDefaultValue=true)]
        public List<SchedulingPolicyProtoYearlySchedule> YearlyDayVec { get; set; }

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
            return this.Equals(input as GranularityBucket);
        }

        /// <summary>
        /// Returns true if GranularityBucket instances are equal
        /// </summary>
        /// <param name="input">Instance of GranularityBucket to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GranularityBucket input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExactDates == input.ExactDates ||
                    (this.ExactDates != null &&
                    this.ExactDates.Equals(input.ExactDates))
                ) && 
                (
                    this.Granularity == input.Granularity ||
                    (this.Granularity != null &&
                    this.Granularity.Equals(input.Granularity))
                ) && 
                (
                    this.MonthlyDayVec == input.MonthlyDayVec ||
                    this.MonthlyDayVec != null &&
                    input.MonthlyDayVec != null &&
                    this.MonthlyDayVec.SequenceEqual(input.MonthlyDayVec)
                ) && 
                (
                    this.Multiplier == input.Multiplier ||
                    (this.Multiplier != null &&
                    this.Multiplier.Equals(input.Multiplier))
                ) && 
                (
                    this.WeeklyDayVec == input.WeeklyDayVec ||
                    this.WeeklyDayVec != null &&
                    input.WeeklyDayVec != null &&
                    this.WeeklyDayVec.SequenceEqual(input.WeeklyDayVec)
                ) && 
                (
                    this.YearlyDayVec == input.YearlyDayVec ||
                    this.YearlyDayVec != null &&
                    input.YearlyDayVec != null &&
                    this.YearlyDayVec.SequenceEqual(input.YearlyDayVec)
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
                if (this.ExactDates != null)
                    hashCode = hashCode * 59 + this.ExactDates.GetHashCode();
                if (this.Granularity != null)
                    hashCode = hashCode * 59 + this.Granularity.GetHashCode();
                if (this.MonthlyDayVec != null)
                    hashCode = hashCode * 59 + this.MonthlyDayVec.GetHashCode();
                if (this.Multiplier != null)
                    hashCode = hashCode * 59 + this.Multiplier.GetHashCode();
                if (this.WeeklyDayVec != null)
                    hashCode = hashCode * 59 + this.WeeklyDayVec.GetHashCode();
                if (this.YearlyDayVec != null)
                    hashCode = hashCode * 59 + this.YearlyDayVec.GetHashCode();
                return hashCode;
            }
        }

    }

}


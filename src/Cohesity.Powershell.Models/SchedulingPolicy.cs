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
    /// Specifies settings that define a backup schedule for a Protection Job.
    /// </summary>
    [DataContract]
    public partial class SchedulingPolicy :  IEquatable<SchedulingPolicy>
    {
        /// <summary>
        /// Specifies how often to start new Job Runs of a Protection Job. &#39;kDaily&#39; means new Job Runs start daily. &#39;kMonthly&#39; means new Job Runs start monthly. &#39;kContinuous&#39; means new Job Runs repetitively start at the beginning of the specified time interval (in hours or minutes). &#39;kContinuousRPO&#39; means this is an RPO schedule. &#39;kCDP&#39; means this is a continuous data protection policy.
        /// </summary>
        /// <value>Specifies how often to start new Job Runs of a Protection Job. &#39;kDaily&#39; means new Job Runs start daily. &#39;kMonthly&#39; means new Job Runs start monthly. &#39;kContinuous&#39; means new Job Runs repetitively start at the beginning of the specified time interval (in hours or minutes). &#39;kContinuousRPO&#39; means this is an RPO schedule. &#39;kCDP&#39; means this is a continuous data protection policy.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PeriodicityEnum
        {
            /// <summary>
            /// Enum KContinuous for value: kContinuous
            /// </summary>
            [EnumMember(Value = "kContinuous")]
            KContinuous = 1,

            /// <summary>
            /// Enum KDaily for value: kDaily
            /// </summary>
            [EnumMember(Value = "kDaily")]
            KDaily = 2,

            /// <summary>
            /// Enum KMonthly for value: kMonthly
            /// </summary>
            [EnumMember(Value = "kMonthly")]
            KMonthly = 3,

            /// <summary>
            /// Enum KContinuousRPO for value: kContinuousRPO
            /// </summary>
            [EnumMember(Value = "kContinuousRPO")]
            KContinuousRPO = 4,

            /// <summary>
            /// Enum KCDP for value: kCDP
            /// </summary>
            [EnumMember(Value = "kCDP")]
            KCDP = 5

        }

        /// <summary>
        /// Specifies how often to start new Job Runs of a Protection Job. &#39;kDaily&#39; means new Job Runs start daily. &#39;kMonthly&#39; means new Job Runs start monthly. &#39;kContinuous&#39; means new Job Runs repetitively start at the beginning of the specified time interval (in hours or minutes). &#39;kContinuousRPO&#39; means this is an RPO schedule. &#39;kCDP&#39; means this is a continuous data protection policy.
        /// </summary>
        /// <value>Specifies how often to start new Job Runs of a Protection Job. &#39;kDaily&#39; means new Job Runs start daily. &#39;kMonthly&#39; means new Job Runs start monthly. &#39;kContinuous&#39; means new Job Runs repetitively start at the beginning of the specified time interval (in hours or minutes). &#39;kContinuousRPO&#39; means this is an RPO schedule. &#39;kCDP&#39; means this is a continuous data protection policy.</value>
        [DataMember(Name="periodicity", EmitDefaultValue=false)]
        public PeriodicityEnum? Periodicity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulingPolicy" /> class.
        /// </summary>
        /// <param name="continuousSchedule">Specifies the time interval between two Job Runs of a continuous backup schedule and any blackout periods when new Job Runs should NOT be started. Set if periodicity is kContinuous..</param>
        /// <param name="dailySchedule">Specifies a daily or weekly backup schedule. Set if periodicity is kDaily..</param>
        /// <param name="monthlySchedule">Specifies a monthly backup schedule. Set if periodicity is kMonthly..</param>
        /// <param name="periodicity">Specifies how often to start new Job Runs of a Protection Job. &#39;kDaily&#39; means new Job Runs start daily. &#39;kMonthly&#39; means new Job Runs start monthly. &#39;kContinuous&#39; means new Job Runs repetitively start at the beginning of the specified time interval (in hours or minutes). &#39;kContinuousRPO&#39; means this is an RPO schedule. &#39;kCDP&#39; means this is a continuous data protection policy..</param>
        /// <param name="rpoSchedule">Specifies an RPO backup schedule. Set if periodicity is kContinuousRPO..</param>
        public SchedulingPolicy(ContinuousSchedule continuousSchedule = default(ContinuousSchedule), DailySchedule dailySchedule = default(DailySchedule), MonthlySchedule monthlySchedule = default(MonthlySchedule), PeriodicityEnum? periodicity = default(PeriodicityEnum?), RpoSchedule rpoSchedule = default(RpoSchedule))
        {
            this.ContinuousSchedule = continuousSchedule;
            this.DailySchedule = dailySchedule;
            this.MonthlySchedule = monthlySchedule;
            this.Periodicity = periodicity;
            this.RpoSchedule = rpoSchedule;
        }
        
        /// <summary>
        /// Specifies the time interval between two Job Runs of a continuous backup schedule and any blackout periods when new Job Runs should NOT be started. Set if periodicity is kContinuous.
        /// </summary>
        /// <value>Specifies the time interval between two Job Runs of a continuous backup schedule and any blackout periods when new Job Runs should NOT be started. Set if periodicity is kContinuous.</value>
        [DataMember(Name="continuousSchedule", EmitDefaultValue=false)]
        public ContinuousSchedule ContinuousSchedule { get; set; }

        /// <summary>
        /// Specifies a daily or weekly backup schedule. Set if periodicity is kDaily.
        /// </summary>
        /// <value>Specifies a daily or weekly backup schedule. Set if periodicity is kDaily.</value>
        [DataMember(Name="dailySchedule", EmitDefaultValue=false)]
        public DailySchedule DailySchedule { get; set; }

        /// <summary>
        /// Specifies a monthly backup schedule. Set if periodicity is kMonthly.
        /// </summary>
        /// <value>Specifies a monthly backup schedule. Set if periodicity is kMonthly.</value>
        [DataMember(Name="monthlySchedule", EmitDefaultValue=false)]
        public MonthlySchedule MonthlySchedule { get; set; }


        /// <summary>
        /// Specifies an RPO backup schedule. Set if periodicity is kContinuousRPO.
        /// </summary>
        /// <value>Specifies an RPO backup schedule. Set if periodicity is kContinuousRPO.</value>
        [DataMember(Name="rpoSchedule", EmitDefaultValue=false)]
        public RpoSchedule RpoSchedule { get; set; }

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
            return this.Equals(input as SchedulingPolicy);
        }

        /// <summary>
        /// Returns true if SchedulingPolicy instances are equal
        /// </summary>
        /// <param name="input">Instance of SchedulingPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchedulingPolicy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContinuousSchedule == input.ContinuousSchedule ||
                    this.ContinuousSchedule != null &&
                    this.ContinuousSchedule.Equals(input.ContinuousSchedule)
                ) && 
                (
                    this.DailySchedule == input.DailySchedule ||
                    this.DailySchedule != null &&
                    this.DailySchedule.Equals(input.DailySchedule)
                ) && 
                (
                    this.MonthlySchedule == input.MonthlySchedule ||
                    this.MonthlySchedule != null &&
                    this.MonthlySchedule.Equals(input.MonthlySchedule)
                ) && 
                (
                    this.Periodicity == input.Periodicity ||
                    (this.Periodicity != null &&
                    this.Periodicity.Equals(input.Periodicity))
                ) && 
                (
                    this.RpoSchedule == input.RpoSchedule ||
                    this.RpoSchedule != null &&
                    this.RpoSchedule.Equals(input.RpoSchedule)
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
                if (this.ContinuousSchedule != null)
                    hashCode = hashCode * 59 + this.ContinuousSchedule.GetHashCode();
                if (this.DailySchedule != null)
                    hashCode = hashCode * 59 + this.DailySchedule.GetHashCode();
                if (this.MonthlySchedule != null)
                    hashCode = hashCode * 59 + this.MonthlySchedule.GetHashCode();
                if (this.Periodicity != null)
                    hashCode = hashCode * 59 + this.Periodicity.GetHashCode();
                if (this.RpoSchedule != null)
                    hashCode = hashCode * 59 + this.RpoSchedule.GetHashCode();
                return hashCode;
            }
        }

    }

}


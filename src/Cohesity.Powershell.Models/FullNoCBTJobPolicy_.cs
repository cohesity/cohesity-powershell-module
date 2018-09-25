// Copyright 2018 Cohesity Inc.

using System;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;



namespace Cohesity.Models
{
    /// <summary>
    /// Specifies the Full (no CBT) backup schedule of a Protection Job and how long Snapshots captured by this schedule are retained on the Cohesity Cluster.
    /// </summary>
    [DataContract]
    public partial class FullNoCBTJobPolicy_ :  IEquatable<FullNoCBTJobPolicy_>
    {
        /// <summary>
        /// Specifies how often to start new Job Runs of a Protection Job. &#39;kDaily&#39; means new Job Runs start daily. &#39;kMonthly&#39; means new Job Runs start monthly. &#39;kContinuous&#39; means new Job Runs repetitively start at the beginning of the specified time interval (in hours or minutes). &#39;kOneOff&#39; means this is an additional schedule.
        /// </summary>
        /// <value>Specifies how often to start new Job Runs of a Protection Job. &#39;kDaily&#39; means new Job Runs start daily. &#39;kMonthly&#39; means new Job Runs start monthly. &#39;kContinuous&#39; means new Job Runs repetitively start at the beginning of the specified time interval (in hours or minutes). &#39;kOneOff&#39; means this is an additional schedule.</value>
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
            /// Enum KOneOff for value: kOneOff
            /// </summary>
            [EnumMember(Value = "kOneOff")]
            KOneOff = 4
        }

        /// <summary>
        /// Specifies how often to start new Job Runs of a Protection Job. &#39;kDaily&#39; means new Job Runs start daily. &#39;kMonthly&#39; means new Job Runs start monthly. &#39;kContinuous&#39; means new Job Runs repetitively start at the beginning of the specified time interval (in hours or minutes). &#39;kOneOff&#39; means this is an additional schedule.
        /// </summary>
        /// <value>Specifies how often to start new Job Runs of a Protection Job. &#39;kDaily&#39; means new Job Runs start daily. &#39;kMonthly&#39; means new Job Runs start monthly. &#39;kContinuous&#39; means new Job Runs repetitively start at the beginning of the specified time interval (in hours or minutes). &#39;kOneOff&#39; means this is an additional schedule.</value>
        [DataMember(Name="periodicity", EmitDefaultValue=false)]
        public PeriodicityEnum? Periodicity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FullNoCBTJobPolicy_" /> class.
        /// </summary>
        /// <param name="continuousSchedule">continuousSchedule.</param>
        /// <param name="dailySchedule">dailySchedule.</param>
        /// <param name="monthlySchedule">monthlySchedule.</param>
        /// <param name="periodicity">Specifies how often to start new Job Runs of a Protection Job. &#39;kDaily&#39; means new Job Runs start daily. &#39;kMonthly&#39; means new Job Runs start monthly. &#39;kContinuous&#39; means new Job Runs repetitively start at the beginning of the specified time interval (in hours or minutes). &#39;kOneOff&#39; means this is an additional schedule..</param>
        public FullNoCBTJobPolicy_(ContinuousSchedule_ continuousSchedule = default(ContinuousSchedule_), DailyWeeklySchedule_ dailySchedule = default(DailyWeeklySchedule_), MonthlySchedule_ monthlySchedule = default(MonthlySchedule_), PeriodicityEnum? periodicity = default(PeriodicityEnum?))
        {
            this.ContinuousSchedule = continuousSchedule;
            this.DailySchedule = dailySchedule;
            this.MonthlySchedule = monthlySchedule;
            this.Periodicity = periodicity;
        }
        
        /// <summary>
        /// Gets or Sets ContinuousSchedule
        /// </summary>
        [DataMember(Name="continuousSchedule", EmitDefaultValue=false)]
        public ContinuousSchedule_ ContinuousSchedule { get; set; }

        /// <summary>
        /// Gets or Sets DailySchedule
        /// </summary>
        [DataMember(Name="dailySchedule", EmitDefaultValue=false)]
        public DailyWeeklySchedule_ DailySchedule { get; set; }

        /// <summary>
        /// Gets or Sets MonthlySchedule
        /// </summary>
        [DataMember(Name="monthlySchedule", EmitDefaultValue=false)]
        public MonthlySchedule_ MonthlySchedule { get; set; }


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
            return this.Equals(input as FullNoCBTJobPolicy_);
        }

        /// <summary>
        /// Returns true if FullNoCBTJobPolicy_ instances are equal
        /// </summary>
        /// <param name="input">Instance of FullNoCBTJobPolicy_ to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FullNoCBTJobPolicy_ input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContinuousSchedule == input.ContinuousSchedule ||
                    (this.ContinuousSchedule != null &&
                    this.ContinuousSchedule.Equals(input.ContinuousSchedule))
                ) && 
                (
                    this.DailySchedule == input.DailySchedule ||
                    (this.DailySchedule != null &&
                    this.DailySchedule.Equals(input.DailySchedule))
                ) && 
                (
                    this.MonthlySchedule == input.MonthlySchedule ||
                    (this.MonthlySchedule != null &&
                    this.MonthlySchedule.Equals(input.MonthlySchedule))
                ) && 
                (
                    this.Periodicity == input.Periodicity ||
                    (this.Periodicity != null &&
                    this.Periodicity.Equals(input.Periodicity))
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
                return hashCode;
            }
        }

        
    }

}


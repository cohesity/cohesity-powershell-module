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
    /// SchedulingPolicyProto
    /// </summary>
    [DataContract]
    public partial class SchedulingPolicyProto :  IEquatable<SchedulingPolicyProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulingPolicyProto" /> class.
        /// </summary>
        /// <param name="continuousSchedule">continuousSchedule.</param>
        /// <param name="dailySchedule">dailySchedule.</param>
        /// <param name="dateSchedule">dateSchedule.</param>
        /// <param name="monthlySchedule">monthlySchedule.</param>
        /// <param name="periodicity">Determines how often the job should be run..</param>
        /// <param name="rpoSchedule">rpoSchedule.</param>
        /// <param name="yearlySchedule">yearlySchedule.</param>
        public SchedulingPolicyProto(SchedulingPolicyProtoContinuousSchedule continuousSchedule = default(SchedulingPolicyProtoContinuousSchedule), SchedulingPolicyProtoDailySchedule dailySchedule = default(SchedulingPolicyProtoDailySchedule), SchedulingPolicyProtoDateSchedule dateSchedule = default(SchedulingPolicyProtoDateSchedule), SchedulingPolicyProtoMonthlySchedule monthlySchedule = default(SchedulingPolicyProtoMonthlySchedule), int? periodicity = default(int?), SchedulingPolicyProtoRPOSchedule rpoSchedule = default(SchedulingPolicyProtoRPOSchedule), SchedulingPolicyProtoYearlySchedule yearlySchedule = default(SchedulingPolicyProtoYearlySchedule))
        {
            this.ContinuousSchedule = continuousSchedule;
            this.DailySchedule = dailySchedule;
            this.DateSchedule = dateSchedule;
            this.MonthlySchedule = monthlySchedule;
            this.Periodicity = periodicity;
            this.RpoSchedule = rpoSchedule;
            this.YearlySchedule = yearlySchedule;
        }
        
        /// <summary>
        /// Gets or Sets ContinuousSchedule
        /// </summary>
        [DataMember(Name="continuousSchedule", EmitDefaultValue=false)]
        public SchedulingPolicyProtoContinuousSchedule ContinuousSchedule { get; set; }

        /// <summary>
        /// Gets or Sets DailySchedule
        /// </summary>
        [DataMember(Name="dailySchedule", EmitDefaultValue=false)]
        public SchedulingPolicyProtoDailySchedule DailySchedule { get; set; }

        /// <summary>
        /// Gets or Sets DateSchedule
        /// </summary>
        [DataMember(Name="dateSchedule", EmitDefaultValue=false)]
        public SchedulingPolicyProtoDateSchedule DateSchedule { get; set; }

        /// <summary>
        /// Gets or Sets MonthlySchedule
        /// </summary>
        [DataMember(Name="monthlySchedule", EmitDefaultValue=false)]
        public SchedulingPolicyProtoMonthlySchedule MonthlySchedule { get; set; }

        /// <summary>
        /// Determines how often the job should be run.
        /// </summary>
        /// <value>Determines how often the job should be run.</value>
        [DataMember(Name="periodicity", EmitDefaultValue=true)]
        public int? Periodicity { get; set; }

        /// <summary>
        /// Gets or Sets RpoSchedule
        /// </summary>
        [DataMember(Name="rpoSchedule", EmitDefaultValue=false)]
        public SchedulingPolicyProtoRPOSchedule RpoSchedule { get; set; }

        /// <summary>
        /// Gets or Sets YearlySchedule
        /// </summary>
        [DataMember(Name="yearlySchedule", EmitDefaultValue=false)]
        public SchedulingPolicyProtoYearlySchedule YearlySchedule { get; set; }

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
            return this.Equals(input as SchedulingPolicyProto);
        }

        /// <summary>
        /// Returns true if SchedulingPolicyProto instances are equal
        /// </summary>
        /// <param name="input">Instance of SchedulingPolicyProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchedulingPolicyProto input)
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
                    this.DateSchedule == input.DateSchedule ||
                    (this.DateSchedule != null &&
                    this.DateSchedule.Equals(input.DateSchedule))
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
                ) && 
                (
                    this.RpoSchedule == input.RpoSchedule ||
                    (this.RpoSchedule != null &&
                    this.RpoSchedule.Equals(input.RpoSchedule))
                ) && 
                (
                    this.YearlySchedule == input.YearlySchedule ||
                    (this.YearlySchedule != null &&
                    this.YearlySchedule.Equals(input.YearlySchedule))
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
                if (this.DateSchedule != null)
                    hashCode = hashCode * 59 + this.DateSchedule.GetHashCode();
                if (this.MonthlySchedule != null)
                    hashCode = hashCode * 59 + this.MonthlySchedule.GetHashCode();
                if (this.Periodicity != null)
                    hashCode = hashCode * 59 + this.Periodicity.GetHashCode();
                if (this.RpoSchedule != null)
                    hashCode = hashCode * 59 + this.RpoSchedule.GetHashCode();
                if (this.YearlySchedule != null)
                    hashCode = hashCode * 59 + this.YearlySchedule.GetHashCode();
                return hashCode;
            }
        }

    }

}


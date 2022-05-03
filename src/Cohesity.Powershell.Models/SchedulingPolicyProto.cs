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
        /// <param name="monthlySchedule">monthlySchedule.</param>
        /// <param name="periodicity">Determines how often the job should be run..</param>
        /// <param name="rpoSchedule">rpoSchedule.</param>
        public SchedulingPolicyProto(SchedulingPolicyProtoContinuousSchedule continuousSchedule = default(SchedulingPolicyProtoContinuousSchedule), SchedulingPolicyProtoDailySchedule dailySchedule = default(SchedulingPolicyProtoDailySchedule), SchedulingPolicyProtoMonthlySchedule monthlySchedule = default(SchedulingPolicyProtoMonthlySchedule), int? periodicity = default(int?), SchedulingPolicyProtoRPOSchedule rpoSchedule = default(SchedulingPolicyProtoRPOSchedule))
        {
            this.ContinuousSchedule = continuousSchedule;
            this.DailySchedule = dailySchedule;
            this.MonthlySchedule = monthlySchedule;
            this.Periodicity = periodicity;
            this.RpoSchedule = rpoSchedule;
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
        /// Gets or Sets MonthlySchedule
        /// </summary>
        [DataMember(Name="monthlySchedule", EmitDefaultValue=false)]
        public SchedulingPolicyProtoMonthlySchedule MonthlySchedule { get; set; }

        /// <summary>
        /// Determines how often the job should be run.
        /// </summary>
        /// <value>Determines how often the job should be run.</value>
        [DataMember(Name="periodicity", EmitDefaultValue=false)]
        public int? Periodicity { get; set; }

        /// <summary>
        /// Gets or Sets RpoSchedule
        /// </summary>
        [DataMember(Name="rpoSchedule", EmitDefaultValue=false)]
        public SchedulingPolicyProtoRPOSchedule RpoSchedule { get; set; }

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


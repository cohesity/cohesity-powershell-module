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
    /// SchedulerProtoSchedulerJobScheduleJobParameters
    /// </summary>
    [DataContract]
    public partial class SchedulerProtoSchedulerJobScheduleJobParameters :  IEquatable<SchedulerProtoSchedulerJobScheduleJobParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulerProtoSchedulerJobScheduleJobParameters" /> class.
        /// </summary>
        /// <param name="reportJobParameter">reportJobParameter.</param>
        public SchedulerProtoSchedulerJobScheduleJobParameters(SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameter reportJobParameter = default(SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameter))
        {
            this.ReportJobParameter = reportJobParameter;
        }
        
        /// <summary>
        /// Gets or Sets ReportJobParameter
        /// </summary>
        [DataMember(Name="reportJobParameter", EmitDefaultValue=false)]
        public SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameter ReportJobParameter { get; set; }

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
            return this.Equals(input as SchedulerProtoSchedulerJobScheduleJobParameters);
        }

        /// <summary>
        /// Returns true if SchedulerProtoSchedulerJobScheduleJobParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of SchedulerProtoSchedulerJobScheduleJobParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchedulerProtoSchedulerJobScheduleJobParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReportJobParameter == input.ReportJobParameter ||
                    (this.ReportJobParameter != null &&
                    this.ReportJobParameter.Equals(input.ReportJobParameter))
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
                if (this.ReportJobParameter != null)
                    hashCode = hashCode * 59 + this.ReportJobParameter.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


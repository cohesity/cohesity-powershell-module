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
    /// SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameter
    /// </summary>
    [DataContract]
    public partial class SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameter :  IEquatable<SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameter" /> class.
        /// </summary>
        /// <param name="receiverEmails">receiverEmails.</param>
        /// <param name="reports">reports.</param>
        public SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameter(List<string> receiverEmails = default(List<string>), List<SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReport> reports = default(List<SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReport>))
        {
            this.ReceiverEmails = receiverEmails;
            this.Reports = reports;
        }
        
        /// <summary>
        /// Gets or Sets ReceiverEmails
        /// </summary>
        [DataMember(Name="receiverEmails", EmitDefaultValue=false)]
        public List<string> ReceiverEmails { get; set; }

        /// <summary>
        /// Gets or Sets Reports
        /// </summary>
        [DataMember(Name="reports", EmitDefaultValue=false)]
        public List<SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReport> Reports { get; set; }

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
            return this.Equals(input as SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameter);
        }

        /// <summary>
        /// Returns true if SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReceiverEmails == input.ReceiverEmails ||
                    this.ReceiverEmails != null &&
                    this.ReceiverEmails.SequenceEqual(input.ReceiverEmails)
                ) && 
                (
                    this.Reports == input.Reports ||
                    this.Reports != null &&
                    this.Reports.SequenceEqual(input.Reports)
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
                if (this.ReceiverEmails != null)
                    hashCode = hashCode * 59 + this.ReceiverEmails.GetHashCode();
                if (this.Reports != null)
                    hashCode = hashCode * 59 + this.Reports.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


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
    /// SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameter
    /// </summary>
    [DataContract]
    public partial class SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameter :  IEquatable<SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameter" /> class.
        /// </summary>
        /// <param name="receiverEmails">Specifies the list of receiver email addresses..</param>
        /// <param name="reports">The list of reports to be sent in the mail..</param>
        public SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameter(List<string> receiverEmails = default(List<string>), List<SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReport> reports = default(List<SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReport>))
        {
            this.ReceiverEmails = receiverEmails;
            this.Reports = reports;
            this.ReceiverEmails = receiverEmails;
            this.Reports = reports;
        }
        
        /// <summary>
        /// Specifies the list of receiver email addresses.
        /// </summary>
        /// <value>Specifies the list of receiver email addresses.</value>
        [DataMember(Name="receiverEmails", EmitDefaultValue=true)]
        public List<string> ReceiverEmails { get; set; }

        /// <summary>
        /// The list of reports to be sent in the mail.
        /// </summary>
        /// <value>The list of reports to be sent in the mail.</value>
        [DataMember(Name="reports", EmitDefaultValue=true)]
        public List<SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReport> Reports { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameter {\n");
            sb.Append("  ReceiverEmails: ").Append(ReceiverEmails).Append("\n");
            sb.Append("  Reports: ").Append(Reports).Append("\n");
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
                    input.ReceiverEmails != null &&
                    this.ReceiverEmails.SequenceEqual(input.ReceiverEmails)
                ) && 
                (
                    this.Reports == input.Reports ||
                    this.Reports != null &&
                    input.Reports != null &&
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

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
    /// SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReport
    /// </summary>
    [DataContract]
    public partial class SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReport :  IEquatable<SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReport>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReport" /> class.
        /// </summary>
        /// <param name="name">Specifies the report name..</param>
        /// <param name="outputFormat">Specifies the output format of the report..</param>
        /// <param name="parameters">parameters.</param>
        /// <param name="subjectLine">Specifies the subject line for report..</param>
        /// <param name="type">Specifies the report type..</param>
        public SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReport(string name = default(string), string outputFormat = default(string), SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReportParameters parameters = default(SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReportParameters), string subjectLine = default(string), int? type = default(int?))
        {
            this.Name = name;
            this.OutputFormat = outputFormat;
            this.Parameters = parameters;
            this.SubjectLine = subjectLine;
            this.Type = type;
        }
        
        /// <summary>
        /// Specifies the report name.
        /// </summary>
        /// <value>Specifies the report name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the output format of the report.
        /// </summary>
        /// <value>Specifies the output format of the report.</value>
        [DataMember(Name="outputFormat", EmitDefaultValue=false)]
        public string OutputFormat { get; set; }

        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReportParameters Parameters { get; set; }

        /// <summary>
        /// Specifies the subject line for report.
        /// </summary>
        /// <value>Specifies the subject line for report.</value>
        [DataMember(Name="subjectLine", EmitDefaultValue=false)]
        public string SubjectLine { get; set; }

        /// <summary>
        /// Specifies the report type.
        /// </summary>
        /// <value>Specifies the report type.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
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
            return this.Equals(input as SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReport);
        }

        /// <summary>
        /// Returns true if SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReport instances are equal
        /// </summary>
        /// <param name="input">Instance of SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReport input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OutputFormat == input.OutputFormat ||
                    (this.OutputFormat != null &&
                    this.OutputFormat.Equals(input.OutputFormat))
                ) && 
                (
                    this.Parameters == input.Parameters ||
                    (this.Parameters != null &&
                    this.Parameters.Equals(input.Parameters))
                ) && 
                (
                    this.SubjectLine == input.SubjectLine ||
                    (this.SubjectLine != null &&
                    this.SubjectLine.Equals(input.SubjectLine))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OutputFormat != null)
                    hashCode = hashCode * 59 + this.OutputFormat.GetHashCode();
                if (this.Parameters != null)
                    hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.SubjectLine != null)
                    hashCode = hashCode * 59 + this.SubjectLine.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}


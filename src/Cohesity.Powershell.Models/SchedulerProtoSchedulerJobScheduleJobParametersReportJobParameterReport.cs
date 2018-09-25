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
    /// SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReport
    /// </summary>
    [DataContract]
    public partial class SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReport :  IEquatable<SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReport>
    {
        /// <summary>
        /// Specifies the report type. The enum which has all the various report types. kAvailableLocalSnapshotsReport, kBackupSummarySReport, kFailedObjectsReport, kProtectionDetailsPerObjectReport, kProtectionJobsInventoryAndScheduleReport, kProtectionSummaryByObjectTypeReport, kSourceGrowthAndVarianceReport, kStorageConsumedByBackupReport, kStorageConsumedByFileCategoriesReport, kStorageConsumedByServersReport, kStorageConsumedByViewBoxReport, kDataTransferredToExternalTargetsReports,
        /// </summary>
        /// <value>Specifies the report type. The enum which has all the various report types. kAvailableLocalSnapshotsReport, kBackupSummarySReport, kFailedObjectsReport, kProtectionDetailsPerObjectReport, kProtectionJobsInventoryAndScheduleReport, kProtectionSummaryByObjectTypeReport, kSourceGrowthAndVarianceReport, kStorageConsumedByBackupReport, kStorageConsumedByFileCategoriesReport, kStorageConsumedByServersReport, kStorageConsumedByViewBoxReport, kDataTransferredToExternalTargetsReports,</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum KUnprotectedVMsReport for value: kUnprotectedVMsReport
            /// </summary>
            [EnumMember(Value = "kUnprotectedVMsReport")]
            KUnprotectedVMsReport = 1
        }

        /// <summary>
        /// Specifies the report type. The enum which has all the various report types. kAvailableLocalSnapshotsReport, kBackupSummarySReport, kFailedObjectsReport, kProtectionDetailsPerObjectReport, kProtectionJobsInventoryAndScheduleReport, kProtectionSummaryByObjectTypeReport, kSourceGrowthAndVarianceReport, kStorageConsumedByBackupReport, kStorageConsumedByFileCategoriesReport, kStorageConsumedByServersReport, kStorageConsumedByViewBoxReport, kDataTransferredToExternalTargetsReports,
        /// </summary>
        /// <value>Specifies the report type. The enum which has all the various report types. kAvailableLocalSnapshotsReport, kBackupSummarySReport, kFailedObjectsReport, kProtectionDetailsPerObjectReport, kProtectionJobsInventoryAndScheduleReport, kProtectionSummaryByObjectTypeReport, kSourceGrowthAndVarianceReport, kStorageConsumedByBackupReport, kStorageConsumedByFileCategoriesReport, kStorageConsumedByServersReport, kStorageConsumedByViewBoxReport, kDataTransferredToExternalTargetsReports,</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReport" /> class.
        /// </summary>
        /// <param name="outputFormat">Specifies the output format of the report..</param>
        /// <param name="parameters">parameters.</param>
        /// <param name="type">Specifies the report type. The enum which has all the various report types. kAvailableLocalSnapshotsReport, kBackupSummarySReport, kFailedObjectsReport, kProtectionDetailsPerObjectReport, kProtectionJobsInventoryAndScheduleReport, kProtectionSummaryByObjectTypeReport, kSourceGrowthAndVarianceReport, kStorageConsumedByBackupReport, kStorageConsumedByFileCategoriesReport, kStorageConsumedByServersReport, kStorageConsumedByViewBoxReport, kDataTransferredToExternalTargetsReports,.</param>
        public SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReport(string outputFormat = default(string), SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReportParameters parameters = default(SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReportParameters), TypeEnum? type = default(TypeEnum?))
        {
            this.OutputFormat = outputFormat;
            this.Parameters = parameters;
            this.Type = type;
        }
        
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
                if (this.OutputFormat != null)
                    hashCode = hashCode * 59 + this.OutputFormat.GetHashCode();
                if (this.Parameters != null)
                    hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


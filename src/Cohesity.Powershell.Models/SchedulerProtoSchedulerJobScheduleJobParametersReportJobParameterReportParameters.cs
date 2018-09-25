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
    /// SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReportParameters
    /// </summary>
    [DataContract]
    public partial class SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReportParameters :  IEquatable<SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReportParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReportParameters" /> class.
        /// </summary>
        /// <param name="jobId">Specifies the id of the job for which to get the report data..</param>
        /// <param name="jobName">Specifies the name of the job for which to get the report data..</param>
        /// <param name="lastNDays">Specifies the number of days from current date for which the report data is to be fetched..</param>
        /// <param name="objectIds">objectIds.</param>
        /// <param name="objectType">Specifies the object type for which to get the report data..</param>
        /// <param name="registeredSourceIds">Specifies the registered sources for which to get the report data..</param>
        /// <param name="runStatus">runStatus.</param>
        /// <param name="sid">Specifies the sid of the user..</param>
        /// <param name="unixUid">Specifies the unix uid of the user..</param>
        /// <param name="vaultIds">vaultIds.</param>
        /// <param name="viewBoxId">Specifies the view box for which to get the report data..</param>
        /// <param name="viewName">Specifies the view name for which the report is required..</param>
        /// <param name="vmName">Specifies the VM name for which to get the report data..</param>
        public SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReportParameters(long? jobId = default(long?), string jobName = default(string), int? lastNDays = default(int?), List<long?> objectIds = default(List<long?>), string objectType = default(string), List<long?> registeredSourceIds = default(List<long?>), List<string> runStatus = default(List<string>), string sid = default(string), int? unixUid = default(int?), List<long?> vaultIds = default(List<long?>), long? viewBoxId = default(long?), string viewName = default(string), string vmName = default(string))
        {
            this.JobId = jobId;
            this.JobName = jobName;
            this.LastNDays = lastNDays;
            this.ObjectIds = objectIds;
            this.ObjectType = objectType;
            this.RegisteredSourceIds = registeredSourceIds;
            this.RunStatus = runStatus;
            this.Sid = sid;
            this.UnixUid = unixUid;
            this.VaultIds = vaultIds;
            this.ViewBoxId = viewBoxId;
            this.ViewName = viewName;
            this.VmName = vmName;
        }
        
        /// <summary>
        /// Specifies the id of the job for which to get the report data.
        /// </summary>
        /// <value>Specifies the id of the job for which to get the report data.</value>
        [DataMember(Name="jobId", EmitDefaultValue=false)]
        public long? JobId { get; set; }

        /// <summary>
        /// Specifies the name of the job for which to get the report data.
        /// </summary>
        /// <value>Specifies the name of the job for which to get the report data.</value>
        [DataMember(Name="jobName", EmitDefaultValue=false)]
        public string JobName { get; set; }

        /// <summary>
        /// Specifies the number of days from current date for which the report data is to be fetched.
        /// </summary>
        /// <value>Specifies the number of days from current date for which the report data is to be fetched.</value>
        [DataMember(Name="lastNDays", EmitDefaultValue=false)]
        public int? LastNDays { get; set; }

        /// <summary>
        /// Gets or Sets ObjectIds
        /// </summary>
        [DataMember(Name="objectIds", EmitDefaultValue=false)]
        public List<long?> ObjectIds { get; set; }

        /// <summary>
        /// Specifies the object type for which to get the report data.
        /// </summary>
        /// <value>Specifies the object type for which to get the report data.</value>
        [DataMember(Name="objectType", EmitDefaultValue=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// Specifies the registered sources for which to get the report data.
        /// </summary>
        /// <value>Specifies the registered sources for which to get the report data.</value>
        [DataMember(Name="registeredSourceIds", EmitDefaultValue=false)]
        public List<long?> RegisteredSourceIds { get; set; }

        /// <summary>
        /// Gets or Sets RunStatus
        /// </summary>
        [DataMember(Name="runStatus", EmitDefaultValue=false)]
        public List<string> RunStatus { get; set; }

        /// <summary>
        /// Specifies the sid of the user.
        /// </summary>
        /// <value>Specifies the sid of the user.</value>
        [DataMember(Name="sid", EmitDefaultValue=false)]
        public string Sid { get; set; }

        /// <summary>
        /// Specifies the unix uid of the user.
        /// </summary>
        /// <value>Specifies the unix uid of the user.</value>
        [DataMember(Name="unixUid", EmitDefaultValue=false)]
        public int? UnixUid { get; set; }

        /// <summary>
        /// Gets or Sets VaultIds
        /// </summary>
        [DataMember(Name="vaultIds", EmitDefaultValue=false)]
        public List<long?> VaultIds { get; set; }

        /// <summary>
        /// Specifies the view box for which to get the report data.
        /// </summary>
        /// <value>Specifies the view box for which to get the report data.</value>
        [DataMember(Name="viewBoxId", EmitDefaultValue=false)]
        public long? ViewBoxId { get; set; }

        /// <summary>
        /// Specifies the view name for which the report is required.
        /// </summary>
        /// <value>Specifies the view name for which the report is required.</value>
        [DataMember(Name="viewName", EmitDefaultValue=false)]
        public string ViewName { get; set; }

        /// <summary>
        /// Specifies the VM name for which to get the report data.
        /// </summary>
        /// <value>Specifies the VM name for which to get the report data.</value>
        [DataMember(Name="vmName", EmitDefaultValue=false)]
        public string VmName { get; set; }

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
            return this.Equals(input as SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReportParameters);
        }

        /// <summary>
        /// Returns true if SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReportParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReportParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReportParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.JobName == input.JobName ||
                    (this.JobName != null &&
                    this.JobName.Equals(input.JobName))
                ) && 
                (
                    this.LastNDays == input.LastNDays ||
                    (this.LastNDays != null &&
                    this.LastNDays.Equals(input.LastNDays))
                ) && 
                (
                    this.ObjectIds == input.ObjectIds ||
                    this.ObjectIds != null &&
                    this.ObjectIds.SequenceEqual(input.ObjectIds)
                ) && 
                (
                    this.ObjectType == input.ObjectType ||
                    (this.ObjectType != null &&
                    this.ObjectType.Equals(input.ObjectType))
                ) && 
                (
                    this.RegisteredSourceIds == input.RegisteredSourceIds ||
                    this.RegisteredSourceIds != null &&
                    this.RegisteredSourceIds.SequenceEqual(input.RegisteredSourceIds)
                ) && 
                (
                    this.RunStatus == input.RunStatus ||
                    this.RunStatus != null &&
                    this.RunStatus.SequenceEqual(input.RunStatus)
                ) && 
                (
                    this.Sid == input.Sid ||
                    (this.Sid != null &&
                    this.Sid.Equals(input.Sid))
                ) && 
                (
                    this.UnixUid == input.UnixUid ||
                    (this.UnixUid != null &&
                    this.UnixUid.Equals(input.UnixUid))
                ) && 
                (
                    this.VaultIds == input.VaultIds ||
                    this.VaultIds != null &&
                    this.VaultIds.SequenceEqual(input.VaultIds)
                ) && 
                (
                    this.ViewBoxId == input.ViewBoxId ||
                    (this.ViewBoxId != null &&
                    this.ViewBoxId.Equals(input.ViewBoxId))
                ) && 
                (
                    this.ViewName == input.ViewName ||
                    (this.ViewName != null &&
                    this.ViewName.Equals(input.ViewName))
                ) && 
                (
                    this.VmName == input.VmName ||
                    (this.VmName != null &&
                    this.VmName.Equals(input.VmName))
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
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.JobName != null)
                    hashCode = hashCode * 59 + this.JobName.GetHashCode();
                if (this.LastNDays != null)
                    hashCode = hashCode * 59 + this.LastNDays.GetHashCode();
                if (this.ObjectIds != null)
                    hashCode = hashCode * 59 + this.ObjectIds.GetHashCode();
                if (this.ObjectType != null)
                    hashCode = hashCode * 59 + this.ObjectType.GetHashCode();
                if (this.RegisteredSourceIds != null)
                    hashCode = hashCode * 59 + this.RegisteredSourceIds.GetHashCode();
                if (this.RunStatus != null)
                    hashCode = hashCode * 59 + this.RunStatus.GetHashCode();
                if (this.Sid != null)
                    hashCode = hashCode * 59 + this.Sid.GetHashCode();
                if (this.UnixUid != null)
                    hashCode = hashCode * 59 + this.UnixUid.GetHashCode();
                if (this.VaultIds != null)
                    hashCode = hashCode * 59 + this.VaultIds.GetHashCode();
                if (this.ViewBoxId != null)
                    hashCode = hashCode * 59 + this.ViewBoxId.GetHashCode();
                if (this.ViewName != null)
                    hashCode = hashCode * 59 + this.ViewName.GetHashCode();
                if (this.VmName != null)
                    hashCode = hashCode * 59 + this.VmName.GetHashCode();
                return hashCode;
            }
        }

        
    }

}


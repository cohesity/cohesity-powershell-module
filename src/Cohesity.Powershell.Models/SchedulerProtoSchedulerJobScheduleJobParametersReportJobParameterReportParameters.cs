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
    /// SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReportParameters
    /// </summary>
    [DataContract]
    public partial class SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReportParameters :  IEquatable<SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReportParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReportParameters" /> class.
        /// </summary>
        /// <param name="allUnderHierarchy">Specifies if subtenants of the given tenants should be considered for report generation..</param>
        /// <param name="compactVersion">Specifies the Cohesity Agent software version..</param>
        /// <param name="consecutiveFailures">Specifies the number of consecutive failures..</param>
        /// <param name="environment">Specifies the Environment for the entity being protected..</param>
        /// <param name="healthStatus">Specifies the Cohesity Agent health status..</param>
        /// <param name="hostOsType">Specifies the OS type on which Cohesity Agent is installed..</param>
        /// <param name="jobId">Specifies the id of the job for which to get the report data..</param>
        /// <param name="jobName">Specifies the name of the job for which to get the report data..</param>
        /// <param name="lastNDays">Specifies the number of days from current date for which the report data is to be fetched..</param>
        /// <param name="objectIds">Specifies the object ids for which to get the report data..</param>
        /// <param name="objectType">Specifies the object type for which to get the report data..</param>
        /// <param name="registeredSourceId">Specifies the registered source for which to get the report data..</param>
        /// <param name="registeredSourceIds">Specifies the registered sources for which to get the report data..</param>
        /// <param name="rollup">Specifies the rollup(day/week/month) for protected object trends report..</param>
        /// <param name="runStatus">Specifies the run status for which to get the report data..</param>
        /// <param name="sid">Specifies the sid of the user..</param>
        /// <param name="tenantIdVec">Specifies tenant ids for which report needs to be generated..</param>
        /// <param name="timezone">Specifies the timezone..</param>
        /// <param name="unixUid">Specifies the unix uid of the user..</param>
        /// <param name="vaultIds">Specifies the vault ids for which to get the report data..</param>
        /// <param name="viewBoxId">Specifies the view box for which to get the report data..</param>
        /// <param name="viewName">Specifies the view name for which the report is required..</param>
        /// <param name="vmName">Specifies the VM name for which to get the report data..</param>
        public SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReportParameters(bool? allUnderHierarchy = default(bool?), string compactVersion = default(string), int? consecutiveFailures = default(int?), string environment = default(string), List<string> healthStatus = default(List<string>), List<string> hostOsType = default(List<string>), long? jobId = default(long?), string jobName = default(string), int? lastNDays = default(int?), List<long> objectIds = default(List<long>), string objectType = default(string), long? registeredSourceId = default(long?), List<long> registeredSourceIds = default(List<long>), string rollup = default(string), List<string> runStatus = default(List<string>), string sid = default(string), List<string> tenantIdVec = default(List<string>), string timezone = default(string), int? unixUid = default(int?), List<long> vaultIds = default(List<long>), long? viewBoxId = default(long?), string viewName = default(string), string vmName = default(string))
        {
            this.AllUnderHierarchy = allUnderHierarchy;
            this.CompactVersion = compactVersion;
            this.ConsecutiveFailures = consecutiveFailures;
            this.Environment = environment;
            this.HealthStatus = healthStatus;
            this.HostOsType = hostOsType;
            this.JobId = jobId;
            this.JobName = jobName;
            this.LastNDays = lastNDays;
            this.ObjectIds = objectIds;
            this.ObjectType = objectType;
            this.RegisteredSourceId = registeredSourceId;
            this.RegisteredSourceIds = registeredSourceIds;
            this.Rollup = rollup;
            this.RunStatus = runStatus;
            this.Sid = sid;
            this.TenantIdVec = tenantIdVec;
            this.Timezone = timezone;
            this.UnixUid = unixUid;
            this.VaultIds = vaultIds;
            this.ViewBoxId = viewBoxId;
            this.ViewName = viewName;
            this.VmName = vmName;
            this.AllUnderHierarchy = allUnderHierarchy;
            this.CompactVersion = compactVersion;
            this.ConsecutiveFailures = consecutiveFailures;
            this.Environment = environment;
            this.HealthStatus = healthStatus;
            this.HostOsType = hostOsType;
            this.JobId = jobId;
            this.JobName = jobName;
            this.LastNDays = lastNDays;
            this.ObjectIds = objectIds;
            this.ObjectType = objectType;
            this.RegisteredSourceId = registeredSourceId;
            this.RegisteredSourceIds = registeredSourceIds;
            this.Rollup = rollup;
            this.RunStatus = runStatus;
            this.Sid = sid;
            this.TenantIdVec = tenantIdVec;
            this.Timezone = timezone;
            this.UnixUid = unixUid;
            this.VaultIds = vaultIds;
            this.ViewBoxId = viewBoxId;
            this.ViewName = viewName;
            this.VmName = vmName;
        }
        
        /// <summary>
        /// Specifies if subtenants of the given tenants should be considered for report generation.
        /// </summary>
        /// <value>Specifies if subtenants of the given tenants should be considered for report generation.</value>
        [DataMember(Name="allUnderHierarchy", EmitDefaultValue=true)]
        public bool? AllUnderHierarchy { get; set; }

        /// <summary>
        /// Specifies the Cohesity Agent software version.
        /// </summary>
        /// <value>Specifies the Cohesity Agent software version.</value>
        [DataMember(Name="compactVersion", EmitDefaultValue=true)]
        public string CompactVersion { get; set; }

        /// <summary>
        /// Specifies the number of consecutive failures.
        /// </summary>
        /// <value>Specifies the number of consecutive failures.</value>
        [DataMember(Name="consecutiveFailures", EmitDefaultValue=true)]
        public int? ConsecutiveFailures { get; set; }

        /// <summary>
        /// Specifies the Environment for the entity being protected.
        /// </summary>
        /// <value>Specifies the Environment for the entity being protected.</value>
        [DataMember(Name="environment", EmitDefaultValue=true)]
        public string Environment { get; set; }

        /// <summary>
        /// Specifies the Cohesity Agent health status.
        /// </summary>
        /// <value>Specifies the Cohesity Agent health status.</value>
        [DataMember(Name="healthStatus", EmitDefaultValue=true)]
        public List<string> HealthStatus { get; set; }

        /// <summary>
        /// Specifies the OS type on which Cohesity Agent is installed.
        /// </summary>
        /// <value>Specifies the OS type on which Cohesity Agent is installed.</value>
        [DataMember(Name="hostOsType", EmitDefaultValue=true)]
        public List<string> HostOsType { get; set; }

        /// <summary>
        /// Specifies the id of the job for which to get the report data.
        /// </summary>
        /// <value>Specifies the id of the job for which to get the report data.</value>
        [DataMember(Name="jobId", EmitDefaultValue=true)]
        public long? JobId { get; set; }

        /// <summary>
        /// Specifies the name of the job for which to get the report data.
        /// </summary>
        /// <value>Specifies the name of the job for which to get the report data.</value>
        [DataMember(Name="jobName", EmitDefaultValue=true)]
        public string JobName { get; set; }

        /// <summary>
        /// Specifies the number of days from current date for which the report data is to be fetched.
        /// </summary>
        /// <value>Specifies the number of days from current date for which the report data is to be fetched.</value>
        [DataMember(Name="lastNDays", EmitDefaultValue=true)]
        public int? LastNDays { get; set; }

        /// <summary>
        /// Specifies the object ids for which to get the report data.
        /// </summary>
        /// <value>Specifies the object ids for which to get the report data.</value>
        [DataMember(Name="objectIds", EmitDefaultValue=true)]
        public List<long> ObjectIds { get; set; }

        /// <summary>
        /// Specifies the object type for which to get the report data.
        /// </summary>
        /// <value>Specifies the object type for which to get the report data.</value>
        [DataMember(Name="objectType", EmitDefaultValue=true)]
        public string ObjectType { get; set; }

        /// <summary>
        /// Specifies the registered source for which to get the report data.
        /// </summary>
        /// <value>Specifies the registered source for which to get the report data.</value>
        [DataMember(Name="registeredSourceId", EmitDefaultValue=true)]
        public long? RegisteredSourceId { get; set; }

        /// <summary>
        /// Specifies the registered sources for which to get the report data.
        /// </summary>
        /// <value>Specifies the registered sources for which to get the report data.</value>
        [DataMember(Name="registeredSourceIds", EmitDefaultValue=true)]
        public List<long> RegisteredSourceIds { get; set; }

        /// <summary>
        /// Specifies the rollup(day/week/month) for protected object trends report.
        /// </summary>
        /// <value>Specifies the rollup(day/week/month) for protected object trends report.</value>
        [DataMember(Name="rollup", EmitDefaultValue=true)]
        public string Rollup { get; set; }

        /// <summary>
        /// Specifies the run status for which to get the report data.
        /// </summary>
        /// <value>Specifies the run status for which to get the report data.</value>
        [DataMember(Name="runStatus", EmitDefaultValue=true)]
        public List<string> RunStatus { get; set; }

        /// <summary>
        /// Specifies the sid of the user.
        /// </summary>
        /// <value>Specifies the sid of the user.</value>
        [DataMember(Name="sid", EmitDefaultValue=true)]
        public string Sid { get; set; }

        /// <summary>
        /// Specifies tenant ids for which report needs to be generated.
        /// </summary>
        /// <value>Specifies tenant ids for which report needs to be generated.</value>
        [DataMember(Name="tenantIdVec", EmitDefaultValue=true)]
        public List<string> TenantIdVec { get; set; }

        /// <summary>
        /// Specifies the timezone.
        /// </summary>
        /// <value>Specifies the timezone.</value>
        [DataMember(Name="timezone", EmitDefaultValue=true)]
        public string Timezone { get; set; }

        /// <summary>
        /// Specifies the unix uid of the user.
        /// </summary>
        /// <value>Specifies the unix uid of the user.</value>
        [DataMember(Name="unixUid", EmitDefaultValue=true)]
        public int? UnixUid { get; set; }

        /// <summary>
        /// Specifies the vault ids for which to get the report data.
        /// </summary>
        /// <value>Specifies the vault ids for which to get the report data.</value>
        [DataMember(Name="vaultIds", EmitDefaultValue=true)]
        public List<long> VaultIds { get; set; }

        /// <summary>
        /// Specifies the view box for which to get the report data.
        /// </summary>
        /// <value>Specifies the view box for which to get the report data.</value>
        [DataMember(Name="viewBoxId", EmitDefaultValue=true)]
        public long? ViewBoxId { get; set; }

        /// <summary>
        /// Specifies the view name for which the report is required.
        /// </summary>
        /// <value>Specifies the view name for which the report is required.</value>
        [DataMember(Name="viewName", EmitDefaultValue=true)]
        public string ViewName { get; set; }

        /// <summary>
        /// Specifies the VM name for which to get the report data.
        /// </summary>
        /// <value>Specifies the VM name for which to get the report data.</value>
        [DataMember(Name="vmName", EmitDefaultValue=true)]
        public string VmName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SchedulerProtoSchedulerJobScheduleJobParametersReportJobParameterReportParameters {\n");
            sb.Append("  AllUnderHierarchy: ").Append(AllUnderHierarchy).Append("\n");
            sb.Append("  CompactVersion: ").Append(CompactVersion).Append("\n");
            sb.Append("  ConsecutiveFailures: ").Append(ConsecutiveFailures).Append("\n");
            sb.Append("  Environment: ").Append(Environment).Append("\n");
            sb.Append("  HealthStatus: ").Append(HealthStatus).Append("\n");
            sb.Append("  HostOsType: ").Append(HostOsType).Append("\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  JobName: ").Append(JobName).Append("\n");
            sb.Append("  LastNDays: ").Append(LastNDays).Append("\n");
            sb.Append("  ObjectIds: ").Append(ObjectIds).Append("\n");
            sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
            sb.Append("  RegisteredSourceId: ").Append(RegisteredSourceId).Append("\n");
            sb.Append("  RegisteredSourceIds: ").Append(RegisteredSourceIds).Append("\n");
            sb.Append("  Rollup: ").Append(Rollup).Append("\n");
            sb.Append("  RunStatus: ").Append(RunStatus).Append("\n");
            sb.Append("  Sid: ").Append(Sid).Append("\n");
            sb.Append("  TenantIdVec: ").Append(TenantIdVec).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  UnixUid: ").Append(UnixUid).Append("\n");
            sb.Append("  VaultIds: ").Append(VaultIds).Append("\n");
            sb.Append("  ViewBoxId: ").Append(ViewBoxId).Append("\n");
            sb.Append("  ViewName: ").Append(ViewName).Append("\n");
            sb.Append("  VmName: ").Append(VmName).Append("\n");
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
                    this.AllUnderHierarchy == input.AllUnderHierarchy ||
                    (this.AllUnderHierarchy != null &&
                    this.AllUnderHierarchy.Equals(input.AllUnderHierarchy))
                ) && 
                (
                    this.CompactVersion == input.CompactVersion ||
                    (this.CompactVersion != null &&
                    this.CompactVersion.Equals(input.CompactVersion))
                ) && 
                (
                    this.ConsecutiveFailures == input.ConsecutiveFailures ||
                    (this.ConsecutiveFailures != null &&
                    this.ConsecutiveFailures.Equals(input.ConsecutiveFailures))
                ) && 
                (
                    this.Environment == input.Environment ||
                    (this.Environment != null &&
                    this.Environment.Equals(input.Environment))
                ) && 
                (
                    this.HealthStatus == input.HealthStatus ||
                    this.HealthStatus != null &&
                    input.HealthStatus != null &&
                    this.HealthStatus.SequenceEqual(input.HealthStatus)
                ) && 
                (
                    this.HostOsType == input.HostOsType ||
                    this.HostOsType != null &&
                    input.HostOsType != null &&
                    this.HostOsType.SequenceEqual(input.HostOsType)
                ) && 
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
                    input.ObjectIds != null &&
                    this.ObjectIds.SequenceEqual(input.ObjectIds)
                ) && 
                (
                    this.ObjectType == input.ObjectType ||
                    (this.ObjectType != null &&
                    this.ObjectType.Equals(input.ObjectType))
                ) && 
                (
                    this.RegisteredSourceId == input.RegisteredSourceId ||
                    (this.RegisteredSourceId != null &&
                    this.RegisteredSourceId.Equals(input.RegisteredSourceId))
                ) && 
                (
                    this.RegisteredSourceIds == input.RegisteredSourceIds ||
                    this.RegisteredSourceIds != null &&
                    input.RegisteredSourceIds != null &&
                    this.RegisteredSourceIds.SequenceEqual(input.RegisteredSourceIds)
                ) && 
                (
                    this.Rollup == input.Rollup ||
                    (this.Rollup != null &&
                    this.Rollup.Equals(input.Rollup))
                ) && 
                (
                    this.RunStatus == input.RunStatus ||
                    this.RunStatus != null &&
                    input.RunStatus != null &&
                    this.RunStatus.SequenceEqual(input.RunStatus)
                ) && 
                (
                    this.Sid == input.Sid ||
                    (this.Sid != null &&
                    this.Sid.Equals(input.Sid))
                ) && 
                (
                    this.TenantIdVec == input.TenantIdVec ||
                    this.TenantIdVec != null &&
                    input.TenantIdVec != null &&
                    this.TenantIdVec.SequenceEqual(input.TenantIdVec)
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && 
                (
                    this.UnixUid == input.UnixUid ||
                    (this.UnixUid != null &&
                    this.UnixUid.Equals(input.UnixUid))
                ) && 
                (
                    this.VaultIds == input.VaultIds ||
                    this.VaultIds != null &&
                    input.VaultIds != null &&
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
                if (this.AllUnderHierarchy != null)
                    hashCode = hashCode * 59 + this.AllUnderHierarchy.GetHashCode();
                if (this.CompactVersion != null)
                    hashCode = hashCode * 59 + this.CompactVersion.GetHashCode();
                if (this.ConsecutiveFailures != null)
                    hashCode = hashCode * 59 + this.ConsecutiveFailures.GetHashCode();
                if (this.Environment != null)
                    hashCode = hashCode * 59 + this.Environment.GetHashCode();
                if (this.HealthStatus != null)
                    hashCode = hashCode * 59 + this.HealthStatus.GetHashCode();
                if (this.HostOsType != null)
                    hashCode = hashCode * 59 + this.HostOsType.GetHashCode();
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
                if (this.RegisteredSourceId != null)
                    hashCode = hashCode * 59 + this.RegisteredSourceId.GetHashCode();
                if (this.RegisteredSourceIds != null)
                    hashCode = hashCode * 59 + this.RegisteredSourceIds.GetHashCode();
                if (this.Rollup != null)
                    hashCode = hashCode * 59 + this.Rollup.GetHashCode();
                if (this.RunStatus != null)
                    hashCode = hashCode * 59 + this.RunStatus.GetHashCode();
                if (this.Sid != null)
                    hashCode = hashCode * 59 + this.Sid.GetHashCode();
                if (this.TenantIdVec != null)
                    hashCode = hashCode * 59 + this.TenantIdVec.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
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

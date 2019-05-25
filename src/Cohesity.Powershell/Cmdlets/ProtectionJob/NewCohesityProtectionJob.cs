// Copyright 2018 Cohesity Inc.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Cohesity.Model;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.ProtectionJob
{
    /// <summary>
    /// <para type="synopsis">
    /// Creates a new protection job.
    /// </para>
    /// <para type="description">
    /// Returns the created protection job.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   New-CohesityProtectionJob -Name 'Test-Job-View' -Description 'Protects a View' -PolicyId 4816026365909361:1530076822448:1 -Environment kView -ViewName cohesity_int_19417 -StorageDomainId 3144
    ///   </code>
    ///   <para>
    ///   Creates a protection job for protecting a Cohesity View.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.New, "CohesityProtectionJob")]
    [OutputType(typeof(Models.ProtectionJob))]
    public class NewCohesityProtectionJob : PSCmdlet
    {
        private Session Session
        {
            get
            {
                var result = SessionState.PSVariable.GetValue("Session") as Session;
                if (result == null)
                {
                    result = new Session();
                    SessionState.PSVariable.Set("Session", result);
                }
                return result;
            }
        }

        /// <summary>
        /// <para type="description">
        /// Specifies the name of the protection job.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty()]
        public string Name { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the description of the protection job.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        [ValidateNotNullOrEmpty()]
        public string Description { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the unique id of the protection policy associated with the protection job.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true, ParameterSetName = "CreateById")]
        [ValidateNotNullOrEmpty()]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the name of the protection policy associated with the protection job.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true, ParameterSetName = "CreateByName")]
        [ValidateNotNullOrEmpty()]
        public string PolicyName { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the unique id of the parent protection source (such as a vCenter server) protected by this protection job.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long? ParentSourceId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the unique id of the protection source objects (such as a virtual machines) protected by this protection job.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipeline = true)]
        public long[] SourceIds { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies a list of Source ids from a Protection Source that should not be protected by this Protection Job.
        /// Both leaf and non-leaf Objects may be specified in this list.
        /// An Object in this list must have its ancestor in the SourceIds list.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long[] ExcludeSourceIds { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies a list of VM tag ids to protect VMs with the corresponding tags.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long[] VmTagIds { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies a list of VM tag ids to exclude VMs with the corresponding tags.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long[] ExcludeVmTagIds { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the timezone for this protection job. Must be a string in Olson time zone format such as "America/Los_Angeles".
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public string Timezone { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the start date time for this protection job.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public DateTime ScheduleStartTime { get; set; } = DateTime.Now;

        /// <summary>
        /// <para type="description">
        /// Specifies the storage domain (view box) id where this job writes data.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true, ParameterSetName = "CreateById")]
        public long StorageDomainId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the name of the storage domain associated with the protection job.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true, ParameterSetName = "CreateByName")]
        [ValidateNotNullOrEmpty()]
        public string StorageDomainName { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the name of the View associated with the protection job.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public string ViewName { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the number of minutes that a Job Run of a Full (no CBT) backup schedule is expected to complete within, also known as a Service-Level Agreement (SLA).
        /// A SLA violation is reported when the run time of a Job Run exceeds the SLA time period specified for this backup schedule.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long? FullSLATimeInMinutes { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the number of minutes that a Job Run of a CBT-based backup schedule is expected to complete within, also known as a Service-Level Agreement (SLA).
        /// A SLA violation is reported when the run time of a Job Run exceeds the SLA time period specified for this backup schedule.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long? IncrementalSLATimeInMinutes { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the environment that this job is protecting. Default is kView.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public EnvironmentEnum? Environment { get; set; }

        [Parameter()]
        public SourceSpecialParameter[] SourceSpecialParameters { get; set; }

        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            Session.AssertAuthentication();
        }

        protected override void ProcessRecord()
        {
            if (string.IsNullOrWhiteSpace(Timezone))
                Timezone = TimeZoneInfoExtensions.GetOlsonTimeZone();

            if (!string.IsNullOrWhiteSpace(PolicyName))
            {
                var policy = RestApiCommon.GetPolicyByName(Session.ApiClient, PolicyName);
                PolicyId = policy.Id;
            }

            if (!string.IsNullOrWhiteSpace(StorageDomainName))
            {
                var domain = RestApiCommon.GetStorageDomainByName(Session.ApiClient, StorageDomainName);
                StorageDomainId = (long) domain.Id;
            }

            var newProtectionJob = new Models.ProtectionJob(name: Name, policyId: PolicyId, viewBoxId: StorageDomainId)
            {
                Timezone = Timezone,
                StartTime = new ProtectionScheduleStartTime_(ScheduleStartTime.Hour, ScheduleStartTime.Minute)
            };

            if (ParentSourceId.HasValue)
                newProtectionJob.ParentSourceId = ParentSourceId;

            if (SourceIds != null && SourceIds.Any())
                newProtectionJob.SourceIds = SourceIds.ToList().ConvertAll<long?>(x => x);

            if (ExcludeSourceIds != null && ExcludeSourceIds.Any())
                newProtectionJob.ExcludeSourceIds = ExcludeSourceIds.ToList().ConvertAll<long?>(x => x);

            if (VmTagIds != null && VmTagIds.Any())
            {
                var vmTagIdsList = VmTagIds.ToList().ConvertAll<long?>(x => x);
                newProtectionJob.VmTagIds = new List<List<long?>>();
                foreach (var vmTagIds in vmTagIdsList)
                {
                    newProtectionJob.VmTagIds.Add(new List<long?> { vmTagIds });
                }
            }  

            if (ExcludeVmTagIds != null && ExcludeVmTagIds.Any())
            {
                var excludeVmTagIdsList = ExcludeVmTagIds.ToList().ConvertAll<long?>(x => x);
                newProtectionJob.ExcludeVmTagIds = new List<List<long?>>();
                foreach (var excludeVmTagIds in excludeVmTagIdsList)
                {
                    newProtectionJob.ExcludeVmTagIds.Add(new List<long?> { excludeVmTagIds });
                }
            }

            if (!string.IsNullOrWhiteSpace(ViewName))
                newProtectionJob.ViewName = ViewName;

            newProtectionJob.Environment = Environment != null ? Environment.ToString() : EnvironmentEnum.kView.ToString();

            if (FullSLATimeInMinutes != null)
                newProtectionJob.FullProtectionSlaTimeMins = FullSLATimeInMinutes;

            if (IncrementalSLATimeInMinutes != null)
                newProtectionJob.IncrementalProtectionSlaTimeMins = IncrementalSLATimeInMinutes;

            if (SourceSpecialParameters != null && SourceSpecialParameters.Any())
            {
                newProtectionJob.SourceSpecialParameters = SourceSpecialParameters.ToList();
            }

            var preparedUrl = $"/public/protectionJobs";
            var result = Session.ApiClient.Post<Models.ProtectionJob>(preparedUrl, newProtectionJob);
            WriteObject(result);
        }
    }
}

using System;
using System.Linq;
using System.Management.Automation;
using Cohesity.Models;
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
    ///   New-CohesityProtectionJob -Name 'Test-Job-View' -Description 'Protects a View' -PolicyID 4816026365909361:1530076822448:1 -Environment 'kView' -ViewName 'cohesity_int_19417' -ViewBoxID 3144
    ///   </code>
    ///   <para>
    ///   Creates a protection job for protecting a View.
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
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty()]
        public string Description { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the unique id of the protection policy associated with the protection job.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty()]
        public string PolicyId { get; set; }

        [Parameter(Mandatory = false)]
        public long? ParentSourceId { get; set; }

        [Parameter(Mandatory = false)]
        public long?[] SourceIds { get; set; }

        [Parameter(Mandatory = false)]
        public string Timezone { get; set; }

        [Parameter(Mandatory = false)]
        public DateTime ScheduleStartTime { get; set; } = DateTime.Now;

        /// <summary>
        /// <para type="description">
        /// Specifies the storage domain (view box) id where this job writes data.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty()]
        public long ViewBoxId { get; set; }

        [Parameter()]
        public string ViewName { get; set; }

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

            if (string.IsNullOrWhiteSpace(Timezone))
                Timezone = TimeZoneInfoExtensions.GetOlsonTimeZone();
        }

        protected override void ProcessRecord()
        {
            var newProtectionJob = new Models.ProtectionJob(name: Name, policyId: PolicyId, viewBoxId: ViewBoxId)
            {
                Timezone = Timezone,
                StartTime = new ProtectionScheduleStartTime_(ScheduleStartTime.Hour, ScheduleStartTime.Minute)
            };

            if (ParentSourceId.HasValue)
                newProtectionJob.ParentSourceId = ParentSourceId;

            if (SourceIds != null && SourceIds.Any())
                newProtectionJob.SourceIds = SourceIds.ToList();

            if (!string.IsNullOrWhiteSpace(ViewName))
                newProtectionJob.ViewName = ViewName;

            newProtectionJob.Environment = Environment != null ? Environment.ToString() : EnvironmentEnum.kView.ToString();

            if (SourceSpecialParameters != null && SourceSpecialParameters.Any())
            {
                newProtectionJob.SourceSpecialParameters = SourceSpecialParameters.ToList();
            }

            var preparedUrl = $"/public/protectionJobs";
            var result = Session.NetworkClient.Post<Models.ProtectionJob>(preparedUrl, newProtectionJob);
            WriteObject(result);
        }
    }
}

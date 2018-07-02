using Cohesity.Models;
using System;
using System.Linq;
using System.Management.Automation;

namespace Cohesity
{
    // Cohesity-CreateDataProtectionJobs -Name "PJName" -PolicyID "PJPolicyID" -ViewBoxID 1

    /// <summary>
    /// <para type="synopsis">
    /// Create a Protection Job.
    /// </para>
    /// <para type="description">
    /// Returns the created Protection Job.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>C:PS&gt;</para>
    ///   <code>
    ///   Cohesity-CreateDataProtectionJobs -Name "My Name" -PolicyID "My PolicyID" -ViewBoxID 1
    ///   </code>
    ///   <para>
    ///   Create a protection job with only required parameters.
    ///   </para>
    /// </example>
    [Cmdlet("Cohesity", "CreateDataProtectionJobs")]
    [OutputType(typeof(ProtectionJob))]
    public class CreateProtectionJobs : PSCmdlet
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
        /// Specifies the name of the Protection Job.
        /// </para>
        /// </summary>
        [Parameter(Position = 1, Mandatory = true)]
        [ValidateNotNullOrEmpty()]
        public string Name { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the description of the Protection Job.
        /// </para>
        /// </summary>
        [Parameter(Position = 2, Mandatory = true)]
        [ValidateNotNullOrEmpty()]

        public string Description { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the unique id of the Protection Policy associated with the Protection Job.
        /// The Policy provides retry settings, Protection Schedules, Priority, SLA, etc. 
        /// The Job defines the Storage Domain (View Box), the Objects to Protect (if applicable), Start Time, Indexing settings, etc.
        /// </para>
        /// </summary>
        [Parameter(Position = 2, Mandatory = true)]
        [ValidateNotNullOrEmpty()]
        public string PolicyID { get; set; }

        [Parameter(Mandatory = false)]
        public long? ParentSourceID { get; set; }

        [Parameter(Mandatory = false)]
        public long?[] SourceIDs { get; set; }

        [Parameter(Mandatory = false)]
        public string Timezone { get; set; }

        [Parameter(Mandatory = false)]
        public DateTime ScheduleStartTime { get; set; } = DateTime.Now;

        /// <summary>
        /// <para type="description">
        /// Specifies the Storage Domain (View Box) id where this Job writes data.
        /// </para>
        /// </summary>
        [Parameter(Position = 3, Mandatory = false)]
        [ValidateNotNullOrEmpty()]
        public long ViewBoxID { get; set; }

        [Parameter()]
        public string ViewName { get; set; }

        [Parameter()]
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
            var newProtectionJob = new ProtectionJob(name: Name, policyId: PolicyID, viewBoxId: ViewBoxID)
            {
                Timezone = Timezone,
                StartTime = new ProtectionScheduleStartTime_(ScheduleStartTime.Hour, ScheduleStartTime.Minute)
            };

            if (ParentSourceID.HasValue)
                newProtectionJob.ParentSourceId = ParentSourceID;

            if (SourceIDs != null && SourceIDs.Any())
                newProtectionJob.SourceIds = SourceIDs.ToList();

            if (!string.IsNullOrWhiteSpace(ViewName))
                newProtectionJob.ViewName = ViewName;

            if (Environment != null)
                newProtectionJob.Environment = Environment.ToString();

            if (SourceSpecialParameters != null && SourceSpecialParameters.Any())
            {
                newProtectionJob.SourceSpecialParameters = SourceSpecialParameters.ToList();
            }
                

            var preparedUrl = $"{Session.NetworkClient.BaseUri.AbsoluteUri}/public/protectionJobs";
            var result = Session.NetworkClient.Post<ProtectionJob>(preparedUrl, newProtectionJob);
            WriteObject(result);
        }
    }
}

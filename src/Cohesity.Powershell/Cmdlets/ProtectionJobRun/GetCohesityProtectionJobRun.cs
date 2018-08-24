using Cohesity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;

namespace Cohesity.Powershell.Cmdlets.ProtectionJobRun
{
    /// <summary>
    /// <para type="synopsis">
    /// List Protection Job Runs filtered by the specified parameters.
    /// </para>
    /// <para type="description">
    /// If no parameters are specified, Job Runs currently on the Cohesity Cluster are returned.
    /// Both running and completed Job Runs are reported.
    /// Specifying parameters filters the results that are returned.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Get-CohesityProtectionJobRun -sourceId 2
    ///   </code>
    ///   <para>
    ///   Only Job Runs protecting the specified sourceId 2 (such as a VM or View) are returned. 
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Get, "CohesityProtectionJobRun")]
    [OutputType(typeof(ProtectionRunInstance))]
    public class GetProtectionJobRun : PSCmdlet
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
        /// Filter by a Protection Job that is specified by id.
        /// If not specified, all Job Runs for all Protection Jobs are returned.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long? JobId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Return a specific Job Run by specifying a time and a jobId.
        /// Specify the time when the Job Run started as a Unix epoch Timestamp (in microseconds).
        /// If this field is specified, jobId must also be specified.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long? StartedTimeUsecs { get; set; } = null;

        /// <summary>
        /// <para type="description">
        /// Filter by a end time specified as a Unix epoch Timestamp (in microseconds).
        /// Only Job Runs that completed before the specified end time are returned.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long? EndTimeUsecs { get; set; } = null;

        /// <summary>
        /// <para type="description">
        /// Specify the number of Job Runs to return.
        /// The newest Job Runs are returned.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long? NumRuns { get; set; } = null;

        /// <summary>
        /// <para type="description">
        /// If true, the individual backup status for all the objects protected by the Job Run are not populated in the response.
        /// For example in a VMware environment, the status of backing up each VM associated with a Job is not returned.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter ExcludeTasks { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by source id. Only Job Runs protecting the specified source (such as a VM or View) are returned.
        /// The source id is assigned by the Cohesity Cluster.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long? SourceId { get; set; } = null;

        /// <summary>
        /// <para type="description">
        /// Filter out Jobs Runs with errors by setting this field.
        /// If not set, Job Runs with errors are returned.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter ExcludeErrorRuns { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by a start time. Only Job Runs that started after the specified time are returned.
        /// Specify the start time as a Unix epoch Timestamp (in microseconds).
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long? StartTimeUsecs { get; set; } = 0;

        /// <summary>
        /// <para type="description">
        /// Filter by run type such as "kFull", "kRegular" or "kLog".
        /// If not specified, Job Runs of all types are returned.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        [ValidateSet("kRegular", "kFull", "kLog", "kSystem", IgnoreCase = true)]
        public string[] RunTypes { get; set; } = null;

        /// <summary>
        /// <para type="description">
        /// Filter out jobs runs that cannot be restored by setting this field.
        /// If not set, Runs without any successful object will be returned.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter ExcludeNonRestoreableRuns { get; set; }

        /// <summary>
        /// Begin Processing
        /// </summary>
        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            Session.AssertAuthentication();
        }

        /// <summary>
        /// Process Record
        /// </summary>
        protected override void ProcessRecord()
        {
            var qb = new QuerystringBuilder();

            if (JobId.HasValue && JobId != null)
                qb.Add("jobId", JobId.Value);

            if (StartedTimeUsecs.HasValue && StartedTimeUsecs != null)
                qb.Add("startedTimeUsecs", StartedTimeUsecs.Value);

            if (EndTimeUsecs.HasValue && EndTimeUsecs != null)
                qb.Add("endTimeUsecs", EndTimeUsecs.Value);

            if (NumRuns.HasValue && NumRuns != null)
                qb.Add("numRuns", NumRuns.Value);

            if (ExcludeTasks.IsPresent)
                qb.Add("excludeTasks", true);

            if (SourceId.HasValue && SourceId != null)
                qb.Add("sourceId", SourceId.Value);

            if (ExcludeErrorRuns.IsPresent)
                qb.Add("excludeErrorRuns", true);

            if (StartTimeUsecs.HasValue && StartTimeUsecs != null)
                qb.Add("startTimeUsecs", StartTimeUsecs.Value);

            if (RunTypes != null && RunTypes.Any())
                qb.Add("runTypes", string.Join(",", RunTypes));

            if (ExcludeNonRestoreableRuns.IsPresent)
                qb.Add("excludeNonRestoreableRuns", true);

            var url = $"/public/protectionRuns{ qb.Build()}";
            var result = Session.NetworkClient.Get<IEnumerable<ProtectionRunInstance>>(url);
            WriteObject(result, true);
        }
    }
}

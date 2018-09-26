// Copyright 2018 Cohesity Inc.
using Cohesity.Models;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.ProtectionJobRun
{
    /// <summary>
    /// <para type="synopsis">
    /// Gets a list of protection job runs filtered by the specified parameters.
    /// </para>
    /// <para type="description">
    /// If no parameters are specified, all the job runs on the Cohesity Cluster are returned.
    /// Specifying parameters filters the results that are returned.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Get-CohesityProtectionJobRun -SourceId 2
    ///   </code>
    ///   <para>
    ///   Only job runs protecting the specified source Id are returned.
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
        /// Filter by a protection job that is specified by id.
        /// If not specified, all job runs for all protection jobs are returned.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long? JobId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Return a specific job run by specifying a time and a jobId.
        /// Specify the time when the job run started as a unix epoch timestamp (in microseconds).
        /// If this field is specified, JobId must also be specified.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long? StartedTime { get; set; } = null;

        /// <summary>
        /// <para type="description">
        /// Filter by a start time. Only job runs that started after the specified time are returned.
        /// Specify the start time as a unix epoch timestamp (in microseconds).
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long? StartTime { get; set; } = 0;

        /// <summary>
        /// <para type="description">
        /// Filter by a end time specified as a unix epoch timestamp (in microseconds).
        /// Only job runs that completed before the specified end time are returned.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long? EndTime { get; set; } = null;

        /// <summary>
        /// <para type="description">
        /// Specify the number of job runs to return.
        /// The newest job runs are returned.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long? NumRuns { get; set; } = null;

        /// <summary>
        /// <para type="description">
        /// If true, the individual backup status for all the objects protected by the job run are not populated in the response.
        /// For example in a VMware environment, the status of backing up each VM associated with a job is not returned.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter ExcludeTasks { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by source id. Only job runs protecting the specified source (such as a VM or View) are returned.
        /// The source id is assigned by the Cohesity Cluster.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long? SourceId { get; set; } = null;

        /// <summary>
        /// <para type="description">
        /// Filter out job runs with errors by setting this field.
        /// If not set, job runs with errors are returned.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter ExcludeErrorRuns { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by run type such as "kFull", "kRegular" or "kLog".
        /// If not specified, job runs of all types are returned.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public string[] RunTypes { get; set; } = null;

        /// <summary>
        /// <para type="description">
        /// Filter out jobs runs that cannot be restored by setting this field.
        /// If not set, runs without any successful object will be returned.
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

            if (StartedTime.HasValue && StartedTime != null)
                qb.Add("startedTimeUsecs", StartedTime.Value);

            if (EndTime.HasValue && EndTime != null)
                qb.Add("endTimeUsecs", EndTime.Value);

            if (NumRuns.HasValue && NumRuns != null)
                qb.Add("numRuns", NumRuns.Value);

            if (ExcludeTasks.IsPresent)
                qb.Add("excludeTasks", true);

            if (SourceId.HasValue && SourceId != null)
                qb.Add("sourceId", SourceId.Value);

            if (ExcludeErrorRuns.IsPresent)
                qb.Add("excludeErrorRuns", true);

            if (StartTime.HasValue && StartTime != null)
                qb.Add("startTimeUsecs", StartTime.Value);

            if (RunTypes != null && RunTypes.Any())
                qb.Add("runTypes", string.Join(",", RunTypes));

            if (ExcludeNonRestoreableRuns.IsPresent)
                qb.Add("excludeNonRestoreableRuns", true);

            var url = $"/public/protectionRuns{ qb.Build()}";
            var result = Session.ApiClient.Get<IEnumerable<ProtectionRunInstance>>(url);
            WriteObject(result, true);
        }
    }
}

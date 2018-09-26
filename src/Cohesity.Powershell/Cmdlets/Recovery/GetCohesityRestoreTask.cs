// Copyright 2018 Cohesity Inc.
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Cohesity.Models;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.Recovery
{
    /// <summary>
    /// <para type="synopsis">
    /// Gets a list of the restore tasks filtered by the specified parameters.
    /// </para>
    /// <para type="description">
    /// If no parameters are specified, all the restore tasks on the Cohesity Cluster are returned.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Get-CohesityRestoreTask -Types kRecoverVMs
    ///   </code>
    ///   <para>
    ///   Returns only the restore tasks that match the type 'kRecoverVMs'.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Get, "CohesityRestoreTask")]
    [OutputType(typeof(RestoreTask))]
    public class GetCohesityRestoreTask : PSCmdlet
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
        /// Filter by a list of task ids.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long[] Ids { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by a list of task types, such as 'kRecoverVMs’, 'kCloneVMs’, ‘kCloneView’ or 'kMountVolumes’.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public RestoreTask.TypeEnum[] Types { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by start date and time by specifying a unix epoch time in microseconds.
        /// All Restore Tasks (both completed and running) on the Cohesity Cluster that started after the specified start time but before the specified end time are returned.
        /// If not set, the start time is creation time of the Cohesity Cluster.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by end date and time by specifying a unix epoch time in microseconds.
        /// All Restore Tasks (both completed and running) on the Cohesity Cluster that started after the specified start time but before the specified end time are returned.
        /// If not set, the end time is the current time.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long? EndTime { get; set; }

        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            Session.AssertAuthentication();
        }

        protected override void ProcessRecord()
        {
            var queries = new Dictionary<string, string>();

            if (Types != null && Types.Any())
                queries.Add("taskTypes", string.Join(",", Types));

            if (Ids != null && Ids.Any())
                queries.Add("taskIds", string.Join(",", Ids));

            if (StartTime.HasValue)
                queries.Add("startTimeUsecs", StartTime.ToString());

            if (EndTime.HasValue)
                queries.Add("endTimeUsecs", EndTime.ToString());

            var queryString = string.Empty;
            if (queries.Any())
                queryString = "?" + string.Join("&", queries.Select(q => $"{q.Key}={q.Value}"));

            var url = $"/public/restore/tasks{queryString}";
            var result = Session.ApiClient.Get<IEnumerable<RestoreTask>>(url);
            WriteObject(result, true);
        }
    }
}

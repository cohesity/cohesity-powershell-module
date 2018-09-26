// Copyright 2018 Cohesity Inc.
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.Alert
{
    /// <summary>
    /// <para type="synopsis">
    /// Returns all Alert Resolution objects found on the Cohesity Cluster that match the filter criteria specified using parameters. 
    /// </para>
    /// <para type="description">
    /// If no filter parameters are specified, all Alert Resolution objects are returned. Each object provides details about the Alert Resolution such as the resolution summary and details.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Get-CohesityAlertResolution -MaxAlerts 10
    ///   </code>
    ///   <para>
    ///   Gets a list of most recent 10 alertResoulitions triggered on the Cohesity Cluster.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Get, "CohesityAlertResolution")]
    [OutputType(typeof(Models.AlertResolution))]
    public class GetCohesityAlertResolution : PSCmdlet
    {
        private Session Session
        {
            get
            {
                if (!(SessionState.PSVariable.GetValue("Session") is Session result))
                {
                    result = new Session();
                    SessionState.PSVariable.Set("Session", result);
                }
                return result;
            }
        }

        /// <summary>
        /// <para type="description">
        /// Limit the number of alerts to the specified value. The newest alerts are returned upto the limit specified.
        /// </para> 
        /// </summary>
        [Parameter(Mandatory = true)]
        public int? MaxAlerts { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by a list of resolution Ids.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public int[] ResolutionIds { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by a list of alert Ids.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public string[] AlertIds { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by start date and time by specifying a unix epoch time in microseconds.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by end date and time by specifying a unix epoch time in microseconds.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long? EndTime { get; set; }

        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            Session.AssertAuthentication();
        }

        /// <summary>
        /// Process Records
        /// </summary>
        protected override void ProcessRecord()
        {
            var queries = new Dictionary<string, string>();

            if (MaxAlerts.HasValue)
                queries.Add("maxAlerts", MaxAlerts.ToString());

             if (ResolutionIds != null && ResolutionIds.Any())
                queries.Add("resolutionIdList", string.Join(",", ResolutionIds));

            if (AlertIds != null && AlertIds.Any())
                queries.Add("alertIdList", string.Join(",", AlertIds));

            if (StartTime.HasValue)
                queries.Add("startDateUsecs", StartTime.ToString());

            if (EndTime.HasValue)
                queries.Add("endDateUsecs", EndTime.ToString());

            var queryString = string.Empty;
            if (queries.Any())
                queryString = "?" + string.Join("&", queries.Select(q => $"{q.Key}={q.Value}"));

            var preparedUrl = $"/public/alertResolutions{queryString}";
            WriteDebug(preparedUrl);
            var result = Session.ApiClient.Get<IEnumerable<Models.AlertResolution>>(preparedUrl);
            WriteObject(result, true);
        }

    }
}


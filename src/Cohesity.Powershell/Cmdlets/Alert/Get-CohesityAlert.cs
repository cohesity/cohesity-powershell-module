﻿using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Cohesity.Powershell.Common;
using static Cohesity.Models.Alert;

namespace Cohesity.Powershell.Cmdlets.Cluster
{
    /// <summary>
    /// <para type="synopsis">
    /// Gets a list of alerts triggered on the Cohesity Cluster filtered by the specified parameters.
    /// </para>
    /// <para type="description">
    /// Gets a list of alerts triggered on the Cohesity Cluster filtered by the specified parameters.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Get-CohesityAlert -MaxAlerts 10
    ///   </code>
    ///   <para>
    ///   Gets a list of most recent 10 alerts triggered on the Cohesity Cluster.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Get, "CohesityAlert")]
    [OutputType(typeof(Models.Alert))]
    public class GetCohesityAlert: PSCmdlet
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
        /// Filter by a list of alert categories such as 'kDisk’, 'kNode’, 'kCluster’, 'kNodeHealth’, 'kClusterHealth’, 'kBackupRestore’, ‘kEncryption’ and 'kArchivalRestore’.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public AlertCategoryEnum[] AlertCategoryList { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by a list of alert states such as ‘kOpen’ and 'kResolved’.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public AlertStateEnum[] AlertStateList { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by a list of alert severities such as 'kCritical’, ‘kWarning’ and 'kInfo’.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public SeverityEnum[] AlertSeverityList { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by a list of resolution Ids.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public int[] ResolutionIdList { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by a list of alert Ids.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public string[] AlertIdList { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by a list of alert types.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public int[] AlertTypeList { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by start date and time by specifying a unix epoch time in microseconds.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public int? StartTime { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by end date and time by specifying a unix epoch time in microseconds.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public int? EndTime { get; set; }

        /// <summary>
        /// Process Records
        /// </summary>
        protected override void ProcessRecord()
        {
            var queries = new Dictionary<string, string>();

            if (MaxAlerts.HasValue)
                queries.Add("maxAlerts", MaxAlerts.ToString());

            if (AlertCategoryList != null && AlertCategoryList.Any())
                queries.Add("alertCategoryList", string.Join(",", AlertCategoryList));

            if (AlertStateList != null && AlertStateList.Any())
                queries.Add("alertStateList", string.Join(",", AlertStateList));

            if (AlertSeverityList != null && AlertSeverityList.Any())
                queries.Add("alertSeverityList", string.Join(",", AlertSeverityList));

            if (ResolutionIdList != null && ResolutionIdList.Any())
                queries.Add("resolutionIdList", string.Join(",", ResolutionIdList));

            if (AlertIdList != null && AlertIdList.Any())
                queries.Add("alertIdList", string.Join(",", AlertIdList));

            if (AlertTypeList != null && AlertTypeList.Any())
                queries.Add("alertTypeList", string.Join(",", AlertTypeList));

            if (StartTime.HasValue)
                queries.Add("startDateUsecs", StartTime.ToString());

            if (EndTime.HasValue)
                queries.Add("endDateUsecs", EndTime.ToString());

            var queryString = string.Empty;
            if (queries.Any())
                queryString = "?" + string.Join("&", queries.Select(q => $"{q.Key}={q.Value}"));

            var preparedUrl = $"/public/alerts{queryString}";
            WriteDebug(preparedUrl);
            var result = Session.NetworkClient.Get<IEnumerable<Models.Alert>>(preparedUrl);
            WriteObject(result, true);
        }

    }
}
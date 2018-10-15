// Copyright 2018 Cohesity Inc.
using System.Linq;
using System.Management.Automation;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.AuditLog
{
    /// <summary>
    /// <para type="synopsis">
    /// Gets a list of audit logs generated on the Cohesity Cluster. 
    /// </para>
    /// <para type="description">
    /// If no parameters are specified, all audit logs currently on the Cohesity Cluster are returned. 
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Get-CohesityAuditLog -UserNames admin
    ///   </code>
    ///   <para>
    ///   All audit logs related to the username admin are displayed.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Get, "CohesityAuditLog")]
    [OutputType(typeof(Models.ClusterAuditLog))]
    public class GetCohesityAuditLog : PSCmdlet
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
        /// Filter by user names who caused the actions that generate Cluster Audit Logs.
        /// </para> 
        /// </summary>
        [Parameter(Mandatory = false)]
        public string[] UserNames { get; set; } = null;

        /// <summary>
        /// <para type="description">
        /// Filter by domains of users who caused the actions that trigger Cluster audit logs.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public string[] Domains { get; set; } = null;

        /// <summary>
        /// <para type="description">
        /// Filter by entity types involved in the actions that generate the Cluster audit logs, such as User, Protection Job, View, etc.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public string[] EntityTypes { get; set; } = null;

        /// <summary>
        /// <para type="description">
        /// Filter by the actions that generate Cluster audit logs such as Activate, Cancel, Clone, Create, etc.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public string[] Actions { get; set; } = null;

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

        /// <summary>
        /// <para type="description">
        /// Filter by matching a substring in entity name or details of the Cluster audit logs.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public string Search { get; set; } = string.Empty;

        /// <summary>
        /// <para type="description">
        /// Specifies an index number that can be used to return subsets of items in multiple requests.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long? StartIndex { get; set; }

        /// <summary>
        /// <para type="description">
        /// Limit the number of items to return in the response for pagination purposes. Default value is 1000.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long? PageCount { get; set; }

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
            var queries = new QuerystringBuilder();

            if (StartIndex != null)
                queries.Add("startIndex", StartIndex.Value);

            if (PageCount != null)
                queries.Add("pageCount", PageCount.Value);

            if (Domains != null && Domains.Any())
                queries.Add("domains", string.Join(",", Domains));

            if (EntityTypes != null && EntityTypes.Any())
                queries.Add("entityTypes", string.Join(",", EntityTypes));

            if (Actions != null && Actions.Any())
                queries.Add("actions", string.Join(",", Actions));

            if (!string.IsNullOrWhiteSpace(Search))
                queries.Add("search", Search.Trim());

            if (UserNames != null && UserNames.Any())
                queries.Add("userNames", string.Join(",", UserNames));

            if (StartTime.HasValue)
                queries.Add("startTimeUsecs", StartTime.ToString());

            if (EndTime.HasValue)
                queries.Add("endTimeUsecs", EndTime.ToString());

            var preparedUrl = $"/public/auditLogs/cluster{queries.Build()}";
            WriteDebug(preparedUrl);
            var result = Session.ApiClient.Get<Models.ClusterAuditLogsSearchResult>(preparedUrl);
            WriteObject(result.ClusterAuditLogs, true);
        }

    }
}


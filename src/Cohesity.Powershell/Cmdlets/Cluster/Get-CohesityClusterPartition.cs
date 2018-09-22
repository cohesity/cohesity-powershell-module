// Copyright 2018 Cohesity Inc.
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.Cluster
{
    /// <summary>
    /// <para type="synopsis">
    /// Gets a list of partitions in the Cohesity Cluster.
    /// </para>
    /// <para type="description">
    /// Gets a list of partitions in the Cohesity Cluster.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Get-CohesityClusterPartition
    ///   </code>
    ///   <para>
    ///   Gets a list of partitions in the Cohesity Cluster.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Get, "CohesityClusterPartition")]
    [OutputType(typeof(Models.ClusterPartition))]
    public class GetCohesityClusterPartition: PSCmdlet
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
        /// Filter by a list of cluster partition ids.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public int[] Ids { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by a list of cluster partition names.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public string[] Names { get; set; }

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

            if (Ids != null && Ids.Any())
                queries.Add("ids", string.Join(",", Ids));

            if (Names != null && Names.Any())
                queries.Add("names", string.Join(",", Names));

            var queryString = string.Empty;
            if (queries.Any())
                queryString = "?" + string.Join("&", queries.Select(q => $"{q.Key}={q.Value}"));

            var preparedUrl = $"/public/clusterPartitions{queryString}";
            var result = Session.ApiClient.Get<IEnumerable<Models.ClusterPartition>>(preparedUrl);
            WriteObject(result, true);
        }

    }
}

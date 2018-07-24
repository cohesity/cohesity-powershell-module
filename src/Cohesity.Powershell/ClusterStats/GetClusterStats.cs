using Cohesity.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;

namespace Cohesity.ClusterStats
{
    /// <summary>
    /// <para type="synopsis">
    /// Returns information about the Cohesity Cluster.
    /// </para>
    /// <para type="description">
    /// Returns information about the Cohesity Cluster with stats.
    /// Specifying parameters filters the results that are returned.
    /// </para>
    /// </summary>
    [Cmdlet("Get", "CohesityClusterStats")]
    [OutputType(typeof(Cluster))]
    public class GetClusterStats : PSCmdlet
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

        private bool fetchStats = false;

        [Parameter(Position = 1, Mandatory = false)]
        public SwitchParameter FetchStats
        {
            get { return fetchStats; }
            set { fetchStats = value; }
        }

        //[Parameter(Position = 1, Mandatory = false)]
        //public bool? FetchStats { get; set; }

        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            Session.AssertAuthentication();
        }

        protected override void ProcessRecord()
        {
            var qb = new QuerystringBuilder();

            //if (FetchStats.HasValue && FetchStats.Value)
            //    qb.Add("fetchStats", FetchStats.Value);
            if (FetchStats)
                qb.Add("fetchStats", FetchStats.ToString());


            var preparedUrl = $"{Session.NetworkClient.BaseUri.AbsoluteUri}/public/cluster{qb.Build()}";
            var result = Session.NetworkClient.Get<Cluster>(preparedUrl);
            WriteObject(result, true);
        }

    }
}

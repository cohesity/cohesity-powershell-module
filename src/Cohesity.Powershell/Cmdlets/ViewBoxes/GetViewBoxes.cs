using Cohesity.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;

namespace Cohesity
{
    /// <summary>
    /// <para type="synopsis">
    /// List Domains (View Boxes) filtered by the specified parameters.
    /// </para>
    /// <para type="description">
    /// If no parameters are specified, all Domains (View Boxes) currently on the Cohesity Cluster are returned.
    /// Specifying parameters filters the results that are returned.
    /// </para>
    /// </summary>
    [Cmdlet("Get", "CohesityViewBox")]
    [OutputType(typeof(ViewBox))]
    public class GetViewBoxes : PSCmdlet
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
        /// Filter by a list of Storage Domain (View Box) ids.
        /// If empty, View Boxes are not filtered by id.
        /// </para>
        /// </summary>
        [Parameter(Position = 1, Mandatory = false)]
        public int[] IDs { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by a list of Storage Domain (View Box) Names.
        /// If empty, Storage Domains(View Boxes) are not filtered by Name.
        /// </para> 
        /// </summary>
        [Parameter(Position = 2, Mandatory = false)]
        public string[] Names { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by a list of Cluster Partition Ids.
        /// </para>
        /// </summary>
        [Parameter(Position = 3, Mandatory = false)]
        public int[] ClusterPartitionIDs { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies whether to include usage and performance statistics.
        /// </para> 
        /// </summary>
        [Parameter(Position = 4, Mandatory = false)]
        public bool? FetchStats { get; set; }


        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            Session.AssertAuthentication();
        }

        protected override void ProcessRecord()
        {
            var qb = new QuerystringBuilder();

            if (IDs != null && IDs.Any())
                qb.Add("ids", IDs);

            if (Names != null && Names.Any())
                qb.Add("names", Names);

            if (ClusterPartitionIDs != null && ClusterPartitionIDs.Any())
                qb.Add("clusterPartitionIds", ClusterPartitionIDs);

            if (FetchStats.HasValue && FetchStats.Value)
                qb.Add("fetchStats", FetchStats.Value);

            var preparedUrl = $"/public/viewBoxes{qb.Build()}";
            var result = Session.NetworkClient.Get<IEnumerable<ViewBox>>(preparedUrl);            
            WriteObject(result, true);
        }
    }
}

// Copyright 2018 Cohesity Inc.
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Cohesity.Models;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.StorageDomain
{
    /// <summary>
    /// <para type="synopsis">
    /// Gets a list of storage domains (view boxes) filtered by the specified parameters.
    /// </para>
    /// <para type="description">
    /// If no parameters are specified, all storage domains (view boxes) on the Cohesity Cluster are returned.
    /// Specifying parameters filters the results that are returned.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Get-CohesityStorageDomain -Names Test-Domain
    ///   </code>
    ///   <para>
    ///   Returns the storage domain that matches the name "Test-Domain".
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Get, "CohesityStorageDomain")]
    [OutputType(typeof(ViewBox))]
    public class GetCohesityStorageDomain : PSCmdlet
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
        /// Filter by a list of storage domain (view box) ids.
        /// If empty, view boxes are not filtered by id.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public int[] Ids { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by a list of storage domain (view box) names.
        /// If empty, storage domains(view boxes) are not filtered by name.
        /// </para> 
        /// </summary>
        [Parameter(Mandatory = false)]
        public string[] Names { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by a list of cluster partition Ids.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public int[] ClusterPartitionIds { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies whether to include usage and performance statistics.
        /// </para> 
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter FetchStats { get; set; }


        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            Session.AssertAuthentication();
        }

        protected override void ProcessRecord()
        {
            var qb = new QuerystringBuilder();

            if (Ids != null && Ids.Any())
                qb.Add("ids", Ids);

            if (Names != null && Names.Any())
                qb.Add("names", Names);

            if (ClusterPartitionIds != null && ClusterPartitionIds.Any())
                qb.Add("clusterPartitionIds", ClusterPartitionIds);

            if (FetchStats.IsPresent)
                qb.Add("fetchStats", true.ToString());

            var preparedUrl = $"/public/viewBoxes{qb.Build()}";
            var result = Session.ApiClient.Get<IEnumerable<ViewBox>>(preparedUrl);            
            WriteObject(result, true);
        }
    }
}

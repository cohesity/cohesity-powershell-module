// Copyright 2018 Cohesity Inc.
using System.Management.Automation;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.Cluster
{
    /// <summary>
    /// <para type="synopsis">
    /// Gets the Cohesity Cluster configuration.
    /// </para>
    /// <para type="description">
    /// If FetchStats parameter is specified, returns stats along with the Cohesity Cluster configuration.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Get-CohesityClusterConfiguration -FetchStats 
    ///   </code>
    ///   <para>
    ///   Returns stats along with the Cohesity Cluster configuration.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Get, "CohesityClusterConfiguration")]
    [OutputType(typeof(Models.Cluster))]
    public class GetCohesityClusterConfiguration : PSCmdlet
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
        /// If specified, also gets stats along with the Cohesity Cluster configuration.
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

            if (FetchStats.IsPresent)
                qb.Add("fetchStats", true);

            var preparedUrl = $"/public/cluster{qb.Build()}";
            var result = Session.ApiClient.Get<Models.Cluster>(preparedUrl);
            WriteObject(result);
        }

    }
}

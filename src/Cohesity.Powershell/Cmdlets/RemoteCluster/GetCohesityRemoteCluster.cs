// Copyright 2018 Cohesity Inc.
using System.Collections.Generic;
using System.Management.Automation;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.RemoteCluster
{
    /// <summary>
    /// <para type="synopsis">
    /// Gets a list of the remote clusters registered with the Cohesity Cluster
    /// </para>
    /// <para type="description">
    /// All remote clusters that are registered with the Cohesity Cluster are returned.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Get-CohesityRemoteCluster
    ///   </code>
    ///   <para>
    ///   Returns all the registered remote clusters.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Get, "CohesityRemoteCluster")]
    [OutputType(typeof(Models.RemoteCluster))]
    public class GetCohesityRemoteCluster : PSCmdlet
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

        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            Session.AssertAuthentication();
        }

        protected override void ProcessRecord()
        {
            var url = $"/public/remoteClusters";
            var results = Session.ApiClient.Get<List<Models.RemoteCluster>>(url);
            WriteObject(results, true);
        }
    }
}

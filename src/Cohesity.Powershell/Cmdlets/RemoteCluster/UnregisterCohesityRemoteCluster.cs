// Copyright 2018 Cohesity Inc.
using System.Management.Automation;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.RemoteCluster
{
    /// <summary>
    /// <para type="synopsis">
    /// Unregisters the specified remote cluster from the Cohesity Cluster.
    /// </para>
    /// <para type="description">
    /// Unregisters the specified remote cluster from the Cohesity Cluster.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Unregister-CohesityRemoteCluster -ClusterId 7539516053202252
    ///   </code>
    ///   <para>
    ///   Unregisters the given remote cluster.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsLifecycle.Unregister, "CohesityRemoteCluster")]
    public class UnregisterCohesityRemoteCluster : PSCmdlet
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

        #region Params

        /// <summary>
        /// <para type="description">
        /// Specifies a unique id of the remote cluster.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ParameterSetName = "ById")]
        [ValidateRange(1, long.MaxValue)]
        public long Id { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies a remote cluster object.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipeline = true, ParameterSetName = "ByObject")]  
        public Model.RemoteCluster RemoteCluster { get; set; }

        #endregion

        #region Processing

        /// <summary>
        /// Preprocess
        /// </summary>
        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            Session.AssertAuthentication();
        }

        /// <summary>
        /// Process
        /// </summary>
        protected override void ProcessRecord()
        {
            if(RemoteCluster != null)
            {
                Id = (long)RemoteCluster.ClusterId;
            }
            // DELETE /public/remoteClusters/{id}
            var preparedUrl = $"/public/remoteClusters/{Id.ToString()}";
            Session.ApiClient.Delete(preparedUrl, string.Empty);

            WriteObject($"Remote cluster with cluster id {Id} was unregistered successfully");
        }

        #endregion
    }
}
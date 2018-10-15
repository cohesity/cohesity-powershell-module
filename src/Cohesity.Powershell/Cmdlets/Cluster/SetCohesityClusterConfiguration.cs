// Copyright 2018 Cohesity Inc.
using System.Management.Automation;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.Cluster
{
    /// <summary>
    /// <para type="synopsis">
    /// Updates the Cohesity Cluster configuration.
    /// </para>
    /// <para type="description">
    /// Returns the Updated Cohesity Cluster configuration.
    /// </para>
    /// </summary>
    /// <example>
    /// <para>PS&gt;</para>
    /// <code>
    /// Set-CohesityClusterConfiguration -ClusterConfiguration $config
    /// </code>
    /// <para>
    /// Updates the Cohesity Cluster configuration with specified parameters.
    /// </para>
    /// </example>

    [Cmdlet(VerbsCommon.Set, "CohesityClusterConfiguration")]
    [OutputType(typeof(Models.Cluster))]
    public class SetCohesityClusterConfiguration : PSCmdlet
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
        /// The updated Cohesity Cluster Configuration.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipeline = true)]
        public Models.Cluster ClusterConfiguration { get; set; } = null;

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
            // PUT public/cluster
            var preparedUrl = $"/public/cluster";
            var result = Session.ApiClient.Put<Models.Cluster>(preparedUrl, ClusterConfiguration);
            WriteObject(result);
        }

        #endregion

    }
}


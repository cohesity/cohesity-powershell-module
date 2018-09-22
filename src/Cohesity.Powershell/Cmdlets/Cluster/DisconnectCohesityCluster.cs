// Copyright 2018 Cohesity Inc.
using System.Management.Automation;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.Cluster
{
    /// <summary>
    /// <para type="synopsis">
    /// Disconnects from the Cohesity Cluster.
    /// </para>
    /// <para type="description">
    /// Disconnects from the Cohesity Cluster and invalidates the session.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Disconnect-CohesityCluster
    ///   </code>
    ///   <para>
    ///   Disconnects from the Cohesity Cluster and invalidates the session.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommunications.Disconnect, "CohesityCluster")]
    public class DisconnectCohesityCluster: PSCmdlet
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

        private readonly UserProfileProvider userProfileProvider;

        /// <summary>
        /// Construct the cmdlet.
        /// </summary>
        public DisconnectCohesityCluster()
        {
            userProfileProvider = ServiceLocator.GetUserProfileProvider();
        }

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
            userProfileProvider.DeleteUserProfile();
            Session.ApiClient.Disconnect();

            WriteObject("Disconnected from the Cohesity Cluster");
        }

    }
}

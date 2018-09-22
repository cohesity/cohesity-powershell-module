// Copyright 2018 Cohesity Inc.
using System.Management.Automation;
using Cohesity.Models;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.ProtectionSource
{
    /// <summary>
    /// <para type="synopsis">
    /// Registers a new Isilon protection source with the Cohesity Cluster.
    /// </para>
    /// <para type="description">
    /// Registers a new Isilon protection source with the Cohesity Cluster.
    /// </para>
    /// </summary>
    /// <example>
    /// <para>PS&gt;</para>
    /// <code>
    /// Register-CohesityProtectionSourceIsilon -Server isilon-cluster.example.com -Credential (Get-Credential)
    /// </code>
    /// <para>
    /// Registers a new Isilon cluster with hostname "isilon-cluster.example.com" with the Cohesity Cluster.
    /// </para>
    /// </example>
    [Cmdlet(VerbsLifecycle.Register, "CohesityProtectionSourceIsilon")]
    [OutputType(typeof(Models.ProtectionSource))]
    public class RegisterCohesityProtectionSourceIsilon : PSCmdlet
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

        #region Params

        /// <summary>
        /// <para type="description">
        /// Hostname or IP Address for the Isilon cluster.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        public string Server { get; set; } = null;

        /// <summary>
        /// <para type="description">
        /// User credentials for the Isilon cluster.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        public PSCredential Credential { get; set; } = null;

        #endregion

        #region Processing

        protected override void BeginProcessing()
        {
            base.BeginProcessing();
            Session.AssertAuthentication();
        }

        protected override void ProcessRecord()
        {
            var param = new RegisterProtectionSourceParameters
            {
                Environment = EnvironmentEnum.kIsilon,
                Endpoint = Server,
                Username = Credential.UserName,
                Password = Credential.GetNetworkCredential().Password
            };

            // POST /public/protectionSources/register
            var preparedUrl = $"/public/protectionSources/register";
            var result = Session.ApiClient.Post<Models.ProtectionSource>(preparedUrl, param);
            WriteObject(result);
        }

        #endregion
    }
}
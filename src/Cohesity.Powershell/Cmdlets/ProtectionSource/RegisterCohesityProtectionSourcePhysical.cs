// Copyright 2018 Cohesity Inc.
using System.Management.Automation;
using Cohesity.Models;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.ProtectionSource
{
    /// <summary>
    /// <para type="synopsis">
    /// Registers a new Physical protection source with the Cohesity Cluster.
    /// </para>
    /// <para type="description">
    /// Registers a new Physical protection source with the Cohesity Cluster.
    /// </para>
    /// </summary>
    /// <example>
    /// <para>PS&gt;</para>
    /// <code>
    /// Register-CohesityProtectionSourcePhysical -Server server.example.com -HostType KLinux -PhysicalType KHost
    /// </code>
    /// <para>
    /// Registers a physical linux server with hostname "server.example.com" with the Cohesity Cluster.
    /// </para>
    /// </example>
    [Cmdlet(VerbsLifecycle.Register, "CohesityProtectionSourcePhysical")]
    [OutputType(typeof(Models.ProtectionSource))]
    public class RegisterCohesityProtectionSourcePhysical : PSCmdlet
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
        /// Hostname or IP Address of the Physical server.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        public string Server { get; set; } = null;

        /// <summary>
        /// <para type="description">
        /// Type of host. Must be set to KLinux or KWindows.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        public RegisterProtectionSourceParameters.HostTypeEnum? HostType { get; set; } = null;

        /// <summary>
        /// <para type="description">
        /// Type of physical host. Must be set to KHost or KWindowsCluster.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        public RegisterProtectionSourceParameters.PhysicalTypeEnum? PhysicalType { get; set; } = null;

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
                Environment = EnvironmentEnum.kPhysical,
                Endpoint = Server,
                HostType = HostType,
                PhysicalType = PhysicalType
            };

            // POST /public/protectionSources/register
            var preparedUrl = $"/public/protectionSources/register";
            var result = Session.ApiClient.Post<Models.ProtectionSource>(preparedUrl, param);
            WriteObject(result);
        }

        #endregion
    }
}
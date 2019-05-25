// Copyright 2018 Cohesity Inc.
using System.Collections.Generic;
using System.Management.Automation;
using Cohesity.Model;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.ProtectionSource
{
    /// <summary>
    /// <para type="synopsis">
    /// Registers an existing source as running MS SQL application.
    /// </para>
    /// <para type="description">
    /// Registers an existing source as running MS SQL application.
    /// </para>
    /// </summary>
    /// <example>
    /// <para>PS&gt;</para>
    /// <code>
    /// Register-CohesityProtectionSourceMSSQL -Id $sourceId -HasPersistentAgent
    /// </code>
    /// <para>
    /// Registers the specified source as running MS SQL application and uses the installed agent to connect.
    /// </para>
    /// </example>
    /// <example>
    /// <para>PS&gt;</para>
    /// <code>
    /// Register-CohesityProtectionSourceMSSQL -Id $sourceId -Credential (Get-Credential)
    /// </code>
    /// <para>
    /// Registers the specified source as running MS SQL application and connects using provided credentials.
    /// </para>
    /// </example>
    [Cmdlet(VerbsLifecycle.Register, "CohesityProtectionSourceMSSQL")]
    [OutputType(typeof(Models.ProtectionSource))]
    public class RegisterCohesityProtectionSourceMSSQL : PSCmdlet
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
        /// Specifies the Id of the Protection Source that has MS SQL Application Server running on it.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true)]
        public long Id { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies if a persistent agent is running on the host.
        /// If this is specified, then credentials are not used.
        /// This mechanism may be used in environments such as VMware to get around UAC permission issues by running the agent as a service with the right credentials.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true, ParameterSetName = "UseAgent")]
        public SwitchParameter HasPersistentAgent { get; set; }

        /// <summary>
        /// <para type="description">
        /// User credentials used to connect to the host.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true, ParameterSetName = "UseCredential")]
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
            var apps = new List<RegisterApplicationServersParameters.ApplicationsEnum>();
            apps.Add(RegisterApplicationServersParameters.ApplicationsEnum.KSQL);

            var param = new RegisterApplicationServersParameters(applications: apps)
            {
                ProtectionSourceId = Id,
                HasPersistentAgent = HasPersistentAgent.IsPresent
            };

            if(Credential != null)
            {
                param.Username = Credential.UserName;
                param.Password = Credential.GetNetworkCredential().Password;
            }

            // POST /public/protectionSources/applicationServers
            var preparedUrl = $"/public/protectionSources/applicationServers";
            var result = Session.ApiClient.Post<Models.ProtectionSource>(preparedUrl, param);
            WriteObject(result);
        }

        #endregion
    }
}
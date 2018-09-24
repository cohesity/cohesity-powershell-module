// Copyright 2018 Cohesity Inc.
using System.Collections.Generic;
using System.Management.Automation;
using Cohesity.Models;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.Agent
{
    /// <summary>
    /// <para type="synopsis">
    /// Upgrades the Cohesity agent on a Physical server registered with Cohesity.
    /// </para>
    /// <para type="description">
    /// Upgrades the Cohesity agent on a Physical server registered with Cohesity.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Update-CohesityPhysicalAgent -Id 12
    ///   </code>
    ///   <para>
    ///   Upgrades the physical agent with the specified Id.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsData.Update, "CohesityPhysicalAgent")]
    public class UpdateCohesityPhysicalAgent : PSCmdlet
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
        /// Specifies a unique id of the physical agent.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true)]
        [ValidateRange(1, long.MaxValue)]
        public long Id { get; set; }

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
            var agentIds = new List<long?> { Id };
            var content = new UpgradePhysicalServerAgents(agentIds);

            // POST public/physicalAgents/upgrade
            var preparedUrl = $"/public/physicalAgents/upgrade";
            var response = Session.ApiClient.Post<Models.UpgradePhysicalAgentsMessage>(preparedUrl, content);
            WriteObject("Upgrading physical agents started successfully");
        }

        #endregion
    }
}

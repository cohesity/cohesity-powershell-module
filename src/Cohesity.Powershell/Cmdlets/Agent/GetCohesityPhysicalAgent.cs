// Copyright 2018 Cohesity Inc.
using Cohesity.Models;
using Cohesity.Powershell.Common;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Cohesity.Powershell.Cmdlets.Agent
{
    /// <summary>
    /// <para type="synopsis">
    /// Gets a list of the registered physical agents with their information.
    /// </para>
    /// <para type="description">
    /// Gets a list of the registered physical agents with their information.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Get-CohesityPhysicalAgent
    ///   </code>
    ///   <para>
    ///   Gets a list of the registered physical agents with their information.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Get, "CohesityPhysicalAgent")]
    [OutputType(typeof(AgentInformation))]
    public class GetCohesityPhysicalAgent : PSCmdlet
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
            var qb = new QuerystringBuilder();

            var environments = new EnvironmentEnum[] { EnvironmentEnum.kPhysical };
            qb.Add("environment", string.Join(",", environments));

            var url = $"/public/protectionSources{qb.Build()}";
            var results = Session.ApiClient.Get<IEnumerable<ProtectionSourceNode>>(url);
            results = FlattenNodes(results);

            List<AgentInformation> agents = new List<AgentInformation>();
            foreach(var result in results)
            {
                if(result.ProtectionSource.PhysicalProtectionSource.Agents != null)
                {
                    agents.AddRange(result.ProtectionSource.PhysicalProtectionSource.Agents);
                }
            }

            WriteObject(agents, true);
        }

        private IEnumerable<ProtectionSourceNode> FlattenNodes(IEnumerable<ProtectionSourceNode> nodes)
        {
            if (nodes == null || !nodes.Any())
                return Enumerable.Empty<ProtectionSourceNode>();

            var result = new List<ProtectionSourceNode>();

            foreach(var node in nodes)
            {
                var childrenNodes = node.Nodes;
                node.Nodes = null;
                result.Add(node);
                result.AddRange(FlattenNodes(childrenNodes));
            }

            return result;
        }
    }
}

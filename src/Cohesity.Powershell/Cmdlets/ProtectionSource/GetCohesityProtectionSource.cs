// Copyright 2018 Cohesity Inc.
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Cohesity.Models;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.ProtectionSource
{
    /// <summary>
    /// <para type="synopsis">
    /// Gets a list of the registered protection sources filtered by the specified parameters.
    /// </para>
    /// <para type="description">
    /// If no parameters are specified, all protection sources that are registered on the Cohesity Cluster are returned.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Get-CohesityProtectionSource -Environments kVMware
    ///   </code>
    ///   <para>
    ///   Returns registered protection sources that match the environment type 'kVMware’.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Get, "CohesityProtectionSource")]
    [OutputType(typeof(ProtectionSourceNode))]
    public class GetCohesityProtectionSource : PSCmdlet
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
        /// Return only protection sources that match the passed in environment type.
        /// For example, set this parameter to ‘kVMware’ to only return the VMware sources.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public EnvironmentEnum[] Environments { get; set; }

        /// <summary>
        /// <para type="description">
        /// Return only the protection source that matches the Id.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long? Id { get; set; }

        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            Session.AssertAuthentication();
        }

        protected override void ProcessRecord()
        {
            var qb = new QuerystringBuilder();

            if (Id.HasValue)
                qb.Add("id", Id.Value);
            
            if (Environments != null && Environments.Any())
                qb.Add("environments", string.Join(",", Environments));
            
            var url = $"/public/protectionSources/rootNodes{qb.Build()}";
            var results = Session.ApiClient.Get<List<ProtectionSourceNode>>(url);

            // Get the list of all group nodes
            var groups = results.Where(x => x.RegistrationInfo == null).ToList();

            foreach(var group in groups)
            {
                // Get children for each group node
                qb = new QuerystringBuilder();
                qb.Add("id", group.ProtectionSource.Id.ToString());
                url = $"/public/protectionSources{qb.Build()}";
                var children = Session.ApiClient.Get<List<ProtectionSourceNode>>(url);
                children = FlattenNodes(children);

                foreach(var child in children)
                {
                    if(child.RegistrationInfo != null)
                    {
                        results.Add(child);
                    }
                }
            }

            // Skip kView, kAgent, kPuppeteer environment types and group nodes themselves
            results = results.Where(x =>
                (x.ProtectionSource.Environment != EnvironmentEnum.kAgent) &&
                (x.ProtectionSource.Environment != EnvironmentEnum.kView) &&
                (x.ProtectionSource.Environment != EnvironmentEnum.kPuppeteer) &&
                (x.RegistrationInfo != null)
            ).ToList();

            // Make sure each source id is only listed once as it might repeat under different environments
            var sources = results.GroupBy(x => x.ProtectionSource.Id).Select(y => y.FirstOrDefault());

            WriteObject(sources, true);
        }

        private List<ProtectionSourceNode> FlattenNodes(List<ProtectionSourceNode> nodes)
        {
            var result = new List<ProtectionSourceNode>();
            if (nodes == null || !nodes.Any())
                return result;

            foreach (var node in nodes)
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

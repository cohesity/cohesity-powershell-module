// Copyright 2018 Cohesity Inc.
using Cohesity.Models;
using Cohesity.Powershell.Common;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Cohesity.Powershell.Cmdlets.ProtectionSource
{
    /// <summary>
    /// <para type="synopsis">
    /// Gets a list of the registered Protection Sources and their Objects.
    /// </para>
    /// <para type="description">
    /// If no parameters are specified, all Protection Sources on the Cohesity Cluster are returned.
    /// In addition, the sub objects for each Source are also returned.
    /// Specifying the parameters can filter the results that are returned.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Get-CohesityProtectionSourceObject -Environments kPhysical
    ///   </code>
    ///   <para>
    ///   Returns registered protection sources that match the environment type 'kPhysical’ and all their objects.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Get, "CohesityProtectionSourceObject")]
    [OutputType(typeof(Models.ProtectionSource))]
    public class GetCohesityProtectionSourceObject : PSCmdlet
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
        /// Set this parameter to true to also return kDatastore object types found in the Source in addition to their Object subtrees.
        /// By default, datastores are not returned.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter IncludeDatastores { get; set; }

        /// <summary>
        /// <para type="description">
        /// Set this parameter to true to also return kNetwork object types found in the Source in addition to their Object subtrees.
        /// By default, network objects are not returned.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter IncludeNetworks { get; set; }

        /// <summary>
        /// <para type="description">
        /// Set this parameter to true to also return kVMFolder object types found in the Source in addition to their Object subtrees.
        /// By default, VM folder objects are not returned.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter IncludeVMFolders { get; set; }

        /// <summary>
        /// <para type="description">
        /// Return only Protection Sources that match the passed in environment type.
        /// For example, set this parameter to ‘kVMware’ to only return the Sources (and their objects) found in the "kVMware" (VMware) environment.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public EnvironmentEnum[] Environments { get; set; }

        /// <summary>
        /// <para type="description">
        /// Return the Object subtree for the passed in Protection Source id.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipeline = true)]
        public long? Id { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter out the Object types (and their subtrees) that match the passed in types.
        /// For example, set this parameter to "kResourcePool" to exclude Resource Pool Objects from being returned.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public string[] ExcludeTypes { get; set; }


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

            if (IncludeDatastores.IsPresent)
                qb.Add("includeDatastores", true);

            if (IncludeNetworks.IsPresent)
                qb.Add("includeNetworks", true);

            if (IncludeVMFolders.IsPresent)
                qb.Add("includeVMFolders", true);

            if (Environments != null && Environments.Any())
                qb.Add("environment", string.Join(",", Environments));

            if (ExcludeTypes != null && ExcludeTypes.Any())
                qb.Add("excludeTypes", ExcludeTypes);

            var url = $"/public/protectionSources{qb.Build()}";
            var results = Session.ApiClient.Get<IEnumerable<ProtectionSourceNode>>(url);
            results = FlattenNodes(results);

            // Extract ProtectionSource objects
            List<Models.ProtectionSource> sources = results.Select(x => x.ProtectionSource).ToList();

            WriteObject(sources, true);
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

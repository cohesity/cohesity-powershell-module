// Copyright 2018 Cohesity Inc.
using Cohesity.Model;
using Cohesity.Powershell.Common;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Cohesity.Powershell.Cmdlets.ProtectionSource
{
    /// <summary>
    /// <para type="synopsis">
    /// Gets a list of the registered Protection Sources and their sub objects.
    /// </para>
    /// <para type="description">
    /// If no parameters are specified, all the Protection Sources and their sub objects are returned.
    /// Specifying additional parameters can filter the results that are returned.
    /// If you only want to get a specific object you can specify the -Id parameter.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Get-CohesityProtectionSourceObject -Environments kPhysical
    ///   </code>
    ///   <para>
    ///   Returns all the registered protection sources and their sub objects that match the environment type 'kPhysical’.
    ///   </para>
    /// </example>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Get-CohesityProtectionSourceObject -Id 1234
    ///   </code>
    ///   <para>
    ///   Returns only the object that matches the specified id.
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
        /// Set this parameter to also return kDatastore type of objects.
        /// By default, datastores are not returned.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter IncludeDatastores { get; set; }

        /// <summary>
        /// <para type="description">
        /// Set this parameter to also return kNetwork type of objects.
        /// By default, network objects are not returned.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter IncludeNetworks { get; set; }

        /// <summary>
        /// <para type="description">
        /// Set this parameter to also return kVMFolder type of objects.
        /// By default, VM folder objects are not returned.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter IncludeVMFolders { get; set; }

        /// <summary>
        /// <para type="description">
        /// Return only Protection Sources that match the passed in environment type.
        /// For example, set this parameter to ‘kVMware’ to only return the Sources (and their sub objects) found in the VMware environment.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public EnvironmentEnum[] Environments { get; set; }

        /// <summary>
        /// <para type="description">
        /// Returns only the object specified by the id.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipeline = true)]
        public long? Id { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter out the Object types (and their sub objects) that match the passed in types.
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
            {
                var url = $"/public/protectionSources/objects/{Id.ToString()}";
                var result = Session.ApiClient.Get<Models.ProtectionSource>(url);
                WriteObject(result);
            }
            else
            {
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

using Cohesity.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;

namespace Cohesity
{
    /// <summary>
    /// <para type="synopsis">
    /// Returns the registered Protection Sources and their Object subtrees.
    /// </para>
    /// <para type="description">
    /// If no parameters are specified, all Protection Sources that are registered on the Cohesity Cluster are returned.
    /// In addition, an Object subtree gathered from each Source is returned.
    /// For example, the Cohesity Cluster interrogates a Source VMware vCenter Server and creates an hierarchical Object subtree that mirrors the Inventory tree on vCenter Server.
    /// The contents of the Object tree is returned as a “nodes” hierarchy of "protectionSource"s.
    /// Specifying parameters can alter the results that are returned.
    /// </para>
    /// </summary>
    [Cmdlet("Cohesity", "ListProtectionSources")]
    [OutputType(typeof(ProtectionSourceNode))]
    public class GetProtectionSources : PSCmdlet
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
        [Parameter(Position = 1, Mandatory = false)]
        public SwitchParameter IncludeDatastores { get; set; }

        /// <summary>
        /// <para type="description">
        /// Set this parameter to true to also return kNetwork object types found in the Source in addition to their Object subtrees.
        /// By default, network objects are not returned.
        /// </para>
        /// </summary>
        [Parameter(Position = 2, Mandatory = false)]
        public SwitchParameter IncludeNetworks { get; set; }

        /// <summary>
        /// <para type="description">
        /// Set this parameter to true to also return kVMFolder object types found in the Source in addition to their Object subtrees.
        /// By default, VM folder objects are not returned.
        /// </para>
        /// </summary>
        [Parameter(Position = 3, Mandatory = false)]
        public SwitchParameter IncludeVMFolders { get; set; }

        /// <summary>
        /// <para type="description">
        /// Return only Protection Sources that match the passed in environment type.
        /// For example, set this parameter to ‘kVMware’ to only return the Sources (and their Object subtrees) found in the "kVMware" (VMware vCenter Server) environment.
        /// NOTE: "kPuppeteer" refers to Cohesity's Remote Adapter. 
        /// </para>
        /// </summary>
        [Parameter(Position = 4, Mandatory = false)]
        //[ValidateSet("kVMware", "kView", "kSQL", "kPuppeteer", "kPhysical", "kPure", "kNetapp", "kGenericNas", "kHyperV", "kAcropolis", "kAzure")]
        public EnvironmentEnum[] Environments { get; set; }

        /// <summary>
        /// <para type="description">
        /// Return the Object subtree for the passed in Protection Source id.
        /// </para>
        /// </summary>
        [Parameter(Position = 5, Mandatory = false)]
        public long ID { get; set; }
        
        /// <summary>
        /// <para type="description">
        /// Filter out the Object types (and their subtrees) that match the passed in types.
        /// For example, set this parameter to "kResourcePool" to exclude Resource Pool Objects from being returned.
        /// </para>
        /// </summary>
        [Parameter(Position = 6, Mandatory = false)]
        public string[] ExcludeTypes { get; set; }
        

        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            Session.AssertAuthentication();
        }

        protected override void ProcessRecord()
        {
            var qb = new QuerystringBuilder();

            if (IncludeDatastores.IsPresent)
                qb.Add("includeDatastores", true);

            if (IncludeNetworks.IsPresent)
                qb.Add("includeNetworks", true);

            if (IncludeVMFolders.IsPresent)
                qb.Add("includeVMFolders", true);
            
            if (Environments != null && Environments.Any())
                qb.Add("environments", string.Join(",", Environments));

            if (ExcludeTypes != null && ExcludeTypes.Any())
                qb.Add("excludeTypes", ExcludeTypes);
            
            var url = $"{Session.NetworkClient.BaseUri.AbsoluteUri}/public/protectionSources{qb.Build()}";
            var result = Session.NetworkClient.Get<IEnumerable<ProtectionSourceNode>>(url);
            WriteObject(result, true);
        }
    }
}

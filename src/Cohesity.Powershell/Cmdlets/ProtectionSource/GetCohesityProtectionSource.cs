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
    ///   Get-CohesityProtectionSource -environment kVMware
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
        /// NOTE: "kPuppeteer" refers to Cohesity's Remote Adapter.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        //[ValidateSet("kVMware", "kView", "kSQL", "kPuppeteer", "kPhysical", "kPure", "kNetapp", "kGenericNas", "kHyperV", "kAcropolis", "kAzure")]
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
            var result = Session.NetworkClient.Get<IEnumerable<ProtectionSourceNode>>(url);
            WriteObject(result, true);
        }
    }
}

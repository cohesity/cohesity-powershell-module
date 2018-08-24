using Cohesity.Models;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.ProtectionSource
{
    /// <summary>
    /// <para type="synopsis">
    /// Returns the Virtual Machines in a vCenter Server.
    /// </para>
    /// <para type="description">
    /// Returns all Virtual Machines found in all the vCenter Servers registered on the Cohesity Cluster that match the filter criteria specified using parameters.
    /// If an id is specified, only VMs found in the specified vCenter Server are returned.
    /// Only VM Objects are returned.
    /// Other VMware Objects such as datacenters are not returned.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Get-CohesityVM -ParentSourceId 1234
    ///   </code>
    ///   <para>
    ///   Get the Virtual Machine Sources belonging to the vCenter Server with the ParentSourceID of 1234.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Get, "CohesityVM")]
    [OutputType(typeof(ProtectionSource_))]
    public class GetCohesityVM : PSCmdlet
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
        /// Limit the VMs returned to the set of VMs found in a specific vCenter Server. Pass in the root Protection Source id for the vCenter Server to search for VMs.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long? ParentSourceId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Limit the returned VMs to those that exactly match the passed in VM name.
        /// To match multiple VM names, specify multiple names that each specify a single VM name.
        /// The string must exactly match the passed in VM name and wild cards are not supported.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public string[] Names { get; set; } = null;

        /// <summary>
        /// <para type="description">
        /// Limit the returned VMs to those that exactly match the passed in UUIDs.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public string[] UUIDs { get; set; } = null;

        /// <summary>
        /// <para type="description">
        /// Limit the returned VMs to those that have been protected by a Protection Job.
        /// By default, both protected and unprotected VMs are returned.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter Protected { get; set; } = false;

        /// <summary>
        /// Begin Processing
        /// </summary>
        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            Session.AssertAuthentication();
        }

        /// <summary>
        /// Process Record
        /// </summary>
        protected override void ProcessRecord()
        {
            var qb = new QuerystringBuilder();

            if (ParentSourceId != null && ParentSourceId.HasValue)
                qb.Add("ParentSourceId", ParentSourceId.Value);

            if (Names != null && Names.Any())
                qb.Add("names", string.Join(",", Names));

            if (UUIDs != null && UUIDs.Any())
                qb.Add("uuids", string.Join(",", UUIDs));

            if (Protected.IsPresent)
                qb.Add("protected", true);

            var url = $"/public/protectionSources/virtualMachines{ qb.Build()}";
            var result = Session.NetworkClient.Get<IEnumerable<ProtectionSource_>>(url);
            WriteObject(result, true);
        }
    }
}

// Copyright 2018 Cohesity Inc.
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.ProtectionSource
{
    /// <summary>
    /// <para type="synopsis">
    /// Gets a list of the VMware virtual machines known to the Cohesity Cluster.
    /// </para>
    /// <para type="description">
    /// Returns all the VMware virtual machines known to the Cohesity Cluster that match the filter criteria specified using parameters.
    /// If the ParentSourceId is specified, only VMs found in that parent source (such as a vCenter Server) are returned.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Get-CohesityVMwareVM -ParentSourceId 2
    ///   </code>
    ///   <para>
    ///   Gets a list of the virtual machines belonging to the vCenter Server with the ParentSourceId of 2.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Get, "CohesityVMwareVM")]
    [OutputType(typeof(Models.ProtectionSource))]
    public class GetCohesityVMwareVM : PSCmdlet
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
        /// Limit the VMs returned to the set of VMs found in a specific parent source (such as vCenter Server).
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long? ParentSourceId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Limit the returned VMs to those that exactly match the passed in VM name.
        /// To match multiple VM names, specify multiple names separated by commas.
        /// The string must exactly match the passed in VM name and wild cards are not supported.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public string[] Names { get; set; } = null;

        /// <summary>
        /// <para type="description">
        /// Limit the returned VMs to those that exactly match the passed in Uuids.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public string[] Uuids { get; set; } = null;

        /// <summary>
        /// <para type="description">
        /// Limit the returned VMs to those that have been protected by a protection job.
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

            if (ParentSourceId != null)
                qb.Add("vCenterId", ParentSourceId.Value);

            if (Names != null && Names.Any())
                qb.Add("names", string.Join(",", Names));

            if (Uuids != null && Uuids.Any())
                qb.Add("uuids", string.Join(",", Uuids));

            if (Protected.IsPresent)
                qb.Add("protected", true);

            var url = $"/public/protectionSources/virtualMachines{ qb.Build()}";
            var result = Session.ApiClient.Get<IEnumerable<Models.ProtectionSource>>(url);
            WriteObject(result, true);
        }
    }
}

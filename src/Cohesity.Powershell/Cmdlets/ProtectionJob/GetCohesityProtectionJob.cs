// Copyright 2018 Cohesity Inc.
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Cohesity.Models;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.ProtectionJob
{
    /// <summary>
    /// <para type="synopsis">
    /// Gets a list of protection jobs filtered by the specified parameters.
    /// </para>
    /// <para type="description">
    /// If no parameters are specified, all protection jobs (both active and inactive) on the Cohesity Cluster are returned.
    /// Note that the deleted protection jobs are not returned, by default.
    /// You may specify the OnlyDeleted parameter to get the deleted protection jobs.
    /// Specifying parameters filters the results that are returned.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Get-CohesityProtectionJob -Names Test-Job
    ///   </code>
    ///   <para>
    ///   Gets the protection job with name "Test-Job".
    ///   </para>
    /// </example>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Get-CohesityProtectionJob -OnlyActive
    ///   </code>
    ///   <para>
    ///   Gets only the active protection jobs on the Cohesity Cluster.
    ///   </para>
    /// </example>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Get-CohesityProtectionJob -OnlyDeleted
    ///   </code>
    ///   <para>
    ///   Gets only the deleted protection jobs on the Cohesity Cluster.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Get, "CohesityProtectionJob")]
    [OutputType(typeof(Models.ProtectionJob))]
    public class GetCohesityProtectionJob : PSCmdlet
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
        /// Filter by a list of protection job ids.
        /// </para> 
        /// </summary>
        [Parameter(Mandatory = false)]
        public int[] Ids { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by a list of protection job names.
        /// </para> 
        /// </summary>
        [Parameter(Mandatory = false)]
        public string[] Names { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by policy ids that are associated with protection jobs. 
        /// Only jobs associated with the specified policy ids, are returned.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public string[] PolicyIds { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by environment types such as kVMware, kView, kSQL, kPuppeteer, kPhysical, kPure, kNetapp, kGenericNas, kHyperV, kAcropolis, kAzure. 
        /// Only jobs protecting the specified environment types are returned. 
        /// NOTE: kPuppeteer refers to Cohesity's remote adapter.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public EnvironmentEnum[] Environments { get; set; }

        /// <summary>
        /// <para type="description">
        /// If set, only the active jobs are returned.
        /// </para> 
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter OnlyActive { get; set; }

        /// <summary>
        /// <para type="description">
        /// If set, only the inactive jobs are returned.
        /// </para> 
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter OnlyInactive { get; set; }

        /// <summary>
        /// <para type="description">
        /// If set, return only the deleted jobs that still have snapshots associated with them.
        /// If not set, the deleted jobs are not returned.
        /// </para> 
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter OnlyDeleted { get; set; }


        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            Session.AssertAuthentication();
        }

        protected override void ProcessRecord()
        {
            var queries = new Dictionary<string, string>();

            // Always include last run and stats
            queries.Add("includeLastRunAndStats", true.ToString().ToLower());

            if (OnlyActive.IsPresent)
                queries.Add("isActive", true.ToString().ToLower());

            if (OnlyInactive.IsPresent)
                queries.Add("isActive", false.ToString().ToLower());

            if (OnlyDeleted.IsPresent)
                queries.Add("isDeleted", true.ToString().ToLower());

            if (Ids != null && Ids.Any())
                queries.Add("ids", string.Join(",", Ids));

            if (Names != null && Names.Any())
                queries.Add("names", string.Join(",", Names));

            if (PolicyIds != null && PolicyIds.Any())
                queries.Add("policyIds", string.Join(",", PolicyIds));

            if (Environments != null && Environments.Any())
                queries.Add("environments", string.Join(",", Environments));

            var queryString = string.Empty;
            if (queries.Any())
                queryString = "?" + string.Join("&", queries.Select(q => $"{q.Key}={q.Value}"));

            var preparedUrl = $"/public/protectionJobs{queryString}";
            var results = Session.ApiClient.Get<IEnumerable<Models.ProtectionJob>>(preparedUrl);

            // Hide deleted protection jobs unless explicitly asked for
            if (!OnlyDeleted.IsPresent)
            {
                results = results.Where(x => !(x.Name.StartsWith("_DELETED"))).ToList();
            }
            WriteObject(results, true);
        }
    }
}

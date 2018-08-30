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
    /// If no parameters are specified, all protection jobs currently on the Cohesity Cluster are returned.
    /// Specifying parameters filters the results that are returned.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Get-CohesityProtectionJob -Names TestJob
    ///   </code>
    ///   <para>
    ///   Displays the protection job with name "TestJob".
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
        /// Filter by inactive or active jobs. If not set, all inactive and active jobs are returned.If true, only active jobs are returned.
        /// If false, only inactive jobs are returned.
        /// When you create a protection job on a primary cluster with a replication schedule, the cluster creates an
        /// inactive copy of the job on the remote cluster.
        /// In addition, when an active and running job is deactivated, the job becomes inactive.
        /// </para> 
        /// </summary>
        [Parameter(Mandatory = false)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// <para type="description">
        /// If true, return only protection jobs that have been deleted but still have snapshots associated with them.
        /// If false, return all protection jobs except those jobs that have been deleted and still have snapshots associated with them.
        /// A job that is deleted with all its snapshots is not returned for either of these cases.
        /// </para> 
        /// </summary>
        [Parameter(Mandatory = false)]
        public bool? IsDeleted { get; set; }

        private bool includeLastRunAndStats = false;

        /// <summary>
        /// <para type="description">
        /// If true, return the last protection run of the job and the summary stats.
        /// </para> 
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter IncludeLastRunAndStats
        {
            get { return includeLastRunAndStats; }
            set { includeLastRunAndStats = value; }
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


        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            Session.AssertAuthentication();
        }

        protected override void ProcessRecord()
        {
            var queries = new Dictionary<string, string>();

            if (IsActive.HasValue)
                queries.Add("isActive", IsActive.ToString());

            if (IsDeleted.HasValue)
                queries.Add("isDeleted", IsDeleted.ToString());

            if (IncludeLastRunAndStats)
                queries.Add("includeLastRunAndStats", IncludeLastRunAndStats.ToString());

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
            var result = Session.NetworkClient.Get<IEnumerable<Models.ProtectionJob>>(preparedUrl);
            WriteObject(result, true);
        }
    }
}

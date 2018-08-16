using Cohesity.Models;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Cohesity
{
    /// <summary>
    /// <para type="synopsis">
    /// Gets a list of Protection Jobs filtered by the specified parameters.
    /// </para>
    /// <para type="description">
    /// If no parameters are specified, all Protection Jobs currently on the Cohesity Cluster are returned.
    /// Specifying parameters filters the results that are returned.
    /// </para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "CohesityProtectionJob")]
    [OutputType(typeof(ProtectionJob))]
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
        /// Filter by Policy ids that are associated with Protection Jobs. 
        /// Only Jobs associated with the specified Policy ids, are returned. 
        /// (optional)
        /// </para>
        /// </summary>
        [Alias("P")]
        [Parameter(Position = 1, Mandatory = false)]
        public string[] PolicyIds { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by environment types such as kVMware, kView, kSQL, kPuppeteer, kPhysical, kPure, kNetapp, kGenericNas, kHyperV, kAcropolis, kAzure. 
        /// Only Jobs protecting the specified environment types are returned. 
        /// NOTE: kPuppeteer; refers to Cohesity's Remote Adapter. 
        /// (optional)
        /// </para>
        /// </summary>
        [Alias("E")]
        [Parameter(Position = 2, Mandatory = false)]
        public EnvironmentEnum[] Environments { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by Inactive or Active Jobs. If not set, all Inactive and Active Jobs are returned.If true, only Active Jobs are returned.
        /// If false, only Inactive Jobs are returned.
        /// When you create a Protection Job on a Primary Cluster with a replication schedule, the Cluster creates an
        /// Inactive copy of the Job on the Remote Cluster.
        /// In addition, when an Active and running Job is deactivated, the Job becomes Inactive.
        /// </para> 
        /// </summary>
        [Parameter(Position = 3, Mandatory = false)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// <para type="description">
        /// If true, return only Protection Jobs that have been deleted but still have Snapshots associated with them.
        /// If false, return all Protection Jobs except those Jobs that have been deleted and still have Snapshots associated with them.
        /// A Job that is deleted with all its Snapshots is not returned for either of these cases.
        /// </para> 
        /// </summary>
        [Parameter(Position = 4, Mandatory = false)]
        public bool? IsDeleted { get; set; }

        private bool includeLastRunAndStats = false;

        /// <summary>
        /// <para type="description">
        /// If true, return the last Protection Run of the Job and the summary stats.
        /// </para> 
        /// </summary>
        [Parameter(Position = 5, Mandatory = false)]
        public SwitchParameter IncludeLastRunAndStats
        {
            get { return includeLastRunAndStats; }
            set { includeLastRunAndStats = value; }
        }

        /// <summary>
        /// <para type="description">
        /// Filter by a list of Protection Job ids.
        /// </para> 
        /// </summary>
        [Parameter(Position = 6, Mandatory = false)]
        public int[] Ids { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by a list of Protection Job names.
        /// </para> 
        /// </summary>
        [Parameter(Position = 7, Mandatory = false)]
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
            var result = Session.NetworkClient.Get<IEnumerable<ProtectionJob>>(preparedUrl);
            WriteObject(result, true);
        }
    }
}

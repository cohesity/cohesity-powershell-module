using Cohesity.Models;
using Cohesity.Powershell.Common;
using System.Linq;
using System.Management.Automation;

namespace Cohesity.Powershell.Cmdlets.ProtectionJobRun
{
    /// <summary>
    /// <para type="synopsis">
    /// Update how long Protection Job Runs and their snapshots are retained on the Cohesity Cluster.
    /// </para>
    /// <para type="description">
    /// Update the expiration date (retention period) for the specified Protection Job Runs and their snapshots.
    /// After an expiration time is reached, the Job Run and its snapshots are deleted.
    /// If an expiration time of 0 is specified, a Job Run and its snapshots are immediately deleted.
    /// </para>
    /// </summary>
    [Cmdlet("Set", "CohesityProtectionJobRun")]
    public class SetCohesityProtectionJobRun : PSCmdlet
    {
        private Session Session
        {
            get
            {
                if (!(SessionState.PSVariable.GetValue("Session") is Session result))
                {
                    result = new Session();
                    SessionState.PSVariable.Set("Session", result);
                }
                return result;
            }
        }

        /// <summary>
        /// <para type="description">
        /// Specifies the Job Runs to update with a new expiration times.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public UpdateProtectionJobRun[] JobRuns { get; set; }

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
            var body = new UpdateProtectionJobRunsParam(JobRuns.ToList());

            var url = $"/public/protectionRuns";
            var result = Session.NetworkClient.Put(url, body);
            WriteObject("Protection Job Run set.");
        }
    }
}

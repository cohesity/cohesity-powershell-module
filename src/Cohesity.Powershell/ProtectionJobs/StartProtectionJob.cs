using Cohesity.Models;
using System.Linq;
using System.Management.Automation;
using static Cohesity.Models.RunProtectionJobParam;

namespace Cohesity.ProtectionJobs
{
    // public/protectionJobs/run/{id}

    /// <summary>
    /// <para type="synopsis">
    /// Immediately execute a single Protection Job Run.
    /// </para>
    /// <para type="description">
    /// Immediately excute a single Job Run and ignore the schedule defined in the Policy.
    /// A Protection Policy associated with the Job may define up to three backup run types:
    ///     Regular (CBT utilized), 2) Full(CBT not utilized) and 3) Log.
    ///     The passed in run type defines what type of backup is done by the Job Run.
    ///     The schedule defined in the Policy for the backup run type is ignored but other settings such as the snapshot retention and retry settings are used.
    ///     Returns success if the Job Run starts.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>C:PS&gt;</para>
    ///   <code>
    ///   Cohesity-CreateDataProtectionJobs -Name "My Name" -PolicyID "My PolicyID" -ViewBoxID 1
    ///   </code>
    ///   <para>
    ///   Create a protection job with only required parameters.
    ///   </para>
    /// </example>
    [Cmdlet("Start", "CohesityProtectionJob")]
    public class StartProtectionJob : PSCmdlet
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

        #region Params

        /// <summary>
        /// <para type="description">
        /// Specifies a unique id of the Protection Job.
        /// </para>
        /// </summary>
        [Parameter(Position = 1, Mandatory = true)]
        [ValidateRange(1, long.MaxValue)]
        public long Id { get; set; }


        /// <summary>
        /// <para type="description">
        /// Specifies the type of backup. If not specified, "kRegular" is assumed.
        /// </para>
        /// </summary>
        [Parameter(Position = 2, Mandatory = false)]
        public RunTypeEnum RunType { get; set; } = RunTypeEnum.KRegular;

        /// <summary>
        /// <para type="description">
        /// If you want to back up only a subset of sources that are protected by the job in this run.
        /// </para>
        /// </summary>
        [Parameter(Position = 3, Mandatory = false)]
        public long?[] SourceIDs { get; set; } = null;

        /// <summary>
        /// <para type="description">
        /// Set if you want specific replication or archival associated with the policy to run.
        /// </para>
        /// </summary>
        [Parameter(Position = 3, Mandatory = false)]
        public RunJobSnapshotTarget[] CopyRunTargets { get; set; } = null;

        #endregion

        #region Processing

        /// <summary>
        /// Preprocess
        /// </summary>
        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            Session.AssertAuthentication();

            if (Id <= 0)
            {
                throw new ParameterBindingException($"Parameter {nameof(Id)} must be greater than zero.");
            }
        }

        /// <summary>
        /// Process
        /// </summary>
        protected override void ProcessRecord()
        {
            var copyRunTargets = CopyRunTargets != null ? CopyRunTargets.ToList() : null;
            var sourceIDs = SourceIDs != null ? SourceIDs.ToList() : null;

            var content = new RunProtectionJobParam(copyRunTargets, RunType, sourceIDs);

            // POST public/protectionJobs/run/{id}
            var preparedUrl = $"{Session.NetworkClient.BaseUri.AbsoluteUri}/public/protectionJobs/run/{Id.ToString()}";
            Session.NetworkClient.Post(preparedUrl, content);
            WriteObject("Protection Job run.");
        }

        #endregion

    }
}

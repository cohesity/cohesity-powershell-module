// Copyright 2018 Cohesity Inc.
using System.Linq;
using System.Management.Automation;
using Cohesity.Models;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.ProtectionJob
{
    /// <summary>
    /// <para type="synopsis">
    /// Immediately starts a protection job run.
    /// </para>
    /// <para type="description">
    /// Immediately starts a protection job run.
    /// A protection policy associated with the job may define various backup run types:
    /// Regular (Incremental, CBT utilized), Full (CBT not utilized), Log, System.
    /// The passed in run type defines what type of backup is performed by the job run.
    /// The schedule defined in the policy for the backup run type is ignored but other settings such as the snapshot retention and retry settings are used.
    /// Returns success if the job run starts.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Start-CohesityProtectionJob -Id 1234
    ///   </code>
    ///   <para>
    ///   Immediately starts a job run for the given protection job.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsLifecycle.Start, "CohesityProtectionJob")]
    public class StartCohesityProtectionJob : PSCmdlet
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
        /// Specifies a unique id of the protection job.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true)]
        [ValidateRange(1, long.MaxValue)]
        public long Id { get; set; }


        /// <summary>
        /// <para type="description">
        /// Specifies the type of backup. If not specified, "KRegular" is assumed.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public RunProtectionJobParam.RunTypeEnum RunType { get; set; } = RunProtectionJobParam.RunTypeEnum.KRegular;

        /// <summary>
        /// <para type="description">
        /// If you want to back up only a subset of sources that are protected by the job in this run.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long?[] SourceIds { get; set; } = null;

        /// <summary>
        /// <para type="description">
        /// Set if you want specific replication or archival associated with the policy to run.
        /// </para>
        /// </summary>
        //[Parameter(Mandatory = false)]
        //public RunJobSnapshotTarget[] CopyRunTargets { get; set; } = null;

        #endregion

        #region Processing

        /// <summary>
        /// Preprocess
        /// </summary>
        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            Session.AssertAuthentication();
        }

        /// <summary>
        /// Process
        /// </summary>
        protected override void ProcessRecord()
        {
            //var copyRunTargets = CopyRunTargets != null ? CopyRunTargets.ToList() : null;
            var sourceIDs = SourceIds != null ? SourceIds.ToList() : null;

            var content = new RunProtectionJobParam
            {
                //CopyRunTargets = copyRunTargets,
                RunType = RunType,
                SourceIds = sourceIDs
            };

            // POST public/protectionJobs/run/{id}
            var preparedUrl = $"/public/protectionJobs/run/{Id.ToString()}";
            Session.ApiClient.Post(preparedUrl, content);
            WriteObject("Protection job was started successfully.");
        }

        #endregion
    }
}

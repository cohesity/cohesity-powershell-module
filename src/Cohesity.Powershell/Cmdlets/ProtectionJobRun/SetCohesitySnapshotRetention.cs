// Copyright 2018 Cohesity Inc.
using System.Collections.Generic;
using System.Management.Automation;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.ProtectionJobRun
{
    /// <summary>
    /// <para type="synopsis">
    /// Changes the retention of the snapshots associated with a Protection Job.
    /// </para>
    /// <para type="description">
    /// Returns success if the retention for snapshots is updated successfully.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Set-CohesitySnapshotRetention -JobName Test-Job -JobRunId 2123 -ExtendByDays 30
    ///   </code>
    ///   <para>
    ///   Extends the retention of the snapshots associated with the specified Protection Job and Job Run Id by 30 days.
    ///   </para>
    /// </example>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Set-CohesitySnapshotRetention -JobName Test-Job -JobRunId 2123 -ReduceByDays 30
    ///   </code>
    ///   <para>
    ///   Reduces the retention of the snapshots associated with the specified Protection Job and Job Run Id by 30 days.
    ///   </para>
    /// </example>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Set-CohesitySnapshotRetention -JobName Test-Job -JobRunId 2123 -ExtendByDays 30 -SourceIds 883
    ///   </code>
    ///   <para>
    ///   Extends the retention of the snapshots associated with only the specified Source Id (such as a VM), Protection Job and Job Run Id by 30 days.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Set, "CohesitySnapshotRetention")]
    public class SetCohesitySnapshotRetention : PSCmdlet
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
        /// The name of the Protection Job.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty()]
        public string JobName { get; set; }

        /// <summary>
        /// <para type="description">
        /// The unique id of the Protection Job Run.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        [ValidateRange(1, long.MaxValue)]
        public long JobRunId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the number of days by which the Snapshot retention will be extended.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true, ParameterSetName = "ExtendRetention")]
        public long? ExtendByDays { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the number of days by which the Snapshot retention will be reduced.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true, ParameterSetName = "ReduceRetention")]
        public long? ReduceByDays { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the source ids to only select snapshots belonging to these source ids.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long[] SourceIds { get; set; }

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
            var job = RestApiCommon.GetProtectionJobByName(Session.ApiClient, JobName);
            var jobRuns = RestApiCommon.GetProtectionJobRunsByJobId(Session.ApiClient, (long)job.Id);

            foreach(var jobRun in jobRuns)
            {
                bool snapshotDeleted = (bool)jobRun.BackupRun.SnapshotsDeleted;
                if (!snapshotDeleted)
                {
                    if (JobRunId == jobRun.BackupRun.JobRunId)
                    {
                        var copyRunTargets = new List<Model.RunJobSnapshotTarget>();
                        var target = new Model.RunJobSnapshotTarget
                        {
                            Type = Model.RunJobSnapshotTarget.TypeEnum.KLocal
                        };

                        if (ExtendByDays.HasValue)
                        {
                            target.DaysToKeep = ExtendByDays;
                        }
                        else if(ReduceByDays.HasValue)
                        {
                            target.DaysToKeep = -ReduceByDays;
                        }

                        copyRunTargets.Add(target);

                        var run = new Model.UpdateProtectionJobRun
                        {
                            CopyRunTargets = copyRunTargets,
                            JobUid = new Model.UniversalId
                            {
                                ClusterId = jobRun.JobUid.ClusterId,
                                ClusterIncarnationId = jobRun.JobUid.ClusterIncarnationId,
                                Id = jobRun.JobUid.Id
                            },
                            RunStartTimeUsecs = (long)jobRun.CopyRun[0].RunStartTimeUsecs
                        };

                        if(SourceIds != null && SourceIds.Length >= 1)
                        {
                            run.SourceIds = new List<long>(SourceIds);
                        }

                        var runs = new List<Model.UpdateProtectionJobRun>();
                        runs.Add(run);

                        var request = new Model.UpdateProtectionJobRunsParam
                        {
                            JobRuns = runs
                        };
                        var preparedUrl = $"/public/protectionRuns";
                        var result = Session.ApiClient.Put(preparedUrl, request);

                        if(ExtendByDays.HasValue)
                        {
                            WriteObject("Extended the snapshot retention successfully");

                        }
                        else if(ReduceByDays.HasValue)
                        {
                            WriteObject("Reduced the snapshot retention successfully");
                        }
                    }
                }
            }
        }

        #endregion

    }
}

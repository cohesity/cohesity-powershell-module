// Copyright 2018 Cohesity Inc.
using System;
using System.Collections.Generic;
using System.Management.Automation;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.ProtectionJobRun
{
    /// <summary>
    /// <para type="synopsis">
    /// Removes the Cohesity snapshots associated with a Protection Job.
    /// </para>
    /// <para type="description">
    /// Returns success if the snapshots associated with the specified Protection Job are expired successfully.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Remove-CohesitySnapshot -JobName Test-Job -JobRunId 2123
    ///   </code>
    ///   <para>
    ///   Expires the snapshots associated with the specified Protection Job and Job Run Id.
    ///   </para>
    /// </example>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Remove-CohesitySnapshot -JobName Test-Job -JobRunId 2123 -SourceIds 883
    ///   </code>
    ///   <para>
    ///   Expires the snapshots associated with only the specified Source Id (such as a VM), Protection Job and Job Run Id.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Remove, "CohesitySnapshot",
        SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.High)]
    public class RemoveCohesitySnapshot : PSCmdlet
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
        /// The piped job object.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipeline = true, ParameterSetName = "ObjectModel")]
        public Cohesity.Model.ProtectionRunInstance JobObject { get; set; }
    /// <summary>
    /// <para type="description">
    /// The name of the Protection Job.
    /// </para>
    /// </summary>
        [Parameter(Mandatory = true, ParameterSetName = "JobName")]
        [ValidateNotNullOrEmpty()]
        public string JobName { get; set; }

        /// <summary>
        /// <para type="description">
        /// The unique id of the Protection Job Run.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true, ParameterSetName = "JobName")]
        [ValidateRange(1, long.MaxValue)]
        public long JobRunId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the source ids to only expire snapshots belonging to those source ids.
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
            if (JobObject != null){
                JobName = JobObject.JobName;
                JobRunId = (long)JobObject.BackupRun.JobRunId;
            }


            if (ShouldProcess($"Job Run Id: {JobRunId} for Protection Job: {JobName}"))
            {
                var job = RestApiCommon.GetProtectionJobByName(Session.ApiClient, JobName);
                var jobRuns = RestApiCommon.GetProtectionJobRunsByJobId(Session.ApiClient, (long)job.Id);

                foreach (var jobRun in jobRuns)
                {
                    bool snapshotDeleted = (bool)jobRun.BackupRun.SnapshotsDeleted;
                    if (!snapshotDeleted)
                    {
                        if (JobRunId == jobRun.BackupRun.JobRunId)
                        {
                            var copyRunTargets = new List<Model.RunJobSnapshotTarget>();
                            var target = new Model.RunJobSnapshotTarget
                            {
                                Type = Model.RunJobSnapshotTarget.TypeEnum.KLocal,
                                DaysToKeep = 0
                            };

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

                            if (SourceIds != null && SourceIds.Length >= 1)
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

                            WriteObject($"Expired the snapshot with Job Run Id: {JobRunId} for Protection Job: {JobName} successfully");
                        }
                    }
                }
            }
            else
            {
                WriteObject($"The snapshot with Job Run Id: {JobRunId} for Protection Job: {JobName} was not expired");
            }
        }

        #endregion

    }
}

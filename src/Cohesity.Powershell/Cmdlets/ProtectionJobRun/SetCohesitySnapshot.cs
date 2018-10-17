// Copyright 2018 Cohesity Inc.
using System;
using System.Collections.Generic;
using System.Management.Automation;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.ProtectionJob
{
    /// <summary>
    /// <para type="synopsis">
    /// Changes the retention of the snapshots associated with a Protection Job or expires them.
    /// </para>
    /// <para type="description">
    /// Returns success if the snapshots associated with the specified Protection Job are updated successfully.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Set-CohesitySnapshot -JobName Test-Job -JobRunStartTime (Get-Date "Oct 10, 2018 6:00am") -ExpireNow
    ///   </code>
    ///   <para>
    ///   Expires the snapshots with the specified start time and associated with the specified Protection Job.
    ///   </para>
    /// </example>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Set-CohesitySnapshot -JobName Test-Job -JobRunStartTime (Get-Date "Oct 10, 2018 6:00am") -KeepUntil (Get-Date "Oct 10, 2019 6:00am")
    ///   </code>
    ///   <para>
    ///   Changes the retention of the snapshots associated with the specified Protection Job and the specified start time.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Set, "CohesitySnapshot")]
    public class SetCohesitySnapshot : PSCmdlet
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
        /// The start time of the Protection Job Run.
        /// </para>
        /// </summary>
        //[Parameter(Mandatory = true)]
        //[ValidateNotNullOrEmpty()]
        //public DateTime JobRunStartTime { get; set; }

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
        /// Specifies if the snapshots must be expired.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true, ParameterSetName = "Expire")]
        public SwitchParameter ExpireNow { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the time until which the snapshots must be retained.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true, ParameterSetName = "SetRetention")]
        public DateTime? KeepUntil { get; set; } = null;

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
                        var run = new Models.UpdateProtectionJobRun
                        {
                            ExpiryTimeUsecs = 0,
                            JobUid = new Models.UniqueGlobalId10
                            {
                                ClusterId = jobRun.JobUid.ClusterId,
                                ClusterIncarnationId = jobRun.JobUid.ClusterIncarnationId,
                                Id = jobRun.JobUid.Id
                            },
                            RunStartTimeUsecs = (long)jobRun.CopyRun[0].RunStartTimeUsecs
                        };

                        if(ExpireNow.IsPresent)
                        {
                            run.ExpiryTimeUsecs = 0;
                        }

                        if (KeepUntil.HasValue)
                        {
                            DateTime NewRetentionTime = (DateTime) KeepUntil;
                            DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                            long expiryTimeUsecs = 
                                (NewRetentionTime.ToUniversalTime() - UnixEpoch).Ticks / (TimeSpan.TicksPerMillisecond / 1000);
                            run.ExpiryTimeUsecs = expiryTimeUsecs;
                        }

                        var runs = new List<Models.UpdateProtectionJobRun>();
                        runs.Add(run);

                        var request = new Models.UpdateProtectionJobRunsParam
                        {
                            JobRuns = runs
                        };
                        var preparedUrl = $"/public/protectionRuns";
                        var result = Session.ApiClient.Put(preparedUrl, request);
                    }
                }

            }
        }

        #endregion

    }
}

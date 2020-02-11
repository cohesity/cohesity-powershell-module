// Copyright 2018 Cohesity Inc.
using System.Management.Automation;
using Cohesity.Model;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.ProtectionJob
{
    /// <summary>
    /// <para type="synopsis">
    /// Cancels a running protection job.
    /// </para>
    /// <para type="description">
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Stop-CohesityProtectionJob -Id 78773 -JobRunId 85510
    ///   </code>
    ///   <para>
    ///   Cancels a running protection job with Id 78773 and JobRunId 85510.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsLifecycle.Stop, "CohesityProtectionJob")]
    public class StopCohesityProtectionJob : PSCmdlet
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
        /// Specifies the unique id of the protection job.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ParameterSetName = "ById")]
        [ValidateRange(1, long.MaxValue)]
        public long Id { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the name of the protection job.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true, ParameterSetName = "ByName")]
        [ValidateNotNullOrEmpty()]
        public string Name { get; set; }

        /// <summary>
        /// <para type="description">
        /// CopyTaskUid is the Uid of a copy task. 
        /// If a particular copy task is to be cancelled, this field should be set to the id of that particular copy task. 
        /// For example, if replication task is to be canceled, CopyTaskUid of the replication task has to be specified.
        /// </para>
        /// </summary>
        //[Parameter(Mandatory = false)]
        //public UniversalId CopyTaskUid { get; set; } = null;

        /// <summary>
        /// <para type="description">
        /// StopArchivalJob is the flag for stopping archival job on external targets.
        /// Archival External Target (such as Tape or AWS)
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter StopArchivalJob { get; set; } = false;

        /// <summary>
        /// <para type="description">
        /// StopCloudSpinJob is the flag for stopping job at Cloud platform.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter StopCloudSpinJob { get; set; } = false;

        /// <summary>
        /// <para type="description">
        /// StopReplicationJob is the flag for stopping replication job on external targets.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter StopReplicationJob { get; set; } = false;

        /// <summary>
        /// <para type="description">
        /// Run Id of a protection job run that needs to be cancelled.
        /// If this run id does not match the id of an active run in the protection job, the job run is not cancelled and an error will be returned.
        /// If this is not specified, the last job run id is used.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long? JobRunId { get; set; }

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
            Model.ProtectionJob currentProtectionjob = null;
            if (!string.IsNullOrWhiteSpace(Name))
            {
                var job = RestApiCommon.GetProtectionJobByName(Session.ApiClient, Name);
                Id = (long)job.Id;
                currentProtectionjob = job;
            }

            if (JobRunId == null)
            {
                var job = RestApiCommon.GetProtectionJobById(Session.ApiClient, Id);
                JobRunId = (long)job.LastRun.BackupRun.JobRunId;
                currentProtectionjob = job;
            }

            UniversalId copyTaskUid = null;
            CopyRun copyRun = null;

            if (StopArchivalJob)
            {
                copyRun = currentProtectionjob.LastRun.CopyRun.Find(x => x.Target.Type == SnapshotTargetSettings.TypeEnum.KArchival);
                if(null == copyRun)
                {
                    WriteObject("Could not find the archival task.");
                    return;
                }

            }
            if (StopCloudSpinJob)
            {
                copyRun = currentProtectionjob.LastRun.CopyRun.Find(x => x.Target.Type == SnapshotTargetSettings.TypeEnum.KCloudDeploy);
                if (null == copyRun)
                {
                    WriteObject("Could not find the cloud deploy task.");
                    return;
                }
            }
            if (StopReplicationJob)
            {
                copyRun = currentProtectionjob.LastRun.CopyRun.Find(x => x.Target.Type == SnapshotTargetSettings.TypeEnum.KRemote);
                if (null == copyRun)
                {
                    WriteObject("Could not find the replication task.");
                    return;
                }
            }

            object body;
            if (null != copyRun)
            {
                copyTaskUid = copyRun.TaskUid;
                // When the non-local job is being stopped
                body = new CancelProtectionJobRunParam
                {
                    // The copy task uid and job id would be used for Archival, Cloud spin and Remote targets
                    CopyTaskUid = copyTaskUid,
                };
            }
            else
            {
                // When the local job is being stopped
                body = new CancelProtectionJobRunParam
                {
                    JobRunId = this.JobRunId
                };

            }
            var url = $"/public/protectionRuns/cancel/{Id.ToString()}";
            Session.ApiClient.Post(url, body);
            WriteObject("Protection Job Run cancelled.");
        }
    }
}


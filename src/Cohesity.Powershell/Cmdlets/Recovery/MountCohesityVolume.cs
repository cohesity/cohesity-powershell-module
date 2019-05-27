// Copyright 2018 Cohesity Inc.
using System.Collections.Generic;
using System.Management.Automation;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.Recovery
{
    /// <summary>
    /// <para type="synopsis">
    /// Mounts the specified volumes instantly to a target host from a previous backup.
    /// </para>
    /// <para type="description">
    /// Mounts the specified volumes instantly to a target host from a previous backup.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Mount-CohesityVolume -TaskName "Test-Mount" -SourceId 12 -JobId 8 -BringDisksOnline -TargetHostId 23 -TargetHostCredential (Get-Credential)
    ///   </code>
    ///   <para>
    ///   Mounts the volumes corresponding to the given source id to the given target host id using the latest run of job id 8.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsData.Mount, "CohesityVolume")]
    public class MountCohesityVolume : PSCmdlet
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
        /// Specifies the name of the instant volume mount task.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty()]
        public string TaskName { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the source id that was backed up.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        [ValidateRange(1, long.MaxValue)]
        public long SourceId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the job id to be used for this instant volume mount.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        [ValidateRange(1, long.MaxValue)]
        public long JobId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the job run id to be used for this instant volume mount.
        /// If not specified the latest run is used.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        [ValidateRange(1, long.MaxValue)]
        public long? JobRunId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the time when the Job Run starts capturing a snapshot.
        /// Specified as a Unix epoch Timestamp (in microseconds).
        /// This must be specified if job run id is specified.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies if the volumes will be brought online on the mount target after attaching the disks.
        /// This field is only applicable for VMs. The Cohesity Cluster always attempts to mount Physical servers.
        /// If the mount target is a VM, then VMware Tools must be installed on the guest operating system and login credentials to the mount target must be specified.
        /// NOTE: If automount is configured for a Windows system, the volumes may be automatically brought online.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter BringDisksOnline { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies a new registered parent Protection Source.
        /// If not specified, the original parent source will be used.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        [ValidateRange(1, long.MaxValue)]
        public long? NewParentId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the source id of the target host where the volumes will be mounted.
        /// NOTE: The source that was backed up and the mount target must be the same type, for example if the source is a VMware VM, then the mount target must also be a VMware VM.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        [ValidateRange(1, long.MaxValue)]
        public long? TargetHostId { get; set; }

        /// <summary>
        /// <para type="description">
        /// User credentials for accessing the target host for mounting the volumes.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public PSCredential TargetHostCredential { get; set; } = null;

        /// <summary>
        /// <para type="description">
        /// Specifies the names of volumes to mount. If none are specified, all volumes are mounted on the target.
        /// Note: Windows volumes should be specified in unix format. '/C' instead of 'C:'
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public string[] VolumeNames { get; set; } = null;

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
            var restoreRequest = new Model.RecoverTaskRequest(name: TaskName)
            {
                Type = Model.RecoverTaskRequest.TypeEnum.KMountVolumes,
                ContinueOnError = true
            };

            var mountParams = new Model.MountVolumesParameters();
            if (BringDisksOnline.IsPresent)
                mountParams.BringDisksOnline = BringDisksOnline;

            if (VolumeNames != null)
                mountParams.VolumeNames = new List<string>(VolumeNames);

            mountParams.TargetSourceId = TargetHostId.HasValue ? TargetHostId : SourceId;

            if (TargetHostCredential != null)
            {
                mountParams.Username = TargetHostCredential.UserName;
                mountParams.Password = TargetHostCredential.GetNetworkCredential().Password;
            }

            restoreRequest.MountParameters = mountParams;

            var restoreObject = new Model.RestoreObjectDetails
            {
                JobId = JobId,
                ProtectionSourceId = SourceId
            };

            if (JobRunId.HasValue)
                restoreObject.JobRunId = JobRunId;

            if (NewParentId.HasValue)
                restoreRequest.NewParentId = NewParentId;

            if (StartTime.HasValue)
                restoreObject.StartedTimeUsecs = StartTime;

            var objects = new List<Model.RestoreObjectDetails>();
            objects.Add(restoreObject);

            restoreRequest.Objects = objects;

            // POST /public/restore/recover
            var preparedUrl = $"/public/restore/recover";
            var result = Session.ApiClient.Post<Model.RestoreTask>(preparedUrl, restoreRequest);
            WriteObject(result);
        }

        #endregion
    }

}

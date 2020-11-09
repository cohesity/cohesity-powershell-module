// Copyright 2018 Cohesity Inc.
using System.Collections.Generic;
using System.Management.Automation;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.Recovery
{
    /// <summary>
    /// <para type="synopsis">
    /// Restores the specified files or folders from a previous backup.
    /// </para>
    /// <para type="description">
    /// Restores the specified files or folders from a previous backup.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Restore-CohesityFile -TaskName "restore-file-vm" -FileNames /C/data/file.txt -JobId 1234 -SourceId 843 -TargetSourceId 856 -TargetParentSourceId 828 -TargetHostType KWindows -TargetHostCredential (Get-Credential)
    ///   </code>
    ///   <para>
    ///   Restores the specified file to the target windows VM with the source id 856 from the latest backup.
    ///   </para>
    /// </example>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Restore-CohesityFile -TaskName "restore-file-physical" -FileNames /C/data/file.txt -JobId 1234 -SourceId 820 -TargetSourceId 858
    ///   </code>
    ///   <para>
    ///   Restores the specified file to the target physical server with the source id 858 from the latest backup.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsData.Restore, "CohesityFile")]
    public class RestoreCohesityFile : PSCmdlet
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
        /// Specifies the name of the Restore Task.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the full names of the files or folders to be restored.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        public string[] FileNames { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the job id that backed up the files and will be used for this restore.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        [ValidateRange(1, long.MaxValue)]
        public long JobId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the id of the original protection source (that was backed up) containing the files and folders.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        [ValidateRange(1, long.MaxValue)]
        public long SourceId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies an optional base directory where the specified files and folders will be restored.
        /// By default, files and folders are restored to their original path.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public string NewBaseDirectory { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the Job Run id that captured the snapshot.
        /// If not specified, the latest backup run is used.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        [ValidateRange(1, long.MaxValue)]
        public long? JobRunId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the time when the Job Run started capturing a snapshot.
        /// Specified as a Unix epoch Timestamp (in microseconds).
        /// This must be specified if the job run id is specified.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        [ValidateRange(1, long.MaxValue)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies that any existing files and folders should not be overwritten during the restore.
        /// By default, any existing files and folders are overwritten by restored files and folders.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter DoNotOverwrite { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies if the Restore Task should continue even if the restore of some files and folders fails.
        /// If specified, the Restore Task ignores errors and restores as many files and folders as possible.
        /// By default, the Restore Task stops restoring if any operation fails.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter ContinueOnError { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies that the Restore Task should not preserve the original attributes of the files and folders.
        /// By default, the original attributes are preserved.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter DoNotPreserveAttributes { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the id of the target source (such as a VM or Physical server) where the files and folders are to be restored.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        public long? TargetSourceId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the id of the registered parent source (such as a vCenter Server) that contains the target source (such as a VM).
        /// This is not required when restoring to a Physical Server but must be specified when restoring to a VM.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long? TargetParentSourceId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the operating system type of the target host.
        /// This is not required when restoring to a Physical Server but must be specified when restoring to a VM.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public Model.RestoreFilesTaskRequest.TargetHostTypeEnum? TargetHostType { get; set; }

        /// <summary>
        /// <para type="description">
        /// User credentials for accessing the target host for restore.
        /// This is not required when restoring to a Physical Server but must be specified when restoring to a VM.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public PSCredential TargetHostCredential { get; set; } = null;

        /// <summary>
        /// <para type="description">
        /// Specifies the type of method to be used to perform file recovery.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public Model.RestoreFilesTaskRequest.FileRecoveryMethodEnum? FileRecoveryMethod { get; set; }

        
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
            var restoreRequest = new Model.RestoreFilesTaskRequest(name: TaskName)
            {
                Filenames = new List<string>(FileNames),
                ContinueOnError = ContinueOnError.IsPresent,
                PreserveAttributes = !(DoNotPreserveAttributes.IsPresent),
                Overwrite = !(DoNotOverwrite.IsPresent)
            };

            if(FileRecoveryMethod.HasValue)
            {
                restoreRequest.FileRecoveryMethod = FileRecoveryMethod;
            }

            if(!string.IsNullOrWhiteSpace(NewBaseDirectory))
            {
                restoreRequest.NewBaseDirectory = NewBaseDirectory;
            }

            if(TargetHostCredential != null)
            {
                restoreRequest.Username = TargetHostCredential.UserName;
                restoreRequest.Password = TargetHostCredential.GetNetworkCredential().Password;
            }

            if (TargetParentSourceId.HasValue)
                restoreRequest.TargetParentSourceId = TargetParentSourceId;
            if (TargetSourceId.HasValue)
                restoreRequest.TargetSourceId = TargetSourceId;
            if (TargetHostType.HasValue)
                restoreRequest.TargetHostType = TargetHostType;

            var job = RestApiCommon.GetProtectionJobById(Session.ApiClient, JobId);
            var restoreObject = new Model.RestoreObjectDetails
            {
                JobId = JobId,
                ProtectionSourceId = SourceId,
                JobUid = new Model.UniversalId
                {
                    Id = job.Id,
                    ClusterId = job.Uid.ClusterId,
                    ClusterIncarnationId = job.Uid.ClusterIncarnationId
                }
            };

            // If job run id is not specified, get the job run id of the last run
            if (JobRunId.HasValue)
            {
                restoreObject.JobRunId = JobRunId;
            }
            else
            {
                restoreObject.JobRunId = job.LastRun.BackupRun.JobRunId;
            }

            // If start time is not specified, get the start time of the last run
            if (StartTime.HasValue)
            {
                restoreObject.StartedTimeUsecs = StartTime;
            }
            else
            {
                restoreObject.StartedTimeUsecs = job.LastRun.BackupRun.Stats.StartTimeUsecs;
            }

            restoreRequest.SourceObjectInfo = restoreObject;
           
            // POST /public/restore/files
            var preparedUrl = $"/public/restore/files";
            var result = Session.ApiClient.Post<Model.RestoreTask>(preparedUrl, restoreRequest);
            WriteObject(result);
        }

        #endregion
    }

}

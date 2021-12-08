// Copyright 2018 Cohesity Inc.
using System.Collections.Generic;
using System.Management.Automation;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.Recovery
{
    /// <summary>
    /// <para type="synopsis">
    /// Restores the specified MS SQL object from a previous backup.
    /// </para>
    /// <para type="description">
    /// Restores the specified  MS SQL object from a previous backup.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Restore-CohesityMSSQLObject -TaskName "sql-restore-task" -SourceId 9 -HostSourceId 3 -JobId 401
    ///   </code>
    ///   <para>
    ///   Restores the MS SQL DB with the given source id using the latest run of job id 401.
    ///   </para>
    /// </example>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    /// $patternList = @()
    /// $pattern = [Cohesity.Model.FilenamePatternToDirectory]::new()
    /// $pattern.Directory = "C:\Secondary"
    /// $pattern.FilenamePattern = "*.mdf"
    /// $patternList += $pattern
    /// 
    /// Restore-CohesityMSSQLObject -TaskName "restore-sql" -SourceId 698 -HostSourceId 675 -JobId 1359 `
    /// -NewDatabaseName "restore-1" -NewInstanceName MSSQLSERVER -TargetHostId 972 `
    /// -TargetDataFilesDirectory "C:\TEST Data" -TargetLogFilesDirectory "C:\TEST Log" `
    /// -TargetSecondaryDataFilesDirectoryList $patternList
    ///   </code>
    ///   <para>
    ///   Restores the MS SQL DB with the given source id on a target server.
    ///   </para>
    /// </example>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Restore-CohesityMSSQLObject -TaskName "restore-sql" -SourceId 3101 -HostSourceId 3099 -JobId 51275 `
    ///   -TargetHostId 3098 -CaptureTailLogs:$false -NewDatabaseName ReportServer_r26 `
    ///   -NewInstanceName MSSQLSERVER -TargetDataFilesDirectory "C:\temp" -TargetLogFilesDirectory "C:\temp" `
    ///   -StartTime 1614450600000000 -RestoreTimeSecs 1617097060
    ///   </code>
    ///   <para>
    ///   Request for restore MSSQL object with RestoreTimeSecs (point in time) parameter and StartTime.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsData.Restore, "CohesityMSSQLObject",
        SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.High)]
    public class RestoreCohesityMSSQLObject : PSCmdlet
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
        /// Specifies the name of the restore task.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the source id of the MS SQL database to restore. This can be obtained using Get-CohesityMSSQLObject.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        [ValidateRange(1, long.MaxValue)]
        public long SourceId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the source id of the physical server or virtual machine that is hosting the MS SQL instance.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        [ValidateRange(1, long.MaxValue)]
        public long HostSourceId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the job id that backed up this MS SQL instance and will be used for this restore.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        [ValidateRange(1, long.MaxValue)]
        public long JobId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the job run id that captured the snapshot for this MS SQL instance. If not specified the latest run is used.
        /// This field must be set if restoring to a different target host.
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
        /// Specifies if the tail logs are to be captured before the restore operation.
        /// This is only applicable if restoring the SQL database to its hosting Protection Source and the database is not being renamed.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter CaptureTailLogs { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies if we want to restore the database and do not want to bring it online after restore.
        /// This is only applicable if restoring the database back to its original location.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter KeepOffline { get; set; }

        /// <summary>
        /// <para type="description">
        /// This field prevents "change data capture" settings from being reomved.
        /// When a database or log backup is restored on another server and database is recovered.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter KeepCDC { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies a new name for the restored database.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public string NewDatabaseName { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the instance name of the SQL Server that should be restored.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public string NewInstanceName { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the time in the past to which the SQL database needs to be restored.
        /// This allows for granular recovery of SQL databases.
        /// If not specified, the SQL database will be restored from the full/incremental snapshot.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        [ValidateRange(1, long.MaxValue)]
        public long? RestoreTimeSecs { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the directory where to put the database data files.
        /// Missing directory will be automatically created.
        /// This field must be set if restoring to a different target host.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        [ValidateNotNullOrEmpty()]
        public string TargetDataFilesDirectory { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the directory where to put the database log files.
        /// Missing directory will be automatically created.
        /// This field must be set if restoring to a different target host.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        [ValidateNotNullOrEmpty()]
        public string TargetLogFilesDirectory { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the secondary data filename pattern and corresponding directories of the DB. Secondary data
        /// files are optional and are user defined. The recommended file extension for secondary files is
        /// ".ndf".  If this option is specified and the destination folders do not exist they will be
        /// automatically created.
        /// This field can be set only if restoring to a different target host.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        [ValidateNotNullOrEmpty()]
        public List<Model.FilenamePatternToDirectory> TargetSecondaryDataFilesDirectoryList { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the target host if the application is to be restored to a different host.
        /// If not specified, then the application is restored to the original host (physical or virtual) that hosted this application.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        [ValidateRange(1, long.MaxValue)]
        public long? TargetHostId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the id of the registered parent source (such as vCenter) of the target host.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        [ValidateRange(1, long.MaxValue)]
        public long? TargetHostParentId { get; set; }

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
        /// Source of the backup object. In this case vault/archival machine.
        /// Use the cmdlet Get-CohesityVault to get the vault/archival source.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long? ArchivalId { get; set; }
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
            if (ShouldProcess($"Source Id : {SourceId}"))
            {
                var applicationRestoreObject = new Model.ApplicationRestoreObject(applicationServerId: SourceId)
                {
                    SqlRestoreParameters = new Model.SqlRestoreParameters
                    {
                        CaptureTailLogs = CaptureTailLogs.IsPresent,
                        KeepOffline = KeepOffline.IsPresent,
                        KeepCdc = KeepCDC.IsPresent
                    }
                };

                if (!string.IsNullOrWhiteSpace(NewDatabaseName))
                {
                    applicationRestoreObject.SqlRestoreParameters.NewDatabaseName = NewDatabaseName;
                }

                if (!string.IsNullOrWhiteSpace(NewInstanceName))
                {
                    applicationRestoreObject.SqlRestoreParameters.NewInstanceName = NewInstanceName;
                }

                if (!string.IsNullOrWhiteSpace(TargetDataFilesDirectory))
                {
                    applicationRestoreObject.SqlRestoreParameters.TargetDataFilesDirectory = TargetDataFilesDirectory;
                }

                if (!string.IsNullOrWhiteSpace(TargetLogFilesDirectory))
                {
                    applicationRestoreObject.SqlRestoreParameters.TargetLogFilesDirectory = TargetLogFilesDirectory;
                }

                if (null != TargetSecondaryDataFilesDirectoryList)
                {
                    applicationRestoreObject.SqlRestoreParameters.TargetSecondaryDataFilesDirectoryList = TargetSecondaryDataFilesDirectoryList;
                }

                if (TargetHostId != null)
                {
                    applicationRestoreObject.TargetHostId = TargetHostId;
                }

                if (TargetHostParentId != null)
                {
                    applicationRestoreObject.TargetRootNodeId = TargetHostParentId;
                }

                var applicationRestoreObjects = new List<Model.ApplicationRestoreObject>();
                applicationRestoreObjects.Add(applicationRestoreObject);

                var job = RestApiCommon.GetProtectionJobById(Session.ApiClient, JobId);
                var hostingProtectionSource = new Model.RestoreObjectDetails
                {
                    JobId = JobId,
                    ProtectionSourceId = HostSourceId,
                    JobUid = new Model.UniversalId
                    {
                        Id = job.Id,
                        ClusterId = job.Uid.ClusterId,
                        ClusterIncarnationId = job.Uid.ClusterIncarnationId
                    }
                };

                if (this.ArchivalId.HasValue)
                {
                    hostingProtectionSource.ArchivalTarget = new Model.ArchivalExternalTarget
                    {
                        VaultId = this.ArchivalId,
                        VaultType = Model.ArchivalExternalTarget.VaultTypeEnum.KCloud
                    };
                }
                if (JobRunId.HasValue)
                    hostingProtectionSource.JobRunId = JobRunId;

                if (StartTime.HasValue)
                    hostingProtectionSource.StartedTimeUsecs = StartTime;

                var restoreRequest = new Model.ApplicationsRestoreTaskRequest(name: TaskName,
                    applicationEnvironment: Model.ApplicationsRestoreTaskRequest.ApplicationEnvironmentEnum.KSQL,
                    applicationRestoreObjects: applicationRestoreObjects,
                    hostingProtectionSource: hostingProtectionSource)
                {
                };

                if (TargetHostCredential != null)
                {
                    restoreRequest.Username = TargetHostCredential.UserName;
                    restoreRequest.Password = TargetHostCredential.GetNetworkCredential().Password;
                }

                if (null != this.RestoreTimeSecs)
                {
                    if (null == this.StartTime)
                    {
                        WriteObject("Please add start time to validate point in time restore.");
                        return;
                    }
                    if (false == IsValidPointInTime(this.RestoreTimeSecs, this.StartTime, this.SourceId, job))
                    {
                        WriteObject("Invalid point in time " + this.RestoreTimeSecs);
                        return;
                    }

                    applicationRestoreObject.SqlRestoreParameters.RestoreTimeSecs = this.RestoreTimeSecs;
                }


                // POST /public/restore/applicationsRecover
                var preparedUrl = $"/public/restore/applicationsRecover";
                var result = Session.ApiClient.Post<Model.RestoreTask>(preparedUrl, restoreRequest);
                WriteObject(result);
            }
        }

        private bool IsValidPointInTime(long? restoreTimeSecs, long? startTime, long sourceId, Model.ProtectionJob job)
        {
            // identifying range from preceeding day
            System.DateTime startDate = RestApiCommon.ConvertUsecsToDateTime((long)startTime);
            startDate = startDate.AddDays(-1);
            long startTimeInUsec = RestApiCommon.ConvertDateTimeToUsecs(startDate);

            var pointsInTimeRange = new Model.RestorePointsForTimeRangeParam
            {
                EndTimeUsecs = RestApiCommon.ConvertDateTimeToUsecs(System.DateTime.Now),
                Environment = Model.RestorePointsForTimeRangeParam.EnvironmentEnum.KSQL,
                JobUids = new List<Model.UniversalId>(),
                ProtectionSourceId = sourceId,
                StartTimeUsecs = startTimeInUsec
            };
            pointsInTimeRange.JobUids.Add(job.Uid);

            var pointsForTimeRangeUrl = $"/public/restore/pointsForTimeRange";
            var timeRangeResult = Session.ApiClient.Post<Model.RestorePointsForTimeRange>(pointsForTimeRangeUrl, pointsInTimeRange);
            bool foundPointInTime = false;
            if (null != timeRangeResult.TimeRanges)
            {
                foreach (var item in timeRangeResult.TimeRanges)
                {
                    var restoreTimeUsecs = restoreTimeSecs * 1000 * 1000;
                    if (item.StartTimeUsecs < restoreTimeUsecs && restoreTimeUsecs < item.EndTimeUsecs)
                    {
                        foundPointInTime = true;
                        break;
                    }
                }
            }
            return foundPointInTime;
        }

        #endregion
    }

}

// Copyright 2018 Cohesity Inc.
using System.Collections.Generic;
using System.Management.Automation;
using Cohesity.Powershell.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Cohesity.Powershell.Cmdlets.Clone
{
    /// <summary>
    /// <para type="synopsis">
    /// Clones the specified MS SQL Database.
    /// </para>
    /// <para type="description">
    /// Clones the specified MS SQL Database.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Copy-CohesityMSSQLObject -TaskName "sql-clone-task" -SourceId 9 -HostSourceId 3 -JobId 41 -NewDatabaseName "ReportDB-clone" -InstanceName "MSSQLSERVER"
    ///   </code>
    ///   <para>
    ///   Clones the MS SQL Database with the given source id using the latest run of job id 41 and renames it to "ReportDB-clone".
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Copy, "CohesityMSSQLObject")]
    public class CopyCohesityMSSQLObject : PSCmdlet
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
        /// Specifies the name of the clone task.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the source id of the MS SQL database to clone. This can be obtained using Get-CohesityMSSQLObject.
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
        /// Specifies the job id that backed up this MS SQL instance and will be used for this clone operation.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        [ValidateRange(1, long.MaxValue)]
        public long JobId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the job run id that captured the snapshot for this MS SQL instance. If not specified the latest run is used.
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
        /// Specifies a new name for the cloned database.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public string NewDatabaseName { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the instance name of the SQL Server for this clone operation.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the target host for this clone operation.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        [ValidateRange(1, long.MaxValue)]
        public long? TargetHostId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the id of the registered parent source (such as vCenter) of the target host.
        /// This is only applicable if the target host is a virtual machine.
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
            var requestData = new Dictionary<string, object>();
            requestData["name"] = TaskName;
            requestData["action"] = "kCloneApp";

            var restoreAppParams = new Dictionary<string, object>();
            restoreAppParams["type"] = 3;

            if (TargetHostCredential != null)
            {
                var credentials = new Dictionary<string, object>();
                credentials["username"] = TargetHostCredential.UserName;
                credentials["password"] = TargetHostCredential.GetNetworkCredential().Password;

                restoreAppParams["credentials"] = credentials;
            }

            var job = RestApiCommon.GetProtectionJobById(Session.ApiClient, JobId);

            var jobUid = new Dictionary<string, object>();
            jobUid["clusterId"] = job.Uid.ClusterId;
            jobUid["clusterIncarnationId"] = job.Uid.ClusterIncarnationId;
            jobUid["objectId"] = job.Id;

            var ownerObject = new Dictionary<string, object>();
            ownerObject["jobId"] = JobId;
            ownerObject["jobUid"] = jobUid;

            if (JobRunId.HasValue)
                ownerObject["jobInstanceId"] = JobRunId;

            // If the parameter is not passed, identify the latest snapshot and start cloning
            if (StartTime.HasValue)
            {
                ownerObject["startTimeUsecs"] = StartTime;
            }
            else
            {
                List<Model.ProtectionRunInstance> jobRuns = new List< Model.ProtectionRunInstance >( RestApiCommon.GetProtectionJobRunsByJobId(Session.ApiClient, JobId));
                if(null != jobRuns && jobRuns.Count > 0)
                {
                    Model.ProtectionRunInstance jobRun = jobRuns[0];
                    if (null != jobRun.CopyRun && jobRun.CopyRun.Count > 0)
                    {
                        if (null != jobRun.CopyRun[0].RunStartTimeUsecs)
                        {
                            ownerObject["startTimeUsecs"] = jobRun.CopyRun[0].RunStartTimeUsecs;
                        }
                    }
                }
            }

            var entity = new Dictionary<string, object>();
            entity["id"] = HostSourceId;

            ownerObject["entity"] = entity;

            var ownerRestoreInfo = new Dictionary<string, object>();
            ownerRestoreInfo["ownerObject"] = ownerObject;
            ownerRestoreInfo["performRestore"] = false;

            restoreAppParams["ownerRestoreInfo"] = ownerRestoreInfo;

            var sqlRestoreParams = new Dictionary<string, object>();
            sqlRestoreParams["captureTailLogs"] = false;
            if (!string.IsNullOrWhiteSpace(NewDatabaseName))
            {
                sqlRestoreParams["newDatabaseName"] = NewDatabaseName;
            }
            if (!string.IsNullOrWhiteSpace(InstanceName))
            {
                sqlRestoreParams["instanceName"] = InstanceName;
            }

            var restoreParams = new Dictionary<string, object>();
            restoreParams["sqlRestoreParams"] = sqlRestoreParams;

            if (TargetHostId != null)
            {
                var targetHost = new Dictionary<string, object>();
                targetHost["id"] = TargetHostId;

                restoreParams["targetHost"] = targetHost;
            }

            if (TargetHostParentId != null)
            {
                var targetHostParentSource = new Dictionary<string, object>();
                targetHostParentSource["id"] = TargetHostParentId;

                restoreParams["targetHostParentSource"] = targetHostParentSource;
            }

            var appEntity = new Dictionary<string, object>();
            appEntity["type"] = 3;
            appEntity["id"] = SourceId;

            var restoreAppObjectVec = new Dictionary<string, object>();
            restoreAppObjectVec["restoreParams"] = restoreParams;
            restoreAppObjectVec["appEntity"] = appEntity;

            restoreAppParams["restoreAppObjectVec"] = new[] { restoreAppObjectVec };

            requestData["restoreAppParams"] = restoreAppParams;

            string cloneRequest = JsonConvert.SerializeObject(requestData, Formatting.Indented);

            // POST /cloneApplication
            var preparedUrl = $"/cloneApplication";
            var result = Session.ApiClient.Post(preparedUrl, cloneRequest);

            JObject restoreTaskObject = JObject.Parse(result);
            string restoreTaskId = (string)restoreTaskObject["restoreTask"]["performRestoreTaskState"]["base"]["taskId"];

            // GET /public/restore/tasks/{id}
            var getRestoreTaskUrl = $"/public/restore/tasks/{restoreTaskId}";
            var response = Session.ApiClient.Get<Model.RestoreTask>(getRestoreTaskUrl);
            WriteObject(response);
        }

        #endregion
    }

}

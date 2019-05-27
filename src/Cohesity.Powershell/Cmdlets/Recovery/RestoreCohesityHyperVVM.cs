// Copyright 2018 Cohesity Inc.
using System.Collections.Generic;
using System.Management.Automation;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.Recovery
{
    /// <summary>
    /// <para type="synopsis">
    /// Restores the specified Hyper-V virtual machine from a previous backup.
    /// </para>
    /// <para type="description">
    /// Restores the specified Hyper-V virtual machine from a previous backup.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Restore-CohesityHyperVVM -TaskName "Test-Restore" -SourceId 2 -JobId 8 -VmNamePrefix "copy-" -DisableNetwork -PoweredOn
    ///   </code>
    ///   <para>
    ///   Restores the Hyper-V virtual machine with the given source id using the latest run of job id 8.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsData.Restore, "CohesityHyperVVM")]
    public class RestoreCohesityHyperVVM : PSCmdlet
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
        /// Specifies the source id of the VM to be restored.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        [ValidateRange(1, long.MaxValue)]
        public long SourceId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the job id that backed up this VM and will be used for this restore.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        [ValidateRange(1, long.MaxValue)]
        public long JobId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the job run id that captured the snapshot for this VM. If not specified the latest run is used.
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
        /// Specifies the prefix to add to the name of the restored VM.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public string VmNamePrefix { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the suffix to add to the name of the restored VM.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public string VmNameSuffix { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies whether the network should be left in disabled state.
        /// Attached network is enabled by default. Use this switch to disable it.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter DisableNetwork { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the power state of the recovered VM.
        /// By default, the VM is powered off.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter PoweredOn { get; set; }

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
                Type = Model.RecoverTaskRequest.TypeEnum.KRecoverVMs,
                ContinueOnError = true
            };

            var hypervParams = new Model.HypervRestoreParameters();
            if(PoweredOn.IsPresent)
                hypervParams.PoweredOn = PoweredOn;
            if(DisableNetwork.IsPresent)
                hypervParams.DisableNetwork = true;
            if(VmNamePrefix != null)
                hypervParams.Prefix = VmNamePrefix;
            if(VmNameSuffix != null)
                hypervParams.Suffix = VmNameSuffix;

            restoreRequest.HypervParameters = hypervParams;

            var restoreObject = new Model.RestoreObjectDetails
            {
                JobId = JobId,
                ProtectionSourceId = SourceId
            };

            if (JobRunId.HasValue)
                restoreObject.JobRunId = JobRunId;

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

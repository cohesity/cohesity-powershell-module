// Copyright 2018 Cohesity Inc.
using System.Collections.Generic;
using System.Management.Automation;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.Recovery
{
    /// <summary>
    /// <para type="synopsis">
    /// Restores the specified VMware virtual machine from a previous backup.
    /// </para>
    /// <para type="description">
    /// Restores the specified VMware virtual machine from a previous backup.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Restore-CohesityVMwareVM -TaskName "Test-Restore" -SourceId 2 -JobId 8 -VmNamePrefix "copy-" -DisableNetwork -PoweredOn
    ///   </code>
    ///   <para>
    ///   Restores the VMware virtual machine with the given source id using the latest run of job id 8.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsData.Restore, "CohesityVMwareVM")]
    public class RestoreCohesityVMwareVM : PSCmdlet
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

        /// <summary>
        /// <para type="description">
        /// Specifies the datastore where the VM should be recovered.
        /// This field is mandatory when recovering the VM to a different resource pool or to a different parent source such as vCenter.
        /// If not specified, VM is recovered to its original datastore location in the parent source.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        [ValidateRange(1, long.MaxValue)]
        public long? DatastoreId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specify this field to override the preserved network configuration or to attach a new network configuration to the recovered VM.
        /// By default, original network configuration is preserved if the VM is recovered under the same parent source and the same resource pool.
        /// Original network configuration is detached if the VM is recovered under a different vCenter or a different resource pool.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        [ValidateRange(1, long.MaxValue)]
        public long? NetworkId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the resource pool where the VM should be recovered.
        /// This field is mandatory if recovering to a new parent source such as vCenter.
        /// If this field is not specified, VM is recovered to the original resource pool.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        [ValidateRange(1, long.MaxValue)]
        public long? ResourcePoolId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the folder where the VM should be restored.
        /// This is applicable only when the VM is being restored to an alternate location.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        [ValidateRange(1, long.MaxValue)]
        public long? VmFolderId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies a new parent source such as vCenter to recover the VM.
        /// If not specified, the VM is recovered to its original parent source.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        [ValidateRange(1, long.MaxValue)]
        public long? NewParentId { get; set; }

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

            var vmwareParams = new Model.VmwareRestoreParameters();
            vmwareParams.PoweredOn = false;
            vmwareParams.DisableNetwork = false;
            if(PoweredOn.IsPresent)
                vmwareParams.PoweredOn = true;
            if(DisableNetwork.IsPresent)
                vmwareParams.DisableNetwork = true;
            if(VmNamePrefix != null)
                vmwareParams.Prefix = VmNamePrefix;
            if(VmNameSuffix != null)
                vmwareParams.Suffix = VmNameSuffix;
            if (DatastoreId.HasValue)
                vmwareParams.DatastoreId = DatastoreId;
            if (NetworkId.HasValue)
                vmwareParams.NetworkId = NetworkId;
            if (ResourcePoolId.HasValue)
                vmwareParams.ResourcePoolId = ResourcePoolId;
            if (VmFolderId.HasValue)
                vmwareParams.VmFolderId = VmFolderId;

            restoreRequest.VmwareParameters = vmwareParams;

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

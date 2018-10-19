// Copyright 2018 Cohesity Inc.
using System.Collections.Generic;
using System.Management.Automation;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.Clone
{
    /// <summary>
    /// <para type="synopsis">
    /// Clones the specified VMware virtual machine.
    /// </para>
    /// <para type="description">
    /// Clones the specified VMware virtual machine.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Copy-CohesityVMwareVM -TaskName "test-clone-task" -SourceId 883 -TargetViewName "test-vm-datastore" -JobId 49402 -VmNamePrefix "clone-" -DisableNetwork -PoweredOn -ResourcePoolId 893
    ///   </code>
    ///   <para>
    ///   Clones the VMware virtual machine with the given source id using the latest run of job id 49402.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Copy, "CohesityVMwareVM")]
    public class CopyCohesityVMwareVM : PSCmdlet
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
        /// Specifies the name of the View where the cloned VM is stored.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        public string TargetViewName { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the source id of the VM to be cloned.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        [ValidateRange(1, long.MaxValue)]
        public long SourceId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the job id that backed up this VM and will be used for cloning.
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
        /// Specifies the prefix to add to the name of the cloned VM.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public string VmNamePrefix { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the suffix to add to the name of the cloned VM.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public string VmNameSuffix { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies whether the network should be left in disabled state.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter DisableNetwork { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the power state of the cloned VM.
        /// By default, the VM is powered off.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter PoweredOn { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the folder where the datastore should be created when the VM is being cloned.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        [ValidateRange(1, long.MaxValue)]
        public long? DatastoreFolderId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specify this field to override the preserved network configuration or to attach a new network configuration to the cloned VM.
        /// By default, original network configuration is preserved if the VM is cloned under the same parent source and the same resource pool.
        /// Original network configuration is detached if the VM is cloned under a different vCenter or a different resource pool.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        [ValidateRange(1, long.MaxValue)]
        public long? NetworkId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the resource pool where the VM should be cloned.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        [ValidateRange(1, long.MaxValue)]
        public long? ResourcePoolId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the folder where the VM should be cloned.
        /// This is applicable only when the VM is being cloned to an alternate location.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        [ValidateRange(1, long.MaxValue)]
        public long? VmFolderId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies a new parent source such as vCenter to clone the VM.
        /// If not specified, the VM is cloned to its original parent source.
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
            var cloneRequest = new Models.CloneTaskRequest(name: TaskName)
            {
                Type = Models.CloneTaskRequest.TypeEnum.KCloneVMs,
                ContinueOnError = true,
                TargetViewName = TargetViewName
            };

            var vmwareParams = new Models.VmwareCloneParameters();
            if(PoweredOn.IsPresent)
                vmwareParams.PoweredOn = PoweredOn;
            if(DisableNetwork.IsPresent)
                vmwareParams.DisableNetwork = true;
            if(VmNamePrefix != null)
                vmwareParams.Prefix = VmNamePrefix;
            if(VmNameSuffix != null)
                vmwareParams.Suffix = VmNameSuffix;
            if (DatastoreFolderId.HasValue)
                vmwareParams.DatastoreFolderId = DatastoreFolderId;
            if (NetworkId.HasValue)
                vmwareParams.NetworkId = NetworkId;
            if (ResourcePoolId.HasValue)
                vmwareParams.ResourcePoolId = ResourcePoolId;
            if (VmFolderId.HasValue)
                vmwareParams.VmFolderId = VmFolderId;

            cloneRequest.VmwareParameters = vmwareParams;

            var cloneObject = new Models.RestoreObject
            {
                JobId = JobId,
                ProtectionSourceId = SourceId
            };

            if (JobRunId.HasValue)
                cloneObject.JobRunId = JobRunId;

            if (NewParentId.HasValue)
                cloneRequest.NewParentId = NewParentId;

            if (StartTime.HasValue)
                cloneObject.StartedTimeUsecs = StartTime;

            var objects = new List<Models.RestoreObject>();
            objects.Add(cloneObject);

            cloneRequest.Objects = objects;

            // POST /public/restore/clone
            var preparedUrl = $"/public/restore/clone";
            var result = Session.ApiClient.Post<Models.RestoreTask>(preparedUrl, cloneRequest);
            WriteObject(result);
        }

        #endregion
    }

}

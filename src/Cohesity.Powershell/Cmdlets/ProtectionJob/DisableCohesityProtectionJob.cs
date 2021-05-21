// Copyright 2018 Cohesity Inc.
using System.Management.Automation;
using Cohesity.Powershell.Common;
using Newtonsoft.Json;

namespace Cohesity.Powershell.Cmdlets.ProtectionJob
{
    /// <summary>
    /// <para type="synopsis">
    /// Deactivates the specified protection job.
    /// </para>
    /// <para type="description">
    /// Deactivates the specified protection job. This is used for failover to a remote cluster.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Disable-CohesityProtectionJob -Id 1234
    ///   </code>
    ///   <para>
    ///   Deactivates the protection job with the Id of 1234.
    ///   </para>
    /// </example>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Disable-CohesityProtectionJob -Name "vm-replication-job" -PowerOffVms
    ///   </code>
    ///   <para>
    ///   Deactivates the protection job with the name "vm-replication-job" and also powers off the associated VMs in VMware environment.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsLifecycle.Disable, "CohesityProtectionJob", DefaultParameterSetName = "ByName")]
    public class DisableCohesityProtectionJob: PSCmdlet
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
        /// Specifies whether to power off the VMs in VMware environment. 
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter PowerOffVms { get; set; }

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
            if (!string.IsNullOrWhiteSpace(Name))
            {
                var job = RestApiCommon.GetProtectionJobByName(Session.ApiClient, Name);
                Id = (long)job.Id;
            }

            var requestData = JsonConvert.SerializeObject(new
            {
                powerOff = PowerOffVms.IsPresent
            });

            // POST /deactivateBackupJob/{id}
            var preparedUrl = $"/deactivateBackupJob/{Id.ToString()}";
            Session.ApiClient.Post(preparedUrl, requestData);
            WriteObject($"Protection job with id {Id} was deactivated successfully.");
        }

        #endregion
    }
}

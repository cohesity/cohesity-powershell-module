// Copyright 2018 Cohesity Inc.
using System.Management.Automation;
using Cohesity.Powershell.Common;
using Newtonsoft.Json;

namespace Cohesity.Powershell.Cmdlets.ProtectionJob
{
    /// <summary>
    /// <para type="synopsis">
    /// Activates the specified protection job.
    /// </para>
    /// <para type="description">
    /// Activates the specified protection job. This is used for failback scenario on remote cluster.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Enable-CohesityProtectionJob -Id 1234 -PolicyId "437211583895198:1541716981258:3" -ParentSourceId 13
    ///   </code>
    ///   <para>
    ///   Activates a protection job with the id of 1234 and associates it with the specified policy id and source id.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsLifecycle.Enable, "CohesityProtectionJob")]
    public class EnableCohesityProtectionJob: PSCmdlet
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
        /// <para type="description">
        /// Specifies the unique id of the protection policy to be associated with the protection job.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty()]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the unique id of the parent protection source (eg. a vCenter server) protected by this protection job.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        public long? ParentSourceId { get; set; }

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
                parentEntityId = ParentSourceId,
                policyId = PolicyId
            });

            // POST /activateBackupJob/{id}
            var preparedUrl = $"/activateBackupJob/{Id.ToString()}";
            Session.ApiClient.Post(preparedUrl, requestData);
            WriteObject($"Protection job with id {Id} was activated successfully.");
        }

        #endregion
    }
}

// Copyright 2018 Cohesity Inc.
using System.Management.Automation;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.ProtectionJob
{
    /// <summary>
    /// <para type="synopsis">
    /// Resumes the future runs of the specified protection job.
    /// </para>
    /// <para type="description">
    /// This operation restores the protection job to a running state and new runs are started as defined by the schedule in the policy associated with the job.
    /// Returns success if the state is changed.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Resume-CohesityProtectionJob -Id 1234
    ///   </code>
    ///   <para>
    ///   Resumes a protection job with the Id of 1234.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsLifecycle.Resume, "CohesityProtectionJob")]
    public class ResumeCohesityProtectionJob : PSCmdlet
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
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true)]
        [ValidateRange(1, long.MaxValue)]
        public long Id { get; set; }
        
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
            var protectionJobState = new
            {
                Pause = false
            };

            // POST /public/protectionJobState/{id}
            var preparedUrl = $"/public/protectionJobState/{Id.ToString()}";
            Session.ApiClient.Post(preparedUrl, protectionJobState);
            WriteObject("Protection job was resumed successfully.");
        }

        #endregion
    }

}

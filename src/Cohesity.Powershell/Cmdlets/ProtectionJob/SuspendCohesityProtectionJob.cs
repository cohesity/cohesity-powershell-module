// Copyright 2018 Cohesity Inc.
using System.Management.Automation;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.ProtectionJob
{
    /// <summary>
    /// <para type="synopsis">
    /// Pauses the future runs of the specified protection job.
    /// </para>
    /// <para type="description">
    /// If the protection job is currently running this operation stops any future runs of this protection job from starting and executing. 
    /// However, any existing runs that were already in progress will continue to run.
    /// Returns success if the paused state is changed.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Suspend-CohesityProtectionJob -Id 1234
    ///   </code>
    ///   <para>
    ///   Pauses a protection job with the Id of 1234.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsLifecycle.Suspend, "CohesityProtectionJob")]
    public class SuspendCohesityProtectionJob: PSCmdlet
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
            var protectionJobState = new {
                Pause = true
            };

            // POST /public/protectionJobState/{id}
            var preparedUrl = $"/public/protectionJobState/{Id.ToString()}";
            Session.ApiClient.Post(preparedUrl, protectionJobState);
            WriteObject("Protection job was paused successfully.");
        }

        #endregion
    }
}

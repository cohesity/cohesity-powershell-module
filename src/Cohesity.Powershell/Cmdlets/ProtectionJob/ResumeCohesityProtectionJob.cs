using System.Management.Automation;

namespace Cohesity.Powershell.Cmdlets.ProtectionJob
{
    /// <summary>
    /// <para type="synopsis">
    /// Resumes the future Runs of the specified Protection Job.
    /// </para>
    /// <para type="description">
    /// This operation restores the Protection Job to a running state and new runs are started as defined by the schedule in the Policy associated with the Job.
    /// Returns success if the state is changed.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Resume-CohesityProtectionJob -Id 1234
    ///   </code>
    ///   <para>
    ///   Resumes a Protection Job with the Id of 1234.
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
        /// Specifies the unique id of the Protection Job.
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
            Session.NetworkClient.Post(preparedUrl, protectionJobState);
            WriteObject("Protection job was resumed successfully.");
        }

        #endregion
    }

}

using System.Management.Automation;

namespace Cohesity
{
    /// <summary>
    /// <para type="synopsis">
    /// Resumes the future Runs of the specified Protection Job.
    /// </para>
    /// <para type="description">
    /// This operation restores the Job to a running state and new Runs are started as defined by the schedule in the Policy associated with the Job.
    /// Returns success if the state is changed.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Resume-CohesityProtectionJob -Id 1234
    ///   </code>
    ///   <para>
    ///   Resumes a Protection Job with the ID of 1234.
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
        /// Specifies a unique id of the Protection Job.
        /// </para>
        /// </summary>
        [Parameter(Position = 1, Mandatory = true)]
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

            if (Id <= 0)
            {
                throw new ParameterBindingException($"Parameter {nameof(Id)} must be greater than zero.");
            }
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
            WriteObject("Protection Job state has been updated.");
        }

        #endregion
    }

}

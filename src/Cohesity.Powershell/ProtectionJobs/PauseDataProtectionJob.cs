using System.Management.Automation;

namespace Cohesity.ProtectionJobs
{
    /// <summary>
    /// <para type="synopsis">
    /// Pause future Runs or resume future Runs of the specified Protection Job.
    /// </para>
    /// <para type="description">
    /// If the Protection Job is currently running (not paused) and true is passed in, this operation stops any new Runs of this Protection Job from stating and executing. 
    /// However, any existing Runs that were already executing will continue to run.
    /// If this Projection Job is paused and false is passed in, this operation restores the Job to a running state and new Runs are started as defined by the schedule in the Policy associated with the Job.
    /// Returns success if the paused state is changed.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>C:PS&gt;</para>
    ///   <code>
    ///   Cohesity-PauseDataProtectionJob -ID 1234
    ///   </code>
    ///   <para>
    ///   Pauses a Protection Job with the ID of 1234.
    ///   </para>
    /// </example>
    /// <example>
    ///   <para>C:PS&gt;</para>
    ///   <code>
    ///   Cohesity-PauseDataProtectionJob -ID 1234 -Pause false
    ///   </code>
    ///   <para>
    ///   Resume a Protection Job with the ID of 1234.
    ///   </para>
    /// </example>
    [Cmdlet("Cohesity", "PauseDataProtectionJob")]
    public class PauseDataProtectionJob: PSCmdlet
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
        public long ID { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the paused state.
        /// Default value is true.
        /// </para>
        /// </summary>
        [Parameter(Position = 2, Mandatory = false)]
        public bool Pause { get; set; } = true;

        #endregion

        #region Processing

        /// <summary>
        /// Preprocess
        /// </summary>
        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            Session.AssertAuthentication();
            
            if (ID <= 0)
            {
                throw new ParameterBindingException($"Parameter {nameof(ID)} must be greater than zero.");
            }
        }

        /// <summary>
        /// Process
        /// </summary>
        protected override void ProcessRecord()
        {
            var protectionJobState = new {
                Pause
            };

            // POST /public/protectionJobState/{id}
            var preparedUrl = $"{Session.NetworkClient.BaseUri.AbsoluteUri}/public/protectionJobState/{ID.ToString()}";
            Session.NetworkClient.Post(preparedUrl, protectionJobState);
            WriteObject("Protection Job state has been updated.");
        }

        #endregion
    }
}

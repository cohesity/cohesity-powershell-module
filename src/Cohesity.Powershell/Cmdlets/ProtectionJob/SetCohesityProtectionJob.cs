using Cohesity.Models;
using System.Management.Automation;

namespace Cohesity
{
    // PUT public/protectionJobs/{id}

    /// <summary>
    /// <para type="synopsis">
    /// Updates a Protection Job.
    /// </para>
    /// <para type="description">
    /// Returns the updated Protection Job.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Set-CohesityProtectionJob -Id 1234 -ProtectionJob $job
    ///   </code>
    ///   <para>
    ///   Updates a protection job with given parameters.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Set, "CohesityProtectionJob")]
    [OutputType(typeof(ProtectionJob))]
    public class SetCohesityProtectionJob : PSCmdlet
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


        /// <summary>
        /// <para type="description">
        /// The updated Protection Job.
        /// </para>
        /// </summary>
        [Parameter(Position = 2, Mandatory = true)]
        public ProtectionJob ProtectionJob { get; set; } = null;

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

            if (ProtectionJob == null)
            {
                throw new ParameterBindingException($"Parameter {nameof(ProtectionJob)} is mandatory.");
            }
        }

        /// <summary>
        /// Process
        /// </summary>
        protected override void ProcessRecord()
        {
            // PUT public/protectionJobs/{id}
            var preparedUrl = $"/public/protectionJobs/{Id.ToString()}";
            var result = Session.NetworkClient.Put<ProtectionJob>(preparedUrl, ProtectionJob);
            WriteObject(result);
        }

        #endregion

    }
}

// Copyright 2018 Cohesity Inc.
using System.Management.Automation;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.ProtectionJob
{
    // PUT public/protectionJobs/{id}

    /// <summary>
    /// <para type="synopsis">
    /// Updates a protection job.
    /// </para>
    /// <para type="description">
    /// Returns the updated protection job.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Set-CohesityProtectionJob -ProtectionJob $job
    ///   </code>
    ///   <para>
    ///   Updates a protection job with the specified parameters.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Set, "CohesityProtectionJob")]
    [OutputType(typeof(Models.ProtectionJob))]
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
        /// The updated protection job.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipeline = true)]
        public Models.ProtectionJob ProtectionJob { get; set; } = null;

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
            // PUT public/protectionJobs/{id}
            var preparedUrl = $"/public/protectionJobs/{ProtectionJob.Id.ToString()}";
            var result = Session.ApiClient.Put<Models.ProtectionJob>(preparedUrl, ProtectionJob);
            WriteObject(result);
        }

        #endregion

    }
}

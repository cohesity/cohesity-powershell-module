using Cohesity.Models;
using System;
using System.Management.Automation;

namespace Cohesity
{
    /// <summary>
    /// <para type="synopsis">
    /// Create a Protection Job.
    /// </para>
    /// <para type="description">
    /// Returns the created Protection Job.
    /// </para>
    /// </summary>
    [Cmdlet("Cohesity", "CreateDataProtectionJobs")]
    [OutputType(typeof(ProtectionJob))]
    public class CreateProtectionJobs : PSCmdlet
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

        /// <summary>
        /// <para type="description">
        /// The Protection Job to create.
        /// </para>
        /// </summary>
        [Parameter(Position = 1, Mandatory = true)]
        public ProtectionJob ProtectionJob { get; set; }


        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            Session.AssertAuthentication();

            if (ProtectionJob == null)
                throw new Exception("Protection Job is required.");
        }

        protected override void ProcessRecord()
        {
            var preparedUrl = $"{Session.NetworkClient.BaseUri.AbsoluteUri}/public/protectionJobs";
            var result = Session.NetworkClient.Post<ProtectionJob>(preparedUrl, ProtectionJob);
            WriteObject(result);
        }
    }
}

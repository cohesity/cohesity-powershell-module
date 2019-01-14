// Copyright 2018 Cohesity Inc.
using System.Management.Automation;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.Recovery
{
    /// <summary>
    /// <para type="synopsis">
    /// Removes or tears down Cohesity instant mount volumes.
    /// </para>
    /// <para type="description">
    /// Removes or tears down the Cohesity instant mount volumes created by the specified task id.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Dismount-CohesityVolume -TaskId 1234
    ///   </code>
    ///   <para>
    ///   Tears down the Cohesity instant mount volumes created by task id 1234.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsData.Dismount, "CohesityVolume",
        SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.High)]
    public class DismountCohesityVolume : PSCmdlet
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
        /// Specifies the task id that created the instant mount volumes to be removed.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true)]
        [ValidateRange(1, long.MaxValue)]
        public long TaskId { get; set; }

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

            // POST /destroyclone/{id}
            if (ShouldProcess($"Instant Volume Mount Task Id: {TaskId}"))
            {
                var preparedUrl = $"/destroyclone/{TaskId.ToString()}";
                Session.ApiClient.Post(preparedUrl, string.Empty);
                WriteObject($"Removed the mounted volumes created by Task Id {TaskId} successfully.");
            }

            else
            {
                WriteObject($"Mounted volumes created by Task Id {TaskId} were not removed.");
            }
        }

        #endregion
    }

}

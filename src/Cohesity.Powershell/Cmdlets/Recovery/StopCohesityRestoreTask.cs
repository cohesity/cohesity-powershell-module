// Copyright 2018 Cohesity Inc.
using System.Management.Automation;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.Recovery
{
    /// <summary>
    /// <para type="synopsis">
    /// Cancels a restore task.
    /// </para>
    /// <para type="description">
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Stop-CohesityRestoreTask -Id 78
    ///   </code>
    ///   <para>
    ///   Cancels a running restore task with Id 78.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsLifecycle.Stop, "CohesityRestoreTask")]
    public class StopCohesityRestoreTask : PSCmdlet
    {
        private Session Session
        {
            get
            {
                if (!(SessionState.PSVariable.GetValue("Session") is Session result))
                {
                    result = new Session();
                    SessionState.PSVariable.Set("Session", result);
                }
                return result;
            }
        }

        /// <summary>
        /// <para type="description">
        /// Specifies a unique id of the restore task.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true)]
        [ValidateRange(1, long.MaxValue)]
        public long Id { get; set; } = 0;

        /// <summary>
        /// Begin Processing
        /// </summary>
        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            Session.AssertAuthentication();
        }

        /// <summary>
        /// Process Record
        /// </summary>
        protected override void ProcessRecord()
        {
            var url = $"/public/restore/tasks/cancel/{Id.ToString()}";
            Session.ApiClient.Put(url, string.Empty);
            WriteObject("Restore Task cancelled.");
        }
    }
}

